public abstract class SymmetricAlgorithm : IDisposable // TypeDefIndex: 999
{	// Fields
	protected int BlockSizeValue; // 0x10
	protected int FeedbackSizeValue; // 0x14
	protected byte[] IVValue; // 0x18
	protected byte[] KeyValue; // 0x20
	protected KeySizes[] LegalBlockSizesValue; // 0x28
	protected KeySizes[] LegalKeySizesValue; // 0x30
	protected int KeySizeValue; // 0x38
	protected CipherMode ModeValue; // 0x3C
	protected PaddingMode PaddingValue; // 0x40

	// Properties
	public virtual int BlockSize { get; set; }
	public virtual int FeedbackSize { get; }
	public virtual byte[] IV { get; set; }
	public virtual byte[] Key { get; set; }
	public virtual KeySizes[] LegalKeySizes { get; }
	public virtual int KeySize { get; set; }
	public virtual CipherMode Mode { get; set; }
	public virtual PaddingMode Padding { get; set; }

	// Methods

	// RVA: 0x17C08F0 Offset: 0x17BFCF0 VA: 0x1817C08F0
	protected void .ctor() { }

	// RVA: 0x17C07F0 Offset: 0x17BFBF0 VA: 0x1817C07F0 Slot: 4
	public void Dispose() { }

	// RVA: 0x17C0600 Offset: 0x17BFA00 VA: 0x1817C0600
	public void Clear() { }

	// RVA: 0x17C0780 Offset: 0x17BFB80 VA: 0x1817C0780 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x36A480 Offset: 0x369880 VA: 0x18036A480 Slot: 6
	public virtual int get_BlockSize() { }

	// RVA: 0x17C0AE0 Offset: 0x17BFEE0 VA: 0x1817C0AE0 Slot: 7
	public virtual void set_BlockSize(int value) { }

	// RVA: 0x596230 Offset: 0x595630 VA: 0x180596230 Slot: 8
	public virtual int get_FeedbackSize() { }

	// RVA: 0x17C0920 Offset: 0x17BFD20 VA: 0x1817C0920 Slot: 9
	public virtual byte[] get_IV() { }

	// RVA: 0x17C0C10 Offset: 0x17C0010 VA: 0x1817C0C10 Slot: 10
	public virtual void set_IV(byte[] value) { }

	// RVA: 0x17C09C0 Offset: 0x17BFDC0 VA: 0x1817C09C0 Slot: 11
	public virtual byte[] get_Key() { }

	// RVA: 0x17C0DC0 Offset: 0x17C01C0 VA: 0x1817C0DC0 Slot: 12
	public virtual void set_Key(byte[] value) { }

	// RVA: 0x17C0A60 Offset: 0x17BFE60 VA: 0x1817C0A60 Slot: 13
	public virtual KeySizes[] get_LegalKeySizes() { }

	// RVA: 0x516B70 Offset: 0x515F70 VA: 0x180516B70 Slot: 14
	public virtual int get_KeySize() { }

	// RVA: 0x17C0D20 Offset: 0x17C0120 VA: 0x1817C0D20 Slot: 15
	public virtual void set_KeySize(int value) { }

	// RVA: 0x5FC790 Offset: 0x5FBB90 VA: 0x1805FC790 Slot: 16
	public virtual CipherMode get_Mode() { }

	// RVA: 0x17C0EF0 Offset: 0x17C02F0 VA: 0x1817C0EF0 Slot: 17
	public virtual void set_Mode(CipherMode value) { }

	// RVA: 0x5F7C80 Offset: 0x5F7080 VA: 0x1805F7C80 Slot: 18
	public virtual PaddingMode get_Padding() { }

	// RVA: 0x17C0F70 Offset: 0x17C0370 VA: 0x1817C0F70 Slot: 19
	public virtual void set_Padding(PaddingMode value) { }

	// RVA: 0x17C0860 Offset: 0x17BFC60 VA: 0x1817C0860
	public bool ValidKeySize(int bitLength) { }

	// RVA: 0x17C0700 Offset: 0x17BFB00 VA: 0x1817C0700
	public static SymmetricAlgorithm Create(string algName) { }

	// RVA: 0x17C06A0 Offset: 0x17BFAA0 VA: 0x1817C06A0 Slot: 20
	public virtual ICryptoTransform CreateEncryptor() { }

	// RVA: -1 Offset: -1 Slot: 21
	public abstract ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV);

	// RVA: 0x17C0640 Offset: 0x17BFA40 VA: 0x1817C0640 Slot: 22
	public virtual ICryptoTransform CreateDecryptor() { }

	// RVA: -1 Offset: -1 Slot: 23
	public abstract ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV);

	// RVA: -1 Offset: -1 Slot: 24
	public abstract void GenerateKey();

	// RVA: -1 Offset: -1 Slot: 25
	public abstract void GenerateIV();

}

