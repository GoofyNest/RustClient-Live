internal class ARC4Managed : RC4, ICryptoTransform, IDisposable // TypeDefIndex: 63
{
	private byte[] key;
	private byte[] state;
	private byte x;
	private byte y;
	private bool m_disposed;

	public override byte[] Key { get; set; }
	public bool CanTransformMultipleBlocks { get; }
	public int InputBlockSize { get; }
	public int OutputBlockSize { get; }


	public void .ctor() { }

	protected override void Finalize() { }

	protected override void Dispose(bool disposing) { }

	public override byte[] get_Key() { }

	public override void set_Key(byte[] value) { }

	public override ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgvIV) { }

	public override ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgvIV) { }

	public override void GenerateIV() { }

	public override void GenerateKey() { }

	public bool get_CanTransformMultipleBlocks() { }

	public int get_InputBlockSize() { }

	public int get_OutputBlockSize() { }

	private void KeySetup(byte[] key) { }

	private void CheckInput(byte[] inputBuffer, int inputOffset, int inputCount) { }

	public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { }

	private int InternalTransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { }

	public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) { }

}

