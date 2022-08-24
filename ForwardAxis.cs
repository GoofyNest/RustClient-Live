internal class ForwardAxis // TypeDefIndex: 2136
{
	private DoubleLinkAxis topNode; 
	private DoubleLinkAxis rootNode; 
	private bool isAttribute; 
	private bool isDss; 
	private bool isSelfAxis; 

	internal DoubleLinkAxis RootNode { get; }
	internal DoubleLinkAxis TopNode { get; }
	internal bool IsAttribute { get; }
	internal bool IsDss { get; }
	internal bool IsSelfAxis { get; }


	internal DoubleLinkAxis get_RootNode() { }

	internal DoubleLinkAxis get_TopNode() { }

	internal bool get_IsAttribute() { }

	internal bool get_IsDss() { }

	internal bool get_IsSelfAxis() { }

	public void .ctor(DoubleLinkAxis axis, bool isdesorself) { }

}

