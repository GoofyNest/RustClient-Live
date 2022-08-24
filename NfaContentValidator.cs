internal sealed class NfaContentValidator : ContentValidator // TypeDefIndex: 2170
{
	private BitSet firstpos; 
	private BitSet[] followpos; 
	private SymbolsDictionary symbols; 
	private Positions positions; 
	private int endMarkerPos; 


	internal void .ctor(BitSet firstpos, BitSet[] followpos, SymbolsDictionary symbols, Positions positions, int endMarkerPos, XmlSchemaContentType contentType, bool isOpen, bool isEmptiable) { }

	public override void InitValidation(ValidationState context) { }

	public override object ValidateElement(XmlQualifiedName name, ValidationState context, out int errorCode) { }

	public override bool CompleteValidation(ValidationState context) { }

	public override ArrayList ExpectedElements(ValidationState context, bool isRequiredOnly) { }

	public override ArrayList ExpectedParticles(ValidationState context, bool isRequiredOnly, XmlSchemaSet schemaSet) { }

}

