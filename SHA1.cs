public abstract class SHA1 : HashAlgorithm // TypeDefIndex: 984
{	// Methods

	// RVA: 0x17B9740 Offset: 0x17B8B40 VA: 0x1817B9740
	protected void .ctor() { }

	// RVA: 0x17B9620 Offset: 0x17B8A20 VA: 0x1817B9620
	public static SHA1 Create() { }

}

public class SHA1Managed : SHA1 // TypeDefIndex: 985
{	// Fields
	private byte[] _buffer; // 0x28
	private long _count; // 0x30
	private uint[] _stateSHA1; // 0x38
	private uint[] _expandedBuffer; // 0x40

	// Methods

	// RVA: 0x17B9520 Offset: 0x17B8920 VA: 0x1817B9520
	public void .ctor() { }

	// RVA: 0x17B8A10 Offset: 0x17B7E10 VA: 0x1817B8A10 Slot: 16
	public override void Initialize() { }

	// RVA: 0x17B89F0 Offset: 0x17B7DF0 VA: 0x1817B89F0 Slot: 17
	protected override void HashCore(byte[] rgb, int ibStart, int cbSize) { }

	// RVA: 0x17B8A00 Offset: 0x17B7E00 VA: 0x1817B8A00 Slot: 18
	protected override byte[] HashFinal() { }

	// RVA: 0x1701890 Offset: 0x1700C90 VA: 0x181701890
	private void InitializeState() { }

	// RVA: 0x17B93B0 Offset: 0x17B87B0 VA: 0x1817B93B0
	private void _HashData(byte[] partIn, int ibStart, int cbSize) { }

	// RVA: 0x17B9050 Offset: 0x17B8450 VA: 0x1817B9050
	private byte[] _EndHash() { }

	// RVA: 0x17B8AA0 Offset: 0x17B7EA0 VA: 0x1817B8AA0
	private static void SHATransform(uint* expandedBuffer, uint* state, byte* block) { }

	// RVA: 0x17B8A60 Offset: 0x17B7E60 VA: 0x1817B8A60
	private static void SHAExpand(uint* x) { }

}

public abstract class SHA256 : HashAlgorithm // TypeDefIndex: 986
{	// Methods

	// RVA: 0x17BAAE0 Offset: 0x17B9EE0 VA: 0x1817BAAE0
	protected void .ctor() { }

	// RVA: 0x17BA9B0 Offset: 0x17B9DB0 VA: 0x1817BA9B0
	public static SHA256 Create() { }

}

public class SHA256Managed : SHA256 // TypeDefIndex: 987
{	// Fields
	private byte[] _buffer; // 0x28
	private long _count; // 0x30
	private uint[] _stateSHA256; // 0x38
	private uint[] _W; // 0x40
	private static readonly uint[] _K; // 0x0

	// Methods

	// RVA: 0x17BA7D0 Offset: 0x17B9BD0 VA: 0x1817BA7D0
	public void .ctor() { }

	// RVA: 0x17B9910 Offset: 0x17B8D10 VA: 0x1817B9910 Slot: 16
	public override void Initialize() { }

	// RVA: 0x17B9770 Offset: 0x17B8B70 VA: 0x1817B9770 Slot: 17
	protected override void HashCore(byte[] rgb, int ibStart, int cbSize) { }

	// RVA: 0x17B9780 Offset: 0x17B8B80 VA: 0x1817B9780 Slot: 18
	protected override byte[] HashFinal() { }

	// RVA: 0x17B9790 Offset: 0x17B8B90 VA: 0x1817B9790
	private void InitializeState() { }

	// RVA: 0x17BA590 Offset: 0x17B9990 VA: 0x1817BA590
	private void _HashData(byte[] partIn, int ibStart, int cbSize) { }

	// RVA: 0x17BA230 Offset: 0x17B9630 VA: 0x1817BA230
	private byte[] _EndHash() { }

	// RVA: 0x17B9A40 Offset: 0x17B8E40 VA: 0x1817B9A40
	private static void SHATransform(uint* expandedBuffer, uint* state, byte* block) { }

	// RVA: 0x17B9970 Offset: 0x17B8D70 VA: 0x1817B9970
	private static uint RotateRight(uint x, int n) { }

	// RVA: 0x17B9760 Offset: 0x17B8B60 VA: 0x1817B9760
	private static uint Ch(uint x, uint y, uint z) { }

	// RVA: 0x17B9960 Offset: 0x17B8D60 VA: 0x1817B9960
	private static uint Maj(uint x, uint y, uint z) { }

	// RVA: 0x17BA8D0 Offset: 0x17B9CD0 VA: 0x1817BA8D0
	private static uint sigma_0(uint x) { }

	// RVA: 0x17BA940 Offset: 0x17B9D40 VA: 0x1817BA940
	private static uint sigma_1(uint x) { }

	// RVA: 0x17BA150 Offset: 0x17B9550 VA: 0x1817BA150
	private static uint Sigma_0(uint x) { }

