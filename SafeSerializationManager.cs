internal sealed class SafeSerializationManager : IObjectReference, ISerializable // TypeDefIndex: 1047
{
	private IList<object> m_serializedStates;
	private SerializationInfo m_savedSerializationInfo;
	private object m_realObject;
	private RuntimeType m_realType;
	[CompilerGeneratedAttribute]
	private EventHandler<SafeSerializationEventArgs> SerializeObjectState;
	private const string RealTypeSerializationName = "CLR_SafeSerializationManager_RealType";

	internal bool IsActive { get; }


	internal void .ctor() { }

	private void .ctor(SerializationInfo info, StreamingContext context) { }

	internal bool get_IsActive() { }

	internal void CompleteSerialization(object serializedObject, SerializationInfo info, StreamingContext context) { }

	internal void CompleteDeserialization(object deserializedObject) { }

	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	private object System.Runtime.Serialization.IObjectReference.GetRealObject(StreamingContext context) { }

	[OnDeserializedAttribute]
	private void OnDeserialized(StreamingContext context) { }

}

