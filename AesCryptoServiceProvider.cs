public sealed class AesCryptoServiceProvider : Aes // TypeDefIndex: 3195
{	// Properties
	public override byte[] IV { get; set; }
	public override byte[] Key { get; set; }
	public override int KeySize { get; set; }
	public override int FeedbackSize { get; }
	public override CipherMode Mode { get; set; }
	public override PaddingMode Padding { get; set; }

	// Methods

	// RVA: 0x221BAF0 Offset: 0x221AEF0 VA: 0x18221BAF0
	public void .ctor() { }

	// RVA: 0x221BA90 Offset: 0x221AE90 VA: 0x18221BA90 Slot: 25
	public override void GenerateIV() { }

	// RVA: 0x221BAC0 Offset: 0x221AEC0 VA: 0x18221BAC0 Slot: 24
	public override void GenerateKey() { }

	// RVA: 0x221B8C0 Offset: 0x221ACC0 VA: 0x18221B8C0 Slot: 23
	public override ICryptoTransform CreateDecryptor(byte[] key, byte[] iv) { }

	// RVA: 0x221B9A0 Offset: 0x221ADA0 VA: 0x18221B9A0 Slot: 21
	public override ICryptoTransform CreateEncryptor(byte[] key, byte[] iv) { }

	// RVA: 0x221BB50 Offset: 0x221AF50 VA: 0x18221BB50 Slot: 9
	public override byte[] get_IV() { }

	// RVA: 0x221BB70 Offset: 0x221AF70 VA: 0x18221BB70 Slot: 10
	public override void set_IV(byte[] value) { }

	// RVA: 0x221BB60 Offset: 0x221AF60 VA: 0x18221BB60 Slot: 11
	public override byte[] get_Key() { }

	// RVA: 0x221BB90 Offset: 0x221AF90 VA: 0x18221BB90 Slot: 12
	public override void set_Key(byte[] value) { }

	// RVA: 0x516B70 Offset: 0x515F70 VA: 0x180516B70 Slot: 14
	public override int get_KeySize() { }

	// RVA: 0x221BB80 Offset: 0x221AF80 VA: 0x18221BB80 Slot: 15
	public override void set_KeySize(int value) { }

	// RVA: 0x596230 Offset: 0x595630 VA: 0x180596230 Slot: 8
	public override int get_FeedbackSize() { }

	// RVA: 0x5FC790 Offset: 0x5FBB90 VA: 0x1805FC790 Slot: 16
	public override CipherMode get_Mode() { }

	// RVA: 0x221BBA0 Offset: 0x221AFA0 VA: 0x18221BBA0 Slot: 17
	public override void set_Mode(CipherMode value) { }

	// RVA: 0x5F7C80 Offset: 0x5F7080 VA: 0x1805F7C80 Slot: 18
	public override PaddingMode get_Padding() { }

	// RVA: 0x221BC20 Offset: 0x221B020 VA: 0x18221BC20 Slot: 19
	public override void set_Padding(PaddingMode value) { }

	// RVA: 0x17C0640 Offset: 0x17BFA40 VA: 0x1817C0640 Slot: 22
	public override ICryptoTransform CreateDecryptor() { }

	// RVA: 0x17C06A0 Offset: 0x17BFAA0 VA: 0x1817C06A0 Slot: 20
	public override ICryptoTransform CreateEncryptor() { }

	// RVA: 0x221BA80 Offset: 0x221AE80 VA: 0x18221BA80 Slot: 5
	protected override void Dispose(bool disposing) { }

}

