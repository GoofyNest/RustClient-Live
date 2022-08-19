public sealed class AesManaged : Aes // TypeDefIndex: 3194
{	// Fields
	private RijndaelManaged m_rijndael; // 0x48

	// Properties
	public override int FeedbackSize { get; }
	public override byte[] IV { get; set; }
	public override byte[] Key { get; set; }
	public override int KeySize { get; set; }
	public override CipherMode Mode { get; set; }
	public override PaddingMode Padding { get; set; }

	// Methods

	// RVA: 0x221C060 Offset: 0x221B460 VA: 0x18221C060
	public void .ctor() { }

	// RVA: 0x221C1B0 Offset: 0x221B5B0 VA: 0x18221C1B0 Slot: 8
	public override int get_FeedbackSize() { }

	// RVA: 0x221C1E0 Offset: 0x221B5E0 VA: 0x18221C1E0 Slot: 9
	public override byte[] get_IV() { }

	// RVA: 0x221C2D0 Offset: 0x221B6D0 VA: 0x18221C2D0 Slot: 10
	public override void set_IV(byte[] value) { }

	// RVA: 0x221C240 Offset: 0x221B640 VA: 0x18221C240 Slot: 11
	public override byte[] get_Key() { }

	// RVA: 0x221C330 Offset: 0x221B730 VA: 0x18221C330 Slot: 12
	public override void set_Key(byte[] value) { }

	// RVA: 0x221C210 Offset: 0x221B610 VA: 0x18221C210 Slot: 14
	public override int get_KeySize() { }

	// RVA: 0x221C300 Offset: 0x221B700 VA: 0x18221C300 Slot: 15
	public override void set_KeySize(int value) { }

	// RVA: 0x221C270 Offset: 0x221B670 VA: 0x18221C270 Slot: 16
	public override CipherMode get_Mode() { }

	// RVA: 0x221C360 Offset: 0x221B760 VA: 0x18221C360 Slot: 17
	public override void set_Mode(CipherMode value) { }

	// RVA: 0x221C2A0 Offset: 0x221B6A0 VA: 0x18221C2A0 Slot: 18
	public override PaddingMode get_Padding() { }

	// RVA: 0x221C400 Offset: 0x221B800 VA: 0x18221C400 Slot: 19
	public override void set_Padding(PaddingMode value) { }

	// RVA: 0x221BC30 Offset: 0x221B030 VA: 0x18221BC30 Slot: 22
	public override ICryptoTransform CreateDecryptor() { }

	// RVA: 0x221BC60 Offset: 0x221B060 VA: 0x18221BC60 Slot: 23
	public override ICryptoTransform CreateDecryptor(byte[] key, byte[] iv) { }

	// RVA: 0x221BDC0 Offset: 0x221B1C0 VA: 0x18221BDC0 Slot: 20
	public override ICryptoTransform CreateEncryptor() { }

	// RVA: 0x221BDF0 Offset: 0x221B1F0 VA: 0x18221BDF0 Slot: 21
	public override ICryptoTransform CreateEncryptor(byte[] key, byte[] iv) { }

	// RVA: 0x221BF50 Offset: 0x221B350 VA: 0x18221BF50 Slot: 5
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1467E20 Offset: 0x1467220 VA: 0x181467E20 Slot: 25
	public override void GenerateIV() { }

	// RVA: 0x221C030 Offset: 0x221B430 VA: 0x18221C030 Slot: 24
	public override void GenerateKey() { }

}

