internal class TermInfoReader // TypeDefIndex: 399
{
	private short boolSize; 
	private short numSize; 
	private short strOffsets; 
	private byte[] buffer; 
	private int booleansOffset; 


	public void .ctor(string term, string filename) { }

	public void .ctor(string term, byte[] buffer) { }

	private void ReadHeader(byte[] buffer, ref int position) { }

	private void ReadNames(byte[] buffer, ref int position) { }

	public int Get(TermInfoNumbers number) { }

	public string Get(TermInfoStrings tstr) { }

	public byte[] GetStringBytes(TermInfoStrings tstr) { }

	private short GetInt16(byte[] buffer, int offset) { }

	private string GetString(byte[] buffer, int offset) { }

	private byte[] GetStringBytes(byte[] buffer, int offset) { }

}

