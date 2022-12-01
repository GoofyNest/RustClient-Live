internal class HebrewNumber // TypeDefIndex: 708
{
	private static HebrewNumber.HebrewValue[] HebrewValues;
	private static char maxHebrewNumberCh;
	private static readonly HebrewNumber.HS[][] NumberPasingState;


	internal static string ToString(int Number) { }

	internal static HebrewNumberParsingState ParseByChar(char ch, ref HebrewNumberParsingContext context) { }

	internal static bool IsDigit(char ch) { }

	private static void .cctor() { }

}

private enum HebrewNumber.HebrewToken // TypeDefIndex: 709
{
	public int value__;
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
{
	internal HebrewNumber.HebrewToken token;
	internal int value;


	internal void .ctor(HebrewNumber.HebrewToken token, int value) { }

}

internal enum HebrewNumber.HS // TypeDefIndex: 711
{
	public int value__;
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

