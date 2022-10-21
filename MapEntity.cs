public class MapEntity : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6325
{
	public bool ShouldPool; 
	private bool _disposed; 
	public List<uint> fogImages; 
	public List<uint> paintImages; 


	public static void ResetToPool(MapEntity instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(MapEntity instance) { }

	public MapEntity Copy() { }

	public static MapEntity Deserialize(Stream stream) { }

	public static MapEntity DeserializeLengthDelimited(Stream stream) { }

	public static MapEntity DeserializeLength(Stream stream, int length) { }

	public static MapEntity Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, MapEntity previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static MapEntity Deserialize(byte[] buffer, MapEntity instance, bool isDelta = False) { }

	public static MapEntity Deserialize(Stream stream, MapEntity instance, bool isDelta) { }

	public static MapEntity DeserializeLengthDelimited(Stream stream, MapEntity instance, bool isDelta) { }

	public static MapEntity DeserializeLength(Stream stream, int length, MapEntity instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, MapEntity instance, MapEntity previous) { }

	public static void Serialize(Stream stream, MapEntity instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(MapEntity instance) { }

	public static void SerializeLengthDelimited(Stream stream, MapEntity instance) { }

	public void .ctor() { }

}

public class MapEntity : HeldEntity // TypeDefIndex: 10310
{
	public uint[] fogImages; 
	public uint[] paintImages; 


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public void PaintImageUpdate(int id, uint hash, byte[] data) { }

	public void .ctor() { }

}

