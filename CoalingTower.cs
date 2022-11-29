public class CoalingTower : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6447
{
	public bool ShouldPool; 
	private bool _disposed; 
	public int lootTypeIndex; 
	public uint oreStorageID; 
	public uint fuelStorageID; 
	public uint activeUnloadableID; 


	public static void ResetToPool(CoalingTower instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(CoalingTower instance) { }

	public CoalingTower Copy() { }

	public static CoalingTower Deserialize(Stream stream) { }

	public static CoalingTower DeserializeLengthDelimited(Stream stream) { }

	public static CoalingTower DeserializeLength(Stream stream, int length) { }

	public static CoalingTower Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, CoalingTower previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static CoalingTower Deserialize(byte[] buffer, CoalingTower instance, bool isDelta = False) { }

	public static CoalingTower Deserialize(Stream stream, CoalingTower instance, bool isDelta) { }

	public static CoalingTower DeserializeLengthDelimited(Stream stream, CoalingTower instance, bool isDelta) { }

	public static CoalingTower DeserializeLength(Stream stream, int length, CoalingTower instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, CoalingTower instance, CoalingTower previous) { }

	public static void Serialize(Stream stream, CoalingTower instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(CoalingTower instance) { }

	public static void SerializeLengthDelimited(Stream stream, CoalingTower instance) { }

	public void .ctor() { }

}

public class CoalingTower : IOEntity // TypeDefIndex: 9996
{
	private static MaterialPropertyBlock materialPB; 
	private static int emissionColorID; 
	private static Color yellowLightOffColour; 
	private static Color greenLightOffColour; 
	[HeaderAttribute] 
	[SerializeField] 
	private BoxCollider unloadingBounds; 
	[SerializeField] 
	private GameObjectRef oreStoragePrefab; 
	[SerializeField] 
	private GameObjectRef fuelStoragePrefab; 
	[SerializeField] 
	private MeshRenderer[] signalLightsExterior; 
	[SerializeField] 
	private MeshRenderer[] signalLightsInterior; 
	[ColorUsageAttribute] 
	public Color greenLightOnColour; 
	[ColorUsageAttribute] 
	public Color yellowLightOnColour; 
	[SerializeField] 
	private Animator vacuumAnimator; 
	[SerializeField] 
	private float vacuumStartDelay; 
	[FormerlySerializedAsAttribute] 
	[SerializeField] 
	private ParticleSystemContainer unloadingFXContainerOre; 
	[SerializeField] 
	private ParticleSystem[] unloadingFXMain; 
	[SerializeField] 
	private ParticleSystem[] unloadingFXDust; 
	[SerializeField] 
	private ParticleSystemContainer unloadingFXContainerFuel; 
	[HeaderAttribute] 
	[SerializeField] 
	private TokenisedPhrase noTraincar; 
	[SerializeField] 
	private TokenisedPhrase noNextTraincar; 
	[SerializeField] 
	private TokenisedPhrase noPrevTraincar; 
	[SerializeField] 
	private TokenisedPhrase trainIsMoving; 
	[SerializeField] 
	private TokenisedPhrase outputIsFull; 
	[SerializeField] 
	private TokenisedPhrase trainHasThrottle; 
	[HeaderAttribute] 
	[SerializeField] 
	private GameObject buttonSoundPos; 
	[SerializeField] 
	private SoundDefinition buttonPressSound; 
	[SerializeField] 
	private SoundDefinition buttonReleaseSound; 
	[SerializeField] 
	private SoundDefinition failedActionSound; 
	[SerializeField] 
	private SoundDefinition failedShuntAlarmSound; 
	[SerializeField] 
	private SoundDefinition armMovementLower; 
	[SerializeField] 
	private SoundDefinition armMovementRaise; 
	[SerializeField] 
	private SoundDefinition suctionAirStart; 
	[SerializeField] 
	private SoundDefinition suctionAirStop; 
	[SerializeField] 
	private SoundDefinition suctionAirLoop; 
	[SerializeField] 
	private SoundDefinition suctionOreStart; 
	[SerializeField] 
	private SoundDefinition suctionOreLoop; 
	[SerializeField] 
	private SoundDefinition suctionOreStop; 
	[SerializeField] 
	private SoundDefinition suctionOreInteriorLoop; 
	[SerializeField] 
	private SoundDefinition oreBinLoop; 
	[SerializeField] 
	private SoundDefinition suctionFluidStart; 
	[SerializeField] 
	private SoundDefinition suctionFluidLoop; 
	[SerializeField] 
	private SoundDefinition suctionFluidStop; 
	[SerializeField] 
	private SoundDefinition suctionFluidInteriorLoop; 
	[SerializeField] 
	private SoundDefinition fluidTankLoop; 
	[SerializeField] 
	private GameObject interiorPipeSoundLocation; 
	[SerializeField] 
	private GameObject armMovementSoundLocation; 
	[SerializeField] 
	private GameObject armSuctionSoundLocation; 
	[SerializeField] 
	private GameObject oreBinSoundLocation; 
	[SerializeField] 
	private GameObject fluidTankSoundLocation; 
	private NetworkedProperty<int> LootTypeIndex; 
	private EntityRef<TrainCar> activeTrainCarRef; 
	private EntityRef<TrainCarUnloadable> activeUnloadableRef; 
	private const BaseEntity.Flags LinedUpFlag = 256;
	private const BaseEntity.Flags HasUnloadableFlag = 128;
	private const BaseEntity.Flags UnloadingInProgressFlag = 8192;
	private const BaseEntity.Flags MoveToNextInProgressFlag = 512;
	private const BaseEntity.Flags MoveToPrevInProgressFlag = 1024;
	private EntityRef<OreHopper> oreStorageInstance; 
	private EntityRef<PercentFullStorageContainer> fuelStorageInstance; 
	public const float TIME_TO_EMPTY = 40;
	[CompilerGeneratedAttribute] 
	private Vector3 <UnloadingPos>k__BackingField; 
	private static List<CoalingTower> unloadersInWorld; 
	private Sound armMovementLoopSound; 
	private Sound suctionAirLoopSound; 
	private Sound suctionMaterialLoopSound; 
	private Sound interiorPipeLoopSound; 
	private Sound unloadDestinationSound; 
	private Option __menuOption_Menu_BinFull; 
	private Option __menuOption_Menu_Next; 
	private Option __menuOption_Menu_Prev; 
	private Option __menuOption_Menu_Unavailable; 
	private Option __menuOption_Menu_Unload; 

	private bool HasTrainCar { get; }
	private bool HasUnloadable { get; }
	private bool HasUnloadableLinedUp { get; }
	public Vector3 UnloadingPos { get; set; }
	public override bool HasMenuOptions { get; }


	public override void ClientOnEnable() { }

	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	public void RefreshSignalLights() { }

	private void SetSignalLightRenderer(MeshRenderer renderer, bool hasTrainCar, bool hasUnloadable, bool hasUnloadableLinedUp) { }

	public void PlayButtonPressSound() { }

	public void PlayButtonReleaseSound() { }

	public void PlayFailedActionSound() { }

	public void PlayFailedShuntAlarmSound() { }

	private void StartSounds() { }

	private void StartSuctionSounds() { }

	private void StopSounds() { }

	private bool IsLookingAtControls(BasePlayer player) { }

	private bool IsLookingAtUnload(BasePlayer player) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_Unload(BasePlayer player) { }

	public bool Menu_Unload_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_Next(BasePlayer player) { }

	public bool Menu_Next_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_Prev(BasePlayer player) { }

	public bool Menu_Prev_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_Unavailable(BasePlayer player) { }

	public bool Menu_Unavailable_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_BinFull(BasePlayer player) { }

	public bool Menu_BinFull_ShowIf(BasePlayer player) { }

	[BaseEntity.RPC_Client] 
	private void ActionFailed(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] 
	private void IssueDuringShunt(BaseEntity.RPCMessage msg) { }

	private bool get_HasTrainCar() { }

	private bool get_HasUnloadable() { }

	private bool get_HasUnloadableLinedUp() { }

	[CompilerGeneratedAttribute] 
	public Vector3 get_UnloadingPos() { }

	[CompilerGeneratedAttribute] 
	private void set_UnloadingPos(Vector3 value) { }

	public override void InitShared() { }

	public override void DestroyShared() { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public static bool IsUnderAnUnloader(TrainCar trainCar, out bool isLinedUp, out Vector3 unloaderPos) { }

	public bool TrainCarIsUnder(TrainCar trainCar, out bool isLinedUp) { }

	private OreHopper GetOreStorage() { }

	private PercentFullStorageContainer GetFuelStorage() { }

	private TrainCar GetActiveTrainCar() { }

	private TrainCarUnloadable GetActiveUnloadable() { }

	private bool OutputBinIsFull() { }

	private bool WagonIsEmpty() { }

	private bool CanUnloadNow(out CoalingTower.ActionAttemptStatus attemptStatus) { }

	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public enum CoalingTower.ActionAttemptStatus // TypeDefIndex: 9997
{
	public int value__; 
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

