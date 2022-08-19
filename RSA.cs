public abstract class RSA : AsymmetricAlgorithm // TypeDefIndex: 982
{	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	protected void .ctor() { }

	// RVA: 0x1704410 Offset: 0x1703810 VA: 0x181704410
	public static RSA Create() { }

	// RVA: 0x1704460 Offset: 0x1703860 VA: 0x181704460 Slot: 10
	public virtual byte[] EncryptValue(byte[] rgb) { }

	// RVA: 0x17044D0 Offset: 0x17038D0 VA: 0x1817044D0 Slot: 8
	public override void FromXmlString(string xmlString) { }

	// RVA: 0x1704A40 Offset: 0x1703E40 VA: 0x181704A40 Slot: 9
	public override string ToXmlString(bool includePrivateParameters) { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract RSAParameters ExportParameters(bool includePrivateParameters);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void ImportParameters(RSAParameters parameters);

}

