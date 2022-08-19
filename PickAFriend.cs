public class PickAFriend : UIDialog // TypeDefIndex: 10902
{	// Fields
	public InputField input; // 0x30
	public RustText headerText; // 0x38
	public bool AutoSelectInputField; // 0x40
	public Action<ulong, string> onSelected; // 0x48
	public Translate.Phrase sleepingBagHeaderPhrase; // 0x50
	public Translate.Phrase turretHeaderPhrase; // 0x58
	public SteamFriendsList friendsList; // 0x60

	// Properties
	public Func<ulong, bool> shouldShowPlayer { set; }

	// Methods

	// RVA: 0x8CE9D0 Offset: 0x8CDDD0 VA: 0x1808CE9D0
	public void set_shouldShowPlayer(Func<ulong, bool> value) { }

	// RVA: 0x8CE8C0 Offset: 0x8CDCC0 VA: 0x1808CE8C0
	public void SetHeaderText(PickAFriend.PickFriendMode mode) { }

	// RVA: 0x8CE730 Offset: 0x8CDB30 VA: 0x1808CE730 Slot: 8
	public override void OpenDialog() { }

	// RVA: 0x8CE5E0 Offset: 0x8CD9E0 VA: 0x1808CE5E0
	private void CheckForNoInput() { }

	// RVA: 0x8CE820 Offset: 0x8CDC20 VA: 0x1808CE820
	public void SelectTextField() { }

	// RVA: 0x8CE6B0 Offset: 0x8CDAB0 VA: 0x1808CE6B0
	public void DoAssign(ulong steamid, string steamName) { }

	// RVA: 0x8CE560 Offset: 0x8CD960 VA: 0x1808CE560
	public void Cancel() { }

	// RVA: 0x8CE920 Offset: 0x8CDD20 VA: 0x1808CE920
	public void .ctor() { }

}

public enum PickAFriend.PickFriendMode // TypeDefIndex: 10903
{	// Fields
	public int value__; // 0x0
	public const PickAFriend.PickFriendMode SleepingBag = 0;
	public const PickAFriend.PickFriendMode AutoTurret = 1;

}

