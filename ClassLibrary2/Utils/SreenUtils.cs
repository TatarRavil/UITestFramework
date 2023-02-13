using OpenQA.Selenium;

namespace CommonLibs.Utils
{
    public class SreenUtils
    {
        private readonly ITakesScreenshot camera;

        public SreenUtils(IWebDriver driver)
        {
            camera = (ITakesScreenshot)driver;
        }

        public void GetScreen(string fileName)
        {
            _ = fileName.Trim();

            if (File.Exists(fileName))
            {
                throw new Exception("File already created");
            }

            var screen = camera.GetScreenshot();
            screen.SaveAsFile(fileName);
        }
    }
}
