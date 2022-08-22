public sealed class DllImportAttribute : Attribute // TypeDefIndex: 1338
{	internal string _val; // 0x10
	public string EntryPoint; // 0x18
	public CharSet CharSet; // 0x20
	public bool SetLastError; // 0x24
	public bool ExactSpelling; // 0x25
	public bool PreserveSig; // 0x26
	public CallingConvention CallingConvention; // 0x28
	public bool BestFitMapping; // 0x2C
	public bool ThrowOnUnmappableChar; // 0x2D

	public string Value { get; }


	internal static Attribute GetCustomAttribute(RuntimeMethodInfo method) { }

	internal static bool IsDefined(RuntimeMethodInfo method) { }

	internal void .ctor(string dllName, string entryPoint, CharSet charSet, bool exactSpelling, bool setLastError, bool preserveSig, CallingConvention callingConvention, bool bestFitMapping, bool throwOnUnmappableChar) { }

	public void .ctor(string dllName) { }

	public string get_Value() { }

}

