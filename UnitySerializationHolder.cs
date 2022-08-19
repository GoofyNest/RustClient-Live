internal class UnitySerializationHolder : ISerializable, IObjectReference // TypeDefIndex: 332
{	// Fields
	private Type[] m_instantiation; // 0x10
	private int[] m_elementTypes; // 0x18
	private int m_genericParameterPosition; // 0x20
	private Type m_declaringType; // 0x28
	private MethodBase m_declaringMethod; // 0x30
	private string m_data; // 0x38
	private string m_assemblyName; // 0x40
	private int m_unityType; // 0x48

	// Methods

	// RVA: 0x2141A00 Offset: 0x2140E00 VA: 0x182141A00
	internal static void GetUnitySerializationInfo(SerializationInfo info, Missing missing) { }

	// RVA: 0x2140D40 Offset: 0x2140140 VA: 0x182140D40
	internal static RuntimeType AddElementTypes(SerializationInfo info, RuntimeType type) { }

	// RVA: 0x2141CC0 Offset: 0x21410C0 VA: 0x182141CC0
	internal Type MakeElementTypes(Type type) { }

	// RVA: 0x2141680 Offset: 0x2140A80 VA: 0x182141680
	internal static void GetUnitySerializationInfo(SerializationInfo info, RuntimeType type) { }

	// RVA: 0x2141AE0 Offset: 0x2140EE0 VA: 0x182141AE0
	internal static void GetUnitySerializationInfo(SerializationInfo info, int unityType, string data, RuntimeAssembly assembly) { }

	// RVA: 0x2141E80 Offset: 0x2141280 VA: 0x182141E80
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2141DE0 Offset: 0x21411E0 VA: 0x182141DE0
	private void ThrowInsufficientInformation(string field) { }

	// RVA: 0x2140FD0 Offset: 0x21403D0 VA: 0x182140FD0 Slot: 6
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2141040 Offset: 0x2140440 VA: 0x182141040 Slot: 7
	public virtual object GetRealObject(StreamingContext context) { }

}

