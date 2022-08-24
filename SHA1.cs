public abstract class SHA1 : HashAlgorithm // TypeDefIndex: 984
{

protected void .ctor() { }

public static SHA1 Create() { }

}

public class SHA1Managed : SHA1 // TypeDefIndex: 985
{
	private byte[] _buffer; 
	private long _count; 
	private uint[] _stateSHA1; 
	private uint[] _expandedBuffer; 


public void .ctor() { }

public override void Initialize() { }

protected override void HashCore(byte[] rgb, int ibStart, int cbSize) { }

protected override byte[] HashFinal() { }

private void InitializeState() { }

private void _HashData(byte[] partIn, int ibStart, int cbSize) { }

private byte[] _EndHash() { }

private static void SHATransform(uint* expandedBuffer, uint* state, byte* block) { }

private static void SHAExpand(uint* x) { }

}

public abstract class SHA256 : HashAlgorithm // TypeDefIndex: 986
{

protected void .ctor() { }

public static SHA256 Create() { }

}

public class SHA256Managed : SHA256 // TypeDefIndex: 987
{
	private byte[] _buffer; 
	private long _count; 
	private uint[] _stateSHA256; 
	private uint[] _W; 
	private static readonly uint[] _K; 


public void .ctor() { }

public override void Initialize() { }

protected override void HashCore(byte[] rgb, int ibStart, int cbSize) { }

protected override byte[] HashFinal() { }

private void InitializeState() { }

private void _HashData(byte[] partIn, int ibStart, int cbSize) { }

private byte[] _EndHash() { }

private static void SHATransform(uint* expandedBuffer, uint* state, byte* block) { }

private static uint RotateRight(uint x, int n) { }

private static uint Ch(uint x, uint y, uint z) { }

private static uint Maj(uint x, uint y, uint z) { }

private static uint sigma_0(uint x) { }

private static uint sigma_1(uint x) { }

private static uint Sigma_0(uint x) { }

private static uint Sigma_1(uint x) { }

private static void SHA256Expand(uint* x) { }

private static void .cctor() { }

}

public abstract class SHA384 : HashAlgorithm // TypeDefIndex: 988
{

protected void .ctor() { }

public static SHA384 Create() { }

}

public class SHA384Managed : SHA384 // TypeDefIndex: 989
{
	private byte[] _buffer; 
	private ulong _count; 
	private ulong[] _stateSHA384; 
	private ulong[] _W; 
	private static readonly ulong[] _K; 


public void .ctor() { }

public override void Initialize() { }

protected override void HashCore(byte[] rgb, int ibStart, int cbSize) { }

protected override byte[] HashFinal() { }

private void InitializeState() { }

private void _HashData(byte[] partIn, int ibStart, int cbSize) { }

private byte[] _EndHash() { }

private static void SHATransform(ulong* expandedBuffer, ulong* state, byte* block) { }

private static ulong RotateRight(ulong x, int n) { }

private static ulong Ch(ulong x, ulong y, ulong z) { }

private static ulong Maj(ulong x, ulong y, ulong z) { }

private static ulong Sigma_0(ulong x) { }

private static ulong Sigma_1(ulong x) { }

private static ulong sigma_0(ulong x) { }

private static ulong sigma_1(ulong x) { }

private static void SHA384Expand(ulong* x) { }

private static void .cctor() { }

}

public abstract class SHA512 : HashAlgorithm // TypeDefIndex: 990
{

protected void .ctor() { }

public static SHA512 Create() { }

}

public class SHA512Managed : SHA512 // TypeDefIndex: 991
{
	private byte[] _buffer; 
	private ulong _count; 
	private ulong[] _stateSHA512; 
	private ulong[] _W; 
	private static readonly ulong[] _K; 


public void .ctor() { }

public override void Initialize() { }

protected override void HashCore(byte[] rgb, int ibStart, int cbSize) { }

protected override byte[] HashFinal() { }

private void InitializeState() { }

private void _HashData(byte[] partIn, int ibStart, int cbSize) { }

private byte[] _EndHash() { }

private static void SHATransform(ulong* expandedBuffer, ulong* state, byte* block) { }

private static ulong RotateRight(ulong x, int n) { }

private static ulong Ch(ulong x, ulong y, ulong z) { }

private static ulong Maj(ulong x, ulong y, ulong z) { }

private static ulong Sigma_0(ulong x) { }

private static ulong Sigma_1(ulong x) { }

private static ulong sigma_0(ulong x) { }

private static ulong sigma_1(ulong x) { }

private static void SHA512Expand(ulong* x) { }

private static void .cctor() { }

}

internal class SHA1Internal // TypeDefIndex: 1011
{
	private uint[] _H; 
	private ulong count; 
	private byte[] _ProcessingBuffer; 
	private int _ProcessingBufferCount; 
	private uint[] buff; 


public void .ctor() { }

public void HashCore(byte[] rgb, int ibStart, int cbSize) { }

public byte[] HashFinal() { }

public void Initialize() { }

private void ProcessBlock(byte[] inputBuffer, uint inputOffset) { }

private static void InitialiseBuff(uint[] buff, byte[] input, uint inputOffset) { }

private static void FillBuff(uint[] buff) { }

private void ProcessFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) { }

internal void AddLength(ulong length, byte[] buffer, int position) { }

}

public sealed class SHA1CryptoServiceProvider : SHA1 // TypeDefIndex: 1012
{
	private SHA1Internal sha; 


public void .ctor() { }

protected override void Finalize() { }

protected override void Dispose(bool disposing) { }

protected override void HashCore(byte[] rgb, int ibStart, int cbSize) { }

protected override byte[] HashFinal() { }

public override void Initialize() { }

}

