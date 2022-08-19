internal abstract class MobileTlsContext : IDisposable // TypeDefIndex: 2551
{	// Fields
	private MobileAuthenticatedStream parent; // 0x10
	private bool serverMode; // 0x18
	private string targetHost; // 0x20
	private string serverName; // 0x28
	private SslProtocols enabledProtocols; // 0x30
	private X509Certificate serverCertificate; // 0x38
	private X509CertificateCollection clientCertificates; // 0x40
	private bool askForClientCert; // 0x48
	private ICertificateValidator2 certificateValidator; // 0x50

	// Properties
	internal MobileAuthenticatedStream Parent { get; }
	public MonoTlsSettings Settings { get; }
	public abstract bool IsAuthenticated { get; }
	public bool IsServer { get; }
	protected string TargetHost { get; }
	protected string ServerName { get; }
	protected X509CertificateCollection ClientCertificates { get; }
	internal X509Certificate LocalServerCertificate { get; }
	internal abstract X509Certificate LocalClientCertificate { get; }

	// Methods

	// RVA: 0x1213DA0 Offset: 0x12131A0 VA: 0x181213DA0
	public void .ctor(MobileAuthenticatedStream parent, bool serverMode, string targetHost, SslProtocols enabledProtocols, X509Certificate serverCertificate, X509CertificateCollection clientCertificates, bool askForClientCert) { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	internal MobileAuthenticatedStream get_Parent() { }

	// RVA: 0x1213F10 Offset: 0x1213310 VA: 0x181213F10
	public MonoTlsSettings get_Settings() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool get_IsAuthenticated();

	// RVA: 0x95B2D0 Offset: 0x95A6D0 VA: 0x18095B2D0
	public bool get_IsServer() { }

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	protected string get_TargetHost() { }

	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230
	protected string get_ServerName() { }

	// RVA: 0x4B9440 Offset: 0x4B8840 VA: 0x1804B9440
	protected X509CertificateCollection get_ClientCertificates() { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void StartHandshake();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool ProcessHandshake();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void FinishHandshake();

	// RVA: 0x5DCC00 Offset: 0x5DC000 VA: 0x1805DCC00
	internal X509Certificate get_LocalServerCertificate() { }

	// RVA: -1 Offset: -1 Slot: 9
	internal abstract X509Certificate get_LocalClientCertificate();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract ValueTuple<int, bool> Read(byte[] buffer, int offset, int count);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract ValueTuple<int, bool> Write(byte[] buffer, int offset, int count);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void Shutdown();

	// RVA: 0x1213B90 Offset: 0x1212F90 VA: 0x181213B90
	protected bool ValidateCertificate(X509Certificate leaf, X509Chain chain) { }

	// RVA: 0x1213CA0 Offset: 0x12130A0 VA: 0x181213CA0
	protected bool ValidateCertificate(X509CertificateCollection certificates) { }

	// RVA: 0x1213A10 Offset: 0x1212E10 VA: 0x181213A10
	protected X509Certificate SelectClientCertificate(X509Certificate serverCertificate, string[] acceptableIssuers) { }

	// RVA: 0x1213900 Offset: 0x1212D00 VA: 0x181213900 Slot: 4
	public void Dispose() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 13
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1213970 Offset: 0x1212D70 VA: 0x181213970 Slot: 1
	protected override void Finalize() { }

}

