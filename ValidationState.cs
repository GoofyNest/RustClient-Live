internal sealed class ValidationState // TypeDefIndex: 2290
{
	public bool IsNill;
	public bool IsDefault;
	public bool NeedValidateChildren;
	public bool CheckRequiredAttribute;
	public bool ValidationSkipped;
	public XmlSchemaContentProcessing ProcessContents;
	public XmlSchemaValidity Validity;
	public SchemaElementDecl ElementDecl;
	public SchemaElementDecl ElementDeclBeforeXsi;
	public string LocalName;
	public string Namespace;
	public ConstraintStruct[] Constr;
	public StateUnion CurrentState;
	public bool HasMatched;
	public BitSet[] CurPos;
	public BitSet AllElementsSet;
	public List<RangePositionInfo> RunningPositions;
	public bool TooComplex;


	public void .ctor() { }

}

