public class PhoneDirectory : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6502
{
	public bool ShouldPool; 
	private bool _disposed; 
	public List<PhoneDirectory.DirectoryEntry> entries; 
	public bool atEnd; 


	public static void ResetToPool(PhoneDirectory instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(PhoneDirectory instance) { }

	public PhoneDirectory Copy() { }

	public static PhoneDirectory Deserialize(Stream stream) { }

	public static PhoneDirectory DeserializeLengthDelimited(Stream stream) { }

	public static PhoneDirectory DeserializeLength(Stream stream, int length) { }

	public static PhoneDirectory Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, PhoneDirectory previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static PhoneDirectory Deserialize(byte[] buffer, PhoneDirectory instance, bool isDelta = False) { }

	public static PhoneDirectory Deserialize(Stream stream, PhoneDirectory instance, bool isDelta) { }

	public static PhoneDirectory DeserializeLengthDelimited(Stream stream, PhoneDirectory instance, bool isDelta) { }

	public static PhoneDirectory DeserializeLength(Stream stream, int length, PhoneDirectory instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, PhoneDirectory instance, PhoneDirectory previous) { }

	public static void Serialize(Stream stream, PhoneDirectory instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(PhoneDirectory instance) { }

	public static void SerializeLengthDelimited(Stream stream, PhoneDirectory instance) { }

	public void .ctor() { }

}

public class PhoneDirectory.DirectoryEntry : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6503
{
	public bool ShouldPool; 
	private bool _disposed; 
	public int phoneNumber; 
	public string phoneName; 


	public static void ResetToPool(PhoneDirectory.DirectoryEntry instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(PhoneDirectory.DirectoryEntry instance) { }

	public PhoneDirectory.DirectoryEntry Copy() { }

	public static PhoneDirectory.DirectoryEntry Deserialize(Stream stream) { }

	public static PhoneDirectory.DirectoryEntry DeserializeLengthDelimited(Stream stream) { }

	public static PhoneDirectory.DirectoryEntry DeserializeLength(Stream stream, int length) { }

	public static PhoneDirectory.DirectoryEntry Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, PhoneDirectory.DirectoryEntry previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static PhoneDirectory.DirectoryEntry Deserialize(byte[] buffer, PhoneDirectory.DirectoryEntry instance, bool isDelta = False) { }

	public static PhoneDirectory.DirectoryEntry Deserialize(Stream stream, PhoneDirectory.DirectoryEntry instance, bool isDelta) { }

	public static PhoneDirectory.DirectoryEntry DeserializeLengthDelimited(Stream stream, PhoneDirectory.DirectoryEntry instance, bool isDelta) { }

	public static PhoneDirectory.DirectoryEntry DeserializeLength(Stream stream, int length, PhoneDirectory.DirectoryEntry instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, PhoneDirectory.DirectoryEntry instance, PhoneDirectory.DirectoryEntry previous) { }

	public static void Serialize(Stream stream, PhoneDirectory.DirectoryEntry instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(PhoneDirectory.DirectoryEntry instance) { }

	public static void SerializeLengthDelimited(Stream stream, PhoneDirectory.DirectoryEntry instance) { }

	public void .ctor() { }

}

