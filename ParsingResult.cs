internal sealed class ParsingResult // TypeDefIndex: 7630
{	// Fields
	public static readonly ParsingResult Parsed; // 0x0
	public static readonly ParsingResult EmptyInputString; // 0x8
	public static readonly ParsingResult NotMatched; // 0x10
	private readonly string _error; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly ParsingStatus <Status>k__BackingField; // 0x18

	// Methods

	// RVA: 0x139F040 Offset: 0x139E440 VA: 0x18139F040
	private void .ctor(string error) { }

	// RVA: 0x139F0C0 Offset: 0x139E4C0 VA: 0x18139F0C0
	private void .ctor(ParsingStatus status) { }

	// RVA: 0x139F080 Offset: 0x139E480 VA: 0x18139F080
	private void .ctor(ParsingStatus status, string error) { }

	// RVA: 0x139EEC0 Offset: 0x139E2C0 VA: 0x18139EEC0
	public static ParsingResult Error(string error) { }

	// RVA: 0x139EF30 Offset: 0x139E330 VA: 0x18139EF30
	private static void .cctor() { }

}

