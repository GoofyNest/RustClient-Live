internal class MemberInfoSerializationHolder : ISerializable, IObjectReference // TypeDefIndex: 536
{	// Fields
	private string m_memberName; // 0x10
	private RuntimeType m_reflectedType; // 0x18
	private string m_signature; // 0x20
	private string m_signature2; // 0x28
	private MemberTypes m_memberType; // 0x30
	private SerializationInfo m_info; // 0x38

	// Methods

	// RVA: 0x18C6280 Offset: 0x18C5680 VA: 0x1818C6280
	public static void GetSerializationInfo(SerializationInfo info, string name, RuntimeType reflectedClass, string signature, MemberTypes type) { }

	// RVA: 0x18C62B0 Offset: 0x18C56B0 VA: 0x1818C62B0
	public static void GetSerializationInfo(SerializationInfo info, string name, RuntimeType reflectedClass, string signature, string signature2, MemberTypes type, Type[] genericArguments) { }

	// RVA: 0x18C6500 Offset: 0x18C5900 VA: 0x1818C6500
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x18C5320 Offset: 0x18C4720 VA: 0x1818C5320 Slot: 6
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x18C5390 Offset: 0x18C4790 VA: 0x1818C5390 Slot: 7
	public virtual object GetRealObject(StreamingContext context) { }

}

