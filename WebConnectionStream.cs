internal class WebConnectionStream : Stream // TypeDefIndex: 3033
{	// Fields
	private static byte[] crlf; // 0x0
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

	// Properties
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

	// Methods

	// RVA: 0x117D310 Offset: 0x117C710 VA: 0x18117D310
	public void .ctor(WebConnection cnc, WebConnectionData data) { }

	// RVA: 0x117D180 Offset: 0x117C580 VA: 0x18117D180
	public void .ctor(WebConnection cnc, HttpWebRequest request) { }

	// RVA: 0x117B170 Offset: 0x117A570 VA: 0x18117B170
	private bool CheckAuthHeader(string headerName) { }

	// RVA: 0x117BD20 Offset: 0x117B120 VA: 0x18117BD20
	private bool IsNtlmAuth() { }

	// RVA: 0x117B240 Offset: 0x117A640 VA: 0x18117B240
	internal void CheckResponseInBuffer() { }

	// RVA: 0x4A2EE0 Offset: 0x4A22E0 VA: 0x1804A2EE0
	internal WebConnection get_Connection() { }

	// RVA: 0x1074D00 Offset: 0x1074100 VA: 0x181074D00 Slot: 13
	public override int get_ReadTimeout() { }

	// RVA: 0x1074CF0 Offset: 0x10740F0 VA: 0x181074CF0 Slot: 14
	public override int get_WriteTimeout() { }

	// RVA: 0x117D650 Offset: 0x117CA50 VA: 0x18117D650
	internal bool get_CompleteRequestWritten() { }

	// RVA: 0xED5200 Offset: 0xED4600 VA: 0x180ED5200
	internal void set_SendChunked(bool value) { }

	// RVA: 0x4B94A0 Offset: 0x4B88A0 VA: 0x1804B94A0
	internal void set_ReadBuffer(byte[] value) { }

	// RVA: 0x5B1C90 Offset: 0x5B1090 VA: 0x1805B1C90
	internal void set_ReadBufferOffset(int value) { }

	// RVA: 0x5B3950 Offset: 0x5B2D50 VA: 0x1805B3950
	internal void set_ReadBufferSize(int value) { }

	// RVA: 0x117D760 Offset: 0x117CB60 VA: 0x18117D760
	internal byte[] get_WriteBuffer() { }

	// RVA: 0x117D730 Offset: 0x117CB30 VA: 0x18117D730
	internal int get_WriteBufferLength() { }

	// RVA: 0x117BCD0 Offset: 0x117B0D0 VA: 0x18117BCD0
	internal void ForceCompletion() { }

	// RVA: 0x117B200 Offset: 0x117A600 VA: 0x18117B200
	internal void CheckComplete() { }

	// RVA: 0x117BE10 Offset: 0x117B210 VA: 0x18117BE10
	internal void ReadAll() { }

	// RVA: 0x117CB60 Offset: 0x117BF60 VA: 0x18117CB60
	private void WriteCallbackWrapper(IAsyncResult r) { }

	// RVA: 0x117C1F0 Offset: 0x117B5F0 VA: 0x18117C1F0
	private void ReadCallbackWrapper(IAsyncResult r) { }

	// RVA: 0x117C310 Offset: 0x117B710 VA: 0x18117C310 Slot: 27
	public override int Read(byte[] buffer, int offset, int size) { }

	// RVA: 0x117A630 Offset: 0x1179A30 VA: 0x18117A630 Slot: 19
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int size, AsyncCallback cb, object state) { }

	// RVA: 0x117B700 Offset: 0x117AB00 VA: 0x18117B700 Slot: 20
	public override int EndRead(IAsyncResult r) { }

	// RVA: 0x117C910 Offset: 0x117BD10 VA: 0x18117C910
	private void WriteAsyncCB(IAsyncResult r) { }

	// RVA: 0x117A9F0 Offset: 0x1179DF0 VA: 0x18117A9F0 Slot: 22
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int size, AsyncCallback cb, object state) { }

	// RVA: 0x117B290 Offset: 0x117A690 VA: 0x18117B290
	private void CheckWriteOverflow(long contentLength, long totalWritten, long size) { }

	// RVA: 0x117BA60 Offset: 0x117AE60 VA: 0x18117BA60 Slot: 23
	public override void EndWrite(IAsyncResult r) { }

	// RVA: 0x117CF50 Offset: 0x117C350 VA: 0x18117CF50 Slot: 29
	public override void Write(byte[] buffer, int offset, int size) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 18
	public override void Flush() { }

	// RVA: 0x117C500 Offset: 0x117B900 VA: 0x18117C500
	internal void SetHeadersAsync(bool setInternalLength, SimpleAsyncCallback callback) { }

	// RVA: 0x117C5C0 Offset: 0x117B9C0 VA: 0x18117C5C0
	private bool SetHeadersAsync(SimpleAsyncResult result, bool setInternalLength) { }

	// RVA: 0x117D720 Offset: 0x117CB20 VA: 0x18117D720
	internal bool get_RequestWritten() { }

	// RVA: 0x117CCD0 Offset: 0x117C0D0 VA: 0x18117CCD0
	internal bool WriteRequestAsync(SimpleAsyncResult result) { }

	// RVA: 0x95E750 Offset: 0x95DB50 VA: 0x18095E750
	internal void InternalClose() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x117D660 Offset: 0x117CA60 VA: 0x18117D660
	internal bool get_GetResponseOnClose() { }

	// RVA: 0x117B360 Offset: 0x117A760 VA: 0x18117B360 Slot: 16
	public override void Close() { }

	// RVA: 0x117BDF0 Offset: 0x117B1F0 VA: 0x18117BDF0
	internal void KillBuffer() { }

	// RVA: 0x117C4B0 Offset: 0x117B8B0 VA: 0x18117C4B0 Slot: 25
	public override long Seek(long a, SeekOrigin b) { }

	// RVA: 0x117C8C0 Offset: 0x117BCC0 VA: 0x18117C8C0 Slot: 26
	public override void SetLength(long a) { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x117D610 Offset: 0x117CA10 VA: 0x18117D610 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x117D630 Offset: 0x117CA30 VA: 0x18117D630 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x117D670 Offset: 0x117CA70 VA: 0x18117D670 Slot: 10
	public override long get_Length() { }

	// RVA: 0x117D6D0 Offset: 0x117CAD0 VA: 0x18117D6D0 Slot: 11
	public override long get_Position() { }

	// RVA: 0x117D790 Offset: 0x117CB90 VA: 0x18117D790 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0x117D0F0 Offset: 0x117C4F0 VA: 0x18117D0F0
	private static void .cctor() { }

}

