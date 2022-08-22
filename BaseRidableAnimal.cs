public class BaseRidableAnimal : BaseVehicle // TypeDefIndex: 8347
{	private Option __menuOption_Menu_Claim; // 0x3B8
	private Option __menuOption_Menu_Lead; // 0x410
	private Option __menuOption_Menu_Open; // 0x468
	private Option __menuOption_Menu_Ride; // 0x4C0
	private Option __menuOption_Menu_StopLead; // 0x518
	private Option __menuOption_Menu_TooHeavy; // 0x570
	public ItemDefinition onlyAllowedItem; // 0x5C8
	public ItemContainer.ContentsType allowedContents; // 0x5D0
	public int maxStackSize; // 0x5D4
	public int numSlots; // 0x5D8
	public string lootPanelName; // 0x5E0
	public bool needsBuildingPrivilegeToUse; // 0x5E8
	public bool isLootable; // 0x5E9
	protected ItemContainer inventory; // 0x5F0
	public const BaseEntity.Flags Flag_ForSale = 256;
	private Vector3 lastMoveDirection; // 0x5F8
	public GameObjectRef saddlePrefab; // 0x608
	public EntityRef saddleRef; // 0x610
	public Transform movementLOSOrigin; // 0x620
	public SoundPlayer sprintSounds; // 0x628
	public SoundPlayer largeWhinny; // 0x630
	public const BaseEntity.Flags Flag_Lead = 32768;
	public const BaseEntity.Flags Flag_HasRider = 2;
	[HeaderAttribute] // RVA: 0xC3740 Offset: 0xC2B40 VA: 0x1800C3740
	public ItemDefinition purchaseToken; // 0x638
	public GameObjectRef eatEffect; // 0x640
	public GameObjectRef CorpsePrefab; // 0x648
	[HeaderAttribute] // RVA: 0xC38D0 Offset: 0xC2CD0 VA: 0x1800C38D0
	public Transform animalFront; // 0x650
	public float obstacleDetectionRadius; // 0x658
	public float maxWaterDepth; // 0x65C
	public float roadSpeedBonus; // 0x660
	public float maxWallClimbSlope; // 0x664
	public float maxStepHeight; // 0x668
	public float maxStepDownHeight; // 0x66C
	[HeaderAttribute] // RVA: 0xC3970 Offset: 0xC2D70 VA: 0x1800C3970
	public BaseRidableAnimal.RunState currentRunState; // 0x670
	public float walkSpeed; // 0x674
	public float trotSpeed; // 0x678
	public float runSpeed; // 0x67C
	public float turnSpeed; // 0x680
	public float maxSpeed; // 0x684
	public Transform[] groundSampleOffsets; // 0x688
	[HeaderAttribute] // RVA: 0xC4D70 Offset: 0xC4170 VA: 0x1800C4D70
	public float staminaSeconds; // 0x690
	public float currentMaxStaminaSeconds; // 0x694
	public float maxStaminaSeconds; // 0x698
	public float staminaCoreLossRatio; // 0x69C
	public float staminaCoreSpeedBonus; // 0x6A0
	public float staminaReplenishRatioMoving; // 0x6A4
	public float staminaReplenishRatioStanding; // 0x6A8
	public float calorieToStaminaRatio; // 0x6AC
	public float hydrationToStaminaRatio; // 0x6B0
	public float maxStaminaCoreFromWater; // 0x6B4
	public bool debugMovement; // 0x6B8
	private const float normalOffsetDist = 0,15;
	private Vector3[] normalOffsets; // 0x6C0
	[ServerVar] // RVA: 0xC4E50 Offset: 0xC4250 VA: 0x1800C4E50
	public static float decayminutes; // 0x0
	public float currentSpeed; // 0x6C8
	public float desiredRotation; // 0x6CC
	public float animalPitchClamp; // 0x6D0
	public float animalRollClamp; // 0x6D4
	private float lastBreathingRate; // 0x6D8
	private float nextTokenCheckTime; // 0x6DC
	private bool lastTokenCheckResult; // 0x6E0

	public override bool HasMenuOptions { get; }
	public override bool IsNpc { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public bool IsForSale() { }

	public virtual bool CanOpenStorage(BasePlayer player) { }

	public void LoadContainer(BaseNetworkable.LoadInfo info) { }

	[BaseEntity.Menu] // RVA: 0xC4F40 Offset: 0xC4340 VA: 0x1800C4F40
	[BaseEntity.Menu.Description] // RVA: 0xC4F40 Offset: 0xC4340 VA: 0x1800C4F40
	[BaseEntity.Menu.Icon] // RVA: 0xC4F40 Offset: 0xC4340 VA: 0x1800C4F40
	[BaseEntity.Menu.ShowIf] // RVA: 0xC4F40 Offset: 0xC4340 VA: 0x1800C4F40
	public void Menu_Open(BasePlayer player) { }

	public bool Menu_Open_ShowIf(BasePlayer player) { }

	public virtual bool ShouldShowLootMenus() { }

	public float GetBreathingDelay() { }

	public bool IsLeading() { }

	public static float UnitsToKPH(float unitsPerSecond) { }

	public override bool get_IsNpc() { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public void UpdateBreathingRate() { }

	public override void PostNetworkUpdate() { }

	public void SprintSoundPlay() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void Stand(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void Eat(BaseEntity.RPCMessage msg) { }

	public override bool DisplayHealthInfo(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xC52D0 Offset: 0xC46D0 VA: 0x1800C52D0
	[BaseEntity.Menu.Description] // RVA: 0xC52D0 Offset: 0xC46D0 VA: 0x1800C52D0
	[BaseEntity.Menu.Icon] // RVA: 0xC52D0 Offset: 0xC46D0 VA: 0x1800C52D0
	[BaseEntity.Menu.ShowIf] // RVA: 0xC52D0 Offset: 0xC46D0 VA: 0x1800C52D0
	public void Menu_TooHeavy(BasePlayer player) { }

	public bool Menu_TooHeavy_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xC5550 Offset: 0xC4950 VA: 0x1800C5550
	[BaseEntity.Menu.Description] // RVA: 0xC5550 Offset: 0xC4950 VA: 0x1800C5550
	[BaseEntity.Menu.Icon] // RVA: 0xC5550 Offset: 0xC4950 VA: 0x1800C5550
	[BaseEntity.Menu.ShowIf] // RVA: 0xC5550 Offset: 0xC4950 VA: 0x1800C5550
	public void Menu_Ride(BasePlayer player) { }

	public bool Menu_Ride_ShowIf(BasePlayer player) { }

	private bool CanPlayerSeeSaddlePoint(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xC5870 Offset: 0xC4C70 VA: 0x1800C5870
	[BaseEntity.Menu.Description] // RVA: 0xC5870 Offset: 0xC4C70 VA: 0x1800C5870
	[BaseEntity.Menu.Icon] // RVA: 0xC5870 Offset: 0xC4C70 VA: 0x1800C5870
	[BaseEntity.Menu.ShowIf] // RVA: 0xC5870 Offset: 0xC4C70 VA: 0x1800C5870
	public void Menu_Lead(BasePlayer player) { }

	public bool Menu_Lead_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xC5B20 Offset: 0xC4F20 VA: 0x1800C5B20
	[BaseEntity.Menu.Description] // RVA: 0xC5B20 Offset: 0xC4F20 VA: 0x1800C5B20
	[BaseEntity.Menu.Icon] // RVA: 0xC5B20 Offset: 0xC4F20 VA: 0x1800C5B20
	[BaseEntity.Menu.ShowIf] // RVA: 0xC5B20 Offset: 0xC4F20 VA: 0x1800C5B20
	public void Menu_StopLead(BasePlayer player) { }

	public bool Menu_StopLead_ShowIf(BasePlayer player) { }

	public virtual bool RideMenuVisible() { }

	public override bool MountMenuVisible(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xC5D80 Offset: 0xC5180 VA: 0x1800C5D80
	[BaseEntity.Menu.Description] // RVA: 0xC5D80 Offset: 0xC5180 VA: 0x1800C5D80
	[BaseEntity.Menu.Icon] // RVA: 0xC5D80 Offset: 0xC5180 VA: 0x1800C5D80
	[BaseEntity.Menu.ShowIf] // RVA: 0xC5D80 Offset: 0xC5180 VA: 0x1800C5D80
	public void Menu_Claim(BasePlayer player) { }

	public bool Menu_Claim_ShowIf(BasePlayer player) { }

	public bool PlayerHasToken(BasePlayer player) { }

	public Item GetPurchaseToken(BasePlayer player) { }

	public virtual float GetWalkSpeed() { }

	public virtual float GetTrotSpeed() { }

	public virtual float GetRunSpeed() { }

	public bool IsPlayerTooHeavy(BasePlayer player) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public enum BaseRidableAnimal.RunState // TypeDefIndex: 8348
{	public int value__; // 0x0
	public const BaseRidableAnimal.RunState stopped = 1;
	public const BaseRidableAnimal.RunState walk = 2;
	public const BaseRidableAnimal.RunState run = 3;
	public const BaseRidableAnimal.RunState sprint = 4;
	public const BaseRidableAnimal.RunState LAST = 5;

}

