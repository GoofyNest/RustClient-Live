internal sealed class ReadObjectInfo // TypeDefIndex: 1108
{	// Fields
	internal int objectInfoId; // 0x10
	internal static int readObjectInfoCounter; // 0x0
	internal Type objectType; // 0x18
	internal ObjectManager objectManager; // 0x20
	internal int count; // 0x28
	internal bool isSi; // 0x2C
	internal bool isNamed; // 0x2D
	internal bool isTyped; // 0x2E
	internal bool bSimpleAssembly; // 0x2F
	internal SerObjectInfoCache cache; // 0x30
	internal string[] wireMemberNames; // 0x38
	internal Type[] wireMemberTypes; // 0x40
	private int lastPosition; // 0x48
	internal ISerializationSurrogate serializationSurrogate; // 0x50
	internal StreamingContext context; // 0x58
	internal List<Type> memberTypesList; // 0x68
	internal SerObjectInfoInit serObjectInfoInit; // 0x70
	internal IFormatterConverter formatterConverter; // 0x78

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	internal void .ctor() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	internal void ObjectEnd() { }

	// RVA: 0x11FCEE0 Offset: 0x11FC2E0 VA: 0x1811FCEE0
	internal void PrepareForReuse() { }

	// RVA: 0x11FB580 Offset: 0x11FA980 VA: 0x1811FB580
	internal static ReadObjectInfo Create(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context, ObjectManager objectManager, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, bool bSimpleAssembly) { }

	// RVA: 0x11FCAC0 Offset: 0x11FBEC0 VA: 0x1811FCAC0
	internal void Init(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context, ObjectManager objectManager, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, bool bSimpleAssembly) { }

	// RVA: 0x11FB410 Offset: 0x11FA810 VA: 0x1811FB410
	internal static ReadObjectInfo Create(Type objectType, string[] memberNames, Type[] memberTypes, ISurrogateSelector surrogateSelector, StreamingContext context, ObjectManager objectManager, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, bool bSimpleAssembly) { }

	// RVA: 0x11FCB80 Offset: 0x11FBF80 VA: 0x1811FCB80
	internal void Init(Type objectType, string[] memberNames, Type[] memberTypes, ISurrogateSelector surrogateSelector, StreamingContext context, ObjectManager objectManager, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, bool bSimpleAssembly) { }

	// RVA: 0x11FC800 Offset: 0x11FBC00 VA: 0x1811FC800
	private void InitReadConstructor(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context) { }

	// RVA: 0x11FCA50 Offset: 0x11FBE50 VA: 0x1811FCA50
	private void InitSiRead() { }

	// RVA: 0x11FC790 Offset: 0x11FBB90 VA: 0x1811FC790
	private void InitNoMembers() { }

	// RVA: 0x11FC4C0 Offset: 0x11FB8C0 VA: 0x1811FC4C0
	private void InitMemberInfo() { }

	// RVA: 0x11FB6B0 Offset: 0x11FAAB0 VA: 0x1811FB6B0
	internal MemberInfo GetMemberInfo(string name) { }

	// RVA: 0x11FC250 Offset: 0x11FB650 VA: 0x1811FC250
	internal Type GetType(string name) { }

	// RVA: 0x11FB350 Offset: 0x11FA750 VA: 0x1811FB350
	internal void AddValue(string name, object value, ref SerializationInfo si, ref object[] memberData) { }

	// RVA: 0x11FC3D0 Offset: 0x11FB7D0 VA: 0x1811FC3D0
	internal void InitDataStore(ref SerializationInfo si, ref object[] memberData) { }

	// RVA: 0x11FCEF0 Offset: 0x11FC2F0 VA: 0x1811FCEF0
	internal void RecordFixup(long objectId, string name, long idRef) { }

	// RVA: 0x11FCC90 Offset: 0x11FC090 VA: 0x1811FCC90
	internal void PopulateObjectMembers(object obj, object[] memberData) { }

	// RVA: 0x11FCD20 Offset: 0x11FC120 VA: 0x1811FCD20
	private int Position(string name) { }

	// RVA: 0x11FBB20 Offset: 0x11FAF20 VA: 0x1811FBB20
	internal Type[] GetMemberTypes(string[] inMemberNames, Type objectType) { }

	// RVA: 0x11FB8B0 Offset: 0x11FACB0 VA: 0x1811FB8B0
	internal Type GetMemberType(MemberInfo objMember) { }

	// RVA: 0x11FC1E0 Offset: 0x11FB5E0 VA: 0x1811FC1E0
	private static ReadObjectInfo GetObjectInfo(SerObjectInfoInit serObjectInfoInit) { }

}

