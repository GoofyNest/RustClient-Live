public static class FormatterServices // TypeDefIndex: 1026
{	// Fields
	internal static ConcurrentDictionary<MemberHolder, MemberInfo[]> m_MemberInfoTable; // 0x0
	private static bool unsafeTypeForwardersIsEnabled; // 0x8
	private static bool unsafeTypeForwardersIsEnabledInitialized; // 0x9
	private static readonly Type[] advancedTypes; // 0x10
	private static Binder s_binder; // 0x18

	// Methods

	// RVA: 0x11EFEC0 Offset: 0x11EF2C0 VA: 0x1811EFEC0
	private static void .cctor() { }

	// RVA: 0x11EE760 Offset: 0x11EDB60 VA: 0x1811EE760
	private static MemberInfo[] GetSerializableMembers(RuntimeType type) { }

	// RVA: 0x11EDA00 Offset: 0x11ECE00 VA: 0x1811EDA00
	private static bool CheckSerializable(RuntimeType type) { }

	// RVA: 0x11EEDC0 Offset: 0x11EE1C0 VA: 0x1811EEDC0
	private static MemberInfo[] InternalGetSerializableMembers(RuntimeType type) { }

	// RVA: 0x11EE3D0 Offset: 0x11ED7D0 VA: 0x1811EE3D0
	private static bool GetParentTypes(RuntimeType parentType, out RuntimeType[] parentTypes, out int parentTypeCount) { }

	// RVA: 0x11EE910 Offset: 0x11EDD10 VA: 0x1811EE910
	public static MemberInfo[] GetSerializableMembers(Type type, StreamingContext context) { }

	// RVA: 0x11EEC10 Offset: 0x11EE010 VA: 0x1811EEC10
	public static object GetUninitializedObject(Type type) { }

	// RVA: 0x11F0030 Offset: 0x11EF430 VA: 0x1811F0030
	private static object nativeGetUninitializedObject(RuntimeType type) { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0
	private static bool GetEnableUnsafeTypeForwarders() { }

	// RVA: 0x11EFDE0 Offset: 0x11EF1E0 VA: 0x1811EFDE0
	internal static bool UnsafeTypeForwardersIsEnabled() { }

	// RVA: 0x11EFBF0 Offset: 0x11EEFF0 VA: 0x1811EFBF0
	internal static void SerializationSetValue(MemberInfo fi, object target, object value) { }

	// RVA: 0x11EF8E0 Offset: 0x11EECE0 VA: 0x1811EF8E0
	public static object PopulateObjectMembers(object obj, MemberInfo[] members, object[] data) { }

	// RVA: 0x11EE060 Offset: 0x11ED460 VA: 0x1811EE060
	public static object[] GetObjectData(object obj, MemberInfo[] members) { }

	// RVA: 0x11EEB60 Offset: 0x11EDF60 VA: 0x1811EEB60
	public static Type GetTypeFromAssembly(Assembly assem, string name) { }

	// RVA: 0x11EF8D0 Offset: 0x11EECD0 VA: 0x1811EF8D0
	internal static Assembly LoadAssemblyFromString(string assemblyName) { }

	// RVA: 0x11EF850 Offset: 0x11EEC50 VA: 0x1811EF850
	internal static Assembly LoadAssemblyFromStringNoThrow(string assemblyName) { }

	// RVA: 0x11EDA30 Offset: 0x11ECE30 VA: 0x1811EDA30
	internal static string GetClrAssemblyName(Type type, out bool hasTypeForwardedFrom) { }

	// RVA: 0x11EDFD0 Offset: 0x11ED3D0 VA: 0x1811EDFD0
	internal static string GetClrTypeFullName(Type type) { }

	// RVA: 0x11EDB90 Offset: 0x11ECF90 VA: 0x1811EDB90
	private static string GetClrTypeFullNameForArray(Type type) { }

	// RVA: 0x11EDD70 Offset: 0x11ED170 VA: 0x1811EDD70
	private static string GetClrTypeFullNameForNonArrayTypes(Type type) { }

}

private sealed class FormatterServices.<>c__DisplayClass9_0 // TypeDefIndex: 1027
{	// Fields
	public Type type; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x12012C0 Offset: 0x12006C0 VA: 0x1812012C0
	internal MemberInfo[] <GetSerializableMembers>b__0(MemberHolder _) { }

}

