internal class ContentValidator // TypeDefIndex: 2167
{	// Fields
	private XmlSchemaContentType contentType; // 0x10
	private bool isOpen; // 0x14
	private bool isEmptiable; // 0x15
	public static readonly ContentValidator Empty; // 0x0
	public static readonly ContentValidator TextOnly; // 0x8
	public static readonly ContentValidator Mixed; // 0x10
	public static readonly ContentValidator Any; // 0x18

	// Properties
	public XmlSchemaContentType ContentType { get; }
	public bool PreserveWhitespace { get; }
	public virtual bool IsEmptiable { get; }
	public bool IsOpen { get; set; }

	// Methods

	// RVA: 0x151ABE0 Offset: 0x1519FE0 VA: 0x18151ABE0
	public void .ctor(XmlSchemaContentType contentType) { }

	// RVA: 0x151AC10 Offset: 0x151A010 VA: 0x18151AC10
	protected void .ctor(XmlSchemaContentType contentType, bool isOpen, bool isEmptiable) { }

	// RVA: 0x36A480 Offset: 0x369880 VA: 0x18036A480
	public XmlSchemaContentType get_ContentType() { }

	// RVA: 0x151AC70 Offset: 0x151A070 VA: 0x18151AC70
	public bool get_PreserveWhitespace() { }

	// RVA: 0x139FE10 Offset: 0x139F210 VA: 0x18139FE10 Slot: 4
	public virtual bool get_IsEmptiable() { }

	// RVA: 0x151AC60 Offset: 0x151A060 VA: 0x18151AC60
	public bool get_IsOpen() { }

	// RVA: 0x9EFA00 Offset: 0x9EEE00 VA: 0x1809EFA00
	public void set_IsOpen(bool value) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 5
	public virtual void InitValidation(ValidationState context) { }

	// RVA: 0x151AA80 Offset: 0x1519E80 VA: 0x18151AA80 Slot: 6
	public virtual object ValidateElement(XmlQualifiedName name, ValidationState context, out int errorCode) { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 7
	public virtual bool CompleteValidation(ValidationState context) { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 8
	public virtual ArrayList ExpectedElements(ValidationState context, bool isRequiredOnly) { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 9
	public virtual ArrayList ExpectedParticles(ValidationState context, bool isRequiredOnly, XmlSchemaSet schemaSet) { }

	// RVA: 0x151AA00 Offset: 0x1519E00 VA: 0x18151AA00
	public static void AddParticleToExpected(XmlSchemaParticle p, XmlSchemaSet schemaSet, ArrayList particles) { }

	// RVA: 0x151A770 Offset: 0x1519B70 VA: 0x18151A770
	public static void AddParticleToExpected(XmlSchemaParticle p, XmlSchemaSet schemaSet, ArrayList particles, bool global) { }

	// RVA: 0x151AAB0 Offset: 0x1519EB0 VA: 0x18151AAB0
	private static void .cctor() { }

}

