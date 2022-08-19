public static class EAC // TypeDefIndex: 9185
{	// Fields
	public static bool isLoading; // 0x0
	public static string lastError; // 0x8
	private static byte[] _lastTicket; // 0x10

	// Properties
	private static bool IsEacEnabled { get; }
	public static bool IsEncryptionSupported { get; }

	// Methods

	// RVA: 0xAB2700 Offset: 0xAB1B00 VA: 0x180AB2700
	private static bool get_IsEacEnabled() { }

	// RVA: 0xAB2720 Offset: 0xAB1B20 VA: 0x180AB2720
	public static bool get_IsEncryptionSupported() { }

	// RVA: 0xAB1B60 Offset: 0xAB0F60 VA: 0x180AB1B60
	public static void Encrypt(Connection connection, MemoryStream src, int srcOffset, MemoryStream dst, int dstOffset) { }

	// RVA: 0xAB1770 Offset: 0xAB0B70 VA: 0x180AB1770
	public static void Decrypt(Connection connection, MemoryStream src, int srcOffset, MemoryStream dst, int dstOffset) { }

	// RVA: 0xAB1F00 Offset: 0xAB1300 VA: 0x180AB1F00
	private static void OnLaunchProgress(object sender, LoadProgressEventArgs eventArgs) { }

	// RVA: 0xAB1D60 Offset: 0xAB1160 VA: 0x180AB1D60
	private static void OnLaunchCompleted(object sender, LoadCompletedEventArgs eventArgs) { }

	// RVA: 0xAB2100 Offset: 0xAB1500 VA: 0x180AB2100
	private static void OnStateChanged(object sender, StateChangedEventArgs eventArgs) { }

	// RVA: 0xAB2470 Offset: 0xAB1870 VA: 0x180AB2470
	private static void SendToServer(byte[] message, int messageLength) { }

	[IteratorStateMachineAttribute] // RVA: 0xD7160 Offset: 0xD6560 VA: 0x1800D7160
	// RVA: 0xAB1980 Offset: 0xAB0D80 VA: 0x180AB1980
	public static IEnumerator DoStartup() { }

	// RVA: 0xAB18C0 Offset: 0xAB0CC0 VA: 0x180AB18C0
	public static void DoShutdown() { }

	// RVA: 0xAB19D0 Offset: 0xAB0DD0 VA: 0x180AB19D0
	public static void DoUpdate() { }

	[AsyncStateMachineAttribute] // RVA: 0xD72B0 Offset: 0xD66B0 VA: 0x1800D72B0
	// RVA: 0xAB1CA0 Offset: 0xAB10A0 VA: 0x180AB1CA0
	public static Task OnJoinServer() { }

	// RVA: 0xAB1FB0 Offset: 0xAB13B0 VA: 0x180AB1FB0
	public static void OnLeaveServer() { }

	// RVA: 0xAB2030 Offset: 0xAB1430 VA: 0x180AB2030
	public static void OnMessageReceived(Message message) { }

	// RVA: 0xAB26A0 Offset: 0xAB1AA0 VA: 0x180AB26A0
	private static void .cctor() { }

}

private sealed class EAC.<DoStartup>d__12 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 9186
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497770 Offset: 0x496B70 VA: 0x180497770
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0xAC1170 Offset: 0xAC0570 VA: 0x180AC1170 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xAC14B0 Offset: 0xAC08B0 VA: 0x180AC14B0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

private struct EAC.<OnJoinServer>d__16 : IAsyncStateMachine // TypeDefIndex: 9187
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	private TaskAwaiter<byte[]> <>u__1; // 0x20

	// Methods

	// RVA: 0xFC4F0 Offset: 0xFB8F0 VA: 0x1800FC4F0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF2060 Offset: 0xF1460 VA: 0x1800F2060 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

