public class NameValueHeaderValue : ICloneable // TypeDefIndex: 5796
{
	internal string value;
	[CompilerGeneratedAttribute]
	private string <Name>k__BackingField;

	public string Name { get; set; }
	public string Value { get; set; }


	public void .ctor(string name, string value) { }

	protected internal void .ctor(NameValueHeaderValue source) { }

	internal void .ctor() { }

	[CompilerGeneratedAttribute]
	public string get_Name() { }

	[CompilerGeneratedAttribute]
	internal void set_Name(string value) { }

	public string get_Value() { }

	public void set_Value(string value) { }

	internal static NameValueHeaderValue Create(string name, string value) { }

	private object System.ICloneable.Clone() { }

	public override int GetHashCode() { }

	public override bool Equals(object obj) { }

	internal static bool TryParsePragma(string input, int minimalCount, out List<NameValueHeaderValue> result) { }

	internal static bool TryParseParameters(Lexer lexer, out List<NameValueHeaderValue> result, out Token t) { }

	public override string ToString() { }

	private static bool TryParseElement(Lexer lexer, out NameValueHeaderValue parsedValue, out Token t) { }

}

