public class HttpWebRequest : WebRequest, ISerializable // TypeDefIndex: 3006
{	private Uri requestUri; // 0x38
	private Uri actualUri; // 0x40
	private bool hostChanged; // 0x48
	private bool allowAutoRedirect; // 0x49
	private bool allowBuffering; // 0x4A
	private X509CertificateCollection certificates; // 0x50
	private string connectionGroup; // 0x58
	private bool haveContentLength; // 0x60
	private long contentLength; // 0x68
	private HttpContinueDelegate continueDelegate; // 0x70
	private CookieContainer cookieContainer; // 0x78
	private ICredentials credentials; // 0x80
	private bool haveResponse; // 0x88
	private bool haveRequest; // 0x89
	private bool requestSent; // 0x8A
	private WebHeaderCollection webHeaders; // 0x90
	private bool keepAlive; // 0x98
	private int maxAutoRedirect; // 0x9C
	private string mediaType; // 0xA0
	private string method; // 0xA8
	private string initialMethod; // 0xB0
	private bool pipelined; // 0xB8
	private bool preAuthenticate; // 0xB9
	private bool usedPreAuth; // 0xBA
	private Version version; // 0xC0
	private bool force_version; // 0xC8
	private Version actualVersion; // 0xD0
	private IWebProxy proxy; // 0xD8
	private bool sendChunked; // 0xE0
	private ServicePoint servicePoint; // 0xE8
	private int timeout; // 0xF0
	private WebConnectionStream writeStream; // 0xF8
	private HttpWebResponse webResponse; // 0x100
	private WebAsyncResult asyncWrite; // 0x108
	private WebAsyncResult asyncRead; // 0x110
	private EventHandler abortHandler; // 0x118
	private int aborted; // 0x120
	private bool gotRequestStream; // 0x124
	private int redirects; // 0x128
	private bool expectContinue; // 0x12C
	private byte[] bodyBuffer; // 0x130
	private int bodyBufferLength; // 0x138
	private bool getResponseCalled; // 0x13C
	private Exception saved_exc; // 0x140
	private object locker; // 0x148
	private bool finished_reading; // 0x150
	internal WebConnection WebConnection; // 0x158
	private DecompressionMethods auto_decomp; // 0x160
	private static int defaultMaxResponseHeadersLength; // 0x0
	private int readWriteTimeout; // 0x164
	private MonoTlsProvider tlsProvider; // 0x168
	private MonoTlsSettings tlsSettings; // 0x170
	private ServerCertValidationCallback certValidationCallback; // 0x178
	private HttpWebRequest.AuthorizationState auth_state; // 0x180
	private HttpWebRequest.AuthorizationState proxy_auth_state; // 0x190
	private string host; // 0x1A0
	internal Action<Stream> ResendContentFactory; // 0x1A8
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <ThrowOnError>k__BackingField; // 0x1B0
	private bool unsafe_auth_blah; // 0x1B1
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <ReuseConnection>k__BackingField; // 0x1B2
	internal WebConnection StoredConnection; // 0x1B8

	public string Accept { set; }
	public Uri Address { get; set; }
	public virtual bool AllowAutoRedirect { set; }
	public virtual bool AllowWriteStreamBuffering { get; set; }
	public DecompressionMethods AutomaticDecompression { get; set; }
	internal bool InternalAllowBuffering { get; }
	private bool MethodWithBuffer { get; }
	internal MonoTlsProvider TlsProvider { get; }
	internal MonoTlsSettings TlsSettings { get; }
	public X509CertificateCollection ClientCertificates { get; }
	public string Connection { set; }
	public override string ConnectionGroupName { set; }
	public override long ContentLength { get; set; }
	internal long InternalContentLength { set; }
	internal bool ThrowOnError { get; set; }
	public override string ContentType { get; set; }
	public virtual CookieContainer CookieContainer { set; }
	public override ICredentials Credentials { get; set; }
	public string Expect { set; }
	public override WebHeaderCollection Headers { get; set; }
	public string Host { get; set; }
	public bool KeepAlive { get; set; }
	public int MaximumAutomaticRedirections { set; }
	public int ReadWriteTimeout { get; }
	public override string Method { get; set; }
	public override bool PreAuthenticate { set; }
	public Version ProtocolVersion { get; set; }
	public override IWebProxy Proxy { get; set; }
	public string Referer { set; }
	public override Uri RequestUri { get; }
	public bool SendChunked { get; set; }
	public ServicePoint ServicePoint { get; }
	internal ServicePoint ServicePointNoLock { get; }
	public override int Timeout { get; }
	public string TransferEncoding { get; }
	public override bool UseDefaultCredentials { get; set; }
	public string UserAgent { set; }
	public bool UnsafeAuthenticatedConnectionSharing { get; }
	internal bool ExpectContinue { get; set; }
	internal Uri AuthUri { get; }
	internal bool ProxyQuery { get; }
	internal ServerCertValidationCallback ServerCertValidationCallback { get; }
	internal bool FinishedReading { get; set; }
	internal bool Aborted { get; }
	internal bool ReuseConnection { get; set; }


