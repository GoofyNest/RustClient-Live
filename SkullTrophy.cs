public class SkullTrophy : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6397
{
	public bool ShouldPool;
	private bool _disposed;
	public string playerName;


	public static void ResetToPool(SkullTrophy instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(SkullTrophy instance) { }

	public SkullTrophy Copy() { }

	public static SkullTrophy Deserialize(Stream stream) { }

	public static SkullTrophy DeserializeLengthDelimited(Stream stream) { }

	public static SkullTrophy DeserializeLength(Stream stream, int length) { }

	public static SkullTrophy Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, SkullTrophy previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static SkullTrophy Deserialize(byte[] buffer, SkullTrophy instance, bool isDelta = False) { }

	public static SkullTrophy Deserialize(Stream stream, SkullTrophy instance, bool isDelta) { }

	public static SkullTrophy DeserializeLengthDelimited(Stream stream, SkullTrophy instance, bool isDelta) { }

	public static SkullTrophy DeserializeLength(Stream stream, int length, SkullTrophy instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, SkullTrophy instance, SkullTrophy previous) { }

	public static void Serialize(Stream stream, SkullTrophy instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(SkullTrophy instance) { }

	public static void SerializeLengthDelimited(Stream stream, SkullTrophy instance) { }

	public void .ctor() { }

}

public class SkullTrophy : StorageContainer // TypeDefIndex: 10521
{
	public RustText NameText;
	public TextProOnACircle CircleModifier;
	public int AngleModifierMinCharCount;
	public int AngleModifierMaxCharCount;
	public int AngleModifierMinArcAngle;
	public int AngleModifierMaxArcAngle;
	public float SunsetTime;
	public float SunriseTime;
	public MeshRenderer[] SkullRenderers;
	public Material[] DaySkull;
	public Material[] NightSkull;
	public Material[] NoSkull;

	private bool IsNightTime { get; }


	private void UpdateVisual(string playerName) { }

	private void ApplySkullMaterials(Material[] mats) { }

	private void UpdateLights() { }

	private bool get_IsNightTime() { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public void .ctor() { }

}

