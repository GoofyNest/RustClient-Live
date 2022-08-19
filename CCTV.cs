public class CCTV_RC : PoweredRemoteControlEntity // TypeDefIndex: 8372
{	// Fields
	private Option __menuOption_Menu_SetDir; // 0x300
	public Transform pivotOrigin; // 0x358
	public Transform yaw; // 0x360
	public Transform pitch; // 0x368
	public Vector2 pitchClamp; // 0x370
	public Vector2 yawClamp; // 0x378
	public float turnSpeed; // 0x380
	public float serverLerpSpeed; // 0x384
	public float clientLerpSpeed; // 0x388
	private float pitchAmount; // 0x38C
	private float yawAmount; // 0x390
	public bool hasPTZ; // 0x394
	public const BaseEntity.Flags Flag_HasViewer = 2048;

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x70CCA0 Offset: 0x70C0A0 VA: 0x18070CCA0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x70D590 Offset: 0x70C990 VA: 0x18070D590 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x70D160 Offset: 0x70C560 VA: 0x18070D160 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x70CC90 Offset: 0x70C090 VA: 0x18070CC90 Slot: 150
	public override int ConsumptionAmount() { }

	// RVA: 0x70D250 Offset: 0x70C650 VA: 0x18070D250
	public void UpdateRotation(float delta) { }

	// RVA: 0x70D020 Offset: 0x70C420 VA: 0x18070D020 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x70CC60 Offset: 0x70C060 VA: 0x18070CC60 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x70D4A0 Offset: 0x70C8A0 VA: 0x18070D4A0
	public void Update() { }

	[BaseEntity.Menu] // RVA: 0xD2650 Offset: 0xD1A50 VA: 0x1800D2650
	[BaseEntity.Menu.Description] // RVA: 0xD2650 Offset: 0xD1A50 VA: 0x1800D2650
	[BaseEntity.Menu.Icon] // RVA: 0xD2650 Offset: 0xD1A50 VA: 0x1800D2650
	[BaseEntity.Menu.ShowIf] // RVA: 0xD2650 Offset: 0xD1A50 VA: 0x1800D2650
	// RVA: 0x70D120 Offset: 0x70C520 VA: 0x18070D120
	public void Menu_SetDir(BasePlayer player) { }

	// RVA: 0x70D090 Offset: 0x70C490 VA: 0x18070D090
	public bool Menu_SetDir_ShowIf(BasePlayer player) { }

	// RVA: 0x70D4E0 Offset: 0x70C8E0 VA: 0x18070D4E0
	public void .ctor() { }

}

