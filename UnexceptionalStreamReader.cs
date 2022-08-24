internal class UnexceptionalStreamReader : StreamReader // TypeDefIndex: 681
{
	private static bool[] newline; 
	private static char newlineChar; 


	private static void .cctor() { }

	public void .ctor(Stream stream, Encoding encoding) { }

	public override int Peek() { }

	public override int Read() { }

	public override int Read([In] [Out] char[] dest_buffer, int index, int count) { }

	private bool CheckEOL(char current) { }

	public override string ReadLine() { }

	public override string ReadToEnd() { }

}

