public class NeedsKeyboard : ListComponent<NeedsKeyboard> // TypeDefIndex: 8012
{
	public UnityEvent onNoKeysDown; 
	public bool ShowEscapeUI; 
	public NeedsKeyboard.BypassOption AllowedBinds; 
	private List<string> binds; 
	private bool watchForNoKeys; 

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
{
	public int value__; 
public const NeedsKeyboard.BypassOption Voice = 1;
public const NeedsKeyboard.BypassOption Chat = 4;
public const NeedsKeyboard.BypassOption Gesture = 8;

}

