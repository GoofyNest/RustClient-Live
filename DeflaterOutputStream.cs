internal class DeflaterOutputStream : Stream // TypeDefIndex: 5673
{
	protected byte[] buf;
	protected Deflater def;
	protected Stream baseOutputStream;
	private bool isClosed;
	private bool isStreamOwner;
	private uint[] keys;

	public bool IsStreamOwner { get; }
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }


	public bool get_IsStreamOwner() { }

	public override bool get_CanRead() { }

	public override bool get_CanSeek() { }

	public override bool get_CanWrite() { }

	public override long get_Length() { }

	public override long get_Position() { }

	public override void set_Position(long value) { }

	public override long Seek(long offset, SeekOrigin origin) { }

	public override void SetLength(long val) { }

	public override int ReadByte() { }

	public override int Read(byte[] b, int off, int len) { }

	public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	protected void Deflate() { }

	public void .ctor(Stream baseOutputStream, Deflater deflater, int bufsize) { }

	public override void Flush() { }

	public virtual void Finish() { }

	public override void Close() { }

	public override void WriteByte(byte bval) { }

	public override void Write(byte[] buf, int off, int len) { }

	protected byte EncryptByte() { }

	protected void EncryptBlock(byte[] buffer, int offset, int length) { }

	protected void UpdateKeys(byte ch) { }

}

