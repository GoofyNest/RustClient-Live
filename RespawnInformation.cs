public class RespawnInformation : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6491
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<RespawnInformation.SpawnOptions> spawnOptions; // 0x18
	public PlayerLifeStory previousLife; // 0x20
	public bool fadeIn; // 0x28

	// Methods

	// RVA: 0x1E00630 Offset: 0x1DFFA30 VA: 0x181E00630
	public static void ResetToPool(RespawnInformation instance) { }

	// RVA: 0x1E00850 Offset: 0x1DFFC50 VA: 0x181E00850
	public void ResetToPool() { }

	// RVA: 0x1E00570 Offset: 0x1DFF970 VA: 0x181E00570 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DFF620 Offset: 0x1DFEA20 VA: 0x181DFF620
	public void CopyTo(RespawnInformation instance) { }

	// RVA: 0x1DFF840 Offset: 0x1DFEC40 VA: 0x181DFF840
	public RespawnInformation Copy() { }

	// RVA: 0x1E003D0 Offset: 0x1DFF7D0 VA: 0x181E003D0
	public static RespawnInformation Deserialize(Stream stream) { }

	// RVA: 0x1DFF8C0 Offset: 0x1DFECC0 VA: 0x181DFF8C0
	public static RespawnInformation DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1DFFFB0 Offset: 0x1DFF3B0 VA: 0x181DFFFB0
	public static RespawnInformation DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E00450 Offset: 0x1DFF850 VA: 0x181E00450
	public static RespawnInformation Deserialize(byte[] buffer) { }

	// RVA: 0x1E005F0 Offset: 0x1DFF9F0 VA: 0x181E005F0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E01280 Offset: 0x1E00680 VA: 0x181E01280 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E012A0 Offset: 0x1E006A0 VA: 0x181E012A0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, RespawnInformation previous) { }

	// RVA: 0x1E00610 Offset: 0x1DFFA10 VA: 0x181E00610 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E00040 Offset: 0x1DFF440 VA: 0x181E00040
	public static RespawnInformation Deserialize(byte[] buffer, RespawnInformation instance, bool isDelta = False) { }

	// RVA: 0x1E00140 Offset: 0x1DFF540 VA: 0x181E00140
	public static RespawnInformation Deserialize(Stream stream, RespawnInformation instance, bool isDelta) { }

	// RVA: 0x1DFF940 Offset: 0x1DFED40 VA: 0x181DFF940
	public static RespawnInformation DeserializeLengthDelimited(Stream stream, RespawnInformation instance, bool isDelta) { }

	// RVA: 0x1DFFC90 Offset: 0x1DFF090 VA: 0x181DFFC90
	public static RespawnInformation DeserializeLength(Stream stream, int length, RespawnInformation instance, bool isDelta) { }

	// RVA: 0x1E00A70 Offset: 0x1DFFE70 VA: 0x181E00A70
	public static void SerializeDelta(Stream stream, RespawnInformation instance, RespawnInformation previous) { }

	// RVA: 0x1E00F60 Offset: 0x1E00360 VA: 0x181E00F60
	public static void Serialize(Stream stream, RespawnInformation instance) { }

	// RVA: 0x1E01270 Offset: 0x1E00670 VA: 0x181E01270
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E01280 Offset: 0x1E00680 VA: 0x181E01280
	public void ToProto(Stream stream) { }

	// RVA: 0x1E00E50 Offset: 0x1E00250 VA: 0x181E00E50
	public static byte[] SerializeToBytes(RespawnInformation instance) { }

	// RVA: 0x1E00DA0 Offset: 0x1E001A0 VA: 0x181E00DA0
	public static void SerializeLengthDelimited(Stream stream, RespawnInformation instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class RespawnInformation.SpawnOptions : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6492
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public RespawnInformation.SpawnOptions.RespawnType type; // 0x14
	public uint id; // 0x18
	public string name; // 0x20
	public float unlockSeconds; // 0x28
	public Vector3 worldPosition; // 0x2C
	public bool occupied; // 0x38

	// Methods

	// RVA: 0x1E0B410 Offset: 0x1E0A810 VA: 0x181E0B410
	public static void ResetToPool(RespawnInformation.SpawnOptions instance) { }

	// RVA: 0x1E0B320 Offset: 0x1E0A720 VA: 0x181E0B320
	public void ResetToPool() { }

	// RVA: 0x1E0AFE0 Offset: 0x1E0A3E0 VA: 0x181E0AFE0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E09790 Offset: 0x1E08B90 VA: 0x181E09790
	public void CopyTo(RespawnInformation.SpawnOptions instance) { }

	// RVA: 0x1E097F0 Offset: 0x1E08BF0 VA: 0x181E097F0
	public RespawnInformation.SpawnOptions Copy() { }

	// RVA: 0x1E0A360 Offset: 0x1E09760 VA: 0x181E0A360
	public static RespawnInformation.SpawnOptions Deserialize(Stream stream) { }

	// RVA: 0x1E09C10 Offset: 0x1E09010 VA: 0x181E09C10
	public static RespawnInformation.SpawnOptions DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E09C90 Offset: 0x1E09090 VA: 0x181E09C90
	public static RespawnInformation.SpawnOptions DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E0AC50 Offset: 0x1E0A050 VA: 0x181E0AC50
	public static RespawnInformation.SpawnOptions Deserialize(byte[] buffer) { }

	// RVA: 0x1E0B060 Offset: 0x1E0A460 VA: 0x181E0B060
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E0BDB0 Offset: 0x1E0B1B0 VA: 0x181E0BDB0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E0BDD0 Offset: 0x1E0B1D0 VA: 0x181E0BDD0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, RespawnInformation.SpawnOptions previous) { }

	// RVA: 0x1E0B300 Offset: 0x1E0A700 VA: 0x181E0B300 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E0A640 Offset: 0x1E09A40 VA: 0x181E0A640
	public static RespawnInformation.SpawnOptions Deserialize(byte[] buffer, RespawnInformation.SpawnOptions instance, bool isDelta = False) { }

	// RVA: 0x1E0A9A0 Offset: 0x1E09DA0 VA: 0x181E0A9A0
	public static RespawnInformation.SpawnOptions Deserialize(Stream stream, RespawnInformation.SpawnOptions instance, bool isDelta) { }

	// RVA: 0x1E098A0 Offset: 0x1E08CA0 VA: 0x181E098A0
	public static RespawnInformation.SpawnOptions DeserializeLengthDelimited(Stream stream, RespawnInformation.SpawnOptions instance, bool isDelta) { }

	// RVA: 0x1E0A020 Offset: 0x1E09420 VA: 0x181E0A020
	public static RespawnInformation.SpawnOptions DeserializeLength(Stream stream, int length, RespawnInformation.SpawnOptions instance, bool isDelta) { }

	// RVA: 0x1E0B500 Offset: 0x1E0A900 VA: 0x181E0B500
	public static void SerializeDelta(Stream stream, RespawnInformation.SpawnOptions instance, RespawnInformation.SpawnOptions previous) { }

	// RVA: 0x1E0BAE0 Offset: 0x1E0AEE0 VA: 0x181E0BAE0
	public static void Serialize(Stream stream, RespawnInformation.SpawnOptions instance) { }

	// RVA: 0x1E0BDA0 Offset: 0x1E0B1A0 VA: 0x181E0BDA0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E0BDB0 Offset: 0x1E0B1B0 VA: 0x181E0BDB0
	public void ToProto(Stream stream) { }

	// RVA: 0x1E0B9D0 Offset: 0x1E0ADD0 VA: 0x181E0B9D0
	public static byte[] SerializeToBytes(RespawnInformation.SpawnOptions instance) { }

	// RVA: 0x1E0B920 Offset: 0x1E0AD20 VA: 0x181E0B920
	public static void SerializeLengthDelimited(Stream stream, RespawnInformation.SpawnOptions instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public enum RespawnInformation.SpawnOptions.RespawnType // TypeDefIndex: 6493
{	// Fields
	public int value__; // 0x0
	public const RespawnInformation.SpawnOptions.RespawnType SleepingBag = 1;
	public const RespawnInformation.SpawnOptions.RespawnType Bed = 2;
	public const RespawnInformation.SpawnOptions.RespawnType BeachTowel = 3;
	public const RespawnInformation.SpawnOptions.RespawnType Camper = 4;

}

