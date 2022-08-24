public sealed class DllImportAttribute : Attribute // TypeDefIndex: 1338
{
	internal string _val; 
	public string EntryPoint; 
	public CharSet CharSet; 
	public bool SetLastError; 
	public bool ExactSpelling; 
	public bool PreserveSig; 
	public CallingConvention CallingConvention; 
	public bool BestFitMapping; 
	public bool ThrowOnUnmappableChar; 

public string Value { get; }


internal static Attribute GetCustomAttribute(RuntimeMethodInfo method) { }

internal static bool IsDefined(RuntimeMethodInfo method) { }

internal void .ctor(string dllName, string entryPoint, CharSet charSet, bool exactSpelling, bool setLastError, bool preserveSig, CallingConvention callingConvention, bool bestFitMapping, bool throwOnUnmappableChar) { }

public void .ctor(string dllName) { }

public string get_Value() { }

}

