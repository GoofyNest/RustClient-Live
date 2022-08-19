internal class CFArray : CFObject // TypeDefIndex: 2514
{	// Fields
	private static readonly IntPtr kCFTypeArrayCallbacks; // 0x1363A

	// Properties
	public int Count { get; }
	public IntPtr Item { get; }

	// Methods

	// RVA: 0x120AED0 Offset: 0x120A2D0 VA: 0x18120AED0
	public void .ctor(IntPtr handle, bool own) { }

	// RVA: 0x120ADE0 Offset: 0x120A1E0 VA: 0x18120ADE0
	private static void .cctor() { }

	// RVA: 0x120ACD0 Offset: 0x120A0D0 VA: 0x18120ACD0
	private static extern IntPtr CFArrayGetCount(IntPtr handle) { }

	// RVA: 0x120AEE0 Offset: 0x120A2E0 VA: 0x18120AEE0
	public int get_Count() { }

	// RVA: 0x120AD50 Offset: 0x120A150 VA: 0x18120AD50
	private static extern IntPtr CFArrayGetValueAtIndex(IntPtr handle, IntPtr index) { }

	// RVA: 0x120AFA0 Offset: 0x120A3A0 VA: 0x18120AFA0
	public IntPtr get_Item(int index) { }

}

