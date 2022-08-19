internal class CStreamWriter : StreamWriter // TypeDefIndex: 684
{	// Fields
	private TermInfoDriver driver; // 0x68

	// Methods

	// RVA: 0x1373B60 Offset: 0x1372F60 VA: 0x181373B60
	public void .ctor(Stream stream, Encoding encoding, bool leaveOpen) { }

	// RVA: 0x1373780 Offset: 0x1372B80 VA: 0x181373780 Slot: 14
	public override void Write(char[] buffer, int index, int count) { }

	// RVA: 0x13739E0 Offset: 0x1372DE0 VA: 0x1813739E0 Slot: 12
	public override void Write(char val) { }

	// RVA: 0x1373670 Offset: 0x1372A70 VA: 0x181373670
	public void InternalWriteString(string val) { }

	// RVA: 0x1373590 Offset: 0x1372990 VA: 0x181373590
	public void InternalWriteChar(char val) { }

	// RVA: 0x13735F0 Offset: 0x13729F0 VA: 0x1813735F0
	public void InternalWriteChars(char[] buffer, int n) { }

	// RVA: 0x1373B20 Offset: 0x1372F20 VA: 0x181373B20 Slot: 13
	public override void Write(char[] val) { }

	// RVA: 0x13736D0 Offset: 0x1372AD0 VA: 0x1813736D0 Slot: 15
	public override void Write(string val) { }

}

