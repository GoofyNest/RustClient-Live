public class SearchLight : IOEntity // TypeDefIndex: 8443
{	// Fields
	private Option __menuOption_StopUseLight; // 0x288
	private Option __menuOption_UseLight; // 0x2E0
	public GameObject pitchObject; // 0x338
	public GameObject yawObject; // 0x340
	public GameObject eyePoint; // 0x348
	public SoundPlayer turnLoop; // 0x350
	public bool needsBuildingPrivilegeToUse; // 0x358
	private Vector3 aimDir; // 0x35C
	private bool wasMoving; // 0x368

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x4A2F30 Offset: 0x4A2330 VA: 0x1804A2F30 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x4A3E60 Offset: 0x4A3260 VA: 0x1804A3E60 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x4A3600 Offset: 0x4A2A00 VA: 0x1804A3600 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x4A36F0 Offset: 0x4A2AF0 VA: 0x1804A36F0 Slot: 27
	public override void ResetState() { }

	// RVA: 0x4A2F20 Offset: 0x4A2320 VA: 0x1804A2F20 Slot: 150
	public override int ConsumptionAmount() { }

	// RVA: 0x4A3480 Offset: 0x4A2880 VA: 0x1804A3480 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x4A3D40 Offset: 0x4A3140 VA: 0x1804A3D40
	public void Update() { }

	// RVA: 0x4A38A0 Offset: 0x4A2CA0 VA: 0x1804A38A0
	private void UpdateAimpoint() { }

	[BaseEntity.Menu] // RVA: 0x83260 Offset: 0x82660 VA: 0x180083260
	[BaseEntity.Menu.Description] // RVA: 0x83260 Offset: 0x82660 VA: 0x180083260
	[BaseEntity.Menu.Icon] // RVA: 0x83260 Offset: 0x82660 VA: 0x180083260
	[BaseEntity.Menu.ShowIf] // RVA: 0x83260 Offset: 0x82660 VA: 0x180083260
	// RVA: 0x4A3D70 Offset: 0x4A3170 VA: 0x1804A3D70
	public void UseLight(BasePlayer player) { }

	// RVA: 0x4A3570 Offset: 0x4A2970 VA: 0x1804A3570
	public bool Menu_UseLight_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x83530 Offset: 0x82930 VA: 0x180083530
	[BaseEntity.Menu.Description] // RVA: 0x83530 Offset: 0x82930 VA: 0x180083530
	[BaseEntity.Menu.Icon] // RVA: 0x83530 Offset: 0x82930 VA: 0x180083530
	[BaseEntity.Menu.ShowIf] // RVA: 0x83530 Offset: 0x82930 VA: 0x180083530
	// RVA: 0x4A3850 Offset: 0x4A2C50 VA: 0x1804A3850
	public void StopUseLight(BasePlayer player) { }

	// RVA: 0x4A34E0 Offset: 0x4A28E0 VA: 0x1804A34E0
	public bool Menu_StopUseLight_ShowIf(BasePlayer player) { }

	// RVA: 0x4A3DC0 Offset: 0x4A31C0 VA: 0x1804A3DC0
	public void .ctor() { }

}

public static class SearchLight.SearchLightFlags // TypeDefIndex: 8444
{	// Fields
	public const BaseEntity.Flags PlayerUsing = 2048;

}

