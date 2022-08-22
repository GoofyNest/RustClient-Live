internal class ActiveAxis // TypeDefIndex: 2134
{	private int currentDepth; // 0x10
	private bool isActive; // 0x14
	private Asttree axisTree; // 0x18
	private ArrayList axisStack; // 0x20

	public int CurrentDepth { get; }


	public int get_CurrentDepth() { }

	internal void Reactivate() { }

	internal void .ctor(Asttree axisTree) { }

	public bool MoveToStartElement(string localname, string URN) { }

	public virtual bool EndElement(string localname, string URN) { }

	public bool MoveToAttribute(string localname, string URN) { }

}

