public class Elevator : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6387
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int floor; // 0x14


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

public class ElevatorLift : BaseCombatEntity // TypeDefIndex: 8387
{	private Option __menuOption_Menu_LowerElevator; // 0x240
	private Option __menuOption_Menu_LowerElevatorToFloor; // 0x298
	private Option __menuOption_Menu_RaiseElevator; // 0x2F0
	private Option __menuOption_Menu_RaiseElevatorToTop; // 0x348
	public GameObject DescendingHurtTrigger; // 0x3A0
	public GameObject MovementCollider; // 0x3A8
	public Transform UpButtonPoint; // 0x3B0
	public Transform DownButtonPoint; // 0x3B8
	public TriggerNotify VehicleTrigger; // 0x3C0
	public GameObjectRef LiftArrivalScreenBounce; // 0x3C8
	public SoundDefinition liftMovementLoopDef; // 0x3D0
	public SoundDefinition liftMovementStartDef; // 0x3D8
	public SoundDefinition liftMovementStopDef; // 0x3E0
	public SoundDefinition liftMovementAccentSoundDef; // 0x3E8
	public GameObjectRef liftButtonPressedEffect; // 0x3F0
	public float movementAccentMinInterval; // 0x3F8
	public float movementAccentMaxInterval; // 0x3FC
	private Sound liftMovementLoopSound; // 0x400
	private float nextMovementAccent; // 0x408
	private const BaseEntity.Flags PressedUp = 128;
	private const BaseEntity.Flags PressedDown = 256;

	public override bool HasMenuOptions { get; }
	private Elevator owner { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	private Elevator get_owner() { }

	[BaseEntity.Menu] // RVA: 0xDAFB0 Offset: 0xDA3B0 VA: 0x1800DAFB0
	[BaseEntity.Menu.Description] // RVA: 0xDAFB0 Offset: 0xDA3B0 VA: 0x1800DAFB0
	[BaseEntity.Menu.Icon] // RVA: 0xDAFB0 Offset: 0xDA3B0 VA: 0x1800DAFB0
	[BaseEntity.Menu.ShowIf] // RVA: 0xDAFB0 Offset: 0xDA3B0 VA: 0x1800DAFB0
	public void Menu_RaiseElevator(BasePlayer p) { }

	protected bool Menu_RaiseElevator_ShowIf(BasePlayer p) { }

	protected virtual bool Menu_RaiseElevator_ShowIf_Base(BasePlayer p) { }

	[BaseEntity.Menu] // RVA: 0xDB330 Offset: 0xDA730 VA: 0x1800DB330
	[BaseEntity.Menu.Description] // RVA: 0xDB330 Offset: 0xDA730 VA: 0x1800DB330
	[BaseEntity.Menu.Icon] // RVA: 0xDB330 Offset: 0xDA730 VA: 0x1800DB330
	[BaseEntity.Menu.ShowIf] // RVA: 0xDB330 Offset: 0xDA730 VA: 0x1800DB330
	public void Menu_RaiseElevatorToTop(BasePlayer p) { }

	[BaseEntity.Menu] // RVA: 0xDB6D0 Offset: 0xDAAD0 VA: 0x1800DB6D0
	[BaseEntity.Menu.Description] // RVA: 0xDB6D0 Offset: 0xDAAD0 VA: 0x1800DB6D0
	[BaseEntity.Menu.Icon] // RVA: 0xDB6D0 Offset: 0xDAAD0 VA: 0x1800DB6D0
	[BaseEntity.Menu.ShowIf] // RVA: 0xDB6D0 Offset: 0xDAAD0 VA: 0x1800DB6D0
	public void Menu_LowerElevator(BasePlayer p) { }

	protected bool Menu_LowerElevator_ShowIf(BasePlayer p) { }

	protected virtual bool Menu_LowerElevator_ShowIf_Base(BasePlayer p) { }

	[BaseEntity.Menu] // RVA: 0xDBBD0 Offset: 0xDAFD0 VA: 0x1800DBBD0
	[BaseEntity.Menu.Description] // RVA: 0xDBBD0 Offset: 0xDAFD0 VA: 0x1800DBBD0
	[BaseEntity.Menu.Icon] // RVA: 0xDBBD0 Offset: 0xDAFD0 VA: 0x1800DBBD0
	[BaseEntity.Menu.ShowIf] // RVA: 0xDBBD0 Offset: 0xDAFD0 VA: 0x1800DBBD0
	public void Menu_LowerElevatorToFloor(BasePlayer p) { }

	protected bool GetLookingAtButton(BasePlayer p, out Elevator.Direction d) { }

	public void PlayLiftArrivalEffect() { }

	public void StartMovementSounds() { }

	public void UpdateMovementSounds() { }

	public void StopMovementSounds() { }

	public void ToggleMovementCollider(bool state) { }

	public void .ctor() { }

}

public class ElevatorLiftStatic : ElevatorLift // TypeDefIndex: 8388
{	private Option __menuOption_Menu_LowerElevatorToFloor; // 0x410
	private Option __menuOption_Menu_RaiseElevatorToTop; // 0x468

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	[BaseEntity.Menu] // RVA: 0xDBE00 Offset: 0xDB200 VA: 0x1800DBE00
	[BaseEntity.Menu.Description] // RVA: 0xDBE00 Offset: 0xDB200 VA: 0x1800DBE00
	[BaseEntity.Menu.Icon] // RVA: 0xDBE00 Offset: 0xDB200 VA: 0x1800DBE00
	[BaseEntity.Menu.ShowIf] // RVA: 0xDBE00 Offset: 0xDB200 VA: 0x1800DBE00
	public void Menu_RaiseElevatorToTop(BasePlayer p) { }

