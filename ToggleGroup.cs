public class ToggleGroup : UIBehaviour // TypeDefIndex: 5018
{	// Fields
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool m_AllowSwitchOff; // 0x18
	private List<Toggle> m_Toggles; // 0x20

	// Properties
	public bool allowSwitchOff { get; set; }

	// Methods

	// RVA: 0x95B2D0 Offset: 0x95A6D0 VA: 0x18095B2D0
	public bool get_allowSwitchOff() { }

	// RVA: 0x95B2F0 Offset: 0x95A6F0 VA: 0x18095B2F0
	public void set_allowSwitchOff(bool value) { }

	// RVA: 0x2242490 Offset: 0x2241890 VA: 0x182242490
	protected void .ctor() { }

	// RVA: 0x22422D0 Offset: 0x22416D0 VA: 0x1822422D0 Slot: 6
	protected override void Start() { }

	// RVA: 0x2242360 Offset: 0x2241760 VA: 0x182242360
	private void ValidateToggleIsInGroup(Toggle toggle) { }

	// RVA: 0x2241EF0 Offset: 0x22412F0 VA: 0x182241EF0
	public void NotifyToggleOn(Toggle toggle, bool sendCallback = True) { }

	// RVA: 0x22422F0 Offset: 0x22416F0 VA: 0x1822422F0
	public void UnregisterToggle(Toggle toggle) { }

	// RVA: 0x2242130 Offset: 0x2241530 VA: 0x182242130
	public void RegisterToggle(Toggle toggle) { }

	// RVA: 0x2241E40 Offset: 0x2241240 VA: 0x182241E40
	public void EnsureValidState() { }

	// RVA: 0x2241D10 Offset: 0x2241110 VA: 0x182241D10
	public bool AnyTogglesOn() { }

	// RVA: 0x2241C10 Offset: 0x2241010 VA: 0x182241C10
	public IEnumerable<Toggle> ActiveToggles() { }

	// RVA: 0x22421A0 Offset: 0x22415A0 VA: 0x1822421A0
	public void SetAllTogglesOff(bool sendCallback = True) { }

}

private sealed class ToggleGroup.<>c // TypeDefIndex: 5019
{	// Fields
	public static readonly ToggleGroup.<>c <>9; // 0x0
	public static Predicate<Toggle> <>9__12_0; // 0x8
	public static Func<Toggle, bool> <>9__13_0; // 0x10

	// Methods

	// RVA: 0x2242D70 Offset: 0x2242170 VA: 0x182242D70
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x4CE4D0 Offset: 0x4CD8D0 VA: 0x1804CE4D0
	internal bool <AnyTogglesOn>b__12_0(Toggle x) { }

	// RVA: 0x4CE4D0 Offset: 0x4CD8D0 VA: 0x1804CE4D0
	internal bool <ActiveToggles>b__13_0(Toggle x) { }

}

