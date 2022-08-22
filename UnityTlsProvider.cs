internal class UnityTlsProvider : MonoTlsProvider // TypeDefIndex: 2511
{	public override string Name { get; }
	public override Guid ID { get; }
	public override bool SupportsSslStream { get; }
	public override bool SupportsMonoExtensions { get; }
	public override bool SupportsConnectionInfo { get; }
	internal override bool SupportsCleanShutdown { get; }
	public override SslProtocols SupportedProtocols { get; }


	public override string get_Name() { }

	public override Guid get_ID() { }

	public override bool get_SupportsSslStream() { }

	public override bool get_SupportsMonoExtensions() { }

	public override bool get_SupportsConnectionInfo() { }

	internal override bool get_SupportsCleanShutdown() { }

	public override SslProtocols get_SupportedProtocols() { }

	public override IMonoSslStream CreateSslStream(Stream innerStream, bool leaveInnerStreamOpen, MonoTlsSettings settings) { }

	internal override IMonoSslStream CreateSslStreamInternal(SslStream sslStream, Stream innerStream, bool leaveInnerStreamOpen, MonoTlsSettings settings) { }

	internal override bool ValidateCertificate(ICertificateValidator2 validator, string targetHost, bool serverMode, X509CertificateCollection certificates, bool wantsChain, ref X509Chain chain, ref MonoSslPolicyErrors errors, ref int status11) { }

	public void .ctor() { }

}

