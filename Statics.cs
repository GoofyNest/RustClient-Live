internal static class Statics // TypeDefIndex: 1577
{	// Fields
	public static readonly TraceLoggingDataType IntPtrType; // 0x0
	public static readonly TraceLoggingDataType UIntPtrType; // 0x4
	public static readonly TraceLoggingDataType HexIntPtrType; // 0x8

	// Methods

	// RVA: 0x10E1620 Offset: 0x10E0A20 VA: 0x1810E1620
	public static byte[] MetadataForString(string name, int prefixSize, int suffixSize, int additionalSize) { }

	// RVA: 0x10E0A00 Offset: 0x10DFE00 VA: 0x1810E0A00
	public static void EncodeTags(int tags, ref int pos, byte[] metadata) { }

	// RVA: 0x10E09D0 Offset: 0x10DFDD0 VA: 0x1810E09D0
	public static byte Combine(int settingValue, byte defaultValue) { }

	// RVA: 0x10E09C0 Offset: 0x10DFDC0 VA: 0x1810E09C0
	public static int Combine(int settingValue1, int settingValue2) { }

	// RVA: 0x10E0940 Offset: 0x10DFD40 VA: 0x1810E0940
	public static void CheckName(string name) { }

	// RVA: 0x10E1830 Offset: 0x10E0C30 VA: 0x1810E1830
	public static bool ShouldOverrideFieldName(string fieldName) { }

	// RVA: 0x10E1610 Offset: 0x10E0A10 VA: 0x1810E1610
	public static TraceLoggingDataType MakeDataType(TraceLoggingDataType baseType, EventFieldFormat format) { }

	// RVA: 0x10E0F50 Offset: 0x10E0350 VA: 0x1810E0F50
	public static TraceLoggingDataType Format8(EventFieldFormat format, TraceLoggingDataType native) { }

	// RVA: 0x10E0D80 Offset: 0x10E0180 VA: 0x1810E0D80
	public static TraceLoggingDataType Format16(EventFieldFormat format, TraceLoggingDataType native) { }

	// RVA: 0x10E0E20 Offset: 0x10E0220 VA: 0x1810E0E20
	public static TraceLoggingDataType Format32(EventFieldFormat format, TraceLoggingDataType native) { }

	// RVA: 0x10E0ED0 Offset: 0x10E02D0 VA: 0x1810E0ED0
	public static TraceLoggingDataType Format64(EventFieldFormat format, TraceLoggingDataType native) { }

	// RVA: 0x10E1000 Offset: 0x10E0400 VA: 0x1810E1000
	public static TraceLoggingDataType FormatPtr(EventFieldFormat format, TraceLoggingDataType native) { }

	// RVA: 0x10E09F0 Offset: 0x10DFDF0 VA: 0x1810E09F0
	public static object CreateInstance(Type type, object[] parameters) { }

	// RVA: 0x10E15F0 Offset: 0x10E09F0 VA: 0x1810E15F0
	public static bool IsValueType(Type type) { }

	// RVA: 0x10E14B0 Offset: 0x10E08B0 VA: 0x1810E14B0
	public static bool IsEnum(Type type) { }

	// RVA: 0x10E1120 Offset: 0x10E0520 VA: 0x1810E1120
	public static IEnumerable<PropertyInfo> GetProperties(Type type) { }

	// RVA: 0x10E1100 Offset: 0x10E0500 VA: 0x1810E1100
	public static MethodInfo GetGetMethod(PropertyInfo propInfo) { }

	// RVA: 0x10E10B0 Offset: 0x10E04B0 VA: 0x1810E10B0
	public static MethodInfo GetDeclaredStaticMethod(Type declaringType, string name) { }

	// RVA: 0x10E1470 Offset: 0x10E0870 VA: 0x1810E1470
	public static bool HasCustomAttribute(PropertyInfo propInfo, Type attributeType) { }

	// RVA: -1 Offset: -1
	public static AttributeType GetCustomAttribute<AttributeType>(PropertyInfo propInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1259A90 Offset: 0x1258E90 VA: 0x181259A90
	|-Statics.GetCustomAttribute<EventFieldAttribute>
	|-Statics.GetCustomAttribute<object>
	*/

	// RVA: -1 Offset: -1
	public static AttributeType GetCustomAttribute<AttributeType>(Type type) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1259980 Offset: 0x1258D80 VA: 0x181259980
	|-Statics.GetCustomAttribute<EventDataAttribute>
	|-Statics.GetCustomAttribute<object>
	|-Statics.GetCustomAttribute<CompilerGeneratedAttribute>
	*/

	// RVA: 0x10E10D0 Offset: 0x10E04D0 VA: 0x1810E10D0
	public static Type[] GetGenericArguments(Type type) { }

	// RVA: 0x10E0A70 Offset: 0x10DFE70 VA: 0x1810E0A70
	public static Type FindEnumerableElementType(Type type) { }

	// RVA: 0x10E14E0 Offset: 0x10E08E0 VA: 0x1810E14E0
	public static bool IsGenericMatch(Type type, object openType) { }

	// RVA: 0x10E09E0 Offset: 0x10DFDE0 VA: 0x1810E09E0
	public static Delegate CreateDelegate(Type delegateType, MethodInfo methodInfo) { }

	// RVA: 0x10E1140 Offset: 0x10E0540 VA: 0x1810E1140
	public static TraceLoggingTypeInfo GetTypeInfoInstance(Type dataType, List<Type> recursionCheck) { }

	// RVA: -1 Offset: -1
	public static TraceLoggingTypeInfo<DataType> CreateDefaultTypeInfo<DataType>(List<Type> recursionCheck) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12AA140 Offset: 0x12A9540 VA: 0x1812AA140
	|-Statics.CreateDefaultTypeInfo<bool>
	|
	|-RVA: 0x12AC070 Offset: 0x12AB470 VA: 0x1812AC070
	|-Statics.CreateDefaultTypeInfo<byte>
	|
	|-RVA: 0x12ADFA0 Offset: 0x12AD3A0 VA: 0x1812ADFA0
	|-Statics.CreateDefaultTypeInfo<char>
	|
	|-RVA: 0x12BB9F0 Offset: 0x12BADF0 VA: 0x1812BB9F0
	|-Statics.CreateDefaultTypeInfo<KeyValuePair<object, object>>
	|
	|-RVA: 0x12B1E00 Offset: 0x12B1200 VA: 0x1812B1E00
	|-Statics.CreateDefaultTypeInfo<DateTime>
	|
	|-RVA: 0x12AFED0 Offset: 0x12AF2D0 VA: 0x1812AFED0
	|-Statics.CreateDefaultTypeInfo<DateTimeOffset>
	|
	|-RVA: 0x12B3D30 Offset: 0x12B3130 VA: 0x1812B3D30
	|-Statics.CreateDefaultTypeInfo<Decimal>
	|
	|-RVA: 0x12B7B90 Offset: 0x12B6F90 VA: 0x1812B7B90
	|-Statics.CreateDefaultTypeInfo<EmptyStruct>
	|
	|-RVA: 0x12B5C60 Offset: 0x12B5060 VA: 0x1812B5C60
	|-Statics.CreateDefaultTypeInfo<double>
	|
	|-RVA: 0x12B9AC0 Offset: 0x12B8EC0 VA: 0x1812B9AC0
	|-Statics.CreateDefaultTypeInfo<Guid>
	|
	|-RVA: 0x1B15300 Offset: 0x1B14700 VA: 0x181B15300
	|-Statics.CreateDefaultTypeInfo<short>
	|
	|-RVA: 0x1B17230 Offset: 0x1B16630 VA: 0x181B17230
	|-Statics.CreateDefaultTypeInfo<int>
	|
	|-RVA: 0x1B19160 Offset: 0x1B18560 VA: 0x181B19160
	|-Statics.CreateDefaultTypeInfo<long>
	|
	|-RVA: 0x1B1B090 Offset: 0x1B1A490 VA: 0x181B1B090
	|-Statics.CreateDefaultTypeInfo<IntPtr>
	|
	|-RVA: 0x1B1CFC0 Offset: 0x1B1C3C0 VA: 0x181B1CFC0
	|-Statics.CreateDefaultTypeInfo<object>
	|
	|-RVA: 0x1B1EEF0 Offset: 0x1B1E2F0 VA: 0x181B1EEF0
	|-Statics.CreateDefaultTypeInfo<sbyte>
	|
	|-RVA: 0x1B20E20 Offset: 0x1B20220 VA: 0x181B20E20
	|-Statics.CreateDefaultTypeInfo<float>
	|
	|-RVA: 0x1B22D50 Offset: 0x1B22150 VA: 0x181B22D50
	|-Statics.CreateDefaultTypeInfo<TimeSpan>
	|
	|-RVA: 0x1B24C80 Offset: 0x1B24080 VA: 0x181B24C80
	|-Statics.CreateDefaultTypeInfo<ushort>
	|
	|-RVA: 0x1B26BB0 Offset: 0x1B25FB0 VA: 0x181B26BB0
	|-Statics.CreateDefaultTypeInfo<uint>
	|
	|-RVA: 0x1B28AE0 Offset: 0x1B27EE0 VA: 0x181B28AE0
	|-Statics.CreateDefaultTypeInfo<ulong>
	|
	|-RVA: 0x1B2AA10 Offset: 0x1B29E10 VA: 0x181B2AA10
	|-Statics.CreateDefaultTypeInfo<UIntPtr>
	*/

	// RVA: 0x10E1870 Offset: 0x10E0C70 VA: 0x1810E1870
	private static void .cctor() { }

}

