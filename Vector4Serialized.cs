public class Vector4Serialized // TypeDefIndex: 6287
{	// Methods

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public static void ResetToPool(Vector4 instance) { }

	// RVA: 0x1E48DD0 Offset: 0x1E481D0 VA: 0x181E48DD0
	public static Vector4 Deserialize(byte[] buffer, ref Vector4 instance, bool isDelta = False) { }

	// RVA: 0x1E48F00 Offset: 0x1E48300 VA: 0x181E48F00
	public static Vector4 Deserialize(Stream stream, ref Vector4 instance, bool isDelta) { }

	// RVA: 0x1E485A0 Offset: 0x1E479A0 VA: 0x181E485A0
	public static Vector4 DeserializeLengthDelimited(Stream stream, ref Vector4 instance, bool isDelta) { }

	// RVA: 0x1E489D0 Offset: 0x1E47DD0 VA: 0x181E489D0
	public static Vector4 DeserializeLength(Stream stream, int length, ref Vector4 instance, bool isDelta) { }

	// RVA: 0x1E49260 Offset: 0x1E48660 VA: 0x181E49260
	public static void SerializeDelta(Stream stream, Vector4 instance, Vector4 previous) { }

	// RVA: 0x1E497B0 Offset: 0x1E48BB0 VA: 0x181E497B0
	public static void Serialize(Stream stream, Vector4 instance) { }

	// RVA: 0x1E49590 Offset: 0x1E48990 VA: 0x181E49590
	public static byte[] SerializeToBytes(Vector4 instance) { }

	// RVA: 0x1E49490 Offset: 0x1E48890 VA: 0x181E49490
	public static void SerializeLengthDelimited(Stream stream, Vector4 instance) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

