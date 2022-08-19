internal class CFUrl : CFObject // TypeDefIndex: 2520
{	// Methods

	// RVA: 0x120AED0 Offset: 0x120A2D0 VA: 0x18120AED0
	public void .ctor(IntPtr handle, bool own) { }

	// RVA: 0x120F250 Offset: 0x120E650 VA: 0x18120F250
	private static extern IntPtr CFURLCreateWithString(IntPtr allocator, IntPtr str, IntPtr baseURL) { }

	// RVA: 0x120F2F0 Offset: 0x120E6F0 VA: 0x18120F2F0
	public static CFUrl Create(string absolute) { }

}

