internal class TraceLoggingMetadataCollector // TypeDefIndex: 1587
{	// Fields
	private readonly TraceLoggingMetadataCollector.Impl impl; // 0x10
	private readonly FieldMetadata currentGroup; // 0x18
	private int bufferedArrayFieldCount; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private EventFieldTags <Tags>k__BackingField; // 0x24

	// Properties
	internal EventFieldTags Tags { get; set; }
	internal int ScratchSize { get; }
	internal int DataCount { get; }
	internal int PinCount { get; }
	private bool BeginningBufferedArray { get; }

	// Methods

	// RVA: 0x10E4170 Offset: 0x10E3570 VA: 0x1810E4170
	internal void .ctor() { }

	// RVA: 0x10E4230 Offset: 0x10E3630 VA: 0x1810E4230
	private void .ctor(TraceLoggingMetadataCollector other, FieldMetadata group) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7E8DA0 Offset: 0x7E81A0 VA: 0x1807E8DA0
	internal EventFieldTags get_Tags() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7E8E00 Offset: 0x7E8200 VA: 0x1807E8E00
	internal void set_Tags(EventFieldTags value) { }

	// RVA: 0x10E42E0 Offset: 0x10E36E0 VA: 0x1810E42E0
	internal int get_ScratchSize() { }

	// RVA: 0x10E42A0 Offset: 0x10E36A0 VA: 0x1810E42A0
	internal int get_DataCount() { }

	// RVA: 0x10E42C0 Offset: 0x10E36C0 VA: 0x1810E42C0
	internal int get_PinCount() { }

	// RVA: 0x10E4290 Offset: 0x10E3690 VA: 0x1810E4290
	private bool get_BeginningBufferedArray() { }

	// RVA: 0x10E3D10 Offset: 0x10E3110 VA: 0x1810E3D10
	public TraceLoggingMetadataCollector AddGroup(string name) { }

	// RVA: 0x10E3E20 Offset: 0x10E3220 VA: 0x1810E3E20
	public void AddScalar(string name, TraceLoggingDataType type) { }

	// RVA: 0x10E3B00 Offset: 0x10E2F00 VA: 0x1810E3B00
	public void AddBinary(string name, TraceLoggingDataType type) { }

	// RVA: 0x10E3950 Offset: 0x10E2D50 VA: 0x1810E3950
	public void AddArray(string name, TraceLoggingDataType type) { }

	// RVA: 0x10E3FB0 Offset: 0x10E33B0 VA: 0x1810E3FB0
	public void BeginBufferedArray() { }

	// RVA: 0x10E4060 Offset: 0x10E3460 VA: 0x1810E4060
	public void EndBufferedArray() { }

	// RVA: 0x10E40F0 Offset: 0x10E34F0 VA: 0x1810E40F0
	internal byte[] GetMetadata() { }

	// RVA: 0x10E3C30 Offset: 0x10E3030 VA: 0x1810E3C30
	private void AddField(FieldMetadata fieldMetadata) { }

}

private class TraceLoggingMetadataCollector.Impl // TypeDefIndex: 1588
{	// Fields
	internal readonly List<FieldMetadata> fields; // 0x10
	internal short scratchSize; // 0x18
	internal sbyte dataCount; // 0x1A
	internal sbyte pinCount; // 0x1B
	private int bufferNesting; // 0x1C
	private bool scalar; // 0x20

	// Methods

	// RVA: 0x10D92B0 Offset: 0x10D86B0 VA: 0x1810D92B0
	public void AddScalar(int size) { }

	// RVA: 0x10D91E0 Offset: 0x10D85E0 VA: 0x1810D91E0
	public void AddNonscalar() { }

	// RVA: 0x10D93A0 Offset: 0x10D87A0 VA: 0x1810D93A0
	public void BeginBuffered() { }

	// RVA: 0x10D9500 Offset: 0x10D8900 VA: 0x1810D9500
	public void EndBuffered() { }

	// RVA: 0x10D93D0 Offset: 0x10D87D0 VA: 0x1810D93D0
	public int Encode(byte[] metadata) { }

	// RVA: 0x10D9510 Offset: 0x10D8910 VA: 0x1810D9510
	public void .ctor() { }

}

