public abstract class HMAC : KeyedHashAlgorithm // TypeDefIndex: 960
{
	private int blockSizeValue;
	internal string m_hashName;
	internal HashAlgorithm m_hash1;
	internal HashAlgorithm m_hash2;
	private byte[] m_inner;
	private byte[] m_outer;
	private bool m_hashing;

	protected int BlockSizeValue { get; set; }
	public override byte[] Key { get; set; }


	protected int get_BlockSizeValue() { }

	protected void set_BlockSizeValue(int value) { }

	private void UpdateIOPadBuffers() { }

	internal void InitializeKey(byte[] key) { }

	public override byte[] get_Key() { }

	public override void set_Key(byte[] value) { }

	public static HMAC Create() { }

	public override void Initialize() { }

	protected override void HashCore(byte[] rgb, int ib, int cb) { }

	protected override byte[] HashFinal() { }

	protected override void Dispose(bool disposing) { }

	protected void .ctor() { }

}

