public class SlotMachine : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6406
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int oldResult1; // 0x14
	public int oldResult2; // 0x18
	public int oldResult3; // 0x1C
	public int newResult1; // 0x20
	public int newResult2; // 0x24
	public int newResult3; // 0x28
	public bool isSpinning; // 0x2C
	public float spinTime; // 0x30
	public uint storageID; // 0x34
	public int multiplier; // 0x38


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
{	private Option __menuOption_Menu_Deposit; // 0x320
	private Option __menuOption_Menu_Spin; // 0x378
	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	public static int ForcePayoutIndex; // 0x0
	[HeaderAttribute] // RVA: 0x85920 Offset: 0x84D20 VA: 0x180085920
	public Transform Reel1; // 0x3D0
	public Transform Reel2; // 0x3D8
	public Transform Reel3; // 0x3E0
	public Transform Arm; // 0x3E8
	public AnimationCurve Curve; // 0x3F0
	public int Reel1Spins; // 0x3F8
	public int Reel2Spins; // 0x3FC
	public int Reel3Spins; // 0x400
	public int MaxReelSpins; // 0x404
	public float SpinDuration; // 0x408
	private int SpinResult1; // 0x40C
	private int SpinResult2; // 0x410
	private int SpinResult3; // 0x414
	private int SpinResultPrevious1; // 0x418
	private int SpinResultPrevious2; // 0x41C
	private int SpinResultPrevious3; // 0x420
	private float SpinTime; // 0x424
	public GameObjectRef StoragePrefab; // 0x428
	public EntityRef StorageInstance; // 0x430
	public SoundDefinition SpinSound; // 0x440
	public SlotMachinePayoutDisplay PayoutDisplay; // 0x448
	public SlotMachinePayoutSettings PayoutSettings; // 0x450
	public Transform HandIkTarget; // 0x458
	private const BaseEntity.Flags HasScrapForSpin = 128;
	private const BaseEntity.Flags IsSpinningFlag = 256;
	public Material PayoutIconMaterial; // 0x460
	public MeshRenderer[] PulseRenderers; // 0x468
	public float PulseSpeed; // 0x470
	[ColorUsageAttribute] // RVA: 0x859B0 Offset: 0x84DB0 VA: 0x1800859B0
	public Color PulseFrom; // 0x474
	[ColorUsageAttribute] // RVA: 0x859B0 Offset: 0x84DB0 VA: 0x1800859B0
	public Color PulseTo; // 0x484
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <CurrentMultiplier>k__BackingField; // 0x494
	private TimeSince lastWin; // 0x498
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static Material <instancedSpriteMaterial>k__BackingField; // 0x8
	private Material instancedPulseMaterial; // 0x4A0
	private TimeSince pulseTime; // 0x4A8
	private float pulseFor; // 0x4AC
	private static int emissionId; // 0x10
	private Quaternion InitialArmRotation; // 0x4B0

	public override bool HasMenuOptions { get; }
	private bool IsSpinning { get; }
	public int CurrentMultiplier { get; set; }
	public static Material instancedSpriteMaterial { get; set; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	private bool get_IsSpinning() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public int get_CurrentMultiplier() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_CurrentMultiplier(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static Material get_instancedSpriteMaterial() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static void set_instancedSpriteMaterial(Material value) { }

	protected override bool HideMenuItems(BasePlayer player) { }

	private bool CanSpin() { }

	[BaseEntity.Menu] // RVA: 0x85F00 Offset: 0x85300 VA: 0x180085F00
	[BaseEntity.Menu.Description] // RVA: 0x85F00 Offset: 0x85300 VA: 0x180085F00
	[BaseEntity.Menu.Icon] // RVA: 0x85F00 Offset: 0x85300 VA: 0x180085F00
	[BaseEntity.Menu.ShowIf] // RVA: 0x85F00 Offset: 0x85300 VA: 0x180085F00
	public void Menu_Spin(BasePlayer player) { }

	public bool Menu_Spin_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x861B0 Offset: 0x855B0 VA: 0x1800861B0
	[BaseEntity.Menu.Description] // RVA: 0x861B0 Offset: 0x855B0 VA: 0x1800861B0
	[BaseEntity.Menu.Icon] // RVA: 0x861B0 Offset: 0x855B0 VA: 0x1800861B0
	[BaseEntity.Menu.ShowIf] // RVA: 0x861B0 Offset: 0x855B0 VA: 0x1800861B0
	public void Menu_Deposit(BasePlayer player) { }

	public bool Menu_Deposit_ShowIf(BasePlayer player) { }

	protected override void ClientInit(Entity info) { }

	private void UpdateSpriteMaterial() { }

	private void UpdatePulse() { }

	private void StartPulse(float duration) { }

	private static float CalculateReelAngle(int oldResult, int newResult, int numSpins, int maxNumSpins, float timeSinceSpin, float maxTime) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
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
{	public int value__; // 0x0
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

