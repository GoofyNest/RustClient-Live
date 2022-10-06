public class Vector3Serialized // TypeDefIndex: 6289
{

	public static void ResetToPool(Vector3 instance) { }

	public static Vector3 Deserialize(byte[] buffer, ref Vector3 instance, bool isDelta = False) { }

	public static Vector3 Deserialize(Stream stream, ref Vector3 instance, bool isDelta) { }

	public static Vector3 DeserializeLengthDelimited(Stream stream, ref Vector3 instance, bool isDelta) { }

	public static Vector3 DeserializeLength(Stream stream, int length, ref Vector3 instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, Vector3 instance, Vector3 previous) { }

	public static void Serialize(Stream stream, Vector3 instance) { }

	public static byte[] SerializeToBytes(Vector3 instance) { }

	public static void SerializeLengthDelimited(Stream stream, Vector3 instance) { }

	public void .ctor() { }

}

