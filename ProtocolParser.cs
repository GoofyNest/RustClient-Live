public static class ProtocolParser // TypeDefIndex: 6280
{
	private static byte[] staticBuffer; 


public static float ReadSingle(Stream stream) { }

public static void WriteSingle(Stream stream, float f) { }

public static double ReadDouble(Stream stream) { }

public static void WriteDouble(Stream stream, double f) { }

public static string ReadString(Stream stream) { }

public static byte[] ReadBytes(Stream stream) { }

public static ArraySegment<byte> ReadPooledBytes(Stream stream) { }

private static void ReadBytesInto(Stream stream, byte[] buffer, int length) { }

public static void SkipBytes(Stream stream) { }

public static void WriteString(Stream stream, string val) { }

public static void WriteBytes(Stream stream, byte[] val) { }

public static void WritePooledBytes(Stream stream, ArraySegment<byte> segment) { }

	[ObsoleteAttribute] 
public static ulong ReadFixed64(BinaryReader reader) { }

	[ObsoleteAttribute] 
public static long ReadSFixed64(BinaryReader reader) { }

	[ObsoleteAttribute] 
public static uint ReadFixed32(BinaryReader reader) { }

	[ObsoleteAttribute] 
public static int ReadSFixed32(BinaryReader reader) { }

	[ObsoleteAttribute] 
public static void WriteFixed64(BinaryWriter writer, ulong val) { }

	[ObsoleteAttribute] 
public static void WriteSFixed64(BinaryWriter writer, long val) { }

	[ObsoleteAttribute] 
public static void WriteFixed32(BinaryWriter writer, uint val) { }

	[ObsoleteAttribute] 
public static void WriteSFixed32(BinaryWriter writer, int val) { }

	[ObsoleteAttribute] 
public static float ReadFloat(BinaryReader reader) { }

	[ObsoleteAttribute] 
public static double ReadDouble(BinaryReader reader) { }

	[ObsoleteAttribute] 
public static void WriteFloat(BinaryWriter writer, float val) { }

	[ObsoleteAttribute] 
public static void WriteDouble(BinaryWriter writer, double val) { }

public static Key ReadKey(Stream stream) { }

public static Key ReadKey(byte firstByte, Stream stream) { }

public static void WriteKey(Stream stream, Key key) { }

public static void SkipKey(Stream stream, Key key) { }

public static byte[] ReadValueBytes(Stream stream, Key key) { }

public static void ReadSkipVarInt(Stream stream) { }

public static byte[] ReadVarIntBytes(Stream stream) { }

	[ObsoleteAttribute] 
public static int ReadInt32(Stream stream) { }

	[ObsoleteAttribute] 
public static void WriteInt32(Stream stream, int val) { }

public static int ReadZInt32(Stream stream) { }

public static void WriteZInt32(Stream stream, int val) { }

public static uint ReadUInt32(Stream stream) { }

public static void WriteUInt32(Stream stream, uint val) { }

	[ObsoleteAttribute] 
public static int ReadInt64(Stream stream) { }

	[ObsoleteAttribute] 
public static void WriteInt64(Stream stream, int val) { }

public static long ReadZInt64(Stream stream) { }

public static void WriteZInt64(Stream stream, long val) { }

public static ulong ReadUInt64(Stream stream) { }

public static void WriteUInt64(Stream stream, ulong val) { }

public static bool ReadBool(Stream stream) { }

public static void WriteBool(Stream stream, bool val) { }

private static void .cctor() { }

}

