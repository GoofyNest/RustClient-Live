internal struct SafeStringMarshal : IDisposable // TypeDefIndex: 22
{
	private readonly string str; 
	private IntPtr marshaled_string; 

	public IntPtr Value { get; }


	public static IntPtr StringToUtf8(string str) { }

	public static void GFree(IntPtr ptr) { }

	public void .ctor(string str) { }

	public IntPtr get_Value() { }

	public void Dispose() { }

}

