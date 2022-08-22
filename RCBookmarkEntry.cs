public class RCBookmarkEntry : MonoBehaviour // TypeDefIndex: 8686
{	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
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

	public string identifier { get; set; }
	public uint netid { get; set; }
	public bool isControlling { get; set; }


	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public string get_identifier() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_identifier(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public uint get_netid() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_netid(uint value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public bool get_isControlling() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_isControlling(bool value) { }

	public void CursorEnter() { }

	public void CursorExit() { }

	public void Setup(string newidentifier, uint newnetid, ComputerMenu ownerMenu, string overrideText = "") { }

	public void DeletePressed() { }

	public void OnPressed() { }

	public void DisconnectedPressed() { }

	public void .ctor() { }

}

