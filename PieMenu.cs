public class PieMenu : UIBehaviour // TypeDefIndex: 11190
{	// Fields
	public static PieMenu Instance; // 0x0
	public Image middleBox; // 0x18
	public PieShape pieBackgroundBlur; // 0x20
	public PieShape pieBackground; // 0x28
	public PieShape pieSelection; // 0x30
	public GameObject pieOptionPrefab; // 0x38
	public GameObject optionsCanvas; // 0x40
	public PieMenu.MenuOption[] options; // 0x48
	public GameObject scaleTarget; // 0x50
	public float sliceGaps; // 0x58
	[RangeAttribute] // RVA: 0x71260 Offset: 0x70660 VA: 0x180071260
	public float outerSize; // 0x5C
	[RangeAttribute] // RVA: 0x71260 Offset: 0x70660 VA: 0x180071260
	public float innerSize; // 0x60
	[RangeAttribute] // RVA: 0x71260 Offset: 0x70660 VA: 0x180071260
	public float iconSize; // 0x64
	[RangeAttribute] // RVA: 0x9EEE0 Offset: 0x9E2E0 VA: 0x18009EEE0
	public float startRadius; // 0x68
	[RangeAttribute] // RVA: 0x9EEE0 Offset: 0x9E2E0 VA: 0x18009EEE0
	public float radiusSize; // 0x6C
	public Image middleImage; // 0x70
	public TextMeshProUGUI middleTitle; // 0x78
	public TextMeshProUGUI middleDesc; // 0x80
	public TextMeshProUGUI middleRequired; // 0x88
	public Color colorIconActive; // 0x90
	public Color colorIconHovered; // 0xA0
	public Color colorIconDisabled; // 0xB0
	public Color colorBackgroundDisabled; // 0xC0
	public SoundDefinition clipOpen; // 0xD0
	public SoundDefinition clipCancel; // 0xD8
	public SoundDefinition clipChanged; // 0xE0
	public SoundDefinition clipSelected; // 0xE8
	public PieMenu.MenuOption defaultOption; // 0xF0
	private bool isClosing; // 0xF8
	private CanvasGroup canvasGroup; // 0x100
	public bool IsOpen; // 0x108
	public Material IconMaterial; // 0x110
	internal PieMenu.MenuOption selectedOption; // 0x118
	private static Color pieSelectionColor; // 0x8
	private static Color middleImageColor; // 0x18
	private static AnimationCurve easePunch; // 0x28

	// Methods

	// RVA: 0x8CFB90 Offset: 0x8CEF90 VA: 0x1808CFB90 Slot: 6
	protected override void Start() { }

	// RVA: 0x8CEB00 Offset: 0x8CDF00 VA: 0x1808CEB00
	public void Clear() { }

	// RVA: 0x8CEA70 Offset: 0x8CDE70 VA: 0x1808CEA70
	public void AddOption(PieMenu.MenuOption option) { }

	// RVA: 0x8CEF20 Offset: 0x8CE320 VA: 0x1808CEF20
	public void FinishAndOpen() { }

	// RVA: 0x8CF270 Offset: 0x8CE670 VA: 0x1808CF270 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x8CFAB0 Offset: 0x8CEEB0 VA: 0x1808CFAB0
	public void SetDefaultOption() { }

	// RVA: 0x8CF2D0 Offset: 0x8CE6D0 VA: 0x1808CF2D0
	public void PlayOpenSound() { }

	// RVA: 0x8CF290 Offset: 0x8CE690 VA: 0x1808CF290
	public void PlayCancelSound() { }

	// RVA: 0x8CEB50 Offset: 0x8CDF50 VA: 0x1808CEB50
	public void Close(bool success = False) { }

	// RVA: 0x8D0EA0 Offset: 0x8D02A0 VA: 0x1808D0EA0
	private void Update() { }

	// RVA: 0x8CF310 Offset: 0x8CE710 VA: 0x1808CF310
	public void Rebuild() { }

	// RVA: 0x8CFCA0 Offset: 0x8CF0A0 VA: 0x1808CFCA0
	public void UpdateInteraction(bool allowLerp = True) { }

	// RVA: 0x8CEDE0 Offset: 0x8CE1E0 VA: 0x1808CEDE0
	public bool DoSelect() { }

	// RVA: 0x8D14F0 Offset: 0x8D08F0 VA: 0x1808D14F0
	public void .ctor() { }

	// RVA: 0x8D1010 Offset: 0x8D0410 VA: 0x1808D1010
	private static void .cctor() { }

}

public class PieMenu.MenuOption // TypeDefIndex: 11191
{	// Fields
	public string name; // 0x10
	public string desc; // 0x18
	public string requirements; // 0x20
	public Sprite sprite; // 0x28
	public bool disabled; // 0x30
	public int order; // 0x34
	public Nullable<PieMenu.MenuOption.ColorMode> overrideColorMode; // 0x38
	public Action<BasePlayer> action; // 0x50
	public PieOption option; // 0x58
	public bool selected; // 0x60
	public bool allowMerge; // 0x61
	public bool wantsMerge; // 0x62

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

public struct PieMenu.MenuOption.ColorMode // TypeDefIndex: 11192
{	// Fields
	public PieMenu.MenuOption.ColorMode.PieMenuSpriteColorOption Mode; // 0x0
	public Color CustomColor; // 0x4

}

public enum PieMenu.MenuOption.ColorMode.PieMenuSpriteColorOption // TypeDefIndex: 11193
{	// Fields
	public int value__; // 0x0
	public const PieMenu.MenuOption.ColorMode.PieMenuSpriteColorOption CustomColor = 0;
	public const PieMenu.MenuOption.ColorMode.PieMenuSpriteColorOption SpriteColor = 1;

}

private sealed class PieMenu.<>c // TypeDefIndex: 11194
{	// Fields
	public static readonly PieMenu.<>c <>9; // 0x0
	public static Func<PieMenu.MenuOption, int> <>9__43_0; // 0x8
	public static Func<PieMenu.MenuOption, bool> <>9__43_1; // 0x10

	// Methods

	// RVA: 0x8E5020 Offset: 0x8E4420 VA: 0x1808E5020
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x762950 Offset: 0x761D50 VA: 0x180762950
	internal int <Rebuild>b__43_0(PieMenu.MenuOption x) { }

	// RVA: 0x8E4D70 Offset: 0x8E4170 VA: 0x1808E4D70
	internal bool <Rebuild>b__43_1(PieMenu.MenuOption x) { }

}

