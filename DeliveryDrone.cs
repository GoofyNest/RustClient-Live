public class DeliveryDrone : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6398
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint marketplaceId; // 0x14
	public uint terminalId; // 0x18
	public uint vendingMachineId; // 0x1C
	public int state; // 0x20

	// Methods

	// RVA: 0x20B70C0 Offset: 0x20B64C0 VA: 0x1820B70C0
	public static void ResetToPool(DeliveryDrone instance) { }

	// RVA: 0x20B7160 Offset: 0x20B6560 VA: 0x1820B7160
	public void ResetToPool() { }

	// RVA: 0x20B6D70 Offset: 0x20B6170 VA: 0x1820B6D70 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1C01DA0 Offset: 0x1C011A0 VA: 0x181C01DA0
	public void CopyTo(DeliveryDrone instance) { }

	// RVA: 0x20B5BE0 Offset: 0x20B4FE0 VA: 0x1820B5BE0
	public DeliveryDrone Copy() { }

	// RVA: 0x20B6310 Offset: 0x20B5710 VA: 0x1820B6310
	public static DeliveryDrone Deserialize(Stream stream) { }

	// RVA: 0x20B5F40 Offset: 0x20B5340 VA: 0x1820B5F40
	public static DeliveryDrone DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x20B5FC0 Offset: 0x20B53C0 VA: 0x1820B5FC0
	public static DeliveryDrone DeserializeLength(Stream stream, int length) { }

	// RVA: 0x20B6560 Offset: 0x20B5960 VA: 0x1820B6560
	public static DeliveryDrone Deserialize(byte[] buffer) { }

	// RVA: 0x20B6E90 Offset: 0x20B6290 VA: 0x1820B6E90
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x20B7720 Offset: 0x20B6B20 VA: 0x1820B7720 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x20B7740 Offset: 0x20B6B40 VA: 0x1820B7740 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, DeliveryDrone previous) { }

	// RVA: 0x20B70A0 Offset: 0x20B64A0 VA: 0x1820B70A0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x20B6870 Offset: 0x20B5C70 VA: 0x1820B6870
	public static DeliveryDrone Deserialize(byte[] buffer, DeliveryDrone instance, bool isDelta = False) { }

	// RVA: 0x20B6B60 Offset: 0x20B5F60 VA: 0x1820B6B60
	public static DeliveryDrone Deserialize(Stream stream, DeliveryDrone instance, bool isDelta) { }

	// RVA: 0x20B5C60 Offset: 0x20B5060 VA: 0x1820B5C60
	public static DeliveryDrone DeserializeLengthDelimited(Stream stream, DeliveryDrone instance, bool isDelta) { }

	// RVA: 0x20B6050 Offset: 0x20B5450 VA: 0x1820B6050
	public static DeliveryDrone DeserializeLength(Stream stream, int length, DeliveryDrone instance, bool isDelta) { }

	// RVA: 0x20B7200 Offset: 0x20B6600 VA: 0x1820B7200
	public static void SerializeDelta(Stream stream, DeliveryDrone instance, DeliveryDrone previous) { }

	// RVA: 0x20B75D0 Offset: 0x20B69D0 VA: 0x1820B75D0
	public static void Serialize(Stream stream, DeliveryDrone instance) { }

	// RVA: 0x20B7710 Offset: 0x20B6B10 VA: 0x1820B7710
	public byte[] ToProtoBytes() { }

	// RVA: 0x20B7720 Offset: 0x20B6B20 VA: 0x1820B7720
	public void ToProto(Stream stream) { }

	// RVA: 0x20B74C0 Offset: 0x20B68C0 VA: 0x1820B74C0
	public static byte[] SerializeToBytes(DeliveryDrone instance) { }

	// RVA: 0x20B7410 Offset: 0x20B6810 VA: 0x1820B7410
	public static void SerializeLengthDelimited(Stream stream, DeliveryDrone instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class DeliveryDrone : Drone // TypeDefIndex: 8799
{	// Fields
	[HeaderAttribute] // RVA: 0xBE6A0 Offset: 0xBDAA0 VA: 0x1800BE6A0
	public float stateTimeout; // 0x320
	public float targetPositionTolerance; // 0x324
	public float preferredCruiseHeight; // 0x328
	public float preferredHeightAboveObstacle; // 0x32C
	public float marginAbovePreferredHeight; // 0x330
	public float obstacleHeightLockDuration; // 0x334
	public int pickUpDelayInTicks; // 0x338
	public DeliveryDroneConfig config; // 0x340
	public GameObjectRef mapMarkerPrefab; // 0x348

	// Methods

	// RVA: 0x8F3050 Offset: 0x8F2450 VA: 0x1808F3050
	public void .ctor() { }

}

