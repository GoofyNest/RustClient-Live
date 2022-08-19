internal class TraceLoggingEventTypes // TypeDefIndex: 1586
{	// Fields
	internal readonly TraceLoggingTypeInfo[] typeInfos; // 0x10
	internal readonly string name; // 0x18
	internal readonly EventTags tags; // 0x20
	internal readonly byte level; // 0x24
	internal readonly byte opcode; // 0x25
	internal readonly EventKeywords keywords; // 0x28
	internal readonly byte[] typeMetadata; // 0x30
	internal readonly int scratchSize; // 0x38
	internal readonly int dataCount; // 0x3C
	internal readonly int pinCount; // 0x40
	private ConcurrentSet<KeyValuePair<string, EventTags>, NameInfo> nameInfos; // 0x48

	// Properties
	internal string Name { get; }
	internal EventTags Tags { get; }

	// Methods

	// RVA: 0x10E37A0 Offset: 0x10E2BA0 VA: 0x1810E37A0
	internal void .ctor(string name, EventTags tags, Type[] types) { }

	// RVA: 0x10E33A0 Offset: 0x10E27A0 VA: 0x1810E33A0
	internal void .ctor(string name, EventTags tags, ParameterInfo[] paramInfos) { }

	// RVA: 0x10E31A0 Offset: 0x10E25A0 VA: 0x1810E31A0
	private void .ctor(EventTags tags, string defaultName, TraceLoggingTypeInfo[] typeInfos) { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	internal string get_Name() { }

	// RVA: 0x4D0170 Offset: 0x4CF570 VA: 0x1804D0170
	internal EventTags get_Tags() { }

	// RVA: 0x10E2C60 Offset: 0x10E2060 VA: 0x1810E2C60
	internal NameInfo GetNameInfo(string name, EventTags tags) { }

	// RVA: 0x10E2E80 Offset: 0x10E2280 VA: 0x1810E2E80
	private TraceLoggingTypeInfo[] MakeArray(ParameterInfo[] paramInfos) { }

	// RVA: 0x10E3020 Offset: 0x10E2420 VA: 0x1810E3020
	private static TraceLoggingTypeInfo[] MakeArray(Type[] types) { }

}

