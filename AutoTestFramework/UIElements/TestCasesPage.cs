using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AutoTestFramework
{
    public class TestCasesPage
    {
        public TestCasesPage()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = ("#main-content > article.mh-loop-item.clearfix.post-76.post.type-post.status-publish.format-standard.has-post-thumbnail.hentry.category-test-cases > div.mh-loop-content.clearfix > header > h3 > a"))]
        public IWebElement LoginButtoninLoginForm { get; set; }

        [FindsBy(How = How.XPath, Using = ("//*[@id='main-content']/article[3]/div[2]/header/h3/a"))]
        public IWebElement UsernameFieldInLoginForm { get; set; }
    }
}
