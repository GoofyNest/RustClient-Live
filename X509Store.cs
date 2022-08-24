public class X509Store // TypeDefIndex: 1721
{
	private string _storePath; 
	private X509CertificateCollection _certificates; 
	private ArrayList _crls; 
	private bool _crl; 
	private bool _newFormat; 

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
{
	private string _name; 
	private StoreLocation _location; 
	private X509Certificate2Collection list; 
	private OpenFlags _flags; 
	private X509Store store; 

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

