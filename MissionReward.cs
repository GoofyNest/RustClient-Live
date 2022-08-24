public class MissionReward : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6452
{
	public bool ShouldPool; 
	private bool _disposed; 
	public int itemID; 
	public int itemAmount; 


public static void ResetToPool(MissionReward instance) { }

public void ResetToPool() { }

public virtual void Dispose() { }

public virtual void EnterPool() { }

public virtual void LeavePool() { }

public void CopyTo(MissionReward instance) { }

public MissionReward Copy() { }

public static MissionReward Deserialize(Stream stream) { }

public static MissionReward DeserializeLengthDelimited(Stream stream) { }

public static MissionReward DeserializeLength(Stream stream, int length) { }

public static MissionReward Deserialize(byte[] buffer) { }

public void FromProto(Stream stream, bool isDelta = False) { }

public virtual void WriteToStream(Stream stream) { }

public virtual void WriteToStreamDelta(Stream stream, MissionReward previous) { }

public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

public static MissionReward Deserialize(byte[] buffer, MissionReward instance, bool isDelta = False) { }

public static MissionReward Deserialize(Stream stream, MissionReward instance, bool isDelta) { }

public static MissionReward DeserializeLengthDelimited(Stream stream, MissionReward instance, bool isDelta) { }

public static MissionReward DeserializeLength(Stream stream, int length, MissionReward instance, bool isDelta) { }

public static void SerializeDelta(Stream stream, MissionReward instance, MissionReward previous) { }

public static void Serialize(Stream stream, MissionReward instance) { }

public byte[] ToProtoBytes() { }

public void ToProto(Stream stream) { }

public static byte[] SerializeToBytes(MissionReward instance) { }

public static void SerializeLengthDelimited(Stream stream, MissionReward instance) { }

public void .ctor() { }

}

