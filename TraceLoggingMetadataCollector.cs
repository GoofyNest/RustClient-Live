internal class TraceLoggingMetadataCollector // TypeDefIndex: 1587
{
	private readonly TraceLoggingMetadataCollector.Impl impl; 
	private readonly FieldMetadata currentGroup; 
	private int bufferedArrayFieldCount; 
	[CompilerGeneratedAttribute] 
	private EventFieldTags <Tags>k__BackingField; 

	internal EventFieldTags Tags { get; set; }
	internal int ScratchSize { get; }
	internal int DataCount { get; }
	internal int PinCount { get; }
	private bool BeginningBufferedArray { get; }


	internal void .ctor() { }

	private void .ctor(TraceLoggingMetadataCollector other, FieldMetadata group) { }

	[CompilerGeneratedAttribute] 
	internal EventFieldTags get_Tags() { }

	[CompilerGeneratedAttribute] 
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
{
	internal readonly List<FieldMetadata> fields; 
	internal short scratchSize; 
	internal sbyte dataCount; 
	internal sbyte pinCount; 
	private int bufferNesting; 
	private bool scalar; 


	public void AddScalar(int size) { }

	public void AddNonscalar() { }

	public void BeginBuffered() { }

	public void EndBuffered() { }

	public int Encode(byte[] metadata) { }

	public void .ctor() { }

}

