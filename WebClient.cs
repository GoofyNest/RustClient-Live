public class WebClient : Component // TypeDefIndex: 2953
{
	private Uri m_baseAddress; 
	private ICredentials m_credentials; 
	private WebHeaderCollection m_headers; 
	private NameValueCollection m_requestParameters; 
	private WebResponse m_WebResponse; 
	private WebRequest m_WebRequest; 
	private Encoding m_Encoding; 
	private string m_Method; 
	private long m_ContentLength; 
	private bool m_InitWebClientAsync; 
	private bool m_Cancelled; 
	private WebClient.ProgressData m_Progress; 
	private IWebProxy m_Proxy; 
	private bool m_ProxySet; 
	private RequestCachePolicy m_CachePolicy; 
	private int m_CallNesting; 
	private AsyncOperation m_AsyncOp; 
	[CompilerGeneratedAttribute] 
	private OpenReadCompletedEventHandler OpenReadCompleted; 
	private SendOrPostCallback openReadOperationCompleted; 
	[CompilerGeneratedAttribute] 
	private OpenWriteCompletedEventHandler OpenWriteCompleted; 
	private SendOrPostCallback openWriteOperationCompleted; 
	[CompilerGeneratedAttribute] 
	private DownloadStringCompletedEventHandler DownloadStringCompleted; 
	private SendOrPostCallback downloadStringOperationCompleted; 
	[CompilerGeneratedAttribute] 
	private DownloadDataCompletedEventHandler DownloadDataCompleted; 
	private SendOrPostCallback downloadDataOperationCompleted; 
	[CompilerGeneratedAttribute] 
	private AsyncCompletedEventHandler DownloadFileCompleted; 
	private SendOrPostCallback downloadFileOperationCompleted; 
	[CompilerGeneratedAttribute] 
	private UploadStringCompletedEventHandler UploadStringCompleted; 
	private SendOrPostCallback uploadStringOperationCompleted; 
	[CompilerGeneratedAttribute] 
	private UploadDataCompletedEventHandler UploadDataCompleted; 
	private SendOrPostCallback uploadDataOperationCompleted; 
	[CompilerGeneratedAttribute] 
	private UploadFileCompletedEventHandler UploadFileCompleted; 
	private SendOrPostCallback uploadFileOperationCompleted; 
	[CompilerGeneratedAttribute] 
	private UploadValuesCompletedEventHandler UploadValuesCompleted; 
	private SendOrPostCallback uploadValuesOperationCompleted; 
	[CompilerGeneratedAttribute] 
	private DownloadProgressChangedEventHandler DownloadProgressChanged; 
	[CompilerGeneratedAttribute] 
	private UploadProgressChangedEventHandler UploadProgressChanged; 
	private SendOrPostCallback reportDownloadProgressChanged; 
	private SendOrPostCallback reportUploadProgressChanged; 

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

	[CompilerGeneratedAttribute] 
public void add_DownloadStringCompleted(DownloadStringCompletedEventHandler value) { }

	[CompilerGeneratedAttribute] 
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

	[CompilerGeneratedAttribute] 
public void add_UploadValuesCompleted(UploadValuesCompletedEventHandler value) { }

	[CompilerGeneratedAttribute] 
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
{
	internal long BytesSent; 
	internal long TotalBytesToSend; 
	internal long BytesReceived; 
	internal long TotalBytesToReceive; 
	internal bool HasUploadPhase; 


internal void Reset() { }

public void .ctor() { }

}

private class WebClient.DownloadBitsState // TypeDefIndex: 2955
{
	internal WebClient WebClient; 
	internal Stream WriteStream; 
	internal byte[] InnerBuffer; 
	internal AsyncOperation AsyncOp; 
	internal WebRequest Request; 
	internal CompletionDelegate CompletionDelegate; 
	internal Stream ReadStream; 
	internal ScatterGatherBuffers SgBuffers; 
	internal long ContentLength; 
	internal long Length; 
	internal WebClient.ProgressData Progress; 

internal bool Async { get; }


internal void .ctor(WebRequest request, Stream writeStream, CompletionDelegate completionDelegate, AsyncOperation asyncOp, WebClient.ProgressData progress, WebClient webClient) { }

internal bool get_Async() { }

internal int SetResponse(WebResponse response) { }

internal bool RetrieveBytes(ref int bytesRetrieved) { }

internal void Close() { }

}

private class WebClient.UploadBitsState // TypeDefIndex: 2956
{
	private int m_ChunkSize; 
	private int m_BufferWritePosition; 
	internal WebClient WebClient; 
	internal Stream WriteStream; 
	internal byte[] InnerBuffer; 
	internal byte[] Header; 
	internal byte[] Footer; 
	internal AsyncOperation AsyncOp; 
	internal WebRequest Request; 
	internal CompletionDelegate UploadCompletionDelegate; 
	internal CompletionDelegate DownloadCompletionDelegate; 
	internal Stream ReadStream; 
	internal WebClient.ProgressData Progress; 

internal bool FileUpload { get; }
internal bool Async { get; }


internal void .ctor(WebRequest request, Stream readStream, byte[] buffer, int chunkSize, byte[] header, byte[] footer, CompletionDelegate uploadCompletionDelegate, CompletionDelegate downloadCompletionDelegate, AsyncOperation asyncOp, WebClient.ProgressData progress, WebClient webClient) { }

internal bool get_FileUpload() { }

internal bool get_Async() { }

internal void SetRequestStream(Stream writeStream) { }

internal bool WriteBytes() { }

internal void Close() { }

}

