internal sealed class LocalCertSelectionCallback : MulticastDelegate // TypeDefIndex: 3071
{

	public void .ctor(object object, IntPtr method) { }

	public virtual X509Certificate Invoke(string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers) { }

	public virtual IAsyncResult BeginInvoke(string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers, AsyncCallback callback, object object) { }

	public virtual X509Certificate EndInvoke(IAsyncResult result) { }

}

