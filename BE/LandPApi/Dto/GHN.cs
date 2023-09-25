using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace LandPApi.Dto
{
    public class PostData
    {
        //public int from_district_id { get; set; } = 1454;
        //public string from_ward_code { get; set; } = "21211";
        //public int service_id { get; set; } = 53320;
        public int insurance_value { get; set; } = 0;
        public int cod_failed_amount { get; set; } = 0;
        public string? coupon { get; set; } = null;
        public int? service_type_id { get; set; } = 2;
        // Need to edit
        public int to_district_id { get; set; } = 1452;
        public string to_ward_code { get; set; } = "21012";
        public int height { get; set; } = 50;
        public int length { get; set; } = 20;
        public int weight { get; set; } = 200;
        public int width { get; set; } = 20;

    }
    class Data
    {
        public int total { get; set; } = 0;
        public int setvice_fee { get; set; }
        public int insurance_fee { get; set; }
        public int pick_station_fee { get; set; }
        public int counpon_value { get; set; }
        public int r2s_fee { get; set; }
        public int return_again { get; set; }
        public int document_return { get; set; }
        public int double_check { get; set; }
        public int cod_fee { get; set; }
        public int pick_remote_areas_fee { get; set; }
        public int deliver_remote_areas_fee { get; set; }
        public int cod_failed_fee { get; set; }
    }
    class ResponseData
    {
        public int code { get; set; }
        public string message { get; set; }
        public Data data { get; set; }
    }
    public class GHN
    {
        public static async Task<int> FeeShip(PostData postData)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://online-gateway.ghn.vn/shiip/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            client.DefaultRequestHeaders.Add("token", "fca2abc3-f9f0-11ed-a281-3aa62a37e0a5");


            HttpResponseMessage response = await client.PostAsJsonAsync("public-api/v2/shipping-order/fee", postData);
            var responseContent = await response.Content.ReadAsStringAsync();
            var responseData = JsonConvert.DeserializeObject<ResponseData>(responseContent);


            return responseData.data.total;
        }
    }
}