	[BaseEntity.Menu] // RVA: 0xDC090 Offset: 0xDB490 VA: 0x1800DC090
	[BaseEntity.Menu.Description] // RVA: 0xDC090 Offset: 0xDB490 VA: 0x1800DC090
	[BaseEntity.Menu.Icon] // RVA: 0xDC090 Offset: 0xDB490 VA: 0x1800DC090
	[BaseEntity.Menu.ShowIf] // RVA: 0xDC090 Offset: 0xDB490 VA: 0x1800DC090
	public void Menu_LowerElevatorToFloor(BasePlayer p) { }

	protected override bool Menu_RaiseElevator_ShowIf_Base(BasePlayer p) { }

	protected override bool Menu_LowerElevator_ShowIf_Base(BasePlayer p) { }

	public void .ctor() { }

}

public class Elevator : IOEntity, IFlagNotify // TypeDefIndex: 8692
{	public Transform LiftRoot; // 0x288
	public GameObjectRef LiftEntityPrefab; // 0x290
	public GameObjectRef IoEntityPrefab; // 0x298
	public Transform IoEntitySpawnPoint; // 0x2A0
	public GameObject FloorBlockerVolume; // 0x2A8
	public float LiftSpeedPerMetre; // 0x2B0
	public GameObject[] PoweredObjects; // 0x2B8
	public MeshRenderer PoweredMesh; // 0x2C0
	[ColorUsageAttribute] // RVA: 0x859B0 Offset: 0x84DB0 VA: 0x1800859B0
	public Color PoweredLightColour; // 0x2C8
	[ColorUsageAttribute] // RVA: 0x859B0 Offset: 0x84DB0 VA: 0x1800859B0
	public Color UnpoweredLightColour; // 0x2D8
	public SkinnedMeshRenderer[] CableRenderers; // 0x2E8
	public LODGroup CableLod; // 0x2F0
	public Transform CableRoot; // 0x2F8
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <Floor>k__BackingField; // 0x300
	protected const BaseEntity.Flags TopFloorFlag = 128;
	public const BaseEntity.Flags ElevatorPowered = 256;
	private ElevatorLift liftEntity; // 0x308

	protected virtual bool IsStatic { get; }
	public int Floor { get; set; }
	protected bool IsTop { get; }


	protected virtual bool get_IsStatic() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public int get_Floor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
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

public enum Elevator.Direction // TypeDefIndex: 8693
{	public int value__; // 0x0
	public const Elevator.Direction Up = 0;
	public const Elevator.Direction Down = 1;

}

public class ElevatorStatic : Elevator // TypeDefIndex: 8694
{	public bool StaticTop; // 0x310
	private const BaseEntity.Flags LiftRecentlyArrived = 512;

	protected override bool IsStatic { get; }


	protected override bool get_IsStatic() { }

	public void .ctor() { }

}

public class ElevatorIOEntity : IOEntity // TypeDefIndex: 9799
{	public int Consumption; // 0x288


	public override int ConsumptionAmount() { }

	public void .ctor() { }

}

