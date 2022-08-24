internal class WebAsyncResult : SimpleAsyncResult // TypeDefIndex: 3025
{
	private int nbytes; 
	private IAsyncResult innerAsyncResult; 
	private HttpWebResponse response; 
	private Stream writeStream; 
	private byte[] buffer; 
	private int offset; 
	private int size; 
	public bool EndCalled; 
	public bool AsyncWriteAll; 
	public HttpWebRequest AsyncObject; 

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

