public class StringWriter : TextWriter // TypeDefIndex: 650
{
	private static UnicodeEncoding m_encoding;
	private StringBuilder _sb;
	private bool _isOpen;

	public override Encoding Encoding { get; }


	public void .ctor() { }

	public void .ctor(IFormatProvider formatProvider) { }

	public void .ctor(StringBuilder sb) { }

	public void .ctor(StringBuilder sb, IFormatProvider formatProvider) { }

	public override void Close() { }

	protected override void Dispose(bool disposing) { }

	public override Encoding get_Encoding() { }

	public override void Write(char value) { }

	public override void Write(char[] buffer, int index, int count) { }

	public override void Write(string value) { }

	public override string ToString() { }

}

