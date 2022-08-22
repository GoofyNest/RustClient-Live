public class MACTripleDES : KeyedHashAlgorithm // TypeDefIndex: 969
{	private ICryptoTransform m_encryptor; // 0x30
	private CryptoStream _cs; // 0x38
	private TailStream _ts; // 0x40
	private int m_bytesPerBlock; // 0x48
	private TripleDES des; // 0x50


	public void .ctor() { }

	public override void Initialize() { }

	protected override void HashCore(byte[] rgbData, int ibStart, int cbSize) { }

	protected override byte[] HashFinal() { }

	protected override void Dispose(bool disposing) { }

}

