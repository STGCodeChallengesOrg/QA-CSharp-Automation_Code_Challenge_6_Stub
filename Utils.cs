/*

automation challenge 6 (Crawler):

Write a crawler that will automatically navigate to every page on the site.

Go to https://www.skiutah.com/

Build a crawler that will start at www.skiutah.com and finds every link/page and goes to that page and finds
other pages it needs to visit.  Remember to not visit the same page twice and to only visit the pages on the domain.

Listed below is the sample code stub for running this test.

*/

namespace Automation_Code_Challenge_6_CSharp
{
    [TestClass]
    class Utils : SeleniumWebdriverBaseClass
    {
        [TestMethod]
        // This method is the main method for launching tests
        public void TestLauncher()
        {
            // Verify Page Title
            verifyPageTitle(URL, Expected_Value);
            // Visit every page of the skiutah.com domain once
            webCrawler();
        }
    }
}
