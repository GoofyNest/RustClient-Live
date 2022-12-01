public class RaySerialized // TypeDefIndex: 6295
{

	public static void ResetToPool(Ray instance) { }

	public static Ray Deserialize(byte[] buffer, ref Ray instance, bool isDelta = False) { }

	public static Ray Deserialize(Stream stream, ref Ray instance, bool isDelta) { }

	public static Ray DeserializeLengthDelimited(Stream stream, ref Ray instance, bool isDelta) { }

	public static Ray DeserializeLength(Stream stream, int length, ref Ray instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, Ray instance, Ray previous) { }

	public static void Serialize(Stream stream, Ray instance) { }

	public static byte[] SerializeToBytes(Ray instance) { }

	public static void SerializeLengthDelimited(Stream stream, Ray instance) { }

	public void .ctor() { }

}

