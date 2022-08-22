internal class CFRunLoop : CFObject // TypeDefIndex: 2521
{	public static CFRunLoop CurrentRunLoop { get; }


	private static extern void CFRunLoopAddSource(IntPtr rl, IntPtr source, IntPtr mode) { }

	private static extern void CFRunLoopRemoveSource(IntPtr rl, IntPtr source, IntPtr mode) { }

	private static extern int CFRunLoopRunInMode(IntPtr mode, double seconds, bool returnAfterSourceHandled) { }

	private static extern IntPtr CFRunLoopGetCurrent() { }

	private static extern void CFRunLoopStop(IntPtr rl) { }

	public void .ctor(IntPtr handle, bool own) { }

	public static CFRunLoop get_CurrentRunLoop() { }

	public void AddSource(IntPtr source, CFString mode) { }

	public void RemoveSource(IntPtr source, CFString mode) { }

	public int RunInMode(CFString mode, double seconds, bool returnAfterSourceHandled) { }

	public void Stop() { }

}

