internal class TraceLoggingEventTypes // TypeDefIndex: 1586
{	internal readonly TraceLoggingTypeInfo[] typeInfos; // 0x10
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

	internal string Name { get; }
	internal EventTags Tags { get; }


	internal void .ctor(string name, EventTags tags, Type[] types) { }

	internal void .ctor(string name, EventTags tags, ParameterInfo[] paramInfos) { }

	private void .ctor(EventTags tags, string defaultName, TraceLoggingTypeInfo[] typeInfos) { }

	internal string get_Name() { }

	internal EventTags get_Tags() { }

	internal NameInfo GetNameInfo(string name, EventTags tags) { }

	private TraceLoggingTypeInfo[] MakeArray(ParameterInfo[] paramInfos) { }

	private static TraceLoggingTypeInfo[] MakeArray(Type[] types) { }

}

