internal class FieldMetadata // TypeDefIndex: 1523
{	// Fields
	private readonly string name; // 0x10
	private readonly int nameSize; // 0x18
	private readonly EventFieldTags tags; // 0x1C
	private readonly byte[] custom; // 0x20
	private readonly ushort fixedCount; // 0x28
	private byte inType; // 0x2A
	private byte outType; // 0x2B

	// Methods

	// RVA: 0x10D8920 Offset: 0x10D7D20 VA: 0x1810D8920
	public void .ctor(string name, TraceLoggingDataType type, EventFieldTags tags, bool variableCount) { }

	// RVA: 0x10D8680 Offset: 0x10D7A80 VA: 0x1810D8680
	private void .ctor(string name, TraceLoggingDataType dataType, EventFieldTags tags, byte countFlags, ushort fixedCount = 0, byte[] custom) { }

	// RVA: 0x10D8600 Offset: 0x10D7A00 VA: 0x1810D8600
	public void IncrementStructFieldCount() { }

	// RVA: 0x10D83D0 Offset: 0x10D77D0 VA: 0x1810D83D0
	public void Encode(ref int pos, byte[] metadata) { }

}

