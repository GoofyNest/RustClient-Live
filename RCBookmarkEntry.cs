public class RCBookmarkEntry : MonoBehaviour // TypeDefIndex: 10397
{
	[CompilerGeneratedAttribute] 
	private string <identifier>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private uint <netid>k__BackingField; 
	private ComputerMenu owner; 
	public RectTransform connectButton; 
	public RectTransform disconnectButton; 
	public RawImage onlineIndicator; 
	public RawImage offlineIndicator; 
	public GameObject selectedindicator; 
	public Image backgroundImage; 
	public Color activeColor; 
	public Color inactiveColor; 
	public Text nameLabel; 
	[CompilerGeneratedAttribute] 
	private bool <isControlling>k__BackingField; 
	public EventTrigger eventTrigger; 

	public string identifier { get; set; }
	public uint netid { get; set; }
	public bool isControlling { get; set; }


	[CompilerGeneratedAttribute] 
	public string get_identifier() { }

	[CompilerGeneratedAttribute] 
	private void set_identifier(string value) { }

	[CompilerGeneratedAttribute] 
	public uint get_netid() { }

	[CompilerGeneratedAttribute] 
	private void set_netid(uint value) { }

	[CompilerGeneratedAttribute] 
	public bool get_isControlling() { }

	[CompilerGeneratedAttribute] 
	private void set_isControlling(bool value) { }

	public void CursorEnter() { }

	public void CursorExit() { }

	public void Setup(string newidentifier, uint newnetid, ComputerMenu ownerMenu, string overrideText = "") { }

	public void DeletePressed() { }

	public void OnPressed() { }

	public void DisconnectedPressed() { }

	public void .ctor() { }

}

