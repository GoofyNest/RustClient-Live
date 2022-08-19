public class PoweredRemoteControlEntity : IOEntity, IRemoteControllable // TypeDefIndex: 8429
{	// Fields
	private Option __menuOption_Menu_SetID; // 0x288
	public string rcIdentifier; // 0x2E0
	public Transform viewEyes; // 0x2E8
	public GameObjectRef IDPanelPrefab; // 0x2F0
	public bool isStatic; // 0x2F8
	public bool appendEntityIDToIdentifier; // 0x2F9

	// Properties
	public override bool HasMenuOptions { get; }
	public virtual bool RequiresMouse { get; }

	// Methods

	// RVA: 0x9800F0 Offset: 0x97F4F0 VA: 0x1809800F0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x980870 Offset: 0x97FC70 VA: 0x180980870 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x980660 Offset: 0x97FA60 VA: 0x180980660 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x980470 Offset: 0x97F870 VA: 0x180980470
	public bool IsStatic() { }

	// RVA: 0x91DC50 Offset: 0x91D050 VA: 0x18091DC50 Slot: 159
	public Transform GetEyes() { }

	// RVA: 0x980080 Offset: 0x97F480 VA: 0x180980080 Slot: 168
	public virtual bool CanControl() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 169
	public virtual bool get_RequiresMouse() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 170
	public virtual void UserInput(InputState inputState, BasePlayer player) { }

	// RVA: 0x4B0E80 Offset: 0x4B0280 VA: 0x1804B0E80 Slot: 160
	public BaseEntity GetEnt() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 161
	public bool Occupied() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 171
	public virtual void InitializeControl(BasePlayer controller) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 172
	public virtual void StopControl() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 173
	public virtual void RCSetup() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 174
	public virtual void RCShutdown() { }

	// RVA: 0x980480 Offset: 0x97F880 VA: 0x180980480 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x980750 Offset: 0x97FB50 VA: 0x180980750 Slot: 162
	public void UpdateIdentifier(string newID, bool clientSend = False) { }

	// RVA: 0x9800E0 Offset: 0x97F4E0 VA: 0x1809800E0 Slot: 163
	public string GetIdentifier() { }

	// RVA: 0x980440 Offset: 0x97F840 VA: 0x180980440 Slot: 28
	public override void InitShared() { }

	// RVA: 0x9800B0 Offset: 0x97F4B0 VA: 0x1809800B0 Slot: 31
	public override void DestroyShared() { }

	[BaseEntity.Menu] // RVA: 0x7D140 Offset: 0x7C540 VA: 0x18007D140
	[BaseEntity.Menu.Description] // RVA: 0x7D140 Offset: 0x7C540 VA: 0x18007D140
	[BaseEntity.Menu.Icon] // RVA: 0x7D140 Offset: 0x7C540 VA: 0x18007D140
	[BaseEntity.Menu.ShowIf] // RVA: 0x7D140 Offset: 0x7C540 VA: 0x18007D140
	// RVA: 0x980580 Offset: 0x97F980 VA: 0x180980580
	public void Menu_SetID(BasePlayer player) { }

	// RVA: 0x980530 Offset: 0x97F930 VA: 0x180980530
	public bool Menu_SetID_ShowIf(BasePlayer player) { }

	// RVA: 0x980800 Offset: 0x97FC00 VA: 0x180980800
	public void .ctor() { }

}

