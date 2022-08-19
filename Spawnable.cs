public class Spawnable : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6336
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint population; // 0x14

	// Methods

	// RVA: 0x1DB1630 Offset: 0x1DB0A30 VA: 0x181DB1630
	public static void ResetToPool(Spawnable instance) { }

	// RVA: 0x1DB16B0 Offset: 0x1DB0AB0 VA: 0x181DB16B0
	public void ResetToPool() { }

	// RVA: 0x1DB1500 Offset: 0x1DB0900 VA: 0x181DB1500 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BF9250 Offset: 0x1BF8650 VA: 0x181BF9250
	public void CopyTo(Spawnable instance) { }

	// RVA: 0x1DB0B80 Offset: 0x1DAFF80 VA: 0x181DB0B80
	public Spawnable Copy() { }

	// RVA: 0x1DB1120 Offset: 0x1DB0520 VA: 0x181DB1120
	public static Spawnable Deserialize(Stream stream) { }

	// RVA: 0x1DB0BF0 Offset: 0x1DAFFF0 VA: 0x181DB0BF0
	public static Spawnable DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1DB1090 Offset: 0x1DB0490 VA: 0x181DB1090
	public static Spawnable DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1DB13E0 Offset: 0x1DB07E0 VA: 0x181DB13E0
	public static Spawnable Deserialize(byte[] buffer) { }

	// RVA: 0x1DB15F0 Offset: 0x1DB09F0 VA: 0x181DB15F0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1DB1B80 Offset: 0x1DB0F80 VA: 0x181DB1B80 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1DB1C50 Offset: 0x1DB1050 VA: 0x181DB1C50 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Spawnable previous) { }

	// RVA: 0x1DB1610 Offset: 0x1DB0A10 VA: 0x181DB1610 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1DB11A0 Offset: 0x1DB05A0 VA: 0x181DB11A0
	public static Spawnable Deserialize(byte[] buffer, Spawnable instance, bool isDelta = False) { }

	// RVA: 0x1DB12A0 Offset: 0x1DB06A0 VA: 0x181DB12A0
	public static Spawnable Deserialize(Stream stream, Spawnable instance, bool isDelta) { }

	// RVA: 0x1DB0C70 Offset: 0x1DB0070 VA: 0x181DB0C70
	public static Spawnable DeserializeLengthDelimited(Stream stream, Spawnable instance, bool isDelta) { }

	// RVA: 0x1DB0E90 Offset: 0x1DB0290 VA: 0x181DB0E90
	public static Spawnable DeserializeLength(Stream stream, int length, Spawnable instance, bool isDelta) { }

	// RVA: 0x1DB1730 Offset: 0x1DB0B30 VA: 0x181DB1730
	public static void SerializeDelta(Stream stream, Spawnable instance, Spawnable previous) { }

	// RVA: 0x1DB1AA0 Offset: 0x1DB0EA0 VA: 0x181DB1AA0
	public static void Serialize(Stream stream, Spawnable instance) { }

	// RVA: 0x1DB1B70 Offset: 0x1DB0F70 VA: 0x181DB1B70
	public byte[] ToProtoBytes() { }

	// RVA: 0x1DB1B80 Offset: 0x1DB0F80 VA: 0x181DB1B80
	public void ToProto(Stream stream) { }

	// RVA: 0x1DB18F0 Offset: 0x1DB0CF0 VA: 0x181DB18F0
	public static byte[] SerializeToBytes(Spawnable instance) { }

	// RVA: 0x1DB1840 Offset: 0x1DB0C40 VA: 0x181DB1840
	public static void SerializeLengthDelimited(Stream stream, Spawnable instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class Spawnable : MonoBehaviour, IServerComponent // TypeDefIndex: 9995
{	// Fields
	[ReadOnlyAttribute] // RVA: 0x70A20 Offset: 0x6FE20 VA: 0x180070A20
	public SpawnPopulation Population; // 0x18
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool ForceSpawnOnly; // 0x20
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string ForceSpawnInfoMessage; // 0x28

	// Methods

	// RVA: 0xA792C0 Offset: 0xA786C0 VA: 0x180A792C0
	protected void OnValidate() { }

	// RVA: 0xA792E0 Offset: 0xA786E0 VA: 0x180A792E0
	public void .ctor() { }

}

