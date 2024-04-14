using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using Microsoft.Web.WebView2.WinForms;


namespace Test_Winforms_e_Selenium
{
    public partial class FormConfirm : Form
    {
        WebView2 webView2;
        public FormConfirm()
        {
            InitializeComponent();

            webView2 = new WebView2();
            webView2.Dock = DockStyle.Fill;

            Controls.Add(webView2);

            webView2.Source = new Uri("https://raphanet.confirm8.com");
        }


        private void button1_Click(object sender, EventArgs e)
        {
            IWebDriver driver = new ChromeDriver();

            // Navega até o site
            driver.Navigate().GoToUrl("http://aplicacoes.socin.com.br/login.html?lang=portuguese");

            // Encontra os campos de login e senha e insere os valores
            IWebElement campoLogin = driver.FindElement(By.Id("username_val"));
            campoLogin.SendKeys("raphanet.parc");

            IWebElement campoSenha = driver.FindElement(By.Id("password_val"));
            campoSenha.SendKeys("TTF6DRTFb9");

            // Submete o formulário de login
            IWebElement botaoLogin = driver.FindElement(By.CssSelector(".button.is-info.is-fullwidth"));
            botaoLogin.Click();

            // Aguarda até que a página seja carregada
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);

            // Navega para uma página específica após o login
            driver.Navigate().GoToUrl("http://aplicacoes.socin.com.br/main.html");

        }
    }

}