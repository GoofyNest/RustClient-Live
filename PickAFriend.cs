public class PickAFriend : UIDialog // TypeDefIndex: 10902
{	public InputField input; // 0x30
	public RustText headerText; // 0x38
	public bool AutoSelectInputField; // 0x40
	public Action<ulong, string> onSelected; // 0x48
	public Translate.Phrase sleepingBagHeaderPhrase; // 0x50
	public Translate.Phrase turretHeaderPhrase; // 0x58
	public SteamFriendsList friendsList; // 0x60

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

public enum PickAFriend.PickFriendMode // TypeDefIndex: 10903
{	public int value__; // 0x0
	public const PickAFriend.PickFriendMode SleepingBag = 0;
	public const PickAFriend.PickFriendMode AutoTurret = 1;

}

