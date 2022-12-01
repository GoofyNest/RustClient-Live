internal sealed class RangeContentValidator : ContentValidator // TypeDefIndex: 2172
{
	private BitSet firstpos;
	private BitSet[] followpos;
	private BitSet positionsWithRangeTerminals;
	private SymbolsDictionary symbols;
	private Positions positions;
	private int minMaxNodesCount;
	private int endMarkerPos;


	internal void .ctor(BitSet firstpos, BitSet[] followpos, SymbolsDictionary symbols, Positions positions, int endMarkerPos, XmlSchemaContentType contentType, bool isEmptiable, BitSet positionsWithRangeTerminals, int minmaxNodesCount) { }

	public override void InitValidation(ValidationState context) { }

	public override object ValidateElement(XmlQualifiedName name, ValidationState context, out int errorCode) { }

	public override bool CompleteValidation(ValidationState context) { }

	public override ArrayList ExpectedElements(ValidationState context, bool isRequiredOnly) { }

	public override ArrayList ExpectedParticles(ValidationState context, bool isRequiredOnly, XmlSchemaSet schemaSet) { }

}

