internal static class ParameterizedStrings // TypeDefIndex: 394
{	// Fields
	[ThreadStaticAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static ParameterizedStrings.LowLevelStack _cachedStack; // 0x80000000

	// Methods

	// RVA: 0x167FD00 Offset: 0x167F100 VA: 0x18167FD00
	public static string Evaluate(string format, ParameterizedStrings.FormatParam[] args) { }

	// RVA: 0x167F100 Offset: 0x167E500 VA: 0x18167F100
	private static string EvaluateInternal(string format, ref int pos, ParameterizedStrings.FormatParam[] args, ParameterizedStrings.LowLevelStack stack, ref ParameterizedStrings.FormatParam[] dynamicVars, ref ParameterizedStrings.FormatParam[] staticVars) { }

	// RVA: 0x14534C0 Offset: 0x14528C0 VA: 0x1814534C0
	private static bool AsBool(int i) { }

	// RVA: 0x14558E0 Offset: 0x1454CE0 VA: 0x1814558E0
	private static int AsInt(bool b) { }

	// RVA: 0x16801C0 Offset: 0x167F5C0 VA: 0x1816801C0
	private static string StringFromAsciiBytes(byte[] buffer, int offset, int length) { }

	// RVA: 0x1680370 Offset: 0x167F770 VA: 0x181680370
	private static extern int snprintf(byte* str, IntPtr size, string format, string arg1) { }

	// RVA: 0x16802B0 Offset: 0x167F6B0 VA: 0x1816802B0
	private static extern int snprintf(byte* str, IntPtr size, string format, int arg1) { }

	// RVA: 0x167FE50 Offset: 0x167F250 VA: 0x18167FE50
	private static string FormatPrintF(string format, object arg) { }

	// RVA: 0x16800D0 Offset: 0x167F4D0 VA: 0x1816800D0
	private static ParameterizedStrings.FormatParam[] GetDynamicOrStaticVariables(char c, ref ParameterizedStrings.FormatParam[] dynamicVars, ref ParameterizedStrings.FormatParam[] staticVars, out int index) { }

}

public struct ParameterizedStrings.FormatParam // TypeDefIndex: 395
{	// Fields
	private readonly int _int32; // 0x0
	private readonly string _string; // 0x8

	// Properties
	public int Int32 { get; }
	public string String { get; }
	public object Object { get; }

	// Methods

	// RVA: 0x2150D0 Offset: 0x2144D0 VA: 0x1802150D0
	public void .ctor(int value) { }

	// RVA: 0xFC970 Offset: 0xFBD70 VA: 0x1800FC970
	private void .ctor(int intValue, string stringValue) { }

	// RVA: 0x18C4780 Offset: 0x18C3B80 VA: 0x1818C4780
	public static ParameterizedStrings.FormatParam op_Implicit(int value) { }

	// RVA: 0xF3850 Offset: 0xF2C50 VA: 0x1800F3850
	public int get_Int32() { }

	// RVA: 0x215140 Offset: 0x214540 VA: 0x180215140
	public string get_String() { }

	// RVA: 0x2150F0 Offset: 0x2144F0 VA: 0x1802150F0
	public object get_Object() { }

}

private sealed class ParameterizedStrings.LowLevelStack // TypeDefIndex: 396
{	// Fields
	private ParameterizedStrings.FormatParam[] _arr; // 0x10
	private int _count; // 0x18

	// Methods

	// RVA: 0x18C52C0 Offset: 0x18C46C0 VA: 0x1818C52C0
	public void .ctor() { }

	// RVA: 0x18C5110 Offset: 0x18C4510 VA: 0x1818C5110
	public ParameterizedStrings.FormatParam Pop() { }

	// RVA: 0x18C51C0 Offset: 0x18C45C0 VA: 0x1818C51C0
	public void Push(ParameterizedStrings.FormatParam item) { }

	// RVA: 0x18C50E0 Offset: 0x18C44E0 VA: 0x1818C50E0
	public void Clear() { }

}

