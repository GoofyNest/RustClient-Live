internal sealed class WriteObjectInfo // TypeDefIndex: 1107
{
	internal int objectInfoId; 
	internal object obj; 
	internal Type objectType; 
	internal bool isSi; 
	internal bool isNamed; 
	internal bool isTyped; 
	internal bool isArray; 
	internal SerializationInfo si; 
	internal SerObjectInfoCache cache; 
	internal object[] memberData; 
	internal ISerializationSurrogate serializationSurrogate; 
	internal StreamingContext context; 
	internal SerObjectInfoInit serObjectInfoInit; 
	internal long objectId; 
	internal long assemId; 
	private string binderTypeName; 
	private string binderAssemblyString; 


internal void .ctor() { }

internal void ObjectEnd() { }

private void InternalInit() { }

internal static WriteObjectInfo Serialize(object obj, ISurrogateSelector surrogateSelector, StreamingContext context, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, ObjectWriter objectWriter, SerializationBinder binder) { }

internal void InitSerialize(object obj, ISurrogateSelector surrogateSelector, StreamingContext context, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, ObjectWriter objectWriter, SerializationBinder binder) { }

internal static WriteObjectInfo Serialize(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, SerializationBinder binder) { }

internal void InitSerialize(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, SerializationBinder binder) { }

private void InitSiWrite() { }

private static void CheckTypeForwardedFrom(SerObjectInfoCache cache, Type objectType, string binderAssemblyString) { }

private void InitNoMembers() { }

private void InitMemberInfo() { }

internal string GetTypeFullName() { }

internal string GetAssemblyString() { }

private void InvokeSerializationBinder(SerializationBinder binder) { }

internal Type GetMemberType(MemberInfo objMember) { }

internal void GetMemberInfo(out string[] outMemberNames, out Type[] outMemberTypes, out object[] outMemberData) { }

private static WriteObjectInfo GetObjectInfo(SerObjectInfoInit serObjectInfoInit) { }

private static void PutObjectInfo(SerObjectInfoInit serObjectInfoInit, WriteObjectInfo objectInfo) { }

}

