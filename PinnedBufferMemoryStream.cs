internal sealed class PinnedBufferMemoryStream : UnmanagedMemoryStream // TypeDefIndex: 637
{
	private byte[] _array; 
	private GCHandle _pinningHandle; 


	internal void .ctor(byte[] array) { }

	protected override void Finalize() { }

	protected override void Dispose(bool disposing) { }

}

