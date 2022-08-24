internal sealed class ParsingResult // TypeDefIndex: 7630
{
	public static readonly ParsingResult Parsed; 
	public static readonly ParsingResult EmptyInputString; 
	public static readonly ParsingResult NotMatched; 
	private readonly string _error; 
	[CompilerGeneratedAttribute] 
	private readonly ParsingStatus <Status>k__BackingField; 


private void .ctor(string error) { }

private void .ctor(ParsingStatus status) { }

private void .ctor(ParsingStatus status, string error) { }

public static ParsingResult Error(string error) { }

private static void .cctor() { }

}

