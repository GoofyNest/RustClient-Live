internal class ScatterGatherBuffers // TypeDefIndex: 2922
{	private ScatterGatherBuffers.MemoryChunk headChunk; // 0x10
	private ScatterGatherBuffers.MemoryChunk currentChunk; // 0x18
	private int nextChunkLength; // 0x20
	private int totalLength; // 0x24
	private int chunkCount; // 0x28

	private bool Empty { get; }
	internal int Length { get; }


	internal void .ctor(long totalSize) { }

	internal BufferOffsetSize[] GetBuffers() { }

	private bool get_Empty() { }

	internal int get_Length() { }

	internal void Write(byte[] buffer, int offset, int count) { }

	private ScatterGatherBuffers.MemoryChunk AllocateMemoryChunk(int newSize) { }

}

private class ScatterGatherBuffers.MemoryChunk // TypeDefIndex: 2923
{	internal byte[] Buffer; // 0x10
	internal int FreeOffset; // 0x18
	internal ScatterGatherBuffers.MemoryChunk Next; // 0x20


	internal void .ctor(int bufferSize) { }

}

