public class TransferCodingHeaderValue : ICloneable // TypeDefIndex: 5808
{	// Fields
	internal string value; // 0x10
	internal List<NameValueHeaderValue> parameters; // 0x18

	// Properties
	public ICollection<NameValueHeaderValue> Parameters { get; }
	public string Value { get; }

	// Methods

	// RVA: 0x10929E0 Offset: 0x1091DE0 VA: 0x1810929E0
	protected void .ctor(TransferCodingHeaderValue source) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	internal void .ctor() { }

	// RVA: 0x1092C40 Offset: 0x1092040 VA: 0x181092C40
	public ICollection<NameValueHeaderValue> get_Parameters() { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public string get_Value() { }

	// RVA: 0x10926C0 Offset: 0x1091AC0 VA: 0x1810926C0 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x1092580 Offset: 0x1091980 VA: 0x181092580 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1092640 Offset: 0x1091A40 VA: 0x181092640 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1092720 Offset: 0x1091B20 VA: 0x181092720 Slot: 3
	public override string ToString() { }

	// RVA: 0x1092950 Offset: 0x1091D50 VA: 0x181092950
	internal static bool TryParse(string input, int minimalCount, out List<TransferCodingHeaderValue> result) { }

	// RVA: 0x1092780 Offset: 0x1091B80 VA: 0x181092780
	private static bool TryParseElement(Lexer lexer, out TransferCodingHeaderValue parsedValue, out Token t) { }

}

