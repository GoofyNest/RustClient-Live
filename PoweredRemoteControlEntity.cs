public class PoweredRemoteControlEntity : IOEntity, IRemoteControllable // TypeDefIndex: 10147
{
	private Option __menuOption_Menu_SetID; 
	public string rcIdentifier; 
	public Transform viewEyes; 
	public GameObjectRef IDPanelPrefab; 
	public bool isStatic; 
	public bool appendEntityIDToIdentifier; 

	public override bool HasMenuOptions { get; }
	public virtual bool RequiresMouse { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public bool IsStatic() { }

	public Transform GetEyes() { }

	public virtual bool CanControl() { }

	public virtual bool get_RequiresMouse() { }

	public virtual void UserInput(InputState inputState, BasePlayer player) { }

	public BaseEntity GetEnt() { }

	public bool Occupied() { }

	public virtual void InitializeControl(BasePlayer controller) { }

	public virtual void StopControl() { }

	public virtual void RCSetup() { }

	public virtual void RCShutdown() { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public void UpdateIdentifier(string newID, bool clientSend = False) { }

	public string GetIdentifier() { }

	public override void InitShared() { }

	public override void DestroyShared() { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_SetID(BasePlayer player) { }

	public bool Menu_SetID_ShowIf(BasePlayer player) { }

	public void .ctor() { }

}

