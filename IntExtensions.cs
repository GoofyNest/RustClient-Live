internal static class IntExtensions // TypeDefIndex: 6914
{
	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static int ToLittleEndianInt(Span<byte> source) { }

	private static T CopyFromMemory<T>(Span<byte> memory) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E7BD0 Offset: 0x5E6FD0 VA: 0x1805E7BD0
	|-IntExtensions.CopyFromMemory<ushort>
	|
	|-RVA: 0x5E7D70 Offset: 0x5E7170 VA: 0x1805E7D70
	|-IntExtensions.CopyFromMemory<ulong>
	*/

}

