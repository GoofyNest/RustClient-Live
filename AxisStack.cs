internal class AxisStack // TypeDefIndex: 2133
{	// Fields
	private ArrayList stack; // 0x10
	private ForwardAxis subtree; // 0x18
	private ActiveAxis parent; // 0x20

	// Properties
	internal ForwardAxis Subtree { get; }
	internal int Length { get; }

	// Methods

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	internal ForwardAxis get_Subtree() { }

	// RVA: 0xB147D0 Offset: 0xB13BD0 VA: 0x180B147D0
	internal int get_Length() { }

	// RVA: 0xF3E8F0 Offset: 0xF3DCF0 VA: 0x180F3E8F0
	public void .ctor(ForwardAxis faxis, ActiveAxis parent) { }

	// RVA: 0xF3E840 Offset: 0xF3DC40 VA: 0x180F3E840
	internal void Push(int depth) { }

	// RVA: 0xF3E7F0 Offset: 0xF3DBF0 VA: 0x180F3E7F0
	internal void Pop() { }

	// RVA: 0xF3E050 Offset: 0xF3D450 VA: 0x180F3E050
	internal static bool Equal(string thisname, string thisURN, string name, string URN) { }

	// RVA: 0xF3E4F0 Offset: 0xF3D8F0 VA: 0x180F3E4F0
	internal void MoveToParent(string name, string URN, int depth) { }

	// RVA: 0xF3E2E0 Offset: 0xF3D6E0 VA: 0x180F3E2E0
	internal bool MoveToChild(string name, string URN, int depth) { }

	// RVA: 0xF3E0E0 Offset: 0xF3D4E0 VA: 0x180F3E0E0
	internal bool MoveToAttribute(string name, string URN, int depth) { }

}

