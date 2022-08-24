public class ToggleGroup : UIBehaviour // TypeDefIndex: 5018
{
	[SerializeField] 
	private bool m_AllowSwitchOff; 
	private List<Toggle> m_Toggles; 

public bool allowSwitchOff { get; set; }


public bool get_allowSwitchOff() { }

public void set_allowSwitchOff(bool value) { }

protected void .ctor() { }

protected override void Start() { }

private void ValidateToggleIsInGroup(Toggle toggle) { }

public void NotifyToggleOn(Toggle toggle, bool sendCallback = True) { }

public void UnregisterToggle(Toggle toggle) { }

public void RegisterToggle(Toggle toggle) { }

public void EnsureValidState() { }

public bool AnyTogglesOn() { }

public IEnumerable<Toggle> ActiveToggles() { }

public void SetAllTogglesOff(bool sendCallback = True) { }

}

private sealed class ToggleGroup.<>c // TypeDefIndex: 5019
{
	public static readonly ToggleGroup.<>c <>9; 
	public static Predicate<Toggle> <>9__12_0; 
	public static Func<Toggle, bool> <>9__13_0; 


private static void .cctor() { }

public void .ctor() { }

internal bool <AnyTogglesOn>b__12_0(Toggle x) { }

internal bool <ActiveToggles>b__13_0(Toggle x) { }

}

