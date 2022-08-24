public sealed class NumberFormatInfo : ICloneable, IFormatProvider // TypeDefIndex: 713
{
	private static NumberFormatInfo invariantInfo; 
	internal int[] numberGroupSizes; 
	internal int[] currencyGroupSizes; 
	internal int[] percentGroupSizes; 
	internal string positiveSign; 
	internal string negativeSign; 
	internal string numberDecimalSeparator; 
	internal string numberGroupSeparator; 
	internal string currencyGroupSeparator; 
	internal string currencyDecimalSeparator; 
	internal string currencySymbol; 
	internal string ansiCurrencySymbol; 
	internal string nanSymbol; 
	internal string positiveInfinitySymbol; 
	internal string negativeInfinitySymbol; 
	internal string percentDecimalSeparator; 
	internal string percentGroupSeparator; 
	internal string percentSymbol; 
	internal string perMilleSymbol; 
	[OptionalFieldAttribute] 
	internal string[] nativeDigits; 
	[OptionalFieldAttribute] 
	internal int m_dataItem; 
	internal int numberDecimalDigits; 
	internal int currencyDecimalDigits; 
	internal int currencyPositivePattern; 
	internal int currencyNegativePattern; 
	internal int numberNegativePattern; 
	internal int percentPositivePattern; 
	internal int percentNegativePattern; 
	internal int percentDecimalDigits; 
	[OptionalFieldAttribute] 
	internal int digitSubstitution; 
	internal bool isReadOnly; 
	[OptionalFieldAttribute] 
	internal bool m_useUserOverride; 
	[OptionalFieldAttribute] 
	internal bool m_isInvariant; 
	[OptionalFieldAttribute] 
	internal bool validForParseAsNumber; 
	[OptionalFieldAttribute] 
	internal bool validForParseAsCurrency; 
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

	[OnSerializingAttribute] 
	private void OnSerializing(StreamingContext ctx) { }

	[OnDeserializingAttribute] 
	private void OnDeserializing(StreamingContext ctx) { }

	[OnDeserializedAttribute] 
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

