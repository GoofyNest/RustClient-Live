internal struct SafeStringMarshal : IDisposable // TypeDefIndex: 22
{	// Fields
	private readonly string str; // 0x0
	private IntPtr marshaled_string; // 0x8

	// Properties
	public IntPtr Value { get; }

	// Methods

	// RVA: 0x1645630 Offset: 0x1644A30 VA: 0x181645630
	public static IntPtr StringToUtf8(string str) { }

	// RVA: 0x1645620 Offset: 0x1644A20 VA: 0x181645620
	public static void GFree(IntPtr ptr) { }

	// RVA: 0x1F6A20 Offset: 0x1F5E20 VA: 0x1801F6A20
	public void .ctor(string str) { }

	// RVA: 0x1F6A70 Offset: 0x1F5E70 VA: 0x1801F6A70
	public IntPtr get_Value() { }

	// RVA: 0x1F69D0 Offset: 0x1F5DD0 VA: 0x1801F69D0 Slot: 4
	public void Dispose() { }

}

