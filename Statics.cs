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
	|-Statics.GetCustomAttribute<EventFieldAttribute>
	|-Statics.GetCustomAttribute<object>
	*/

	public static AttributeType GetCustomAttribute<AttributeType>(Type type) { }
	/* GenericInstMethod :
	|
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
	|-Statics.CreateDefaultTypeInfo<bool>
	|
	|-Statics.CreateDefaultTypeInfo<byte>
	|
	|-Statics.CreateDefaultTypeInfo<char>
	|
	|-Statics.CreateDefaultTypeInfo<KeyValuePair<object, object>>
	|
	|-Statics.CreateDefaultTypeInfo<DateTime>
	|
	|-Statics.CreateDefaultTypeInfo<DateTimeOffset>
	|
	|-Statics.CreateDefaultTypeInfo<Decimal>
	|
	|-Statics.CreateDefaultTypeInfo<EmptyStruct>
	|
	|-Statics.CreateDefaultTypeInfo<double>
	|
	|-Statics.CreateDefaultTypeInfo<Guid>
	|
	|-Statics.CreateDefaultTypeInfo<short>
	|
	|-Statics.CreateDefaultTypeInfo<int>
	|
	|-Statics.CreateDefaultTypeInfo<long>
	|
	|-Statics.CreateDefaultTypeInfo<IntPtr>
	|
	|-Statics.CreateDefaultTypeInfo<object>
	|
	|-Statics.CreateDefaultTypeInfo<sbyte>
	|
	|-Statics.CreateDefaultTypeInfo<float>
	|
	|-Statics.CreateDefaultTypeInfo<TimeSpan>
	|
	|-Statics.CreateDefaultTypeInfo<ushort>
	|
	|-Statics.CreateDefaultTypeInfo<uint>
	|
	|-Statics.CreateDefaultTypeInfo<ulong>
	|
	|-Statics.CreateDefaultTypeInfo<UIntPtr>
	*/

	private static void .cctor() { }

}

