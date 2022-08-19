public class GZipStream : Stream // TypeDefIndex: 2861
{	// Fields
	private DeflateStream _deflateStream; // 0x28

	// Properties
	public override bool CanRead { get; }
	public override bool CanWrite { get; }
	public override bool CanSeek { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x1560370 Offset: 0x155F770 VA: 0x181560370
	public void .ctor(Stream stream, CompressionMode mode) { }

	// RVA: 0x1560430 Offset: 0x155F830 VA: 0x181560430
	public void .ctor(Stream stream, CompressionMode mode, bool leaveOpen) { }

	// RVA: 0x1560500 Offset: 0x155F900 VA: 0x181560500 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x1560540 Offset: 0x155F940 VA: 0x181560540 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x1560520 Offset: 0x155F920 VA: 0x181560520 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x1560560 Offset: 0x155F960 VA: 0x181560560 Slot: 10
	public override long get_Length() { }

	// RVA: 0x15605C0 Offset: 0x155F9C0 VA: 0x1815605C0 Slot: 11
	public override long get_Position() { }

	// RVA: 0x1560620 Offset: 0x155FA20 VA: 0x181560620 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0x1560130 Offset: 0x155F530 VA: 0x181560130 Slot: 18
	public override void Flush() { }

	// RVA: 0x15601F0 Offset: 0x155F5F0 VA: 0x1815601F0 Slot: 25
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x1560250 Offset: 0x155F650 VA: 0x181560250 Slot: 26
	public override void SetLength(long value) { }

	// RVA: 0x1560190 Offset: 0x155F590 VA: 0x181560190 Slot: 28
	public override int ReadByte() { }

	// RVA: 0x155FE70 Offset: 0x155F270 VA: 0x18155FE70 Slot: 19
	public override IAsyncResult BeginRead(byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x15600F0 Offset: 0x155F4F0 VA: 0x1815600F0 Slot: 20
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x15601C0 Offset: 0x155F5C0 VA: 0x1815601C0 Slot: 27
	public override int Read(byte[] array, int offset, int count) { }

	// RVA: 0x155FF20 Offset: 0x155F320 VA: 0x18155FF20 Slot: 22
	public override IAsyncResult BeginWrite(byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x1211D90 Offset: 0x1211190 VA: 0x181211D90 Slot: 23
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x1560340 Offset: 0x155F740 VA: 0x181560340 Slot: 29
	public override void Write(byte[] array, int offset, int count) { }

	// RVA: 0x1560020 Offset: 0x155F420 VA: 0x181560020 Slot: 17
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1560160 Offset: 0x155F560 VA: 0x181560160 Slot: 21
	public override Task<int> ReadAsync(byte[] array, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x1560310 Offset: 0x155F710 VA: 0x181560310 Slot: 24
	public override Task WriteAsync(byte[] array, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x155FFF0 Offset: 0x155F3F0 VA: 0x18155FFF0 Slot: 15
	public override Task CopyToAsync(Stream destination, int bufferSize, CancellationToken cancellationToken) { }

	// RVA: 0x155FFD0 Offset: 0x155F3D0 VA: 0x18155FFD0
	private void CheckDeflateStream() { }

	// RVA: 0x15602B0 Offset: 0x155F6B0 VA: 0x1815602B0
	private static void ThrowStreamClosedException() { }

}

public class GZipStream : Stream // TypeDefIndex: 6945
{	// Fields
	public Nullable<DateTime> LastModified; // 0x28
	private int _headerByteCount; // 0x38
	internal ZlibBaseStream _baseStream; // 0x40
	private bool _disposed; // 0x48
	private bool _firstReadDone; // 0x49
	private string _FileName; // 0x50
	private string _Comment; // 0x58
	private int _Crc32; // 0x60
	internal static readonly DateTime _unixEpoch; // 0x0
	internal static readonly Encoding iso8859dash1; // 0x8

	// Properties
	public string Comment { get; set; }
	public string FileName { get; set; }
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x4CC340 Offset: 0x4CB740 VA: 0x1804CC340
	public string get_Comment() { }

	// RVA: 0x21C9D70 Offset: 0x21C9170 VA: 0x1821C9D70
	public void set_Comment(string value) { }

	// RVA: 0x4CC350 Offset: 0x4CB750 VA: 0x1804CC350
	public string get_FileName() { }

	// RVA: 0x21C9DF0 Offset: 0x21C91F0 VA: 0x1821C9DF0
	public void set_FileName(string value) { }

	// RVA: 0x21C9B70 Offset: 0x21C8F70 VA: 0x1821C9B70
	public void .ctor(Stream stream, CompressionMode mode) { }

	// RVA: 0x21C9B50 Offset: 0x21C8F50 VA: 0x1821C9B50
	public void .ctor(Stream stream, CompressionMode mode, CompressionLevel level) { }

	// RVA: 0x21C99C0 Offset: 0x21C8DC0 VA: 0x1821C99C0
	public void .ctor(Stream stream, CompressionMode mode, CompressionLevel level, bool leaveOpen) { }

	// RVA: 0x21C8DA0 Offset: 0x21C81A0 VA: 0x1821C8DA0 Slot: 17
	protected override void Dispose(bool disposing) { }

	// RVA: 0x21C9BA0 Offset: 0x21C8FA0 VA: 0x1821C9BA0 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x21C9C30 Offset: 0x21C9030 VA: 0x1821C9C30 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x21C9300 Offset: 0x21C8700 VA: 0x1821C9300 Slot: 18
	public override void Flush() { }

	// RVA: 0x21C9CC0 Offset: 0x21C90C0 VA: 0x1821C9CC0 Slot: 10
	public override long get_Length() { }

	// RVA: 0x21C9D10 Offset: 0x21C9110 VA: 0x1821C9D10 Slot: 11
	public override long get_Position() { }

	// RVA: 0x21C9F80 Offset: 0x21C9380 VA: 0x1821C9F80 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0x21C9380 Offset: 0x21C8780 VA: 0x1821C9380 Slot: 27
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x21C9650 Offset: 0x21C8A50 VA: 0x1821C9650 Slot: 25
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x21C96A0 Offset: 0x21C8AA0 VA: 0x1821C96A0 Slot: 26
	public override void SetLength(long value) { }

	// RVA: 0x21C9810 Offset: 0x21C8C10 VA: 0x1821C9810 Slot: 29
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x21C8EA0 Offset: 0x21C82A0 VA: 0x1821C8EA0
	private int EmitHeader() { }

	// RVA: 0x21C8C60 Offset: 0x21C8060 VA: 0x1821C8C60
	public static byte[] CompressBuffer(byte[] b) { }

	// RVA: 0x21C96F0 Offset: 0x21C8AF0 VA: 0x1821C96F0
	public static byte[] UncompressBuffer(byte[] compressed) { }

	// RVA: 0x21C9920 Offset: 0x21C8D20 VA: 0x1821C9920
	private static void .cctor() { }

}

