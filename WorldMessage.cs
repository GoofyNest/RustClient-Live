public class WorldMessage : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6498
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public WorldMessage.MessageType status; // 0x14
	public List<PrefabData> prefabs; // 0x18
	public List<PathData> paths; // 0x20

	// Methods

	// RVA: 0x1E542B0 Offset: 0x1E536B0 VA: 0x181E542B0
	public static void ResetToPool(WorldMessage instance) { }

	// RVA: 0x1E545C0 Offset: 0x1E539C0 VA: 0x181E545C0
	public void ResetToPool() { }

	// RVA: 0x1E541F0 Offset: 0x1E535F0 VA: 0x181E541F0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E52EF0 Offset: 0x1E522F0 VA: 0x181E52EF0
	public void CopyTo(WorldMessage instance) { }

	// RVA: 0x1E53110 Offset: 0x1E52510 VA: 0x181E53110
	public WorldMessage Copy() { }

	// RVA: 0x1E53F70 Offset: 0x1E53370 VA: 0x181E53F70
	public static WorldMessage Deserialize(Stream stream) { }

	// RVA: 0x1E53190 Offset: 0x1E52590 VA: 0x181E53190
	public static WorldMessage DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E53540 Offset: 0x1E52940 VA: 0x181E53540
	public static WorldMessage DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E53C40 Offset: 0x1E53040 VA: 0x181E53C40
	public static WorldMessage Deserialize(byte[] buffer) { }

	// RVA: 0x1E54270 Offset: 0x1E53670 VA: 0x181E54270
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E55350 Offset: 0x1E54750 VA: 0x181E55350 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E55370 Offset: 0x1E54770 VA: 0x181E55370 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, WorldMessage previous) { }

	// RVA: 0x1E54290 Offset: 0x1E53690 VA: 0x181E54290 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E53B40 Offset: 0x1E52F40 VA: 0x181E53B40
	public static WorldMessage Deserialize(byte[] buffer, WorldMessage instance, bool isDelta = False) { }

	// RVA: 0x1E538F0 Offset: 0x1E52CF0 VA: 0x181E538F0
	public static WorldMessage Deserialize(Stream stream, WorldMessage instance, bool isDelta) { }

	// RVA: 0x1E53210 Offset: 0x1E52610 VA: 0x181E53210
	public static WorldMessage DeserializeLengthDelimited(Stream stream, WorldMessage instance, bool isDelta) { }

	// RVA: 0x1E535D0 Offset: 0x1E529D0 VA: 0x181E535D0
	public static WorldMessage DeserializeLength(Stream stream, int length, WorldMessage instance, bool isDelta) { }

	// RVA: 0x1E548D0 Offset: 0x1E53CD0 VA: 0x181E548D0
	public static void SerializeDelta(Stream stream, WorldMessage instance, WorldMessage previous) { }

	// RVA: 0x1E54F10 Offset: 0x1E54310 VA: 0x181E54F10
	public static void Serialize(Stream stream, WorldMessage instance) { }

	// RVA: 0x1E55340 Offset: 0x1E54740 VA: 0x181E55340
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E55350 Offset: 0x1E54750 VA: 0x181E55350
	public void ToProto(Stream stream) { }

	// RVA: 0x1E54E00 Offset: 0x1E54200 VA: 0x181E54E00
	public static byte[] SerializeToBytes(WorldMessage instance) { }

	// RVA: 0x1E54D10 Offset: 0x1E54110 VA: 0x181E54D10
	public static void SerializeLengthDelimited(Stream stream, WorldMessage instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public enum WorldMessage.MessageType // TypeDefIndex: 6499
{	// Fields
	public int value__; // 0x0
	public const WorldMessage.MessageType Request = 1;
	public const WorldMessage.MessageType Receive = 2;
	public const WorldMessage.MessageType Done = 3;

}

