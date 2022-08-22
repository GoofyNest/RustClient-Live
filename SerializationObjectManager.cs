public sealed class SerializationObjectManager // TypeDefIndex: 1061
{	private Hashtable m_objectSeenTable; // 0x10
	private SerializationEventHandler m_onSerializedHandler; // 0x18
	private StreamingContext m_context; // 0x20


	public void .ctor(StreamingContext context) { }

	public void RegisterObject(object obj) { }

	public void RaiseOnSerializedEvent() { }

	private void AddOnSerialized(object obj) { }

}

