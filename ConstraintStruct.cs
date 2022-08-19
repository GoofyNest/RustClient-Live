internal sealed class ConstraintStruct // TypeDefIndex: 2145
{	// Fields
	internal CompiledIdentityConstraint constraint; // 0x10
	internal SelectorActiveAxis axisSelector; // 0x18
	internal ArrayList axisFields; // 0x20
	internal Hashtable qualifiedTable; // 0x28
	internal Hashtable keyrefTable; // 0x30
	private int tableDim; // 0x38

	// Properties
	internal int TableDim { get; }

	// Methods

	// RVA: 0x516B70 Offset: 0x515F70 VA: 0x180516B70
	internal int get_TableDim() { }

	// RVA: 0x151A650 Offset: 0x1519A50 VA: 0x18151A650
	internal void .ctor(CompiledIdentityConstraint constraint) { }

}

