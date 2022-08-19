internal sealed class DfaContentValidator : ContentValidator // TypeDefIndex: 2169
{	// Fields
	private int[][] transitionTable; // 0x18
	private SymbolsDictionary symbols; // 0x20

	// Methods

	// RVA: 0x152F300 Offset: 0x152E700 VA: 0x18152F300
	internal void .ctor(int[][] transitionTable, SymbolsDictionary symbols, XmlSchemaContentType contentType, bool isOpen, bool isEmptiable) { }

	// RVA: 0x152F120 Offset: 0x152E520 VA: 0x18152F120 Slot: 5
	public override void InitValidation(ValidationState context) { }

	// RVA: 0x152F1B0 Offset: 0x152E5B0 VA: 0x18152F1B0 Slot: 6
	public override object ValidateElement(XmlQualifiedName name, ValidationState context, out int errorCode) { }

	// RVA: 0x152ED80 Offset: 0x152E180 VA: 0x18152ED80 Slot: 7
	public override bool CompleteValidation(ValidationState context) { }

	// RVA: 0x152EDA0 Offset: 0x152E1A0 VA: 0x18152EDA0 Slot: 8
	public override ArrayList ExpectedElements(ValidationState context, bool isRequiredOnly) { }

	// RVA: 0x152EF80 Offset: 0x152E380 VA: 0x18152EF80 Slot: 9
	public override ArrayList ExpectedParticles(ValidationState context, bool isRequiredOnly, XmlSchemaSet schemaSet) { }

}

