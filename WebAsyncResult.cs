internal class WebAsyncResult : SimpleAsyncResult // TypeDefIndex: 3025
{	private int nbytes; // 0x50
	private IAsyncResult innerAsyncResult; // 0x58
	private HttpWebResponse response; // 0x60
	private Stream writeStream; // 0x68
	private byte[] buffer; // 0x70
	private int offset; // 0x78
	private int size; // 0x7C
	public bool EndCalled; // 0x80
	public bool AsyncWriteAll; // 0x81
	public HttpWebRequest AsyncObject; // 0x88

	internal int NBytes { get; set; }
	internal IAsyncResult InnerAsyncResult { get; set; }
	internal Stream WriteStream { get; }
	internal HttpWebResponse Response { get; }
	internal byte[] Buffer { get; }
	internal int Offset { get; }
	internal int Size { get; }


	public void .ctor(AsyncCallback cb, object state) { }

	public void .ctor(HttpWebRequest request, AsyncCallback cb, object state) { }

	public void .ctor(AsyncCallback cb, object state, byte[] buffer, int offset, int size) { }

	internal void Reset() { }

	internal void SetCompleted(bool synch, int nbytes) { }

	internal void SetCompleted(bool synch, Stream writeStream) { }

	internal void SetCompleted(bool synch, HttpWebResponse response) { }

	internal void DoCallback() { }

	internal int get_NBytes() { }

	internal void set_NBytes(int value) { }

	internal IAsyncResult get_InnerAsyncResult() { }

	internal void set_InnerAsyncResult(IAsyncResult value) { }

	internal Stream get_WriteStream() { }

	internal HttpWebResponse get_Response() { }

	internal byte[] get_Buffer() { }

	internal int get_Offset() { }

	internal int get_Size() { }

}

