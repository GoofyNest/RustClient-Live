public class WebClient : Component // TypeDefIndex: 2953
{	// Fields
	private Uri m_baseAddress; // 0x28
	private ICredentials m_credentials; // 0x30
	private WebHeaderCollection m_headers; // 0x38
	private NameValueCollection m_requestParameters; // 0x40
	private WebResponse m_WebResponse; // 0x48
	private WebRequest m_WebRequest; // 0x50
	private Encoding m_Encoding; // 0x58
	private string m_Method; // 0x60
	private long m_ContentLength; // 0x68
	private bool m_InitWebClientAsync; // 0x70
	private bool m_Cancelled; // 0x71
	private WebClient.ProgressData m_Progress; // 0x78
	private IWebProxy m_Proxy; // 0x80
	private bool m_ProxySet; // 0x88
	private RequestCachePolicy m_CachePolicy; // 0x90
	private int m_CallNesting; // 0x98
	private AsyncOperation m_AsyncOp; // 0xA0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private OpenReadCompletedEventHandler OpenReadCompleted; // 0xA8
	private SendOrPostCallback openReadOperationCompleted; // 0xB0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private OpenWriteCompletedEventHandler OpenWriteCompleted; // 0xB8
	private SendOrPostCallback openWriteOperationCompleted; // 0xC0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private DownloadStringCompletedEventHandler DownloadStringCompleted; // 0xC8
	private SendOrPostCallback downloadStringOperationCompleted; // 0xD0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private DownloadDataCompletedEventHandler DownloadDataCompleted; // 0xD8
	private SendOrPostCallback downloadDataOperationCompleted; // 0xE0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private AsyncCompletedEventHandler DownloadFileCompleted; // 0xE8
	private SendOrPostCallback downloadFileOperationCompleted; // 0xF0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private UploadStringCompletedEventHandler UploadStringCompleted; // 0xF8
	private SendOrPostCallback uploadStringOperationCompleted; // 0x100
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private UploadDataCompletedEventHandler UploadDataCompleted; // 0x108
	private SendOrPostCallback uploadDataOperationCompleted; // 0x110
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private UploadFileCompletedEventHandler UploadFileCompleted; // 0x118
	private SendOrPostCallback uploadFileOperationCompleted; // 0x120
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private UploadValuesCompletedEventHandler UploadValuesCompleted; // 0x128
	private SendOrPostCallback uploadValuesOperationCompleted; // 0x130
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private DownloadProgressChangedEventHandler DownloadProgressChanged; // 0x138
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private UploadProgressChangedEventHandler UploadProgressChanged; // 0x140
	private SendOrPostCallback reportDownloadProgressChanged; // 0x148
	private SendOrPostCallback reportUploadProgressChanged; // 0x150

	// Properties
	public Encoding Encoding { get; set; }
	public ICredentials Credentials { get; }

	// Methods

	// RVA: 0x1010010 Offset: 0x100F410 VA: 0x181010010
	public void .ctor() { }

	// RVA: 0x100D8B0 Offset: 0x100CCB0 VA: 0x18100D8B0
	private void InitWebClientAsync() { }

	// RVA: 0x100AF60 Offset: 0x100A360 VA: 0x18100AF60
	private void ClearWebClientState() { }

	// RVA: 0x100B040 Offset: 0x100A440 VA: 0x18100B040
	private void CompleteWebClientState() { }

	// RVA: 0x4CC340 Offset: 0x4CB740 VA: 0x1804CC340
	public Encoding get_Encoding() { }

	// RVA: 0x1010390 Offset: 0x100F790 VA: 0x181010390
	public void set_Encoding(Encoding value) { }

	// RVA: 0x4A2EE0 Offset: 0x4A22E0 VA: 0x1804A2EE0
	public ICredentials get_Credentials() { }

	// RVA: 0x100D6C0 Offset: 0x100CAC0 VA: 0x18100D6C0 Slot: 12
	protected virtual WebRequest GetWebRequest(Uri address) { }

	// RVA: 0x100D860 Offset: 0x100CC60 VA: 0x18100D860 Slot: 13
	protected virtual WebResponse GetWebResponse(WebRequest request) { }

	// RVA: 0x100D800 Offset: 0x100CC00 VA: 0x18100D800 Slot: 14
	protected virtual WebResponse GetWebResponse(WebRequest request, IAsyncResult result) { }

	// RVA: 0x100C010 Offset: 0x100B410 VA: 0x18100C010
	private byte[] DownloadDataInternal(Uri address, out WebRequest request) { }

	// RVA: 0x100F780 Offset: 0x100EB80 VA: 0x18100F780
	private byte[] UploadValuesInternal(NameValueCollection data) { }

	// RVA: 0x100C9C0 Offset: 0x100BDC0 VA: 0x18100C9C0
	public string DownloadString(string address) { }

	// RVA: 0x100C860 Offset: 0x100BC60 VA: 0x18100C860
	public string DownloadString(Uri address) { }

	// RVA: 0x100ADF0 Offset: 0x100A1F0 VA: 0x18100ADF0
	private static void AbortRequest(WebRequest request) { }

	// RVA: 0x100B050 Offset: 0x100A450 VA: 0x18100B050
	private void CopyHeadersTo(WebRequest request) { }

	// RVA: 0x100CF50 Offset: 0x100C350 VA: 0x18100CF50
	private Uri GetUri(string path) { }

	// RVA: 0x100D390 Offset: 0x100C790 VA: 0x18100D390
	private Uri GetUri(Uri address) { }

	// RVA: 0x100BB50 Offset: 0x100AF50 VA: 0x18100BB50
	private static void DownloadBitsResponseCallback(IAsyncResult result) { }

	// RVA: 0x100BAA0 Offset: 0x100AEA0 VA: 0x18100BAA0
	private static void DownloadBitsReadCallback(IAsyncResult result) { }

	// RVA: 0x100B770 Offset: 0x100AB70 VA: 0x18100B770
	private static void DownloadBitsReadCallbackState(WebClient.DownloadBitsState state, IAsyncResult result) { }

	// RVA: 0x100BEA0 Offset: 0x100B2A0 VA: 0x18100BEA0
	private byte[] DownloadBits(WebRequest request, Stream writeStream, CompletionDelegate completionDelegate, AsyncOperation asyncOp) { }

	// RVA: 0x100E530 Offset: 0x100D930 VA: 0x18100E530
	private static void UploadBitsRequestCallback(IAsyncResult result) { }

	// RVA: 0x100E850 Offset: 0x100DC50 VA: 0x18100E850
	private static void UploadBitsWriteCallback(IAsyncResult result) { }

	// RVA: 0x100EB90 Offset: 0x100DF90 VA: 0x18100EB90
	private void UploadBits(WebRequest request, Stream readStream, byte[] buffer, int chunkSize, byte[] header, byte[] footer, CompletionDelegate uploadCompletionDelegate, CompletionDelegate downloadCompletionDelegate, AsyncOperation asyncOp) { }

	// RVA: 0x100AEE0 Offset: 0x100A2E0 VA: 0x18100AEE0
	private bool ByteArrayHasPrefix(byte[] prefix, byte[] byteArray) { }

	// RVA: 0x100CA50 Offset: 0x100BE50 VA: 0x18100CA50
	private string GetStringUsingEncoding(WebRequest request, byte[] data) { }

	// RVA: 0x100DC70 Offset: 0x100D070 VA: 0x18100DC70
	private string MapToDefaultMethod(Uri address) { }

	// RVA: 0x100FF60 Offset: 0x100F360 VA: 0x18100FF60
	private static string UrlEncode(string str) { }

	// RVA: 0x100FEC0 Offset: 0x100F2C0 VA: 0x18100FEC0
	private static string UrlEncode(string str, Encoding e) { }

	// RVA: 0x100FE60 Offset: 0x100F260 VA: 0x18100FE60
	private static byte[] UrlEncodeToBytes(string str, Encoding e) { }

	// RVA: 0x100FBB0 Offset: 0x100EFB0 VA: 0x18100FBB0
	private static byte[] UrlEncodeBytesToBytesInternal(byte[] bytes, int offset, int count, bool alwaysCreateReturnValue) { }

	// RVA: 0x100DB70 Offset: 0x100CF70 VA: 0x18100DB70
	private static char IntToHex(int n) { }

	// RVA: 0x100DC00 Offset: 0x100D000 VA: 0x18100DC00
	private static bool IsSafe(char ch) { }

	// RVA: 0x100DB80 Offset: 0x100CF80 VA: 0x18100DB80
	private void InvokeOperationCompleted(AsyncOperation asyncOp, SendOrPostCallback callback, AsyncCompletedEventArgs eventArgs) { }

	// RVA: 0x100AED0 Offset: 0x100A2D0 VA: 0x18100AED0
	private bool AnotherCallInProgress(int callNesting) { }

	// RVA: 0xAEA310 Offset: 0xAE9710 VA: 0x180AEA310 Slot: 15
	protected virtual void OnOpenReadCompleted(OpenReadCompletedEventArgs e) { }

	// RVA: 0x100DEE0 Offset: 0x100D2E0 VA: 0x18100DEE0
	private void OpenReadOperationCompleted(object arg) { }

	// RVA: 0x100DE20 Offset: 0x100D220 VA: 0x18100DE20 Slot: 16
	protected virtual void OnOpenWriteCompleted(OpenWriteCompletedEventArgs e) { }

	// RVA: 0x100DF80 Offset: 0x100D380 VA: 0x18100DF80
	private void OpenWriteOperationCompleted(object arg) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1010110 Offset: 0x100F510 VA: 0x181010110
	public void add_DownloadStringCompleted(DownloadStringCompletedEventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1010250 Offset: 0x100F650 VA: 0x181010250
	public void remove_DownloadStringCompleted(DownloadStringCompletedEventHandler value) { }

	// RVA: 0x100DE00 Offset: 0x100D200 VA: 0x18100DE00 Slot: 17
	protected virtual void OnDownloadStringCompleted(DownloadStringCompletedEventArgs e) { }

	// RVA: 0x100C7C0 Offset: 0x100BBC0 VA: 0x18100C7C0
	private void DownloadStringOperationCompleted(object arg) { }

	// RVA: 0x100C320 Offset: 0x100B720 VA: 0x18100C320
	private void DownloadStringAsyncCallback(byte[] returnBytes, Exception exception, object state) { }

	// RVA: 0x100C4F0 Offset: 0x100B8F0 VA: 0x18100C4F0
	public void DownloadStringAsync(Uri address) { }

	// RVA: 0x100C500 Offset: 0x100B900 VA: 0x18100C500
	public void DownloadStringAsync(Uri address, object userToken) { }

	// RVA: 0x100DDA0 Offset: 0x100D1A0 VA: 0x18100DDA0 Slot: 18
	protected virtual void OnDownloadDataCompleted(DownloadDataCompletedEventArgs e) { }

	// RVA: 0x100C1E0 Offset: 0x100B5E0 VA: 0x18100C1E0
	private void DownloadDataOperationCompleted(object arg) { }

	// RVA: 0x100DDC0 Offset: 0x100D1C0 VA: 0x18100DDC0 Slot: 19
	protected virtual void OnDownloadFileCompleted(AsyncCompletedEventArgs e) { }

	// RVA: 0x100C280 Offset: 0x100B680 VA: 0x18100C280
	private void DownloadFileOperationCompleted(object arg) { }

	// RVA: 0x100DEA0 Offset: 0x100D2A0 VA: 0x18100DEA0 Slot: 20
	protected virtual void OnUploadStringCompleted(UploadStringCompletedEventArgs e) { }

	// RVA: 0x100EEE0 Offset: 0x100E2E0 VA: 0x18100EEE0
	private void UploadStringOperationCompleted(object arg) { }

	// RVA: 0x100E340 Offset: 0x100D740 VA: 0x18100E340
	private void StartDownloadAsync(WebClient.UploadBitsState state) { }

	// RVA: 0x100DE40 Offset: 0x100D240 VA: 0x18100DE40 Slot: 21
	protected virtual void OnUploadDataCompleted(UploadDataCompletedEventArgs e) { }

	// RVA: 0x100EDA0 Offset: 0x100E1A0 VA: 0x18100EDA0
	private void UploadDataOperationCompleted(object arg) { }

	// RVA: 0x100DE60 Offset: 0x100D260 VA: 0x18100DE60 Slot: 22
	protected virtual void OnUploadFileCompleted(UploadFileCompletedEventArgs e) { }

	// RVA: 0x100EE40 Offset: 0x100E240 VA: 0x18100EE40
	private void UploadFileOperationCompleted(object arg) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x10101B0 Offset: 0x100F5B0 VA: 0x1810101B0
	public void add_UploadValuesCompleted(UploadValuesCompletedEventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x10102F0 Offset: 0x100F6F0 VA: 0x1810102F0
	public void remove_UploadValuesCompleted(UploadValuesCompletedEventHandler value) { }

	// RVA: 0x100DEC0 Offset: 0x100D2C0 VA: 0x18100DEC0 Slot: 23
	protected virtual void OnUploadValuesCompleted(UploadValuesCompletedEventArgs e) { }

	// RVA: 0x100FB10 Offset: 0x100EF10 VA: 0x18100FB10
	private void UploadValuesOperationCompleted(object arg) { }

	// RVA: 0x100F0A0 Offset: 0x100E4A0 VA: 0x18100F0A0
	private void UploadValuesAsyncWriteCallback(byte[] returnBytes, Exception exception, object state) { }

	// RVA: 0x100EF80 Offset: 0x100E380 VA: 0x18100EF80
	private void UploadValuesAsyncReadCallback(byte[] returnBytes, Exception exception, object state) { }

	// RVA: 0x100F210 Offset: 0x100E610 VA: 0x18100F210
	public void UploadValuesAsync(Uri address, string method, NameValueCollection data) { }

	// RVA: 0x100F230 Offset: 0x100E630 VA: 0x18100F230
	public void UploadValuesAsync(Uri address, string method, NameValueCollection data, object userToken) { }

	// RVA: 0x100DDE0 Offset: 0x100D1E0 VA: 0x18100DDE0 Slot: 24
	protected virtual void OnDownloadProgressChanged(DownloadProgressChangedEventArgs e) { }

	// RVA: 0x100DE80 Offset: 0x100D280 VA: 0x18100DE80 Slot: 25
	protected virtual void OnUploadProgressChanged(UploadProgressChangedEventArgs e) { }

	// RVA: 0x100E200 Offset: 0x100D600 VA: 0x18100E200
	private void ReportDownloadProgressChanged(object arg) { }

	// RVA: 0x100E2A0 Offset: 0x100D6A0 VA: 0x18100E2A0
	private void ReportUploadProgressChanged(object arg) { }

	// RVA: 0x100E020 Offset: 0x100D420 VA: 0x18100E020
	private void PostProgressChanged(AsyncOperation asyncOp, WebClient.ProgressData progress) { }

}

private class WebClient.ProgressData // TypeDefIndex: 2954
{	// Fields
	internal long BytesSent; // 0x10
	internal long TotalBytesToSend; // 0x18
	internal long BytesReceived; // 0x20
	internal long TotalBytesToReceive; // 0x28
	internal bool HasUploadPhase; // 0x30

	// Methods

	// RVA: 0x11773C0 Offset: 0x11767C0 VA: 0x1811773C0
	internal void Reset() { }

	// RVA: 0x11773E0 Offset: 0x11767E0 VA: 0x1811773E0
	public void .ctor() { }

}

private class WebClient.DownloadBitsState // TypeDefIndex: 2955
{	// Fields
	internal WebClient WebClient; // 0x10
	internal Stream WriteStream; // 0x18
	internal byte[] InnerBuffer; // 0x20
	internal AsyncOperation AsyncOp; // 0x28
	internal WebRequest Request; // 0x30
	internal CompletionDelegate CompletionDelegate; // 0x38
	internal Stream ReadStream; // 0x40
	internal ScatterGatherBuffers SgBuffers; // 0x48
	internal long ContentLength; // 0x50
	internal long Length; // 0x58
	internal WebClient.ProgressData Progress; // 0x60

	// Properties
	internal bool Async { get; }

	// Methods

	// RVA: 0x1176950 Offset: 0x1175D50 VA: 0x181176950
	internal void .ctor(WebRequest request, Stream writeStream, CompletionDelegate completionDelegate, AsyncOperation asyncOp, WebClient.ProgressData progress, WebClient webClient) { }

	// RVA: 0x11769F0 Offset: 0x1175DF0 VA: 0x1811769F0
	internal bool get_Async() { }

	// RVA: 0x1176670 Offset: 0x1175A70 VA: 0x181176670
	internal int SetResponse(WebResponse response) { }

	// RVA: 0x11763A0 Offset: 0x11757A0 VA: 0x1811763A0
	internal bool RetrieveBytes(ref int bytesRetrieved) { }

	// RVA: 0x1176350 Offset: 0x1175750 VA: 0x181176350
	internal void Close() { }

}

private class WebClient.UploadBitsState // TypeDefIndex: 2956
{	// Fields
	private int m_ChunkSize; // 0x10
	private int m_BufferWritePosition; // 0x14
	internal WebClient WebClient; // 0x18
	internal Stream WriteStream; // 0x20
	internal byte[] InnerBuffer; // 0x28
	internal byte[] Header; // 0x30
	internal byte[] Footer; // 0x38
	internal AsyncOperation AsyncOp; // 0x40
	internal WebRequest Request; // 0x48
	internal CompletionDelegate UploadCompletionDelegate; // 0x50
	internal CompletionDelegate DownloadCompletionDelegate; // 0x58
	internal Stream ReadStream; // 0x60
	internal WebClient.ProgressData Progress; // 0x68

	// Properties
	internal bool FileUpload { get; }
	internal bool Async { get; }

	// Methods

	// RVA: 0x1179280 Offset: 0x1178680 VA: 0x181179280
	internal void .ctor(WebRequest request, Stream readStream, byte[] buffer, int chunkSize, byte[] header, byte[] footer, CompletionDelegate uploadCompletionDelegate, CompletionDelegate downloadCompletionDelegate, AsyncOperation asyncOp, WebClient.ProgressData progress, WebClient webClient) { }

	// RVA: 0x11793F0 Offset: 0x11787F0 VA: 0x1811793F0
	internal bool get_FileUpload() { }

	// RVA: 0x11793E0 Offset: 0x11787E0 VA: 0x1811793E0
	internal bool get_Async() { }

	// RVA: 0x1178F40 Offset: 0x1178340 VA: 0x181178F40
	internal void SetRequestStream(Stream writeStream) { }

	// RVA: 0x1179080 Offset: 0x1178480 VA: 0x181179080
	internal bool WriteBytes() { }

	// RVA: 0x1178EF0 Offset: 0x11782F0 VA: 0x181178EF0
	internal void Close() { }

}

