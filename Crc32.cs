internal sealed class Crc32 // TypeDefIndex: 5667
{
	private static readonly uint CrcSeed; 
	private static readonly uint[] CrcTable; 
	private uint crc; 

	public long Value { get; }


	internal static uint ComputeCrc32(uint oldCrc, byte bval) { }

	public long get_Value() { }

	public void Update(byte[] buf, int off, int len) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class CRC32 // TypeDefIndex: 6968
{
	private uint dwPolynomial; 
	private long _TotalBytesRead; 
	private bool reverseBits; 
	private uint[] crc32Table; 
	private uint _register; 

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

