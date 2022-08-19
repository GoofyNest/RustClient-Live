public class ExcavatorArm : BaseEntity // TypeDefIndex: 8390
{	// Fields
	private Option __menuOption_Menu_TargetHQM; // 0x168
	private Option __menuOption_Menu_TargetMetal; // 0x1C0
	private Option __menuOption_Menu_TargetStone; // 0x218
	private Option __menuOption_Menu_TargetSulfur; // 0x270
	public float yaw1; // 0x2C8
	public float yaw2; // 0x2CC
	public Transform wheel; // 0x2D0
	public float wheelSpeed; // 0x2D8
	public float turnSpeed; // 0x2DC
	public Transform miningOffset; // 0x2E0
	public GameObjectRef bounceEffect; // 0x2E8
	public LightGroupAtTime lights; // 0x2F0
	public Material conveyorMaterial; // 0x2F8
	public float beltSpeedMax; // 0x300
	public const BaseEntity.Flags Flag_HasPower = 65536;
	public List<ExcavatorOutputPile> outputPiles; // 0x308
	public SoundDefinition miningStartButtonSoundDef; // 0x310
	[HeaderAttribute] // RVA: 0xDD9B0 Offset: 0xDCDB0 VA: 0x1800DD9B0
	public ItemAmount[] resourcesToMine; // 0x318
	public float resourceProductionTickRate; // 0x320
	public float timeForFullResources; // 0x324
	private ItemAmount[] pendingResources; // 0x328
	private float wheelRotation; // 0x330
	private float nextBounceTime; // 0x334
	private float currentWheelTurnSpeed; // 0x338
	private float currentBeltSpeed; // 0x33C
	private float currentBeltOffset; // 0x340

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x8BBEC0 Offset: 0x8BB2C0 VA: 0x1808BBEC0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x8BD780 Offset: 0x8BCB80 VA: 0x1808BD780 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x8BD030 Offset: 0x8BC430 VA: 0x1808BD030 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x5714C0 Offset: 0x5708C0 VA: 0x1805714C0
	public bool IsPowered() { }

	// RVA: 0x5C9C90 Offset: 0x5C9090 VA: 0x1805C9C90
	public bool IsMining() { }

	// RVA: 0x581F40 Offset: 0x581340 VA: 0x180581F40 Slot: 52
	public override float GetExtrapolationTime() { }

	// RVA: 0x8BD1D0 Offset: 0x8BC5D0 VA: 0x1808BD1D0 Slot: 16
	public override void PostNetworkUpdate() { }

	// RVA: 0x8BD2C0 Offset: 0x8BC6C0 VA: 0x1808BD2C0
	public void SetLightStatus(bool wantsOn) { }

	// RVA: 0x8BD300 Offset: 0x8BC700 VA: 0x1808BD300
	public void Update() { }

	[BaseEntity.Menu] // RVA: 0xDEDA0 Offset: 0xDE1A0 VA: 0x1800DEDA0
	[BaseEntity.Menu.Description] // RVA: 0xDEDA0 Offset: 0xDE1A0 VA: 0x1800DEDA0
	[BaseEntity.Menu.Icon] // RVA: 0xDEDA0 Offset: 0xDE1A0 VA: 0x1800DEDA0
	[BaseEntity.Menu.ShowIf] // RVA: 0xDEDA0 Offset: 0xDE1A0 VA: 0x1800DEDA0
	// RVA: 0x8BC930 Offset: 0x8BBD30 VA: 0x1808BC930
	public void Menu_TargetHQM(BasePlayer player) { }

	// RVA: 0x8BC870 Offset: 0x8BBC70 VA: 0x1808BC870
	public bool Menu_TargetHQM_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xDEFD0 Offset: 0xDE3D0 VA: 0x1800DEFD0
	[BaseEntity.Menu.Description] // RVA: 0xDEFD0 Offset: 0xDE3D0 VA: 0x1800DEFD0
	[BaseEntity.Menu.Icon] // RVA: 0xDEFD0 Offset: 0xDE3D0 VA: 0x1800DEFD0
	[BaseEntity.Menu.ShowIf] // RVA: 0xDEFD0 Offset: 0xDE3D0 VA: 0x1800DEFD0
	// RVA: 0x8BCF00 Offset: 0x8BC300 VA: 0x1808BCF00
	public void Menu_TargetSulfur(BasePlayer player) { }

	// RVA: 0x8BCE40 Offset: 0x8BC240 VA: 0x1808BCE40
	public bool Menu_TargetSulfur_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xDF2B0 Offset: 0xDE6B0 VA: 0x1800DF2B0
	[BaseEntity.Menu.Description] // RVA: 0xDF2B0 Offset: 0xDE6B0 VA: 0x1800DF2B0
	[BaseEntity.Menu.Icon] // RVA: 0xDF2B0 Offset: 0xDE6B0 VA: 0x1800DF2B0
	[BaseEntity.Menu.ShowIf] // RVA: 0xDF2B0 Offset: 0xDE6B0 VA: 0x1800DF2B0
	// RVA: 0x8BCD10 Offset: 0x8BC110 VA: 0x1808BCD10
	public void Menu_TargetStone(BasePlayer player) { }

	// RVA: 0x8BCC50 Offset: 0x8BC050 VA: 0x1808BCC50
	public bool Menu_TargetStone_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xDF560 Offset: 0xDE960 VA: 0x1800DF560
	[BaseEntity.Menu.Description] // RVA: 0xDF560 Offset: 0xDE960 VA: 0x1800DF560
	[BaseEntity.Menu.Icon] // RVA: 0xDF560 Offset: 0xDE960 VA: 0x1800DF560
	[BaseEntity.Menu.ShowIf] // RVA: 0xDF560 Offset: 0xDE960 VA: 0x1800DF560
	// RVA: 0x8BCB20 Offset: 0x8BBF20 VA: 0x1808BCB20
	public void Menu_TargetMetal(BasePlayer player) { }

	// RVA: 0x8BCA60 Offset: 0x8BBE60 VA: 0x1808BCA60
	public bool Menu_TargetMetal_ShowIf(BasePlayer player) { }

	// RVA: 0x8BD120 Offset: 0x8BC520 VA: 0x1808BD120
	private void PlayMiningStartButtonSound(Vector3 position) { }

	// RVA: 0x8BD6F0 Offset: 0x8BCAF0 VA: 0x1808BD6F0
	public void .ctor() { }

}

