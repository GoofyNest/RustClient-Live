public class MiningQuarry : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6324
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public ResourceExtractor extractor; // 0x18
	public int staticType; // 0x20

	// Methods

	// RVA: 0x1F44C30 Offset: 0x1F44030 VA: 0x181F44C30
	public static void ResetToPool(MiningQuarry instance) { }

	// RVA: 0x1F44CE0 Offset: 0x1F440E0 VA: 0x181F44CE0
	public void ResetToPool() { }

	// RVA: 0x1F44AC0 Offset: 0x1F43EC0 VA: 0x181F44AC0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F43CE0 Offset: 0x1F430E0 VA: 0x181F43CE0
	public void CopyTo(MiningQuarry instance) { }

	// RVA: 0x1F43D70 Offset: 0x1F43170 VA: 0x181F43D70
	public MiningQuarry Copy() { }

	// RVA: 0x1F44900 Offset: 0x1F43D00 VA: 0x181F44900
	public static MiningQuarry Deserialize(Stream stream) { }

	// RVA: 0x1F440B0 Offset: 0x1F434B0 VA: 0x181F440B0
	public static MiningQuarry DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F44370 Offset: 0x1F43770 VA: 0x181F44370
	public static MiningQuarry DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F44400 Offset: 0x1F43800 VA: 0x181F44400
	public static MiningQuarry Deserialize(byte[] buffer) { }

	// RVA: 0x1F44BF0 Offset: 0x1F43FF0 VA: 0x181F44BF0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F45350 Offset: 0x1F44750 VA: 0x181F45350 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F45370 Offset: 0x1F44770 VA: 0x181F45370 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, MiningQuarry previous) { }

	// RVA: 0x1F44C10 Offset: 0x1F44010 VA: 0x181F44C10 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F44800 Offset: 0x1F43C00 VA: 0x181F44800
	public static MiningQuarry Deserialize(byte[] buffer, MiningQuarry instance, bool isDelta = False) { }

	// RVA: 0x1F44670 Offset: 0x1F43A70 VA: 0x181F44670
	public static MiningQuarry Deserialize(Stream stream, MiningQuarry instance, bool isDelta) { }

	// RVA: 0x1F43E40 Offset: 0x1F43240 VA: 0x181F43E40
	public static MiningQuarry DeserializeLengthDelimited(Stream stream, MiningQuarry instance, bool isDelta) { }

	// RVA: 0x1F44130 Offset: 0x1F43530 VA: 0x181F44130
	public static MiningQuarry DeserializeLength(Stream stream, int length, MiningQuarry instance, bool isDelta) { }

	// RVA: 0x1F44D90 Offset: 0x1F44190 VA: 0x181F44D90
	public static void SerializeDelta(Stream stream, MiningQuarry instance, MiningQuarry previous) { }

	// RVA: 0x1F45160 Offset: 0x1F44560 VA: 0x181F45160
	public static void Serialize(Stream stream, MiningQuarry instance) { }

	// RVA: 0x1F45340 Offset: 0x1F44740 VA: 0x181F45340
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F45350 Offset: 0x1F44750 VA: 0x181F45350
	public void ToProto(Stream stream) { }

	// RVA: 0x1F45050 Offset: 0x1F44450 VA: 0x181F45050
	public static byte[] SerializeToBytes(MiningQuarry instance) { }

	// RVA: 0x1F44FA0 Offset: 0x1F443A0 VA: 0x181F44FA0
	public static void SerializeLengthDelimited(Stream stream, MiningQuarry instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class MiningQuarry : BaseResourceExtractor // TypeDefIndex: 9567
{	// Fields
	public Animator beltAnimator; // 0x248
	public Renderer beltScrollRenderer; // 0x250
	public int scrollMatIndex; // 0x258
	public SoundPlayer[] onSounds; // 0x260
	public float processRate; // 0x268
	public float workToAdd; // 0x26C
	public GameObjectRef bucketDropEffect; // 0x270
	public GameObject bucketDropTransform; // 0x278
	public MiningQuarry.ChildPrefab engineSwitchPrefab; // 0x280
	public MiningQuarry.ChildPrefab hopperPrefab; // 0x288
	public MiningQuarry.ChildPrefab fuelStoragePrefab; // 0x290
	public MiningQuarry.QuarryType staticType; // 0x298
	public bool isStatic; // 0x29C
	private List<SoundModulation.Modulator> soundGainMods; // 0x2A0
	private List<SoundModulation.Modulator> soundPitchMods; // 0x2A8
	private float beltSpeed; // 0x2B0

	// Methods

	// RVA: 0x4F2CB0 Offset: 0x4F20B0 VA: 0x1804F2CB0
	public bool IsEngineOn() { }

	// RVA: 0x7656F0 Offset: 0x764AF0 VA: 0x1807656F0
	public void Update() { }

	// RVA: 0x765500 Offset: 0x764900 VA: 0x180765500
	public void BucketDrop() { }

	// RVA: 0x765560 Offset: 0x764960 VA: 0x180765560 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x765AA0 Offset: 0x764EA0 VA: 0x180765AA0
	public void .ctor() { }

}

public enum MiningQuarry.QuarryType // TypeDefIndex: 9568
{	// Fields
	public int value__; // 0x0
	public const MiningQuarry.QuarryType None = 0;
	public const MiningQuarry.QuarryType Basic = 1;
	public const MiningQuarry.QuarryType Sulfur = 2;
	public const MiningQuarry.QuarryType HQM = 3;

}

public class MiningQuarry.ChildPrefab // TypeDefIndex: 9569
{	// Fields
	public GameObjectRef prefabToSpawn; // 0x10
	public GameObject origin; // 0x18
	public BaseEntity instance; // 0x20

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

