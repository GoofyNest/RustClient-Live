internal abstract class Base64Encoder // TypeDefIndex: 1813
{	// Fields
	private byte[] leftOverBytes; // 0x10
	private int leftOverBytesCount; // 0x18
	private char[] charsLine; // 0x20

	// Methods

	// RVA: 0x12D85F0 Offset: 0x12D79F0 VA: 0x1812D85F0
	internal void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	internal abstract void WriteChars(char[] chars, int index, int count);

	// RVA: 0x12D81A0 Offset: 0x12D75A0 VA: 0x1812D81A0
	internal void Encode(byte[] buffer, int index, int count) { }

	// RVA: 0x12D8520 Offset: 0x12D7920 VA: 0x1812D8520
	internal void Flush() { }

}

internal class Base64Encoder // TypeDefIndex: 5917
{	// Fields
	private readonly char[] _charsLine; // 0x10
	private readonly TextWriter _writer; // 0x18
	private byte[] _leftOverBytes; // 0x20
	private int _leftOverBytesCount; // 0x28

	// Methods

	// RVA: 0x17F8F80 Offset: 0x17F8380 VA: 0x1817F8F80
	public void .ctor(TextWriter writer) { }

	// RVA: 0x17F8AF0 Offset: 0x17F7EF0 VA: 0x1817F8AF0
	public void Encode(byte[] buffer, int index, int count) { }

	// RVA: 0x17F8E80 Offset: 0x17F8280 VA: 0x1817F8E80
	public void Flush() { }

	// RVA: 0x17F8F50 Offset: 0x17F8350 VA: 0x1817F8F50
	private void WriteChars(char[] chars, int index, int count) { }

}

