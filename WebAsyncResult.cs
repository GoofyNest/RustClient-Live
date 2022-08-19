internal class WebAsyncResult : SimpleAsyncResult // TypeDefIndex: 3025
{	// Fields
	private int nbytes; // 0x50
	private IAsyncResult innerAsyncResult; // 0x58
	private HttpWebResponse response; // 0x60
	private Stream writeStream; // 0x68
	private byte[] buffer; // 0x70
	private int offset; // 0x78
	private int size; // 0x7C
	public bool EndCalled; // 0x80
	public bool AsyncWriteAll; // 0x81
	public HttpWebRequest AsyncObject; // 0x88

	// Properties
	internal int NBytes { get; set; }
	internal IAsyncResult InnerAsyncResult { get; set; }
	internal Stream WriteStream { get; }
	internal HttpWebResponse Response { get; }
	internal byte[] Buffer { get; }
	internal int Offset { get; }
	internal int Size { get; }

	// Methods

	// RVA: 0x100ADD0 Offset: 0x100A1D0 VA: 0x18100ADD0
	public void .ctor(AsyncCallback cb, object state) { }

	// RVA: 0x100AD90 Offset: 0x100A190 VA: 0x18100AD90
	public void .ctor(HttpWebRequest request, AsyncCallback cb, object state) { }

	// RVA: 0x100AD50 Offset: 0x100A150 VA: 0x18100AD50
	public void .ctor(AsyncCallback cb, object state, byte[] buffer, int offset, int size) { }

	// RVA: 0x100AC70 Offset: 0x100A070 VA: 0x18100AC70
	internal void Reset() { }

	// RVA: 0x100ACC0 Offset: 0x100A0C0 VA: 0x18100ACC0
	internal void SetCompleted(bool synch, int nbytes) { }

	// RVA: 0x100ACD0 Offset: 0x100A0D0 VA: 0x18100ACD0
	internal void SetCompleted(bool synch, Stream writeStream) { }

	// RVA: 0x100AD10 Offset: 0x100A110 VA: 0x18100AD10
	internal void SetCompleted(bool synch, HttpWebResponse response) { }

	// RVA: 0xFFA6A0 Offset: 0xFF9AA0 VA: 0x180FFA6A0
	internal void DoCallback() { }

	// RVA: 0x8C8B80 Offset: 0x8C7F80 VA: 0x1808C8B80
	internal int get_NBytes() { }

	// RVA: 0x8C8BC0 Offset: 0x8C7FC0 VA: 0x1808C8BC0
	internal void set_NBytes(int value) { }

	// RVA: 0x4CC340 Offset: 0x4CB740 VA: 0x1804CC340
	internal IAsyncResult get_InnerAsyncResult() { }

	// RVA: 0x4CC360 Offset: 0x4CB760 VA: 0x1804CC360
	internal void set_InnerAsyncResult(IAsyncResult value) { }

	// RVA: 0x5334F0 Offset: 0x5328F0 VA: 0x1805334F0
	internal Stream get_WriteStream() { }

	// RVA: 0x54FB60 Offset: 0x54EF60 VA: 0x18054FB60
	internal HttpWebResponse get_Response() { }

	// RVA: 0x58DC30 Offset: 0x58D030 VA: 0x18058DC30
	internal byte[] get_Buffer() { }

	// RVA: 0xAF14F0 Offset: 0xAF08F0 VA: 0x180AF14F0
	internal int get_Offset() { }

	// RVA: 0x100ADE0 Offset: 0x100A1E0 VA: 0x18100ADE0
	internal int get_Size() { }

}

