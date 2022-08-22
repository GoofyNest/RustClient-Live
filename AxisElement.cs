internal class AxisElement // TypeDefIndex: 2132
{	internal DoubleLinkAxis curNode; // 0x10
	internal int rootDepth; // 0x18
	internal int curDepth; // 0x1C
	internal bool isMatch; // 0x20

	internal DoubleLinkAxis CurNode { get; }


	internal DoubleLinkAxis get_CurNode() { }

	internal void .ctor(DoubleLinkAxis node, int depth) { }

	internal void SetDepth(int depth) { }

	internal void MoveToParent(int depth, ForwardAxis parent) { }

	internal bool MoveToChild(string name, string URN, int depth, ForwardAxis parent) { }

}

