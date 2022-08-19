public class NameValueHeaderValue : ICloneable // TypeDefIndex: 5787
{	// Fields
	internal string value; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <Name>k__BackingField; // 0x18

	// Properties
	public string Name { get; set; }
	public string Value { get; set; }

	// Methods

	// RVA: 0x108E3B0 Offset: 0x108D7B0 VA: 0x18108E3B0
	public void .ctor(string name, string value) { }

	// RVA: 0x108E410 Offset: 0x108D810 VA: 0x18108E410
	protected internal void .ctor(NameValueHeaderValue source) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	internal void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public string get_Name() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4D0180 Offset: 0x4CF580 VA: 0x1804D0180
	internal void set_Name(string value) { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public string get_Value() { }

	// RVA: 0x108E460 Offset: 0x108D860 VA: 0x18108E460
	public void set_Value(string value) { }

	// RVA: 0x108DB00 Offset: 0x108CF00 VA: 0x18108DB00
	internal static NameValueHeaderValue Create(string name, string value) { }

	// RVA: 0x108DC80 Offset: 0x108D080 VA: 0x18108DC80 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x107F260 Offset: 0x107E660 VA: 0x18107F260 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x108DB90 Offset: 0x108CF90 VA: 0x18108DB90 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x108E320 Offset: 0x108D720 VA: 0x18108E320
	internal static bool TryParsePragma(string input, int minimalCount, out List<NameValueHeaderValue> result) { }

	// RVA: 0x108DFD0 Offset: 0x108D3D0 VA: 0x18108DFD0
	internal static bool TryParseParameters(Lexer lexer, out List<NameValueHeaderValue> result, out Token t) { }

	// RVA: 0x108DD00 Offset: 0x108D100 VA: 0x18108DD00 Slot: 3
	public override string ToString() { }

	// RVA: 0x108DD60 Offset: 0x108D160 VA: 0x18108DD60
	private static bool TryParseElement(Lexer lexer, out NameValueHeaderValue parsedValue, out Token t) { }

}

