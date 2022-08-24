public class ViaHeaderValue : ICloneable // TypeDefIndex: 5810
{
	[CompilerGeneratedAttribute] 
	private string <Comment>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private string <ProtocolName>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private string <ProtocolVersion>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private string <ReceivedBy>k__BackingField; 

	public string Comment { get; set; }
	public string ProtocolName { get; set; }
	public string ProtocolVersion { get; set; }
	public string ReceivedBy { get; set; }


	private void .ctor() { }

	[CompilerGeneratedAttribute] 
	public string get_Comment() { }

	[CompilerGeneratedAttribute] 
	private void set_Comment(string value) { }

	[CompilerGeneratedAttribute] 
	public string get_ProtocolName() { }

	[CompilerGeneratedAttribute] 
	private void set_ProtocolName(string value) { }

	[CompilerGeneratedAttribute] 
	public string get_ProtocolVersion() { }

	[CompilerGeneratedAttribute] 
	private void set_ProtocolVersion(string value) { }

	[CompilerGeneratedAttribute] 
	public string get_ReceivedBy() { }

	[CompilerGeneratedAttribute] 
	private void set_ReceivedBy(string value) { }

	private object System.ICloneable.Clone() { }

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

	internal static bool TryParse(string input, int minimalCount, out List<ViaHeaderValue> result) { }

	private static bool TryParseElement(Lexer lexer, out ViaHeaderValue parsedValue, out Token t) { }

	public override string ToString() { }

}

