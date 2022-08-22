public class NeedsKeyboard : ListComponent<NeedsKeyboard> // TypeDefIndex: 8012
{	public UnityEvent onNoKeysDown; // 0x18
	public bool ShowEscapeUI; // 0x20
	public NeedsKeyboard.BypassOption AllowedBinds; // 0x24
	private List<string> binds; // 0x28
	private bool watchForNoKeys; // 0x30

	public static bool ShouldShowUI { get; }


	private static void GetBindString(NeedsKeyboard.BypassOption bypassOption, List<string> resultBinds) { }

	public static bool AnyActive(KeyCode key = 0, NeedsKeyboard.BypassOption forBypass = 0) { }

	public static bool get_ShouldShowUI() { }

	protected override void OnEnable() { }

	public void Update() { }

	private bool AllowKeyInput(KeyCode k, NeedsKeyboard.BypassOption forBypass) { }

	protected virtual bool ShouldBlockInput() { }

	public void .ctor() { }

}

public enum NeedsKeyboard.BypassOption // TypeDefIndex: 8013
{	public int value__; // 0x0
	public const NeedsKeyboard.BypassOption Voice = 1;
	public const NeedsKeyboard.BypassOption Chat = 4;
	public const NeedsKeyboard.BypassOption Gesture = 8;

}

