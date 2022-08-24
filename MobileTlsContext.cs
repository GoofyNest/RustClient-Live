internal abstract class MobileTlsContext : IDisposable // TypeDefIndex: 2551
{
	private MobileAuthenticatedStream parent; 
	private bool serverMode; 
	private string targetHost; 
	private string serverName; 
	private SslProtocols enabledProtocols; 
	private X509Certificate serverCertificate; 
	private X509CertificateCollection clientCertificates; 
	private bool askForClientCert; 
	private ICertificateValidator2 certificateValidator; 

internal MobileAuthenticatedStream Parent { get; }
public MonoTlsSettings Settings { get; }
public abstract bool IsAuthenticated { get; }
public bool IsServer { get; }
protected string TargetHost { get; }
protected string ServerName { get; }
protected X509CertificateCollection ClientCertificates { get; }
internal X509Certificate LocalServerCertificate { get; }
internal abstract X509Certificate LocalClientCertificate { get; }


public void .ctor(MobileAuthenticatedStream parent, bool serverMode, string targetHost, SslProtocols enabledProtocols, X509Certificate serverCertificate, X509CertificateCollection clientCertificates, bool askForClientCert) { }

internal MobileAuthenticatedStream get_Parent() { }

public MonoTlsSettings get_Settings() { }

public abstract bool get_IsAuthenticated();

public bool get_IsServer() { }

protected string get_TargetHost() { }

protected string get_ServerName() { }

protected X509CertificateCollection get_ClientCertificates() { }

public abstract void StartHandshake();

public abstract bool ProcessHandshake();

public abstract void FinishHandshake();

internal X509Certificate get_LocalServerCertificate() { }

internal abstract X509Certificate get_LocalClientCertificate();

public abstract ValueTuple<int, bool> Read(byte[] buffer, int offset, int count);

public abstract ValueTuple<int, bool> Write(byte[] buffer, int offset, int count);

public abstract void Shutdown();

protected bool ValidateCertificate(X509Certificate leaf, X509Chain chain) { }

protected bool ValidateCertificate(X509CertificateCollection certificates) { }

protected X509Certificate SelectClientCertificate(X509Certificate serverCertificate, string[] acceptableIssuers) { }

public void Dispose() { }

protected virtual void Dispose(bool disposing) { }

protected override void Finalize() { }

}

