internal sealed class SerializationHeaderRecord // TypeDefIndex: 1071
{	// Fields
	internal int binaryFormatterMajorVersion; // 0x10
	internal int binaryFormatterMinorVersion; // 0x14
	internal BinaryHeaderEnum binaryHeaderEnum; // 0x18
	internal int topId; // 0x1C
	internal int headerId; // 0x20
	internal int majorVersion; // 0x24
	internal int minorVersion; // 0x28

	// Methods

	// RVA: 0x1071990 Offset: 0x1070D90 VA: 0x181071990
	internal void .ctor() { }

	// RVA: 0x11FD940 Offset: 0x11FCD40 VA: 0x1811FD940
	internal void .ctor(BinaryHeaderEnum binaryHeaderEnum, int topId, int headerId, int majorVersion, int minorVersion) { }

	// RVA: 0x11FD8C0 Offset: 0x11FCCC0 VA: 0x1811FD8C0 Slot: 4
	public void Write(__BinaryWriter sout) { }

	// RVA: 0x11FD490 Offset: 0x11FC890 VA: 0x1811FD490
	private static int GetInt32(byte[] buffer, int index) { }

	// RVA: 0x11FD540 Offset: 0x11FC940 VA: 0x1811FD540 Slot: 5
	public void Read(__BinaryParser input) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public void Dump() { }

}

