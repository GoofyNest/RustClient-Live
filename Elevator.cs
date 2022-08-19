public class Elevator : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6387
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int floor; // 0x14

	// Methods

	// RVA: 0x1E6E220 Offset: 0x1E6D620 VA: 0x181E6E220
	public static void ResetToPool(Elevator instance) { }

	// RVA: 0x1E6E2A0 Offset: 0x1E6D6A0 VA: 0x181E6E2A0
	public void ResetToPool() { }

	// RVA: 0x1E6E0F0 Offset: 0x1E6D4F0 VA: 0x181E6E0F0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BF9250 Offset: 0x1BF8650 VA: 0x181BF9250
	public void CopyTo(Elevator instance) { }

	// RVA: 0x1E6D770 Offset: 0x1E6CB70 VA: 0x181E6D770
	public Elevator Copy() { }

	// RVA: 0x1E6DD10 Offset: 0x1E6D110 VA: 0x181E6DD10
	public static Elevator Deserialize(Stream stream) { }

	// RVA: 0x1E6DA00 Offset: 0x1E6CE00 VA: 0x181E6DA00
	public static Elevator DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E6DC80 Offset: 0x1E6D080 VA: 0x181E6DC80
	public static Elevator DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E6DD90 Offset: 0x1E6D190 VA: 0x181E6DD90
	public static Elevator Deserialize(byte[] buffer) { }

	// RVA: 0x1E6E1E0 Offset: 0x1E6D5E0 VA: 0x181E6E1E0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E6E770 Offset: 0x1E6DB70 VA: 0x181E6E770 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E6E840 Offset: 0x1E6DC40 VA: 0x181E6E840 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Elevator previous) { }

	// RVA: 0x1E6E200 Offset: 0x1E6D600 VA: 0x181E6E200 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E6DEB0 Offset: 0x1E6D2B0 VA: 0x181E6DEB0
	public static Elevator Deserialize(byte[] buffer, Elevator instance, bool isDelta = False) { }

	// RVA: 0x1E6DFB0 Offset: 0x1E6D3B0 VA: 0x181E6DFB0
	public static Elevator Deserialize(Stream stream, Elevator instance, bool isDelta) { }

	// RVA: 0x1E6D7E0 Offset: 0x1E6CBE0 VA: 0x181E6D7E0
	public static Elevator DeserializeLengthDelimited(Stream stream, Elevator instance, bool isDelta) { }

	// RVA: 0x1E6DA80 Offset: 0x1E6CE80 VA: 0x181E6DA80
	public static Elevator DeserializeLength(Stream stream, int length, Elevator instance, bool isDelta) { }

	// RVA: 0x1E6E320 Offset: 0x1E6D720 VA: 0x181E6E320
	public static void SerializeDelta(Stream stream, Elevator instance, Elevator previous) { }

	// RVA: 0x1E6E690 Offset: 0x1E6DA90 VA: 0x181E6E690
	public static void Serialize(Stream stream, Elevator instance) { }

	// RVA: 0x1E6E760 Offset: 0x1E6DB60 VA: 0x181E6E760
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E6E770 Offset: 0x1E6DB70 VA: 0x181E6E770
	public void ToProto(Stream stream) { }

	// RVA: 0x1E6E4E0 Offset: 0x1E6D8E0 VA: 0x181E6E4E0
	public static byte[] SerializeToBytes(Elevator instance) { }

	// RVA: 0x1E6E430 Offset: 0x1E6D830 VA: 0x181E6E430
	public static void SerializeLengthDelimited(Stream stream, Elevator instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class ElevatorLift : BaseCombatEntity // TypeDefIndex: 8387
{	// Fields
	private Option __menuOption_Menu_LowerElevator; // 0x240
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

	// Properties
	public override bool HasMenuOptions { get; }
	private Elevator owner { get; }

	// Methods

	// RVA: 0xABDDB0 Offset: 0xABD1B0 VA: 0x180ABDDB0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0xABF2E0 Offset: 0xABE6E0 VA: 0x180ABF2E0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0xABEA00 Offset: 0xABDE00 VA: 0x180ABEA00 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0xABF4B0 Offset: 0xABE8B0 VA: 0x180ABF4B0
	private Elevator get_owner() { }

	[BaseEntity.Menu] // RVA: 0xDAFB0 Offset: 0xDA3B0 VA: 0x1800DAFB0
	[BaseEntity.Menu.Description] // RVA: 0xDAFB0 Offset: 0xDA3B0 VA: 0x1800DAFB0
	[BaseEntity.Menu.Icon] // RVA: 0xDAFB0 Offset: 0xDA3B0 VA: 0x1800DAFB0
	[BaseEntity.Menu.ShowIf] // RVA: 0xDAFB0 Offset: 0xDA3B0 VA: 0x1800DAFB0
	// RVA: 0xABE9B0 Offset: 0xABDDB0 VA: 0x180ABE9B0
	public void Menu_RaiseElevator(BasePlayer p) { }

	// RVA: 0xABE910 Offset: 0xABDD10 VA: 0x180ABE910
	protected bool Menu_RaiseElevator_ShowIf(BasePlayer p) { }

	// RVA: 0xABE900 Offset: 0xABDD00 VA: 0x180ABE900 Slot: 145
	protected virtual bool Menu_RaiseElevator_ShowIf_Base(BasePlayer p) { }

	[BaseEntity.Menu] // RVA: 0xDB330 Offset: 0xDA730 VA: 0x1800DB330
	[BaseEntity.Menu.Description] // RVA: 0xDB330 Offset: 0xDA730 VA: 0x1800DB330
	[BaseEntity.Menu.Icon] // RVA: 0xDB330 Offset: 0xDA730 VA: 0x1800DB330
	[BaseEntity.Menu.ShowIf] // RVA: 0xDB330 Offset: 0xDA730 VA: 0x1800DB330
	// RVA: 0xABE8B0 Offset: 0xABDCB0 VA: 0x180ABE8B0
	public void Menu_RaiseElevatorToTop(BasePlayer p) { }

	[BaseEntity.Menu] // RVA: 0xDB6D0 Offset: 0xDAAD0 VA: 0x1800DB6D0
	[BaseEntity.Menu.Description] // RVA: 0xDB6D0 Offset: 0xDAAD0 VA: 0x1800DB6D0
	[BaseEntity.Menu.Icon] // RVA: 0xDB6D0 Offset: 0xDAAD0 VA: 0x1800DB6D0
	[BaseEntity.Menu.ShowIf] // RVA: 0xDB6D0 Offset: 0xDAAD0 VA: 0x1800DB6D0
	// RVA: 0xABE860 Offset: 0xABDC60 VA: 0x180ABE860
	public void Menu_LowerElevator(BasePlayer p) { }

	// RVA: 0xABE7C0 Offset: 0xABDBC0 VA: 0x180ABE7C0
	protected bool Menu_LowerElevator_ShowIf(BasePlayer p) { }

	// RVA: 0xABE7B0 Offset: 0xABDBB0 VA: 0x180ABE7B0 Slot: 146
	protected virtual bool Menu_LowerElevator_ShowIf_Base(BasePlayer p) { }

	[BaseEntity.Menu] // RVA: 0xDBBD0 Offset: 0xDAFD0 VA: 0x1800DBBD0
	[BaseEntity.Menu.Description] // RVA: 0xDBBD0 Offset: 0xDAFD0 VA: 0x1800DBBD0
	[BaseEntity.Menu.Icon] // RVA: 0xDBBD0 Offset: 0xDAFD0 VA: 0x1800DBBD0
	[BaseEntity.Menu.ShowIf] // RVA: 0xDBBD0 Offset: 0xDAFD0 VA: 0x1800DBBD0
	// RVA: 0xABE760 Offset: 0xABDB60 VA: 0x180ABE760
	public void Menu_LowerElevatorToFloor(BasePlayer p) { }

	// RVA: 0xABDC20 Offset: 0xABD020 VA: 0x180ABDC20
	protected bool GetLookingAtButton(BasePlayer p, out Elevator.Direction d) { }

	// RVA: 0xABEAF0 Offset: 0xABDEF0 VA: 0x180ABEAF0
	public void PlayLiftArrivalEffect() { }

	// RVA: 0xABEDA0 Offset: 0xABE1A0 VA: 0x180ABEDA0
	public void StartMovementSounds() { }

	// RVA: 0xABF100 Offset: 0xABE500 VA: 0x180ABF100
	public void UpdateMovementSounds() { }

	// RVA: 0xABEF40 Offset: 0xABE340 VA: 0x180ABEF40
	public void StopMovementSounds() { }

	// RVA: 0xABF060 Offset: 0xABE460 VA: 0x180ABF060
	public void ToggleMovementCollider(bool state) { }

	// RVA: 0xABDAB0 Offset: 0xABCEB0 VA: 0x180ABDAB0
	public void .ctor() { }

}

public class ElevatorLiftStatic : ElevatorLift // TypeDefIndex: 8388
{	// Fields
	private Option __menuOption_Menu_LowerElevatorToFloor; // 0x410
	private Option __menuOption_Menu_RaiseElevatorToTop; // 0x468

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0xABD4B0 Offset: 0xABC8B0 VA: 0x180ABD4B0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0xABDAD0 Offset: 0xABCED0 VA: 0x180ABDAD0 Slot: 50
	public override bool get_HasMenuOptions() { }

	[BaseEntity.Menu] // RVA: 0xDBE00 Offset: 0xDB200 VA: 0x1800DBE00
	[BaseEntity.Menu.Description] // RVA: 0xDBE00 Offset: 0xDB200 VA: 0x1800DBE00
	[BaseEntity.Menu.Icon] // RVA: 0xDBE00 Offset: 0xDB200 VA: 0x1800DBE00
	[BaseEntity.Menu.ShowIf] // RVA: 0xDBE00 Offset: 0xDB200 VA: 0x1800DBE00
	// RVA: 0xABDA60 Offset: 0xABCE60 VA: 0x180ABDA60
	public void Menu_RaiseElevatorToTop(BasePlayer p) { }

	[BaseEntity.Menu] // RVA: 0xDC090 Offset: 0xDB490 VA: 0x1800DC090
	[BaseEntity.Menu.Description] // RVA: 0xDC090 Offset: 0xDB490 VA: 0x1800DC090
	[BaseEntity.Menu.Icon] // RVA: 0xDC090 Offset: 0xDB490 VA: 0x1800DC090
	[BaseEntity.Menu.ShowIf] // RVA: 0xDC090 Offset: 0xDB490 VA: 0x1800DC090
	// RVA: 0xABDA10 Offset: 0xABCE10 VA: 0x180ABDA10
	public void Menu_LowerElevatorToFloor(BasePlayer p) { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 145
	protected override bool Menu_RaiseElevator_ShowIf_Base(BasePlayer p) { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 146
	protected override bool Menu_LowerElevator_ShowIf_Base(BasePlayer p) { }

	// RVA: 0xABDAB0 Offset: 0xABCEB0 VA: 0x180ABDAB0
	public void .ctor() { }

}

public class Elevator : IOEntity, IFlagNotify // TypeDefIndex: 8692
{	// Fields
	public Transform LiftRoot; // 0x288
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

	// Properties
	protected virtual bool IsStatic { get; }
	public int Floor { get; set; }
	protected bool IsTop { get; }

	// Methods

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 160
	protected virtual bool get_IsStatic() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xAC09B0 Offset: 0xABFDB0 VA: 0x180AC09B0
	public int get_Floor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xAC09C0 Offset: 0xABFDC0 VA: 0x180AC09C0
	public void set_Floor(int value) { }

	// RVA: 0x4989F0 Offset: 0x497DF0 VA: 0x1804989F0
	protected bool get_IsTop() { }

	// RVA: 0xABF830 Offset: 0xABEC30 VA: 0x180ABF830 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0xAC05D0 Offset: 0xABF9D0 VA: 0x180AC05D0
	private void UpdateCable() { }

	// RVA: 0xAC0260 Offset: 0xABF660 VA: 0x180AC0260
	private void SetCableBounds(float height) { }

	// RVA: 0xABF670 Offset: 0xABEA70 VA: 0x180ABF670
	private void DisableUpdate() { }

	// RVA: 0xABF5A0 Offset: 0xABE9A0 VA: 0x180ABF5A0 Slot: 13
	public override void ClientOnEnable() { }

	// RVA: 0xAC0430 Offset: 0xABF830 VA: 0x180AC0430 Slot: 62
	protected override void SpawnGibs() { }

	// RVA: 0xABFA80 Offset: 0xABEE80 VA: 0x180ABFA80 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0xABF6E0 Offset: 0xABEAE0 VA: 0x180ABF6E0
	private void FindExistingLiftChild() { }

	// RVA: 0xABF900 Offset: 0xABED00 VA: 0x180ABF900 Slot: 159
	public void OnFlagToggled(bool state) { }

	// RVA: 0xABF540 Offset: 0xABE940 VA: 0x180ABF540
	public void .ctor() { }

}

public enum Elevator.Direction // TypeDefIndex: 8693
{	// Fields
	public int value__; // 0x0
	public const Elevator.Direction Up = 0;
	public const Elevator.Direction Down = 1;

}

public class ElevatorStatic : Elevator // TypeDefIndex: 8694
{	// Fields
	public bool StaticTop; // 0x310
	private const BaseEntity.Flags LiftRecentlyArrived = 512;

	// Properties
	protected override bool IsStatic { get; }

	// Methods

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 160
	protected override bool get_IsStatic() { }

	// RVA: 0xABF540 Offset: 0xABE940 VA: 0x180ABF540
	public void .ctor() { }

}

public class ElevatorIOEntity : IOEntity // TypeDefIndex: 9799
{	// Fields
	public int Consumption; // 0x288

	// Methods

	// RVA: 0xABB240 Offset: 0xABA640 VA: 0x180ABB240 Slot: 150
	public override int ConsumptionAmount() { }

	// RVA: 0xABD450 Offset: 0xABC850 VA: 0x180ABD450
	public void .ctor() { }

}

