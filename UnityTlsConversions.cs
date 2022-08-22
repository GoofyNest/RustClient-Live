internal static class UnityTlsConversions // TypeDefIndex: 2510
{
	public static UnityTls.unitytls_protocol GetMinProtocol(SslProtocols protocols) { }

	public static UnityTls.unitytls_protocol GetMaxProtocol(SslProtocols protocols) { }

	public static TlsProtocols ConvertProtocolVersion(UnityTls.unitytls_protocol protocol) { }

	public static AlertDescription VerifyResultToAlertDescription(UnityTls.unitytls_x509verify_result verifyResult, AlertDescription defaultAlert = 80) { }

	public static MonoSslPolicyErrors VerifyResultToPolicyErrror(UnityTls.unitytls_x509verify_result verifyResult) { }

}

