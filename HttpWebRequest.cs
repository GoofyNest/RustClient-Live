public class HttpWebRequest : WebRequest, ISerializable // TypeDefIndex: 3006
{
	private Uri requestUri; 
	private Uri actualUri; 
	private bool hostChanged; 
	private bool allowAutoRedirect; 
	private bool allowBuffering; 
	private X509CertificateCollection certificates; 
	private string connectionGroup; 
	private bool haveContentLength; 
	private long contentLength; 
	private HttpContinueDelegate continueDelegate; 
	private CookieContainer cookieContainer; 
	private ICredentials credentials; 
	private bool haveResponse; 
	private bool haveRequest; 
	private bool requestSent; 
	private WebHeaderCollection webHeaders; 
	private bool keepAlive; 
	private int maxAutoRedirect; 
	private string mediaType; 
	private string method; 
	private string initialMethod; 
	private bool pipelined; 
	private bool preAuthenticate; 
	private bool usedPreAuth; 
	private Version version; 
	private bool force_version; 
	private Version actualVersion; 
	private IWebProxy proxy; 
	private bool sendChunked; 
	private ServicePoint servicePoint; 
	private int timeout; 
	private WebConnectionStream writeStream; 
	private HttpWebResponse webResponse; 
	private WebAsyncResult asyncWrite; 
	private WebAsyncResult asyncRead; 
	private EventHandler abortHandler; 
	private int aborted; 
	private bool gotRequestStream; 
	private int redirects; 
	private bool expectContinue; 
	private byte[] bodyBuffer; 
	private int bodyBufferLength; 
	private bool getResponseCalled; 
	private Exception saved_exc; 
	private object locker; 
	private bool finished_reading; 
	internal WebConnection WebConnection; 
	private DecompressionMethods auto_decomp; 
	private static int defaultMaxResponseHeadersLength; 
	private int readWriteTimeout; 
	private MonoTlsProvider tlsProvider; 
	private MonoTlsSettings tlsSettings; 
	private ServerCertValidationCallback certValidationCallback; 
	private HttpWebRequest.AuthorizationState auth_state; 
	private HttpWebRequest.AuthorizationState proxy_auth_state; 
	private string host; 
	internal Action<Stream> ResendContentFactory; 
	[CompilerGeneratedAttribute] 
	private bool <ThrowOnError>k__BackingField; 
	private bool unsafe_auth_blah; 
	[CompilerGeneratedAttribute] 
	private bool <ReuseConnection>k__BackingField; 
	internal WebConnection StoredConnection; 

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

	[ObsoleteAttribute] 
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

	[CompilerGeneratedAttribute] 
	internal bool get_ThrowOnError() { }

	[CompilerGeneratedAttribute] 
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

	[CompilerGeneratedAttribute] 
	internal bool get_ReuseConnection() { }

	[CompilerGeneratedAttribute] 
	internal void set_ReuseConnection(bool value) { }

	[CompilerGeneratedAttribute] 
	private void <SetWriteStream>b__258_0(SimpleAsyncResult result) { }

	[CompilerGeneratedAttribute] 
	private void <SetWriteStream>b__258_1(SimpleAsyncResult inner) { }

	[CompilerGeneratedAttribute] 
	private bool <SetWriteStreamInner>b__259_0(SimpleAsyncResult result) { }

	[EditorBrowsableAttribute] 
	[ObsoleteAttribute] 
	public void .ctor() { }

}

private enum HttpWebRequest.NtlmAuthState // TypeDefIndex: 3007
{
	public int value__; 
	public const HttpWebRequest.NtlmAuthState None = 0;
	public const HttpWebRequest.NtlmAuthState Challenge = 1;
	public const HttpWebRequest.NtlmAuthState Response = 2;

}

private struct HttpWebRequest.AuthorizationState // TypeDefIndex: 3008
{
	private readonly HttpWebRequest request; 
	private readonly bool isProxy; 
	private bool isCompleted; 
	private HttpWebRequest.NtlmAuthState ntlm_auth_state; 

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
{
	public WebAsyncResult aread; 
	public HttpWebRequest <>4__this; 


	public void .ctor() { }

	internal void <BeginGetResponse>b__0(SimpleAsyncResult inner) { }

}

