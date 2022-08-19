internal class PendingBuffer // TypeDefIndex: 5663
{	// Fields
	protected byte[] buf; // 0x10
	private int start; // 0x18
	private int end; // 0x1C
	private uint bits; // 0x20
	private int bitCount; // 0x24

	// Properties
	public int BitCount { get; }
	public bool IsFlushed { get; }

	// Methods

	// RVA: 0x22FE5D0 Offset: 0x22FD9D0 VA: 0x1822FE5D0
	public void .ctor(int bufsize) { }

	// RVA: 0x22FE1A0 Offset: 0x22FD5A0 VA: 0x1822FE1A0
	public void Reset() { }

	// RVA: 0x22FE4D0 Offset: 0x22FD8D0 VA: 0x1822FE4D0
	public void WriteShort(int s) { }

	// RVA: 0x22FE2F0 Offset: 0x22FD6F0 VA: 0x1822FE2F0
	public void WriteBlock(byte[] block, int offset, int len) { }

	// RVA: 0x7E8DA0 Offset: 0x7E81A0 VA: 0x1807E8DA0
	public int get_BitCount() { }

	// RVA: 0x22FDFD0 Offset: 0x22FD3D0 VA: 0x1822FDFD0
	public void AlignToByte() { }

	// RVA: 0x22FE1B0 Offset: 0x22FD5B0 VA: 0x1822FE1B0
	public void WriteBits(int b, int count) { }

	// RVA: 0x22FE3D0 Offset: 0x22FD7D0 VA: 0x1822FE3D0
	public void WriteShortMSB(int s) { }

	// RVA: 0x22FE630 Offset: 0x22FDA30 VA: 0x1822FE630
	public bool get_IsFlushed() { }

	// RVA: 0x22FE0E0 Offset: 0x22FD4E0 VA: 0x1822FE0E0
	public int Flush(byte[] output, int offset, int length) { }

}

