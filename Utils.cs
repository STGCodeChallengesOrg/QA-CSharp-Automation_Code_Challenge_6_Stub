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
