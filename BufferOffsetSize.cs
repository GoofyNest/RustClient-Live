internal class BufferOffsetSize // TypeDefIndex: 2530
{	// Fields
	public byte[] Buffer; // 0x10
	public int Offset; // 0x18
	public int Size; // 0x1C
	public int TotalBytes; // 0x20
	public bool Complete; // 0x24

	// Properties
	public int EndOffset { get; }
	public int Remaining { get; }

	// Methods

	// RVA: 0x7992A0 Offset: 0x7986A0 VA: 0x1807992A0
	public int get_EndOffset() { }

	// RVA: 0x120ACA0 Offset: 0x120A0A0 VA: 0x18120ACA0
	public int get_Remaining() { }

	// RVA: 0x120AB70 Offset: 0x1209F70 VA: 0x18120AB70
	public void .ctor(byte[] buffer, int offset, int size) { }

	// RVA: 0x120AAF0 Offset: 0x1209EF0 VA: 0x18120AAF0 Slot: 3
	public override string ToString() { }

}

internal class BufferOffsetSize // TypeDefIndex: 2913
{	// Fields
	internal byte[] Buffer; // 0x10
	internal int Offset; // 0x18
	internal int Size; // 0x1C

	// Methods

	// RVA: 0x154CE90 Offset: 0x154C290 VA: 0x18154CE90
	internal void .ctor(byte[] buffer, int offset, int size, bool copyBuffer) { }

}

