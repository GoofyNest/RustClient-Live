internal class GAHTTPApi // TypeDefIndex: 5674
{
	private static readonly GAHTTPApi _instance; 
	private static string protocol; 
	private static string hostName; 
	private static string version; 
	private static string baseUrl; 
	private static string initializeUrlPath; 
	private static string eventsUrlPath; 
	private bool useGzip; 

	public static GAHTTPApi Instance { get; }


	private static string getBaseUrl() { }

	public static GAHTTPApi get_Instance() { }

	private void .ctor() { }

	private bool MyRemoteCertificateValidationCallback(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { }

	public KeyValuePair<EGAHTTPApiResponse, JSONObject> RequestInitReturningDict() { }

	public KeyValuePair<EGAHTTPApiResponse, JSONNode> SendEventsInArray(List<JSONNode> eventArray) { }

	private byte[] CreatePayloadData(string payload, bool gzip) { }

	private HttpWebRequest CreateRequest(string url, byte[] payloadData, bool gzip) { }

	private EGAHTTPApiResponse ProcessRequestResponse(HttpStatusCode responseCode, string responseMessage, string body, string requestId) { }

	private static void .cctor() { }

}

