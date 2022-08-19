internal class UnityTlsContext : MobileTlsContext // TypeDefIndex: 2509
{	// Fields
	private UnityTls.unitytls_tlsctx* tlsContext; // 0x58
	private UnityTls.unitytls_x509list* requestedClientCertChain; // 0x60
	private UnityTls.unitytls_key* requestedClientKey; // 0x68
	private UnityTls.unitytls_tlsctx_read_callback readCallback; // 0x70
	private UnityTls.unitytls_tlsctx_write_callback writeCallback; // 0x78
	private UnityTls.unitytls_tlsctx_certificate_callback certificateCallback; // 0x80
	private UnityTls.unitytls_tlsctx_x509verify_callback verifyCallback; // 0x88
	private X509Certificate localClientCertificate; // 0x90
	private X509Certificate remoteCertificate; // 0x98
	private MonoTlsConnectionInfo connectioninfo; // 0xA0
	private bool isAuthenticated; // 0xA8
	private bool hasContext; // 0xA9
	private bool closedGraceful; // 0xAA
	private byte[] writeBuffer; // 0xB0
	private byte[] readBuffer; // 0xB8
	private GCHandle handle; // 0xC0
	private Exception lastException; // 0xC8

	// Properties
	public override bool IsAuthenticated { get; }
	internal override X509Certificate LocalClientCertificate { get; }

	// Methods

	// RVA: 0x121AB20 Offset: 0x1219F20 VA: 0x18121AB20
	public void .ctor(MobileAuthenticatedStream parent, bool serverMode, string targetHost, SslProtocols enabledProtocols, X509Certificate serverCertificate, X509CertificateCollection clientCertificates, bool askForClientCert) { }

	// RVA: 0x1219270 Offset: 0x1218670 VA: 0x181219270
	private static void ExtractNativeKeyAndChainFromManagedCertificate(X509Certificate cert, UnityTls.unitytls_errorstate* errorState, out UnityTls.unitytls_x509list* nativeCertChain, out UnityTls.unitytls_key* nativeKey) { }

	// RVA: 0x7E83F0 Offset: 0x7E77F0 VA: 0x1807E83F0 Slot: 5
	public override bool get_IsAuthenticated() { }

	// RVA: 0x4E09F0 Offset: 0x4DFDF0 VA: 0x1804E09F0 Slot: 9
	internal override X509Certificate get_LocalClientCertificate() { }

	// RVA: 0x1219DD0 Offset: 0x12191D0 VA: 0x181219DD0 Slot: 10
	public override ValueTuple<int, bool> Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x121A930 Offset: 0x1219D30 VA: 0x18121A930 Slot: 11
	public override ValueTuple<int, bool> Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x1219FC0 Offset: 0x12193C0 VA: 0x181219FC0 Slot: 12
	public override void Shutdown() { }

	// RVA: 0x1219130 Offset: 0x1218530 VA: 0x181219130 Slot: 13
	protected override void Dispose(bool disposing) { }

	// RVA: 0x121A0D0 Offset: 0x12194D0 VA: 0x18121A0D0 Slot: 6
	public override void StartHandshake() { }

	// RVA: 0x1219660 Offset: 0x1218A60 VA: 0x181219660 Slot: 7
	public override bool ProcessHandshake() { }

	// RVA: 0x1219520 Offset: 0x1218920 VA: 0x181219520 Slot: 8
	public override void FinishHandshake() { }

	[MonoPInvokeCallbackAttribute] // RVA: 0x9F840 Offset: 0x9EC40 VA: 0x18009F840
	// RVA: 0x121A610 Offset: 0x1219A10 VA: 0x18121A610
	private static IntPtr WriteCallback(void* userData, byte* data, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x121A730 Offset: 0x1219B30 VA: 0x18121A730
	private IntPtr WriteCallback(byte* data, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState) { }

	[MonoPInvokeCallbackAttribute] // RVA: 0x9F940 Offset: 0x9ED40 VA: 0x18009F940
	// RVA: 0x1219A30 Offset: 0x1218E30 VA: 0x181219A30
	private static IntPtr ReadCallback(void* userData, byte* buffer, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x1219B50 Offset: 0x1218F50 VA: 0x181219B50
	private IntPtr ReadCallback(byte* buffer, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState) { }

	[MonoPInvokeCallbackAttribute] // RVA: 0x9F9F0 Offset: 0x9EDF0 VA: 0x18009F9F0
	// RVA: 0x121A340 Offset: 0x1219740 VA: 0x18121A340
	private static UnityTls.unitytls_x509verify_result VerifyCallback(void* userData, UnityTls.unitytls_x509list_ref chain, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x121A450 Offset: 0x1219850 VA: 0x18121A450
	private UnityTls.unitytls_x509verify_result VerifyCallback(UnityTls.unitytls_x509list_ref chain, UnityTls.unitytls_errorstate* errorState) { }

	[MonoPInvokeCallbackAttribute] // RVA: 0xA0E10 Offset: 0xA0210 VA: 0x1800A0E10
	// RVA: 0x1218BF0 Offset: 0x1217FF0 VA: 0x181218BF0
	private static void CertificateCallback(void* userData, UnityTls.unitytls_tlsctx* ctx, byte* cn, IntPtr cnLen, UnityTls.unitytls_x509name* caList, IntPtr caListLen, UnityTls.unitytls_x509list_ref* chain, UnityTls.unitytls_key_ref* key, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x1218D60 Offset: 0x1218160 VA: 0x181218D60
	private void CertificateCallback(UnityTls.unitytls_tlsctx* ctx, byte* cn, IntPtr cnLen, UnityTls.unitytls_x509name* caList, IntPtr caListLen, UnityTls.unitytls_x509list_ref* chain, UnityTls.unitytls_key_ref* key, UnityTls.unitytls_errorstate* errorState) { }

}

