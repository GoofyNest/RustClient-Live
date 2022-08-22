internal class TermInfoReader // TypeDefIndex: 399
{	private short boolSize; // 0x10
	private short numSize; // 0x12
	private short strOffsets; // 0x14
	private byte[] buffer; // 0x18
	private int booleansOffset; // 0x20


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

