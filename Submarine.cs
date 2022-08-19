public class Submarine : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6418
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float throttle; // 0x14
	public float upDown; // 0x18
	public float rudder; // 0x1C
	public uint fuelStorageID; // 0x20
	public float fuelAmount; // 0x24
	public uint torpedoStorageID; // 0x28
	public float oxygen; // 0x2C
	public uint itemStorageID; // 0x30

	// Methods

	// RVA: 0x1DBF5D0 Offset: 0x1DBE9D0 VA: 0x181DBF5D0
	public static void ResetToPool(Submarine instance) { }

	// RVA: 0x1DBF6B0 Offset: 0x1DBEAB0 VA: 0x181DBF6B0
	public void ResetToPool() { }

	// RVA: 0x1DBF110 Offset: 0x1DBE510 VA: 0x181DBF110 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DBD830 Offset: 0x1DBCC30 VA: 0x181DBD830
	public void CopyTo(Submarine instance) { }

	// RVA: 0x1DBD880 Offset: 0x1DBCC80 VA: 0x181DBD880
	public Submarine Copy() { }

	// RVA: 0x1DBE980 Offset: 0x1DBDD80 VA: 0x181DBE980
	public static Submarine Deserialize(Stream stream) { }

	// RVA: 0x1DBDD20 Offset: 0x1DBD120 VA: 0x181DBDD20
	public static Submarine DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1DBDDA0 Offset: 0x1DBD1A0 VA: 0x181DBDDA0
	public static Submarine DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1DBE540 Offset: 0x1DBD940 VA: 0x181DBE540
	public static Submarine Deserialize(byte[] buffer) { }

	// RVA: 0x1DBF280 Offset: 0x1DBE680 VA: 0x181DBF280
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1DBFED0 Offset: 0x1DBF2D0 VA: 0x181DBFED0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1DBFEF0 Offset: 0x1DBF2F0 VA: 0x181DBFEF0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Submarine previous) { }

	// RVA: 0x1DBF5B0 Offset: 0x1DBE9B0 VA: 0x181DBF5B0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1DBECF0 Offset: 0x1DBE0F0 VA: 0x181DBECF0
	public static Submarine Deserialize(byte[] buffer, Submarine instance, bool isDelta = False) { }

	// RVA: 0x1DBE210 Offset: 0x1DBD610 VA: 0x181DBE210
	public static Submarine Deserialize(Stream stream, Submarine instance, bool isDelta) { }

	// RVA: 0x1DBD920 Offset: 0x1DBCD20 VA: 0x181DBD920
	public static Submarine DeserializeLengthDelimited(Stream stream, Submarine instance, bool isDelta) { }

	// RVA: 0x1DBDE30 Offset: 0x1DBD230 VA: 0x181DBDE30
	public static Submarine DeserializeLength(Stream stream, int length, Submarine instance, bool isDelta) { }

	// RVA: 0x1DBF790 Offset: 0x1DBEB90 VA: 0x181DBF790
	public static void SerializeDelta(Stream stream, Submarine instance, Submarine previous) { }

	// RVA: 0x1DBFCE0 Offset: 0x1DBF0E0 VA: 0x181DBFCE0
	public static void Serialize(Stream stream, Submarine instance) { }

	// RVA: 0x1DBFEC0 Offset: 0x1DBF2C0 VA: 0x181DBFEC0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1DBFED0 Offset: 0x1DBF2D0 VA: 0x181DBFED0
	public void ToProto(Stream stream) { }

	// RVA: 0x1DBFBD0 Offset: 0x1DBEFD0 VA: 0x181DBFBD0
	public static byte[] SerializeToBytes(Submarine instance) { }

	// RVA: 0x1DBFB20 Offset: 0x1DBEF20 VA: 0x181DBFB20
	public static void SerializeLengthDelimited(Stream stream, Submarine instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

