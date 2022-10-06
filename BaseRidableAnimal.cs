public class BaseRidableAnimal : BaseVehicle // TypeDefIndex: 10052
{
	private Option __menuOption_Menu_Claim; 
	private Option __menuOption_Menu_Lead; 
	private Option __menuOption_Menu_Open; 
	private Option __menuOption_Menu_Ride; 
	private Option __menuOption_Menu_StopLead; 
	private Option __menuOption_Menu_TooHeavy; 
	public ItemDefinition onlyAllowedItem; 
	public ItemContainer.ContentsType allowedContents; 
	public int maxStackSize; 
	public int numSlots; 
	public string lootPanelName; 
	public bool needsBuildingPrivilegeToUse; 
	public bool isLootable; 
	public ItemContainer inventory; 
	public const BaseEntity.Flags Flag_ForSale = 256;
	private Vector3 lastMoveDirection; 
	public GameObjectRef saddlePrefab; 
	public EntityRef saddleRef; 
	public Transform movementLOSOrigin; 
	public SoundPlayer sprintSounds; 
	public SoundPlayer largeWhinny; 
	public const BaseEntity.Flags Flag_Lead = 32768;
	public const BaseEntity.Flags Flag_HasRider = 2;
	[HeaderAttribute] 
	public ItemDefinition purchaseToken; 
	public GameObjectRef eatEffect; 
	public GameObjectRef CorpsePrefab; 
	[HeaderAttribute] 
	public Transform animalFront; 
	public float obstacleDetectionRadius; 
	public float maxWaterDepth; 
	public float roadSpeedBonus; 
	public float maxWallClimbSlope; 
	public float maxStepHeight; 
	public float maxStepDownHeight; 
	[HeaderAttribute] 
	public BaseRidableAnimal.RunState currentRunState; 
	public float walkSpeed; 
	public float trotSpeed; 
	public float runSpeed; 
	public float turnSpeed; 
	public float maxSpeed; 
	public Transform[] groundSampleOffsets; 
	[HeaderAttribute] 
	public float staminaSeconds; 
	public float currentMaxStaminaSeconds; 
	public float maxStaminaSeconds; 
	public float staminaCoreLossRatio; 
	public float staminaCoreSpeedBonus; 
	public float staminaReplenishRatioMoving; 
	public float staminaReplenishRatioStanding; 
	public float calorieToStaminaRatio; 
	public float hydrationToStaminaRatio; 
	public float maxStaminaCoreFromWater; 
	public bool debugMovement; 
	private const float normalOffsetDist = 0,15;
	private Vector3[] normalOffsets; 
	[ServerVar] 
	public static float decayminutes; 
	public float currentSpeed; 
	public float desiredRotation; 
	public float animalPitchClamp; 
	public float animalRollClamp; 
	private float lastBreathingRate; 
	private float nextTokenCheckTime; 
	private bool lastTokenCheckResult; 

	public override bool HasMenuOptions { get; }
	public override bool IsNpc { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public bool IsForSale() { }

	public virtual bool CanOpenStorage(BasePlayer player) { }

	public void LoadContainer(BaseNetworkable.LoadInfo info) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
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

	[BaseEntity.RPC_Client] 
	public void Stand(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] 
	public void Eat(BaseEntity.RPCMessage msg) { }

	public override bool DisplayHealthInfo(BasePlayer player) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_TooHeavy(BasePlayer player) { }

	public bool Menu_TooHeavy_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_Ride(BasePlayer player) { }

	public bool Menu_Ride_ShowIf(BasePlayer player) { }

	private bool CanPlayerSeeSaddlePoint(BasePlayer player) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_Lead(BasePlayer player) { }

	public bool Menu_Lead_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_StopLead(BasePlayer player) { }

	public bool Menu_StopLead_ShowIf(BasePlayer player) { }

	public virtual bool RideMenuVisible() { }

	public override bool MountMenuVisible(BasePlayer player) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
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

public enum BaseRidableAnimal.RunState // TypeDefIndex: 10053
{
	public int value__; 
	public const BaseRidableAnimal.RunState stopped = 1;
	public const BaseRidableAnimal.RunState walk = 2;
	public const BaseRidableAnimal.RunState run = 3;
	public const BaseRidableAnimal.RunState sprint = 4;
	public const BaseRidableAnimal.RunState LAST = 5;

}

