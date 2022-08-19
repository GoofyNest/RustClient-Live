public class MemoryBank : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6555
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int type; // 0x14
	public int slotCount; // 0x18
	public List<int> slots; // 0x20

	// Methods

	// RVA: 0x1F40020 Offset: 0x1F3F420 VA: 0x181F40020
	public static void ResetToPool(MemoryBank instance) { }

	// RVA: 0x1F3FF20 Offset: 0x1F3F320 VA: 0x181F3FF20
	public void ResetToPool() { }

	// RVA: 0x1F3FD70 Offset: 0x1F3F170 VA: 0x181F3FD70 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F3EB80 Offset: 0x1F3DF80 VA: 0x181F3EB80
	public void CopyTo(MemoryBank instance) { }

	// RVA: 0x1F3ECA0 Offset: 0x1F3E0A0 VA: 0x181F3ECA0
	public MemoryBank Copy() { }

	// RVA: 0x1F3F740 Offset: 0x1F3EB40 VA: 0x181F3F740
	public static MemoryBank Deserialize(Stream stream) { }

	// RVA: 0x1F3F110 Offset: 0x1F3E510 VA: 0x181F3F110
	public static MemoryBank DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F3F190 Offset: 0x1F3E590 VA: 0x181F3F190
	public static MemoryBank DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F3F980 Offset: 0x1F3ED80 VA: 0x181F3F980
	public static MemoryBank Deserialize(byte[] buffer) { }

	// RVA: 0x1F3FEE0 Offset: 0x1F3F2E0 VA: 0x181F3FEE0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F406A0 Offset: 0x1F3FAA0 VA: 0x181F406A0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F406C0 Offset: 0x1F3FAC0 VA: 0x181F406C0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, MemoryBank previous) { }

	// RVA: 0x1F3FF00 Offset: 0x1F3F300 VA: 0x181F3FF00 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F3FC70 Offset: 0x1F3F070 VA: 0x181F3FC70
	public static MemoryBank Deserialize(byte[] buffer, MemoryBank instance, bool isDelta = False) { }

	// RVA: 0x1F3F510 Offset: 0x1F3E910 VA: 0x181F3F510
	public static MemoryBank Deserialize(Stream stream, MemoryBank instance, bool isDelta) { }

	// RVA: 0x1F3EE10 Offset: 0x1F3E210 VA: 0x181F3EE10
	public static MemoryBank DeserializeLengthDelimited(Stream stream, MemoryBank instance, bool isDelta) { }

	// RVA: 0x1F3F220 Offset: 0x1F3E620 VA: 0x181F3F220
	public static MemoryBank DeserializeLength(Stream stream, int length, MemoryBank instance, bool isDelta) { }

	// RVA: 0x1F40120 Offset: 0x1F3F520 VA: 0x181F40120
	public static void SerializeDelta(Stream stream, MemoryBank instance, MemoryBank previous) { }

	// RVA: 0x1F404E0 Offset: 0x1F3F8E0 VA: 0x181F404E0
	public static void Serialize(Stream stream, MemoryBank instance) { }

	// RVA: 0x1F40690 Offset: 0x1F3FA90 VA: 0x181F40690
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F406A0 Offset: 0x1F3FAA0 VA: 0x181F406A0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F403D0 Offset: 0x1F3F7D0 VA: 0x181F403D0
	public static byte[] SerializeToBytes(MemoryBank instance) { }

	// RVA: 0x1F40320 Offset: 0x1F3F720 VA: 0x181F40320
	public static void SerializeLengthDelimited(Stream stream, MemoryBank instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

