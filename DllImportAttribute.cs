public sealed class DllImportAttribute : Attribute // TypeDefIndex: 1338
{	// Fields
	internal string _val; // 0x10
	public string EntryPoint; // 0x18
	public CharSet CharSet; // 0x20
	public bool SetLastError; // 0x24
	public bool ExactSpelling; // 0x25
	public bool PreserveSig; // 0x26
	public CallingConvention CallingConvention; // 0x28
	public bool BestFitMapping; // 0x2C
	public bool ThrowOnUnmappableChar; // 0x2D

	// Properties
	public string Value { get; }

	// Methods

	// RVA: 0xFE0C40 Offset: 0xFE0040 VA: 0x180FE0C40
	internal static Attribute GetCustomAttribute(RuntimeMethodInfo method) { }

	// RVA: 0xFE0F00 Offset: 0xFE0300 VA: 0x180FE0F00
	internal static bool IsDefined(RuntimeMethodInfo method) { }

	// RVA: 0xFE0F30 Offset: 0xFE0330 VA: 0x180FE0F30
	internal void .ctor(string dllName, string entryPoint, CharSet charSet, bool exactSpelling, bool setLastError, bool preserveSig, CallingConvention callingConvention, bool bestFitMapping, bool throwOnUnmappableChar) { }

	// RVA: 0x805E80 Offset: 0x805280 VA: 0x180805E80
	public void .ctor(string dllName) { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public string get_Value() { }

}

