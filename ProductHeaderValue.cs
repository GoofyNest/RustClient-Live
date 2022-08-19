public class ProductHeaderValue : ICloneable // TypeDefIndex: 5801
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <Name>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <Version>k__BackingField; // 0x18

	// Properties
	public string Name { get; set; }
	public string Version { get; set; }

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	internal void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public string get_Name() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B94C0 Offset: 0x4B88C0 VA: 0x1804B94C0
	internal void set_Name(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public string get_Version() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4D0180 Offset: 0x4CF580 VA: 0x1804D0180
	internal void set_Version(string value) { }

	// RVA: 0xD6C080 Offset: 0xD6B480 VA: 0x180D6C080 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x108EF80 Offset: 0x108E380 VA: 0x18108EF80 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x108F040 Offset: 0x108E440 VA: 0x18108F040 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x108F350 Offset: 0x108E750 VA: 0x18108F350
	internal static bool TryParse(string input, int minimalCount, out List<ProductHeaderValue> result) { }

	// RVA: 0x108F110 Offset: 0x108E510 VA: 0x18108F110
	private static bool TryParseElement(Lexer lexer, out ProductHeaderValue parsedValue, out Token t) { }

	// RVA: 0x108F0C0 Offset: 0x108E4C0 VA: 0x18108F0C0 Slot: 3
	public override string ToString() { }

}

