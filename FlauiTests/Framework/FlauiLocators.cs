using System;
using FlaUI.Core.AutomationElements;
using FlaUI.Core.Definitions;
using FlaUI.Core.Tools;

namespace FlauiTests.Framework
{
    class FlauiLocators : BaseTest
    {
        private const int BigWaitTimeout = 10000;

        public static Button FindButtonByName(string buttonName)
        {
            return WaitForElement(() => mainWindow.FindFirstDescendant(cf =>
                cf.ByControlType(ControlType.Button).And(cf.ByName(buttonName)))).AsButton();
        }

        public static Button FindButtonByAutomationId(string buttonName)
        {
            return WaitForElement(() => mainWindow.FindFirstDescendant(cf =>
                cf.ByControlType(ControlType.Button).And(cf.ByAutomationId(buttonName)))).AsButton();
        }
        public static TextBox FindEditBoxByAutomationId(string editBox)
        {
            return WaitForElement(() => mainWindow.FindFirstDescendant(cf =>
                cf.ByControlType(ControlType.Edit).And(cf.ByAutomationId(editBox)))).AsTextBox();
        }

        public static ComboBox FindComboBoxByAutomationId(string comboBox)
        {
            return WaitForElement(() => mainWindow.FindFirstDescendant(cf =>
                cf.ByControlType(ControlType.ComboBox).And(cf.ByAutomationId(comboBox)))).AsComboBox();
        }

        public static string GetLabelTextByAutomationId(string textName)
        {
            var labelElement = WaitForElement(() => mainWindow.FindFirstDescendant(cf =>
                  cf.ByControlType(ControlType.Text).And(cf.ByName(textName)))).AsTextBox();
            return labelElement.Patterns.LegacyIAccessible.Pattern.Name.ToString();
        }

        //similar to fluent wait , waits for an element to get loaded in the page with the give time interval
        public static T WaitForElement<T>(Func<T> getter)
        {
            var retry = Retry.WhileNull<T>(
                () => getter(),
                TimeSpan.FromMilliseconds(BigWaitTimeout),
                TimeSpan.FromMilliseconds(1000));
            Console.WriteLine("Retry Result :" + retry.Result);
            if (!retry.Success)
            {
                Console.WriteLine("Failed to get an element within a wait timeout");
            }
            return retry.Result;
        }
	}
}
