public class CompanionSetupScreen : SingletonComponent<CompanionSetupScreen> // TypeDefIndex: 11084
{	// Fields
	public const string PairedKey = "companionPaired";
	public GameObject instructionsBody; // 0x18
	public GameObject detailsPanel; // 0x20
	public GameObject loadingMessage; // 0x28
	public GameObject errorMessage; // 0x30
	public GameObject notSupportedMessage; // 0x38
	public GameObject disabledMessage; // 0x40
	public GameObject enabledMessage; // 0x48
	public GameObject refreshButton; // 0x50
	public GameObject enableButton; // 0x58
	public GameObject disableButton; // 0x60
	public GameObject pairButton; // 0x68
	public RustText serverName; // 0x70
	public RustButton helpButton; // 0x78
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private CompanionSetupScreen.ScreenState <State>k__BackingField; // 0x80
	private bool _isLoading; // 0x84
	private Nullable<bool> _enabled; // 0x85
	private bool _hidePair; // 0x87

	// Properties
	public CompanionSetupScreen.ScreenState State { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x59C1A0 Offset: 0x59B5A0 VA: 0x18059C1A0
	public CompanionSetupScreen.ScreenState get_State() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x59C1B0 Offset: 0x59B5B0 VA: 0x18059C1B0
	private void set_State(CompanionSetupScreen.ScreenState value) { }

	// RVA: 0x59B9F0 Offset: 0x59ADF0 VA: 0x18059B9F0
	public void OnEnable() { }

	// RVA: 0x59BC80 Offset: 0x59B080 VA: 0x18059BC80
	public void Refresh() { }

	[AsyncStateMachineAttribute] // RVA: 0x94EA0 Offset: 0x942A0 VA: 0x180094EA0
	// RVA: 0x59BBB0 Offset: 0x59AFB0 VA: 0x18059BBB0
	public void RefreshImpl() { }

	[AsyncStateMachineAttribute] // RVA: 0x95010 Offset: 0x94410 VA: 0x180095010
	// RVA: 0x59B7D0 Offset: 0x59ABD0 VA: 0x18059B7D0
	public void Enable() { }

	[AsyncStateMachineAttribute] // RVA: 0x951D0 Offset: 0x945D0 VA: 0x1800951D0
	// RVA: 0x59B700 Offset: 0x59AB00 VA: 0x18059B700
	public void Disable() { }

	// RVA: 0x59BA40 Offset: 0x59AE40 VA: 0x18059BA40
	public void Pair() { }

	// RVA: 0x59C110 Offset: 0x59B510 VA: 0x18059C110
	private void ResetPair() { }

	// RVA: 0x59BA00 Offset: 0x59AE00 VA: 0x18059BA00
	public void OpenVideo() { }

	// RVA: 0x59B8A0 Offset: 0x59ACA0 VA: 0x18059B8A0
	public void HelpPressed() { }

	// RVA: 0x59B9F0 Offset: 0x59ADF0 VA: 0x18059B9F0
	public void HelpReleased() { }

	// RVA: 0x59C130 Offset: 0x59B530 VA: 0x18059C130
	private void UpdateUI() { }

	// RVA: 0x59B4C0 Offset: 0x59A8C0 VA: 0x18059B4C0
	public void ChangeState(CompanionSetupScreen.ScreenState state) { }

	// RVA: 0x59C140 Offset: 0x59B540 VA: 0x18059C140
	public void .ctor() { }

}

public enum CompanionSetupScreen.ScreenState // TypeDefIndex: 11085
{	// Fields
	public int value__; // 0x0
	public const CompanionSetupScreen.ScreenState Loading = 0;
	public const CompanionSetupScreen.ScreenState Error = 1;
	public const CompanionSetupScreen.ScreenState NoServer = 2;
	public const CompanionSetupScreen.ScreenState NotSupported = 3;
	public const CompanionSetupScreen.ScreenState NotInstalled = 4;
	public const CompanionSetupScreen.ScreenState Disabled = 5;
	public const CompanionSetupScreen.ScreenState Enabled = 6;
	public const CompanionSetupScreen.ScreenState ShowHelp = 7;

}

private struct CompanionSetupScreen.<RefreshImpl>d__24 : IAsyncStateMachine // TypeDefIndex: 11086
{	// Fields
	public int <>1__state; // 0x0
	public AsyncVoidMethodBuilder <>t__builder; // 0x8
	public CompanionSetupScreen <>4__this; // 0x28
	private TaskAwaiter<CompanionSubscription.Status> <>u__1; // 0x30

	// Methods

