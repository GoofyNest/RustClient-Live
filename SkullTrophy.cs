public class SkullTrophy : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6388
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public string playerName; // 0x18

	// Methods

	// RVA: 0x1E09130 Offset: 0x1E08530 VA: 0x181E09130
	public static void ResetToPool(SkullTrophy instance) { }

	// RVA: 0x1E091C0 Offset: 0x1E085C0 VA: 0x181E091C0
	public void ResetToPool() { }

	// RVA: 0x1E08FE0 Offset: 0x1E083E0 VA: 0x181E08FE0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1D62910 Offset: 0x1D61D10 VA: 0x181D62910
	public void CopyTo(SkullTrophy instance) { }

	// RVA: 0x1E08640 Offset: 0x1E07A40 VA: 0x181E08640
	public SkullTrophy Copy() { }

	// RVA: 0x1E08F60 Offset: 0x1E08360 VA: 0x181E08F60
	public static SkullTrophy Deserialize(Stream stream) { }

	// RVA: 0x1E086C0 Offset: 0x1E07AC0 VA: 0x181E086C0
	public static SkullTrophy DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E08960 Offset: 0x1E07D60 VA: 0x181E08960
	public static SkullTrophy DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E08BF0 Offset: 0x1E07FF0 VA: 0x181E08BF0
	public static SkullTrophy Deserialize(byte[] buffer) { }

	// RVA: 0x1E090F0 Offset: 0x1E084F0 VA: 0x181E090F0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E09630 Offset: 0x1E08A30 VA: 0x181E09630 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E09650 Offset: 0x1E08A50 VA: 0x181E09650 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, SkullTrophy previous) { }

	// RVA: 0x1E09110 Offset: 0x1E08510 VA: 0x181E09110 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E08E60 Offset: 0x1E08260 VA: 0x181E08E60
	public static SkullTrophy Deserialize(byte[] buffer, SkullTrophy instance, bool isDelta = False) { }

	// RVA: 0x1E08D10 Offset: 0x1E08110 VA: 0x181E08D10
	public static SkullTrophy Deserialize(Stream stream, SkullTrophy instance, bool isDelta) { }

	// RVA: 0x1E08740 Offset: 0x1E07B40 VA: 0x181E08740
	public static SkullTrophy DeserializeLengthDelimited(Stream stream, SkullTrophy instance, bool isDelta) { }

	// RVA: 0x1E089F0 Offset: 0x1E07DF0 VA: 0x181E089F0
	public static SkullTrophy DeserializeLength(Stream stream, int length, SkullTrophy instance, bool isDelta) { }

	// RVA: 0x1E09250 Offset: 0x1E08650 VA: 0x181E09250
	public static void SerializeDelta(Stream stream, SkullTrophy instance, SkullTrophy previous) { }

	// RVA: 0x1E09530 Offset: 0x1E08930 VA: 0x181E09530
	public static void Serialize(Stream stream, SkullTrophy instance) { }

	// RVA: 0x1E09620 Offset: 0x1E08A20 VA: 0x181E09620
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E09630 Offset: 0x1E08A30 VA: 0x181E09630
	public void ToProto(Stream stream) { }

	// RVA: 0x1E09420 Offset: 0x1E08820 VA: 0x181E09420
	public static byte[] SerializeToBytes(SkullTrophy instance) { }

	// RVA: 0x1E09370 Offset: 0x1E08770 VA: 0x181E09370
	public static void SerializeLengthDelimited(Stream stream, SkullTrophy instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class SkullTrophy : StorageContainer // TypeDefIndex: 8795
{	// Fields
	public RustText NameText; // 0x3D0
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

	// Properties
	private bool IsNightTime { get; }

	// Methods

	// RVA: 0x5BF540 Offset: 0x5BE940 VA: 0x1805BF540
	private void UpdateVisual(string playerName) { }

	// RVA: 0x5BF400 Offset: 0x5BE800 VA: 0x1805BF400
	private void ApplySkullMaterials(Material[] mats) { }

	// RVA: 0x5BF4F0 Offset: 0x5BE8F0 VA: 0x1805BF4F0
	private void UpdateLights() { }

	// RVA: 0x5BF880 Offset: 0x5BEC80 VA: 0x1805BF880
	private bool get_IsNightTime() { }

	// RVA: 0x5BF480 Offset: 0x5BE880 VA: 0x1805BF480 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x5BF7F0 Offset: 0x5BEBF0 VA: 0x1805BF7F0
	public void .ctor() { }

}

