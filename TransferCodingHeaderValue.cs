public class TransferCodingHeaderValue : ICloneable // TypeDefIndex: 5815
{
	internal string value; 
	internal List<NameValueHeaderValue> parameters; 

	public ICollection<NameValueHeaderValue> Parameters { get; }
	public string Value { get; }


	protected void .ctor(TransferCodingHeaderValue source) { }

	internal void .ctor() { }

	public ICollection<NameValueHeaderValue> get_Parameters() { }

	public string get_Value() { }

	private object System.ICloneable.Clone() { }

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

	public override string ToString() { }

	internal static bool TryParse(string input, int minimalCount, out List<TransferCodingHeaderValue> result) { }

	private static bool TryParseElement(Lexer lexer, out TransferCodingHeaderValue parsedValue, out Token t) { }

}

