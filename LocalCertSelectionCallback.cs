internal sealed class LocalCertSelectionCallback : MulticastDelegate // TypeDefIndex: 3071
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xFF4240 Offset: 0xFF3640 VA: 0x180FF4240 Slot: 12
	public virtual X509Certificate Invoke(string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers) { }

	// RVA: 0xFF41F0 Offset: 0xFF35F0 VA: 0x180FF41F0 Slot: 13
	public virtual IAsyncResult BeginInvoke(string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers, AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual X509Certificate EndInvoke(IAsyncResult result) { }

}

