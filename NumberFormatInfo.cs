public sealed class NumberFormatInfo : ICloneable, IFormatProvider // TypeDefIndex: 713
{	// Fields
	private static NumberFormatInfo invariantInfo; // 0x0
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

	// Properties
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

	// Methods

	// RVA: 0x137FCE0 Offset: 0x137F0E0 VA: 0x18137FCE0
	public void .ctor() { }

	[OnSerializingAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x137F340 Offset: 0x137E740 VA: 0x18137F340
	private void OnSerializing(StreamingContext ctx) { }

	[OnDeserializingAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	private void OnDeserializing(StreamingContext ctx) { }

	[OnDeserializedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	private void OnDeserialized(StreamingContext ctx) { }

	// RVA: 0x137F620 Offset: 0x137EA20 VA: 0x18137F620
	internal void .ctor(CultureData cultureData) { }

	// RVA: 0x137FE70 Offset: 0x137F270 VA: 0x18137FE70
	public static NumberFormatInfo get_InvariantInfo() { }

	// RVA: 0x137F0C0 Offset: 0x137E4C0 VA: 0x18137F0C0
	public static NumberFormatInfo GetInstance(IFormatProvider formatProvider) { }

	// RVA: 0x137EFC0 Offset: 0x137E3C0 VA: 0x18137EFC0 Slot: 4
	public object Clone() { }

	// RVA: 0x2F95B0 Offset: 0x2F89B0 VA: 0x1802F95B0
	public int get_CurrencyDecimalDigits() { }

	// RVA: 0x4CC350 Offset: 0x4CB750 VA: 0x1804CC350
	public string get_CurrencyDecimalSeparator() { }

	// RVA: 0xDAEC30 Offset: 0xDAE030 VA: 0x180DAEC30
	public bool get_IsReadOnly() { }

	// RVA: 0x137FCF0 Offset: 0x137F0F0 VA: 0x18137FCF0
	public int[] get_CurrencyGroupSizes() { }

	// RVA: 0x137FF80 Offset: 0x137F380 VA: 0x18137FF80
	public int[] get_NumberGroupSizes() { }

	// RVA: 0x1380000 Offset: 0x137F400 VA: 0x181380000
	public int[] get_PercentGroupSizes() { }

	// RVA: 0x5DCCA0 Offset: 0x5DC0A0 VA: 0x1805DCCA0
	public string get_CurrencyGroupSeparator() { }

	// RVA: 0x4CC340 Offset: 0x4CB740 VA: 0x1804CC340
	public string get_CurrencySymbol() { }

	// RVA: 0x137FD70 Offset: 0x137F170 VA: 0x18137FD70
	public static NumberFormatInfo get_CurrentInfo() { }

	// RVA: 0x5334F0 Offset: 0x5328F0 VA: 0x1805334F0
	public string get_NaNSymbol() { }

	// RVA: 0x1074D10 Offset: 0x1074110 VA: 0x181074D10
	public int get_CurrencyNegativePattern() { }

	// RVA: 0x1074D00 Offset: 0x1074100 VA: 0x181074D00
	public int get_NumberNegativePattern() { }

	// RVA: 0x1074CF0 Offset: 0x10740F0 VA: 0x181074CF0
	public int get_PercentPositivePattern() { }

	// RVA: 0xADE1B0 Offset: 0xADD5B0 VA: 0x180ADE1B0
	public int get_PercentNegativePattern() { }

	// RVA: 0x4E4EC0 Offset: 0x4E42C0 VA: 0x1804E4EC0
	public string get_NegativeInfinitySymbol() { }

	// RVA: 0x4A2EE0 Offset: 0x4A22E0 VA: 0x1804A2EE0
	public string get_NegativeSign() { }

	// RVA: 0xA2BC00 Offset: 0xA2B000 VA: 0x180A2BC00
	public int get_NumberDecimalDigits() { }

	// RVA: 0x5DCC00 Offset: 0x5DC000 VA: 0x1805DCC00
	public string get_NumberDecimalSeparator() { }

	// RVA: 0x4B9440 Offset: 0x4B8840 VA: 0x1804B9440
	public string get_NumberGroupSeparator() { }

	// RVA: 0x1074CE0 Offset: 0x10740E0 VA: 0x181074CE0
	public int get_CurrencyPositivePattern() { }

	// RVA: 0x58DC30 Offset: 0x58D030 VA: 0x18058DC30
	public string get_PositiveInfinitySymbol() { }

	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230
	public string get_PositiveSign() { }

	// RVA: 0xADE1D0 Offset: 0xADD5D0 VA: 0x180ADE1D0
	public int get_PercentDecimalDigits() { }

	// RVA: 0x58DC40 Offset: 0x58D040 VA: 0x18058DC40
	public string get_PercentDecimalSeparator() { }

	// RVA: 0x58DBD0 Offset: 0x58CFD0 VA: 0x18058DBD0
	public string get_PercentGroupSeparator() { }

	// RVA: 0x4E09F0 Offset: 0x4DFDF0 VA: 0x1804E09F0
	public string get_PercentSymbol() { }

	// RVA: 0x58DBE0 Offset: 0x58CFE0 VA: 0x18058DBE0
	public string get_PerMilleSymbol() { }

	// RVA: 0x137F030 Offset: 0x137E430 VA: 0x18137F030 Slot: 5
	public object GetFormat(Type formatType) { }

	// RVA: 0x137F3D0 Offset: 0x137E7D0 VA: 0x18137F3D0
	public static NumberFormatInfo ReadOnly(NumberFormatInfo nfi) { }

	// RVA: 0x137F550 Offset: 0x137E950 VA: 0x18137F550
	internal static void ValidateParseStyleInteger(NumberStyles style) { }

	// RVA: 0x137F480 Offset: 0x137E880 VA: 0x18137F480
	internal static void ValidateParseStyleFloatingPoint(NumberStyles style) { }

}

