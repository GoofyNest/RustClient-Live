public class UnityWebRequest : IDisposable // TypeDefIndex: 4133
{
	internal IntPtr m_Ptr;
	internal DownloadHandler m_DownloadHandler;
	internal UploadHandler m_UploadHandler;
	internal CertificateHandler m_CertificateHandler;
	internal Uri m_Uri;
	public const string kHttpVerbGET = "GET";
	public const string kHttpVerbHEAD = "HEAD";
	public const string kHttpVerbPOST = "POST";
	public const string kHttpVerbPUT = "PUT";
	public const string kHttpVerbCREATE = "CREATE";
	public const string kHttpVerbDELETE = "DELETE";
	[CompilerGeneratedAttribute]
	[DebuggerBrowsableAttribute]
	private bool <disposeCertificateHandlerOnDispose>k__BackingField;
	[DebuggerBrowsableAttribute]
	[CompilerGeneratedAttribute]
	private bool <disposeDownloadHandlerOnDispose>k__BackingField;
	[DebuggerBrowsableAttribute]
	[CompilerGeneratedAttribute]
	private bool <disposeUploadHandlerOnDispose>k__BackingField;

	public bool disposeCertificateHandlerOnDispose { get; set; }
	public bool disposeDownloadHandlerOnDispose { get; set; }
	public bool disposeUploadHandlerOnDispose { get; set; }
	public string method { set; }
	public string error { get; }
	public string url { get; set; }
	public long responseCode { get; }
	public bool isModifiable { get; }
	public bool isDone { get; }
	public bool isNetworkError { get; }
	public bool isHttpError { get; }
	public float downloadProgress { get; }
	[ObsoleteAttribute]
	public bool chunkedTransfer { set; }
	public UploadHandler uploadHandler { get; set; }
	public DownloadHandler downloadHandler { get; set; }
	public CertificateHandler certificateHandler { get; set; }
	public int timeout { set; }


	[NativeMethodAttribute]
	[NativeConditionalAttribute]
	private static string GetWebErrorString(UnityWebRequest.UnityWebRequestError err) { }

	[VisibleToOtherModulesAttribute]
	internal static string GetHTTPStatusString(long responseCode) { }

	[CompilerGeneratedAttribute]
	public bool get_disposeCertificateHandlerOnDispose() { }

	[CompilerGeneratedAttribute]
	public void set_disposeCertificateHandlerOnDispose(bool value) { }

	[CompilerGeneratedAttribute]
	public bool get_disposeDownloadHandlerOnDispose() { }

	[CompilerGeneratedAttribute]
	public void set_disposeDownloadHandlerOnDispose(bool value) { }

	[CompilerGeneratedAttribute]
	public bool get_disposeUploadHandlerOnDispose() { }

	[CompilerGeneratedAttribute]
	public void set_disposeUploadHandlerOnDispose(bool value) { }

	internal static IntPtr Create() { }

	[NativeMethodAttribute]
	private void Release() { }

	internal void InternalDestroy() { }

	private void InternalSetDefaults() { }

	public void .ctor(string url) { }

	public void .ctor(string url, string method) { }

	public void .ctor(string url, string method, DownloadHandler downloadHandler, UploadHandler uploadHandler) { }

	protected override void Finalize() { }

	public void Dispose() { }

	private void DisposeHandlers() { }

	[NativeThrowsAttribute]
	internal UnityWebRequestAsyncOperation BeginWebRequest() { }

	[ObsoleteAttribute]
	public AsyncOperation Send() { }

	public UnityWebRequestAsyncOperation SendWebRequest() { }

	[NativeMethodAttribute]
	public void Abort() { }

	private UnityWebRequest.UnityWebRequestError SetMethod(UnityWebRequest.UnityWebRequestMethod methodType) { }

	internal void InternalSetMethod(UnityWebRequest.UnityWebRequestMethod methodType) { }

	private UnityWebRequest.UnityWebRequestError SetCustomMethod(string customMethodName) { }

	internal void InternalSetCustomMethod(string customMethodName) { }

	public void set_method(string value) { }

	private UnityWebRequest.UnityWebRequestError GetError() { }

	public string get_error() { }

	public string get_url() { }

	public void set_url(string value) { }

	private string GetUrl() { }

	private UnityWebRequest.UnityWebRequestError SetUrl(string url) { }

	private void InternalSetUrl(string url) { }

	public long get_responseCode() { }

	private bool IsExecuting() { }

	[NativeMethodAttribute]
	public bool get_isModifiable() { }

	[NativeMethodAttribute]
	public bool get_isDone() { }

	[NativeMethodAttribute]
	public bool get_isNetworkError() { }

	[NativeMethodAttribute]
	public bool get_isHttpError() { }

	private float GetDownloadProgress() { }

	public float get_downloadProgress() { }

	private UnityWebRequest.UnityWebRequestError SetChunked(bool chunked) { }

	public void set_chunkedTransfer(bool value) { }

	[NativeMethodAttribute]
	internal UnityWebRequest.UnityWebRequestError InternalSetRequestHeader(string name, string value) { }

	public void SetRequestHeader(string name, string value) { }

	private UnityWebRequest.UnityWebRequestError SetUploadHandler(UploadHandler uh) { }

	public UploadHandler get_uploadHandler() { }

	public void set_uploadHandler(UploadHandler value) { }

	private UnityWebRequest.UnityWebRequestError SetDownloadHandler(DownloadHandler dh) { }

	public DownloadHandler get_downloadHandler() { }

	public void set_downloadHandler(DownloadHandler value) { }

	private UnityWebRequest.UnityWebRequestError SetCertificateHandler(CertificateHandler ch) { }

	public CertificateHandler get_certificateHandler() { }

	public void set_certificateHandler(CertificateHandler value) { }

	private UnityWebRequest.UnityWebRequestError SetTimeoutMsec(int timeout) { }

	public void set_timeout(int value) { }

	public static UnityWebRequest Get(string uri) { }

	public static UnityWebRequest Post(string uri, WWWForm formData) { }

	private static void SetupPost(UnityWebRequest request, WWWForm formData) { }

	public static string EscapeURL(string s) { }

	public static string EscapeURL(string s, Encoding e) { }

	public static string UnEscapeURL(string s, Encoding e) { }

}

