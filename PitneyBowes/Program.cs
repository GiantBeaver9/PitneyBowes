HttpClient client = new HttpClient();

Uri pitney = new Uri("https://shipping-api-sandbox.pitneybowes.com/");
var key = ""; var BasicKey = "";
string GetToken = "oauth/token";

client.BaseAddress = pitney;
client.DefaultRequestHeaders.Add("ApiKey", key);
client.DefaultRequestHeaders.Add("Basic", BasicKey);
client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/x-www-form-urlencoded"));

var response = await client.PostAsync(pitney + GetToken, new StringContent(""));
