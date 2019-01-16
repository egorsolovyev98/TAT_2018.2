using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace task_DEV9
{
    /// <summary>
    /// Main page form.
    /// </summary>
    public  class MainPageForm
    {
        /// <summary>
        /// The driver.
        /// </summary>
        private IWebDriver _driver;


        /// <summary>
        /// The messages.
        /// </summary>
        private By messages = By.XPath("//*[@id='l_msg']");


        /// <summary>
        /// Initializes a new instance of the <see cref="T:task_DEV9.MainPageForm"/> class.
        /// </summary>
        /// <param name="driver">Driver.</param>
        public MainPageForm(ChromeDriver driver)
        {
            _driver = driver;
        }


        /// <summary>
        /// Goes to messages.
        /// </summary>
        public void GoToMessages()
        {
            _driver.FindElement(messages).Click();
        }
    }
}