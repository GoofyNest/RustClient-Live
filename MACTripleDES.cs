public class MACTripleDES : KeyedHashAlgorithm // TypeDefIndex: 969
{	// Fields
	private ICryptoTransform m_encryptor; // 0x30
	private CryptoStream _cs; // 0x38
	private TailStream _ts; // 0x40
	private int m_bytesPerBlock; // 0x48
	private TripleDES des; // 0x50

	// Methods

	// RVA: 0x16FDCF0 Offset: 0x16FD0F0 VA: 0x1816FDCF0
	public void .ctor() { }

	// RVA: 0x814ED0 Offset: 0x8142D0 VA: 0x180814ED0 Slot: 16
	public override void Initialize() { }

	// RVA: 0x16FD9D0 Offset: 0x16FCDD0 VA: 0x1816FD9D0 Slot: 17
	protected override void HashCore(byte[] rgbData, int ibStart, int cbSize) { }

	// RVA: 0x16FDB70 Offset: 0x16FCF70 VA: 0x1816FDB70 Slot: 18
	protected override byte[] HashFinal() { }

	// RVA: 0x16FD930 Offset: 0x16FCD30 VA: 0x1816FD930 Slot: 15
	protected override void Dispose(bool disposing) { }

}