private sealed class WebConnectionStream.<>c__DisplayClass75_0 // TypeDefIndex: 3034
{	// Fields
	public WebConnectionStream <>4__this; // 0x10
	public bool setInternalLength; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x11785F0 Offset: 0x11779F0 VA: 0x1811785F0
	internal bool <SetHeadersAsync>b__0(SimpleAsyncResult r) { }

}

private sealed class WebConnectionStream.<>c__DisplayClass76_0 // TypeDefIndex: 3035
{	// Fields
	public WebConnectionStream <>4__this; // 0x10
	public SimpleAsyncResult result; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x1178620 Offset: 0x1177A20 VA: 0x181178620
	internal void <SetHeadersAsync>b__0(IAsyncResult r) { }

}

private sealed class WebConnectionStream.<>c__DisplayClass80_0 // TypeDefIndex: 3036
{	// Fields
	public SimpleAsyncResult result; // 0x10
	public WebConnectionStream <>4__this; // 0x18
	public int length; // 0x20
	public byte[] bytes; // 0x28
	public AsyncCallback <>9__1; // 0x30

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x1178C60 Offset: 0x1178060 VA: 0x181178C60
	internal void <WriteRequestAsync>b__0(SimpleAsyncResult inner) { }

	// RVA: 0x1178E20 Offset: 0x1178220 VA: 0x181178E20
	internal void <WriteRequestAsync>b__1(IAsyncResult r) { }

}

