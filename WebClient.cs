public class WebClient : Component // TypeDefIndex: 2953
{	private Uri m_baseAddress; // 0x28
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

	public Encoding Encoding { get; set; }
	public ICredentials Credentials { get; }


	public void .ctor() { }

	private void InitWebClientAsync() { }

	private void ClearWebClientState() { }

	private void CompleteWebClientState() { }

	public Encoding get_Encoding() { }

	public void set_Encoding(Encoding value) { }

	public ICredentials get_Credentials() { }

	protected virtual WebRequest GetWebRequest(Uri address) { }

	protected virtual WebResponse GetWebResponse(WebRequest request) { }

	protected virtual WebResponse GetWebResponse(WebRequest request, IAsyncResult result) { }

	private byte[] DownloadDataInternal(Uri address, out WebRequest request) { }

	private byte[] UploadValuesInternal(NameValueCollection data) { }

	public string DownloadString(string address) { }

	public string DownloadString(Uri address) { }

	private static void AbortRequest(WebRequest request) { }

	private void CopyHeadersTo(WebRequest request) { }

	private Uri GetUri(string path) { }

	private Uri GetUri(Uri address) { }

	private static void DownloadBitsResponseCallback(IAsyncResult result) { }

	private static void DownloadBitsReadCallback(IAsyncResult result) { }

	private static void DownloadBitsReadCallbackState(WebClient.DownloadBitsState state, IAsyncResult result) { }

	private byte[] DownloadBits(WebRequest request, Stream writeStream, CompletionDelegate completionDelegate, AsyncOperation asyncOp) { }

	private static void UploadBitsRequestCallback(IAsyncResult result) { }

	private static void UploadBitsWriteCallback(IAsyncResult result) { }

	private void UploadBits(WebRequest request, Stream readStream, byte[] buffer, int chunkSize, byte[] header, byte[] footer, CompletionDelegate uploadCompletionDelegate, CompletionDelegate downloadCompletionDelegate, AsyncOperation asyncOp) { }

	private bool ByteArrayHasPrefix(byte[] prefix, byte[] byteArray) { }

	private string GetStringUsingEncoding(WebRequest request, byte[] data) { }

	private string MapToDefaultMethod(Uri address) { }

	private static string UrlEncode(string str) { }

	private static string UrlEncode(string str, Encoding e) { }

	private static byte[] UrlEncodeToBytes(string str, Encoding e) { }

	private static byte[] UrlEncodeBytesToBytesInternal(byte[] bytes, int offset, int count, bool alwaysCreateReturnValue) { }

	private static char IntToHex(int n) { }

	private static bool IsSafe(char ch) { }

	private void InvokeOperationCompleted(AsyncOperation asyncOp, SendOrPostCallback callback, AsyncCompletedEventArgs eventArgs) { }

	private bool AnotherCallInProgress(int callNesting) { }

	protected virtual void OnOpenReadCompleted(OpenReadCompletedEventArgs e) { }

	private void OpenReadOperationCompleted(object arg) { }

	protected virtual void OnOpenWriteCompleted(OpenWriteCompletedEventArgs e) { }

	private void OpenWriteOperationCompleted(object arg) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void add_DownloadStringCompleted(DownloadStringCompletedEventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void remove_DownloadStringCompleted(DownloadStringCompletedEventHandler value) { }

	protected virtual void OnDownloadStringCompleted(DownloadStringCompletedEventArgs e) { }

	private void DownloadStringOperationCompleted(object arg) { }

	private void DownloadStringAsyncCallback(byte[] returnBytes, Exception exception, object state) { }

	public void DownloadStringAsync(Uri address) { }

	public void DownloadStringAsync(Uri address, object userToken) { }

	protected virtual void OnDownloadDataCompleted(DownloadDataCompletedEventArgs e) { }

	private void DownloadDataOperationCompleted(object arg) { }

	protected virtual void OnDownloadFileCompleted(AsyncCompletedEventArgs e) { }

	private void DownloadFileOperationCompleted(object arg) { }

	protected virtual void OnUploadStringCompleted(UploadStringCompletedEventArgs e) { }

	private void UploadStringOperationCompleted(object arg) { }

	private void StartDownloadAsync(WebClient.UploadBitsState state) { }

	protected virtual void OnUploadDataCompleted(UploadDataCompletedEventArgs e) { }

	private void UploadDataOperationCompleted(object arg) { }

	protected virtual void OnUploadFileCompleted(UploadFileCompletedEventArgs e) { }

	private void UploadFileOperationCompleted(object arg) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void add_UploadValuesCompleted(UploadValuesCompletedEventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void remove_UploadValuesCompleted(UploadValuesCompletedEventHandler value) { }

	protected virtual void OnUploadValuesCompleted(UploadValuesCompletedEventArgs e) { }

	private void UploadValuesOperationCompleted(object arg) { }

	private void UploadValuesAsyncWriteCallback(byte[] returnBytes, Exception exception, object state) { }

	private void UploadValuesAsyncReadCallback(byte[] returnBytes, Exception exception, object state) { }

	public void UploadValuesAsync(Uri address, string method, NameValueCollection data) { }

	public void UploadValuesAsync(Uri address, string method, NameValueCollection data, object userToken) { }

	protected virtual void OnDownloadProgressChanged(DownloadProgressChangedEventArgs e) { }

	protected virtual void OnUploadProgressChanged(UploadProgressChangedEventArgs e) { }

	private void ReportDownloadProgressChanged(object arg) { }

	private void ReportUploadProgressChanged(object arg) { }

	private void PostProgressChanged(AsyncOperation asyncOp, WebClient.ProgressData progress) { }

}

private class WebClient.ProgressData // TypeDefIndex: 2954
{	internal long BytesSent; // 0x10
	internal long TotalBytesToSend; // 0x18
	internal long BytesReceived; // 0x20
	internal long TotalBytesToReceive; // 0x28
	internal bool HasUploadPhase; // 0x30


	internal void Reset() { }

	public void .ctor() { }

}

private class WebClient.DownloadBitsState // TypeDefIndex: 2955
{	internal WebClient WebClient; // 0x10
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

	internal bool Async { get; }


	internal void .ctor(WebRequest request, Stream writeStream, CompletionDelegate completionDelegate, AsyncOperation asyncOp, WebClient.ProgressData progress, WebClient webClient) { }

	internal bool get_Async() { }

	internal int SetResponse(WebResponse response) { }

	internal bool RetrieveBytes(ref int bytesRetrieved) { }

	internal void Close() { }

}

private class WebClient.UploadBitsState // TypeDefIndex: 2956
{	private int m_ChunkSize; // 0x10
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

	internal bool FileUpload { get; }
	internal bool Async { get; }


	internal void .ctor(WebRequest request, Stream readStream, byte[] buffer, int chunkSize, byte[] header, byte[] footer, CompletionDelegate uploadCompletionDelegate, CompletionDelegate downloadCompletionDelegate, AsyncOperation asyncOp, WebClient.ProgressData progress, WebClient webClient) { }

	internal bool get_FileUpload() { }

	internal bool get_Async() { }

	internal void SetRequestStream(Stream writeStream) { }

	internal bool WriteBytes() { }

	internal void Close() { }

}

