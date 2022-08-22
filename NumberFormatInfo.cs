public sealed class NumberFormatInfo : ICloneable, IFormatProvider // TypeDefIndex: 713
{	private static NumberFormatInfo invariantInfo; // 0x0
	internal int[] numberGroupSizes; // 0x10
	internal int[] currencyGroupSizes; // 0x18
	internal int[] percentGroupSizes; // 0x20
	internal string positiveSign; // 0x28
	internal string negativeSign; // 0x30
	internal string numberDecimalSeparator; // 0x38
	internal string numberGroupSeparator; // 0x40
	internal string currencyGroupSeparator; // 0x48
	internal string currencyDecimalSeparator; // 0x50
	internal string currencySymbol; // 0x58
	internal string ansiCurrencySymbol; // 0x60
	internal string nanSymbol; // 0x68
	internal string positiveInfinitySymbol; // 0x70
	internal string negativeInfinitySymbol; // 0x78
	internal string percentDecimalSeparator; // 0x80
	internal string percentGroupSeparator; // 0x88
	internal string percentSymbol; // 0x90
	internal string perMilleSymbol; // 0x98
	[OptionalFieldAttribute] // RVA: 0x92E60 Offset: 0x92260 VA: 0x180092E60
	internal string[] nativeDigits; // 0xA0
	[OptionalFieldAttribute] // RVA: 0x96440 Offset: 0x95840 VA: 0x180096440
	internal int m_dataItem; // 0xA8
	internal int numberDecimalDigits; // 0xAC
	internal int currencyDecimalDigits; // 0xB0
	internal int currencyPositivePattern; // 0xB4
	internal int currencyNegativePattern; // 0xB8
	internal int numberNegativePattern; // 0xBC
	internal int percentPositivePattern; // 0xC0
	internal int percentNegativePattern; // 0xC4
	internal int percentDecimalDigits; // 0xC8
	[OptionalFieldAttribute] // RVA: 0x92E60 Offset: 0x92260 VA: 0x180092E60
	internal int digitSubstitution; // 0xCC
	internal bool isReadOnly; // 0xD0
	[OptionalFieldAttribute] // RVA: 0x96440 Offset: 0x95840 VA: 0x180096440
	internal bool m_useUserOverride; // 0xD1
	[OptionalFieldAttribute] // RVA: 0x92E60 Offset: 0x92260 VA: 0x180092E60
	internal bool m_isInvariant; // 0xD2
	[OptionalFieldAttribute] // RVA: 0x96440 Offset: 0x95840 VA: 0x180096440
	internal bool validForParseAsNumber; // 0xD3
	[OptionalFieldAttribute] // RVA: 0x96440 Offset: 0x95840 VA: 0x180096440
	internal bool validForParseAsCurrency; // 0xD4
	private const NumberStyles InvalidNumberStyles = -1024;

	public static NumberFormatInfo InvariantInfo { get; }
	public int CurrencyDecimalDigits { get; }
	public string CurrencyDecimalSeparator { get; }
	public bool IsReadOnly { get; }
	public int[] CurrencyGroupSizes { get; }
	public int[] NumberGroupSizes { get; }
	public int[] PercentGroupSizes { get; }
	public string CurrencyGroupSeparator { get; }
	public string CurrencySymbol { get; }
	public static NumberFormatInfo CurrentInfo { get; }
	public string NaNSymbol { get; }
	public int CurrencyNegativePattern { get; }
	public int NumberNegativePattern { get; }
	public int PercentPositivePattern { get; }
	public int PercentNegativePattern { get; }
	public string NegativeInfinitySymbol { get; }
	public string NegativeSign { get; }
	public int NumberDecimalDigits { get; }
	public string NumberDecimalSeparator { get; }
	public string NumberGroupSeparator { get; }
	public int CurrencyPositivePattern { get; }
	public string PositiveInfinitySymbol { get; }
	public string PositiveSign { get; }
	public int PercentDecimalDigits { get; }
	public string PercentDecimalSeparator { get; }
	public string PercentGroupSeparator { get; }
	public string PercentSymbol { get; }
	public string PerMilleSymbol { get; }


	public void .ctor() { }

	[OnSerializingAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void OnSerializing(StreamingContext ctx) { }

	[OnDeserializingAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void OnDeserializing(StreamingContext ctx) { }

	[OnDeserializedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void OnDeserialized(StreamingContext ctx) { }

	internal void .ctor(CultureData cultureData) { }

	public static NumberFormatInfo get_InvariantInfo() { }

	public static NumberFormatInfo GetInstance(IFormatProvider formatProvider) { }

	public object Clone() { }

	public int get_CurrencyDecimalDigits() { }

	public string get_CurrencyDecimalSeparator() { }

	public bool get_IsReadOnly() { }

	public int[] get_CurrencyGroupSizes() { }

	public int[] get_NumberGroupSizes() { }

	public int[] get_PercentGroupSizes() { }

	public string get_CurrencyGroupSeparator() { }

	public string get_CurrencySymbol() { }

	public static NumberFormatInfo get_CurrentInfo() { }

	public string get_NaNSymbol() { }

	public int get_CurrencyNegativePattern() { }

	public int get_NumberNegativePattern() { }

	public int get_PercentPositivePattern() { }

	public int get_PercentNegativePattern() { }

	public string get_NegativeInfinitySymbol() { }

	public string get_NegativeSign() { }

	public int get_NumberDecimalDigits() { }

	public string get_NumberDecimalSeparator() { }

	public string get_NumberGroupSeparator() { }

	public int get_CurrencyPositivePattern() { }

	public string get_PositiveInfinitySymbol() { }

	public string get_PositiveSign() { }

	public int get_PercentDecimalDigits() { }

	public string get_PercentDecimalSeparator() { }

	public string get_PercentGroupSeparator() { }

	public string get_PercentSymbol() { }

	public string get_PerMilleSymbol() { }

	public object GetFormat(Type formatType) { }

	public static NumberFormatInfo ReadOnly(NumberFormatInfo nfi) { }

	internal static void ValidateParseStyleInteger(NumberStyles style) { }

	internal static void ValidateParseStyleFloatingPoint(NumberStyles style) { }

}

