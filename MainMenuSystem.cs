public class MainMenuSystem : SingletonComponent<MainMenuSystem> // TypeDefIndex: 11119
{	public static bool isOpen; // 0x0
	public static Action OnOpenStateChanged; // 0x8
	public RustButton SessionButton; // 0x18
	public GameObject SessionPanel; // 0x20
	public GameObject NewsStoriesAlert; // 0x28
	public GameObject ItemStoreAlert; // 0x30
	public GameObject CompanionAlert; // 0x38
	public GameObject DemoBrowser; // 0x40
	public GameObject DemoBrowserButton; // 0x48
	public GameObject SuicideButton; // 0x50
	public GameObject EndDemoButton; // 0x58
	public GameObject ReflexModeOption; // 0x60
	public GameObject ReflexLatencyMarkerOption; // 0x68

	private bool shouldShowSessionButton { get; }


	protected override void Awake() { }

	protected override void OnDestroy() { }

	private void Update() { }

	private bool get_shouldShowSessionButton() { }

	private void OnEscape() { }

	public void HideClicked() { }

	public static void Hide() { }

	public static void Show() { }

	private void ShowDemoBrowserButton() { }

	private void OnEnabledState(bool b) { }

	private static void OnConnected() { }

	private static void OnDisconnected() { }

	public void OnClickedQuitDemo() { }

	public void .ctor() { }

	private static void .cctor() { }

}

private sealed class MainMenuSystem.<>c // TypeDefIndex: 11120
{	public static readonly MainMenuSystem.<>c <>9; // 0x0
	public static Func<IPlayerItemDefinition, bool> <>9__15_0; // 0x8
	public static Func<IPlayerItemDefinition, int> <>9__15_1; // 0x10


	private static void .cctor() { }

	public void .ctor() { }

	internal bool <Update>b__15_0(IPlayerItemDefinition x) { }

	internal int <Update>b__15_1(IPlayerItemDefinition x) { }

}

