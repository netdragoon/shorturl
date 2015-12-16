using Canducci.ShortUrl;
using System;
using System.Web.UI;
namespace Canducci.Web4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

                string Url = "http://www.uol.com.br"; // digite o endereço

                IsGd isgd = new IsGd(Url);
                ShortUrlClient client = new ShortUrlClient(isgd);
                ShortUrlReceive response = client.Receive();
                client.Dispose();
                HLink.NavigateUrl = response.ShortUrl.AbsoluteUri;

            }
        }
    }
}