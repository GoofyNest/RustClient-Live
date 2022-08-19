internal sealed class Converter // TypeDefIndex: 1090
{	// Fields
	private static int primitiveTypeEnumLength; // 0x0
	private static Type[] typeA; // 0x8
	private static Type[] arrayTypeA; // 0x10
	private static string[] valueA; // 0x18
	private static TypeCode[] typeCodeA; // 0x20
	private static InternalPrimitiveTypeE[] codeA; // 0x28
	internal static Type typeofISerializable; // 0x30
	internal static Type typeofString; // 0x38
	internal static Type typeofConverter; // 0x40
	internal static Type typeofBoolean; // 0x48
	internal static Type typeofByte; // 0x50
	internal static Type typeofChar; // 0x58
	internal static Type typeofDecimal; // 0x60
	internal static Type typeofDouble; // 0x68
	internal static Type typeofInt16; // 0x70
	internal static Type typeofInt32; // 0x78
	internal static Type typeofInt64; // 0x80
	internal static Type typeofSByte; // 0x88
	internal static Type typeofSingle; // 0x90
	internal static Type typeofTimeSpan; // 0x98
	internal static Type typeofDateTime; // 0xA0
	internal static Type typeofUInt16; // 0xA8
	internal static Type typeofUInt32; // 0xB0
	internal static Type typeofUInt64; // 0xB8
	internal static Type typeofObject; // 0xC0
	internal static Type typeofSystemVoid; // 0xC8
	internal static Assembly urtAssembly; // 0xD0
	internal static string urtAssemblyString; // 0xD8
	internal static Type typeofTypeArray; // 0xE0
	internal static Type typeofObjectArray; // 0xE8
	internal static Type typeofStringArray; // 0xF0
	internal static Type typeofBooleanArray; // 0xF8
	internal static Type typeofByteArray; // 0x100
	internal static Type typeofCharArray; // 0x108
	internal static Type typeofDecimalArray; // 0x110
	internal static Type typeofDoubleArray; // 0x118
	internal static Type typeofInt16Array; // 0x120
	internal static Type typeofInt32Array; // 0x128
	internal static Type typeofInt64Array; // 0x130
	internal static Type typeofSByteArray; // 0x138
	internal static Type typeofSingleArray; // 0x140
	internal static Type typeofTimeSpanArray; // 0x148
	internal static Type typeofDateTimeArray; // 0x150
	internal static Type typeofUInt16Array; // 0x158
	internal static Type typeofUInt32Array; // 0x160
	internal static Type typeofUInt64Array; // 0x168
	internal static Type typeofMarshalByRefObject; // 0x170

	// Methods

	// RVA: 0x11EC070 Offset: 0x11EB470 VA: 0x1811EC070
	internal static InternalPrimitiveTypeE ToCode(Type type) { }

	// RVA: 0x11EBF00 Offset: 0x11EB300 VA: 0x1811EBF00
	internal static bool IsWriteAsByteArray(InternalPrimitiveTypeE code) { }

	// RVA: 0x11EC6A0 Offset: 0x11EBAA0 VA: 0x1811EC6A0
	internal static int TypeLength(InternalPrimitiveTypeE code) { }

	// RVA: 0x11EBF70 Offset: 0x11EB370 VA: 0x1811EBF70
	internal static Type ToArrayType(InternalPrimitiveTypeE code) { }

	// RVA: 0x11EAB50 Offset: 0x11E9F50 VA: 0x1811EAB50
	private static void InitTypeA() { }

	// RVA: 0x11EA140 Offset: 0x11E9540 VA: 0x1811EA140
	private static void InitArrayTypeA() { }

	// RVA: 0x11EC5A0 Offset: 0x11EB9A0 VA: 0x1811EC5A0
	internal static Type ToType(InternalPrimitiveTypeE code) { }

	// RVA: 0x11E9E60 Offset: 0x11E9260 VA: 0x1811E9E60
	internal static Array CreatePrimitiveArray(InternalPrimitiveTypeE code, int length) { }

	// RVA: 0x11EBBB0 Offset: 0x11EAFB0 VA: 0x1811EBBB0
	internal static bool IsPrimitiveArray(Type type, out object typeInformation) { }

	// RVA: 0x11EB500 Offset: 0x11EA900 VA: 0x1811EB500
	private static void InitValueA() { }

	// RVA: 0x11EC2C0 Offset: 0x11EB6C0 VA: 0x1811EC2C0
	internal static string ToComType(InternalPrimitiveTypeE code) { }

	// RVA: 0x11EB260 Offset: 0x11EA660 VA: 0x1811EB260
	private static void InitTypeCodeA() { }

	// RVA: 0x11EC4B0 Offset: 0x11EB8B0 VA: 0x1811EC4B0
	internal static TypeCode ToTypeCode(InternalPrimitiveTypeE code) { }

	// RVA: 0x11EA870 Offset: 0x11E9C70 VA: 0x1811EA870
	private static void InitCodeA() { }

	// RVA: 0x11EC3C0 Offset: 0x11EB7C0 VA: 0x1811EC3C0
	internal static InternalPrimitiveTypeE ToPrimitiveTypeEnum(TypeCode typeCode) { }

	// RVA: 0x11E9F90 Offset: 0x11E9390 VA: 0x1811E9F90
	internal static object FromString(string value, InternalPrimitiveTypeE code) { }

	// RVA: 0x11EC720 Offset: 0x11EBB20 VA: 0x1811EC720
	private static void .cctor() { }

}

