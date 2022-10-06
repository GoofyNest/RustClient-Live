public class PickAFriend : UIDialog // TypeDefIndex: 12621
{
	public InputField input; 
	public RustText headerText; 
	public bool AutoSelectInputField; 
	public Action<ulong, string> onSelected; 
	public Translate.Phrase sleepingBagHeaderPhrase; 
	public Translate.Phrase turretHeaderPhrase; 
	public SteamFriendsList friendsList; 

	public Func<ulong, bool> shouldShowPlayer { set; }


	public void set_shouldShowPlayer(Func<ulong, bool> value) { }

	public void SetHeaderText(PickAFriend.PickFriendMode mode) { }

	public override void OpenDialog() { }

	private void CheckForNoInput() { }

	public void SelectTextField() { }

	public void DoAssign(ulong steamid, string steamName) { }

	public void Cancel() { }

	public void .ctor() { }

}

public enum PickAFriend.PickFriendMode // TypeDefIndex: 12622
{
	public int value__; 
	public const PickAFriend.PickFriendMode SleepingBag = 0;
	public const PickAFriend.PickFriendMode AutoTurret = 1;

}

