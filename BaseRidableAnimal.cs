public class BaseRidableAnimal : BaseVehicle // TypeDefIndex: 8347
{	// Fields
	private Option __menuOption_Menu_Claim; // 0x3B8
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

	// Properties
	public override bool HasMenuOptions { get; }
	public override bool IsNpc { get; }

	// Methods

	// RVA: 0x907BF0 Offset: 0x906FF0 VA: 0x180907BF0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x90A3A0 Offset: 0x9097A0 VA: 0x18090A3A0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x909230 Offset: 0x908630 VA: 0x180909230 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x593220 Offset: 0x592620 VA: 0x180593220
	public bool IsForSale() { }

	// RVA: 0x907720 Offset: 0x906B20 VA: 0x180907720 Slot: 194
	public virtual bool CanOpenStorage(BasePlayer player) { }

	// RVA: 0x908AC0 Offset: 0x907EC0 VA: 0x180908AC0
	public void LoadContainer(BaseNetworkable.LoadInfo info) { }

	[BaseEntity.Menu] // RVA: 0xC4F40 Offset: 0xC4340 VA: 0x1800C4F40
	[BaseEntity.Menu.Description] // RVA: 0xC4F40 Offset: 0xC4340 VA: 0x1800C4F40
	[BaseEntity.Menu.Icon] // RVA: 0xC4F40 Offset: 0xC4340 VA: 0x1800C4F40
	[BaseEntity.Menu.ShowIf] // RVA: 0xC4F40 Offset: 0xC4340 VA: 0x1800C4F40
	// RVA: 0x908FF0 Offset: 0x9083F0 VA: 0x180908FF0
	public void Menu_Open(BasePlayer player) { }

	// RVA: 0x908ED0 Offset: 0x9082D0 VA: 0x180908ED0
	public bool Menu_Open_ShowIf(BasePlayer player) { }

	// RVA: 0x909C90 Offset: 0x909090 VA: 0x180909C90 Slot: 195
	public virtual bool ShouldShowLootMenus() { }

	// RVA: 0x907BB0 Offset: 0x906FB0 VA: 0x180907BB0
	public float GetBreathingDelay() { }

	// RVA: 0x8BE280 Offset: 0x8BD680 VA: 0x1808BE280
	public bool IsLeading() { }

	// RVA: 0x909DE0 Offset: 0x9091E0 VA: 0x180909DE0
	public static float UnitsToKPH(float unitsPerSecond) { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 98
	public override bool get_IsNpc() { }

	// RVA: 0x908BB0 Offset: 0x907FB0 VA: 0x180908BB0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x909E00 Offset: 0x909200 VA: 0x180909E00
	public void UpdateBreathingRate() { }

	// RVA: 0x909AB0 Offset: 0x908EB0 VA: 0x180909AB0 Slot: 16
	public override void PostNetworkUpdate() { }

	// RVA: 0x909D20 Offset: 0x909120 VA: 0x180909D20
	public void SprintSoundPlay() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x909D50 Offset: 0x909150 VA: 0x180909D50
	public void Stand(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x907B30 Offset: 0x906F30 VA: 0x180907B30
	public void Eat(BaseEntity.RPCMessage msg) { }

	// RVA: 0x9079F0 Offset: 0x906DF0 VA: 0x1809079F0 Slot: 131
	public override bool DisplayHealthInfo(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xC52D0 Offset: 0xC46D0 VA: 0x1800C52D0
	[BaseEntity.Menu.Description] // RVA: 0xC52D0 Offset: 0xC46D0 VA: 0x1800C52D0
	[BaseEntity.Menu.Icon] // RVA: 0xC52D0 Offset: 0xC46D0 VA: 0x1800C52D0
	[BaseEntity.Menu.ShowIf] // RVA: 0xC52D0 Offset: 0xC46D0 VA: 0x1800C52D0
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public void Menu_TooHeavy(BasePlayer player) { }

	// RVA: 0x908A90 Offset: 0x907E90 VA: 0x180908A90
	public bool Menu_TooHeavy_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xC5550 Offset: 0xC4950 VA: 0x1800C5550
	[BaseEntity.Menu.Description] // RVA: 0xC5550 Offset: 0xC4950 VA: 0x1800C5550
	[BaseEntity.Menu.Icon] // RVA: 0xC5550 Offset: 0xC4950 VA: 0x1800C5550
	[BaseEntity.Menu.ShowIf] // RVA: 0xC5550 Offset: 0xC4950 VA: 0x1800C5550
	// RVA: 0x909100 Offset: 0x908500 VA: 0x180909100
	public void Menu_Ride(BasePlayer player) { }

	// RVA: 0x909030 Offset: 0x908430 VA: 0x180909030
	public bool Menu_Ride_ShowIf(BasePlayer player) { }

	// RVA: 0x907780 Offset: 0x906B80 VA: 0x180907780
	private bool CanPlayerSeeSaddlePoint(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xC5870 Offset: 0xC4C70 VA: 0x1800C5870
	[BaseEntity.Menu.Description] // RVA: 0xC5870 Offset: 0xC4C70 VA: 0x1800C5870
	[BaseEntity.Menu.Icon] // RVA: 0xC5870 Offset: 0xC4C70 VA: 0x1800C5870
	[BaseEntity.Menu.ShowIf] // RVA: 0xC5870 Offset: 0xC4C70 VA: 0x1800C5870
	// RVA: 0x908E80 Offset: 0x908280 VA: 0x180908E80
	public void Menu_Lead(BasePlayer player) { }

	// RVA: 0x908DE0 Offset: 0x9081E0 VA: 0x180908DE0
	public bool Menu_Lead_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xC5B20 Offset: 0xC4F20 VA: 0x1800C5B20
	[BaseEntity.Menu.Description] // RVA: 0xC5B20 Offset: 0xC4F20 VA: 0x1800C5B20
	[BaseEntity.Menu.Icon] // RVA: 0xC5B20 Offset: 0xC4F20 VA: 0x1800C5B20
	[BaseEntity.Menu.ShowIf] // RVA: 0xC5B20 Offset: 0xC4F20 VA: 0x1800C5B20
	// RVA: 0x9091E0 Offset: 0x9085E0 VA: 0x1809091E0
	public void Menu_StopLead(BasePlayer player) { }

	// RVA: 0x909140 Offset: 0x908540 VA: 0x180909140
	public bool Menu_StopLead_ShowIf(BasePlayer player) { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 196
	public virtual bool RideMenuVisible() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 184
	public override bool MountMenuVisible(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xC5D80 Offset: 0xC5180 VA: 0x1800C5D80
	[BaseEntity.Menu.Description] // RVA: 0xC5D80 Offset: 0xC5180 VA: 0x1800C5D80
	[BaseEntity.Menu.Icon] // RVA: 0xC5D80 Offset: 0xC5180 VA: 0x1800C5D80
	[BaseEntity.Menu.ShowIf] // RVA: 0xC5D80 Offset: 0xC5180 VA: 0x1800C5D80
	// RVA: 0x908DA0 Offset: 0x9081A0 VA: 0x180908DA0
	public void Menu_Claim(BasePlayer player) { }

	// RVA: 0x908CC0 Offset: 0x9080C0 VA: 0x180908CC0
	public bool Menu_Claim_ShowIf(BasePlayer player) { }

	// RVA: 0x909A70 Offset: 0x908E70 VA: 0x180909A70
	public bool PlayerHasToken(BasePlayer player) { }

	// RVA: 0x908A20 Offset: 0x907E20 VA: 0x180908A20
	public Item GetPurchaseToken(BasePlayer player) { }

	// RVA: 0x908A80 Offset: 0x907E80 VA: 0x180908A80 Slot: 197
	public virtual float GetWalkSpeed() { }

	// RVA: 0x908A70 Offset: 0x907E70 VA: 0x180908A70 Slot: 198
	public virtual float GetTrotSpeed() { }

	// RVA: 0x908A60 Offset: 0x907E60 VA: 0x180908A60 Slot: 199
	public virtual float GetRunSpeed() { }

	// RVA: 0x908A90 Offset: 0x907E90 VA: 0x180908A90
	public bool IsPlayerTooHeavy(BasePlayer player) { }

	// RVA: 0x909FB0 Offset: 0x9093B0 VA: 0x180909FB0
	public void .ctor() { }

	// RVA: 0x909F70 Offset: 0x909370 VA: 0x180909F70
	private static void .cctor() { }

}

public enum BaseRidableAnimal.RunState // TypeDefIndex: 8348
{	// Fields
	public int value__; // 0x0
	public const BaseRidableAnimal.RunState stopped = 1;
	public const BaseRidableAnimal.RunState walk = 2;
	public const BaseRidableAnimal.RunState run = 3;
	public const BaseRidableAnimal.RunState sprint = 4;
	public const BaseRidableAnimal.RunState LAST = 5;

}

