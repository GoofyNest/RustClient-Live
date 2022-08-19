public class RSAPKCS1SignatureDeformatter : AsymmetricSignatureDeformatter // TypeDefIndex: 1009
{	// Fields
	private RSA rsa; // 0x10
	private string hashName; // 0x18

	// Methods

	// RVA: 0x7992B0 Offset: 0x7986B0 VA: 0x1807992B0
	public void .ctor() { }

	// RVA: 0x17B1F40 Offset: 0x17B1340 VA: 0x1817B1F40
	public void .ctor(AsymmetricAlgorithm key) { }

	// RVA: 0x17B1C70 Offset: 0x17B1070 VA: 0x1817B1C70 Slot: 5
	public override void SetHashAlgorithm(string strName) { }

	// RVA: 0x17B1CF0 Offset: 0x17B10F0 VA: 0x1817B1CF0 Slot: 4
	public override void SetKey(AsymmetricAlgorithm key) { }

	// RVA: 0x17B1DB0 Offset: 0x17B11B0 VA: 0x1817B1DB0 Slot: 6
	public override bool VerifySignature(byte[] rgbHash, byte[] rgbSignature) { }

}

