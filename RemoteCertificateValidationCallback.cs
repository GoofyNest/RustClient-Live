public sealed class RemoteCertificateValidationCallback : MulticastDelegate // TypeDefIndex: 3069
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xFF64E0 Offset: 0xFF58E0 VA: 0x180FF64E0 Slot: 12
	public virtual bool Invoke(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { }

	// RVA: 0xFF6440 Offset: 0xFF5840 VA: 0x180FF6440 Slot: 13
	public virtual IAsyncResult BeginInvoke(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors, AsyncCallback callback, object object) { }

	// RVA: 0xFF1100 Offset: 0xFF0500 VA: 0x180FF1100 Slot: 14
	public virtual bool EndInvoke(IAsyncResult result) { }

}

