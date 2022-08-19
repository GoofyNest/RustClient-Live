public class ZiplineArrivalPoint : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6436
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<VectorData> linePoints; // 0x18

	// Methods

	// RVA: 0x1E56290 Offset: 0x1E55690 VA: 0x181E56290
	public static void ResetToPool(ZiplineArrivalPoint instance) { }

	// RVA: 0x1E56370 Offset: 0x1E55770 VA: 0x181E56370
	public void ResetToPool() { }

	// RVA: 0x1E56100 Offset: 0x1E55500 VA: 0x181E56100 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E55390 Offset: 0x1E54790 VA: 0x181E55390
	public void CopyTo(ZiplineArrivalPoint instance) { }

	// RVA: 0x1E554F0 Offset: 0x1E548F0 VA: 0x181E554F0
	public ZiplineArrivalPoint Copy() { }

	// RVA: 0x1E55F80 Offset: 0x1E55380 VA: 0x181E55F80
	public static ZiplineArrivalPoint Deserialize(Stream stream) { }

	// RVA: 0x1E55930 Offset: 0x1E54D30 VA: 0x181E55930
	public static ZiplineArrivalPoint DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E55C20 Offset: 0x1E55020 VA: 0x181E55C20
	public static ZiplineArrivalPoint DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E55E60 Offset: 0x1E55260 VA: 0x181E55E60
	public static ZiplineArrivalPoint Deserialize(byte[] buffer) { }

	// RVA: 0x1E56250 Offset: 0x1E55650 VA: 0x181E56250
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E56B30 Offset: 0x1E55F30 VA: 0x181E56B30 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E56B50 Offset: 0x1E55F50 VA: 0x181E56B50 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ZiplineArrivalPoint previous) { }

	// RVA: 0x1E56270 Offset: 0x1E55670 VA: 0x181E56270 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E56000 Offset: 0x1E55400 VA: 0x181E56000
	public static ZiplineArrivalPoint Deserialize(byte[] buffer, ZiplineArrivalPoint instance, bool isDelta = False) { }

	// RVA: 0x1E55CB0 Offset: 0x1E550B0 VA: 0x181E55CB0
	public static ZiplineArrivalPoint Deserialize(Stream stream, ZiplineArrivalPoint instance, bool isDelta) { }

	// RVA: 0x1E556B0 Offset: 0x1E54AB0 VA: 0x181E556B0
	public static ZiplineArrivalPoint DeserializeLengthDelimited(Stream stream, ZiplineArrivalPoint instance, bool isDelta) { }

	// RVA: 0x1E559B0 Offset: 0x1E54DB0 VA: 0x181E559B0
	public static ZiplineArrivalPoint DeserializeLength(Stream stream, int length, ZiplineArrivalPoint instance, bool isDelta) { }

	// RVA: 0x1E56450 Offset: 0x1E55850 VA: 0x181E56450
	public static void SerializeDelta(Stream stream, ZiplineArrivalPoint instance, ZiplineArrivalPoint previous) { }

	// RVA: 0x1E568D0 Offset: 0x1E55CD0 VA: 0x181E568D0
	public static void Serialize(Stream stream, ZiplineArrivalPoint instance) { }

	// RVA: 0x1E56B20 Offset: 0x1E55F20 VA: 0x181E56B20
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E56B30 Offset: 0x1E55F30 VA: 0x181E56B30
	public void ToProto(Stream stream) { }

	// RVA: 0x1E567C0 Offset: 0x1E55BC0 VA: 0x181E567C0
	public static byte[] SerializeToBytes(ZiplineArrivalPoint instance) { }

	// RVA: 0x1E566D0 Offset: 0x1E55AD0 VA: 0x181E566D0
	public static void SerializeLengthDelimited(Stream stream, ZiplineArrivalPoint instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class ZiplineArrivalPoint : BaseEntity // TypeDefIndex: 8669
{	// Fields
	public LineRenderer Line; // 0x168
	private Vector3[] linePositions; // 0x170

	// Methods

	// RVA: 0x1A93570 Offset: 0x1A92970 VA: 0x181A93570 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x1A93710 Offset: 0x1A92B10 VA: 0x181A93710 Slot: 27
	public override void ResetState() { }

	// RVA: 0x1A93740 Offset: 0x1A92B40 VA: 0x181A93740
	private void UpdateLineRenderer() { }

	// RVA: 0x1A938D0 Offset: 0x1A92CD0 VA: 0x181A938D0
	public void .ctor() { }

}

