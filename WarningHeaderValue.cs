public class WarningHeaderValue : ICloneable // TypeDefIndex: 5820
{
	[CompilerGeneratedAttribute]
	private string <Agent>k__BackingField;
	[CompilerGeneratedAttribute]
	private int <Code>k__BackingField;
	[CompilerGeneratedAttribute]
	private Nullable<DateTimeOffset> <Date>k__BackingField;
	[CompilerGeneratedAttribute]
	private string <Text>k__BackingField;

	public string Agent { get; set; }
	public int Code { get; set; }
	public Nullable<DateTimeOffset> Date { get; set; }
	public string Text { get; set; }


	private void .ctor() { }

	[CompilerGeneratedAttribute]
	public string get_Agent() { }

	[CompilerGeneratedAttribute]
	private void set_Agent(string value) { }

	[CompilerGeneratedAttribute]
	public int get_Code() { }

	[CompilerGeneratedAttribute]
	private void set_Code(int value) { }

	[CompilerGeneratedAttribute]
	public Nullable<DateTimeOffset> get_Date() { }

	[CompilerGeneratedAttribute]
	private void set_Date(Nullable<DateTimeOffset> value) { }

	[CompilerGeneratedAttribute]
	public string get_Text() { }

	[CompilerGeneratedAttribute]
	private void set_Text(string value) { }

	private static bool IsCodeValid(int code) { }

	private object System.ICloneable.Clone() { }

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

	internal static bool TryParse(string input, int minimalCount, out List<WarningHeaderValue> result) { }

	private static bool TryParseElement(Lexer lexer, out WarningHeaderValue parsedValue, out Token t) { }

	public override string ToString() { }

}

