internal sealed class ParticleContentValidator : ContentValidator // TypeDefIndex: 2168
{
	private SymbolsDictionary symbols;
	private Positions positions;
	private Stack stack;
	private SyntaxTreeNode contentNode;
	private bool isPartial;
	private int minMaxNodesCount;
	private bool enableUpaCheck;


	public void .ctor(XmlSchemaContentType contentType) { }

	public void .ctor(XmlSchemaContentType contentType, bool enableUpaCheck) { }

	public override void InitValidation(ValidationState context) { }

	public override object ValidateElement(XmlQualifiedName name, ValidationState context, out int errorCode) { }

	public override bool CompleteValidation(ValidationState context) { }

	public void Start() { }

	public void OpenGroup() { }

	public void CloseGroup() { }

	public bool Exists(XmlQualifiedName name) { }

	public void AddName(XmlQualifiedName name, object particle) { }

	public void AddNamespaceList(NamespaceList namespaceList, object particle) { }

	private void AddLeafNode(SyntaxTreeNode node) { }

	public void AddChoice() { }

	public void AddSequence() { }

	public void AddStar() { }

	public void AddPlus() { }

	public void AddQMark() { }

	public void AddLeafRange(Decimal min, Decimal max) { }

	private void Closure(InteriorNode node) { }

	public ContentValidator Finish(bool useDFA) { }

	private BitSet[] CalculateTotalFollowposForRangeNodes(BitSet firstpos, BitSet[] followpos, out BitSet posWithRangeTerminals) { }

	private void CheckCMUPAWithLeafRangeNodes(BitSet curpos) { }

	private BitSet GetApplicableMinMaxFollowPos(BitSet curpos, BitSet posWithRangeTerminals, BitSet[] minmaxFollowPos) { }

	private void CheckUniqueParticleAttribution(BitSet firstpos, BitSet[] followpos) { }

	private void CheckUniqueParticleAttribution(BitSet curpos) { }

	private int[][] BuildTransitionTable(BitSet firstpos, BitSet[] followpos, int endMarkerPos) { }

}

