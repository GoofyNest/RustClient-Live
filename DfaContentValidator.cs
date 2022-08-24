internal sealed class DfaContentValidator : ContentValidator // TypeDefIndex: 2169
{
	private int[][] transitionTable; 
	private SymbolsDictionary symbols; 


	internal void .ctor(int[][] transitionTable, SymbolsDictionary symbols, XmlSchemaContentType contentType, bool isOpen, bool isEmptiable) { }

	public override void InitValidation(ValidationState context) { }

	public override object ValidateElement(XmlQualifiedName name, ValidationState context, out int errorCode) { }

	public override bool CompleteValidation(ValidationState context) { }

	public override ArrayList ExpectedElements(ValidationState context, bool isRequiredOnly) { }

	public override ArrayList ExpectedParticles(ValidationState context, bool isRequiredOnly, XmlSchemaSet schemaSet) { }

}

