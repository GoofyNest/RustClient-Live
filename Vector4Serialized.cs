public class Vector4Serialized // TypeDefIndex: 6287
{

	public static void ResetToPool(Vector4 instance) { }

	public static Vector4 Deserialize(byte[] buffer, ref Vector4 instance, bool isDelta = False) { }

	public static Vector4 Deserialize(Stream stream, ref Vector4 instance, bool isDelta) { }

	public static Vector4 DeserializeLengthDelimited(Stream stream, ref Vector4 instance, bool isDelta) { }

	public static Vector4 DeserializeLength(Stream stream, int length, ref Vector4 instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, Vector4 instance, Vector4 previous) { }

	public static void Serialize(Stream stream, Vector4 instance) { }

	public static byte[] SerializeToBytes(Vector4 instance) { }

	public static void SerializeLengthDelimited(Stream stream, Vector4 instance) { }

	public void .ctor() { }

}

