internal static class Statics // TypeDefIndex: 1577
{	public static readonly TraceLoggingDataType IntPtrType; // 0x0
	public static readonly TraceLoggingDataType UIntPtrType; // 0x4
	public static readonly TraceLoggingDataType HexIntPtrType; // 0x8


	public static byte[] MetadataForString(string name, int prefixSize, int suffixSize, int additionalSize) { }

	public static void EncodeTags(int tags, ref int pos, byte[] metadata) { }

	public static byte Combine(int settingValue, byte defaultValue) { }

	public static int Combine(int settingValue1, int settingValue2) { }

	public static void CheckName(string name) { }

	public static bool ShouldOverrideFieldName(string fieldName) { }

	public static TraceLoggingDataType MakeDataType(TraceLoggingDataType baseType, EventFieldFormat format) { }

	public static TraceLoggingDataType Format8(EventFieldFormat format, TraceLoggingDataType native) { }

	public static TraceLoggingDataType Format16(EventFieldFormat format, TraceLoggingDataType native) { }

	public static TraceLoggingDataType Format32(EventFieldFormat format, TraceLoggingDataType native) { }

	public static TraceLoggingDataType Format64(EventFieldFormat format, TraceLoggingDataType native) { }

	public static TraceLoggingDataType FormatPtr(EventFieldFormat format, TraceLoggingDataType native) { }

	public static object CreateInstance(Type type, object[] parameters) { }

	public static bool IsValueType(Type type) { }

	public static bool IsEnum(Type type) { }

	public static IEnumerable<PropertyInfo> GetProperties(Type type) { }

	public static MethodInfo GetGetMethod(PropertyInfo propInfo) { }

	public static MethodInfo GetDeclaredStaticMethod(Type declaringType, string name) { }

	public static bool HasCustomAttribute(PropertyInfo propInfo, Type attributeType) { }

	public static AttributeType GetCustomAttribute<AttributeType>(PropertyInfo propInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1259A90 Offset: 0x1258E90 VA: 0x181259A90
	|-Statics.GetCustomAttribute<EventFieldAttribute>
	|-Statics.GetCustomAttribute<object>
	*/

	public static AttributeType GetCustomAttribute<AttributeType>(Type type) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1259980 Offset: 0x1258D80 VA: 0x181259980
	|-Statics.GetCustomAttribute<EventDataAttribute>
	|-Statics.GetCustomAttribute<object>
	|-Statics.GetCustomAttribute<CompilerGeneratedAttribute>
	*/

	public static Type[] GetGenericArguments(Type type) { }

	public static Type FindEnumerableElementType(Type type) { }

	public static bool IsGenericMatch(Type type, object openType) { }

	public static Delegate CreateDelegate(Type delegateType, MethodInfo methodInfo) { }

	public static TraceLoggingTypeInfo GetTypeInfoInstance(Type dataType, List<Type> recursionCheck) { }

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

	private static void .cctor() { }

}

