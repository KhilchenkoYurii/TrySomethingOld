using System.Net;

namespace AsynchronousProgramming
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var path = "https://www.youtube.com/";

            //DownloadHTMLAsync(path);

            MessageBox.Show("Waiting for task executed");


            var htmlText = await GetHtmlAnync(path);

            MessageBox.Show(htmlText.Substring(0, 10));
        }

        public static void DownloadHTML(string url)
        {
            var webClient = new WebClient();

            var html = webClient.DownloadString(url);

            using (var streamWriter = new StreamWriter(@"C:\Users\yurii.khilchenko\Desktop\Test.txt"))
            {
                streamWriter.Write(html);
            }
        }

        public async Task DownloadHTMLAsync(string url)
        {
            var webClient = new WebClient();

            var html = await webClient.DownloadStringTaskAsync(url);

            using (var streamWriter = new StreamWriter(@"C:\Users\yurii.khilchenko\Desktop\Test.txt"))
            {
                await streamWriter.WriteAsync(html);
            }

        }

        public string GetHtml(string url)
        {
            var webClient = new WebClient();

            var html = webClient.DownloadString(url);

            return html;
        }

        public async Task<string> GetHtmlAnync(string url)
        {
            var webClient = new WebClient();

            return await webClient.DownloadStringTaskAsync(url); ;
        }

    }
}
