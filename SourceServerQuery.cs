internal static class SourceServerQuery // TypeDefIndex: 5259
{
	private static readonly byte[] A2S_SERVERQUERY_GETCHALLENGE; 
	private static readonly Dictionary<IPEndPoint, Task<Dictionary<string, string>>> PendingQueries; 


	internal static Task<Dictionary<string, string>> GetRules(ServerInfo server) { }

	[AsyncStateMachineAttribute] 
	private static Task<Dictionary<string, string>> GetRulesImpl(IPEndPoint endpoint) { }

	[AsyncStateMachineAttribute] 
	private static Task<Dictionary<string, string>> GetRules(UdpClient client) { }

	[AsyncStateMachineAttribute] 
	private static Task<byte[]> Receive(UdpClient client) { }

	[AsyncStateMachineAttribute] 
	private static Task<byte[]> GetChallengeData(UdpClient client) { }

	[AsyncStateMachineAttribute] 
	private static Task Send(UdpClient client, byte[] message) { }

	private static byte[] Combine(byte[][] arrays) { }

	private static void .cctor() { }

}

private sealed class SourceServerQuery.<>c__DisplayClass3_0 // TypeDefIndex: 5260
{
	public IPEndPoint endpoint; 


	public void .ctor() { }

	internal Task<Dictionary<string, string>> <GetRules>b__0(Task<Dictionary<string, string>> t) { }

}

private struct SourceServerQuery.<GetRulesImpl>d__4 : IAsyncStateMachine // TypeDefIndex: 5261
{
	public int <>1__state; 
	public AsyncTaskMethodBuilder<Dictionary<string, string>> <>t__builder; 
	public IPEndPoint endpoint; 
	private UdpClient <client>5__2; 
	private TaskAwaiter<Dictionary<string, string>> <>u__1; 


	private void MoveNext() { }

	[DebuggerHiddenAttribute] 
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct SourceServerQuery.<GetRules>d__5 : IAsyncStateMachine // TypeDefIndex: 5262
{
	public int <>1__state; 
	public AsyncTaskMethodBuilder<Dictionary<string, string>> <>t__builder; 
	public UdpClient client; 
	private TaskAwaiter<byte[]> <>u__1; 
	private TaskAwaiter <>u__2; 


	private void MoveNext() { }

	[DebuggerHiddenAttribute] 
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private sealed class SourceServerQuery.<>c // TypeDefIndex: 5263
{
	public static readonly SourceServerQuery.<>c <>9; 
	public static Func<byte[], bool> <>9__6_0; 
	public static Func<byte[], int> <>9__9_0; 


	private static void .cctor() { }

	public void .ctor() { }

	internal bool <Receive>b__6_0(byte[] p) { }

	internal int <Combine>b__9_0(byte[] a) { }

}

private struct SourceServerQuery.<Receive>d__6 : IAsyncStateMachine // TypeDefIndex: 5264
{
	public int <>1__state; 
	public AsyncTaskMethodBuilder<byte[]> <>t__builder; 
	public UdpClient client; 
	private byte[][] <packets>5__2; 
	private TaskAwaiter<UdpReceiveResult> <>u__1; 


	private void MoveNext() { }

	[DebuggerHiddenAttribute] 
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct SourceServerQuery.<GetChallengeData>d__7 : IAsyncStateMachine // TypeDefIndex: 5265
{
	public int <>1__state; 
	public AsyncTaskMethodBuilder<byte[]> <>t__builder; 
	public UdpClient client; 
	private TaskAwaiter <>u__1; 
	private TaskAwaiter<byte[]> <>u__2; 


	private void MoveNext() { }

	[DebuggerHiddenAttribute] 
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct SourceServerQuery.<Send>d__8 : IAsyncStateMachine // TypeDefIndex: 5266
{
	public int <>1__state; 
	public AsyncTaskMethodBuilder <>t__builder; 
	public byte[] message; 
	public UdpClient client; 
	private TaskAwaiter<int> <>u__1; 


	private void MoveNext() { }

	[DebuggerHiddenAttribute] 
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

