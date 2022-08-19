internal class GAHTTPApi // TypeDefIndex: 5673
{	// Fields
	private static readonly GAHTTPApi _instance; // 0x0
	private static string protocol; // 0x8
	private static string hostName; // 0x10
	private static string version; // 0x18
	private static string baseUrl; // 0x20
	private static string initializeUrlPath; // 0x28
	private static string eventsUrlPath; // 0x30
	private bool useGzip; // 0x10

	// Properties
	public static GAHTTPApi Instance { get; }

	// Methods

	// RVA: 0x13B2A90 Offset: 0x13B1E90 VA: 0x1813B2A90
	private static string getBaseUrl() { }

	// RVA: 0x13B2D10 Offset: 0x13B2110 VA: 0x1813B2D10
	public static GAHTTPApi get_Instance() { }

	// RVA: 0x13B2A00 Offset: 0x13B1E00 VA: 0x1813B2A00
	private void .ctor() { }

	// RVA: 0x13B0560 Offset: 0x13AF960 VA: 0x1813B0560
	private bool MyRemoteCertificateValidationCallback(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { }

	// RVA: 0x13B0B60 Offset: 0x13AFF60 VA: 0x1813B0B60
	public KeyValuePair<EGAHTTPApiResponse, JSONObject> RequestInitReturningDict() { }

	// RVA: 0x13B1A10 Offset: 0x13B0E10 VA: 0x1813B1A10
	public KeyValuePair<EGAHTTPApiResponse, JSONNode> SendEventsInArray(List<JSONNode> eventArray) { }

	// RVA: 0x13AFF30 Offset: 0x13AF330 VA: 0x1813AFF30
	private byte[] CreatePayloadData(string payload, bool gzip) { }

	// RVA: 0x13B02E0 Offset: 0x13AF6E0 VA: 0x1813B02E0
	private HttpWebRequest CreateRequest(string url, byte[] payloadData, bool gzip) { }

	// RVA: 0x13B0760 Offset: 0x13AFB60 VA: 0x1813B0760
	private EGAHTTPApiResponse ProcessRequestResponse(HttpStatusCode responseCode, string responseMessage, string body, string requestId) { }

	// RVA: 0x13B2860 Offset: 0x13B1C60 VA: 0x1813B2860
	private static void .cctor() { }

}

