public class LoadingScreen : SingletonComponent<LoadingScreen> // TypeDefIndex: 11117
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static bool <WantsSkip>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static string <Text>k__BackingField; // 0x8
	public CanvasRenderer panel; // 0x18
	public TextMeshProUGUI title; // 0x20
	public TextMeshProUGUI subtitle; // 0x28
	public Button skipButton; // 0x30
	public Button cancelButton; // 0x38
	public GameObject performanceWarning; // 0x40
	public AudioSource music; // 0x48
	public RectTransform serverInfo; // 0x50
	public RustText serverName; // 0x58
	public RustText serverPlayers; // 0x60
	public RustLayout serverModeSection; // 0x68
	public RustText serverMode; // 0x70
	public RustText serverMap; // 0x78
	public RustLayout serverTagsSection; // 0x80
	public ServerBrowserTagList serverTags; // 0x88
	public RawImage backgroundImage; // 0x90
	public Texture2D defaultBackground; // 0x98
	public GameObject pingWarning; // 0xA0
	public RustText pingWarningText; // 0xA8
	[TooltipAttribute] // RVA: 0x976D0 Offset: 0x96AD0 VA: 0x1800976D0
	public int minPingDiffToShowWarning; // 0xB0
	[TooltipAttribute] // RVA: 0x977A0 Offset: 0x96BA0 VA: 0x1800977A0
	public float pingDiffFactorToShowWarning; // 0xB4
	[TooltipAttribute] // RVA: 0x97880 Offset: 0x96C80 VA: 0x180097880
	public int requiredPingSampleCount; // 0xB8
	private string _backgroundImagePath; // 0xC0
	private Texture2D _backgroundImage; // 0xC8
	private string _pingWarningTextTemplate; // 0xD0
	private int _pingSampleCount; // 0xD8
	private int _minimumPingSample; // 0xDC

	// Properties
	public static bool isOpen { get; }
	public static bool WantsSkip { get; set; }
	public static string Text { get; set; }

	// Methods

	// RVA: 0x4F7480 Offset: 0x4F6880 VA: 0x1804F7480
	public static bool get_isOpen() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4F7440 Offset: 0x4F6840 VA: 0x1804F7440
	public static bool get_WantsSkip() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4F7630 Offset: 0x4F6A30 VA: 0x1804F7630
	private static void set_WantsSkip(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4F75E0 Offset: 0x4F69E0 VA: 0x1804F75E0
	private static void set_Text(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4F7400 Offset: 0x4F6800 VA: 0x1804F7400
	public static string get_Text() { }

	// RVA: 0x4F4F70 Offset: 0x4F4370 VA: 0x1804F4F70 Slot: 6
	protected override void Awake() { }

	// RVA: 0x4F5F10 Offset: 0x4F5310 VA: 0x1804F5F10 Slot: 7
	protected override void OnDestroy() { }

	// RVA: 0x4F6000 Offset: 0x4F5400 VA: 0x1804F6000
	public void OnDisable() { }

	// RVA: 0x4F62F0 Offset: 0x4F56F0 VA: 0x1804F62F0
	public static void Show(bool hideCancel = False) { }

	// RVA: 0x4F59A0 Offset: 0x4F4DA0 VA: 0x1804F59A0
	public static void Hide() { }

	// RVA: 0x4F6010 Offset: 0x4F5410 VA: 0x1804F6010
	public static void ShowPerformanceWarning() { }

	// RVA: 0x4F5620 Offset: 0x4F4A20 VA: 0x1804F5620
	public static void HidePerformanceWarning() { }

	// RVA: 0x4F6160 Offset: 0x4F5560 VA: 0x1804F6160
	public static void ShowSkip() { }

	// RVA: 0x4F5810 Offset: 0x4F4C10 VA: 0x1804F5810
	public static void HideSkip() { }

	// RVA: 0x4F6F60 Offset: 0x4F6360 VA: 0x1804F6F60
	public static void Update(string strType) { }

	// RVA: 0x4F71C0 Offset: 0x4F65C0 VA: 0x1804F71C0
	public static void Update(string strType, string strSubtitle) { }

	// RVA: 0x4F6890 Offset: 0x4F5C90 VA: 0x1804F6890
	public void UpdateFromServer(string strTitle, string strSubtitle) { }

	// RVA: 0x4F5220 Offset: 0x4F4620 VA: 0x1804F5220
	public void CancelLoading() { }

	// RVA: 0x4F6750 Offset: 0x4F5B50 VA: 0x1804F6750
	public void SkipLoading() { }

	// RVA: 0x4F5770 Offset: 0x4F4B70 VA: 0x1804F5770
	private void HidePingWarning() { }

	// RVA: 0x4F6950 Offset: 0x4F5D50 VA: 0x1804F6950
	private void UpdatePingWarning() { }

	// RVA: 0x4F6C90 Offset: 0x4F6090 VA: 0x1804F6C90
	public void UpdateServerInfo(Nullable<ServerInfo> server, Dictionary<string, string> serverRules) { }

	// RVA: 0x4F5D90 Offset: 0x4F5190 VA: 0x1804F5D90
	private void LoadBackgroundImage() { }

	// RVA: 0x4F5560 Offset: 0x4F4960 VA: 0x1804F5560
	private void FreeBackgroundImage() { }

	// RVA: 0x4F52D0 Offset: 0x4F46D0 VA: 0x1804F52D0
	private void ChooseBackgroundImage() { }

	// RVA: 0x4F7380 Offset: 0x4F6780 VA: 0x1804F7380
	public void .ctor() { }

	[AsyncStateMachineAttribute] // RVA: 0x97FD0 Offset: 0x973D0 VA: 0x180097FD0
	[CompilerGeneratedAttribute] // RVA: 0x97FD0 Offset: 0x973D0 VA: 0x180097FD0
	// RVA: 0x4F6790 Offset: 0x4F5B90 VA: 0x1804F6790
	private void <ChooseBackgroundImage>g__PreloadBackgroundImage|56_0(string url) { }

}

private struct LoadingScreen.<<ChooseBackgroundImage>g__PreloadBackgroundImage|56_0>d : IAsyncStateMachine // TypeDefIndex: 11118
{	// Fields
	public int <>1__state; // 0x0
	public AsyncVoidMethodBuilder <>t__builder; // 0x8
	public string url; // 0x28
	public LoadingScreen <>4__this; // 0x30
	private TaskAwaiter<string> <>u__1; // 0x38

	// Methods

	// RVA: 0xF26F0 Offset: 0xF1AF0 VA: 0x1800F26F0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF1420 Offset: 0xF0820 VA: 0x1800F1420 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

