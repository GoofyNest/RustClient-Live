public sealed class RC2CryptoServiceProvider : RC2 // TypeDefIndex: 974
{
	private bool m_use40bitSalt;
	private static KeySizes[] s_legalKeySizes;

	public override int EffectiveKeySize { get; }


	public void .ctor() { }

	public override int get_EffectiveKeySize() { }

	public override ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV) { }

	public override ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV) { }

	public override void GenerateKey() { }

	public override void GenerateIV() { }

	private static void .cctor() { }

}

