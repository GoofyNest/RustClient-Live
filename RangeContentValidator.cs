internal sealed class RangeContentValidator : ContentValidator // TypeDefIndex: 2172
{	// Fields
	private BitSet firstpos; // 0x18
	private BitSet[] followpos; // 0x20
	private BitSet positionsWithRangeTerminals; // 0x28
	private SymbolsDictionary symbols; // 0x30
	private Positions positions; // 0x38
	private int minMaxNodesCount; // 0x40
	private int endMarkerPos; // 0x44

	// Methods

	// RVA: 0xB23EF0 Offset: 0xB232F0 VA: 0x180B23EF0
	internal void .ctor(BitSet firstpos, BitSet[] followpos, SymbolsDictionary symbols, Positions positions, int endMarkerPos, XmlSchemaContentType contentType, bool isEmptiable, BitSet positionsWithRangeTerminals, int minmaxNodesCount) { }

	// RVA: 0xB23370 Offset: 0xB22770 VA: 0x180B23370 Slot: 5
	public override void InitValidation(ValidationState context) { }

	// RVA: 0xB234D0 Offset: 0xB228D0 VA: 0x180B234D0 Slot: 6
	public override object ValidateElement(XmlQualifiedName name, ValidationState context, out int errorCode) { }

	// RVA: 0xB22E10 Offset: 0xB22210 VA: 0x180B22E10 Slot: 7
	public override bool CompleteValidation(ValidationState context) { }

	// RVA: 0xB22E30 Offset: 0xB22230 VA: 0x180B22E30 Slot: 8
	public override ArrayList ExpectedElements(ValidationState context, bool isRequiredOnly) { }

	// RVA: 0xB230E0 Offset: 0xB224E0 VA: 0x180B230E0 Slot: 9
	public override ArrayList ExpectedParticles(ValidationState context, bool isRequiredOnly, XmlSchemaSet schemaSet) { }

}

