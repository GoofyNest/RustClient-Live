public class ReclaimManager : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6403
{
	public bool ShouldPool; 
	private bool _disposed; 
	public List<ReclaimManager.ReclaimInfo> reclaimEntries; 
	public int lastReclaimID; 


	public static void ResetToPool(ReclaimManager instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(ReclaimManager instance) { }

	public ReclaimManager Copy() { }

	public static ReclaimManager Deserialize(Stream stream) { }

	public static ReclaimManager DeserializeLengthDelimited(Stream stream) { }

	public static ReclaimManager DeserializeLength(Stream stream, int length) { }

	public static ReclaimManager Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, ReclaimManager previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static ReclaimManager Deserialize(byte[] buffer, ReclaimManager instance, bool isDelta = False) { }

	public static ReclaimManager Deserialize(Stream stream, ReclaimManager instance, bool isDelta) { }

	public static ReclaimManager DeserializeLengthDelimited(Stream stream, ReclaimManager instance, bool isDelta) { }

	public static ReclaimManager DeserializeLength(Stream stream, int length, ReclaimManager instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, ReclaimManager instance, ReclaimManager previous) { }

	public static void Serialize(Stream stream, ReclaimManager instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(ReclaimManager instance) { }

	public static void SerializeLengthDelimited(Stream stream, ReclaimManager instance) { }

	public void .ctor() { }

}

public class ReclaimManager.ReclaimInfo : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6404
{
	public bool ShouldPool; 
	private bool _disposed; 
	public ulong victimID; 
	public ulong killerID; 
	public string killerString; 
	public ItemContainer inventory; 


	public static void ResetToPool(ReclaimManager.ReclaimInfo instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(ReclaimManager.ReclaimInfo instance) { }

	public ReclaimManager.ReclaimInfo Copy() { }

	public static ReclaimManager.ReclaimInfo Deserialize(Stream stream) { }

	public static ReclaimManager.ReclaimInfo DeserializeLengthDelimited(Stream stream) { }

	public static ReclaimManager.ReclaimInfo DeserializeLength(Stream stream, int length) { }

	public static ReclaimManager.ReclaimInfo Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, ReclaimManager.ReclaimInfo previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static ReclaimManager.ReclaimInfo Deserialize(byte[] buffer, ReclaimManager.ReclaimInfo instance, bool isDelta = False) { }

	public static ReclaimManager.ReclaimInfo Deserialize(Stream stream, ReclaimManager.ReclaimInfo instance, bool isDelta) { }

	public static ReclaimManager.ReclaimInfo DeserializeLengthDelimited(Stream stream, ReclaimManager.ReclaimInfo instance, bool isDelta) { }

	public static ReclaimManager.ReclaimInfo DeserializeLength(Stream stream, int length, ReclaimManager.ReclaimInfo instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, ReclaimManager.ReclaimInfo instance, ReclaimManager.ReclaimInfo previous) { }

	public static void Serialize(Stream stream, ReclaimManager.ReclaimInfo instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(ReclaimManager.ReclaimInfo instance) { }

	public static void SerializeLengthDelimited(Stream stream, ReclaimManager.ReclaimInfo instance) { }

	public void .ctor() { }

}

public class ReclaimManager : BaseEntity // TypeDefIndex: 9886
{
	private const int defaultReclaims = 128;
	private const int reclaimSlotCount = 40;


	public void .ctor() { }

}

