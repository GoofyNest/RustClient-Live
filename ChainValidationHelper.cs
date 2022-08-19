internal class ChainValidationHelper : ICertificateValidator2, ICertificateValidator // TypeDefIndex: 2543
{	// Fields
	private readonly object sender; // 0x10
	private readonly MonoTlsSettings settings; // 0x18
	private readonly MonoTlsProvider provider; // 0x20
	private readonly ServerCertValidationCallback certValidationCallback; // 0x28
	private readonly LocalCertSelectionCallback certSelectionCallback; // 0x30
	private readonly ServerCertValidationCallbackWrapper callbackWrapper; // 0x38
	private readonly MonoTlsStream tlsStream; // 0x40
	private readonly HttpWebRequest request; // 0x48

	// Properties
	public MonoTlsSettings Settings { get; }

	// Methods

	// RVA: 0x12108D0 Offset: 0x120FCD0 VA: 0x1812108D0
	internal static ICertificateValidator GetInternalValidator(MonoTlsProvider provider, MonoTlsSettings settings) { }

	// RVA: 0x12107E0 Offset: 0x120FBE0 VA: 0x1812107E0
	internal static ChainValidationHelper Create(MonoTlsProvider provider, ref MonoTlsSettings settings, MonoTlsStream stream) { }

	// RVA: 0x12111E0 Offset: 0x12105E0 VA: 0x1812111E0
	private void .ctor(MonoTlsProvider provider, MonoTlsSettings settings, bool cloneSettings, MonoTlsStream stream, ServerCertValidationCallbackWrapper callbackWrapper) { }

	// RVA: 0x1210890 Offset: 0x120FC90 VA: 0x181210890
	private static X509Certificate DefaultSelectionCallback(string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers) { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 5
	public MonoTlsSettings get_Settings() { }

	// RVA: 0x1210970 Offset: 0x120FD70 VA: 0x181210970 Slot: 6
	public bool SelectClientCertificate(string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers, out X509Certificate clientCertificate) { }

	// RVA: 0x12109D0 Offset: 0x120FDD0 VA: 0x1812109D0 Slot: 7
	public ValidationResult ValidateCertificate(string host, bool serverMode, X509CertificateCollection certs) { }

	// RVA: 0x1210AF0 Offset: 0x120FEF0 VA: 0x181210AF0 Slot: 4
	public ValidationResult ValidateCertificate(string host, bool serverMode, X509Certificate leaf, X509Chain chain) { }

	// RVA: 0x1210BF0 Offset: 0x120FFF0 VA: 0x181210BF0
	private ValidationResult ValidateChain(string host, bool server, X509Certificate leaf, X509Chain chain, X509CertificateCollection certs, SslPolicyErrors errors) { }

	// RVA: 0x1210CE0 Offset: 0x12100E0 VA: 0x181210CE0
	private ValidationResult ValidateChain(string host, bool server, X509Certificate leaf, ref X509Chain chain, X509CertificateCollection certs, SslPolicyErrors errors) { }

}

