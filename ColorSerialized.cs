public class ColorSerialized // TypeDefIndex: 6288
{	// Methods

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public static void ResetToPool(Color instance) { }

	// RVA: 0x1E40E40 Offset: 0x1E40240 VA: 0x181E40E40
	public static Color Deserialize(byte[] buffer, ref Color instance, bool isDelta = False) { }

	// RVA: 0x1E40AE0 Offset: 0x1E3FEE0 VA: 0x181E40AE0
	public static Color Deserialize(Stream stream, ref Color instance, bool isDelta) { }

	// RVA: 0x1E402B0 Offset: 0x1E3F6B0 VA: 0x181E402B0
	public static Color DeserializeLengthDelimited(Stream stream, ref Color instance, bool isDelta) { }

	// RVA: 0x1E406E0 Offset: 0x1E3FAE0 VA: 0x181E406E0
	public static Color DeserializeLength(Stream stream, int length, ref Color instance, bool isDelta) { }

	// RVA: 0x1E40F70 Offset: 0x1E40370 VA: 0x181E40F70
	public static void SerializeDelta(Stream stream, Color instance, Color previous) { }

	// RVA: 0x1E414C0 Offset: 0x1E408C0 VA: 0x181E414C0
	public static void Serialize(Stream stream, Color instance) { }

	// RVA: 0x1E412A0 Offset: 0x1E406A0 VA: 0x181E412A0
	public static byte[] SerializeToBytes(Color instance) { }

	// RVA: 0x1E411A0 Offset: 0x1E405A0 VA: 0x181E411A0
	public static void SerializeLengthDelimited(Stream stream, Color instance) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

