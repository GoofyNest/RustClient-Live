internal class WebConnectionStream : Stream // TypeDefIndex: 3033
{	private static byte[] crlf; // 0x0
	private bool isRead; // 0x28
	private WebConnection cnc; // 0x30
	private HttpWebRequest request; // 0x38
	private byte[] readBuffer; // 0x40
	private int readBufferOffset; // 0x48
	private int readBufferSize; // 0x4C
	private int stream_length; // 0x50
	private long contentLength; // 0x58
	private long totalRead; // 0x60
	internal long totalWritten; // 0x68
	private bool nextReadCalled; // 0x70
	private int pendingReads; // 0x74
	private int pendingWrites; // 0x78
	private ManualResetEvent pending; // 0x80
	private bool allowBuffering; // 0x88
	private bool sendChunked; // 0x89
	private MemoryStream writeBuffer; // 0x90
	private bool requestWritten; // 0x98
	private byte[] headers; // 0xA0
	private bool disposed; // 0xA8
	private bool headersSent; // 0xA9
	private object locker; // 0xB0
	private bool initRead; // 0xB8
	private bool read_eof; // 0xB9
	private bool complete_request_written; // 0xBA
	private int read_timeout; // 0xBC
	private int write_timeout; // 0xC0
	private AsyncCallback cb_wrapper; // 0xC8
	internal bool IgnoreIOErrors; // 0xD0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <GetResponseOnClose>k__BackingField; // 0xD1

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

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
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
{	public WebConnectionStream <>4__this; // 0x10
	public bool setInternalLength; // 0x18


	public void .ctor() { }

	internal bool <SetHeadersAsync>b__0(SimpleAsyncResult r) { }

}

private sealed class WebConnectionStream.<>c__DisplayClass76_0 // TypeDefIndex: 3035
{	public WebConnectionStream <>4__this; // 0x10
	public SimpleAsyncResult result; // 0x18


	public void .ctor() { }

	internal void <SetHeadersAsync>b__0(IAsyncResult r) { }

}

private sealed class WebConnectionStream.<>c__DisplayClass80_0 // TypeDefIndex: 3036
{	public SimpleAsyncResult result; // 0x10
	public WebConnectionStream <>4__this; // 0x18
	public int length; // 0x20
	public byte[] bytes; // 0x28
	public AsyncCallback <>9__1; // 0x30


	public void .ctor() { }

	internal void <WriteRequestAsync>b__0(SimpleAsyncResult inner) { }

	internal void <WriteRequestAsync>b__1(IAsyncResult r) { }

}

