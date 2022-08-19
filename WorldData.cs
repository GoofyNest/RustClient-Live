public class WorldData : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6507
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint size; // 0x14
	public List<MapData> maps; // 0x18
	public List<PrefabData> prefabs; // 0x20
	public List<PathData> paths; // 0x28

	// Methods

	// RVA: 0x1E50590 Offset: 0x1E4F990 VA: 0x181E50590
	public static void ResetToPool(WorldData instance) { }

	// RVA: 0x1E509C0 Offset: 0x1E4FDC0 VA: 0x181E509C0
	public void ResetToPool() { }

	// RVA: 0x1E504D0 Offset: 0x1E4F8D0 VA: 0x181E504D0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E4F360 Offset: 0x1E4E760 VA: 0x181E4F360
	public void CopyTo(WorldData instance) { }

	// RVA: 0x1E4F660 Offset: 0x1E4EA60 VA: 0x181E4F660
	public WorldData Copy() { }

	// RVA: 0x1E50330 Offset: 0x1E4F730 VA: 0x181E50330
	public static WorldData Deserialize(Stream stream) { }

	// RVA: 0x1E4FAA0 Offset: 0x1E4EEA0 VA: 0x181E4FAA0
	public static WorldData DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E4FB20 Offset: 0x1E4EF20 VA: 0x181E4FB20
	public static WorldData DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E503B0 Offset: 0x1E4F7B0 VA: 0x181E503B0
	public static WorldData Deserialize(byte[] buffer) { }

	// RVA: 0x1E50550 Offset: 0x1E4F950 VA: 0x181E50550
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E51B50 Offset: 0x1E50F50 VA: 0x181E51B50 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E51B70 Offset: 0x1E50F70 VA: 0x181E51B70 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, WorldData previous) { }

	// RVA: 0x1E50570 Offset: 0x1E4F970 VA: 0x181E50570 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E50230 Offset: 0x1E4F630 VA: 0x181E50230
	public static WorldData Deserialize(byte[] buffer, WorldData instance, bool isDelta = False) { }

	// RVA: 0x1E4FF50 Offset: 0x1E4F350 VA: 0x181E4FF50
	public static WorldData Deserialize(Stream stream, WorldData instance, bool isDelta) { }

	// RVA: 0x1E4F6E0 Offset: 0x1E4EAE0 VA: 0x181E4F6E0
	public static WorldData DeserializeLengthDelimited(Stream stream, WorldData instance, bool isDelta) { }

	// RVA: 0x1E4FBB0 Offset: 0x1E4EFB0 VA: 0x181E4FBB0
	public static WorldData DeserializeLength(Stream stream, int length, WorldData instance, bool isDelta) { }

	// RVA: 0x1E50DF0 Offset: 0x1E501F0 VA: 0x181E50DF0
	public static void SerializeDelta(Stream stream, WorldData instance, WorldData previous) { }

	// RVA: 0x1E515B0 Offset: 0x1E509B0 VA: 0x181E515B0
	public static void Serialize(Stream stream, WorldData instance) { }

	// RVA: 0x1E51B40 Offset: 0x1E50F40 VA: 0x181E51B40
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E51B50 Offset: 0x1E50F50 VA: 0x181E51B50
	public void ToProto(Stream stream) { }

	// RVA: 0x1E514A0 Offset: 0x1E508A0 VA: 0x181E514A0
	public static byte[] SerializeToBytes(WorldData instance) { }

	// RVA: 0x1E513B0 Offset: 0x1E507B0 VA: 0x181E513B0
	public static void SerializeLengthDelimited(Stream stream, WorldData instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

