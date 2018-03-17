# ExcelDna.COM.QuickStart.V2

EXCEL DNA COM Sample : Generation of an XLL file to be used in VBA.  
This is a v2 version, more detailed, of project [ExcelDna.COM.QuickStart](https://github.com/danmgs/ExcelDna.COM.QuickStart).


![alt capture1](https://github.com/danmgs/ExcelDna.COM.QuickStart.V2/blob/master/img/screenshot1.JPG)

# INTRO

You should know that Excel DNA allows to expose UDF functions under Excel Sheets. 
- as formula in cell
- directly via VBA Code with :

```
Application.Run("[my function name here]")
```

To do so, these functions are implemented in C# as **public static** in static class. 

Yet besides to this, and more powerful: we will demonstrate any C# functions could be COM exposed.
The Goal of the produced XLL is to expose, via COM technology, C# functions which can be used under VBA Excel code.

# STEPS TO FOLLOW

#### 1. Generation of the XLL

- Check Post Build event of project **"DataApi.XLAddin"**, this will:
- Generate tlb files
- Build a **DataApi.XLAddin-packed.xll**.
- Copy **DataApi.XLAddin-packed.xll** to **lib\DataApi.XLAddin.xll** (renaming)
- Copy **DataApi.XLAddin.xll.config** to **lib\DataApi.XLAddin.xll.config**

![alt capture2](https://github.com/danmgs/ExcelDna.COM.QuickStart.V2/blob/master/img/screenshot2.JPG)

tlb files will allow any C# functions to be COM exposed.

#### 2. Referencing the DataApi.XLAddin.xll.

- Open Excel
- Load the **DataApi.XLAddin.xll**.   
Or, Open Excel, Tools > References > Browse in order to add the generated **lib\DataApi.XLAddin.xll**

![alt capture3](https://github.com/danmgs/ExcelDna.COM.QuickStart.V2/blob/master/img/screenshot3.JPG)

![alt capture4](https://github.com/danmgs/ExcelDna.COM.QuickStart.V2/blob/master/img/screenshot4.JPG)

![alt capture5](https://github.com/danmgs/ExcelDna.COM.QuickStart.V2/blob/master/img/screenshot5.JPG)

*In a classical COM registration process, user will need to add tlb as VBA References, then regsvr32 these tlb.  
The drawback of this method is that it will register in the personal local registry.*

*With EXCEL DNA, we do not need to reference the tlb anymore but the .xll:  
**DataApi.XLAddin.xll** contains all the plumbing in the .dna file.  
At each use, the xll will register in a personal "on-the-fly" EXCEL DNA virtual env.*

What dll is COMVisible:
```
<ExternalLibrary Path="DataApiXLAddin.dll" ComServer="true" Pack="true" />
```

Auto-registration routine is implemented in class:
```
ExcelAddin.cs
```

#### 3. Testing with the sample XL for demo

- Open Sample **"Sheet_Testing_XLL.xlsm"** and browse for the xll as shown in step **2.**
- Input order parameters and click to book the order. 

#### 4. Logging has been implemented with log4net, to allow it:

- **log4net.dll** is packed in .dna config 
 
```
<Reference Path="log4net.dll" LoadFromBytes="true" Pack="true" />
```

-  loaded via DataApi.XLAddin > AssemblyInfo.cs file:
```
[assembly: log4net.Config.XmlConfigurator]
```

- Files **"DataApi.XLAddin.xll.config"** and referenced **"DataApi.XLAddin.xll"** must be in the same directory
- File **"DataApi.XLAddin.xll.config"** is configured by default to log in directory :
 
```
C:\log 
```

#### 5. Additionnal: Check sample codes for details https://github.com/Excel-DNA/ExcelDna
```
ExcelDna-master\ExcelDna-master\Distribution\Samples\ComServer 
```

# ADDITIONNAL NOTES


#### 1. Define what's COM visible or not :

*In "AutoDual" mode, we do not need to declare an interface ICOMFooBar to define what will be explicitely COM Visible.  
However, default methods such as :  
**Equals(), GetHashCode(), GetType(), ToString()** will appeared as COM Visible and available for use in EXCEL VBA.*  

A sample class has been written **"COMFooBar.cs"** for demo purpose:

![alt capture6](https://github.com/danmgs/ExcelDna.COM.QuickStart.V2/blob/master/img/screenshot6.JPG)

![alt capture7](https://github.com/danmgs/ExcelDna.COM.QuickStart.V2/blob/master/img/screenshot7.JPG)

#### 2. HOW TO : Pass a string array from VBA to COM C# : use of LoadComObjectIntoTArray
   
In order to set the **string[] AdditionnalInfos** property of **Trade** class, please check the demonstration in **COMTrade** class :

```
public void SetAdditionnalInfos(object addInfosStringArray)    
```
 
Call in VBA

```
Dim additionnalInfosArr(3) As String
...
comTrade.SetAdditionnalInfos (additionnalInfosArr)
```

Help and details [here](https://www.codeproject.com/Articles/12386/Sending-an-array-of-doubles-from-Excel-VBA-to-C-us).