internal class FieldMetadata // TypeDefIndex: 1523
{	private readonly string name; // 0x10
	private readonly int nameSize; // 0x18
	private readonly EventFieldTags tags; // 0x1C
	private readonly byte[] custom; // 0x20
	private readonly ushort fixedCount; // 0x28
	private byte inType; // 0x2A
	private byte outType; // 0x2B


	public void .ctor(string name, TraceLoggingDataType type, EventFieldTags tags, bool variableCount) { }

	private void .ctor(string name, TraceLoggingDataType dataType, EventFieldTags tags, byte countFlags, ushort fixedCount = 0, byte[] custom) { }

	public void IncrementStructFieldCount() { }

	public void Encode(ref int pos, byte[] metadata) { }

}

