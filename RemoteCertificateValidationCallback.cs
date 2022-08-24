public sealed class RemoteCertificateValidationCallback : MulticastDelegate // TypeDefIndex: 3069
{

	public void .ctor(object object, IntPtr method) { }

	public virtual bool Invoke(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { }

	public virtual IAsyncResult BeginInvoke(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors, AsyncCallback callback, object object) { }

	public virtual bool EndInvoke(IAsyncResult result) { }

}

