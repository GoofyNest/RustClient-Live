public class ParentInfo : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6302
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint uid; // 0x14
	public uint bone; // 0x18

	// Methods

	// RVA: 0x1F8F460 Offset: 0x1F8E860 VA: 0x181F8F460
	public static void ResetToPool(ParentInfo instance) { }

	// RVA: 0x1F8F3E0 Offset: 0x1F8E7E0 VA: 0x181F8F3E0
	public void ResetToPool() { }

	// RVA: 0x1F8F140 Offset: 0x1F8E540 VA: 0x181F8F140 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DB9660 Offset: 0x1DB8A60 VA: 0x181DB9660
	public void CopyTo(ParentInfo instance) { }

	// RVA: 0x1F8E340 Offset: 0x1F8D740 VA: 0x181F8E340
	public ParentInfo Copy() { }

	// RVA: 0x1F8EB90 Offset: 0x1F8DF90 VA: 0x181F8EB90
	public static ParentInfo Deserialize(Stream stream) { }

	// RVA: 0x1F8E3B0 Offset: 0x1F8D7B0 VA: 0x181F8E3B0
	public static ParentInfo DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F8E680 Offset: 0x1F8DA80 VA: 0x181F8E680
	public static ParentInfo DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F8ED50 Offset: 0x1F8E150 VA: 0x181F8ED50
	public static ParentInfo Deserialize(byte[] buffer) { }

	// RVA: 0x1F8F240 Offset: 0x1F8E640 VA: 0x181F8F240
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F8F920 Offset: 0x1F8ED20 VA: 0x181F8F920 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F8F940 Offset: 0x1F8ED40 VA: 0x181F8F940 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ParentInfo previous) { }

	// RVA: 0x1F8F3C0 Offset: 0x1F8E7C0 VA: 0x181F8F3C0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F8E940 Offset: 0x1F8DD40 VA: 0x181F8E940
	public static ParentInfo Deserialize(byte[] buffer, ParentInfo instance, bool isDelta = False) { }

	// RVA: 0x1F8EFC0 Offset: 0x1F8E3C0 VA: 0x181F8EFC0
	public static ParentInfo Deserialize(Stream stream, ParentInfo instance, bool isDelta) { }

	// RVA: 0x1F8E430 Offset: 0x1F8D830 VA: 0x181F8E430
	public static ParentInfo DeserializeLengthDelimited(Stream stream, ParentInfo instance, bool isDelta) { }

	// RVA: 0x1F8E710 Offset: 0x1F8DB10 VA: 0x181F8E710
	public static ParentInfo DeserializeLength(Stream stream, int length, ParentInfo instance, bool isDelta) { }

	// RVA: 0x1F8F4E0 Offset: 0x1F8E8E0 VA: 0x181F8F4E0
	public static void SerializeDelta(Stream stream, ParentInfo instance, ParentInfo previous) { }

	// RVA: 0x1F8F810 Offset: 0x1F8EC10 VA: 0x181F8F810
	public static void Serialize(Stream stream, ParentInfo instance) { }

	// RVA: 0x1F8F910 Offset: 0x1F8ED10 VA: 0x181F8F910
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F8F920 Offset: 0x1F8ED20 VA: 0x181F8F920
	public void ToProto(Stream stream) { }

	// RVA: 0x1F8F700 Offset: 0x1F8EB00 VA: 0x181F8F700
	public static byte[] SerializeToBytes(ParentInfo instance) { }

	// RVA: 0x1F8F650 Offset: 0x1F8EA50 VA: 0x181F8F650
	public static void SerializeLengthDelimited(Stream stream, ParentInfo instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

