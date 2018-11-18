# ReactJSNetAspDotNetStart
# Herb Zhao 18/11/2018

This is an example of how to set up ReactJS.NET at ASP.NET MVC5 + VS2017. This example is based on the official Tutorial (ASP.NET 4.x) - https://reactjs.net/tutorials/aspnet4.html

Please read this official tutorial before you initialize this project.

Although the official tutorial is very useful, it is for VS2013 + ASP.NET MVC4 which are outdated. This example (ASP.NET MVC5.X.X + VS2017) shows extra configurations and Nuget packages. Otherwise error will occour bacause of no JS Engine.

Initialize project difference:
ASP.NET Web Application (.NET Framework)
  -> Select icon "MVC", and
  -> Add folders and core references for: Tick "MVC"

Extra works:
1. Install nugget packages: JsEngineSwitcher.V8, x86, x64
2. Editing ReactConfig.cs according to the project file.

Otherwise (if only follow above tutorial), Http 500 error happens when access .jsx files because there is no JS engine.
