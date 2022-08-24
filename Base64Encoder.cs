internal abstract class Base64Encoder // TypeDefIndex: 1813
{
	private byte[] leftOverBytes; 
	private int leftOverBytesCount; 
	private char[] charsLine; 


	internal void .ctor() { }

	internal abstract void WriteChars(char[] chars, int index, int count);

	internal void Encode(byte[] buffer, int index, int count) { }

	internal void Flush() { }

}

internal class Base64Encoder // TypeDefIndex: 5917
{
	private readonly char[] _charsLine; 
	private readonly TextWriter _writer; 
	private byte[] _leftOverBytes; 
	private int _leftOverBytesCount; 


	public void .ctor(TextWriter writer) { }

	public void Encode(byte[] buffer, int index, int count) { }

	public void Flush() { }

	private void WriteChars(char[] chars, int index, int count) { }

}

