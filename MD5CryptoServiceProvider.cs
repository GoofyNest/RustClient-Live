public sealed class MD5CryptoServiceProvider : MD5 // TypeDefIndex: 1006
{	private uint[] _H; // 0x28
	private uint[] buff; // 0x30
	private ulong count; // 0x38
	private byte[] _ProcessingBuffer; // 0x40
	private int _ProcessingBufferCount; // 0x48
	private static readonly uint[] K; // 0x0


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

