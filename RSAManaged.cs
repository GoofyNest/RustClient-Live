internal class RSAManaged : RSA // TypeDefIndex: 75
{
	private bool isCRTpossible; 
	private bool keyBlinding; 
	private bool keypairGenerated; 
	private bool m_disposed; 
	private BigInteger d; 
	private BigInteger p; 
	private BigInteger q; 
	private BigInteger dp; 
	private BigInteger dq; 
	private BigInteger qInv; 
	private BigInteger n; 
	private BigInteger e; 
	[CompilerGeneratedAttribute] 
	private RSAManaged.KeyGeneratedEventHandler KeyGenerated; 

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

	[CompilerGeneratedAttribute] 
public void add_KeyGenerated(RSAManaged.KeyGeneratedEventHandler value) { }

	[CompilerGeneratedAttribute] 
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
{
	private bool isCRTpossible; 
	private bool keypairGenerated; 
	private bool m_disposed; 
	private BigInteger d; 
	private BigInteger p; 
	private BigInteger q; 
	private BigInteger dp; 
	private BigInteger dq; 
	private BigInteger qInv; 
	private BigInteger n; 
	private BigInteger e; 
	[CompilerGeneratedAttribute] 
	private RSAManaged.KeyGeneratedEventHandler KeyGenerated; 

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