	// RVA: 0x17BA1C0 Offset: 0x17B95C0 VA: 0x1817BA1C0
	private static uint Sigma_1(uint x) { }

	// RVA: 0x17B9990 Offset: 0x17B8D90 VA: 0x1817B9990
	private static void SHA256Expand(uint* x) { }

	// RVA: 0x17BA760 Offset: 0x17B9B60 VA: 0x1817BA760
	private static void .cctor() { }

}

public abstract class SHA384 : HashAlgorithm // TypeDefIndex: 988
{	// Methods

	// RVA: 0x17BBEB0 Offset: 0x17BB2B0 VA: 0x1817BBEB0
	protected void .ctor() { }

	// RVA: 0x17BBD80 Offset: 0x17BB180 VA: 0x1817BBD80
	public static SHA384 Create() { }

}

public class SHA384Managed : SHA384 // TypeDefIndex: 989
{	// Fields
	private byte[] _buffer; // 0x28
	private ulong _count; // 0x30
	private ulong[] _stateSHA384; // 0x38
	private ulong[] _W; // 0x40
	private static readonly ulong[] _K; // 0x0

	// Methods

	// RVA: 0x17BBB80 Offset: 0x17BAF80 VA: 0x1817BBB80
	public void .ctor() { }

	// RVA: 0x17BACF0 Offset: 0x17BA0F0 VA: 0x1817BACF0 Slot: 16
	public override void Initialize() { }

	// RVA: 0x17BAB10 Offset: 0x17B9F10 VA: 0x1817BAB10 Slot: 17
	protected override void HashCore(byte[] rgb, int ibStart, int cbSize) { }

	// RVA: 0x17BAB20 Offset: 0x17B9F20 VA: 0x1817BAB20 Slot: 18
	protected override byte[] HashFinal() { }

	// RVA: 0x17BAB30 Offset: 0x17B9F30 VA: 0x1817BAB30
	private void InitializeState() { }

	// RVA: 0x17BB940 Offset: 0x17BAD40 VA: 0x1817BB940
	private void _HashData(byte[] partIn, int ibStart, int cbSize) { }

	// RVA: 0x17BB700 Offset: 0x17BAB00 VA: 0x1817BB700
	private byte[] _EndHash() { }

	// RVA: 0x17BAE20 Offset: 0x17BA220 VA: 0x1817BAE20
	private static void SHATransform(ulong* expandedBuffer, ulong* state, byte* block) { }

	// RVA: 0x17BAD50 Offset: 0x17BA150 VA: 0x1817BAD50
	private static ulong RotateRight(ulong x, int n) { }

	// RVA: 0x17BAB00 Offset: 0x17B9F00 VA: 0x1817BAB00
	private static ulong Ch(ulong x, ulong y, ulong z) { }

	// RVA: 0x17BAD40 Offset: 0x17BA140 VA: 0x1817BAD40
	private static ulong Maj(ulong x, ulong y, ulong z) { }

	// RVA: 0x17BB600 Offset: 0x17BAA00 VA: 0x1817BB600
	private static ulong Sigma_0(ulong x) { }

	// RVA: 0x17BB680 Offset: 0x17BAA80 VA: 0x1817BB680
	private static ulong Sigma_1(ulong x) { }

	// RVA: 0x17BBC80 Offset: 0x17BB080 VA: 0x1817BBC80
	private static ulong sigma_0(ulong x) { }

	// RVA: 0x17BBD00 Offset: 0x17BB100 VA: 0x1817BBD00
	private static ulong sigma_1(ulong x) { }

	// RVA: 0x17BAD70 Offset: 0x17BA170 VA: 0x1817BAD70
	private static void SHA384Expand(ulong* x) { }

	// RVA: 0x17BBB10 Offset: 0x17BAF10 VA: 0x1817BBB10
	private static void .cctor() { }

}

public abstract class SHA512 : HashAlgorithm // TypeDefIndex: 990
{	// Methods

	// RVA: 0x17BD240 Offset: 0x17BC640 VA: 0x1817BD240
	protected void .ctor() { }

	// RVA: 0x17BD110 Offset: 0x17BC510 VA: 0x1817BD110
	public static SHA512 Create() { }

}

public class SHA512Managed : SHA512 // TypeDefIndex: 991
{	// Fields
	private byte[] _buffer; // 0x28
	private ulong _count; // 0x30
	private ulong[] _stateSHA512; // 0x38
	private ulong[] _W; // 0x40
	private static readonly ulong[] _K; // 0x0

	// Methods

	// RVA: 0x17BCF10 Offset: 0x17BC310 VA: 0x1817BCF10
	public void .ctor() { }

	// RVA: 0x17BC0B0 Offset: 0x17BB4B0 VA: 0x1817BC0B0 Slot: 16
	public override void Initialize() { }

	// RVA: 0x17BBED0 Offset: 0x17BB2D0 VA: 0x1817BBED0 Slot: 17
	protected override void HashCore(byte[] rgb, int ibStart, int cbSize) { }

