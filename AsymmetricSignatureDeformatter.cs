public abstract class AsymmetricSignatureDeformatter // TypeDefIndex: 939
{	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	protected void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void SetKey(AsymmetricAlgorithm key);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void SetHashAlgorithm(string strName);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool VerifySignature(byte[] rgbHash, byte[] rgbSignature);

}

