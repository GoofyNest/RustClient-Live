internal class AxisElement // TypeDefIndex: 2132
{	// Fields
	internal DoubleLinkAxis curNode; // 0x10
	internal int rootDepth; // 0x18
	internal int curDepth; // 0x1C
	internal bool isMatch; // 0x20

	// Properties
	internal DoubleLinkAxis CurNode { get; }

	// Methods

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	internal DoubleLinkAxis get_CurNode() { }

	// RVA: 0xF3E000 Offset: 0xF3D400 VA: 0x180F3E000
	internal void .ctor(DoubleLinkAxis node, int depth) { }

	// RVA: 0xF3DFF0 Offset: 0xF3D3F0 VA: 0x180F3DFF0
	internal void SetDepth(int depth) { }

	// RVA: 0xF3DED0 Offset: 0xF3D2D0 VA: 0x180F3DED0
	internal void MoveToParent(int depth, ForwardAxis parent) { }

	// RVA: 0xF3DD40 Offset: 0xF3D140 VA: 0x180F3DD40
	internal bool MoveToChild(string name, string URN, int depth, ForwardAxis parent) { }

}

