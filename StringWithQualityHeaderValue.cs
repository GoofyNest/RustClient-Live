public class StringWithQualityHeaderValue : ICloneable // TypeDefIndex: 5812
{
	[CompilerGeneratedAttribute] 
	private Nullable<double> <Quality>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private string <Value>k__BackingField; 

	public Nullable<double> Quality { get; set; }
	public string Value { get; set; }


	private void .ctor() { }

	[CompilerGeneratedAttribute] 
	public Nullable<double> get_Quality() { }

	[CompilerGeneratedAttribute] 
	private void set_Quality(Nullable<double> value) { }

	[CompilerGeneratedAttribute] 
	public string get_Value() { }

	[CompilerGeneratedAttribute] 
	private void set_Value(string value) { }

	private object System.ICloneable.Clone() { }

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

	internal static bool TryParse(string input, int minimalCount, out List<StringWithQualityHeaderValue> result) { }

	private static bool TryParseElement(Lexer lexer, out StringWithQualityHeaderValue parsedValue, out Token t) { }

	public override string ToString() { }

}

