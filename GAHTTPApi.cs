internal class GAHTTPApi // TypeDefIndex: 5673
{	private static readonly GAHTTPApi _instance; // 0x0
	private static string protocol; // 0x8
	private static string hostName; // 0x10
	private static string version; // 0x18
	private static string baseUrl; // 0x20
	private static string initializeUrlPath; // 0x28
	private static string eventsUrlPath; // 0x30
	private bool useGzip; // 0x10

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

