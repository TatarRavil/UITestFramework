using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;

namespace CommonLibs.Utils
{
    public class ExtentReportUtils
    {
        private ExtentHtmlReporter extentHtmlReporter;
        private ExtentReports extentReports;
        private ExtentTest extentTest;

        public ExtentReportUtils(string htmlReportFileName)
        {
            extentHtmlReporter = new ExtentHtmlReporter(htmlReportFileName);
            extentReports = new ExtentReports();
            extentReports.AttachReporter(extentHtmlReporter);
        }

        public void CreateTestCase(string testName)
        {
            extentTest = extentReports.CreateTest(testName);
        }

        public void AddTestLog(Status status, string comment)
        {
            extentTest.Log(status, comment);
        }

        public void AddScreen(string screenFileName)
        {
            extentTest.AddScreenCaptureFromPath(screenFileName);
        }

        public void FlushReport()
        {
            extentReports.Flush();
        }
    }
}
