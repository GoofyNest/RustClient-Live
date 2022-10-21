public class Photo : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6388
{
	public bool ShouldPool; 
	private bool _disposed; 
	public ulong photographerSteamId; 
	public uint imageCrc; 


	public static void ResetToPool(Photo instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(Photo instance) { }

	public Photo Copy() { }

	public static Photo Deserialize(Stream stream) { }

	public static Photo DeserializeLengthDelimited(Stream stream) { }

	public static Photo DeserializeLength(Stream stream, int length) { }

	public static Photo Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, Photo previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static Photo Deserialize(byte[] buffer, Photo instance, bool isDelta = False) { }

	public static Photo Deserialize(Stream stream, Photo instance, bool isDelta) { }

	public static Photo DeserializeLengthDelimited(Stream stream, Photo instance, bool isDelta) { }

	public static Photo DeserializeLength(Stream stream, int length, Photo instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, Photo instance, Photo previous) { }

	public static void Serialize(Stream stream, Photo instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(Photo instance) { }

	public static void SerializeLengthDelimited(Stream stream, Photo instance) { }

	public void .ctor() { }

}

