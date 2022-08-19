public static class ProtocolParser // TypeDefIndex: 6280
{	// Fields
	private static byte[] staticBuffer; // 0x2B0AFD0

	// Methods

	// RVA: 0x1E41F90 Offset: 0x1E41390 VA: 0x181E41F90
	public static float ReadSingle(Stream stream) { }

	// RVA: 0x1E430F0 Offset: 0x1E424F0 VA: 0x181E430F0
	public static void WriteSingle(Stream stream, float f) { }

	// RVA: 0x1E41AA0 Offset: 0x1E40EA0 VA: 0x181E41AA0
	public static double ReadDouble(Stream stream) { }

	// RVA: 0x1E42BC0 Offset: 0x1E41FC0 VA: 0x181E42BC0
	public static void WriteDouble(Stream stream, double f) { }

	// RVA: 0x1E420E0 Offset: 0x1E414E0 VA: 0x181E420E0
	public static string ReadString(Stream stream) { }

	// RVA: 0x1E419E0 Offset: 0x1E40DE0 VA: 0x181E419E0
	public static byte[] ReadBytes(Stream stream) { }

	// RVA: 0x1E41DC0 Offset: 0x1E411C0 VA: 0x181E41DC0
	public static ArraySegment<byte> ReadPooledBytes(Stream stream) { }

	// RVA: 0x1E41830 Offset: 0x1E40C30 VA: 0x181E41830
	private static void ReadBytesInto(Stream stream, byte[] buffer, int length) { }

	// RVA: 0x1E42760 Offset: 0x1E41B60 VA: 0x181E42760
	public static void SkipBytes(Stream stream) { }

	// RVA: 0x1E431B0 Offset: 0x1E425B0 VA: 0x181E431B0
	public static void WriteString(Stream stream, string val) { }

	// RVA: 0x1E42AE0 Offset: 0x1E41EE0 VA: 0x181E42AE0
	public static void WriteBytes(Stream stream, byte[] val) { }

	// RVA: 0x1E42F50 Offset: 0x1E42350 VA: 0x181E42F50
	public static void WritePooledBytes(Stream stream, ArraySegment<byte> segment) { }

	[ObsoleteAttribute] // RVA: 0xB05C0 Offset: 0xAF9C0 VA: 0x1800B05C0
	// RVA: 0x1E41B90 Offset: 0x1E40F90 VA: 0x181E41B90
	public static ulong ReadFixed64(BinaryReader reader) { }

	[ObsoleteAttribute] // RVA: 0xB05C0 Offset: 0xAF9C0 VA: 0x1800B05C0
	// RVA: 0x1E41F60 Offset: 0x1E41360 VA: 0x181E41F60
	public static long ReadSFixed64(BinaryReader reader) { }

	[ObsoleteAttribute] // RVA: 0xB05C0 Offset: 0xAF9C0 VA: 0x1800B05C0
	// RVA: 0x1E41B60 Offset: 0x1E40F60 VA: 0x181E41B60
	public static uint ReadFixed32(BinaryReader reader) { }

	[ObsoleteAttribute] // RVA: 0xB05C0 Offset: 0xAF9C0 VA: 0x1800B05C0
	// RVA: 0x1E41F30 Offset: 0x1E41330 VA: 0x181E41F30
	public static int ReadSFixed32(BinaryReader reader) { }

	[ObsoleteAttribute] // RVA: 0xB05C0 Offset: 0xAF9C0 VA: 0x1800B05C0
	// RVA: 0x1E42CE0 Offset: 0x1E420E0 VA: 0x181E42CE0
	public static void WriteFixed64(BinaryWriter writer, ulong val) { }

	[ObsoleteAttribute] // RVA: 0xB05C0 Offset: 0xAF9C0 VA: 0x1800B05C0
	// RVA: 0x1E430C0 Offset: 0x1E424C0 VA: 0x181E430C0
	public static void WriteSFixed64(BinaryWriter writer, long val) { }

	[ObsoleteAttribute] // RVA: 0xB05C0 Offset: 0xAF9C0 VA: 0x1800B05C0
	// RVA: 0x1E42CB0 Offset: 0x1E420B0 VA: 0x181E42CB0
	public static void WriteFixed32(BinaryWriter writer, uint val) { }

	[ObsoleteAttribute] // RVA: 0xB05C0 Offset: 0xAF9C0 VA: 0x1800B05C0
	// RVA: 0x1E43090 Offset: 0x1E42490 VA: 0x181E43090
	public static void WriteSFixed32(BinaryWriter writer, int val) { }

	[ObsoleteAttribute] // RVA: 0xB05C0 Offset: 0xAF9C0 VA: 0x1800B05C0
	// RVA: 0x1E41BC0 Offset: 0x1E40FC0 VA: 0x181E41BC0
	public static float ReadFloat(BinaryReader reader) { }

	[ObsoleteAttribute] // RVA: 0xB05C0 Offset: 0xAF9C0 VA: 0x1800B05C0
	// RVA: 0x1E41A70 Offset: 0x1E40E70 VA: 0x181E41A70
	public static double ReadDouble(BinaryReader reader) { }

	[ObsoleteAttribute] // RVA: 0xB05C0 Offset: 0xAF9C0 VA: 0x1800B05C0
	// RVA: 0x1DCD890 Offset: 0x1DCCC90 VA: 0x181DCD890
	public static void WriteFloat(BinaryWriter writer, float val) { }

	[ObsoleteAttribute] // RVA: 0xB05C0 Offset: 0xAF9C0 VA: 0x1800B05C0
	// RVA: 0x1E42C80 Offset: 0x1E42080 VA: 0x181E42C80
	public static void WriteDouble(BinaryWriter writer, double val) { }

	// RVA: 0x1E41D50 Offset: 0x1E41150 VA: 0x181E41D50
	public static Key ReadKey(Stream stream) { }

	// RVA: 0x1E41CB0 Offset: 0x1E410B0 VA: 0x181E41CB0
	public static Key ReadKey(byte firstByte, Stream stream) { }

	// RVA: 0x1E42E90 Offset: 0x1E42290 VA: 0x181E42E90
	public static void WriteKey(Stream stream, Key key) { }

	// RVA: 0x1E428A0 Offset: 0x1E41CA0 VA: 0x181E428A0
	public static void SkipKey(Stream stream, Key key) { }

	// RVA: 0x1E424F0 Offset: 0x1E418F0 VA: 0x181E424F0
	public static byte[] ReadValueBytes(Stream stream, Key key) { }

	// RVA: 0x1E42050 Offset: 0x1E41450 VA: 0x181E42050
	public static void ReadSkipVarInt(Stream stream) { }

	// RVA: 0x1E42550 Offset: 0x1E41950 VA: 0x181E42550
	public static byte[] ReadVarIntBytes(Stream stream) { }

	[ObsoleteAttribute] // RVA: 0xB1E80 Offset: 0xB1280 VA: 0x1800B1E80
	// RVA: 0x1E41BF0 Offset: 0x1E40FF0 VA: 0x181E41BF0
	public static int ReadInt32(Stream stream) { }

	[ObsoleteAttribute] // RVA: 0xB2030 Offset: 0xB1430 VA: 0x1800B2030
	// RVA: 0x1E42D10 Offset: 0x1E42110 VA: 0x181E42D10
	public static void WriteInt32(Stream stream, int val) { }

	// RVA: 0x1E42690 Offset: 0x1E41A90 VA: 0x181E42690
	public static int ReadZInt32(Stream stream) { }

	// RVA: 0x1E43410 Offset: 0x1E42810 VA: 0x181E43410
	public static void WriteZInt32(Stream stream, int val) { }

	// RVA: 0x1E42290 Offset: 0x1E41690 VA: 0x181E42290
	public static uint ReadUInt32(Stream stream) { }

	// RVA: 0x1E43310 Offset: 0x1E42710 VA: 0x181E43310
	public static void WriteUInt32(Stream stream, uint val) { }

	[ObsoleteAttribute] // RVA: 0xB21C0 Offset: 0xB15C0 VA: 0x1800B21C0
	// RVA: 0x1E41C50 Offset: 0x1E41050 VA: 0x181E41C50
	public static int ReadInt64(Stream stream) { }

	[ObsoleteAttribute] // RVA: 0xB22A0 Offset: 0xB16A0 VA: 0x1800B22A0
	// RVA: 0x1E42DD0 Offset: 0x1E421D0 VA: 0x181E42DD0
	public static void WriteInt64(Stream stream, int val) { }

	// RVA: 0x1E426F0 Offset: 0x1E41AF0 VA: 0x181E426F0
	public static long ReadZInt64(Stream stream) { }

	// RVA: 0x1E434D0 Offset: 0x1E428D0 VA: 0x181E434D0
	public static void WriteZInt64(Stream stream, long val) { }

	// RVA: 0x1E423C0 Offset: 0x1E417C0 VA: 0x181E423C0
	public static ulong ReadUInt64(Stream stream) { }

	// RVA: 0x1E43390 Offset: 0x1E42790 VA: 0x181E43390
	public static void WriteUInt64(Stream stream, ulong val) { }

	// RVA: 0x1E41770 Offset: 0x1E40B70 VA: 0x181E41770
	public static bool ReadBool(Stream stream) { }

	// RVA: 0x1E42AB0 Offset: 0x1E41EB0 VA: 0x181E42AB0
	public static void WriteBool(Stream stream, bool val) { }

	// RVA: 0x1E435A0 Offset: 0x1E429A0 VA: 0x181E435A0
	private static void .cctor() { }

}

