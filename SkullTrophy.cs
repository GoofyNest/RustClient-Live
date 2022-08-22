public class SkullTrophy : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6388
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public string playerName; // 0x18


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

public class SkullTrophy : StorageContainer // TypeDefIndex: 8795
{	public RustText NameText; // 0x3D0
	public TextProOnACircle CircleModifier; // 0x3D8
	public int AngleModifierMinCharCount; // 0x3E0
	public int AngleModifierMaxCharCount; // 0x3E4
	public int AngleModifierMinArcAngle; // 0x3E8
	public int AngleModifierMaxArcAngle; // 0x3EC
	public float SunsetTime; // 0x3F0
	public float SunriseTime; // 0x3F4
	public MeshRenderer[] SkullRenderers; // 0x3F8
	public Material[] DaySkull; // 0x400
	public Material[] NightSkull; // 0x408
	public Material[] NoSkull; // 0x410

	private bool IsNightTime { get; }


	private void UpdateVisual(string playerName) { }

	private void ApplySkullMaterials(Material[] mats) { }

	private void UpdateLights() { }

	private bool get_IsNightTime() { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public void .ctor() { }

}

