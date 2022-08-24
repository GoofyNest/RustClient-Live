internal class ChainValidationHelper : ICertificateValidator2, ICertificateValidator // TypeDefIndex: 2543
{
	private readonly object sender; 
	private readonly MonoTlsSettings settings; 
	private readonly MonoTlsProvider provider; 
	private readonly ServerCertValidationCallback certValidationCallback; 
	private readonly LocalCertSelectionCallback certSelectionCallback; 
	private readonly ServerCertValidationCallbackWrapper callbackWrapper; 
	private readonly MonoTlsStream tlsStream; 
	private readonly HttpWebRequest request; 

public MonoTlsSettings Settings { get; }


internal static ICertificateValidator GetInternalValidator(MonoTlsProvider provider, MonoTlsSettings settings) { }

internal static ChainValidationHelper Create(MonoTlsProvider provider, ref MonoTlsSettings settings, MonoTlsStream stream) { }

private void .ctor(MonoTlsProvider provider, MonoTlsSettings settings, bool cloneSettings, MonoTlsStream stream, ServerCertValidationCallbackWrapper callbackWrapper) { }

private static X509Certificate DefaultSelectionCallback(string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers) { }

public MonoTlsSettings get_Settings() { }

public bool SelectClientCertificate(string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers, out X509Certificate clientCertificate) { }

public ValidationResult ValidateCertificate(string host, bool serverMode, X509CertificateCollection certs) { }

public ValidationResult ValidateCertificate(string host, bool serverMode, X509Certificate leaf, X509Chain chain) { }

private ValidationResult ValidateChain(string host, bool server, X509Certificate leaf, X509Chain chain, X509CertificateCollection certs, SslPolicyErrors errors) { }

private ValidationResult ValidateChain(string host, bool server, X509Certificate leaf, ref X509Chain chain, X509CertificateCollection certs, SslPolicyErrors errors) { }

}

