internal class TraceLoggingMetadataCollector // TypeDefIndex: 1587
{	private readonly TraceLoggingMetadataCollector.Impl impl; // 0x10
	private readonly FieldMetadata currentGroup; // 0x18
	private int bufferedArrayFieldCount; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private EventFieldTags <Tags>k__BackingField; // 0x24

	internal EventFieldTags Tags { get; set; }
	internal int ScratchSize { get; }
	internal int DataCount { get; }
	internal int PinCount { get; }
	private bool BeginningBufferedArray { get; }


	internal void .ctor() { }

	private void .ctor(TraceLoggingMetadataCollector other, FieldMetadata group) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal EventFieldTags get_Tags() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal void set_Tags(EventFieldTags value) { }

	internal int get_ScratchSize() { }

	internal int get_DataCount() { }

	internal int get_PinCount() { }

	private bool get_BeginningBufferedArray() { }

	public TraceLoggingMetadataCollector AddGroup(string name) { }

	public void AddScalar(string name, TraceLoggingDataType type) { }

	public void AddBinary(string name, TraceLoggingDataType type) { }

	public void AddArray(string name, TraceLoggingDataType type) { }

	public void BeginBufferedArray() { }

	public void EndBufferedArray() { }

	internal byte[] GetMetadata() { }

	private void AddField(FieldMetadata fieldMetadata) { }

}

private class TraceLoggingMetadataCollector.Impl // TypeDefIndex: 1588
{	internal readonly List<FieldMetadata> fields; // 0x10
	internal short scratchSize; // 0x18
	internal sbyte dataCount; // 0x1A
	internal sbyte pinCount; // 0x1B
	private int bufferNesting; // 0x1C
	private bool scalar; // 0x20


	public void AddScalar(int size) { }

	public void AddNonscalar() { }

	public void BeginBuffered() { }

	public void EndBuffered() { }

	public int Encode(byte[] metadata) { }

	public void .ctor() { }

}

