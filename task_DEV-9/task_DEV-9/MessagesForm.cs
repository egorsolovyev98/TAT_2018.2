using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace task_DEV9
{
    /// <summary>
    /// Messages form.
    /// </summary>
    public class MessagesForm
    {
        /// <summary>
        /// The driver.
        /// </summary>
        private IWebDriver _driver;


        /// <summary>
        /// The messages.
        /// </summary>
        private By _messages = By.XPath("//*[@class='nim-dialog--text-preview']");


        /// <summary>
        /// The unread messages.
        /// </summary>
        private By _UnreadMessages = By.XPath("//a[@class='im-page--dialogs-filter ']");


        /// <summary>
        /// Initializes a new instance of the <see cref="T:task_DEV9.MessagesForm"/> class.
        /// </summary>
        /// <param name="driver">Driver.</param>
        public MessagesForm(ChromeDriver driver)
        {
            _driver = driver;
        }


        /// <summary>
        /// Gets the unread messages.
        /// </summary>
        /// <returns>The unread messages.</returns>
        public List<string> GetUnreadMessages()
        {
            Thread.Sleep(1000);
            _driver.FindElement(_UnreadMessages).Click();
            var elements = _driver.FindElements(_messages).ToList();
            List<string> messages = new List<string>();

            foreach (IWebElement el in elements)
            {
                messages.Add(el.Text);
            }

            return messages;
        }
    }
}