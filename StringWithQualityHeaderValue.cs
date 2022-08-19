public class StringWithQualityHeaderValue : ICloneable // TypeDefIndex: 5807
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Nullable<double> <Quality>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <Value>k__BackingField; // 0x20

	// Properties
	public Nullable<double> Quality { get; set; }
	public string Value { get; set; }

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	private void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xFE0C30 Offset: 0xFE0030 VA: 0x180FE0C30
	public Nullable<double> get_Quality() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1091450 Offset: 0x1090850 VA: 0x181091450
	private void set_Quality(Nullable<double> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	public string get_Value() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497E30 Offset: 0x497230 VA: 0x180497E30
	private void set_Value(string value) { }

	// RVA: 0xD6C080 Offset: 0xD6B480 VA: 0x180D6C080 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x1091BB0 Offset: 0x1090FB0 VA: 0x181091BB0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1091C90 Offset: 0x1091090 VA: 0x181091C90 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x10921B0 Offset: 0x10915B0 VA: 0x1810921B0
	internal static bool TryParse(string input, int minimalCount, out List<StringWithQualityHeaderValue> result) { }

	// RVA: 0x1091DF0 Offset: 0x10911F0 VA: 0x181091DF0
	private static bool TryParseElement(Lexer lexer, out StringWithQualityHeaderValue parsedValue, out Token t) { }

	// RVA: 0x1091D20 Offset: 0x1091120 VA: 0x181091D20 Slot: 3
	public override string ToString() { }

}

