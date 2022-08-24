public class MiningQuarry : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6324
{
	public bool ShouldPool; 
	private bool _disposed; 
	public ResourceExtractor extractor; 
	public int staticType; 


	public static void ResetToPool(MiningQuarry instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(MiningQuarry instance) { }

	public MiningQuarry Copy() { }

	public static MiningQuarry Deserialize(Stream stream) { }

	public static MiningQuarry DeserializeLengthDelimited(Stream stream) { }

	public static MiningQuarry DeserializeLength(Stream stream, int length) { }

	public static MiningQuarry Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, MiningQuarry previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static MiningQuarry Deserialize(byte[] buffer, MiningQuarry instance, bool isDelta = False) { }

	public static MiningQuarry Deserialize(Stream stream, MiningQuarry instance, bool isDelta) { }

	public static MiningQuarry DeserializeLengthDelimited(Stream stream, MiningQuarry instance, bool isDelta) { }

	public static MiningQuarry DeserializeLength(Stream stream, int length, MiningQuarry instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, MiningQuarry instance, MiningQuarry previous) { }

	public static void Serialize(Stream stream, MiningQuarry instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(MiningQuarry instance) { }

	public static void SerializeLengthDelimited(Stream stream, MiningQuarry instance) { }

	public void .ctor() { }

}

public class MiningQuarry : BaseResourceExtractor // TypeDefIndex: 9567
{
	public Animator beltAnimator; 
	public Renderer beltScrollRenderer; 
	public int scrollMatIndex; 
	public SoundPlayer[] onSounds; 
	public float processRate; 
	public float workToAdd; 
	public GameObjectRef bucketDropEffect; 
	public GameObject bucketDropTransform; 
	public MiningQuarry.ChildPrefab engineSwitchPrefab; 
	public MiningQuarry.ChildPrefab hopperPrefab; 
	public MiningQuarry.ChildPrefab fuelStoragePrefab; 
	public MiningQuarry.QuarryType staticType; 
	public bool isStatic; 
	private List<SoundModulation.Modulator> soundGainMods; 
	private List<SoundModulation.Modulator> soundPitchMods; 
	private float beltSpeed; 


	public bool IsEngineOn() { }

	public void Update() { }

	public void BucketDrop() { }

	protected override void ClientInit(Entity info) { }

	public void .ctor() { }

}

public enum MiningQuarry.QuarryType // TypeDefIndex: 9568
{
	public int value__; 
	public const MiningQuarry.QuarryType None = 0;
	public const MiningQuarry.QuarryType Basic = 1;
	public const MiningQuarry.QuarryType Sulfur = 2;
	public const MiningQuarry.QuarryType HQM = 3;

}

public class MiningQuarry.ChildPrefab // TypeDefIndex: 9569
{
	public GameObjectRef prefabToSpawn; 
	public GameObject origin; 
	public BaseEntity instance; 


	public void .ctor() { }

}

