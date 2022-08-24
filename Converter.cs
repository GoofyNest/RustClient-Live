internal sealed class Converter // TypeDefIndex: 1090
{
	private static int primitiveTypeEnumLength; 
	private static Type[] typeA; 
	private static Type[] arrayTypeA; 
	private static string[] valueA; 
	private static TypeCode[] typeCodeA; 
	private static InternalPrimitiveTypeE[] codeA; 
	internal static Type typeofISerializable; 
	internal static Type typeofString; 
	internal static Type typeofConverter; 
	internal static Type typeofBoolean; 
	internal static Type typeofByte; 
	internal static Type typeofChar; 
	internal static Type typeofDecimal; 
	internal static Type typeofDouble; 
	internal static Type typeofInt16; 
	internal static Type typeofInt32; 
	internal static Type typeofInt64; 
	internal static Type typeofSByte; 
	internal static Type typeofSingle; 
	internal static Type typeofTimeSpan; 
	internal static Type typeofDateTime; 
	internal static Type typeofUInt16; 
	internal static Type typeofUInt32; 
	internal static Type typeofUInt64; 
	internal static Type typeofObject; 
	internal static Type typeofSystemVoid; 
	internal static Assembly urtAssembly; 
	internal static string urtAssemblyString; 
	internal static Type typeofTypeArray; 
	internal static Type typeofObjectArray; 
	internal static Type typeofStringArray; 
	internal static Type typeofBooleanArray; 
	internal static Type typeofByteArray; 
	internal static Type typeofCharArray; 
	internal static Type typeofDecimalArray; 
	internal static Type typeofDoubleArray; 
	internal static Type typeofInt16Array; 
	internal static Type typeofInt32Array; 
	internal static Type typeofInt64Array; 
	internal static Type typeofSByteArray; 
	internal static Type typeofSingleArray; 
	internal static Type typeofTimeSpanArray; 
	internal static Type typeofDateTimeArray; 
	internal static Type typeofUInt16Array; 
	internal static Type typeofUInt32Array; 
	internal static Type typeofUInt64Array; 
	internal static Type typeofMarshalByRefObject; 


internal static InternalPrimitiveTypeE ToCode(Type type) { }

internal static bool IsWriteAsByteArray(InternalPrimitiveTypeE code) { }

internal static int TypeLength(InternalPrimitiveTypeE code) { }

internal static Type ToArrayType(InternalPrimitiveTypeE code) { }

private static void InitTypeA() { }

private static void InitArrayTypeA() { }

internal static Type ToType(InternalPrimitiveTypeE code) { }

internal static Array CreatePrimitiveArray(InternalPrimitiveTypeE code, int length) { }

internal static bool IsPrimitiveArray(Type type, out object typeInformation) { }

private static void InitValueA() { }

internal static string ToComType(InternalPrimitiveTypeE code) { }

private static void InitTypeCodeA() { }

internal static TypeCode ToTypeCode(InternalPrimitiveTypeE code) { }

private static void InitCodeA() { }

internal static InternalPrimitiveTypeE ToPrimitiveTypeEnum(TypeCode typeCode) { }

internal static object FromString(string value, InternalPrimitiveTypeE code) { }

private static void .cctor() { }

}

