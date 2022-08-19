internal class UnexceptionalStreamReader : StreamReader // TypeDefIndex: 681
{	// Fields
	private static bool[] newline; // 0x0
	private static char newlineChar; // 0x8

	// Methods

	// RVA: 0x1632D30 Offset: 0x1632130 VA: 0x181632D30
	private static void .cctor() { }

	// RVA: 0x1632DC0 Offset: 0x16321C0 VA: 0x181632DC0
	public void .ctor(Stream stream, Encoding encoding) { }

	// RVA: 0x1632880 Offset: 0x1631C80 VA: 0x181632880 Slot: 9
	public override int Peek() { }

	// RVA: 0x1632AD0 Offset: 0x1631ED0 VA: 0x181632AD0 Slot: 10
	public override int Read() { }

	// RVA: 0x1632B30 Offset: 0x1631F30 VA: 0x181632B30 Slot: 11
	public override int Read([In] [Out] char[] dest_buffer, int index, int count) { }

	// RVA: 0x1632650 Offset: 0x1631A50 VA: 0x181632650
	private bool CheckEOL(char current) { }

	// RVA: 0x1632950 Offset: 0x1631D50 VA: 0x181632950 Slot: 13
	public override string ReadLine() { }

	// RVA: 0x16329B0 Offset: 0x1631DB0 VA: 0x1816329B0 Slot: 12
	public override string ReadToEnd() { }

}

