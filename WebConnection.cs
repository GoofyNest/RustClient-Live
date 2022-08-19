internal class WebConnection // TypeDefIndex: 3027
{	// Fields
	private ServicePoint sPoint; // 0x10
	private Stream nstream; // 0x18
	internal Socket socket; // 0x20
	private object socketLock; // 0x28
	private IWebConnectionState state; // 0x30
	private WebExceptionStatus status; // 0x38
	private bool keepAlive; // 0x3C
	private byte[] buffer; // 0x40
	private EventHandler abortHandler; // 0x48
	private WebConnection.AbortHelper abortHelper; // 0x50
	internal WebConnectionData Data; // 0x58
	private bool chunkedRead; // 0x60
	private MonoChunkStream chunkStream; // 0x68
	private Queue queue; // 0x70
	private bool reused; // 0x78
	private int position; // 0x7C
	private HttpWebRequest priority_request; // 0x80
	private NetworkCredential ntlm_credentials; // 0x88
	private bool ntlm_authenticated; // 0x90
	private bool unsafe_sharing; // 0x91
	private WebConnection.NtlmAuthState connect_ntlm_auth_state; // 0x94
	private HttpWebRequest connect_request; // 0x98
	private Exception connect_exception; // 0xA0
	private MonoTlsStream tlsStream; // 0xA8

	// Properties
	internal HttpWebRequest PriorityRequest { set; }
	internal bool NtlmAuthenticated { get; set; }
	internal NetworkCredential NtlmCredential { get; set; }
	internal bool UnsafeAuthenticatedConnectionSharing { get; set; }

	// Methods

	// RVA: 0x1182E60 Offset: 0x1182260 VA: 0x181182E60
	public void .ctor(IWebConnectionState wcs, ServicePoint sPoint) { }

	// RVA: 0x117E320 Offset: 0x117D720 VA: 0x18117E320
	private bool CanReuse() { }

	// RVA: 0x117E720 Offset: 0x117DB20 VA: 0x18117E720
	private void Connect(HttpWebRequest request) { }

	// RVA: 0x117EF30 Offset: 0x117E330 VA: 0x18117EF30
	private bool CreateTunnel(HttpWebRequest request, Uri connectUri, Stream stream, out byte[] buffer) { }

	// RVA: 0x1181C70 Offset: 0x1181070 VA: 0x181181C70
	private WebHeaderCollection ReadHeaders(Stream stream, out byte[] retBuffer, out int status) { }

	// RVA: 0x1180440 Offset: 0x117F840 VA: 0x181180440
	private void FlushContents(Stream stream, int contentLength) { }

	// RVA: 0x117ED10 Offset: 0x117E110 VA: 0x18117ED10
	private bool CreateStream(HttpWebRequest request) { }

	// RVA: 0x1180C70 Offset: 0x1180070 VA: 0x181180C70
	private void HandleError(WebExceptionStatus st, Exception e, string where) { }

	// RVA: 0x11816F0 Offset: 0x1180AF0 VA: 0x1811816F0
	private void ReadDone(IAsyncResult result) { }

	// RVA: 0x11803C0 Offset: 0x117F7C0 VA: 0x1811803C0
	private static bool ExpectContent(int statusCode, string method) { }

	// RVA: 0x1181260 Offset: 0x1180660 VA: 0x181181260
	internal void InitRead() { }

	// RVA: 0x11804C0 Offset: 0x117F8C0 VA: 0x1811804C0
	private static int GetResponse(WebConnectionData data, ServicePoint sPoint, byte[] buffer, int max) { }

	// RVA: 0x1180E40 Offset: 0x1180240 VA: 0x181180E40
	private void InitConnection(HttpWebRequest request) { }

	// RVA: 0x1182940 Offset: 0x1181D40 VA: 0x181182940
	internal EventHandler SendRequest(HttpWebRequest request) { }

	// RVA: 0x11827D0 Offset: 0x1181BD0 VA: 0x1811827D0
	private void SendNext() { }

	// RVA: 0x1181370 Offset: 0x1180770 VA: 0x181181370
	internal void NextRead() { }

	// RVA: 0x1182200 Offset: 0x1181600 VA: 0x181182200
	private static bool ReadLine(byte[] buffer, ref int start, int max, ref string output) { }

	// RVA: 0x117DC60 Offset: 0x117D060 VA: 0x18117DC60
	internal IAsyncResult BeginRead(HttpWebRequest request, byte[] buffer, int offset, int size, AsyncCallback cb, object state) { }

	// RVA: 0x117F910 Offset: 0x117ED10 VA: 0x18117F910
	internal int EndRead(HttpWebRequest request, IAsyncResult result) { }

	// RVA: 0x1180260 Offset: 0x117F660 VA: 0x181180260
	private int EnsureRead(byte[] buffer, int offset, int size) { }

	// RVA: 0x117E670 Offset: 0x117DA70 VA: 0x18117E670
	private bool CompleteChunkedRead() { }

	// RVA: 0x117DF80 Offset: 0x117D380 VA: 0x18117DF80
	internal IAsyncResult BeginWrite(HttpWebRequest request, byte[] buffer, int offset, int size, AsyncCallback cb, object state) { }

	// RVA: 0x117FF90 Offset: 0x117F390 VA: 0x18117FF90
	internal bool EndWrite(HttpWebRequest request, bool throwOnError, IAsyncResult result) { }

	// RVA: 0x1182400 Offset: 0x1181800 VA: 0x181182400
	internal int Read(HttpWebRequest request, byte[] buffer, int offset, int size) { }

	// RVA: 0x1182BF0 Offset: 0x1181FF0 VA: 0x181182BF0
	internal bool Write(HttpWebRequest request, byte[] buffer, int offset, int size, ref string err_msg) { }

	// RVA: 0x117E350 Offset: 0x117D750 VA: 0x18117E350
	internal void Close(bool sendNext) { }

	// RVA: 0x117D7E0 Offset: 0x117CBE0 VA: 0x18117D7E0
	private void Abort(object sender, EventArgs args) { }

	// RVA: 0x1182790 Offset: 0x1181B90 VA: 0x181182790
	internal void ResetNtlm() { }

	// RVA: 0x58DCD0 Offset: 0x58D0D0 VA: 0x18058DCD0
	internal void set_PriorityRequest(HttpWebRequest value) { }

	// RVA: 0x1183060 Offset: 0x1182460 VA: 0x181183060
	internal bool get_NtlmAuthenticated() { }

	// RVA: 0x1183080 Offset: 0x1182480 VA: 0x181183080
	internal void set_NtlmAuthenticated(bool value) { }

	// RVA: 0x58DBD0 Offset: 0x58CFD0 VA: 0x18058DBD0
	internal NetworkCredential get_NtlmCredential() { }

	// RVA: 0x58DC60 Offset: 0x58D060 VA: 0x18058DC60
	internal void set_NtlmCredential(NetworkCredential value) { }

	// RVA: 0x1183070 Offset: 0x1182470 VA: 0x181183070
	internal bool get_UnsafeAuthenticatedConnectionSharing() { }

	// RVA: 0x1183090 Offset: 0x1182490 VA: 0x181183090
	internal void set_UnsafeAuthenticatedConnectionSharing(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1182B40 Offset: 0x1181F40 VA: 0x181182B40
	private void <SendRequest>b__41_0(object o) { }

}

private enum WebConnection.NtlmAuthState // TypeDefIndex: 3028
{	// Fields
	public int value__; // 0x0
	public const WebConnection.NtlmAuthState None = 0;
	public const WebConnection.NtlmAuthState Challenge = 1;
	public const WebConnection.NtlmAuthState Response = 2;

}

private class WebConnection.AbortHelper // TypeDefIndex: 3029
{	// Fields
	public WebConnection Connection; // 0x10

	// Methods

	// RVA: 0x1173E30 Offset: 0x1173230 VA: 0x181173E30
	public void Abort(object sender, EventArgs args) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

