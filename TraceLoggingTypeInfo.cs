internal abstract class TraceLoggingTypeInfo // TypeDefIndex: 1589
{	// Fields
	private readonly string name; // 0x10
	private readonly EventKeywords keywords; // 0x18
	private readonly EventLevel level; // 0x20
	private readonly EventOpcode opcode; // 0x24
	private readonly EventTags tags; // 0x28
	private readonly Type dataType; // 0x30

	// Properties
	public string Name { get; }
	public EventLevel Level { get; }
	public EventOpcode Opcode { get; }
	public EventKeywords Keywords { get; }
	public EventTags Tags { get; }
	internal Type DataType { get; }

	// Methods

	// RVA: 0x10E44C0 Offset: 0x10E38C0 VA: 0x1810E44C0
	internal void .ctor(Type dataType) { }

	// RVA: 0x10E4300 Offset: 0x10E3700 VA: 0x1810E4300
	internal void .ctor(Type dataType, string name, EventLevel level, EventOpcode opcode, EventKeywords keywords, EventTags tags) { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public string get_Name() { }

	// RVA: 0x4D0170 Offset: 0x4CF570 VA: 0x1804D0170
	public EventLevel get_Level() { }

	// RVA: 0x7E8DA0 Offset: 0x7E81A0 VA: 0x1807E8DA0
	public EventOpcode get_Opcode() { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public EventKeywords get_Keywords() { }

	// RVA: 0x4BB390 Offset: 0x4BA790 VA: 0x1804BB390
	public EventTags get_Tags() { }

	// RVA: 0x4A2EE0 Offset: 0x4A22E0 VA: 0x1804A2EE0
	internal Type get_DataType() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void WriteObjectData(TraceLoggingDataCollector collector, object value);

	// RVA: 0x7B2BE0 Offset: 0x7B1FE0 VA: 0x1807B2BE0 Slot: 6
	public virtual object GetData(object value) { }

}

