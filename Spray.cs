public class Spray : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6430
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public ulong sprayedBy; // 0x18
	public long timestamp; // 0x20

	// Methods

	// RVA: 0x1DB9000 Offset: 0x1DB8400 VA: 0x181DB9000
	public static void ResetToPool(Spray instance) { }

	// RVA: 0x1DB8F70 Offset: 0x1DB8370 VA: 0x181DB8F70
	public void ResetToPool() { }

	// RVA: 0x1DB8CD0 Offset: 0x1DB80D0 VA: 0x181DB8CD0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DB7EA0 Offset: 0x1DB72A0 VA: 0x181DB7EA0
	public void CopyTo(Spray instance) { }

	// RVA: 0x1DB7ED0 Offset: 0x1DB72D0 VA: 0x181DB7ED0
	public Spray Copy() { }

	// RVA: 0x1DB88A0 Offset: 0x1DB7CA0 VA: 0x181DB88A0
	public static Spray Deserialize(Stream stream) { }

	// RVA: 0x1DB8190 Offset: 0x1DB7590 VA: 0x181DB8190
	public static Spray DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1DB8440 Offset: 0x1DB7840 VA: 0x181DB8440
	public static Spray DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1DB8A60 Offset: 0x1DB7E60 VA: 0x181DB8A60
	public static Spray Deserialize(byte[] buffer) { }

	// RVA: 0x1DB8DD0 Offset: 0x1DB81D0 VA: 0x181DB8DD0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1DB94C0 Offset: 0x1DB88C0 VA: 0x181DB94C0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1DB94E0 Offset: 0x1DB88E0 VA: 0x181DB94E0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Spray previous) { }

	// RVA: 0x1DB8F50 Offset: 0x1DB8350 VA: 0x181DB8F50 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1DB8650 Offset: 0x1DB7A50 VA: 0x181DB8650
	public static Spray Deserialize(byte[] buffer, Spray instance, bool isDelta = False) { }

	// RVA: 0x1DB84D0 Offset: 0x1DB78D0 VA: 0x181DB84D0
	public static Spray Deserialize(Stream stream, Spray instance, bool isDelta) { }

	// RVA: 0x1DB7F40 Offset: 0x1DB7340 VA: 0x181DB7F40
	public static Spray DeserializeLengthDelimited(Stream stream, Spray instance, bool isDelta) { }

	// RVA: 0x1DB8210 Offset: 0x1DB7610 VA: 0x181DB8210
	public static Spray DeserializeLength(Stream stream, int length, Spray instance, bool isDelta) { }

	// RVA: 0x1DB9090 Offset: 0x1DB8490 VA: 0x181DB9090
	public static void SerializeDelta(Stream stream, Spray instance, Spray previous) { }

	// RVA: 0x1DB93B0 Offset: 0x1DB87B0 VA: 0x181DB93B0
	public static void Serialize(Stream stream, Spray instance) { }

	// RVA: 0x1DB94B0 Offset: 0x1DB88B0 VA: 0x181DB94B0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1DB94C0 Offset: 0x1DB88C0 VA: 0x181DB94C0
	public void ToProto(Stream stream) { }

	// RVA: 0x1DB92A0 Offset: 0x1DB86A0 VA: 0x181DB92A0
	public static byte[] SerializeToBytes(Spray instance) { }

	// RVA: 0x1DB91F0 Offset: 0x1DB85F0 VA: 0x181DB91F0
	public static void SerializeLengthDelimited(Stream stream, Spray instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

