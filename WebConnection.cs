internal class WebConnection // TypeDefIndex: 3027
{
	private ServicePoint sPoint; 
	private Stream nstream; 
	internal Socket socket; 
	private object socketLock; 
	private IWebConnectionState state; 
	private WebExceptionStatus status; 
	private bool keepAlive; 
	private byte[] buffer; 
	private EventHandler abortHandler; 
	private WebConnection.AbortHelper abortHelper; 
	internal WebConnectionData Data; 
	private bool chunkedRead; 
	private MonoChunkStream chunkStream; 
	private Queue queue; 
	private bool reused; 
	private int position; 
	private HttpWebRequest priority_request; 
	private NetworkCredential ntlm_credentials; 
	private bool ntlm_authenticated; 
	private bool unsafe_sharing; 
	private WebConnection.NtlmAuthState connect_ntlm_auth_state; 
	private HttpWebRequest connect_request; 
	private Exception connect_exception; 
	private MonoTlsStream tlsStream; 

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

	[CompilerGeneratedAttribute] 
private void <SendRequest>b__41_0(object o) { }

}

private enum WebConnection.NtlmAuthState // TypeDefIndex: 3028
{
	public int value__; 
public const WebConnection.NtlmAuthState None = 0;
public const WebConnection.NtlmAuthState Challenge = 1;
public const WebConnection.NtlmAuthState Response = 2;

}

private class WebConnection.AbortHelper // TypeDefIndex: 3029
{
	public WebConnection Connection; 


public void Abort(object sender, EventArgs args) { }

public void .ctor() { }

}

