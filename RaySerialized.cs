public class RaySerialized // TypeDefIndex: 6286
{	// Methods

	// RVA: 0x1E440F0 Offset: 0x1E434F0 VA: 0x181E440F0
	public static void ResetToPool(Ray instance) { }

	// RVA: 0x1E43E20 Offset: 0x1E43220 VA: 0x181E43E20
	public static Ray Deserialize(byte[] buffer, ref Ray instance, bool isDelta = False) { }

	// RVA: 0x1E43BF0 Offset: 0x1E42FF0 VA: 0x181E43BF0
	public static Ray Deserialize(Stream stream, ref Ray instance, bool isDelta) { }

	// RVA: 0x1E435F0 Offset: 0x1E429F0 VA: 0x181E435F0
	public static Ray DeserializeLengthDelimited(Stream stream, ref Ray instance, bool isDelta) { }

	// RVA: 0x1E43900 Offset: 0x1E42D00 VA: 0x181E43900
	public static Ray DeserializeLength(Stream stream, int length, ref Ray instance, bool isDelta) { }

	// RVA: 0x1E44150 Offset: 0x1E43550 VA: 0x181E44150
	public static void SerializeDelta(Stream stream, Ray instance, Ray previous) { }

	// RVA: 0x1E44820 Offset: 0x1E43C20 VA: 0x181E44820
	public static void Serialize(Stream stream, Ray instance) { }

	// RVA: 0x1E446F0 Offset: 0x1E43AF0 VA: 0x181E446F0
	public static byte[] SerializeToBytes(Ray instance) { }

	// RVA: 0x1E445E0 Offset: 0x1E439E0 VA: 0x181E445E0
	public static void SerializeLengthDelimited(Stream stream, Ray instance) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

