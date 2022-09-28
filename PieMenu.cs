public class PieMenu : UIBehaviour // TypeDefIndex: 12886
{
	public static PieMenu Instance; 
	public Image middleBox; 
	public PieShape pieBackgroundBlur; 
	public PieShape pieBackground; 
	public PieShape pieSelection; 
	public GameObject pieOptionPrefab; 
	public GameObject optionsCanvas; 
	public PieMenu.MenuOption[] options; 
	public GameObject scaleTarget; 
	public float sliceGaps; 
	[RangeAttribute] 
	public float outerSize; 
	[RangeAttribute] 
	public float innerSize; 
	[RangeAttribute] 
	public float iconSize; 
	[RangeAttribute] 
	public float startRadius; 
	[RangeAttribute] 
	public float radiusSize; 
	public Image middleImage; 
	public TextMeshProUGUI middleTitle; 
	public TextMeshProUGUI middleDesc; 
	public TextMeshProUGUI middleRequired; 
	public Color colorIconActive; 
	public Color colorIconHovered; 
	public Color colorIconDisabled; 
	public Color colorBackgroundDisabled; 
	public SoundDefinition clipOpen; 
	public SoundDefinition clipCancel; 
	public SoundDefinition clipChanged; 
	public SoundDefinition clipSelected; 
	public PieMenu.MenuOption defaultOption; 
	private bool isClosing; 
	private CanvasGroup canvasGroup; 
	public bool IsOpen; 
	public Material IconMaterial; 
	internal PieMenu.MenuOption selectedOption; 
	private static Color pieSelectionColor; 
	private static Color middleImageColor; 
	private static AnimationCurve easePunch; 


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

public class PieMenu.MenuOption // TypeDefIndex: 12887
{
	public string name; 
	public string desc; 
	public string requirements; 
	public Sprite sprite; 
	public bool disabled; 
	public int order; 
	public Nullable<PieMenu.MenuOption.ColorMode> overrideColorMode; 
	public Action<BasePlayer> action; 
	public PieOption option; 
	public bool selected; 
	public bool allowMerge; 
	public bool wantsMerge; 


	public void .ctor() { }

}

public struct PieMenu.MenuOption.ColorMode // TypeDefIndex: 12888
{
	public PieMenu.MenuOption.ColorMode.PieMenuSpriteColorOption Mode; 
	public Color CustomColor; 

}

public enum PieMenu.MenuOption.ColorMode.PieMenuSpriteColorOption // TypeDefIndex: 12889
{
	public int value__; 
	public const PieMenu.MenuOption.ColorMode.PieMenuSpriteColorOption CustomColor = 0;
	public const PieMenu.MenuOption.ColorMode.PieMenuSpriteColorOption SpriteColor = 1;

}

private sealed class PieMenu.<>c // TypeDefIndex: 12890
{
	public static readonly PieMenu.<>c <>9; 
	public static Func<PieMenu.MenuOption, int> <>9__43_0; 
	public static Func<PieMenu.MenuOption, bool> <>9__43_1; 


	private static void .cctor() { }

	public void .ctor() { }

	internal int <Rebuild>b__43_0(PieMenu.MenuOption x) { }

	internal bool <Rebuild>b__43_1(PieMenu.MenuOption x) { }

}

