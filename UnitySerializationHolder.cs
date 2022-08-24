internal class UnitySerializationHolder : ISerializable, IObjectReference // TypeDefIndex: 332
{
	private Type[] m_instantiation; 
	private int[] m_elementTypes; 
	private int m_genericParameterPosition; 
	private Type m_declaringType; 
	private MethodBase m_declaringMethod; 
	private string m_data; 
	private string m_assemblyName; 
	private int m_unityType; 


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

