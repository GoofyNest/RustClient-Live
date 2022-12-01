internal class DSAManaged : DSA // TypeDefIndex: 78
{
	private bool keypairGenerated;
	private bool m_disposed;
	private BigInteger p;
	private BigInteger q;
	private BigInteger g;
	private BigInteger x;
	private BigInteger y;
	private BigInteger j;
	private BigInteger seed;
	private int counter;
	private bool j_missing;
	private RandomNumberGenerator rng;
	[CompilerGeneratedAttribute]
	private DSAManaged.KeyGeneratedEventHandler KeyGenerated;

	private RandomNumberGenerator Random { get; }
	public override int KeySize { get; }
	public bool PublicOnly { get; }


	public void .ctor(int dwKeySize) { }

	protected override void Finalize() { }

	private void Generate() { }

	private void GenerateKeyPair() { }

	private void add(byte[] a, byte[] b, int value) { }

	private void GenerateParams(int keyLength) { }

	private RandomNumberGenerator get_Random() { }

	public override int get_KeySize() { }

	public bool get_PublicOnly() { }

	private byte[] NormalizeArray(byte[] array) { }

	public override DSAParameters ExportParameters(bool includePrivateParameters) { }

	public override void ImportParameters(DSAParameters parameters) { }

	public override bool VerifySignature(byte[] rgbHash, byte[] rgbSignature) { }

	protected override void Dispose(bool disposing) { }

	[CompilerGeneratedAttribute]
	public void add_KeyGenerated(DSAManaged.KeyGeneratedEventHandler value) { }

	[CompilerGeneratedAttribute]
	public void remove_KeyGenerated(DSAManaged.KeyGeneratedEventHandler value) { }

}

public sealed class DSAManaged.KeyGeneratedEventHandler : MulticastDelegate // TypeDefIndex: 79
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(object sender, EventArgs e) { }

	public virtual IAsyncResult BeginInvoke(object sender, EventArgs e, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

