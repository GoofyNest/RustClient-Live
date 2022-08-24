public class ProductHeaderValue : ICloneable // TypeDefIndex: 5801
{
	[CompilerGeneratedAttribute] 
	private string <Name>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private string <Version>k__BackingField; 

	public string Name { get; set; }
	public string Version { get; set; }


	internal void .ctor() { }

	[CompilerGeneratedAttribute] 
	public string get_Name() { }

	[CompilerGeneratedAttribute] 
	internal void set_Name(string value) { }

	[CompilerGeneratedAttribute] 
	public string get_Version() { }

	[CompilerGeneratedAttribute] 
	internal void set_Version(string value) { }

	private object System.ICloneable.Clone() { }

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

	internal static bool TryParse(string input, int minimalCount, out List<ProductHeaderValue> result) { }

	private static bool TryParseElement(Lexer lexer, out ProductHeaderValue parsedValue, out Token t) { }

	public override string ToString() { }

}

