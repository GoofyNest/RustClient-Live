internal class AxisStack // TypeDefIndex: 2133
{	private ArrayList stack; // 0x10
	private ForwardAxis subtree; // 0x18
	private ActiveAxis parent; // 0x20

	internal ForwardAxis Subtree { get; }
	internal int Length { get; }


	internal ForwardAxis get_Subtree() { }

	internal int get_Length() { }

	public void .ctor(ForwardAxis faxis, ActiveAxis parent) { }

	internal void Push(int depth) { }

	internal void Pop() { }

	internal static bool Equal(string thisname, string thisURN, string name, string URN) { }

	internal void MoveToParent(string name, string URN, int depth) { }

	internal bool MoveToChild(string name, string URN, int depth) { }

	internal bool MoveToAttribute(string name, string URN, int depth) { }

}

