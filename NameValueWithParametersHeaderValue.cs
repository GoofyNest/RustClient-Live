public class NameValueWithParametersHeaderValue : NameValueHeaderValue, ICloneable // TypeDefIndex: 5793
{
	private List<NameValueHeaderValue> parameters; 

	public ICollection<NameValueHeaderValue> Parameters { get; }


	protected void .ctor(NameValueWithParametersHeaderValue source) { }

	private void .ctor() { }

	public ICollection<NameValueHeaderValue> get_Parameters() { }

	private object System.ICloneable.Clone() { }

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

	public override string ToString() { }

	internal static bool TryParse(string input, int minimalCount, out List<NameValueWithParametersHeaderValue> result) { }

	private static bool TryParseElement(Lexer lexer, out NameValueWithParametersHeaderValue parsedValue, out Token t) { }

}

