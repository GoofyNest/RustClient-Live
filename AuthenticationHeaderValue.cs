public class AuthenticationHeaderValue : ICloneable // TypeDefIndex: 5762
{
	[CompilerGeneratedAttribute] 
	private string <Parameter>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private string <Scheme>k__BackingField; 

	public string Parameter { get; set; }
	public string Scheme { get; set; }


	private void .ctor() { }

	[CompilerGeneratedAttribute] 
	public string get_Parameter() { }

	[CompilerGeneratedAttribute] 
	private void set_Parameter(string value) { }

	[CompilerGeneratedAttribute] 
	public string get_Scheme() { }

	[CompilerGeneratedAttribute] 
	private void set_Scheme(string value) { }

	private object System.ICloneable.Clone() { }

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

	public static bool TryParse(string input, out AuthenticationHeaderValue parsedValue) { }

	internal static bool TryParse(string input, int minimalCount, out List<AuthenticationHeaderValue> result) { }

	private static bool TryParseElement(Lexer lexer, out AuthenticationHeaderValue parsedValue, out Token t) { }

	public override string ToString() { }

}

