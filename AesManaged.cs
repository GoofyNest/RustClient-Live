public sealed class AesManaged : Aes // TypeDefIndex: 3194
{
	private RijndaelManaged m_rijndael; 

	public override int FeedbackSize { get; }
	public override byte[] IV { get; set; }
	public override byte[] Key { get; set; }
	public override int KeySize { get; set; }
	public override CipherMode Mode { get; set; }
	public override PaddingMode Padding { get; set; }


	public void .ctor() { }

	public override int get_FeedbackSize() { }

	public override byte[] get_IV() { }

	public override void set_IV(byte[] value) { }

	public override byte[] get_Key() { }

	public override void set_Key(byte[] value) { }

	public override int get_KeySize() { }

	public override void set_KeySize(int value) { }

	public override CipherMode get_Mode() { }

	public override void set_Mode(CipherMode value) { }

	public override PaddingMode get_Padding() { }

	public override void set_Padding(PaddingMode value) { }

	public override ICryptoTransform CreateDecryptor() { }

	public override ICryptoTransform CreateDecryptor(byte[] key, byte[] iv) { }

	public override ICryptoTransform CreateEncryptor() { }

	public override ICryptoTransform CreateEncryptor(byte[] key, byte[] iv) { }

	protected override void Dispose(bool disposing) { }

	public override void GenerateIV() { }

	public override void GenerateKey() { }

}

