using React;
using JavaScriptEngineSwitcher.Core;
using JavaScriptEngineSwitcher.V8;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(ReactJSNetAspDotNetStart.ReactConfig), "Configure")]

namespace ReactJSNetAspDotNetStart
{
	public static class ReactConfig
	{
		public static void Configure()
		{
            // Set Javascript Engine in JavaScriptEngineSwitcher
            JsEngineSwitcher.Current.DefaultEngineName = V8JsEngine.EngineName;
            JsEngineSwitcher.Current.EngineFactories.AddV8();

            // Conclusion - Herb Zhao
            // Build up this project according to Tutorial (ASP.NET 4.x):
            // https://reactjs.net/tutorials/aspnet4.html
            // However this tutorial is based on VS2013 and ASP.NET 4.x
            // For VS2017 & ASP.NET 5.2.X (this version), extra works needed.
            
            // Extra works:
            // 1. Install nugget package: JsEngineSwitcher.V8, x86, x64
            // 2. Editing ReactConfig.cs

            // Otherwise (if only follow above tutorial):
            // 500 error when access .jsx files because there is no JS engine
            // 1. https://github.com/reactjs/React.NET/issues/418 similar issue
            // 2. Remove auto-registered JS engines from React.Core, which need at least 1 js engine nugget package, such as V8
            // https://github.com/reactjs/React.NET/pull/582/files/57b53ecefef561a02854f66fee354e95e73f16b7
            // 3. together with 2, how to install V8
            // https://github.com/reactjs/React.NET/blob/master/src/React.Sample.Mvc4/App_Start/ReactConfig.cs
            // 4. Install x86 and x64 version of V8 packages
            // https://github.com/reactjs/React.NET/blob/master/src/React.Sample.Mvc4/packages.config
            // More£ºall available JS engine
            // https://github.com/Taritsyn/JavaScriptEngineSwitcher/wiki/Registration-of-JS-engines
            
        }
    }
}