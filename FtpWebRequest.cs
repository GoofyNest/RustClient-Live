public sealed class FtpWebRequest : WebRequest // TypeDefIndex: 3002
{	// Fields
	private Uri requestUri; // 0x38
	private string file_name; // 0x40
	private ServicePoint servicePoint; // 0x48
	private Stream origDataStream; // 0x50
	private Stream dataStream; // 0x58
	private Stream controlStream; // 0x60
	private StreamReader controlReader; // 0x68
	private NetworkCredential credentials; // 0x70
	private IPHostEntry hostEntry; // 0x78
	private IPEndPoint localEndPoint; // 0x80
	private IPEndPoint remoteEndPoint; // 0x88
	private IWebProxy proxy; // 0x90
	private int timeout; // 0x98
	private int rwTimeout; // 0x9C
	private long offset; // 0xA0
	private bool binary; // 0xA8
	private bool enableSsl; // 0xA9
	private bool usePassive; // 0xAA
	private bool keepAlive; // 0xAB
	private string method; // 0xB0
	private string renameTo; // 0xB8
	private object locker; // 0xC0
	private FtpWebRequest.RequestState requestState; // 0xC8
	private FtpAsyncResult asyncResult; // 0xD0
	private FtpWebResponse ftpResponse; // 0xD8
	private Stream requestStream; // 0xE0
	private string initial_path; // 0xE8
	private static readonly string[] supportedCommands; // 0x0
	private Encoding dataEncoding; // 0xF0

	// Properties
	[MonoTODOAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public override string ConnectionGroupName { set; }
	public override string ContentType { get; set; }
	public override long ContentLength { get; set; }
	public override ICredentials Credentials { get; set; }
	public bool EnableSsl { get; }
	[MonoTODOAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public override WebHeaderCollection Headers { get; set; }
	public override string Method { get; set; }
	public override bool PreAuthenticate { set; }
	public override IWebProxy Proxy { get; set; }
	public int ReadWriteTimeout { get; }
	public override Uri RequestUri { get; }
	public ServicePoint ServicePoint { get; }
	[MonoTODOAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public override bool UseDefaultCredentials { get; set; }
	public override int Timeout { get; }
	private string DataType { get; }
	private FtpWebRequest.RequestState State { get; set; }

	// Methods

	// RVA: 0x13324E0 Offset: 0x13318E0 VA: 0x1813324E0
	internal void .ctor(Uri uri) { }

	// RVA: 0x132EAF0 Offset: 0x132DEF0 VA: 0x18132EAF0
	private static Exception GetMustImplement() { }

	// RVA: 0x13328C0 Offset: 0x1331CC0 VA: 0x1813328C0 Slot: 12
	public override void set_ConnectionGroupName(string value) { }

	// RVA: 0x13326A0 Offset: 0x1331AA0 VA: 0x1813326A0 Slot: 17
	public override string get_ContentType() { }

	// RVA: 0x1332920 Offset: 0x1331D20 VA: 0x181332920 Slot: 18
	public override void set_ContentType(string value) { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 15
	public override long get_ContentLength() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 16
	public override void set_ContentLength(long value) { }

	// RVA: 0x58DC30 Offset: 0x58D030 VA: 0x18058DC30 Slot: 19
	public override ICredentials get_Credentials() { }

	// RVA: 0x1332970 Offset: 0x1331D70 VA: 0x181332970 Slot: 20
	public override void set_Credentials(ICredentials value) { }

	// RVA: 0xC1F290 Offset: 0xC1E690 VA: 0x180C1F290
	public bool get_EnableSsl() { }

	// RVA: 0x1332730 Offset: 0x1331B30 VA: 0x181332730 Slot: 13
	public override WebHeaderCollection get_Headers() { }

	// RVA: 0x1332AE0 Offset: 0x1331EE0 VA: 0x181332AE0 Slot: 14
	public override void set_Headers(WebHeaderCollection value) { }

	// RVA: 0x972280 Offset: 0x971680 VA: 0x180972280 Slot: 9
	public override string get_Method() { }

	// RVA: 0x1332B40 Offset: 0x1331F40 VA: 0x181332B40 Slot: 10
	public override void set_Method(string value) { }

	// RVA: 0x1332CB0 Offset: 0x13320B0 VA: 0x181332CB0 Slot: 25
	public override void set_PreAuthenticate(bool value) { }

	// RVA: 0x4E09F0 Offset: 0x4DFDF0 VA: 0x1804E09F0 Slot: 23
	public override IWebProxy get_Proxy() { }

	// RVA: 0x1332D00 Offset: 0x1332100 VA: 0x181332D00 Slot: 24
	public override void set_Proxy(IWebProxy value) { }

	// RVA: 0xB96A10 Offset: 0xB95E10 VA: 0x180B96A10
	public int get_ReadWriteTimeout() { }

	// RVA: 0x5DCC00 Offset: 0x5DC000 VA: 0x1805DCC00 Slot: 11
	public override Uri get_RequestUri() { }

	// RVA: 0x1332790 Offset: 0x1331B90 VA: 0x181332790
	public ServicePoint get_ServicePoint() { }

	// RVA: 0x1332860 Offset: 0x1331C60 VA: 0x181332860 Slot: 21
	public override bool get_UseDefaultCredentials() { }

	// RVA: 0x1332F20 Offset: 0x1332320 VA: 0x181332F20 Slot: 22
	public override void set_UseDefaultCredentials(bool value) { }

	// RVA: 0xB96A00 Offset: 0xB95E00 VA: 0x180B96A00 Slot: 26
	public override int get_Timeout() { }

	// RVA: 0x13326F0 Offset: 0x1331AF0 VA: 0x1813326F0
	private string get_DataType() { }

	// RVA: 0x13327A0 Offset: 0x1331BA0 VA: 0x1813327A0
	private FtpWebRequest.RequestState get_State() { }

	// RVA: 0x1332D90 Offset: 0x1332190 VA: 0x181332D90
	private void set_State(FtpWebRequest.RequestState value) { }

	// RVA: 0x132CCE0 Offset: 0x132C0E0 VA: 0x18132CCE0 Slot: 35
	public override void Abort() { }

	// RVA: 0x132D770 Offset: 0x132CB70 VA: 0x18132D770 Slot: 29
	public override IAsyncResult BeginGetResponse(AsyncCallback callback, object state) { }

	// RVA: 0x132E520 Offset: 0x132D920 VA: 0x18132E520 Slot: 30
	public override WebResponse EndGetResponse(IAsyncResult asyncResult) { }

	// RVA: 0x132F390 Offset: 0x132E790 VA: 0x18132F390 Slot: 28
	public override WebResponse GetResponse() { }

	// RVA: 0x132D4A0 Offset: 0x132C8A0 VA: 0x18132D4A0 Slot: 31
	public override IAsyncResult BeginGetRequestStream(AsyncCallback callback, object state) { }

	// RVA: 0x132E2E0 Offset: 0x132D6E0 VA: 0x18132E2E0 Slot: 32
	public override Stream EndGetRequestStream(IAsyncResult asyncResult) { }

	// RVA: 0x132F150 Offset: 0x132E550 VA: 0x18132F150 Slot: 27
	public override Stream GetRequestStream() { }

	// RVA: 0x132F3D0 Offset: 0x132E7D0 VA: 0x18132F3D0
	private ServicePoint GetServicePoint() { }

	// RVA: 0x1331670 Offset: 0x1330A70 VA: 0x181331670
	private void ResolveHost() { }

	// RVA: 0x1330D40 Offset: 0x1330140 VA: 0x181330D40
	private void ProcessRequest() { }

	// RVA: 0x1331B20 Offset: 0x1330F20 VA: 0x181331B20
	private void SetType() { }

	// RVA: 0x132EFA0 Offset: 0x132E3A0 VA: 0x18132EFA0
	private string GetRemoteFolderPath(Uri uri) { }

	// RVA: 0x132D9F0 Offset: 0x132CDF0 VA: 0x18132D9F0
	private void CWDAndSetFileName(Uri uri) { }

	// RVA: 0x1330420 Offset: 0x132F820 VA: 0x181330420
	private void ProcessMethod() { }

	// RVA: 0x132DFF0 Offset: 0x132D3F0 VA: 0x18132DFF0
	private void CloseControlConnection() { }

	// RVA: 0x132E090 Offset: 0x132D490 VA: 0x18132E090
	internal void CloseDataConnection() { }

	// RVA: 0x132DF20 Offset: 0x132D320 VA: 0x18132DF20
	private void CloseConnection() { }

	// RVA: 0x1331020 Offset: 0x1330420 VA: 0x181331020
	private void ProcessSimpleMethod() { }

	// RVA: 0x1331E40 Offset: 0x1331240 VA: 0x181331E40
	private void UploadData() { }

	// RVA: 0x132E1D0 Offset: 0x132D5D0 VA: 0x18132E1D0
	private void DownloadData() { }

	// RVA: 0x132DEB0 Offset: 0x132D2B0 VA: 0x18132DEB0
	private void CheckRequestStarted() { }

	// RVA: 0x132FB80 Offset: 0x132EF80 VA: 0x18132FB80
	private void OpenControlConnection() { }

	// RVA: 0x132E930 Offset: 0x132DD30 VA: 0x18132E930
	private static string GetInitialPath(FtpStatus status) { }

	// RVA: 0x1331C60 Offset: 0x1331060 VA: 0x181331C60
	private Socket SetupPassiveConnection(string statusDescription, bool ipv6) { }

	// RVA: 0x132EB40 Offset: 0x132DF40 VA: 0x18132EB40
	private int GetPortV4(string responseString) { }

	// RVA: 0x132ED80 Offset: 0x132E180 VA: 0x18132ED80
	private int GetPortV6(string responseString) { }

	// RVA: 0x132E7F0 Offset: 0x132DBF0 VA: 0x18132E7F0
	private string FormatAddress(IPAddress address, int Port) { }

	// RVA: 0x132E6F0 Offset: 0x132DAF0 VA: 0x18132E6F0
	private string FormatAddressV6(IPAddress address, int port) { }

	// RVA: 0x132E0D0 Offset: 0x132D4D0 VA: 0x18132E0D0
	private Exception CreateExceptionFromResponse(FtpStatus status) { }

	// RVA: 0x1331A80 Offset: 0x1330E80 VA: 0x181331A80
	internal void SetTransferCompleted() { }

	// RVA: 0x1330400 Offset: 0x132F800 VA: 0x181330400
	internal void OperationCompleted() { }

	// RVA: 0x1331A50 Offset: 0x1330E50 VA: 0x181331A50
	private void SetCompleteWithError(Exception exc) { }

	// RVA: 0x132F500 Offset: 0x132E900 VA: 0x18132F500
	private Socket InitDataConnection() { }

	// RVA: 0x1330050 Offset: 0x132F450 VA: 0x181330050
	private void OpenDataConnection() { }

	// RVA: 0x132CE80 Offset: 0x132C280 VA: 0x18132CE80
	private void Authenticate() { }

	// RVA: 0x13319B0 Offset: 0x1330DB0 VA: 0x1813319B0
	private FtpStatus SendCommand(string command, string[] parameters) { }

	// RVA: 0x1331810 Offset: 0x1330C10 VA: 0x181331810
	private FtpStatus SendCommand(bool waitResponse, string command, string[] parameters) { }

	// RVA: 0x13319D0 Offset: 0x1330DD0 VA: 0x1813319D0
	internal static FtpStatus ServiceNotAvailable() { }

	// RVA: 0x132F190 Offset: 0x132E590 VA: 0x18132F190
	internal FtpStatus GetResponseStatus() { }

	// RVA: 0x132FA70 Offset: 0x132EE70 VA: 0x18132FA70
	private void InitiateSecureConnection(ref Stream stream) { }

	// RVA: 0x132DBB0 Offset: 0x132CFB0 VA: 0x18132DBB0
	internal bool ChangeToSSLSocket(ref Stream stream) { }

	// RVA: 0x132F460 Offset: 0x132E860 VA: 0x18132F460
	private bool InFinalState() { }

	// RVA: 0x132F4B0 Offset: 0x132E8B0 VA: 0x18132F4B0
	private bool InProgress() { }

	// RVA: 0x132DE40 Offset: 0x132D240 VA: 0x18132DE40
	internal void CheckIfAborted() { }

	// RVA: 0x132DDB0 Offset: 0x132D1B0 VA: 0x18132DDB0
	private void CheckFinalState() { }

	// RVA: 0x1331F60 Offset: 0x1331360 VA: 0x181331F60
	private static void .cctor() { }

}

private enum FtpWebRequest.RequestState // TypeDefIndex: 3003
{	// Fields
	public int value__; // 0x0
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

