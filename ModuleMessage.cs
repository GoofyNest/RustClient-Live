public class ModuleMessage : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6490
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint itemid; // 0x14
	public int moduleid; // 0x18
	public int type; // 0x1C
	public byte[] data; // 0x20


	public static void ResetToPool(ModuleMessage instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(ModuleMessage instance) { }

	public ModuleMessage Copy() { }

	public static ModuleMessage Deserialize(Stream stream) { }

	public static ModuleMessage DeserializeLengthDelimited(Stream stream) { }

	public static ModuleMessage DeserializeLength(Stream stream, int length) { }

	public static ModuleMessage Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, ModuleMessage previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static ModuleMessage Deserialize(byte[] buffer, ModuleMessage instance, bool isDelta = False) { }

	public static ModuleMessage Deserialize(Stream stream, ModuleMessage instance, bool isDelta) { }

	public static ModuleMessage DeserializeLengthDelimited(Stream stream, ModuleMessage instance, bool isDelta) { }

	public static ModuleMessage DeserializeLength(Stream stream, int length, ModuleMessage instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, ModuleMessage instance, ModuleMessage previous) { }

	public static void Serialize(Stream stream, ModuleMessage instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(ModuleMessage instance) { }

	public static void SerializeLengthDelimited(Stream stream, ModuleMessage instance) { }

	public void .ctor() { }

}

