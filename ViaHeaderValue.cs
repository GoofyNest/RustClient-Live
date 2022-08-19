public class ViaHeaderValue : ICloneable // TypeDefIndex: 5810
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <Comment>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <ProtocolName>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <ProtocolVersion>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <ReceivedBy>k__BackingField; // 0x28

	// Properties
	public string Comment { get; set; }
	public string ProtocolName { get; set; }
	public string ProtocolVersion { get; set; }
	public string ReceivedBy { get; set; }

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	private void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public string get_Comment() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B94C0 Offset: 0x4B88C0 VA: 0x1804B94C0
	private void set_Comment(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public string get_ProtocolName() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4D0180 Offset: 0x4CF580 VA: 0x1804D0180
	private void set_ProtocolName(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	public string get_ProtocolVersion() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497E30 Offset: 0x497230 VA: 0x180497E30
	private void set_ProtocolVersion(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230
	public string get_ReceivedBy() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7CE240 Offset: 0x7CD640 VA: 0x1807CE240
	private void set_ReceivedBy(string value) { }

	// RVA: 0xD6C080 Offset: 0xD6B480 VA: 0x180D6C080 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x1095F20 Offset: 0x1095320 VA: 0x181095F20 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1096010 Offset: 0x1095410 VA: 0x181096010 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1096740 Offset: 0x1095B40 VA: 0x181096740
	internal static bool TryParse(string input, int minimalCount, out List<ViaHeaderValue> result) { }

	// RVA: 0x1096390 Offset: 0x1095790 VA: 0x181096390
	private static bool TryParseElement(Lexer lexer, out ViaHeaderValue parsedValue, out Token t) { }

	// RVA: 0x1096110 Offset: 0x1095510 VA: 0x181096110 Slot: 3
	public override string ToString() { }

}