internal enum UnityWebRequest.UnityWebRequestMethod // TypeDefIndex: 4134
{
	public int value__;
	public const UnityWebRequest.UnityWebRequestMethod Get = 0;
	public const UnityWebRequest.UnityWebRequestMethod Post = 1;
	public const UnityWebRequest.UnityWebRequestMethod Put = 2;
	public const UnityWebRequest.UnityWebRequestMethod Head = 3;
	public const UnityWebRequest.UnityWebRequestMethod Custom = 4;

}

internal enum UnityWebRequest.UnityWebRequestError // TypeDefIndex: 4135
{
	public int value__;
	public const UnityWebRequest.UnityWebRequestError OK = 0;
	public const UnityWebRequest.UnityWebRequestError Unknown = 1;
	public const UnityWebRequest.UnityWebRequestError SDKError = 2;
	public const UnityWebRequest.UnityWebRequestError UnsupportedProtocol = 3;
	public const UnityWebRequest.UnityWebRequestError MalformattedUrl = 4;
	public const UnityWebRequest.UnityWebRequestError CannotResolveProxy = 5;
	public const UnityWebRequest.UnityWebRequestError CannotResolveHost = 6;
	public const UnityWebRequest.UnityWebRequestError CannotConnectToHost = 7;
	public const UnityWebRequest.UnityWebRequestError AccessDenied = 8;
	public const UnityWebRequest.UnityWebRequestError GenericHttpError = 9;
	public const UnityWebRequest.UnityWebRequestError WriteError = 10;
	public const UnityWebRequest.UnityWebRequestError ReadError = 11;
	public const UnityWebRequest.UnityWebRequestError OutOfMemory = 12;
	public const UnityWebRequest.UnityWebRequestError Timeout = 13;
	public const UnityWebRequest.UnityWebRequestError HTTPPostError = 14;
	public const UnityWebRequest.UnityWebRequestError SSLCannotConnect = 15;
	public const UnityWebRequest.UnityWebRequestError Aborted = 16;
	public const UnityWebRequest.UnityWebRequestError TooManyRedirects = 17;
	public const UnityWebRequest.UnityWebRequestError ReceivedNoData = 18;
	public const UnityWebRequest.UnityWebRequestError SSLNotSupported = 19;
	public const UnityWebRequest.UnityWebRequestError FailedToSendData = 20;
	public const UnityWebRequest.UnityWebRequestError FailedToReceiveData = 21;
	public const UnityWebRequest.UnityWebRequestError SSLCertificateError = 22;
	public const UnityWebRequest.UnityWebRequestError SSLCipherNotAvailable = 23;
	public const UnityWebRequest.UnityWebRequestError SSLCACertError = 24;
	public const UnityWebRequest.UnityWebRequestError UnrecognizedContentEncoding = 25;
	public const UnityWebRequest.UnityWebRequestError LoginFailed = 26;
	public const UnityWebRequest.UnityWebRequestError SSLShutdownFailed = 27;
	public const UnityWebRequest.UnityWebRequestError NoInternetConnection = 28;

}

