internal class DSAManaged : DSA // TypeDefIndex: 78
{	private bool keypairGenerated; // 0x20
	private bool m_disposed; // 0x21
	private BigInteger p; // 0x28
	private BigInteger q; // 0x30
	private BigInteger g; // 0x38
	private BigInteger x; // 0x40
	private BigInteger y; // 0x48
	private BigInteger j; // 0x50
	private BigInteger seed; // 0x58
	private int counter; // 0x60
	private bool j_missing; // 0x64
	private RandomNumberGenerator rng; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private DSAManaged.KeyGeneratedEventHandler KeyGenerated; // 0x70

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

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void add_KeyGenerated(DSAManaged.KeyGeneratedEventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void remove_KeyGenerated(DSAManaged.KeyGeneratedEventHandler value) { }

}

public sealed class DSAManaged.KeyGeneratedEventHandler : MulticastDelegate // TypeDefIndex: 79
{
	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(object sender, EventArgs e) { }

	public virtual IAsyncResult BeginInvoke(object sender, EventArgs e, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

