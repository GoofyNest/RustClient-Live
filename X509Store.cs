public class X509Store // TypeDefIndex: 1721
{	// Fields
	private string _storePath; // 0x10
	private X509CertificateCollection _certificates; // 0x18
	private ArrayList _crls; // 0x20
	private bool _crl; // 0x28
	private bool _newFormat; // 0x29

	// Properties
	public X509CertificateCollection Certificates { get; }
	public ArrayList Crls { get; }

	// Methods

	// RVA: 0x227D740 Offset: 0x227CB40 VA: 0x18227D740
	internal void .ctor(string path, bool crl, bool newFormat) { }

	// RVA: 0x227D7A0 Offset: 0x227CBA0 VA: 0x18227D7A0
	public X509CertificateCollection get_Certificates() { }

	// RVA: 0x227D7E0 Offset: 0x227CBE0 VA: 0x18227D7E0
	public ArrayList get_Crls() { }

	// RVA: 0x227D5F0 Offset: 0x227C9F0 VA: 0x18227D5F0
	private byte[] Load(string filename) { }

	// RVA: 0x227D460 Offset: 0x227C860 VA: 0x18227D460
	private X509Certificate LoadCertificate(string filename) { }

	// RVA: 0x227D4D0 Offset: 0x227C8D0 VA: 0x18227D4D0
	private X509Crl LoadCrl(string filename) { }

	// RVA: 0x227D3D0 Offset: 0x227C7D0 VA: 0x18227D3D0
	private bool CheckStore(string path, bool throwException) { }

	// RVA: 0x227D140 Offset: 0x227C540 VA: 0x18227D140
	private X509CertificateCollection BuildCertificatesCollection(string storeName) { }

	// RVA: 0x227D290 Offset: 0x227C690 VA: 0x18227D290
	private ArrayList BuildCrlsCollection(string storeName) { }

}

public sealed class X509Store : IDisposable // TypeDefIndex: 2837
{	// Fields
	private string _name; // 0x10
	private StoreLocation _location; // 0x18
	private X509Certificate2Collection list; // 0x20
	private OpenFlags _flags; // 0x28
	private X509Store store; // 0x30

	// Properties
	public X509Certificate2Collection Certificates { get; }
	private X509Stores Factory { get; }
	internal X509Store Store { get; }

	// Methods

	// RVA: 0x14DEF40 Offset: 0x14DE340 VA: 0x1814DEF40
	public void .ctor(StoreName storeName, StoreLocation storeLocation) { }

	// RVA: 0x14DF080 Offset: 0x14DE480 VA: 0x1814DF080
	public X509Certificate2Collection get_Certificates() { }

	// RVA: 0x14DF120 Offset: 0x14DE520 VA: 0x1814DF120
	private X509Stores get_Factory() { }

	// RVA: 0x4A2EE0 Offset: 0x4A22E0 VA: 0x1804A2EE0
	internal X509Store get_Store() { }

	// RVA: 0x14DEBE0 Offset: 0x14DDFE0 VA: 0x1814DEBE0
	public void Close() { }

	// RVA: 0x14DEBE0 Offset: 0x14DDFE0 VA: 0x1814DEBE0 Slot: 4
	public void Dispose() { }

	// RVA: 0x14DEC20 Offset: 0x14DE020 VA: 0x1814DEC20
	public void Open(OpenFlags flags) { }

}