	private static void .cctor() { }

	public void .ctor(Uri uri) { }

	[ObsoleteAttribute] // RVA: 0xB6DD0 Offset: 0xB61D0 VA: 0x1800B6DD0
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	private void ResetAuthorization() { }

	private void SetSpecialHeaders(string HeaderName, string value) { }

	public void set_Accept(string value) { }

	public Uri get_Address() { }

	internal void set_Address(Uri value) { }

	public virtual void set_AllowAutoRedirect(bool value) { }

	public virtual bool get_AllowWriteStreamBuffering() { }

	public virtual void set_AllowWriteStreamBuffering(bool value) { }

	public DecompressionMethods get_AutomaticDecompression() { }

	public void set_AutomaticDecompression(DecompressionMethods value) { }

	internal bool get_InternalAllowBuffering() { }

	private bool get_MethodWithBuffer() { }

	internal MonoTlsProvider get_TlsProvider() { }

	internal MonoTlsSettings get_TlsSettings() { }

	public X509CertificateCollection get_ClientCertificates() { }

	public void set_Connection(string value) { }

	public override void set_ConnectionGroupName(string value) { }

	public override long get_ContentLength() { }

	public override void set_ContentLength(long value) { }

	internal void set_InternalContentLength(long value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal bool get_ThrowOnError() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal void set_ThrowOnError(bool value) { }

	public override string get_ContentType() { }

	public override void set_ContentType(string value) { }

	public virtual void set_CookieContainer(CookieContainer value) { }

	public override ICredentials get_Credentials() { }

	public override void set_Credentials(ICredentials value) { }

	public void set_Expect(string value) { }

	public override WebHeaderCollection get_Headers() { }

	public override void set_Headers(WebHeaderCollection value) { }

	public string get_Host() { }

	public void set_Host(string value) { }

	private static bool CheckValidHost(string scheme, string val) { }

	public bool get_KeepAlive() { }

	public void set_KeepAlive(bool value) { }

	public void set_MaximumAutomaticRedirections(int value) { }

	public int get_ReadWriteTimeout() { }

	public override string get_Method() { }

	public override void set_Method(string value) { }

	public override void set_PreAuthenticate(bool value) { }

	public Version get_ProtocolVersion() { }

	public void set_ProtocolVersion(Version value) { }

	public override IWebProxy get_Proxy() { }

	public override void set_Proxy(IWebProxy value) { }

	public void set_Referer(string value) { }

	public override Uri get_RequestUri() { }

	public bool get_SendChunked() { }

	public void set_SendChunked(bool value) { }

	public ServicePoint get_ServicePoint() { }

	internal ServicePoint get_ServicePointNoLock() { }

	public override int get_Timeout() { }

	public string get_TransferEncoding() { }

	public override bool get_UseDefaultCredentials() { }

	public override void set_UseDefaultCredentials(bool value) { }

	public void set_UserAgent(string value) { }

	public bool get_UnsafeAuthenticatedConnectionSharing() { }

	internal bool get_ExpectContinue() { }

	internal void set_ExpectContinue(bool value) { }

	internal Uri get_AuthUri() { }

	internal bool get_ProxyQuery() { }

	internal ServerCertValidationCallback get_ServerCertValidationCallback() { }

	internal ServicePoint GetServicePoint() { }

	public override IAsyncResult BeginGetRequestStream(AsyncCallback callback, object state) { }

	public override Stream EndGetRequestStream(IAsyncResult asyncResult) { }

	public override Stream GetRequestStream() { }

	private bool CheckIfForceWrite(SimpleAsyncResult result) { }

	public override IAsyncResult BeginGetResponse(AsyncCallback callback, object state) { }

	public override WebResponse EndGetResponse(IAsyncResult asyncResult) { }

	public override WebResponse GetResponse() { }

	internal bool get_FinishedReading() { }

	internal void set_FinishedReading(bool value) { }

	internal bool get_Aborted() { }

	public override void Abort() { }

	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	private void CheckRequestStarted() { }

	internal void DoContinueDelegate(int statusCode, WebHeaderCollection headers) { }

	private void RewriteRedirectToGet() { }

	private bool Redirect(WebAsyncResult result, HttpStatusCode code, WebResponse response) { }

	private string GetHeaders() { }

	private void DoPreAuthenticate() { }

	internal void SetWriteStreamError(WebExceptionStatus status, Exception exc) { }

	internal byte[] GetRequestHeaders() { }

	internal void SetWriteStream(WebConnectionStream stream) { }

	private void SetWriteStreamInner(SimpleAsyncCallback callback) { }

	private void SetWriteStreamError(Exception exc) { }

	internal void SetResponseError(WebExceptionStatus status, Exception e, string where) { }

	private void CheckSendError(WebConnectionData data) { }

	private bool HandleNtlmAuth(WebAsyncResult r) { }

	internal void SetResponseData(WebConnectionData data) { }

	private bool CheckAuthorization(WebResponse response, HttpStatusCode code) { }

	private bool CheckFinalStatus(WebAsyncResult result) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal bool get_ReuseConnection() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal void set_ReuseConnection(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void <SetWriteStream>b__258_0(SimpleAsyncResult result) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void <SetWriteStream>b__258_1(SimpleAsyncResult inner) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <SetWriteStreamInner>b__259_0(SimpleAsyncResult result) { }

	[EditorBrowsableAttribute] // RVA: 0xB8680 Offset: 0xB7A80 VA: 0x1800B8680
	[ObsoleteAttribute] // RVA: 0xB8680 Offset: 0xB7A80 VA: 0x1800B8680
	public void .ctor() { }

}

private enum HttpWebRequest.NtlmAuthState // TypeDefIndex: 3007
{	public int value__; // 0x0
	public const HttpWebRequest.NtlmAuthState None = 0;
	public const HttpWebRequest.NtlmAuthState Challenge = 1;
	public const HttpWebRequest.NtlmAuthState Response = 2;

}

private struct HttpWebRequest.AuthorizationState // TypeDefIndex: 3008
{	private readonly HttpWebRequest request; // 0x0
	private readonly bool isProxy; // 0x8
	private bool isCompleted; // 0x9
	private HttpWebRequest.NtlmAuthState ntlm_auth_state; // 0xC

	public bool IsCompleted { get; }
	public HttpWebRequest.NtlmAuthState NtlmAuthState { get; }
	public bool IsNtlmAuthenticated { get; }


	public bool get_IsCompleted() { }

	public HttpWebRequest.NtlmAuthState get_NtlmAuthState() { }

	public bool get_IsNtlmAuthenticated() { }

	public void .ctor(HttpWebRequest request, bool isProxy) { }

	public bool CheckAuthorization(WebResponse response, HttpStatusCode code) { }

	public void Reset() { }

	public override string ToString() { }

}

private sealed class HttpWebRequest.<>c__DisplayClass238_0 // TypeDefIndex: 3009
{	public WebAsyncResult aread; // 0x10
	public HttpWebRequest <>4__this; // 0x18


	public void .ctor() { }

	internal void <BeginGetResponse>b__0(SimpleAsyncResult inner) { }

}

