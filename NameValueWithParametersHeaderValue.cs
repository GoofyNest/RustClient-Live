public class NameValueWithParametersHeaderValue : NameValueHeaderValue, ICloneable // TypeDefIndex: 5788
{	// Fields
	private List<NameValueHeaderValue> parameters; // 0x20

	// Properties
	public ICollection<NameValueHeaderValue> Parameters { get; }

	// Methods

	// RVA: 0x108ECE0 Offset: 0x108E0E0 VA: 0x18108ECE0
	protected void .ctor(NameValueWithParametersHeaderValue source) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	private void .ctor() { }

	// RVA: 0x108EF10 Offset: 0x108E310 VA: 0x18108EF10
	public ICollection<NameValueHeaderValue> get_Parameters() { }

	// RVA: 0x108E810 Offset: 0x108DC10 VA: 0x18108E810 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x108E600 Offset: 0x108DA00 VA: 0x18108E600 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x108E750 Offset: 0x108DB50 VA: 0x18108E750 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x108E870 Offset: 0x108DC70 VA: 0x18108E870 Slot: 3
	public override string ToString() { }

	// RVA: 0x108EC50 Offset: 0x108E050 VA: 0x18108EC50
	internal static bool TryParse(string input, int minimalCount, out List<NameValueWithParametersHeaderValue> result) { }

	// RVA: 0x108E970 Offset: 0x108DD70 VA: 0x18108E970
	private static bool TryParseElement(Lexer lexer, out NameValueWithParametersHeaderValue parsedValue, out Token t) { }

}

