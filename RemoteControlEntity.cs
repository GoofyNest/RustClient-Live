public class RemoteControlEntity : BaseCombatEntity, IRemoteControllable // TypeDefIndex: 8435
{
	private Option __menuOption_Menu_SetID; 
	[HeaderAttribute] 
	public string rcIdentifier; 
	public Transform viewEyes; 
	public GameObjectRef IDPanelPrefab; 

	public override bool HasMenuOptions { get; }
	public virtual bool RequiresMouse { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public Transform GetEyes() { }

	public BaseEntity GetEnt() { }

	public bool Occupied() { }

	public string GetIdentifier() { }

	public void UpdateIdentifier(string newID, bool clientSend = False) { }

	public virtual void RCSetup() { }

	public virtual void RCShutdown() { }

	public override void InitShared() { }

	public override void DestroyShared() { }

	public virtual bool CanControl() { }

	public virtual bool get_RequiresMouse() { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_SetID(BasePlayer player) { }

	public bool Menu_SetID_ShowIf(BasePlayer player) { }

	public void .ctor() { }

}

