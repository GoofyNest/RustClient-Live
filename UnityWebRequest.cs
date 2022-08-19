public class UnityWebRequest : IDisposable // TypeDefIndex: 4128
{	// Fields
	internal IntPtr m_Ptr; // 0x10
	internal DownloadHandler m_DownloadHandler; // 0x18
	internal UploadHandler m_UploadHandler; // 0x20
	internal CertificateHandler m_CertificateHandler; // 0x28
	internal Uri m_Uri; // 0x30
	public const string kHttpVerbGET = "GET";
	public const string kHttpVerbHEAD = "HEAD";
	public const string kHttpVerbPOST = "POST";
	public const string kHttpVerbPUT = "PUT";
	public const string kHttpVerbCREATE = "CREATE";
	public const string kHttpVerbDELETE = "DELETE";
	[CompilerGeneratedAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	[DebuggerBrowsableAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	private bool <disposeCertificateHandlerOnDispose>k__BackingField; // 0x38
	[DebuggerBrowsableAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	[CompilerGeneratedAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	private bool <disposeDownloadHandlerOnDispose>k__BackingField; // 0x39
	[DebuggerBrowsableAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	[CompilerGeneratedAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	private bool <disposeUploadHandlerOnDispose>k__BackingField; // 0x3A

	// Properties
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
	[ObsoleteAttribute] // RVA: 0x91050 Offset: 0x90450 VA: 0x180091050
	public bool chunkedTransfer { set; }
	public UploadHandler uploadHandler { get; set; }
	public DownloadHandler downloadHandler { get; set; }
	public CertificateHandler certificateHandler { get; set; }
	public int timeout { set; }

	// Methods

	[NativeMethodAttribute] // RVA: 0x8FB50 Offset: 0x8EF50 VA: 0x18008FB50
	[NativeConditionalAttribute] // RVA: 0x8FB50 Offset: 0x8EF50 VA: 0x18008FB50
	// RVA: 0x229AA60 Offset: 0x2299E60 VA: 0x18229AA60
	private static string GetWebErrorString(UnityWebRequest.UnityWebRequestError err) { }

	[VisibleToOtherModulesAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x229A9E0 Offset: 0x2299DE0 VA: 0x18229A9E0
	internal static string GetHTTPStatusString(long responseCode) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x8B1120 Offset: 0x8B0520 VA: 0x1808B1120
	public bool get_disposeCertificateHandlerOnDispose() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x78BED0 Offset: 0x78B2D0 VA: 0x18078BED0
	public void set_disposeCertificateHandlerOnDispose(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x8B1130 Offset: 0x8B0530 VA: 0x1808B1130
	public bool get_disposeDownloadHandlerOnDispose() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x8B1140 Offset: 0x8B0540 VA: 0x1808B1140
	public void set_disposeDownloadHandlerOnDispose(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x115AFB0 Offset: 0x115A3B0 VA: 0x18115AFB0
	public bool get_disposeUploadHandlerOnDispose() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x115B3C0 Offset: 0x115A7C0 VA: 0x18115B3C0
	public void set_disposeUploadHandlerOnDispose(bool value) { }

	// RVA: 0x229A4C0 Offset: 0x22998C0 VA: 0x18229A4C0
	internal static IntPtr Create() { }

	[NativeMethodAttribute] // RVA: 0x90400 Offset: 0x8F800 VA: 0x180090400
	// RVA: 0x229B0D0 Offset: 0x229A4D0 VA: 0x18229B0D0
	private void Release() { }

	// RVA: 0x229ABC0 Offset: 0x2299FC0 VA: 0x18229ABC0
	internal void InternalDestroy() { }

	// RVA: 0x229AD50 Offset: 0x229A150 VA: 0x18229AD50
	private void InternalSetDefaults() { }

	// RVA: 0x229BC00 Offset: 0x229B000 VA: 0x18229BC00
	public void .ctor(string url) { }

	// RVA: 0x229BB80 Offset: 0x229AF80 VA: 0x18229BB80
	public void .ctor(string url, string method) { }

	// RVA: 0x229BAD0 Offset: 0x229AED0 VA: 0x18229BAD0
	public void .ctor(string url, string method, DownloadHandler downloadHandler, UploadHandler uploadHandler) { }

	// RVA: 0x229A890 Offset: 0x2299C90 VA: 0x18229A890 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x229A550 Offset: 0x2299950 VA: 0x18229A550 Slot: 4
	public void Dispose() { }

	// RVA: 0x229A4F0 Offset: 0x22998F0 VA: 0x18229A4F0
	private void DisposeHandlers() { }

	[NativeThrowsAttribute] // RVA: 0x80970 Offset: 0x7FD70 VA: 0x180080970
	// RVA: 0x229A480 Offset: 0x2299880 VA: 0x18229A480
	internal UnityWebRequestAsyncOperation BeginWebRequest() { }

	[ObsoleteAttribute] // RVA: 0x905F0 Offset: 0x8F9F0 VA: 0x1800905F0
	// RVA: 0x229B110 Offset: 0x229A510 VA: 0x18229B110
	public AsyncOperation Send() { }

	// RVA: 0x229B110 Offset: 0x229A510 VA: 0x18229B110
	public UnityWebRequestAsyncOperation SendWebRequest() { }

	[NativeMethodAttribute] // RVA: 0x90400 Offset: 0x8F800 VA: 0x180090400
	// RVA: 0x229A440 Offset: 0x2299840 VA: 0x18229A440
	public void Abort() { }

	// RVA: 0x229B2B0 Offset: 0x229A6B0 VA: 0x18229B2B0
	private UnityWebRequest.UnityWebRequestError SetMethod(UnityWebRequest.UnityWebRequestMethod methodType) { }

	// RVA: 0x229AD60 Offset: 0x229A160 VA: 0x18229AD60
	internal void InternalSetMethod(UnityWebRequest.UnityWebRequestMethod methodType) { }

	// RVA: 0x229B210 Offset: 0x229A610 VA: 0x18229B210
	private UnityWebRequest.UnityWebRequestError SetCustomMethod(string customMethodName) { }

	// RVA: 0x229AC50 Offset: 0x229A050 VA: 0x18229AC50
	internal void InternalSetCustomMethod(string customMethodName) { }

	// RVA: 0x229C300 Offset: 0x229B700 VA: 0x18229C300
	public void set_method(string value) { }

	// RVA: 0x229A9A0 Offset: 0x2299DA0 VA: 0x18229A9A0
	private UnityWebRequest.UnityWebRequestError GetError() { }

	// RVA: 0x229BD00 Offset: 0x229B100 VA: 0x18229BD00
	public string get_error() { }

	// RVA: 0x229AA20 Offset: 0x2299E20 VA: 0x18229AA20
	public string get_url() { }

	// RVA: 0x229C750 Offset: 0x229BB50 VA: 0x18229C750
	public void set_url(string value) { }

	// RVA: 0x229AA20 Offset: 0x2299E20 VA: 0x18229AA20
	private string GetUrl() { }

	// RVA: 0x229B500 Offset: 0x229A900 VA: 0x18229B500
	private UnityWebRequest.UnityWebRequestError SetUrl(string url) { }

	// RVA: 0x229AEC0 Offset: 0x229A2C0 VA: 0x18229AEC0
	private void InternalSetUrl(string url) { }

	// RVA: 0x229BFA0 Offset: 0x229B3A0 VA: 0x18229BFA0
	public long get_responseCode() { }

	// RVA: 0x229AFC0 Offset: 0x229A3C0 VA: 0x18229AFC0
	private bool IsExecuting() { }

	[NativeMethodAttribute] // RVA: 0x90820 Offset: 0x8FC20 VA: 0x180090820
	// RVA: 0x229BF20 Offset: 0x229B320 VA: 0x18229BF20
	public bool get_isModifiable() { }

	[NativeMethodAttribute] // RVA: 0x90A30 Offset: 0x8FE30 VA: 0x180090A30
	// RVA: 0x229BEA0 Offset: 0x229B2A0 VA: 0x18229BEA0
	public bool get_isDone() { }

	[NativeMethodAttribute] // RVA: 0x90B10 Offset: 0x8FF10 VA: 0x180090B10
	// RVA: 0x229BF60 Offset: 0x229B360 VA: 0x18229BF60
	public bool get_isNetworkError() { }

	[NativeMethodAttribute] // RVA: 0x90D10 Offset: 0x90110 VA: 0x180090D10
	// RVA: 0x229BEE0 Offset: 0x229B2E0 VA: 0x18229BEE0
	public bool get_isHttpError() { }

	// RVA: 0x229A960 Offset: 0x2299D60 VA: 0x18229A960
	private float GetDownloadProgress() { }

	// RVA: 0x229BC60 Offset: 0x229B060 VA: 0x18229BC60
	public float get_downloadProgress() { }

	// RVA: 0x229B1C0 Offset: 0x229A5C0 VA: 0x18229B1C0
	private UnityWebRequest.UnityWebRequestError SetChunked(bool chunked) { }

	// RVA: 0x229C0F0 Offset: 0x229B4F0 VA: 0x18229C0F0
	public void set_chunkedTransfer(bool value) { }

	[NativeMethodAttribute] // RVA: 0x90E60 Offset: 0x90260 VA: 0x180090E60
	// RVA: 0x229AE60 Offset: 0x229A260 VA: 0x18229AE60
	internal UnityWebRequest.UnityWebRequestError InternalSetRequestHeader(string name, string value) { }

	// RVA: 0x229B2F0 Offset: 0x229A6F0 VA: 0x18229B2F0
	public void SetRequestHeader(string name, string value) { }

	// RVA: 0x229B4B0 Offset: 0x229A8B0 VA: 0x18229B4B0
	private UnityWebRequest.UnityWebRequestError SetUploadHandler(UploadHandler uh) { }

	// RVA: 0x1A5DBD0 Offset: 0x1A5CFD0 VA: 0x181A5DBD0
	public UploadHandler get_uploadHandler() { }

	// RVA: 0x229C640 Offset: 0x229BA40 VA: 0x18229C640
	public void set_uploadHandler(UploadHandler value) { }

	// RVA: 0x229B260 Offset: 0x229A660 VA: 0x18229B260
	private UnityWebRequest.UnityWebRequestError SetDownloadHandler(DownloadHandler dh) { }

	// RVA: 0x1818770 Offset: 0x1817B70 VA: 0x181818770
	public DownloadHandler get_downloadHandler() { }

	// RVA: 0x229C1F0 Offset: 0x229B5F0 VA: 0x18229C1F0
	public void set_downloadHandler(DownloadHandler value) { }

	// RVA: 0x229B170 Offset: 0x229A570 VA: 0x18229B170
	private UnityWebRequest.UnityWebRequestError SetCertificateHandler(CertificateHandler ch) { }

	// RVA: 0x1818760 Offset: 0x1817B60 VA: 0x181818760
	public CertificateHandler get_certificateHandler() { }

	// RVA: 0x229BFE0 Offset: 0x229B3E0 VA: 0x18229BFE0
	public void set_certificateHandler(CertificateHandler value) { }

	// RVA: 0x229B470 Offset: 0x229A870 VA: 0x18229B470
	private UnityWebRequest.UnityWebRequestError SetTimeoutMsec(int timeout) { }

	// RVA: 0x229C510 Offset: 0x229B910 VA: 0x18229C510
	public void set_timeout(int value) { }

	// RVA: 0x229AAA0 Offset: 0x2299EA0 VA: 0x18229AAA0
	public static UnityWebRequest Get(string uri) { }

	// RVA: 0x229B000 Offset: 0x229A400 VA: 0x18229B000
	public static UnityWebRequest Post(string uri, WWWForm formData) { }

	// RVA: 0x229B550 Offset: 0x229A950 VA: 0x18229B550
	private static void SetupPost(UnityWebRequest request, WWWForm formData) { }

	// RVA: 0x229A740 Offset: 0x2299B40 VA: 0x18229A740
	public static string EscapeURL(string s) { }

	// RVA: 0x229A5F0 Offset: 0x22999F0 VA: 0x18229A5F0
	public static string EscapeURL(string s, Encoding e) { }

	// RVA: 0x229B9F0 Offset: 0x229ADF0 VA: 0x18229B9F0
	public static string UnEscapeURL(string s, Encoding e) { }

}

internal enum UnityWebRequest.UnityWebRequestMethod // TypeDefIndex: 4129
{	// Fields
	public int value__; // 0x0
	public const UnityWebRequest.UnityWebRequestMethod Get = 0;
	public const UnityWebRequest.UnityWebRequestMethod Post = 1;
	public const UnityWebRequest.UnityWebRequestMethod Put = 2;
	public const UnityWebRequest.UnityWebRequestMethod Head = 3;
	public const UnityWebRequest.UnityWebRequestMethod Custom = 4;

}

internal enum UnityWebRequest.UnityWebRequestError // TypeDefIndex: 4130
{	// Fields
	public int value__; // 0x0
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

