internal sealed class SerializationHeaderRecord // TypeDefIndex: 1071
{
	internal int binaryFormatterMajorVersion; 
	internal int binaryFormatterMinorVersion; 
	internal BinaryHeaderEnum binaryHeaderEnum; 
	internal int topId; 
	internal int headerId; 
	internal int majorVersion; 
	internal int minorVersion; 


internal void .ctor() { }

internal void .ctor(BinaryHeaderEnum binaryHeaderEnum, int topId, int headerId, int majorVersion, int minorVersion) { }

public void Write(__BinaryWriter sout) { }

private static int GetInt32(byte[] buffer, int index) { }

public void Read(__BinaryParser input) { }

public void Dump() { }

}

