public class DeliveryDrone : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6398
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint marketplaceId; // 0x14
	public uint terminalId; // 0x18
	public uint vendingMachineId; // 0x1C
	public int state; // 0x20


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
{	[HeaderAttribute] // RVA: 0xBE6A0 Offset: 0xBDAA0 VA: 0x1800BE6A0
	public float stateTimeout; // 0x320
	public float targetPositionTolerance; // 0x324
	public float preferredCruiseHeight; // 0x328
	public float preferredHeightAboveObstacle; // 0x32C
	public float marginAbovePreferredHeight; // 0x330
	public float obstacleHeightLockDuration; // 0x334
	public int pickUpDelayInTicks; // 0x338
	public DeliveryDroneConfig config; // 0x340
	public GameObjectRef mapMarkerPrefab; // 0x348


	public void .ctor() { }

}

