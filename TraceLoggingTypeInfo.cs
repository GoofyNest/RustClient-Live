internal abstract class TraceLoggingTypeInfo // TypeDefIndex: 1589
{	private readonly string name; // 0x10
	private readonly EventKeywords keywords; // 0x18
	private readonly EventLevel level; // 0x20
	private readonly EventOpcode opcode; // 0x24
	private readonly EventTags tags; // 0x28
	private readonly Type dataType; // 0x30

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

