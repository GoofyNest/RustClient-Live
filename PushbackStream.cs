public class PushbackStream // TypeDefIndex: 7395
{	// Fields
	private readonly int _BackBufferSize; // 0x10
	private readonly CircularByteBuffer _CircularByteBuffer; // 0x18
	private readonly Stream _Stream; // 0x20
	private readonly byte[] _TemporaryBuffer; // 0x28
	private int _NumForwardBytesInBuffer; // 0x30

	// Methods

	// RVA: 0x225DA00 Offset: 0x225CE00 VA: 0x18225DA00
	internal void .ctor(Stream s, int backBufferSize) { }

	// RVA: 0x225D7C0 Offset: 0x225CBC0 VA: 0x18225D7C0
	internal int Read(sbyte[] toRead, int offset, int length) { }

	// RVA: 0x225D980 Offset: 0x225CD80 VA: 0x18225D980
	internal void UnRead(int length) { }

	// RVA: 0x225D790 Offset: 0x225CB90 VA: 0x18225D790
	internal void Close() { }

}

