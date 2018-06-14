using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutoTestFramework
{
    public static class NavigateTo
    {
        public static void LoginFormThroughTheMenu()
        {
            Menu menu = new Menu();
            TestScenarioPage testScenario = new TestScenarioPage();

            menu.TestScenarios.Click();
            Thread.Sleep(5000);
            testScenario.LoginPage.Click();
            Thread.Sleep(5000);
        }

        public static void LoginFromThroughThePost()
        {
            Menu menu = new Menu();
            TestCasesPage testCases = new TestCasesPage();
            UsernameFieldPage usernameField = new UsernameFieldPage();

            menu.TestCases.Click();
            Thread.Sleep(5000);
            testCases.UsernameFieldInLoginForm.Click();
            Thread.Sleep(5000);
            Thread.Sleep(5000);
        }
    }
}
