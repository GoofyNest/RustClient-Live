internal static class ParameterizedStrings // TypeDefIndex: 394
{
	[ThreadStaticAttribute]
	private static ParameterizedStrings.LowLevelStack _cachedStack;


	public static string Evaluate(string format, ParameterizedStrings.FormatParam[] args) { }

	private static string EvaluateInternal(string format, ref int pos, ParameterizedStrings.FormatParam[] args, ParameterizedStrings.LowLevelStack stack, ref ParameterizedStrings.FormatParam[] dynamicVars, ref ParameterizedStrings.FormatParam[] staticVars) { }

	private static bool AsBool(int i) { }

	private static int AsInt(bool b) { }

	private static string StringFromAsciiBytes(byte[] buffer, int offset, int length) { }

	private static extern int snprintf(byte* str, IntPtr size, string format, string arg1) { }

	private static extern int snprintf(byte* str, IntPtr size, string format, int arg1) { }

	private static string FormatPrintF(string format, object arg) { }

	private static ParameterizedStrings.FormatParam[] GetDynamicOrStaticVariables(char c, ref ParameterizedStrings.FormatParam[] dynamicVars, ref ParameterizedStrings.FormatParam[] staticVars, out int index) { }

}

public struct ParameterizedStrings.FormatParam // TypeDefIndex: 395
{
	private readonly int _int32;
	private readonly string _string;

	public int Int32 { get; }
	public string String { get; }
	public object Object { get; }


	public void .ctor(int value) { }

	private void .ctor(int intValue, string stringValue) { }

	public static ParameterizedStrings.FormatParam op_Implicit(int value) { }

	public int get_Int32() { }

	public string get_String() { }

	public object get_Object() { }

}

private sealed class ParameterizedStrings.LowLevelStack // TypeDefIndex: 396
{
	private ParameterizedStrings.FormatParam[] _arr;
	private int _count;


	public void .ctor() { }

	public ParameterizedStrings.FormatParam Pop() { }

	public void Push(ParameterizedStrings.FormatParam item) { }

	public void Clear() { }

}

