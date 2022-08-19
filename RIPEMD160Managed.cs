public class RIPEMD160Managed : RIPEMD160 // TypeDefIndex: 980
{	// Fields
	private byte[] _buffer; // 0x28
	private long _count; // 0x30
	private uint[] _stateMD160; // 0x38
	private uint[] _blockDWords; // 0x40

	// Methods

	// RVA: 0x1703E90 Offset: 0x1703290 VA: 0x181703E90
	public void .ctor() { }

	// RVA: 0x1701970 Offset: 0x1700D70 VA: 0x181701970 Slot: 16
	public override void Initialize() { }

	// RVA: 0x1701860 Offset: 0x1700C60 VA: 0x181701860 Slot: 17
	protected override void HashCore(byte[] rgb, int ibStart, int cbSize) { }

	// RVA: 0x1701870 Offset: 0x1700C70 VA: 0x181701870 Slot: 18
	protected override byte[] HashFinal() { }

	// RVA: 0x1701890 Offset: 0x1700C90 VA: 0x181701890
	private void InitializeState() { }

	// RVA: 0x1703D20 Offset: 0x1703120 VA: 0x181703D20
	private void _HashData(byte[] partIn, int ibStart, int cbSize) { }

	// RVA: 0x1703AE0 Offset: 0x1702EE0 VA: 0x181703AE0
	private byte[] _EndHash() { }

	// RVA: 0x17019D0 Offset: 0x1700DD0 VA: 0x1817019D0
	private static void MDTransform(uint* blockDWords, uint* state, byte* block) { }

	// RVA: 0x1701830 Offset: 0x1700C30 VA: 0x181701830
	private static uint F(uint x, uint y, uint z) { }

	// RVA: 0x1701840 Offset: 0x1700C40 VA: 0x181701840
	private static uint G(uint x, uint y, uint z) { }

	// RVA: 0x1701850 Offset: 0x1700C50 VA: 0x181701850
	private static uint H(uint x, uint y, uint z) { }

	// RVA: 0x1701880 Offset: 0x1700C80 VA: 0x181701880
	private static uint I(uint x, uint y, uint z) { }

	// RVA: 0x17019C0 Offset: 0x1700DC0 VA: 0x1817019C0
	private static uint J(uint x, uint y, uint z) { }

}

