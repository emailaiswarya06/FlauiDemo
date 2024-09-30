using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlauiTests.Framework
{
    class UIActions : BaseTest
    {
        public static void ClickButtonByName(string buttonName)
        {
            var button = FlauiLocators.FindButtonByName(buttonName);
            button.Click();
        }

        public static void ClickButtonByAutomationId(string buttonName)
        {
            var button = FlauiLocators.FindButtonByAutomationId(buttonName);
            button.Click();
        }

        public static void TypeEditBoxByAutomationId(string editBoxAutomationId, string editBoxText)
        {
            var editBox = FlauiLocators.FindEditBoxByAutomationId(editBoxAutomationId);
            editBox.Text = editBoxText;
        }

        public static void ChooseItemFromComboBoxByAutomationId(string comboBoxAutomationId, string comboBoxValue)
        {
            var comboBox = FlauiLocators.FindComboBoxByAutomationId(comboBoxAutomationId);
            comboBox.Expand();
            comboBox.Select(comboBoxValue).Click();

        }
        protected string GetPopUpMessagebyAutomationId(string textName)
        {
            return FlauiLocators.GetLabelTextByAutomationId(textName);
        }
    }
}
