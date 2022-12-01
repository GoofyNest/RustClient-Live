internal class FieldMetadata // TypeDefIndex: 1523
{
	private readonly string name;
	private readonly int nameSize;
	private readonly EventFieldTags tags;
	private readonly byte[] custom;
	private readonly ushort fixedCount;
	private byte inType;
	private byte outType;


	public void .ctor(string name, TraceLoggingDataType type, EventFieldTags tags, bool variableCount) { }

	private void .ctor(string name, TraceLoggingDataType dataType, EventFieldTags tags, byte countFlags, ushort fixedCount = 0, byte[] custom) { }

	public void IncrementStructFieldCount() { }

	public void Encode(ref int pos, byte[] metadata) { }

}

