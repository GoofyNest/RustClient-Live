internal class MemberInfoSerializationHolder : ISerializable, IObjectReference // TypeDefIndex: 536
{
	private string m_memberName; 
	private RuntimeType m_reflectedType; 
	private string m_signature; 
	private string m_signature2; 
	private MemberTypes m_memberType; 
	private SerializationInfo m_info; 


public static void GetSerializationInfo(SerializationInfo info, string name, RuntimeType reflectedClass, string signature, MemberTypes type) { }

public static void GetSerializationInfo(SerializationInfo info, string name, RuntimeType reflectedClass, string signature, string signature2, MemberTypes type, Type[] genericArguments) { }

internal void .ctor(SerializationInfo info, StreamingContext context) { }

public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

public virtual object GetRealObject(StreamingContext context) { }

}

