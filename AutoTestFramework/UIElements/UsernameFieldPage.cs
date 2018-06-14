using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AutoTestFramework
{
    public class UsernameFieldPage
    {
        public UsernameFieldPage()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.XPath, Using =("//*[@id='post-74']/div/p/a"))]
        public IWebElement LoginFormLink { get; set; }
    }
}
