internal static class CallbackHelpers // TypeDefIndex: 2556
{	// Methods

	// RVA: 0x1210210 Offset: 0x120F610 VA: 0x181210210
	internal static RemoteCertificateValidationCallback MonoToPublic(MonoRemoteCertificateValidationCallback callback) { }

	// RVA: 0x1210150 Offset: 0x120F550 VA: 0x181210150
	internal static LocalCertSelectionCallback MonoToInternal(MonoLocalCertificateSelectionCallback callback) { }

}

private sealed class CallbackHelpers.<>c__DisplayClass5_0 // TypeDefIndex: 2557
{	// Fields
	public MonoRemoteCertificateValidationCallback callback; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x1218AD0 Offset: 0x1217ED0 VA: 0x181218AD0
	internal bool <MonoToPublic>b__0(object t, X509Certificate c, X509Chain ch, SslPolicyErrors e) { }

}

private sealed class CallbackHelpers.<>c__DisplayClass8_0 // TypeDefIndex: 2558
{	// Fields
	public MonoLocalCertificateSelectionCallback callback; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x1218B60 Offset: 0x1217F60 VA: 0x181218B60
	internal X509Certificate <MonoToInternal>b__0(string t, X509CertificateCollection lc, X509Certificate rc, string[] ai) { }

}

