internal abstract class X509Certificate2Impl : X509CertificateImpl // TypeDefIndex: 2817
{
	public abstract X509ExtensionCollection Extensions { get; }
	public abstract X500DistinguishedName IssuerName { get; }
	public abstract AsymmetricAlgorithm PrivateKey { get; set; }
	public abstract PublicKey PublicKey { get; }
	public abstract Oid SignatureAlgorithm { get; }
	public abstract X500DistinguishedName SubjectName { get; }
	public abstract int Version { get; }
	internal abstract X509CertificateImplCollection IntermediateCertificates { get; }
	internal abstract X509Certificate2Impl FallbackImpl { get; }


	public abstract X509ExtensionCollection get_Extensions();

	public abstract X500DistinguishedName get_IssuerName();

	public abstract AsymmetricAlgorithm get_PrivateKey();

	public abstract void set_PrivateKey(AsymmetricAlgorithm value);

	public abstract PublicKey get_PublicKey();

	public abstract Oid get_SignatureAlgorithm();

	public abstract X500DistinguishedName get_SubjectName();

	public abstract int get_Version();

	internal abstract X509CertificateImplCollection get_IntermediateCertificates();

	internal abstract X509Certificate2Impl get_FallbackImpl();

	public abstract string GetNameInfo(X509NameType nameType, bool forIssuer);

	public abstract void Import(byte[] rawData, string password, X509KeyStorageFlags keyStorageFlags);

	public abstract bool Verify(X509Certificate2 thisCertificate);

	public abstract void Reset();

	protected void .ctor() { }

}

