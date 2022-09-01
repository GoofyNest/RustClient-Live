public static class EAC // TypeDefIndex: 9189
{
	public static bool isLoading; 
	public static string lastError; 
	private static byte[] _lastTicket; 

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

	[IteratorStateMachineAttribute] 
	public static IEnumerator DoStartup() { }

	public static void DoShutdown() { }

	public static void DoUpdate() { }

	[AsyncStateMachineAttribute] 
	public static Task OnJoinServer() { }

	public static void OnLeaveServer() { }

	public static void OnMessageReceived(Message message) { }

	private static void .cctor() { }

}

private sealed class EAC.<DoStartup>d__12 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 9190
{
	private int <>1__state; 
	private object <>2__current; 

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] 
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] 
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute] 
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] 
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] 
	private object System.Collections.IEnumerator.get_Current() { }

}

private struct EAC.<OnJoinServer>d__16 : IAsyncStateMachine // TypeDefIndex: 9191
{
	public int <>1__state; 
	public AsyncTaskMethodBuilder <>t__builder; 
	private TaskAwaiter<byte[]> <>u__1; 


	private void MoveNext() { }

	[DebuggerHiddenAttribute] 
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

