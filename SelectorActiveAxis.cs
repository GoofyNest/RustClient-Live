internal class SelectorActiveAxis : ActiveAxis // TypeDefIndex: 2147
{	// Fields
	private ConstraintStruct cs; // 0x28
	private ArrayList KSs; // 0x30
	private int KSpointer; // 0x38

	// Properties
	public int lastDepth { get; }

	// Methods

	// RVA: 0xEEA0F0 Offset: 0xEE94F0 VA: 0x180EEA0F0
	public int get_lastDepth() { }

	// RVA: 0xEEA060 Offset: 0xEE9460 VA: 0x180EEA060
	public void .ctor(Asttree axisTree, ConstraintStruct cs) { }

	// RVA: 0xEE9AD0 Offset: 0xEE8ED0 VA: 0x180EE9AD0 Slot: 4
	public override bool EndElement(string localname, string URN) { }

	// RVA: 0xEE9CD0 Offset: 0xEE90D0 VA: 0x180EE9CD0
	public int PushKS(int errline, int errcol) { }

	// RVA: 0xEE9BF0 Offset: 0xEE8FF0 VA: 0x180EE9BF0
	public KeySequence PopKS() { }

}

