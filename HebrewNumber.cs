internal class HebrewNumber // TypeDefIndex: 708
{	// Fields
	private static HebrewNumber.HebrewValue[] HebrewValues; // 0x0
	private static char maxHebrewNumberCh; // 0x8
	private static readonly HebrewNumber.HS[][] NumberPasingState; // 0x10

	// Methods

	// RVA: 0x16EF700 Offset: 0x16EEB00 VA: 0x1816EF700
	internal static string ToString(int Number) { }

	// RVA: 0x16EF4E0 Offset: 0x16EE8E0 VA: 0x1816EF4E0
	internal static HebrewNumberParsingState ParseByChar(char ch, ref HebrewNumberParsingContext context) { }

	// RVA: 0x16EF3E0 Offset: 0x16EE7E0 VA: 0x1816EF3E0
	internal static bool IsDigit(char ch) { }

	// RVA: 0x16EF970 Offset: 0x16EED70 VA: 0x1816EF970
	private static void .cctor() { }

}

private enum HebrewNumber.HebrewToken // TypeDefIndex: 709
{	// Fields
	public int value__; // 0x0
	public const HebrewNumber.HebrewToken Invalid = -1;
	public const HebrewNumber.HebrewToken Digit400 = 0;
	public const HebrewNumber.HebrewToken Digit200_300 = 1;
	public const HebrewNumber.HebrewToken Digit100 = 2;
	public const HebrewNumber.HebrewToken Digit10 = 3;
	public const HebrewNumber.HebrewToken Digit1 = 4;
	public const HebrewNumber.HebrewToken Digit6_7 = 5;
	public const HebrewNumber.HebrewToken Digit7 = 6;
	public const HebrewNumber.HebrewToken Digit9 = 7;
	public const HebrewNumber.HebrewToken SingleQuote = 8;
	public const HebrewNumber.HebrewToken DoubleQuote = 9;

}

private class HebrewNumber.HebrewValue // TypeDefIndex: 710
{	// Fields
	internal HebrewNumber.HebrewToken token; // 0x10
	internal int value; // 0x14

	// Methods

	// RVA: 0x45B750 Offset: 0x45AB50 VA: 0x18045B750
	internal void .ctor(HebrewNumber.HebrewToken token, int value) { }

}

internal enum HebrewNumber.HS // TypeDefIndex: 711
{	// Fields
	public int value__; // 0x0
	public const HebrewNumber.HS _err = -1;
	public const HebrewNumber.HS Start = 0;
	public const HebrewNumber.HS S400 = 1;
	public const HebrewNumber.HS S400_400 = 2;
	public const HebrewNumber.HS S400_X00 = 3;
	public const HebrewNumber.HS S400_X0 = 4;
	public const HebrewNumber.HS X00_DQ = 5;
	public const HebrewNumber.HS S400_X00_X0 = 6;
	public const HebrewNumber.HS X0_DQ = 7;
	public const HebrewNumber.HS X = 8;
	public const HebrewNumber.HS X0 = 9;
	public const HebrewNumber.HS X00 = 10;
	public const HebrewNumber.HS S400_DQ = 11;
	public const HebrewNumber.HS S400_400_DQ = 12;
	public const HebrewNumber.HS S400_400_100 = 13;
	public const HebrewNumber.HS S9 = 14;
	public const HebrewNumber.HS X00_S9 = 15;
	public const HebrewNumber.HS S9_DQ = 16;
	public const HebrewNumber.HS END = 100;

}

