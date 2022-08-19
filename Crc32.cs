internal sealed class Crc32 // TypeDefIndex: 5666
{	// Fields
	private static readonly uint CrcSeed; // 0x0
	private static readonly uint[] CrcTable; // 0x8
	private uint crc; // 0x10

	// Properties
	public long Value { get; }

	// Methods

	// RVA: 0x13A6480 Offset: 0x13A5880 VA: 0x1813A6480
	internal static uint ComputeCrc32(uint oldCrc, byte bval) { }

	// RVA: 0x36A480 Offset: 0x369880 VA: 0x18036A480 Slot: 4
	public long get_Value() { }

	// RVA: 0x13A6520 Offset: 0x13A5920 VA: 0x1813A6520 Slot: 5
	public void Update(byte[] buf, int off, int len) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x13A6720 Offset: 0x13A5B20 VA: 0x1813A6720
	private static void .cctor() { }

}

public class CRC32 // TypeDefIndex: 6967
{	// Fields
	private uint dwPolynomial; // 0x10
	private long _TotalBytesRead; // 0x18
	private bool reverseBits; // 0x20
	private uint[] crc32Table; // 0x28
	private uint _register; // 0x30

	// Properties
	public long TotalBytesRead { get; }
	public int Crc32Result { get; }

	// Methods

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public long get_TotalBytesRead() { }

	// RVA: 0x21C23D0 Offset: 0x21C17D0 VA: 0x1821C23D0
	public int get_Crc32Result() { }

	// RVA: 0x21C2110 Offset: 0x21C1510 VA: 0x1821C2110
	public void SlurpBlock(byte[] block, int offset, int count) { }

	// RVA: 0x21C2260 Offset: 0x21C1660 VA: 0x1821C2260
	public void UpdateCRC(byte b) { }

	// RVA: 0x21C20B0 Offset: 0x21C14B0 VA: 0x1821C20B0
	private static uint ReverseBits(uint data) { }

	// RVA: 0x21C2080 Offset: 0x21C1480 VA: 0x1821C2080
	private static byte ReverseBits(byte data) { }

	// RVA: 0x21C1F10 Offset: 0x21C1310 VA: 0x1821C1F10
	private void GenerateLookupTable() { }

	// RVA: 0x21C2390 Offset: 0x21C1790 VA: 0x1821C2390
	public void .ctor() { }

	// RVA: 0x21C2300 Offset: 0x21C1700 VA: 0x1821C2300
	public void .ctor(bool reverseBits) { }

	// RVA: 0x21C2340 Offset: 0x21C1740 VA: 0x1821C2340
	public void .ctor(int polynomial, bool reverseBits) { }

	// RVA: 0x21C2070 Offset: 0x21C1470 VA: 0x1821C2070
	public void Reset() { }

}

