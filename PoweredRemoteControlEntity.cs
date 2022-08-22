public class PoweredRemoteControlEntity : IOEntity, IRemoteControllable // TypeDefIndex: 8429
{	private Option __menuOption_Menu_SetID; // 0x288
	public string rcIdentifier; // 0x2E0
	public Transform viewEyes; // 0x2E8
	public GameObjectRef IDPanelPrefab; // 0x2F0
	public bool isStatic; // 0x2F8
	public bool appendEntityIDToIdentifier; // 0x2F9

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

	[BaseEntity.Menu] // RVA: 0x7D140 Offset: 0x7C540 VA: 0x18007D140
	[BaseEntity.Menu.Description] // RVA: 0x7D140 Offset: 0x7C540 VA: 0x18007D140
	[BaseEntity.Menu.Icon] // RVA: 0x7D140 Offset: 0x7C540 VA: 0x18007D140
	[BaseEntity.Menu.ShowIf] // RVA: 0x7D140 Offset: 0x7C540 VA: 0x18007D140
	public void Menu_SetID(BasePlayer player) { }

	public bool Menu_SetID_ShowIf(BasePlayer player) { }

	public void .ctor() { }

}

