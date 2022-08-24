internal class UnityTlsContext : MobileTlsContext // TypeDefIndex: 2509
{
	private UnityTls.unitytls_tlsctx* tlsContext; 
	private UnityTls.unitytls_x509list* requestedClientCertChain; 
	private UnityTls.unitytls_key* requestedClientKey; 
	private UnityTls.unitytls_tlsctx_read_callback readCallback; 
	private UnityTls.unitytls_tlsctx_write_callback writeCallback; 
	private UnityTls.unitytls_tlsctx_certificate_callback certificateCallback; 
	private UnityTls.unitytls_tlsctx_x509verify_callback verifyCallback; 
	private X509Certificate localClientCertificate; 
	private X509Certificate remoteCertificate; 
	private MonoTlsConnectionInfo connectioninfo; 
	private bool isAuthenticated; 
	private bool hasContext; 
	private bool closedGraceful; 
	private byte[] writeBuffer; 
	private byte[] readBuffer; 
	private GCHandle handle; 
	private Exception lastException; 

public override bool IsAuthenticated { get; }
internal override X509Certificate LocalClientCertificate { get; }


public void .ctor(MobileAuthenticatedStream parent, bool serverMode, string targetHost, SslProtocols enabledProtocols, X509Certificate serverCertificate, X509CertificateCollection clientCertificates, bool askForClientCert) { }

private static void ExtractNativeKeyAndChainFromManagedCertificate(X509Certificate cert, UnityTls.unitytls_errorstate* errorState, out UnityTls.unitytls_x509list* nativeCertChain, out UnityTls.unitytls_key* nativeKey) { }

public override bool get_IsAuthenticated() { }

internal override X509Certificate get_LocalClientCertificate() { }

public override ValueTuple<int, bool> Read(byte[] buffer, int offset, int count) { }

public override ValueTuple<int, bool> Write(byte[] buffer, int offset, int count) { }

public override void Shutdown() { }

protected override void Dispose(bool disposing) { }

public override void StartHandshake() { }

public override bool ProcessHandshake() { }

public override void FinishHandshake() { }

	[MonoPInvokeCallbackAttribute] 
private static IntPtr WriteCallback(void* userData, byte* data, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState) { }

private IntPtr WriteCallback(byte* data, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState) { }

	[MonoPInvokeCallbackAttribute] 
private static IntPtr ReadCallback(void* userData, byte* buffer, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState) { }

private IntPtr ReadCallback(byte* buffer, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState) { }

	[MonoPInvokeCallbackAttribute] 
private static UnityTls.unitytls_x509verify_result VerifyCallback(void* userData, UnityTls.unitytls_x509list_ref chain, UnityTls.unitytls_errorstate* errorState) { }

private UnityTls.unitytls_x509verify_result VerifyCallback(UnityTls.unitytls_x509list_ref chain, UnityTls.unitytls_errorstate* errorState) { }

	[MonoPInvokeCallbackAttribute] 
private static void CertificateCallback(void* userData, UnityTls.unitytls_tlsctx* ctx, byte* cn, IntPtr cnLen, UnityTls.unitytls_x509name* caList, IntPtr caListLen, UnityTls.unitytls_x509list_ref* chain, UnityTls.unitytls_key_ref* key, UnityTls.unitytls_errorstate* errorState) { }

private void CertificateCallback(UnityTls.unitytls_tlsctx* ctx, byte* cn, IntPtr cnLen, UnityTls.unitytls_x509name* caList, IntPtr caListLen, UnityTls.unitytls_x509list_ref* chain, UnityTls.unitytls_key_ref* key, UnityTls.unitytls_errorstate* errorState) { }

}

