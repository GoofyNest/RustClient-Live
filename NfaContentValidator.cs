internal sealed class NfaContentValidator : ContentValidator // TypeDefIndex: 2170
{	// Fields
	private BitSet firstpos; // 0x18
	private BitSet[] followpos; // 0x20
	private SymbolsDictionary symbols; // 0x28
	private Positions positions; // 0x30
	private int endMarkerPos; // 0x38

	// Methods

	// RVA: 0xB0EE60 Offset: 0xB0E260 VA: 0x180B0EE60
	internal void .ctor(BitSet firstpos, BitSet[] followpos, SymbolsDictionary symbols, Positions positions, int endMarkerPos, XmlSchemaContentType contentType, bool isOpen, bool isEmptiable) { }

	// RVA: 0xB0EA90 Offset: 0xB0DE90 VA: 0x180B0EA90 Slot: 5
	public override void InitValidation(ValidationState context) { }

	// RVA: 0xB0EC00 Offset: 0xB0E000 VA: 0x180B0EC00 Slot: 6
	public override object ValidateElement(XmlQualifiedName name, ValidationState context, out int errorCode) { }

	// RVA: 0xB0E640 Offset: 0xB0DA40 VA: 0x180B0E640 Slot: 7
	public override bool CompleteValidation(ValidationState context) { }

	// RVA: 0xB0E6A0 Offset: 0xB0DAA0 VA: 0x180B0E6A0 Slot: 8
	public override ArrayList ExpectedElements(ValidationState context, bool isRequiredOnly) { }

	// RVA: 0xB0E8A0 Offset: 0xB0DCA0 VA: 0x180B0E8A0 Slot: 9
	public override ArrayList ExpectedParticles(ValidationState context, bool isRequiredOnly, XmlSchemaSet schemaSet) { }

}

