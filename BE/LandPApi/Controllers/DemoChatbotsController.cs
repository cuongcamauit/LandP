using Google.Cloud.Dialogflow.V2;
using Google.Protobuf;
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace LandPApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemoChatbotsController : ControllerBase
    {
        private static readonly JsonParser jsonParser = new JsonParser(JsonParser.Settings.Default.WithIgnoreUnknownFields(true));
        [HttpPost]
        //public IActionResult Demo(object obj)
        //{
        //    Console.WriteLine(obj.ToString());
        //    return Ok(obj);
        //}
        public async Task<IActionResult> GetWebhookResponse()
        {
            Console.WriteLine("Hello");
            WebhookRequest request;
            using (var reader = new StreamReader(Request.Body))
            {
                request = jsonParser.Parse<WebhookRequest>(reader);
            }

            var pas = request.QueryResult.Parameters;
            Console.WriteLine(pas.ToString());
            string category = null;

            //var askingName = pas.Fields.ContainsKey("name") && pas.Fields["name"].ToString().Replace('\"', ' ').Trim().Length > 0;
            //var askingAddress = pas.Fields.ContainsKey("address") && pas.Fields["address"].ToString().Replace('\"', ' ').Trim().Length > 0;
            //var askingBusinessHour = pas.Fields.ContainsKey("business-hours") && pas.Fields["business-hours"].ToString().Replace('\"', ' ').Trim().Length > 0;
            var response = new WebhookResponse();

            string name = "Jeffson Library", address = "1234 Brentwood Lane, Dallas, TX 12345", businessHour = "8:00 am to 8:00 pm";

            StringBuilder sb = new StringBuilder();

            //if (askingName)
            //{
            //    sb.Append("The name of library is: " + name + "; ");
            //}

            //if (askingAddress)
            //{
            //    sb.Append("The Address of library is: " + address + "; ");
            //}

            //if (askingBusinessHour)
            //{
            //    sb.Append("The Business Hour of library is: " + businessHour + "; ");
            //}

            if (sb.Length == 0)
            {
                sb.Append("Greetings from our Webhook API!");
            }

            response.FulfillmentText = sb.ToString();

            return Ok(response.ToString());
        }

    }
}
