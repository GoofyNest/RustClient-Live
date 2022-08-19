public class AuthenticationHeaderValue : ICloneable // TypeDefIndex: 5758
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <Parameter>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <Scheme>k__BackingField; // 0x18

	// Properties
	public string Parameter { get; set; }
	public string Scheme { get; set; }

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	private void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public string get_Parameter() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B94C0 Offset: 0x4B88C0 VA: 0x1804B94C0
	private void set_Parameter(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public string get_Scheme() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4D0180 Offset: 0x4CF580 VA: 0x1804D0180
	private void set_Scheme(string value) { }

	// RVA: 0xD6C080 Offset: 0xD6B480 VA: 0x180D6C080 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x107F1A0 Offset: 0x107E5A0 VA: 0x18107F1A0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x107F260 Offset: 0x107E660 VA: 0x18107F260 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x107F590 Offset: 0x107E990 VA: 0x18107F590
	public static bool TryParse(string input, out AuthenticationHeaderValue parsedValue) { }

	// RVA: 0x107F500 Offset: 0x107E900 VA: 0x18107F500
	internal static bool TryParse(string input, int minimalCount, out List<AuthenticationHeaderValue> result) { }

	// RVA: 0x107F340 Offset: 0x107E740 VA: 0x18107F340
	private static bool TryParseElement(Lexer lexer, out AuthenticationHeaderValue parsedValue, out Token t) { }

	// RVA: 0x107F2F0 Offset: 0x107E6F0 VA: 0x18107F2F0 Slot: 3
	public override string ToString() { }

}

