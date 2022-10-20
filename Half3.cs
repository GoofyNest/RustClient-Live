public struct Half3 : IProto // TypeDefIndex: 6480
{
	public uint x; 
	public uint y; 
	public uint z; 


	public static void ResetToPool(Half3 instance) { }

	public void CopyTo(Half3 instance) { }

	public Half3 Copy() { }

	public static Half3 Deserialize(Stream stream) { }

	public static Half3 DeserializeLengthDelimited(Stream stream) { }

	public static Half3 DeserializeLength(Stream stream, int length) { }

	public static Half3 Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public void WriteToStream(Stream stream) { }

	public void WriteToStreamDelta(Stream stream, Half3 previous) { }

	public void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static Half3 Deserialize(byte[] buffer, ref Half3 instance, bool isDelta = False) { }

	public static Half3 Deserialize(Stream stream, ref Half3 instance, bool isDelta) { }

	public static Half3 DeserializeLengthDelimited(Stream stream, ref Half3 instance, bool isDelta) { }

	public static Half3 DeserializeLength(Stream stream, int length, ref Half3 instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, Half3 instance, Half3 previous) { }

	public static void Serialize(Stream stream, Half3 instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(Half3 instance) { }

	public static void SerializeLengthDelimited(Stream stream, Half3 instance) { }

}

public struct Half3 // TypeDefIndex: 13168
{
	public ushort x; 
	public ushort y; 
	public ushort z; 


	public void .ctor(Vector3 vec) { }

	public static Vector3 op_Explicit(Half3 vec) { }

}

