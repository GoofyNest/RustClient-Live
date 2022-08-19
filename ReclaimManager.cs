public class ReclaimManager : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6403
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<ReclaimManager.ReclaimInfo> reclaimEntries; // 0x18
	public int lastReclaimID; // 0x20

	// Methods

	// RVA: 0x1DF91E0 Offset: 0x1DF85E0 VA: 0x181DF91E0
	public static void ResetToPool(ReclaimManager instance) { }

	// RVA: 0x1DF9000 Offset: 0x1DF8400 VA: 0x181DF9000
	public void ResetToPool() { }

	// RVA: 0x1DF8F40 Offset: 0x1DF8340 VA: 0x181DF8F40 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DF80E0 Offset: 0x1DF74E0 VA: 0x181DF80E0
	public void CopyTo(ReclaimManager instance) { }

	// RVA: 0x1DF82F0 Offset: 0x1DF76F0 VA: 0x181DF82F0
	public ReclaimManager Copy() { }

	// RVA: 0x1DF8B90 Offset: 0x1DF7F90 VA: 0x181DF8B90
	public static ReclaimManager Deserialize(Stream stream) { }

	// RVA: 0x1DF8680 Offset: 0x1DF7A80 VA: 0x181DF8680
	public static ReclaimManager DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1DF89E0 Offset: 0x1DF7DE0 VA: 0x181DF89E0
	public static ReclaimManager DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1DF8A70 Offset: 0x1DF7E70 VA: 0x181DF8A70
	public static ReclaimManager Deserialize(byte[] buffer) { }

	// RVA: 0x1DF8FC0 Offset: 0x1DF83C0 VA: 0x181DF8FC0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1DF9A10 Offset: 0x1DF8E10 VA: 0x181DF9A10 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1DF9A30 Offset: 0x1DF8E30 VA: 0x181DF9A30 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ReclaimManager previous) { }

	// RVA: 0x1DF8FE0 Offset: 0x1DF83E0 VA: 0x181DF8FE0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1DF8E40 Offset: 0x1DF8240 VA: 0x181DF8E40
	public static ReclaimManager Deserialize(byte[] buffer, ReclaimManager instance, bool isDelta = False) { }

	// RVA: 0x1DF8C10 Offset: 0x1DF8010 VA: 0x181DF8C10
	public static ReclaimManager Deserialize(Stream stream, ReclaimManager instance, bool isDelta) { }

	// RVA: 0x1DF8370 Offset: 0x1DF7770 VA: 0x181DF8370
	public static ReclaimManager DeserializeLengthDelimited(Stream stream, ReclaimManager instance, bool isDelta) { }

	// RVA: 0x1DF8700 Offset: 0x1DF7B00 VA: 0x181DF8700
	public static ReclaimManager DeserializeLength(Stream stream, int length, ReclaimManager instance, bool isDelta) { }

	// RVA: 0x1DF93C0 Offset: 0x1DF87C0 VA: 0x181DF93C0
	public static void SerializeDelta(Stream stream, ReclaimManager instance, ReclaimManager previous) { }

	// RVA: 0x1DF97D0 Offset: 0x1DF8BD0 VA: 0x181DF97D0
	public static void Serialize(Stream stream, ReclaimManager instance) { }

	// RVA: 0x1DF9A00 Offset: 0x1DF8E00 VA: 0x181DF9A00
	public byte[] ToProtoBytes() { }

	// RVA: 0x1DF9A10 Offset: 0x1DF8E10 VA: 0x181DF9A10
	public void ToProto(Stream stream) { }

	// RVA: 0x1DF96C0 Offset: 0x1DF8AC0 VA: 0x181DF96C0
	public static byte[] SerializeToBytes(ReclaimManager instance) { }

	// RVA: 0x1DF9610 Offset: 0x1DF8A10 VA: 0x181DF9610
	public static void SerializeLengthDelimited(Stream stream, ReclaimManager instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class ReclaimManager.ReclaimInfo : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6404
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public ulong victimID; // 0x18
	public ulong killerID; // 0x20
	public string killerString; // 0x28
	public ItemContainer inventory; // 0x30

	// Methods

	// RVA: 0x1DF76D0 Offset: 0x1DF6AD0 VA: 0x181DF76D0
	public static void ResetToPool(ReclaimManager.ReclaimInfo instance) { }

	// RVA: 0x1DF77D0 Offset: 0x1DF6BD0 VA: 0x181DF77D0
	public void ResetToPool() { }

	// RVA: 0x1DF7400 Offset: 0x1DF6800 VA: 0x181DF7400 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DF60C0 Offset: 0x1DF54C0 VA: 0x181DF60C0
	public void CopyTo(ReclaimManager.ReclaimInfo instance) { }

	// RVA: 0x1DF6150 Offset: 0x1DF5550 VA: 0x181DF6150
	public ReclaimManager.ReclaimInfo Copy() { }

	// RVA: 0x1DF7190 Offset: 0x1DF6590 VA: 0x181DF7190
	public static ReclaimManager.ReclaimInfo Deserialize(Stream stream) { }

	// RVA: 0x1DF6540 Offset: 0x1DF5940 VA: 0x181DF6540
	public static ReclaimManager.ReclaimInfo DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1DF65C0 Offset: 0x1DF59C0 VA: 0x181DF65C0
	public static ReclaimManager.ReclaimInfo DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1DF6C40 Offset: 0x1DF6040 VA: 0x181DF6C40
	public static ReclaimManager.ReclaimInfo Deserialize(byte[] buffer) { }

	// RVA: 0x1DF7480 Offset: 0x1DF6880 VA: 0x181DF7480
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1DF80A0 Offset: 0x1DF74A0 VA: 0x181DF80A0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1DF80C0 Offset: 0x1DF74C0 VA: 0x181DF80C0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ReclaimManager.ReclaimInfo previous) { }

	// RVA: 0x1DF76B0 Offset: 0x1DF6AB0 VA: 0x181DF76B0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1DF6940 Offset: 0x1DF5D40 VA: 0x181DF6940
	public static ReclaimManager.ReclaimInfo Deserialize(byte[] buffer, ReclaimManager.ReclaimInfo instance, bool isDelta = False) { }

	// RVA: 0x1DF6F60 Offset: 0x1DF6360 VA: 0x181DF6F60
	public static ReclaimManager.ReclaimInfo Deserialize(Stream stream, ReclaimManager.ReclaimInfo instance, bool isDelta) { }

	// RVA: 0x1DF6230 Offset: 0x1DF5630 VA: 0x181DF6230
	public static ReclaimManager.ReclaimInfo DeserializeLengthDelimited(Stream stream, ReclaimManager.ReclaimInfo instance, bool isDelta) { }

	// RVA: 0x1DF6650 Offset: 0x1DF5A50 VA: 0x181DF6650
	public static ReclaimManager.ReclaimInfo DeserializeLength(Stream stream, int length, ReclaimManager.ReclaimInfo instance, bool isDelta) { }

	// RVA: 0x1DF78D0 Offset: 0x1DF6CD0 VA: 0x181DF78D0
	public static void SerializeDelta(Stream stream, ReclaimManager.ReclaimInfo instance, ReclaimManager.ReclaimInfo previous) { }

	// RVA: 0x1DF7DD0 Offset: 0x1DF71D0 VA: 0x181DF7DD0
	public static void Serialize(Stream stream, ReclaimManager.ReclaimInfo instance) { }

	// RVA: 0x1DF8090 Offset: 0x1DF7490 VA: 0x181DF8090
	public byte[] ToProtoBytes() { }

	// RVA: 0x1DF80A0 Offset: 0x1DF74A0 VA: 0x181DF80A0
	public void ToProto(Stream stream) { }

	// RVA: 0x1DF7CC0 Offset: 0x1DF70C0 VA: 0x181DF7CC0
	public static byte[] SerializeToBytes(ReclaimManager.ReclaimInfo instance) { }

	// RVA: 0x1DF7C10 Offset: 0x1DF7010 VA: 0x181DF7C10
	public static void SerializeLengthDelimited(Stream stream, ReclaimManager.ReclaimInfo instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class ReclaimManager : BaseEntity // TypeDefIndex: 9886
{	// Fields
	private const int defaultReclaims = 128;
	private const int reclaimSlotCount = 40;

	// Methods

	// RVA: 0x6ABB70 Offset: 0x6AAF70 VA: 0x1806ABB70
	public void .ctor() { }

}

