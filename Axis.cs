internal class Axis : AstNode // TypeDefIndex: 1789
{
	private Axis.AxisType axisType;
	private AstNode input;
	private string prefix;
	private string name;
	private XPathNodeType nodeType;
	protected bool abbrAxis;
	private string urn;

	public override AstNode.AstType Type { get; }
	public override XPathResultType ReturnType { get; }
	public AstNode Input { get; set; }
	public string Prefix { get; }
	public string Name { get; }
	public XPathNodeType NodeType { get; }
	public Axis.AxisType TypeOfAxis { get; }
	public bool AbbrAxis { get; }
	public string Urn { get; set; }


	public void .ctor(Axis.AxisType axisType, AstNode input, string prefix, string name, XPathNodeType nodetype) { }

	public void .ctor(Axis.AxisType axisType, AstNode input) { }

	public override AstNode.AstType get_Type() { }

	public override XPathResultType get_ReturnType() { }

	public AstNode get_Input() { }

	public void set_Input(AstNode value) { }

	public string get_Prefix() { }

	public string get_Name() { }

	public XPathNodeType get_NodeType() { }

	public Axis.AxisType get_TypeOfAxis() { }

	public bool get_AbbrAxis() { }

	public string get_Urn() { }

	public void set_Urn(string value) { }

}

public enum Axis.AxisType // TypeDefIndex: 1790
{
	public int value__;
	public const Axis.AxisType Ancestor = 0;
	public const Axis.AxisType AncestorOrSelf = 1;
	public const Axis.AxisType Attribute = 2;
	public const Axis.AxisType Child = 3;
	public const Axis.AxisType Descendant = 4;
	public const Axis.AxisType DescendantOrSelf = 5;
	public const Axis.AxisType Following = 6;
	public const Axis.AxisType FollowingSibling = 7;
	public const Axis.AxisType Namespace = 8;
	public const Axis.AxisType Parent = 9;
	public const Axis.AxisType Preceding = 10;
	public const Axis.AxisType PrecedingSibling = 11;
	public const Axis.AxisType Self = 12;
	public const Axis.AxisType None = 13;

}

