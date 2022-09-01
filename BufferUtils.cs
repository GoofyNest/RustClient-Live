internal static class BufferUtils // TypeDefIndex: 5959
{

[PreserveAttribute] 
internal static class BufferUtils

	public static char[] RentBuffer(IArrayPool<char> bufferPool, int minSize) { }

	public static void ReturnBuffer(IArrayPool<char> bufferPool, char[] buffer) { }

	public static char[] EnsureBufferSize(IArrayPool<char> bufferPool, int size, char[] buffer) { }

}

