internal class Axis : AstNode // TypeDefIndex: 1789
{	// Fields
	private Axis.AxisType axisType; // 0x10
	private AstNode input; // 0x18
	private string prefix; // 0x20
	private string name; // 0x28
	private XPathNodeType nodeType; // 0x30
	protected bool abbrAxis; // 0x34
	private string urn; // 0x38

	// Properties
	public override AstNode.AstType Type { get; }
	public override XPathResultType ReturnType { get; }
	public AstNode Input { get; set; }
	public string Prefix { get; }
	public string Name { get; }
	public XPathNodeType NodeType { get; }
	public Axis.AxisType TypeOfAxis { get; }
	public bool AbbrAxis { get; }
	public string Urn { get; set; }

	// Methods

	// RVA: 0x12D8010 Offset: 0x12D7410 VA: 0x1812D8010
	public void .ctor(Axis.AxisType axisType, AstNode input, string prefix, string name, XPathNodeType nodetype) { }

	// RVA: 0x12D80C0 Offset: 0x12D74C0 VA: 0x1812D80C0
	public void .ctor(Axis.AxisType axisType, AstNode input) { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 4
	public override AstNode.AstType get_Type() { }

	// RVA: 0xABD0E0 Offset: 0xABC4E0 VA: 0x180ABD0E0 Slot: 5
	public override XPathResultType get_ReturnType() { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public AstNode get_Input() { }

	// RVA: 0x4D0180 Offset: 0x4CF580 VA: 0x1804D0180
	public void set_Input(AstNode value) { }

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	public string get_Prefix() { }

	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230
	public string get_Name() { }

	// RVA: 0xA178C0 Offset: 0xA16CC0 VA: 0x180A178C0
	public XPathNodeType get_NodeType() { }

	// RVA: 0x36A480 Offset: 0x369880 VA: 0x18036A480
	public Axis.AxisType get_TypeOfAxis() { }

	// RVA: 0xB9D210 Offset: 0xB9C610 VA: 0x180B9D210
	public bool get_AbbrAxis() { }

	// RVA: 0x5DCC00 Offset: 0x5DC000 VA: 0x1805DCC00
	public string get_Urn() { }

	// RVA: 0x5089D0 Offset: 0x507DD0 VA: 0x1805089D0
	public void set_Urn(string value) { }

}

public enum Axis.AxisType // TypeDefIndex: 1790
{	// Fields
	public int value__; // 0x0
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

