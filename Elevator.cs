public class Elevator : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6391
{
	public bool ShouldPool; 
	private bool _disposed; 
	public int floor; 


	public static void ResetToPool(Elevator instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(Elevator instance) { }

	public Elevator Copy() { }

	public static Elevator Deserialize(Stream stream) { }

	public static Elevator DeserializeLengthDelimited(Stream stream) { }

	public static Elevator DeserializeLength(Stream stream, int length) { }

	public static Elevator Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, Elevator previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static Elevator Deserialize(byte[] buffer, Elevator instance, bool isDelta = False) { }

	public static Elevator Deserialize(Stream stream, Elevator instance, bool isDelta) { }

	public static Elevator DeserializeLengthDelimited(Stream stream, Elevator instance, bool isDelta) { }

	public static Elevator DeserializeLength(Stream stream, int length, Elevator instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, Elevator instance, Elevator previous) { }

	public static void Serialize(Stream stream, Elevator instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(Elevator instance) { }

	public static void SerializeLengthDelimited(Stream stream, Elevator instance) { }

	public void .ctor() { }

}

public class ElevatorLift : BaseCombatEntity // TypeDefIndex: 10093
{
	private Option __menuOption_Menu_LowerElevator; 
	private Option __menuOption_Menu_LowerElevatorToFloor; 
	private Option __menuOption_Menu_RaiseElevator; 
	private Option __menuOption_Menu_RaiseElevatorToTop; 
	public GameObject DescendingHurtTrigger; 
	public GameObject MovementCollider; 
	public Transform UpButtonPoint; 
	public Transform DownButtonPoint; 
	public TriggerNotify VehicleTrigger; 
	public GameObjectRef LiftArrivalScreenBounce; 
	public SoundDefinition liftMovementLoopDef; 
	public SoundDefinition liftMovementStartDef; 
	public SoundDefinition liftMovementStopDef; 
	public SoundDefinition liftMovementAccentSoundDef; 
	public GameObjectRef liftButtonPressedEffect; 
	public float movementAccentMinInterval; 
	public float movementAccentMaxInterval; 
	private Sound liftMovementLoopSound; 
	private float nextMovementAccent; 
	private const BaseEntity.Flags PressedUp = 128;
	private const BaseEntity.Flags PressedDown = 256;

	public override bool HasMenuOptions { get; }
	private Elevator owner { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	private Elevator get_owner() { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_RaiseElevator(BasePlayer p) { }

	protected bool Menu_RaiseElevator_ShowIf(BasePlayer p) { }

	protected virtual bool Menu_RaiseElevator_ShowIf_Base(BasePlayer p) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_RaiseElevatorToTop(BasePlayer p) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_LowerElevator(BasePlayer p) { }

	protected bool Menu_LowerElevator_ShowIf(BasePlayer p) { }

	protected virtual bool Menu_LowerElevator_ShowIf_Base(BasePlayer p) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_LowerElevatorToFloor(BasePlayer p) { }

	protected bool GetLookingAtButton(BasePlayer p, out Elevator.Direction d) { }

	public void PlayLiftArrivalEffect() { }

	public void StartMovementSounds() { }

	public void UpdateMovementSounds() { }

	public void StopMovementSounds() { }

	public void ToggleMovementCollider(bool state) { }

	public void .ctor() { }

}

public class ElevatorLiftStatic : ElevatorLift // TypeDefIndex: 10094
{
	private Option __menuOption_Menu_LowerElevatorToFloor; 
	private Option __menuOption_Menu_RaiseElevatorToTop; 

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_RaiseElevatorToTop(BasePlayer p) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_LowerElevatorToFloor(BasePlayer p) { }

	protected override bool Menu_RaiseElevator_ShowIf_Base(BasePlayer p) { }

	protected override bool Menu_LowerElevator_ShowIf_Base(BasePlayer p) { }

	public void .ctor() { }

}

public class Elevator : IOEntity, IFlagNotify // TypeDefIndex: 10402
{
	public Transform LiftRoot; 
	public GameObjectRef LiftEntityPrefab; 
	public GameObjectRef IoEntityPrefab; 
	public Transform IoEntitySpawnPoint; 
	public GameObject FloorBlockerVolume; 
	public float LiftSpeedPerMetre; 
	public GameObject[] PoweredObjects; 
	public MeshRenderer PoweredMesh; 
	[ColorUsageAttribute] 
	public Color PoweredLightColour; 
	[ColorUsageAttribute] 
	public Color UnpoweredLightColour; 
	public SkinnedMeshRenderer[] CableRenderers; 
	public LODGroup CableLod; 
	public Transform CableRoot; 
	[CompilerGeneratedAttribute] 
	private int <Floor>k__BackingField; 
	protected const BaseEntity.Flags TopFloorFlag = 128;
	public const BaseEntity.Flags ElevatorPowered = 256;
	private ElevatorLift liftEntity; 

	protected virtual bool IsStatic { get; }
	public int Floor { get; set; }
	protected bool IsTop { get; }


	protected virtual bool get_IsStatic() { }

	[CompilerGeneratedAttribute] 
	public int get_Floor() { }

	[CompilerGeneratedAttribute] 
	public void set_Floor(int value) { }

	protected bool get_IsTop() { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	private void UpdateCable() { }

	private void SetCableBounds(float height) { }

	private void DisableUpdate() { }

	public override void ClientOnEnable() { }

	protected override void SpawnGibs() { }

	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	private void FindExistingLiftChild() { }

	public void OnFlagToggled(bool state) { }

	public void .ctor() { }

}

public enum Elevator.Direction // TypeDefIndex: 10403
{
	public int value__; 
	public const Elevator.Direction Up = 0;
	public const Elevator.Direction Down = 1;

}

public class ElevatorStatic : Elevator // TypeDefIndex: 10404
{
	public bool StaticTop; 
	private const BaseEntity.Flags LiftRecentlyArrived = 512;

	protected override bool IsStatic { get; }


	protected override bool get_IsStatic() { }

	public void .ctor() { }

}

public class ElevatorIOEntity : IOEntity // TypeDefIndex: 11519
{
	public int Consumption; 


	public override int ConsumptionAmount() { }

	public void .ctor() { }

}

