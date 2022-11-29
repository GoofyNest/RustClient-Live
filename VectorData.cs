public struct VectorData : IProto // TypeDefIndex: 6297
{
	public float x; 
	public float y; 
	public float z; 


	public void .ctor(float x, float y, float z) { }

	public static VectorData op_Implicit(Vector3 v) { }

	public static VectorData op_Implicit(Quaternion q) { }

	public static Vector3 op_Implicit(VectorData v) { }

	public static Quaternion op_Implicit(VectorData v) { }

	public static void ResetToPool(VectorData instance) { }

	public void CopyTo(VectorData instance) { }

	public VectorData Copy() { }

	public static VectorData Deserialize(Stream stream) { }

	public static VectorData DeserializeLengthDelimited(Stream stream) { }

	public static VectorData DeserializeLength(Stream stream, int length) { }

	public static VectorData Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public void WriteToStream(Stream stream) { }

	public void WriteToStreamDelta(Stream stream, VectorData previous) { }

	public void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static VectorData Deserialize(byte[] buffer, ref VectorData instance, bool isDelta = False) { }

	public static VectorData Deserialize(Stream stream, ref VectorData instance, bool isDelta) { }

	public static VectorData DeserializeLengthDelimited(Stream stream, ref VectorData instance, bool isDelta) { }

	public static VectorData DeserializeLength(Stream stream, int length, ref VectorData instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, VectorData instance, VectorData previous) { }

	public static void Serialize(Stream stream, VectorData instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(VectorData instance) { }

	public static void SerializeLengthDelimited(Stream stream, VectorData instance) { }

}

