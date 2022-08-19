public abstract class DSA : AsymmetricAlgorithm // TypeDefIndex: 956
{	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	protected void .ctor() { }

	// RVA: 0x16FAD70 Offset: 0x16FA170 VA: 0x1816FAD70
	public static DSA Create() { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract bool VerifySignature(byte[] rgbHash, byte[] rgbSignature);

	// RVA: 0x16FADD0 Offset: 0x16FA1D0 VA: 0x1816FADD0 Slot: 8
	public override void FromXmlString(string xmlString) { }

	// RVA: 0x16FB5E0 Offset: 0x16FA9E0 VA: 0x1816FB5E0 Slot: 9
	public override string ToXmlString(bool includePrivateParameters) { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract DSAParameters ExportParameters(bool includePrivateParameters);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void ImportParameters(DSAParameters parameters);

}

