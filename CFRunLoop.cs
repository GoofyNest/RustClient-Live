internal class CFRunLoop : CFObject // TypeDefIndex: 2521
{	// Properties
	public static CFRunLoop CurrentRunLoop { get; }

	// Methods

	// RVA: 0x120E640 Offset: 0x120DA40 VA: 0x18120E640
	private static extern void CFRunLoopAddSource(IntPtr rl, IntPtr source, IntPtr mode) { }

	// RVA: 0x120E750 Offset: 0x120DB50 VA: 0x18120E750
	private static extern void CFRunLoopRemoveSource(IntPtr rl, IntPtr source, IntPtr mode) { }

	// RVA: 0x120E7F0 Offset: 0x120DBF0 VA: 0x18120E7F0
	private static extern int CFRunLoopRunInMode(IntPtr mode, double seconds, bool returnAfterSourceHandled) { }

	// RVA: 0x120E6E0 Offset: 0x120DAE0 VA: 0x18120E6E0
	private static extern IntPtr CFRunLoopGetCurrent() { }

	// RVA: 0x120E890 Offset: 0x120DC90 VA: 0x18120E890
	private static extern void CFRunLoopStop(IntPtr rl) { }

	// RVA: 0x120AED0 Offset: 0x120A2D0 VA: 0x18120AED0
	public void .ctor(IntPtr handle, bool own) { }

	// RVA: 0x120EAF0 Offset: 0x120DEF0 VA: 0x18120EAF0
	public static CFRunLoop get_CurrentRunLoop() { }

	// RVA: 0x120E590 Offset: 0x120D990 VA: 0x18120E590
	public void AddSource(IntPtr source, CFString mode) { }

	// RVA: 0x120E910 Offset: 0x120DD10 VA: 0x18120E910
	public void RemoveSource(IntPtr source, CFString mode) { }

	// RVA: 0x120E9C0 Offset: 0x120DDC0 VA: 0x18120E9C0
	public int RunInMode(CFString mode, double seconds, bool returnAfterSourceHandled) { }

	// RVA: 0x120EA70 Offset: 0x120DE70 VA: 0x18120EA70
	public void Stop() { }

}

