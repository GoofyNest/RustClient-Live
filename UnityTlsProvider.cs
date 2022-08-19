internal class UnityTlsProvider : MonoTlsProvider // TypeDefIndex: 2511
{	// Properties
	public override string Name { get; }
	public override Guid ID { get; }
	public override bool SupportsSslStream { get; }
	public override bool SupportsMonoExtensions { get; }
	public override bool SupportsConnectionInfo { get; }
	internal override bool SupportsCleanShutdown { get; }
	public override SslProtocols SupportedProtocols { get; }

	// Methods

	// RVA: 0x15B2F00 Offset: 0x15B2300 VA: 0x1815B2F00 Slot: 5
	public override string get_Name() { }

	// RVA: 0x15B2E90 Offset: 0x15B2290 VA: 0x1815B2E90 Slot: 4
	public override Guid get_ID() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 6
	public override bool get_SupportsSslStream() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 8
	public override bool get_SupportsMonoExtensions() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 7
	public override bool get_SupportsConnectionInfo() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 13
	internal override bool get_SupportsCleanShutdown() { }

	// RVA: 0x15B2F30 Offset: 0x15B2330 VA: 0x1815B2F30 Slot: 9
	public override SslProtocols get_SupportedProtocols() { }

	// RVA: 0x15B2850 Offset: 0x15B1C50 VA: 0x1815B2850 Slot: 10
	public override IMonoSslStream CreateSslStream(Stream innerStream, bool leaveInnerStreamOpen, MonoTlsSettings settings) { }

	// RVA: 0x15B2770 Offset: 0x15B1B70 VA: 0x1815B2770 Slot: 11
	internal override IMonoSslStream CreateSslStreamInternal(SslStream sslStream, Stream innerStream, bool leaveInnerStreamOpen, MonoTlsSettings settings) { }

	// RVA: 0x15B2870 Offset: 0x15B1C70 VA: 0x1815B2870 Slot: 12
	internal override bool ValidateCertificate(ICertificateValidator2 validator, string targetHost, bool serverMode, X509CertificateCollection certificates, bool wantsChain, ref X509Chain chain, ref MonoSslPolicyErrors errors, ref int status11) { }

	// RVA: 0x7992B0 Offset: 0x7986B0 VA: 0x1807992B0
	public void .ctor() { }

}

