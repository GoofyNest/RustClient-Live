public sealed class MD5CryptoServiceProvider : MD5 // TypeDefIndex: 1006
{
	private uint[] _H; 
	private uint[] buff; 
	private ulong count; 
	private byte[] _ProcessingBuffer; 
	private int _ProcessingBufferCount; 
	private static readonly uint[] K; 


	public void .ctor() { }

	protected override void Finalize() { }

	protected override void Dispose(bool disposing) { }

	protected override void HashCore(byte[] rgb, int ibStart, int cbSize) { }

	protected override byte[] HashFinal() { }

	public override void Initialize() { }

	private void ProcessBlock(byte[] inputBuffer, int inputOffset) { }

	private void ProcessFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) { }

	internal void AddLength(ulong length, byte[] buffer, int position) { }

	private static void .cctor() { }

}

