public class CoalingTower : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6438
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int lootTypeIndex; // 0x14
	public uint oreStorageID; // 0x18
	public uint fuelStorageID; // 0x1C
	public uint activeUnloadableID; // 0x20

	// Methods

	// RVA: 0x20A8750 Offset: 0x20A7B50 VA: 0x1820A8750
	public static void ResetToPool(CoalingTower instance) { }

	// RVA: 0x20A86B0 Offset: 0x20A7AB0 VA: 0x1820A86B0
	public void ResetToPool() { }

	// RVA: 0x20A8360 Offset: 0x20A7760 VA: 0x1820A8360 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1C01DA0 Offset: 0x1C011A0 VA: 0x181C01DA0
	public void CopyTo(CoalingTower instance) { }

	// RVA: 0x20A71D0 Offset: 0x20A65D0 VA: 0x1820A71D0
	public CoalingTower Copy() { }

	// RVA: 0x20A8110 Offset: 0x20A7510 VA: 0x1820A8110
	public static CoalingTower Deserialize(Stream stream) { }

	// RVA: 0x20A7250 Offset: 0x20A6650 VA: 0x1820A7250
	public static CoalingTower DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x20A7870 Offset: 0x20A6C70 VA: 0x1820A7870
	public static CoalingTower DeserializeLength(Stream stream, int length) { }

	// RVA: 0x20A7B10 Offset: 0x20A6F10 VA: 0x1820A7B10
	public static CoalingTower Deserialize(byte[] buffer) { }

	// RVA: 0x20A8480 Offset: 0x20A7880 VA: 0x1820A8480
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x20A8D20 Offset: 0x20A8120 VA: 0x1820A8D20 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x20A8D40 Offset: 0x20A8140 VA: 0x1820A8D40 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, CoalingTower previous) { }

	// RVA: 0x20A8690 Offset: 0x20A7A90 VA: 0x1820A8690 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x20A7E20 Offset: 0x20A7220 VA: 0x1820A7E20
	public static CoalingTower Deserialize(byte[] buffer, CoalingTower instance, bool isDelta = False) { }

	// RVA: 0x20A7900 Offset: 0x20A6D00 VA: 0x1820A7900
	public static CoalingTower Deserialize(Stream stream, CoalingTower instance, bool isDelta) { }

	// RVA: 0x20A72D0 Offset: 0x20A66D0 VA: 0x1820A72D0
	public static CoalingTower DeserializeLengthDelimited(Stream stream, CoalingTower instance, bool isDelta) { }

	// RVA: 0x20A75B0 Offset: 0x20A69B0 VA: 0x1820A75B0
	public static CoalingTower DeserializeLength(Stream stream, int length, CoalingTower instance, bool isDelta) { }

	// RVA: 0x20A87F0 Offset: 0x20A7BF0 VA: 0x1820A87F0
	public static void SerializeDelta(Stream stream, CoalingTower instance, CoalingTower previous) { }

	// RVA: 0x20A8BC0 Offset: 0x20A7FC0 VA: 0x1820A8BC0
	public static void Serialize(Stream stream, CoalingTower instance) { }

	// RVA: 0x20A8D10 Offset: 0x20A8110 VA: 0x1820A8D10
	public byte[] ToProtoBytes() { }

	// RVA: 0x20A8D20 Offset: 0x20A8120 VA: 0x1820A8D20
	public void ToProto(Stream stream) { }

	// RVA: 0x20A8AB0 Offset: 0x20A7EB0 VA: 0x1820A8AB0
	public static byte[] SerializeToBytes(CoalingTower instance) { }

	// RVA: 0x20A8A00 Offset: 0x20A7E00 VA: 0x1820A8A00
	public static void SerializeLengthDelimited(Stream stream, CoalingTower instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class CoalingTower : IOEntity // TypeDefIndex: 8282
{	// Fields
	private static MaterialPropertyBlock materialPB; // 0x0
	private static int emissionColorID; // 0x8
	private static Color yellowLightOffColour; // 0xC
	private static Color greenLightOffColour; // 0x1C
	[HeaderAttribute] // RVA: 0xA7B70 Offset: 0xA6F70 VA: 0x1800A7B70
	[SerializeField] // RVA: 0xA7B70 Offset: 0xA6F70 VA: 0x1800A7B70
	private BoxCollider unloadingBounds; // 0x288
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private GameObjectRef oreStoragePrefab; // 0x290
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private GameObjectRef fuelStoragePrefab; // 0x298
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private MeshRenderer[] signalLightsExterior; // 0x2A0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private MeshRenderer[] signalLightsInterior; // 0x2A8
	[ColorUsageAttribute] // RVA: 0x76690 Offset: 0x75A90 VA: 0x180076690
	public Color greenLightOnColour; // 0x2B0
	[ColorUsageAttribute] // RVA: 0x76690 Offset: 0x75A90 VA: 0x180076690
	public Color yellowLightOnColour; // 0x2C0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Animator vacuumAnimator; // 0x2D0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float vacuumStartDelay; // 0x2D8
	[FormerlySerializedAsAttribute] // RVA: 0xA9430 Offset: 0xA8830 VA: 0x1800A9430
	[SerializeField] // RVA: 0xA9430 Offset: 0xA8830 VA: 0x1800A9430
	private ParticleSystemContainer unloadingFXContainerOre; // 0x2E0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ParticleSystem[] unloadingFXMain; // 0x2E8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ParticleSystem[] unloadingFXDust; // 0x2F0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ParticleSystemContainer unloadingFXContainerFuel; // 0x2F8
	[HeaderAttribute] // RVA: 0xA9690 Offset: 0xA8A90 VA: 0x1800A9690
	[SerializeField] // RVA: 0xA9690 Offset: 0xA8A90 VA: 0x1800A9690
	private TokenisedPhrase noTraincar; // 0x300
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private TokenisedPhrase noNextTraincar; // 0x308
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private TokenisedPhrase noPrevTraincar; // 0x310
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private TokenisedPhrase trainIsMoving; // 0x318
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private TokenisedPhrase outputIsFull; // 0x320
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private TokenisedPhrase trainHasThrottle; // 0x328
	[HeaderAttribute] // RVA: 0xA9AB0 Offset: 0xA8EB0 VA: 0x1800A9AB0
	[SerializeField] // RVA: 0xA9AB0 Offset: 0xA8EB0 VA: 0x1800A9AB0
	private GameObject buttonSoundPos; // 0x330
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private SoundDefinition buttonPressSound; // 0x338
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private SoundDefinition buttonReleaseSound; // 0x340
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private SoundDefinition failedActionSound; // 0x348
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private SoundDefinition failedShuntAlarmSound; // 0x350
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private SoundDefinition armMovementLower; // 0x358
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private SoundDefinition armMovementRaise; // 0x360
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private SoundDefinition suctionAirStart; // 0x368
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private SoundDefinition suctionAirStop; // 0x370
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private SoundDefinition suctionAirLoop; // 0x378
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private SoundDefinition suctionOreStart; // 0x380
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private SoundDefinition suctionOreLoop; // 0x388
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private SoundDefinition suctionOreStop; // 0x390
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private SoundDefinition suctionOreInteriorLoop; // 0x398
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private SoundDefinition oreBinLoop; // 0x3A0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private SoundDefinition suctionFluidStart; // 0x3A8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private SoundDefinition suctionFluidLoop; // 0x3B0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private SoundDefinition suctionFluidStop; // 0x3B8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private SoundDefinition suctionFluidInteriorLoop; // 0x3C0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private SoundDefinition fluidTankLoop; // 0x3C8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private GameObject interiorPipeSoundLocation; // 0x3D0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private GameObject armMovementSoundLocation; // 0x3D8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private GameObject armSuctionSoundLocation; // 0x3E0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private GameObject oreBinSoundLocation; // 0x3E8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private GameObject fluidTankSoundLocation; // 0x3F0
	private NetworkedProperty<int> LootTypeIndex; // 0x3F8
	private EntityRef<TrainCar> activeTrainCarRef; // 0x400
	private EntityRef<TrainCarUnloadable> activeUnloadableRef; // 0x410
	private const BaseEntity.Flags LinedUpFlag = 256;
	private const BaseEntity.Flags HasUnloadableFlag = 128;
	private const BaseEntity.Flags UnloadingInProgressFlag = 8192;
	private const BaseEntity.Flags MoveToNextInProgressFlag = 512;
	private const BaseEntity.Flags MoveToPrevInProgressFlag = 1024;
	private EntityRef<OreHopper> oreStorageInstance; // 0x420
	private EntityRef<PercentFullStorageContainer> fuelStorageInstance; // 0x430
	public const float TIME_TO_EMPTY = 40;
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Vector3 <UnloadingPos>k__BackingField; // 0x440
	private static List<CoalingTower> unloadersInWorld; // 0x30
	private Sound armMovementLoopSound; // 0x450
	private Sound suctionAirLoopSound; // 0x458
	private Sound suctionMaterialLoopSound; // 0x460
	private Sound interiorPipeLoopSound; // 0x468
	private Sound unloadDestinationSound; // 0x470
	private Option __menuOption_Menu_BinFull; // 0x478
	private Option __menuOption_Menu_Next; // 0x4D0
	private Option __menuOption_Menu_Prev; // 0x528
	private Option __menuOption_Menu_Unavailable; // 0x580
	private Option __menuOption_Menu_Unload; // 0x5D8

	// Properties
	private bool HasTrainCar { get; }
	private bool HasUnloadable { get; }
	private bool HasUnloadableLinedUp { get; }
	public Vector3 UnloadingPos { get; set; }
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x58F1A0 Offset: 0x58E5A0 VA: 0x18058F1A0 Slot: 13
	public override void ClientOnEnable() { }

	// RVA: 0x590FE0 Offset: 0x5903E0 VA: 0x180590FE0 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0x591DE0 Offset: 0x5911E0 VA: 0x180591DE0
	public void RefreshSignalLights() { }

	// RVA: 0x591FE0 Offset: 0x5913E0 VA: 0x180591FE0
	private void SetSignalLightRenderer(MeshRenderer renderer, bool hasTrainCar, bool hasUnloadable, bool hasUnloadableLinedUp) { }

	// RVA: 0x591D20 Offset: 0x591120 VA: 0x180591D20
	public void PlayButtonPressSound() { }

	// RVA: 0x591D60 Offset: 0x591160 VA: 0x180591D60
	public void PlayButtonReleaseSound() { }

	// RVA: 0x591DA0 Offset: 0x5911A0 VA: 0x180591DA0
	public void PlayFailedActionSound() { }

	// RVA: 0x590710 Offset: 0x58FB10 VA: 0x180590710
	public void PlayFailedShuntAlarmSound() { }

	// RVA: 0x592340 Offset: 0x591740 VA: 0x180592340
	private void StartSounds() { }

	// RVA: 0x5923F0 Offset: 0x5917F0 VA: 0x1805923F0
	private void StartSuctionSounds() { }

	// RVA: 0x592860 Offset: 0x591C60 VA: 0x180592860
	private void StopSounds() { }

	// RVA: 0x590270 Offset: 0x58F670 VA: 0x180590270
	private bool IsLookingAtControls(BasePlayer player) { }

	// RVA: 0x590370 Offset: 0x58F770 VA: 0x180590370
	private bool IsLookingAtUnload(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xAAB40 Offset: 0xA9F40 VA: 0x1800AAB40
	[BaseEntity.Menu.Description] // RVA: 0xAAB40 Offset: 0xA9F40 VA: 0x1800AAB40
	[BaseEntity.Menu.Icon] // RVA: 0xAAB40 Offset: 0xA9F40 VA: 0x1800AAB40
	[BaseEntity.Menu.ShowIf] // RVA: 0xAAB40 Offset: 0xA9F40 VA: 0x1800AAB40
	// RVA: 0x590FA0 Offset: 0x5903A0 VA: 0x180590FA0
	public void Menu_Unload(BasePlayer player) { }

	// RVA: 0x590EF0 Offset: 0x5902F0 VA: 0x180590EF0
	public bool Menu_Unload_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xAAE20 Offset: 0xAA220 VA: 0x1800AAE20
	[BaseEntity.Menu.Description] // RVA: 0xAAE20 Offset: 0xAA220 VA: 0x1800AAE20
	[BaseEntity.Menu.Icon] // RVA: 0xAAE20 Offset: 0xAA220 VA: 0x1800AAE20
	[BaseEntity.Menu.ShowIf] // RVA: 0xAAE20 Offset: 0xAA220 VA: 0x1800AAE20
	// RVA: 0x590BD0 Offset: 0x58FFD0 VA: 0x180590BD0
	public void Menu_Next(BasePlayer player) { }

	// RVA: 0x590AB0 Offset: 0x58FEB0 VA: 0x180590AB0
	public bool Menu_Next_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xAB170 Offset: 0xAA570 VA: 0x1800AB170
	[BaseEntity.Menu.Description] // RVA: 0xAB170 Offset: 0xAA570 VA: 0x1800AB170
	[BaseEntity.Menu.Icon] // RVA: 0xAB170 Offset: 0xAA570 VA: 0x1800AB170
	[BaseEntity.Menu.ShowIf] // RVA: 0xAB170 Offset: 0xAA570 VA: 0x1800AB170
	// RVA: 0x590D30 Offset: 0x590130 VA: 0x180590D30
	public void Menu_Prev(BasePlayer player) { }

	// RVA: 0x590C10 Offset: 0x590010 VA: 0x180590C10
	public bool Menu_Prev_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xAB4B0 Offset: 0xAA8B0 VA: 0x1800AB4B0
	[BaseEntity.Menu.Description] // RVA: 0xAB4B0 Offset: 0xAA8B0 VA: 0x1800AB4B0
	[BaseEntity.Menu.Icon] // RVA: 0xAB4B0 Offset: 0xAA8B0 VA: 0x1800AB4B0
	[BaseEntity.Menu.ShowIf] // RVA: 0xAB4B0 Offset: 0xAA8B0 VA: 0x1800AB4B0
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public void Menu_Unavailable(BasePlayer player) { }

	// RVA: 0x590D70 Offset: 0x590170 VA: 0x180590D70
	public bool Menu_Unavailable_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xAB6D0 Offset: 0xAAAD0 VA: 0x1800AB6D0
	[BaseEntity.Menu.Description] // RVA: 0xAB6D0 Offset: 0xAAAD0 VA: 0x1800AB6D0
	[BaseEntity.Menu.Icon] // RVA: 0xAB6D0 Offset: 0xAAAD0 VA: 0x1800AB6D0
	[BaseEntity.Menu.ShowIf] // RVA: 0xAB6D0 Offset: 0xAAAD0 VA: 0x1800AB6D0
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public void Menu_BinFull(BasePlayer player) { }

	// RVA: 0x590A40 Offset: 0x58FE40 VA: 0x180590A40
	public bool Menu_BinFull_ShowIf(BasePlayer player) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x58EEE0 Offset: 0x58E2E0 VA: 0x18058EEE0
	private void ActionFailed(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x590710 Offset: 0x58FB10 VA: 0x180590710
	private void IssueDuringShunt(BaseEntity.RPCMessage msg) { }

	// RVA: 0x5931D0 Offset: 0x5925D0 VA: 0x1805931D0
	private bool get_HasTrainCar() { }

	// RVA: 0x593230 Offset: 0x592630 VA: 0x180593230
	private bool get_HasUnloadable() { }

	// RVA: 0x593220 Offset: 0x592620 VA: 0x180593220
	private bool get_HasUnloadableLinedUp() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x593280 Offset: 0x592680 VA: 0x180593280
	public Vector3 get_UnloadingPos() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5932A0 Offset: 0x5926A0 VA: 0x1805932A0
	private void set_UnloadingPos(Vector3 value) { }

	// RVA: 0x590040 Offset: 0x58F440 VA: 0x180590040 Slot: 28
	public override void InitShared() { }

	// RVA: 0x58F1F0 Offset: 0x58E5F0 VA: 0x18058F1F0 Slot: 31
	public override void DestroyShared() { }

	// RVA: 0x590750 Offset: 0x58FB50 VA: 0x180590750 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x590420 Offset: 0x58F820 VA: 0x180590420
	public static bool IsUnderAnUnloader(TrainCar trainCar, out bool isLinedUp, out Vector3 unloaderPos) { }

	// RVA: 0x592BC0 Offset: 0x591FC0 VA: 0x180592BC0
	public bool TrainCarIsUnder(TrainCar trainCar, out bool isLinedUp) { }

	// RVA: 0x58FFD0 Offset: 0x58F3D0 VA: 0x18058FFD0
	private OreHopper GetOreStorage() { }

	// RVA: 0x58F350 Offset: 0x58E750 VA: 0x18058F350
	private PercentFullStorageContainer GetFuelStorage() { }

	// RVA: 0x58F270 Offset: 0x58E670 VA: 0x18058F270
	private TrainCar GetActiveTrainCar() { }

	// RVA: 0x58F2E0 Offset: 0x58E6E0 VA: 0x18058F2E0
	private TrainCarUnloadable GetActiveUnloadable() { }

	// RVA: 0x591B80 Offset: 0x590F80 VA: 0x180591B80
	private bool OutputBinIsFull() { }

	// RVA: 0x592CE0 Offset: 0x5920E0 VA: 0x180592CE0
	private bool WagonIsEmpty() { }

	// RVA: 0x58F120 Offset: 0x58E520 VA: 0x18058F120
	private bool CanUnloadNow(out CoalingTower.ActionAttemptStatus attemptStatus) { }

	// RVA: 0x58F3C0 Offset: 0x58E7C0 VA: 0x18058F3C0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x592EA0 Offset: 0x5922A0 VA: 0x180592EA0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x591400 Offset: 0x590800 VA: 0x180591400 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x592E40 Offset: 0x592240 VA: 0x180592E40
	public void .ctor() { }

	// RVA: 0x592DC0 Offset: 0x5921C0 VA: 0x180592DC0
	private static void .cctor() { }

}

public enum CoalingTower.ActionAttemptStatus // TypeDefIndex: 8283
{	// Fields
	public int value__; // 0x0
	public const CoalingTower.ActionAttemptStatus NoError = 0;
	public const CoalingTower.ActionAttemptStatus GenericError = 1;
	public const CoalingTower.ActionAttemptStatus NoTrainCar = 2;
	public const CoalingTower.ActionAttemptStatus NoNextTrainCar = 3;
	public const CoalingTower.ActionAttemptStatus NoPrevTrainCar = 4;
	public const CoalingTower.ActionAttemptStatus TrainIsMoving = 5;
	public const CoalingTower.ActionAttemptStatus OutputIsFull = 6;
	public const CoalingTower.ActionAttemptStatus AlreadyShunting = 7;
	public const CoalingTower.ActionAttemptStatus TrainHasThrottle = 8;

}

