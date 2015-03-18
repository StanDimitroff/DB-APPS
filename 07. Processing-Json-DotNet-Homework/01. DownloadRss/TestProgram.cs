namespace DownloadRss
{
    using System.Net;

    class TestProgram
    {
        static void Main()
        {
            // Download the content of the SoftUni RSS feed

            WebClient webClient = new WebClient();
            webClient.DownloadFile("https://softuni.bg/Feed/News", "../../../softuni-rss.xml");
        }
    }
}