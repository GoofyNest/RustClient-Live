public class ResourceExtractor : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6323
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public ItemContainer fuelContents; // 0x18
	public ItemContainer outputContents; // 0x20

	// Methods

	// RVA: 0x1DFEE20 Offset: 0x1DFE220 VA: 0x181DFEE20
	public static void ResetToPool(ResourceExtractor instance) { }

	// RVA: 0x1DFED40 Offset: 0x1DFE140 VA: 0x181DFED40
	public void ResetToPool() { }

	// RVA: 0x1DFEBA0 Offset: 0x1DFDFA0 VA: 0x181DFEBA0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DFDFB0 Offset: 0x1DFD3B0 VA: 0x181DFDFB0
	public void CopyTo(ResourceExtractor instance) { }

	// RVA: 0x1DFE070 Offset: 0x1DFD470 VA: 0x181DFE070
	public ResourceExtractor Copy() { }

	// RVA: 0x1DFEB20 Offset: 0x1DFDF20 VA: 0x181DFEB20
	public static ResourceExtractor Deserialize(Stream stream) { }

	// RVA: 0x1DFE400 Offset: 0x1DFD800 VA: 0x181DFE400
	public static ResourceExtractor DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1DFE480 Offset: 0x1DFD880 VA: 0x181DFE480
	public static ResourceExtractor DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1DFE860 Offset: 0x1DFDC60 VA: 0x181DFE860
	public static ResourceExtractor Deserialize(byte[] buffer) { }

	// RVA: 0x1DFED00 Offset: 0x1DFE100 VA: 0x181DFED00
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1DFF5E0 Offset: 0x1DFE9E0 VA: 0x181DFF5E0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1DFF600 Offset: 0x1DFEA00 VA: 0x181DFF600 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ResourceExtractor previous) { }

	// RVA: 0x1DFED20 Offset: 0x1DFE120 VA: 0x181DFED20 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1DFE760 Offset: 0x1DFDB60 VA: 0x181DFE760
	public static ResourceExtractor Deserialize(byte[] buffer, ResourceExtractor instance, bool isDelta = False) { }

	// RVA: 0x1DFE980 Offset: 0x1DFDD80 VA: 0x181DFE980
	public static ResourceExtractor Deserialize(Stream stream, ResourceExtractor instance, bool isDelta) { }

	// RVA: 0x1DFE180 Offset: 0x1DFD580 VA: 0x181DFE180
	public static ResourceExtractor DeserializeLengthDelimited(Stream stream, ResourceExtractor instance, bool isDelta) { }

	// RVA: 0x1DFE510 Offset: 0x1DFD910 VA: 0x181DFE510
	public static ResourceExtractor DeserializeLength(Stream stream, int length, ResourceExtractor instance, bool isDelta) { }

	// RVA: 0x1DFEF00 Offset: 0x1DFE300 VA: 0x181DFEF00
	public static void SerializeDelta(Stream stream, ResourceExtractor instance, ResourceExtractor previous) { }

	// RVA: 0x1DFF360 Offset: 0x1DFE760 VA: 0x181DFF360
	public static void Serialize(Stream stream, ResourceExtractor instance) { }

	// RVA: 0x1DFF5D0 Offset: 0x1DFE9D0 VA: 0x181DFF5D0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1DFF5E0 Offset: 0x1DFE9E0 VA: 0x181DFF5E0
	public void ToProto(Stream stream) { }

	// RVA: 0x1DFF250 Offset: 0x1DFE650 VA: 0x181DFF250
	public static byte[] SerializeToBytes(ResourceExtractor instance) { }

	// RVA: 0x1DFF1A0 Offset: 0x1DFE5A0 VA: 0x181DFF1A0
	public static void SerializeLengthDelimited(Stream stream, ResourceExtractor instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

