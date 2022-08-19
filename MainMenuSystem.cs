public class MainMenuSystem : SingletonComponent<MainMenuSystem> // TypeDefIndex: 11119
{	// Fields
	public static bool isOpen; // 0x0
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

	// Properties
	private bool shouldShowSessionButton { get; }

	// Methods

	// RVA: 0x5784F0 Offset: 0x5778F0 VA: 0x1805784F0 Slot: 6
	protected override void Awake() { }

	// RVA: 0x578A40 Offset: 0x577E40 VA: 0x180578A40 Slot: 7
	protected override void OnDestroy() { }

	// RVA: 0x579350 Offset: 0x578750 VA: 0x180579350
	private void Update() { }

	// RVA: 0x579B40 Offset: 0x578F40 VA: 0x180579B40
	private bool get_shouldShowSessionButton() { }

	// RVA: 0x578D50 Offset: 0x578150 VA: 0x180578D50
	private void OnEscape() { }

	// RVA: 0x5786D0 Offset: 0x577AD0 VA: 0x1805786D0
	public void HideClicked() { }

	// RVA: 0x578770 Offset: 0x577B70 VA: 0x180578770
	public static void Hide() { }

	// RVA: 0x578FD0 Offset: 0x5783D0 VA: 0x180578FD0
	public static void Show() { }

	// RVA: 0x578F00 Offset: 0x578300 VA: 0x180578F00
	private void ShowDemoBrowserButton() { }

	// RVA: 0x578B60 Offset: 0x577F60 VA: 0x180578B60
	private void OnEnabledState(bool b) { }

	// RVA: 0x5789D0 Offset: 0x577DD0 VA: 0x1805789D0
	private static void OnConnected() { }

	// RVA: 0x578AF0 Offset: 0x577EF0 VA: 0x180578AF0
	private static void OnDisconnected() { }

	// RVA: 0x578980 Offset: 0x577D80 VA: 0x180578980
	public void OnClickedQuitDemo() { }

	// RVA: 0x579AE0 Offset: 0x578EE0 VA: 0x180579AE0
	public void .ctor() { }

	// RVA: 0x579AA0 Offset: 0x578EA0 VA: 0x180579AA0
	private static void .cctor() { }

}

private sealed class MainMenuSystem.<>c // TypeDefIndex: 11120
{	// Fields
	public static readonly MainMenuSystem.<>c <>9; // 0x0
	public static Func<IPlayerItemDefinition, bool> <>9__15_0; // 0x8
	public static Func<IPlayerItemDefinition, int> <>9__15_1; // 0x10

	// Methods

	// RVA: 0x5892F0 Offset: 0x5886F0 VA: 0x1805892F0
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x588440 Offset: 0x587840 VA: 0x180588440
	internal bool <Update>b__15_0(IPlayerItemDefinition x) { }

	// RVA: 0x588500 Offset: 0x587900 VA: 0x180588500
	internal int <Update>b__15_1(IPlayerItemDefinition x) { }

}

