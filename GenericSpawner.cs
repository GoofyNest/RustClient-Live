public class GenericSpawner : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6314
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<GenericSpawner.SpawnedEnt> ents; // 0x18

	// Methods

	// RVA: 0x1D5A1A0 Offset: 0x1D595A0 VA: 0x181D5A1A0
	public static void ResetToPool(GenericSpawner instance) { }

	// RVA: 0x1D59FF0 Offset: 0x1D593F0 VA: 0x181D59FF0
	public void ResetToPool() { }

	// RVA: 0x1D59D70 Offset: 0x1D59170 VA: 0x181D59D70 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1D58EE0 Offset: 0x1D582E0 VA: 0x181D58EE0
	public void CopyTo(GenericSpawner instance) { }

	// RVA: 0x1D59070 Offset: 0x1D58470 VA: 0x181D59070
	public GenericSpawner Copy() { }

	// RVA: 0x1D59BF0 Offset: 0x1D58FF0 VA: 0x181D59BF0
	public static GenericSpawner Deserialize(Stream stream) { }

	// RVA: 0x1D59530 Offset: 0x1D58930 VA: 0x181D59530
	public static GenericSpawner DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1D595B0 Offset: 0x1D589B0 VA: 0x181D595B0
	public static GenericSpawner DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1D598E0 Offset: 0x1D58CE0 VA: 0x181D598E0
	public static GenericSpawner Deserialize(byte[] buffer) { }

	// RVA: 0x1D59FB0 Offset: 0x1D593B0 VA: 0x181D59FB0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1D5A8E0 Offset: 0x1D59CE0 VA: 0x181D5A8E0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1D5A900 Offset: 0x1D59D00 VA: 0x181D5A900 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, GenericSpawner previous) { }

	// RVA: 0x1D59FD0 Offset: 0x1D593D0 VA: 0x181D59FD0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1D59C70 Offset: 0x1D59070 VA: 0x181D59C70
	public static GenericSpawner Deserialize(byte[] buffer, GenericSpawner instance, bool isDelta = False) { }

	// RVA: 0x1D59A00 Offset: 0x1D58E00 VA: 0x181D59A00
	public static GenericSpawner Deserialize(Stream stream, GenericSpawner instance, bool isDelta) { }

	// RVA: 0x1D59260 Offset: 0x1D58660 VA: 0x181D59260
	public static GenericSpawner DeserializeLengthDelimited(Stream stream, GenericSpawner instance, bool isDelta) { }

	// RVA: 0x1D59640 Offset: 0x1D58A40 VA: 0x181D59640
	public static GenericSpawner DeserializeLength(Stream stream, int length, GenericSpawner instance, bool isDelta) { }

	// RVA: 0x1D5A350 Offset: 0x1D59750 VA: 0x181D5A350
	public static void SerializeDelta(Stream stream, GenericSpawner instance, GenericSpawner previous) { }

	// RVA: 0x1D5A6F0 Offset: 0x1D59AF0 VA: 0x181D5A6F0
	public static void Serialize(Stream stream, GenericSpawner instance) { }

	// RVA: 0x1D5A8D0 Offset: 0x1D59CD0 VA: 0x181D5A8D0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1D5A8E0 Offset: 0x1D59CE0 VA: 0x181D5A8E0
	public void ToProto(Stream stream) { }

	// RVA: 0x1D5A5E0 Offset: 0x1D599E0 VA: 0x181D5A5E0
	public static byte[] SerializeToBytes(GenericSpawner instance) { }

	// RVA: 0x1D5A530 Offset: 0x1D59930 VA: 0x181D5A530
	public static void SerializeLengthDelimited(Stream stream, GenericSpawner instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class GenericSpawner.SpawnedEnt : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6315
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint uid; // 0x14
	public uint spawnPointIndex; // 0x18
	public bool mobile; // 0x1C

	// Methods

	// RVA: 0x1D64BA0 Offset: 0x1D63FA0 VA: 0x181D64BA0
	public static void ResetToPool(GenericSpawner.SpawnedEnt instance) { }

	// RVA: 0x1D64B10 Offset: 0x1D63F10 VA: 0x181D64B10
	public void ResetToPool() { }

	// RVA: 0x1D648C0 Offset: 0x1D63CC0 VA: 0x181D648C0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1D63960 Offset: 0x1D62D60 VA: 0x181D63960
	public void CopyTo(GenericSpawner.SpawnedEnt instance) { }

	// RVA: 0x1D63990 Offset: 0x1D62D90 VA: 0x181D63990
	public GenericSpawner.SpawnedEnt Copy() { }

	// RVA: 0x1D646D0 Offset: 0x1D63AD0 VA: 0x181D646D0
	public static GenericSpawner.SpawnedEnt Deserialize(Stream stream) { }

	// RVA: 0x1D63A10 Offset: 0x1D62E10 VA: 0x181D63A10
	public static GenericSpawner.SpawnedEnt DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1D63D10 Offset: 0x1D63110 VA: 0x181D63D10
	public static GenericSpawner.SpawnedEnt DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1D64000 Offset: 0x1D63400 VA: 0x181D64000
	public static GenericSpawner.SpawnedEnt Deserialize(byte[] buffer) { }

	// RVA: 0x1D64940 Offset: 0x1D63D40 VA: 0x181D64940
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1D650E0 Offset: 0x1D644E0 VA: 0x181D650E0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1D65100 Offset: 0x1D64500 VA: 0x181D65100 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, GenericSpawner.SpawnedEnt previous) { }

	// RVA: 0x1D64AF0 Offset: 0x1D63EF0 VA: 0x181D64AF0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1D64450 Offset: 0x1D63850 VA: 0x181D64450
	public static GenericSpawner.SpawnedEnt Deserialize(byte[] buffer, GenericSpawner.SpawnedEnt instance, bool isDelta = False) { }

	// RVA: 0x1D642A0 Offset: 0x1D636A0 VA: 0x181D642A0
	public static GenericSpawner.SpawnedEnt Deserialize(Stream stream, GenericSpawner.SpawnedEnt instance, bool isDelta) { }

	// RVA: 0x1D63A90 Offset: 0x1D62E90 VA: 0x181D63A90
	public static GenericSpawner.SpawnedEnt DeserializeLengthDelimited(Stream stream, GenericSpawner.SpawnedEnt instance, bool isDelta) { }

	// RVA: 0x1D63DA0 Offset: 0x1D631A0 VA: 0x181D63DA0
	public static GenericSpawner.SpawnedEnt DeserializeLength(Stream stream, int length, GenericSpawner.SpawnedEnt instance, bool isDelta) { }

	// RVA: 0x1D64C30 Offset: 0x1D64030 VA: 0x181D64C30
	public static void SerializeDelta(Stream stream, GenericSpawner.SpawnedEnt instance, GenericSpawner.SpawnedEnt previous) { }

	// RVA: 0x1D64FB0 Offset: 0x1D643B0 VA: 0x181D64FB0
	public static void Serialize(Stream stream, GenericSpawner.SpawnedEnt instance) { }

	// RVA: 0x1D650D0 Offset: 0x1D644D0 VA: 0x181D650D0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1D650E0 Offset: 0x1D644E0 VA: 0x181D650E0
	public void ToProto(Stream stream) { }

	// RVA: 0x1D64EA0 Offset: 0x1D642A0 VA: 0x181D64EA0
	public static byte[] SerializeToBytes(GenericSpawner.SpawnedEnt instance) { }

	// RVA: 0x1D64DF0 Offset: 0x1D641F0 VA: 0x181D64DF0
	public static void SerializeLengthDelimited(Stream stream, GenericSpawner.SpawnedEnt instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

