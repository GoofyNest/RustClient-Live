public class MapEntity : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6320
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<uint> fogImages; // 0x18
	public List<uint> paintImages; // 0x20

	// Methods

	// RVA: 0x1F39440 Offset: 0x1F38840 VA: 0x181F39440
	public static void ResetToPool(MapEntity instance) { }

	// RVA: 0x1F392F0 Offset: 0x1F386F0 VA: 0x181F392F0
	public void ResetToPool() { }

	// RVA: 0x1F390F0 Offset: 0x1F384F0 VA: 0x181F390F0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F382F0 Offset: 0x1F376F0 VA: 0x181F382F0
	public void CopyTo(MapEntity instance) { }

	// RVA: 0x1F384F0 Offset: 0x1F378F0 VA: 0x181F384F0
	public MapEntity Copy() { }

	// RVA: 0x1F39070 Offset: 0x1F38470 VA: 0x181F39070
	public static MapEntity Deserialize(Stream stream) { }

	// RVA: 0x1F38570 Offset: 0x1F37970 VA: 0x181F38570
	public static MapEntity DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F388E0 Offset: 0x1F37CE0 VA: 0x181F388E0
	public static MapEntity DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F38D40 Offset: 0x1F38140 VA: 0x181F38D40
	public static MapEntity Deserialize(byte[] buffer) { }

	// RVA: 0x1F392B0 Offset: 0x1F386B0 VA: 0x181F392B0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F39B20 Offset: 0x1F38F20 VA: 0x181F39B20 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F39B40 Offset: 0x1F38F40 VA: 0x181F39B40 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, MapEntity previous) { }

	// RVA: 0x1F392D0 Offset: 0x1F386D0 VA: 0x181F392D0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F38C40 Offset: 0x1F38040 VA: 0x181F38C40
	public static MapEntity Deserialize(byte[] buffer, MapEntity instance, bool isDelta = False) { }

	// RVA: 0x1F38E60 Offset: 0x1F38260 VA: 0x181F38E60
	public static MapEntity Deserialize(Stream stream, MapEntity instance, bool isDelta) { }

	// RVA: 0x1F385F0 Offset: 0x1F379F0 VA: 0x181F385F0
	public static MapEntity DeserializeLengthDelimited(Stream stream, MapEntity instance, bool isDelta) { }

	// RVA: 0x1F38970 Offset: 0x1F37D70 VA: 0x181F38970
	public static MapEntity DeserializeLength(Stream stream, int length, MapEntity instance, bool isDelta) { }

	// RVA: 0x1F39590 Offset: 0x1F38990 VA: 0x181F39590
	public static void SerializeDelta(Stream stream, MapEntity instance, MapEntity previous) { }

	// RVA: 0x1F39930 Offset: 0x1F38D30 VA: 0x181F39930
	public static void Serialize(Stream stream, MapEntity instance) { }

	// RVA: 0x1F39B10 Offset: 0x1F38F10 VA: 0x181F39B10
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F39B20 Offset: 0x1F38F20 VA: 0x181F39B20
	public void ToProto(Stream stream) { }

	// RVA: 0x1F39820 Offset: 0x1F38C20 VA: 0x181F39820
	public static byte[] SerializeToBytes(MapEntity instance) { }

	// RVA: 0x1F39770 Offset: 0x1F38B70 VA: 0x181F39770
	public static void SerializeLengthDelimited(Stream stream, MapEntity instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class MapEntity : HeldEntity // TypeDefIndex: 8601
{	// Fields
	public uint[] fogImages; // 0x1F8
	public uint[] paintImages; // 0x200

	// Methods

	// RVA: 0x57CA50 Offset: 0x57BE50 VA: 0x18057CA50 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x57C930 Offset: 0x57BD30 VA: 0x18057C930 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x57CB40 Offset: 0x57BF40 VA: 0x18057CB40
	public void PaintImageUpdate(int id, uint hash, byte[] data) { }

	// RVA: 0x57CC00 Offset: 0x57C000 VA: 0x18057CC00
	public void .ctor() { }

}

