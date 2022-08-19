public abstract class RestRgbService : IRgbService // TypeDefIndex: 7678
{	// Fields
	private readonly SemaphoreSlim _sema; // 0x10
	private readonly Stopwatch _heartbeatTimer; // 0x18
	private readonly Stopwatch _timeSinceFailure; // 0x20
	private bool _failed; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <IsConnected>k__BackingField; // 0x29
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Vector3 <ColorCorrection>k__BackingField; // 0x2C
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private HttpClient <Client>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private TimeSpan <HeartbeatInterval>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private TimeSpan <ReinitializeDelay>k__BackingField; // 0x48

	// Properties
	public bool IsConnected { get; set; }
	public Vector3 ColorCorrection { get; set; }
	protected HttpClient Client { get; set; }
	protected TimeSpan HeartbeatInterval { get; set; }
	protected TimeSpan ReinitializeDelay { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x754350 Offset: 0x753750 VA: 0x180754350 Slot: 4
	public bool get_IsConnected() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x111F140 Offset: 0x111E540 VA: 0x18111F140
	protected void set_IsConnected(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x12C77F0 Offset: 0x12C6BF0 VA: 0x1812C77F0 Slot: 5
	public Vector3 get_ColorCorrection() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x21BB9F0 Offset: 0x21BADF0 VA: 0x1821BB9F0 Slot: 6
	public void set_ColorCorrection(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5DCC00 Offset: 0x5DC000 VA: 0x1805DCC00
	protected HttpClient get_Client() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5089D0 Offset: 0x507DD0 VA: 0x1805089D0
	protected void set_Client(HttpClient value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B9440 Offset: 0x4B8840 VA: 0x1804B9440
	protected TimeSpan get_HeartbeatInterval() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x21BBA00 Offset: 0x21BAE00 VA: 0x1821BBA00
	protected void set_HeartbeatInterval(TimeSpan value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5DCCA0 Offset: 0x5DC0A0 VA: 0x1805DCCA0
	protected TimeSpan get_ReinitializeDelay() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xEE12D0 Offset: 0xEE06D0 VA: 0x180EE12D0
	protected void set_ReinitializeDelay(TimeSpan value) { }

	// RVA: 0x21BB850 Offset: 0x21BAC50 VA: 0x1821BB850
	protected void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract ValueTask<bool> Initialize();

	// RVA: -1 Offset: -1 Slot: 14
	protected abstract ValueTask Shutdown();

	// RVA: -1 Offset: -1 Slot: 15
	protected abstract Task SendHeartbeat();

	// RVA: -1 Offset: -1 Slot: 16
	protected abstract Task SendStaticColor(Color color);

	// RVA: -1 Offset: -1 Slot: 17
	protected abstract Task SendPulseColor(Color color, float duration);

	// RVA: -1 Offset: -1 Slot: 18
	protected abstract Task SendEvent(RgbEventType type);

	[AsyncStateMachineAttribute] // RVA: 0xB6A40 Offset: 0xB5E40 VA: 0x1800B6A40
	// RVA: 0x21BB370 Offset: 0x21BA770 VA: 0x1821BB370 Slot: 7
	public ValueTask Start() { }

	[AsyncStateMachineAttribute] // RVA: 0xB6B80 Offset: 0xB5F80 VA: 0x1800B6B80
	// RVA: 0x21BB650 Offset: 0x21BAA50 VA: 0x1821BB650 Slot: 8
	public ValueTask Stop() { }

	[AsyncStateMachineAttribute] // RVA: 0xB6D80 Offset: 0xB6180 VA: 0x1800B6D80
	// RVA: 0x21BB750 Offset: 0x21BAB50 VA: 0x1821BB750 Slot: 9
	public ValueTask Update() { }

	[AsyncStateMachineAttribute] // RVA: 0xB6E70 Offset: 0xB6270 VA: 0x1800B6E70
	// RVA: 0x21BB270 Offset: 0x21BA670 VA: 0x1821BB270
	private void SendHeartbeatAndWait() { }

	// RVA: 0x21BB560 Offset: 0x21BA960 VA: 0x1821BB560 Slot: 10
	public void StaticColor(Color color) { }

	[AsyncStateMachineAttribute] // RVA: 0xB6F60 Offset: 0xB6360 VA: 0x1800B6F60
	// RVA: 0x21BB470 Offset: 0x21BA870 VA: 0x1821BB470
	private void StaticColorImpl(Color color) { }

	// RVA: 0x21BB160 Offset: 0x21BA560 VA: 0x1821BB160 Slot: 11
	public void PulseColor(Color color, float duration) { }

	[AsyncStateMachineAttribute] // RVA: 0xB70C0 Offset: 0xB64C0 VA: 0x1800B70C0
	// RVA: 0x21BB060 Offset: 0x21BA460 VA: 0x1821BB060
	private void PulseColorImpl(Color color, float duration) { }

	// RVA: 0x21BAF70 Offset: 0x21BA370 VA: 0x1821BAF70 Slot: 12
	public void Event(RgbEventType type) { }

	[AsyncStateMachineAttribute] // RVA: 0xB7260 Offset: 0xB6660 VA: 0x1800B7260
	// RVA: 0x21BAE80 Offset: 0x21BA280 VA: 0x1821BAE80
	private void EventImpl(RgbEventType type) { }

	// RVA: 0x21BB340 Offset: 0x21BA740 VA: 0x1821BB340
	private void ShutdownFromFailure() { }

	[AsyncStateMachineAttribute] // RVA: 0xB8630 Offset: 0xB7A30 VA: 0x1800B8630
	// RVA: -1 Offset: -1
	protected Task<HttpResponseMessage> SendPost<T>(string endpoint, T payload) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE833D0 Offset: 0xE827D0 VA: 0x180E833D0
	|-RestRgbService.SendPost<GameEvent<ColorEventData>>
	|
	|-RVA: 0xE83280 Offset: 0xE82680 VA: 0x180E83280
	|-RestRgbService.SendPost<GameEvent<EmptyEventData>>
	|
	|-RVA: 0xE83520 Offset: 0xE82920 VA: 0x180E83520
	|-RestRgbService.SendPost<GameMetadata>
	|
	|-RVA: 0xE83670 Offset: 0xE82A70 VA: 0x180E83670
	|-RestRgbService.SendPost<LoadGoLispHandlers>
	|
	|-RVA: 0xE837C0 Offset: 0xE82BC0 VA: 0x180E837C0
	|-RestRgbService.SendPost<RegisterGameEvent>
	|
	|-RVA: 0xE83910 Offset: 0xE82D10 VA: 0x180E83910
	|-RestRgbService.SendPost<RegisterTimelineEvents>
	|
	|-RVA: 0xE83A60 Offset: 0xE82E60 VA: 0x180E83A60
	|-RestRgbService.SendPost<RemoveGame>
	*/

	// RVA: -1 Offset: -1
	protected static HttpContent BuildContent<T>(T parameters) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE82C60 Offset: 0xE82060 VA: 0x180E82C60
	|-RestRgbService.BuildContent<GameEvent<ColorEventData>>
	|
	|-RVA: 0xE82B80 Offset: 0xE81F80 VA: 0x180E82B80
	|-RestRgbService.BuildContent<GameEvent<EmptyEventData>>
	|
	|-RVA: 0xE82D40 Offset: 0xE82140 VA: 0x180E82D40
	|-RestRgbService.BuildContent<GameMetadata>
	|
	|-RVA: 0xE82E20 Offset: 0xE82220 VA: 0x180E82E20
	|-RestRgbService.BuildContent<Heartbeat>
	|
	|-RVA: 0xE82F00 Offset: 0xE82300 VA: 0x180E82F00
	|-RestRgbService.BuildContent<LoadGoLispHandlers>
	|
	|-RVA: 0xE82FE0 Offset: 0xE823E0 VA: 0x180E82FE0
	|-RestRgbService.BuildContent<RegisterGameEvent>
	|
	|-RVA: 0xE830C0 Offset: 0xE824C0 VA: 0x180E830C0
	|-RestRgbService.BuildContent<RegisterTimelineEvents>
	|
	|-RVA: 0xE831A0 Offset: 0xE825A0 VA: 0x180E831A0
	|-RestRgbService.BuildContent<RemoveGame>
	*/

}

private struct RestRgbService.<Start>d__31 : IAsyncStateMachine // TypeDefIndex: 7679
{	// Fields
	public int <>1__state; // 0x0
	public AsyncValueTaskMethodBuilder <>t__builder; // 0x8
	public RestRgbService <>4__this; // 0x28
	private TaskAwaiter <>u__1; // 0x30
	private ValueTaskAwaiter<bool> <>u__2; // 0x38

	// Methods

	// RVA: 0x236E20 Offset: 0x236220 VA: 0x180236E20 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x236E00 Offset: 0x236200 VA: 0x180236E00 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct RestRgbService.<Stop>d__32 : IAsyncStateMachine // TypeDefIndex: 7680
{	// Fields
	public int <>1__state; // 0x0
	public AsyncValueTaskMethodBuilder <>t__builder; // 0x8
	public RestRgbService <>4__this; // 0x28
	private TaskAwaiter <>u__1; // 0x30
	private ValueTaskAwaiter <>u__2; // 0x38

	// Methods

	// RVA: 0x236E50 Offset: 0x236250 VA: 0x180236E50 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x236E00 Offset: 0x236200 VA: 0x180236E00 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct RestRgbService.<Update>d__33 : IAsyncStateMachine // TypeDefIndex: 7681
{	// Fields
	public int <>1__state; // 0x0
	public AsyncValueTaskMethodBuilder <>t__builder; // 0x8
	public RestRgbService <>4__this; // 0x28
	private ValueTaskAwaiter <>u__1; // 0x30

	// Methods

	// RVA: 0x236E70 Offset: 0x236270 VA: 0x180236E70 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x236E00 Offset: 0x236200 VA: 0x180236E00 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct RestRgbService.<SendHeartbeatAndWait>d__34 : IAsyncStateMachine // TypeDefIndex: 7682
{	// Fields
	public int <>1__state; // 0x0
	public AsyncVoidMethodBuilder <>t__builder; // 0x8
	public RestRgbService <>4__this; // 0x28
	private TaskAwaiter<bool> <>u__1; // 0x30
	private TaskAwaiter <>u__2; // 0x38

	// Methods

	// RVA: 0x236DB0 Offset: 0x2361B0 VA: 0x180236DB0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF1420 Offset: 0xF0820 VA: 0x1800F1420 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct RestRgbService.<StaticColorImpl>d__36 : IAsyncStateMachine // TypeDefIndex: 7683
{	// Fields
	public int <>1__state; // 0x0
	public AsyncVoidMethodBuilder <>t__builder; // 0x8
	public RestRgbService <>4__this; // 0x28
	public Color color; // 0x30
	private TaskAwaiter <>u__1; // 0x40

	// Methods

	// RVA: 0x236E30 Offset: 0x236230 VA: 0x180236E30 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF1420 Offset: 0xF0820 VA: 0x1800F1420 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct RestRgbService.<PulseColorImpl>d__38 : IAsyncStateMachine // TypeDefIndex: 7684
{	// Fields
	public int <>1__state; // 0x0
	public AsyncVoidMethodBuilder <>t__builder; // 0x8
	public RestRgbService <>4__this; // 0x28
	public Color color; // 0x30
	public float duration; // 0x40
	private TaskAwaiter <>u__1; // 0x48

	// Methods

	// RVA: 0x236D90 Offset: 0x236190 VA: 0x180236D90 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF1420 Offset: 0xF0820 VA: 0x1800F1420 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct RestRgbService.<EventImpl>d__40 : IAsyncStateMachine // TypeDefIndex: 7685
{	// Fields
	public int <>1__state; // 0x0
	public AsyncVoidMethodBuilder <>t__builder; // 0x8
	public RestRgbService <>4__this; // 0x28
	public RgbEventType type; // 0x30
	private TaskAwaiter <>u__1; // 0x38

	// Methods

	// RVA: 0x236D20 Offset: 0x236120 VA: 0x180236D20 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF1420 Offset: 0xF0820 VA: 0x1800F1420 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct RestRgbService.<SendPost>d__42<T> : IAsyncStateMachine // TypeDefIndex: 7686
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<HttpResponseMessage> <>t__builder; // 0x0
	public T payload; // 0x0
	public RestRgbService <>4__this; // 0x0
	public string endpoint; // 0x0
	private TaskAwaiter<HttpResponseMessage> <>u__1; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x120530 Offset: 0x11F930 VA: 0x180120530
	|-RestRgbService.<SendPost>d__42<GameEvent<ColorEventData>>.MoveNext
	|
	|-RVA: 0x120540 Offset: 0x11F940 VA: 0x180120540
	|-RestRgbService.<SendPost>d__42<GameEvent<EmptyEventData>>.MoveNext
	|
	|-RVA: 0x120520 Offset: 0x11F920 VA: 0x180120520
	|-RestRgbService.<SendPost>d__42<GameMetadata>.MoveNext
	|
	|-RVA: 0x120500 Offset: 0x11F900 VA: 0x180120500
	|-RestRgbService.<SendPost>d__42<LoadGoLispHandlers>.MoveNext
	|
	|-RVA: 0x120510 Offset: 0x11F910 VA: 0x180120510
	|-RestRgbService.<SendPost>d__42<RegisterGameEvent>.MoveNext
	|
	|-RVA: 0x1204F0 Offset: 0x11F8F0 VA: 0x1801204F0
	|-RestRgbService.<SendPost>d__42<RegisterTimelineEvents>.MoveNext
	|
	|-RVA: 0x120550 Offset: 0x11F950 VA: 0x180120550
	|-RestRgbService.<SendPost>d__42<RemoveGame>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x120740 Offset: 0x11FB40 VA: 0x180120740
	|-RestRgbService.<SendPost>d__42<GameEvent<ColorEventData>>.SetStateMachine
	|
	|-RVA: 0x120650 Offset: 0x11FA50 VA: 0x180120650
	|-RestRgbService.<SendPost>d__42<GameEvent<EmptyEventData>>.SetStateMachine
	|
	|-RVA: 0x1205B0 Offset: 0x11F9B0 VA: 0x1801205B0
	|-RestRgbService.<SendPost>d__42<GameMetadata>.SetStateMachine
	|
	|-RVA: 0x120600 Offset: 0x11FA00 VA: 0x180120600
	|-RestRgbService.<SendPost>d__42<LoadGoLispHandlers>.SetStateMachine
	|
	|-RVA: 0x120560 Offset: 0x11F960 VA: 0x180120560
	|-RestRgbService.<SendPost>d__42<RegisterGameEvent>.SetStateMachine
	|
	|-RVA: 0x1206A0 Offset: 0x11FAA0 VA: 0x1801206A0
	|-RestRgbService.<SendPost>d__42<RegisterTimelineEvents>.SetStateMachine
	|
	|-RVA: 0x1206F0 Offset: 0x11FAF0 VA: 0x1801206F0
	|-RestRgbService.<SendPost>d__42<RemoveGame>.SetStateMachine
	*/

}

