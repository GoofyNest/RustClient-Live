public class LoadingScreen : SingletonComponent<LoadingScreen> // TypeDefIndex: 11142
{
	[CompilerGeneratedAttribute] 
	private static bool <WantsSkip>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private static string <Text>k__BackingField; 
	public CanvasRenderer panel; 
	public TextMeshProUGUI title; 
	public TextMeshProUGUI subtitle; 
	public Button skipButton; 
	public Button cancelButton; 
	public GameObject performanceWarning; 
	public AudioSource music; 
	public RectTransform serverInfo; 
	public RustText serverName; 
	public RustText serverPlayers; 
	public RustLayout serverModeSection; 
	public RustText serverMode; 
	public RustText serverMap; 
	public RustLayout serverTagsSection; 
	public ServerBrowserTagList serverTags; 
	public RectTransform demoInfo; 
	public RustText demoName; 
	public RustText demoLength; 
	public RustText demoDate; 
	public RustText demoMap; 
	public RawImage backgroundImage; 
	public Texture2D defaultBackground; 
	public GameObject pingWarning; 
	public RustText pingWarningText; 
	[TooltipAttribute] 
	public int minPingDiffToShowWarning; 
	[TooltipAttribute] 
	public float pingDiffFactorToShowWarning; 
	[TooltipAttribute] 
	public int requiredPingSampleCount; 
	private string _backgroundImagePath; 
	private Texture2D _backgroundImage; 
	private string _pingWarningTextTemplate; 
	private int _pingSampleCount; 
	private int _minimumPingSample; 

	public static bool isOpen { get; }
	public static bool WantsSkip { get; set; }
	public static string Text { get; set; }


	public static bool get_isOpen() { }

	[CompilerGeneratedAttribute] 
	public static bool get_WantsSkip() { }

	[CompilerGeneratedAttribute] 
	private static void set_WantsSkip(bool value) { }

	[CompilerGeneratedAttribute] 
	private static void set_Text(string value) { }

	[CompilerGeneratedAttribute] 
	public static string get_Text() { }

	protected override void Awake() { }

	protected override void OnDestroy() { }

	public void OnDisable() { }

	public static void Show(bool hideCancel = False) { }

	public static void Hide() { }

	public static void ShowPerformanceWarning() { }

	public static void HidePerformanceWarning() { }

	public static void ShowSkip() { }

	public static void HideSkip() { }

	public static void Update(string strType) { }

	public static void Update(string strType, string strSubtitle) { }

	public void UpdateFromServer(string strTitle, string strSubtitle) { }

	public void CancelLoading() { }

	public void SkipLoading() { }

	private void HidePingWarning() { }

	private void UpdatePingWarning() { }

	public void UpdateServerInfo(Nullable<ServerInfo> server, Dictionary<string, string> serverRules) { }

	public void UpdateDemoInfo(Reader demoReader) { }

	private void LoadBackgroundImage() { }

	private void FreeBackgroundImage() { }

	private void ChooseBackgroundImage() { }

	public void .ctor() { }

	[AsyncStateMachineAttribute] 
	[CompilerGeneratedAttribute] 
	private void <ChooseBackgroundImage>g__PreloadBackgroundImage|62_0(string url) { }

}

private struct LoadingScreen.<<ChooseBackgroundImage>g__PreloadBackgroundImage|62_0>d : IAsyncStateMachine // TypeDefIndex: 11143
{
	public int <>1__state; 
	public AsyncVoidMethodBuilder <>t__builder; 
	public string url; 
	public LoadingScreen <>4__this; 
	private TaskAwaiter<string> <>u__1; 


	private void MoveNext() { }

	[DebuggerHiddenAttribute] 
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

