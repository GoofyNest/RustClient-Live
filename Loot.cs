public class Loot : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6313
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public ItemContainer contents; // 0x18

	// Methods

	// RVA: 0x1F1F1F0 Offset: 0x1F1E5F0 VA: 0x181F1F1F0
	public static void ResetToPool(Loot instance) { }

	// RVA: 0x1F1F150 Offset: 0x1F1E550 VA: 0x181F1F150
	public void ResetToPool() { }

	// RVA: 0x1F1EFF0 Offset: 0x1F1E3F0 VA: 0x181F1EFF0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DBAE10 Offset: 0x1DBA210 VA: 0x181DBAE10
	public void CopyTo(Loot instance) { }

	// RVA: 0x1F1E4B0 Offset: 0x1F1D8B0 VA: 0x181F1E4B0
	public Loot Copy() { }

	// RVA: 0x1F1ED50 Offset: 0x1F1E150 VA: 0x181F1ED50
	public static Loot Deserialize(Stream stream) { }

	// RVA: 0x1F1E580 Offset: 0x1F1D980 VA: 0x181F1E580
	public static Loot DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F1EAF0 Offset: 0x1F1DEF0 VA: 0x181F1EAF0
	public static Loot DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F1EED0 Offset: 0x1F1E2D0 VA: 0x181F1EED0
	public static Loot Deserialize(byte[] buffer) { }

	// RVA: 0x1F1F110 Offset: 0x1F1E510 VA: 0x181F1F110
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F1F780 Offset: 0x1F1EB80 VA: 0x181F1F780 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F1F7A0 Offset: 0x1F1EBA0 VA: 0x181F1F7A0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Loot previous) { }

	// RVA: 0x1F1F130 Offset: 0x1F1E530 VA: 0x181F1F130 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F1EDD0 Offset: 0x1F1E1D0 VA: 0x181F1EDD0
	public static Loot Deserialize(byte[] buffer, Loot instance, bool isDelta = False) { }

	// RVA: 0x1F1EB80 Offset: 0x1F1DF80 VA: 0x181F1EB80
	public static Loot Deserialize(Stream stream, Loot instance, bool isDelta) { }

	// RVA: 0x1F1E600 Offset: 0x1F1DA00 VA: 0x181F1E600
	public static Loot DeserializeLengthDelimited(Stream stream, Loot instance, bool isDelta) { }

	// RVA: 0x1F1E890 Offset: 0x1F1DC90 VA: 0x181F1E890
	public static Loot DeserializeLength(Stream stream, int length, Loot instance, bool isDelta) { }

	// RVA: 0x1F1F290 Offset: 0x1F1E690 VA: 0x181F1F290
	public static void SerializeDelta(Stream stream, Loot instance, Loot previous) { }

	// RVA: 0x1F1F5F0 Offset: 0x1F1E9F0 VA: 0x181F1F5F0
	public static void Serialize(Stream stream, Loot instance) { }

	// RVA: 0x1F1F770 Offset: 0x1F1EB70 VA: 0x181F1F770
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F1F780 Offset: 0x1F1EB80 VA: 0x181F1F780
	public void ToProto(Stream stream) { }

	// RVA: 0x1F1F4E0 Offset: 0x1F1E8E0 VA: 0x181F1F4E0
	public static byte[] SerializeToBytes(Loot instance) { }

	// RVA: 0x1F1F430 Offset: 0x1F1E830 VA: 0x181F1F430
	public static void SerializeLengthDelimited(Stream stream, Loot instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

