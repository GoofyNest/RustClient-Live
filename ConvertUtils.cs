internal static class ConvertUtils // TypeDefIndex: 5943
{	// Fields
	private static readonly Dictionary<Type, PrimitiveTypeCode> TypeCodeMap; // 0x0
	private static readonly TypeInformation[] PrimitiveTypeCodes; // 0x8
	private static readonly ThreadSafeStore<ConvertUtils.TypeConvertKey, Func<object, object>> CastConverters; // 0x10

	// Methods

	// RVA: 0x17FA630 Offset: 0x17F9A30 VA: 0x1817FA630
	public static PrimitiveTypeCode GetTypeCode(Type t) { }

	// RVA: 0x17FA690 Offset: 0x17F9A90 VA: 0x1817FA690
	public static PrimitiveTypeCode GetTypeCode(Type t, out bool isEnum) { }

	// RVA: 0x17FA930 Offset: 0x17F9D30 VA: 0x1817FA930
	public static TypeInformation GetTypeInformation(IConvertible convertable) { }

	// RVA: 0x17FAF00 Offset: 0x17FA300 VA: 0x1817FAF00
	public static bool IsConvertible(Type t) { }

	// RVA: 0x17FB0B0 Offset: 0x17FA4B0 VA: 0x1817FB0B0
	public static TimeSpan ParseTimeSpan(string input) { }

	// RVA: 0x17FA0A0 Offset: 0x17F94A0 VA: 0x1817FA0A0
	private static Func<object, object> CreateCastConverter(ConvertUtils.TypeConvertKey t) { }

	// RVA: 0x17FBC10 Offset: 0x17FB010 VA: 0x1817FBC10
	private static bool TryConvert(object initialValue, CultureInfo culture, Type targetType, out object value) { }

	// RVA: 0x17FB250 Offset: 0x17FA650 VA: 0x1817FB250
	private static ConvertUtils.ConvertResult TryConvertInternal(object initialValue, CultureInfo culture, Type targetType, out object value) { }

	// RVA: 0x17F9F30 Offset: 0x17F9330 VA: 0x1817F9F30
	public static object ConvertOrCast(object initialValue, CultureInfo culture, Type targetType) { }

	// RVA: 0x17FA2E0 Offset: 0x17F96E0 VA: 0x1817FA2E0
	private static object EnsureTypeAssignable(object value, Type initialType, Type targetType) { }

	// RVA: 0x17FA5A0 Offset: 0x17F99A0 VA: 0x1817FA5A0
	internal static TypeConverter GetConverter(Type t) { }

	// RVA: 0x17FBCE0 Offset: 0x17FB0E0 VA: 0x1817FBCE0
	public static bool VersionTryParse(string input, out Version result) { }

	// RVA: 0x17FAF90 Offset: 0x17FA390 VA: 0x1817FAF90
	public static bool IsInteger(object value) { }

	// RVA: 0x17FAB90 Offset: 0x17F9F90 VA: 0x1817FAB90
	public static ParseResult Int32TryParse(char[] chars, int start, int length, out int value) { }

	// RVA: 0x17FAD60 Offset: 0x17FA160 VA: 0x1817FAD60
	public static ParseResult Int64TryParse(char[] chars, int start, int length, out long value) { }

	// RVA: 0x17FB110 Offset: 0x17FA510 VA: 0x1817FB110
	public static bool TryConvertGuid(string s, out Guid g) { }

	// RVA: 0x17FAAB0 Offset: 0x17F9EB0 VA: 0x1817FAAB0
	public static int HexTextToInt(char[] text, int start, int end) { }

	// RVA: 0x17FA9E0 Offset: 0x17F9DE0 VA: 0x1817FA9E0
	private static int HexCharToInt(char ch) { }

	// RVA: 0x17FBD80 Offset: 0x17FB180 VA: 0x1817FBD80
	private static void .cctor() { }

}

internal struct ConvertUtils.TypeConvertKey // TypeDefIndex: 5944
{	// Fields
	private readonly Type _initialType; // 0x0
	private readonly Type _targetType; // 0x8

	// Properties
	public Type InitialType { get; }
	public Type TargetType { get; }

	// Methods

	// RVA: 0xFC6D0 Offset: 0xFBAD0 VA: 0x1800FC6D0
	public Type get_InitialType() { }

	// RVA: 0xF3DB0 Offset: 0xF31B0 VA: 0x1800F3DB0
	public Type get_TargetType() { }

	// RVA: 0xF5940 Offset: 0xF4D40 VA: 0x1800F5940
	public void .ctor(Type initialType, Type targetType) { }

	// RVA: 0xF58E0 Offset: 0xF4CE0 VA: 0x1800F58E0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x211D00 Offset: 0x211100 VA: 0x180211D00 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2114B0 Offset: 0x2108B0 VA: 0x1802114B0
	public bool Equals(ConvertUtils.TypeConvertKey other) { }

}

internal enum ConvertUtils.ConvertResult // TypeDefIndex: 5945
{	// Fields
	public int value__; // 0x0
	public const ConvertUtils.ConvertResult Success = 0;
	public const ConvertUtils.ConvertResult CannotConvertNull = 1;
	public const ConvertUtils.ConvertResult NotInstantiableType = 2;
	public const ConvertUtils.ConvertResult NoValidConversion = 3;

}

private sealed class ConvertUtils.<>c__DisplayClass9_0 // TypeDefIndex: 5946
{	// Fields
	public MethodCall<object, object> call; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x1810250 Offset: 0x180F650 VA: 0x181810250
	internal object <CreateCastConverter>b__0(object o) { }

}

