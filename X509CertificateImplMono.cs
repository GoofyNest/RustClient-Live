internal sealed class X509CertificateImplMono : X509CertificateImpl // TypeDefIndex: 1019
{	// Fields
	private X509Certificate x509; // 0x18

	// Properties
	public override bool IsValid { get; }

	// Methods

	// RVA: 0x10B06F0 Offset: 0x10AFAF0 VA: 0x1810B06F0
	public void .ctor(X509Certificate x509) { }

	// RVA: 0x17C5ED0 Offset: 0x17C52D0 VA: 0x1817C5ED0 Slot: 5
	public override bool get_IsValid() { }

	// RVA: 0x17C5660 Offset: 0x17C4A60 VA: 0x1817C5660 Slot: 6
	public override X509CertificateImpl Clone() { }

	// RVA: 0x17C58B0 Offset: 0x17C4CB0 VA: 0x1817C58B0 Slot: 7
	public override string GetIssuerName(bool legacyV1Mode) { }

	// RVA: 0x17C5AB0 Offset: 0x17C4EB0 VA: 0x1817C5AB0 Slot: 8
	public override string GetSubjectName(bool legacyV1Mode) { }

	// RVA: 0x17C59B0 Offset: 0x17C4DB0 VA: 0x1817C59B0 Slot: 9
	public override byte[] GetRawCertData() { }

	// RVA: 0x17C5710 Offset: 0x17C4B10 VA: 0x1817C5710 Slot: 12
	protected override byte[] GetCertHash(bool lazy) { }

	// RVA: 0x17C5BB0 Offset: 0x17C4FB0 VA: 0x1817C5BB0 Slot: 10
	public override DateTime GetValidFrom() { }

	// RVA: 0x17C5C30 Offset: 0x17C5030 VA: 0x1817C5C30 Slot: 11
	public override DateTime GetValidUntil() { }

	// RVA: 0x14D1D20 Offset: 0x14D1120 VA: 0x1814D1D20 Slot: 13
	public override bool Equals(X509CertificateImpl other, out bool result) { }

	// RVA: 0x17C5A30 Offset: 0x17C4E30 VA: 0x1817C5A30 Slot: 14
	public override byte[] GetSerialNumber() { }

	// RVA: 0x17C5CB0 Offset: 0x17C50B0 VA: 0x1817C5CB0 Slot: 15
	public override string ToString(bool full) { }

	// RVA: 0xA792C0 Offset: 0xA786C0 VA: 0x180A792C0 Slot: 16
	protected override void Dispose(bool disposing) { }

}

