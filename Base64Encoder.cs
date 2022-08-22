internal abstract class Base64Encoder // TypeDefIndex: 1813
{	private byte[] leftOverBytes; // 0x10
	private int leftOverBytesCount; // 0x18
	private char[] charsLine; // 0x20


	internal void .ctor() { }

	internal abstract void WriteChars(char[] chars, int index, int count);

	internal void Encode(byte[] buffer, int index, int count) { }

	internal void Flush() { }

}

internal class Base64Encoder // TypeDefIndex: 5917
{	private readonly char[] _charsLine; // 0x10
	private readonly TextWriter _writer; // 0x18
	private byte[] _leftOverBytes; // 0x20
	private int _leftOverBytesCount; // 0x28


	public void .ctor(TextWriter writer) { }

	public void Encode(byte[] buffer, int index, int count) { }

	public void Flush() { }

	private void WriteChars(char[] chars, int index, int count) { }

}

