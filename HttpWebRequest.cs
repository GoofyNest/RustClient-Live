public class HttpWebRequest : WebRequest, ISerializable // TypeDefIndex: 3006
{	// Fields
	private Uri requestUri; // 0x38
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

	// Properties
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

	// Methods

	// RVA: 0x133B1B0 Offset: 0x133A5B0 VA: 0x18133B1B0
	private static void .cctor() { }

	// RVA: 0x133B220 Offset: 0x133A620 VA: 0x18133B220
	public void .ctor(Uri uri) { }

	[ObsoleteAttribute] // RVA: 0xB6DD0 Offset: 0xB61D0 VA: 0x1800B6DD0
	// RVA: 0x133B400 Offset: 0x133A800 VA: 0x18133B400
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1339D30 Offset: 0x1339130 VA: 0x181339D30
	private void ResetAuthorization() { }

	// RVA: 0x133A960 Offset: 0x1339D60 VA: 0x18133A960
	private void SetSpecialHeaders(string HeaderName, string value) { }

	// RVA: 0x133BD80 Offset: 0x133B180 VA: 0x18133BD80
	public void set_Accept(string value) { }

	// RVA: 0x4B9440 Offset: 0x4B8840 VA: 0x1804B9440
	public Uri get_Address() { }

	// RVA: 0x4B94A0 Offset: 0x4B88A0 VA: 0x1804B94A0
	internal void set_Address(Uri value) { }

	// RVA: 0x82B450 Offset: 0x82A850 VA: 0x18082B450 Slot: 36
	public virtual void set_AllowAutoRedirect(bool value) { }

	// RVA: 0xB9D220 Offset: 0xB9C620 VA: 0x180B9D220 Slot: 37
	public virtual bool get_AllowWriteStreamBuffering() { }

	// RVA: 0x1233220 Offset: 0x1232620 VA: 0x181233220 Slot: 38
	public virtual void set_AllowWriteStreamBuffering(bool value) { }

	// RVA: 0x94E3D0 Offset: 0x94D7D0 VA: 0x18094E3D0
	public DecompressionMethods get_AutomaticDecompression() { }

	// RVA: 0x133BE20 Offset: 0x133B220 VA: 0x18133BE20
	public void set_AutomaticDecompression(DecompressionMethods value) { }

	// RVA: 0x133BB80 Offset: 0x133AF80 VA: 0x18133BB80
	internal bool get_InternalAllowBuffering() { }

	// RVA: 0x133BB90 Offset: 0x133AF90 VA: 0x18133BB90
	private bool get_MethodWithBuffer() { }

	// RVA: 0xA1B2D0 Offset: 0xA1A6D0 VA: 0x180A1B2D0
	internal MonoTlsProvider get_TlsProvider() { }

	// RVA: 0x8A99E0 Offset: 0x8A8DE0 VA: 0x1808A99E0
	internal MonoTlsSettings get_TlsSettings() { }

	// RVA: 0x133BA70 Offset: 0x133AE70 VA: 0x18133BA70
	public X509CertificateCollection get_ClientCertificates() { }

	// RVA: 0x133BEA0 Offset: 0x133B2A0 VA: 0x18133BEA0
	public void set_Connection(string value) { }

	// RVA: 0x4CC360 Offset: 0x4CB760 VA: 0x1804CC360 Slot: 12
	public override void set_ConnectionGroupName(string value) { }

	// RVA: 0x5334F0 Offset: 0x5328F0 VA: 0x1805334F0 Slot: 15
	public override long get_ContentLength() { }

	// RVA: 0x133C050 Offset: 0x133B450 VA: 0x18133C050 Slot: 16
	public override void set_ContentLength(long value) { }

	// RVA: 0x133C6B0 Offset: 0x133BAB0 VA: 0x18133C6B0
	internal void set_InternalContentLength(long value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xC62530 Offset: 0xC61930 VA: 0x180C62530
	internal bool get_ThrowOnError() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x133CC50 Offset: 0x133C050 VA: 0x18133CC50
	internal void set_ThrowOnError(bool value) { }

	// RVA: 0x133BAE0 Offset: 0x133AEE0 VA: 0x18133BAE0 Slot: 17
	public override string get_ContentType() { }

	// RVA: 0x133C120 Offset: 0x133B520 VA: 0x18133C120 Slot: 18
	public override void set_ContentType(string value) { }

	// RVA: 0x4E51E0 Offset: 0x4E45E0 VA: 0x1804E51E0 Slot: 39
	public virtual void set_CookieContainer(CookieContainer value) { }

	// RVA: 0x58DC40 Offset: 0x58D040 VA: 0x18058DC40 Slot: 19
	public override ICredentials get_Credentials() { }

	// RVA: 0x58DCD0 Offset: 0x58D0D0 VA: 0x18058DCD0 Slot: 20
	public override void set_Credentials(ICredentials value) { }

	// RVA: 0x133C180 Offset: 0x133B580 VA: 0x18133C180
	public void set_Expect(string value) { }

	// RVA: 0x4E09F0 Offset: 0x4DFDF0 VA: 0x1804E09F0 Slot: 13
	public override WebHeaderCollection get_Headers() { }

	// RVA: 0x133C2F0 Offset: 0x133B6F0 VA: 0x18133C2F0 Slot: 14
	public override void set_Headers(WebHeaderCollection value) { }

	// RVA: 0x133BB50 Offset: 0x133AF50 VA: 0x18133BB50
	public string get_Host() { }

	// RVA: 0x133C470 Offset: 0x133B870 VA: 0x18133C470
	public void set_Host(string value) { }

	// RVA: 0x1337EE0 Offset: 0x13372E0 VA: 0x181337EE0
	private static bool CheckValidHost(string scheme, string val) { }

	// RVA: 0x117D720 Offset: 0x117CB20 VA: 0x18117D720
	public bool get_KeepAlive() { }

	// RVA: 0x133C6C0 Offset: 0x133BAC0 VA: 0x18133C6C0
	public void set_KeepAlive(bool value) { }

	// RVA: 0x133C6D0 Offset: 0x133BAD0 VA: 0x18133C6D0
	public void set_MaximumAutomaticRedirections(int value) { }

	// RVA: 0x133BC70 Offset: 0x133B070 VA: 0x18133BC70
	public int get_ReadWriteTimeout() { }

	// RVA: 0x9321E0 Offset: 0x9315E0 VA: 0x1809321E0 Slot: 9
	public override string get_Method() { }

	// RVA: 0x133C750 Offset: 0x133BB50 VA: 0x18133C750 Slot: 10
	public override void set_Method(string value) { }

	// RVA: 0x12D5560 Offset: 0x12D4960 VA: 0x1812D5560 Slot: 25
	public override void set_PreAuthenticate(bool value) { }

	// RVA: 0x104A060 Offset: 0x1049460 VA: 0x18104A060
	public Version get_ProtocolVersion() { }

	// RVA: 0x133C8D0 Offset: 0x133BCD0 VA: 0x18133C8D0
	public void set_ProtocolVersion(Version value) { }

	// RVA: 0xD9A430 Offset: 0xD99830 VA: 0x180D9A430 Slot: 23
	public override IWebProxy get_Proxy() { }

	// RVA: 0x133CA20 Offset: 0x133BE20 VA: 0x18133CA20 Slot: 24
	public override void set_Proxy(IWebProxy value) { }

	// RVA: 0x133CAC0 Offset: 0x133BEC0 VA: 0x18133CAC0
	public void set_Referer(string value) { }

	// RVA: 0x5DCC00 Offset: 0x5DC000 VA: 0x1805DCC00 Slot: 11
	public override Uri get_RequestUri() { }

	// RVA: 0x10C2B80 Offset: 0x10C1F80 VA: 0x1810C2B80
	public bool get_SendChunked() { }

	// RVA: 0x133CBD0 Offset: 0x133BFD0 VA: 0x18133CBD0
	public void set_SendChunked(bool value) { }

	// RVA: 0x133BC90 Offset: 0x133B090 VA: 0x18133BC90
	public ServicePoint get_ServicePoint() { }

	// RVA: 0x94E830 Offset: 0x94DC30 VA: 0x18094E830
	internal ServicePoint get_ServicePointNoLock() { }

	// RVA: 0x1074C80 Offset: 0x1074080 VA: 0x181074C80 Slot: 26
	public override int get_Timeout() { }

	// RVA: 0x133BCA0 Offset: 0x133B0A0 VA: 0x18133BCA0
	public string get_TransferEncoding() { }

	// RVA: 0x133BD00 Offset: 0x133B100 VA: 0x18133BD00 Slot: 21
	public override bool get_UseDefaultCredentials() { }

	// RVA: 0x133CC60 Offset: 0x133C060 VA: 0x18133CC60 Slot: 22
	public override void set_UseDefaultCredentials(bool value) { }

	// RVA: 0x133CCF0 Offset: 0x133C0F0 VA: 0x18133CCF0
	public void set_UserAgent(string value) { }

	// RVA: 0x133BCF0 Offset: 0x133B0F0 VA: 0x18133BCF0
	public bool get_UnsafeAuthenticatedConnectionSharing() { }

	// RVA: 0x133BB30 Offset: 0x133AF30 VA: 0x18133BB30
	internal bool get_ExpectContinue() { }

	// RVA: 0x133C170 Offset: 0x133B570 VA: 0x18133C170
	internal void set_ExpectContinue(bool value) { }

	// RVA: 0x4B9440 Offset: 0x4B8840 VA: 0x1804B9440
	internal Uri get_AuthUri() { }

	// RVA: 0x133BC40 Offset: 0x133B040 VA: 0x18133BC40
	internal bool get_ProxyQuery() { }

	// RVA: 0xC62840 Offset: 0xC61C40 VA: 0x180C62840
	internal ServerCertValidationCallback get_ServerCertValidationCallback() { }

	// RVA: 0x1339560 Offset: 0x1338960 VA: 0x181339560
	internal ServicePoint GetServicePoint() { }

	// RVA: 0x1336CD0 Offset: 0x13360D0 VA: 0x181336CD0 Slot: 31
	public override IAsyncResult BeginGetRequestStream(AsyncCallback callback, object state) { }

	// RVA: 0x13381D0 Offset: 0x13375D0 VA: 0x1813381D0 Slot: 32
	public override Stream EndGetRequestStream(IAsyncResult asyncResult) { }

	// RVA: 0x1339320 Offset: 0x1338720 VA: 0x181339320 Slot: 27
	public override Stream GetRequestStream() { }

	// RVA: 0x1337BE0 Offset: 0x1336FE0 VA: 0x181337BE0
	private bool CheckIfForceWrite(SimpleAsyncResult result) { }

	// RVA: 0x1337150 Offset: 0x1336550 VA: 0x181337150 Slot: 29
	public override IAsyncResult BeginGetResponse(AsyncCallback callback, object state) { }

	// RVA: 0x13382F0 Offset: 0x13376F0 VA: 0x1813382F0 Slot: 30
	public override WebResponse EndGetResponse(IAsyncResult asyncResult) { }

	// RVA: 0x13394B0 Offset: 0x13388B0 VA: 0x1813394B0 Slot: 28
	public override WebResponse GetResponse() { }

	// RVA: 0x133BB40 Offset: 0x133AF40 VA: 0x18133BB40
	internal bool get_FinishedReading() { }

	// RVA: 0x133C2E0 Offset: 0x133B6E0 VA: 0x18133C2E0
	internal void set_FinishedReading(bool value) { }

	// RVA: 0x133BA40 Offset: 0x133AE40 VA: 0x18133BA40
	internal bool get_Aborted() { }

	// RVA: 0x1336A40 Offset: 0x1335E40 VA: 0x181336A40 Slot: 35
	public override void Abort() { }

	// RVA: 0x1188F90 Offset: 0x1188390 VA: 0x181188F90 Slot: 6
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1338BD0 Offset: 0x1337FD0 VA: 0x181338BD0 Slot: 7
	protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1337D30 Offset: 0x1337130 VA: 0x181337D30
	private void CheckRequestStarted() { }

	// RVA: 0x1338050 Offset: 0x1337450 VA: 0x181338050
	internal void DoContinueDelegate(int statusCode, WebHeaderCollection headers) { }

	// RVA: 0x1339DC0 Offset: 0x13391C0 VA: 0x181339DC0
	private void RewriteRedirectToGet() { }

	// RVA: 0x1339910 Offset: 0x1338D10 VA: 0x181339910
	private bool Redirect(WebAsyncResult result, HttpStatusCode code, WebResponse response) { }

	// RVA: 0x1338470 Offset: 0x1337870 VA: 0x181338470
	private string GetHeaders() { }

	// RVA: 0x1338070 Offset: 0x1337470 VA: 0x181338070
	private void DoPreAuthenticate() { }

	// RVA: 0x133AAC0 Offset: 0x1339EC0 VA: 0x18133AAC0
	internal void SetWriteStreamError(WebExceptionStatus status, Exception exc) { }

	// RVA: 0x1338EC0 Offset: 0x13382C0 VA: 0x181338EC0
	internal byte[] GetRequestHeaders() { }

	// RVA: 0x133ACF0 Offset: 0x133A0F0 VA: 0x18133ACF0
	internal void SetWriteStream(WebConnectionStream stream) { }

	// RVA: 0x133AC70 Offset: 0x133A070 VA: 0x18133AC70
	private void SetWriteStreamInner(SimpleAsyncCallback callback) { }

	// RVA: 0x133AA20 Offset: 0x1339E20 VA: 0x18133AA20
	private void SetWriteStreamError(Exception exc) { }

	// RVA: 0x133A6C0 Offset: 0x1339AC0 VA: 0x18133A6C0
	internal void SetResponseError(WebExceptionStatus status, Exception e, string where) { }

	// RVA: 0x1337DA0 Offset: 0x13371A0 VA: 0x181337DA0
	private void CheckSendError(WebConnectionData data) { }

	// RVA: 0x13396A0 Offset: 0x1338AA0 VA: 0x1813396A0
	private bool HandleNtlmAuth(WebAsyncResult r) { }

	// RVA: 0x1339E30 Offset: 0x1339230 VA: 0x181339E30
	internal void SetResponseData(WebConnectionData data) { }

	// RVA: 0x1337450 Offset: 0x1336850 VA: 0x181337450
	private bool CheckAuthorization(WebResponse response, HttpStatusCode code) { }

	// RVA: 0x1337480 Offset: 0x1336880 VA: 0x181337480
	private bool CheckFinalStatus(WebAsyncResult result) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x133BC80 Offset: 0x133B080 VA: 0x18133BC80
	internal bool get_ReuseConnection() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x133CBC0 Offset: 0x133BFC0 VA: 0x18133CBC0
	internal void set_ReuseConnection(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x133AEF0 Offset: 0x133A2F0 VA: 0x18133AEF0
	private void <SetWriteStream>b__258_0(SimpleAsyncResult result) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x133B070 Offset: 0x133A470 VA: 0x18133B070
	private void <SetWriteStream>b__258_1(SimpleAsyncResult inner) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x133ADF0 Offset: 0x133A1F0 VA: 0x18133ADF0
	private bool <SetWriteStreamInner>b__259_0(SimpleAsyncResult result) { }

	[EditorBrowsableAttribute] // RVA: 0xB8680 Offset: 0xB7A80 VA: 0x1800B8680
	[ObsoleteAttribute] // RVA: 0xB8680 Offset: 0xB7A80 VA: 0x1800B8680
	// RVA: 0x133B1F0 Offset: 0x133A5F0 VA: 0x18133B1F0
	public void .ctor() { }

}

private enum HttpWebRequest.NtlmAuthState // TypeDefIndex: 3007
{	// Fields
	public int value__; // 0x0
	public const HttpWebRequest.NtlmAuthState None = 0;
	public const HttpWebRequest.NtlmAuthState Challenge = 1;
	public const HttpWebRequest.NtlmAuthState Response = 2;

}

private struct HttpWebRequest.AuthorizationState // TypeDefIndex: 3008
{	// Fields
	private readonly HttpWebRequest request; // 0x0
	private readonly bool isProxy; // 0x8
	private bool isCompleted; // 0x9
	private HttpWebRequest.NtlmAuthState ntlm_auth_state; // 0xC

	// Properties
	public bool IsCompleted { get; }
	public HttpWebRequest.NtlmAuthState NtlmAuthState { get; }
	public bool IsNtlmAuthenticated { get; }

	// Methods

	// RVA: 0x1AE180 Offset: 0x1AD580 VA: 0x1801AE180
	public bool get_IsCompleted() { }

	// RVA: 0x1AE2C0 Offset: 0x1AD6C0 VA: 0x1801AE2C0
	public HttpWebRequest.NtlmAuthState get_NtlmAuthState() { }

	// RVA: 0x1E13E0 Offset: 0x1E07E0 VA: 0x1801E13E0
	public bool get_IsNtlmAuthenticated() { }

	// RVA: 0x1E13A0 Offset: 0x1E07A0 VA: 0x1801E13A0
	public void .ctor(HttpWebRequest request, bool isProxy) { }

	// RVA: 0x1E12D0 Offset: 0x1E06D0 VA: 0x1801E12D0
	public bool CheckAuthorization(WebResponse response, HttpStatusCode code) { }

	// RVA: 0x1E12E0 Offset: 0x1E06E0 VA: 0x1801E12E0
	public void Reset() { }

	// RVA: 0x1E12F0 Offset: 0x1E06F0 VA: 0x1801E12F0 Slot: 3
	public override string ToString() { }

}

private sealed class HttpWebRequest.<>c__DisplayClass238_0 // TypeDefIndex: 3009
{	// Fields
	public WebAsyncResult aread; // 0x10
	public HttpWebRequest <>4__this; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x1343EB0 Offset: 0x13432B0 VA: 0x181343EB0
	internal void <BeginGetResponse>b__0(SimpleAsyncResult inner) { }

}

