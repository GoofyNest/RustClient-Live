public class GZipStream : Stream // TypeDefIndex: 2861
{	private DeflateStream _deflateStream; // 0x28

	public override bool CanRead { get; }
	public override bool CanWrite { get; }
	public override bool CanSeek { get; }
	public override long Length { get; }
	public override long Position { get; set; }


	public void .ctor(Stream stream, CompressionMode mode) { }

	public void .ctor(Stream stream, CompressionMode mode, bool leaveOpen) { }

	public override bool get_CanRead() { }

	public override bool get_CanWrite() { }

	public override bool get_CanSeek() { }

	public override long get_Length() { }

	public override long get_Position() { }

	public override void set_Position(long value) { }

	public override void Flush() { }

	public override long Seek(long offset, SeekOrigin origin) { }

	public override void SetLength(long value) { }

	public override int ReadByte() { }

	public override IAsyncResult BeginRead(byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	public override int EndRead(IAsyncResult asyncResult) { }

	public override int Read(byte[] array, int offset, int count) { }

	public override IAsyncResult BeginWrite(byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	public override void EndWrite(IAsyncResult asyncResult) { }

	public override void Write(byte[] array, int offset, int count) { }

	protected override void Dispose(bool disposing) { }

	public override Task<int> ReadAsync(byte[] array, int offset, int count, CancellationToken cancellationToken) { }

	public override Task WriteAsync(byte[] array, int offset, int count, CancellationToken cancellationToken) { }

	public override Task CopyToAsync(Stream destination, int bufferSize, CancellationToken cancellationToken) { }

	private void CheckDeflateStream() { }

	private static void ThrowStreamClosedException() { }

}

public class GZipStream : Stream // TypeDefIndex: 6945
{	public Nullable<DateTime> LastModified; // 0x28
	private int _headerByteCount; // 0x38
	internal ZlibBaseStream _baseStream; // 0x40
	private bool _disposed; // 0x48
	private bool _firstReadDone; // 0x49
	private string _FileName; // 0x50
	private string _Comment; // 0x58
	private int _Crc32; // 0x60
	internal static readonly DateTime _unixEpoch; // 0x0
	internal static readonly Encoding iso8859dash1; // 0x8

	public string Comment { get; set; }
	public string FileName { get; set; }
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }


	public string get_Comment() { }

	public void set_Comment(string value) { }

	public string get_FileName() { }

	public void set_FileName(string value) { }

	public void .ctor(Stream stream, CompressionMode mode) { }

	public void .ctor(Stream stream, CompressionMode mode, CompressionLevel level) { }

	public void .ctor(Stream stream, CompressionMode mode, CompressionLevel level, bool leaveOpen) { }

	protected override void Dispose(bool disposing) { }

	public override bool get_CanRead() { }

	public override bool get_CanSeek() { }

	public override bool get_CanWrite() { }

	public override void Flush() { }

	public override long get_Length() { }

	public override long get_Position() { }

	public override void set_Position(long value) { }

	public override int Read(byte[] buffer, int offset, int count) { }

	public override long Seek(long offset, SeekOrigin origin) { }

	public override void SetLength(long value) { }

	public override void Write(byte[] buffer, int offset, int count) { }

	private int EmitHeader() { }

	public static byte[] CompressBuffer(byte[] b) { }

	public static byte[] UncompressBuffer(byte[] compressed) { }

	private static void .cctor() { }

}

