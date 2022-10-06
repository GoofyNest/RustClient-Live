public class StashContainer : StorageContainer // TypeDefIndex: 10160
{
	private Option __menuOption_Menu_HideStash; 
	public Transform visuals; 
	public float burriedOffset; 
	public float raisedOffset; 
	public GameObjectRef buryEffect; 
	public float uncoverRange; 

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public bool IsHidden() { }

	public bool PlayerInRange(BasePlayer ply) { }

	public override bool ShouldShowLootMenus() { }

	protected override void ClientInit(Entity info) { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_HideStash(BasePlayer player) { }

	public bool Menu_HideStash_ShowIf(BasePlayer player) { }

	public void TryUnhide() { }

	public void Update() { }

	public void .ctor() { }

}

public static class StashContainer.StashContainerFlags // TypeDefIndex: 10161
{
	public const BaseEntity.Flags Hidden = 2048;

}

