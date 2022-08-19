public class RemoteControlEntity : BaseCombatEntity, IRemoteControllable // TypeDefIndex: 8435
{	// Fields
	private Option __menuOption_Menu_SetID; // 0x240
	[HeaderAttribute] // RVA: 0x7FBE0 Offset: 0x7EFE0 VA: 0x18007FBE0
	public string rcIdentifier; // 0x298
	public Transform viewEyes; // 0x2A0
	public GameObjectRef IDPanelPrefab; // 0x2A8

	// Properties
	public override bool HasMenuOptions { get; }
	public virtual bool RequiresMouse { get; }

	// Methods

	// RVA: 0x92BBC0 Offset: 0x92AFC0 VA: 0x18092BBC0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x92C3C0 Offset: 0x92B7C0 VA: 0x18092C3C0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x92C190 Offset: 0x92B590 VA: 0x18092C190 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x92BBA0 Offset: 0x92AFA0 VA: 0x18092BBA0 Slot: 145
	public Transform GetEyes() { }

	// RVA: 0x4B0E80 Offset: 0x4B0280 VA: 0x1804B0E80 Slot: 146
	public BaseEntity GetEnt() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 147
	public bool Occupied() { }

	// RVA: 0x92BBB0 Offset: 0x92AFB0 VA: 0x18092BBB0 Slot: 149
	public string GetIdentifier() { }

	// RVA: 0x92C280 Offset: 0x92B680 VA: 0x18092C280 Slot: 148
	public void UpdateIdentifier(string newID, bool clientSend = False) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 154
	public virtual void RCSetup() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 155
	public virtual void RCShutdown() { }

	// RVA: 0x92BF40 Offset: 0x92B340 VA: 0x18092BF40 Slot: 28
	public override void InitShared() { }

	// RVA: 0x92BB70 Offset: 0x92AF70 VA: 0x18092BB70 Slot: 31
	public override void DestroyShared() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 156
	public virtual bool CanControl() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 157
	public virtual bool get_RequiresMouse() { }

	// RVA: 0x92BF70 Offset: 0x92B370 VA: 0x18092BF70 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	[BaseEntity.Menu] // RVA: 0x7D140 Offset: 0x7C540 VA: 0x18007D140
	[BaseEntity.Menu.Description] // RVA: 0x7D140 Offset: 0x7C540 VA: 0x18007D140
	[BaseEntity.Menu.Icon] // RVA: 0x7D140 Offset: 0x7C540 VA: 0x18007D140
	[BaseEntity.Menu.ShowIf] // RVA: 0x7D140 Offset: 0x7C540 VA: 0x18007D140
	// RVA: 0x92C0B0 Offset: 0x92B4B0 VA: 0x18092C0B0
	public void Menu_SetID(BasePlayer player) { }

	// RVA: 0x92C010 Offset: 0x92B410 VA: 0x18092C010
	public bool Menu_SetID_ShowIf(BasePlayer player) { }

	// RVA: 0x92C370 Offset: 0x92B770 VA: 0x18092C370
	public void .ctor() { }

}

