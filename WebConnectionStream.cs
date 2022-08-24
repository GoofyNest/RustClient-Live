internal class WebConnectionStream : Stream // TypeDefIndex: 3033
{
	private static byte[] crlf; 
	private bool isRead; 
	private WebConnection cnc; 
	private HttpWebRequest request; 
	private byte[] readBuffer; 
	private int readBufferOffset; 
	private int readBufferSize; 
	private int stream_length; 
	private long contentLength; 
	private long totalRead; 
	internal long totalWritten; 
	private bool nextReadCalled; 
	private int pendingReads; 
	private int pendingWrites; 
	private ManualResetEvent pending; 
	private bool allowBuffering; 
	private bool sendChunked; 
	private MemoryStream writeBuffer; 
	private bool requestWritten; 
	private byte[] headers; 
	private bool disposed; 
	private bool headersSent; 
	private object locker; 
	private bool initRead; 
	private bool read_eof; 
	private bool complete_request_written; 
	private int read_timeout; 
	private int write_timeout; 
	private AsyncCallback cb_wrapper; 
	internal bool IgnoreIOErrors; 
	[CompilerGeneratedAttribute] 
	private bool <GetResponseOnClose>k__BackingField; 

internal WebConnection Connection { get; }
public override int ReadTimeout { get; }
public override int WriteTimeout { get; }
internal bool CompleteRequestWritten { get; }
internal bool SendChunked { set; }
internal byte[] ReadBuffer { set; }
internal int ReadBufferOffset { set; }
internal int ReadBufferSize { set; }
internal byte[] WriteBuffer { get; }
internal int WriteBufferLength { get; }
internal bool RequestWritten { get; }
internal bool GetResponseOnClose { get; }
public override bool CanSeek { get; }
public override bool CanRead { get; }
public override bool CanWrite { get; }
public override long Length { get; }
public override long Position { get; set; }


public void .ctor(WebConnection cnc, WebConnectionData data) { }

public void .ctor(WebConnection cnc, HttpWebRequest request) { }

private bool CheckAuthHeader(string headerName) { }

private bool IsNtlmAuth() { }

internal void CheckResponseInBuffer() { }

internal WebConnection get_Connection() { }

public override int get_ReadTimeout() { }

public override int get_WriteTimeout() { }

internal bool get_CompleteRequestWritten() { }

internal void set_SendChunked(bool value) { }

internal void set_ReadBuffer(byte[] value) { }

internal void set_ReadBufferOffset(int value) { }

internal void set_ReadBufferSize(int value) { }

internal byte[] get_WriteBuffer() { }

internal int get_WriteBufferLength() { }

internal void ForceCompletion() { }

internal void CheckComplete() { }

internal void ReadAll() { }

private void WriteCallbackWrapper(IAsyncResult r) { }

private void ReadCallbackWrapper(IAsyncResult r) { }

public override int Read(byte[] buffer, int offset, int size) { }

public override IAsyncResult BeginRead(byte[] buffer, int offset, int size, AsyncCallback cb, object state) { }

public override int EndRead(IAsyncResult r) { }

private void WriteAsyncCB(IAsyncResult r) { }

public override IAsyncResult BeginWrite(byte[] buffer, int offset, int size, AsyncCallback cb, object state) { }

private void CheckWriteOverflow(long contentLength, long totalWritten, long size) { }

public override void EndWrite(IAsyncResult r) { }

public override void Write(byte[] buffer, int offset, int size) { }

public override void Flush() { }

internal void SetHeadersAsync(bool setInternalLength, SimpleAsyncCallback callback) { }

private bool SetHeadersAsync(SimpleAsyncResult result, bool setInternalLength) { }

internal bool get_RequestWritten() { }

internal bool WriteRequestAsync(SimpleAsyncResult result) { }

internal void InternalClose() { }

	[CompilerGeneratedAttribute] 
internal bool get_GetResponseOnClose() { }

public override void Close() { }

internal void KillBuffer() { }

public override long Seek(long a, SeekOrigin b) { }

public override void SetLength(long a) { }

public override bool get_CanSeek() { }

public override bool get_CanRead() { }

public override bool get_CanWrite() { }

public override long get_Length() { }

public override long get_Position() { }

public override void set_Position(long value) { }

private static void .cctor() { }

}

private sealed class WebConnectionStream.<>c__DisplayClass75_0 // TypeDefIndex: 3034
{
	public WebConnectionStream <>4__this; 
	public bool setInternalLength; 


public void .ctor() { }

internal bool <SetHeadersAsync>b__0(SimpleAsyncResult r) { }

}

private sealed class WebConnectionStream.<>c__DisplayClass76_0 // TypeDefIndex: 3035
{
	public WebConnectionStream <>4__this; 
	public SimpleAsyncResult result; 


public void .ctor() { }

internal void <SetHeadersAsync>b__0(IAsyncResult r) { }

}

private sealed class WebConnectionStream.<>c__DisplayClass80_0 // TypeDefIndex: 3036
{
	public SimpleAsyncResult result; 
	public WebConnectionStream <>4__this; 
	public int length; 
	public byte[] bytes; 
	public AsyncCallback <>9__1; 


public void .ctor() { }

internal void <WriteRequestAsync>b__0(SimpleAsyncResult inner) { }

internal void <WriteRequestAsync>b__1(IAsyncResult r) { }

}

