public class OwnerInfo : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6334
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public ulong steamid; // 0x18

	// Methods

	// RVA: 0x1F8AAF0 Offset: 0x1F89EF0 VA: 0x181F8AAF0
	public static void ResetToPool(OwnerInfo instance) { }

	// RVA: 0x1F8AA70 Offset: 0x1F89E70 VA: 0x181F8AA70
	public void ResetToPool() { }

	// RVA: 0x1F8A940 Offset: 0x1F89D40 VA: 0x181F8A940 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F17770 Offset: 0x1F16B70 VA: 0x181F17770
	public void CopyTo(OwnerInfo instance) { }

	// RVA: 0x1F89FC0 Offset: 0x1F893C0 VA: 0x181F89FC0
	public OwnerInfo Copy() { }

	// RVA: 0x1F8A7A0 Offset: 0x1F89BA0 VA: 0x181F8A7A0
	public static OwnerInfo Deserialize(Stream stream) { }

	// RVA: 0x1F8A250 Offset: 0x1F89650 VA: 0x181F8A250
	public static OwnerInfo DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F8A2D0 Offset: 0x1F896D0 VA: 0x181F8A2D0
	public static OwnerInfo DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F8A820 Offset: 0x1F89C20 VA: 0x181F8A820
	public static OwnerInfo Deserialize(byte[] buffer) { }

	// RVA: 0x1F8AA30 Offset: 0x1F89E30 VA: 0x181F8AA30
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F8AFC0 Offset: 0x1F8A3C0 VA: 0x181F8AFC0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F8B090 Offset: 0x1F8A490 VA: 0x181F8B090 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, OwnerInfo previous) { }

	// RVA: 0x1F8AA50 Offset: 0x1F89E50 VA: 0x181F8AA50 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F8A560 Offset: 0x1F89960 VA: 0x181F8A560
	public static OwnerInfo Deserialize(byte[] buffer, OwnerInfo instance, bool isDelta = False) { }

	// RVA: 0x1F8A660 Offset: 0x1F89A60 VA: 0x181F8A660
	public static OwnerInfo Deserialize(Stream stream, OwnerInfo instance, bool isDelta) { }

	// RVA: 0x1F8A030 Offset: 0x1F89430 VA: 0x181F8A030
	public static OwnerInfo DeserializeLengthDelimited(Stream stream, OwnerInfo instance, bool isDelta) { }

	// RVA: 0x1F8A360 Offset: 0x1F89760 VA: 0x181F8A360
	public static OwnerInfo DeserializeLength(Stream stream, int length, OwnerInfo instance, bool isDelta) { }

	// RVA: 0x1F8AB70 Offset: 0x1F89F70 VA: 0x181F8AB70
	public static void SerializeDelta(Stream stream, OwnerInfo instance, OwnerInfo previous) { }

	// RVA: 0x1F8AEE0 Offset: 0x1F8A2E0 VA: 0x181F8AEE0
	public static void Serialize(Stream stream, OwnerInfo instance) { }

	// RVA: 0x1F8AFB0 Offset: 0x1F8A3B0 VA: 0x181F8AFB0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F8AFC0 Offset: 0x1F8A3C0 VA: 0x181F8AFC0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F8AD30 Offset: 0x1F8A130 VA: 0x181F8AD30
	public static byte[] SerializeToBytes(OwnerInfo instance) { }

	// RVA: 0x1F8AC80 Offset: 0x1F8A080 VA: 0x181F8AC80
	public static void SerializeLengthDelimited(Stream stream, OwnerInfo instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

