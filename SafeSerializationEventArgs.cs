public sealed class SafeSerializationEventArgs : EventArgs // TypeDefIndex: 1045
{	// Fields
	private StreamingContext m_streamingContext; // 0x10
	private List<object> m_serializedStates; // 0x20

	// Properties
	internal IList<object> SerializedStates { get; }

	// Methods

	// RVA: 0x129F230 Offset: 0x129E630 VA: 0x18129F230
	internal void .ctor(StreamingContext streamingContext) { }

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	internal IList<object> get_SerializedStates() { }

}

