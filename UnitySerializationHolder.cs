internal class UnitySerializationHolder : ISerializable, IObjectReference // TypeDefIndex: 332
{	private Type[] m_instantiation; // 0x10
	private int[] m_elementTypes; // 0x18
	private int m_genericParameterPosition; // 0x20
	private Type m_declaringType; // 0x28
	private MethodBase m_declaringMethod; // 0x30
	private string m_data; // 0x38
	private string m_assemblyName; // 0x40
	private int m_unityType; // 0x48


	internal static void GetUnitySerializationInfo(SerializationInfo info, Missing missing) { }

	internal static RuntimeType AddElementTypes(SerializationInfo info, RuntimeType type) { }

	internal Type MakeElementTypes(Type type) { }

	internal static void GetUnitySerializationInfo(SerializationInfo info, RuntimeType type) { }

	internal static void GetUnitySerializationInfo(SerializationInfo info, int unityType, string data, RuntimeAssembly assembly) { }

	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	private void ThrowInsufficientInformation(string field) { }

	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	public virtual object GetRealObject(StreamingContext context) { }

}

