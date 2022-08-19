public class NeedsKeyboard : ListComponent<NeedsKeyboard> // TypeDefIndex: 8012
{	// Fields
	public UnityEvent onNoKeysDown; // 0x18
	public bool ShowEscapeUI; // 0x20
	public NeedsKeyboard.BypassOption AllowedBinds; // 0x24
	private List<string> binds; // 0x28
	private bool watchForNoKeys; // 0x30

	// Properties
	public static bool ShouldShowUI { get; }

	// Methods

	// RVA: 0x106B9F0 Offset: 0x106ADF0 VA: 0x18106B9F0
	private static void GetBindString(NeedsKeyboard.BypassOption bypassOption, List<string> resultBinds) { }

	// RVA: 0x106B710 Offset: 0x106AB10 VA: 0x18106B710
	public static bool AnyActive(KeyCode key = 0, NeedsKeyboard.BypassOption forBypass = 0) { }

	// RVA: 0x106BD50 Offset: 0x106B150 VA: 0x18106BD50
	public static bool get_ShouldShowUI() { }

	// RVA: 0x106BA90 Offset: 0x106AE90 VA: 0x18106BA90 Slot: 6
	protected override void OnEnable() { }

	// RVA: 0x106BD10 Offset: 0x106B110 VA: 0x18106BD10
	public void Update() { }

	// RVA: 0x106B540 Offset: 0x106A940 VA: 0x18106B540
	private bool AllowKeyInput(KeyCode k, NeedsKeyboard.BypassOption forBypass) { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 8
	protected virtual bool ShouldBlockInput() { }

	// RVA: 0x106B4B0 Offset: 0x106A8B0 VA: 0x18106B4B0
	public void .ctor() { }

}

public enum NeedsKeyboard.BypassOption // TypeDefIndex: 8013
{	// Fields
	public int value__; // 0x0
	public const NeedsKeyboard.BypassOption Voice = 1;
	public const NeedsKeyboard.BypassOption Chat = 4;
	public const NeedsKeyboard.BypassOption Gesture = 8;

}

