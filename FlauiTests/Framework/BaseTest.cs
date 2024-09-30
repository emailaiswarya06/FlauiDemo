using System;
using FlaUI.Core;
using FlaUI.Core.AutomationElements;
using FlaUI.UIA3;
using NUnit.Framework;

namespace FlauiTests.Framework
{
    class BaseTest
    {
        protected static Window mainWindow;
        protected static UIA3Automation automation;
        [SetUp]
        public void LaunchMainWindow()
        {
            Console.WriteLine("Inside base test setup method");
            var applicationPath = "";

            if (TestContext.CurrentContext.Test.Namespace.Contains("Tests"))
            {
                applicationPath = GetApplicationPath("BankSystemPath");
            }
            Console.Write(applicationPath);
            Application application = Application.Launch(applicationPath);

            automation = new UIA3Automation();
            application.WaitWhileMainHandleIsMissing();
            mainWindow = application.GetMainWindow(automation);
        }


        [TearDown]
        public void CloseApplication()
        {
            Console.WriteLine("Inside base test tear down method");
            mainWindow.Close();
            UIActions.ClickButtonByName("Yes");

        }


        private static string GetApplicationPath(string appName)
        {
            var appPathEnv = System.Environment.GetEnvironmentVariable(appName);
            if (appPathEnv == null || appPathEnv.Trim().Equals(""))
            {
                return FileHandler.ReadJsonFile(appName, $@"{FileHandler.GetCurrentFolderPath()}TestResources\ApplicationPath.json");
            }
            return appPathEnv;
        }
    }
}
