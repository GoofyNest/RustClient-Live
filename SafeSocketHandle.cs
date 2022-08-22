internal sealed class SafeSocketHandle : SafeHandleZeroOrMinusOneIsInvalid // TypeDefIndex: 3062
{	private List<Thread> blocking_threads; // 0x20
	private Dictionary<Thread, StackTrace> threads_stacktraces; // 0x28
	private bool in_cleanup; // 0x30
	private static bool THROW_ON_ABORT_RETRIES; // 0x0


	public void .ctor(IntPtr preexistingHandle, bool ownsHandle) { }

	protected override bool ReleaseHandle() { }

	public void RegisterForBlockingSyscall() { }

	public void UnRegisterForBlockingSyscall() { }

	private static void .cctor() { }

}

