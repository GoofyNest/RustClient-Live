internal class FtpDataStream : Stream, IDisposable // TypeDefIndex: 2997
{
	private FtpWebRequest request; 
	private Stream networkStream; 
	private bool disposed; 
	private bool isRead; 
	private int totalRead; 

	public override bool CanRead { get; }
	public override bool CanWrite { get; }
	public override bool CanSeek { get; }
	public override long Length { get; }
	public override long Position { get; set; }


	internal void .ctor(FtpWebRequest request, Stream stream, bool isRead) { }

	public override bool get_CanRead() { }

	public override bool get_CanWrite() { }

	public override bool get_CanSeek() { }

	public override long get_Length() { }

	public override long get_Position() { }

	public override void set_Position(long value) { }

	public override void Close() { }

	public override void Flush() { }

	public override long Seek(long offset, SeekOrigin origin) { }

	public override void SetLength(long value) { }

	private int ReadInternal(byte[] buffer, int offset, int size) { }

	public override IAsyncResult BeginRead(byte[] buffer, int offset, int size, AsyncCallback cb, object state) { }

	public override int EndRead(IAsyncResult asyncResult) { }

	public override int Read(byte[] buffer, int offset, int size) { }

	private void WriteInternal(byte[] buffer, int offset, int size) { }

	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int size, AsyncCallback cb, object state) { }

	public override void EndWrite(IAsyncResult asyncResult) { }

	public override void Write(byte[] buffer, int offset, int size) { }

	protected override void Finalize() { }

	private void System.IDisposable.Dispose() { }

	protected override void Dispose(bool disposing) { }

	private void CheckDisposed() { }

}

private sealed class FtpDataStream.WriteDelegate : MulticastDelegate // TypeDefIndex: 2998
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(byte[] buffer, int offset, int size) { }

	public virtual IAsyncResult BeginInvoke(byte[] buffer, int offset, int size, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

private sealed class FtpDataStream.ReadDelegate : MulticastDelegate // TypeDefIndex: 2999
{

	public void .ctor(object object, IntPtr method) { }

	public virtual int Invoke(byte[] buffer, int offset, int size) { }

	public virtual IAsyncResult BeginInvoke(byte[] buffer, int offset, int size, AsyncCallback callback, object object) { }

	public virtual int EndInvoke(IAsyncResult result) { }

}

