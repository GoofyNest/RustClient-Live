internal sealed class SafeSocketHandle : SafeHandleZeroOrMinusOneIsInvalid // TypeDefIndex: 3062
{
	private List<Thread> blocking_threads; 
	private Dictionary<Thread, StackTrace> threads_stacktraces; 
	private bool in_cleanup; 
	private static bool THROW_ON_ABORT_RETRIES; 


	public void .ctor(IntPtr preexistingHandle, bool ownsHandle) { }

	protected override bool ReleaseHandle() { }

	public void RegisterForBlockingSyscall() { }

	public void UnRegisterForBlockingSyscall() { }

	private static void .cctor() { }

}

