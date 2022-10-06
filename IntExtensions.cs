internal static class IntExtensions // TypeDefIndex: 6947
{

	[ExtensionAttribute] 
	public static int ToLittleEndianInt(Span<byte> source) { }

	private static T CopyFromMemory<T>(Span<byte> memory) { }
	/* GenericInstMethod :
	|
	|-IntExtensions.CopyFromMemory<ushort>
	|
	|-IntExtensions.CopyFromMemory<ulong>
	*/

}

