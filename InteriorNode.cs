internal abstract class InteriorNode : SyntaxTreeNode // TypeDefIndex: 2159
{	// Fields
	private SyntaxTreeNode leftChild; // 0x10
	private SyntaxTreeNode rightChild; // 0x18

	// Properties
	public SyntaxTreeNode LeftChild { get; set; }
	public SyntaxTreeNode RightChild { get; set; }

	// Methods

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public SyntaxTreeNode get_LeftChild() { }

	// RVA: 0x4B94C0 Offset: 0x4B88C0 VA: 0x1804B94C0
	public void set_LeftChild(SyntaxTreeNode value) { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public SyntaxTreeNode get_RightChild() { }

	// RVA: 0x4D0180 Offset: 0x4CF580 VA: 0x1804D0180
	public void set_RightChild(SyntaxTreeNode value) { }

	// RVA: 0xB0BC20 Offset: 0xB0B020 VA: 0x180B0BC20
	protected void ExpandTreeNoRecursive(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	// RVA: 0xB0BDD0 Offset: 0xB0B1D0 VA: 0x180B0BDD0 Slot: 4
	public override void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	// RVA: 0x7992B0 Offset: 0x7986B0 VA: 0x1807992B0
	protected void .ctor() { }

}

