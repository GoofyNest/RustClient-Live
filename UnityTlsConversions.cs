internal static class UnityTlsConversions // TypeDefIndex: 2510
{	// Methods

	// RVA: 0x15B20A0 Offset: 0x15B14A0 VA: 0x1815B20A0
	public static UnityTls.unitytls_protocol GetMinProtocol(SslProtocols protocols) { }

	// RVA: 0x15B1F50 Offset: 0x15B1350 VA: 0x1815B1F50
	public static UnityTls.unitytls_protocol GetMaxProtocol(SslProtocols protocols) { }

	// RVA: 0x15B1F20 Offset: 0x15B1320 VA: 0x1815B1F20
	public static TlsProtocols ConvertProtocolVersion(UnityTls.unitytls_protocol protocol) { }

	// RVA: 0x15B21F0 Offset: 0x15B15F0 VA: 0x1815B21F0
	public static AlertDescription VerifyResultToAlertDescription(UnityTls.unitytls_x509verify_result verifyResult, AlertDescription defaultAlert = 80) { }

	// RVA: 0x15B26B0 Offset: 0x15B1AB0 VA: 0x1815B26B0
	public static MonoSslPolicyErrors VerifyResultToPolicyErrror(UnityTls.unitytls_x509verify_result verifyResult) { }

}

