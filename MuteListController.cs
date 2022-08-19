public class MuteListController : UIDialog // TypeDefIndex: 12036
{	// Fields
	public RectTransform ListParent; // 0x30
	public GameObjectRef UserWidget; // 0x38
	public SteamFriendsList SearchList; // 0x40

	// Methods

	// RVA: 0x4BE340 Offset: 0x4BD740 VA: 0x1804BE340 Slot: 6
	protected override void OnEnable() { }

	// RVA: 0x4BE450 Offset: 0x4BD850 VA: 0x1804BE450
	private void PopulateMuteList() { }

	// RVA: 0x4BE7D0 Offset: 0x4BDBD0 VA: 0x1804BE7D0
	public void RemoveFromMuteList(ulong id) { }

	// RVA: 0x4BE290 Offset: 0x4BD690 VA: 0x1804BE290
	public void MutePlayer(ulong id, string playerName) { }

	// RVA: 0x4BE840 Offset: 0x4BDC40 VA: 0x1804BE840
	public void .ctor() { }

}

private sealed class MuteListController.<>c // TypeDefIndex: 12037
{	// Fields
	public static readonly MuteListController.<>c <>9; // 0x0
	public static Func<ulong, bool> <>9__3_0; // 0x8

	// Methods

	// RVA: 0x4CF1C0 Offset: 0x4CE5C0 VA: 0x1804CF1C0
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x4CE720 Offset: 0x4CDB20 VA: 0x1804CE720
	internal bool <OnEnable>b__3_0(ulong arg) { }

}

private sealed class MuteListController.<>c__DisplayClass4_0 // TypeDefIndex: 12038
{	// Fields
	public Chat.MuteEntry muteEntry; // 0x10
	public MuteListController <>4__this; // 0x28

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x4CEFC0 Offset: 0x4CE3C0 VA: 0x1804CEFC0
	internal void <PopulateMuteList>b__0() { }

}

