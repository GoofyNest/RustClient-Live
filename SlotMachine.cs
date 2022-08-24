public class SlotMachine : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6406
{
	public bool ShouldPool; 
	private bool _disposed; 
	public int oldResult1; 
	public int oldResult2; 
	public int oldResult3; 
	public int newResult1; 
	public int newResult2; 
	public int newResult3; 
	public bool isSpinning; 
	public float spinTime; 
	public uint storageID; 
	public int multiplier; 


	public static void ResetToPool(SlotMachine instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(SlotMachine instance) { }

	public SlotMachine Copy() { }

	public static SlotMachine Deserialize(Stream stream) { }

	public static SlotMachine DeserializeLengthDelimited(Stream stream) { }

	public static SlotMachine DeserializeLength(Stream stream, int length) { }

	public static SlotMachine Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, SlotMachine previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static SlotMachine Deserialize(byte[] buffer, SlotMachine instance, bool isDelta = False) { }

	public static SlotMachine Deserialize(Stream stream, SlotMachine instance, bool isDelta) { }

	public static SlotMachine DeserializeLengthDelimited(Stream stream, SlotMachine instance, bool isDelta) { }

	public static SlotMachine DeserializeLength(Stream stream, int length, SlotMachine instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, SlotMachine instance, SlotMachine previous) { }

	public static void Serialize(Stream stream, SlotMachine instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(SlotMachine instance) { }

	public static void SerializeLengthDelimited(Stream stream, SlotMachine instance) { }

	public void .ctor() { }

}

public class SlotMachine : BaseMountable // TypeDefIndex: 8447
{
	private Option __menuOption_Menu_Deposit; 
	private Option __menuOption_Menu_Spin; 
	[ServerVar] 
	public static int ForcePayoutIndex; 
	[HeaderAttribute] 
	public Transform Reel1; 
	public Transform Reel2; 
	public Transform Reel3; 
	public Transform Arm; 
	public AnimationCurve Curve; 
	public int Reel1Spins; 
	public int Reel2Spins; 
	public int Reel3Spins; 
	public int MaxReelSpins; 
	public float SpinDuration; 
	private int SpinResult1; 
	private int SpinResult2; 
	private int SpinResult3; 
	private int SpinResultPrevious1; 
	private int SpinResultPrevious2; 
	private int SpinResultPrevious3; 
	private float SpinTime; 
	public GameObjectRef StoragePrefab; 
	public EntityRef StorageInstance; 
	public SoundDefinition SpinSound; 
	public SlotMachinePayoutDisplay PayoutDisplay; 
	public SlotMachinePayoutSettings PayoutSettings; 
	public Transform HandIkTarget; 
	private const BaseEntity.Flags HasScrapForSpin = 128;
	private const BaseEntity.Flags IsSpinningFlag = 256;
	public Material PayoutIconMaterial; 
	public MeshRenderer[] PulseRenderers; 
	public float PulseSpeed; 
	[ColorUsageAttribute] 
	public Color PulseFrom; 
	[ColorUsageAttribute] 
	public Color PulseTo; 
	[CompilerGeneratedAttribute] 
	private int <CurrentMultiplier>k__BackingField; 
	private TimeSince lastWin; 
	[CompilerGeneratedAttribute] 
	private static Material <instancedSpriteMaterial>k__BackingField; 
	private Material instancedPulseMaterial; 
	private TimeSince pulseTime; 
	private float pulseFor; 
	private static int emissionId; 
	private Quaternion InitialArmRotation; 

	public override bool HasMenuOptions { get; }
	private bool IsSpinning { get; }
	public int CurrentMultiplier { get; set; }
	public static Material instancedSpriteMaterial { get; set; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	private bool get_IsSpinning() { }

	[CompilerGeneratedAttribute] 
	public int get_CurrentMultiplier() { }

	[CompilerGeneratedAttribute] 
	private void set_CurrentMultiplier(int value) { }

	[CompilerGeneratedAttribute] 
	public static Material get_instancedSpriteMaterial() { }

	[CompilerGeneratedAttribute] 
	private static void set_instancedSpriteMaterial(Material value) { }

	protected override bool HideMenuItems(BasePlayer player) { }

	private bool CanSpin() { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_Spin(BasePlayer player) { }

	public bool Menu_Spin_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_Deposit(BasePlayer player) { }

	public bool Menu_Deposit_ShowIf(BasePlayer player) { }

	protected override void ClientInit(Entity info) { }

	private void UpdateSpriteMaterial() { }

	private void UpdatePulse() { }

	private void StartPulse(float duration) { }

	private static float CalculateReelAngle(int oldResult, int newResult, int numSpins, int maxNumSpins, float timeSinceSpin, float maxTime) { }

	[BaseEntity.RPC_Client] 
	private void RPC_OnSpin(BaseEntity.RPCMessage msg) { }

	private void UpdateSpinVisualsInvoke() { }

	private void UpdateSpinVisuals(bool force = False) { }

	public override Quaternion GetMountedRotation() { }

	public void RequestMultiplierChange(int newMultiplier) { }

	public override void UpdatePlayerModel(BasePlayer player) { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	private bool CalculatePayout(out SlotMachinePayoutSettings.PayoutInfo info, out int bonus) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public enum SlotMachine.SlotFaces // TypeDefIndex: 8448
{
	public int value__; 
	public const SlotMachine.SlotFaces Scrap = 0;
	public const SlotMachine.SlotFaces Rope = 1;
	public const SlotMachine.SlotFaces Apple = 2;
	public const SlotMachine.SlotFaces LowGrade = 3;
	public const SlotMachine.SlotFaces Wood = 4;
	public const SlotMachine.SlotFaces Bandage = 5;
	public const SlotMachine.SlotFaces Charcoal = 6;
	public const SlotMachine.SlotFaces Gunpowder = 7;
	public const SlotMachine.SlotFaces Rust = 8;
	public const SlotMachine.SlotFaces Meat = 9;
	public const SlotMachine.SlotFaces Hammer = 10;
	public const SlotMachine.SlotFaces Sulfur = 11;
	public const SlotMachine.SlotFaces TechScrap = 12;
	public const SlotMachine.SlotFaces Frags = 13;
	public const SlotMachine.SlotFaces Cloth = 14;
	public const SlotMachine.SlotFaces LuckySeven = 15;

}

