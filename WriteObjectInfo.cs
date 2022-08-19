internal sealed class WriteObjectInfo // TypeDefIndex: 1107
{	// Fields
	internal int objectInfoId; // 0x10
	internal object obj; // 0x18
	internal Type objectType; // 0x20
	internal bool isSi; // 0x28
	internal bool isNamed; // 0x29
	internal bool isTyped; // 0x2A
	internal bool isArray; // 0x2B
	internal SerializationInfo si; // 0x30
	internal SerObjectInfoCache cache; // 0x38
	internal object[] memberData; // 0x40
	internal ISerializationSurrogate serializationSurrogate; // 0x48
	internal StreamingContext context; // 0x50
	internal SerObjectInfoInit serObjectInfoInit; // 0x60
	internal long objectId; // 0x68
	internal long assemId; // 0x70
	private string binderTypeName; // 0x78
	private string binderAssemblyString; // 0x80

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	internal void .ctor() { }

	// RVA: 0x1203A40 Offset: 0x1202E40 VA: 0x181203A40
	internal void ObjectEnd() { }

	// RVA: 0x1203970 Offset: 0x1202D70 VA: 0x181203970
	private void InternalInit() { }

	// RVA: 0x1203B40 Offset: 0x1202F40 VA: 0x181203B40
	internal static WriteObjectInfo Serialize(object obj, ISurrogateSelector surrogateSelector, StreamingContext context, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, ObjectWriter objectWriter, SerializationBinder binder) { }

	// RVA: 0x1202D80 Offset: 0x1202180 VA: 0x181202D80
	internal void InitSerialize(object obj, ISurrogateSelector surrogateSelector, StreamingContext context, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, ObjectWriter objectWriter, SerializationBinder binder) { }

	// RVA: 0x1203AA0 Offset: 0x1202EA0 VA: 0x181203AA0
	internal static WriteObjectInfo Serialize(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, SerializationBinder binder) { }

	// RVA: 0x12027D0 Offset: 0x1201BD0 VA: 0x1812027D0
	internal void InitSerialize(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, SerializationBinder binder) { }

	// RVA: 0x12035B0 Offset: 0x12029B0 VA: 0x1812035B0
	private void InitSiWrite() { }

	// RVA: 0x1201C60 Offset: 0x1201060 VA: 0x181201C60
	private static void CheckTypeForwardedFrom(SerObjectInfoCache cache, Type objectType, string binderAssemblyString) { }

	// RVA: 0x12026B0 Offset: 0x1201AB0 VA: 0x1812026B0
	private void InitNoMembers() { }

	// RVA: 0x12022C0 Offset: 0x12016C0 VA: 0x1812022C0
	private void InitMemberInfo() { }

	// RVA: 0x1202290 Offset: 0x1201690 VA: 0x181202290
	internal string GetTypeFullName() { }

	// RVA: 0x1201DC0 Offset: 0x12011C0 VA: 0x181201DC0
	internal string GetAssemblyString() { }

	// RVA: 0x1203A00 Offset: 0x1202E00 VA: 0x181203A00
	private void InvokeSerializationBinder(SerializationBinder binder) { }

	// RVA: 0x1201EE0 Offset: 0x12012E0 VA: 0x181201EE0
	internal Type GetMemberType(MemberInfo objMember) { }

	// RVA: 0x1201DF0 Offset: 0x12011F0 VA: 0x181201DF0
	internal void GetMemberInfo(out string[] outMemberNames, out Type[] outMemberTypes, out object[] outMemberData) { }

	// RVA: 0x1202150 Offset: 0x1201550 VA: 0x181202150
	private static WriteObjectInfo GetObjectInfo(SerObjectInfoInit serObjectInfoInit) { }

	// RVA: 0x1203A70 Offset: 0x1202E70 VA: 0x181203A70
	private static void PutObjectInfo(SerObjectInfoInit serObjectInfoInit, WriteObjectInfo objectInfo) { }

}

