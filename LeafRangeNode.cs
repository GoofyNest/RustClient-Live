internal sealed class LeafRangeNode : LeafNode // TypeDefIndex: 2166
{
	private Decimal min; 
	private Decimal max; 
	private BitSet nextIteration; 

	public Decimal Max { get; }
	public Decimal Min { get; }
	public BitSet NextIteration { get; set; }
	public override bool IsRangeNode { get; }


	public void .ctor(Decimal min, Decimal max) { }

	public void .ctor(int pos, Decimal min, Decimal max) { }

	public Decimal get_Max() { }

	public Decimal get_Min() { }

	public BitSet get_NextIteration() { }

	public void set_NextIteration(BitSet value) { }

	public override bool get_IsRangeNode() { }

	public override void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

}

