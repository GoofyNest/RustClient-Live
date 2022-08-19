internal static class X509Helper2 // TypeDefIndex: 2834
{	// Methods

	// RVA: 0x14DDF80 Offset: 0x14DD380 VA: 0x1814DDF80
	internal static void Initialize() { }

	// RVA: 0x14DE050 Offset: 0x14DD450 VA: 0x1814DE050
	internal static void ThrowIfContextInvalid(X509CertificateImpl impl) { }

	// RVA: 0x14DDEE0 Offset: 0x14DD2E0 VA: 0x1814DDEE0
	internal static X509Certificate2Impl Import(byte[] rawData, string password, X509KeyStorageFlags keyStorageFlags, bool disableProvider = False) { }

	// RVA: 0x14DDD50 Offset: 0x14DD150 VA: 0x1814DDD50
	internal static X509Certificate2Impl Import(X509Certificate cert, bool disableProvider = False) { }

	[MonoTODOAttribute] // RVA: 0xB0780 Offset: 0xAFB80 VA: 0x1800B0780
	// RVA: 0x14DDC70 Offset: 0x14DD070 VA: 0x1814DDC70
	internal static X509Certificate GetMonoCertificate(X509Certificate2 certificate) { }

	// RVA: 0x14DDAD0 Offset: 0x14DCED0 VA: 0x1814DDAD0
	internal static X509ChainImpl CreateChainImpl(bool useMachineContext) { }

	// RVA: 0x14DDFD0 Offset: 0x14DD3D0 VA: 0x1814DDFD0
	public static bool IsValid(X509ChainImpl impl) { }

	// RVA: 0x14DDFF0 Offset: 0x14DD3F0 VA: 0x1814DDFF0
	internal static void ThrowIfContextInvalid(X509ChainImpl impl) { }

	// RVA: 0x14DDC00 Offset: 0x14DD000 VA: 0x1814DDC00
	internal static Exception GetInvalidChainContextException() { }

}

private class X509Helper2.MyNativeHelper : INativeCertificateHelper // TypeDefIndex: 2835
{	// Methods

	// RVA: 0x14C4300 Offset: 0x14C3700 VA: 0x1814C4300 Slot: 4
	public X509CertificateImpl Import(X509Certificate cert) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

