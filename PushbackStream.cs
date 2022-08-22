public class PushbackStream // TypeDefIndex: 7395
{	private readonly int _BackBufferSize; // 0x10
	private readonly CircularByteBuffer _CircularByteBuffer; // 0x18
	private readonly Stream _Stream; // 0x20
	private readonly byte[] _TemporaryBuffer; // 0x28
	private int _NumForwardBytesInBuffer; // 0x30


	internal void .ctor(Stream s, int backBufferSize) { }

	internal int Read(sbyte[] toRead, int offset, int length) { }

	internal void UnRead(int length) { }

	internal void Close() { }

}

