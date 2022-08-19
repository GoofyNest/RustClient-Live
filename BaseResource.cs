public class BaseResource : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6297
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int stage; // 0x14
	public float health; // 0x18

	// Methods

	// RVA: 0x1F618C0 Offset: 0x1F60CC0 VA: 0x181F618C0
	public static void ResetToPool(BaseResource instance) { }

	// RVA: 0x1F61840 Offset: 0x1F60C40 VA: 0x181F61840
	public void ResetToPool() { }

	// RVA: 0x1F615A0 Offset: 0x1F609A0 VA: 0x181F615A0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DB9660 Offset: 0x1DB8A60 VA: 0x181DB9660
	public void CopyTo(BaseResource instance) { }

	// RVA: 0x1F607A0 Offset: 0x1F5FBA0 VA: 0x181F607A0
	public BaseResource Copy() { }

	// RVA: 0x1F61010 Offset: 0x1F60410 VA: 0x181F61010
	public static BaseResource Deserialize(Stream stream) { }

	// RVA: 0x1F60A60 Offset: 0x1F5FE60 VA: 0x181F60A60
	public static BaseResource DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F60AE0 Offset: 0x1F5FEE0 VA: 0x181F60AE0
	public static BaseResource DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F60DA0 Offset: 0x1F601A0 VA: 0x181F60DA0
	public static BaseResource Deserialize(byte[] buffer) { }

	// RVA: 0x1F616A0 Offset: 0x1F60AA0 VA: 0x181F616A0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F61D90 Offset: 0x1F61190 VA: 0x181F61D90 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F61DB0 Offset: 0x1F611B0 VA: 0x181F61DB0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, BaseResource previous) { }

	// RVA: 0x1F61820 Offset: 0x1F60C20 VA: 0x181F61820 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F61350 Offset: 0x1F60750 VA: 0x181F61350
	public static BaseResource Deserialize(byte[] buffer, BaseResource instance, bool isDelta = False) { }

	// RVA: 0x1F611D0 Offset: 0x1F605D0 VA: 0x181F611D0
	public static BaseResource Deserialize(Stream stream, BaseResource instance, bool isDelta) { }

	// RVA: 0x1F60810 Offset: 0x1F5FC10 VA: 0x181F60810
	public static BaseResource DeserializeLengthDelimited(Stream stream, BaseResource instance, bool isDelta) { }

	// RVA: 0x1F60B70 Offset: 0x1F5FF70 VA: 0x181F60B70
	public static BaseResource DeserializeLength(Stream stream, int length, BaseResource instance, bool isDelta) { }

	// RVA: 0x1F61940 Offset: 0x1F60D40 VA: 0x181F61940
	public static void SerializeDelta(Stream stream, BaseResource instance, BaseResource previous) { }

	// RVA: 0x1F61C80 Offset: 0x1F61080 VA: 0x181F61C80
	public static void Serialize(Stream stream, BaseResource instance) { }

	// RVA: 0x1F61D80 Offset: 0x1F61180 VA: 0x181F61D80
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F61D90 Offset: 0x1F61190 VA: 0x181F61D90
	public void ToProto(Stream stream) { }

	// RVA: 0x1F61B70 Offset: 0x1F60F70 VA: 0x181F61B70
	public static byte[] SerializeToBytes(BaseResource instance) { }

	// RVA: 0x1F61AC0 Offset: 0x1F60EC0 VA: 0x181F61AC0
	public static void SerializeLengthDelimited(Stream stream, BaseResource instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

