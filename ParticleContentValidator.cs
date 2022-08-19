internal sealed class ParticleContentValidator : ContentValidator // TypeDefIndex: 2168
{	// Fields
	private SymbolsDictionary symbols; // 0x18
	private Positions positions; // 0x20
	private Stack stack; // 0x28
	private SyntaxTreeNode contentNode; // 0x30
	private bool isPartial; // 0x38
	private int minMaxNodesCount; // 0x3C
	private bool enableUpaCheck; // 0x40

	// Methods

	// RVA: 0xB14550 Offset: 0xB13950 VA: 0x180B14550
	public void .ctor(XmlSchemaContentType contentType) { }

	// RVA: 0xB144D0 Offset: 0xB138D0 VA: 0x180B144D0
	public void .ctor(XmlSchemaContentType contentType, bool enableUpaCheck) { }

	// RVA: 0xB14300 Offset: 0xB13700 VA: 0x180B14300 Slot: 5
	public override void InitValidation(ValidationState context) { }

	// RVA: 0xB14480 Offset: 0xB13880 VA: 0x180B14480 Slot: 6
	public override object ValidateElement(XmlQualifiedName name, ValidationState context, out int errorCode) { }

	// RVA: 0xB138A0 Offset: 0xB12CA0 VA: 0x180B138A0 Slot: 7
	public override bool CompleteValidation(ValidationState context) { }

	// RVA: 0xB14380 Offset: 0xB13780 VA: 0x180B14380
	public void Start() { }

	// RVA: 0xB14350 Offset: 0xB13750 VA: 0x180B14350
	public void OpenGroup() { }

	// RVA: 0xB13540 Offset: 0xB12940 VA: 0x180B13540
	public void CloseGroup() { }

	// RVA: 0xB138F0 Offset: 0xB12CF0 VA: 0x180B138F0
	public bool Exists(XmlQualifiedName name) { }

	// RVA: 0xB122C0 Offset: 0xB116C0 VA: 0x180B122C0
	public void AddName(XmlQualifiedName name, object particle) { }

	// RVA: 0xB12370 Offset: 0xB11770 VA: 0x180B12370
	public void AddNamespaceList(NamespaceList namespaceList, object particle) { }

	// RVA: 0xB120D0 Offset: 0xB114D0 VA: 0x180B120D0
	private void AddLeafNode(SyntaxTreeNode node) { }

	// RVA: 0xB11FD0 Offset: 0xB113D0 VA: 0x180B11FD0
	public void AddChoice() { }

	// RVA: 0xB124F0 Offset: 0xB118F0 VA: 0x180B124F0
	public void AddSequence() { }

	// RVA: 0xB125F0 Offset: 0xB119F0 VA: 0x180B125F0
	public void AddStar() { }

	// RVA: 0xB12430 Offset: 0xB11830 VA: 0x180B12430
	public void AddPlus() { }

	// RVA: 0xB12490 Offset: 0xB11890 VA: 0x180B12490
	public void AddQMark() { }

	// RVA: 0xB121E0 Offset: 0xB115E0 VA: 0x180B121E0
	public void AddLeafRange(Decimal min, Decimal max) { }

	// RVA: 0xB136E0 Offset: 0xB12AE0 VA: 0x180B136E0
	private void Closure(InteriorNode node) { }

	// RVA: 0xB13920 Offset: 0xB12D20 VA: 0x180B13920
	public ContentValidator Finish(bool useDFA) { }

	// RVA: 0xB12C10 Offset: 0xB12010 VA: 0x180B12C10
	private BitSet[] CalculateTotalFollowposForRangeNodes(BitSet firstpos, BitSet[] followpos, out BitSet posWithRangeTerminals) { }

	// RVA: 0xB12FD0 Offset: 0xB123D0 VA: 0x180B12FD0
	private void CheckCMUPAWithLeafRangeNodes(BitSet curpos) { }

	// RVA: 0xB14100 Offset: 0xB13500 VA: 0x180B14100
	private BitSet GetApplicableMinMaxFollowPos(BitSet curpos, BitSet posWithRangeTerminals, BitSet[] minmaxFollowPos) { }

	// RVA: 0xB13490 Offset: 0xB12890 VA: 0x180B13490
	private void CheckUniqueParticleAttribution(BitSet firstpos, BitSet[] followpos) { }

	// RVA: 0xB131F0 Offset: 0xB125F0 VA: 0x180B131F0
	private void CheckUniqueParticleAttribution(BitSet curpos) { }

	// RVA: 0xB12650 Offset: 0xB11A50 VA: 0x180B12650
	private int[][] BuildTransitionTable(BitSet firstpos, BitSet[] followpos, int endMarkerPos) { }

}

