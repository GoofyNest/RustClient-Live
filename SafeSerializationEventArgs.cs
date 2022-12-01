public sealed class SafeSerializationEventArgs : EventArgs // TypeDefIndex: 1045
{
	private StreamingContext m_streamingContext;
	private List<object> m_serializedStates;

	internal IList<object> SerializedStates { get; }


	internal void .ctor(StreamingContext streamingContext) { }

	internal IList<object> get_SerializedStates() { }

}

