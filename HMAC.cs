public abstract class HMAC : KeyedHashAlgorithm // TypeDefIndex: 960
{	// Fields
	private int blockSizeValue; // 0x30
	internal string m_hashName; // 0x38
	internal HashAlgorithm m_hash1; // 0x40
	internal HashAlgorithm m_hash2; // 0x48
	private byte[] m_inner; // 0x50
	private byte[] m_outer; // 0x58
	private bool m_hashing; // 0x60

	// Properties
	protected int BlockSizeValue { get; set; }
	public override byte[] Key { get; set; }

	// Methods

	// RVA: 0xA178C0 Offset: 0xA16CC0 VA: 0x180A178C0
	protected int get_BlockSizeValue() { }

	// RVA: 0xA17E80 Offset: 0xA17280 VA: 0x180A17E80
	protected void set_BlockSizeValue(int value) { }

	// RVA: 0x16FC930 Offset: 0x16FBD30 VA: 0x1816FC930
	private void UpdateIOPadBuffers() { }

	// RVA: 0x16FC700 Offset: 0x16FBB00 VA: 0x1816FC700
	internal void InitializeKey(byte[] key) { }

	// RVA: 0x16FCB00 Offset: 0x16FBF00 VA: 0x1816FCB00 Slot: 19
	public override byte[] get_Key() { }

	// RVA: 0x16FCB80 Offset: 0x16FBF80 VA: 0x1816FCB80 Slot: 20
	public override void set_Key(byte[] value) { }

	// RVA: 0x16FC3D0 Offset: 0x16FB7D0 VA: 0x1816FC3D0
	public static HMAC Create() { }

	// RVA: 0x16FC8E0 Offset: 0x16FBCE0 VA: 0x1816FC8E0 Slot: 16
	public override void Initialize() { }

	// RVA: 0x16FC4D0 Offset: 0x16FB8D0 VA: 0x1816FC4D0 Slot: 17
	protected override void HashCore(byte[] rgb, int ib, int cb) { }

	// RVA: 0x16FC580 Offset: 0x16FB980 VA: 0x1816FC580 Slot: 18
	protected override byte[] HashFinal() { }

	// RVA: 0x16FC420 Offset: 0x16FB820 VA: 0x1816FC420 Slot: 15
	protected override void Dispose(bool disposing) { }

	// RVA: 0x16FCAF0 Offset: 0x16FBEF0 VA: 0x1816FCAF0
	protected void .ctor() { }

}

