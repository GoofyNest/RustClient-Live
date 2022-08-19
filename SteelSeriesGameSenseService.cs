public class SteelSeriesGameSenseService : RestRgbService // TypeDefIndex: 7693
{	// Fields
	private const string GameId = "RUST";
	private const string StaticColorEvent = "STATIC_COLOR";
	private const string PulseColorEvent = "PULSE_COLOR";
	private const string AllyDeathEvent = "ALLY_DIED";
	private const string EnemyDeathEvent = "ENEMY_DIED";
	private static readonly string PulseHandlerCode; // 0x0
	private string _address; // 0x50
	private string _heartbeatEndpoint; // 0x58
	private HttpContent _heartbeatContent; // 0x60
	private string _gameEventEndpoint; // 0x68

	// Methods

	[AsyncStateMachineAttribute] // RVA: 0xB9F00 Offset: 0xB9300 VA: 0x1800B9F00
	// RVA: 0x21BCDA0 Offset: 0x21BC1A0 VA: 0x1821BCDA0 Slot: 13
	protected override ValueTask<bool> Initialize() { }

	[AsyncStateMachineAttribute] // RVA: 0xBB340 Offset: 0xBA740 VA: 0x1800BB340
	// RVA: 0x21BD2E0 Offset: 0x21BC6E0 VA: 0x1821BD2E0 Slot: 14
	protected override ValueTask Shutdown() { }

	[AsyncStateMachineAttribute] // RVA: 0xBB520 Offset: 0xBA920 VA: 0x1800BB520
	// RVA: 0x21BCFB0 Offset: 0x21BC3B0 VA: 0x1821BCFB0 Slot: 15
	protected override Task SendHeartbeat() { }

	[AsyncStateMachineAttribute] // RVA: 0xBB680 Offset: 0xBAA80 VA: 0x1800BB680
	// RVA: 0x21BD1D0 Offset: 0x21BC5D0 VA: 0x1821BD1D0 Slot: 16
	protected override Task SendStaticColor(Color color) { }

	[AsyncStateMachineAttribute] // RVA: 0xBB7A0 Offset: 0xBABA0 VA: 0x1800BB7A0
	// RVA: 0x21BD0A0 Offset: 0x21BC4A0 VA: 0x1821BD0A0 Slot: 17
	protected override Task SendPulseColor(Color color, float duration) { }

	[AsyncStateMachineAttribute] // RVA: 0xBB890 Offset: 0xBAC90 VA: 0x1800BB890
	// RVA: 0x21BCEB0 Offset: 0x21BC2B0 VA: 0x1821BCEB0 Slot: 18
	protected override Task SendEvent(RgbEventType type) { }

	// RVA: 0x21BD3E0 Offset: 0x21BC7E0 VA: 0x1821BD3E0
	private static string TryGetMomentsEvent(RgbEventType type) { }

	// RVA: 0x21BC8F0 Offset: 0x21BBCF0 VA: 0x1821BC8F0
	private ColorData GetColorData(Color color) { }

	// RVA: 0x21BCB40 Offset: 0x21BBF40 VA: 0x1821BCB40
	private string GetEndpoint(string path) { }

	// RVA: 0x21BCBA0 Offset: 0x21BBFA0 VA: 0x1821BCBA0
	private static string GetGameSenseAddress() { }

	// RVA: 0x21BCA00 Offset: 0x21BBE00 VA: 0x1821BCA00
	private static string GetCorePropsPath() { }

	// RVA: 0x21BB850 Offset: 0x21BAC50 VA: 0x1821BB850
	public void .ctor() { }

	// RVA: 0x21BD430 Offset: 0x21BC830 VA: 0x1821BD430
	private static void .cctor() { }

}

private struct SteelSeriesGameSenseService.<Initialize>d__10 : IAsyncStateMachine // TypeDefIndex: 7694
{	// Fields
	public int <>1__state; // 0x0
	public AsyncValueTaskMethodBuilder<bool> <>t__builder; // 0x8
	public SteelSeriesGameSenseService <>4__this; // 0x28
	private string <registerGameEventEndpoint>5__2; // 0x30
	private TaskAwaiter<HttpResponseMessage> <>u__1; // 0x38

	// Methods

	// RVA: 0x236D30 Offset: 0x236130 VA: 0x180236D30 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x236D40 Offset: 0x236140 VA: 0x180236D40 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct SteelSeriesGameSenseService.<Shutdown>d__11 : IAsyncStateMachine // TypeDefIndex: 7695
{	// Fields
	public int <>1__state; // 0x0
	public AsyncValueTaskMethodBuilder <>t__builder; // 0x8
	public SteelSeriesGameSenseService <>4__this; // 0x28
	private TaskAwaiter<HttpResponseMessage> <>u__1; // 0x30

	// Methods

	// RVA: 0x236DF0 Offset: 0x2361F0 VA: 0x180236DF0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x236E00 Offset: 0x236200 VA: 0x180236E00 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct SteelSeriesGameSenseService.<SendHeartbeat>d__12 : IAsyncStateMachine // TypeDefIndex: 7696
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public SteelSeriesGameSenseService <>4__this; // 0x20
	private TaskAwaiter<HttpResponseMessage> <>u__1; // 0x28

	// Methods

	// RVA: 0x236DC0 Offset: 0x2361C0 VA: 0x180236DC0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF2060 Offset: 0xF1460 VA: 0x1800F2060 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct SteelSeriesGameSenseService.<SendStaticColor>d__13 : IAsyncStateMachine // TypeDefIndex: 7697
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public SteelSeriesGameSenseService <>4__this; // 0x20
	public Color color; // 0x28
	private TaskAwaiter<HttpResponseMessage> <>u__1; // 0x38

	// Methods

	// RVA: 0x236DE0 Offset: 0x2361E0 VA: 0x180236DE0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF2060 Offset: 0xF1460 VA: 0x1800F2060 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct SteelSeriesGameSenseService.<SendPulseColor>d__14 : IAsyncStateMachine // TypeDefIndex: 7698
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public SteelSeriesGameSenseService <>4__this; // 0x20
	public float duration; // 0x28
	public Color color; // 0x2C
	private TaskAwaiter<HttpResponseMessage> <>u__1; // 0x40

	// Methods

	// RVA: 0x236DD0 Offset: 0x2361D0 VA: 0x180236DD0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF2060 Offset: 0xF1460 VA: 0x1800F2060 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct SteelSeriesGameSenseService.<SendEvent>d__15 : IAsyncStateMachine // TypeDefIndex: 7699
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public RgbEventType type; // 0x20
	public SteelSeriesGameSenseService <>4__this; // 0x28
	private TaskAwaiter<HttpResponseMessage> <>u__1; // 0x30

	// Methods

	// RVA: 0x236DA0 Offset: 0x2361A0 VA: 0x180236DA0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF2060 Offset: 0xF1460 VA: 0x1800F2060 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

