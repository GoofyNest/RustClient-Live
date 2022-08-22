internal class Asttree // TypeDefIndex: 2137
{	private ArrayList fAxisArray; // 0x10
	private string xpathexpr; // 0x18
	private bool isField; // 0x20
	private XmlNamespaceManager nsmgr; // 0x28

	internal ArrayList SubtreeArray { get; }


	internal ArrayList get_SubtreeArray() { }

	public void .ctor(string xPath, bool isField, XmlNamespaceManager nsmgr) { }

	private static bool IsNameTest(Axis ast) { }

	internal static bool IsAttribute(Axis ast) { }

	private static bool IsDescendantOrSelf(Axis ast) { }

	internal static bool IsSelf(Axis ast) { }

	public void CompileXPath(string xPath, bool isField, XmlNamespaceManager nsmgr) { }

	private void SetURN(Axis axis, XmlNamespaceManager nsmgr) { }

}

