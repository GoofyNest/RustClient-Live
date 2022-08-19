public sealed class RC2CryptoServiceProvider : RC2 // TypeDefIndex: 974
{	// Fields
	private bool m_use40bitSalt; // 0x50
	private static KeySizes[] s_legalKeySizes; // 0x0

	// Properties
	public override int EffectiveKeySize { get; }

	// Methods

	// RVA: 0x16FFE60 Offset: 0x16FF260 VA: 0x1816FFE60
	public void .ctor() { }

	// RVA: 0x516B70 Offset: 0x515F70 VA: 0x180516B70 Slot: 26
	public override int get_EffectiveKeySize() { }

	// RVA: 0x16FFBC0 Offset: 0x16FEFC0 VA: 0x1816FFBC0 Slot: 21
	public override ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV) { }

	// RVA: 0x16FFB00 Offset: 0x16FEF00 VA: 0x1816FFB00 Slot: 23
	public override ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV) { }

	// RVA: 0x16FFD00 Offset: 0x16FF100 VA: 0x1816FFD00 Slot: 24
	public override void GenerateKey() { }

	// RVA: 0x16FFC80 Offset: 0x16FF080 VA: 0x1816FFC80 Slot: 25
	public override void GenerateIV() { }

	// RVA: 0x16FFD80 Offset: 0x16FF180 VA: 0x1816FFD80
	private static void .cctor() { }

}

