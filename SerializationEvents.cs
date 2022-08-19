internal class SerializationEvents // TypeDefIndex: 1054
{	// Fields
	private List<MethodInfo> m_OnSerializingMethods; // 0x10
	private List<MethodInfo> m_OnSerializedMethods; // 0x18
	private List<MethodInfo> m_OnDeserializingMethods; // 0x20
	private List<MethodInfo> m_OnDeserializedMethods; // 0x28

	// Properties
	internal bool HasOnSerializingEvents { get; }

	// Methods

	// RVA: 0x12A0BC0 Offset: 0x129FFC0 VA: 0x1812A0BC0
	private List<MethodInfo> GetMethodsWithAttribute(Type attribute, Type t) { }

	// RVA: 0x12A1480 Offset: 0x12A0880 VA: 0x1812A1480
	internal void .ctor(Type t) { }

	// RVA: 0x12A15B0 Offset: 0x12A09B0 VA: 0x1812A15B0
	internal bool get_HasOnSerializingEvents() { }

	// RVA: 0x12A1230 Offset: 0x12A0630 VA: 0x1812A1230
	internal void InvokeOnSerializing(object obj, StreamingContext context) { }

	// RVA: 0x12A0FE0 Offset: 0x12A03E0 VA: 0x1812A0FE0
	internal void InvokeOnDeserializing(object obj, StreamingContext context) { }

	// RVA: 0x12A0D90 Offset: 0x12A0190 VA: 0x1812A0D90
	internal void InvokeOnDeserialized(object obj, StreamingContext context) { }

	// RVA: 0x12A0980 Offset: 0x129FD80 VA: 0x1812A0980
	internal SerializationEventHandler AddOnSerialized(object obj, SerializationEventHandler handler) { }

	// RVA: 0x12A0740 Offset: 0x129FB40 VA: 0x1812A0740
	internal SerializationEventHandler AddOnDeserialized(object obj, SerializationEventHandler handler) { }

}

