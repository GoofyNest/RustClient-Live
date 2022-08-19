internal class ActiveAxis // TypeDefIndex: 2134
{	// Fields
	private int currentDepth; // 0x10
	private bool isActive; // 0x14
	private Asttree axisTree; // 0x18
	private ArrayList axisStack; // 0x20

	// Properties
	public int CurrentDepth { get; }

	// Methods

	// RVA: 0x36A480 Offset: 0x369880 VA: 0x18036A480
	public int get_CurrentDepth() { }

	// RVA: 0xF3BE00 Offset: 0xF3B200 VA: 0x180F3BE00
	internal void Reactivate() { }

	// RVA: 0xF3BE10 Offset: 0xF3B210 VA: 0x180F3BE10
	internal void .ctor(Asttree axisTree) { }

	// RVA: 0xF3BC70 Offset: 0xF3B070 VA: 0x180F3BC70
	public bool MoveToStartElement(string localname, string URN) { }

	// RVA: 0xF3B920 Offset: 0xF3AD20 VA: 0x180F3B920 Slot: 4
	public virtual bool EndElement(string localname, string URN) { }

	// RVA: 0xF3BAC0 Offset: 0xF3AEC0 VA: 0x180F3BAC0
	public bool MoveToAttribute(string localname, string URN) { }

}

