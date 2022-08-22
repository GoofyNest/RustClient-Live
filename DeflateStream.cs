public class DeflateStream : Stream // TypeDefIndex: 2862
{	private Stream base_stream; // 0x28
	private CompressionMode mode; // 0x30
	private bool leaveOpen; // 0x34
	private bool disposed; // 0x35
	private DeflateStreamNative native; // 0x38

	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }


	public void .ctor(Stream stream, CompressionMode mode) { }

	internal void .ctor(Stream stream, CompressionMode mode, bool leaveOpen, int windowsBits) { }

	internal void .ctor(Stream compressedStream, CompressionMode mode, bool leaveOpen, bool gzip) { }

	protected override void Dispose(bool disposing) { }

	private int ReadInternal(byte[] array, int offset, int count) { }

	public override int Read(byte[] array, int offset, int count) { }

	private void WriteInternal(byte[] array, int offset, int count) { }

	public override void Write(byte[] array, int offset, int count) { }

	public override void Flush() { }

	public override IAsyncResult BeginRead(byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	public override IAsyncResult BeginWrite(byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	public override int EndRead(IAsyncResult asyncResult) { }

	public override void EndWrite(IAsyncResult asyncResult) { }

	public override long Seek(long offset, SeekOrigin origin) { }

	public override void SetLength(long value) { }

	public override bool get_CanRead() { }

	public override bool get_CanSeek() { }

	public override bool get_CanWrite() { }

	public override long get_Length() { }

	public override long get_Position() { }

	public override void set_Position(long value) { }

}

private sealed class DeflateStream.ReadMethod : MulticastDelegate // TypeDefIndex: 2863
{
	public void .ctor(object object, IntPtr method) { }

	public virtual int Invoke(byte[] array, int offset, int count) { }

	public virtual IAsyncResult BeginInvoke(byte[] array, int offset, int count, AsyncCallback callback, object object) { }

	public virtual int EndInvoke(IAsyncResult result) { }

}

private sealed class DeflateStream.WriteMethod : MulticastDelegate // TypeDefIndex: 2864
{
	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(byte[] array, int offset, int count) { }

	public virtual IAsyncResult BeginInvoke(byte[] array, int offset, int count, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

