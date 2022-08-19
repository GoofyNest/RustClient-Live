public class RgbController : IDisposable // TypeDefIndex: 7687
{	// Fields
	private readonly IReadOnlyList<IRgbService> _services; // 0x10
	private readonly CancellationTokenSource _cts; // 0x18
	private readonly ManualResetEventSlim _shutdown; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly IRgbService <SteelSeries>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly IRgbService <Razer>k__BackingField; // 0x30

	// Properties
	public IRgbService SteelSeries { get; }
	public IRgbService Razer { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230
	public IRgbService get_SteelSeries() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4A2EE0 Offset: 0x4A22E0 VA: 0x1804A2EE0
	public IRgbService get_Razer() { }

	// RVA: 0x21BC530 Offset: 0x21BB930 VA: 0x1821BC530
	public void .ctor() { }

	// RVA: 0x21BBA10 Offset: 0x21BAE10 VA: 0x1821BBA10 Slot: 4
	public void Dispose() { }

	// RVA: 0x21BC090 Offset: 0x21BB490 VA: 0x1821BC090
	public void StaticColor(Color color) { }

	// RVA: 0x21BBD90 Offset: 0x21BB190 VA: 0x1821BBD90
	public void PulseColor(Color color, float duration = 1) { }

	// RVA: 0x21BBAF0 Offset: 0x21BAEF0 VA: 0x1821BBAF0
	public void Event(RgbEventType type) { }

	[AsyncStateMachineAttribute] // RVA: 0xB94A0 Offset: 0xB88A0 VA: 0x1800B94A0
	// RVA: 0x21BC460 Offset: 0x21BB860 VA: 0x1821BC460
	private void Worker() { }

	[AsyncStateMachineAttribute] // RVA: 0xB9640 Offset: 0xB8A40 VA: 0x1800B9640
	// RVA: 0x21BBF90 Offset: 0x21BB390 VA: 0x1821BBF90
	private ValueTask StartServices() { }

	[AsyncStateMachineAttribute] // RVA: 0xB9780 Offset: 0xB8B80 VA: 0x1800B9780
	// RVA: 0x21BC260 Offset: 0x21BB660 VA: 0x1821BC260
	private ValueTask StopServices() { }

	[AsyncStateMachineAttribute] // RVA: 0xB9900 Offset: 0xB8D00 VA: 0x1800B9900
	// RVA: 0x21BC360 Offset: 0x21BB760 VA: 0x1821BC360
	private ValueTask UpdateServices() { }

	// RVA: 0x21BBCA0 Offset: 0x21BB0A0 VA: 0x1821BBCA0
	public static void LogError(string message) { }

	// RVA: 0x21BBD00 Offset: 0x21BB100 VA: 0x1821BBD00
	public static void LogError(Exception exception, string message) { }

}

private struct RgbController.<Worker>d__14 : IAsyncStateMachine // TypeDefIndex: 7688
{	// Fields
	public int <>1__state; // 0x0
	public AsyncVoidMethodBuilder <>t__builder; // 0x8
	public RgbController <>4__this; // 0x28
	private CancellationToken <ct>5__2; // 0x30
	private ValueTaskAwaiter <>u__1; // 0x38

	// Methods

	// RVA: 0x236E80 Offset: 0x236280 VA: 0x180236E80 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF1420 Offset: 0xF0820 VA: 0x1800F1420 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct RgbController.<StartServices>d__15 : IAsyncStateMachine // TypeDefIndex: 7689
{	// Fields
	public int <>1__state; // 0x0
	public AsyncValueTaskMethodBuilder <>t__builder; // 0x8
	public RgbController <>4__this; // 0x28
	private IEnumerator<IRgbService> <>7__wrap1; // 0x30
	private IRgbService <service>5__3; // 0x38
	private ValueTaskAwaiter <>u__1; // 0x40

	// Methods

	// RVA: 0x236E10 Offset: 0x236210 VA: 0x180236E10 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x236E00 Offset: 0x236200 VA: 0x180236E00 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct RgbController.<StopServices>d__16 : IAsyncStateMachine // TypeDefIndex: 7690
{	// Fields
	public int <>1__state; // 0x0
	public AsyncValueTaskMethodBuilder <>t__builder; // 0x8
	public RgbController <>4__this; // 0x28
	private IEnumerator<IRgbService> <>7__wrap1; // 0x30
	private IRgbService <service>5__3; // 0x38
	private ValueTaskAwaiter <>u__1; // 0x40

	// Methods

	// RVA: 0x236E40 Offset: 0x236240 VA: 0x180236E40 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x236E00 Offset: 0x236200 VA: 0x180236E00 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct RgbController.<UpdateServices>d__17 : IAsyncStateMachine // TypeDefIndex: 7691
{	// Fields
	public int <>1__state; // 0x0
	public AsyncValueTaskMethodBuilder <>t__builder; // 0x8
	public RgbController <>4__this; // 0x28
	private IEnumerator<IRgbService> <>7__wrap1; // 0x30
	private IRgbService <service>5__3; // 0x38
	private ValueTaskAwaiter <>u__1; // 0x40

	// Methods

	// RVA: 0x236E60 Offset: 0x236260 VA: 0x180236E60 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x236E00 Offset: 0x236200 VA: 0x180236E00 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

