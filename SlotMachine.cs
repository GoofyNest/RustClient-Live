public class SlotMachine : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6406
{	// Fields
	public bool ShouldPool; // 0x10
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

	// Methods

	// RVA: 0x1DAB950 Offset: 0x1DAAD50 VA: 0x181DAB950
	public static void ResetToPool(SlotMachine instance) { }

	// RVA: 0x1DABA50 Offset: 0x1DAAE50 VA: 0x181DABA50
	public void ResetToPool() { }

	// RVA: 0x1DAB400 Offset: 0x1DAA800 VA: 0x181DAB400 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DA9820 Offset: 0x1DA8C20 VA: 0x181DA9820
	public void CopyTo(SlotMachine instance) { }

	// RVA: 0x1DA9880 Offset: 0x1DA8C80 VA: 0x181DA9880
	public SlotMachine Copy() { }

	// RVA: 0x1DAA7E0 Offset: 0x1DA9BE0 VA: 0x181DAA7E0
	public static SlotMachine Deserialize(Stream stream) { }

	// RVA: 0x1DA9930 Offset: 0x1DA8D30 VA: 0x181DA9930
	public static SlotMachine DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1DA9E30 Offset: 0x1DA9230 VA: 0x181DA9E30
	public static SlotMachine DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1DAA320 Offset: 0x1DA9720 VA: 0x181DAA320
	public static SlotMachine Deserialize(byte[] buffer) { }

	// RVA: 0x1DAB590 Offset: 0x1DAA990 VA: 0x181DAB590
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1DAC350 Offset: 0x1DAB750 VA: 0x181DAC350 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1DAC370 Offset: 0x1DAB770 VA: 0x181DAC370 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, SlotMachine previous) { }

	// RVA: 0x1DAB930 Offset: 0x1DAAD30 VA: 0x181DAB930 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1DAABC0 Offset: 0x1DA9FC0 VA: 0x181DAABC0
	public static SlotMachine Deserialize(byte[] buffer, SlotMachine instance, bool isDelta = False) { }

	// RVA: 0x1DAB060 Offset: 0x1DAA460 VA: 0x181DAB060
	public static SlotMachine Deserialize(Stream stream, SlotMachine instance, bool isDelta) { }

	// RVA: 0x1DA99B0 Offset: 0x1DA8DB0 VA: 0x181DA99B0
	public static SlotMachine DeserializeLengthDelimited(Stream stream, SlotMachine instance, bool isDelta) { }

	// RVA: 0x1DA9EC0 Offset: 0x1DA92C0 VA: 0x181DA9EC0
	public static SlotMachine DeserializeLength(Stream stream, int length, SlotMachine instance, bool isDelta) { }

	// RVA: 0x1DABB50 Offset: 0x1DAAF50 VA: 0x181DABB50
	public static void SerializeDelta(Stream stream, SlotMachine instance, SlotMachine previous) { }

	// RVA: 0x1DAC120 Offset: 0x1DAB520 VA: 0x181DAC120
	public static void Serialize(Stream stream, SlotMachine instance) { }

	// RVA: 0x1DAC340 Offset: 0x1DAB740 VA: 0x181DAC340
	public byte[] ToProtoBytes() { }

	// RVA: 0x1DAC350 Offset: 0x1DAB750 VA: 0x181DAC350
	public void ToProto(Stream stream) { }

	// RVA: 0x1DAC010 Offset: 0x1DAB410 VA: 0x181DAC010
	public static byte[] SerializeToBytes(SlotMachine instance) { }

	// RVA: 0x1DABF60 Offset: 0x1DAB360 VA: 0x181DABF60
	public static void SerializeLengthDelimited(Stream stream, SlotMachine instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class SlotMachine : BaseMountable // TypeDefIndex: 8447
{	// Fields
	private Option __menuOption_Menu_Deposit; // 0x320
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

	// Properties
	public override bool HasMenuOptions { get; }
	private bool IsSpinning { get; }
	public int CurrentMultiplier { get; set; }
	public static Material instancedSpriteMaterial { get; set; }

	// Methods

	// RVA: 0x5C6590 Offset: 0x5C5990 VA: 0x1805C6590 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x5C8150 Offset: 0x5C7550 VA: 0x1805C8150 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x5C6E40 Offset: 0x5C6240 VA: 0x1805C6E40 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x593220 Offset: 0x592620 VA: 0x180593220
	private bool get_IsSpinning() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5C8140 Offset: 0x5C7540 VA: 0x1805C8140
	public int get_CurrentMultiplier() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5C83B0 Offset: 0x5C77B0 VA: 0x1805C83B0
	private void set_CurrentMultiplier(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5C82F0 Offset: 0x5C76F0 VA: 0x1805C82F0
	public static Material get_instancedSpriteMaterial() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5C83C0 Offset: 0x5C77C0 VA: 0x1805C83C0
	private static void set_instancedSpriteMaterial(Material value) { }

	// RVA: 0x56F250 Offset: 0x56E650 VA: 0x18056F250 Slot: 65
	protected override bool HideMenuItems(BasePlayer player) { }

	// RVA: 0x4989F0 Offset: 0x497DF0 VA: 0x1804989F0
	private bool CanSpin() { }

	[BaseEntity.Menu] // RVA: 0x85F00 Offset: 0x85300 VA: 0x180085F00
	[BaseEntity.Menu.Description] // RVA: 0x85F00 Offset: 0x85300 VA: 0x180085F00
	[BaseEntity.Menu.Icon] // RVA: 0x85F00 Offset: 0x85300 VA: 0x180085F00
	[BaseEntity.Menu.ShowIf] // RVA: 0x85F00 Offset: 0x85300 VA: 0x180085F00
	// RVA: 0x5C6E00 Offset: 0x5C6200 VA: 0x1805C6E00
	public void Menu_Spin(BasePlayer player) { }

	// RVA: 0x5C6DA0 Offset: 0x5C61A0 VA: 0x1805C6DA0
	public bool Menu_Spin_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x861B0 Offset: 0x855B0 VA: 0x1800861B0
	[BaseEntity.Menu.Description] // RVA: 0x861B0 Offset: 0x855B0 VA: 0x1800861B0
	[BaseEntity.Menu.Icon] // RVA: 0x861B0 Offset: 0x855B0 VA: 0x1800861B0
	[BaseEntity.Menu.ShowIf] // RVA: 0x861B0 Offset: 0x855B0 VA: 0x1800861B0
	// RVA: 0x5C6D60 Offset: 0x5C6160 VA: 0x1805C6D60
	public void Menu_Deposit(BasePlayer player) { }

	// RVA: 0x5C6D20 Offset: 0x5C6120 VA: 0x1805C6D20
	public bool Menu_Deposit_ShowIf(BasePlayer player) { }

	// RVA: 0x5C6230 Offset: 0x5C5630 VA: 0x1805C6230 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x5C7F00 Offset: 0x5C7300 VA: 0x1805C7F00
	private void UpdateSpriteMaterial() { }

	// RVA: 0x5C7760 Offset: 0x5C6B60 VA: 0x1805C7760
	private void UpdatePulse() { }

	// RVA: 0x5C74F0 Offset: 0x5C68F0 VA: 0x1805C74F0
	private void StartPulse(float duration) { }

	// RVA: 0x5C6150 Offset: 0x5C5550 VA: 0x1805C6150
	private static float CalculateReelAngle(int oldResult, int newResult, int numSpins, int maxNumSpins, float timeSinceSpin, float maxTime) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5C7290 Offset: 0x5C6690 VA: 0x1805C7290
	private void RPC_OnSpin(BaseEntity.RPCMessage msg) { }

	// RVA: 0x5C7970 Offset: 0x5C6D70 VA: 0x1805C7970
	private void UpdateSpinVisualsInvoke() { }

	// RVA: 0x5C7980 Offset: 0x5C6D80 VA: 0x1805C7980
	private void UpdateSpinVisuals(bool force = False) { }

	// RVA: 0x5C6B40 Offset: 0x5C5F40 VA: 0x1805C6B40 Slot: 175
	public override Quaternion GetMountedRotation() { }

	// RVA: 0x5C7490 Offset: 0x5C6890 VA: 0x1805C7490
	public void RequestMultiplierChange(int newMultiplier) { }

	// RVA: 0x5C7660 Offset: 0x5C6A60 VA: 0x1805C7660 Slot: 173
	public override void UpdatePlayerModel(BasePlayer player) { }

	// RVA: 0x5C6B80 Offset: 0x5C5F80 VA: 0x1805C6B80 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x5C5F00 Offset: 0x5C5300 VA: 0x1805C5F00
	private bool CalculatePayout(out SlotMachinePayoutSettings.PayoutInfo info, out int bonus) { }

	// RVA: 0x5C80A0 Offset: 0x5C74A0 VA: 0x1805C80A0
	public void .ctor() { }

	// RVA: 0x5C8020 Offset: 0x5C7420 VA: 0x1805C8020
	private static void .cctor() { }

}

public enum SlotMachine.SlotFaces // TypeDefIndex: 8448
{	// Fields
	public int value__; // 0x0
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

