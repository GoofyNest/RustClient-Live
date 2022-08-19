public sealed class SerializationObjectManager // TypeDefIndex: 1061
{	// Fields
	private Hashtable m_objectSeenTable; // 0x10
	private SerializationEventHandler m_onSerializedHandler; // 0x18
	private StreamingContext m_context; // 0x20

	// Methods

	// RVA: 0x12A4AF0 Offset: 0x12A3EF0 VA: 0x1812A4AF0
	public void .ctor(StreamingContext context) { }

	// RVA: 0x12A4940 Offset: 0x12A3D40 VA: 0x1812A4940
	public void RegisterObject(object obj) { }

	// RVA: 0x12A4910 Offset: 0x12A3D10 VA: 0x1812A4910
	public void RaiseOnSerializedEvent() { }

	// RVA: 0x12A4860 Offset: 0x12A3C60 VA: 0x1812A4860
	private void AddOnSerialized(object obj) { }

}

