public class PushbackStream // TypeDefIndex: 7396
{
	private readonly int _BackBufferSize; 
	private readonly CircularByteBuffer _CircularByteBuffer; 
	private readonly Stream _Stream; 
	private readonly byte[] _TemporaryBuffer; 
	private int _NumForwardBytesInBuffer; 


	internal void .ctor(Stream s, int backBufferSize) { }

	internal int Read(sbyte[] toRead, int offset, int length) { }

	internal void UnRead(int length) { }

	internal void Close() { }

}

