# ExcelDna.COM.QuickStart.V2

EXCEL DNA COM Sample : Generation of an XLL file to be used in VBA. 
This is a v2 version (more detailled version) of This site was built using [ExcelDna.COM.QuickStart](https://github.com/danmgs/ExcelDna.COM.QuickStart).


![alt capture1](https://github.com/danmgs/ExcelDna.COM.QuickStart.V2/blob/master/img/screenshot1.JPG)


1. Generation of the XLL
- Check Post Build event of project "DataApi.XLAddin", this will:
- Generate tlb files
- Build a DataApi.XLAddin-packed.xll.
- Copy DataApi.XLAddin-packed.xll to lib\DataApi.XLAddin.xll (renaming)
- Copy DataApi.XLAddin.xll.config to lib\DataApi.XLAddin.xll.config

2. Referencing the DataApi.XLAddin.xll.
- Open Excel
- Load the DataApi.XLAddin.xll. 
Or, Open Excel, Tools > References > Browse in order to add DataApi.XLAddin.xll

*In a classical COM registration process, user will need to add tlb as VBA References, then regsvr32 these tlb. 
The drawback of this method is that it will register in the personal local registry.*

*With EXCEL DNA, we do not need to reference the tlb anymore but the .xll:
DataApi.XLAddin.xll contains all the plumbing in the .dna file.
At each use, the xll will register in a personal "on-the-fly" EXCEL DNA virtual env.*

What dll is COMVisible:
```
<ExternalLibrary Path="DataApiXLAddin.dll" ComServer="true" Pack="true" />
```

Auto-registration routine is implemented in class:
```
ExcelAddin.cs
```


3. Testing with the sample "Sheet_Testing_XLL.xlsm" for demo
- Open Sample and browse for the xll as shown in step 2.
- Input order parameters and click to book the order. 

4. Logging has been implemented with log4net, to allow it:
- log4net.dll is packed in .dna config 
 
```
<Reference Path="log4net.dll" LoadFromBytes="true" Pack="true" />
```

-  loaded via DataApi.XLAddin / AssemblyInfo.cs file:
```
[assembly: log4net.Config.XmlConfigurator]
```

- Files "DataApi.XLAddin.xll.config" and referenced "DataApi.XLAddin.xll" must be in the same directory
- File "DataApi.XLAddin.xll.config" is configured by default to log in 
 
```
C:\log 
```



5. Additionnal: Check sample codes for details https://github.com/Excel-DNA/ExcelDna
```
ExcelDna-master\ExcelDna-master\Distribution\Samples\ComServer 
```
