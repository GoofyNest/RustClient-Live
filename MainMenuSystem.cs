public class MainMenuSystem : SingletonComponent<MainMenuSystem> // TypeDefIndex: 12910
{
	public static bool isOpen;
	public static Action OnOpenStateChanged;
	public RustButton SessionButton;
	public GameObject SessionPanel;
	public GameObject NewsStoriesAlert;
	public GameObject ItemStoreAlert;
	public GameObject CompanionAlert;
	public GameObject DemoBrowser;
	public GameObject DemoBrowserButton;
	public GameObject SuicideButton;
	public GameObject EndDemoButton;
	public GameObject ReflexModeOption;
	public GameObject ReflexLatencyMarkerOption;

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

private sealed class MainMenuSystem.<>c // TypeDefIndex: 12911
{
	public static readonly MainMenuSystem.<>c <>9;
	public static Func<IPlayerItemDefinition, bool> <>9__15_0;
	public static Func<IPlayerItemDefinition, int> <>9__15_1;


	private static void .cctor() { }

	public void .ctor() { }

	internal bool <Update>

	internal int <Update>

}

