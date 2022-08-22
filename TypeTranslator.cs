internal class TypeTranslator // TypeDefIndex: 2064
{	private static Hashtable nameCache; // 0x0
	private static Hashtable primitiveTypes; // 0x8
	private static Hashtable primitiveArrayTypes; // 0x10
	private static Hashtable nullableTypes; // 0x18


	private static void .cctor() { }

	public static TypeData GetTypeData(Type type) { }

	public static TypeData GetTypeData(Type runtimeType, string xmlDataType, bool underlyingEnumType = False) { }

	public static TypeData GetPrimitiveTypeData(string typeName) { }

	public static TypeData GetPrimitiveTypeData(string typeName, bool nullable) { }

	public static TypeData FindPrimitiveTypeData(string typeName) { }

	public static string GetArrayName(string elemName) { }

	public static void ParseArrayType(string arrayType, out string type, out string ns, out string dimensions) { }

}

