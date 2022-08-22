internal sealed class Crc32 // TypeDefIndex: 5666
{	private static readonly uint CrcSeed; // 0x0
	private static readonly uint[] CrcTable; // 0x8
	private uint crc; // 0x10

	public long Value { get; }


	internal static uint ComputeCrc32(uint oldCrc, byte bval) { }

	public long get_Value() { }

	public void Update(byte[] buf, int off, int len) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class CRC32 // TypeDefIndex: 6967
{	private uint dwPolynomial; // 0x10
	private long _TotalBytesRead; // 0x18
	private bool reverseBits; // 0x20
	private uint[] crc32Table; // 0x28
	private uint _register; // 0x30

	public long TotalBytesRead { get; }
	public int Crc32Result { get; }


	public long get_TotalBytesRead() { }

	public int get_Crc32Result() { }

	public void SlurpBlock(byte[] block, int offset, int count) { }

	public void UpdateCRC(byte b) { }

	private static uint ReverseBits(uint data) { }

	private static byte ReverseBits(byte data) { }

	private void GenerateLookupTable() { }

	public void .ctor() { }

	public void .ctor(bool reverseBits) { }

	public void .ctor(int polynomial, bool reverseBits) { }

	public void Reset() { }

}

