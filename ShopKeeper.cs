public class ShopKeeper : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6381
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint vendingRef; // 0x14


	public static void ResetToPool(ShopKeeper instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(ShopKeeper instance) { }

	public ShopKeeper Copy() { }

	public static ShopKeeper Deserialize(Stream stream) { }

	public static ShopKeeper DeserializeLengthDelimited(Stream stream) { }

	public static ShopKeeper DeserializeLength(Stream stream, int length) { }

	public static ShopKeeper Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, ShopKeeper previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static ShopKeeper Deserialize(byte[] buffer, ShopKeeper instance, bool isDelta = False) { }

	public static ShopKeeper Deserialize(Stream stream, ShopKeeper instance, bool isDelta) { }

	public static ShopKeeper DeserializeLengthDelimited(Stream stream, ShopKeeper instance, bool isDelta) { }

	public static ShopKeeper DeserializeLength(Stream stream, int length, ShopKeeper instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, ShopKeeper instance, ShopKeeper previous) { }

	public static void Serialize(Stream stream, ShopKeeper instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(ShopKeeper instance) { }

	public static void SerializeLengthDelimited(Stream stream, ShopKeeper instance) { }

	public void .ctor() { }

}

