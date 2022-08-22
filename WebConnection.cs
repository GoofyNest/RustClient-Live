internal class WebConnection // TypeDefIndex: 3027
{	private ServicePoint sPoint; // 0x10
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

	internal HttpWebRequest PriorityRequest { set; }
	internal bool NtlmAuthenticated { get; set; }
	internal NetworkCredential NtlmCredential { get; set; }
	internal bool UnsafeAuthenticatedConnectionSharing { get; set; }


	public void .ctor(IWebConnectionState wcs, ServicePoint sPoint) { }

	private bool CanReuse() { }

	private void Connect(HttpWebRequest request) { }

	private bool CreateTunnel(HttpWebRequest request, Uri connectUri, Stream stream, out byte[] buffer) { }

	private WebHeaderCollection ReadHeaders(Stream stream, out byte[] retBuffer, out int status) { }

	private void FlushContents(Stream stream, int contentLength) { }

	private bool CreateStream(HttpWebRequest request) { }

	private void HandleError(WebExceptionStatus st, Exception e, string where) { }

	private void ReadDone(IAsyncResult result) { }

	private static bool ExpectContent(int statusCode, string method) { }

	internal void InitRead() { }

	private static int GetResponse(WebConnectionData data, ServicePoint sPoint, byte[] buffer, int max) { }

	private void InitConnection(HttpWebRequest request) { }

	internal EventHandler SendRequest(HttpWebRequest request) { }

	private void SendNext() { }

	internal void NextRead() { }

	private static bool ReadLine(byte[] buffer, ref int start, int max, ref string output) { }

	internal IAsyncResult BeginRead(HttpWebRequest request, byte[] buffer, int offset, int size, AsyncCallback cb, object state) { }

	internal int EndRead(HttpWebRequest request, IAsyncResult result) { }

	private int EnsureRead(byte[] buffer, int offset, int size) { }

	private bool CompleteChunkedRead() { }

	internal IAsyncResult BeginWrite(HttpWebRequest request, byte[] buffer, int offset, int size, AsyncCallback cb, object state) { }

	internal bool EndWrite(HttpWebRequest request, bool throwOnError, IAsyncResult result) { }

	internal int Read(HttpWebRequest request, byte[] buffer, int offset, int size) { }

	internal bool Write(HttpWebRequest request, byte[] buffer, int offset, int size, ref string err_msg) { }

	internal void Close(bool sendNext) { }

	private void Abort(object sender, EventArgs args) { }

	internal void ResetNtlm() { }

	internal void set_PriorityRequest(HttpWebRequest value) { }

	internal bool get_NtlmAuthenticated() { }

	internal void set_NtlmAuthenticated(bool value) { }

	internal NetworkCredential get_NtlmCredential() { }

	internal void set_NtlmCredential(NetworkCredential value) { }

	internal bool get_UnsafeAuthenticatedConnectionSharing() { }

	internal void set_UnsafeAuthenticatedConnectionSharing(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void <SendRequest>b__41_0(object o) { }

}

private enum WebConnection.NtlmAuthState // TypeDefIndex: 3028
{	public int value__; // 0x0
	public const WebConnection.NtlmAuthState None = 0;
	public const WebConnection.NtlmAuthState Challenge = 1;
	public const WebConnection.NtlmAuthState Response = 2;

}

private class WebConnection.AbortHelper // TypeDefIndex: 3029
{	public WebConnection Connection; // 0x10


	public void Abort(object sender, EventArgs args) { }

	public void .ctor() { }

}

