internal static class SourceServerQuery // TypeDefIndex: 5258
{	// Fields
	private static readonly byte[] A2S_SERVERQUERY_GETCHALLENGE; // 0x0
	private static readonly Dictionary<IPEndPoint, Task<Dictionary<string, string>>> PendingQueries; // 0x8

	// Methods

	// RVA: 0xDDED10 Offset: 0xDDE110 VA: 0x180DDED10
	internal static Task<Dictionary<string, string>> GetRules(ServerInfo server) { }

	[AsyncStateMachineAttribute] // RVA: 0x996A0 Offset: 0x98AA0 VA: 0x1800996A0
	// RVA: 0xDDEC40 Offset: 0xDDE040 VA: 0x180DDEC40
	private static Task<Dictionary<string, string>> GetRulesImpl(IPEndPoint endpoint) { }

	[AsyncStateMachineAttribute] // RVA: 0x99AD0 Offset: 0x98ED0 VA: 0x180099AD0
	// RVA: 0xDDF090 Offset: 0xDDE490 VA: 0x180DDF090
	private static Task<Dictionary<string, string>> GetRules(UdpClient client) { }

	[AsyncStateMachineAttribute] // RVA: 0x99CC0 Offset: 0x990C0 VA: 0x180099CC0
	// RVA: 0xDDF160 Offset: 0xDDE560 VA: 0x180DDF160
	private static Task<byte[]> Receive(UdpClient client) { }

	[AsyncStateMachineAttribute] // RVA: 0x99DE0 Offset: 0x991E0 VA: 0x180099DE0
	// RVA: 0xDDEB70 Offset: 0xDDDF70 VA: 0x180DDEB70
	private static Task<byte[]> GetChallengeData(UdpClient client) { }

	[AsyncStateMachineAttribute] // RVA: 0x9A0B0 Offset: 0x994B0 VA: 0x18009A0B0
	// RVA: 0xDDF230 Offset: 0xDDE630 VA: 0x180DDF230
	private static Task Send(UdpClient client, byte[] message) { }

	// RVA: 0xDDE9F0 Offset: 0xDDDDF0 VA: 0x180DDE9F0
	private static byte[] Combine(byte[][] arrays) { }

	// RVA: 0xDDF320 Offset: 0xDDE720 VA: 0x180DDF320
	private static void .cctor() { }

}

private sealed class SourceServerQuery.<>c__DisplayClass3_0 // TypeDefIndex: 5259
{	// Fields
	public IPEndPoint endpoint; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0xDEB0D0 Offset: 0xDEA4D0 VA: 0x180DEB0D0
	internal Task<Dictionary<string, string>> <GetRules>b__0(Task<Dictionary<string, string>> t) { }

}

private struct SourceServerQuery.<GetRulesImpl>d__4 : IAsyncStateMachine // TypeDefIndex: 5260
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<Dictionary<string, string>> <>t__builder; // 0x8
	public IPEndPoint endpoint; // 0x20
	private UdpClient <client>5__2; // 0x28
	private TaskAwaiter<Dictionary<string, string>> <>u__1; // 0x30

	// Methods

	// RVA: 0x1233D0 Offset: 0x1227D0 VA: 0x1801233D0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1233E0 Offset: 0x1227E0 VA: 0x1801233E0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct SourceServerQuery.<GetRules>d__5 : IAsyncStateMachine // TypeDefIndex: 5261
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<Dictionary<string, string>> <>t__builder; // 0x8
	public UdpClient client; // 0x20
	private TaskAwaiter<byte[]> <>u__1; // 0x28
	private TaskAwaiter <>u__2; // 0x30

	// Methods

	// RVA: 0x123430 Offset: 0x122830 VA: 0x180123430 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x123440 Offset: 0x122840 VA: 0x180123440 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private sealed class SourceServerQuery.<>c // TypeDefIndex: 5262
{	// Fields
	public static readonly SourceServerQuery.<>c <>9; // 0x0
	public static Func<byte[], bool> <>9__6_0; // 0x8
	public static Func<byte[], int> <>9__9_0; // 0x10

	// Methods

	// RVA: 0xDEB300 Offset: 0xDEA700 VA: 0x180DEB300
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0xDEAFD0 Offset: 0xDEA3D0 VA: 0x180DEAFD0
	internal bool <Receive>b__6_0(byte[] p) { }

	// RVA: 0xDEA210 Offset: 0xDE9610 VA: 0x180DEA210
	internal int <Combine>b__9_0(byte[] a) { }

}

private struct SourceServerQuery.<Receive>d__6 : IAsyncStateMachine // TypeDefIndex: 5263
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<byte[]> <>t__builder; // 0x8
	public UdpClient client; // 0x20
	private byte[][] <packets>5__2; // 0x28
	private TaskAwaiter<UdpReceiveResult> <>u__1; // 0x30

	// Methods

	// RVA: 0x1234F0 Offset: 0x1228F0 VA: 0x1801234F0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x123500 Offset: 0x122900 VA: 0x180123500 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct SourceServerQuery.<GetChallengeData>d__7 : IAsyncStateMachine // TypeDefIndex: 5264
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<byte[]> <>t__builder; // 0x8
	public UdpClient client; // 0x20
	private TaskAwaiter <>u__1; // 0x28
	private TaskAwaiter<byte[]> <>u__2; // 0x30

	// Methods

	// RVA: 0x1232B0 Offset: 0x1226B0 VA: 0x1801232B0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1232C0 Offset: 0x1226C0 VA: 0x1801232C0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct SourceServerQuery.<Send>d__8 : IAsyncStateMachine // TypeDefIndex: 5265
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public byte[] message; // 0x20
	public UdpClient client; // 0x28
	private TaskAwaiter<int> <>u__1; // 0x30

	// Methods

	// RVA: 0x123610 Offset: 0x122A10 VA: 0x180123610 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF2060 Offset: 0xF1460 VA: 0x1800F2060 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

