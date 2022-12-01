internal static class X509Helper2 // TypeDefIndex: 2834
{

	internal static void Initialize() { }

	internal static void ThrowIfContextInvalid(X509CertificateImpl impl) { }

	internal static X509Certificate2Impl Import(byte[] rawData, string password, X509KeyStorageFlags keyStorageFlags, bool disableProvider = False) { }

	internal static X509Certificate2Impl Import(X509Certificate cert, bool disableProvider = False) { }

	[MonoTODOAttribute]
	internal static X509Certificate GetMonoCertificate(X509Certificate2 certificate) { }

	internal static X509ChainImpl CreateChainImpl(bool useMachineContext) { }

	public static bool IsValid(X509ChainImpl impl) { }

	internal static void ThrowIfContextInvalid(X509ChainImpl impl) { }

	internal static Exception GetInvalidChainContextException() { }

}

private class X509Helper2.MyNativeHelper : INativeCertificateHelper // TypeDefIndex: 2835
{

	public X509CertificateImpl Import(X509Certificate cert) { }

	public void .ctor() { }

}

