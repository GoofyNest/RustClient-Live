public class StashContainer : StorageContainer // TypeDefIndex: 8455
{	private Option __menuOption_Menu_HideStash; // 0x3D0
	public Transform visuals; // 0x428
	public float burriedOffset; // 0x430
	public float raisedOffset; // 0x434
	public GameObjectRef buryEffect; // 0x438
	public float uncoverRange; // 0x440

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public bool IsHidden() { }

	public bool PlayerInRange(BasePlayer ply) { }

	public override bool ShouldShowLootMenus() { }

	protected override void ClientInit(Entity info) { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	[BaseEntity.Menu] // RVA: 0x8DB00 Offset: 0x8CF00 VA: 0x18008DB00
	[BaseEntity.Menu.Description] // RVA: 0x8DB00 Offset: 0x8CF00 VA: 0x18008DB00
	[BaseEntity.Menu.Icon] // RVA: 0x8DB00 Offset: 0x8CF00 VA: 0x18008DB00
	[BaseEntity.Menu.ShowIf] // RVA: 0x8DB00 Offset: 0x8CF00 VA: 0x18008DB00
	public void Menu_HideStash(BasePlayer player) { }

	public bool Menu_HideStash_ShowIf(BasePlayer player) { }

	public void TryUnhide() { }

	public void Update() { }

	public void .ctor() { }

}

public static class StashContainer.StashContainerFlags // TypeDefIndex: 8456
{	public const BaseEntity.Flags Hidden = 2048;

}

