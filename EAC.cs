public static class EAC // TypeDefIndex: 10894
{
	public static bool isLoading; 
	public static string lastError; 
	public static string steamTicket; 
	public static ProductUserId LocalUserId; 
	public static AntiCheatClientInterface Interface; 

	public static bool IsEncryptionSupported { get; }


	public static bool get_IsEncryptionSupported() { }

	public static void Encrypt(Connection connection, ArraySegment<byte> src, ref ArraySegment<byte> dst) { }

	public static void Decrypt(Connection connection, ArraySegment<byte> src, ref ArraySegment<byte> dst) { }

	private static void SendToServer(ref OnMessageToServerCallbackInfo data) { }

	private static void LoginCallback(ref LoginCallbackInfo data) { }

	private static void CreateUserCallback(ref CreateUserCallbackInfo data) { }

	private static void AuthExpirationCallback(ref AuthExpirationCallbackInfo data) { }

	public static void DoStartup() { }

	public static void DoShutdown() { }

	public static void DoUpdate() { }

	[AsyncStateMachineAttribute] 
	public static Task OnJoinServer() { }

	public static void OnLeaveServer() { }

	public static void OnMessageReceived(Message message) { }

	private static void .cctor() { }

}

private struct EAC.<OnJoinServer>d__16 : IAsyncStateMachine // TypeDefIndex: 10895
{
	public int <>1__state; 
	public AsyncTaskMethodBuilder <>t__builder; 
	private TaskAwaiter<byte[]> <>u__1; 
	private TaskAwaiter <>u__2; 


	private void MoveNext() { }

	[DebuggerHiddenAttribute] 
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

