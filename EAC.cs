public static class EAC // TypeDefIndex: 9185
{	public static bool isLoading; // 0x0
	public static string lastError; // 0x8
	private static byte[] _lastTicket; // 0x10

	private static bool IsEacEnabled { get; }
	public static bool IsEncryptionSupported { get; }


	private static bool get_IsEacEnabled() { }

	public static bool get_IsEncryptionSupported() { }

	public static void Encrypt(Connection connection, MemoryStream src, int srcOffset, MemoryStream dst, int dstOffset) { }

	public static void Decrypt(Connection connection, MemoryStream src, int srcOffset, MemoryStream dst, int dstOffset) { }

	private static void OnLaunchProgress(object sender, LoadProgressEventArgs eventArgs) { }

	private static void OnLaunchCompleted(object sender, LoadCompletedEventArgs eventArgs) { }

	private static void OnStateChanged(object sender, StateChangedEventArgs eventArgs) { }

	private static void SendToServer(byte[] message, int messageLength) { }

	[IteratorStateMachineAttribute] // RVA: 0xD7160 Offset: 0xD6560 VA: 0x1800D7160
	public static IEnumerator DoStartup() { }

	public static void DoShutdown() { }

	public static void DoUpdate() { }

	[AsyncStateMachineAttribute] // RVA: 0xD72B0 Offset: 0xD66B0 VA: 0x1800D72B0
	public static Task OnJoinServer() { }

	public static void OnLeaveServer() { }

	public static void OnMessageReceived(Message message) { }

	private static void .cctor() { }

}

private sealed class EAC.<DoStartup>d__12 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 9186
{	private int <>1__state; // 0x10
	private object <>2__current; // 0x18

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private object System.Collections.IEnumerator.get_Current() { }

}

private struct EAC.<OnJoinServer>d__16 : IAsyncStateMachine // TypeDefIndex: 9187
{	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	private TaskAwaiter<byte[]> <>u__1; // 0x20


	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

