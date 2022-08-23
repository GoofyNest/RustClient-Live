internal static class IntExtensions // TypeDefIndex: 6914
{
	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static int ToLittleEndianInt(Span<byte> source) { }

	private static T CopyFromMemory<T>(Span<byte> memory) { }
	/* GenericInstMethod :
	|
	|-IntExtensions.CopyFromMemory<ushort>
	|
	|-IntExtensions.CopyFromMemory<ulong>
	*/

}

