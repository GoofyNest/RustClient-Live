internal sealed class SafeSocketHandle : SafeHandleZeroOrMinusOneIsInvalid // TypeDefIndex: 3062
{	// Fields
	private List<Thread> blocking_threads; // 0x20
	private Dictionary<Thread, StackTrace> threads_stacktraces; // 0x28
	private bool in_cleanup; // 0x30
	private static bool THROW_ON_ABORT_RETRIES; // 0x0

	// Methods

	// RVA: 0xFF7610 Offset: 0xFF6A10 VA: 0x180FF7610
	public void .ctor(IntPtr preexistingHandle, bool ownsHandle) { }

	// RVA: 0xFF6F30 Offset: 0xFF6330 VA: 0x180FF6F30 Slot: 7
	protected override bool ReleaseHandle() { }

	// RVA: 0xFF6CC0 Offset: 0xFF60C0 VA: 0x180FF6CC0
	public void RegisterForBlockingSyscall() { }

	// RVA: 0xFF7420 Offset: 0xFF6820 VA: 0x180FF7420
	public void UnRegisterForBlockingSyscall() { }

	// RVA: 0xFF75B0 Offset: 0xFF69B0 VA: 0x180FF75B0
	private static void .cctor() { }

}

