internal sealed class AllElementsContentValidator : ContentValidator // TypeDefIndex: 2173
{	// Fields
	private Hashtable elements; // 0x18
	private object[] particles; // 0x20
	private BitSet isRequired; // 0x28
	private int countRequired; // 0x30

	// Properties
	public override bool IsEmptiable { get; }

	// Methods

	// RVA: 0xF3CBB0 Offset: 0xF3BFB0 VA: 0x180F3CBB0
	public void .ctor(XmlSchemaContentType contentType, int size, bool isEmptiable) { }

	// RVA: 0xF3C050 Offset: 0xF3B450 VA: 0x180F3C050
	public bool AddElement(XmlQualifiedName name, object particle, bool isEmptiable) { }

	// RVA: 0xF3CCF0 Offset: 0xF3C0F0 VA: 0x180F3CCF0 Slot: 4
	public override bool get_IsEmptiable() { }

	// RVA: 0xF3C900 Offset: 0xF3BD00 VA: 0x180F3C900 Slot: 5
	public override void InitValidation(ValidationState context) { }

	// RVA: 0xF3C9E0 Offset: 0xF3BDE0 VA: 0x180F3C9E0 Slot: 6
	public override object ValidateElement(XmlQualifiedName name, ValidationState context, out int errorCode) { }

	// RVA: 0xF3C1C0 Offset: 0xF3B5C0 VA: 0x180F3C1C0 Slot: 7
	public override bool CompleteValidation(ValidationState context) { }

	// RVA: 0xF3C210 Offset: 0xF3B610 VA: 0x180F3C210 Slot: 8
	public override ArrayList ExpectedElements(ValidationState context, bool isRequiredOnly) { }

	// RVA: 0xF3C570 Offset: 0xF3B970 VA: 0x180F3C570 Slot: 9
	public override ArrayList ExpectedParticles(ValidationState context, bool isRequiredOnly, XmlSchemaSet schemaSet) { }

}

