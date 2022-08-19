public class Vector3Serialized // TypeDefIndex: 6285
{	// Methods

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public static void ResetToPool(Vector3 instance) { }

	// RVA: 0x1E47C20 Offset: 0x1E47020 VA: 0x181E47C20
	public static Vector3 Deserialize(byte[] buffer, ref Vector3 instance, bool isDelta = False) { }

	// RVA: 0x1E47D50 Offset: 0x1E47150 VA: 0x181E47D50
	public static Vector3 Deserialize(Stream stream, ref Vector3 instance, bool isDelta) { }

	// RVA: 0x1E47440 Offset: 0x1E46840 VA: 0x181E47440
	public static Vector3 DeserializeLengthDelimited(Stream stream, ref Vector3 instance, bool isDelta) { }

	// RVA: 0x1E47840 Offset: 0x1E46C40 VA: 0x181E47840
	public static Vector3 DeserializeLength(Stream stream, int length, ref Vector3 instance, bool isDelta) { }

	// RVA: 0x1E48070 Offset: 0x1E47470 VA: 0x181E48070
	public static void SerializeDelta(Stream stream, Vector3 instance, Vector3 previous) { }

	// RVA: 0x1E48480 Offset: 0x1E47880 VA: 0x181E48480
	public static void Serialize(Stream stream, Vector3 instance) { }

	// RVA: 0x1E48360 Offset: 0x1E47760 VA: 0x181E48360
	public static byte[] SerializeToBytes(Vector3 instance) { }

	// RVA: 0x1E48260 Offset: 0x1E47660 VA: 0x181E48260
	public static void SerializeLengthDelimited(Stream stream, Vector3 instance) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

