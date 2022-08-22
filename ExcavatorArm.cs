public class ExcavatorArm : BaseEntity // TypeDefIndex: 8390
{	private Option __menuOption_Menu_TargetHQM; // 0x168
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

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public bool IsPowered() { }

	public bool IsMining() { }

	public override float GetExtrapolationTime() { }

	public override void PostNetworkUpdate() { }

	public void SetLightStatus(bool wantsOn) { }

	public void Update() { }

	[BaseEntity.Menu] // RVA: 0xDEDA0 Offset: 0xDE1A0 VA: 0x1800DEDA0
	[BaseEntity.Menu.Description] // RVA: 0xDEDA0 Offset: 0xDE1A0 VA: 0x1800DEDA0
	[BaseEntity.Menu.Icon] // RVA: 0xDEDA0 Offset: 0xDE1A0 VA: 0x1800DEDA0
	[BaseEntity.Menu.ShowIf] // RVA: 0xDEDA0 Offset: 0xDE1A0 VA: 0x1800DEDA0
	public void Menu_TargetHQM(BasePlayer player) { }

	public bool Menu_TargetHQM_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xDEFD0 Offset: 0xDE3D0 VA: 0x1800DEFD0
	[BaseEntity.Menu.Description] // RVA: 0xDEFD0 Offset: 0xDE3D0 VA: 0x1800DEFD0
	[BaseEntity.Menu.Icon] // RVA: 0xDEFD0 Offset: 0xDE3D0 VA: 0x1800DEFD0
	[BaseEntity.Menu.ShowIf] // RVA: 0xDEFD0 Offset: 0xDE3D0 VA: 0x1800DEFD0
	public void Menu_TargetSulfur(BasePlayer player) { }

	public bool Menu_TargetSulfur_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xDF2B0 Offset: 0xDE6B0 VA: 0x1800DF2B0
	[BaseEntity.Menu.Description] // RVA: 0xDF2B0 Offset: 0xDE6B0 VA: 0x1800DF2B0
	[BaseEntity.Menu.Icon] // RVA: 0xDF2B0 Offset: 0xDE6B0 VA: 0x1800DF2B0
	[BaseEntity.Menu.ShowIf] // RVA: 0xDF2B0 Offset: 0xDE6B0 VA: 0x1800DF2B0
	public void Menu_TargetStone(BasePlayer player) { }

	public bool Menu_TargetStone_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xDF560 Offset: 0xDE960 VA: 0x1800DF560
	[BaseEntity.Menu.Description] // RVA: 0xDF560 Offset: 0xDE960 VA: 0x1800DF560
	[BaseEntity.Menu.Icon] // RVA: 0xDF560 Offset: 0xDE960 VA: 0x1800DF560
	[BaseEntity.Menu.ShowIf] // RVA: 0xDF560 Offset: 0xDE960 VA: 0x1800DF560
	public void Menu_TargetMetal(BasePlayer player) { }

	public bool Menu_TargetMetal_ShowIf(BasePlayer player) { }

	private void PlayMiningStartButtonSound(Vector3 position) { }

	public void .ctor() { }

}

