public class ColorSerialized // TypeDefIndex: 6297
{

	public static void ResetToPool(Color instance) { }

	public static Color Deserialize(byte[] buffer, ref Color instance, bool isDelta = False) { }

	public static Color Deserialize(Stream stream, ref Color instance, bool isDelta) { }

	public static Color DeserializeLengthDelimited(Stream stream, ref Color instance, bool isDelta) { }

	public static Color DeserializeLength(Stream stream, int length, ref Color instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, Color instance, Color previous) { }

	public static void Serialize(Stream stream, Color instance) { }

	public static byte[] SerializeToBytes(Color instance) { }

	public static void SerializeLengthDelimited(Stream stream, Color instance) { }

	public void .ctor() { }

}

