using DataApi.XLAddin.COM.Model.Enums;
using DataApi.XLAddin.COM.Model.Interfaces;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace DataApi.XLAddin.COM.Model
{
    [ComVisible(true)]
    [ClassInterface(ClassInterfaceType.None)]
    public class COMUnderlyingInfos : ICOMUnderlyingInfos
    {
        private List<COMUnderlying> _underlyings;

        public COMUnderlyingInfos()
        {
            _underlyings = new List<COMUnderlying>();
        }

        public int Count
        {
            get
            {
                return _underlyings.Count;
            }
        }

        public void Add(COMUnderlying comUnderlying)
        {
            _underlyings.Add(comUnderlying);
        }

        // COM Visibility works on array, not on List
        public COMUnderlying[] GetValues
        {
            get
            {
                return _underlyings.ToArray();
            }
        }

        public void Clear()
        {
            _underlyings.Clear();
        }
    }
}
