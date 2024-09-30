using FlauiTests.Framework;

namespace FlauiTests.Pages
{
    class RegistrationPage : UIActions
    {
        private string buttonRegistration = "Registration";
        private string editBoxFirstNameAutomationId = "InFName";
        private string editBoxLastNameAutomationId = "InLName";
        private string ageDropDownAutomationId = "InAge";
        private string countryDropDownAutomationId = "InCountry";
        private string messageDialogName = "You Have Been Registered Successfully You Can Login Now!";


        public string Registration()
        {
            ClickButtonByName(buttonRegistration); 
            TypeEditBoxByAutomationId(editBoxFirstNameAutomationId, "Eric");
            TypeEditBoxByAutomationId(editBoxLastNameAutomationId, "Carle");
            ChooseItemFromComboBoxByAutomationId(ageDropDownAutomationId,"22");
            ChooseItemFromComboBoxByAutomationId(countryDropDownAutomationId, "India");
            TypeEditBoxByAutomationId("InPhone", "1234567890");
            TypeEditBoxByAutomationId("InEmail", "abcd4@gmail.com");
            TypeEditBoxByAutomationId("InPass", "abcd");
            TypeEditBoxByAutomationId("InCard", "12345678103");
            ClickButtonByName("Ok");
            string registerPopupMsg = GetPopUpMessagebyAutomationId(messageDialogName);
            ClickButtonByName("OK");
            return registerPopupMsg;
        }
    }
}
