internal class TypeTranslator // TypeDefIndex: 2064
{
	private static Hashtable nameCache; 
	private static Hashtable primitiveTypes; 
	private static Hashtable primitiveArrayTypes; 
	private static Hashtable nullableTypes; 


private static void .cctor() { }

public static TypeData GetTypeData(Type type) { }

public static TypeData GetTypeData(Type runtimeType, string xmlDataType, bool underlyingEnumType = False) { }

public static TypeData GetPrimitiveTypeData(string typeName) { }

public static TypeData GetPrimitiveTypeData(string typeName, bool nullable) { }

public static TypeData FindPrimitiveTypeData(string typeName) { }

public static string GetArrayName(string elemName) { }

public static void ParseArrayType(string arrayType, out string type, out string ns, out string dimensions) { }

}

