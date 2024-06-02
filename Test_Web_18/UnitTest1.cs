using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Threading;
using Web_18_Huynh;

namespace Test_Web_18
{
    [TestClass]
    public class UnitTest1
    {
        private ChromeDriverService chromeDriverService;
        private ChromeDriver chromeDriver;

        [TestInitialize]
        public void Setup()
        {
            // Ẩn màn hình đen khi chạy
            var chromeDriverService = ChromeDriverService.CreateDefaultService();
            chromeDriverService.HideCommandPromptWindow = true;
            chromeDriver = new ChromeDriver(chromeDriverService);
        }

        [TestCleanup]
        public void TearDown()
        {
            // Clean up and close the browser
            if (chromeDriver != null)
            {
                chromeDriver.Quit();
                chromeDriver.Dispose();
            }
        }

        [TestMethod]
        public void Test_btnOpen_18()
        {
            // Navigate to YouTube
            chromeDriver.Url = "https://manga.com.vn/";
            chromeDriver.Navigate();
            Thread.Sleep(3000); // Wait for the page to load

            // Assert the URL
            Assert.AreEqual("https://manga.com.vn/", chromeDriver.Url, "The browser did not navigate to YouTube successfully.");
        }

        [TestMethod]
        public void Test_btnSearch_18()
        {
            Test_btnOpen_18();

            // Kiểm tra xem ô tìm kiếm có hiển thị hay không
            var searchBar = chromeDriver.FindElement(By.XPath("//*[@id=\"__next\"]/main/header/div/div[1]/form/input"));
            searchBar.Clear();
            searchBar.SendKeys("Conan");
            searchBar.Submit();
            Thread.Sleep(3000);
        }

        [TestMethod]
        public void Test_btnChon_18()
        {
            try
            {
                // Thực hiện tìm kiếm
                Test_btnSearch_18();

                // Click vào truyện đầu tiên từ kết quả tìm kiếm
                var KQsearch_18 = chromeDriver.FindElements(By.XPath("//*[@id=\"__next\"]/main/div[2]/div/div[1]/div[2]/div[1]/div[2]/h3/a"));
                KQsearch_18[0].Click();
                Thread.Sleep(5000);
                Assert.IsNotNull(KQsearch_18, "Không tìm thấy truyện đã chọn.");

            }
            catch (Exception ex)
            {
                Assert.Fail($"Đã xảy ra lỗi: {ex.Message}");
            }
        }


        [TestMethod]
        public void Test_btnF_18()
        {
            try
            {
                Test_btnChon_18();
                // Kiểm tra xem đã chuyển đến chương đầu tiên hay không
                var docFist = chromeDriver.FindElement(By.XPath("//*[@id=\"__next\"]/main/div[3]/div[2]/div/div[2]/div[2]/div[4]/button[1]/span"));
                docFist.Click();
                Thread.Sleep(5000);
                Assert.IsNotNull(docFist, "Không tìm thấy nút 'Đọc từ đầu'.");

            }
            catch (Exception ex)
            {
                Assert.Fail($"Đã xảy ra lỗi: {ex.Message}");
            }
        }

        [TestMethod]
        public void Test_btnN_18()
        {
            try
            {
                Test_btnChon_18();
                // Kiểm tra xem đã chuyển đến chương mới nhất hay không
                var docNew = chromeDriver.FindElement(By.XPath("//*[@id=\"__next\"]/main/div[3]/div[2]/div/div[2]/div[2]/div[4]/button[2]/span"));
                docNew.Click();
                Thread.Sleep(5000);
                Assert.IsNotNull(docNew, "Không tìm thấy nút 'Đọc mới nhất'.");

            }
            catch (Exception ex)
            {
                Assert.Fail($"Đã xảy ra lỗi: {ex.Message}");
            }
        }

        [TestMethod]
        public void Test_btnBack_18()
        {
            // Mở trang web và thực hiện tìm kiếm với từ khóa "Conan"
            Test_btnSearch_18();


            // Quay lại trang trước đó
            chromeDriver.Navigate().Back();
            Thread.Sleep(3000);

            // Kiểm tra xem đã quay lại trang tìm kiếm với từ khóa "Conan" hay không
            Assert.IsTrue(chromeDriver.Url.Contains("https://manga.com.vn/"), "Không quay lại trang tìm kiếm với từ khóa 'Conan'.");

        }

    }
}
