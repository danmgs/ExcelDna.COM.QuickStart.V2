using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DataApi.XLAddin.COM.Model
{
    public class Utils<T>
    {
        // https://www.codeproject.com/Articles/12386/Sending-an-array-of-doubles-from-Excel-VBA-to-C-us
        // how to expose a string[]
        public static T[] LoadComObjectIntoTArray(object comObject)
        {
            Type thisType = comObject.GetType();
            Type dblType = Type.GetType(string.Format("System.String[]", typeof(T).Name));
            T[] tArray = new T[1];
            // temporary allocation to keep compiler happy.
            if (thisType == dblType)
            {
                object[] args = new object[1];
                int numEntries = (int)thisType.InvokeMember("Length",
                                         BindingFlags.GetProperty,
                                         null, comObject, null);
                tArray = new T[numEntries];
                for (int j1 = 0; j1 < numEntries; j1++)
                {
                    args[0] = j1; //+ 1; // since VB arrays index from 1
                    tArray[j1] =
                        (T)thisType.InvokeMember("GetValue",
                                       BindingFlags.InvokeMethod,
                                          null, comObject, args);
                }
            } // End if(thisType == dblType)
            return tArray;
        } // End LoadComObjectIntoDoubleArray()
    }
}
