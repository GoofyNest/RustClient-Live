internal abstract class TraceLoggingTypeInfo // TypeDefIndex: 1589
{
	private readonly string name; 
	private readonly EventKeywords keywords; 
	private readonly EventLevel level; 
	private readonly EventOpcode opcode; 
	private readonly EventTags tags; 
	private readonly Type dataType; 

	public string Name { get; }
	public EventLevel Level { get; }
	public EventOpcode Opcode { get; }
	public EventKeywords Keywords { get; }
	public EventTags Tags { get; }
	internal Type DataType { get; }


	internal void .ctor(Type dataType) { }

	internal void .ctor(Type dataType, string name, EventLevel level, EventOpcode opcode, EventKeywords keywords, EventTags tags) { }

	public string get_Name() { }

	public EventLevel get_Level() { }

	public EventOpcode get_Opcode() { }

	public EventKeywords get_Keywords() { }

	public EventTags get_Tags() { }

	internal Type get_DataType() { }

	public abstract void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format);

	public abstract void WriteObjectData(TraceLoggingDataCollector collector, object value);

	public virtual object GetData(object value) { }

}

