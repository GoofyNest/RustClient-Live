public class ModuleMessage : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6490
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint itemid; // 0x14
	public int moduleid; // 0x18
	public int type; // 0x1C
	public byte[] data; // 0x20

	// Methods

	// RVA: 0x1F84860 Offset: 0x1F83C60 VA: 0x181F84860
	public static void ResetToPool(ModuleMessage instance) { }

	// RVA: 0x1F847B0 Offset: 0x1F83BB0 VA: 0x181F847B0
	public void ResetToPool() { }

	// RVA: 0x1F84440 Offset: 0x1F83840 VA: 0x181F84440 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F83110 Offset: 0x1F82510 VA: 0x181F83110
	public void CopyTo(ModuleMessage instance) { }

	// RVA: 0x1F831C0 Offset: 0x1F825C0 VA: 0x181F831C0
	public ModuleMessage Copy() { }

	// RVA: 0x1F83EC0 Offset: 0x1F832C0 VA: 0x181F83EC0
	public static ModuleMessage Deserialize(Stream stream) { }

	// RVA: 0x1F832D0 Offset: 0x1F826D0 VA: 0x181F832D0
	public static ModuleMessage DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F83640 Offset: 0x1F82A40 VA: 0x181F83640
	public static ModuleMessage DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F84120 Offset: 0x1F83520 VA: 0x181F84120
	public static ModuleMessage Deserialize(byte[] buffer) { }

	// RVA: 0x1F84570 Offset: 0x1F83970 VA: 0x181F84570
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F84E90 Offset: 0x1F84290 VA: 0x181F84E90 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F84EB0 Offset: 0x1F842B0 VA: 0x181F84EB0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ModuleMessage previous) { }

	// RVA: 0x1F84790 Offset: 0x1F83B90 VA: 0x181F84790 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F83BC0 Offset: 0x1F82FC0 VA: 0x181F83BC0
	public static ModuleMessage Deserialize(byte[] buffer, ModuleMessage instance, bool isDelta = False) { }

	// RVA: 0x1F839A0 Offset: 0x1F82DA0 VA: 0x181F839A0
	public static ModuleMessage Deserialize(Stream stream, ModuleMessage instance, bool isDelta) { }

	// RVA: 0x1F83350 Offset: 0x1F82750 VA: 0x181F83350
	public static ModuleMessage DeserializeLengthDelimited(Stream stream, ModuleMessage instance, bool isDelta) { }

	// RVA: 0x1F836D0 Offset: 0x1F82AD0 VA: 0x181F836D0
	public static ModuleMessage DeserializeLength(Stream stream, int length, ModuleMessage instance, bool isDelta) { }

	// RVA: 0x1F84910 Offset: 0x1F83D10 VA: 0x181F84910
	public static void SerializeDelta(Stream stream, ModuleMessage instance, ModuleMessage previous) { }

	// RVA: 0x1F84CF0 Offset: 0x1F840F0 VA: 0x181F84CF0
	public static void Serialize(Stream stream, ModuleMessage instance) { }

	// RVA: 0x1F84E80 Offset: 0x1F84280 VA: 0x181F84E80
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F84E90 Offset: 0x1F84290 VA: 0x181F84E90
	public void ToProto(Stream stream) { }

	// RVA: 0x1F84BE0 Offset: 0x1F83FE0 VA: 0x181F84BE0
	public static byte[] SerializeToBytes(ModuleMessage instance) { }

	// RVA: 0x1F84B30 Offset: 0x1F83F30 VA: 0x181F84B30
	public static void SerializeLengthDelimited(Stream stream, ModuleMessage instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

