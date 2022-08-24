internal class CFString : CFObject // TypeDefIndex: 2518
{
	private string str; 


	public void .ctor(IntPtr handle, bool own) { }

	private static extern IntPtr CFStringCreateWithCharacters(IntPtr alloc, IntPtr chars, IntPtr length) { }

	public static CFString Create(string value) { }

	private static extern IntPtr CFStringGetLength(IntPtr handle) { }

	private static extern IntPtr CFStringGetCharactersPtr(IntPtr handle) { }

	private static extern IntPtr CFStringGetCharacters(IntPtr handle, CFRange range, IntPtr buffer) { }

	public static string AsString(IntPtr handle) { }

	public override string ToString() { }

}

