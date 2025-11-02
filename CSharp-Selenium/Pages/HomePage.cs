using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSelenium.Pages
{
    public class HomePage : BasePage
    {
        Dictionary<PageName, string> listOfPages = new Dictionary<PageName, string>()
        {
            { PageName.AbTesting, "A/B Testing" },
            { PageName.AddRemoveElements, "Add/Remove Elements" },
            { PageName.BasicAuth, "Basic Auth (user and pass: admin)" },
            { PageName.BrokenImages, "Broken Images" },
            { PageName.ChallengingDom, "Challenging DOM" },
            { PageName.Checkboxes, "Checkboxes" },
            { PageName.ContextMenu, "Context Menu" },
            { PageName.DigestAuthentication, "Digest Authentication (user and pass: admin)" },
            { PageName.DisappearingElements, "Disappearing Elements" },
            { PageName.DragAndDrop, "Drag and Drop" },
            { PageName.Dropdown, "Dropdown" },
            { PageName.DynamicContent, "Dynamic Content" },
            { PageName.DynamicControls, "Dynamic Controls" },
            { PageName.DynamicLoading, "Dynamic Loading" },
            { PageName.EntryAd, "Entry Ad" },
            { PageName.ExitIntent, "Exit Intent" },
            { PageName.FileDownload, "File Download" },
            { PageName.FileUpload, "File Upload" },
            { PageName.FloatingMenu, "Floating Menu" },
            { PageName.ForgotPassword, "Forgot Password" },
            { PageName.FormAuthentication, "Form Authentication" },
            { PageName.Frames, "Frames" },
            { PageName.Geolocation, "Geolocation" },
            { PageName.HorizontalSlider, "Horizontal Slider" },
            { PageName.Hovers, "Hovers" },
            { PageName.InfiniteScroll, "Infinite Scroll" },
            { PageName.Inputs, "Inputs" },
            { PageName.JQueryUiMenus, "JQuery UI Menus" },
            { PageName.JavaScriptAlerts, "JavaScript Alerts" },
            { PageName.JavaScriptOnloadError, "JavaScript onload event error" },
            { PageName.KeyPresses, "Key Presses" },
            { PageName.LargeDeepDom, "Large & Deep DOM" },
            { PageName.MultipleWindows, "Multiple Windows" },
            { PageName.NestedFrames, "Nested Frames" },
            { PageName.NotificationMessages, "Notification Messages" },
            { PageName.RedirectLink, "Redirect Link" },
            { PageName.SecureFileDownload, "Secure File Download" },
            { PageName.ShadowDom, "Shadow DOM" },
            { PageName.ShiftingContent, "Shifting Content" },
            { PageName.SlowResources, "Slow Resources" },
            { PageName.SortableDataTables, "Sortable Data Tables" },
            { PageName.StatusCodes, "Status Codes" },
            { PageName.Typos, "Typos" },
            { PageName.WysiwygEditor, "WYSIWYG Editor" }
        };
        public enum PageName
        {
            AbTesting,
            AddRemoveElements,
            BasicAuth,
            BrokenImages,
            ChallengingDom,
            Checkboxes,
            ContextMenu,
            DigestAuthentication,
            DisappearingElements,
            DragAndDrop,
            Dropdown,
            DynamicContent,
            DynamicControls,
            DynamicLoading,
            EntryAd,
            ExitIntent,
            FileDownload,
            FileUpload,
            FloatingMenu,
            ForgotPassword,
            FormAuthentication,
            Frames,
            Geolocation,
            HorizontalSlider,
            Hovers,
            InfiniteScroll,
            Inputs,
            JQueryUiMenus,
            JavaScriptAlerts,
            JavaScriptOnloadError,
            KeyPresses,
            LargeDeepDom,
            MultipleWindows,
            NestedFrames,
            NotificationMessages,
            RedirectLink,
            SecureFileDownload,
            ShadowDom,
            ShiftingContent,
            SlowResources,
            SortableDataTables,
            StatusCodes,
            Typos,
            WysiwygEditor
        }
        public HomePage(IWebDriver driver) : base(driver)
        {
            this.url = "https://the-internet.herokuapp.com/";
        }
        public void ClickOnLink(string text)
        {
            Link_sel(text).Click();
        }
        public IWebElement Link_sel(string text)
        {
            By by = By.XPath($"//li[a][contains(string(), '{text}')]");
            return driver.FindElement(by);
        }
        public void EnsureLinksArePresent()
        {

        }
    }
}