	// RVA: 0x17BBEE0 Offset: 0x17BB2E0 VA: 0x1817BBEE0 Slot: 18
	protected override byte[] HashFinal() { }

	// RVA: 0x17BBEF0 Offset: 0x17BB2F0 VA: 0x1817BBEF0
	private void InitializeState() { }

	// RVA: 0x17BCCD0 Offset: 0x17BC0D0 VA: 0x1817BCCD0
	private void _HashData(byte[] partIn, int ibStart, int cbSize) { }

	// RVA: 0x17BCA90 Offset: 0x17BBE90 VA: 0x1817BCA90
	private byte[] _EndHash() { }

	// RVA: 0x17BC1B0 Offset: 0x17BB5B0 VA: 0x1817BC1B0
	private static void SHATransform(ulong* expandedBuffer, ulong* state, byte* block) { }

	// RVA: 0x17BAD50 Offset: 0x17BA150 VA: 0x1817BAD50
	private static ulong RotateRight(ulong x, int n) { }

	// RVA: 0x17BAB00 Offset: 0x17B9F00 VA: 0x1817BAB00
	private static ulong Ch(ulong x, ulong y, ulong z) { }

	// RVA: 0x17BAD40 Offset: 0x17BA140 VA: 0x1817BAD40
	private static ulong Maj(ulong x, ulong y, ulong z) { }

	// RVA: 0x17BC990 Offset: 0x17BBD90 VA: 0x1817BC990
	private static ulong Sigma_0(ulong x) { }

	// RVA: 0x17BCA10 Offset: 0x17BBE10 VA: 0x1817BCA10
	private static ulong Sigma_1(ulong x) { }

	// RVA: 0x17BD010 Offset: 0x17BC410 VA: 0x1817BD010
	private static ulong sigma_0(ulong x) { }

	// RVA: 0x17BD090 Offset: 0x17BC490 VA: 0x1817BD090
	private static ulong sigma_1(ulong x) { }

	// RVA: 0x17BC100 Offset: 0x17BB500 VA: 0x1817BC100
	private static void SHA512Expand(ulong* x) { }

	// RVA: 0x17BCEA0 Offset: 0x17BC2A0 VA: 0x1817BCEA0
	private static void .cctor() { }

}

internal class SHA1Internal // TypeDefIndex: 1011
{	// Fields
	private uint[] _H; // 0x10
	private ulong count; // 0x18
	private byte[] _ProcessingBuffer; // 0x20
	private int _ProcessingBufferCount; // 0x28
	private uint[] buff; // 0x30

	// Methods

	// RVA: 0x17B8950 Offset: 0x17B7D50 VA: 0x1817B8950
	public void .ctor() { }

	// RVA: 0x17B7080 Offset: 0x17B6480 VA: 0x1817B7080
	public void HashCore(byte[] rgb, int ibStart, int cbSize) { }

	// RVA: 0x17B71A0 Offset: 0x17B65A0 VA: 0x1817B71A0
	public byte[] HashFinal() { }

	// RVA: 0x17B7E80 Offset: 0x17B7280 VA: 0x1817B7E80
	public void Initialize() { }

	// RVA: 0x17B7F60 Offset: 0x17B7360 VA: 0x1817B7F60
	private void ProcessBlock(byte[] inputBuffer, uint inputOffset) { }

	// RVA: 0x17B72B0 Offset: 0x17B66B0 VA: 0x1817B72B0
	private static void InitialiseBuff(uint[] buff, byte[] input, uint inputOffset) { }

	// RVA: 0x17B6AA0 Offset: 0x17B5EA0 VA: 0x1817B6AA0
	private static void FillBuff(uint[] buff) { }

	// RVA: 0x17B8790 Offset: 0x17B7B90 VA: 0x1817B8790
	private void ProcessFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x17B6930 Offset: 0x17B5D30 VA: 0x1817B6930
	internal void AddLength(ulong length, byte[] buffer, int position) { }

}

public sealed class SHA1CryptoServiceProvider : SHA1 // TypeDefIndex: 1012
{	// Fields
	private SHA1Internal sha; // 0x28

	// Methods

	// RVA: 0x17B6840 Offset: 0x17B5C40 VA: 0x1817B6840
	public void .ctor() { }

	// RVA: 0x16FE080 Offset: 0x16FD480 VA: 0x1816FE080 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x17B65C0 Offset: 0x17B59C0 VA: 0x1817B65C0 Slot: 15
	protected override void Dispose(bool disposing) { }

	// RVA: 0x17B65D0 Offset: 0x17B59D0 VA: 0x1817B65D0 Slot: 17
	protected override void HashCore(byte[] rgb, int ibStart, int cbSize) { }

	// RVA: 0x17B6700 Offset: 0x17B5B00 VA: 0x1817B6700 Slot: 18
	protected override byte[] HashFinal() { }

	// RVA: 0x17B6820 Offset: 0x17B5C20 VA: 0x1817B6820 Slot: 16
	public override void Initialize() { }

}

