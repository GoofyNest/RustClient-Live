internal class TypeTranslator // TypeDefIndex: 2064
{	// Fields
	private static Hashtable nameCache; // 0x0
	private static Hashtable primitiveTypes; // 0x8
	private static Hashtable primitiveArrayTypes; // 0x10
	private static Hashtable nullableTypes; // 0x18

	// Methods

	// RVA: 0x1103A30 Offset: 0x1102E30 VA: 0x181103A30
	private static void .cctor() { }

	// RVA: 0x1102CC0 Offset: 0x11020C0 VA: 0x181102CC0
	public static TypeData GetTypeData(Type type) { }

	// RVA: 0x1102D20 Offset: 0x1102120 VA: 0x181102D20
	public static TypeData GetTypeData(Type runtimeType, string xmlDataType, bool underlyingEnumType = False) { }

	// RVA: 0x1102C60 Offset: 0x1102060 VA: 0x181102C60
	public static TypeData GetPrimitiveTypeData(string typeName) { }

	// RVA: 0x1102A10 Offset: 0x1101E10 VA: 0x181102A10
	public static TypeData GetPrimitiveTypeData(string typeName, bool nullable) { }

	// RVA: 0x1102850 Offset: 0x1101C50 VA: 0x181102850
	public static TypeData FindPrimitiveTypeData(string typeName) { }

	// RVA: 0x1102920 Offset: 0x1101D20 VA: 0x181102920
	public static string GetArrayName(string elemName) { }

	// RVA: 0x11038E0 Offset: 0x1102CE0 VA: 0x1811038E0
	public static void ParseArrayType(string arrayType, out string type, out string ns, out string dimensions) { }

}

