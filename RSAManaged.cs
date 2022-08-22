internal class RSAManaged : RSA // TypeDefIndex: 75
{	private bool isCRTpossible; // 0x20
	private bool keyBlinding; // 0x21
	private bool keypairGenerated; // 0x22
	private bool m_disposed; // 0x23
	private BigInteger d; // 0x28
	private BigInteger p; // 0x30
	private BigInteger q; // 0x38
	private BigInteger dp; // 0x40
	private BigInteger dq; // 0x48
	private BigInteger qInv; // 0x50
	private BigInteger n; // 0x58
	private BigInteger e; // 0x60
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private RSAManaged.KeyGeneratedEventHandler KeyGenerated; // 0x68

	public override int KeySize { get; }
	public bool PublicOnly { get; }


	public void .ctor(int keySize) { }

	protected override void Finalize() { }

	private void GenerateKeyPair() { }

	public override int get_KeySize() { }

	public bool get_PublicOnly() { }

	public override byte[] EncryptValue(byte[] rgb) { }

	public override RSAParameters ExportParameters(bool includePrivateParameters) { }

	public override void ImportParameters(RSAParameters parameters) { }

	protected override void Dispose(bool disposing) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void add_KeyGenerated(RSAManaged.KeyGeneratedEventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void remove_KeyGenerated(RSAManaged.KeyGeneratedEventHandler value) { }

	public override string ToXmlString(bool includePrivateParameters) { }

	private byte[] GetPaddedValue(BigInteger value, int length) { }

}

public sealed class RSAManaged.KeyGeneratedEventHandler : MulticastDelegate // TypeDefIndex: 76
{
	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(object sender, EventArgs e) { }

	public virtual IAsyncResult BeginInvoke(object sender, EventArgs e, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

public class RSAManaged : RSA // TypeDefIndex: 1761
{	private bool isCRTpossible; // 0x20
	private bool keypairGenerated; // 0x21
	private bool m_disposed; // 0x22
	private BigInteger d; // 0x28
	private BigInteger p; // 0x30
	private BigInteger q; // 0x38
	private BigInteger dp; // 0x40
	private BigInteger dq; // 0x48
	private BigInteger qInv; // 0x50
	private BigInteger n; // 0x58
	private BigInteger e; // 0x60
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private RSAManaged.KeyGeneratedEventHandler KeyGenerated; // 0x68

	public bool PublicOnly { get; }


	private void GenerateKeyPair() { }

	public bool get_PublicOnly() { }

	public override RSAParameters ExportParameters(bool includePrivateParameters) { }

	public override void ImportParameters(RSAParameters parameters) { }

	private byte[] GetPaddedValue(BigInteger value, int length) { }

}

public sealed class RSAManaged.KeyGeneratedEventHandler : MulticastDelegate // TypeDefIndex: 1762
{
	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(object sender, EventArgs e) { }

	public virtual IAsyncResult BeginInvoke(object sender, EventArgs e, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

