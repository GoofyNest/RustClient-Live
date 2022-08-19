public class RCBookmarkEntry : MonoBehaviour // TypeDefIndex: 8686
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <identifier>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private uint <netid>k__BackingField; // 0x20
	private ComputerMenu owner; // 0x28
	public RectTransform connectButton; // 0x30
	public RectTransform disconnectButton; // 0x38
	public RawImage onlineIndicator; // 0x40
	public RawImage offlineIndicator; // 0x48
	public GameObject selectedindicator; // 0x50
	public Image backgroundImage; // 0x58
	public Color activeColor; // 0x60
	public Color inactiveColor; // 0x70
	public Text nameLabel; // 0x80
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <isControlling>k__BackingField; // 0x88
	public EventTrigger eventTrigger; // 0x90

	// Properties
	public string identifier { get; set; }
	public uint netid { get; set; }
	public bool isControlling { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public string get_identifier() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4D0180 Offset: 0x4CF580 VA: 0x1804D0180
	private void set_identifier(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4D0170 Offset: 0x4CF570 VA: 0x1804D0170
	public uint get_netid() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x69CC40 Offset: 0x69C040 VA: 0x18069CC40
	private void set_netid(uint value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x69CC20 Offset: 0x69C020 VA: 0x18069CC20
	public bool get_isControlling() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x69CC30 Offset: 0x69C030 VA: 0x18069CC30
	private void set_isControlling(bool value) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public void CursorEnter() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public void CursorExit() { }

	// RVA: 0x69CAC0 Offset: 0x69BEC0 VA: 0x18069CAC0
	public void Setup(string newidentifier, uint newnetid, ComputerMenu ownerMenu, string overrideText = "") { }

	// RVA: 0x69CA30 Offset: 0x69BE30 VA: 0x18069CA30
	public void DeletePressed() { }

	// RVA: 0x69CA90 Offset: 0x69BE90 VA: 0x18069CA90
	public void OnPressed() { }

	// RVA: 0x69CA60 Offset: 0x69BE60 VA: 0x18069CA60
	public void DisconnectedPressed() { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

