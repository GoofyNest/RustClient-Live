internal class ScatterGatherBuffers // TypeDefIndex: 2922
{
	private ScatterGatherBuffers.MemoryChunk headChunk; 
	private ScatterGatherBuffers.MemoryChunk currentChunk; 
	private int nextChunkLength; 
	private int totalLength; 
	private int chunkCount; 

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
{
	internal byte[] Buffer; 
	internal int FreeOffset; 
	internal ScatterGatherBuffers.MemoryChunk Next; 


	internal void .ctor(int bufferSize) { }

}

