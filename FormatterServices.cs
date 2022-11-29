public static class FormatterServices // TypeDefIndex: 1026
{
	internal static ConcurrentDictionary<MemberHolder, MemberInfo[]> m_MemberInfoTable; 
	private static bool unsafeTypeForwardersIsEnabled; 
	private static bool unsafeTypeForwardersIsEnabledInitialized; 
	private static readonly Type[] advancedTypes; 
	private static Binder s_binder; 


	private static void .cctor() { }

	private static MemberInfo[] GetSerializableMembers(RuntimeType type) { }

	private static bool CheckSerializable(RuntimeType type) { }

	private static MemberInfo[] InternalGetSerializableMembers(RuntimeType type) { }

	private static bool GetParentTypes(RuntimeType parentType, out RuntimeType[] parentTypes, out int parentTypeCount) { }

	public static MemberInfo[] GetSerializableMembers(Type type, StreamingContext context) { }

	public static object GetUninitializedObject(Type type) { }

	private static object nativeGetUninitializedObject(RuntimeType type) { }

	private static bool GetEnableUnsafeTypeForwarders() { }

	internal static bool UnsafeTypeForwardersIsEnabled() { }

	internal static void SerializationSetValue(MemberInfo fi, object target, object value) { }

	public static object PopulateObjectMembers(object obj, MemberInfo[] members, object[] data) { }

	public static object[] GetObjectData(object obj, MemberInfo[] members) { }

	public static Type GetTypeFromAssembly(Assembly assem, string name) { }

	internal static Assembly LoadAssemblyFromString(string assemblyName) { }

	internal static Assembly LoadAssemblyFromStringNoThrow(string assemblyName) { }

	internal static string GetClrAssemblyName(Type type, out bool hasTypeForwardedFrom) { }

	internal static string GetClrTypeFullName(Type type) { }

	private static string GetClrTypeFullNameForArray(Type type) { }

	private static string GetClrTypeFullNameForNonArrayTypes(Type type) { }

}

private sealed class FormatterServices.<>c__DisplayClass9_0 // TypeDefIndex: 1027
{
	public Type type; 


	public void .ctor() { }

	internal MemberInfo[] <GetSerializableMembers>

}

