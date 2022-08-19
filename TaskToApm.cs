internal static class TaskToApm // TypeDefIndex: 890
{	// Methods

	// RVA: 0x1604C60 Offset: 0x1604060 VA: 0x181604C60
	public static IAsyncResult Begin(Task task, AsyncCallback callback, object state) { }

	// RVA: 0x1604E20 Offset: 0x1604220 VA: 0x181604E20
	public static void End(IAsyncResult asyncResult) { }

	// RVA: -1 Offset: -1
	public static TResult End<TResult>(IAsyncResult asyncResult) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14C0830 Offset: 0x14BFC30 VA: 0x1814C0830
	|-TaskToApm.End<int>
	|
	|-RVA: 0x14C08F0 Offset: 0x14BFCF0 VA: 0x1814C08F0
	|-TaskToApm.End<object>
	*/

	// RVA: 0x1604EE0 Offset: 0x16042E0 VA: 0x181604EE0
	private static void InvokeCallbackWhenTaskCompletes(Task antecedent, AsyncCallback callback, IAsyncResult asyncResult) { }

}

private sealed class TaskToApm.TaskWrapperAsyncResult : IAsyncResult // TypeDefIndex: 891
{	// Fields
	internal readonly Task Task; // 0x10
	private readonly object m_state; // 0x18
	private readonly bool m_completedSynchronously; // 0x20

	// Properties
	private object System.IAsyncResult.AsyncState { get; }
	private bool System.IAsyncResult.CompletedSynchronously { get; }
	private bool System.IAsyncResult.IsCompleted { get; }
	private WaitHandle System.IAsyncResult.AsyncWaitHandle { get; }

	// Methods

	// RVA: 0xFF6C00 Offset: 0xFF6000 VA: 0x180FF6C00
	internal void .ctor(Task task, object state, bool completedSynchronously) { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 6
	private object System.IAsyncResult.get_AsyncState() { }

	// RVA: 0xB0BB80 Offset: 0xB0AF80 VA: 0x180B0BB80 Slot: 7
	private bool System.IAsyncResult.get_CompletedSynchronously() { }

	// RVA: 0x4B0AA0 Offset: 0x4AFEA0 VA: 0x1804B0AA0 Slot: 4
	private bool System.IAsyncResult.get_IsCompleted() { }

	// RVA: 0x1604FD0 Offset: 0x16043D0 VA: 0x181604FD0 Slot: 5
	private WaitHandle System.IAsyncResult.get_AsyncWaitHandle() { }

}

private sealed class TaskToApm.<>c__DisplayClass3_0 // TypeDefIndex: 892
{	// Fields
	public AsyncCallback callback; // 0x10
	public IAsyncResult asyncResult; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x1616AC0 Offset: 0x1615EC0 VA: 0x181616AC0
	internal void <InvokeCallbackWhenTaskCompletes>b__0() { }

}

