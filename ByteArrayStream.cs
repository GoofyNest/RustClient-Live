public class ByteArrayStream : Stream // TypeDefIndex: 4833
{	// Fields
	private byte[] _data; // 0x28
	private int _base; // 0x30
	private int _length; // 0x34
	private int _position; // 0x38

	// Properties
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x2267EC0 Offset: 0x22672C0 VA: 0x182267EC0 Slot: 10
	public override long get_Length() { }

	// RVA: 0x2267ED0 Offset: 0x22672D0 VA: 0x182267ED0 Slot: 11
	public override long get_Position() { }

	// RVA: 0x220CCA0 Offset: 0x220C0A0 VA: 0x18220CCA0 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0x2267DB0 Offset: 0x22671B0 VA: 0x182267DB0
	public void .ctor() { }

	// RVA: 0x2267A20 Offset: 0x2266E20 VA: 0x182267A20
	public void SetData(byte[] data, int offset, int length) { }

	// RVA: 0x22677C0 Offset: 0x2266BC0 VA: 0x1822677C0 Slot: 27
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x2267760 Offset: 0x2266B60 VA: 0x182267760 Slot: 28
	public override int ReadByte() { }

	// RVA: 0x2267C40 Offset: 0x2267040 VA: 0x182267C40 Slot: 29
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x2267B90 Offset: 0x2266F90 VA: 0x182267B90 Slot: 30
	public override void WriteByte(byte value) { }

	// RVA: 0x2267960 Offset: 0x2266D60 VA: 0x182267960 Slot: 25
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 18
	public override void Flush() { }

	// RVA: 0x2267B40 Offset: 0x2266F40 VA: 0x182267B40 Slot: 26
	public override void SetLength(long value) { }

}

