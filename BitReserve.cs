internal sealed class BitReserve // TypeDefIndex: 7383
{	// Fields
	private const int BUFSIZE = 32768;
	private const int BUFSIZE_MASK = 32767;
	private int[] _Buffer; // 0x10
	private int _Offset; // 0x18
	private int _Totbit; // 0x1C
	private int _BufByteIdx; // 0x20

	// Methods

	// RVA: 0x5F42B0 Offset: 0x5F36B0 VA: 0x1805F42B0
	internal void .ctor() { }

	// RVA: 0x5F3F20 Offset: 0x5F3320 VA: 0x1805F3F20
	private void InitBlock() { }

	// RVA: 0x4BE1F0 Offset: 0x4BD5F0 VA: 0x1804BE1F0
	internal int HssTell() { }

	// RVA: 0x5F4140 Offset: 0x5F3540 VA: 0x1805F4140
	internal int ReadBits(int n) { }

	// RVA: 0x5F4230 Offset: 0x5F3630 VA: 0x1805F4230
	internal int ReadOneBit() { }

	// RVA: 0x5F3F70 Offset: 0x5F3370 VA: 0x1805F3F70
	internal void PutBuffer(int val) { }

	// RVA: 0x5F4280 Offset: 0x5F3680 VA: 0x1805F4280
	internal void RewindStreamBits(int bitCount) { }

	// RVA: 0x5F4290 Offset: 0x5F3690 VA: 0x1805F4290
	internal void RewindStreamBytes(int byteCount) { }

}

