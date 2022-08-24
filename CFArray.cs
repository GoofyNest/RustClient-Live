internal class CFArray : CFObject // TypeDefIndex: 2514
{
	private static readonly IntPtr kCFTypeArrayCallbacks; 

	public int Count { get; }
	public IntPtr Item { get; }


	public void .ctor(IntPtr handle, bool own) { }

	private static void .cctor() { }

	private static extern IntPtr CFArrayGetCount(IntPtr handle) { }

	public int get_Count() { }

	private static extern IntPtr CFArrayGetValueAtIndex(IntPtr handle, IntPtr index) { }

	public IntPtr get_Item(int index) { }

}

