internal sealed class SafeSerializationManager : IObjectReference, ISerializable // TypeDefIndex: 1047
{	private IList<object> m_serializedStates; // 0x10
	private SerializationInfo m_savedSerializationInfo; // 0x18
	private object m_realObject; // 0x20
	private RuntimeType m_realType; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private EventHandler<SafeSerializationEventArgs> SerializeObjectState; // 0x30
	private const string RealTypeSerializationName = "CLR_SafeSerializationManager_RealType";

	internal bool IsActive { get; }


	internal void .ctor() { }

	private void .ctor(SerializationInfo info, StreamingContext context) { }

	internal bool get_IsActive() { }

	internal void CompleteSerialization(object serializedObject, SerializationInfo info, StreamingContext context) { }

	internal void CompleteDeserialization(object deserializedObject) { }

	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	private object System.Runtime.Serialization.IObjectReference.GetRealObject(StreamingContext context) { }

	[OnDeserializedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void OnDeserialized(StreamingContext context) { }

}

