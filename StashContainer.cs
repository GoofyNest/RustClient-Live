public class StashContainer : StorageContainer // TypeDefIndex: 8455
{	// Fields
	private Option __menuOption_Menu_HideStash; // 0x3D0
	public Transform visuals; // 0x428
	public float burriedOffset; // 0x430
	public float raisedOffset; // 0x434
	public GameObjectRef buryEffect; // 0x438
	public float uncoverRange; // 0x440

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0xA86880 Offset: 0xA85C80 VA: 0x180A86880 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0xA874C0 Offset: 0xA868C0 VA: 0x180A874C0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0xA86D20 Offset: 0xA86120 VA: 0x180A86D20 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x7518F0 Offset: 0x750CF0 VA: 0x1807518F0
	public bool IsHidden() { }

	// RVA: 0xA86E10 Offset: 0xA86210 VA: 0x180A86E10
	public bool PlayerInRange(BasePlayer ply) { }

	// RVA: 0xA87050 Offset: 0xA86450 VA: 0x180A87050 Slot: 153
	public override bool ShouldShowLootMenus() { }

	// RVA: 0xA866D0 Offset: 0xA85AD0 VA: 0x180A866D0 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0xA86B80 Offset: 0xA85F80 VA: 0x180A86B80 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	[BaseEntity.Menu] // RVA: 0x8DB00 Offset: 0x8CF00 VA: 0x18008DB00
	[BaseEntity.Menu.Description] // RVA: 0x8DB00 Offset: 0x8CF00 VA: 0x18008DB00
	[BaseEntity.Menu.Icon] // RVA: 0x8DB00 Offset: 0x8CF00 VA: 0x18008DB00
	[BaseEntity.Menu.ShowIf] // RVA: 0x8DB00 Offset: 0x8CF00 VA: 0x18008DB00
	// RVA: 0xA86CE0 Offset: 0xA860E0 VA: 0x180A86CE0
	public void Menu_HideStash(BasePlayer player) { }

	// RVA: 0x79AE90 Offset: 0x79A290 VA: 0x18079AE90
	public bool Menu_HideStash_ShowIf(BasePlayer player) { }

	// RVA: 0xA87090 Offset: 0xA86490 VA: 0x180A87090
	public void TryUnhide() { }

	// RVA: 0xA871D0 Offset: 0xA865D0 VA: 0x180A871D0
	public void Update() { }

	// RVA: 0xA87460 Offset: 0xA86860 VA: 0x180A87460
	public void .ctor() { }

}

public static class StashContainer.StashContainerFlags // TypeDefIndex: 8456
{	// Fields
	public const BaseEntity.Flags Hidden = 2048;

}

