public class MACTripleDES : KeyedHashAlgorithm // TypeDefIndex: 969
{
	private ICryptoTransform m_encryptor; 
	private CryptoStream _cs; 
	private TailStream _ts; 
	private int m_bytesPerBlock; 
	private TripleDES des; 


public void .ctor() { }

public override void Initialize() { }

protected override void HashCore(byte[] rgbData, int ibStart, int cbSize) { }

protected override byte[] HashFinal() { }

protected override void Dispose(bool disposing) { }

}

