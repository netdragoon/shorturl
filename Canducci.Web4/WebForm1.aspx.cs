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
                string ApiKey = "";

                ShortUrlSend request = ShortUrlSendFactory.Create("http://www.muchiutt.com.br/loja");

                ShortUrlClient client = ShortUrlClientFactory.Create(ApiKey);

                ShortUrlReceive response = client.Receive(request);

                HLink.NavigateUrl = response.ShortUrl.AbsoluteUri;

            }
        }
    }
}