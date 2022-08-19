internal abstract class X509CertificateImpl : IDisposable // TypeDefIndex: 1018
{	// Fields
	private byte[] cachedCertificateHash; // 0x10

	// Properties
	public abstract bool IsValid { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool get_IsValid();

	// RVA: 0x17C6310 Offset: 0x17C5710 VA: 0x1817C6310
	protected void ThrowIfContextInvalid() { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract X509CertificateImpl Clone();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract string GetIssuerName(bool legacyV1Mode);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract string GetSubjectName(bool legacyV1Mode);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract byte[] GetRawCertData();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract DateTime GetValidFrom();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract DateTime GetValidUntil();

	// RVA: 0x17C6180 Offset: 0x17C5580 VA: 0x1817C6180
	public byte[] GetCertHash() { }

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract byte[] GetCertHash(bool lazy);

	// RVA: 0x17C6220 Offset: 0x17C5620 VA: 0x1817C6220 Slot: 2
	public override int GetHashCode() { }

	// RVA: -1 Offset: -1 Slot: 13
	public abstract bool Equals(X509CertificateImpl other, out bool result);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract byte[] GetSerialNumber();

	// RVA: -1 Offset: -1 Slot: 15
	public abstract string ToString(bool full);

	// RVA: 0x17C5F50 Offset: 0x17C5350 VA: 0x1817C5F50 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x17C5EE0 Offset: 0x17C52E0 VA: 0x1817C5EE0 Slot: 4
	public void Dispose() { }

	// RVA: 0xE31A20 Offset: 0xE30E20 VA: 0x180E31A20 Slot: 16
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x17C60E0 Offset: 0x17C54E0 VA: 0x1817C60E0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	protected void .ctor() { }

}

