internal class TraceLoggingEventTypes // TypeDefIndex: 1586
{
	internal readonly TraceLoggingTypeInfo[] typeInfos; 
	internal readonly string name; 
	internal readonly EventTags tags; 
	internal readonly byte level; 
	internal readonly byte opcode; 
	internal readonly EventKeywords keywords; 
	internal readonly byte[] typeMetadata; 
	internal readonly int scratchSize; 
	internal readonly int dataCount; 
	internal readonly int pinCount; 
	private ConcurrentSet<KeyValuePair<string, EventTags>, NameInfo> nameInfos; 

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

