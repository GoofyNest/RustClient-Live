public sealed class SafeSerializationEventArgs : EventArgs // TypeDefIndex: 1045
{	private StreamingContext m_streamingContext; // 0x10
	private List<object> m_serializedStates; // 0x20

	internal IList<object> SerializedStates { get; }


	internal void .ctor(StreamingContext streamingContext) { }

	internal IList<object> get_SerializedStates() { }

}

