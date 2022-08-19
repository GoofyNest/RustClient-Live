internal class CFString : CFObject // TypeDefIndex: 2518
{	// Fields
	private string str; // 0x18

	// Methods

	// RVA: 0x120AED0 Offset: 0x120A2D0 VA: 0x18120AED0
	public void .ctor(IntPtr handle, bool own) { }

	// RVA: 0x120EEB0 Offset: 0x120E2B0 VA: 0x18120EEB0
	private static extern IntPtr CFStringCreateWithCharacters(IntPtr alloc, IntPtr chars, IntPtr length) { }

	// RVA: 0x120F0F0 Offset: 0x120E4F0 VA: 0x18120F0F0
	public static CFString Create(string value) { }

	// RVA: 0x120F070 Offset: 0x120E470 VA: 0x18120F070
	private static extern IntPtr CFStringGetLength(IntPtr handle) { }

	// RVA: 0x120EF50 Offset: 0x120E350 VA: 0x18120EF50
	private static extern IntPtr CFStringGetCharactersPtr(IntPtr handle) { }

	// RVA: 0x120EFD0 Offset: 0x120E3D0 VA: 0x18120EFD0
	private static extern IntPtr CFStringGetCharacters(IntPtr handle, CFRange range, IntPtr buffer) { }

	// RVA: 0x120EC10 Offset: 0x120E010 VA: 0x18120EC10
	public static string AsString(IntPtr handle) { }

	// RVA: 0x120F210 Offset: 0x120E610 VA: 0x18120F210 Slot: 3
	public override string ToString() { }

}

