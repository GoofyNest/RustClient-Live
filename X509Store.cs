public class X509Store // TypeDefIndex: 1721
{	private string _storePath; // 0x10
	private X509CertificateCollection _certificates; // 0x18
	private ArrayList _crls; // 0x20
	private bool _crl; // 0x28
	private bool _newFormat; // 0x29

	public X509CertificateCollection Certificates { get; }
	public ArrayList Crls { get; }


	internal void .ctor(string path, bool crl, bool newFormat) { }

	public X509CertificateCollection get_Certificates() { }

	public ArrayList get_Crls() { }

	private byte[] Load(string filename) { }

	private X509Certificate LoadCertificate(string filename) { }

	private X509Crl LoadCrl(string filename) { }

	private bool CheckStore(string path, bool throwException) { }

	private X509CertificateCollection BuildCertificatesCollection(string storeName) { }

	private ArrayList BuildCrlsCollection(string storeName) { }

}

public sealed class X509Store : IDisposable // TypeDefIndex: 2837
{	private string _name; // 0x10
	private StoreLocation _location; // 0x18
	private X509Certificate2Collection list; // 0x20
	private OpenFlags _flags; // 0x28
	private X509Store store; // 0x30

	public X509Certificate2Collection Certificates { get; }
	private X509Stores Factory { get; }
	internal X509Store Store { get; }


	public void .ctor(StoreName storeName, StoreLocation storeLocation) { }

	public X509Certificate2Collection get_Certificates() { }

	private X509Stores get_Factory() { }

	internal X509Store get_Store() { }

	public void Close() { }

	public void Dispose() { }

	public void Open(OpenFlags flags) { }

}

