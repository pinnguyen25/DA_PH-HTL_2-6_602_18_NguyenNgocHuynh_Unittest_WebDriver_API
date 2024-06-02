using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Windows.Forms;

namespace Web_18_Huynh
{
    public partial class Form1 : Form
    {
        private IWebDriver driver;
        private ChromeDriverService chromeDriverService;
        private ChromeDriver chromeDriver;
        public Form1()
        {
            InitializeComponent();
            // Khởi tạo ChromeDriverService để ẩn cửa sổ dòng lệnh
            chromeDriverService = ChromeDriverService.CreateDefaultService();
            chromeDriverService.HideCommandPromptWindow = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        public void btnOpen_18_Click(object sender, EventArgs e)
        {
            ChromeOptions options = new ChromeOptions();
            chromeDriver = new ChromeDriver(chromeDriverService, options);

            // Điều hướng đến trang truyện
            chromeDriver.Url = "https://manga.com.vn/";
            chromeDriver.Navigate();
        }

        public void btnSearch_18_Click(object sender, EventArgs e)
        {
            if (chromeDriver == null)
            {
                MessageBox.Show("Vui lòng mở trình duyệt trước.");
                return;
            }

            //Tìm đối tượng nút tìm kiếm trên trang truyện
            IWebElement searchBar = chromeDriver.FindElement(By.XPath("//*[@id=\"__next\"]/main/header/div/div[1]/form/input"));

            // Lấy nội dung từ TextBox và tách thành một mảng các từ
            string[] searchTerms = txtSearch.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            // Ghép các từ lại thành một chuỗi, cách nhau bởi dấu cách
            string tukhoa_18 = string.Join(" ", searchTerms);

            // Gửi chuỗi tìm kiếm vào ô tìm kiếm và gửi yêu cầu tìm kiếm
            searchBar.SendKeys(tukhoa_18);
            searchBar.Submit();

        }

        public void btnChon_18_Click(object sender, EventArgs e)
        {
            if (chromeDriver == null)
            {
                MessageBox.Show("Vui lòng mở trình duyệt trước.");
                return;
            }
            try
            {
                // Kiểm tra xem đã tìm kiếm và có kết quả trả về hay không
                var KQsearch_18 = chromeDriver.FindElements(By.XPath("//*[@id=\"__next\"]/main/div[2]/div/div[1]/div[2]/div[1]/div[2]"));
                if (KQsearch_18.Count > 0)
                {
                    // Chọn truyện đầu tiên từ kết quả tìm kiếm
                    KQsearch_18[0].Click();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy kết quả truyện trong kết quả tìm kiếm.");
                }
            }
            catch (NoSuchElementException ex)
            {
                MessageBox.Show("Không tìm thấy phần tử video: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }


        public void btnF_18_Click(object sender, EventArgs e)
        {
            try
            {
                // Tìm nút đọc từ đầu
                IWebElement docF_18 = chromeDriver.FindElement(By.XPath("//*[@id=\"__next\"]/main/div[3]/div[2]/div/div[2]/div[2]/div[4]/button[1]"));
                docF_18.Click();

            }
            catch (NoSuchElementException ex)
            {
                MessageBox.Show("Không tìm thấy nút 'Đọc từ đầu': " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        public void btnN_18_Click(object sender, EventArgs e)
        {
            try
            {
                // Tìm nút đọc mới nhất
                IWebElement docN_18 = chromeDriver.FindElement(By.XPath("//*[@id=\"__next\"]/main/div[3]/div[2]/div/div[2]/div[2]/div[4]/button[2]"));
                docN_18.Click();

            }
            catch (NoSuchElementException ex)
            {
                MessageBox.Show("Không tìm thấy nút 'Đọc mới nhất': " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        public void btnBack_18_Click(object sender, EventArgs e)
        {

            try
            {
                chromeDriver.Navigate().Back();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}");
            }
        }
        // Đảm bảo ChromeDriver được giải phóng đúng cách khi đóng form
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (chromeDriver != null)
            {
                chromeDriver.Quit();
                chromeDriver.Dispose();
            }
        }
    }

}

