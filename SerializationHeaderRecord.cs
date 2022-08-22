internal sealed class SerializationHeaderRecord // TypeDefIndex: 1071
{	internal int binaryFormatterMajorVersion; // 0x10
	internal int binaryFormatterMinorVersion; // 0x14
	internal BinaryHeaderEnum binaryHeaderEnum; // 0x18
	internal int topId; // 0x1C
	internal int headerId; // 0x20
	internal int majorVersion; // 0x24
	internal int minorVersion; // 0x28


	internal void .ctor() { }

	internal void .ctor(BinaryHeaderEnum binaryHeaderEnum, int topId, int headerId, int majorVersion, int minorVersion) { }

	public void Write(__BinaryWriter sout) { }

	private static int GetInt32(byte[] buffer, int index) { }

	public void Read(__BinaryParser input) { }

	public void Dump() { }

}

