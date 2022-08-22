public class PieMenu : UIBehaviour // TypeDefIndex: 11190
{	public static PieMenu Instance; // 0x0
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


	protected override void Start() { }

	public void Clear() { }

	public void AddOption(PieMenu.MenuOption option) { }

	public void FinishAndOpen() { }

	protected override void OnEnable() { }

	public void SetDefaultOption() { }

	public void PlayOpenSound() { }

	public void PlayCancelSound() { }

	public void Close(bool success = False) { }

	private void Update() { }

	public void Rebuild() { }

	public void UpdateInteraction(bool allowLerp = True) { }

	public bool DoSelect() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class PieMenu.MenuOption // TypeDefIndex: 11191
{	public string name; // 0x10
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


	public void .ctor() { }

}

public struct PieMenu.MenuOption.ColorMode // TypeDefIndex: 11192
{	public PieMenu.MenuOption.ColorMode.PieMenuSpriteColorOption Mode; // 0x0
	public Color CustomColor; // 0x4

}

public enum PieMenu.MenuOption.ColorMode.PieMenuSpriteColorOption // TypeDefIndex: 11193
{	public int value__; // 0x0
	public const PieMenu.MenuOption.ColorMode.PieMenuSpriteColorOption CustomColor = 0;
	public const PieMenu.MenuOption.ColorMode.PieMenuSpriteColorOption SpriteColor = 1;

}

private sealed class PieMenu.<>c // TypeDefIndex: 11194
{	public static readonly PieMenu.<>c <>9; // 0x0
	public static Func<PieMenu.MenuOption, int> <>9__43_0; // 0x8
	public static Func<PieMenu.MenuOption, bool> <>9__43_1; // 0x10


	private static void .cctor() { }

	public void .ctor() { }

	internal int <Rebuild>b__43_0(PieMenu.MenuOption x) { }

	internal bool <Rebuild>b__43_1(PieMenu.MenuOption x) { }

}

