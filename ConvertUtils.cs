internal static class ConvertUtils // TypeDefIndex: 5943
{
	private static readonly Dictionary<Type, PrimitiveTypeCode> TypeCodeMap; 
	private static readonly TypeInformation[] PrimitiveTypeCodes; 
	private static readonly ThreadSafeStore<ConvertUtils.TypeConvertKey, Func<object, object>> CastConverters; 


	public static PrimitiveTypeCode GetTypeCode(Type t) { }

	public static PrimitiveTypeCode GetTypeCode(Type t, out bool isEnum) { }

	public static TypeInformation GetTypeInformation(IConvertible convertable) { }

	public static bool IsConvertible(Type t) { }

	public static TimeSpan ParseTimeSpan(string input) { }

	private static Func<object, object> CreateCastConverter(ConvertUtils.TypeConvertKey t) { }

	private static bool TryConvert(object initialValue, CultureInfo culture, Type targetType, out object value) { }

	private static ConvertUtils.ConvertResult TryConvertInternal(object initialValue, CultureInfo culture, Type targetType, out object value) { }

	public static object ConvertOrCast(object initialValue, CultureInfo culture, Type targetType) { }

	private static object EnsureTypeAssignable(object value, Type initialType, Type targetType) { }

	internal static TypeConverter GetConverter(Type t) { }

	public static bool VersionTryParse(string input, out Version result) { }

	public static bool IsInteger(object value) { }

	public static ParseResult Int32TryParse(char[] chars, int start, int length, out int value) { }

	public static ParseResult Int64TryParse(char[] chars, int start, int length, out long value) { }

	public static bool TryConvertGuid(string s, out Guid g) { }

	public static int HexTextToInt(char[] text, int start, int end) { }

	private static int HexCharToInt(char ch) { }

	private static void .cctor() { }

}

internal struct ConvertUtils.TypeConvertKey // TypeDefIndex: 5944
{
	private readonly Type _initialType; 
	private readonly Type _targetType; 

	public Type InitialType { get; }
	public Type TargetType { get; }


	public Type get_InitialType() { }

	public Type get_TargetType() { }

	public void .ctor(Type initialType, Type targetType) { }

	public override int GetHashCode() { }

	public override bool Equals(object obj) { }

	public bool Equals(ConvertUtils.TypeConvertKey other) { }

}

internal enum ConvertUtils.ConvertResult // TypeDefIndex: 5945
{
	public int value__; 
	public const ConvertUtils.ConvertResult Success = 0;
	public const ConvertUtils.ConvertResult CannotConvertNull = 1;
	public const ConvertUtils.ConvertResult NotInstantiableType = 2;
	public const ConvertUtils.ConvertResult NoValidConversion = 3;

}

private sealed class ConvertUtils.<>c__DisplayClass9_0 // TypeDefIndex: 5946
{
	public MethodCall<object, object> call; 


	public void .ctor() { }

	internal object <CreateCastConverter>b__0(object o) { }

}

