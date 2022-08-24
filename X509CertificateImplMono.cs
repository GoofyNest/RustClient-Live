internal sealed class X509CertificateImplMono : X509CertificateImpl // TypeDefIndex: 1019
{
	private X509Certificate x509; 

	public override bool IsValid { get; }


	public void .ctor(X509Certificate x509) { }

	public override bool get_IsValid() { }

	public override X509CertificateImpl Clone() { }

	public override string GetIssuerName(bool legacyV1Mode) { }

	public override string GetSubjectName(bool legacyV1Mode) { }

	public override byte[] GetRawCertData() { }

	protected override byte[] GetCertHash(bool lazy) { }

	public override DateTime GetValidFrom() { }

	public override DateTime GetValidUntil() { }

	public override bool Equals(X509CertificateImpl other, out bool result) { }

	public override byte[] GetSerialNumber() { }

	public override string ToString(bool full) { }

	protected override void Dispose(bool disposing) { }

}

