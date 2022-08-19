public class WarningHeaderValue : ICloneable // TypeDefIndex: 5811
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <Agent>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <Code>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Nullable<DateTimeOffset> <Date>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <Text>k__BackingField; // 0x38

	// Properties
	public string Agent { get; set; }
	public int Code { get; set; }
	public Nullable<DateTimeOffset> Date { get; set; }
	public string Text { get; set; }

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	private void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public string get_Agent() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B94C0 Offset: 0x4B88C0 VA: 0x1804B94C0
	private void set_Agent(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4BE200 Offset: 0x4BD600 VA: 0x1804BE200
	public int get_Code() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7E8E20 Offset: 0x7E8220 VA: 0x1807E8E20
	private void set_Code(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1097290 Offset: 0x1096690 VA: 0x181097290
	public Nullable<DateTimeOffset> get_Date() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x10972B0 Offset: 0x10966B0 VA: 0x1810972B0
	private void set_Date(Nullable<DateTimeOffset> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5DCC00 Offset: 0x5DC000 VA: 0x1805DCC00
	public string get_Text() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5089D0 Offset: 0x507DD0 VA: 0x1805089D0
	private void set_Text(string value) { }

	// RVA: 0x1096A10 Offset: 0x1095E10 VA: 0x181096A10
	private static bool IsCodeValid(int code) { }

	// RVA: 0xD6C080 Offset: 0xD6B480 VA: 0x180D6C080 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x10967D0 Offset: 0x1095BD0 VA: 0x1810967D0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1096930 Offset: 0x1095D30 VA: 0x181096930 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1097200 Offset: 0x1096600 VA: 0x181097200
	internal static bool TryParse(string input, int minimalCount, out List<WarningHeaderValue> result) { }

	// RVA: 0x1096D50 Offset: 0x1096150 VA: 0x181096D50
	private static bool TryParseElement(Lexer lexer, out WarningHeaderValue parsedValue, out Token t) { }

	// RVA: 0x1096A30 Offset: 0x1095E30 VA: 0x181096A30 Slot: 3
	public override string ToString() { }

}

