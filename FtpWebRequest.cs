public sealed class FtpWebRequest : WebRequest // TypeDefIndex: 3002
{
	private Uri requestUri;
	private string file_name;
	private ServicePoint servicePoint;
	private Stream origDataStream;
	private Stream dataStream;
	private Stream controlStream;
	private StreamReader controlReader;
	private NetworkCredential credentials;
	private IPHostEntry hostEntry;
	private IPEndPoint localEndPoint;
	private IPEndPoint remoteEndPoint;
	private IWebProxy proxy;
	private int timeout;
	private int rwTimeout;
	private long offset;
	private bool binary;
	private bool enableSsl;
	private bool usePassive;
	private bool keepAlive;
	private string method;
	private string renameTo;
	private object locker;
	private FtpWebRequest.RequestState requestState;
	private FtpAsyncResult asyncResult;
	private FtpWebResponse ftpResponse;
	private Stream requestStream;
	private string initial_path;
	private static readonly string[] supportedCommands;
	private Encoding dataEncoding;

	[MonoTODOAttribute]
	public override string ConnectionGroupName { set; }
	public override string ContentType { get; set; }
	public override long ContentLength { get; set; }
	public override ICredentials Credentials { get; set; }
	public bool EnableSsl { get; }
	[MonoTODOAttribute]
	public override WebHeaderCollection Headers { get; set; }
	public override string Method { get; set; }
	public override bool PreAuthenticate { set; }
	public override IWebProxy Proxy { get; set; }
	public int ReadWriteTimeout { get; }
	public override Uri RequestUri { get; }
	public ServicePoint ServicePoint { get; }
	[MonoTODOAttribute]
	public override bool UseDefaultCredentials { get; set; }
	public override int Timeout { get; }
	private string DataType { get; }
	private FtpWebRequest.RequestState State { get; set; }


	internal void .ctor(Uri uri) { }

	private static Exception GetMustImplement() { }

	public override void set_ConnectionGroupName(string value) { }

	public override string get_ContentType() { }

	public override void set_ContentType(string value) { }

	public override long get_ContentLength() { }

	public override void set_ContentLength(long value) { }

	public override ICredentials get_Credentials() { }

	public override void set_Credentials(ICredentials value) { }

	public bool get_EnableSsl() { }

	public override WebHeaderCollection get_Headers() { }

	public override void set_Headers(WebHeaderCollection value) { }

	public override string get_Method() { }

	public override void set_Method(string value) { }

	public override void set_PreAuthenticate(bool value) { }

	public override IWebProxy get_Proxy() { }

	public override void set_Proxy(IWebProxy value) { }

	public int get_ReadWriteTimeout() { }

	public override Uri get_RequestUri() { }

	public ServicePoint get_ServicePoint() { }

	public override bool get_UseDefaultCredentials() { }

	public override void set_UseDefaultCredentials(bool value) { }

	public override int get_Timeout() { }

	private string get_DataType() { }

	private FtpWebRequest.RequestState get_State() { }

	private void set_State(FtpWebRequest.RequestState value) { }

	public override void Abort() { }

	public override IAsyncResult BeginGetResponse(AsyncCallback callback, object state) { }

	public override WebResponse EndGetResponse(IAsyncResult asyncResult) { }

	public override WebResponse GetResponse() { }

	public override IAsyncResult BeginGetRequestStream(AsyncCallback callback, object state) { }

	public override Stream EndGetRequestStream(IAsyncResult asyncResult) { }

	public override Stream GetRequestStream() { }

	private ServicePoint GetServicePoint() { }

	private void ResolveHost() { }

	private void ProcessRequest() { }

	private void SetType() { }

	private string GetRemoteFolderPath(Uri uri) { }

	private void CWDAndSetFileName(Uri uri) { }

	private void ProcessMethod() { }

	private void CloseControlConnection() { }

	internal void CloseDataConnection() { }

	private void CloseConnection() { }

	private void ProcessSimpleMethod() { }

	private void UploadData() { }

	private void DownloadData() { }

	private void CheckRequestStarted() { }

	private void OpenControlConnection() { }

	private static string GetInitialPath(FtpStatus status) { }

	private Socket SetupPassiveConnection(string statusDescription, bool ipv6) { }

	private int GetPortV4(string responseString) { }

	private int GetPortV6(string responseString) { }

	private string FormatAddress(IPAddress address, int Port) { }

	private string FormatAddressV6(IPAddress address, int port) { }

	private Exception CreateExceptionFromResponse(FtpStatus status) { }

	internal void SetTransferCompleted() { }

	internal void OperationCompleted() { }

	private void SetCompleteWithError(Exception exc) { }

	private Socket InitDataConnection() { }

	private void OpenDataConnection() { }

	private void Authenticate() { }

	private FtpStatus SendCommand(string command, string[] parameters) { }

	private FtpStatus SendCommand(bool waitResponse, string command, string[] parameters) { }

	internal static FtpStatus ServiceNotAvailable() { }

	internal FtpStatus GetResponseStatus() { }

	private void InitiateSecureConnection(ref Stream stream) { }

	internal bool ChangeToSSLSocket(ref Stream stream) { }

	private bool InFinalState() { }

	private bool InProgress() { }

	internal void CheckIfAborted() { }

	private void CheckFinalState() { }

	private static void .cctor() { }

}

private enum FtpWebRequest.RequestState // TypeDefIndex: 3003
{
	public int value__;
	public const FtpWebRequest.RequestState Before = 0;
	public const FtpWebRequest.RequestState Scheduled = 1;
	public const FtpWebRequest.RequestState Connecting = 2;
	public const FtpWebRequest.RequestState Authenticating = 3;
	public const FtpWebRequest.RequestState OpeningData = 4;
	public const FtpWebRequest.RequestState TransferInProgress = 5;
	public const FtpWebRequest.RequestState Finished = 6;
	public const FtpWebRequest.RequestState Aborted = 7;
	public const FtpWebRequest.RequestState Error = 8;

}

