public class Magazine : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6317
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int capacity; // 0x14
	public int contents; // 0x18
	public int ammoType; // 0x1C

	// Methods

	// RVA: 0x1F247D0 Offset: 0x1F23BD0 VA: 0x181F247D0
	public static void ResetToPool(Magazine instance) { }

	// RVA: 0x1F24740 Offset: 0x1F23B40 VA: 0x181F24740
	public void ResetToPool() { }

	// RVA: 0x1F24460 Offset: 0x1F23860 VA: 0x181F24460 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E231E0 Offset: 0x1E225E0 VA: 0x181E231E0
	public void CopyTo(Magazine instance) { }

	// RVA: 0x1F23530 Offset: 0x1F22930 VA: 0x181F23530
	public Magazine Copy() { }

	// RVA: 0x1F23FF0 Offset: 0x1F233F0 VA: 0x181F23FF0
	public static Magazine Deserialize(Stream stream) { }

	// RVA: 0x1F235B0 Offset: 0x1F229B0 VA: 0x181F235B0
	public static Magazine DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F23B10 Offset: 0x1F22F10 VA: 0x181F23B10
	public static Magazine DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F23BA0 Offset: 0x1F22FA0 VA: 0x181F23BA0
	public static Magazine Deserialize(byte[] buffer) { }

	// RVA: 0x1F24570 Offset: 0x1F23970 VA: 0x181F24570
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F24D10 Offset: 0x1F24110 VA: 0x181F24D10 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F24D30 Offset: 0x1F24130 VA: 0x181F24D30 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Magazine previous) { }

	// RVA: 0x1F24720 Offset: 0x1F23B20 VA: 0x181F24720 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F241E0 Offset: 0x1F235E0 VA: 0x181F241E0
	public static Magazine Deserialize(byte[] buffer, Magazine instance, bool isDelta = False) { }

	// RVA: 0x1F23E40 Offset: 0x1F23240 VA: 0x181F23E40
	public static Magazine Deserialize(Stream stream, Magazine instance, bool isDelta) { }

	// RVA: 0x1F23630 Offset: 0x1F22A30 VA: 0x181F23630
	public static Magazine DeserializeLengthDelimited(Stream stream, Magazine instance, bool isDelta) { }

	// RVA: 0x1F238B0 Offset: 0x1F22CB0 VA: 0x181F238B0
	public static Magazine DeserializeLength(Stream stream, int length, Magazine instance, bool isDelta) { }

	// RVA: 0x1F24860 Offset: 0x1F23C60 VA: 0x181F24860
	public static void SerializeDelta(Stream stream, Magazine instance, Magazine previous) { }

	// RVA: 0x1F24BE0 Offset: 0x1F23FE0 VA: 0x181F24BE0
	public static void Serialize(Stream stream, Magazine instance) { }

	// RVA: 0x1F24D00 Offset: 0x1F24100 VA: 0x181F24D00
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F24D10 Offset: 0x1F24110 VA: 0x181F24D10
	public void ToProto(Stream stream) { }

	// RVA: 0x1F24AD0 Offset: 0x1F23ED0 VA: 0x181F24AD0
	public static byte[] SerializeToBytes(Magazine instance) { }

	// RVA: 0x1F24A20 Offset: 0x1F23E20 VA: 0x181F24A20
	public static void SerializeLengthDelimited(Stream stream, Magazine instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

