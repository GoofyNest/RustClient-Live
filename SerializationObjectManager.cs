public sealed class SerializationObjectManager // TypeDefIndex: 1061
{
	private Hashtable m_objectSeenTable; 
	private SerializationEventHandler m_onSerializedHandler; 
	private StreamingContext m_context; 


public void .ctor(StreamingContext context) { }

public void RegisterObject(object obj) { }

public void RaiseOnSerializedEvent() { }

private void AddOnSerialized(object obj) { }

}