	// RVA: 0xF2F00 Offset: 0xF2300 VA: 0x1800F2F00 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF1420 Offset: 0xF0820 VA: 0x1800F1420 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct CompanionSetupScreen.<Enable>d__25 : IAsyncStateMachine // TypeDefIndex: 11087
{	// Fields
	public int <>1__state; // 0x0
	public AsyncVoidMethodBuilder <>t__builder; // 0x8
	public CompanionSetupScreen <>4__this; // 0x28
	private TaskAwaiter <>u__1; // 0x30

	// Methods

	// RVA: 0xF2EF0 Offset: 0xF22F0 VA: 0x1800F2EF0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF1420 Offset: 0xF0820 VA: 0x1800F1420 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct CompanionSetupScreen.<Disable>d__26 : IAsyncStateMachine // TypeDefIndex: 11088
{	// Fields
	public int <>1__state; // 0x0
	public AsyncVoidMethodBuilder <>t__builder; // 0x8
	public CompanionSetupScreen <>4__this; // 0x28
	private TaskAwaiter <>u__1; // 0x30

	// Methods

	// RVA: 0xF2EE0 Offset: 0xF22E0 VA: 0x1800F2EE0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF1420 Offset: 0xF0820 VA: 0x1800F1420 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

public static class CompanionSubscription // TypeDefIndex: 11089
{	// Fields
	private const string ApiEndpoint = "https://companion-rust.facepunch.com/api/subscriptions";
	private const string CheckApi = "https://companion-rust.facepunch.com/api/subscriptions/check";
	private const string AddApi = "https://companion-rust.facepunch.com/api/subscriptions/add";
	private const string RemoveApi = "https://companion-rust.facepunch.com/api/subscriptions/remove";
	private static readonly HttpClient Http; // 0x2B0AA90

	// Methods

	[AsyncStateMachineAttribute] // RVA: 0x955A0 Offset: 0x949A0 VA: 0x1800955A0
	// RVA: 0x59C290 Offset: 0x59B690 VA: 0x18059C290
	public static Task<CompanionSubscription.Status> CheckStatus() { }

	[AsyncStateMachineAttribute] // RVA: 0x95660 Offset: 0x94A60 VA: 0x180095660
	// RVA: 0x59C1C0 Offset: 0x59B5C0 VA: 0x18059C1C0
	public static Task Add() { }

	[AsyncStateMachineAttribute] // RVA: 0x957E0 Offset: 0x94BE0 VA: 0x1800957E0
	// RVA: 0x59C560 Offset: 0x59B960 VA: 0x18059C560
	public static Task Remove() { }

	// RVA: 0x59C370 Offset: 0x59B770 VA: 0x18059C370
	private static StringContent GenerateRequest(IAuthTicket authTicket) { }

	// RVA: 0x59C630 Offset: 0x59BA30 VA: 0x18059C630
	private static void .cctor() { }

}

private class CompanionSubscription.Request // TypeDefIndex: 11090
{	// Fields
	public string SteamTicket; // 0x10
	public string ServerId; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

public class CompanionSubscription.Status // TypeDefIndex: 11091
{	// Fields
	public bool IsInstalled; // 0x10
	public bool IsSubscribed; // 0x11

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

private struct CompanionSubscription.<CheckStatus>d__5 : IAsyncStateMachine // TypeDefIndex: 11092
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<CompanionSubscription.Status> <>t__builder; // 0x8
	private IAuthTicket <ticket>5__2; // 0x20
	private TaskAwaiter<IAuthTicket> <>u__1; // 0x28
	private TaskAwaiter<HttpResponseMessage> <>u__2; // 0x30
	private TaskAwaiter<string> <>u__3; // 0x38

	// Methods

	// RVA: 0xF46A0 Offset: 0xF3AA0 VA: 0x1800F46A0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF46B0 Offset: 0xF3AB0 VA: 0x1800F46B0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct CompanionSubscription.<Add>d__6 : IAsyncStateMachine // TypeDefIndex: 11093
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	private IAuthTicket <ticket>5__2; // 0x20
	private TaskAwaiter<IAuthTicket> <>u__1; // 0x28
	private TaskAwaiter<HttpResponseMessage> <>u__2; // 0x30

	// Methods

	// RVA: 0xF4690 Offset: 0xF3A90 VA: 0x1800F4690 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF2060 Offset: 0xF1460 VA: 0x1800F2060 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct CompanionSubscription.<Remove>d__7 : IAsyncStateMachine // TypeDefIndex: 11094
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	private IAuthTicket <ticket>5__2; // 0x20
	private TaskAwaiter<IAuthTicket> <>u__1; // 0x28
	private TaskAwaiter<HttpResponseMessage> <>u__2; // 0x30

	// Methods

	// RVA: 0xF4700 Offset: 0xF3B00 VA: 0x1800F4700 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF2060 Offset: 0xF1460 VA: 0x1800F2060 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

