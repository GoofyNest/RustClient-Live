internal abstract class InteriorNode : SyntaxTreeNode // TypeDefIndex: 2159
{	private SyntaxTreeNode leftChild; // 0x10
	private SyntaxTreeNode rightChild; // 0x18

	public SyntaxTreeNode LeftChild { get; set; }
	public SyntaxTreeNode RightChild { get; set; }


	public SyntaxTreeNode get_LeftChild() { }

	public void set_LeftChild(SyntaxTreeNode value) { }

	public SyntaxTreeNode get_RightChild() { }

	public void set_RightChild(SyntaxTreeNode value) { }

	protected void ExpandTreeNoRecursive(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	public override void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	protected void .ctor() { }

}

