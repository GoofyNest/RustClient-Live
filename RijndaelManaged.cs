public sealed class RijndaelManaged : Rijndael // TypeDefIndex: 976
{	// Methods

	// RVA: 0x17B6210 Offset: 0x17B5610 VA: 0x1817B6210
	public void .ctor() { }

	// RVA: 0x17B5DF0 Offset: 0x17B51F0 VA: 0x1817B5DF0 Slot: 21
	public override ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV) { }

	// RVA: 0x17B5C70 Offset: 0x17B5070 VA: 0x1817B5C70 Slot: 23
	public override ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV) { }

	// RVA: 0x17B6000 Offset: 0x17B5400 VA: 0x1817B6000 Slot: 24
	public override void GenerateKey() { }

	// RVA: 0x17B5F70 Offset: 0x17B5370 VA: 0x1817B5F70 Slot: 25
	public override void GenerateIV() { }

	// RVA: 0x17B6090 Offset: 0x17B5490 VA: 0x1817B6090
	private ICryptoTransform NewEncryptor(byte[] rgbKey, CipherMode mode, byte[] rgbIV, int feedbackSize, RijndaelManagedTransformMode encryptMode) { }

}

