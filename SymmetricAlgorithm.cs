public abstract class SymmetricAlgorithm : IDisposable // TypeDefIndex: 999
{	protected int BlockSizeValue; // 0x10
	protected int FeedbackSizeValue; // 0x14
	protected byte[] IVValue; // 0x18
	protected byte[] KeyValue; // 0x20
	protected KeySizes[] LegalBlockSizesValue; // 0x28
	protected KeySizes[] LegalKeySizesValue; // 0x30
	protected int KeySizeValue; // 0x38
	protected CipherMode ModeValue; // 0x3C
	protected PaddingMode PaddingValue; // 0x40

	public virtual int BlockSize { get; set; }
	public virtual int FeedbackSize { get; }
	public virtual byte[] IV { get; set; }
	public virtual byte[] Key { get; set; }
	public virtual KeySizes[] LegalKeySizes { get; }
	public virtual int KeySize { get; set; }
	public virtual CipherMode Mode { get; set; }
	public virtual PaddingMode Padding { get; set; }


	protected void .ctor() { }

	public void Dispose() { }

	public void Clear() { }

	protected virtual void Dispose(bool disposing) { }

	public virtual int get_BlockSize() { }

	public virtual void set_BlockSize(int value) { }

	public virtual int get_FeedbackSize() { }

	public virtual byte[] get_IV() { }

	public virtual void set_IV(byte[] value) { }

	public virtual byte[] get_Key() { }

	public virtual void set_Key(byte[] value) { }

	public virtual KeySizes[] get_LegalKeySizes() { }

	public virtual int get_KeySize() { }

	public virtual void set_KeySize(int value) { }

	public virtual CipherMode get_Mode() { }

	public virtual void set_Mode(CipherMode value) { }

	public virtual PaddingMode get_Padding() { }

	public virtual void set_Padding(PaddingMode value) { }

	public bool ValidKeySize(int bitLength) { }

	public static SymmetricAlgorithm Create(string algName) { }

	public virtual ICryptoTransform CreateEncryptor() { }

	public abstract ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV);

	public virtual ICryptoTransform CreateDecryptor() { }

	public abstract ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV);

	public abstract void GenerateKey();

	public abstract void GenerateIV();

}

