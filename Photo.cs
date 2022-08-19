public class Photo : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6383
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public ulong photographerSteamId; // 0x18
	public uint imageCrc; // 0x20

	// Methods

	// RVA: 0x1EA5E60 Offset: 0x1EA5260 VA: 0x181EA5E60
	public static void ResetToPool(Photo instance) { }

	// RVA: 0x1EA5DE0 Offset: 0x1EA51E0 VA: 0x181EA5DE0
	public void ResetToPool() { }

	// RVA: 0x1EA5B40 Offset: 0x1EA4F40 VA: 0x181EA5B40 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1EA4D10 Offset: 0x1EA4110 VA: 0x181EA4D10
	public void CopyTo(Photo instance) { }

	// RVA: 0x1EA4D40 Offset: 0x1EA4140 VA: 0x181EA4D40
	public Photo Copy() { }

	// RVA: 0x1EA55B0 Offset: 0x1EA49B0 VA: 0x181EA55B0
	public static Photo Deserialize(Stream stream) { }

	// RVA: 0x1EA5000 Offset: 0x1EA4400 VA: 0x181EA5000
	public static Photo DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EA52B0 Offset: 0x1EA46B0 VA: 0x181EA52B0
	public static Photo DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EA5340 Offset: 0x1EA4740 VA: 0x181EA5340
	public static Photo Deserialize(byte[] buffer) { }

	// RVA: 0x1EA5C40 Offset: 0x1EA5040 VA: 0x181EA5C40
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EA6320 Offset: 0x1EA5720 VA: 0x181EA6320 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EA6340 Offset: 0x1EA5740 VA: 0x181EA6340 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Photo previous) { }

	// RVA: 0x1EA5DC0 Offset: 0x1EA51C0 VA: 0x181EA5DC0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EA58F0 Offset: 0x1EA4CF0 VA: 0x181EA58F0
	public static Photo Deserialize(byte[] buffer, Photo instance, bool isDelta = False) { }

	// RVA: 0x1EA5770 Offset: 0x1EA4B70 VA: 0x181EA5770
	public static Photo Deserialize(Stream stream, Photo instance, bool isDelta) { }

	// RVA: 0x1EA4DB0 Offset: 0x1EA41B0 VA: 0x181EA4DB0
	public static Photo DeserializeLengthDelimited(Stream stream, Photo instance, bool isDelta) { }

	// RVA: 0x1EA5080 Offset: 0x1EA4480 VA: 0x181EA5080
	public static Photo DeserializeLength(Stream stream, int length, Photo instance, bool isDelta) { }

	// RVA: 0x1EA5EE0 Offset: 0x1EA52E0 VA: 0x181EA5EE0
	public static void SerializeDelta(Stream stream, Photo instance, Photo previous) { }

	// RVA: 0x1EA6210 Offset: 0x1EA5610 VA: 0x181EA6210
	public static void Serialize(Stream stream, Photo instance) { }

	// RVA: 0x1EA6310 Offset: 0x1EA5710 VA: 0x181EA6310
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EA6320 Offset: 0x1EA5720 VA: 0x181EA6320
	public void ToProto(Stream stream) { }

	// RVA: 0x1EA6100 Offset: 0x1EA5500 VA: 0x181EA6100
	public static byte[] SerializeToBytes(Photo instance) { }

	// RVA: 0x1EA6050 Offset: 0x1EA5450 VA: 0x181EA6050
	public static void SerializeLengthDelimited(Stream stream, Photo instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

