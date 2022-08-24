public class DeliveryDrone : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6398
{
	public bool ShouldPool; 
	private bool _disposed; 
	public uint marketplaceId; 
	public uint terminalId; 
	public uint vendingMachineId; 
	public int state; 


public static void ResetToPool(DeliveryDrone instance) { }

public void ResetToPool() { }

public virtual void Dispose() { }

public virtual void EnterPool() { }

public virtual void LeavePool() { }

public void CopyTo(DeliveryDrone instance) { }

public DeliveryDrone Copy() { }

public static DeliveryDrone Deserialize(Stream stream) { }

public static DeliveryDrone DeserializeLengthDelimited(Stream stream) { }

public static DeliveryDrone DeserializeLength(Stream stream, int length) { }

public static DeliveryDrone Deserialize(byte[] buffer) { }

public void FromProto(Stream stream, bool isDelta = False) { }

public virtual void WriteToStream(Stream stream) { }

public virtual void WriteToStreamDelta(Stream stream, DeliveryDrone previous) { }

public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

public static DeliveryDrone Deserialize(byte[] buffer, DeliveryDrone instance, bool isDelta = False) { }

public static DeliveryDrone Deserialize(Stream stream, DeliveryDrone instance, bool isDelta) { }

public static DeliveryDrone DeserializeLengthDelimited(Stream stream, DeliveryDrone instance, bool isDelta) { }

public static DeliveryDrone DeserializeLength(Stream stream, int length, DeliveryDrone instance, bool isDelta) { }

public static void SerializeDelta(Stream stream, DeliveryDrone instance, DeliveryDrone previous) { }

public static void Serialize(Stream stream, DeliveryDrone instance) { }

public byte[] ToProtoBytes() { }

public void ToProto(Stream stream) { }

public static byte[] SerializeToBytes(DeliveryDrone instance) { }

public static void SerializeLengthDelimited(Stream stream, DeliveryDrone instance) { }

public void .ctor() { }

}

public class DeliveryDrone : Drone // TypeDefIndex: 8799
{
	[HeaderAttribute] 
	public float stateTimeout; 
	public float targetPositionTolerance; 
	public float preferredCruiseHeight; 
	public float preferredHeightAboveObstacle; 
	public float marginAbovePreferredHeight; 
	public float obstacleHeightLockDuration; 
	public int pickUpDelayInTicks; 
	public DeliveryDroneConfig config; 
	public GameObjectRef mapMarkerPrefab; 


public void .ctor() { }

}

