internal sealed class SafeSerializationManager : IObjectReference, ISerializable // TypeDefIndex: 1047
{	// Fields
	private IList<object> m_serializedStates; // 0x10
	private SerializationInfo m_savedSerializationInfo; // 0x18
	private object m_realObject; // 0x20
	private RuntimeType m_realType; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private EventHandler<SafeSerializationEventArgs> SerializeObjectState; // 0x30
	private const string RealTypeSerializationName = "CLR_SafeSerializationManager_RealType";

	// Properties
	internal bool IsActive { get; }

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	internal void .ctor() { }

	// RVA: 0x129FD50 Offset: 0x129F150 VA: 0x18129FD50
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x129FF10 Offset: 0x129F310 VA: 0x18129FF10
	internal bool get_IsActive() { }

	// RVA: 0x129F5F0 Offset: 0x129E9F0 VA: 0x18129F5F0
	internal void CompleteSerialization(object serializedObject, SerializationInfo info, StreamingContext context) { }

	// RVA: 0x129F2E0 Offset: 0x129E6E0 VA: 0x18129F2E0
	internal void CompleteDeserialization(object deserializedObject) { }

	// RVA: 0x129FC10 Offset: 0x129F010 VA: 0x18129FC10 Slot: 5
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x129F910 Offset: 0x129ED10 VA: 0x18129F910 Slot: 4
	private object System.Runtime.Serialization.IObjectReference.GetRealObject(StreamingContext context) { }

	[OnDeserializedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x129F850 Offset: 0x129EC50 VA: 0x18129F850
	private void OnDeserialized(StreamingContext context) { }

}

