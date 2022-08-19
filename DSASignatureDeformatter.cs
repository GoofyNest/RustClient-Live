public class DSASignatureDeformatter : AsymmetricSignatureDeformatter // TypeDefIndex: 957
{	// Fields
	private DSA _dsaKey; // 0x10
	private string _oid; // 0x18

	// Methods

	// RVA: 0x16FAC10 Offset: 0x16FA010 VA: 0x1816FAC10
	public void .ctor() { }

	// RVA: 0x16FAAF0 Offset: 0x16F9EF0 VA: 0x1816FAAF0
	public void .ctor(AsymmetricAlgorithm key) { }

	// RVA: 0x16FA920 Offset: 0x16F9D20 VA: 0x1816FA920 Slot: 4
	public override void SetKey(AsymmetricAlgorithm key) { }

	// RVA: 0x16FA870 Offset: 0x16F9C70 VA: 0x1816FA870 Slot: 5
	public override void SetHashAlgorithm(string strName) { }

	// RVA: 0x16FA9E0 Offset: 0x16F9DE0 VA: 0x1816FA9E0 Slot: 6
	public override bool VerifySignature(byte[] rgbHash, byte[] rgbSignature) { }

}

