internal class ScatterGatherBuffers // TypeDefIndex: 2922
{	// Fields
	private ScatterGatherBuffers.MemoryChunk headChunk; // 0x10
	private ScatterGatherBuffers.MemoryChunk currentChunk; // 0x18
	private int nextChunkLength; // 0x20
	private int totalLength; // 0x24
	private int chunkCount; // 0x28

	// Properties
	private bool Empty { get; }
	internal int Length { get; }

	// Methods

	// RVA: 0xFF7A10 Offset: 0xFF6E10 VA: 0x180FF7A10
	internal void .ctor(long totalSize) { }

	// RVA: 0xFF77A0 Offset: 0xFF6BA0 VA: 0x180FF77A0
	internal BufferOffsetSize[] GetBuffers() { }

	// RVA: 0xFF7A70 Offset: 0xFF6E70 VA: 0x180FF7A70
	private bool get_Empty() { }

	// RVA: 0x7E8DA0 Offset: 0x7E81A0 VA: 0x1807E8DA0
	internal int get_Length() { }

	// RVA: 0xFF7900 Offset: 0xFF6D00 VA: 0x180FF7900
	internal void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0xFF76D0 Offset: 0xFF6AD0 VA: 0x180FF76D0
	private ScatterGatherBuffers.MemoryChunk AllocateMemoryChunk(int newSize) { }

}

private class ScatterGatherBuffers.MemoryChunk // TypeDefIndex: 2923
{	// Fields
	internal byte[] Buffer; // 0x10
	internal int FreeOffset; // 0x18
	internal ScatterGatherBuffers.MemoryChunk Next; // 0x20

	// Methods

	// RVA: 0xFF4760 Offset: 0xFF3B60 VA: 0x180FF4760
	internal void .ctor(int bufferSize) { }

}

