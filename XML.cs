internal class SmallXmlParser // TypeDefIndex: 24
{	// Fields
	private SmallXmlParser.IContentHandler handler; // 0x10
	private TextReader reader; // 0x18
	private Stack elementNames; // 0x20
	private Stack xmlSpaces; // 0x28
	private string xmlSpace; // 0x30
	private StringBuilder buffer; // 0x38
	private char[] nameBuffer; // 0x40
	private bool isWhitespace; // 0x48
	private SmallXmlParser.AttrListImpl attributes; // 0x50
	private int line; // 0x58
	private int column; // 0x5C
	private bool resetColumn; // 0x60

	// Methods

	// RVA: 0x1593FD0 Offset: 0x15933D0 VA: 0x181593FD0
	public void .ctor() { }

	// RVA: 0x1591DF0 Offset: 0x15911F0 VA: 0x181591DF0
	private Exception Error(string msg) { }

	// RVA: 0x1593F10 Offset: 0x1593310 VA: 0x181593F10
	private Exception UnexpectedEndError() { }

	// RVA: 0x15921D0 Offset: 0x15915D0 VA: 0x1815921D0
	private bool IsNameChar(char c, bool start) { }

	// RVA: 0x1592370 Offset: 0x1591770 VA: 0x181592370
	private bool IsWhitespace(int c) { }

	// RVA: 0x1593F00 Offset: 0x1593300 VA: 0x181593F00
	public void SkipWhitespaces() { }

	// RVA: 0x15920C0 Offset: 0x15914C0 VA: 0x1815920C0
	private void HandleWhitespaces() { }

	// RVA: 0x1593E10 Offset: 0x1593210 VA: 0x181593E10
	public void SkipWhitespaces(bool expected) { }

	// RVA: 0x15925F0 Offset: 0x15919F0 VA: 0x1815925F0
	private int Peek() { }

	// RVA: 0x1593DB0 Offset: 0x15931B0 VA: 0x181593DB0
	private int Read() { }

	// RVA: 0x1591ED0 Offset: 0x15912D0 VA: 0x181591ED0
	public void Expect(int c) { }

	// RVA: 0x1593C50 Offset: 0x1593050 VA: 0x181593C50
	private string ReadUntil(char until, bool handleReferences) { }

	// RVA: 0x1593750 Offset: 0x1592B50 VA: 0x181593750
	public string ReadName() { }

	// RVA: 0x1592390 Offset: 0x1591790 VA: 0x181592390
	public void Parse(TextReader input, SmallXmlParser.IContentHandler handler) { }

	// RVA: 0x1591CF0 Offset: 0x15910F0 VA: 0x181591CF0
	private void Cleanup() { }

	// RVA: 0x1592D80 Offset: 0x1592180 VA: 0x181592D80
	public void ReadContent() { }

	// RVA: 0x1591FF0 Offset: 0x15913F0 VA: 0x181591FF0
	private void HandleBufferedContent() { }

	// RVA: 0x1592B00 Offset: 0x1591F00 VA: 0x181592B00
	private void ReadCharacters() { }

	// RVA: 0x1593A30 Offset: 0x1592E30 VA: 0x181593A30
	private void ReadReference() { }

	// RVA: 0x1592950 Offset: 0x1591D50 VA: 0x181592950
	private int ReadCharacterReference() { }

	// RVA: 0x1592620 Offset: 0x1591A20 VA: 0x181592620
	private void ReadAttribute(SmallXmlParser.AttrListImpl a) { }

	// RVA: 0x15927D0 Offset: 0x1591BD0 VA: 0x1815927D0
	private void ReadCDATASection() { }

	// RVA: 0x1592C20 Offset: 0x1592020 VA: 0x181592C20
	private void ReadComment() { }

}

private class SmallXmlParser.AttrListImpl : SmallXmlParser.IAttrList // TypeDefIndex: 27
{	// Fields
	private List<string> attrNames; // 0x10
	private List<string> attrValues; // 0x18

	// Properties
	public int Length { get; }
	public string[] Names { get; }
	public string[] Values { get; }

	// Methods

	// RVA: 0x1588D70 Offset: 0x1588170 VA: 0x181588D70 Slot: 4
	public int get_Length() { }

	// RVA: 0x1588B30 Offset: 0x1587F30 VA: 0x181588B30 Slot: 5
	public string GetName(int i) { }

	// RVA: 0x1588B90 Offset: 0x1587F90 VA: 0x181588B90 Slot: 6
	public string GetValue(int i) { }

	// RVA: 0x1588BF0 Offset: 0x1587FF0 VA: 0x181588BF0 Slot: 7
	public string GetValue(string name) { }

	// RVA: 0x1588DB0 Offset: 0x15881B0 VA: 0x181588DB0 Slot: 8
	public string[] get_Names() { }

	// RVA: 0x1588E00 Offset: 0x1588200 VA: 0x181588E00 Slot: 9
	public string[] get_Values() { }

	// RVA: 0x1588AD0 Offset: 0x1587ED0 VA: 0x181588AD0
	internal void Clear() { }

	// RVA: 0x1588A50 Offset: 0x1587E50 VA: 0x181588A50
	internal void Add(string name, string value) { }

	// RVA: 0x1588CD0 Offset: 0x15880D0 VA: 0x181588CD0
	public void .ctor() { }

}

internal class SmallXmlParserException : SystemException // TypeDefIndex: 28
{	// Fields
	private int line; // 0x88
	private int column; // 0x8C

	// Methods

	// RVA: 0x1591C30 Offset: 0x1591030 VA: 0x181591C30
	public void .ctor(string msg, int line, int column) { }

}

public sealed class XmlSyntaxException : SystemException // TypeDefIndex: 909
{	// Methods

	// RVA: 0x18B6D50 Offset: 0x18B6150 VA: 0x1818B6D50
	public void .ctor() { }

	// RVA: 0x18BE390 Offset: 0x18BD790 VA: 0x1818BE390
	public void .ctor(int lineNumber) { }

	// RVA: 0x18BE210 Offset: 0x18BD610 VA: 0x1818BE210
	public void .ctor(int lineNumber, string message) { }

	// RVA: 0x1481250 Offset: 0x1480650 VA: 0x181481250
	public void .ctor(string message) { }

	// RVA: 0x18B6CC0 Offset: 0x18B60C0 VA: 0x1818B6CC0
	public void .ctor(string message, Exception inner) { }

	// RVA: 0x18AAC90 Offset: 0x18AA090 VA: 0x1818AAC90
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

}

internal class XPathParser // TypeDefIndex: 1800
{	// Fields
	private XPathScanner scanner; // 0x10
	private int parseDepth; // 0x18
	private static readonly XPathResultType[] temparray1; // 0x0
	private static readonly XPathResultType[] temparray2; // 0x8
	private static readonly XPathResultType[] temparray3; // 0x10
	private static readonly XPathResultType[] temparray4; // 0x18
	private static readonly XPathResultType[] temparray5; // 0x20
	private static readonly XPathResultType[] temparray6; // 0x28
	private static readonly XPathResultType[] temparray7; // 0x30
	private static readonly XPathResultType[] temparray8; // 0x38
	private static readonly XPathResultType[] temparray9; // 0x40
	private static Hashtable functionTable; // 0x48
	private static Hashtable AxesTable; // 0x50

	// Methods

	// RVA: 0x6C0000 Offset: 0x6BF400 VA: 0x1806C0000
	private void .ctor(XPathScanner scanner) { }

	// RVA: 0x12F3F10 Offset: 0x12F3310 VA: 0x1812F3F10
	public static AstNode ParseXPathExpresion(string xpathExpresion) { }

	// RVA: 0x12F1DF0 Offset: 0x12F11F0 VA: 0x1812F1DF0
	private AstNode ParseExpresion(AstNode qyInput) { }

	// RVA: 0x12F2F50 Offset: 0x12F2350 VA: 0x1812F2F50
	private AstNode ParseOrExpr(AstNode qyInput) { }

	// RVA: 0x12F1B80 Offset: 0x12F0F80 VA: 0x1812F1B80
	private AstNode ParseAndExpr(AstNode qyInput) { }

	// RVA: 0x12F1CD0 Offset: 0x12F10D0 VA: 0x1812F1CD0
	private AstNode ParseEqualityExpr(AstNode qyInput) { }

	// RVA: 0x12F35C0 Offset: 0x12F29C0 VA: 0x1812F35C0
	private AstNode ParseRelationalExpr(AstNode qyInput) { }

	// RVA: 0x12F1A60 Offset: 0x12F0E60 VA: 0x1812F1A60
	private AstNode ParseAdditiveExpr(AstNode qyInput) { }

	// RVA: 0x12F2AB0 Offset: 0x12F1EB0 VA: 0x1812F2AB0
	private AstNode ParseMultiplicativeExpr(AstNode qyInput) { }

	// RVA: 0x12F3BB0 Offset: 0x12F2FB0 VA: 0x1812F3BB0
	private AstNode ParseUnaryExpr(AstNode qyInput) { }

	// RVA: 0x12F3D00 Offset: 0x12F3100 VA: 0x1812F3D00
	private AstNode ParseUnionExpr(AstNode qyInput) { }

	// RVA: 0x12F18C0 Offset: 0x12F0CC0 VA: 0x1812F18C0
	private static bool IsNodeType(XPathScanner scaner) { }

	// RVA: 0x12F30A0 Offset: 0x12F24A0 VA: 0x1812F30A0
	private AstNode ParsePathExpr(AstNode qyInput) { }

	// RVA: 0x12F1F90 Offset: 0x12F1390 VA: 0x1812F1F90
	private AstNode ParseFilterExpr(AstNode qyInput) { }

	// RVA: 0x12F32F0 Offset: 0x12F26F0 VA: 0x1812F32F0
	private AstNode ParsePredicate(AstNode qyInput) { }

	// RVA: 0x12F21E0 Offset: 0x12F15E0 VA: 0x1812F21E0
	private AstNode ParseLocationPath(AstNode qyInput) { }

	// RVA: 0x12F36F0 Offset: 0x12F2AF0 VA: 0x1812F36F0
	private AstNode ParseRelativeLocationPath(AstNode qyInput) { }

	// RVA: 0x12F1A10 Offset: 0x12F0E10 VA: 0x1812F1A10
	private static bool IsStep(XPathScanner.LexKind lexKind) { }

	// RVA: 0x12F37D0 Offset: 0x12F2BD0 VA: 0x1812F37D0
	private AstNode ParseStep(AstNode qyInput) { }

	// RVA: 0x12F2C60 Offset: 0x12F2060 VA: 0x1812F2C60
	private AstNode ParseNodeTest(AstNode qyInput, Axis.AxisType axisType, XPathNodeType nodeType) { }

	// RVA: 0x12F1970 Offset: 0x12F0D70 VA: 0x1812F1970
	private static bool IsPrimaryExpr(XPathScanner scanner) { }

	// RVA: 0x12F3390 Offset: 0x12F2790 VA: 0x1812F3390
	private AstNode ParsePrimaryExpr(AstNode qyInput) { }

	// RVA: 0x12F2320 Offset: 0x12F1720 VA: 0x1812F2320
	private AstNode ParseMethod(AstNode qyInput) { }

	// RVA: 0x12F0850 Offset: 0x12EFC50 VA: 0x1812F0850
	private void CheckToken(XPathScanner.LexKind t) { }

	// RVA: 0x12F40A0 Offset: 0x12F34A0 VA: 0x1812F40A0
	private void PassToken(XPathScanner.LexKind t) { }

	// RVA: 0x12F1A40 Offset: 0x12F0E40 VA: 0x1812F1A40
	private void NextLex() { }

	// RVA: 0x12F40D0 Offset: 0x12F34D0 VA: 0x1812F40D0
	private bool TestOp(string op) { }

	// RVA: 0x12F07D0 Offset: 0x12EFBD0 VA: 0x1812F07D0
	private void CheckNodeSet(XPathResultType t) { }

	// RVA: 0x12F0C00 Offset: 0x12F0000 VA: 0x1812F0C00
	private static Hashtable CreateFunctionTable() { }

	// RVA: 0x12F08E0 Offset: 0x12EFCE0 VA: 0x1812F08E0
	private static Hashtable CreateAxesTable() { }

	// RVA: 0x12F17C0 Offset: 0x12F0BC0 VA: 0x1812F17C0
	private Axis.AxisType GetAxis(XPathScanner scaner) { }

	// RVA: 0x12F4120 Offset: 0x12F3520 VA: 0x1812F4120
	private static void .cctor() { }

}

private class XPathParser.ParamInfo // TypeDefIndex: 1801
{	// Fields
	private Function.FunctionType ftype; // 0x10
	private int minargs; // 0x14
	private int maxargs; // 0x18
	private XPathResultType[] argTypes; // 0x20

	// Properties
	public Function.FunctionType FType { get; }
	public int Minargs { get; }
	public int Maxargs { get; }
	public XPathResultType[] ArgTypes { get; }

	// Methods

	// RVA: 0x36A480 Offset: 0x369880 VA: 0x18036A480
	public Function.FunctionType get_FType() { }

	// RVA: 0x596230 Offset: 0x595630 VA: 0x180596230
	public int get_Minargs() { }

	// RVA: 0x4BE200 Offset: 0x4BD600 VA: 0x1804BE200
	public int get_Maxargs() { }

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	public XPathResultType[] get_ArgTypes() { }

	// RVA: 0x12EF130 Offset: 0x12EE530 VA: 0x1812EF130
	internal void .ctor(Function.FunctionType ftype, int minargs, int maxargs, XPathResultType[] argTypes) { }

}

internal sealed class XPathScanner // TypeDefIndex: 1802
{	// Fields
	private string xpathExpr; // 0x10
	private int xpathExprIndex; // 0x18
	private XPathScanner.LexKind kind; // 0x1C
	private char currentChar; // 0x20
	private string name; // 0x28
	private string prefix; // 0x30
	private string stringValue; // 0x38
	private double numberValue; // 0x40
	private bool canBeFunction; // 0x48
	private XmlCharType xmlCharType; // 0x50

	// Properties
	public string SourceText { get; }
	private char CurerntChar { get; }
	public XPathScanner.LexKind Kind { get; }
	public string Name { get; }
	public string Prefix { get; }
	public string StringValue { get; }
	public double NumberValue { get; }
	public bool CanBeFunction { get; }

	// Methods

	// RVA: 0x12F4F40 Offset: 0x12F4340 VA: 0x1812F4F40
	public void .ctor(string xpathExpr) { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public string get_SourceText() { }

	// RVA: 0x12F5030 Offset: 0x12F4430 VA: 0x1812F5030
	private char get_CurerntChar() { }

	// RVA: 0x12F4470 Offset: 0x12F3870 VA: 0x1812F4470
	private bool NextChar() { }

	// RVA: 0x4BE1F0 Offset: 0x4BD5F0 VA: 0x1804BE1F0
	public XPathScanner.LexKind get_Kind() { }

	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230
	public string get_Name() { }

	// RVA: 0x4A2EE0 Offset: 0x4A22E0 VA: 0x1804A2EE0
	public string get_Prefix() { }

	// RVA: 0x5DCC00 Offset: 0x5DC000 VA: 0x1805DCC00
	public string get_StringValue() { }

	// RVA: 0x12F5040 Offset: 0x12F4440 VA: 0x1812F5040
	public double get_NumberValue() { }

	// RVA: 0x4B9270 Offset: 0x4B8670 VA: 0x1804B9270
	public bool get_CanBeFunction() { }

	// RVA: 0x12F4EA0 Offset: 0x12F42A0 VA: 0x1812F4EA0
	private void SkipSpace() { }

	// RVA: 0x12F44C0 Offset: 0x12F38C0 VA: 0x1812F44C0
	public bool NextLex() { }

	// RVA: 0x12F4BF0 Offset: 0x12F3FF0 VA: 0x1812F4BF0
	private double ScanNumber() { }

	// RVA: 0x12F4A40 Offset: 0x12F3E40 VA: 0x1812F4A40
	private double ScanFraction() { }

	// RVA: 0x12F4D60 Offset: 0x12F4160 VA: 0x1812F4D60
	private string ScanString() { }

	// RVA: 0x12F4B30 Offset: 0x12F3F30 VA: 0x1812F4B30
	private string ScanName() { }

}

public enum XPathScanner.LexKind // TypeDefIndex: 1803
{	// Fields
	public int value__; // 0x0
	public const XPathScanner.LexKind Comma = 44;
	public const XPathScanner.LexKind Slash = 47;
	public const XPathScanner.LexKind At = 64;
	public const XPathScanner.LexKind Dot = 46;
	public const XPathScanner.LexKind LParens = 40;
	public const XPathScanner.LexKind RParens = 41;
	public const XPathScanner.LexKind LBracket = 91;
	public const XPathScanner.LexKind RBracket = 93;
	public const XPathScanner.LexKind Star = 42;
	public const XPathScanner.LexKind Plus = 43;
	public const XPathScanner.LexKind Minus = 45;
	public const XPathScanner.LexKind Eq = 61;
	public const XPathScanner.LexKind Lt = 60;
	public const XPathScanner.LexKind Gt = 62;
	public const XPathScanner.LexKind Bang = 33;
	public const XPathScanner.LexKind Dollar = 36;
	public const XPathScanner.LexKind Apos = 39;
	public const XPathScanner.LexKind Quote = 34;
	public const XPathScanner.LexKind Union = 124;
	public const XPathScanner.LexKind Ne = 78;
	public const XPathScanner.LexKind Le = 76;
	public const XPathScanner.LexKind Ge = 71;
	public const XPathScanner.LexKind And = 65;
	public const XPathScanner.LexKind Or = 79;
	public const XPathScanner.LexKind DotDot = 68;
	public const XPathScanner.LexKind SlashSlash = 83;
	public const XPathScanner.LexKind Name = 110;
	public const XPathScanner.LexKind String = 115;
	public const XPathScanner.LexKind Number = 100;
	public const XPathScanner.LexKind Axe = 97;
	public const XPathScanner.LexKind Eof = 69;

}

internal sealed class XPathDocumentNavigator : XPathNavigator, IXmlLineInfo // TypeDefIndex: 1804
{	// Fields
	private XPathNode[] pageCurrent; // 0x10
	private XPathNode[] pageParent; // 0x18
	private int idxCurrent; // 0x20
	private int idxParent; // 0x24

	// Properties
	public override string Value { get; }
	public override XPathNodeType NodeType { get; }
	public override string LocalName { get; }
	public override string NamespaceURI { get; }
	public override string Prefix { get; }
	public override XmlNameTable NameTable { get; }
	public override object UnderlyingObject { get; }
	public int LineNumber { get; }
	public int LinePosition { get; }

	// Methods

	// RVA: 0x12EFA30 Offset: 0x12EEE30 VA: 0x1812EFA30
	public void .ctor(XPathNode[] pageCurrent, int idxCurrent, XPathNode[] pageParent, int idxParent) { }

	// RVA: 0x12EFDB0 Offset: 0x12EF1B0 VA: 0x1812EFDB0 Slot: 5
	public override string get_Value() { }

	// RVA: 0x12EF2B0 Offset: 0x12EE6B0 VA: 0x1812EF2B0 Slot: 23
	public override XPathNavigator Clone() { }

	// RVA: 0x12EFD20 Offset: 0x12EF120 VA: 0x1812EFD20 Slot: 24
	public override XPathNodeType get_NodeType() { }

	// RVA: 0x12EFC30 Offset: 0x12EF030 VA: 0x1812EFC30 Slot: 25
	public override string get_LocalName() { }

	// RVA: 0x12EFCD0 Offset: 0x12EF0D0 VA: 0x1812EFCD0 Slot: 26
	public override string get_NamespaceURI() { }

	// RVA: 0x12EFD60 Offset: 0x12EF160 VA: 0x1812EFD60 Slot: 27
	public override string get_Prefix() { }

	// RVA: 0x12EFC80 Offset: 0x12EF080 VA: 0x1812EFC80 Slot: 19
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x12EF480 Offset: 0x12EE880 VA: 0x1812EF480 Slot: 30
	public override bool MoveToFirstNamespace(XPathNamespaceScope namespaceScope) { }

	// RVA: 0x12EF720 Offset: 0x12EEB20 VA: 0x1812EF720 Slot: 31
	public override bool MoveToNextNamespace(XPathNamespaceScope scope) { }

	// RVA: 0x12EF930 Offset: 0x12EED30 VA: 0x1812EF930 Slot: 32
	public override bool MoveToParent() { }

	// RVA: 0x12EF3F0 Offset: 0x12EE7F0 VA: 0x1812EF3F0 Slot: 33
	public override bool IsSamePosition(XPathNavigator other) { }

	// RVA: 0xE4C4C0 Offset: 0xE4B8C0 VA: 0x180E4C4C0 Slot: 28
	public override object get_UnderlyingObject() { }

	// RVA: 0x12EF3A0 Offset: 0x12EE7A0 VA: 0x1812EF3A0 Slot: 35
	public bool HasLineInfo() { }

	// RVA: 0x12EFAD0 Offset: 0x12EEED0 VA: 0x1812EFAD0 Slot: 36
	public int get_LineNumber() { }

	// RVA: 0x12EFB70 Offset: 0x12EEF70 VA: 0x1812EFB70 Slot: 37
	public int get_LinePosition() { }

	// RVA: 0x12EF390 Offset: 0x12EE790 VA: 0x1812EF390
	public int GetPositionHashCode() { }

}

internal struct XPathNode // TypeDefIndex: 1805
{	// Fields
	private XPathNodeInfoAtom info; // 0x0
	private ushort idxSibling; // 0x8
	private ushort idxParent; // 0xA
	private ushort idxSimilar; // 0xC
	private ushort posOffset; // 0xE
	private uint props; // 0x10
	private string value; // 0x18

	// Properties
	public XPathNodeType NodeType { get; }
	public string Prefix { get; }
	public string LocalName { get; }
	public string NamespaceUri { get; }
	public XPathDocument Document { get; }
	public int LineNumber { get; }
	public int LinePosition { get; }
	public int CollapsedLinePosition { get; }
	public XPathNodePageInfo PageInfo { get; }
	public bool IsXmlNamespaceNode { get; }
	public bool HasSibling { get; }
	public bool HasCollapsedText { get; }
	public bool IsText { get; }
	public bool HasNamespaceDecls { get; }
	public string Value { get; }

	// Methods

	// RVA: 0x1E0230 Offset: 0x1DF630 VA: 0x1801E0230
	public XPathNodeType get_NodeType() { }

	// RVA: 0x1E0260 Offset: 0x1DF660 VA: 0x1801E0260
	public string get_Prefix() { }

	// RVA: 0x1E01F0 Offset: 0x1DF5F0 VA: 0x1801E01F0
	public string get_LocalName() { }

	// RVA: 0x1E0210 Offset: 0x1DF610 VA: 0x1801E0210
	public string get_NamespaceUri() { }

	// RVA: 0x1E0080 Offset: 0x1DF480 VA: 0x1801E0080
	public XPathDocument get_Document() { }

	// RVA: 0x1E01A0 Offset: 0x1DF5A0 VA: 0x1801E01A0
	public int get_LineNumber() { }

	// RVA: 0x1E01D0 Offset: 0x1DF5D0 VA: 0x1801E01D0
	public int get_LinePosition() { }

	// RVA: 0x1E0050 Offset: 0x1DF450 VA: 0x1801E0050
	public int get_CollapsedLinePosition() { }

	// RVA: 0x1E0240 Offset: 0x1DF640 VA: 0x1801E0240
	public XPathNodePageInfo get_PageInfo() { }

	// RVA: 0x1DFFD0 Offset: 0x1DF3D0 VA: 0x1801DFFD0
	public int GetParent(out XPathNode[] pageNode) { }

	// RVA: 0x1E0010 Offset: 0x1DF410 VA: 0x1801E0010
	public int GetSibling(out XPathNode[] pageNode) { }

	// RVA: 0x1E0130 Offset: 0x1DF530 VA: 0x1801E0130
	public bool get_IsXmlNamespaceNode() { }

	// RVA: 0x1E00C0 Offset: 0x1DF4C0 VA: 0x1801E00C0
	public bool get_HasSibling() { }

	// RVA: 0x1E00A0 Offset: 0x1DF4A0 VA: 0x1801E00A0
	public bool get_HasCollapsedText() { }

	// RVA: 0x1E00D0 Offset: 0x1DF4D0 VA: 0x1801E00D0
	public bool get_IsText() { }

	// RVA: 0x1E00B0 Offset: 0x1DF4B0 VA: 0x1801E00B0
	public bool get_HasNamespaceDecls() { }

	// RVA: 0xF3DE0 Offset: 0xF31E0 VA: 0x1800F3DE0
	public string get_Value() { }

}

internal struct XPathNodeRef // TypeDefIndex: 1806
{	// Fields
	private XPathNode[] page; // 0x0
	private int idx; // 0x8

	// Properties
	public XPathNode[] Page { get; }
	public int Index { get; }

	// Methods

	// RVA: 0xF9CD0 Offset: 0xF90D0 VA: 0x1800F9CD0
	public void .ctor(XPathNode[] page, int idx) { }

	// RVA: 0xFC6D0 Offset: 0xFBAD0 VA: 0x1800FC6D0
	public XPathNode[] get_Page() { }

	// RVA: 0x122CA0 Offset: 0x1220A0 VA: 0x180122CA0
	public int get_Index() { }

	// RVA: 0x1DFF60 Offset: 0x1DF360 VA: 0x1801DFF60 Slot: 2
	public override int GetHashCode() { }

}

internal abstract class XPathNodeHelper // TypeDefIndex: 1807
{	// Methods

	// RVA: 0x12F0230 Offset: 0x12EF630 VA: 0x1812F0230
	public static int GetLocalNamespaces(XPathNode[] pageElem, int idxElem, out XPathNode[] pageNmsp) { }

	// RVA: 0x12F00F0 Offset: 0x12EF4F0 VA: 0x1812F00F0
	public static int GetInScopeNamespaces(XPathNode[] pageElem, int idxElem, out XPathNode[] pageNmsp) { }

	// RVA: 0x12F0400 Offset: 0x12EF800 VA: 0x1812F0400
	public static bool GetParent(ref XPathNode[] pageNode, ref int idxNode) { }

	// RVA: 0x12F02B0 Offset: 0x12EF6B0 VA: 0x1812F02B0
	public static int GetLocation(XPathNode[] pageNode, int idxNode) { }

	// RVA: 0x12F04A0 Offset: 0x12EF8A0 VA: 0x1812F04A0
	public static bool GetTextFollowing(ref XPathNode[] pageCurrent, ref int idxCurrent, XPathNode[] pageEnd, int idxEnd) { }

	// RVA: 0x12F0300 Offset: 0x12EF700 VA: 0x1812F0300
	public static bool GetNonDescendant(ref XPathNode[] pageNode, ref int idxNode) { }

}

internal sealed class XPathNodePageInfo // TypeDefIndex: 1808
{	// Fields
	private int pageNum; // 0x10
	private int nodeCount; // 0x14
	private XPathNode[] pageNext; // 0x18

	// Properties
	public int PageNumber { get; }
	public int NodeCount { get; }
	public XPathNode[] NextPage { get; }

	// Methods

	// RVA: 0x36A480 Offset: 0x369880 VA: 0x18036A480
	public int get_PageNumber() { }

	// RVA: 0x596230 Offset: 0x595630 VA: 0x180596230
	public int get_NodeCount() { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public XPathNode[] get_NextPage() { }

}

internal sealed class XPathNodeInfoAtom // TypeDefIndex: 1809
{	// Fields
	private string localName; // 0x10
	private string namespaceUri; // 0x18
	private string prefix; // 0x20
	private XPathNode[] pageParent; // 0x28
	private XPathNode[] pageSibling; // 0x30
	private XPathDocument doc; // 0x38
	private int lineNumBase; // 0x40
	private int linePosBase; // 0x44
	private XPathNodePageInfo pageInfo; // 0x48

	// Properties
	public XPathNodePageInfo PageInfo { get; }
	public string LocalName { get; }
	public string NamespaceUri { get; }
	public string Prefix { get; }
	public XPathNode[] SiblingPage { get; }
	public XPathNode[] ParentPage { get; }
	public XPathDocument Document { get; }
	public int LineNumberBase { get; }
	public int LinePositionBase { get; }

	// Methods

	// RVA: 0x5DCCA0 Offset: 0x5DC0A0 VA: 0x1805DCCA0
	public XPathNodePageInfo get_PageInfo() { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public string get_LocalName() { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public string get_NamespaceUri() { }

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	public string get_Prefix() { }

	// RVA: 0x4A2EE0 Offset: 0x4A22E0 VA: 0x1804A2EE0
	public XPathNode[] get_SiblingPage() { }

	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230
	public XPathNode[] get_ParentPage() { }

	// RVA: 0x5DCC00 Offset: 0x5DC000 VA: 0x1805DCC00
	public XPathDocument get_Document() { }

	// RVA: 0x5F7C80 Offset: 0x5F7080 VA: 0x1805F7C80
	public int get_LineNumberBase() { }

	// RVA: 0x5F7C90 Offset: 0x5F7090 VA: 0x1805F7C90
	public int get_LinePositionBase() { }

}

internal class XmlRawWriterBase64Encoder : Base64Encoder // TypeDefIndex: 1814
{	// Fields
	private XmlRawWriter rawWriter; // 0x28

	// Methods

	// RVA: 0xB9C070 Offset: 0xB9B470 VA: 0x180B9C070
	internal void .ctor(XmlRawWriter rawWriter) { }

	// RVA: 0xB9C040 Offset: 0xB9B440 VA: 0x180B9C040 Slot: 4
	internal override void WriteChars(char[] chars, int index, int count) { }

}

internal class XmlTextWriterBase64Encoder : Base64Encoder // TypeDefIndex: 1815
{	// Fields
	private XmlTextEncoder xmlTextEncoder; // 0x28

	// Methods

	// RVA: 0xB9C070 Offset: 0xB9B470 VA: 0x180B9C070
	internal void .ctor(XmlTextEncoder xmlTextEncoder) { }

	// RVA: 0x1314410 Offset: 0x1313810 VA: 0x181314410 Slot: 4
	internal override void WriteChars(char[] chars, int index, int count) { }

}

internal enum BinXmlToken // TypeDefIndex: 1818
{	// Fields
	public int value__; // 0x0
	public const BinXmlToken Error = 0;
	public const BinXmlToken NotImpl = -2;
	public const BinXmlToken EOF = -1;
	public const BinXmlToken XmlDecl = 254;
	public const BinXmlToken Encoding = 253;
	public const BinXmlToken DocType = 252;
	public const BinXmlToken System = 251;
	public const BinXmlToken Public = 250;
	public const BinXmlToken Subset = 249;
	public const BinXmlToken Element = 248;
	public const BinXmlToken EndElem = 247;
	public const BinXmlToken Attr = 246;
	public const BinXmlToken EndAttrs = 245;
	public const BinXmlToken PI = 244;
	public const BinXmlToken Comment = 243;
	public const BinXmlToken CData = 242;
	public const BinXmlToken EndCData = 241;
	public const BinXmlToken Name = 240;
	public const BinXmlToken QName = 239;
	public const BinXmlToken XmlText = 237;
	public const BinXmlToken Nest = 236;
	public const BinXmlToken EndNest = 235;
	public const BinXmlToken Extn = 234;
	public const BinXmlToken NmFlush = 233;
	public const BinXmlToken SQL_BIT = 6;
	public const BinXmlToken SQL_TINYINT = 7;
	public const BinXmlToken SQL_SMALLINT = 1;
	public const BinXmlToken SQL_INT = 2;
	public const BinXmlToken SQL_BIGINT = 8;
	public const BinXmlToken SQL_REAL = 3;
	public const BinXmlToken SQL_FLOAT = 4;
	public const BinXmlToken SQL_MONEY = 5;
	public const BinXmlToken SQL_SMALLMONEY = 20;
	public const BinXmlToken SQL_DATETIME = 18;
	public const BinXmlToken SQL_SMALLDATETIME = 19;
	public const BinXmlToken SQL_DECIMAL = 10;
	public const BinXmlToken SQL_NUMERIC = 11;
	public const BinXmlToken SQL_UUID = 9;
	public const BinXmlToken SQL_VARBINARY = 15;
	public const BinXmlToken SQL_BINARY = 12;
	public const BinXmlToken SQL_IMAGE = 23;
	public const BinXmlToken SQL_CHAR = 13;
	public const BinXmlToken SQL_VARCHAR = 16;
	public const BinXmlToken SQL_TEXT = 22;
	public const BinXmlToken SQL_NVARCHAR = 17;
	public const BinXmlToken SQL_NCHAR = 14;
	public const BinXmlToken SQL_NTEXT = 24;
	public const BinXmlToken SQL_UDT = 27;
	public const BinXmlToken XSD_KATMAI_DATE = 127;
	public const BinXmlToken XSD_KATMAI_DATETIME = 126;
	public const BinXmlToken XSD_KATMAI_TIME = 125;
	public const BinXmlToken XSD_KATMAI_DATEOFFSET = 124;
	public const BinXmlToken XSD_KATMAI_DATETIMEOFFSET = 123;
	public const BinXmlToken XSD_KATMAI_TIMEOFFSET = 122;
	public const BinXmlToken XSD_BOOLEAN = 134;
	public const BinXmlToken XSD_TIME = 129;
	public const BinXmlToken XSD_DATETIME = 130;
	public const BinXmlToken XSD_DATE = 131;
	public const BinXmlToken XSD_BINHEX = 132;
	public const BinXmlToken XSD_BASE64 = 133;
	public const BinXmlToken XSD_DECIMAL = 135;
	public const BinXmlToken XSD_BYTE = 136;
	public const BinXmlToken XSD_UNSIGNEDSHORT = 137;
	public const BinXmlToken XSD_UNSIGNEDINT = 138;
	public const BinXmlToken XSD_UNSIGNEDLONG = 139;
	public const BinXmlToken XSD_QNAME = 140;

}

internal struct BinXmlSqlDecimal // TypeDefIndex: 1819
{	// Fields
	internal byte m_bLen; // 0x0
	internal byte m_bPrec; // 0x1
	internal byte m_bScale; // 0x2
	internal byte m_bSign; // 0x3
	internal uint m_data1; // 0x4
	internal uint m_data2; // 0x8
	internal uint m_data3; // 0xC
	internal uint m_data4; // 0x10
	private static readonly byte NUMERIC_MAX_PRECISION; // 0x0
	private static readonly byte MaxPrecision; // 0x1
	private static readonly byte MaxScale; // 0x2
	private static readonly int x_cNumeMax; // 0x4
	private static readonly long x_lInt32Base; // 0x8
	private static readonly ulong x_ulInt32Base; // 0x10
	private static readonly ulong x_ulInt32BaseForMod; // 0x18
	internal static readonly ulong x_llMax; // 0x20
	private static readonly double DUINT_BASE; // 0x28
	private static readonly double DUINT_BASE2; // 0x30
	private static readonly double DUINT_BASE3; // 0x38
	private static readonly uint[] x_rgulShiftBase; // 0x40
	private static readonly byte[] rgCLenFromPrec; // 0x48

	// Properties
	public bool IsPositive { get; }

	// Methods

	// RVA: 0x1DFE30 Offset: 0x1DF230 VA: 0x1801DFE30
	public bool get_IsPositive() { }

	// RVA: 0x1DFE20 Offset: 0x1DF220 VA: 0x1801DFE20
	public void .ctor(byte[] data, int offset, bool trim) { }

	// RVA: 0x11FD490 Offset: 0x11FC890 VA: 0x1811FD490
	private static uint UIntFromByteArray(byte[] data, int offset) { }

	// RVA: 0x12DBEC0 Offset: 0x12DB2C0 VA: 0x1812DBEC0
	private static void MpDiv1(uint[] rgulU, ref int ciulU, uint iulD, out uint iulR) { }

	// RVA: 0xEB7100 Offset: 0xEB6500 VA: 0x180EB7100
	private static void MpNormalize(uint[] rgulU, ref int ciulU) { }

	// RVA: 0xEB4F50 Offset: 0xEB4350 VA: 0x180EB4F50
	private static char ChFromDigit(uint uiDigit) { }

	// RVA: 0x1DFD40 Offset: 0x1DF140 VA: 0x1801DFD40
	public Decimal ToDecimal() { }

	// RVA: 0x1DFE10 Offset: 0x1DF210 VA: 0x1801DFE10
	private void TrimTrailingZeros() { }

	// RVA: 0x1DFE00 Offset: 0x1DF200 VA: 0x1801DFE00 Slot: 3
	public override string ToString() { }

	// RVA: 0x12DC860 Offset: 0x12DBC60 VA: 0x1812DC860
	private static void .cctor() { }

}

internal struct BinXmlSqlMoney // TypeDefIndex: 1820
{	// Fields
	private long data; // 0x0

	// Methods

	// RVA: 0x1DFF50 Offset: 0x1DF350 VA: 0x1801DFF50
	public void .ctor(int v) { }

	// RVA: 0x1D2D40 Offset: 0x1D2140 VA: 0x1801D2D40
	public void .ctor(long v) { }

	// RVA: 0x1DFE40 Offset: 0x1DF240 VA: 0x1801DFE40
	public Decimal ToDecimal() { }

	// RVA: 0x1DFE90 Offset: 0x1DF290 VA: 0x1801DFE90 Slot: 3
	public override string ToString() { }

}

internal abstract class BinXmlDateTime // TypeDefIndex: 1821
{	// Fields
	internal static int[] KatmaiTimeScaleMultiplicator; // 0x0
	private static readonly double SQLTicksPerMillisecond; // 0x8
	public static readonly int SQLTicksPerSecond; // 0x10
	public static readonly int SQLTicksPerMinute; // 0x14
	public static readonly int SQLTicksPerHour; // 0x18
	private static readonly int SQLTicksPerDay; // 0x1C

	// Methods

	// RVA: 0x12D9E00 Offset: 0x12D9200 VA: 0x1812D9E00
	private static void Write2Dig(StringBuilder sb, int val) { }

	// RVA: 0x12D9F30 Offset: 0x12D9330 VA: 0x1812D9F30
	private static void Write4DigNeg(StringBuilder sb, int val) { }

	// RVA: 0x12D9E70 Offset: 0x12D9270 VA: 0x1812D9E70
	private static void Write3Dec(StringBuilder sb, int val) { }

	// RVA: 0x12DA060 Offset: 0x12D9460 VA: 0x1812DA060
	private static void WriteDate(StringBuilder sb, int yr, int mnth, int day) { }

	// RVA: 0x12DA6E0 Offset: 0x12D9AE0 VA: 0x1812DA6E0
	private static void WriteTime(StringBuilder sb, int hr, int min, int sec, int ms) { }

	// RVA: 0x12DA290 Offset: 0x12D9690 VA: 0x1812DA290
	private static void WriteTimeFullPrecision(StringBuilder sb, int hr, int min, int sec, int fraction) { }

	// RVA: 0x12DA4E0 Offset: 0x12D98E0 VA: 0x1812DA4E0
	private static void WriteTimeZone(StringBuilder sb, TimeSpan zone) { }

	// RVA: 0x12DA5A0 Offset: 0x12D99A0 VA: 0x1812DA5A0
	private static void WriteTimeZone(StringBuilder sb, bool negTimeZone, int hr, int min) { }

	// RVA: 0x12D90D0 Offset: 0x12D84D0 VA: 0x1812D90D0
	private static void BreakDownXsdDateTime(long val, out int yr, out int mnth, out int day, out int hr, out int min, out int sec, out int ms) { }

	// RVA: 0x12D9290 Offset: 0x12D8690 VA: 0x1812D9290
	private static void BreakDownXsdDate(long val, out int yr, out int mnth, out int day, out bool negTimeZone, out int hr, out int min) { }

	// RVA: 0x12D93F0 Offset: 0x12D87F0 VA: 0x1812D93F0
	private static void BreakDownXsdTime(long val, out int hr, out int min, out int sec, out int ms) { }

	// RVA: 0x12DA900 Offset: 0x12D9D00 VA: 0x1812DA900
	public static string XsdDateTimeToString(long val) { }

	// RVA: 0x12DAB80 Offset: 0x12D9F80 VA: 0x1812DAB80
	public static string XsdDateToString(long val) { }

	// RVA: 0x12DBC30 Offset: 0x12DB030 VA: 0x1812DBC30
	public static string XsdTimeToString(long val) { }

	// RVA: 0x12D9BC0 Offset: 0x12D8FC0 VA: 0x1812D9BC0
	public static string SqlDateTimeToString(int dateticks, uint timeticks) { }

	// RVA: 0x12D9B00 Offset: 0x12D8F00 VA: 0x1812D9B00
	public static DateTime SqlDateTimeToDateTime(int dateticks, uint timeticks) { }

	// RVA: 0x12D9D00 Offset: 0x12D9100 VA: 0x1812D9D00
	public static string SqlSmallDateTimeToString(short dateticks, ushort timeticks) { }

	// RVA: 0x12D9C80 Offset: 0x12D9080 VA: 0x1812D9C80
	public static DateTime SqlSmallDateTimeToDateTime(short dateticks, ushort timeticks) { }

	// RVA: 0x12DB5B0 Offset: 0x12DA9B0 VA: 0x1812DB5B0
	public static DateTime XsdKatmaiDateToDateTime(byte[] data, int offset) { }

	// RVA: 0x12DB340 Offset: 0x12DA740 VA: 0x1812DB340
	public static DateTime XsdKatmaiDateTimeToDateTime(byte[] data, int offset) { }

	// RVA: 0x12DBA80 Offset: 0x12DAE80 VA: 0x1812DBA80
	public static DateTime XsdKatmaiTimeToDateTime(byte[] data, int offset) { }

	// RVA: 0x12DAE60 Offset: 0x12DA260 VA: 0x1812DAE60
	public static DateTimeOffset XsdKatmaiDateOffsetToDateTimeOffset(byte[] data, int offset) { }

	// RVA: 0x12DB030 Offset: 0x12DA430 VA: 0x1812DB030
	public static DateTimeOffset XsdKatmaiDateTimeOffsetToDateTimeOffset(byte[] data, int offset) { }

	// RVA: 0x12DB880 Offset: 0x12DAC80 VA: 0x1812DB880
	public static DateTimeOffset XsdKatmaiTimeOffsetToDateTimeOffset(byte[] data, int offset) { }

	// RVA: 0x12DB6B0 Offset: 0x12DAAB0 VA: 0x1812DB6B0
	public static string XsdKatmaiDateToString(byte[] data, int offset) { }

	// RVA: 0x12DB450 Offset: 0x12DA850 VA: 0x1812DB450
	public static string XsdKatmaiDateTimeToString(byte[] data, int offset) { }

	// RVA: 0x12DBAE0 Offset: 0x12DAEE0 VA: 0x1812DBAE0
	public static string XsdKatmaiTimeToString(byte[] data, int offset) { }

	// RVA: 0x12DAEE0 Offset: 0x12DA2E0 VA: 0x1812DAEE0
	public static string XsdKatmaiDateOffsetToString(byte[] data, int offset) { }

	// RVA: 0x12DB1B0 Offset: 0x12DA5B0 VA: 0x1812DB1B0
	public static string XsdKatmaiDateTimeOffsetToString(byte[] data, int offset) { }

	// RVA: 0x12DB900 Offset: 0x12DAD00 VA: 0x1812DB900
	public static string XsdKatmaiTimeOffsetToString(byte[] data, int offset) { }

	// RVA: 0x12D96D0 Offset: 0x12D8AD0 VA: 0x1812D96D0
	private static long GetKatmaiDateTicks(byte[] data, ref int pos) { }

	// RVA: 0x12D9770 Offset: 0x12D8B70 VA: 0x1812D9770
	private static long GetKatmaiTimeTicks(byte[] data, ref int pos) { }

	// RVA: 0x12D9A90 Offset: 0x12D8E90 VA: 0x1812D9A90
	private static long GetKatmaiTimeZoneTicks(byte[] data, int pos) { }

	// RVA: 0x12D95F0 Offset: 0x12D89F0 VA: 0x1812D95F0
	private static int GetFractions(DateTime dt) { }

	// RVA: 0x12D9510 Offset: 0x12D8910 VA: 0x1812D9510
	private static int GetFractions(DateTimeOffset dt) { }

	// RVA: 0x12DBDE0 Offset: 0x12DB1E0 VA: 0x1812DBDE0
	private static void .cctor() { }

}

internal sealed class XmlSqlBinaryReader : XmlReader, IXmlNamespaceResolver // TypeDefIndex: 1822
{	// Fields
	internal static readonly Type TypeOfObject; // 0x0
	internal static readonly Type TypeOfString; // 0x8
	private static Type[] TokenTypeMap; // 0x10
	private static byte[] XsdKatmaiTimeScaleToValueLengthMap; // 0x18
	private static ReadState[] ScanState2ReadState; // 0x20
	private Stream inStrm; // 0x10
	private byte[] data; // 0x18
	private int pos; // 0x20
	private int mark; // 0x24
	private int end; // 0x28
	private long offset; // 0x30
	private bool eof; // 0x38
	private bool sniffed; // 0x39
	private bool isEmpty; // 0x3A
	private int docState; // 0x3C
	private XmlSqlBinaryReader.SymbolTables symbolTables; // 0x40
	private XmlNameTable xnt; // 0x60
	private bool xntFromSettings; // 0x68
	private string xml; // 0x70
	private string xmlns; // 0x78
	private string nsxmlns; // 0x80
	private string baseUri; // 0x88
	private XmlSqlBinaryReader.ScanState state; // 0x90
	private XmlNodeType nodetype; // 0x94
	private BinXmlToken token; // 0x98
	private int attrIndex; // 0x9C
	private XmlSqlBinaryReader.QName qnameOther; // 0xA0
	private XmlSqlBinaryReader.QName qnameElement; // 0xB8
	private XmlNodeType parentNodeType; // 0xD0
	private XmlSqlBinaryReader.ElemInfo[] elementStack; // 0xD8
	private int elemDepth; // 0xE0
	private XmlSqlBinaryReader.AttrInfo[] attributes; // 0xE8
	private int[] attrHashTbl; // 0xF0
	private int attrCount; // 0xF8
	private int posAfterAttrs; // 0xFC
	private bool xmlspacePreserve; // 0x100
	private int tokLen; // 0x104
	private int tokDataPos; // 0x108
	private bool hasTypedValue; // 0x10C
	private Type valueType; // 0x110
	private string stringValue; // 0x118
	private Dictionary<string, XmlSqlBinaryReader.NamespaceDecl> namespaces; // 0x120
	private XmlSqlBinaryReader.NestedBinXml prevNameInfo; // 0x128
	private XmlReader textXmlReader; // 0x130
	private bool closeInput; // 0x138
	private bool checkCharacters; // 0x139
	private bool ignoreWhitespace; // 0x13A
	private bool ignorePIs; // 0x13B
	private bool ignoreComments; // 0x13C
	private DtdProcessing dtdProcessing; // 0x140
	private SecureStringHasher hasher; // 0x148
	private XmlCharType xmlCharType; // 0x150
	private Encoding unicode; // 0x158
	private byte version; // 0x160

	// Properties
	public override XmlReaderSettings Settings { get; }
	public override XmlNodeType NodeType { get; }
	public override string LocalName { get; }
	public override string NamespaceURI { get; }
	public override string Prefix { get; }
	public override string Value { get; }
	public override int Depth { get; }
	public override string BaseURI { get; }
	public override bool IsEmptyElement { get; }
	public override XmlSpace XmlSpace { get; }
	public override string XmlLang { get; }
	public override Type ValueType { get; }
	public override int AttributeCount { get; }
	public override bool EOF { get; }
	public override XmlNameTable NameTable { get; }
	public override ReadState ReadState { get; }

	// Methods

	// RVA: 0xBAB3D0 Offset: 0xBAA7D0 VA: 0x180BAB3D0
	public void .ctor(Stream stream, byte[] data, int len, string baseUri, bool closeInput, XmlReaderSettings settings) { }

	// RVA: 0xBABB70 Offset: 0xBAAF70 VA: 0x180BABB70 Slot: 5
	public override XmlReaderSettings get_Settings() { }

	// RVA: 0xBABAD0 Offset: 0xBAAED0 VA: 0x180BABAD0 Slot: 6
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x9321E0 Offset: 0x9315E0 VA: 0x1809321E0 Slot: 8
	public override string get_LocalName() { }

	// RVA: 0x972280 Offset: 0x971680 VA: 0x180972280 Slot: 9
	public override string get_NamespaceURI() { }

	// RVA: 0x58DBC0 Offset: 0x58CFC0 VA: 0x18058DBC0 Slot: 10
	public override string get_Prefix() { }

	// RVA: 0xBABE00 Offset: 0xBAB200 VA: 0x180BABE00 Slot: 11
	public override string get_Value() { }

	// RVA: 0xBAB9D0 Offset: 0xBAADD0 VA: 0x180BAB9D0 Slot: 12
	public override int get_Depth() { }

	// RVA: 0x58DBD0 Offset: 0x58CFD0 VA: 0x18058DBD0 Slot: 13
	public override string get_BaseURI() { }

	// RVA: 0xBABAB0 Offset: 0xBAAEB0 VA: 0x180BABAB0 Slot: 14
	public override bool get_IsEmptyElement() { }

	// RVA: 0xBAC1D0 Offset: 0xBAB5D0 VA: 0x180BAC1D0 Slot: 17
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0xBAC120 Offset: 0xBAB520 VA: 0x180BAC120 Slot: 18
	public override string get_XmlLang() { }

	// RVA: 0x94E420 Offset: 0x94D820 VA: 0x18094E420 Slot: 20
	public override Type get_ValueType() { }

	// RVA: 0xBAB970 Offset: 0xBAAD70 VA: 0x180BAB970 Slot: 21
	public override int get_AttributeCount() { }

	// RVA: 0xBA2ED0 Offset: 0xBA22D0 VA: 0x180BA2ED0 Slot: 23
	public override string GetAttribute(string name, string ns) { }

	// RVA: 0xBA2DA0 Offset: 0xBA21A0 VA: 0x180BA2DA0 Slot: 22
	public override string GetAttribute(string name) { }

	// RVA: 0xBA2E10 Offset: 0xBA2210 VA: 0x180BA2E10 Slot: 24
	public override string GetAttribute(int i) { }

	// RVA: 0xBA52D0 Offset: 0xBA46D0 VA: 0x180BA52D0 Slot: 25
	public override bool MoveToAttribute(string name) { }

	// RVA: 0xBA5360 Offset: 0xBA4760 VA: 0x180BA5360 Slot: 26
	public override void MoveToAttribute(int i) { }

	// RVA: 0xBA5540 Offset: 0xBA4940 VA: 0x180BA5540 Slot: 27
	public override bool MoveToFirstAttribute() { }

	// RVA: 0xBA55C0 Offset: 0xBA49C0 VA: 0x180BA55C0 Slot: 28
	public override bool MoveToNextAttribute() { }

	// RVA: 0xBA5430 Offset: 0xBA4830 VA: 0x180BA5430 Slot: 29
	public override bool MoveToElement() { }

	// RVA: 0xBABAA0 Offset: 0xBAAEA0 VA: 0x180BABAA0 Slot: 32
	public override bool get_EOF() { }

	// RVA: 0xBA65F0 Offset: 0xBA59F0 VA: 0x180BA65F0 Slot: 30
	public override bool ReadAttributeValue() { }

	// RVA: 0xBA12B0 Offset: 0xBA06B0 VA: 0x180BA12B0 Slot: 33
	public override void Close() { }

	// RVA: 0x54FB60 Offset: 0x54EF60 VA: 0x18054FB60 Slot: 36
	public override XmlNameTable get_NameTable() { }

	// RVA: 0xBA5210 Offset: 0xBA4610 VA: 0x180BA5210 Slot: 37
	public override string LookupNamespace(string prefix) { }

	// RVA: 0xBA7F20 Offset: 0xBA7320 VA: 0x180BA7F20 Slot: 39
	public override void ResolveEntity() { }

	// RVA: 0xBABAE0 Offset: 0xBAAEE0 VA: 0x180BABAE0 Slot: 34
	public override ReadState get_ReadState() { }

	// RVA: 0xBA7A60 Offset: 0xBA6E60 VA: 0x180BA7A60 Slot: 31
	public override bool Read() { }

	// RVA: 0xBA9090 Offset: 0xBA8490 VA: 0x180BA9090 Slot: 53
	private IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0xBA93E0 Offset: 0xBA87E0 VA: 0x180BA93E0 Slot: 55
	private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

	// RVA: 0xBAAFF0 Offset: 0xBAA3F0 VA: 0x180BAAFF0
	private void VerifyVersion(int requiredVersion, BinXmlToken token) { }

	// RVA: 0xBA07E0 Offset: 0xB9FBE0 VA: 0x180BA07E0
	private void AddInitNamespace(string prefix, string uri) { }

	// RVA: 0xBA0920 Offset: 0xB9FD20 VA: 0x180BA0920
	private void AddName() { }

	// RVA: 0xBA0A80 Offset: 0xB9FE80 VA: 0x180BA0A80
	private void AddQName() { }

	// RVA: 0xBA5660 Offset: 0xBA4A60 VA: 0x180BA5660
	private void NameFlush() { }

	// RVA: 0xBA8F60 Offset: 0xBA8360 VA: 0x180BA8F60
	private void SkipExtn() { }

	// RVA: 0xBA7880 Offset: 0xBA6C80 VA: 0x180BA7880
	private int ReadQNameRef() { }

	// RVA: 0xBA77A0 Offset: 0xBA6BA0 VA: 0x180BA77A0
	private int ReadNameRef() { }

	// RVA: 0xBA1360 Offset: 0xBA0760 VA: 0x180BA1360
	private bool FillAllowEOF() { }

	// RVA: 0xBA15A0 Offset: 0xBA09A0 VA: 0x180BA15A0
	private void Fill_(int require) { }

	// RVA: 0xBA1620 Offset: 0xBA0A20 VA: 0x180BA1620
	private void Fill(int require) { }

	// RVA: 0xBA67C0 Offset: 0xBA5BC0 VA: 0x180BA67C0
	private byte ReadByte() { }

	// RVA: 0xBA79E0 Offset: 0xBA6DE0 VA: 0x180BA79E0
	private ushort ReadUShort() { }

	// RVA: 0xBA5E00 Offset: 0xBA5200 VA: 0x180BA5E00
	private int ParseMB32() { }

	// RVA: 0xBA5C50 Offset: 0xBA5050 VA: 0x180BA5C50
	private int ParseMB32_(byte b) { }

	// RVA: 0xBA5E70 Offset: 0xBA5270 VA: 0x180BA5E70
	private int ParseMB32(int pos) { }

	// RVA: 0xBA5E00 Offset: 0xBA5200 VA: 0x180BA5E00
	private int ParseMB64() { }

	// RVA: 0xBA60C0 Offset: 0xBA54C0 VA: 0x180BA60C0
	private BinXmlToken PeekToken() { }

	// RVA: 0xBA7960 Offset: 0xBA6D60 VA: 0x180BA7960
	private BinXmlToken ReadToken() { }

	// RVA: 0xBA5790 Offset: 0xBA4B90 VA: 0x180BA5790
	private BinXmlToken NextToken2(BinXmlToken token) { }

	// RVA: 0xBA56C0 Offset: 0xBA4AC0 VA: 0x180BA56C0
	private BinXmlToken NextToken1() { }

	// RVA: 0xBA5B40 Offset: 0xBA4F40 VA: 0x180BA5B40
	private BinXmlToken NextToken() { }

	// RVA: 0xBA60A0 Offset: 0xBA54A0 VA: 0x180BA60A0
	private BinXmlToken PeekNextToken() { }

	// RVA: 0xBA7BE0 Offset: 0xBA6FE0 VA: 0x180BA7BE0
	private BinXmlToken RescanNextToken() { }

	// RVA: 0xBA5FD0 Offset: 0xBA53D0 VA: 0x180BA5FD0
	private string ParseText() { }

	// RVA: 0xBA8C50 Offset: 0xBA8050 VA: 0x180BA8C50
	private int ScanText(out int start) { }

	// RVA: 0xBA3580 Offset: 0xBA2980 VA: 0x180BA3580
	private string GetString(int pos, int cch) { }

	// RVA: 0xBA3550 Offset: 0xBA2950 VA: 0x180BA3550
	private string GetStringAligned(byte[] data, int offset, int cch) { }

	// RVA: 0xBA2C00 Offset: 0xBA2000 VA: 0x180BA2C00
	private string GetAttributeText(int i) { }

	// RVA: 0xBA5050 Offset: 0xBA4450 VA: 0x180BA5050
	private int LocateAttribute(string name, string ns) { }

	// RVA: 0xBA5110 Offset: 0xBA4510 VA: 0x180BA5110
	private int LocateAttribute(string name) { }

	// RVA: 0xBA6210 Offset: 0xBA5610 VA: 0x180BA6210
	private void PositionOnAttribute(int i) { }

	// RVA: 0xBA3A40 Offset: 0xBA2E40 VA: 0x180BA3A40
	private void GrowElements() { }

	// RVA: 0xBA39A0 Offset: 0xBA2DA0 VA: 0x180BA39A0
	private void GrowAttributes() { }

	// RVA: 0xBA1290 Offset: 0xBA0690 VA: 0x180BA1290
	private void ClearAttributes() { }

	// RVA: 0xBA6340 Offset: 0xBA5740 VA: 0x180BA6340
	private void PushNamespace(string prefix, string ns, bool implied) { }

	// RVA: 0xBA6130 Offset: 0xBA5530 VA: 0x180BA6130
	private void PopNamespaces(XmlSqlBinaryReader.NamespaceDecl firstInScopeChain) { }

	// RVA: 0xBA18D0 Offset: 0xBA0CD0 VA: 0x180BA18D0
	private void GenerateImpliedXmlnsAttrs() { }

	// RVA: 0xBA7190 Offset: 0xBA6590 VA: 0x180BA7190
	private bool ReadInit(bool skipXmlDecl) { }

	// RVA: 0xBA7F70 Offset: 0xBA7370 VA: 0x180BA7F70
	private void ScanAttributes() { }

	// RVA: 0xBA8D90 Offset: 0xBA8190 VA: 0x180BA8D90
	private void SimpleCheckForDuplicateAttributes() { }

	// RVA: 0xBA3AE0 Offset: 0xBA2EE0 VA: 0x180BA3AE0
	private void HashCheckForDuplicateAttributes() { }

	// RVA: 0xBAB060 Offset: 0xBAA460 VA: 0x180BAB060
	private string XmlDeclValue() { }

	// RVA: 0xBA0D50 Offset: 0xBA0150 VA: 0x180BA0D50
	private string CDATAValue() { }

	// RVA: 0xBA16C0 Offset: 0xBA0AC0 VA: 0x180BA16C0
	private void FinishCDATA() { }

	// RVA: 0xBA17B0 Offset: 0xBA0BB0 VA: 0x180BA17B0
	private void FinishEndElement() { }

	// RVA: 0xBA6810 Offset: 0xBA5C10 VA: 0x180BA6810
	private bool ReadDoc() { }

	// RVA: 0xBA3F00 Offset: 0xBA3300 VA: 0x180BA3F00
	private void ImplReadData(BinXmlToken tokenType) { }

	// RVA: 0xBA4440 Offset: 0xBA3840 VA: 0x180BA4440
	private void ImplReadElement() { }

	// RVA: 0xBA47F0 Offset: 0xBA3BF0 VA: 0x180BA47F0
	private void ImplReadEndElement() { }

	// RVA: 0xBA4090 Offset: 0xBA3490 VA: 0x180BA4090
	private void ImplReadDoctype() { }

	// RVA: 0xBA4AD0 Offset: 0xBA3ED0 VA: 0x180BA4AD0
	private void ImplReadPI() { }

	// RVA: 0xBA3EC0 Offset: 0xBA32C0 VA: 0x180BA3EC0
	private void ImplReadComment() { }

	// RVA: 0xBA3E30 Offset: 0xBA3230 VA: 0x180BA3E30
	private void ImplReadCDATA() { }

	// RVA: 0xBA4970 Offset: 0xBA3D70 VA: 0x180BA4970
	private void ImplReadNest() { }

	// RVA: 0xBA4900 Offset: 0xBA3D00 VA: 0x180BA4900
	private void ImplReadEndNest() { }

	// RVA: 0xBA4B60 Offset: 0xBA3F60 VA: 0x180BA4B60
	private void ImplReadXmlText() { }

	// RVA: 0xBA9830 Offset: 0xBA8C30 VA: 0x180BA9830
	private void UpdateFromTextReader() { }

	// RVA: 0xBA9810 Offset: 0xBA8C10 VA: 0x180BA9810
	private bool UpdateFromTextReader(bool needUpdate) { }

	// RVA: 0xBA0EB0 Offset: 0xBA02B0 VA: 0x180BA0EB0
	private void CheckAllowContent() { }

	// RVA: 0xBA1AE0 Offset: 0xBA0EE0 VA: 0x180BA1AE0
	private void GenerateTokenTypeMap() { }

	// RVA: 0xBA3700 Offset: 0xBA2B00 VA: 0x180BA3700
	private Type GetValueType(BinXmlToken token) { }

	// RVA: 0xBA65D0 Offset: 0xBA59D0 VA: 0x180BA65D0
	private void ReScanOverValue(BinXmlToken token) { }

	// RVA: 0xBA8A30 Offset: 0xBA7E30 VA: 0x180BA8A30
	private XmlNodeType ScanOverValue(BinXmlToken token, bool attr, bool checkChars) { }

	// RVA: 0xBA8500 Offset: 0xBA7900 VA: 0x180BA8500
	private XmlNodeType ScanOverAnyValue(BinXmlToken token, bool attr, bool checkChars) { }

	// RVA: 0xBA0FD0 Offset: 0xBA03D0 VA: 0x180BA0FD0
	private XmlNodeType CheckText(bool attr) { }

	// RVA: 0xBA0F20 Offset: 0xBA0320 VA: 0x180BA0F20
	private XmlNodeType CheckTextIsWS() { }

	// RVA: 0xBA1230 Offset: 0xBA0630 VA: 0x180BA1230
	private void CheckValueTokenBounds() { }

	// RVA: 0xBA37F0 Offset: 0xBA2BF0 VA: 0x180BA37F0
	private int GetXsdKatmaiTokenLength(BinXmlToken token) { }

	// RVA: 0xBAB1C0 Offset: 0xBAA5C0 VA: 0x180BAB1C0
	private int XsdKatmaiTimeScaleToValueLength(byte scale) { }

	// RVA: 0xBAA240 Offset: 0xBA9640 VA: 0x180BAA240
	private long ValueAsLong() { }

	// RVA: 0xBAAF40 Offset: 0xBAA340 VA: 0x180BAAF40
	private ulong ValueAsULong() { }

	// RVA: 0xBA9D90 Offset: 0xBA9190 VA: 0x180BA9D90
	private Decimal ValueAsDecimal() { }

	// RVA: 0xBAA040 Offset: 0xBA9440 VA: 0x180BAA040
	private double ValueAsDouble() { }

	// RVA: 0xBA9930 Offset: 0xBA8D30 VA: 0x180BA9930
	private string ValueAsDateTimeString() { }

	// RVA: 0xBAA770 Offset: 0xBA9B70 VA: 0x180BAA770
	private string ValueAsString(BinXmlToken token) { }

	// RVA: 0xBA31F0 Offset: 0xBA25F0 VA: 0x180BA31F0
	private short GetInt16(int pos) { }

	// RVA: 0xBA31F0 Offset: 0xBA25F0 VA: 0x180BA31F0
	private ushort GetUInt16(int pos) { }

	// RVA: 0xBA3250 Offset: 0xBA2650 VA: 0x180BA3250
	private int GetInt32(int pos) { }

	// RVA: 0xBA3250 Offset: 0xBA2650 VA: 0x180BA3250
	private uint GetUInt32(int pos) { }

	// RVA: 0xBA3300 Offset: 0xBA2700 VA: 0x180BA3300
	private long GetInt64(int pos) { }

	// RVA: 0xBA3300 Offset: 0xBA2700 VA: 0x180BA3300
	private ulong GetUInt64(int pos) { }

	// RVA: 0xBA34A0 Offset: 0xBA28A0 VA: 0x180BA34A0
	private float GetSingle(int offset) { }

	// RVA: 0xBA3050 Offset: 0xBA2450 VA: 0x180BA3050
	private double GetDouble(int offset) { }

	// RVA: 0xBA95C0 Offset: 0xBA89C0 VA: 0x180BA95C0
	private Exception ThrowUnexpectedToken(BinXmlToken token) { }

	// RVA: 0xBA97A0 Offset: 0xBA8BA0 VA: 0x180BA97A0
	private Exception ThrowXmlException(string res) { }

	// RVA: 0xBA9650 Offset: 0xBA8A50 VA: 0x180BA9650
	private Exception ThrowXmlException(string res, string arg1, string arg2) { }

	// RVA: 0xBA9550 Offset: 0xBA8950 VA: 0x180BA9550
	private Exception ThrowNotSupported(string res) { }

	// RVA: 0xBAB280 Offset: 0xBAA680 VA: 0x180BAB280
	private static void .cctor() { }

}

private enum XmlSqlBinaryReader.ScanState // TypeDefIndex: 1823
{	// Fields
	public int value__; // 0x0
	public const XmlSqlBinaryReader.ScanState Doc = 0;
	public const XmlSqlBinaryReader.ScanState XmlText = 1;
	public const XmlSqlBinaryReader.ScanState Attr = 2;
	public const XmlSqlBinaryReader.ScanState AttrVal = 3;
	public const XmlSqlBinaryReader.ScanState AttrValPseudoValue = 4;
	public const XmlSqlBinaryReader.ScanState Init = 5;
	public const XmlSqlBinaryReader.ScanState Error = 6;
	public const XmlSqlBinaryReader.ScanState EOF = 7;
	public const XmlSqlBinaryReader.ScanState Closed = 8;

}

internal struct XmlSqlBinaryReader.QName // TypeDefIndex: 1824
{	// Fields
	public string prefix; // 0x0
	public string localname; // 0x8
	public string namespaceUri; // 0x10

	// Methods

	// RVA: 0xF5B60 Offset: 0xF4F60 VA: 0x1800F5B60
	public void .ctor(string prefix, string lname, string nsUri) { }

	// RVA: 0xF5B60 Offset: 0xF4F60 VA: 0x1800F5B60
	public void Set(string prefix, string lname, string nsUri) { }

	// RVA: 0xFD820 Offset: 0xFCC20 VA: 0x1800FD820
	public void Clear() { }

	// RVA: 0xFD470 Offset: 0xFC870 VA: 0x1800FD470
	public bool MatchNs(string lname, string nsUri) { }

	// RVA: 0xFD990 Offset: 0xFCD90 VA: 0x1800FD990
	public bool MatchPrefix(string prefix, string lname) { }

	// RVA: 0xFD810 Offset: 0xFCC10 VA: 0x1800FD810
	public void CheckPrefixNS(string prefix, string namespaceUri) { }

	// RVA: 0xF58E0 Offset: 0xF4CE0 VA: 0x1800F58E0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xFD930 Offset: 0xFCD30 VA: 0x1800FD930
	public int GetNSHashCode(SecureStringHasher hasher) { }

	// RVA: 0xFD830 Offset: 0xFCC30 VA: 0x1800FD830 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0xFD9E0 Offset: 0xFCDE0 VA: 0x1800FD9E0 Slot: 3
	public override string ToString() { }

	// RVA: 0xB96860 Offset: 0xB95C60 VA: 0x180B96860
	public static bool op_Equality(XmlSqlBinaryReader.QName a, XmlSqlBinaryReader.QName b) { }

}

private struct XmlSqlBinaryReader.ElemInfo // TypeDefIndex: 1825
{	// Fields
	public XmlSqlBinaryReader.QName name; // 0x0
	public string xmlLang; // 0x18
	public XmlSpace xmlSpace; // 0x20
	public bool xmlspacePreserve; // 0x24
	public XmlSqlBinaryReader.NamespaceDecl nsdecls; // 0x28

	// Methods

	// RVA: 0xFD790 Offset: 0xFCB90 VA: 0x1800FD790
	public void Set(XmlSqlBinaryReader.QName name, bool xmlspacePreserve) { }

	// RVA: 0xFD760 Offset: 0xFCB60 VA: 0x1800FD760
	public XmlSqlBinaryReader.NamespaceDecl Clear() { }

}

private struct XmlSqlBinaryReader.AttrInfo // TypeDefIndex: 1826
{	// Fields
	public XmlSqlBinaryReader.QName name; // 0x0
	public string val; // 0x18
	public int contentPos; // 0x20
	public int hashCode; // 0x24
	public int prevHash; // 0x28

	// Methods

	// RVA: 0xFD4C0 Offset: 0xFC8C0 VA: 0x1800FD4C0
	public void Set(XmlSqlBinaryReader.QName n, string v) { }

	// RVA: 0xFD510 Offset: 0xFC910 VA: 0x1800FD510
	public void Set(XmlSqlBinaryReader.QName n, int pos) { }

	// RVA: 0xFD3D0 Offset: 0xFC7D0 VA: 0x1800FD3D0
	public void GetLocalnameAndNamespaceUri(out string localname, out string namespaceUri) { }

	// RVA: 0xFD350 Offset: 0xFC750 VA: 0x1800FD350
	public int GetLocalnameAndNamespaceUriAndHash(SecureStringHasher hasher, out string localname, out string namespaceUri) { }

	// RVA: 0xFD470 Offset: 0xFC870 VA: 0x1800FD470
	public bool MatchNS(string localname, string namespaceUri) { }

	// RVA: 0xFD410 Offset: 0xFC810 VA: 0x1800FD410
	public bool MatchHashNS(int hash, string localname, string namespaceUri) { }

	// RVA: 0xFD340 Offset: 0xFC740 VA: 0x1800FD340
	public void AdjustPosition(int adj) { }

}

private class XmlSqlBinaryReader.NamespaceDecl // TypeDefIndex: 1827
{	// Fields
	public string prefix; // 0x10
	public string uri; // 0x18
	public XmlSqlBinaryReader.NamespaceDecl scopeLink; // 0x20
	public XmlSqlBinaryReader.NamespaceDecl prevLink; // 0x28
	public int scope; // 0x30
	public bool implied; // 0x34

	// Methods

	// RVA: 0xB96460 Offset: 0xB95860 VA: 0x180B96460
	public void .ctor(string prefix, string nsuri, XmlSqlBinaryReader.NamespaceDecl nextInScope, XmlSqlBinaryReader.NamespaceDecl prevDecl, int scope, bool implied) { }

}

private struct XmlSqlBinaryReader.SymbolTables // TypeDefIndex: 1828
{	// Fields
	public string[] symtable; // 0x0
	public int symCount; // 0x8
	public XmlSqlBinaryReader.QName[] qnametable; // 0x10
	public int qnameCount; // 0x18

	// Methods

	// RVA: 0xFDA40 Offset: 0xFCE40 VA: 0x1800FDA40
	public void Init() { }

}

private class XmlSqlBinaryReader.NestedBinXml // TypeDefIndex: 1829
{	// Fields
	public XmlSqlBinaryReader.SymbolTables symbolTables; // 0x10
	public int docState; // 0x30
	public XmlSqlBinaryReader.NestedBinXml next; // 0x38

	// Methods

	// RVA: 0xB964F0 Offset: 0xB958F0 VA: 0x180B964F0
	public void .ctor(XmlSqlBinaryReader.SymbolTables symbolTables, int docState, XmlSqlBinaryReader.NestedBinXml next) { }

}

internal class XmlAsyncCheckReader : XmlReader // TypeDefIndex: 1873
{	// Fields
	private readonly XmlReader coreReader; // 0x10
	private Task lastTask; // 0x18

	// Properties
	internal XmlReader CoreReader { get; }
	public override XmlReaderSettings Settings { get; }
	public override XmlNodeType NodeType { get; }
	public override string Name { get; }
	public override string LocalName { get; }
	public override string NamespaceURI { get; }
	public override string Prefix { get; }
	public override string Value { get; }
	public override int Depth { get; }
	public override string BaseURI { get; }
	public override bool IsEmptyElement { get; }
	public override bool IsDefault { get; }
	public override char QuoteChar { get; }
	public override XmlSpace XmlSpace { get; }
	public override string XmlLang { get; }
	public override IXmlSchemaInfo SchemaInfo { get; }
	public override Type ValueType { get; }
	public override int AttributeCount { get; }
	public override bool EOF { get; }
	public override ReadState ReadState { get; }
	public override XmlNameTable NameTable { get; }
	public override bool CanResolveEntity { get; }
	public override bool CanReadValueChunk { get; }
	public override bool HasAttributes { get; }
	internal override XmlNamespaceManager NamespaceManager { get; }
	internal override IDtdInfo DtdInfo { get; }

	// Methods

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	internal XmlReader get_CoreReader() { }

	// RVA: 0xE4DEF0 Offset: 0xE4D2F0 VA: 0x180E4DEF0
	public static XmlAsyncCheckReader CreateAsyncCheckWrapper(XmlReader reader) { }

	// RVA: 0xE4E760 Offset: 0xE4DB60 VA: 0x180E4E760
	public void .ctor(XmlReader reader) { }

	// RVA: 0xE4DE20 Offset: 0xE4D220 VA: 0x180E4DE20
	private void CheckAsync() { }

	// RVA: 0xE4ED10 Offset: 0xE4E110 VA: 0x180E4ED10 Slot: 5
	public override XmlReaderSettings get_Settings() { }

	// RVA: 0xE4EBD0 Offset: 0xE4DFD0 VA: 0x180E4EBD0 Slot: 6
	public override XmlNodeType get_NodeType() { }

	// RVA: 0xE4EB10 Offset: 0xE4DF10 VA: 0x180E4EB10 Slot: 7
	public override string get_Name() { }

	// RVA: 0xE4EA90 Offset: 0xE4DE90 VA: 0x180E4EA90 Slot: 8
	public override string get_LocalName() { }

	// RVA: 0xE4EB90 Offset: 0xE4DF90 VA: 0x180E4EB90 Slot: 9
	public override string get_NamespaceURI() { }

	// RVA: 0xE4EC10 Offset: 0xE4E010 VA: 0x180E4EC10 Slot: 10
	public override string get_Prefix() { }

	// RVA: 0xE4EDE0 Offset: 0xE4E1E0 VA: 0x180E4EDE0 Slot: 11
	public override string get_Value() { }

	// RVA: 0xE4E910 Offset: 0xE4DD10 VA: 0x180E4E910 Slot: 12
	public override int get_Depth() { }

	// RVA: 0xE4E850 Offset: 0xE4DC50 VA: 0x180E4E850 Slot: 13
	public override string get_BaseURI() { }

	// RVA: 0xE4EA50 Offset: 0xE4DE50 VA: 0x180E4EA50 Slot: 14
	public override bool get_IsEmptyElement() { }

	// RVA: 0xE4EA10 Offset: 0xE4DE10 VA: 0x180E4EA10 Slot: 15
	public override bool get_IsDefault() { }

	// RVA: 0xE4EC50 Offset: 0xE4E050 VA: 0x180E4EC50 Slot: 16
	public override char get_QuoteChar() { }

	// RVA: 0xE4EE60 Offset: 0xE4E260 VA: 0x180E4EE60 Slot: 17
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0xE4EE20 Offset: 0xE4E220 VA: 0x180E4EE20 Slot: 18
	public override string get_XmlLang() { }

	// RVA: 0xE4ECD0 Offset: 0xE4E0D0 VA: 0x180E4ECD0 Slot: 19
	public override IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0xE4EDA0 Offset: 0xE4E1A0 VA: 0x180E4EDA0 Slot: 20
	public override Type get_ValueType() { }

	// RVA: 0xE4E810 Offset: 0xE4DC10 VA: 0x180E4E810 Slot: 21
	public override int get_AttributeCount() { }

	// RVA: 0xE4E160 Offset: 0xE4D560 VA: 0x180E4E160 Slot: 22
	public override string GetAttribute(string name) { }

	// RVA: 0xE4E1B0 Offset: 0xE4D5B0 VA: 0x180E4E1B0 Slot: 23
	public override string GetAttribute(string name, string namespaceURI) { }

	// RVA: 0xE4E210 Offset: 0xE4D610 VA: 0x180E4E210 Slot: 24
	public override string GetAttribute(int i) { }

	// RVA: 0xE4E360 Offset: 0xE4D760 VA: 0x180E4E360 Slot: 25
	public override bool MoveToAttribute(string name) { }

	// RVA: 0xE4E310 Offset: 0xE4D710 VA: 0x180E4E310 Slot: 26
	public override void MoveToAttribute(int i) { }

	// RVA: 0xE4E430 Offset: 0xE4D830 VA: 0x180E4E430 Slot: 27
	public override bool MoveToFirstAttribute() { }

	// RVA: 0xE4E470 Offset: 0xE4D870 VA: 0x180E4E470 Slot: 28
	public override bool MoveToNextAttribute() { }

	// RVA: 0xE4E3F0 Offset: 0xE4D7F0 VA: 0x180E4E3F0 Slot: 29
	public override bool MoveToElement() { }

	// RVA: 0xE4E4B0 Offset: 0xE4D8B0 VA: 0x180E4E4B0 Slot: 30
	public override bool ReadAttributeValue() { }

	// RVA: 0xE4E6A0 Offset: 0xE4DAA0 VA: 0x180E4E6A0 Slot: 31
	public override bool Read() { }

	// RVA: 0xE4E990 Offset: 0xE4DD90 VA: 0x180E4E990 Slot: 32
	public override bool get_EOF() { }

	// RVA: 0xE4DEB0 Offset: 0xE4D2B0 VA: 0x180E4DEB0 Slot: 33
	public override void Close() { }

	// RVA: 0xE4EC90 Offset: 0xE4E090 VA: 0x180E4EC90 Slot: 34
	public override ReadState get_ReadState() { }

	// RVA: 0xE4E720 Offset: 0xE4DB20 VA: 0x180E4E720 Slot: 35
	public override void Skip() { }

	// RVA: 0xE4EAD0 Offset: 0xE4DED0 VA: 0x180E4EAD0 Slot: 36
	public override XmlNameTable get_NameTable() { }

	// RVA: 0xE4E2C0 Offset: 0xE4D6C0 VA: 0x180E4E2C0 Slot: 37
	public override string LookupNamespace(string prefix) { }

	// RVA: 0xE4E8D0 Offset: 0xE4DCD0 VA: 0x180E4E8D0 Slot: 38
	public override bool get_CanResolveEntity() { }

	// RVA: 0xE4E6E0 Offset: 0xE4DAE0 VA: 0x180E4E6E0 Slot: 39
	public override void ResolveEntity() { }

	// RVA: 0xE4E890 Offset: 0xE4DC90 VA: 0x180E4E890 Slot: 40
	public override bool get_CanReadValueChunk() { }

	// RVA: 0xE4E630 Offset: 0xE4DA30 VA: 0x180E4E630 Slot: 41
	public override int ReadValueChunk(char[] buffer, int index, int count) { }

	// RVA: 0xE4E5F0 Offset: 0xE4D9F0 VA: 0x180E4E5F0 Slot: 42
	public override string ReadString() { }

	// RVA: 0xE4E3B0 Offset: 0xE4D7B0 VA: 0x180E4E3B0 Slot: 43
	public override XmlNodeType MoveToContent() { }

	// RVA: 0xE4E5B0 Offset: 0xE4D9B0 VA: 0x180E4E5B0 Slot: 44
	public override void ReadStartElement() { }

	// RVA: 0xE4E4F0 Offset: 0xE4D8F0 VA: 0x180E4E4F0 Slot: 45
	public override string ReadElementString() { }

	// RVA: 0xE4E530 Offset: 0xE4D930 VA: 0x180E4E530 Slot: 46
	public override void ReadEndElement() { }

	// RVA: 0xE4E260 Offset: 0xE4D660 VA: 0x180E4E260 Slot: 47
	public override bool IsStartElement(string localname, string ns) { }

	// RVA: 0xE4E570 Offset: 0xE4D970 VA: 0x180E4E570 Slot: 48
	public override string ReadInnerXml() { }

	// RVA: 0xE4E9D0 Offset: 0xE4DDD0 VA: 0x180E4E9D0 Slot: 49
	public override bool get_HasAttributes() { }

	// RVA: 0xE4E130 Offset: 0xE4D530 VA: 0x180E4E130 Slot: 50
	protected override void Dispose(bool disposing) { }

	// RVA: 0xE4EB50 Offset: 0xE4DF50 VA: 0x180E4EB50 Slot: 51
	internal override XmlNamespaceManager get_NamespaceManager() { }

	// RVA: 0xE4E950 Offset: 0xE4DD50 VA: 0x180E4E950 Slot: 52
	internal override IDtdInfo get_DtdInfo() { }

}

internal class XmlAsyncCheckReaderWithNS : XmlAsyncCheckReader, IXmlNamespaceResolver // TypeDefIndex: 1874
{	// Fields
	private readonly IXmlNamespaceResolver readerAsIXmlNamespaceResolver; // 0x20

	// Methods

	// RVA: 0xE4DD90 Offset: 0xE4D190 VA: 0x180E4DD90
	public void .ctor(XmlReader reader) { }

	// RVA: 0xE4DC70 Offset: 0xE4D070 VA: 0x180E4DC70 Slot: 53
	private IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0xE4DCD0 Offset: 0xE4D0D0 VA: 0x180E4DCD0 Slot: 54
	private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0xE4DD30 Offset: 0xE4D130 VA: 0x180E4DD30 Slot: 55
	private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

}

internal class XmlAsyncCheckReaderWithLineInfo : XmlAsyncCheckReader, IXmlLineInfo // TypeDefIndex: 1875
{	// Fields
	private readonly IXmlLineInfo readerAsIXmlLineInfo; // 0x20

	// Properties
	public virtual int LineNumber { get; }
	public virtual int LinePosition { get; }

	// Methods

	// RVA: 0xE4DB40 Offset: 0xE4CF40 VA: 0x180E4DB40
	public void .ctor(XmlReader reader) { }

	// RVA: 0xE4DAF0 Offset: 0xE4CEF0 VA: 0x180E4DAF0 Slot: 56
	public virtual bool HasLineInfo() { }

	// RVA: 0xE4DBD0 Offset: 0xE4CFD0 VA: 0x180E4DBD0 Slot: 57
	public virtual int get_LineNumber() { }

	// RVA: 0xE4DC20 Offset: 0xE4D020 VA: 0x180E4DC20 Slot: 58
	public virtual int get_LinePosition() { }

}

internal class XmlAsyncCheckReaderWithLineInfoNS : XmlAsyncCheckReaderWithLineInfo, IXmlNamespaceResolver // TypeDefIndex: 1876
{	// Fields
	private readonly IXmlNamespaceResolver readerAsIXmlNamespaceResolver; // 0x28

	// Methods

	// RVA: 0xE4DA00 Offset: 0xE4CE00 VA: 0x180E4DA00
	public void .ctor(XmlReader reader) { }

	// RVA: 0xE4D8E0 Offset: 0xE4CCE0 VA: 0x180E4D8E0 Slot: 59
	private IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0xE4D940 Offset: 0xE4CD40 VA: 0x180E4D940 Slot: 60
	private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0xE4D9A0 Offset: 0xE4CDA0 VA: 0x180E4D9A0 Slot: 61
	private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

}

internal class XmlAsyncCheckReaderWithLineInfoNSSchema : XmlAsyncCheckReaderWithLineInfoNS, IXmlSchemaInfo // TypeDefIndex: 1877
{	// Fields
	private readonly IXmlSchemaInfo readerAsIXmlSchemaInfo; // 0x30

	// Properties
	private XmlSchemaValidity System.Xml.Schema.IXmlSchemaInfo.Validity { get; }
	private bool System.Xml.Schema.IXmlSchemaInfo.IsDefault { get; }
	private bool System.Xml.Schema.IXmlSchemaInfo.IsNil { get; }
	private XmlSchemaSimpleType System.Xml.Schema.IXmlSchemaInfo.MemberType { get; }
	private XmlSchemaType System.Xml.Schema.IXmlSchemaInfo.SchemaType { get; }
	private XmlSchemaElement System.Xml.Schema.IXmlSchemaInfo.SchemaElement { get; }
	private XmlSchemaAttribute System.Xml.Schema.IXmlSchemaInfo.SchemaAttribute { get; }

	// Methods

	// RVA: 0xE4D850 Offset: 0xE4CC50 VA: 0x180E4D850
	public void .ctor(XmlReader reader) { }

	// RVA: 0xE4D800 Offset: 0xE4CC00 VA: 0x180E4D800 Slot: 62
	private XmlSchemaValidity System.Xml.Schema.IXmlSchemaInfo.get_Validity() { }

	// RVA: 0xE4D540 Offset: 0xE4C940 VA: 0x180E4D540 Slot: 63
	private bool System.Xml.Schema.IXmlSchemaInfo.get_IsDefault() { }

	// RVA: 0xE4D590 Offset: 0xE4C990 VA: 0x180E4D590 Slot: 64
	private bool System.Xml.Schema.IXmlSchemaInfo.get_IsNil() { }

	// RVA: 0xE4D5E0 Offset: 0xE4C9E0 VA: 0x180E4D5E0 Slot: 65
	private XmlSchemaSimpleType System.Xml.Schema.IXmlSchemaInfo.get_MemberType() { }

	// RVA: 0xE4D7B0 Offset: 0xE4CBB0 VA: 0x180E4D7B0 Slot: 66
	private XmlSchemaType System.Xml.Schema.IXmlSchemaInfo.get_SchemaType() { }

	// RVA: 0xE4D6F0 Offset: 0xE4CAF0 VA: 0x180E4D6F0 Slot: 67
	private XmlSchemaElement System.Xml.Schema.IXmlSchemaInfo.get_SchemaElement() { }

	// RVA: 0xE4D630 Offset: 0xE4CA30 VA: 0x180E4D630 Slot: 68
	private XmlSchemaAttribute System.Xml.Schema.IXmlSchemaInfo.get_SchemaAttribute() { }

}

internal class XmlAsyncCheckWriter : XmlWriter // TypeDefIndex: 1878
{	// Fields
	private readonly XmlWriter coreWriter; // 0x18
	private Task lastTask; // 0x20

	// Properties
	public override WriteState WriteState { get; }

	// Methods

	// RVA: 0xE4F8D0 Offset: 0xE4ECD0 VA: 0x180E4F8D0
	public void .ctor(XmlWriter writer) { }

	// RVA: 0xE4EEA0 Offset: 0xE4E2A0 VA: 0x180E4EEA0
	private void CheckAsync() { }

	// RVA: 0xE4F680 Offset: 0xE4EA80 VA: 0x180E4F680 Slot: 5
	public override void WriteStartDocument() { }

	// RVA: 0xE4F6C0 Offset: 0xE4EAC0 VA: 0x180E4F6C0 Slot: 6
	public override void WriteStartDocument(bool standalone) { }

	// RVA: 0xE4F380 Offset: 0xE4E780 VA: 0x180E4F380 Slot: 7
	public override void WriteEndDocument() { }

	// RVA: 0xE4F2D0 Offset: 0xE4E6D0 VA: 0x180E4F2D0 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0xE4F710 Offset: 0xE4EB10 VA: 0x180E4F710 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0xE4F3C0 Offset: 0xE4E7C0 VA: 0x180E4F3C0 Slot: 10
	public override void WriteEndElement() { }

	// RVA: 0xE4F450 Offset: 0xE4E850 VA: 0x180E4F450 Slot: 11
	public override void WriteFullEndElement() { }

	// RVA: 0xE4F610 Offset: 0xE4EA10 VA: 0x180E4F610 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0xE4F340 Offset: 0xE4E740 VA: 0x180E4F340 Slot: 13
	public override void WriteEndAttribute() { }

	// RVA: 0xE4F170 Offset: 0xE4E570 VA: 0x180E4F170 Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0xE4F280 Offset: 0xE4E680 VA: 0x180E4F280 Slot: 15
	public override void WriteComment(string text) { }

	// RVA: 0xE4F4F0 Offset: 0xE4E8F0 VA: 0x180E4F4F0 Slot: 16
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0xE4F400 Offset: 0xE4E800 VA: 0x180E4F400 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0xE4F1C0 Offset: 0xE4E5C0 VA: 0x180E4F1C0 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0xE4F880 Offset: 0xE4EC80 VA: 0x180E4F880 Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0xE4F780 Offset: 0xE4EB80 VA: 0x180E4F780 Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0xE4F7D0 Offset: 0xE4EBD0 VA: 0x180E4F7D0 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0xE4F210 Offset: 0xE4E610 VA: 0x180E4F210 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0xE4F550 Offset: 0xE4E950 VA: 0x180E4F550 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0xE4F5C0 Offset: 0xE4E9C0 VA: 0x180E4F5C0 Slot: 24
	public override void WriteRaw(string data) { }

	// RVA: 0xE4F090 Offset: 0xE4E490 VA: 0x180E4F090 Slot: 25
	public override void WriteBase64(byte[] buffer, int index, int count) { }

	// RVA: 0xE4F100 Offset: 0xE4E500 VA: 0x180E4F100 Slot: 26
	public override void WriteBinHex(byte[] buffer, int index, int count) { }

	// RVA: 0xE4F960 Offset: 0xE4ED60 VA: 0x180E4F960 Slot: 27
	public override WriteState get_WriteState() { }

	// RVA: 0xE4EF30 Offset: 0xE4E330 VA: 0x180E4EF30 Slot: 28
	public override void Close() { }

	// RVA: 0xE4EFA0 Offset: 0xE4E3A0 VA: 0x180E4EFA0 Slot: 29
	public override void Flush() { }

	// RVA: 0xE4EFE0 Offset: 0xE4E3E0 VA: 0x180E4EFE0 Slot: 30
	public override string LookupPrefix(string ns) { }

	// RVA: 0xE4F830 Offset: 0xE4EC30 VA: 0x180E4F830 Slot: 31
	public override void WriteValue(string value) { }

	// RVA: 0xE4F030 Offset: 0xE4E430 VA: 0x180E4F030 Slot: 32
	public override void WriteAttributes(XmlReader reader, bool defattr) { }

	// RVA: 0xE4F490 Offset: 0xE4E890 VA: 0x180E4F490 Slot: 33
	public override void WriteNode(XmlReader reader, bool defattr) { }

	// RVA: 0xE4EF70 Offset: 0xE4E370 VA: 0x180E4EF70 Slot: 34
	protected override void Dispose(bool disposing) { }

}

internal class XmlAutoDetectWriter : XmlRawWriter // TypeDefIndex: 1879
{	// Fields
	private XmlRawWriter wrapped; // 0x28
	private OnRemoveWriter onRemove; // 0x30
	private XmlWriterSettings writerSettings; // 0x38
	private XmlEventCache eventCache; // 0x40
	private TextWriter textWriter; // 0x48
	private Stream strm; // 0x50

	// Properties
	internal override IXmlNamespaceResolver NamespaceResolver { set; }
	internal override bool SupportsNamespaceDeclarationInChunks { get; }

	// Methods

	// RVA: 0xE52FE0 Offset: 0xE523E0 VA: 0x180E52FE0
	private void .ctor(XmlWriterSettings writerSettings) { }

	// RVA: 0xE52F60 Offset: 0xE52360 VA: 0x180E52F60
	public void .ctor(TextWriter textWriter, XmlWriterSettings writerSettings) { }

	// RVA: 0xE52FA0 Offset: 0xE523A0 VA: 0x180E52FA0
	public void .ctor(Stream strm, XmlWriterSettings writerSettings) { }

	// RVA: 0xE52800 Offset: 0xE51C00 VA: 0x180E52800 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0xE52B70 Offset: 0xE51F70 VA: 0x180E52B70 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0xE52AF0 Offset: 0xE51EF0 VA: 0x180E52AF0 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0xE52880 Offset: 0xE51C80 VA: 0x180E52880 Slot: 13
	public override void WriteEndAttribute() { }

	// RVA: 0xE52700 Offset: 0xE51B00 VA: 0x180E52700 Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0xE527B0 Offset: 0xE51BB0 VA: 0x180E527B0 Slot: 15
	public override void WriteComment(string text) { }

	// RVA: 0xE52A10 Offset: 0xE51E10 VA: 0x180E52A10 Slot: 16
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0xE52E50 Offset: 0xE52250 VA: 0x180E52E50 Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0xE52D30 Offset: 0xE52130 VA: 0x180E52D30 Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0xB9C2F0 Offset: 0xB9B6F0 VA: 0x180B9C2F0 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0xE52AB0 Offset: 0xE51EB0 VA: 0x180E52AB0 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0xE52A60 Offset: 0xE51E60 VA: 0x180E52A60 Slot: 24
	public override void WriteRaw(string data) { }

	// RVA: 0xE52910 Offset: 0xE51D10 VA: 0x180E52910 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0xE52750 Offset: 0xE51B50 VA: 0x180E52750 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0xE52D80 Offset: 0xE52180 VA: 0x180E52D80 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0xE52600 Offset: 0xE51A00 VA: 0x180E52600 Slot: 25
	public override void WriteBase64(byte[] buffer, int index, int count) { }

	// RVA: 0xE52680 Offset: 0xE51A80 VA: 0x180E52680 Slot: 26
	public override void WriteBinHex(byte[] buffer, int index, int count) { }

	// RVA: 0xE52160 Offset: 0xE51560 VA: 0x180E52160 Slot: 28
	public override void Close() { }

	// RVA: 0xE523F0 Offset: 0xE517F0 VA: 0x180E523F0 Slot: 29
	public override void Flush() { }

	// RVA: 0xE52DF0 Offset: 0xE521F0 VA: 0x180E52DF0 Slot: 31
	public override void WriteValue(string value) { }

	// RVA: 0xE530D0 Offset: 0xE524D0 VA: 0x180E530D0 Slot: 35
	internal override void set_NamespaceResolver(IXmlNamespaceResolver value) { }

	// RVA: 0xE52F00 Offset: 0xE52300 VA: 0x180E52F00 Slot: 36
	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0xE52EA0 Offset: 0xE522A0 VA: 0x180E52EA0 Slot: 37
	internal override void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0xE52520 Offset: 0xE51920 VA: 0x180E52520 Slot: 38
	internal override void StartElementContent() { }

	// RVA: 0xE528B0 Offset: 0xE51CB0 VA: 0x180E528B0 Slot: 40
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0xE52970 Offset: 0xE51D70 VA: 0x180E52970 Slot: 41
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0xE529A0 Offset: 0xE51DA0 VA: 0x180E529A0 Slot: 42
	internal override void WriteNamespaceDeclaration(string prefix, string ns) { }

	// RVA: 0xE530A0 Offset: 0xE524A0 VA: 0x180E530A0 Slot: 43
	internal override bool get_SupportsNamespaceDeclarationInChunks() { }

	// RVA: 0xE52CD0 Offset: 0xE520D0 VA: 0x180E52CD0 Slot: 44
	internal override void WriteStartNamespaceDeclaration(string prefix) { }

	// RVA: 0xE528E0 Offset: 0xE51CE0 VA: 0x180E528E0 Slot: 45
	internal override void WriteEndNamespaceDeclaration() { }

	// RVA: 0xE52440 Offset: 0xE51840 VA: 0x180E52440
	private static bool IsHtmlTag(string tagName) { }

	// RVA: 0xE523E0 Offset: 0xE517E0 VA: 0x180E523E0
	private void EnsureWrappedWriter(XmlOutputMethod outMethod) { }

	// RVA: 0xE52550 Offset: 0xE51950 VA: 0x180E52550
	private bool TextBlockCreatesWriter(string textBlock) { }

	// RVA: 0xE521B0 Offset: 0xE515B0 VA: 0x180E521B0
	private void CreateWrappedWriter(XmlOutputMethod outMethod) { }

}

internal class XmlEncodedRawTextWriter : XmlRawWriter // TypeDefIndex: 1880
{	// Fields
	private readonly bool useAsync; // 0x28
	protected byte[] bufBytes; // 0x30
	protected Stream stream; // 0x38
	protected Encoding encoding; // 0x40
	protected XmlCharType xmlCharType; // 0x48
	protected int bufPos; // 0x50
	protected int textPos; // 0x54
	protected int contentPos; // 0x58
	protected int cdataPos; // 0x5C
	protected int attrEndPos; // 0x60
	protected int bufLen; // 0x64
	protected bool writeToNull; // 0x68
	protected bool hadDoubleBracket; // 0x69
	protected bool inAttributeValue; // 0x6A
	protected int bufBytesUsed; // 0x6C
	protected char[] bufChars; // 0x70
	protected Encoder encoder; // 0x78
	protected TextWriter writer; // 0x80
	protected bool trackTextContent; // 0x88
	protected bool inTextContent; // 0x89
	private int lastMarkPos; // 0x8C
	private int[] textContentMarks; // 0x90
	private CharEntityEncoderFallback charEntityFallback; // 0x98
	protected NewLineHandling newLineHandling; // 0xA0
	protected bool closeOutput; // 0xA4
	protected bool omitXmlDeclaration; // 0xA5
	protected string newLineChars; // 0xA8
	protected bool checkCharacters; // 0xB0
	protected XmlStandalone standalone; // 0xB4
	protected XmlOutputMethod outputMethod; // 0xB8
	protected bool autoXmlDeclaration; // 0xBC
	protected bool mergeCDataSections; // 0xBD

	// Properties
	internal override bool SupportsNamespaceDeclarationInChunks { get; }

	// Methods

	// RVA: 0x11BD710 Offset: 0x11BCB10 VA: 0x1811BD710
	protected void .ctor(XmlWriterSettings settings) { }

	// RVA: 0x11BD300 Offset: 0x11BC700 VA: 0x1811BD300
	public void .ctor(TextWriter writer, XmlWriterSettings settings) { }

	// RVA: 0x11BD400 Offset: 0x11BC800 VA: 0x1811BD400
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x11BD090 Offset: 0x11BC490 VA: 0x1811BD090 Slot: 36
	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x11BD290 Offset: 0x11BC690 VA: 0x1811BD290 Slot: 37
	internal override void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0x11BB6E0 Offset: 0x11BAAE0 VA: 0x1811BB6E0 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x11BCB20 Offset: 0x11BBF20 VA: 0x1811BCB20 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x11BA080 Offset: 0x11B9480 VA: 0x1811BA080 Slot: 38
	internal override void StartElementContent() { }

	// RVA: 0x11BBDF0 Offset: 0x11BB1F0 VA: 0x1811BBDF0 Slot: 40
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x11BC190 Offset: 0x11BB590 VA: 0x1811BC190 Slot: 41
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x11BC990 Offset: 0x11BBD90 VA: 0x1811BC990 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x11BBD80 Offset: 0x11BB180 VA: 0x1811BBD80 Slot: 13
	public override void WriteEndAttribute() { }

	// RVA: 0x11BC320 Offset: 0x11BB720 VA: 0x1811BC320 Slot: 42
	internal override void WriteNamespaceDeclaration(string prefix, string namespaceName) { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 43
	internal override bool get_SupportsNamespaceDeclarationInChunks() { }

	// RVA: 0x11BCC40 Offset: 0x11BC040 VA: 0x1811BCC40 Slot: 44
	internal override void WriteStartNamespaceDeclaration(string prefix) { }

	// RVA: 0x11BC020 Offset: 0x11BB420 VA: 0x1811BC020 Slot: 45
	internal override void WriteEndNamespaceDeclaration() { }

	// RVA: 0x11BAB30 Offset: 0x11B9F30 VA: 0x1811BAB30 Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0x11BB500 Offset: 0x11BA900 VA: 0x1811BB500 Slot: 15
	public override void WriteComment(string text) { }

	// RVA: 0x11BC410 Offset: 0x11BB810 VA: 0x1811BC410 Slot: 16
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x11BC090 Offset: 0x11BB490 VA: 0x1811BC090 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x11BAE50 Offset: 0x11BA250 VA: 0x1811BAE50 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x11BD010 Offset: 0x11BC410 VA: 0x1811BD010 Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x11BCDD0 Offset: 0x11BC1D0 VA: 0x1811BCDD0 Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0x11BCE50 Offset: 0x11BC250 VA: 0x1811BCE50 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x11BB080 Offset: 0x11BA480 VA: 0x1811BB080 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x11BC900 Offset: 0x11BBD00 VA: 0x1811BC900 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0x11BC890 Offset: 0x11BBC90 VA: 0x1811BC890 Slot: 24
	public override void WriteRaw(string data) { }

	// RVA: 0x11B9070 Offset: 0x11B8470 VA: 0x1811B9070 Slot: 28
	public override void Close() { }

	// RVA: 0x11B9B70 Offset: 0x11B8F70 VA: 0x1811B9B70 Slot: 29
	public override void Flush() { }

	// RVA: 0x11B96F0 Offset: 0x11B8AF0 VA: 0x1811B96F0 Slot: 48
	protected virtual void FlushBuffer() { }

	// RVA: 0x11B9410 Offset: 0x11B8810 VA: 0x1811B9410
	private void EncodeChars(int startOffset, int endOffset, bool writeAllToStream) { }

	// RVA: 0x11B9AA0 Offset: 0x11B8EA0 VA: 0x1811B9AA0
	private void FlushEncoder() { }

	// RVA: 0x11BA450 Offset: 0x11B9850 VA: 0x1811BA450
	protected void WriteAttributeTextBlock(char* pSrc, char* pSrcEnd) { }

	// RVA: 0x11BBA40 Offset: 0x11BAE40 VA: 0x1811BBA40
	protected void WriteElementTextBlock(char* pSrc, char* pSrcEnd) { }

	// RVA: 0x11B9E80 Offset: 0x11B9280 VA: 0x1811B9E80
	protected void RawText(string s) { }

	// RVA: 0x11B9ED0 Offset: 0x11B92D0 VA: 0x1811B9ED0
	protected void RawText(char* pSrcBegin, char* pSrcEnd) { }

	// RVA: 0x11BC5C0 Offset: 0x11BB9C0 VA: 0x1811BC5C0
	protected void WriteRawWithCharChecking(char* pSrcBegin, char* pSrcEnd) { }

	// RVA: 0x11BB120 Offset: 0x11BA520 VA: 0x1811BB120
	protected void WriteCommentOrPi(string text, int stopChar) { }

	// RVA: 0x11BA760 Offset: 0x11B9B60 VA: 0x1811BA760
	protected void WriteCDataSection(string text) { }

	// RVA: 0x11B9590 Offset: 0x11B8990 VA: 0x1811B9590
	private static char* EncodeSurrogate(char* pSrc, char* pSrcEnd, char* pDst) { }

	// RVA: 0x11B9C90 Offset: 0x11B9090 VA: 0x1811B9C90
	private char* InvalidXmlChar(int ch, char* pDst, bool entitize) { }

	// RVA: 0x11B9310 Offset: 0x11B8710 VA: 0x1811B9310
	internal void EncodeChar(ref char* pSrc, char* pSrcEnd, ref char* pDst) { }

	// RVA: 0x11B8ED0 Offset: 0x11B82D0 VA: 0x1811B8ED0
	protected void ChangeTextContentMark(bool value) { }

	// RVA: 0x11B9BE0 Offset: 0x11B8FE0 VA: 0x1811B9BE0
	private void GrowTextContentMarks() { }

	// RVA: 0x11BC380 Offset: 0x11BB780 VA: 0x1811BC380
	protected char* WriteNewLine(char* pDst) { }

	// RVA: 0x11B9DF0 Offset: 0x11B91F0 VA: 0x1811B9DF0
	protected static char* LtEntity(char* pDst) { }

	// RVA: 0x11B9C70 Offset: 0x11B9070 VA: 0x1811B9C70
	protected static char* GtEntity(char* pDst) { }

	// RVA: 0x11B8E90 Offset: 0x11B8290 VA: 0x1811B8E90
	protected static char* AmpEntity(char* pDst) { }

	// RVA: 0x11B9E10 Offset: 0x11B9210 VA: 0x1811B9E10
	protected static char* QuoteEntity(char* pDst) { }

	// RVA: 0x11BA0D0 Offset: 0x11B94D0 VA: 0x1811BA0D0
	protected static char* TabEntity(char* pDst) { }

	// RVA: 0x11B9DD0 Offset: 0x11B91D0 VA: 0x1811B9DD0
	protected static char* LineFeedEntity(char* pDst) { }

	// RVA: 0x11B8EB0 Offset: 0x11B82B0 VA: 0x1811B8EB0
	protected static char* CarriageReturnEntity(char* pDst) { }

	// RVA: 0x11B8FC0 Offset: 0x11B83C0 VA: 0x1811B8FC0
	private static char* CharEntity(char* pDst, char ch) { }

	// RVA: 0x11B9E50 Offset: 0x11B9250 VA: 0x1811B9E50
	protected static char* RawStartCData(char* pDst) { }

	// RVA: 0x11B9E30 Offset: 0x11B9230 VA: 0x1811B9E30
	protected static char* RawEndCData(char* pDst) { }

	// RVA: 0x11BA0F0 Offset: 0x11B94F0 VA: 0x1811BA0F0
	protected void ValidateContentChars(string chars, string propertyName, bool allowOnlyWhitespace) { }

}

internal class XmlEncodedRawTextWriterIndent : XmlEncodedRawTextWriter // TypeDefIndex: 1881
{	// Fields
	protected int indentLevel; // 0xC0
	protected bool newLineOnAttributes; // 0xC4
	protected string indentChars; // 0xC8
	protected bool mixedContent; // 0xD0
	private BitStack mixedContentStack; // 0xD8
	protected ConformanceLevel conformanceLevel; // 0xE0

	// Methods

	// RVA: 0x11B8D90 Offset: 0x11B8190 VA: 0x1811B8D90
	public void .ctor(TextWriter writer, XmlWriterSettings settings) { }

	// RVA: 0x11B8D60 Offset: 0x11B8160 VA: 0x1811B8D60
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x11B8600 Offset: 0x11B7A00 VA: 0x1811B8600 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x11B8AF0 Offset: 0x11B7EF0 VA: 0x1811B8AF0 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x11B8460 Offset: 0x11B7860 VA: 0x1811B8460 Slot: 38
	internal override void StartElementContent() { }

	// RVA: 0x94E8A0 Offset: 0x94DCA0 VA: 0x18094E8A0 Slot: 39
	internal override void OnRootElement(ConformanceLevel currentConformanceLevel) { }

	// RVA: 0x11B8670 Offset: 0x11B7A70 VA: 0x1811B8670 Slot: 40
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x11B8800 Offset: 0x11B7C00 VA: 0x1811B8800 Slot: 41
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x11B8A90 Offset: 0x11B7E90 VA: 0x1811B8A90 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x11B8500 Offset: 0x11B7900 VA: 0x1811B8500 Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0x11B85C0 Offset: 0x11B79C0 VA: 0x1811B85C0 Slot: 15
	public override void WriteComment(string text) { }

	// RVA: 0x11B8930 Offset: 0x11B7D30 VA: 0x1811B8930 Slot: 16
	public override void WriteProcessingInstruction(string target, string text) { }

	// RVA: 0x11B8700 Offset: 0x11B7B00 VA: 0x1811B8700 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x11B8510 Offset: 0x11B7910 VA: 0x1811B8510 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x11B8CD0 Offset: 0x11B80D0 VA: 0x1811B8CD0 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x11B8CE0 Offset: 0x11B80E0 VA: 0x1811B8CE0 Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x11B8C50 Offset: 0x11B8050 VA: 0x1811B8C50 Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0x11B8520 Offset: 0x11B7920 VA: 0x1811B8520 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x11B8980 Offset: 0x11B7D80 VA: 0x1811B8980 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0x11B8A20 Offset: 0x11B7E20 VA: 0x1811B8A20 Slot: 24
	public override void WriteRaw(string data) { }

	// RVA: 0x11B84E0 Offset: 0x11B78E0 VA: 0x1811B84E0 Slot: 25
	public override void WriteBase64(byte[] buffer, int index, int count) { }

	// RVA: 0x11B8350 Offset: 0x11B7750 VA: 0x1811B8350
	private void Init(XmlWriterSettings settings) { }

	// RVA: 0x11B8890 Offset: 0x11B7C90 VA: 0x1811B8890
	private void WriteIndent() { }

}

internal sealed class XmlEventCache : XmlRawWriter // TypeDefIndex: 1882
{	// Fields
	private List<XmlEventCache.XmlEvent[]> pages; // 0x28
	private XmlEventCache.XmlEvent[] pageCurr; // 0x30
	private int pageSize; // 0x38
	private bool hasRootNode; // 0x3C
	private StringConcat singleText; // 0x40
	private string baseUri; // 0x78

	// Methods

	// RVA: 0x11BFE60 Offset: 0x11BF260 VA: 0x1811BFE60
	public void .ctor(string baseUri, bool hasRootNode) { }

	// RVA: 0x11BE870 Offset: 0x11BDC70 VA: 0x1811BE870
	public void EndEvents() { }

	// RVA: 0x11BE8C0 Offset: 0x11BDCC0 VA: 0x1811BE8C0
	public void EventsToWriter(XmlWriter writer) { }

	// RVA: 0x11BF810 Offset: 0x11BEC10 VA: 0x1811BF810 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x11BFB30 Offset: 0x11BEF30 VA: 0x1811BFB30 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x11BFB00 Offset: 0x11BEF00 VA: 0x1811BFB00 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x11BF8C0 Offset: 0x11BECC0 VA: 0x1811BF8C0 Slot: 13
	public override void WriteEndAttribute() { }

	// RVA: 0x11BF690 Offset: 0x11BEA90 VA: 0x1811BF690 Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0x11BF7A0 Offset: 0x11BEBA0 VA: 0x1811BF7A0 Slot: 15
	public override void WriteComment(string text) { }

	// RVA: 0x11BFA60 Offset: 0x11BEE60 VA: 0x1811BFA60 Slot: 16
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x11BFCE0 Offset: 0x11BF0E0 VA: 0x1811BFCE0 Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x11BFB60 Offset: 0x11BEF60 VA: 0x1811BFB60 Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0xB9C2F0 Offset: 0xB9B6F0 VA: 0x180B9C2F0 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0xE52AB0 Offset: 0xE51EB0 VA: 0x180E52AB0 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0x11BFA90 Offset: 0x11BEE90 VA: 0x1811BFA90 Slot: 24
	public override void WriteRaw(string data) { }

	// RVA: 0x11BF990 Offset: 0x11BED90 VA: 0x1811BF990 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x11BF700 Offset: 0x11BEB00 VA: 0x1811BF700 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x11BFBF0 Offset: 0x11BEFF0 VA: 0x1811BFBF0 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x11BF470 Offset: 0x11BE870 VA: 0x1811BF470 Slot: 25
	public override void WriteBase64(byte[] buffer, int index, int count) { }

	// RVA: 0x11BF580 Offset: 0x11BE980 VA: 0x1811BF580 Slot: 26
	public override void WriteBinHex(byte[] buffer, int index, int count) { }

	// RVA: 0x11BE730 Offset: 0x11BDB30 VA: 0x1811BE730 Slot: 28
	public override void Close() { }

	// RVA: 0x11BF190 Offset: 0x11BE590 VA: 0x1811BF190 Slot: 29
	public override void Flush() { }

	// RVA: 0xAEA3F0 Offset: 0xAE97F0 VA: 0x180AEA3F0 Slot: 31
	public override void WriteValue(string value) { }

	// RVA: 0x11BE780 Offset: 0x11BDB80 VA: 0x1811BE780 Slot: 34
	protected override void Dispose(bool disposing) { }

	// RVA: 0x11BFDC0 Offset: 0x11BF1C0 VA: 0x1811BFDC0 Slot: 36
	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x11BFD50 Offset: 0x11BF150 VA: 0x1811BFD50 Slot: 37
	internal override void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0x11BF360 Offset: 0x11BE760 VA: 0x1811BF360 Slot: 38
	internal override void StartElementContent() { }

	// RVA: 0x11BF960 Offset: 0x11BED60 VA: 0x1811BF960 Slot: 40
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x11BFA00 Offset: 0x11BEE00 VA: 0x1811BFA00 Slot: 41
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x11BFA30 Offset: 0x11BEE30 VA: 0x1811BFA30 Slot: 42
	internal override void WriteNamespaceDeclaration(string prefix, string ns) { }

	// RVA: 0x11BF910 Offset: 0x11BED10 VA: 0x1811BF910 Slot: 46
	internal override void WriteEndBase64() { }

	// RVA: 0x11BE5E0 Offset: 0x11BD9E0 VA: 0x1811BE5E0
	private void AddEvent(XmlEventCache.XmlEventType eventType) { }

	// RVA: 0x11BE6C0 Offset: 0x11BDAC0 VA: 0x1811BE6C0
	private void AddEvent(XmlEventCache.XmlEventType eventType, string s1) { }

	// RVA: 0x11BE630 Offset: 0x11BDA30 VA: 0x1811BE630
	private void AddEvent(XmlEventCache.XmlEventType eventType, string s1, string s2) { }

	// RVA: 0x11BE490 Offset: 0x11BD890 VA: 0x1811BE490
	private void AddEvent(XmlEventCache.XmlEventType eventType, string s1, string s2, string s3) { }

	// RVA: 0x11BE530 Offset: 0x11BD930 VA: 0x1811BE530
	private void AddEvent(XmlEventCache.XmlEventType eventType, string s1, string s2, string s3, object o) { }

	// RVA: 0x11BE420 Offset: 0x11BD820 VA: 0x1811BE420
	private void AddEvent(XmlEventCache.XmlEventType eventType, object o) { }

	// RVA: 0x11BF1E0 Offset: 0x11BE5E0 VA: 0x1811BF1E0
	private int NewEvent() { }

	// RVA: 0x11BF3B0 Offset: 0x11BE7B0 VA: 0x1811BF3B0
	private static byte[] ToBytes(byte[] buffer, int index, int count) { }

}

private enum XmlEventCache.XmlEventType // TypeDefIndex: 1883
{	// Fields
	public int value__; // 0x0
	public const XmlEventCache.XmlEventType Unknown = 0;
	public const XmlEventCache.XmlEventType DocType = 1;
	public const XmlEventCache.XmlEventType StartElem = 2;
	public const XmlEventCache.XmlEventType StartAttr = 3;
	public const XmlEventCache.XmlEventType EndAttr = 4;
	public const XmlEventCache.XmlEventType CData = 5;
	public const XmlEventCache.XmlEventType Comment = 6;
	public const XmlEventCache.XmlEventType PI = 7;
	public const XmlEventCache.XmlEventType Whitespace = 8;
	public const XmlEventCache.XmlEventType String = 9;
	public const XmlEventCache.XmlEventType Raw = 10;
	public const XmlEventCache.XmlEventType EntRef = 11;
	public const XmlEventCache.XmlEventType CharEnt = 12;
	public const XmlEventCache.XmlEventType SurrCharEnt = 13;
	public const XmlEventCache.XmlEventType Base64 = 14;
	public const XmlEventCache.XmlEventType BinHex = 15;
	public const XmlEventCache.XmlEventType XmlDecl1 = 16;
	public const XmlEventCache.XmlEventType XmlDecl2 = 17;
	public const XmlEventCache.XmlEventType StartContent = 18;
	public const XmlEventCache.XmlEventType EndElem = 19;
	public const XmlEventCache.XmlEventType FullEndElem = 20;
	public const XmlEventCache.XmlEventType Nmsp = 21;
	public const XmlEventCache.XmlEventType EndBase64 = 22;
	public const XmlEventCache.XmlEventType Close = 23;
	public const XmlEventCache.XmlEventType Flush = 24;
	public const XmlEventCache.XmlEventType Dispose = 25;

}

private struct XmlEventCache.XmlEvent // TypeDefIndex: 1884
{	// Fields
	private XmlEventCache.XmlEventType eventType; // 0x0
	private string s1; // 0x8
	private string s2; // 0x10
	private string s3; // 0x18
	private object o; // 0x20

	// Properties
	public XmlEventCache.XmlEventType EventType { get; }
	public string String1 { get; }
	public string String2 { get; }
	public string String3 { get; }
	public object Object { get; }

	// Methods

	// RVA: 0xF3A80 Offset: 0xF2E80 VA: 0x1800F3A80
	public void InitEvent(XmlEventCache.XmlEventType eventType) { }

	// RVA: 0xFC970 Offset: 0xFBD70 VA: 0x1800FC970
	public void InitEvent(XmlEventCache.XmlEventType eventType, string s1) { }

	// RVA: 0x1D0C80 Offset: 0x1D0080 VA: 0x1801D0C80
	public void InitEvent(XmlEventCache.XmlEventType eventType, string s1, string s2) { }

	// RVA: 0xF2A70 Offset: 0xF1E70 VA: 0x1800F2A70
	public void InitEvent(XmlEventCache.XmlEventType eventType, string s1, string s2, string s3) { }

	// RVA: 0x1D0C00 Offset: 0x1D0000 VA: 0x1801D0C00
	public void InitEvent(XmlEventCache.XmlEventType eventType, string s1, string s2, string s3, object o) { }

	// RVA: 0x1D0C60 Offset: 0x1D0060 VA: 0x1801D0C60
	public void InitEvent(XmlEventCache.XmlEventType eventType, object o) { }

	// RVA: 0xF3850 Offset: 0xF2C50 VA: 0x1800F3850
	public XmlEventCache.XmlEventType get_EventType() { }

	// RVA: 0xF3DB0 Offset: 0xF31B0 VA: 0x1800F3DB0
	public string get_String1() { }

	// RVA: 0xF3DD0 Offset: 0xF31D0 VA: 0x1800F3DD0
	public string get_String2() { }

	// RVA: 0xF3DE0 Offset: 0xF31E0 VA: 0x1800F3DE0
	public string get_String3() { }

	// RVA: 0xF3860 Offset: 0xF2C60 VA: 0x1800F3860
	public object get_Object() { }

}

public class XmlParserContext // TypeDefIndex: 1885
{	// Fields
	private XmlNameTable _nt; // 0x10
	private XmlNamespaceManager _nsMgr; // 0x18
	private string _docTypeName; // 0x20
	private string _pubId; // 0x28
	private string _sysId; // 0x30
	private string _internalSubset; // 0x38
	private string _xmlLang; // 0x40
	private XmlSpace _xmlSpace; // 0x48
	private string _baseURI; // 0x50
	private Encoding _encoding; // 0x58

	// Properties
	public XmlNameTable NameTable { get; }
	public XmlNamespaceManager NamespaceManager { get; }
	public string DocTypeName { get; }
	public string PublicId { get; }
	public string SystemId { get; }
	public string BaseURI { get; }
	public string InternalSubset { get; }
	public string XmlLang { get; }
	public XmlSpace XmlSpace { get; }
	public Encoding Encoding { get; }
	internal bool HasDtdInfo { get; }

	// Methods

	// RVA: 0xB9AB70 Offset: 0xB99F70 VA: 0x180B9AB70
	public void .ctor(XmlNameTable nt, XmlNamespaceManager nsMgr, string xmlLang, XmlSpace xmlSpace) { }

	// RVA: 0xB9AEF0 Offset: 0xB9A2F0 VA: 0x180B9AEF0
	public void .ctor(XmlNameTable nt, XmlNamespaceManager nsMgr, string docTypeName, string pubId, string sysId, string internalSubset, string baseURI, string xmlLang, XmlSpace xmlSpace) { }

	// RVA: 0xB9AC20 Offset: 0xB9A020 VA: 0x180B9AC20
	public void .ctor(XmlNameTable nt, XmlNamespaceManager nsMgr, string docTypeName, string pubId, string sysId, string internalSubset, string baseURI, string xmlLang, XmlSpace xmlSpace, Encoding enc) { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public XmlNameTable get_NameTable() { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public XmlNamespaceManager get_NamespaceManager() { }

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	public string get_DocTypeName() { }

	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230
	public string get_PublicId() { }

	// RVA: 0x4A2EE0 Offset: 0x4A22E0 VA: 0x1804A2EE0
	public string get_SystemId() { }

	// RVA: 0x4CC350 Offset: 0x4CB750 VA: 0x1804CC350
	public string get_BaseURI() { }

	// RVA: 0x5DCC00 Offset: 0x5DC000 VA: 0x1805DCC00
	public string get_InternalSubset() { }

	// RVA: 0x4B9440 Offset: 0x4B8840 VA: 0x1804B9440
	public string get_XmlLang() { }

	// RVA: 0x5B1C80 Offset: 0x5B1080 VA: 0x1805B1C80
	public XmlSpace get_XmlSpace() { }

	// RVA: 0x4CC340 Offset: 0x4CB740 VA: 0x1804CC340
	public Encoding get_Encoding() { }

	// RVA: 0xB9AF60 Offset: 0xB9A360 VA: 0x180B9AF60
	internal bool get_HasDtdInfo() { }

}

internal abstract class XmlRawWriter : XmlWriter // TypeDefIndex: 1886
{	// Fields
	protected XmlRawWriterBase64Encoder base64Encoder; // 0x18
	protected IXmlNamespaceResolver resolver; // 0x20

	// Properties
	public override WriteState WriteState { get; }
	internal virtual IXmlNamespaceResolver NamespaceResolver { set; }
	internal virtual bool SupportsNamespaceDeclarationInChunks { get; }

	// Methods

	// RVA: 0xB9C5F0 Offset: 0xB9B9F0 VA: 0x180B9C5F0 Slot: 5
	public override void WriteStartDocument() { }

	// RVA: 0xB9C580 Offset: 0xB9B980 VA: 0x180B9C580 Slot: 6
	public override void WriteStartDocument(bool standalone) { }

	// RVA: 0xB9C350 Offset: 0xB9B750 VA: 0x180B9C350 Slot: 7
	public override void WriteEndDocument() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0xB9C3C0 Offset: 0xB9B7C0 VA: 0x180B9C3C0 Slot: 10
	public override void WriteEndElement() { }

	// RVA: 0xB9C480 Offset: 0xB9B880 VA: 0x180B9C480 Slot: 11
	public override void WriteFullEndElement() { }

	// RVA: 0xB9C1A0 Offset: 0xB9B5A0 VA: 0x180B9C1A0 Slot: 25
	public override void WriteBase64(byte[] buffer, int index, int count) { }

	// RVA: 0xB9C0C0 Offset: 0xB9B4C0 VA: 0x180B9C0C0 Slot: 30
	public override string LookupPrefix(string ns) { }

	// RVA: 0xB9C770 Offset: 0xB9BB70 VA: 0x180B9C770 Slot: 27
	public override WriteState get_WriteState() { }

	// RVA: 0xAEA3F0 Offset: 0xAE97F0 VA: 0x180AEA3F0 Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0xB9C260 Offset: 0xB9B660 VA: 0x180B9C260 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0xB9C6B0 Offset: 0xB9BAB0 VA: 0x180B9C6B0 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0xAEA3F0 Offset: 0xAE97F0 VA: 0x180AEA3F0 Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0xB9C2F0 Offset: 0xB9B6F0 VA: 0x180B9C2F0 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0xB9C2F0 Offset: 0xB9B6F0 VA: 0x180B9C2F0 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0xAEA3F0 Offset: 0xAE97F0 VA: 0x180AEA3F0 Slot: 24
	public override void WriteRaw(string data) { }

	// RVA: 0xAEA3F0 Offset: 0xAE97F0 VA: 0x180AEA3F0 Slot: 31
	public override void WriteValue(string value) { }

	// RVA: 0xB9C130 Offset: 0xB9B530 VA: 0x180B9C130 Slot: 32
	public override void WriteAttributes(XmlReader reader, bool defattr) { }

	// RVA: 0xB9C510 Offset: 0xB9B910 VA: 0x180B9C510 Slot: 33
	public override void WriteNode(XmlReader reader, bool defattr) { }

	// RVA: 0x497E30 Offset: 0x497230 VA: 0x180497E30 Slot: 35
	internal virtual void set_NamespaceResolver(IXmlNamespaceResolver value) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 36
	internal virtual void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 37
	internal virtual void WriteXmlDeclaration(string xmldecl) { }

	// RVA: -1 Offset: -1 Slot: 38
	internal abstract void StartElementContent();

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 39
	internal virtual void OnRootElement(ConformanceLevel conformanceLevel) { }

	// RVA: -1 Offset: -1 Slot: 40
	internal abstract void WriteEndElement(string prefix, string localName, string ns);

	// RVA: 0xB9C4F0 Offset: 0xB9B8F0 VA: 0x180B9C4F0 Slot: 41
	internal virtual void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: -1 Offset: -1 Slot: 42
	internal abstract void WriteNamespaceDeclaration(string prefix, string ns);

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 43
	internal virtual bool get_SupportsNamespaceDeclarationInChunks() { }

	// RVA: 0xB9C660 Offset: 0xB9BA60 VA: 0x180B9C660 Slot: 44
	internal virtual void WriteStartNamespaceDeclaration(string prefix) { }

	// RVA: 0xB9C430 Offset: 0xB9B830 VA: 0x180B9C430 Slot: 45
	internal virtual void WriteEndNamespaceDeclaration() { }

	// RVA: 0xB9C330 Offset: 0xB9B730 VA: 0x180B9C330 Slot: 46
	internal virtual void WriteEndBase64() { }

	// RVA: 0xB9C0A0 Offset: 0xB9B4A0 VA: 0x180B9C0A0 Slot: 47
	internal virtual void Close(WriteState currentState) { }

	// RVA: 0x7992B0 Offset: 0x7986B0 VA: 0x1807992B0
	protected void .ctor() { }

}

public abstract class XmlReader : IDisposable // TypeDefIndex: 1887
{	// Fields
	private static uint IsTextualNodeBitmap; // 0x0
	private static uint CanReadContentAsBitmap; // 0x4
	private static uint HasValueBitmap; // 0x8

	// Properties
	public virtual XmlReaderSettings Settings { get; }
	public abstract XmlNodeType NodeType { get; }
	public virtual string Name { get; }
	public abstract string LocalName { get; }
	public abstract string NamespaceURI { get; }
	public abstract string Prefix { get; }
	public abstract string Value { get; }
	public abstract int Depth { get; }
	public abstract string BaseURI { get; }
	public abstract bool IsEmptyElement { get; }
	public virtual bool IsDefault { get; }
	public virtual char QuoteChar { get; }
	public virtual XmlSpace XmlSpace { get; }
	public virtual string XmlLang { get; }
	public virtual IXmlSchemaInfo SchemaInfo { get; }
	public virtual Type ValueType { get; }
	public abstract int AttributeCount { get; }
	public abstract bool EOF { get; }
	public abstract ReadState ReadState { get; }
	public abstract XmlNameTable NameTable { get; }
	public virtual bool CanResolveEntity { get; }
	public virtual bool CanReadValueChunk { get; }
	public virtual bool HasAttributes { get; }
	internal virtual XmlNamespaceManager NamespaceManager { get; }
	internal bool IsDefaultInternal { get; }
	internal virtual IDtdInfo DtdInfo { get; }

	// Methods

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 5
	public virtual XmlReaderSettings get_Settings() { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract XmlNodeType get_NodeType();

	// RVA: 0xB9F9D0 Offset: 0xB9EDD0 VA: 0x180B9F9D0 Slot: 7
	public virtual string get_Name() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract string get_LocalName();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract string get_NamespaceURI();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract string get_Prefix();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract string get_Value();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract int get_Depth();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract string get_BaseURI();

	// RVA: -1 Offset: -1 Slot: 14
	public abstract bool get_IsEmptyElement();

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 15
	public virtual bool get_IsDefault() { }

	// RVA: 0xB9FAD0 Offset: 0xB9EED0 VA: 0x180B9FAD0 Slot: 16
	public virtual char get_QuoteChar() { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 17
	public virtual XmlSpace get_XmlSpace() { }

	// RVA: 0xB9FB80 Offset: 0xB9EF80 VA: 0x180B9FB80 Slot: 18
	public virtual string get_XmlLang() { }

	// RVA: 0xB9FAE0 Offset: 0xB9EEE0 VA: 0x180B9FAE0 Slot: 19
	public virtual IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0xB9FB20 Offset: 0xB9EF20 VA: 0x180B9FB20 Slot: 20
	public virtual Type get_ValueType() { }

	// RVA: -1 Offset: -1 Slot: 21
	public abstract int get_AttributeCount();

	// RVA: -1 Offset: -1 Slot: 22
	public abstract string GetAttribute(string name);

	// RVA: -1 Offset: -1 Slot: 23
	public abstract string GetAttribute(string name, string namespaceURI);

	// RVA: -1 Offset: -1 Slot: 24
	public abstract string GetAttribute(int i);

	// RVA: -1 Offset: -1 Slot: 25
	public abstract bool MoveToAttribute(string name);

	// RVA: 0xB9E2D0 Offset: 0xB9D6D0 VA: 0x180B9E2D0 Slot: 26
	public virtual void MoveToAttribute(int i) { }

	// RVA: -1 Offset: -1 Slot: 27
	public abstract bool MoveToFirstAttribute();

	// RVA: -1 Offset: -1 Slot: 28
	public abstract bool MoveToNextAttribute();

	// RVA: -1 Offset: -1 Slot: 29
	public abstract bool MoveToElement();

	// RVA: -1 Offset: -1 Slot: 30
	public abstract bool ReadAttributeValue();

	// RVA: -1 Offset: -1 Slot: 31
	public abstract bool Read();

	// RVA: -1 Offset: -1 Slot: 32
	public abstract bool get_EOF();

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 33
	public virtual void Close() { }

	// RVA: -1 Offset: -1 Slot: 34
	public abstract ReadState get_ReadState();

	// RVA: 0xB9F190 Offset: 0xB9E590 VA: 0x180B9F190 Slot: 35
	public virtual void Skip() { }

	// RVA: -1 Offset: -1 Slot: 36
	public abstract XmlNameTable get_NameTable();

	// RVA: -1 Offset: -1 Slot: 37
	public abstract string LookupNamespace(string prefix);

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 38
	public virtual bool get_CanResolveEntity() { }

	// RVA: -1 Offset: -1 Slot: 39
	public abstract void ResolveEntity();

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 40
	public virtual bool get_CanReadValueChunk() { }

	// RVA: 0xB9EF30 Offset: 0xB9E330 VA: 0x180B9EF30 Slot: 41
	public virtual int ReadValueChunk(char[] buffer, int index, int count) { }

	[EditorBrowsableAttribute] // RVA: 0x7D5E0 Offset: 0x7C9E0 VA: 0x18007D5E0
	// RVA: 0xB9ED10 Offset: 0xB9E110 VA: 0x180B9ED10 Slot: 42
	public virtual string ReadString() { }

	// RVA: 0xB9E3A0 Offset: 0xB9D7A0 VA: 0x180B9E3A0 Slot: 43
	public virtual XmlNodeType MoveToContent() { }

	// RVA: 0xB9EC10 Offset: 0xB9E010 VA: 0x180B9EC10 Slot: 44
	public virtual void ReadStartElement() { }

	[EditorBrowsableAttribute] // RVA: 0x7D5E0 Offset: 0x7C9E0 VA: 0x18007D5E0
	// RVA: 0xB9E430 Offset: 0xB9D830 VA: 0x180B9E430 Slot: 45
	public virtual string ReadElementString() { }

	// RVA: 0xB9E6B0 Offset: 0xB9DAB0 VA: 0x180B9E6B0 Slot: 46
	public virtual void ReadEndElement() { }

	// RVA: 0xB9E1B0 Offset: 0xB9D5B0 VA: 0x180B9E1B0 Slot: 47
	public virtual bool IsStartElement(string localname, string ns) { }

	// RVA: 0xB9E7B0 Offset: 0xB9DBB0 VA: 0x180B9E7B0 Slot: 48
	public virtual string ReadInnerXml() { }

	// RVA: 0xB9F390 Offset: 0xB9E790 VA: 0x180B9F390
	private void WriteNode(XmlWriter xtw, bool defattr) { }

	// RVA: 0xB9F280 Offset: 0xB9E680 VA: 0x180B9F280
	private void WriteAttributeValue(XmlWriter xtw) { }

	// RVA: 0xB9DD60 Offset: 0xB9D160 VA: 0x180B9DD60
	private XmlWriter CreateWriterForInnerOuterXml(StringWriter sw) { }

	// RVA: 0xB9EFA0 Offset: 0xB9E3A0 VA: 0x180B9EFA0
	private void SetNamespacesFlag(XmlTextWriter xtw) { }

	// RVA: 0xB9F930 Offset: 0xB9ED30 VA: 0x180B9F930 Slot: 49
	public virtual bool get_HasAttributes() { }

	// RVA: 0xB9E0D0 Offset: 0xB9D4D0 VA: 0x180B9E0D0 Slot: 4
	public void Dispose() { }

	// RVA: 0xB9E0F0 Offset: 0xB9D4F0 VA: 0x180B9E0F0 Slot: 50
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 51
	internal virtual XmlNamespaceManager get_NamespaceManager() { }

	// RVA: 0xB9E250 Offset: 0xB9D650 VA: 0x180B9E250
	internal static bool IsTextualNode(XmlNodeType nodeType) { }

	// RVA: 0xB9E130 Offset: 0xB9D530 VA: 0x180B9E130
	internal static bool HasValueInternal(XmlNodeType nodeType) { }

	// RVA: 0xB9F0B0 Offset: 0xB9E4B0 VA: 0x180B9F0B0
	private bool SkipSubtree() { }

	// RVA: 0xB9F950 Offset: 0xB9ED50 VA: 0x180B9F950
	internal bool get_IsDefaultInternal() { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 52
	internal virtual IDtdInfo get_DtdInfo() { }

	// RVA: 0xB9DEA0 Offset: 0xB9D2A0 VA: 0x180B9DEA0
	public static XmlReader Create(Stream input, XmlReaderSettings settings, string baseUri) { }

	// RVA: 0xB9E040 Offset: 0xB9D440 VA: 0x180B9E040
	public static XmlReader Create(TextReader input, XmlReaderSettings settings, string baseUri) { }

	// RVA: 0xB9DA30 Offset: 0xB9CE30 VA: 0x180B9DA30
	internal static XmlReader CreateSqlReader(Stream input, XmlReaderSettings settings, XmlParserContext inputContext) { }

	// RVA: 0xB9D9A0 Offset: 0xB9CDA0 VA: 0x180B9D9A0
	internal static int CalcBufferSize(Stream input) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	protected void .ctor() { }

	// RVA: 0xB9F8C0 Offset: 0xB9ECC0 VA: 0x180B9F8C0
	private static void .cctor() { }

}

public sealed class XmlReaderSettings // TypeDefIndex: 1888
{	// Fields
	private bool useAsync; // 0x10
	private XmlNameTable nameTable; // 0x18
	private XmlResolver xmlResolver; // 0x20
	private int lineNumberOffset; // 0x28
	private int linePositionOffset; // 0x2C
	private ConformanceLevel conformanceLevel; // 0x30
	private bool checkCharacters; // 0x34
	private long maxCharactersInDocument; // 0x38
	private long maxCharactersFromEntities; // 0x40
	private bool ignoreWhitespace; // 0x48
	private bool ignorePIs; // 0x49
	private bool ignoreComments; // 0x4A
	private DtdProcessing dtdProcessing; // 0x4C
	private ValidationType validationType; // 0x50
	private XmlSchemaValidationFlags validationFlags; // 0x54
	private XmlSchemaSet schemas; // 0x58
	private ValidationEventHandler valEventHandler; // 0x60
	private bool closeInput; // 0x68
	private bool isReadOnly; // 0x69
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <IsXmlResolverSet>k__BackingField; // 0x6A
	private static Nullable<bool> s_enableLegacyXmlSettings; // 0x0

	// Properties
	public bool Async { get; set; }
	public XmlNameTable NameTable { get; set; }
	internal bool IsXmlResolverSet { get; set; }
	public XmlResolver XmlResolver { set; }
	public int LineNumberOffset { get; set; }
	public int LinePositionOffset { get; set; }
	public ConformanceLevel ConformanceLevel { get; set; }
	public bool CheckCharacters { get; set; }
	public long MaxCharactersInDocument { get; set; }
	public long MaxCharactersFromEntities { get; set; }
	public bool IgnoreWhitespace { get; set; }
	public bool IgnoreProcessingInstructions { get; set; }
	public bool IgnoreComments { get; set; }
	public DtdProcessing DtdProcessing { get; set; }
	public bool CloseInput { get; set; }
	public ValidationType ValidationType { get; set; }
	public XmlSchemaValidationFlags ValidationFlags { get; set; }
	public XmlSchemaSet Schemas { get; set; }
	internal bool ReadOnly { set; }

	// Methods

	// RVA: 0xB9D140 Offset: 0xB9C540 VA: 0x180B9D140
	public void .ctor() { }

	// RVA: 0x497E20 Offset: 0x497220 VA: 0x180497E20
	public bool get_Async() { }

	// RVA: 0xB9D2C0 Offset: 0xB9C6C0 VA: 0x180B9D2C0
	public void set_Async(bool value) { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public XmlNameTable get_NameTable() { }

	// RVA: 0xB9D770 Offset: 0xB9CB70 VA: 0x180B9D770
	public void set_NameTable(XmlNameTable value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xB9D240 Offset: 0xB9C640 VA: 0x180B9D240
	internal bool get_IsXmlResolverSet() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xB9D5A0 Offset: 0xB9C9A0 VA: 0x180B9D5A0
	internal void set_IsXmlResolverSet(bool value) { }

	// RVA: 0xB9D940 Offset: 0xB9CD40 VA: 0x180B9D940
	public void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	internal XmlResolver GetXmlResolver() { }

	// RVA: 0xB9CF80 Offset: 0xB9C380 VA: 0x180B9CF80
	internal XmlResolver GetXmlResolver_CheckConfig() { }

	// RVA: 0x4BB390 Offset: 0x4BA790 VA: 0x1804BB390
	public int get_LineNumberOffset() { }

	// RVA: 0xB9D5B0 Offset: 0xB9C9B0 VA: 0x180B9D5B0
	public void set_LineNumberOffset(int value) { }

	// RVA: 0x5F7BF0 Offset: 0x5F6FF0 VA: 0x1805F7BF0
	public int get_LinePositionOffset() { }

	// RVA: 0xB9D600 Offset: 0xB9CA00 VA: 0x180B9D600
	public void set_LinePositionOffset(int value) { }

	// RVA: 0xA178C0 Offset: 0xA16CC0 VA: 0x180A178C0
	public ConformanceLevel get_ConformanceLevel() { }

	// RVA: 0xB9D3B0 Offset: 0xB9C7B0 VA: 0x180B9D3B0
	public void set_ConformanceLevel(ConformanceLevel value) { }

	// RVA: 0xB9D210 Offset: 0xB9C610 VA: 0x180B9D210
	public bool get_CheckCharacters() { }

	// RVA: 0xB9D310 Offset: 0xB9C710 VA: 0x180B9D310
	public void set_CheckCharacters(bool value) { }

	// RVA: 0x5DCC00 Offset: 0x5DC000 VA: 0x1805DCC00
	public long get_MaxCharactersInDocument() { }

	// RVA: 0xB9D6E0 Offset: 0xB9CAE0 VA: 0x180B9D6E0
	public void set_MaxCharactersInDocument(long value) { }

	// RVA: 0x4B9440 Offset: 0x4B8840 VA: 0x1804B9440
	public long get_MaxCharactersFromEntities() { }

	// RVA: 0xB9D650 Offset: 0xB9CA50 VA: 0x180B9D650
	public void set_MaxCharactersFromEntities(long value) { }

	// RVA: 0x4B9270 Offset: 0x4B8670 VA: 0x1804B9270
	public bool get_IgnoreWhitespace() { }

	// RVA: 0xB9D550 Offset: 0xB9C950 VA: 0x180B9D550
	public void set_IgnoreWhitespace(bool value) { }

	// RVA: 0xB9D230 Offset: 0xB9C630 VA: 0x180B9D230
	public bool get_IgnoreProcessingInstructions() { }

	// RVA: 0xB9D500 Offset: 0xB9C900 VA: 0x180B9D500
	public void set_IgnoreProcessingInstructions(bool value) { }

	// RVA: 0xB9D220 Offset: 0xB9C620 VA: 0x180B9D220
	public bool get_IgnoreComments() { }

	// RVA: 0xB9D4B0 Offset: 0xB9C8B0 VA: 0x180B9D4B0
	public void set_IgnoreComments(bool value) { }

	// RVA: 0x5B35A0 Offset: 0x5B29A0 VA: 0x1805B35A0
	public DtdProcessing get_DtdProcessing() { }

	// RVA: 0xB9D430 Offset: 0xB9C830 VA: 0x180B9D430
	public void set_DtdProcessing(DtdProcessing value) { }

	// RVA: 0x82A660 Offset: 0x829A60 VA: 0x18082A660
	public bool get_CloseInput() { }

	// RVA: 0xB9D360 Offset: 0xB9C760 VA: 0x180B9D360
	public void set_CloseInput(bool value) { }

	// RVA: 0x8C8B80 Offset: 0x8C7F80 VA: 0x1808C8B80
	public ValidationType get_ValidationType() { }

	// RVA: 0xB9D8C0 Offset: 0xB9CCC0 VA: 0x180B9D8C0
	public void set_ValidationType(ValidationType value) { }

	// RVA: 0x5F8160 Offset: 0x5F7560 VA: 0x1805F8160
	public XmlSchemaValidationFlags get_ValidationFlags() { }

	// RVA: 0xB9D840 Offset: 0xB9CC40 VA: 0x180B9D840
	public void set_ValidationFlags(XmlSchemaValidationFlags value) { }

	// RVA: 0xB9D250 Offset: 0xB9C650 VA: 0x180B9D250
	public XmlSchemaSet get_Schemas() { }

	// RVA: 0xB9D7E0 Offset: 0xB9CBE0 VA: 0x180B9D7E0
	public void set_Schemas(XmlSchemaSet value) { }

	// RVA: 0xB9C9C0 Offset: 0xB9BDC0 VA: 0x180B9C9C0
	public XmlReaderSettings Clone() { }

	// RVA: 0x54FB60 Offset: 0x54EF60 VA: 0x18054FB60
	internal ValidationEventHandler GetEventHandler() { }

	// RVA: 0xB9CB00 Offset: 0xB9BF00 VA: 0x180B9CB00
	internal XmlReader CreateReader(Stream input, Uri baseUri, string baseUriString, XmlParserContext inputContext) { }

	// RVA: 0xB9CC80 Offset: 0xB9C080 VA: 0x180B9CC80
	internal XmlReader CreateReader(TextReader input, string baseUriString, XmlParserContext inputContext) { }

	// RVA: 0xB9D7D0 Offset: 0xB9CBD0 VA: 0x180B9D7D0
	internal void set_ReadOnly(bool value) { }

	// RVA: 0xB9C910 Offset: 0xB9BD10 VA: 0x180B9C910
	private void CheckReadOnly(string propertyName) { }

	// RVA: 0xB9D080 Offset: 0xB9C480 VA: 0x180B9D080
	private void Initialize() { }

	// RVA: 0xB9CFB0 Offset: 0xB9C3B0 VA: 0x180B9CFB0
	private void Initialize(XmlResolver resolver) { }

	// RVA: 0xB9CA20 Offset: 0xB9BE20 VA: 0x180B9CA20
	private static XmlResolver CreateDefaultResolver() { }

	// RVA: 0xB9C7E0 Offset: 0xB9BBE0 VA: 0x180B9C7E0
	internal XmlReader AddValidation(XmlReader reader) { }

	// RVA: 0xB9CA70 Offset: 0xB9BE70 VA: 0x180B9CA70
	private XmlValidatingReaderImpl CreateDtdValidatingReader(XmlReader baseReader) { }

	// RVA: 0xB9CE70 Offset: 0xB9C270 VA: 0x180B9CE70
	internal static bool EnableLegacyXmlSettings() { }

}

public enum XmlSpace // TypeDefIndex: 1889
{	// Fields
	public int value__; // 0x0
	public const XmlSpace None = 0;
	public const XmlSpace Default = 1;
	public const XmlSpace Preserve = 2;

}

internal class XmlTextEncoder // TypeDefIndex: 1890
{	// Fields
	private TextWriter textWriter; // 0x10
	private bool inAttribute; // 0x18
	private char quoteChar; // 0x1A
	private StringBuilder attrValue; // 0x20
	private bool cacheAttrValue; // 0x28
	private XmlCharType xmlCharType; // 0x30

	// Properties
	internal char QuoteChar { set; }
	internal string AttributeValue { get; }

	// Methods

	// RVA: 0xBAD850 Offset: 0xBACC50 VA: 0x180BAD850
	internal void .ctor(TextWriter textWriter) { }

	// RVA: 0xBAD910 Offset: 0xBACD10 VA: 0x180BAD910
	internal void set_QuoteChar(char value) { }

	// RVA: 0xBAC290 Offset: 0xBAB690 VA: 0x180BAC290
	internal void StartAttribute(bool cacheAttrValue) { }

	// RVA: 0xBAC250 Offset: 0xBAB650 VA: 0x180BAC250
	internal void EndAttribute() { }

	// RVA: 0xBAD8A0 Offset: 0xBACCA0 VA: 0x180BAD8A0
	internal string get_AttributeValue() { }

	// RVA: 0xBACC40 Offset: 0xBAC040 VA: 0x180BACC40
	internal void WriteSurrogateChar(char lowChar, char highChar) { }

	// RVA: 0xBACD20 Offset: 0xBAC120 VA: 0x180BACD20
	internal void Write(char[] array, int offset, int count) { }

	// RVA: 0xBACAC0 Offset: 0xBABEC0 VA: 0x180BACAC0
	internal void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0xBAD220 Offset: 0xBAC620 VA: 0x180BAD220
	internal void Write(string text) { }

	// RVA: 0xBAC640 Offset: 0xBABA40 VA: 0x180BAC640
	internal void WriteRawWithSurrogateChecking(string text) { }

	// RVA: 0xBAC860 Offset: 0xBABC60 VA: 0x180BAC860
	internal void WriteRaw(char[] array, int offset, int count) { }

	// RVA: 0xBAC430 Offset: 0xBAB830 VA: 0x180BAC430
	internal void WriteCharEntity(char ch) { }

	// RVA: 0xBAC5C0 Offset: 0xBAB9C0 VA: 0x180BAC5C0
	internal void WriteEntityRef(string name) { }

	// RVA: 0xBACA00 Offset: 0xBABE00 VA: 0x180BACA00
	private void WriteStringFragment(string str, int offset, int count, char[] helperBuffer) { }

	// RVA: 0xBAC3C0 Offset: 0xBAB7C0 VA: 0x180BAC3C0
	private void WriteCharEntityImpl(char ch) { }

	// RVA: 0xBAC320 Offset: 0xBAB720 VA: 0x180BAC320
	private void WriteCharEntityImpl(string strVal) { }

	// RVA: 0xBAC540 Offset: 0xBAB940 VA: 0x180BAC540
	private void WriteEntityRefImpl(string name) { }

}

public class XmlTextReader : XmlReader, IXmlLineInfo, IXmlNamespaceResolver // TypeDefIndex: 1891
{	// Fields
	private XmlTextReaderImpl impl; // 0x10

	// Properties
	public override XmlNodeType NodeType { get; }
	public override string Name { get; }
	public override string LocalName { get; }
	public override string NamespaceURI { get; }
	public override string Prefix { get; }
	public override string Value { get; }
	public override int Depth { get; }
	public override string BaseURI { get; }
	public override bool IsEmptyElement { get; }
	public override bool IsDefault { get; }
	public override char QuoteChar { get; }
	public override XmlSpace XmlSpace { get; }
	public override string XmlLang { get; }
	public override int AttributeCount { get; }
	public override bool EOF { get; }
	public override ReadState ReadState { get; }
	public override XmlNameTable NameTable { get; }
	public override bool CanResolveEntity { get; }
	public override bool CanReadValueChunk { get; }
	public int LineNumber { get; }
	public int LinePosition { get; }
	public bool Namespaces { get; }
	public bool Normalization { get; set; }
	public WhitespaceHandling WhitespaceHandling { set; }
	public EntityHandling EntityHandling { set; }
	public XmlResolver XmlResolver { set; }
	internal XmlTextReaderImpl Impl { get; }
	internal override XmlNamespaceManager NamespaceManager { get; }
	internal bool XmlValidatingReaderCompatibilityMode { set; }
	internal override IDtdInfo DtdInfo { get; }

	// Methods

	// RVA: 0xBC3F80 Offset: 0xBC3380 VA: 0x180BC3F80
	public void .ctor(Stream input) { }

	// RVA: 0xBC3DA0 Offset: 0xBC31A0 VA: 0x180BC3DA0
	public void .ctor(string url, Stream input, XmlNameTable nt) { }

	// RVA: 0xBC3C80 Offset: 0xBC3080 VA: 0x180BC3C80
	public void .ctor(TextReader input) { }

	// RVA: 0xBC3E80 Offset: 0xBC3280 VA: 0x180BC3E80
	public void .ctor(TextReader input, XmlNameTable nt) { }

	// RVA: 0xB14680 Offset: 0xB13A80 VA: 0x180B14680 Slot: 6
	public override XmlNodeType get_NodeType() { }

	// RVA: 0xBC4280 Offset: 0xBC3680 VA: 0x180BC4280 Slot: 7
	public override string get_Name() { }

	// RVA: 0xBC4220 Offset: 0xBC3620 VA: 0x180BC4220 Slot: 8
	public override string get_LocalName() { }

	// RVA: 0xBC42E0 Offset: 0xBC36E0 VA: 0x180BC42E0 Slot: 9
	public override string get_NamespaceURI() { }

	// RVA: 0xBC4350 Offset: 0xBC3750 VA: 0x180BC4350 Slot: 10
	public override string get_Prefix() { }

	// RVA: 0xBC43B0 Offset: 0xBC37B0 VA: 0x180BC43B0 Slot: 11
	public override string get_Value() { }

	// RVA: 0xBC40D0 Offset: 0xBC34D0 VA: 0x180BC40D0 Slot: 12
	public override int get_Depth() { }

	// RVA: 0xBC40A0 Offset: 0xBC34A0 VA: 0x180BC40A0 Slot: 13
	public override string get_BaseURI() { }

	// RVA: 0xBC4190 Offset: 0xBC3590 VA: 0x180BC4190 Slot: 14
	public override bool get_IsEmptyElement() { }

	// RVA: 0xBC4160 Offset: 0xBC3560 VA: 0x180BC4160 Slot: 15
	public override bool get_IsDefault() { }

	// RVA: 0xBC4380 Offset: 0xBC3780 VA: 0x180BC4380 Slot: 16
	public override char get_QuoteChar() { }

	// RVA: 0xBC4410 Offset: 0xBC3810 VA: 0x180BC4410 Slot: 17
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0xBC43E0 Offset: 0xBC37E0 VA: 0x180BC43E0 Slot: 18
	public override string get_XmlLang() { }

	// RVA: 0xB147D0 Offset: 0xB13BD0 VA: 0x180B147D0 Slot: 21
	public override int get_AttributeCount() { }

	// RVA: 0xBC3920 Offset: 0xBC2D20 VA: 0x180BC3920 Slot: 22
	public override string GetAttribute(string name) { }

	// RVA: 0xBC3950 Offset: 0xBC2D50 VA: 0x180BC3950 Slot: 23
	public override string GetAttribute(string localName, string namespaceURI) { }

	// RVA: 0xBC3980 Offset: 0xBC2D80 VA: 0x180BC3980 Slot: 24
	public override string GetAttribute(int i) { }

	// RVA: 0xBC3A20 Offset: 0xBC2E20 VA: 0x180BC3A20 Slot: 25
	public override bool MoveToAttribute(string name) { }

	// RVA: 0xBC39F0 Offset: 0xBC2DF0 VA: 0x180BC39F0 Slot: 26
	public override void MoveToAttribute(int i) { }

	// RVA: 0xBC3A80 Offset: 0xBC2E80 VA: 0x180BC3A80 Slot: 27
	public override bool MoveToFirstAttribute() { }

	// RVA: 0xBC3AB0 Offset: 0xBC2EB0 VA: 0x180BC3AB0 Slot: 28
	public override bool MoveToNextAttribute() { }

	// RVA: 0xBC3A50 Offset: 0xBC2E50 VA: 0x180BC3A50 Slot: 29
	public override bool MoveToElement() { }

	// RVA: 0xBC3AE0 Offset: 0xBC2EE0 VA: 0x180BC3AE0 Slot: 30
	public override bool ReadAttributeValue() { }

	// RVA: 0xBC3B40 Offset: 0xBC2F40 VA: 0x180BC3B40 Slot: 31
	public override bool Read() { }

	// RVA: 0xBC4130 Offset: 0xBC3530 VA: 0x180BC4130 Slot: 32
	public override bool get_EOF() { }

	// RVA: 0xB9A5D0 Offset: 0xB999D0 VA: 0x180B9A5D0 Slot: 33
	public override void Close() { }

	// RVA: 0xB9A640 Offset: 0xB99A40 VA: 0x180B9A640 Slot: 34
	public override ReadState get_ReadState() { }

	// RVA: 0xBC3BA0 Offset: 0xBC2FA0 VA: 0x180BC3BA0 Slot: 35
	public override void Skip() { }

	// RVA: 0xBC4250 Offset: 0xBC3650 VA: 0x180BC4250 Slot: 36
	public override XmlNameTable get_NameTable() { }

	// RVA: 0xBC39B0 Offset: 0xBC2DB0 VA: 0x180BC39B0 Slot: 37
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 38
	public override bool get_CanResolveEntity() { }

	// RVA: 0xBC3B70 Offset: 0xBC2F70 VA: 0x180BC3B70 Slot: 39
	public override void ResolveEntity() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 40
	public override bool get_CanReadValueChunk() { }

	// RVA: 0xBC3B10 Offset: 0xBC2F10 VA: 0x180BC3B10 Slot: 42
	public override string ReadString() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 53
	public bool HasLineInfo() { }

	// RVA: 0xBC41C0 Offset: 0xBC35C0 VA: 0x180BC41C0 Slot: 54
	public int get_LineNumber() { }

	// RVA: 0xBC41F0 Offset: 0xBC35F0 VA: 0x180BC41F0 Slot: 55
	public int get_LinePosition() { }

	// RVA: 0xBC3BD0 Offset: 0xBC2FD0 VA: 0x180BC3BD0 Slot: 56
	private IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0xBC3C10 Offset: 0xBC3010 VA: 0x180BC3C10 Slot: 57
	private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0xBC3C40 Offset: 0xBC3040 VA: 0x180BC3C40 Slot: 58
	private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

	// RVA: 0xBC4310 Offset: 0xBC3710 VA: 0x180BC4310
	public bool get_Namespaces() { }

	// RVA: 0xBC4330 Offset: 0xBC3730 VA: 0x180BC4330
	public bool get_Normalization() { }

	// RVA: 0xBC44E0 Offset: 0xBC38E0 VA: 0x180BC44E0
	public void set_Normalization(bool value) { }

	// RVA: 0xBC45A0 Offset: 0xBC39A0 VA: 0x180BC45A0
	public void set_WhitespaceHandling(WhitespaceHandling value) { }

	// RVA: 0xBC4440 Offset: 0xBC3840 VA: 0x180BC4440
	public void set_EntityHandling(EntityHandling value) { }

	// RVA: 0xBC4680 Offset: 0xBC3A80 VA: 0x180BC4680
	public void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	internal XmlTextReaderImpl get_Impl() { }

	// RVA: 0xBC42B0 Offset: 0xBC36B0 VA: 0x180BC42B0 Slot: 51
	internal override XmlNamespaceManager get_NamespaceManager() { }

	// RVA: 0xBC4730 Offset: 0xBC3B30 VA: 0x180BC4730
	internal void set_XmlValidatingReaderCompatibilityMode(bool value) { }

	// RVA: 0xBC4100 Offset: 0xBC3500 VA: 0x180BC4100 Slot: 52
	internal override IDtdInfo get_DtdInfo() { }

}

internal class XmlTextReaderImpl : XmlReader, IXmlLineInfo, IXmlNamespaceResolver // TypeDefIndex: 1892
{	// Fields
	private readonly bool useAsync; // 0x10
	private XmlTextReaderImpl.LaterInitParam laterInitParam; // 0x18
	private XmlCharType xmlCharType; // 0x20
	private XmlTextReaderImpl.ParsingState ps; // 0x28
	private XmlTextReaderImpl.ParsingFunction parsingFunction; // 0xA0
	private XmlTextReaderImpl.ParsingFunction nextParsingFunction; // 0xA4
	private XmlTextReaderImpl.ParsingFunction nextNextParsingFunction; // 0xA8
	private XmlTextReaderImpl.NodeData[] nodes; // 0xB0
	private XmlTextReaderImpl.NodeData curNode; // 0xB8
	private int index; // 0xC0
	private int curAttrIndex; // 0xC4
	private int attrCount; // 0xC8
	private int attrHashtable; // 0xCC
	private int attrDuplWalkCount; // 0xD0
	private bool attrNeedNamespaceLookup; // 0xD4
	private bool fullAttrCleanup; // 0xD5
	private XmlTextReaderImpl.NodeData[] attrDuplSortingArray; // 0xD8
	private XmlNameTable nameTable; // 0xE0
	private bool nameTableFromSettings; // 0xE8
	private XmlResolver xmlResolver; // 0xF0
	private string url; // 0xF8
	private bool normalize; // 0x100
	private bool supportNamespaces; // 0x101
	private WhitespaceHandling whitespaceHandling; // 0x104
	private DtdProcessing dtdProcessing; // 0x108
	private EntityHandling entityHandling; // 0x10C
	private bool ignorePIs; // 0x110
	private bool ignoreComments; // 0x111
	private bool checkCharacters; // 0x112
	private int lineNumberOffset; // 0x114
	private int linePositionOffset; // 0x118
	private bool closeInput; // 0x11C
	private long maxCharactersInDocument; // 0x120
	private long maxCharactersFromEntities; // 0x128
	private bool v1Compat; // 0x130
	private XmlNamespaceManager namespaceManager; // 0x138
	private string lastPrefix; // 0x140
	private XmlTextReaderImpl.XmlContext xmlContext; // 0x148
	private XmlTextReaderImpl.ParsingState[] parsingStatesStack; // 0x150
	private int parsingStatesStackTop; // 0x158
	private string reportedBaseUri; // 0x160
	private Encoding reportedEncoding; // 0x168
	private IDtdInfo dtdInfo; // 0x170
	private XmlNodeType fragmentType; // 0x178
	private XmlParserContext fragmentParserContext; // 0x180
	private bool fragment; // 0x188
	private IncrementalReadDecoder incReadDecoder; // 0x190
	private XmlTextReaderImpl.IncrementalReadState incReadState; // 0x198
	private LineInfo incReadLineInfo; // 0x19C
	private int incReadDepth; // 0x1A4
	private int incReadLeftStartPos; // 0x1A8
	private int incReadLeftEndPos; // 0x1AC
	private int attributeValueBaseEntityId; // 0x1B0
	private bool emptyEntityInAttributeResolved; // 0x1B4
	private IValidationEventHandling validationEventHandling; // 0x1B8
	private XmlTextReaderImpl.OnDefaultAttributeUseDelegate onDefaultAttributeUse; // 0x1C0
	private bool validatingReaderCompatFlag; // 0x1C8
	private bool addDefaultAttributesAndNormalize; // 0x1C9
	private StringBuilder stringBuilder; // 0x1D0
	private bool rootElementParsed; // 0x1D8
	private bool standalone; // 0x1D9
	private int nextEntityId; // 0x1DC
	private XmlTextReaderImpl.ParsingMode parsingMode; // 0x1E0
	private ReadState readState; // 0x1E4
	private IDtdEntityInfo lastEntity; // 0x1E8
	private bool afterResetState; // 0x1F0
	private int documentStartBytePos; // 0x1F4
	private int readValueOffset; // 0x1F8
	private long charactersInDocument; // 0x200
	private long charactersFromEntities; // 0x208
	private Dictionary<IDtdEntityInfo, IDtdEntityInfo> currentEntities; // 0x210
	private bool disableUndeclaredEntityCheck; // 0x218
	private XmlReader outerReader; // 0x220
	private bool xmlResolverIsSet; // 0x228
	private string Xml; // 0x230
	private string XmlNs; // 0x238
	private Task<Tuple<int, int, int, bool>> parseText_dummyTask; // 0x240

	// Properties
	public override XmlReaderSettings Settings { get; }
	public override XmlNodeType NodeType { get; }
	public override string Name { get; }
	public override string LocalName { get; }
	public override string NamespaceURI { get; }
	public override string Prefix { get; }
	public override string Value { get; }
	public override int Depth { get; }
	public override string BaseURI { get; }
	public override bool IsEmptyElement { get; }
	public override bool IsDefault { get; }
	public override char QuoteChar { get; }
	public override XmlSpace XmlSpace { get; }
	public override string XmlLang { get; }
	public override ReadState ReadState { get; }
	public override bool EOF { get; }
	public override XmlNameTable NameTable { get; }
	public override bool CanResolveEntity { get; }
	public override int AttributeCount { get; }
	internal XmlReader OuterReader { set; }
	public override bool CanReadValueChunk { get; }
	public int LineNumber { get; }
	public int LinePosition { get; }
	internal bool Namespaces { get; set; }
	internal bool Normalization { get; set; }
	internal WhitespaceHandling WhitespaceHandling { set; }
	internal EntityHandling EntityHandling { set; }
	internal bool IsResolverSet { get; }
	internal XmlResolver XmlResolver { set; }
	internal XmlNameTable DtdParserProxy_NameTable { get; }
	internal IXmlNamespaceResolver DtdParserProxy_NamespaceResolver { get; }
	internal bool DtdParserProxy_DtdValidation { get; }
	internal bool DtdParserProxy_Normalization { get; }
	internal bool DtdParserProxy_Namespaces { get; }
	internal bool DtdParserProxy_V1CompatibilityMode { get; }
	internal Uri DtdParserProxy_BaseUri { get; }
	internal bool DtdParserProxy_IsEof { get; }
	internal char[] DtdParserProxy_ParsingBuffer { get; }
	internal int DtdParserProxy_ParsingBufferLength { get; }
	internal int DtdParserProxy_CurrentPosition { get; set; }
	internal int DtdParserProxy_EntityStackLength { get; }
	internal bool DtdParserProxy_IsEntityEolNormalized { get; }
	internal IValidationEventHandling DtdParserProxy_ValidationEventHandling { get; }
	internal int DtdParserProxy_LineNo { get; }
	internal int DtdParserProxy_LineStartPosition { get; }
	private bool IsResolverNull { get; }
	private bool InAttributeValueIterator { get; }
	private bool DtdValidation { get; }
	private bool InEntity { get; }
	internal override IDtdInfo DtdInfo { get; }
	internal IValidationEventHandling ValidationEventHandling { set; }
	internal XmlTextReaderImpl.OnDefaultAttributeUseDelegate OnDefaultAttributeUse { set; }
	internal bool XmlValidatingReaderCompatibilityMode { set; }
	internal XmlNodeType FragmentType { get; }
	internal object InternalSchemaType { set; }
	internal object InternalTypedValue { get; set; }
	internal bool StandAlone { get; }
	internal override XmlNamespaceManager NamespaceManager { get; }
	internal bool V1Compat { get; }
	internal bool DisableUndeclaredEntityCheck { set; }

	// Methods

	// RVA: 0xBC1500 Offset: 0xBC0900 VA: 0x180BC1500
	internal void .ctor(XmlNameTable nt) { }

	// RVA: 0xBC1ED0 Offset: 0xBC12D0 VA: 0x180BC1ED0
	private void .ctor(XmlResolver resolver, XmlReaderSettings settings, XmlParserContext context) { }

	// RVA: 0xBC1AD0 Offset: 0xBC0ED0 VA: 0x180BC1AD0
	internal void .ctor(Stream input) { }

	// RVA: 0xBC1CA0 Offset: 0xBC10A0 VA: 0x180BC1CA0
	internal void .ctor(string url, Stream input, XmlNameTable nt) { }

	// RVA: 0xBC1A40 Offset: 0xBC0E40 VA: 0x180BC1A40
	internal void .ctor(TextReader input) { }

	// RVA: 0xBC2400 Offset: 0xBC1800 VA: 0x180BC2400
	internal void .ctor(TextReader input, XmlNameTable nt) { }

	// RVA: 0xBC2820 Offset: 0xBC1C20 VA: 0x180BC2820
	internal void .ctor(string url, TextReader input, XmlNameTable nt) { }

	// RVA: 0xBC1910 Offset: 0xBC0D10 VA: 0x180BC1910
	internal void .ctor(string xmlFragment, XmlNodeType fragType, XmlParserContext context) { }

	// RVA: 0xBC1DC0 Offset: 0xBC11C0 VA: 0x180BC1DC0
	internal void .ctor(string xmlFragment, XmlParserContext context) { }

	// RVA: 0xBB0D80 Offset: 0xBB0180 VA: 0x180BB0D80
	private void FinishInitUriString() { }

	// RVA: 0xBC2470 Offset: 0xBC1870 VA: 0x180BC2470
	internal void .ctor(Stream stream, byte[] bytes, int byteCount, XmlReaderSettings settings, Uri baseUri, string baseUriStr, XmlParserContext context, bool closeInput) { }

	// RVA: 0xBB0C00 Offset: 0xBB0000 VA: 0x180BB0C00
	private void FinishInitStream() { }

	// RVA: 0xBC1B60 Offset: 0xBC0F60 VA: 0x180BC1B60
	internal void .ctor(TextReader input, XmlReaderSettings settings, string baseUriStr, XmlParserContext context) { }

	// RVA: 0xBB0CD0 Offset: 0xBB00D0 VA: 0x180BB0CD0
	private void FinishInitTextReader() { }

	// RVA: 0xBC2760 Offset: 0xBC1B60 VA: 0x180BC2760
	internal void .ctor(string xmlFragment, XmlParserContext context, XmlReaderSettings settings) { }

	// RVA: 0xBC2CF0 Offset: 0xBC20F0 VA: 0x180BC2CF0 Slot: 5
	public override XmlReaderSettings get_Settings() { }

	// RVA: 0xBC2C70 Offset: 0xBC2070 VA: 0x180BC2C70 Slot: 6
	public override XmlNodeType get_NodeType() { }

	// RVA: 0xBC2C20 Offset: 0xBC2020 VA: 0x180BC2C20 Slot: 7
	public override string get_Name() { }

	// RVA: 0xBC2C00 Offset: 0xBC2000 VA: 0x180BC2C00 Slot: 8
	public override string get_LocalName() { }

	// RVA: 0xBC2C50 Offset: 0xBC2050 VA: 0x180BC2C50 Slot: 9
	public override string get_NamespaceURI() { }

	// RVA: 0xBC2C90 Offset: 0xBC2090 VA: 0x180BC2C90 Slot: 10
	public override string get_Prefix() { }

	// RVA: 0xBC3120 Offset: 0xBC2520 VA: 0x180BC3120 Slot: 11
	public override string get_Value() { }

	// RVA: 0xBC2920 Offset: 0xBC1D20 VA: 0x180BC2920 Slot: 12
	public override int get_Depth() { }

	// RVA: 0x7FEF40 Offset: 0x7FE340 VA: 0x1807FEF40 Slot: 13
	public override string get_BaseURI() { }

	// RVA: 0xBC2B20 Offset: 0xBC1F20 VA: 0x180BC2B20 Slot: 14
	public override bool get_IsEmptyElement() { }

	// RVA: 0xBC2AF0 Offset: 0xBC1EF0 VA: 0x180BC2AF0 Slot: 15
	public override bool get_IsDefault() { }

	// RVA: 0xBC2CB0 Offset: 0xBC20B0 VA: 0x180BC2CB0 Slot: 16
	public override char get_QuoteChar() { }

	// RVA: 0xBC32B0 Offset: 0xBC26B0 VA: 0x180BC32B0 Slot: 17
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0xBC3290 Offset: 0xBC2690 VA: 0x180BC3290 Slot: 18
	public override string get_XmlLang() { }

	// RVA: 0xBC2CE0 Offset: 0xBC20E0 VA: 0x180BC2CE0 Slot: 34
	public override ReadState get_ReadState() { }

	// RVA: 0xBC2A80 Offset: 0xBC1E80 VA: 0x180BC2A80 Slot: 32
	public override bool get_EOF() { }

	// RVA: 0x4EBD40 Offset: 0x4EB140 VA: 0x1804EBD40 Slot: 36
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 38
	public override bool get_CanResolveEntity() { }

	// RVA: 0xADE1D0 Offset: 0xADD5D0 VA: 0x180ADE1D0 Slot: 21
	public override int get_AttributeCount() { }

	// RVA: 0xBB1940 Offset: 0xBB0D40 VA: 0x180BB1940 Slot: 22
	public override string GetAttribute(string name) { }

	// RVA: 0xBB1780 Offset: 0xBB0B80 VA: 0x180BB1780 Slot: 23
	public override string GetAttribute(string localName, string namespaceURI) { }

	// RVA: 0xBB16C0 Offset: 0xBB0AC0 VA: 0x180BB16C0 Slot: 24
	public override string GetAttribute(int i) { }

	// RVA: 0xBB3F80 Offset: 0xBB3380 VA: 0x180BB3F80 Slot: 25
	public override bool MoveToAttribute(string name) { }

	// RVA: 0xBB4050 Offset: 0xBB3450 VA: 0x180BB4050 Slot: 26
	public override void MoveToAttribute(int i) { }

	// RVA: 0xBB41D0 Offset: 0xBB35D0 VA: 0x180BB41D0 Slot: 27
	public override bool MoveToFirstAttribute() { }

	// RVA: 0xBB4260 Offset: 0xBB3660 VA: 0x180BB4260 Slot: 28
	public override bool MoveToNextAttribute() { }

	// RVA: 0xBB4130 Offset: 0xBB3530 VA: 0x180BB4130 Slot: 29
	public override bool MoveToElement() { }

	// RVA: 0xBB10D0 Offset: 0xBB04D0 VA: 0x180BB10D0
	private void FinishInit() { }

	// RVA: 0xBBDDA0 Offset: 0xBBD1A0 VA: 0x180BBDDA0 Slot: 31
	public override bool Read() { }

	// RVA: 0xBAF9E0 Offset: 0xBAEDE0 VA: 0x180BAF9E0 Slot: 33
	public override void Close() { }

	// RVA: 0xBBFC40 Offset: 0xBBF040 VA: 0x180BBFC40 Slot: 35
	public override void Skip() { }

	// RVA: 0xBB3E40 Offset: 0xBB3240 VA: 0x180BB3E40 Slot: 37
	public override string LookupNamespace(string prefix) { }

	// RVA: 0xBBD070 Offset: 0xBBC470 VA: 0x180BBD070 Slot: 30
	public override bool ReadAttributeValue() { }

	// RVA: 0xBBE750 Offset: 0xBBDB50 VA: 0x180BBE750 Slot: 39
	public override void ResolveEntity() { }

	// RVA: 0xBC36B0 Offset: 0xBC2AB0 VA: 0x180BC36B0
	internal void set_OuterReader(XmlReader value) { }

	// RVA: 0xBB3EB0 Offset: 0xBB32B0 VA: 0x180BB3EB0
	internal void MoveOffEntityReference() { }

	// RVA: 0xBBD870 Offset: 0xBBCC70 VA: 0x180BBD870 Slot: 42
	public override string ReadString() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 40
	public override bool get_CanReadValueChunk() { }

	// RVA: 0xBBD890 Offset: 0xBBCC90 VA: 0x180BBD890 Slot: 41
	public override int ReadValueChunk(char[] buffer, int index, int count) { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 53
	public bool HasLineInfo() { }

	// RVA: 0xBC2BA0 Offset: 0xBC1FA0 VA: 0x180BC2BA0 Slot: 54
	public int get_LineNumber() { }

	// RVA: 0xBC2BD0 Offset: 0xBC1FD0 VA: 0x180BC2BD0 Slot: 55
	public int get_LinePosition() { }

	// RVA: 0xBB1CF0 Offset: 0xBB10F0 VA: 0x180BB1CF0 Slot: 56
	private IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0xBC0370 Offset: 0xBBF770 VA: 0x180BC0370 Slot: 57
	private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0xBB3E80 Offset: 0xBB3280 VA: 0x180BB3E80 Slot: 58
	private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

	// RVA: 0xBB1CF0 Offset: 0xBB10F0 VA: 0x180BB1CF0
	internal IDictionary<string, string> GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0xBB3E80 Offset: 0xBB3280 VA: 0x180BB3E80
	internal string LookupPrefix(string namespaceName) { }

	// RVA: 0xBC2A50 Offset: 0xBC1E50 VA: 0x180BC2A50
	internal bool get_Namespaces() { }

	// RVA: 0xBC33D0 Offset: 0xBC27D0 VA: 0x180BC33D0
	internal void set_Namespaces(bool value) { }

	// RVA: 0xBC2A60 Offset: 0xBC1E60 VA: 0x180BC2A60
	internal bool get_Normalization() { }

	// RVA: 0xBC35F0 Offset: 0xBC29F0 VA: 0x180BC35F0
	internal void set_Normalization(bool value) { }

	// RVA: 0xBC36D0 Offset: 0xBC2AD0 VA: 0x180BC36D0
	internal void set_WhitespaceHandling(WhitespaceHandling value) { }

	// RVA: 0xBC32E0 Offset: 0xBC26E0 VA: 0x180BC32E0
	internal void set_EntityHandling(EntityHandling value) { }

	// RVA: 0xBC2B90 Offset: 0xBC1F90 VA: 0x180BC2B90
	internal bool get_IsResolverSet() { }

	// RVA: 0xBC37B0 Offset: 0xBC2BB0 VA: 0x180BC37B0
	internal void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x4EBD40 Offset: 0x4EB140 VA: 0x1804EBD40
	internal XmlNameTable get_DtdParserProxy_NameTable() { }

	// RVA: 0xBC2A40 Offset: 0xBC1E40 VA: 0x180BC2A40
	internal IXmlNamespaceResolver get_DtdParserProxy_NamespaceResolver() { }

	// RVA: 0xBC2A10 Offset: 0xBC1E10 VA: 0x180BC2A10
	internal bool get_DtdParserProxy_DtdValidation() { }

	// RVA: 0xBC2A60 Offset: 0xBC1E60 VA: 0x180BC2A60
	internal bool get_DtdParserProxy_Normalization() { }

	// RVA: 0xBC2A50 Offset: 0xBC1E50 VA: 0x180BC2A50
	internal bool get_DtdParserProxy_Namespaces() { }

	// RVA: 0xBC2A70 Offset: 0xBC1E70 VA: 0x180BC2A70
	internal bool get_DtdParserProxy_V1CompatibilityMode() { }

	// RVA: 0xBC2940 Offset: 0xBC1D40 VA: 0x180BC2940
	internal Uri get_DtdParserProxy_BaseUri() { }

	// RVA: 0x69CC20 Offset: 0x69C020 VA: 0x18069CC20
	internal bool get_DtdParserProxy_IsEof() { }

	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230
	internal char[] get_DtdParserProxy_ParsingBuffer() { }

	// RVA: 0x5FC780 Offset: 0x5FBB80 VA: 0x1805FC780
	internal int get_DtdParserProxy_ParsingBufferLength() { }

	// RVA: 0xA178C0 Offset: 0xA16CC0 VA: 0x180A178C0
	internal int get_DtdParserProxy_CurrentPosition() { }

	// RVA: 0xA17E80 Offset: 0xA17280 VA: 0x180A17E80
	internal void set_DtdParserProxy_CurrentPosition(int value) { }

	// RVA: 0xBC2A20 Offset: 0xBC1E20 VA: 0x180BC2A20
	internal int get_DtdParserProxy_EntityStackLength() { }

	// RVA: 0xBC2A30 Offset: 0xBC1E30 VA: 0x180BC2A30
	internal bool get_DtdParserProxy_IsEntityEolNormalized() { }

	// RVA: 0x751610 Offset: 0x750A10 VA: 0x180751610
	internal IValidationEventHandling get_DtdParserProxy_ValidationEventHandling() { }

	// RVA: 0xBAFDF0 Offset: 0xBAF1F0 VA: 0x180BAFDF0
	internal void DtdParserProxy_OnNewLine(int pos) { }

	// RVA: 0x7E3970 Offset: 0x7E2D70 VA: 0x1807E3970
	internal int get_DtdParserProxy_LineNo() { }

	// RVA: 0xB24340 Offset: 0xB23740 VA: 0x180B24340
	internal int get_DtdParserProxy_LineStartPosition() { }

	// RVA: 0xBB0620 Offset: 0xBAFA20 VA: 0x180BB0620
	internal int DtdParserProxy_ReadData() { }

	// RVA: 0xBB0140 Offset: 0xBAF540 VA: 0x180BB0140
	internal int DtdParserProxy_ParseNumericCharRef(StringBuilder internalSubsetBuilder) { }

	// RVA: 0xBB0130 Offset: 0xBAF530 VA: 0x180BB0130
	internal int DtdParserProxy_ParseNamedCharRef(bool expand, StringBuilder internalSubsetBuilder) { }

	// RVA: 0xBB01F0 Offset: 0xBAF5F0 VA: 0x180BB01F0
	internal void DtdParserProxy_ParsePI(StringBuilder sb) { }

	// RVA: 0xBAFFC0 Offset: 0xBAF3C0 VA: 0x180BAFFC0
	internal void DtdParserProxy_ParseComment(StringBuilder sb) { }

	// RVA: 0xBC2B50 Offset: 0xBC1F50 VA: 0x180BC2B50
	private bool get_IsResolverNull() { }

	// RVA: 0xBB1D60 Offset: 0xBB1160 VA: 0x180BB1D60
	private XmlResolver GetTempResolver() { }

	// RVA: 0xBB0330 Offset: 0xBAF730 VA: 0x180BB0330
	internal bool DtdParserProxy_PushEntity(IDtdEntityInfo entity, out int entityId) { }

	// RVA: 0xBB0240 Offset: 0xBAF640 VA: 0x180BB0240
	internal bool DtdParserProxy_PopEntity(out IDtdEntityInfo oldEntity, out int newEntityId) { }

	// RVA: 0xBB0400 Offset: 0xBAF800 VA: 0x180BB0400
	internal bool DtdParserProxy_PushExternalSubset(string systemId, string publicId) { }

	// RVA: 0xBB0580 Offset: 0xBAF980 VA: 0x180BB0580
	internal void DtdParserProxy_PushInternalDtd(string baseUri, string internalDtd) { }

	// RVA: 0xBB0630 Offset: 0xBAFA30 VA: 0x180BB0630
	internal void DtdParserProxy_Throw(Exception e) { }

	// RVA: 0xBAFEE0 Offset: 0xBAF2E0 VA: 0x180BAFEE0
	internal void DtdParserProxy_OnSystemId(string systemId, LineInfo keywordLineInfo, LineInfo systemLiteralLineInfo) { }

	// RVA: 0xBAFE00 Offset: 0xBAF200 VA: 0x180BAFE00
	internal void DtdParserProxy_OnPublicId(string publicId, LineInfo keywordLineInfo, LineInfo publicLiteralLineInfo) { }

	// RVA: 0xBC0DC0 Offset: 0xBC01C0 VA: 0x180BC0DC0
	private void Throw(int pos, string res, string arg) { }

	// RVA: 0xBC1180 Offset: 0xBC0580 VA: 0x180BC1180
	private void Throw(int pos, string res, string[] args) { }

	// RVA: 0xBC0E00 Offset: 0xBC0200 VA: 0x180BC0E00
	private void Throw(int pos, string res) { }

	// RVA: 0xBC0F10 Offset: 0xBC0310 VA: 0x180BC0F10
	private void Throw(string res) { }

	// RVA: 0xBC11C0 Offset: 0xBC05C0 VA: 0x180BC11C0
	private void Throw(string res, int lineNo, int linePos) { }

	// RVA: 0xBC1030 Offset: 0xBC0430 VA: 0x180BC1030
	private void Throw(string res, string arg) { }

	// RVA: 0xBC0E70 Offset: 0xBC0270 VA: 0x180BC0E70
	private void Throw(string res, string arg, int lineNo, int linePos) { }

	// RVA: 0xBC0F70 Offset: 0xBC0370 VA: 0x180BC0F70
	private void Throw(string res, string[] args) { }

	// RVA: 0xBC10F0 Offset: 0xBC04F0 VA: 0x180BC10F0
	private void Throw(string res, string arg, Exception innerException) { }

	// RVA: 0xBC0D00 Offset: 0xBC0100 VA: 0x180BC0D00
	private void Throw(string res, string[] args, Exception innerException) { }

	// RVA: 0xBC0C40 Offset: 0xBC0040 VA: 0x180BC0C40
	private void Throw(Exception e) { }

	// RVA: 0xBBCFC0 Offset: 0xBBC3C0 VA: 0x180BBCFC0
	private void ReThrow(Exception e, int lineNo, int linePos) { }

	// RVA: 0xBC0A70 Offset: 0xBBFE70 VA: 0x180BC0A70
	private void ThrowWithoutLineInfo(string res) { }

	// RVA: 0xBC0B10 Offset: 0xBBFF10 VA: 0x180BC0B10
	private void ThrowWithoutLineInfo(string res, string arg) { }

	// RVA: 0xBC0BA0 Offset: 0xBBFFA0 VA: 0x180BC0BA0
	private void ThrowWithoutLineInfo(string res, string[] args, Exception innerException) { }

	// RVA: 0xBC0400 Offset: 0xBBF800 VA: 0x180BC0400
	private void ThrowInvalidChar(char[] data, int length, int invCharPos) { }

	// RVA: 0xBBEC70 Offset: 0xBBE070 VA: 0x180BBEC70
	private void SetErrorState() { }

	// RVA: 0xBBE9B0 Offset: 0xBBDDB0 VA: 0x180BBE9B0
	private void SendValidationEvent(XmlSeverityType severity, string code, string arg, int lineNo, int linePos) { }

	// RVA: 0xBBEAF0 Offset: 0xBBDEF0 VA: 0x180BBEAF0
	private void SendValidationEvent(XmlSeverityType severity, XmlSchemaException exception) { }

	// RVA: 0xBC2A90 Offset: 0xBC1E90 VA: 0x180BC2A90
	private bool get_InAttributeValueIterator() { }

	// RVA: 0xBB0920 Offset: 0xBAFD20 VA: 0x180BB0920
	private void FinishAttributeValueIterator() { }

	// RVA: 0xBC2A10 Offset: 0xBC1E10 VA: 0x180BC2A10
	private bool get_DtdValidation() { }

	// RVA: 0xBB3590 Offset: 0xBB2990 VA: 0x180BB3590
	private void InitStreamInput(Stream stream, Encoding encoding) { }

	// RVA: 0xBB39A0 Offset: 0xBB2DA0 VA: 0x180BB39A0
	private void InitStreamInput(string baseUriStr, Stream stream, Encoding encoding) { }

	// RVA: 0xBB3920 Offset: 0xBB2D20 VA: 0x180BB3920
	private void InitStreamInput(Uri baseUri, Stream stream, Encoding encoding) { }

	// RVA: 0xBB3560 Offset: 0xBB2960 VA: 0x180BB3560
	private void InitStreamInput(Uri baseUri, string baseUriStr, Stream stream, Encoding encoding) { }

	// RVA: 0xBB3610 Offset: 0xBB2A10 VA: 0x180BB3610
	private void InitStreamInput(Uri baseUri, string baseUriStr, Stream stream, byte[] bytes, int byteCount, Encoding encoding) { }

	// RVA: 0xBB3AF0 Offset: 0xBB2EF0 VA: 0x180BB3AF0
	private void InitTextReaderInput(string baseUriStr, TextReader input) { }

	// RVA: 0xBB3B10 Offset: 0xBB2F10 VA: 0x180BB3B10
	private void InitTextReaderInput(string baseUriStr, Uri baseUri, TextReader input) { }

	// RVA: 0xBB39D0 Offset: 0xBB2DD0 VA: 0x180BB39D0
	private void InitStringInput(string baseUriStr, Encoding originalEncoding, string str) { }

	// RVA: 0xBB32C0 Offset: 0xBB26C0 VA: 0x180BB32C0
	private void InitFragmentReader(XmlNodeType fragmentType, XmlParserContext parserContext, bool allowXmlDeclFragment) { }

	// RVA: 0xBBC6E0 Offset: 0xBBBAE0 VA: 0x180BBC6E0
	private void ProcessDtdFromParserContext(XmlParserContext context) { }

	// RVA: 0xBB4D50 Offset: 0xBB4150 VA: 0x180BB4D50
	private void OpenUrl() { }

	// RVA: 0xBB4C00 Offset: 0xBB4000 VA: 0x180BB4C00
	private void OpenUrlDelegate(object xmlResolver) { }

	// RVA: 0xBAFBD0 Offset: 0xBAEFD0 VA: 0x180BAFBD0
	private Encoding DetectEncoding() { }

	// RVA: 0xBBEC90 Offset: 0xBBE090 VA: 0x180BBEC90
	private void SetupEncoding(Encoding encoding) { }

	// RVA: 0xBC01D0 Offset: 0xBBF5D0 VA: 0x180BC01D0
	private void SwitchEncoding(Encoding newEncoding) { }

	// RVA: 0xBAF740 Offset: 0xBAEB40 VA: 0x180BAF740
	private Encoding CheckEncoding(string newEncodingName) { }

	// RVA: 0xBC1280 Offset: 0xBC0680 VA: 0x180BC1280
	private void UnDecodeChars() { }

	// RVA: 0xBC0160 Offset: 0xBBF560 VA: 0x180BC0160
	private void SwitchEncodingToUTF8() { }

	// RVA: 0xBBD3E0 Offset: 0xBBC7E0 VA: 0x180BBD3E0
	private int ReadData() { }

	// RVA: 0xBB19E0 Offset: 0xBB0DE0 VA: 0x180BB19E0
	private int GetChars(int maxCharsCount) { }

	// RVA: 0xBB3C00 Offset: 0xBB3000 VA: 0x180BB3C00
	private void InvalidCharRecovery(ref int bytesCount, out int charsCount) { }

	// RVA: 0xBAFAE0 Offset: 0xBAEEE0 VA: 0x180BAFAE0
	internal void Close(bool closeInput) { }

	// RVA: 0xBBF230 Offset: 0xBBE630 VA: 0x180BBF230
	private void ShiftBuffer(int sourcePos, int destPos, int count) { }

	// RVA: 0xBBB450 Offset: 0xBBA850 VA: 0x180BBB450
	private bool ParseXmlDeclaration(bool isTextDecl) { }

	// RVA: 0xBB7260 Offset: 0xBB6660 VA: 0x180BB7260
	private bool ParseDocumentContent() { }

	// RVA: 0xBB7C00 Offset: 0xBB7000 VA: 0x180BB7C00
	private bool ParseElementContent() { }

	// RVA: 0xBC06A0 Offset: 0xBBFAA0 VA: 0x180BC06A0
	private void ThrowUnclosedElements() { }

	// RVA: 0xBB7FA0 Offset: 0xBB73A0 VA: 0x180BB7FA0
	private void ParseElement() { }

	// RVA: 0xBAE650 Offset: 0xBADA50 VA: 0x180BAE650
	private void AddDefaultAttributesAndNormalize() { }

	// RVA: 0xBB8560 Offset: 0xBB7960 VA: 0x180BB8560
	private void ParseEndElement() { }

	// RVA: 0xBC0470 Offset: 0xBBF870 VA: 0x180BC0470
	private void ThrowTagMismatch(XmlTextReaderImpl.NodeData startTag) { }

	// RVA: 0xBB61E0 Offset: 0xBB55E0 VA: 0x180BB61E0
	private void ParseAttributes() { }

	// RVA: 0xBB08B0 Offset: 0xBAFCB0 VA: 0x180BB08B0
	private void ElementNamespaceLookup() { }

	// RVA: 0xBAF630 Offset: 0xBAEA30 VA: 0x180BAF630
	private void AttributeNamespaceLookup() { }

	// RVA: 0xBAF200 Offset: 0xBAE600 VA: 0x180BAF200
	private void AttributeDuplCheck() { }

	// RVA: 0xBB4420 Offset: 0xBB3820 VA: 0x180BB4420
	private void OnDefaultNamespaceDecl(XmlTextReaderImpl.NodeData attr) { }

	// RVA: 0xBB4630 Offset: 0xBB3A30 VA: 0x180BB4630
	private void OnNamespaceDecl(XmlTextReaderImpl.NodeData attr) { }

	// RVA: 0xBB4740 Offset: 0xBB3B40 VA: 0x180BB4740
	private void OnXmlReservedAttribute(XmlTextReaderImpl.NodeData attr) { }

	// RVA: 0xBB5710 Offset: 0xBB4B10 VA: 0x180BB5710
	private void ParseAttributeValueSlow(int curPos, char quoteChar, XmlTextReaderImpl.NodeData attr) { }

	// RVA: 0xBAD920 Offset: 0xBACD20 VA: 0x180BAD920
	private void AddAttributeChunkToList(XmlTextReaderImpl.NodeData attr, XmlTextReaderImpl.NodeData chunk, ref XmlTextReaderImpl.NodeData lastChunk) { }

	// RVA: 0xBBAE40 Offset: 0xBBA240 VA: 0x180BBAE40
	private bool ParseText() { }

	// RVA: 0xBBA680 Offset: 0xBB9A80 VA: 0x180BBA680
	private bool ParseText(out int startPos, out int endPos, ref int outOrChars) { }

	// RVA: 0xBB1260 Offset: 0xBB0660 VA: 0x180BB1260
	private void FinishPartialValue() { }

	// RVA: 0xBB1120 Offset: 0xBB0520 VA: 0x180BB1120
	private void FinishOtherValueIterator() { }

	// RVA: 0xBBF610 Offset: 0xBBEA10 VA: 0x180BBF610
	private void SkipPartialTextValue() { }

	// RVA: 0xBB15D0 Offset: 0xBB09D0 VA: 0x180BB15D0
	private void FinishReadValueChunk() { }

	// RVA: 0xBB1390 Offset: 0xBB0790 VA: 0x180BB1390
	private void FinishReadContentAsBinary() { }

	// RVA: 0xBB14E0 Offset: 0xBB08E0 VA: 0x180BB14E0
	private void FinishReadElementContentAsBinary() { }

	// RVA: 0xBBA390 Offset: 0xBB9790 VA: 0x180BBA390
	private bool ParseRootLevelWhitespace() { }

	// RVA: 0xBB8AF0 Offset: 0xBB7EF0 VA: 0x180BB8AF0
	private void ParseEntityReference() { }

	// RVA: 0xBB2010 Offset: 0xBB1410 VA: 0x180BB2010
	private XmlTextReaderImpl.EntityType HandleEntityReference(bool isInAttributeValue, XmlTextReaderImpl.EntityExpandType expandType, out int charRefEndPos) { }

	// RVA: 0xBB22B0 Offset: 0xBB16B0 VA: 0x180BB22B0
	private XmlTextReaderImpl.EntityType HandleGeneralEntityReference(string name, bool isInAttributeValue, bool pushFakeEntityIfNullResolver, int entityStartLinePos) { }

	// RVA: 0xBC2AB0 Offset: 0xBC1EB0 VA: 0x180BC2AB0
	private bool get_InEntity() { }

	// RVA: 0xBB1E70 Offset: 0xBB1270 VA: 0x180BB1E70
	private bool HandleEntityEnd(bool checkEntityNesting) { }

	// RVA: 0xBBEE80 Offset: 0xBBE280 VA: 0x180BBEE80
	private void SetupEndEntityNodeInContent() { }

	// RVA: 0xBBEDF0 Offset: 0xBBE1F0 VA: 0x180BBEDF0
	private void SetupEndEntityNodeInAttribute() { }

	// RVA: 0xBB9CA0 Offset: 0xBB90A0 VA: 0x180BB9CA0
	private bool ParsePI() { }

	// RVA: 0xBB9CB0 Offset: 0xBB90B0 VA: 0x180BB9CB0
	private bool ParsePI(StringBuilder piInDtdStringBuilder) { }

	// RVA: 0xBB98D0 Offset: 0xBB8CD0 VA: 0x180BB98D0
	private bool ParsePIValue(out int outStartPos, out int outEndPos) { }

	// RVA: 0xBB6F40 Offset: 0xBB6340 VA: 0x180BB6F40
	private bool ParseComment() { }

	// RVA: 0xBB6EA0 Offset: 0xBB62A0 VA: 0x180BB6EA0
	private void ParseCData() { }

	// RVA: 0xBB6860 Offset: 0xBB5C60 VA: 0x180BB6860
	private void ParseCDataOrComment(XmlNodeType type) { }

	// RVA: 0xBB6A40 Offset: 0xBB5E40 VA: 0x180BB6A40
	private bool ParseCDataOrComment(XmlNodeType type, out int outStartPos, out int outEndPos) { }

	// RVA: 0xBB6FA0 Offset: 0xBB63A0 VA: 0x180BB6FA0
	private bool ParseDoctypeDecl() { }

	// RVA: 0xBB7980 Offset: 0xBB6D80 VA: 0x180BB7980
	private void ParseDtd() { }

	// RVA: 0xBBF260 Offset: 0xBBE660 VA: 0x180BBF260
	private void SkipDtd() { }

	// RVA: 0xBBF670 Offset: 0xBBEA70 VA: 0x180BBF670
	private void SkipPublicOrSystemIdLiteral() { }

	// RVA: 0xBBF710 Offset: 0xBBEB10 VA: 0x180BBF710
	private void SkipUntil(char stopChar, bool recognizeLiterals) { }

	// RVA: 0xBB0640 Offset: 0xBAFA40 VA: 0x180BB0640
	private int EatWhitespaces(StringBuilder sb) { }

	// RVA: 0xBB6EB0 Offset: 0xBB62B0 VA: 0x180BB6EB0
	private int ParseCharRefInline(int startPos, out int charCount, out XmlTextReaderImpl.EntityType entityType) { }

	// RVA: 0xBB9800 Offset: 0xBB8C00 VA: 0x180BB9800
	private int ParseNumericCharRef(bool expand, StringBuilder internalSubsetBuilder, out XmlTextReaderImpl.EntityType entityType) { }

	// RVA: 0xBB9090 Offset: 0xBB8490 VA: 0x180BB9090
	private int ParseNumericCharRefInline(int startPos, bool expand, StringBuilder internalSubsetBuilder, out int charCount, out XmlTextReaderImpl.EntityType entityType) { }

	// RVA: 0xBB9010 Offset: 0xBB8410 VA: 0x180BB9010
	private int ParseNamedCharRef(bool expand, StringBuilder internalSubsetBuilder) { }

	// RVA: 0xBB8C30 Offset: 0xBB8030 VA: 0x180BB8C30
	private int ParseNamedCharRefInline(int startPos, bool expand, StringBuilder internalSubsetBuilder) { }

	// RVA: 0xBB8C00 Offset: 0xBB8000 VA: 0x180BB8C00
	private int ParseName() { }

	// RVA: 0xBBA0C0 Offset: 0xBB94C0 VA: 0x180BBA0C0
	private int ParseQName(out int colonPos) { }

	// RVA: 0xBBA0E0 Offset: 0xBB94E0 VA: 0x180BBA0E0
	private int ParseQName(bool isQName, int startOffset, out int colonPos) { }

	// RVA: 0xBBD390 Offset: 0xBBC790 VA: 0x180BBD390
	private bool ReadDataInName(ref int pos) { }

	// RVA: 0xBB89F0 Offset: 0xBB7DF0 VA: 0x180BB89F0
	private string ParseEntityName() { }

	// RVA: 0xBAEED0 Offset: 0xBAE2D0 VA: 0x180BAEED0
	private XmlTextReaderImpl.NodeData AddNode(int nodeIndex, int nodeDepth) { }

	// RVA: 0xBAF080 Offset: 0xBAE480 VA: 0x180BAF080
	private XmlTextReaderImpl.NodeData AllocNode(int nodeIndex, int nodeDepth) { }

	// RVA: 0xBAD990 Offset: 0xBACD90 VA: 0x180BAD990
	private XmlTextReaderImpl.NodeData AddAttributeNoChecks(string name, int attrDepth) { }

	// RVA: 0xBADA20 Offset: 0xBACE20 VA: 0x180BADA20
	private XmlTextReaderImpl.NodeData AddAttribute(int endNamePos, int colonPos) { }

	// RVA: 0xBADC50 Offset: 0xBAD050 VA: 0x180BADC50
	private XmlTextReaderImpl.NodeData AddAttribute(string localName, string prefix, string nameWPrefix) { }

	// RVA: 0xBBC4D0 Offset: 0xBBB8D0 VA: 0x180BBC4D0
	private void PopElementContext() { }

	// RVA: 0xBAFDF0 Offset: 0xBAF1F0 VA: 0x180BAFDF0
	private void OnNewLine(int pos) { }

	// RVA: 0xBB4550 Offset: 0xBB3950 VA: 0x180BB4550
	private void OnEof() { }

	// RVA: 0xBB3D60 Offset: 0xBB3160 VA: 0x180BB3D60
	private string LookupNamespace(XmlTextReaderImpl.NodeData node) { }

	// RVA: 0xBAEC30 Offset: 0xBAE030 VA: 0x180BAEC30
	private void AddNamespace(string prefix, string uri, XmlTextReaderImpl.NodeData attr) { }

	// RVA: 0xBBE680 Offset: 0xBBDA80 VA: 0x180BBE680
	private void ResetAttributes() { }

	// RVA: 0xBB1610 Offset: 0xBB0A10 VA: 0x180BB1610
	private void FullAttributeCleanup() { }

	// RVA: 0xBBCF20 Offset: 0xBBC320 VA: 0x180BBCF20
	private void PushXmlContext() { }

	// RVA: 0xBBC6A0 Offset: 0xBBBAA0 VA: 0x180BBC6A0
	private void PopXmlContext() { }

	// RVA: 0xBB1E20 Offset: 0xBB1220 VA: 0x180BB1E20
	private XmlNodeType GetWhitespaceType() { }

	// RVA: 0xBB1DC0 Offset: 0xBB11C0 VA: 0x180BB1DC0
	private XmlNodeType GetTextNodeType(int orChars) { }

	// RVA: 0xBBC740 Offset: 0xBBBB40 VA: 0x180BBC740
	private void PushExternalEntityOrSubset(string publicId, string systemId, Uri baseUri, string entityName) { }

	// RVA: 0xBB4960 Offset: 0xBB3D60 VA: 0x180BB4960
	private bool OpenAndPush(Uri uri) { }

	// RVA: 0xBBCA50 Offset: 0xBBBE50 VA: 0x180BBCA50
	private bool PushExternalEntity(IDtdEntityInfo entity) { }

	// RVA: 0xBBCC50 Offset: 0xBBC050 VA: 0x180BBCC50
	private void PushInternalEntity(IDtdEntityInfo entity) { }

	// RVA: 0xBBC540 Offset: 0xBBB940 VA: 0x180BBC540
	private void PopEntity() { }

	// RVA: 0xBBE4A0 Offset: 0xBBD8A0 VA: 0x180BBE4A0
	private void RegisterEntity(IDtdEntityInfo entity) { }

	// RVA: 0xBC1330 Offset: 0xBC0730 VA: 0x180BC1330
	private void UnregisterEntity() { }

	// RVA: 0xBBCDC0 Offset: 0xBBC1C0 VA: 0x180BBCDC0
	private void PushParsingState() { }

	// RVA: 0xBBC5D0 Offset: 0xBBB9D0 VA: 0x180BBC5D0
	private void PopParsingState() { }

	// RVA: 0xBB2790 Offset: 0xBB1B90 VA: 0x180BB2790
	private int IncrementalRead() { }

	// RVA: 0xBB0B70 Offset: 0xBAFF70 VA: 0x180BB0B70
	private void FinishIncrementalRead() { }

	// RVA: 0xBB8B70 Offset: 0xBB7F70 VA: 0x180BB8B70
	private bool ParseFragmentAttribute() { }

	// RVA: 0xBB5030 Offset: 0xBB4430 VA: 0x180BB5030
	private bool ParseAttributeValueChunk() { }

	// RVA: 0xBBB3A0 Offset: 0xBBA7A0 VA: 0x180BBB3A0
	private void ParseXmlDeclarationFragment() { }

	// RVA: 0xBC0A50 Offset: 0xBBFE50 VA: 0x180BC0A50
	private void ThrowUnexpectedToken(int pos, string expectedToken) { }

	// RVA: 0xBC0A40 Offset: 0xBBFE40 VA: 0x180BC0A40
	private void ThrowUnexpectedToken(string expectedToken1) { }

	// RVA: 0xBC08A0 Offset: 0xBBFCA0 VA: 0x180BC08A0
	private void ThrowUnexpectedToken(int pos, string expectedToken1, string expectedToken2) { }

	// RVA: 0xBC08E0 Offset: 0xBBFCE0 VA: 0x180BC08E0
	private void ThrowUnexpectedToken(string expectedToken1, string expectedToken2) { }

	// RVA: 0xBBB2A0 Offset: 0xBBA6A0 VA: 0x180BBB2A0
	private string ParseUnexpectedToken(int pos) { }

	// RVA: 0xBBB2B0 Offset: 0xBBA6B0 VA: 0x180BBB2B0
	private string ParseUnexpectedToken() { }

	// RVA: 0xBC0390 Offset: 0xBBF790 VA: 0x180BC0390
	private void ThrowExpectingWhitespace(int pos) { }

	// RVA: 0xBB1BD0 Offset: 0xBB0FD0 VA: 0x180BB1BD0
	private int GetIndexOfAttributeWithoutPrefix(string name) { }

	// RVA: 0xBB1AF0 Offset: 0xBB0EF0 VA: 0x180BB1AF0
	private int GetIndexOfAttributeWithPrefix(string name) { }

	// RVA: 0xBC1480 Offset: 0xBC0880 VA: 0x180BC1480
	private bool ZeroEndingStream(int pos) { }

	// RVA: 0xBB77B0 Offset: 0xBB6BB0 VA: 0x180BB77B0
	private void ParseDtdFromParserContext() { }

	// RVA: 0xBB4310 Offset: 0xBB3710 VA: 0x180BB4310
	private bool MoveToNextContentNode(bool moveIfOnContentNode) { }

	// RVA: 0xBBEFC0 Offset: 0xBBE3C0 VA: 0x180BBEFC0
	private void SetupFromParserContext(XmlParserContext context, XmlReaderSettings settings) { }

	// RVA: 0x8A99E0 Offset: 0x8A8DE0 VA: 0x1808A99E0 Slot: 52
	internal override IDtdInfo get_DtdInfo() { }

	// RVA: 0xBBEBB0 Offset: 0xBBDFB0 VA: 0x180BBEBB0
	internal void SetDtdInfo(IDtdInfo newDtdInfo) { }

	// RVA: 0xBC36C0 Offset: 0xBC2AC0 VA: 0x180BC36C0
	internal void set_ValidationEventHandling(IValidationEventHandling value) { }

	// RVA: 0xBC36A0 Offset: 0xBC2AA0 VA: 0x180BC36A0
	internal void set_OnDefaultAttributeUse(XmlTextReaderImpl.OnDefaultAttributeUseDelegate value) { }

	// RVA: 0xBC3860 Offset: 0xBC2C60 VA: 0x180BC3860
	internal void set_XmlValidatingReaderCompatibilityMode(bool value) { }

	// RVA: 0x8CB380 Offset: 0x8CA780 VA: 0x1808CB380
	internal XmlNodeType get_FragmentType() { }

	// RVA: 0xBAF720 Offset: 0xBAEB20 VA: 0x180BAF720
	internal void ChangeCurrentNodeType(XmlNodeType newNodeType) { }

	// RVA: 0xBB1D20 Offset: 0xBB1120 VA: 0x180BB1D20
	internal XmlResolver GetResolver() { }

	// RVA: 0xBC3370 Offset: 0xBC2770 VA: 0x180BC3370
	internal void set_InternalSchemaType(object value) { }

	// RVA: 0xBC2AC0 Offset: 0xBC1EC0 VA: 0x180BC2AC0
	internal object get_InternalTypedValue() { }

	// RVA: 0xBC33A0 Offset: 0xBC27A0 VA: 0x180BC33A0
	internal void set_InternalTypedValue(object value) { }

	// RVA: 0xBC3110 Offset: 0xBC2510 VA: 0x180BC3110
	internal bool get_StandAlone() { }

	// RVA: 0xBC2A40 Offset: 0xBC1E40 VA: 0x180BC2A40 Slot: 51
	internal override XmlNamespaceManager get_NamespaceManager() { }

	// RVA: 0xBC2A70 Offset: 0xBC1E70 VA: 0x180BC2A70
	internal bool get_V1Compat() { }

	// RVA: 0xBADDC0 Offset: 0xBAD1C0 VA: 0x180BADDC0
	private bool AddDefaultAttributeDtd(IDtdDefaultAttributeInfo defAttrInfo, bool definedInDtd, XmlTextReaderImpl.NodeData[] nameSortedNodeData) { }

	// RVA: 0xBAE3D0 Offset: 0xBAD7D0 VA: 0x180BAE3D0
	internal bool AddDefaultAttributeNonDtd(SchemaAttDef attrDef) { }

	// RVA: 0xBAE100 Offset: 0xBAD500 VA: 0x180BAE100
	private XmlTextReaderImpl.NodeData AddDefaultAttributeInternal(string localName, string ns, string prefix, string value, int lineNo, int linePos, int valueLineNo, int valueLinePos, bool isXmlAttribute) { }

	// RVA: 0xBC32D0 Offset: 0xBC26D0 VA: 0x180BC32D0
	internal void set_DisableUndeclaredEntityCheck(bool value) { }

	// RVA: 0xBC1390 Offset: 0xBC0790 VA: 0x180BC1390
	private bool UriEqual(Uri uri1, string uri1Str, string uri2Str, XmlResolver resolver) { }

	// RVA: 0xBBE390 Offset: 0xBBD790 VA: 0x180BBE390
	private void RegisterConsumedCharacters(long characters, bool inEntityReference) { }

	// RVA: 0xBBFF80 Offset: 0xBBF380 VA: 0x180BBFF80
	internal static string StripSpaces(string value) { }

	// RVA: 0xBBFE20 Offset: 0xBBF220 VA: 0x180BBFE20
	internal static void StripSpaces(char[] value, int index, ref int len) { }

	// RVA: 0xBAF6F0 Offset: 0xBAEAF0 VA: 0x180BAF6F0
	internal static void BlockCopyChars(char[] src, int srcOffset, char[] dst, int dstOffset, int count) { }

	// RVA: 0xBAF710 Offset: 0xBAEB10 VA: 0x180BAF710
	internal static void BlockCopy(byte[] src, int srcOffset, byte[] dst, int dstOffset, int count) { }

}

private enum XmlTextReaderImpl.ParsingFunction // TypeDefIndex: 1893
{	// Fields
	public int value__; // 0x0
	public const XmlTextReaderImpl.ParsingFunction ElementContent = 0;
	public const XmlTextReaderImpl.ParsingFunction NoData = 1;
	public const XmlTextReaderImpl.ParsingFunction OpenUrl = 2;
	public const XmlTextReaderImpl.ParsingFunction SwitchToInteractive = 3;
	public const XmlTextReaderImpl.ParsingFunction SwitchToInteractiveXmlDecl = 4;
	public const XmlTextReaderImpl.ParsingFunction DocumentContent = 5;
	public const XmlTextReaderImpl.ParsingFunction MoveToElementContent = 6;
	public const XmlTextReaderImpl.ParsingFunction PopElementContext = 7;
	public const XmlTextReaderImpl.ParsingFunction PopEmptyElementContext = 8;
	public const XmlTextReaderImpl.ParsingFunction ResetAttributesRootLevel = 9;
	public const XmlTextReaderImpl.ParsingFunction Error = 10;
	public const XmlTextReaderImpl.ParsingFunction Eof = 11;
	public const XmlTextReaderImpl.ParsingFunction ReaderClosed = 12;
	public const XmlTextReaderImpl.ParsingFunction EntityReference = 13;
	public const XmlTextReaderImpl.ParsingFunction InIncrementalRead = 14;
	public const XmlTextReaderImpl.ParsingFunction FragmentAttribute = 15;
	public const XmlTextReaderImpl.ParsingFunction ReportEndEntity = 16;
	public const XmlTextReaderImpl.ParsingFunction AfterResolveEntityInContent = 17;
	public const XmlTextReaderImpl.ParsingFunction AfterResolveEmptyEntityInContent = 18;
	public const XmlTextReaderImpl.ParsingFunction XmlDeclarationFragment = 19;
	public const XmlTextReaderImpl.ParsingFunction GoToEof = 20;
	public const XmlTextReaderImpl.ParsingFunction PartialTextValue = 21;
	public const XmlTextReaderImpl.ParsingFunction InReadAttributeValue = 22;
	public const XmlTextReaderImpl.ParsingFunction InReadValueChunk = 23;
	public const XmlTextReaderImpl.ParsingFunction InReadContentAsBinary = 24;
	public const XmlTextReaderImpl.ParsingFunction InReadElementContentAsBinary = 25;

}

private enum XmlTextReaderImpl.ParsingMode // TypeDefIndex: 1894
{	// Fields
	public int value__; // 0x0
	public const XmlTextReaderImpl.ParsingMode Full = 0;
	public const XmlTextReaderImpl.ParsingMode SkipNode = 1;
	public const XmlTextReaderImpl.ParsingMode SkipContent = 2;

}

private enum XmlTextReaderImpl.EntityType // TypeDefIndex: 1895
{	// Fields
	public int value__; // 0x0
	public const XmlTextReaderImpl.EntityType CharacterDec = 0;
	public const XmlTextReaderImpl.EntityType CharacterHex = 1;
	public const XmlTextReaderImpl.EntityType CharacterNamed = 2;
	public const XmlTextReaderImpl.EntityType Expanded = 3;
	public const XmlTextReaderImpl.EntityType Skipped = 4;
	public const XmlTextReaderImpl.EntityType FakeExpanded = 5;
	public const XmlTextReaderImpl.EntityType Unexpanded = 6;
	public const XmlTextReaderImpl.EntityType ExpandedInAttribute = 7;

}

private enum XmlTextReaderImpl.EntityExpandType // TypeDefIndex: 1896
{	// Fields
	public int value__; // 0x0
	public const XmlTextReaderImpl.EntityExpandType All = 0;
	public const XmlTextReaderImpl.EntityExpandType OnlyGeneral = 1;
	public const XmlTextReaderImpl.EntityExpandType OnlyCharacter = 2;

}

private enum XmlTextReaderImpl.IncrementalReadState // TypeDefIndex: 1897
{	// Fields
	public int value__; // 0x0
	public const XmlTextReaderImpl.IncrementalReadState Text = 0;
	public const XmlTextReaderImpl.IncrementalReadState StartTag = 1;
	public const XmlTextReaderImpl.IncrementalReadState PI = 2;
	public const XmlTextReaderImpl.IncrementalReadState CDATA = 3;
	public const XmlTextReaderImpl.IncrementalReadState Comment = 4;
	public const XmlTextReaderImpl.IncrementalReadState Attributes = 5;
	public const XmlTextReaderImpl.IncrementalReadState AttributeValue = 6;
	public const XmlTextReaderImpl.IncrementalReadState ReadData = 7;
	public const XmlTextReaderImpl.IncrementalReadState EndElement = 8;
	public const XmlTextReaderImpl.IncrementalReadState End = 9;
	public const XmlTextReaderImpl.IncrementalReadState ReadValueChunk_OnCachedValue = 10;
	public const XmlTextReaderImpl.IncrementalReadState ReadValueChunk_OnPartialValue = 11;
	public const XmlTextReaderImpl.IncrementalReadState ReadContentAsBinary_OnCachedValue = 12;
	public const XmlTextReaderImpl.IncrementalReadState ReadContentAsBinary_OnPartialValue = 13;
	public const XmlTextReaderImpl.IncrementalReadState ReadContentAsBinary_End = 14;

}

private class XmlTextReaderImpl.LaterInitParam // TypeDefIndex: 1898
{	// Fields
	public bool useAsync; // 0x10
	public Stream inputStream; // 0x18
	public byte[] inputBytes; // 0x20
	public int inputByteCount; // 0x28
	public Uri inputbaseUri; // 0x30
	public string inputUriStr; // 0x38
	public XmlResolver inputUriResolver; // 0x40
	public XmlParserContext inputContext; // 0x48
	public TextReader inputTextReader; // 0x50
	public XmlTextReaderImpl.InitInputType initType; // 0x58

	// Methods

	// RVA: 0x1313110 Offset: 0x1312510 VA: 0x181313110
	public void .ctor() { }

}

private enum XmlTextReaderImpl.InitInputType // TypeDefIndex: 1899
{	// Fields
	public int value__; // 0x0
	public const XmlTextReaderImpl.InitInputType UriString = 0;
	public const XmlTextReaderImpl.InitInputType Stream = 1;
	public const XmlTextReaderImpl.InitInputType TextReader = 2;
	public const XmlTextReaderImpl.InitInputType Invalid = 3;

}

private struct XmlTextReaderImpl.ParsingState // TypeDefIndex: 1900
{	// Fields
	internal char[] chars; // 0x0
	internal int charPos; // 0x8
	internal int charsUsed; // 0xC
	internal Encoding encoding; // 0x10
	internal bool appendMode; // 0x18
	internal Stream stream; // 0x20
	internal Decoder decoder; // 0x28
	internal byte[] bytes; // 0x30
	internal int bytePos; // 0x38
	internal int bytesUsed; // 0x3C
	internal TextReader textReader; // 0x40
	internal int lineNo; // 0x48
	internal int lineStartPos; // 0x4C
	internal string baseUriStr; // 0x50
	internal Uri baseUri; // 0x58
	internal bool isEof; // 0x60
	internal bool isStreamEof; // 0x61
	internal IDtdEntityInfo entity; // 0x68
	internal int entityId; // 0x70
	internal bool eolNormalized; // 0x74
	internal bool entityResolvedManually; // 0x75

	// Properties
	internal int LineNo { get; }
	internal int LinePos { get; }

	// Methods

	// RVA: 0x1E0EB0 Offset: 0x1E02B0 VA: 0x1801E0EB0
	internal void Clear() { }

	// RVA: 0x1E0F90 Offset: 0x1E0390 VA: 0x1801E0F90
	internal void Close(bool closeInput) { }

	// RVA: 0x1E0980 Offset: 0x1DFD80 VA: 0x1801E0980
	internal int get_LineNo() { }

	// RVA: 0x1E0FD0 Offset: 0x1E03D0 VA: 0x1801E0FD0
	internal int get_LinePos() { }

}

private class XmlTextReaderImpl.XmlContext // TypeDefIndex: 1901
{	// Fields
	internal XmlSpace xmlSpace; // 0x10
	internal string xmlLang; // 0x18
	internal string defaultNamespace; // 0x20
	internal XmlTextReaderImpl.XmlContext previousContext; // 0x28

	// Methods

	// RVA: 0x1314310 Offset: 0x1313710 VA: 0x181314310
	internal void .ctor() { }

	// RVA: 0x13143A0 Offset: 0x13137A0 VA: 0x1813143A0
	internal void .ctor(XmlTextReaderImpl.XmlContext previousContext) { }

}

private class XmlTextReaderImpl.NoNamespaceManager : XmlNamespaceManager // TypeDefIndex: 1902
{	// Properties
	public override string DefaultNamespace { get; }

	// Methods

	// RVA: 0x7992B0 Offset: 0x7986B0 VA: 0x1807992B0
	public void .ctor() { }

	// RVA: 0x1313200 Offset: 0x1312600 VA: 0x181313200 Slot: 9
	public override string get_DefaultNamespace() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 10
	public override void PushScope() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 11
	public override bool PopScope() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 12
	public override void AddNamespace(string prefix, string uri) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 13
	public override void RemoveNamespace(string prefix, string uri) { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 14
	public override IEnumerator GetEnumerator() { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 15
	public override IDictionary<string, string> GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x13131C0 Offset: 0x13125C0 VA: 0x1813131C0 Slot: 16
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 17
	public override string LookupPrefix(string uri) { }

}

internal class XmlTextReaderImpl.DtdParserProxy : IDtdParserAdapterV1, IDtdParserAdapterWithValidation, IDtdParserAdapter // TypeDefIndex: 1903
{	// Fields
	private XmlTextReaderImpl reader; // 0x10

	// Properties
	private XmlNameTable System.Xml.IDtdParserAdapter.NameTable { get; }
	private IXmlNamespaceResolver System.Xml.IDtdParserAdapter.NamespaceResolver { get; }
	private Uri System.Xml.IDtdParserAdapter.BaseUri { get; }
	private bool System.Xml.IDtdParserAdapter.IsEof { get; }
	private char[] System.Xml.IDtdParserAdapter.ParsingBuffer { get; }
	private int System.Xml.IDtdParserAdapter.ParsingBufferLength { get; }
	private int System.Xml.IDtdParserAdapter.CurrentPosition { get; set; }
	private int System.Xml.IDtdParserAdapter.EntityStackLength { get; }
	private bool System.Xml.IDtdParserAdapter.IsEntityEolNormalized { get; }
	private int System.Xml.IDtdParserAdapter.LineNo { get; }
	private int System.Xml.IDtdParserAdapter.LineStartPosition { get; }
	private bool System.Xml.IDtdParserAdapterWithValidation.DtdValidation { get; }
	private IValidationEventHandling System.Xml.IDtdParserAdapterWithValidation.ValidationEventHandling { get; }
	private bool System.Xml.IDtdParserAdapterV1.Normalization { get; }
	private bool System.Xml.IDtdParserAdapterV1.Namespaces { get; }
	private bool System.Xml.IDtdParserAdapterV1.V1CompatibilityMode { get; }

	// Methods

	// RVA: 0x6C0000 Offset: 0x6BF400 VA: 0x1806C0000
	internal void .ctor(XmlTextReaderImpl reader) { }

	// RVA: 0x1313000 Offset: 0x1312400 VA: 0x181313000 Slot: 9
	private XmlNameTable System.Xml.IDtdParserAdapter.get_NameTable() { }

	// RVA: 0x1313020 Offset: 0x1312420 VA: 0x181313020 Slot: 10
	private IXmlNamespaceResolver System.Xml.IDtdParserAdapter.get_NamespaceResolver() { }

	// RVA: 0x1312F20 Offset: 0x1312320 VA: 0x181312F20 Slot: 11
	private Uri System.Xml.IDtdParserAdapter.get_BaseUri() { }

	// RVA: 0x1312FA0 Offset: 0x13123A0 VA: 0x181312FA0 Slot: 18
	private bool System.Xml.IDtdParserAdapter.get_IsEof() { }

	// RVA: 0x1313060 Offset: 0x1312460 VA: 0x181313060 Slot: 12
	private char[] System.Xml.IDtdParserAdapter.get_ParsingBuffer() { }

	// RVA: 0x1313040 Offset: 0x1312440 VA: 0x181313040 Slot: 13
	private int System.Xml.IDtdParserAdapter.get_ParsingBufferLength() { }

	// RVA: 0x1312F40 Offset: 0x1312340 VA: 0x181312F40 Slot: 14
	private int System.Xml.IDtdParserAdapter.get_CurrentPosition() { }

	// RVA: 0x1313080 Offset: 0x1312480 VA: 0x181313080 Slot: 15
	private void System.Xml.IDtdParserAdapter.set_CurrentPosition(int value) { }

	// RVA: 0x1312F60 Offset: 0x1312360 VA: 0x181312F60 Slot: 19
	private int System.Xml.IDtdParserAdapter.get_EntityStackLength() { }

	// RVA: 0x1312F80 Offset: 0x1312380 VA: 0x181312F80 Slot: 20
	private bool System.Xml.IDtdParserAdapter.get_IsEntityEolNormalized() { }

	// RVA: 0x1312D60 Offset: 0x1312160 VA: 0x181312D60 Slot: 22
	private void System.Xml.IDtdParserAdapter.OnNewLine(int pos) { }

	// RVA: 0x1312FC0 Offset: 0x13123C0 VA: 0x181312FC0 Slot: 16
	private int System.Xml.IDtdParserAdapter.get_LineNo() { }

	// RVA: 0x1312FE0 Offset: 0x13123E0 VA: 0x181312FE0 Slot: 17
	private int System.Xml.IDtdParserAdapter.get_LineStartPosition() { }

	// RVA: 0x1312EE0 Offset: 0x13122E0 VA: 0x181312EE0 Slot: 21
	private int System.Xml.IDtdParserAdapter.ReadData() { }

	// RVA: 0x1312E20 Offset: 0x1312220 VA: 0x181312E20 Slot: 23
	private int System.Xml.IDtdParserAdapter.ParseNumericCharRef(StringBuilder internalSubsetBuilder) { }

	// RVA: 0x1312E00 Offset: 0x1312200 VA: 0x181312E00 Slot: 24
	private int System.Xml.IDtdParserAdapter.ParseNamedCharRef(bool expand, StringBuilder internalSubsetBuilder) { }

	// RVA: 0x1312E40 Offset: 0x1312240 VA: 0x181312E40 Slot: 25
	private void System.Xml.IDtdParserAdapter.ParsePI(StringBuilder sb) { }

	// RVA: 0x1312DE0 Offset: 0x13121E0 VA: 0x181312DE0 Slot: 26
	private void System.Xml.IDtdParserAdapter.ParseComment(StringBuilder sb) { }

	// RVA: 0x1312E80 Offset: 0x1312280 VA: 0x181312E80 Slot: 27
	private bool System.Xml.IDtdParserAdapter.PushEntity(IDtdEntityInfo entity, out int entityId) { }

	// RVA: 0x1312E60 Offset: 0x1312260 VA: 0x181312E60 Slot: 28
	private bool System.Xml.IDtdParserAdapter.PopEntity(out IDtdEntityInfo oldEntity, out int newEntityId) { }

	// RVA: 0x1312EA0 Offset: 0x13122A0 VA: 0x181312EA0 Slot: 29
	private bool System.Xml.IDtdParserAdapter.PushExternalSubset(string systemId, string publicId) { }

	// RVA: 0x1312EC0 Offset: 0x13122C0 VA: 0x181312EC0 Slot: 30
	private void System.Xml.IDtdParserAdapter.PushInternalDtd(string baseUri, string internalDtd) { }

	// RVA: 0x1312F00 Offset: 0x1312300 VA: 0x181312F00 Slot: 33
	private void System.Xml.IDtdParserAdapter.Throw(Exception e) { }

	// RVA: 0x1312DB0 Offset: 0x13121B0 VA: 0x181312DB0 Slot: 31
	private void System.Xml.IDtdParserAdapter.OnSystemId(string systemId, LineInfo keywordLineInfo, LineInfo systemLiteralLineInfo) { }

	// RVA: 0x1312D80 Offset: 0x1312180 VA: 0x181312D80 Slot: 32
	private void System.Xml.IDtdParserAdapter.OnPublicId(string publicId, LineInfo keywordLineInfo, LineInfo publicLiteralLineInfo) { }

	// RVA: 0x1312D20 Offset: 0x1312120 VA: 0x181312D20 Slot: 7
	private bool System.Xml.IDtdParserAdapterWithValidation.get_DtdValidation() { }

	// RVA: 0x1312D40 Offset: 0x1312140 VA: 0x181312D40 Slot: 8
	private IValidationEventHandling System.Xml.IDtdParserAdapterWithValidation.get_ValidationEventHandling() { }

	// RVA: 0xBC4330 Offset: 0xBC3730 VA: 0x180BC4330 Slot: 5
	private bool System.Xml.IDtdParserAdapterV1.get_Normalization() { }

	// RVA: 0xBC4310 Offset: 0xBC3710 VA: 0x180BC4310 Slot: 6
	private bool System.Xml.IDtdParserAdapterV1.get_Namespaces() { }

	// RVA: 0x1312D00 Offset: 0x1312100 VA: 0x181312D00 Slot: 4
	private bool System.Xml.IDtdParserAdapterV1.get_V1CompatibilityMode() { }

}

private class XmlTextReaderImpl.NodeData : IComparable // TypeDefIndex: 1904
{	// Fields
	private static XmlTextReaderImpl.NodeData s_None; // 0x0
	internal XmlNodeType type; // 0x10
	internal string localName; // 0x18
	internal string prefix; // 0x20
	internal string ns; // 0x28
	internal string nameWPrefix; // 0x30
	private string value; // 0x38
	private char[] chars; // 0x40
	private int valueStartPos; // 0x48
	private int valueLength; // 0x4C
	internal LineInfo lineInfo; // 0x50
	internal LineInfo lineInfo2; // 0x58
	internal char quoteChar; // 0x60
	internal int depth; // 0x64
	private bool isEmptyOrDefault; // 0x68
	internal int entityId; // 0x6C
	internal bool xmlContextPushed; // 0x70
	internal XmlTextReaderImpl.NodeData nextAttrValueChunk; // 0x78
	internal object schemaType; // 0x80
	internal object typedValue; // 0x88

	// Properties
	internal static XmlTextReaderImpl.NodeData None { get; }
	internal int LineNo { get; }
	internal int LinePos { get; }
	internal bool IsEmptyElement { get; set; }
	internal bool IsDefaultAttribute { get; set; }
	internal bool ValueBuffered { get; }
	internal string StringValue { get; }

	// Methods

	// RVA: 0x1313B70 Offset: 0x1312F70 VA: 0x181313B70
	internal static XmlTextReaderImpl.NodeData get_None() { }

	// RVA: 0x1313A90 Offset: 0x1312E90 VA: 0x181313A90
	internal void .ctor() { }

	// RVA: 0x8C8B80 Offset: 0x8C7F80 VA: 0x1808C8B80
	internal int get_LineNo() { }

	// RVA: 0x5F8160 Offset: 0x5F7560 VA: 0x1805F8160
	internal int get_LinePos() { }

	// RVA: 0x1313B60 Offset: 0x1312F60 VA: 0x181313B60
	internal bool get_IsEmptyElement() { }

	// RVA: 0xE64690 Offset: 0xE63A90 VA: 0x180E64690
	internal void set_IsEmptyElement(bool value) { }

	// RVA: 0x1313B50 Offset: 0x1312F50 VA: 0x181313B50
	internal bool get_IsDefaultAttribute() { }

	// RVA: 0xE64690 Offset: 0xE63A90 VA: 0x180E64690
	internal void set_IsDefaultAttribute(bool value) { }

	// RVA: 0x1313D00 Offset: 0x1313100 VA: 0x181313D00
	internal bool get_ValueBuffered() { }

	// RVA: 0x1313CB0 Offset: 0x13130B0 VA: 0x181313CB0
	internal string get_StringValue() { }

	// RVA: 0x1313A40 Offset: 0x1312E40 VA: 0x181313A40
	internal void TrimSpacesInValue() { }

	// RVA: 0x13132E0 Offset: 0x13126E0 VA: 0x1813132E0
	internal void Clear(XmlNodeType type) { }

	// RVA: 0x1313240 Offset: 0x1312640 VA: 0x181313240
	internal void ClearName() { }

	// RVA: 0x1313650 Offset: 0x1312A50 VA: 0x181313650
	internal void SetLineInfo(int lineNo, int linePos) { }

	// RVA: 0x1313640 Offset: 0x1312A40 VA: 0x181313640
	internal void SetLineInfo2(int lineNo, int linePos) { }

	// RVA: 0x1313820 Offset: 0x1312C20 VA: 0x181313820
	internal void SetValueNode(XmlNodeType type, string value) { }

	// RVA: 0x1313860 Offset: 0x1312C60 VA: 0x181313860
	internal void SetValueNode(XmlNodeType type, char[] chars, int startPos, int len) { }

	// RVA: 0x1313660 Offset: 0x1312A60 VA: 0x181313660
	internal void SetNamedNode(XmlNodeType type, string localName) { }

	// RVA: 0x1313750 Offset: 0x1312B50 VA: 0x181313750
	internal void SetNamedNode(XmlNodeType type, string localName, string prefix, string nameWPrefix) { }

	// RVA: 0x1313920 Offset: 0x1312D20 VA: 0x181313920
	internal void SetValue(string value) { }

	// RVA: 0x13138C0 Offset: 0x1312CC0 VA: 0x1813138C0
	internal void SetValue(char[] chars, int startPos, int len) { }

	// RVA: 0x13135D0 Offset: 0x13129D0 VA: 0x1813135D0
	internal void OnBufferInvalidated() { }

	// RVA: 0x13133F0 Offset: 0x13127F0 VA: 0x1813133F0
	internal void CopyTo(int valueOffset, StringBuilder sb) { }

	// RVA: 0x1313390 Offset: 0x1312790 VA: 0x181313390
	internal int CopyTo(int valueOffset, char[] buffer, int offset, int length) { }

	// RVA: 0x1313520 Offset: 0x1312920 VA: 0x181313520
	internal string GetNameWPrefix(XmlNameTable nt) { }

	// RVA: 0x1313480 Offset: 0x1312880 VA: 0x181313480
	internal string CreateNameWPrefix(XmlNameTable nt) { }

	// RVA: 0x1313940 Offset: 0x1312D40 VA: 0x181313940 Slot: 4
	private int System.IComparable.CompareTo(object obj) { }

}

private class XmlTextReaderImpl.DtdDefaultAttributeInfoToNodeDataComparer : IComparer<object> // TypeDefIndex: 1905
{	// Fields
	private static IComparer<object> s_instance; // 0x2B0ABAC

	// Properties
	internal static IComparer<object> Instance { get; }

	// Methods

	// RVA: 0x1312CA0 Offset: 0x13120A0 VA: 0x181312CA0
	internal static IComparer<object> get_Instance() { }

	// RVA: 0x13129E0 Offset: 0x1311DE0 VA: 0x1813129E0 Slot: 4
	public int Compare(object x, object y) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x1312C40 Offset: 0x1312040 VA: 0x181312C40
	private static void .cctor() { }

}

internal sealed class XmlTextReaderImpl.OnDefaultAttributeUseDelegate : MulticastDelegate // TypeDefIndex: 1906
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xADFD50 Offset: 0xADF150 VA: 0x180ADFD50 Slot: 12
	public virtual void Invoke(IDtdDefaultAttributeInfo defaultAttribute, XmlTextReaderImpl coreReader) { }

	// RVA: 0xADFD10 Offset: 0xADF110 VA: 0x180ADFD10 Slot: 13
	public virtual IAsyncResult BeginInvoke(IDtdDefaultAttributeInfo defaultAttribute, XmlTextReaderImpl coreReader, AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public class XmlTextWriter : XmlWriter // TypeDefIndex: 1908
{	// Fields
	private TextWriter textWriter; // 0x18
	private XmlTextEncoder xmlEncoder; // 0x20
	private Encoding encoding; // 0x28
	private Formatting formatting; // 0x30
	private bool indented; // 0x34
	private int indentation; // 0x38
	private char indentChar; // 0x3C
	private XmlTextWriter.TagInfo[] stack; // 0x40
	private int top; // 0x48
	private XmlTextWriter.State[] stateTable; // 0x50
	private XmlTextWriter.State currentState; // 0x58
	private XmlTextWriter.Token lastToken; // 0x5C
	private XmlTextWriterBase64Encoder base64Encoder; // 0x60
	private char quoteChar; // 0x68
	private char curQuoteChar; // 0x6A
	private bool namespaces; // 0x6C
	private XmlTextWriter.SpecialAttr specialAttr; // 0x70
	private string prefixForXmlNs; // 0x78
	private bool flush; // 0x80
	private XmlTextWriter.Namespace[] nsStack; // 0x88
	private int nsTop; // 0x90
	private Dictionary<string, int> nsHashtable; // 0x98
	private bool useNsHashtable; // 0xA0
	private XmlCharType xmlCharType; // 0xA8
	private static string[] stateName; // 0x0
	private static string[] tokenName; // 0x8
	private static readonly XmlTextWriter.State[] stateTableDefault; // 0x10
	private static readonly XmlTextWriter.State[] stateTableDocument; // 0x18

	// Properties
	public Stream BaseStream { get; }
	public bool Namespaces { set; }
	public Formatting Formatting { set; }
	public char QuoteChar { set; }
	public override WriteState WriteState { get; }

	// Methods

	// RVA: 0x1319AF0 Offset: 0x1318EF0 VA: 0x181319AF0
	internal void .ctor() { }

	// RVA: 0x13199F0 Offset: 0x1318DF0 VA: 0x1813199F0
	public void .ctor(Stream w, Encoding encoding) { }

	// RVA: 0x13198A0 Offset: 0x1318CA0 VA: 0x1813198A0
	public void .ctor(string filename, Encoding encoding) { }

	// RVA: 0x13197D0 Offset: 0x1318BD0 VA: 0x1813197D0
	public void .ctor(TextWriter w) { }

	// RVA: 0x1319C50 Offset: 0x1319050 VA: 0x181319C50
	public Stream get_BaseStream() { }

	// RVA: 0x1319D60 Offset: 0x1319160 VA: 0x181319D60
	public void set_Namespaces(bool value) { }

	// RVA: 0x1319D50 Offset: 0x1319150 VA: 0x181319D50
	public void set_Formatting(Formatting value) { }

	// RVA: 0x1319DE0 Offset: 0x13191E0 VA: 0x181319DE0
	public void set_QuoteChar(char value) { }

	// RVA: 0x1318210 Offset: 0x1317610 VA: 0x181318210 Slot: 5
	public override void WriteStartDocument() { }

	// RVA: 0x13181F0 Offset: 0x13175F0 VA: 0x1813181F0 Slot: 6
	public override void WriteStartDocument(bool standalone) { }

	// RVA: 0x1317110 Offset: 0x1316510 VA: 0x181317110 Slot: 7
	public override void WriteEndDocument() { }

	// RVA: 0x1316D00 Offset: 0x1316100 VA: 0x181316D00 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x1318220 Offset: 0x1317620 VA: 0x181318220 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x1317290 Offset: 0x1316690 VA: 0x181317290 Slot: 10
	public override void WriteEndElement() { }

	// RVA: 0x13177A0 Offset: 0x1316BA0 VA: 0x1813177A0 Slot: 11
	public override void WriteFullEndElement() { }

	// RVA: 0x1317AA0 Offset: 0x1316EA0 VA: 0x181317AA0 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x1317090 Offset: 0x1316490 VA: 0x181317090 Slot: 13
	public override void WriteEndAttribute() { }

	// RVA: 0x13168E0 Offset: 0x1315CE0 VA: 0x1813168E0 Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0x1316B90 Offset: 0x1315F90 VA: 0x181316B90 Slot: 15
	public override void WriteComment(string text) { }

	// RVA: 0x13177B0 Offset: 0x1316BB0 VA: 0x1813177B0 Slot: 16
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x13176F0 Offset: 0x1316AF0 VA: 0x1813176F0 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x1316A30 Offset: 0x1315E30 VA: 0x181316A30 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x13188F0 Offset: 0x1317CF0 VA: 0x1813188F0 Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x1318790 Offset: 0x1317B90 VA: 0x181318790 Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0x1318840 Offset: 0x1317C40 VA: 0x181318840 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x1316AD0 Offset: 0x1315ED0 VA: 0x181316AD0 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x13179E0 Offset: 0x1316DE0 VA: 0x1813179E0 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0x1317940 Offset: 0x1316D40 VA: 0x181317940 Slot: 24
	public override void WriteRaw(string data) { }

	// RVA: 0x1316720 Offset: 0x1315B20 VA: 0x181316720 Slot: 25
	public override void WriteBase64(byte[] buffer, int index, int count) { }

	// RVA: 0x1316830 Offset: 0x1315C30 VA: 0x181316830 Slot: 26
	public override void WriteBinHex(byte[] buffer, int index, int count) { }

	// RVA: 0x1319CE0 Offset: 0x13190E0 VA: 0x181319CE0 Slot: 27
	public override WriteState get_WriteState() { }

	// RVA: 0x1314D30 Offset: 0x1314130 VA: 0x181314D30 Slot: 28
	public override void Close() { }

	// RVA: 0x1314F90 Offset: 0x1314390 VA: 0x181314F90 Slot: 29
	public override void Flush() { }

	// RVA: 0x1315AC0 Offset: 0x1314EC0 VA: 0x181315AC0 Slot: 30
	public override string LookupPrefix(string ns) { }

	// RVA: 0x13161A0 Offset: 0x13155A0 VA: 0x1813161A0
	private void StartDocument(int standalone) { }

	// RVA: 0x1314750 Offset: 0x1313B50 VA: 0x181314750
	private void AutoComplete(XmlTextWriter.Token token) { }

	// RVA: 0x1314700 Offset: 0x1313B00 VA: 0x181314700
	private void AutoCompleteAll() { }

	// RVA: 0x13153D0 Offset: 0x13147D0 VA: 0x1813153D0
	private void InternalWriteEndElement(bool longFormat) { }

	// RVA: 0x13172A0 Offset: 0x13166A0 VA: 0x1813172A0
	private void WriteEndStartTag(bool empty) { }

	// RVA: 0x1317040 Offset: 0x1316440 VA: 0x181317040
	private void WriteEndAttributeQuote() { }

	// RVA: 0x13152E0 Offset: 0x13146E0 VA: 0x1813152E0
	private void Indent(bool beforeEndElement) { }

	// RVA: 0x1315C90 Offset: 0x1315090 VA: 0x181315C90
	private void PushNamespace(string prefix, string ns, bool declared) { }

	// RVA: 0x1314440 Offset: 0x1313840 VA: 0x181314440
	private void AddNamespace(string prefix, string ns, bool declared) { }

	// RVA: 0x1314600 Offset: 0x1313A00 VA: 0x181314600
	private void AddToNamespaceHashtable(int namespaceIndex) { }

	// RVA: 0x1315BC0 Offset: 0x1314FC0 VA: 0x181315BC0
	private void PopNamespaces(int indexFrom, int indexTo) { }

	// RVA: 0x1314FC0 Offset: 0x13143C0 VA: 0x181314FC0
	private string GeneratePrefix() { }

	// RVA: 0x1315740 Offset: 0x1314B40 VA: 0x181315740
	private void InternalWriteProcessingInstruction(string name, string text) { }

	// RVA: 0x13159A0 Offset: 0x1314DA0 VA: 0x1813159A0
	private int LookupNamespace(string prefix) { }

	// RVA: 0x1315840 Offset: 0x1314C40 VA: 0x181315840
	private int LookupNamespaceInCurrentScope(string prefix) { }

	// RVA: 0x1314E50 Offset: 0x1314250 VA: 0x181314E50
	private string FindPrefix(string ns) { }

	// RVA: 0x1316400 Offset: 0x1315800 VA: 0x181316400
	private void ValidateName(string name, bool isNCName) { }

	// RVA: 0x13150B0 Offset: 0x13144B0 VA: 0x1813150B0
	private void HandleSpecialAttribute() { }

	// RVA: 0x1316600 Offset: 0x1315A00 VA: 0x181316600
	private void VerifyPrefixXml(string prefix, string ns) { }

	// RVA: 0x13160C0 Offset: 0x13154C0 VA: 0x1813160C0
	private void PushStack() { }

	// RVA: 0x1314F60 Offset: 0x1314360 VA: 0x181314F60
	private void FlushEncoders() { }

	// RVA: 0x1318D40 Offset: 0x1318140 VA: 0x181318D40
	private static void .cctor() { }

}

private enum XmlTextWriter.NamespaceState // TypeDefIndex: 1909
{	// Fields
	public int value__; // 0x0
	public const XmlTextWriter.NamespaceState Uninitialized = 0;
	public const XmlTextWriter.NamespaceState NotDeclaredButInScope = 1;
	public const XmlTextWriter.NamespaceState DeclaredButNotWrittenOut = 2;
	public const XmlTextWriter.NamespaceState DeclaredAndWrittenOut = 3;

}

private struct XmlTextWriter.TagInfo // TypeDefIndex: 1910
{	// Fields
	internal string name; // 0x0
	internal string prefix; // 0x8
	internal string defaultNs; // 0x10
	internal XmlTextWriter.NamespaceState defaultNsState; // 0x18
	internal XmlSpace xmlSpace; // 0x1C
	internal string xmlLang; // 0x20
	internal int prevNsTop; // 0x28
	internal int prefixCount; // 0x2C
	internal bool mixed; // 0x30

	// Methods

	// RVA: 0x1E1000 Offset: 0x1E0400 VA: 0x1801E1000
	internal void Init(int nsTop) { }

}

private struct XmlTextWriter.Namespace // TypeDefIndex: 1911
{	// Fields
	internal string prefix; // 0x0
	internal string ns; // 0x8
	internal bool declared; // 0x10
	internal int prevNsIndex; // 0x14

	// Methods

	// RVA: 0x1E0CB0 Offset: 0x1E00B0 VA: 0x1801E0CB0
	internal void Set(string prefix, string ns, bool declared) { }

}

private enum XmlTextWriter.SpecialAttr // TypeDefIndex: 1912
{	// Fields
	public int value__; // 0x0
	public const XmlTextWriter.SpecialAttr None = 0;
	public const XmlTextWriter.SpecialAttr XmlSpace = 1;
	public const XmlTextWriter.SpecialAttr XmlLang = 2;
	public const XmlTextWriter.SpecialAttr XmlNs = 3;

}

private enum XmlTextWriter.State // TypeDefIndex: 1913
{	// Fields
	public int value__; // 0x0
	public const XmlTextWriter.State Start = 0;
	public const XmlTextWriter.State Prolog = 1;
	public const XmlTextWriter.State PostDTD = 2;
	public const XmlTextWriter.State Element = 3;
	public const XmlTextWriter.State Attribute = 4;
	public const XmlTextWriter.State Content = 5;
	public const XmlTextWriter.State AttrOnly = 6;
	public const XmlTextWriter.State Epilog = 7;
	public const XmlTextWriter.State Error = 8;
	public const XmlTextWriter.State Closed = 9;

}

private enum XmlTextWriter.Token // TypeDefIndex: 1914
{	// Fields
	public int value__; // 0x0
	public const XmlTextWriter.Token PI = 0;
	public const XmlTextWriter.Token Doctype = 1;
	public const XmlTextWriter.Token Comment = 2;
	public const XmlTextWriter.Token CData = 3;
	public const XmlTextWriter.Token StartElement = 4;
	public const XmlTextWriter.Token EndElement = 5;
	public const XmlTextWriter.Token LongEndElement = 6;
	public const XmlTextWriter.Token StartAttribute = 7;
	public const XmlTextWriter.Token EndAttribute = 8;
	public const XmlTextWriter.Token Content = 9;
	public const XmlTextWriter.Token Base64 = 10;
	public const XmlTextWriter.Token RawData = 11;
	public const XmlTextWriter.Token Whitespace = 12;
	public const XmlTextWriter.Token Empty = 13;

}

internal class XmlUtf8RawTextWriter : XmlRawWriter // TypeDefIndex: 1915
{	// Fields
	private readonly bool useAsync; // 0x28
	protected byte[] bufBytes; // 0x30
	protected Stream stream; // 0x38
	protected Encoding encoding; // 0x40
	protected XmlCharType xmlCharType; // 0x48
	protected int bufPos; // 0x50
	protected int textPos; // 0x54
	protected int contentPos; // 0x58
	protected int cdataPos; // 0x5C
	protected int attrEndPos; // 0x60
	protected int bufLen; // 0x64
	protected bool writeToNull; // 0x68
	protected bool hadDoubleBracket; // 0x69
	protected bool inAttributeValue; // 0x6A
	protected NewLineHandling newLineHandling; // 0x6C
	protected bool closeOutput; // 0x70
	protected bool omitXmlDeclaration; // 0x71
	protected string newLineChars; // 0x78
	protected bool checkCharacters; // 0x80
	protected XmlStandalone standalone; // 0x84
	protected XmlOutputMethod outputMethod; // 0x88
	protected bool autoXmlDeclaration; // 0x8C
	protected bool mergeCDataSections; // 0x8D

	// Properties
	internal override bool SupportsNamespaceDeclarationInChunks { get; }

	// Methods

	// RVA: 0x131E8F0 Offset: 0x131DCF0 VA: 0x18131E8F0
	protected void .ctor(XmlWriterSettings settings) { }

	// RVA: 0x131E6A0 Offset: 0x131DAA0 VA: 0x18131E6A0
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x131E4C0 Offset: 0x131D8C0 VA: 0x18131E4C0 Slot: 36
	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x131E450 Offset: 0x131D850 VA: 0x18131E450 Slot: 37
	internal override void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0x131CE50 Offset: 0x131C250 VA: 0x18131CE50 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x131E040 Offset: 0x131D440 VA: 0x18131E040 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x131BB00 Offset: 0x131AF00 VA: 0x18131BB00 Slot: 38
	internal override void StartElementContent() { }

	// RVA: 0x131D4B0 Offset: 0x131C8B0 VA: 0x18131D4B0 Slot: 40
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x131D7C0 Offset: 0x131CBC0 VA: 0x18131D7C0 Slot: 41
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x131DEF0 Offset: 0x131D2F0 VA: 0x18131DEF0 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x131D460 Offset: 0x131C860 VA: 0x18131D460 Slot: 13
	public override void WriteEndAttribute() { }

	// RVA: 0x11BC320 Offset: 0x11BB720 VA: 0x1811BC320 Slot: 42
	internal override void WriteNamespaceDeclaration(string prefix, string namespaceName) { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 43
	internal override bool get_SupportsNamespaceDeclarationInChunks() { }

	// RVA: 0x131E130 Offset: 0x131D530 VA: 0x18131E130 Slot: 44
	internal override void WriteStartNamespaceDeclaration(string prefix) { }

	// RVA: 0x131D6A0 Offset: 0x131CAA0 VA: 0x18131D6A0 Slot: 45
	internal override void WriteEndNamespaceDeclaration() { }

	// RVA: 0x131C4C0 Offset: 0x131B8C0 VA: 0x18131C4C0 Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0x131CCC0 Offset: 0x131C0C0 VA: 0x18131CCC0 Slot: 15
	public override void WriteComment(string text) { }

	// RVA: 0x131D990 Offset: 0x131CD90 VA: 0x18131D990 Slot: 16
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x131D6F0 Offset: 0x131CAF0 VA: 0x18131D6F0 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x131C770 Offset: 0x131BB70 VA: 0x18131C770 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x131E270 Offset: 0x131D670 VA: 0x18131E270 Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x131E270 Offset: 0x131D670 VA: 0x18131E270 Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0x131E2D0 Offset: 0x131D6D0 VA: 0x18131E2D0 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x12EDAF0 Offset: 0x12ECEF0 VA: 0x1812EDAF0 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x131DE50 Offset: 0x131D250 VA: 0x18131DE50 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0x131DEA0 Offset: 0x131D2A0 VA: 0x18131DEA0 Slot: 24
	public override void WriteRaw(string data) { }

	// RVA: 0x131AF60 Offset: 0x131A360 VA: 0x18131AF60 Slot: 28
	public override void Close() { }

	// RVA: 0x131B640 Offset: 0x131AA40 VA: 0x18131B640 Slot: 29
	public override void Flush() { }

	// RVA: 0x131B3A0 Offset: 0x131A7A0 VA: 0x18131B3A0 Slot: 48
	protected virtual void FlushBuffer() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	private void FlushEncoder() { }

	// RVA: 0x131BEC0 Offset: 0x131B2C0 VA: 0x18131BEC0
	protected void WriteAttributeTextBlock(char* pSrc, char* pSrcEnd) { }

	// RVA: 0x131D170 Offset: 0x131C570 VA: 0x18131D170
	protected void WriteElementTextBlock(char* pSrc, char* pSrcEnd) { }

	// RVA: 0x131BAB0 Offset: 0x131AEB0 VA: 0x18131BAB0
	protected void RawText(string s) { }

	// RVA: 0x131B880 Offset: 0x131AC80 VA: 0x18131B880
	protected void RawText(char* pSrcBegin, char* pSrcEnd) { }

	// RVA: 0x131DB00 Offset: 0x131CF00 VA: 0x18131DB00
	protected void WriteRawWithCharChecking(char* pSrcBegin, char* pSrcEnd) { }

	// RVA: 0x131C960 Offset: 0x131BD60 VA: 0x18131C960
	protected void WriteCommentOrPi(string text, int stopChar) { }

	// RVA: 0x131C190 Offset: 0x131B590 VA: 0x18131C190
	protected void WriteCDataSection(string text) { }

	// RVA: 0x131B800 Offset: 0x131AC00 VA: 0x18131B800
	private static bool IsSurrogateByte(byte b) { }

	// RVA: 0x131B210 Offset: 0x131A610 VA: 0x18131B210
	private static byte* EncodeSurrogate(char* pSrc, char* pSrcEnd, byte* pDst) { }

	// RVA: 0x131B690 Offset: 0x131AA90 VA: 0x18131B690
	private byte* InvalidXmlChar(int ch, byte* pDst, bool entitize) { }

	// RVA: 0x131B0E0 Offset: 0x131A4E0 VA: 0x18131B0E0
	internal void EncodeChar(ref char* pSrc, char* pSrcEnd, ref byte* pDst) { }

	// RVA: 0x131B1C0 Offset: 0x131A5C0 VA: 0x18131B1C0
	internal static byte* EncodeMultibyteUTF8(int ch, byte* pDst) { }

	// RVA: 0x131AEB0 Offset: 0x131A2B0 VA: 0x18131AEB0
	internal static void CharToUTF8(ref char* pSrc, char* pSrcEnd, ref byte* pDst) { }

	// RVA: 0x131D910 Offset: 0x131CD10 VA: 0x18131D910
	protected byte* WriteNewLine(byte* pDst) { }

	// RVA: 0x131B820 Offset: 0x131AC20 VA: 0x18131B820
	protected static byte* LtEntity(byte* pDst) { }

	// RVA: 0x131B680 Offset: 0x131AA80 VA: 0x18131B680
	protected static byte* GtEntity(byte* pDst) { }

	// RVA: 0x131ADF0 Offset: 0x131A1F0 VA: 0x18131ADF0
	protected static byte* AmpEntity(byte* pDst) { }

	// RVA: 0x131B830 Offset: 0x131AC30 VA: 0x18131B830
	protected static byte* QuoteEntity(byte* pDst) { }

	// RVA: 0x131BB50 Offset: 0x131AF50 VA: 0x18131BB50
	protected static byte* TabEntity(byte* pDst) { }

	// RVA: 0x131B810 Offset: 0x131AC10 VA: 0x18131B810
	protected static byte* LineFeedEntity(byte* pDst) { }

	// RVA: 0x131AE00 Offset: 0x131A200 VA: 0x18131AE00
	protected static byte* CarriageReturnEntity(byte* pDst) { }

	// RVA: 0x131AE10 Offset: 0x131A210 VA: 0x18131AE10
	private static byte* CharEntity(byte* pDst, char ch) { }

	// RVA: 0x131B860 Offset: 0x131AC60 VA: 0x18131B860
	protected static byte* RawStartCData(byte* pDst) { }

	// RVA: 0x131B850 Offset: 0x131AC50 VA: 0x18131B850
	protected static byte* RawEndCData(byte* pDst) { }

	// RVA: 0x131BB60 Offset: 0x131AF60 VA: 0x18131BB60
	protected void ValidateContentChars(string chars, string propertyName, bool allowOnlyWhitespace) { }

}

internal class XmlUtf8RawTextWriterIndent : XmlUtf8RawTextWriter // TypeDefIndex: 1916
{	// Fields
	protected int indentLevel; // 0x90
	protected bool newLineOnAttributes; // 0x94
	protected string indentChars; // 0x98
	protected bool mixedContent; // 0xA0
	private BitStack mixedContentStack; // 0xA8
	protected ConformanceLevel conformanceLevel; // 0xB0

	// Methods

	// RVA: 0x131ACD0 Offset: 0x131A0D0 VA: 0x18131ACD0
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x131A6B0 Offset: 0x1319AB0 VA: 0x18131A6B0 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x131AB20 Offset: 0x1319F20 VA: 0x18131AB20 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x131A550 Offset: 0x1319950 VA: 0x18131A550 Slot: 38
	internal override void StartElementContent() { }

	// RVA: 0x2F95C0 Offset: 0x2F89C0 VA: 0x1802F95C0 Slot: 39
	internal override void OnRootElement(ConformanceLevel currentConformanceLevel) { }

	// RVA: 0x131A720 Offset: 0x1319B20 VA: 0x18131A720 Slot: 40
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x131A880 Offset: 0x1319C80 VA: 0x18131A880 Slot: 41
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x131AAC0 Offset: 0x1319EC0 VA: 0x18131AAC0 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x131A5F0 Offset: 0x13199F0 VA: 0x18131A5F0 Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0x131A670 Offset: 0x1319A70 VA: 0x18131A670 Slot: 15
	public override void WriteComment(string text) { }

	// RVA: 0x131A9B0 Offset: 0x1319DB0 VA: 0x18131A9B0 Slot: 16
	public override void WriteProcessingInstruction(string target, string text) { }

	// RVA: 0x131A7B0 Offset: 0x1319BB0 VA: 0x18131A7B0 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x131A600 Offset: 0x1319A00 VA: 0x18131A600 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x131ACC0 Offset: 0x131A0C0 VA: 0x18131ACC0 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x131AC50 Offset: 0x131A050 VA: 0x18131AC50 Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x131AC50 Offset: 0x131A050 VA: 0x18131AC50 Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0x131A610 Offset: 0x1319A10 VA: 0x18131A610 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x131AA60 Offset: 0x1319E60 VA: 0x18131AA60 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0x131AA00 Offset: 0x1319E00 VA: 0x18131AA00 Slot: 24
	public override void WriteRaw(string data) { }

	// RVA: 0x131A5D0 Offset: 0x13199D0 VA: 0x18131A5D0 Slot: 25
	public override void WriteBase64(byte[] buffer, int index, int count) { }

	// RVA: 0x131A440 Offset: 0x1319840 VA: 0x18131A440
	private void Init(XmlWriterSettings settings) { }

	// RVA: 0x131A910 Offset: 0x1319D10 VA: 0x18131A910
	private void WriteIndent() { }

}

public class XmlValidatingReader : XmlReader // TypeDefIndex: 1917
{	// Fields
	private XmlValidatingReaderImpl impl; // 0x10

	// Properties
	public override XmlNodeType NodeType { get; }
	public override string LocalName { get; }
	public override string NamespaceURI { get; }
	public override string Prefix { get; }
	public override string Value { get; }
	public override int Depth { get; }
	public override string BaseURI { get; }
	public override bool IsEmptyElement { get; }
	public override int AttributeCount { get; }
	public override bool EOF { get; }
	public override ReadState ReadState { get; }
	public override XmlNameTable NameTable { get; }
	public bool Namespaces { get; }

	// Methods

	// RVA: 0xB14680 Offset: 0xB13A80 VA: 0x180B14680 Slot: 6
	public override XmlNodeType get_NodeType() { }

	// RVA: 0xBC4220 Offset: 0xBC3620 VA: 0x180BC4220 Slot: 8
	public override string get_LocalName() { }

	// RVA: 0xBC42E0 Offset: 0xBC36E0 VA: 0x180BC42E0 Slot: 9
	public override string get_NamespaceURI() { }

	// RVA: 0xBC4350 Offset: 0xBC3750 VA: 0x180BC4350 Slot: 10
	public override string get_Prefix() { }

	// RVA: 0xBC43B0 Offset: 0xBC37B0 VA: 0x180BC43B0 Slot: 11
	public override string get_Value() { }

	// RVA: 0xBC40D0 Offset: 0xBC34D0 VA: 0x180BC40D0 Slot: 12
	public override int get_Depth() { }

	// RVA: 0xBC40A0 Offset: 0xBC34A0 VA: 0x180BC40A0 Slot: 13
	public override string get_BaseURI() { }

	// RVA: 0xBC4190 Offset: 0xBC3590 VA: 0x180BC4190 Slot: 14
	public override bool get_IsEmptyElement() { }

	// RVA: 0xB147D0 Offset: 0xB13BD0 VA: 0x180B147D0 Slot: 21
	public override int get_AttributeCount() { }

	// RVA: 0xBC3920 Offset: 0xBC2D20 VA: 0x180BC3920 Slot: 22
	public override string GetAttribute(string name) { }

	// RVA: 0xBC3950 Offset: 0xBC2D50 VA: 0x180BC3950 Slot: 23
	public override string GetAttribute(string localName, string namespaceURI) { }

	// RVA: 0xBC3980 Offset: 0xBC2D80 VA: 0x180BC3980 Slot: 24
	public override string GetAttribute(int i) { }

	// RVA: 0xBC3A20 Offset: 0xBC2E20 VA: 0x180BC3A20 Slot: 25
	public override bool MoveToAttribute(string name) { }

	// RVA: 0xBC3A80 Offset: 0xBC2E80 VA: 0x180BC3A80 Slot: 27
	public override bool MoveToFirstAttribute() { }

	// RVA: 0xBC3AB0 Offset: 0xBC2EB0 VA: 0x180BC3AB0 Slot: 28
	public override bool MoveToNextAttribute() { }

	// RVA: 0xBC3A50 Offset: 0xBC2E50 VA: 0x180BC3A50 Slot: 29
	public override bool MoveToElement() { }

	// RVA: 0xBC3AE0 Offset: 0xBC2EE0 VA: 0x180BC3AE0 Slot: 30
	public override bool ReadAttributeValue() { }

	// RVA: 0xBC3B40 Offset: 0xBC2F40 VA: 0x180BC3B40 Slot: 31
	public override bool Read() { }

	// RVA: 0xBC4130 Offset: 0xBC3530 VA: 0x180BC4130 Slot: 32
	public override bool get_EOF() { }

	// RVA: 0xB9A640 Offset: 0xB99A40 VA: 0x180B9A640 Slot: 34
	public override ReadState get_ReadState() { }

	// RVA: 0xBC4250 Offset: 0xBC3650 VA: 0x180BC4250 Slot: 36
	public override XmlNameTable get_NameTable() { }

	// RVA: 0xBC39B0 Offset: 0xBC2DB0 VA: 0x180BC39B0 Slot: 37
	public override string LookupNamespace(string prefix) { }

	// RVA: 0xBC3B70 Offset: 0xBC2F70 VA: 0x180BC3B70 Slot: 39
	public override void ResolveEntity() { }

	// RVA: 0x131FFC0 Offset: 0x131F3C0 VA: 0x18131FFC0
	public bool get_Namespaces() { }

}

internal sealed class XmlValidatingReaderImpl : XmlReader, IXmlLineInfo, IXmlNamespaceResolver // TypeDefIndex: 1918
{	// Fields
	private XmlReader coreReader; // 0x10
	private XmlTextReaderImpl coreReaderImpl; // 0x18
	private IXmlNamespaceResolver coreReaderNSResolver; // 0x20
	private ValidationType validationType; // 0x28
	private BaseValidator validator; // 0x30
	private XmlSchemaCollection schemaCollection; // 0x38
	private bool processIdentityConstraints; // 0x40
	private XmlValidatingReaderImpl.ParsingFunction parsingFunction; // 0x44
	private XmlValidatingReaderImpl.ValidationEventHandling eventHandling; // 0x48
	private XmlParserContext parserContext; // 0x50
	private ReadContentAsBinaryHelper readBinaryHelper; // 0x58
	private XmlReader outerReader; // 0x60
	private static XmlResolver s_tempResolver; // 0x0

	// Properties
	public override XmlReaderSettings Settings { get; }
	public override XmlNodeType NodeType { get; }
	public override string Name { get; }
	public override string LocalName { get; }
	public override string NamespaceURI { get; }
	public override string Prefix { get; }
	public override string Value { get; }
	public override int Depth { get; }
	public override string BaseURI { get; }
	public override bool IsEmptyElement { get; }
	public override bool IsDefault { get; }
	public override char QuoteChar { get; }
	public override XmlSpace XmlSpace { get; }
	public override string XmlLang { get; }
	public override ReadState ReadState { get; }
	public override bool EOF { get; }
	public override XmlNameTable NameTable { get; }
	public override int AttributeCount { get; }
	public override bool CanResolveEntity { get; }
	public int LineNumber { get; }
	public int LinePosition { get; }
	internal ValidationType ValidationType { get; }
	internal XmlSchemaCollection Schemas { get; }
	internal bool Namespaces { get; }
	internal BaseValidator Validator { get; set; }
	internal override XmlNamespaceManager NamespaceManager { get; }
	internal bool StandAlone { get; }
	internal object SchemaTypeObject { set; }
	internal object TypedValueObject { get; set; }
	internal override IDtdInfo DtdInfo { get; }

	// Methods

	// RVA: 0x131F880 Offset: 0x131EC80 VA: 0x18131F880
	internal void .ctor(XmlReader reader, ValidationEventHandler settingsEventHandler, bool processIdentityConstraints) { }

	// RVA: 0x131FE70 Offset: 0x131F270 VA: 0x18131FE70 Slot: 5
	public override XmlReaderSettings get_Settings() { }

	// RVA: 0xB14680 Offset: 0xB13A80 VA: 0x180B14680 Slot: 6
	public override XmlNodeType get_NodeType() { }

	// RVA: 0xBC4280 Offset: 0xBC3680 VA: 0x180BC4280 Slot: 7
	public override string get_Name() { }

	// RVA: 0xBC4220 Offset: 0xBC3620 VA: 0x180BC4220 Slot: 8
	public override string get_LocalName() { }

	// RVA: 0xBC42E0 Offset: 0xBC36E0 VA: 0x180BC42E0 Slot: 9
	public override string get_NamespaceURI() { }

	// RVA: 0xBC4350 Offset: 0xBC3750 VA: 0x180BC4350 Slot: 10
	public override string get_Prefix() { }

	// RVA: 0xBC43B0 Offset: 0xBC37B0 VA: 0x180BC43B0 Slot: 11
	public override string get_Value() { }

	// RVA: 0xBC40D0 Offset: 0xBC34D0 VA: 0x180BC40D0 Slot: 12
	public override int get_Depth() { }

	// RVA: 0xBC40A0 Offset: 0xBC34A0 VA: 0x180BC40A0 Slot: 13
	public override string get_BaseURI() { }

	// RVA: 0xBC4190 Offset: 0xBC3590 VA: 0x180BC4190 Slot: 14
	public override bool get_IsEmptyElement() { }

	// RVA: 0xBC4160 Offset: 0xBC3560 VA: 0x180BC4160 Slot: 15
	public override bool get_IsDefault() { }

	// RVA: 0xBC4380 Offset: 0xBC3780 VA: 0x180BC4380 Slot: 16
	public override char get_QuoteChar() { }

	// RVA: 0xBC4410 Offset: 0xBC3810 VA: 0x180BC4410 Slot: 17
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0xBC43E0 Offset: 0xBC37E0 VA: 0x180BC43E0 Slot: 18
	public override string get_XmlLang() { }

	// RVA: 0x131FE30 Offset: 0x131F230 VA: 0x18131FE30 Slot: 34
	public override ReadState get_ReadState() { }

	// RVA: 0xBC4130 Offset: 0xBC3530 VA: 0x180BC4130 Slot: 32
	public override bool get_EOF() { }

	// RVA: 0xBC4250 Offset: 0xBC3650 VA: 0x180BC4250 Slot: 36
	public override XmlNameTable get_NameTable() { }

	// RVA: 0xB147D0 Offset: 0xB13BD0 VA: 0x180B147D0 Slot: 21
	public override int get_AttributeCount() { }

	// RVA: 0xBC3920 Offset: 0xBC2D20 VA: 0x180BC3920 Slot: 22
	public override string GetAttribute(string name) { }

	// RVA: 0xBC3950 Offset: 0xBC2D50 VA: 0x180BC3950 Slot: 23
	public override string GetAttribute(string localName, string namespaceURI) { }

	// RVA: 0xBC3980 Offset: 0xBC2D80 VA: 0x180BC3980 Slot: 24
	public override string GetAttribute(int i) { }

	// RVA: 0x131ED50 Offset: 0x131E150 VA: 0x18131ED50 Slot: 25
	public override bool MoveToAttribute(string name) { }

	// RVA: 0x131EDA0 Offset: 0x131E1A0 VA: 0x18131EDA0 Slot: 26
	public override void MoveToAttribute(int i) { }

	// RVA: 0x131EE30 Offset: 0x131E230 VA: 0x18131EE30 Slot: 27
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x131EE80 Offset: 0x131E280 VA: 0x18131EE80 Slot: 28
	public override bool MoveToNextAttribute() { }

	// RVA: 0x131EDE0 Offset: 0x131E1E0 VA: 0x18131EDE0 Slot: 29
	public override bool MoveToElement() { }

	// RVA: 0x131F2C0 Offset: 0x131E6C0 VA: 0x18131F2C0 Slot: 31
	public override bool Read() { }

	// RVA: 0x131EA20 Offset: 0x131DE20 VA: 0x18131EA20 Slot: 33
	public override void Close() { }

	// RVA: 0x131EC00 Offset: 0x131E000 VA: 0x18131EC00 Slot: 37
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x131F190 Offset: 0x131E590 VA: 0x18131F190 Slot: 30
	public override bool ReadAttributeValue() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 38
	public override bool get_CanResolveEntity() { }

	// RVA: 0x131F4E0 Offset: 0x131E8E0 VA: 0x18131F4E0 Slot: 39
	public override void ResolveEntity() { }

	// RVA: 0x131EC90 Offset: 0x131E090 VA: 0x18131EC90
	internal void MoveOffEntityReference() { }

	// RVA: 0x131F1F0 Offset: 0x131E5F0 VA: 0x18131F1F0 Slot: 42
	public override string ReadString() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 53
	public bool HasLineInfo() { }

	// RVA: 0x131FCA0 Offset: 0x131F0A0 VA: 0x18131FCA0 Slot: 54
	public int get_LineNumber() { }

	// RVA: 0x131FD40 Offset: 0x131F140 VA: 0x18131FD40 Slot: 55
	public int get_LinePosition() { }

	// RVA: 0x131EA60 Offset: 0x131DE60 VA: 0x18131EA60 Slot: 56
	private IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0xBC0370 Offset: 0xBBF770 VA: 0x180BC0370 Slot: 57
	private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0x131EC30 Offset: 0x131E030 VA: 0x18131EC30 Slot: 58
	private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

	// RVA: 0x131EA60 Offset: 0x131DE60 VA: 0x18131EA60
	internal IDictionary<string, string> GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x131EC30 Offset: 0x131E030 VA: 0x18131EC30
	internal string LookupPrefix(string namespaceName) { }

	// RVA: 0x4BB390 Offset: 0x4BA790 VA: 0x1804BB390
	internal ValidationType get_ValidationType() { }

	// RVA: 0x5DCC00 Offset: 0x5DC000 VA: 0x1805DCC00
	internal XmlSchemaCollection get_Schemas() { }

	// RVA: 0x131FE10 Offset: 0x131F210 VA: 0x18131FE10
	internal bool get_Namespaces() { }

	// RVA: 0x131EED0 Offset: 0x131E2D0 VA: 0x18131EED0
	private void ParseDtdFromParserContext() { }

	// RVA: 0x131F800 Offset: 0x131EC00 VA: 0x18131F800
	private void ValidateDtd() { }

	// RVA: 0x131F450 Offset: 0x131E850 VA: 0x18131F450
	private void ResolveEntityInternally() { }

	// RVA: 0x131F520 Offset: 0x131E920 VA: 0x18131F520
	private void SetupValidation(ValidationType valType) { }

	// RVA: 0x131EB20 Offset: 0x131DF20 VA: 0x18131EB20
	private XmlResolver GetResolver() { }

	// RVA: 0x131F080 Offset: 0x131E480 VA: 0x18131F080
	private void ProcessCoreReaderEvent() { }

	// RVA: 0x4A2EE0 Offset: 0x4A22E0 VA: 0x1804A2EE0
	internal BaseValidator get_Validator() { }

	// RVA: 0x4A2F10 Offset: 0x4A2310 VA: 0x1804A2F10
	internal void set_Validator(BaseValidator value) { }

	// RVA: 0x131FDE0 Offset: 0x131F1E0 VA: 0x18131FDE0 Slot: 51
	internal override XmlNamespaceManager get_NamespaceManager() { }

	// RVA: 0x131FF40 Offset: 0x131F340 VA: 0x18131FF40
	internal bool get_StandAlone() { }

	// RVA: 0x131FF80 Offset: 0x131F380 VA: 0x18131FF80
	internal void set_SchemaTypeObject(object value) { }

	// RVA: 0x131FF60 Offset: 0x131F360 VA: 0x18131FF60
	internal object get_TypedValueObject() { }

	// RVA: 0x131FFA0 Offset: 0x131F3A0 VA: 0x18131FFA0
	internal void set_TypedValueObject(object value) { }

	// RVA: 0x131EA00 Offset: 0x131DE00 VA: 0x18131EA00
	internal bool AddDefaultAttribute(SchemaAttDef attdef) { }

	// RVA: 0x131FC70 Offset: 0x131F070 VA: 0x18131FC70 Slot: 52
	internal override IDtdInfo get_DtdInfo() { }

	// RVA: 0x131F6C0 Offset: 0x131EAC0 VA: 0x18131F6C0
	internal void ValidateDefaultAttributeOnUse(IDtdDefaultAttributeInfo defaultAttribute, XmlTextReaderImpl coreReader) { }

}

private enum XmlValidatingReaderImpl.ParsingFunction // TypeDefIndex: 1919
{	// Fields
	public int value__; // 0x0
	public const XmlValidatingReaderImpl.ParsingFunction Read = 0;
	public const XmlValidatingReaderImpl.ParsingFunction Init = 1;
	public const XmlValidatingReaderImpl.ParsingFunction ParseDtdFromContext = 2;
	public const XmlValidatingReaderImpl.ParsingFunction ResolveEntityInternally = 3;
	public const XmlValidatingReaderImpl.ParsingFunction InReadBinaryContent = 4;
	public const XmlValidatingReaderImpl.ParsingFunction ReaderClosed = 5;
	public const XmlValidatingReaderImpl.ParsingFunction Error = 6;
	public const XmlValidatingReaderImpl.ParsingFunction None = 7;

}

internal class XmlValidatingReaderImpl.ValidationEventHandling : IValidationEventHandling // TypeDefIndex: 1920
{	// Fields
	private XmlValidatingReaderImpl reader; // 0x10
	private ValidationEventHandler eventHandler; // 0x18

	// Properties
	private object System.Xml.IValidationEventHandling.EventHandler { get; }

	// Methods

	// RVA: 0x6C0000 Offset: 0x6BF400 VA: 0x1806C0000
	internal void .ctor(XmlValidatingReaderImpl reader) { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 4
	private object System.Xml.IValidationEventHandling.get_EventHandler() { }

	// RVA: 0x13141F0 Offset: 0x13135F0 VA: 0x1813141F0 Slot: 5
	private void System.Xml.IValidationEventHandling.SendEvent(Exception exception, XmlSeverityType severity) { }

	// RVA: 0x1314170 Offset: 0x1313570 VA: 0x181314170
	internal void AddHandler(ValidationEventHandler handler) { }

}

internal class XmlWellFormedWriter : XmlWriter // TypeDefIndex: 1921
{	// Fields
	private XmlWriter writer; // 0x18
	private XmlRawWriter rawWriter; // 0x20
	private IXmlNamespaceResolver predefinedNamespaces; // 0x28
	private XmlWellFormedWriter.Namespace[] nsStack; // 0x30
	private int nsTop; // 0x38
	private Dictionary<string, int> nsHashtable; // 0x40
	private bool useNsHashtable; // 0x48
	private XmlWellFormedWriter.ElementScope[] elemScopeStack; // 0x50
	private int elemTop; // 0x58
	private XmlWellFormedWriter.AttrName[] attrStack; // 0x60
	private int attrCount; // 0x68
	private Dictionary<string, int> attrHashTable; // 0x70
	private XmlWellFormedWriter.SpecialAttribute specAttr; // 0x78
	private XmlWellFormedWriter.AttributeValueCache attrValueCache; // 0x80
	private string curDeclPrefix; // 0x88
	private XmlWellFormedWriter.State[] stateTable; // 0x90
	private XmlWellFormedWriter.State currentState; // 0x98
	private bool checkCharacters; // 0x9C
	private bool omitDuplNamespaces; // 0x9D
	private bool writeEndDocumentOnClose; // 0x9E
	private ConformanceLevel conformanceLevel; // 0xA0
	private bool dtdWritten; // 0xA4
	private bool xmlDeclFollows; // 0xA5
	private XmlCharType xmlCharType; // 0xA8
	private SecureStringHasher hasher; // 0xB0
	internal static readonly string[] stateName; // 0x0
	internal static readonly string[] tokenName; // 0x8
	private static WriteState[] state2WriteState; // 0x10
	private static readonly XmlWellFormedWriter.State[] StateTableDocument; // 0x18
	private static readonly XmlWellFormedWriter.State[] StateTableAuto; // 0x20

	// Properties
	public override WriteState WriteState { get; }
	internal XmlRawWriter RawWriter { get; }
	private bool SaveAttrValue { get; }
	private bool InBase64 { get; }
	private bool IsClosedOrErrorState { get; }

	// Methods

	// RVA: 0x1326790 Offset: 0x1325B90 VA: 0x181326790
	internal void .ctor(XmlWriter writer, XmlWriterSettings settings) { }

	// RVA: 0x1326CD0 Offset: 0x13260D0 VA: 0x181326CD0 Slot: 27
	public override WriteState get_WriteState() { }

	// RVA: 0x1324F90 Offset: 0x1324390 VA: 0x181324F90 Slot: 5
	public override void WriteStartDocument() { }

	// RVA: 0x1324FA0 Offset: 0x13243A0 VA: 0x181324FA0 Slot: 6
	public override void WriteStartDocument(bool standalone) { }

	// RVA: 0x1323C60 Offset: 0x1323060 VA: 0x181323C60 Slot: 7
	public override void WriteEndDocument() { }

	// RVA: 0x1323010 Offset: 0x1322410 VA: 0x181323010 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x1324FD0 Offset: 0x13243D0 VA: 0x181324FD0 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x1323D70 Offset: 0x1323170 VA: 0x181323D70 Slot: 10
	public override void WriteEndElement() { }

	// RVA: 0x1324060 Offset: 0x1323460 VA: 0x181324060 Slot: 11
	public override void WriteFullEndElement() { }

	// RVA: 0x1324800 Offset: 0x1323C00 VA: 0x181324800 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string namespaceName) { }

	// RVA: 0x13233C0 Offset: 0x13227C0 VA: 0x1813233C0 Slot: 13
	public override void WriteEndAttribute() { }

	// RVA: 0x1322A10 Offset: 0x1321E10 VA: 0x181322A10 Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0x1322F50 Offset: 0x1322350 VA: 0x181322F50 Slot: 15
	public override void WriteComment(string text) { }

	// RVA: 0x1324230 Offset: 0x1323630 VA: 0x181324230 Slot: 16
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x1323F40 Offset: 0x1323340 VA: 0x181323F40 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x1322AD0 Offset: 0x1321ED0 VA: 0x181322AD0 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x1325440 Offset: 0x1324840 VA: 0x181325440 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x13257E0 Offset: 0x1324BE0 VA: 0x1813257E0 Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x13252E0 Offset: 0x13246E0 VA: 0x1813252E0 Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0x1322CB0 Offset: 0x13220B0 VA: 0x181322CB0 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x1324420 Offset: 0x1323820 VA: 0x181324420 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0x13246C0 Offset: 0x1323AC0 VA: 0x1813246C0 Slot: 24
	public override void WriteRaw(string data) { }

	// RVA: 0x1322780 Offset: 0x1321B80 VA: 0x181322780 Slot: 25
	public override void WriteBase64(byte[] buffer, int index, int count) { }

	// RVA: 0x1320C80 Offset: 0x1320080 VA: 0x181320C80 Slot: 28
	public override void Close() { }

	// RVA: 0x1320F90 Offset: 0x1320390 VA: 0x181320F90 Slot: 29
	public override void Flush() { }

	// RVA: 0x13216D0 Offset: 0x1320AD0 VA: 0x1813216D0 Slot: 30
	public override string LookupPrefix(string ns) { }

	// RVA: 0x1325690 Offset: 0x1324A90 VA: 0x181325690 Slot: 31
	public override void WriteValue(string value) { }

	// RVA: 0x1322920 Offset: 0x1321D20 VA: 0x181322920 Slot: 26
	public override void WriteBinHex(byte[] buffer, int index, int count) { }

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	internal XmlRawWriter get_RawWriter() { }

	// RVA: 0xB242B0 Offset: 0xB236B0 VA: 0x180B242B0
	private bool get_SaveAttrValue() { }

	// RVA: 0x1326CA0 Offset: 0x13260A0 VA: 0x181326CA0
	private bool get_InBase64() { }

	// RVA: 0x13222B0 Offset: 0x13216B0 VA: 0x1813222B0
	private void SetSpecialAttribute(XmlWellFormedWriter.SpecialAttribute special) { }

	// RVA: 0x1324E30 Offset: 0x1324230 VA: 0x181324E30
	private void WriteStartDocumentImpl(XmlStandalone standalone) { }

	// RVA: 0x1322560 Offset: 0x1321960 VA: 0x181322560
	private void StartFragment() { }

	// RVA: 0x1321E70 Offset: 0x1321270 VA: 0x181321E70
	private void PushNamespaceImplicit(string prefix, string ns) { }

	// RVA: 0x1321950 Offset: 0x1320D50 VA: 0x181321950
	private bool PushNamespaceExplicit(string prefix, string ns) { }

	// RVA: 0x1320330 Offset: 0x131F730 VA: 0x181320330
	private void AddNamespace(string prefix, string ns, XmlWellFormedWriter.NamespaceKind kind) { }

	// RVA: 0x1320610 Offset: 0x131FA10 VA: 0x181320610
	private void AddToNamespaceHashtable(int namespaceIndex) { }

	// RVA: 0x13214D0 Offset: 0x13208D0 VA: 0x1813214D0
	private int LookupNamespaceIndex(string prefix) { }

	// RVA: 0x1321890 Offset: 0x1320C90 VA: 0x181321890
	private void PopNamespaces(int indexFrom, int indexTo) { }

	// RVA: 0x1320EA0 Offset: 0x13202A0 VA: 0x181320EA0
	private static XmlException DupAttrException(string prefix, string localName) { }

	// RVA: 0x1320710 Offset: 0x131FB10 VA: 0x181320710
	private void AdvanceState(XmlWellFormedWriter.Token token) { }

	// RVA: 0x13223A0 Offset: 0x13217A0 VA: 0x1813223A0
	private void StartElementContent() { }

	// RVA: 0x1321150 Offset: 0x1320550 VA: 0x181321150
	private static string GetStateName(XmlWellFormedWriter.State state) { }

	// RVA: 0x13215E0 Offset: 0x13209E0 VA: 0x1813215E0
	internal string LookupNamespace(string prefix) { }

	// RVA: 0x13213E0 Offset: 0x13207E0 VA: 0x1813213E0
	private string LookupLocalNamespace(string prefix) { }

	// RVA: 0x1321020 Offset: 0x1320420 VA: 0x181321020
	private string GeneratePrefix() { }

	// RVA: 0x1320B10 Offset: 0x131FF10 VA: 0x181320B10
	private void CheckNCName(string ncname) { }

	// RVA: 0x13211F0 Offset: 0x13205F0 VA: 0x1813211F0
	private static Exception InvalidCharsException(string name, int badCharIndex) { }

	// RVA: 0x1322570 Offset: 0x1321970 VA: 0x181322570
	private void ThrowInvalidStateTransition(XmlWellFormedWriter.Token token, XmlWellFormedWriter.State currentState) { }

	// RVA: 0x1326CC0 Offset: 0x13260C0 VA: 0x181326CC0
	private bool get_IsClosedOrErrorState() { }

	// RVA: 0x131FFF0 Offset: 0x131F3F0 VA: 0x18131FFF0
	private void AddAttribute(string prefix, string localName, string namespaceName) { }

	// RVA: 0x13204C0 Offset: 0x131F8C0 VA: 0x1813204C0
	private void AddToAttrHashTable(int attributeIndex) { }

	// RVA: 0x1325990 Offset: 0x1324D90 VA: 0x181325990
	private static void .cctor() { }

}

private enum XmlWellFormedWriter.State // TypeDefIndex: 1922
{	// Fields
	public int value__; // 0x0
	public const XmlWellFormedWriter.State Start = 0;
	public const XmlWellFormedWriter.State TopLevel = 1;
	public const XmlWellFormedWriter.State Document = 2;
	public const XmlWellFormedWriter.State Element = 3;
	public const XmlWellFormedWriter.State Content = 4;
	public const XmlWellFormedWriter.State B64Content = 5;
	public const XmlWellFormedWriter.State B64Attribute = 6;
	public const XmlWellFormedWriter.State AfterRootEle = 7;
	public const XmlWellFormedWriter.State Attribute = 8;
	public const XmlWellFormedWriter.State SpecialAttr = 9;
	public const XmlWellFormedWriter.State EndDocument = 10;
	public const XmlWellFormedWriter.State RootLevelAttr = 11;
	public const XmlWellFormedWriter.State RootLevelSpecAttr = 12;
	public const XmlWellFormedWriter.State RootLevelB64Attr = 13;
	public const XmlWellFormedWriter.State AfterRootLevelAttr = 14;
	public const XmlWellFormedWriter.State Closed = 15;
	public const XmlWellFormedWriter.State Error = 16;
	public const XmlWellFormedWriter.State StartContent = 101;
	public const XmlWellFormedWriter.State StartContentEle = 102;
	public const XmlWellFormedWriter.State StartContentB64 = 103;
	public const XmlWellFormedWriter.State StartDoc = 104;
	public const XmlWellFormedWriter.State StartDocEle = 106;
	public const XmlWellFormedWriter.State EndAttrSEle = 107;
	public const XmlWellFormedWriter.State EndAttrEEle = 108;
	public const XmlWellFormedWriter.State EndAttrSCont = 109;
	public const XmlWellFormedWriter.State EndAttrSAttr = 111;
	public const XmlWellFormedWriter.State PostB64Cont = 112;
	public const XmlWellFormedWriter.State PostB64Attr = 113;
	public const XmlWellFormedWriter.State PostB64RootAttr = 114;
	public const XmlWellFormedWriter.State StartFragEle = 115;
	public const XmlWellFormedWriter.State StartFragCont = 116;
	public const XmlWellFormedWriter.State StartFragB64 = 117;
	public const XmlWellFormedWriter.State StartRootLevelAttr = 118;

}

private enum XmlWellFormedWriter.Token // TypeDefIndex: 1923
{	// Fields
	public int value__; // 0x0
	public const XmlWellFormedWriter.Token StartDocument = 0;
	public const XmlWellFormedWriter.Token EndDocument = 1;
	public const XmlWellFormedWriter.Token PI = 2;
	public const XmlWellFormedWriter.Token Comment = 3;
	public const XmlWellFormedWriter.Token Dtd = 4;
	public const XmlWellFormedWriter.Token StartElement = 5;
	public const XmlWellFormedWriter.Token EndElement = 6;
	public const XmlWellFormedWriter.Token StartAttribute = 7;
	public const XmlWellFormedWriter.Token EndAttribute = 8;
	public const XmlWellFormedWriter.Token Text = 9;
	public const XmlWellFormedWriter.Token CData = 10;
	public const XmlWellFormedWriter.Token AtomicValue = 11;
	public const XmlWellFormedWriter.Token Base64 = 12;
	public const XmlWellFormedWriter.Token RawData = 13;
	public const XmlWellFormedWriter.Token Whitespace = 14;

}

private class XmlWellFormedWriter.NamespaceResolverProxy : IXmlNamespaceResolver // TypeDefIndex: 1924
{	// Fields
	private XmlWellFormedWriter wfWriter; // 0x10

	// Methods

	// RVA: 0x6C0000 Offset: 0x6BF400 VA: 0x1806C0000
	internal void .ctor(XmlWellFormedWriter wfWriter) { }

	// RVA: 0x1313120 Offset: 0x1312520 VA: 0x181313120 Slot: 4
	private IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x1313170 Offset: 0x1312570 VA: 0x181313170 Slot: 5
	private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0x1313190 Offset: 0x1312590 VA: 0x181313190 Slot: 6
	private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

}

private struct XmlWellFormedWriter.ElementScope // TypeDefIndex: 1925
{	// Fields
	internal int prevNSTop; // 0x0
	internal string prefix; // 0x8
	internal string localName; // 0x10
	internal string namespaceUri; // 0x18
	internal XmlSpace xmlSpace; // 0x20
	internal string xmlLang; // 0x28

	// Methods

	// RVA: 0x1E0A20 Offset: 0x1DFE20 VA: 0x1801E0A20
	internal void Set(string prefix, string localName, string namespaceUri, int prevNSTop) { }

	// RVA: 0x1E0AA0 Offset: 0x1DFEA0 VA: 0x1801E0AA0
	internal void WriteEndElement(XmlRawWriter rawWriter) { }

	// RVA: 0x1E0AE0 Offset: 0x1DFEE0 VA: 0x1801E0AE0
	internal void WriteFullEndElement(XmlRawWriter rawWriter) { }

}

private enum XmlWellFormedWriter.NamespaceKind // TypeDefIndex: 1926
{	// Fields
	public int value__; // 0x0
	public const XmlWellFormedWriter.NamespaceKind Written = 0;
	public const XmlWellFormedWriter.NamespaceKind NeedToWrite = 1;
	public const XmlWellFormedWriter.NamespaceKind Implied = 2;
	public const XmlWellFormedWriter.NamespaceKind Special = 3;

}

private struct XmlWellFormedWriter.Namespace // TypeDefIndex: 1927
{	// Fields
	internal string prefix; // 0x0
	internal string namespaceUri; // 0x8
	internal XmlWellFormedWriter.NamespaceKind kind; // 0x10
	internal int prevNsIndex; // 0x14

	// Methods

	// RVA: 0x1E0C60 Offset: 0x1E0060 VA: 0x1801E0C60
	internal void Set(string prefix, string namespaceUri, XmlWellFormedWriter.NamespaceKind kind) { }

	// RVA: 0x1E0D00 Offset: 0x1E0100 VA: 0x1801E0D00
	internal void WriteDecl(XmlWriter writer, XmlRawWriter rawWriter) { }

}

private struct XmlWellFormedWriter.AttrName // TypeDefIndex: 1928
{	// Fields
	internal string prefix; // 0x0
	internal string namespaceUri; // 0x8
	internal string localName; // 0x10
	internal int prev; // 0x18

	// Methods

	// RVA: 0x1E09C0 Offset: 0x1DFDC0 VA: 0x1801E09C0
	internal void Set(string prefix, string localName, string namespaceUri) { }

	// RVA: 0x1E09B0 Offset: 0x1DFDB0 VA: 0x1801E09B0
	internal bool IsDuplicate(string prefix, string localName, string namespaceUri) { }

}

private enum XmlWellFormedWriter.SpecialAttribute // TypeDefIndex: 1929
{	// Fields
	public int value__; // 0x0
	public const XmlWellFormedWriter.SpecialAttribute No = 0;
	public const XmlWellFormedWriter.SpecialAttribute DefaultXmlns = 1;
	public const XmlWellFormedWriter.SpecialAttribute PrefixedXmlns = 2;
	public const XmlWellFormedWriter.SpecialAttribute XmlSpace = 3;
	public const XmlWellFormedWriter.SpecialAttribute XmlLang = 4;

}

private class XmlWellFormedWriter.AttributeValueCache // TypeDefIndex: 1930
{	// Fields
	private StringBuilder stringValue; // 0x10
	private string singleStringValue; // 0x18
	private XmlWellFormedWriter.AttributeValueCache.Item[] items; // 0x20
	private int firstItem; // 0x28
	private int lastItem; // 0x2C

	// Properties
	internal string StringValue { get; }

	// Methods

	// RVA: 0x13129A0 Offset: 0x1311DA0 VA: 0x1813129A0
	internal string get_StringValue() { }

	// RVA: 0x13122E0 Offset: 0x13116E0 VA: 0x1813122E0
	internal void WriteEntityRef(string name) { }

	// RVA: 0x1312100 Offset: 0x1311500 VA: 0x181312100
	internal void WriteCharEntity(char ch) { }

	// RVA: 0x13126F0 Offset: 0x1311AF0 VA: 0x1813126F0
	internal void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x13128A0 Offset: 0x1311CA0 VA: 0x1813128A0
	internal void WriteWhitespace(string ws) { }

	// RVA: 0x1312630 Offset: 0x1311A30 VA: 0x181312630
	internal void WriteString(string text) { }

	// RVA: 0x13121D0 Offset: 0x13115D0 VA: 0x1813121D0
	internal void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x1312490 Offset: 0x1311890 VA: 0x181312490
	internal void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0x13125A0 Offset: 0x13119A0 VA: 0x1813125A0
	internal void WriteRaw(string data) { }

	// RVA: 0x1312810 Offset: 0x1311C10 VA: 0x181312810
	internal void WriteValue(string value) { }

	// RVA: 0x1311730 Offset: 0x1310B30 VA: 0x181311730
	internal void Replay(XmlWriter writer) { }

	// RVA: 0x1311BF0 Offset: 0x1310FF0 VA: 0x181311BF0
	internal void Trim() { }

	// RVA: 0x13116E0 Offset: 0x1310AE0 VA: 0x1813116E0
	internal void Clear() { }

	// RVA: 0x1311B90 Offset: 0x1310F90 VA: 0x181311B90
	private void StartComplexValue() { }

	// RVA: 0x1311530 Offset: 0x1310930 VA: 0x181311530
	private void AddItem(XmlWellFormedWriter.AttributeValueCache.ItemType type, object data) { }

	// RVA: 0x1312930 Offset: 0x1311D30 VA: 0x181312930
	public void .ctor() { }

}

private enum XmlWellFormedWriter.AttributeValueCache.ItemType // TypeDefIndex: 1931
{	// Fields
	public int value__; // 0x0
	public const XmlWellFormedWriter.AttributeValueCache.ItemType EntityRef = 0;
	public const XmlWellFormedWriter.AttributeValueCache.ItemType CharEntity = 1;
	public const XmlWellFormedWriter.AttributeValueCache.ItemType SurrogateCharEntity = 2;
	public const XmlWellFormedWriter.AttributeValueCache.ItemType Whitespace = 3;
	public const XmlWellFormedWriter.AttributeValueCache.ItemType String = 4;
	public const XmlWellFormedWriter.AttributeValueCache.ItemType StringChars = 5;
	public const XmlWellFormedWriter.AttributeValueCache.ItemType Raw = 6;
	public const XmlWellFormedWriter.AttributeValueCache.ItemType RawChars = 7;
	public const XmlWellFormedWriter.AttributeValueCache.ItemType ValueString = 8;

}

private class XmlWellFormedWriter.AttributeValueCache.Item // TypeDefIndex: 1932
{	// Fields
	internal XmlWellFormedWriter.AttributeValueCache.ItemType type; // 0x10
	internal object data; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	internal void .ctor() { }

	// RVA: 0x11E7300 Offset: 0x11E6700 VA: 0x1811E7300
	internal void Set(XmlWellFormedWriter.AttributeValueCache.ItemType type, object data) { }

}

private class XmlWellFormedWriter.AttributeValueCache.BufferChunk // TypeDefIndex: 1933
{	// Fields
	internal char[] buffer; // 0x10
	internal int index; // 0x18
	internal int count; // 0x1C

	// Methods

	// RVA: 0xB76E20 Offset: 0xB76220 VA: 0x180B76E20
	internal void .ctor(char[] buffer, int index, int count) { }

}

public abstract class XmlWriter : IDisposable // TypeDefIndex: 1935
{	// Fields
	private char[] writeNodeBuffer; // 0x10

	// Properties
	public abstract WriteState WriteState { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void WriteStartDocument();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void WriteStartDocument(bool standalone);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void WriteEndDocument();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void WriteDocType(string name, string pubid, string sysid, string subset);

	// RVA: 0x1328710 Offset: 0x1327B10 VA: 0x181328710
	public void WriteStartElement(string localName, string ns) { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void WriteStartElement(string prefix, string localName, string ns);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void WriteEndElement();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract void WriteFullEndElement();

	// RVA: 0x1327E10 Offset: 0x1327210 VA: 0x181327E10
	public void WriteAttributeString(string localName, string ns, string value) { }

	// RVA: 0x1327DA0 Offset: 0x13271A0 VA: 0x181327DA0
	public void WriteAttributeString(string localName, string value) { }

	// RVA: 0x1327E80 Offset: 0x1327280 VA: 0x181327E80
	public void WriteAttributeString(string prefix, string localName, string ns, string value) { }

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void WriteStartAttribute(string prefix, string localName, string ns);

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void WriteEndAttribute();

	// RVA: -1 Offset: -1 Slot: 14
	public abstract void WriteCData(string text);

	// RVA: -1 Offset: -1 Slot: 15
	public abstract void WriteComment(string text);

	// RVA: -1 Offset: -1 Slot: 16
	public abstract void WriteProcessingInstruction(string name, string text);

	// RVA: -1 Offset: -1 Slot: 17
	public abstract void WriteEntityRef(string name);

	// RVA: -1 Offset: -1 Slot: 18
	public abstract void WriteCharEntity(char ch);

	// RVA: -1 Offset: -1 Slot: 19
	public abstract void WriteWhitespace(string ws);

	// RVA: -1 Offset: -1 Slot: 20
	public abstract void WriteString(string text);

	// RVA: -1 Offset: -1 Slot: 21
	public abstract void WriteSurrogateCharEntity(char lowChar, char highChar);

	// RVA: -1 Offset: -1 Slot: 22
	public abstract void WriteChars(char[] buffer, int index, int count);

	// RVA: -1 Offset: -1 Slot: 23
	public abstract void WriteRaw(char[] buffer, int index, int count);

	// RVA: -1 Offset: -1 Slot: 24
	public abstract void WriteRaw(string data);

	// RVA: -1 Offset: -1 Slot: 25
	public abstract void WriteBase64(byte[] buffer, int index, int count);

	// RVA: 0x1328190 Offset: 0x1327590 VA: 0x181328190 Slot: 26
	public virtual void WriteBinHex(byte[] buffer, int index, int count) { }

	// RVA: -1 Offset: -1 Slot: 27
	public abstract WriteState get_WriteState();

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 28
	public virtual void Close() { }

	// RVA: -1 Offset: -1 Slot: 29
	public abstract void Flush();

	// RVA: -1 Offset: -1 Slot: 30
	public abstract string LookupPrefix(string ns);

	// RVA: 0x1328740 Offset: 0x1327B40 VA: 0x181328740 Slot: 31
	public virtual void WriteValue(string value) { }

	// RVA: 0x1327ED0 Offset: 0x13272D0 VA: 0x181327ED0 Slot: 32
	public virtual void WriteAttributes(XmlReader reader, bool defattr) { }

	// RVA: 0x1328230 Offset: 0x1327630 VA: 0x181328230 Slot: 33
	public virtual void WriteNode(XmlReader reader, bool defattr) { }

	// RVA: 0x13281C0 Offset: 0x13275C0 VA: 0x1813281C0
	public void WriteElementString(string localName, string ns, string value) { }

	// RVA: 0x1327D40 Offset: 0x1327140 VA: 0x181327D40 Slot: 4
	public void Dispose() { }

	// RVA: 0x1327D60 Offset: 0x1327160 VA: 0x181327D60 Slot: 34
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1327C60 Offset: 0x1327060 VA: 0x181327C60
	public static XmlWriter Create(Stream output, XmlWriterSettings settings) { }

	// RVA: 0x1327CD0 Offset: 0x13270D0 VA: 0x181327CD0
	public static XmlWriter Create(TextWriter output, XmlWriterSettings settings) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	protected void .ctor() { }

}

public enum XmlOutputMethod // TypeDefIndex: 1936
{	// Fields
	public int value__; // 0x0
	public const XmlOutputMethod Xml = 0;
	public const XmlOutputMethod Html = 1;
	public const XmlOutputMethod Text = 2;
	public const XmlOutputMethod AutoDetect = 3;

}

internal enum XmlStandalone // TypeDefIndex: 1938
{	// Fields
	public int value__; // 0x0
	public const XmlStandalone Omit = 0;
	public const XmlStandalone Yes = 1;
	public const XmlStandalone No = 2;

}

public sealed class XmlWriterSettings // TypeDefIndex: 1939
{	// Fields
	private bool useAsync; // 0x10
	private Encoding encoding; // 0x18
	private bool omitXmlDecl; // 0x20
	private NewLineHandling newLineHandling; // 0x24
	private string newLineChars; // 0x28
	private TriState indent; // 0x30
	private string indentChars; // 0x38
	private bool newLineOnAttributes; // 0x40
	private bool closeOutput; // 0x41
	private NamespaceHandling namespaceHandling; // 0x44
	private ConformanceLevel conformanceLevel; // 0x48
	private bool checkCharacters; // 0x4C
	private bool writeEndDocumentOnClose; // 0x4D
	private XmlOutputMethod outputMethod; // 0x50
	private List<XmlQualifiedName> cdataSections; // 0x58
	private bool doNotEscapeUriAttributes; // 0x60
	private bool mergeCDataSections; // 0x61
	private string mediaType; // 0x68
	private string docTypeSystem; // 0x70
	private string docTypePublic; // 0x78
	private XmlStandalone standalone; // 0x80
	private bool autoXmlDecl; // 0x84
	private bool isReadOnly; // 0x85

	// Properties
	public bool Async { get; }
	public Encoding Encoding { get; }
	public bool OmitXmlDeclaration { get; set; }
	public NewLineHandling NewLineHandling { get; }
	public string NewLineChars { get; }
	public bool Indent { get; set; }
	public string IndentChars { get; }
	public bool NewLineOnAttributes { get; }
	public bool CloseOutput { get; }
	public ConformanceLevel ConformanceLevel { get; set; }
	public bool CheckCharacters { get; }
	public NamespaceHandling NamespaceHandling { get; set; }
	public bool WriteEndDocumentOnClose { get; }
	public XmlOutputMethod OutputMethod { get; set; }
	internal List<XmlQualifiedName> CDataSectionElements { get; }
	public bool DoNotEscapeUriAttributes { get; }
	internal bool MergeCDataSections { get; }
	internal string MediaType { get; }
	internal string DocTypeSystem { get; }
	internal string DocTypePublic { get; }
	internal XmlStandalone Standalone { get; }
	internal bool AutoXmlDeclaration { get; }
	internal TriState IndentInternal { get; }
	internal bool IsQuerySpecific { get; }
	internal bool ReadOnly { set; }

	// Methods

	// RVA: 0x13278C0 Offset: 0x1326CC0 VA: 0x1813278C0
	public void .ctor() { }

	// RVA: 0x497E20 Offset: 0x497220 VA: 0x180497E20
	public bool get_Async() { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public Encoding get_Encoding() { }

	// RVA: 0xB0BB80 Offset: 0xB0AF80 VA: 0x180B0BB80
	public bool get_OmitXmlDeclaration() { }

	// RVA: 0x1327C00 Offset: 0x1327000 VA: 0x181327C00
	public void set_OmitXmlDeclaration(bool value) { }

	// RVA: 0x7E8DA0 Offset: 0x7E81A0 VA: 0x1807E8DA0
	public NewLineHandling get_NewLineHandling() { }

	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230
	public string get_NewLineChars() { }

	// RVA: 0x1327A20 Offset: 0x1326E20 VA: 0x181327A20
	public bool get_Indent() { }

	// RVA: 0x1327B20 Offset: 0x1326F20 VA: 0x181327B20
	public void set_Indent(bool value) { }

	// RVA: 0x5DCC00 Offset: 0x5DC000 VA: 0x1805DCC00
	public string get_IndentChars() { }

	// RVA: 0x7E53F0 Offset: 0x7E47F0 VA: 0x1807E53F0
	public bool get_NewLineOnAttributes() { }

	// RVA: 0xEE1D40 Offset: 0xEE1140 VA: 0x180EE1D40
	public bool get_CloseOutput() { }

	// RVA: 0x5B1C80 Offset: 0x5B1080 VA: 0x1805B1C80
	public ConformanceLevel get_ConformanceLevel() { }

	// RVA: 0x1327AA0 Offset: 0x1326EA0 VA: 0x181327AA0
	public void set_ConformanceLevel(ConformanceLevel value) { }

	// RVA: 0xC1C200 Offset: 0xC1B600 VA: 0x180C1C200
	public bool get_CheckCharacters() { }

	// RVA: 0x5F7C90 Offset: 0x5F7090 VA: 0x1805F7C90
	public NamespaceHandling get_NamespaceHandling() { }

	// RVA: 0x1327B80 Offset: 0x1326F80 VA: 0x181327B80
	public void set_NamespaceHandling(NamespaceHandling value) { }

	// RVA: 0x1327A90 Offset: 0x1326E90 VA: 0x181327A90
	public bool get_WriteEndDocumentOnClose() { }

	// RVA: 0x8C8B80 Offset: 0x8C7F80 VA: 0x1808C8B80
	public XmlOutputMethod get_OutputMethod() { }

	// RVA: 0x8C8BC0 Offset: 0x8C7FC0 VA: 0x1808C8BC0
	internal void set_OutputMethod(XmlOutputMethod value) { }

	// RVA: 0x1327060 Offset: 0x1326460 VA: 0x181327060
	public XmlWriterSettings Clone() { }

	// RVA: 0x4CC340 Offset: 0x4CB740 VA: 0x1804CC340
	internal List<XmlQualifiedName> get_CDataSectionElements() { }

	// RVA: 0xA2DBD0 Offset: 0xA2CFD0 VA: 0x180A2DBD0
	public bool get_DoNotEscapeUriAttributes() { }

	// RVA: 0x10813A0 Offset: 0x10807A0 VA: 0x1810813A0
	internal bool get_MergeCDataSections() { }

	// RVA: 0x5334F0 Offset: 0x5328F0 VA: 0x1805334F0
	internal string get_MediaType() { }

	// RVA: 0x58DC30 Offset: 0x58D030 VA: 0x18058DC30
	internal string get_DocTypeSystem() { }

	// RVA: 0x4E4EC0 Offset: 0x4E42C0 VA: 0x1804E4EC0
	internal string get_DocTypePublic() { }

	// RVA: 0x59C1A0 Offset: 0x59B5A0 VA: 0x18059C1A0
	internal XmlStandalone get_Standalone() { }

	// RVA: 0x1327A10 Offset: 0x1326E10 VA: 0x181327A10
	internal bool get_AutoXmlDeclaration() { }

	// RVA: 0xA178C0 Offset: 0xA16CC0 VA: 0x180A178C0
	internal TriState get_IndentInternal() { }

	// RVA: 0x1327A30 Offset: 0x1326E30 VA: 0x181327A30
	internal bool get_IsQuerySpecific() { }

	// RVA: 0x1327370 Offset: 0x1326770 VA: 0x181327370
	internal XmlWriter CreateWriter(Stream output) { }

	// RVA: 0x1327110 Offset: 0x1326510 VA: 0x181327110
	internal XmlWriter CreateWriter(TextWriter output) { }

	// RVA: 0x1327C50 Offset: 0x1327050 VA: 0x181327C50
	internal void set_ReadOnly(bool value) { }

	// RVA: 0x1326FB0 Offset: 0x13263B0 VA: 0x181326FB0
	private void CheckReadOnly(string propertyName) { }

	// RVA: 0x13277C0 Offset: 0x1326BC0 VA: 0x1813277C0
	private void Initialize() { }

}

internal class XsdCachingReader : XmlReader, IXmlLineInfo // TypeDefIndex: 1940
{	// Fields
	private XmlReader coreReader; // 0x10
	private XmlNameTable coreReaderNameTable; // 0x18
	private ValidatingReaderNodeData[] contentEvents; // 0x20
	private ValidatingReaderNodeData[] attributeEvents; // 0x28
	private ValidatingReaderNodeData cachedNode; // 0x30
	private XsdCachingReader.CachingReaderState cacheState; // 0x38
	private int contentIndex; // 0x3C
	private int attributeCount; // 0x40
	private bool returnOriginalStringValues; // 0x44
	private CachingEventHandler cacheHandler; // 0x48
	private int currentAttrIndex; // 0x50
	private int currentContentIndex; // 0x54
	private bool readAhead; // 0x58
	private IXmlLineInfo lineInfo; // 0x60
	private ValidatingReaderNodeData textNode; // 0x68

	// Properties
	public override XmlReaderSettings Settings { get; }
	public override XmlNodeType NodeType { get; }
	public override string Name { get; }
	public override string LocalName { get; }
	public override string NamespaceURI { get; }
	public override string Prefix { get; }
	public override string Value { get; }
	public override int Depth { get; }
	public override string BaseURI { get; }
	public override bool IsEmptyElement { get; }
	public override bool IsDefault { get; }
	public override char QuoteChar { get; }
	public override XmlSpace XmlSpace { get; }
	public override string XmlLang { get; }
	public override int AttributeCount { get; }
	public override bool EOF { get; }
	public override ReadState ReadState { get; }
	public override XmlNameTable NameTable { get; }
	private int System.Xml.IXmlLineInfo.LineNumber { get; }
	private int System.Xml.IXmlLineInfo.LinePosition { get; }

	// Methods

	// RVA: 0x1329F50 Offset: 0x1329350 VA: 0x181329F50
	internal void .ctor(XmlReader reader, IXmlLineInfo lineInfo, CachingEventHandler handlerMethod) { }

	// RVA: 0x1328FA0 Offset: 0x13283A0 VA: 0x181328FA0
	private void Init() { }

	// RVA: 0x1329B90 Offset: 0x1328F90 VA: 0x181329B90
	internal void Reset(XmlReader reader) { }

	// RVA: 0x132A150 Offset: 0x1329550 VA: 0x18132A150 Slot: 5
	public override XmlReaderSettings get_Settings() { }

	// RVA: 0x132A110 Offset: 0x1329510 VA: 0x18132A110 Slot: 6
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x132A0C0 Offset: 0x13294C0 VA: 0x18132A0C0 Slot: 7
	public override string get_Name() { }

	// RVA: 0x132A0A0 Offset: 0x13294A0 VA: 0x18132A0A0 Slot: 8
	public override string get_LocalName() { }

	// RVA: 0x132A0F0 Offset: 0x13294F0 VA: 0x18132A0F0 Slot: 9
	public override string get_NamespaceURI() { }

	// RVA: 0x132A130 Offset: 0x1329530 VA: 0x18132A130 Slot: 10
	public override string get_Prefix() { }

	// RVA: 0x132A180 Offset: 0x1329580 VA: 0x18132A180 Slot: 11
	public override string get_Value() { }

	// RVA: 0x132A040 Offset: 0x1329440 VA: 0x18132A040 Slot: 12
	public override int get_Depth() { }

	// RVA: 0xBC40A0 Offset: 0xBC34A0 VA: 0x180BC40A0 Slot: 13
	public override string get_BaseURI() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 14
	public override bool get_IsEmptyElement() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 15
	public override bool get_IsDefault() { }

	// RVA: 0xBC4380 Offset: 0xBC3780 VA: 0x180BC4380 Slot: 16
	public override char get_QuoteChar() { }

	// RVA: 0xBC4410 Offset: 0xBC3810 VA: 0x180BC4410 Slot: 17
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0xBC43E0 Offset: 0xBC37E0 VA: 0x180BC43E0 Slot: 18
	public override string get_XmlLang() { }

	// RVA: 0x5F7C80 Offset: 0x5F7080 VA: 0x1805F7C80 Slot: 21
	public override int get_AttributeCount() { }

	// RVA: 0x1328D40 Offset: 0x1328140 VA: 0x181328D40 Slot: 22
	public override string GetAttribute(string name) { }

	// RVA: 0x1328E80 Offset: 0x1328280 VA: 0x181328E80 Slot: 23
	public override string GetAttribute(string name, string namespaceURI) { }

	// RVA: 0x1328DD0 Offset: 0x13281D0 VA: 0x181328DD0 Slot: 24
	public override string GetAttribute(int i) { }

	// RVA: 0x13291F0 Offset: 0x13285F0 VA: 0x1813291F0 Slot: 25
	public override bool MoveToAttribute(string name) { }

	// RVA: 0x1329140 Offset: 0x1328540 VA: 0x181329140 Slot: 26
	public override void MoveToAttribute(int i) { }

	// RVA: 0x13292E0 Offset: 0x13286E0 VA: 0x1813292E0 Slot: 27
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x1329340 Offset: 0x1328740 VA: 0x181329340 Slot: 28
	public override bool MoveToNextAttribute() { }

	// RVA: 0x1329290 Offset: 0x1328690 VA: 0x181329290 Slot: 29
	public override bool MoveToElement() { }

	// RVA: 0x1329490 Offset: 0x1328890 VA: 0x181329490 Slot: 31
	public override bool Read() { }

	// RVA: 0x1329B10 Offset: 0x1328F10 VA: 0x181329B10
	internal ValidatingReaderNodeData RecordTextNode(string textValue, string originalStringValue, int depth, int lineNo, int linePos) { }

	// RVA: 0x1329D70 Offset: 0x1329170 VA: 0x181329D70
	internal void SwitchTextNodeAndEndElement(string textValue, string originalStringValue) { }

	// RVA: 0x13299C0 Offset: 0x1328DC0 VA: 0x1813299C0
	internal void RecordEndElementNode() { }

	// RVA: 0x132A060 Offset: 0x1329460 VA: 0x18132A060 Slot: 32
	public override bool get_EOF() { }

	// RVA: 0x1328AC0 Offset: 0x1327EC0 VA: 0x181328AC0 Slot: 33
	public override void Close() { }

	// RVA: 0xB9A640 Offset: 0xB99A40 VA: 0x180B9A640 Slot: 34
	public override ReadState get_ReadState() { }

	// RVA: 0x1329C40 Offset: 0x1329040 VA: 0x181329C40 Slot: 35
	public override void Skip() { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 36
	public override XmlNameTable get_NameTable() { }

	// RVA: 0xBC3C10 Offset: 0xBC3010 VA: 0x180BC3C10 Slot: 37
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x1329BC0 Offset: 0x1328FC0 VA: 0x181329BC0 Slot: 39
	public override void ResolveEntity() { }

	// RVA: 0x13293A0 Offset: 0x13287A0 VA: 0x1813293A0 Slot: 30
	public override bool ReadAttributeValue() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 53
	private bool System.Xml.IXmlLineInfo.HasLineInfo() { }

	// RVA: 0x1329F10 Offset: 0x1329310 VA: 0x181329F10 Slot: 54
	private int System.Xml.IXmlLineInfo.get_LineNumber() { }

	// RVA: 0x1329F30 Offset: 0x1329330 VA: 0x181329F30 Slot: 55
	private int System.Xml.IXmlLineInfo.get_LinePosition() { }

	// RVA: 0x1329C10 Offset: 0x1329010 VA: 0x181329C10
	internal void SetToReplayMode() { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	internal XmlReader GetCoreReader() { }

	// RVA: 0x54FB60 Offset: 0x54EF60 VA: 0x18054FB60
	internal IXmlLineInfo GetLineInfo() { }

	// RVA: 0x1328AB0 Offset: 0x1327EB0 VA: 0x181328AB0
	private void ClearAttributesInfo() { }

	// RVA: 0x1328760 Offset: 0x1327B60 VA: 0x181328760
	private ValidatingReaderNodeData AddAttribute(int attIndex) { }

	// RVA: 0x1328900 Offset: 0x1327D00 VA: 0x181328900
	private ValidatingReaderNodeData AddContent(XmlNodeType nodeType) { }

	// RVA: 0x1329800 Offset: 0x1328C00 VA: 0x181329800
	private void RecordAttributes() { }

	// RVA: 0x1328C80 Offset: 0x1328080 VA: 0x181328C80
	private int GetAttributeIndexWithoutPrefix(string name) { }

	// RVA: 0x1328BC0 Offset: 0x1327FC0 VA: 0x181328BC0
	private int GetAttributeIndexWithPrefix(string name) { }

	// RVA: 0x1328B00 Offset: 0x1327F00 VA: 0x181328B00
	private ValidatingReaderNodeData CreateDummyTextNode(string attributeValue, int depth) { }

}

private enum XsdCachingReader.CachingReaderState // TypeDefIndex: 1941
{	// Fields
	public int value__; // 0x0
	public const XsdCachingReader.CachingReaderState None = 0;
	public const XsdCachingReader.CachingReaderState Init = 1;
	public const XsdCachingReader.CachingReaderState Record = 2;
	public const XsdCachingReader.CachingReaderState Replay = 3;
	public const XsdCachingReader.CachingReaderState ReaderClosed = 4;
	public const XsdCachingReader.CachingReaderState Error = 5;

}

internal class XsdValidatingReader : XmlReader, IXmlSchemaInfo, IXmlLineInfo, IXmlNamespaceResolver // TypeDefIndex: 1944
{	// Fields
	private XmlReader coreReader; // 0x10
	private IXmlNamespaceResolver coreReaderNSResolver; // 0x18
	private IXmlNamespaceResolver thisNSResolver; // 0x20
	private XmlSchemaValidator validator; // 0x28
	private XmlResolver xmlResolver; // 0x30
	private ValidationEventHandler validationEvent; // 0x38
	private XsdValidatingReader.ValidatingReaderState validationState; // 0x40
	private XmlValueGetter valueGetter; // 0x48
	private XmlNamespaceManager nsManager; // 0x50
	private bool manageNamespaces; // 0x58
	private bool processInlineSchema; // 0x59
	private bool replayCache; // 0x5A
	private ValidatingReaderNodeData cachedNode; // 0x60
	private AttributePSVIInfo attributePSVI; // 0x68
	private int attributeCount; // 0x70
	private int coreReaderAttributeCount; // 0x74
	private int currentAttrIndex; // 0x78
	private AttributePSVIInfo[] attributePSVINodes; // 0x80
	private ArrayList defaultAttributes; // 0x88
	private Parser inlineSchemaParser; // 0x90
	private object atomicValue; // 0x98
	private XmlSchemaInfo xmlSchemaInfo; // 0xA0
	private string originalAtomicValueString; // 0xA8
	private XmlNameTable coreReaderNameTable; // 0xB0
	private XsdCachingReader cachingReader; // 0xB8
	private ValidatingReaderNodeData textNode; // 0xC0
	private string NsXmlNs; // 0xC8
	private string NsXs; // 0xD0
	private string NsXsi; // 0xD8
	private string XsiType; // 0xE0
	private string XsiNil; // 0xE8
	private string XsdSchema; // 0xF0
	private string XsiSchemaLocation; // 0xF8
	private string XsiNoNamespaceSchemaLocation; // 0x100
	private XmlCharType xmlCharType; // 0x108
	private IXmlLineInfo lineInfo; // 0x110
	private ReadContentAsBinaryHelper readBinaryHelper; // 0x118
	private XsdValidatingReader.ValidatingReaderState savedState; // 0x120
	private static Type TypeOfString; // 0x0

	// Properties
	public override XmlReaderSettings Settings { get; }
	public override XmlNodeType NodeType { get; }
	public override string Name { get; }
	public override string LocalName { get; }
	public override string NamespaceURI { get; }
	public override string Prefix { get; }
	public override string Value { get; }
	public override int Depth { get; }
	public override string BaseURI { get; }
	public override bool IsEmptyElement { get; }
	public override bool IsDefault { get; }
	public override char QuoteChar { get; }
	public override XmlSpace XmlSpace { get; }
	public override string XmlLang { get; }
	public override IXmlSchemaInfo SchemaInfo { get; }
	public override Type ValueType { get; }
	public override int AttributeCount { get; }
	public override bool EOF { get; }
	public override ReadState ReadState { get; }
	public override XmlNameTable NameTable { get; }
	private bool System.Xml.Schema.IXmlSchemaInfo.IsDefault { get; }
	private bool System.Xml.Schema.IXmlSchemaInfo.IsNil { get; }
	private XmlSchemaValidity System.Xml.Schema.IXmlSchemaInfo.Validity { get; }
	private XmlSchemaSimpleType System.Xml.Schema.IXmlSchemaInfo.MemberType { get; }
	private XmlSchemaType System.Xml.Schema.IXmlSchemaInfo.SchemaType { get; }
	private XmlSchemaElement System.Xml.Schema.IXmlSchemaInfo.SchemaElement { get; }
	private XmlSchemaAttribute System.Xml.Schema.IXmlSchemaInfo.SchemaAttribute { get; }
	public int LineNumber { get; }
	public int LinePosition { get; }
	private XmlSchemaInfo AttributeSchemaInfo { get; }

	// Methods

	// RVA: 0x223E730 Offset: 0x223DB30 VA: 0x18223E730
	internal void .ctor(XmlReader reader, XmlResolver xmlResolver, XmlReaderSettings readerSettings, XmlSchemaObject partialValidationType) { }

	// RVA: 0x223E900 Offset: 0x223DD00 VA: 0x18223E900
	internal void .ctor(XmlReader reader, XmlResolver xmlResolver, XmlReaderSettings readerSettings) { }

	// RVA: 0x223BFC0 Offset: 0x223B3C0 VA: 0x18223BFC0
	private void Init() { }

	// RVA: 0x223DB00 Offset: 0x223CF00 VA: 0x18223DB00
	private void SetupValidator(XmlReaderSettings readerSettings, XmlReader reader, XmlSchemaObject partialValidationType) { }

	// RVA: 0x223ED70 Offset: 0x223E170 VA: 0x18223ED70 Slot: 5
	public override XmlReaderSettings get_Settings() { }

	// RVA: 0x223EC50 Offset: 0x223E050 VA: 0x18223EC50 Slot: 6
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x223EAA0 Offset: 0x223DEA0 VA: 0x18223EAA0 Slot: 7
	public override string get_Name() { }

	// RVA: 0x223EA60 Offset: 0x223DE60 VA: 0x18223EA60 Slot: 8
	public override string get_LocalName() { }

	// RVA: 0x223EC10 Offset: 0x223E010 VA: 0x18223EC10 Slot: 9
	public override string get_NamespaceURI() { }

	// RVA: 0x223ECF0 Offset: 0x223E0F0 VA: 0x18223ECF0 Slot: 10
	public override string get_Prefix() { }

	// RVA: 0x223EF10 Offset: 0x223E310 VA: 0x18223EF10 Slot: 11
	public override string get_Value() { }

	// RVA: 0x223E940 Offset: 0x223DD40 VA: 0x18223E940 Slot: 12
	public override int get_Depth() { }

	// RVA: 0xBC40A0 Offset: 0xBC34A0 VA: 0x180BC40A0 Slot: 13
	public override string get_BaseURI() { }

	// RVA: 0xBC4190 Offset: 0xBC3590 VA: 0x180BC4190 Slot: 14
	public override bool get_IsEmptyElement() { }

	// RVA: 0x223E980 Offset: 0x223DD80 VA: 0x18223E980 Slot: 15
	public override bool get_IsDefault() { }

	// RVA: 0xBC4380 Offset: 0xBC3780 VA: 0x180BC4380 Slot: 16
	public override char get_QuoteChar() { }

	// RVA: 0xBC4410 Offset: 0xBC3810 VA: 0x180BC4410 Slot: 17
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0xBC43E0 Offset: 0xBC37E0 VA: 0x180BC43E0 Slot: 18
	public override string get_XmlLang() { }

	// RVA: 0x4B0E80 Offset: 0x4B0280 VA: 0x1804B0E80 Slot: 19
	public override IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x223EE50 Offset: 0x223E250 VA: 0x18223EE50 Slot: 20
	public override Type get_ValueType() { }

	// RVA: 0x7E3970 Offset: 0x7E2D70 VA: 0x1807E3970 Slot: 21
	public override int get_AttributeCount() { }

	// RVA: 0x223B580 Offset: 0x223A980 VA: 0x18223B580 Slot: 22
	public override string GetAttribute(string name) { }

	// RVA: 0x223B460 Offset: 0x223A860 VA: 0x18223B460 Slot: 23
	public override string GetAttribute(string name, string namespaceURI) { }

	// RVA: 0x223B5F0 Offset: 0x223A9F0 VA: 0x18223B5F0 Slot: 24
	public override string GetAttribute(int i) { }

	// RVA: 0x223C520 Offset: 0x223B920 VA: 0x18223C520 Slot: 25
	public override bool MoveToAttribute(string name) { }

	// RVA: 0x223C380 Offset: 0x223B780 VA: 0x18223C380 Slot: 26
	public override void MoveToAttribute(int i) { }

	// RVA: 0x223C650 Offset: 0x223BA50 VA: 0x18223C650 Slot: 27
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x223C800 Offset: 0x223BC00 VA: 0x18223C800 Slot: 28
	public override bool MoveToNextAttribute() { }

	// RVA: 0x223C600 Offset: 0x223BA00 VA: 0x18223C600 Slot: 29
	public override bool MoveToElement() { }

	// RVA: 0x223D7E0 Offset: 0x223CBE0 VA: 0x18223D7E0 Slot: 31
	public override bool Read() { }

	// RVA: 0xBC4130 Offset: 0xBC3530 VA: 0x180BC4130 Slot: 32
	public override bool get_EOF() { }

	// RVA: 0x223B0D0 Offset: 0x223A4D0 VA: 0x18223B0D0 Slot: 33
	public override void Close() { }

	// RVA: 0x223ED30 Offset: 0x223E130 VA: 0x18223ED30 Slot: 34
	public override ReadState get_ReadState() { }

	// RVA: 0x223DD50 Offset: 0x223D150 VA: 0x18223DD50 Slot: 35
	public override void Skip() { }

	// RVA: 0x972280 Offset: 0x971680 VA: 0x180972280 Slot: 36
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x223C320 Offset: 0x223B720 VA: 0x18223C320 Slot: 37
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x223DAB0 Offset: 0x223CEB0 VA: 0x18223DAB0 Slot: 39
	public override void ResolveEntity() { }

	// RVA: 0x223D690 Offset: 0x223CA90 VA: 0x18223D690 Slot: 30
	public override bool ReadAttributeValue() { }

	// RVA: 0x223E0C0 Offset: 0x223D4C0 VA: 0x18223E0C0 Slot: 54
	private bool System.Xml.Schema.IXmlSchemaInfo.get_IsDefault() { }

	// RVA: 0x223E150 Offset: 0x223D550 VA: 0x18223E150 Slot: 55
	private bool System.Xml.Schema.IXmlSchemaInfo.get_IsNil() { }

	// RVA: 0x223E460 Offset: 0x223D860 VA: 0x18223E460 Slot: 53
	private XmlSchemaValidity System.Xml.Schema.IXmlSchemaInfo.get_Validity() { }

	// RVA: 0x223E1A0 Offset: 0x223D5A0 VA: 0x18223E1A0 Slot: 56
	private XmlSchemaSimpleType System.Xml.Schema.IXmlSchemaInfo.get_MemberType() { }

	// RVA: 0x223E400 Offset: 0x223D800 VA: 0x18223E400 Slot: 57
	private XmlSchemaType System.Xml.Schema.IXmlSchemaInfo.get_SchemaType() { }

	// RVA: 0x223E3A0 Offset: 0x223D7A0 VA: 0x18223E3A0 Slot: 58
	private XmlSchemaElement System.Xml.Schema.IXmlSchemaInfo.get_SchemaElement() { }

	// RVA: 0x223E350 Offset: 0x223D750 VA: 0x18223E350 Slot: 59
	private XmlSchemaAttribute System.Xml.Schema.IXmlSchemaInfo.get_SchemaAttribute() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 60
	public bool HasLineInfo() { }

	// RVA: 0x223E9C0 Offset: 0x223DDC0 VA: 0x18223E9C0 Slot: 61
	public int get_LineNumber() { }

	// RVA: 0x223EA10 Offset: 0x223DE10 VA: 0x18223EA10 Slot: 62
	public int get_LinePosition() { }

	// RVA: 0x223DED0 Offset: 0x223D2D0 VA: 0x18223DED0 Slot: 63
	private IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x223DFC0 Offset: 0x223D3C0 VA: 0x18223DFC0 Slot: 64
	private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0x223E040 Offset: 0x223D440 VA: 0x18223E040 Slot: 65
	private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

	// RVA: 0xBC43B0 Offset: 0xBC37B0 VA: 0x180BC43B0
	private object GetStringValue() { }

	// RVA: 0x223E920 Offset: 0x223DD20 VA: 0x18223E920
	private XmlSchemaInfo get_AttributeSchemaInfo() { }

	// RVA: 0x223D250 Offset: 0x223C650 VA: 0x18223D250
	private void ProcessReaderEvent() { }

	// RVA: 0x223C970 Offset: 0x223BD70 VA: 0x18223C970
	private void ProcessElementEvent() { }

	// RVA: 0x223CF80 Offset: 0x223C380 VA: 0x18223CF80
	private void ProcessEndElementEvent() { }

	// RVA: 0x223E500 Offset: 0x223D900 VA: 0x18223E500
	private void ValidateAttributes() { }

	// RVA: 0x223B070 Offset: 0x223A470 VA: 0x18223B070
	private void ClearAttributesInfo() { }

	// RVA: 0x223B290 Offset: 0x223A690 VA: 0x18223B290
	private AttributePSVIInfo GetAttributePSVI(string name) { }

	// RVA: 0x223B1D0 Offset: 0x223A5D0 VA: 0x18223B1D0
	private AttributePSVIInfo GetAttributePSVI(string localName, string ns) { }

	// RVA: 0x223B830 Offset: 0x223AC30 VA: 0x18223B830
	private ValidatingReaderNodeData GetDefaultAttribute(string name, bool updatePosition) { }

	// RVA: 0x223B980 Offset: 0x223AD80 VA: 0x18223B980
	private ValidatingReaderNodeData GetDefaultAttribute(string attrLocalName, string ns, bool updatePosition) { }

	// RVA: 0x223AE80 Offset: 0x223A280 VA: 0x18223AE80
	private AttributePSVIInfo AddAttributePSVI(int attIndex) { }

	// RVA: 0x223C2D0 Offset: 0x223B6D0 VA: 0x18223C2D0
	private bool IsXSDRoot(string localName, string ns) { }

	// RVA: 0x223D130 Offset: 0x223C530 VA: 0x18223D130
	private void ProcessInlineSchema() { }

	// RVA: 0x223D440 Offset: 0x223C840 VA: 0x18223D440
	private void ReadAheadForMemberType() { }

	// RVA: 0x223BB00 Offset: 0x223AF00 VA: 0x18223BB00
	private void GetIsDefault() { }

	// RVA: 0x223BE10 Offset: 0x223B210 VA: 0x18223BE10
	private void GetMemberType() { }

	// RVA: 0x223B730 Offset: 0x223AB30 VA: 0x18223B730
	private XsdCachingReader GetCachingReader() { }

	// RVA: 0x223B110 Offset: 0x223A510 VA: 0x18223B110
	internal ValidatingReaderNodeData CreateDummyTextNode(string attributeValue, int depth) { }

	// RVA: 0x223B020 Offset: 0x223A420 VA: 0x18223B020
	internal void CachingCallBack(XsdCachingReader cachingReader) { }

	// RVA: 0x223BF20 Offset: 0x223B320 VA: 0x18223BF20
	private string GetOriginalAtomicValueStringOfElement() { }

}

private enum XsdValidatingReader.ValidatingReaderState // TypeDefIndex: 1945
{	// Fields
	public int value__; // 0x0
	public const XsdValidatingReader.ValidatingReaderState None = 0;
	public const XsdValidatingReader.ValidatingReaderState Init = 1;
	public const XsdValidatingReader.ValidatingReaderState Read = 2;
	public const XsdValidatingReader.ValidatingReaderState OnDefaultAttribute = -1;
	public const XsdValidatingReader.ValidatingReaderState OnReadAttributeValue = -2;
	public const XsdValidatingReader.ValidatingReaderState OnAttribute = 3;
	public const XsdValidatingReader.ValidatingReaderState ClearAttributes = 4;
	public const XsdValidatingReader.ValidatingReaderState ParseInlineSchema = 5;
	public const XsdValidatingReader.ValidatingReaderState ReadAhead = 6;
	public const XsdValidatingReader.ValidatingReaderState OnReadBinaryContent = 7;
	public const XsdValidatingReader.ValidatingReaderState ReaderClosed = 8;
	public const XsdValidatingReader.ValidatingReaderState EOF = 9;
	public const XsdValidatingReader.ValidatingReaderState Error = 10;

}

public class XmlAttribute : XmlNode // TypeDefIndex: 1947
{	// Fields
	private XmlName name; // 0x18
	private XmlLinkedNode lastChild; // 0x20

	// Properties
	internal int LocalNameHash { get; }
	internal XmlName XmlName { get; set; }
	public override XmlNode ParentNode { get; }
	public override string Name { get; }
	public override string LocalName { get; }
	public override string NamespaceURI { get; }
	public override string Prefix { get; set; }
	public override XmlNodeType NodeType { get; }
	public override XmlDocument OwnerDocument { get; }
	public override string Value { get; set; }
	public override IXmlSchemaInfo SchemaInfo { get; }
	public override string InnerText { set; }
	internal override bool IsContainer { get; }
	internal override XmlLinkedNode LastNode { get; set; }
	public virtual bool Specified { get; }
	public virtual XmlElement OwnerElement { get; }
	public override string InnerXml { set; }
	public override string BaseURI { get; }
	internal override XmlSpace XmlSpace { get; }
	internal override string XmlLang { get; }

	// Methods

	// RVA: 0xE51BA0 Offset: 0xE50FA0 VA: 0x180E51BA0
	internal void .ctor(XmlName name, XmlDocument doc) { }

	// RVA: 0xE51D50 Offset: 0xE51150 VA: 0x180E51D50
	internal int get_LocalNameHash() { }

	// RVA: 0xE51B50 Offset: 0xE50F50 VA: 0x180E51B50
	protected internal void .ctor(string prefix, string localName, string namespaceURI, XmlDocument doc) { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	internal XmlName get_XmlName() { }

	// RVA: 0x4D0180 Offset: 0x4CF580 VA: 0x1804D0180
	internal void set_XmlName(XmlName value) { }

	// RVA: 0xE51420 Offset: 0xE50820 VA: 0x180E51420 Slot: 31
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 10
	public override XmlNode get_ParentNode() { }

	// RVA: 0xE51D70 Offset: 0xE51170 VA: 0x180E51D70 Slot: 6
	public override string get_Name() { }

	// RVA: 0x8FB8A0 Offset: 0x8FACA0 VA: 0x1808FB8A0 Slot: 36
	public override string get_LocalName() { }

	// RVA: 0xE51D90 Offset: 0xE51190 VA: 0x180E51D90 Slot: 33
	public override string get_NamespaceURI() { }

	// RVA: 0xE51E50 Offset: 0xE51250 VA: 0x180E51E50 Slot: 34
	public override string get_Prefix() { }

	// RVA: 0xE52080 Offset: 0xE51480 VA: 0x180E52080 Slot: 35
	public override void set_Prefix(string value) { }

	// RVA: 0x54B2D0 Offset: 0x54A6D0 VA: 0x18054B2D0 Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0xE51DB0 Offset: 0xE511B0 VA: 0x180E51DB0 Slot: 15
	public override XmlDocument get_OwnerDocument() { }

	// RVA: 0xE51E70 Offset: 0xE51270 VA: 0x180E51E70 Slot: 7
	public override string get_Value() { }

	// RVA: 0xE52140 Offset: 0xE51540 VA: 0x180E52140 Slot: 8
	public override void set_Value(string value) { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 41
	public override IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0xE51F80 Offset: 0xE51380 VA: 0x180E51F80 Slot: 39
	public override void set_InnerText(string value) { }

	// RVA: 0xE51650 Offset: 0xE50A50 VA: 0x180E51650
	internal bool PrepareOwnerElementInElementIdAttrMap() { }

	// RVA: 0xE518E0 Offset: 0xE50CE0 VA: 0x180E518E0
	internal void ResetOwnerElementInElementIdAttrMap(string oldInnerText) { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 18
	internal override bool get_IsContainer() { }

	// RVA: 0xE511D0 Offset: 0xE505D0 VA: 0x180E511D0 Slot: 26
	internal override XmlNode AppendChildForLoad(XmlNode newChild, XmlDocument doc) { }

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00 Slot: 19
	internal override XmlLinkedNode get_LastNode() { }

	// RVA: 0x497E30 Offset: 0x497230 VA: 0x180497E30 Slot: 20
	internal override void set_LastNode(XmlLinkedNode value) { }

	// RVA: 0xE51640 Offset: 0xE50A40 VA: 0x180E51640 Slot: 27
	internal override bool IsValidChildType(XmlNodeType type) { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 56
	public virtual bool get_Specified() { }

	// RVA: 0xE515A0 Offset: 0xE509A0 VA: 0x180E515A0 Slot: 21
	public override XmlNode InsertBefore(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0xE51500 Offset: 0xE50900 VA: 0x180E51500 Slot: 22
	public override XmlNode InsertAfter(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0xE51860 Offset: 0xE50C60 VA: 0x180E51860 Slot: 23
	public override XmlNode RemoveChild(XmlNode oldChild) { }

	// RVA: 0xE517E0 Offset: 0xE50BE0 VA: 0x180E517E0 Slot: 24
	public override XmlNode PrependChild(XmlNode newChild) { }

	// RVA: 0xE513A0 Offset: 0xE507A0 VA: 0x180E513A0 Slot: 25
	public override XmlNode AppendChild(XmlNode newChild) { }

	// RVA: 0xE51DD0 Offset: 0xE511D0 VA: 0x180E51DD0 Slot: 57
	public virtual XmlElement get_OwnerElement() { }

	// RVA: 0xE51FF0 Offset: 0xE513F0 VA: 0x180E51FF0 Slot: 40
	public override void set_InnerXml(string value) { }

	// RVA: 0xE51A80 Offset: 0xE50E80 VA: 0x180E51A80 Slot: 43
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0xE51A10 Offset: 0xE50E10 VA: 0x180E51A10 Slot: 44
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0xE51CC0 Offset: 0xE510C0 VA: 0x180E51CC0 Slot: 42
	public override string get_BaseURI() { }

	// RVA: 0x4B94C0 Offset: 0x4B88C0 VA: 0x1804B94C0 Slot: 47
	internal override void SetParent(XmlNode node) { }

	// RVA: 0xE51F20 Offset: 0xE51320 VA: 0x180E51F20 Slot: 53
	internal override XmlSpace get_XmlSpace() { }

	// RVA: 0xE51E90 Offset: 0xE51290 VA: 0x180E51E90 Slot: 54
	internal override string get_XmlLang() { }

}

public sealed class XmlAttributeCollection : XmlNamedNodeMap, ICollection, IEnumerable // TypeDefIndex: 1948
{	// Properties
	public XmlAttribute ItemOf { get; }
	public XmlAttribute ItemOf { get; }
	public XmlAttribute ItemOf { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	private int System.Collections.ICollection.Count { get; }

	// Methods

	// RVA: 0xE50E40 Offset: 0xE50240 VA: 0x180E50E40
	internal void .ctor(XmlNode parent) { }

	// RVA: 0xE50E50 Offset: 0xE50250 VA: 0x180E50E50
	public XmlAttribute get_ItemOf(int i) { }

	// RVA: 0xE510A0 Offset: 0xE504A0 VA: 0x180E510A0
	public XmlAttribute get_ItemOf(string name) { }

	// RVA: 0xE50F40 Offset: 0xE50340 VA: 0x180E50F40
	public XmlAttribute get_ItemOf(string localName, string namespaceURI) { }

	// RVA: 0xE4FE40 Offset: 0xE4F240 VA: 0x180E4FE40
	internal int FindNodeOffsetNS(XmlAttribute node) { }

	// RVA: 0xE50B70 Offset: 0xE4FF70 VA: 0x180E50B70 Slot: 6
	public override XmlNode SetNamedItem(XmlNode node) { }

	// RVA: 0xE4FBA0 Offset: 0xE4EFA0 VA: 0x180E4FBA0
	public XmlAttribute Append(XmlAttribute node) { }

	// RVA: 0xE50A00 Offset: 0xE4FE00 VA: 0x180E50A00
	public XmlAttribute Remove(XmlAttribute node) { }

	// RVA: 0xE504C0 Offset: 0xE4F8C0 VA: 0x180E504C0
	public XmlAttribute RemoveAt(int i) { }

	// RVA: 0xE503E0 Offset: 0xE4F7E0 VA: 0x180E503E0
	public void RemoveAll() { }

	// RVA: 0xE50DA0 Offset: 0xE501A0 VA: 0x180E50DA0 Slot: 13
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x4B0E80 Offset: 0x4B0280 VA: 0x1804B0E80 Slot: 15
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0xE50E30 Offset: 0xE50230 VA: 0x180E50E30 Slot: 14
	private int System.Collections.ICollection.get_Count() { }

	// RVA: 0xE4F9A0 Offset: 0xE4EDA0 VA: 0x180E4F9A0 Slot: 9
	internal override XmlNode AddNode(XmlNode node) { }

	// RVA: 0xE4FFE0 Offset: 0xE4F3E0 VA: 0x180E4FFE0 Slot: 12
	internal override XmlNode InsertNodeAt(int i, XmlNode node) { }

	// RVA: 0xE50690 Offset: 0xE4FA90 VA: 0x180E50690 Slot: 11
	internal override XmlNode RemoveNodeAt(int i) { }

	// RVA: 0xE4FD70 Offset: 0xE4F170 VA: 0x180E4FD70
	internal void Detach(XmlAttribute attr) { }

	// RVA: 0xE500A0 Offset: 0xE4F4A0 VA: 0x180E500A0
	internal void InsertParentIntoElementIdAttrMap(XmlAttribute attr) { }

	// RVA: 0xE50870 Offset: 0xE4FC70 VA: 0x180E50870
	internal void RemoveParentFromElementIdAttrMap(XmlAttribute attr) { }

	// RVA: 0xE50580 Offset: 0xE4F980 VA: 0x180E50580
	internal int RemoveDuplicateAttribute(XmlAttribute attr) { }

	// RVA: 0xE502E0 Offset: 0xE4F6E0 VA: 0x180E502E0
	internal bool PrepareParentInElementIdAttrMap(string attrPrefix, string attrLocalName) { }

	// RVA: 0xE50A90 Offset: 0xE4FE90 VA: 0x180E50A90
	internal void ResetParentInElementIdAttrMap(string oldVal, string newVal) { }

	// RVA: 0xE50230 Offset: 0xE4F630 VA: 0x180E50230
	internal XmlAttribute InternalAppendAttribute(XmlAttribute node) { }

}

public class XmlCDataSection : XmlCharacterData // TypeDefIndex: 1949
{	// Properties
	public override string Name { get; }
	public override string LocalName { get; }
	public override XmlNodeType NodeType { get; }
	public override XmlNode ParentNode { get; }
	internal override bool IsText { get; }

	// Methods

	// RVA: 0xE531D0 Offset: 0xE525D0 VA: 0x180E531D0
	protected internal void .ctor(string data, XmlDocument doc) { }

	// RVA: 0xE53210 Offset: 0xE52610 VA: 0x180E53210 Slot: 6
	public override string get_Name() { }

	// RVA: 0xE53210 Offset: 0xE52610 VA: 0x180E53210 Slot: 36
	public override string get_LocalName() { }

	// RVA: 0xE32BD0 Offset: 0xE31FD0 VA: 0x180E32BD0 Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0xBC48A0 Offset: 0xBC3CA0 VA: 0x180BC48A0 Slot: 10
	public override XmlNode get_ParentNode() { }

	// RVA: 0xE53130 Offset: 0xE52530 VA: 0x180E53130 Slot: 31
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0xE53190 Offset: 0xE52590 VA: 0x180E53190 Slot: 43
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 44
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 55
	internal override bool get_IsText() { }

}

public abstract class XmlCharacterData : XmlLinkedNode // TypeDefIndex: 1950
{	// Fields
	private string data; // 0x20

	// Properties
	public override string Value { get; set; }
	public override string InnerText { get; set; }
	public virtual string Data { get; set; }

	// Methods

	// RVA: 0xE531D0 Offset: 0xE525D0 VA: 0x180E531D0
	protected internal void .ctor(string data, XmlDocument doc) { }

	// RVA: 0xBA0720 Offset: 0xB9FB20 VA: 0x180BA0720 Slot: 7
	public override string get_Value() { }

	// RVA: 0xE53F00 Offset: 0xE53300 VA: 0x180E53F00 Slot: 8
	public override void set_Value(string value) { }

	// RVA: 0x829900 Offset: 0x828D00 VA: 0x180829900 Slot: 38
	public override string get_InnerText() { }

	// RVA: 0xE53EE0 Offset: 0xE532E0 VA: 0x180E53EE0 Slot: 39
	public override void set_InnerText(string value) { }

	// RVA: 0xE53DC0 Offset: 0xE531C0 VA: 0x180E53DC0 Slot: 56
	public virtual string get_Data() { }

	// RVA: 0xE53E10 Offset: 0xE53210 VA: 0x180E53E10 Slot: 57
	public virtual void set_Data(string value) { }

	// RVA: 0xE53D40 Offset: 0xE53140 VA: 0x180E53D40
	internal bool CheckOnData(string data) { }

}

internal sealed class XmlChildEnumerator : IEnumerator // TypeDefIndex: 1951
{	// Fields
	internal XmlNode container; // 0x10
	internal XmlNode child; // 0x18
	internal bool isFirst; // 0x20

	// Properties
	private object System.Collections.IEnumerator.Current { get; }
	internal XmlNode Current { get; }

	// Methods

	// RVA: 0xE54080 Offset: 0xE53480 VA: 0x180E54080
	internal void .ctor(XmlNode container) { }

	// RVA: 0xE53F20 Offset: 0xE53320 VA: 0x180E53F20 Slot: 4
	private bool System.Collections.IEnumerator.MoveNext() { }

	// RVA: 0xE53F20 Offset: 0xE53320 VA: 0x180E53F20
	internal bool MoveNext() { }

	// RVA: 0xE53FC0 Offset: 0xE533C0 VA: 0x180E53FC0 Slot: 6
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0xE54000 Offset: 0xE53400 VA: 0x180E54000 Slot: 5
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0xE54000 Offset: 0xE53400 VA: 0x180E54000
	internal XmlNode get_Current() { }

}

internal class XmlChildNodes : XmlNodeList // TypeDefIndex: 1952
{	// Fields
	private XmlNode container; // 0x10

	// Properties
	public override int Count { get; }

	// Methods

	// RVA: 0x805E80 Offset: 0x805280 VA: 0x180805E80
	public void .ctor(XmlNode container) { }

	// RVA: 0xE541F0 Offset: 0xE535F0 VA: 0x180E541F0 Slot: 6
	public override XmlNode Item(int i) { }

	// RVA: 0xE54260 Offset: 0xE53660 VA: 0x180E54260 Slot: 7
	public override int get_Count() { }

	// RVA: 0xE540F0 Offset: 0xE534F0 VA: 0x180E540F0 Slot: 8
	public override IEnumerator GetEnumerator() { }

}

public class XmlComment : XmlCharacterData // TypeDefIndex: 1953
{	// Properties
	public override string Name { get; }
	public override string LocalName { get; }
	public override XmlNodeType NodeType { get; }

	// Methods

	// RVA: 0xE531D0 Offset: 0xE525D0 VA: 0x180E531D0
	protected internal void .ctor(string comment, XmlDocument doc) { }

	// RVA: 0xE54360 Offset: 0xE53760 VA: 0x180E54360 Slot: 6
	public override string get_Name() { }

	// RVA: 0xE54360 Offset: 0xE53760 VA: 0x180E54360 Slot: 36
	public override string get_LocalName() { }

	// RVA: 0x8B0DD0 Offset: 0x8B01D0 VA: 0x1808B0DD0 Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0xE542C0 Offset: 0xE536C0 VA: 0x180E542C0 Slot: 31
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0xE54320 Offset: 0xE53720 VA: 0x180E54320 Slot: 43
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 44
	public override void WriteContentTo(XmlWriter w) { }

}

public class XmlDeclaration : XmlLinkedNode // TypeDefIndex: 1954
{	// Fields
	private string version; // 0x20
	private string encoding; // 0x28
	private string standalone; // 0x30

	// Properties
	public string Version { get; set; }
	public string Encoding { get; set; }
	public string Standalone { get; set; }
	public override string Value { get; set; }
	public override string InnerText { get; set; }
	public override string Name { get; }
	public override string LocalName { get; }
	public override XmlNodeType NodeType { get; }

	// Methods

	// RVA: 0xE5C5B0 Offset: 0xE5B9B0 VA: 0x180E5C5B0
	protected internal void .ctor(string version, string encoding, string standalone, XmlDocument doc) { }

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	public string get_Version() { }

	// RVA: 0x497E30 Offset: 0x497230 VA: 0x180497E30
	internal void set_Version(string value) { }

	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230
	public string get_Encoding() { }

	// RVA: 0xE5C8F0 Offset: 0xE5BCF0 VA: 0x180E5C8F0
	public void set_Encoding(string value) { }

	// RVA: 0x4A2EE0 Offset: 0x4A22E0 VA: 0x1804A2EE0
	public string get_Standalone() { }

	// RVA: 0xE5CC70 Offset: 0xE5C070 VA: 0x180E5CC70
	public void set_Standalone(string value) { }

	// RVA: 0xE51E70 Offset: 0xE51270 VA: 0x180E51E70 Slot: 7
	public override string get_Value() { }

	// RVA: 0xE52140 Offset: 0xE51540 VA: 0x180E52140 Slot: 8
	public override void set_Value(string value) { }

	// RVA: 0xE5C780 Offset: 0xE5BB80 VA: 0x180E5C780 Slot: 38
	public override string get_InnerText() { }

	// RVA: 0xE5C960 Offset: 0xE5BD60 VA: 0x180E5C960 Slot: 39
	public override void set_InnerText(string value) { }

	// RVA: 0xE5C8B0 Offset: 0xE5BCB0 VA: 0x180E5C8B0 Slot: 6
	public override string get_Name() { }

	// RVA: 0x95B210 Offset: 0x95A610 VA: 0x18095B210 Slot: 36
	public override string get_LocalName() { }

	// RVA: 0xE5C8E0 Offset: 0xE5BCE0 VA: 0x180E5C8E0 Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0xE5C440 Offset: 0xE5B840 VA: 0x180E5C440 Slot: 31
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0xE5C540 Offset: 0xE5B940 VA: 0x180E5C540 Slot: 43
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 44
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0xE5C490 Offset: 0xE5B890 VA: 0x180E5C490
	private bool IsValidXmlVersion(string ver) { }

}

public class XmlDocument : XmlNode // TypeDefIndex: 1955
{	// Fields
	private XmlImplementation implementation; // 0x18
	private DomNameTable domNameTable; // 0x20
	private XmlLinkedNode lastChild; // 0x28
	private XmlNamedNodeMap entities; // 0x30
	private Hashtable htElementIdMap; // 0x38
	private Hashtable htElementIDAttrDecl; // 0x40
	private SchemaInfo schemaInfo; // 0x48
	private XmlSchemaSet schemas; // 0x50
	private bool reportValidity; // 0x58
	private bool actualLoadingStatus; // 0x59
	private XmlNodeChangedEventHandler onNodeInsertingDelegate; // 0x60
	private XmlNodeChangedEventHandler onNodeInsertedDelegate; // 0x68
	private XmlNodeChangedEventHandler onNodeRemovingDelegate; // 0x70
	private XmlNodeChangedEventHandler onNodeRemovedDelegate; // 0x78
	private XmlNodeChangedEventHandler onNodeChangingDelegate; // 0x80
	private XmlNodeChangedEventHandler onNodeChangedDelegate; // 0x88
	internal bool fEntRefNodesPresent; // 0x90
	internal bool fCDataNodesPresent; // 0x91
	private bool preserveWhitespace; // 0x92
	private bool isLoading; // 0x93
	internal string strDocumentName; // 0x98
	internal string strDocumentFragmentName; // 0xA0
	internal string strCommentName; // 0xA8
	internal string strTextName; // 0xB0
	internal string strCDataSectionName; // 0xB8
	internal string strEntityName; // 0xC0
	internal string strID; // 0xC8
	internal string strXmlns; // 0xD0
	internal string strXml; // 0xD8
	internal string strSpace; // 0xE0
	internal string strLang; // 0xE8
	internal string strEmpty; // 0xF0
	internal string strNonSignificantWhitespaceName; // 0xF8
	internal string strSignificantWhitespaceName; // 0x100
	internal string strReservedXmlns; // 0x108
	internal string strReservedXml; // 0x110
	internal string baseURI; // 0x118
	private XmlResolver resolver; // 0x120
	internal bool bSetResolver; // 0x128
	internal object objLock; // 0x130
	internal static EmptyEnumerator EmptyEnumerator; // 0x0
	internal static IXmlSchemaInfo NotKnownSchemaInfo; // 0x8
	internal static IXmlSchemaInfo ValidSchemaInfo; // 0x10
	internal static IXmlSchemaInfo InvalidSchemaInfo; // 0x18

	// Properties
	internal SchemaInfo DtdSchemaInfo { get; set; }
	public override XmlNodeType NodeType { get; }
	public override XmlNode ParentNode { get; }
	public virtual XmlDocumentType DocumentType { get; }
	internal virtual XmlDeclaration Declaration { get; }
	public XmlImplementation Implementation { get; }
	public override string Name { get; }
	public override string LocalName { get; }
	public XmlElement DocumentElement { get; }
	internal override bool IsContainer { get; }
	internal override XmlLinkedNode LastNode { get; set; }
	public override XmlDocument OwnerDocument { get; }
	public XmlSchemaSet Schemas { set; }
	internal bool CanReportValidity { get; }
	internal bool HasSetResolver { get; }
	public virtual XmlResolver XmlResolver { set; }
	public XmlNameTable NameTable { get; }
	public override bool IsReadOnly { get; }
	internal XmlNamedNodeMap Entities { get; set; }
	internal bool IsLoading { get; set; }
	internal bool ActualLoadingStatus { get; }
	public override string InnerText { set; }
	public override string InnerXml { set; }
	internal string Version { get; }
	internal string Encoding { get; }
	internal string Standalone { get; }
	public override IXmlSchemaInfo SchemaInfo { get; }
	public override string BaseURI { get; }

	// Methods

	// RVA: 0xE61060 Offset: 0xE60460 VA: 0x180E61060
	public void .ctor() { }

	// RVA: 0xE60C10 Offset: 0xE60010 VA: 0x180E60C10
	public void .ctor(XmlNameTable nt) { }

	// RVA: 0xE60C80 Offset: 0xE60080 VA: 0x180E60C80
	protected internal void .ctor(XmlImplementation imp) { }

	// RVA: 0x5DCCA0 Offset: 0x5DC0A0 VA: 0x1805DCCA0
	internal SchemaInfo get_DtdSchemaInfo() { }

	// RVA: 0x5F7050 Offset: 0x5F6450 VA: 0x1805F7050
	internal void set_DtdSchemaInfo(SchemaInfo value) { }

	// RVA: 0xE5DA90 Offset: 0xE5CE90 VA: 0x180E5DA90
	internal static void CheckName(string name) { }

	// RVA: 0xE5D480 Offset: 0xE5C880 VA: 0x180E5D480
	internal XmlName AddXmlName(string prefix, string localName, string namespaceURI, IXmlSchemaInfo schemaInfo) { }

	// RVA: 0xE5F330 Offset: 0xE5E730 VA: 0x180E5F330
	internal XmlName GetXmlName(string prefix, string localName, string namespaceURI, IXmlSchemaInfo schemaInfo) { }

	// RVA: 0xE5CD90 Offset: 0xE5C190 VA: 0x180E5CD90
	internal XmlName AddAttrXmlName(string prefix, string localName, string namespaceURI, IXmlSchemaInfo schemaInfo) { }

	// RVA: 0xE5D3A0 Offset: 0xE5C7A0 VA: 0x180E5D3A0
	internal bool AddIdInfo(XmlName eleName, XmlName attrName) { }

	// RVA: 0xE5EF30 Offset: 0xE5E330 VA: 0x180E5EF30
	private XmlName GetIDInfoByElement_(XmlName eleName) { }

	// RVA: 0xE5F040 Offset: 0xE5E440 VA: 0x180E5F040
	internal XmlName GetIDInfoByElement(XmlName eleName) { }

	// RVA: 0xE5E8D0 Offset: 0xE5DCD0 VA: 0x180E5E8D0
	private WeakReference GetElement(ArrayList elementList, XmlElement elem) { }

	// RVA: 0xE5D1A0 Offset: 0xE5C5A0 VA: 0x180E5D1A0
	internal void AddElementWithId(string id, XmlElement elem) { }

	// RVA: 0xE60400 Offset: 0xE5F800 VA: 0x180E60400
	internal void RemoveElementWithId(string id, XmlElement elem) { }

	// RVA: 0xE5DBF0 Offset: 0xE5CFF0 VA: 0x180E5DBF0 Slot: 31
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0xE61370 Offset: 0xE60770 VA: 0x180E61370 Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 10
	public override XmlNode get_ParentNode() { }

	// RVA: 0xE61210 Offset: 0xE60610 VA: 0x180E61210 Slot: 56
	public virtual XmlDocumentType get_DocumentType() { }

	// RVA: 0xE610D0 Offset: 0xE604D0 VA: 0x180E610D0 Slot: 57
	internal virtual XmlDeclaration get_Declaration() { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public XmlImplementation get_Implementation() { }

	// RVA: 0x58DBE0 Offset: 0x58CFE0 VA: 0x18058DBE0 Slot: 6
	public override string get_Name() { }

	// RVA: 0x58DBE0 Offset: 0x58CFE0 VA: 0x18058DBE0 Slot: 36
	public override string get_LocalName() { }

	// RVA: 0xE61180 Offset: 0xE60580 VA: 0x180E61180
	public XmlElement get_DocumentElement() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 18
	internal override bool get_IsContainer() { }

	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230 Slot: 19
	internal override XmlLinkedNode get_LastNode() { }

	// RVA: 0x7CE240 Offset: 0x7CD640 VA: 0x1807CE240 Slot: 20
	internal override void set_LastNode(XmlLinkedNode value) { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 15
	public override XmlDocument get_OwnerDocument() { }

	// RVA: 0x4CC370 Offset: 0x4CB770 VA: 0x1804CC370
	public void set_Schemas(XmlSchemaSet value) { }

	// RVA: 0x5ABE90 Offset: 0x5AB290 VA: 0x1805ABE90
	internal bool get_CanReportValidity() { }

	// RVA: 0xE61350 Offset: 0xE60750 VA: 0x180E61350
	internal bool get_HasSetResolver() { }

	// RVA: 0x7F5E00 Offset: 0x7F5200 VA: 0x1807F5E00
	internal XmlResolver GetResolver() { }

	// RVA: 0xE615B0 Offset: 0xE609B0 VA: 0x180E615B0 Slot: 58
	public virtual void set_XmlResolver(XmlResolver value) { }

	// RVA: 0xE5FD80 Offset: 0xE5F180 VA: 0x180E5FD80 Slot: 27
	internal override bool IsValidChildType(XmlNodeType type) { }

	// RVA: 0xE5F3D0 Offset: 0xE5E7D0 VA: 0x180E5F3D0
	private bool HasNodeTypeInPrevSiblings(XmlNodeType nt, XmlNode refNode) { }

	// RVA: 0xE5F360 Offset: 0xE5E760 VA: 0x180E5F360
	private bool HasNodeTypeInNextSiblings(XmlNodeType nt, XmlNode refNode) { }

	// RVA: 0xE5D8D0 Offset: 0xE5CCD0 VA: 0x180E5D8D0 Slot: 28
	internal override bool CanInsertBefore(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0xE5D780 Offset: 0xE5CB80 VA: 0x180E5D780 Slot: 29
	internal override bool CanInsertAfter(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0xE5DE20 Offset: 0xE5D220 VA: 0x180E5DE20
	public XmlAttribute CreateAttribute(string name) { }

	// RVA: 0xE60790 Offset: 0xE5FB90 VA: 0x180E60790
	internal void SetDefaultNamespace(string prefix, string localName, ref string namespaceURI) { }

	// RVA: 0xE5DF50 Offset: 0xE5D350 VA: 0x180E5DF50 Slot: 59
	public virtual XmlCDataSection CreateCDataSection(string data) { }

	// RVA: 0xE5DFD0 Offset: 0xE5D3D0 VA: 0x180E5DFD0 Slot: 60
	public virtual XmlComment CreateComment(string data) { }

	// RVA: 0xE5E130 Offset: 0xE5D530 VA: 0x180E5E130 Slot: 61
	public virtual XmlDocumentType CreateDocumentType(string name, string publicId, string systemId, string internalSubset) { }

	// RVA: 0xE5E0D0 Offset: 0xE5D4D0 VA: 0x180E5E0D0 Slot: 62
	public virtual XmlDocumentFragment CreateDocumentFragment() { }

	// RVA: 0xE5E280 Offset: 0xE5D680 VA: 0x180E5E280
	public XmlElement CreateElement(string name) { }

	// RVA: 0xE5CEE0 Offset: 0xE5C2E0 VA: 0x180E5CEE0
	internal void AddDefaultAttributes(XmlElement elem) { }

	// RVA: 0xE5F220 Offset: 0xE5E620 VA: 0x180E5F220
	private SchemaElementDecl GetSchemaElementDecl(XmlElement elem) { }

	// RVA: 0xE601A0 Offset: 0xE5F5A0 VA: 0x180E601A0
	private XmlAttribute PrepareDefaultAttribute(SchemaAttDef attdef, string attrPrefix, string attrLocalname, string attrNamespaceURI) { }

	// RVA: 0xE5E400 Offset: 0xE5D800 VA: 0x180E5E400 Slot: 63
	public virtual XmlEntityReference CreateEntityReference(string name) { }

	// RVA: 0xE5E470 Offset: 0xE5D870 VA: 0x180E5E470 Slot: 64
	public virtual XmlProcessingInstruction CreateProcessingInstruction(string target, string data) { }

	// RVA: 0xE5E640 Offset: 0xE5DA40 VA: 0x180E5E640 Slot: 65
	public virtual XmlDeclaration CreateXmlDeclaration(string version, string encoding, string standalone) { }

	// RVA: 0xE5E560 Offset: 0xE5D960 VA: 0x180E5E560 Slot: 66
	public virtual XmlText CreateTextNode(string text) { }

	// RVA: 0xE5E4F0 Offset: 0xE5D8F0 VA: 0x180E5E4F0 Slot: 67
	public virtual XmlSignificantWhitespace CreateSignificantWhitespace(string text) { }

	// RVA: 0xE5E5D0 Offset: 0xE5D9D0 VA: 0x180E5E5D0 Slot: 68
	public virtual XmlWhitespace CreateWhitespace(string text) { }

	// RVA: 0xE5DD70 Offset: 0xE5D170 VA: 0x180E5DD70
	public XmlAttribute CreateAttribute(string qualifiedName, string namespaceURI) { }

	// RVA: 0xE5E1D0 Offset: 0xE5D5D0 VA: 0x180E5E1D0
	public XmlElement CreateElement(string qualifiedName, string namespaceURI) { }

	// RVA: 0xE5F6C0 Offset: 0xE5EAC0 VA: 0x180E5F6C0
	private XmlNode ImportNodeInternal(XmlNode node, bool deep) { }

	// RVA: 0xE5F4B0 Offset: 0xE5E8B0 VA: 0x180E5F4B0
	private void ImportAttributes(XmlNode fromElem, XmlNode toElem) { }

	// RVA: 0xE5F610 Offset: 0xE5EA10 VA: 0x180E5F610
	private void ImportChildren(XmlNode fromNode, XmlNode toNode, bool deep) { }

	// RVA: 0xE51E50 Offset: 0xE51250 VA: 0x180E51E50
	public XmlNameTable get_NameTable() { }

	// RVA: 0xE5DCD0 Offset: 0xE5D0D0 VA: 0x180E5DCD0 Slot: 69
	public virtual XmlAttribute CreateAttribute(string prefix, string localName, string namespaceURI) { }

	// RVA: 0xE5E040 Offset: 0xE5D440 VA: 0x180E5E040 Slot: 70
	protected internal virtual XmlAttribute CreateDefaultAttribute(string prefix, string localName, string namespaceURI) { }

	// RVA: 0xE5E330 Offset: 0xE5D730 VA: 0x180E5E330 Slot: 71
	public virtual XmlElement CreateElement(string prefix, string localName, string namespaceURI) { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 37
	public override bool get_IsReadOnly() { }

	// RVA: 0xE612D0 Offset: 0xE606D0 VA: 0x180E612D0
	internal XmlNamedNodeMap get_Entities() { }

	// RVA: 0x4A2F10 Offset: 0x4A2310 VA: 0x1804A2F10
	internal void set_Entities(XmlNamedNodeMap value) { }

	// RVA: 0xE61360 Offset: 0xE60760 VA: 0x180E61360
	internal bool get_IsLoading() { }

	// RVA: 0xE615A0 Offset: 0xE609A0 VA: 0x180E615A0
	internal void set_IsLoading(bool value) { }

	// RVA: 0xAF1470 Offset: 0xAF0870 VA: 0x180AF1470
	internal bool get_ActualLoadingStatus() { }

	// RVA: 0xE60300 Offset: 0xE5F700 VA: 0x180E60300 Slot: 72
	public virtual XmlNode ReadNode(XmlReader reader) { }

	// RVA: 0xE60840 Offset: 0xE5FC40 VA: 0x180E60840
	private XmlTextReader SetupReader(XmlTextReader tr) { }

	// RVA: 0xE60080 Offset: 0xE5F480 VA: 0x180E60080 Slot: 73
	public virtual void Load(XmlReader reader) { }

	// RVA: 0xE5FF20 Offset: 0xE5F320 VA: 0x180E5FF20 Slot: 74
	public virtual void LoadXml(string xml) { }

	// RVA: 0xE61510 Offset: 0xE60910 VA: 0x180E61510 Slot: 39
	public override void set_InnerText(string value) { }

	// RVA: 0xE61580 Offset: 0xE60980 VA: 0x180E61580 Slot: 40
	public override void set_InnerXml(string value) { }

	// RVA: 0xE60560 Offset: 0xE5F960 VA: 0x180E60560 Slot: 75
	public virtual void Save(XmlWriter w) { }

	// RVA: 0xE60AE0 Offset: 0xE5FEE0 VA: 0x180E60AE0 Slot: 43
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0xE608A0 Offset: 0xE5FCA0 VA: 0x180E608A0 Slot: 44
	public override void WriteContentTo(XmlWriter xw) { }

	// RVA: 0xE5EE40 Offset: 0xE5E240 VA: 0x180E5EE40 Slot: 50
	internal override XmlNodeChangedEventArgs GetEventArgs(XmlNode node, XmlNode oldParent, XmlNode newParent, string oldValue, string newValue, XmlNodeChangedAction action) { }

	// RVA: 0xE5F150 Offset: 0xE5E550 VA: 0x180E5F150
	internal XmlNodeChangedEventArgs GetInsertEventArgsForLoad(XmlNode node, XmlNode newParent) { }

	// RVA: 0xE5D730 Offset: 0xE5CB30 VA: 0x180E5D730 Slot: 51
	internal override void BeforeEvent(XmlNodeChangedEventArgs args) { }

	// RVA: 0xE5D4B0 Offset: 0xE5C8B0 VA: 0x180E5D4B0 Slot: 52
	internal override void AfterEvent(XmlNodeChangedEventArgs args) { }

	// RVA: 0xE5E6D0 Offset: 0xE5DAD0 VA: 0x180E5E6D0
	internal XmlAttribute GetDefaultAttribute(XmlElement elem, string attrPrefix, string attrLocalname, string attrNamespaceURI) { }

	// RVA: 0xE614E0 Offset: 0xE608E0 VA: 0x180E614E0
	internal string get_Version() { }

	// RVA: 0xE612A0 Offset: 0xE606A0 VA: 0x180E612A0
	internal string get_Encoding() { }

	// RVA: 0xE614B0 Offset: 0xE608B0 VA: 0x180E614B0
	internal string get_Standalone() { }

	// RVA: 0xE5ED50 Offset: 0xE5E150 VA: 0x180E5ED50
	internal XmlEntity GetEntityNode(string name) { }

	// RVA: 0xE61380 Offset: 0xE60780 VA: 0x180E61380 Slot: 41
	public override IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0xE610C0 Offset: 0xE604C0 VA: 0x180E610C0 Slot: 42
	public override string get_BaseURI() { }

	// RVA: 0xE60780 Offset: 0xE5FB80 VA: 0x180E60780
	internal void SetBaseURI(string inBaseURI) { }

	// RVA: 0xE5D500 Offset: 0xE5C900 VA: 0x180E5D500 Slot: 26
	internal override XmlNode AppendChildForLoad(XmlNode newChild, XmlDocument doc) { }

	// RVA: 0xE60B00 Offset: 0xE5FF00 VA: 0x180E60B00
	private static void .cctor() { }

}

public class XmlDocumentFragment : XmlNode // TypeDefIndex: 1956
{	// Fields
	private XmlLinkedNode lastChild; // 0x18

	// Properties
	public override string Name { get; }
	public override string LocalName { get; }
	public override XmlNodeType NodeType { get; }
	public override XmlNode ParentNode { get; }
	public override XmlDocument OwnerDocument { get; }
	public override string InnerXml { set; }
	internal override bool IsContainer { get; }
	internal override XmlLinkedNode LastNode { get; set; }

	// Methods

	// RVA: 0x11B5890 Offset: 0x11B4C90 VA: 0x1811B5890
	protected internal void .ctor(XmlDocument ownerDocument) { }

	// RVA: 0x11B5930 Offset: 0x11B4D30 VA: 0x1811B5930 Slot: 6
	public override string get_Name() { }

	// RVA: 0x11B5930 Offset: 0x11B4D30 VA: 0x1811B5930 Slot: 36
	public override string get_LocalName() { }

	// RVA: 0x11B5960 Offset: 0x11B4D60 VA: 0x1811B5960 Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 10
	public override XmlNode get_ParentNode() { }

	// RVA: 0x11B5970 Offset: 0x11B4D70 VA: 0x1811B5970 Slot: 15
	public override XmlDocument get_OwnerDocument() { }

	// RVA: 0x11B59F0 Offset: 0x11B4DF0 VA: 0x1811B59F0 Slot: 40
	public override void set_InnerXml(string value) { }

	// RVA: 0x11B54E0 Offset: 0x11B48E0 VA: 0x1811B54E0 Slot: 31
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 18
	internal override bool get_IsContainer() { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 19
	internal override XmlLinkedNode get_LastNode() { }

	// RVA: 0x4D0180 Offset: 0x4CF580 VA: 0x1804D0180 Slot: 20
	internal override void set_LastNode(XmlLinkedNode value) { }

	// RVA: 0x11B5580 Offset: 0x11B4980 VA: 0x1811B5580 Slot: 27
	internal override bool IsValidChildType(XmlNodeType type) { }

	// RVA: 0x11B53F0 Offset: 0x11B47F0 VA: 0x1811B53F0 Slot: 29
	internal override bool CanInsertAfter(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x11B5470 Offset: 0x11B4870 VA: 0x1811B5470 Slot: 28
	internal override bool CanInsertBefore(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0xE60AE0 Offset: 0xE5FEE0 VA: 0x180E60AE0 Slot: 43
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x11B5630 Offset: 0x11B4A30 VA: 0x1811B5630 Slot: 44
	public override void WriteContentTo(XmlWriter w) { }

}

public class XmlDocumentType : XmlLinkedNode // TypeDefIndex: 1957
{	// Fields
	private string name; // 0x20
	private string publicId; // 0x28
	private string systemId; // 0x30
	private string internalSubset; // 0x38
	private bool namespaces; // 0x40
	private XmlNamedNodeMap entities; // 0x48
	private XmlNamedNodeMap notations; // 0x50
	private SchemaInfo schemaInfo; // 0x58

	// Properties
	public override string Name { get; }
	public override string LocalName { get; }
	public override XmlNodeType NodeType { get; }
	public override bool IsReadOnly { get; }
	public XmlNamedNodeMap Entities { get; }
	public XmlNamedNodeMap Notations { get; }
	public string PublicId { get; }
	public string SystemId { get; }
	public string InternalSubset { get; }
	internal bool ParseWithNamespaces { get; }
	internal SchemaInfo DtdSchemaInfo { get; set; }

	// Methods

	// RVA: 0x11B5B40 Offset: 0x11B4F40 VA: 0x1811B5B40
	protected internal void .ctor(string name, string publicId, string systemId, string internalSubset, XmlDocument doc) { }

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00 Slot: 6
	public override string get_Name() { }

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00 Slot: 36
	public override string get_LocalName() { }

	// RVA: 0x4A2F20 Offset: 0x4A2320 VA: 0x1804A2F20 Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x11B5A90 Offset: 0x11B4E90 VA: 0x1811B5A90 Slot: 31
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 37
	public override bool get_IsReadOnly() { }

	// RVA: 0x11B5D00 Offset: 0x11B5100 VA: 0x1811B5D00
	public XmlNamedNodeMap get_Entities() { }

	// RVA: 0x11B5D90 Offset: 0x11B5190 VA: 0x1811B5D90
	public XmlNamedNodeMap get_Notations() { }

	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230
	public string get_PublicId() { }

	// RVA: 0x4A2EE0 Offset: 0x4A22E0 VA: 0x1804A2EE0
	public string get_SystemId() { }

	// RVA: 0x5DCC00 Offset: 0x5DC000 VA: 0x1805DCC00
	public string get_InternalSubset() { }

	// RVA: 0x7E53F0 Offset: 0x7E47F0 VA: 0x1807E53F0
	internal bool get_ParseWithNamespaces() { }

	// RVA: 0x11B5AF0 Offset: 0x11B4EF0 VA: 0x1811B5AF0 Slot: 43
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 44
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x4CC340 Offset: 0x4CB740 VA: 0x1804CC340
	internal SchemaInfo get_DtdSchemaInfo() { }

	// RVA: 0x4CC360 Offset: 0x4CB760 VA: 0x1804CC360
	internal void set_DtdSchemaInfo(SchemaInfo value) { }

}

public class XmlElement : XmlLinkedNode // TypeDefIndex: 1958
{	// Fields
	private XmlName name; // 0x20
	private XmlAttributeCollection attributes; // 0x28
	private XmlLinkedNode lastChild; // 0x30

	// Properties
	internal XmlName XmlName { get; set; }
	public override string Name { get; }
	public override string LocalName { get; }
	public override string NamespaceURI { get; }
	public override string Prefix { get; set; }
	public override XmlNodeType NodeType { get; }
	public override XmlNode ParentNode { get; }
	public override XmlDocument OwnerDocument { get; }
	internal override bool IsContainer { get; }
	public bool IsEmpty { get; set; }
	internal override XmlLinkedNode LastNode { get; set; }
	public override XmlAttributeCollection Attributes { get; }
	public virtual bool HasAttributes { get; }
	public override IXmlSchemaInfo SchemaInfo { get; }
	public override string InnerXml { set; }
	public override string InnerText { get; set; }
	public override XmlNode NextSibling { get; }

	// Methods

	// RVA: 0x11B7C80 Offset: 0x11B7080 VA: 0x1811B7C80
	internal void .ctor(XmlName name, bool empty, XmlDocument doc) { }

	// RVA: 0x11B7AF0 Offset: 0x11B6EF0 VA: 0x1811B7AF0
	protected internal void .ctor(string prefix, string localName, string namespaceURI, XmlDocument doc) { }

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	internal XmlName get_XmlName() { }

	// RVA: 0x497E30 Offset: 0x497230 VA: 0x180497E30
	internal void set_XmlName(XmlName value) { }

	// RVA: 0x11B6A60 Offset: 0x11B5E60 VA: 0x1811B6A60 Slot: 31
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x11B8010 Offset: 0x11B7410 VA: 0x1811B8010 Slot: 6
	public override string get_Name() { }

	// RVA: 0x11B7FF0 Offset: 0x11B73F0 VA: 0x1811B7FF0 Slot: 36
	public override string get_LocalName() { }

	// RVA: 0x11B8030 Offset: 0x11B7430 VA: 0x1811B8030 Slot: 33
	public override string get_NamespaceURI() { }

	// RVA: 0x11B80B0 Offset: 0x11B74B0 VA: 0x1811B80B0 Slot: 34
	public override string get_Prefix() { }

	// RVA: 0x11B8290 Offset: 0x11B7690 VA: 0x1811B8290 Slot: 35
	public override void set_Prefix(string value) { }

	// RVA: 0x5CB140 Offset: 0x5CA540 VA: 0x1805CB140 Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460 Slot: 10
	public override XmlNode get_ParentNode() { }

	// RVA: 0x11B8090 Offset: 0x11B7490 VA: 0x1811B8090 Slot: 15
	public override XmlDocument get_OwnerDocument() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 18
	internal override bool get_IsContainer() { }

	// RVA: 0x11B6890 Offset: 0x11B5C90 VA: 0x1811B6890 Slot: 26
	internal override XmlNode AppendChildForLoad(XmlNode newChild, XmlDocument doc) { }

	// RVA: 0x11B7FD0 Offset: 0x11B73D0 VA: 0x1811B7FD0
	public bool get_IsEmpty() { }

	// RVA: 0x11B8230 Offset: 0x11B7630 VA: 0x1811B8230
	public void set_IsEmpty(bool value) { }

	// RVA: 0x11B7FE0 Offset: 0x11B73E0 VA: 0x1811B7FE0 Slot: 19
	internal override XmlLinkedNode get_LastNode() { }

	// RVA: 0x4A2F10 Offset: 0x4A2310 VA: 0x1804A2F10 Slot: 20
	internal override void set_LastNode(XmlLinkedNode value) { }

	// RVA: 0x11B71A0 Offset: 0x11B65A0 VA: 0x1811B71A0 Slot: 27
	internal override bool IsValidChildType(XmlNodeType type) { }

	// RVA: 0x11B7E50 Offset: 0x11B7250 VA: 0x1811B7E50 Slot: 14
	public override XmlAttributeCollection get_Attributes() { }

	// RVA: 0x11B7F90 Offset: 0x11B7390 VA: 0x1811B7F90 Slot: 56
	public virtual bool get_HasAttributes() { }

	// RVA: 0x11B7060 Offset: 0x11B6460 VA: 0x1811B7060 Slot: 57
	public virtual string GetAttribute(string name) { }

	// RVA: 0x11B75C0 Offset: 0x11B69C0 VA: 0x1811B75C0 Slot: 58
	public virtual void SetAttribute(string name, string value) { }

	// RVA: 0x11B6FF0 Offset: 0x11B63F0 VA: 0x1811B6FF0 Slot: 59
	public virtual XmlAttribute GetAttributeNode(string name) { }

	// RVA: 0x11B7370 Offset: 0x11B6770 VA: 0x1811B7370 Slot: 60
	public virtual XmlAttribute SetAttributeNode(XmlAttribute newAttr) { }

	// RVA: 0x11B70E0 Offset: 0x11B64E0 VA: 0x1811B70E0 Slot: 61
	public virtual string GetAttribute(string localName, string namespaceURI) { }

	// RVA: 0x11B7490 Offset: 0x11B6890 VA: 0x1811B7490 Slot: 62
	public virtual string SetAttribute(string localName, string namespaceURI, string value) { }

	// RVA: 0x11B6F70 Offset: 0x11B6370 VA: 0x1811B6F70 Slot: 63
	public virtual XmlAttribute GetAttributeNode(string localName, string namespaceURI) { }

	// RVA: 0x11B7280 Offset: 0x11B6680 VA: 0x1811B7280 Slot: 64
	public virtual XmlAttribute SetAttributeNode(string localName, string namespaceURI) { }

	// RVA: 0x11B7180 Offset: 0x11B6580 VA: 0x1811B7180 Slot: 65
	public virtual bool HasAttribute(string name) { }

	// RVA: 0x11B79E0 Offset: 0x11B6DE0 VA: 0x1811B79E0 Slot: 43
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x11B76A0 Offset: 0x11B6AA0 VA: 0x1811B76A0
	private static void WriteElementTo(XmlWriter writer, XmlElement e) { }

	// RVA: 0x11B78B0 Offset: 0x11B6CB0 VA: 0x1811B78B0
	private void WriteStartElement(XmlWriter w) { }

	// RVA: 0xE51A10 Offset: 0xE50E10 VA: 0x180E51A10 Slot: 44
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x11B7200 Offset: 0x11B6600 VA: 0x1811B7200 Slot: 66
	public virtual void RemoveAllAttributes() { }

	// RVA: 0x11B7250 Offset: 0x11B6650 VA: 0x1811B7250 Slot: 45
	public override void RemoveAll() { }

	// RVA: 0x11B7240 Offset: 0x11B6640 VA: 0x1811B7240
	internal void RemoveAllChildren() { }

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00 Slot: 41
	public override IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x11B81B0 Offset: 0x11B75B0 VA: 0x1811B81B0 Slot: 40
	public override void set_InnerXml(string value) { }

	// RVA: 0x11B7FC0 Offset: 0x11B73C0 VA: 0x1811B7FC0 Slot: 38
	public override string get_InnerText() { }

	// RVA: 0x11B80D0 Offset: 0x11B74D0 VA: 0x1811B80D0 Slot: 39
	public override void set_InnerText(string value) { }

	// RVA: 0x11B8050 Offset: 0x11B7450 VA: 0x1811B8050 Slot: 13
	public override XmlNode get_NextSibling() { }

	// RVA: 0x4B94C0 Offset: 0x4B88C0 VA: 0x1804B94C0 Slot: 47
	internal override void SetParent(XmlNode node) { }

}

public class XmlEntity : XmlNode // TypeDefIndex: 1959
{	// Fields
	private string publicId; // 0x18
	private string systemId; // 0x20
	private string notationName; // 0x28
	private string name; // 0x30
	private string unparsedReplacementStr; // 0x38
	private string baseURI; // 0x40
	private XmlLinkedNode lastChild; // 0x48
	private bool childrenFoliating; // 0x50

	// Properties
	public override bool IsReadOnly { get; }
	public override string Name { get; }
	public override string LocalName { get; }
	public override string InnerText { get; set; }
	internal override bool IsContainer { get; }
	internal override XmlLinkedNode LastNode { get; set; }
	public override XmlNodeType NodeType { get; }
	public string SystemId { get; }
	public override string InnerXml { set; }
	public override string BaseURI { get; }

	// Methods

	// RVA: 0x11BE0F0 Offset: 0x11BD4F0 VA: 0x1811BE0F0
	internal void .ctor(string name, string strdata, string publicId, string systemId, string notationName, XmlDocument doc) { }

	// RVA: 0x11BE060 Offset: 0x11BD460 VA: 0x1811BE060 Slot: 31
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 37
	public override bool get_IsReadOnly() { }

	// RVA: 0x4A2EE0 Offset: 0x4A22E0 VA: 0x1804A2EE0 Slot: 6
	public override string get_Name() { }

	// RVA: 0x4A2EE0 Offset: 0x4A22E0 VA: 0x1804A2EE0 Slot: 36
	public override string get_LocalName() { }

	// RVA: 0x11B7FC0 Offset: 0x11B73C0 VA: 0x1811B7FC0 Slot: 38
	public override string get_InnerText() { }

	// RVA: 0x11BE340 Offset: 0x11BD740 VA: 0x1811BE340 Slot: 39
	public override void set_InnerText(string value) { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 18
	internal override bool get_IsContainer() { }

	// RVA: 0x11BE240 Offset: 0x11BD640 VA: 0x1811BE240 Slot: 19
	internal override XmlLinkedNode get_LastNode() { }

	// RVA: 0x5F7050 Offset: 0x5F6450 VA: 0x1805F7050 Slot: 20
	internal override void set_LastNode(XmlLinkedNode value) { }

	// RVA: 0x11BE0D0 Offset: 0x11BD4D0 VA: 0x1811BE0D0 Slot: 27
	internal override bool IsValidChildType(XmlNodeType type) { }

	// RVA: 0x8E3F40 Offset: 0x8E3340 VA: 0x1808E3F40 Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	public string get_SystemId() { }

	// RVA: 0x11BE3B0 Offset: 0x11BD7B0 VA: 0x1811BE3B0 Slot: 40
	public override void set_InnerXml(string value) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 43
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 44
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x4B9440 Offset: 0x4B8840 VA: 0x1804B9440 Slot: 42
	public override string get_BaseURI() { }

	// RVA: 0x4B94A0 Offset: 0x4B88A0 VA: 0x1804B94A0
	internal void SetBaseURI(string inBaseURI) { }

}

public class XmlEntityReference : XmlLinkedNode // TypeDefIndex: 1960
{	// Fields
	private string name; // 0x20
	private XmlLinkedNode lastChild; // 0x28

	// Properties
	public override string Name { get; }
	public override string LocalName { get; }
	public override string Value { get; set; }
	public override XmlNodeType NodeType { get; }
	public override bool IsReadOnly { get; }
	internal override bool IsContainer { get; }
	internal override XmlLinkedNode LastNode { get; set; }
	public override string BaseURI { get; }
	internal string ChildBaseURI { get; }

	// Methods

	// RVA: 0x11BDCB0 Offset: 0x11BD0B0 VA: 0x1811BDCB0
	protected internal void .ctor(string name, XmlDocument doc) { }

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00 Slot: 6
	public override string get_Name() { }

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00 Slot: 36
	public override string get_LocalName() { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 7
	public override string get_Value() { }

	// RVA: 0x11BDFF0 Offset: 0x11BD3F0 VA: 0x1811BDFF0 Slot: 8
	public override void set_Value(string value) { }

	// RVA: 0x70CC90 Offset: 0x70C090 VA: 0x18070CC90 Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x11BD830 Offset: 0x11BCC30 VA: 0x1811BD830 Slot: 31
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 37
	public override bool get_IsReadOnly() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 18
	internal override bool get_IsContainer() { }

	// RVA: 0x11BD940 Offset: 0x11BCD40 VA: 0x1811BD940 Slot: 47
	internal override void SetParent(XmlNode node) { }

	// RVA: 0xE2B140 Offset: 0xE2A540 VA: 0x180E2B140 Slot: 48
	internal override void SetParentForLoad(XmlNode node) { }

	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230 Slot: 19
	internal override XmlLinkedNode get_LastNode() { }

	// RVA: 0x7CE240 Offset: 0x7CD640 VA: 0x1807CE240 Slot: 20
	internal override void set_LastNode(XmlLinkedNode value) { }

	// RVA: 0x11B71A0 Offset: 0x11B65A0 VA: 0x1811B71A0 Slot: 27
	internal override bool IsValidChildType(XmlNodeType type) { }

	// RVA: 0x11BDC80 Offset: 0x11BD080 VA: 0x1811BDC80 Slot: 43
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x11BDA20 Offset: 0x11BCE20 VA: 0x1811BDA20 Slot: 44
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x11BDE40 Offset: 0x11BD240 VA: 0x1811BDE40 Slot: 42
	public override string get_BaseURI() { }

	// RVA: 0x11BD880 Offset: 0x11BCC80 VA: 0x1811BD880
	private string ConstructBaseURI(string baseURI, string systemId) { }

	// RVA: 0x11BDE80 Offset: 0x11BD280 VA: 0x1811BDE80
	internal string get_ChildBaseURI() { }

}

public enum XmlNodeChangedAction // TypeDefIndex: 1961
{	// Fields
	public int value__; // 0x0
	public const XmlNodeChangedAction Insert = 0;
	public const XmlNodeChangedAction Remove = 1;
	public const XmlNodeChangedAction Change = 2;

}

public class XmlImplementation // TypeDefIndex: 1962
{	// Fields
	private XmlNameTable nameTable; // 0x10

	// Properties
	internal XmlNameTable NameTable { get; }

	// Methods

	// RVA: 0x11C1800 Offset: 0x11C0C00 VA: 0x1811C1800
	public void .ctor() { }

	// RVA: 0x6C0000 Offset: 0x6BF400 VA: 0x1806C0000
	public void .ctor(XmlNameTable nt) { }

	// RVA: 0x11C17A0 Offset: 0x11C0BA0 VA: 0x1811C17A0 Slot: 4
	public virtual XmlDocument CreateDocument() { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	internal XmlNameTable get_NameTable() { }

}

public abstract class XmlLinkedNode : XmlNode // TypeDefIndex: 1963
{	// Fields
	internal XmlLinkedNode next; // 0x18

	// Properties
	public override XmlNode PreviousSibling { get; }
	public override XmlNode NextSibling { get; }

	// Methods

	// RVA: 0x11C1870 Offset: 0x11C0C70 VA: 0x1811C1870
	internal void .ctor(XmlDocument doc) { }

	// RVA: 0x11C1980 Offset: 0x11C0D80 VA: 0x1811C1980 Slot: 12
	public override XmlNode get_PreviousSibling() { }

	// RVA: 0x11C1920 Offset: 0x11C0D20 VA: 0x1811C1920 Slot: 13
	public override XmlNode get_NextSibling() { }

}

internal class XmlLoader // TypeDefIndex: 1964
{	// Fields
	private XmlDocument doc; // 0x10
	private XmlReader reader; // 0x18
	private bool preserveWhitespace; // 0x20

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x11C5B00 Offset: 0x11C4F00 VA: 0x1811C5B00
	internal void Load(XmlDocument doc, XmlReader reader, bool preserveWhitespace) { }

	// RVA: 0x11C3BE0 Offset: 0x11C2FE0 VA: 0x1811C3BE0
	private void LoadDocSequence(XmlDocument parentDoc) { }

	// RVA: 0x11C6500 Offset: 0x11C5900 VA: 0x1811C6500
	internal XmlNode ReadCurrentNode(XmlDocument doc, XmlReader reader) { }

	// RVA: 0x11C5440 Offset: 0x11C4840 VA: 0x1811C5440
	private XmlNode LoadNode(bool skipOverWhitespace) { }

	// RVA: 0x11C3000 Offset: 0x11C2400 VA: 0x1811C3000
	private XmlAttribute LoadAttributeNode() { }

	// RVA: 0x11C3820 Offset: 0x11C2C20 VA: 0x1811C3820
	private XmlAttribute LoadDefaultAttribute() { }

	// RVA: 0x11C3360 Offset: 0x11C2760 VA: 0x1811C3360
	private void LoadAttributeValue(XmlNode parent, bool direct) { }

	// RVA: 0x11C49D0 Offset: 0x11C3DD0 VA: 0x1811C49D0
	private XmlEntityReference LoadEntityReferenceNode(bool direct) { }

	// RVA: 0x11C3650 Offset: 0x11C2A50 VA: 0x1811C3650
	private XmlDeclaration LoadDeclarationNode() { }

	// RVA: 0x11C3C50 Offset: 0x11C3050 VA: 0x1811C3C50
	private XmlDocumentType LoadDocumentTypeNode() { }

	// RVA: 0x11C4DC0 Offset: 0x11C41C0 VA: 0x1811C4DC0
	private XmlNode LoadNodeDirect() { }

	// RVA: 0x11C2A90 Offset: 0x11C1E90 VA: 0x1811C2A90
	private XmlAttribute LoadAttributeNodeDirect() { }

	// RVA: 0x11C6050 Offset: 0x11C5450 VA: 0x1811C6050
	internal void ParseDocumentType(XmlDocumentType dtNode) { }

	// RVA: 0x11C5DE0 Offset: 0x11C51E0 VA: 0x1811C5DE0
	private void ParseDocumentType(XmlDocumentType dtNode, bool bUseResolver, XmlResolver resolver) { }

	// RVA: 0x11C3E80 Offset: 0x11C3280 VA: 0x1811C3E80
	private void LoadDocumentType(IDtdInfo dtdInfo, XmlDocumentType dtNode) { }

	// RVA: 0x11C2200 Offset: 0x11C1600 VA: 0x1811C2200
	private XmlParserContext GetContext(XmlNode node) { }

	// RVA: 0x11C60D0 Offset: 0x11C54D0 VA: 0x1811C60D0
	internal XmlNamespaceManager ParsePartialContent(XmlNode parentNode, string innerxmltext, XmlNodeType nt) { }

	// RVA: 0x11C4C20 Offset: 0x11C4020 VA: 0x1811C4C20
	internal void LoadInnerXmlElement(XmlElement node, string innerxmltext) { }

	// RVA: 0x11C4C00 Offset: 0x11C4000 VA: 0x1811C4C00
	internal void LoadInnerXmlAttribute(XmlAttribute node, string innerxmltext) { }

	// RVA: 0x11C66A0 Offset: 0x11C5AA0 VA: 0x1811C66A0
	private void RemoveDuplicateNamespace(XmlElement elem, XmlNamespaceManager mgr, bool fCheckElemAttrs) { }

	// RVA: 0x11C1C30 Offset: 0x11C1030 VA: 0x1811C1C30
	private string EntitizeName(string name) { }

	// RVA: 0x11C2160 Offset: 0x11C1560 VA: 0x1811C2160
	internal void ExpandEntity(XmlEntity ent) { }

	// RVA: 0x11C1C80 Offset: 0x11C1080 VA: 0x1811C1C80
	internal void ExpandEntityReference(XmlEntityReference eref) { }

	// RVA: 0x11C1A00 Offset: 0x11C0E00 VA: 0x1811C1A00
	private XmlReader CreateInnerXmlReader(string xmlFragment, XmlNodeType nt, XmlParserContext context, XmlDocument doc) { }

	// RVA: 0x11C6300 Offset: 0x11C5700 VA: 0x1811C6300
	internal static void ParseXmlDeclarationValue(string strValue, out string version, out string encoding, out string standalone) { }

	// RVA: 0x11C69C0 Offset: 0x11C5DC0 VA: 0x1811C69C0
	internal static Exception UnexpectedNodeType(XmlNodeType nodetype) { }

}

internal class XmlName : IXmlSchemaInfo // TypeDefIndex: 1965
{	// Fields
	private string prefix; // 0x10
	private string localName; // 0x18
	private string ns; // 0x20
	private string name; // 0x28
	private int hashCode; // 0x30
	internal XmlDocument ownerDoc; // 0x38
	internal XmlName next; // 0x40

	// Properties
	public string LocalName { get; }
	public string NamespaceURI { get; }
	public string Prefix { get; }
	public int HashCode { get; }
	public XmlDocument OwnerDocument { get; }
	public string Name { get; }
	public virtual XmlSchemaValidity Validity { get; }
	public virtual bool IsDefault { get; }
	public virtual bool IsNil { get; }
	public virtual XmlSchemaSimpleType MemberType { get; }
	public virtual XmlSchemaType SchemaType { get; }
	public virtual XmlSchemaElement SchemaElement { get; }
	public virtual XmlSchemaAttribute SchemaAttribute { get; }

	// Methods

	// RVA: 0x11C6FE0 Offset: 0x11C63E0 VA: 0x1811C6FE0
	public static XmlName Create(string prefix, string localName, string ns, int hashCode, XmlDocument ownerDoc, XmlName next, IXmlSchemaInfo schemaInfo) { }

	// RVA: 0x11C7270 Offset: 0x11C6670 VA: 0x1811C7270
	internal void .ctor(string prefix, string localName, string ns, int hashCode, XmlDocument ownerDoc, XmlName next) { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public string get_LocalName() { }

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	public string get_NamespaceURI() { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public string get_Prefix() { }

	// RVA: 0xA178C0 Offset: 0xA16CC0 VA: 0x180A178C0
	public int get_HashCode() { }

	// RVA: 0x5DCC00 Offset: 0x5DC000 VA: 0x1805DCC00
	public XmlDocument get_OwnerDocument() { }

	// RVA: 0x11C7320 Offset: 0x11C6720 VA: 0x1811C7320
	public string get_Name() { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 11
	public virtual XmlSchemaValidity get_Validity() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 12
	public virtual bool get_IsDefault() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 13
	public virtual bool get_IsNil() { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 14
	public virtual XmlSchemaSimpleType get_MemberType() { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 15
	public virtual XmlSchemaType get_SchemaType() { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 16
	public virtual XmlSchemaElement get_SchemaElement() { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 17
	public virtual XmlSchemaAttribute get_SchemaAttribute() { }

	// RVA: 0xDEAFD0 Offset: 0xDEA3D0 VA: 0x180DEAFD0 Slot: 18
	public virtual bool Equals(IXmlSchemaInfo schemaInfo) { }

	// RVA: 0x11C7200 Offset: 0x11C6600 VA: 0x1811C7200
	public static int GetHashCode(string name) { }

}

internal sealed class XmlNameEx : XmlName // TypeDefIndex: 1966
{	// Fields
	private byte flags; // 0x48
	private XmlSchemaSimpleType memberType; // 0x50
	private XmlSchemaType schemaType; // 0x58
	private object decl; // 0x60

	// Properties
	public override XmlSchemaValidity Validity { get; }
	public override bool IsDefault { get; }
	public override bool IsNil { get; }
	public override XmlSchemaSimpleType MemberType { get; }
	public override XmlSchemaType SchemaType { get; }
	public override XmlSchemaElement SchemaElement { get; }
	public override XmlSchemaAttribute SchemaAttribute { get; }

	// Methods

	// RVA: 0x11C6CF0 Offset: 0x11C60F0 VA: 0x1811C6CF0
	internal void .ctor(string prefix, string localName, string ns, int hashCode, XmlDocument ownerDoc, XmlName next, IXmlSchemaInfo schemaInfo) { }

	// RVA: 0x11C6FB0 Offset: 0x11C63B0 VA: 0x1811C6FB0 Slot: 11
	public override XmlSchemaValidity get_Validity() { }

	// RVA: 0x11C6E90 Offset: 0x11C6290 VA: 0x1811C6E90 Slot: 12
	public override bool get_IsDefault() { }

	// RVA: 0x11C6EA0 Offset: 0x11C62A0 VA: 0x1811C6EA0 Slot: 13
	public override bool get_IsNil() { }

	// RVA: 0x4CC350 Offset: 0x4CB750 VA: 0x1804CC350 Slot: 14
	public override XmlSchemaSimpleType get_MemberType() { }

	// RVA: 0x4CC340 Offset: 0x4CB740 VA: 0x1804CC340 Slot: 15
	public override XmlSchemaType get_SchemaType() { }

	// RVA: 0x11C6F30 Offset: 0x11C6330 VA: 0x1811C6F30 Slot: 16
	public override XmlSchemaElement get_SchemaElement() { }

	// RVA: 0x11C6EB0 Offset: 0x11C62B0 VA: 0x1811C6EB0 Slot: 17
	public override XmlSchemaAttribute get_SchemaAttribute() { }

	// RVA: 0x11C6CE0 Offset: 0x11C60E0 VA: 0x1811C6CE0
	public void SetValidity(XmlSchemaValidity value) { }

	// RVA: 0x11C6C80 Offset: 0x11C6080 VA: 0x1811C6C80
	public void SetIsDefault(bool value) { }

	// RVA: 0x11C6CB0 Offset: 0x11C60B0 VA: 0x1811C6CB0
	public void SetIsNil(bool value) { }

	// RVA: 0x11C6AC0 Offset: 0x11C5EC0 VA: 0x1811C6AC0 Slot: 18
	public override bool Equals(IXmlSchemaInfo schemaInfo) { }

}

public class XmlNamedNodeMap : IEnumerable // TypeDefIndex: 1967
{	// Fields
	internal XmlNode parent; // 0x10
	internal XmlNamedNodeMap.SmallXmlNodeList nodes; // 0x18

	// Properties
	public virtual int Count { get; }

	// Methods

	// RVA: 0x6C0000 Offset: 0x6BF400 VA: 0x1806C0000
	internal void .ctor(XmlNode parent) { }

	// RVA: 0x11C79C0 Offset: 0x11C6DC0 VA: 0x1811C79C0 Slot: 5
	public virtual XmlNode GetNamedItem(string name) { }

	// RVA: 0x11C7F30 Offset: 0x11C7330 VA: 0x1811C7F30 Slot: 6
	public virtual XmlNode SetNamedItem(XmlNode node) { }

	// RVA: 0x11C8110 Offset: 0x11C7510 VA: 0x1811C8110 Slot: 7
	public virtual int get_Count() { }

	// RVA: 0x11C79B0 Offset: 0x11C6DB0 VA: 0x1811C79B0 Slot: 8
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x11C7770 Offset: 0x11C6B70 VA: 0x1811C7770
	internal int FindNodeOffset(string name) { }

	// RVA: 0x11C7870 Offset: 0x11C6C70 VA: 0x1811C7870
	internal int FindNodeOffset(string localName, string namespaceURI) { }

	// RVA: 0x11C7590 Offset: 0x11C6990 VA: 0x1811C7590 Slot: 9
	internal virtual XmlNode AddNode(XmlNode node) { }

	// RVA: 0x11C74D0 Offset: 0x11C68D0 VA: 0x1811C74D0 Slot: 10
	internal virtual XmlNode AddNodeForLoad(XmlNode node, XmlDocument doc) { }

	// RVA: 0x11C7D40 Offset: 0x11C7140 VA: 0x1811C7D40 Slot: 11
	internal virtual XmlNode RemoveNodeAt(int i) { }

	// RVA: 0x11C7EC0 Offset: 0x11C72C0 VA: 0x1811C7EC0
	internal XmlNode ReplaceNodeAt(int i, XmlNode node) { }

	// RVA: 0x11C7B50 Offset: 0x11C6F50 VA: 0x1811C7B50 Slot: 12
	internal virtual XmlNode InsertNodeAt(int i, XmlNode node) { }

}

internal struct XmlNamedNodeMap.SmallXmlNodeList // TypeDefIndex: 1968
{	// Fields
	private object field; // 0x0

	// Properties
	public int Count { get; }
	public object Item { get; }

	// Methods

	// RVA: 0x1D0A80 Offset: 0x1CFE80 VA: 0x1801D0A80
	public int get_Count() { }

	// RVA: 0x1D0A90 Offset: 0x1CFE90 VA: 0x1801D0A90
	public object get_Item(int index) { }

	// RVA: 0x1D0A40 Offset: 0x1CFE40 VA: 0x1801D0A40
	public void Add(object value) { }

	// RVA: 0x1D0A70 Offset: 0x1CFE70 VA: 0x1801D0A70
	public void RemoveAt(int index) { }

	// RVA: 0x1D0A60 Offset: 0x1CFE60 VA: 0x1801D0A60
	public void Insert(int index, object value) { }

	// RVA: 0x1D0A50 Offset: 0x1CFE50 VA: 0x1801D0A50
	public IEnumerator GetEnumerator() { }

}

private class XmlNamedNodeMap.SmallXmlNodeList.SingleObjectEnumerator : IEnumerator // TypeDefIndex: 1969
{	// Fields
	private object loneValue; // 0x10
	private int position; // 0x18

	// Properties
	public object Current { get; }

	// Methods

	// RVA: 0x11B44A0 Offset: 0x11B38A0 VA: 0x1811B44A0
	public void .ctor(object value) { }

	// RVA: 0x11B44E0 Offset: 0x11B38E0 VA: 0x1811B44E0 Slot: 5
	public object get_Current() { }

	// RVA: 0x11B4480 Offset: 0x11B3880 VA: 0x1811B4480 Slot: 4
	public bool MoveNext() { }

	// RVA: 0x1176E50 Offset: 0x1176250 VA: 0x181176E50 Slot: 6
	public void Reset() { }

}

public abstract class XmlNode : ICloneable, IEnumerable // TypeDefIndex: 1970
{	// Fields
	internal XmlNode parentNode; // 0x10

	// Properties
	public abstract string Name { get; }
	public virtual string Value { get; set; }
	public abstract XmlNodeType NodeType { get; }
	public virtual XmlNode ParentNode { get; }
	public virtual XmlNodeList ChildNodes { get; }
	public virtual XmlNode PreviousSibling { get; }
	public virtual XmlNode NextSibling { get; }
	public virtual XmlAttributeCollection Attributes { get; }
	public virtual XmlDocument OwnerDocument { get; }
	public virtual XmlNode FirstChild { get; }
	public virtual XmlNode LastChild { get; }
	internal virtual bool IsContainer { get; }
	internal virtual XmlLinkedNode LastNode { get; set; }
	public virtual bool HasChildNodes { get; }
	public virtual string NamespaceURI { get; }
	public virtual string Prefix { get; set; }
	public abstract string LocalName { get; }
	public virtual bool IsReadOnly { get; }
	public virtual string InnerText { get; set; }
	public virtual string InnerXml { set; }
	public virtual IXmlSchemaInfo SchemaInfo { get; }
	public virtual string BaseURI { get; }
	internal XmlDocument Document { get; }
	internal virtual XmlSpace XmlSpace { get; }
	internal virtual string XmlLang { get; }
	internal virtual bool IsText { get; }

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	internal void .ctor() { }

	// RVA: 0x11CCC60 Offset: 0x11CC060 VA: 0x1811CCC60
	internal void .ctor(XmlDocument doc) { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract string get_Name();

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 7
	public virtual string get_Value() { }

	// RVA: 0x11CD860 Offset: 0x11CCC60 VA: 0x1811CD860 Slot: 8
	public virtual void set_Value(string value) { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract XmlNodeType get_NodeType();

	// RVA: 0x11CD300 Offset: 0x11CC700 VA: 0x1811CD300 Slot: 10
	public virtual XmlNode get_ParentNode() { }

	// RVA: 0x11CCE40 Offset: 0x11CC240 VA: 0x1811CCE40 Slot: 11
	public virtual XmlNodeList get_ChildNodes() { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 12
	public virtual XmlNode get_PreviousSibling() { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 13
	public virtual XmlNode get_NextSibling() { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 14
	public virtual XmlAttributeCollection get_Attributes() { }

	// RVA: 0x11CD230 Offset: 0x11CC630 VA: 0x1811CD230 Slot: 15
	public virtual XmlDocument get_OwnerDocument() { }

	// RVA: 0x11CCF40 Offset: 0x11CC340 VA: 0x1811CCF40 Slot: 16
	public virtual XmlNode get_FirstChild() { }

	// RVA: 0x11CD1D0 Offset: 0x11CC5D0 VA: 0x1811CD1D0 Slot: 17
	public virtual XmlNode get_LastChild() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 18
	internal virtual bool get_IsContainer() { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 19
	internal virtual XmlLinkedNode get_LastNode() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 20
	internal virtual void set_LastNode(XmlLinkedNode value) { }

	// RVA: 0x11CA500 Offset: 0x11C9900 VA: 0x1811CA500
	internal bool AncestorNode(XmlNode node) { }

	// RVA: 0x11CBE20 Offset: 0x11CB220 VA: 0x1811CBE20 Slot: 21
	public virtual XmlNode InsertBefore(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x11CB730 Offset: 0x11CAB30 VA: 0x1811CB730 Slot: 22
	public virtual XmlNode InsertAfter(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x11CC610 Offset: 0x11CBA10 VA: 0x1811CC610 Slot: 23
	public virtual XmlNode RemoveChild(XmlNode oldChild) { }

	// RVA: 0x11CC540 Offset: 0x11CB940 VA: 0x1811CC540 Slot: 24
	public virtual XmlNode PrependChild(XmlNode newChild) { }

	// RVA: 0x11CA860 Offset: 0x11C9C60 VA: 0x1811CA860 Slot: 25
	public virtual XmlNode AppendChild(XmlNode newChild) { }

	// RVA: 0x11CA570 Offset: 0x11C9970 VA: 0x1811CA570 Slot: 26
	internal virtual XmlNode AppendChildForLoad(XmlNode newChild, XmlDocument doc) { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 27
	internal virtual bool IsValidChildType(XmlNodeType type) { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 28
	internal virtual bool CanInsertBefore(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 29
	internal virtual bool CanInsertAfter(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x11CCF70 Offset: 0x11CC370 VA: 0x1811CCF70 Slot: 30
	public virtual bool get_HasChildNodes() { }

	// RVA: -1 Offset: -1 Slot: 31
	public abstract XmlNode CloneNode(bool deep);

	// RVA: 0x11CAE40 Offset: 0x11CA240 VA: 0x1811CAE40 Slot: 32
	internal virtual void CopyChildren(XmlDocument doc, XmlNode container, bool deep) { }

	// RVA: 0x11CD1F0 Offset: 0x11CC5F0 VA: 0x1811CD1F0 Slot: 33
	public virtual string get_NamespaceURI() { }

	// RVA: 0x11CD3F0 Offset: 0x11CC7F0 VA: 0x1811CD3F0 Slot: 34
	public virtual string get_Prefix() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 35
	public virtual void set_Prefix(string value) { }

	// RVA: -1 Offset: -1 Slot: 36
	public abstract string get_LocalName();

	// RVA: 0x11CD0A0 Offset: 0x11CC4A0 VA: 0x1811CD0A0 Slot: 37
	public virtual bool get_IsReadOnly() { }

	// RVA: 0x11CB610 Offset: 0x11CAA10 VA: 0x1811CB610
	internal static bool HasReadOnlyParent(XmlNode n) { }

	// RVA: 0x11CCC00 Offset: 0x11CC000 VA: 0x1811CCC00 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x11CCBA0 Offset: 0x11CBFA0 VA: 0x1811CCBA0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x11CAF70 Offset: 0x11CA370 VA: 0x1811CAF70
	public IEnumerator GetEnumerator() { }

	// RVA: 0x11CA750 Offset: 0x11C9B50 VA: 0x1811CA750
	private void AppendChildText(StringBuilder builder) { }

	// RVA: 0x11CCF90 Offset: 0x11CC390 VA: 0x1811CCF90 Slot: 38
	public virtual string get_InnerText() { }

	// RVA: 0x11CD6F0 Offset: 0x11CCAF0 VA: 0x1811CD6F0 Slot: 39
	public virtual void set_InnerText(string value) { }

	// RVA: 0x11CD7F0 Offset: 0x11CCBF0 VA: 0x1811CD7F0 Slot: 40
	public virtual void set_InnerXml(string value) { }

	// RVA: 0x11CD430 Offset: 0x11CC830 VA: 0x1811CD430 Slot: 41
	public virtual IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x11CCD00 Offset: 0x11CC100 VA: 0x1811CCD00 Slot: 42
	public virtual string get_BaseURI() { }

	// RVA: -1 Offset: -1 Slot: 43
	public abstract void WriteTo(XmlWriter w);

	// RVA: -1 Offset: -1 Slot: 44
	public abstract void WriteContentTo(XmlWriter w);

	// RVA: 0x11CC590 Offset: 0x11CB990 VA: 0x1811CC590 Slot: 45
	public virtual void RemoveAll() { }

	// RVA: 0x11CCEA0 Offset: 0x11CC2A0 VA: 0x1811CCEA0
	internal XmlDocument get_Document() { }

	// RVA: 0x11CB5B0 Offset: 0x11CA9B0 VA: 0x1811CB5B0 Slot: 46
	public virtual string GetPrefixOfNamespace(string namespaceURI) { }

	// RVA: 0x11CB100 Offset: 0x11CA500 VA: 0x1811CB100
	internal string GetPrefixOfNamespaceStrict(string namespaceURI) { }

	// RVA: 0x11CCA80 Offset: 0x11CBE80 VA: 0x1811CCA80 Slot: 47
	internal virtual void SetParent(XmlNode node) { }

	// RVA: 0x4B94C0 Offset: 0x4B88C0 VA: 0x1804B94C0 Slot: 48
	internal virtual void SetParentForLoad(XmlNode node) { }

	// RVA: 0x11CCAC0 Offset: 0x11CBEC0 VA: 0x1811CCAC0
	internal static void SplitName(string name, out string prefix, out string localName) { }

	// RVA: 0x11CAEF0 Offset: 0x11CA2F0 VA: 0x1811CAEF0 Slot: 49
	internal virtual XmlNode FindChild(XmlNodeType type) { }

	// RVA: 0x11CAFD0 Offset: 0x11CA3D0 VA: 0x1811CAFD0 Slot: 50
	internal virtual XmlNodeChangedEventArgs GetEventArgs(XmlNode node, XmlNode oldParent, XmlNode newParent, string oldValue, string newValue, XmlNodeChangedAction action) { }

	// RVA: 0x11CADF0 Offset: 0x11CA1F0 VA: 0x1811CADF0 Slot: 51
	internal virtual void BeforeEvent(XmlNodeChangedEventArgs args) { }

	// RVA: 0x11CA4B0 Offset: 0x11C98B0 VA: 0x1811CA4B0 Slot: 52
	internal virtual void AfterEvent(XmlNodeChangedEventArgs args) { }

	// RVA: 0x11CD590 Offset: 0x11CC990 VA: 0x1811CD590 Slot: 53
	internal virtual XmlSpace get_XmlSpace() { }

	// RVA: 0x11CD490 Offset: 0x11CC890 VA: 0x1811CD490 Slot: 54
	internal virtual string get_XmlLang() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 55
	internal virtual bool get_IsText() { }

	// RVA: 0x11CC510 Offset: 0x11CB910 VA: 0x1811CC510
	internal static void NestTextNodes(XmlNode prevNode, XmlNode nextNode) { }

	// RVA: 0x11CCC20 Offset: 0x11CC020 VA: 0x1811CCC20
	internal static void UnnestTextNodes(XmlNode prevNode, XmlNode nextNode) { }

}

public class XmlNodeChangedEventArgs : EventArgs // TypeDefIndex: 1971
{	// Fields
	private XmlNodeChangedAction action; // 0x10
	private XmlNode node; // 0x18
	private XmlNode oldParent; // 0x20
	private XmlNode newParent; // 0x28
	private string oldValue; // 0x30
	private string newValue; // 0x38

	// Properties
	public XmlNodeChangedAction Action { get; }

	// Methods

	// RVA: 0x11C9090 Offset: 0x11C8490 VA: 0x1811C9090
	public void .ctor(XmlNode node, XmlNode oldParent, XmlNode newParent, string oldValue, string newValue, XmlNodeChangedAction action) { }

	// RVA: 0x36A480 Offset: 0x369880 VA: 0x18036A480
	public XmlNodeChangedAction get_Action() { }

}

public sealed class XmlNodeChangedEventHandler : MulticastDelegate // TypeDefIndex: 1972
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xADFD50 Offset: 0xADF150 VA: 0x180ADFD50 Slot: 12
	public virtual void Invoke(object sender, XmlNodeChangedEventArgs e) { }

	// RVA: 0xADFD10 Offset: 0xADF110 VA: 0x180ADFD10 Slot: 13
	public virtual IAsyncResult BeginInvoke(object sender, XmlNodeChangedEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public abstract class XmlNodeList : IEnumerable, IDisposable // TypeDefIndex: 1973
{	// Properties
	public abstract int Count { get; }
	public virtual XmlNode ItemOf { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 6
	public abstract XmlNode Item(int index);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract int get_Count();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract IEnumerator GetEnumerator();

	// RVA: 0x11C9160 Offset: 0x11C8560 VA: 0x1811C9160 Slot: 9
	public virtual XmlNode get_ItemOf(int i) { }

	// RVA: 0xE35F10 Offset: 0xE35310 VA: 0x180E35F10 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 10
	protected virtual void PrivateDisposeNodeList() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	protected void .ctor() { }

}

internal class XmlNodeReaderNavigator // TypeDefIndex: 1974
{	// Fields
	private XmlNode curNode; // 0x10
	private XmlNode elemNode; // 0x18
	private XmlNode logNode; // 0x20
	private int attrIndex; // 0x28
	private int logAttrIndex; // 0x2C
	private XmlNameTable nameTable; // 0x30
	private XmlDocument doc; // 0x38
	private int nAttrInd; // 0x40
	private int nDeclarationAttrCount; // 0x44
	private int nDocTypeAttrCount; // 0x48
	private int nLogLevel; // 0x4C
	private int nLogAttrInd; // 0x50
	private bool bLogOnAttrVal; // 0x54
	private bool bCreatedOnAttribute; // 0x55
	internal XmlNodeReaderNavigator.VirtualAttribute[] decNodeAttributes; // 0x58
	internal XmlNodeReaderNavigator.VirtualAttribute[] docTypeNodeAttributes; // 0x60
	private bool bOnAttrVal; // 0x68

	// Properties
	public XmlNodeType NodeType { get; }
	public string NamespaceURI { get; }
	public string Name { get; }
	public string LocalName { get; }
	internal bool CreatedOnAttribute { get; }
	public string Prefix { get; }
	public string Value { get; }
	public string BaseURI { get; }
	public XmlSpace XmlSpace { get; }
	public string XmlLang { get; }
	public bool IsEmptyElement { get; }
	public bool IsDefault { get; }
	public IXmlSchemaInfo SchemaInfo { get; }
	public XmlNameTable NameTable { get; }
	public int AttributeCount { get; }
	private bool IsOnDeclOrDocType { get; }
	public XmlDocument Document { get; }

	// Methods

	// RVA: 0xB99AE0 Offset: 0xB98EE0 VA: 0x180B99AE0
	public void .ctor(XmlNode node) { }

	// RVA: 0xB9A600 Offset: 0xB99A00 VA: 0x180B9A600
	public XmlNodeType get_NodeType() { }

	// RVA: 0xB9A5D0 Offset: 0xB999D0 VA: 0x180B9A5D0
	public string get_NamespaceURI() { }

	// RVA: 0xB9A480 Offset: 0xB99880 VA: 0x180B9A480
	public string get_Name() { }

	// RVA: 0xB9A270 Offset: 0xB99670 VA: 0x180B9A270
	public string get_LocalName() { }

	// RVA: 0xB9A030 Offset: 0xB99430 VA: 0x180B9A030
	internal bool get_CreatedOnAttribute() { }

	// RVA: 0xB98270 Offset: 0xB97670 VA: 0x180B98270
	private bool IsLocalNameEmpty(XmlNodeType nt) { }

	// RVA: 0xB9A640 Offset: 0xB99A40 VA: 0x180B9A640
	public string get_Prefix() { }

	// RVA: 0xB9A6A0 Offset: 0xB99AA0 VA: 0x180B9A6A0
	public string get_Value() { }

	// RVA: 0xB9A000 Offset: 0xB99400 VA: 0x180B9A000
	public string get_BaseURI() { }

	// RVA: 0xB9A9A0 Offset: 0xB99DA0 VA: 0x180B9A9A0
	public XmlSpace get_XmlSpace() { }

	// RVA: 0xB9A970 Offset: 0xB99D70 VA: 0x180B9A970
	public string get_XmlLang() { }

	// RVA: 0xB9A140 Offset: 0xB99540 VA: 0x180B9A140
	public bool get_IsEmptyElement() { }

	// RVA: 0xB9A040 Offset: 0xB99440 VA: 0x180B9A040
	public bool get_IsDefault() { }

	// RVA: 0xB9A670 Offset: 0xB99A70 VA: 0x180B9A670
	public IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x4A2EE0 Offset: 0x4A22E0 VA: 0x1804A2EE0
	public XmlNameTable get_NameTable() { }

	// RVA: 0xB99E70 Offset: 0xB99270 VA: 0x180B99E70
	public int get_AttributeCount() { }

	// RVA: 0xB96A20 Offset: 0xB95E20 VA: 0x180B96A20
	private void CheckIndexCondition(int attributeIndex) { }

	// RVA: 0xB97ED0 Offset: 0xB972D0 VA: 0x180B97ED0
	private void InitDecAttr() { }

	// RVA: 0xB977A0 Offset: 0xB96BA0 VA: 0x180B977A0
	public string GetDeclarationAttr(XmlDeclaration decl, string name) { }

	// RVA: 0xB97740 Offset: 0xB96B40 VA: 0x180B97740
	public string GetDeclarationAttr(int i) { }

	// RVA: 0xB976A0 Offset: 0xB96AA0 VA: 0x180B976A0
	public int GetDecAttrInd(string name) { }

	// RVA: 0xB98100 Offset: 0xB97500 VA: 0x180B98100
	private void InitDocTypeAttr() { }

	// RVA: 0xB97900 Offset: 0xB96D00 VA: 0x180B97900
	public string GetDocumentTypeAttr(XmlDocumentType docType, string name) { }

	// RVA: 0xB979A0 Offset: 0xB96DA0 VA: 0x180B979A0
	public string GetDocumentTypeAttr(int i) { }

	// RVA: 0xB97860 Offset: 0xB96C60 VA: 0x180B97860
	public int GetDocTypeAttrInd(string name) { }

	// RVA: 0xB96C30 Offset: 0xB96030 VA: 0x180B96C30
	private string GetAttributeFromElement(XmlElement elem, string name) { }

	// RVA: 0xB97320 Offset: 0xB96720 VA: 0x180B97320
	public string GetAttribute(string name) { }

	// RVA: 0xB96BD0 Offset: 0xB95FD0 VA: 0x180B96BD0
	private string GetAttributeFromElement(XmlElement elem, string name, string ns) { }

	// RVA: 0xB96F70 Offset: 0xB96370 VA: 0x180B96F70
	public string GetAttribute(string name, string ns) { }

	// RVA: 0xB96C80 Offset: 0xB96080 VA: 0x180B96C80
	public string GetAttribute(int attributeIndex) { }

	// RVA: 0xB982C0 Offset: 0xB976C0 VA: 0x180B982C0
	public void LogMove(int level) { }

	// RVA: 0xB99A90 Offset: 0xB98E90 VA: 0x180B99A90
	public void RollBackMove(ref int level) { }

	// RVA: 0xB9A230 Offset: 0xB99630 VA: 0x180B9A230
	private bool get_IsOnDeclOrDocType() { }

	// RVA: 0xB999B0 Offset: 0xB98DB0 VA: 0x180B999B0
	public void ResetToAttribute(ref int level) { }

	// RVA: 0xB996F0 Offset: 0xB98AF0 VA: 0x180B996F0
	public void ResetMove(ref int level, ref XmlNodeType nt) { }

	// RVA: 0xB98D70 Offset: 0xB98170 VA: 0x180B98D70
	public bool MoveToAttribute(string name) { }

	// RVA: 0xB98A00 Offset: 0xB97E00 VA: 0x180B98A00
	private bool MoveToAttributeFromElement(XmlElement elem, string name, string ns) { }

	// RVA: 0xB98AE0 Offset: 0xB97EE0 VA: 0x180B98AE0
	public bool MoveToAttribute(string name, string namespaceURI) { }

	// RVA: 0xB98DD0 Offset: 0xB981D0 VA: 0x180B98DD0
	public void MoveToAttribute(int attributeIndex) { }

	// RVA: 0xB99150 Offset: 0xB98550 VA: 0x180B99150
	public bool MoveToNextAttribute(ref int level) { }

	// RVA: 0xB99450 Offset: 0xB98850 VA: 0x180B99450
	public bool MoveToParent() { }

	// RVA: 0xB990E0 Offset: 0xB984E0 VA: 0x180B990E0
	public bool MoveToFirstChild() { }

	// RVA: 0xB99360 Offset: 0xB98760 VA: 0x180B99360
	private bool MoveToNextSibling(XmlNode node) { }

	// RVA: 0xB993C0 Offset: 0xB987C0 VA: 0x180B993C0
	public bool MoveToNext() { }

	// RVA: 0xB99040 Offset: 0xB98440 VA: 0x180B99040
	public bool MoveToElement() { }

	// RVA: 0xB98300 Offset: 0xB97700 VA: 0x180B98300
	public string LookupNamespace(string prefix) { }

	// RVA: 0xB96AA0 Offset: 0xB95EA0 VA: 0x180B96AA0
	internal string DefaultLookupNamespace(string prefix) { }

	// RVA: 0xB985E0 Offset: 0xB979E0 VA: 0x180B985E0
	internal string LookupPrefix(string namespaceName) { }

	// RVA: 0xB97A00 Offset: 0xB96E00 VA: 0x180B97A00
	internal IDictionary<string, string> GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0xB994C0 Offset: 0xB988C0 VA: 0x180B994C0
	public bool ReadAttributeValue(ref int level, ref bool bResolveEntity, ref XmlNodeType nt) { }

	// RVA: 0x5DCC00 Offset: 0x5DC000 VA: 0x1805DCC00
	public XmlDocument get_Document() { }

}

internal struct XmlNodeReaderNavigator.VirtualAttribute // TypeDefIndex: 1975
{	// Fields
	internal string name; // 0x0
	internal string value; // 0x8

	// Methods

	// RVA: 0xF5940 Offset: 0xF4D40 VA: 0x1800F5940
	internal void .ctor(string name, string value) { }

}

public class XmlNodeReader : XmlReader, IXmlNamespaceResolver // TypeDefIndex: 1976
{	// Fields
	private XmlNodeReaderNavigator readerNav; // 0x10
	private XmlNodeType nodeType; // 0x18
	private int curDepth; // 0x1C
	private ReadState readState; // 0x20
	private bool fEOF; // 0x24
	private bool bResolveEntity; // 0x25
	private bool bStartFromDocument; // 0x26
	private bool bInReadBinary; // 0x27
	private ReadContentAsBinaryHelper readBinaryHelper; // 0x28

	// Properties
	public override XmlNodeType NodeType { get; }
	public override string Name { get; }
	public override string LocalName { get; }
	public override string NamespaceURI { get; }
	public override string Prefix { get; }
	public override string Value { get; }
	public override int Depth { get; }
	public override string BaseURI { get; }
	public override bool CanResolveEntity { get; }
	public override bool IsEmptyElement { get; }
	public override bool IsDefault { get; }
	public override XmlSpace XmlSpace { get; }
	public override string XmlLang { get; }
	public override IXmlSchemaInfo SchemaInfo { get; }
	public override int AttributeCount { get; }
	public override bool EOF { get; }
	public override ReadState ReadState { get; }
	public override bool HasAttributes { get; }
	public override XmlNameTable NameTable { get; }
	internal override IDtdInfo DtdInfo { get; }

	// Methods

	// RVA: 0x11CA020 Offset: 0x11C9420 VA: 0x1811CA020
	public void .ctor(XmlNode node) { }

	// RVA: 0x11C9310 Offset: 0x11C8710 VA: 0x1811C9310
	internal bool IsInReadingStates() { }

	// RVA: 0x11CA320 Offset: 0x11C9720 VA: 0x1811CA320 Slot: 6
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x11CA260 Offset: 0x11C9660 VA: 0x1811CA260 Slot: 7
	public override string get_Name() { }

	// RVA: 0x11CA200 Offset: 0x11C9600 VA: 0x1811CA200 Slot: 8
	public override string get_LocalName() { }

	// RVA: 0x11CA2C0 Offset: 0x11C96C0 VA: 0x1811CA2C0 Slot: 9
	public override string get_NamespaceURI() { }

	// RVA: 0x11CA330 Offset: 0x11C9730 VA: 0x1811CA330 Slot: 10
	public override string get_Prefix() { }

	// RVA: 0x11CA3C0 Offset: 0x11C97C0 VA: 0x1811CA3C0 Slot: 11
	public override string get_Value() { }

	// RVA: 0x4BE1F0 Offset: 0x4BD5F0 VA: 0x1804BE1F0 Slot: 12
	public override int get_Depth() { }

	// RVA: 0x11CA140 Offset: 0x11C9540 VA: 0x1811CA140 Slot: 13
	public override string get_BaseURI() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 38
	public override bool get_CanResolveEntity() { }

	// RVA: 0x11CA1D0 Offset: 0x11C95D0 VA: 0x1811CA1D0 Slot: 14
	public override bool get_IsEmptyElement() { }

	// RVA: 0x11CA1A0 Offset: 0x11C95A0 VA: 0x1811CA1A0 Slot: 15
	public override bool get_IsDefault() { }

	// RVA: 0x11CA480 Offset: 0x11C9880 VA: 0x1811CA480 Slot: 17
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0x11CA420 Offset: 0x11C9820 VA: 0x1811CA420 Slot: 18
	public override string get_XmlLang() { }

	// RVA: 0x11CA390 Offset: 0x11C9790 VA: 0x1811CA390 Slot: 19
	public override IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x11CA100 Offset: 0x11C9500 VA: 0x1811CA100 Slot: 21
	public override int get_AttributeCount() { }

	// RVA: 0x11C91C0 Offset: 0x11C85C0 VA: 0x1811C91C0 Slot: 22
	public override string GetAttribute(string name) { }

	// RVA: 0x11C91F0 Offset: 0x11C85F0 VA: 0x1811C91F0 Slot: 23
	public override string GetAttribute(string name, string namespaceURI) { }

	// RVA: 0x11C9280 Offset: 0x11C8680 VA: 0x1811C9280 Slot: 24
	public override string GetAttribute(int attributeIndex) { }

	// RVA: 0x11C9500 Offset: 0x11C8900 VA: 0x1811C9500 Slot: 25
	public override bool MoveToAttribute(string name) { }

	// RVA: 0x11C9360 Offset: 0x11C8760 VA: 0x1811C9360 Slot: 26
	public override void MoveToAttribute(int attributeIndex) { }

	// RVA: 0x11C96A0 Offset: 0x11C8AA0 VA: 0x1811C96A0 Slot: 27
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x11C9780 Offset: 0x11C8B80 VA: 0x1811C9780 Slot: 28
	public override bool MoveToNextAttribute() { }

	// RVA: 0x11C95D0 Offset: 0x11C89D0 VA: 0x1811C95D0 Slot: 29
	public override bool MoveToElement() { }

	// RVA: 0x11C9D40 Offset: 0x11C9140 VA: 0x1811C9D40 Slot: 31
	public override bool Read() { }

	// RVA: 0x11C9D50 Offset: 0x11C9150 VA: 0x1811C9D50
	private bool Read(bool fSkipChildren) { }

	// RVA: 0x11C9A80 Offset: 0x11C8E80 VA: 0x1811C9A80
	private bool ReadNextNode(bool fSkipChildren) { }

	// RVA: 0x11C9F40 Offset: 0x11C9340 VA: 0x1811C9F40
	private void SetEndOfFile() { }

	// RVA: 0x11C9890 Offset: 0x11C8C90 VA: 0x1811C9890
	private bool ReadAtZeroLevel(bool fSkipChildren) { }

	// RVA: 0x11C9950 Offset: 0x11C8D50 VA: 0x1811C9950
	private bool ReadForward(bool fSkipChildren) { }

	// RVA: 0x11C9860 Offset: 0x11C8C60 VA: 0x1811C9860
	private void ReSetReadingMarks() { }

	// RVA: 0x11CA190 Offset: 0x11C9590 VA: 0x1811CA190 Slot: 32
	public override bool get_EOF() { }

	// RVA: 0x11C9180 Offset: 0x11C8580 VA: 0x1811C9180 Slot: 33
	public override void Close() { }

	// RVA: 0x4D0170 Offset: 0x4CF570 VA: 0x1804D0170 Slot: 34
	public override ReadState get_ReadState() { }

	// RVA: 0x11C9F60 Offset: 0x11C9360 VA: 0x1811C9F60 Slot: 35
	public override void Skip() { }

	// RVA: 0x11C9C90 Offset: 0x11C9090 VA: 0x1811C9C90 Slot: 42
	public override string ReadString() { }

	// RVA: 0xB9F930 Offset: 0xB9ED30 VA: 0x180B9F930 Slot: 49
	public override bool get_HasAttributes() { }

	// RVA: 0x524950 Offset: 0x523D50 VA: 0x180524950 Slot: 36
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x11C9320 Offset: 0x11C8720 VA: 0x1811C9320 Slot: 37
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x11C9EB0 Offset: 0x11C92B0 VA: 0x1811C9EB0 Slot: 39
	public override void ResolveEntity() { }

	// RVA: 0x11C9900 Offset: 0x11C8D00 VA: 0x1811C9900 Slot: 30
	public override bool ReadAttributeValue() { }

	// RVA: 0x11C9190 Offset: 0x11C8590 VA: 0x1811C9190
	private void FinishReadBinary() { }

	// RVA: 0x11C9F70 Offset: 0x11C9370 VA: 0x1811C9F70 Slot: 53
	private IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x11CA000 Offset: 0x11C9400 VA: 0x1811CA000 Slot: 55
	private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

	// RVA: 0x11C9F90 Offset: 0x11C9390 VA: 0x1811C9F90 Slot: 54
	private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0x11CA160 Offset: 0x11C9560 VA: 0x1811CA160 Slot: 52
	internal override IDtdInfo get_DtdInfo() { }

}

public class XmlNotation : XmlNode // TypeDefIndex: 1977
{	// Fields
	private string publicId; // 0x18
	private string systemId; // 0x20
	private string name; // 0x28

	// Properties
	public override string Name { get; }
	public override string LocalName { get; }
	public override XmlNodeType NodeType { get; }
	public override bool IsReadOnly { get; }
	public override string InnerXml { set; }

	// Methods

	// RVA: 0xB9AA40 Offset: 0xB99E40 VA: 0x180B9AA40
	internal void .ctor(string name, string publicId, string systemId, XmlDocument doc) { }

	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230 Slot: 6
	public override string get_Name() { }

	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230 Slot: 36
	public override string get_LocalName() { }

	// RVA: 0xB9AAF0 Offset: 0xB99EF0 VA: 0x180B9AAF0 Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0xB9A9D0 Offset: 0xB99DD0 VA: 0x180B9A9D0 Slot: 31
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 37
	public override bool get_IsReadOnly() { }

	// RVA: 0xB9AB00 Offset: 0xB99F00 VA: 0x180B9AB00 Slot: 40
	public override void set_InnerXml(string value) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 43
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 44
	public override void WriteContentTo(XmlWriter w) { }

}

public class XmlProcessingInstruction : XmlLinkedNode // TypeDefIndex: 1978
{	// Fields
	private string target; // 0x20
	private string data; // 0x28

	// Properties
	public override string Name { get; }
	public override string LocalName { get; }
	public override string Value { get; set; }
	public string Data { set; }
	public override string InnerText { get; set; }
	public override XmlNodeType NodeType { get; }

	// Methods

	// RVA: 0xB9B080 Offset: 0xB9A480 VA: 0x180B9B080
	protected internal void .ctor(string target, string data, XmlDocument doc) { }

	// RVA: 0xB9B0D0 Offset: 0xB9A4D0 VA: 0x180B9B0D0 Slot: 6
	public override string get_Name() { }

	// RVA: 0x95B210 Offset: 0x95A610 VA: 0x18095B210 Slot: 36
	public override string get_LocalName() { }

	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230 Slot: 7
	public override string get_Value() { }

	// RVA: 0xB9B200 Offset: 0xB9A600 VA: 0x180B9B200 Slot: 8
	public override void set_Value(string value) { }

	// RVA: 0xB9B130 Offset: 0xB9A530 VA: 0x180B9B130
	public void set_Data(string value) { }

	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230 Slot: 38
	public override string get_InnerText() { }

	// RVA: 0xB9B200 Offset: 0xB9A600 VA: 0x180B9B200 Slot: 39
	public override void set_InnerText(string value) { }

	// RVA: 0xB9B120 Offset: 0xB9A520 VA: 0x180B9B120 Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0xB9AFF0 Offset: 0xB9A3F0 VA: 0x180B9AFF0 Slot: 31
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0xB9B040 Offset: 0xB9A440 VA: 0x180B9B040 Slot: 43
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 44
	public override void WriteContentTo(XmlWriter w) { }

}

public class XmlSignificantWhitespace : XmlCharacterData // TypeDefIndex: 1979
{	// Properties
	public override string Name { get; }
	public override string LocalName { get; }
	public override XmlNodeType NodeType { get; }
	public override XmlNode ParentNode { get; }
	public override string Value { get; set; }
	internal override bool IsText { get; }

	// Methods

	// RVA: 0xBA0580 Offset: 0xB9F980 VA: 0x180BA0580
	protected internal void .ctor(string strData, XmlDocument doc) { }

	// RVA: 0xBA0640 Offset: 0xB9FA40 VA: 0x180BA0640 Slot: 6
	public override string get_Name() { }

	// RVA: 0xBA0640 Offset: 0xB9FA40 VA: 0x180BA0640 Slot: 36
	public override string get_LocalName() { }

	// RVA: 0xBA0670 Offset: 0xB9FA70 VA: 0x180BA0670 Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0xBA0680 Offset: 0xB9FA80 VA: 0x180BA0680 Slot: 10
	public override XmlNode get_ParentNode() { }

	// RVA: 0xBA04E0 Offset: 0xB9F8E0 VA: 0x180BA04E0 Slot: 31
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0xBA0720 Offset: 0xB9FB20 VA: 0x180BA0720 Slot: 7
	public override string get_Value() { }

	// RVA: 0xBA0740 Offset: 0xB9FB40 VA: 0x180BA0740 Slot: 8
	public override void set_Value(string value) { }

	// RVA: 0xBA0540 Offset: 0xB9F940 VA: 0x180BA0540 Slot: 43
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 44
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 55
	internal override bool get_IsText() { }

}

public class XmlText : XmlCharacterData // TypeDefIndex: 1980
{	// Properties
	public override string Name { get; }
	public override string LocalName { get; }
	public override XmlNodeType NodeType { get; }
	public override XmlNode ParentNode { get; }
	public override string Value { get; set; }
	internal override bool IsText { get; }

	// Methods

	// RVA: 0xBC4860 Offset: 0xBC3C60 VA: 0x180BC4860
	internal void .ctor(string strData) { }

	// RVA: 0xBC4850 Offset: 0xBC3C50 VA: 0x180BC4850
	protected internal void .ctor(string strData, XmlDocument doc) { }

	// RVA: 0xBC4870 Offset: 0xBC3C70 VA: 0x180BC4870 Slot: 6
	public override string get_Name() { }

	// RVA: 0xBC4870 Offset: 0xBC3C70 VA: 0x180BC4870 Slot: 36
	public override string get_LocalName() { }

	// RVA: 0xABD0E0 Offset: 0xABC4E0 VA: 0x180ABD0E0 Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0xBC48A0 Offset: 0xBC3CA0 VA: 0x180BC48A0 Slot: 10
	public override XmlNode get_ParentNode() { }

	// RVA: 0xBC47F0 Offset: 0xBC3BF0 VA: 0x180BC47F0 Slot: 31
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0xBA0720 Offset: 0xB9FB20 VA: 0x180BA0720 Slot: 7
	public override string get_Value() { }

	// RVA: 0xBC4940 Offset: 0xBC3D40 VA: 0x180BC4940 Slot: 8
	public override void set_Value(string value) { }

	// RVA: 0xBA0540 Offset: 0xB9F940 VA: 0x180BA0540 Slot: 43
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 44
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 55
	internal override bool get_IsText() { }

}

internal class XmlUnspecifiedAttribute : XmlAttribute // TypeDefIndex: 1981
{	// Fields
	private bool fSpecified; // 0x28

	// Properties
	public override bool Specified { get; }
	public override string InnerText { set; }

	// Methods

	// RVA: 0x131A060 Offset: 0x1319460 VA: 0x18131A060
	protected internal void .ctor(string prefix, string localName, string namespaceURI, XmlDocument doc) { }

	// RVA: 0x9775C0 Offset: 0x9769C0 VA: 0x1809775C0 Slot: 56
	public override bool get_Specified() { }

	// RVA: 0x1319EA0 Offset: 0x13192A0 VA: 0x181319EA0 Slot: 31
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x131A070 Offset: 0x1319470 VA: 0x18131A070 Slot: 39
	public override void set_InnerText(string value) { }

	// RVA: 0x131A010 Offset: 0x1319410 VA: 0x18131A010 Slot: 21
	public override XmlNode InsertBefore(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x1319FF0 Offset: 0x13193F0 VA: 0x181319FF0 Slot: 22
	public override XmlNode InsertAfter(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x131A030 Offset: 0x1319430 VA: 0x18131A030 Slot: 23
	public override XmlNode RemoveChild(XmlNode oldChild) { }

	// RVA: 0x1319E80 Offset: 0x1319280 VA: 0x181319E80 Slot: 25
	public override XmlNode AppendChild(XmlNode newChild) { }

	// RVA: 0x131A050 Offset: 0x1319450 VA: 0x18131A050 Slot: 43
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x9775D0 Offset: 0x9769D0 VA: 0x1809775D0
	internal void SetSpecified(bool f) { }

}

public class XmlWhitespace : XmlCharacterData // TypeDefIndex: 1982
{	// Properties
	public override string Name { get; }
	public override string LocalName { get; }
	public override XmlNodeType NodeType { get; }
	public override XmlNode ParentNode { get; }
	public override string Value { get; set; }
	internal override bool IsText { get; }

	// Methods

	// RVA: 0x1326E10 Offset: 0x1326210 VA: 0x181326E10
	protected internal void .ctor(string strData, XmlDocument doc) { }

	// RVA: 0x1326ED0 Offset: 0x13262D0 VA: 0x181326ED0 Slot: 6
	public override string get_Name() { }

	// RVA: 0x1326ED0 Offset: 0x13262D0 VA: 0x181326ED0 Slot: 36
	public override string get_LocalName() { }

	// RVA: 0x1326F00 Offset: 0x1326300 VA: 0x181326F00 Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0xBA0680 Offset: 0xB9FA80 VA: 0x180BA0680 Slot: 10
	public override XmlNode get_ParentNode() { }

	// RVA: 0xBA0720 Offset: 0xB9FB20 VA: 0x180BA0720 Slot: 7
	public override string get_Value() { }

	// RVA: 0x1326F10 Offset: 0x1326310 VA: 0x181326F10 Slot: 8
	public override void set_Value(string value) { }

	// RVA: 0x1326D70 Offset: 0x1326170 VA: 0x181326D70 Slot: 31
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x1326DD0 Offset: 0x13261D0 VA: 0x181326DD0 Slot: 43
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 44
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 55
	internal override bool get_IsText() { }

}

public enum XmlTokenizedType // TypeDefIndex: 1999
{	// Fields
	public int value__; // 0x0
	public const XmlTokenizedType CDATA = 0;
	public const XmlTokenizedType ID = 1;
	public const XmlTokenizedType IDREF = 2;
	public const XmlTokenizedType IDREFS = 3;
	public const XmlTokenizedType ENTITY = 4;
	public const XmlTokenizedType ENTITIES = 5;
	public const XmlTokenizedType NMTOKEN = 6;
	public const XmlTokenizedType NMTOKENS = 7;
	public const XmlTokenizedType NOTATION = 8;
	public const XmlTokenizedType ENUMERATION = 9;
	public const XmlTokenizedType QName = 10;
	public const XmlTokenizedType NCName = 11;
	public const XmlTokenizedType None = 12;

}

internal struct XmlCharType // TypeDefIndex: 2001
{	// Fields
	private static object s_Lock; // 0x0
	private static byte[] s_CharProperties; // 0x8
	internal byte[] charProperties; // 0x0

	// Properties
	private static object StaticLock { get; }
	public static XmlCharType Instance { get; }

	// Methods

	// RVA: 0xE53CB0 Offset: 0xE530B0 VA: 0x180E53CB0
	private static object get_StaticLock() { }

	// RVA: 0xE533D0 Offset: 0xE527D0 VA: 0x180E533D0
	private static void InitInstance() { }

	// RVA: 0xE53B00 Offset: 0xE52F00 VA: 0x180E53B00
	private static void SetProperties(string ranges, byte value) { }

	// RVA: 0xF1380 Offset: 0xF0780 VA: 0x1800F1380
	private void .ctor(byte[] charProperties) { }

	// RVA: 0xE53C30 Offset: 0xE53030 VA: 0x180E53C30
	public static XmlCharType get_Instance() { }

	// RVA: 0x12C630 Offset: 0x12BA30 VA: 0x18012C630
	public bool IsWhiteSpace(char ch) { }

	// RVA: 0x12C210 Offset: 0x12B610 VA: 0x18012C210
	public bool IsNCNameSingleChar(char ch) { }

	// RVA: 0x12C5B0 Offset: 0x12B9B0 VA: 0x18012C5B0
	public bool IsStartNCNameSingleChar(char ch) { }

	// RVA: 0x12C2A0 Offset: 0x12B6A0 VA: 0x18012C2A0
	public bool IsNameSingleChar(char ch) { }

	// RVA: 0x12C150 Offset: 0x12B550 VA: 0x18012C150
	public bool IsCharData(char ch) { }

	// RVA: 0x12C4E0 Offset: 0x12B8E0 VA: 0x18012C4E0
	public bool IsPubidChar(char ch) { }

	// RVA: 0x12C5F0 Offset: 0x12B9F0 VA: 0x18012C5F0
	internal bool IsTextChar(char ch) { }

	// RVA: 0x12C190 Offset: 0x12B590 VA: 0x18012C190
	public bool IsLetter(char ch) { }

	// RVA: 0x12C1D0 Offset: 0x12B5D0 VA: 0x18012C1D0
	public bool IsNCNameCharXml4e(char ch) { }

	// RVA: 0x12C560 Offset: 0x12B960 VA: 0x18012C560
	public bool IsStartNCNameCharXml4e(char ch) { }

	// RVA: 0x12C250 Offset: 0x12B650 VA: 0x18012C250
	public bool IsNameCharXml4e(char ch) { }

	// RVA: 0xE53630 Offset: 0xE52A30 VA: 0x180E53630
	public static bool IsDigit(char ch) { }

	// RVA: 0xE53640 Offset: 0xE52A40 VA: 0x180E53640
	internal static bool IsHighSurrogate(int ch) { }

	// RVA: 0xE53650 Offset: 0xE52A50 VA: 0x180E53650
	internal static bool IsLowSurrogate(int ch) { }

	// RVA: 0xE53A70 Offset: 0xE52E70 VA: 0x180E53A70
	internal static bool IsSurrogate(int ch) { }

	// RVA: 0xE533A0 Offset: 0xE527A0 VA: 0x180E533A0
	internal static int CombineSurrogateChar(int lowChar, int highChar) { }

	// RVA: 0xE53BF0 Offset: 0xE52FF0 VA: 0x180E53BF0
	internal static void SplitSurrogateChar(int combinedChar, out char lowChar, out char highChar) { }

	// RVA: 0x12C450 Offset: 0x12B850 VA: 0x18012C450
	internal bool IsOnlyWhitespace(string str) { }

	// RVA: 0x12C3C0 Offset: 0x12B7C0 VA: 0x18012C3C0
	internal int IsOnlyWhitespaceWithPos(string str) { }

	// RVA: 0x12C2F0 Offset: 0x12B6F0 VA: 0x18012C2F0
	internal int IsOnlyCharData(string str) { }

	// RVA: 0xE53850 Offset: 0xE52C50 VA: 0x180E53850
	internal static bool IsOnlyDigits(string str, int startPos, int len) { }

	// RVA: 0x12C4F0 Offset: 0x12B8F0 VA: 0x18012C4F0
	internal int IsPublicId(string str) { }

	// RVA: 0xE533C0 Offset: 0xE527C0 VA: 0x180E533C0
	private static bool InRange(int value, int start, int end) { }

}

internal static class XmlComplianceUtil // TypeDefIndex: 2002
{	// Methods

	// RVA: 0xE54540 Offset: 0xE53940 VA: 0x180E54540
	public static string NonCDataNormalize(string value) { }

	// RVA: 0xE54390 Offset: 0xE53790 VA: 0x180E54390
	public static string CDataNormalize(string value) { }

}

public enum XmlDateTimeSerializationMode // TypeDefIndex: 2004
{	// Fields
	public int value__; // 0x0
	public const XmlDateTimeSerializationMode Local = 0;
	public const XmlDateTimeSerializationMode Utc = 1;
	public const XmlDateTimeSerializationMode Unspecified = 2;
	public const XmlDateTimeSerializationMode RoundtripKind = 3;

}

public class XmlConvert // TypeDefIndex: 2005
{	// Fields
	private static XmlCharType xmlCharType; // 0x0
	internal static char[] crt; // 0x8
	private static readonly int c_EncodedCharLength; // 0x10
	private static Regex c_EncodeCharPattern; // 0x18
	private static Regex c_DecodeCharPattern; // 0x20
	private static string[] s_allDateTimeFormats; // 0x28
	internal static readonly char[] WhitespaceChars; // 0x30

	// Properties
	private static string[] AllDateTimeFormats { get; }

	// Methods

	// RVA: 0xE56A40 Offset: 0xE55E40 VA: 0x180E56A40
	public static string EncodeName(string name) { }

	// RVA: 0xE569E0 Offset: 0xE55DE0 VA: 0x180E569E0
	public static string EncodeLocalName(string name) { }

	// RVA: 0xE56110 Offset: 0xE55510 VA: 0x180E56110
	public static string DecodeName(string name) { }

	// RVA: 0xE56AA0 Offset: 0xE55EA0 VA: 0x180E56AA0
	private static string EncodeName(string name, bool first, bool local) { }

	// RVA: 0xE574F0 Offset: 0xE568F0 VA: 0x180E574F0
	private static int FromHex(char digit) { }

	// RVA: 0xE573B0 Offset: 0xE567B0 VA: 0x180E573B0
	internal static byte[] FromBinHexString(string s) { }

	// RVA: 0xE57460 Offset: 0xE56860 VA: 0x180E57460
	internal static byte[] FromBinHexString(string s, bool allowOddCount) { }

	// RVA: 0xE577B0 Offset: 0xE56BB0 VA: 0x180E577B0
	internal static string ToBinHexString(byte[] inArray) { }

	// RVA: 0xE5BE90 Offset: 0xE5B290 VA: 0x180E5BE90
	public static string VerifyName(string name) { }

	// RVA: 0xE5B690 Offset: 0xE5AA90 VA: 0x180E5B690
	internal static Exception TryVerifyName(string name) { }

	// RVA: 0xE5BFC0 Offset: 0xE5B3C0 VA: 0x180E5BFC0
	internal static string VerifyQName(string name, ExceptionType exceptionType) { }

	// RVA: 0xE5BD20 Offset: 0xE5B120 VA: 0x180E5BD20
	public static string VerifyNCName(string name) { }

	// RVA: 0xE5BBE0 Offset: 0xE5AFE0 VA: 0x180E5BBE0
	internal static string VerifyNCName(string name, ExceptionType exceptionType) { }

	// RVA: 0xE5B3D0 Offset: 0xE5A7D0 VA: 0x180E5B3D0
	internal static Exception TryVerifyNCName(string name) { }

	// RVA: 0xE5C180 Offset: 0xE5B580 VA: 0x180E5C180
	public static string VerifyTOKEN(string token) { }

	// RVA: 0xE5B870 Offset: 0xE5AC70 VA: 0x180E5B870
	internal static Exception TryVerifyTOKEN(string token) { }

	// RVA: 0xE5B4C0 Offset: 0xE5A8C0 VA: 0x180E5B4C0
	internal static Exception TryVerifyNMTOKEN(string name) { }

	// RVA: 0xE5B7B0 Offset: 0xE5ABB0 VA: 0x180E5B7B0
	internal static Exception TryVerifyNormalizedString(string str) { }

	// RVA: 0xE58AC0 Offset: 0xE57EC0 VA: 0x180E58AC0
	public static string ToString(bool value) { }

	// RVA: 0xE58590 Offset: 0xE57990 VA: 0x180E58590
	public static string ToString(char value) { }

	// RVA: 0xE58B90 Offset: 0xE57F90 VA: 0x180E58B90
	public static string ToString(Decimal value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0xE58C30 Offset: 0xE58030 VA: 0x180E58C30
	public static string ToString(sbyte value) { }

	// RVA: 0xE58BC0 Offset: 0xE57FC0 VA: 0x180E58BC0
	public static string ToString(short value) { }

	// RVA: 0xE58990 Offset: 0xE57D90 VA: 0x180E58990
	public static string ToString(int value) { }

	// RVA: 0xE58B00 Offset: 0xE57F00 VA: 0x180E58B00
	public static string ToString(long value) { }

	// RVA: 0xE58960 Offset: 0xE57D60 VA: 0x180E58960
	public static string ToString(byte value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0xE58920 Offset: 0xE57D20 VA: 0x180E58920
	public static string ToString(ushort value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0xE589C0 Offset: 0xE57DC0 VA: 0x180E589C0
	public static string ToString(uint value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0xE58560 Offset: 0xE57960 VA: 0x180E58560
	public static string ToString(ulong value) { }

	// RVA: 0xE589F0 Offset: 0xE57DF0 VA: 0x180E589F0
	public static string ToString(float value) { }

	// RVA: 0xE58620 Offset: 0xE57A20 VA: 0x180E58620
	public static string ToString(double value) { }

	// RVA: 0xE58B30 Offset: 0xE57F30 VA: 0x180E58B30
	public static string ToString(TimeSpan value) { }

	// RVA: 0xE585B0 Offset: 0xE579B0 VA: 0x180E585B0
	public static string ToString(DateTime value, string format) { }

	// RVA: 0xE58750 Offset: 0xE57B50 VA: 0x180E58750
	public static string ToString(DateTime value, XmlDateTimeSerializationMode dateTimeOption) { }

	// RVA: 0xE58BF0 Offset: 0xE57FF0 VA: 0x180E58BF0
	public static string ToString(DateTimeOffset value) { }

	// RVA: 0xE58950 Offset: 0xE57D50 VA: 0x180E58950
	public static string ToString(Guid value) { }

	// RVA: 0xE57820 Offset: 0xE56C20 VA: 0x180E57820
	public static bool ToBoolean(string s) { }

	// RVA: 0xE59490 Offset: 0xE58890 VA: 0x180E59490
	internal static Exception TryToBoolean(string s, out bool result) { }

	// RVA: 0xE57A20 Offset: 0xE56E20 VA: 0x180E57A20
	public static char ToChar(string s) { }

	// RVA: 0xE59870 Offset: 0xE58C70 VA: 0x180E59870
	internal static Exception TryToChar(string s, out char result) { }

	// RVA: 0xE58010 Offset: 0xE57410 VA: 0x180E58010
	public static Decimal ToDecimal(string s) { }

	// RVA: 0xE59A00 Offset: 0xE58E00 VA: 0x180E59A00
	internal static Exception TryToDecimal(string s, out Decimal result) { }

	// RVA: 0xE58310 Offset: 0xE57710 VA: 0x180E58310
	internal static Decimal ToInteger(string s) { }

	// RVA: 0xE5A5B0 Offset: 0xE599B0 VA: 0x180E5A5B0
	internal static Exception TryToInteger(string s, out Decimal result) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0xE583A0 Offset: 0xE577A0 VA: 0x180E583A0
	public static sbyte ToSByte(string s) { }

	// RVA: 0xE5A760 Offset: 0xE59B60 VA: 0x180E5A760
	internal static Exception TryToSByte(string s, out sbyte result) { }

	// RVA: 0xE58280 Offset: 0xE57680 VA: 0x180E58280
	public static short ToInt16(string s) { }

	// RVA: 0xE5A130 Offset: 0xE59530 VA: 0x180E5A130
	internal static Exception TryToInt16(string s, out short result) { }

	// RVA: 0xE582B0 Offset: 0xE576B0 VA: 0x180E582B0
	public static int ToInt32(string s) { }

	// RVA: 0xE5A2B0 Offset: 0xE596B0 VA: 0x180E5A2B0
	internal static Exception TryToInt32(string s, out int result) { }

	// RVA: 0xE582E0 Offset: 0xE576E0 VA: 0x180E582E0
	public static long ToInt64(string s) { }

	// RVA: 0xE5A430 Offset: 0xE59830 VA: 0x180E5A430
	internal static Exception TryToInt64(string s, out long result) { }

	// RVA: 0xE579F0 Offset: 0xE56DF0 VA: 0x180E579F0
	public static byte ToByte(string s) { }

	// RVA: 0xE596F0 Offset: 0xE58AF0 VA: 0x180E596F0
	internal static Exception TryToByte(string s, out byte result) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0xE58DA0 Offset: 0xE581A0 VA: 0x180E58DA0
	public static ushort ToUInt16(string s) { }

	// RVA: 0xE5AC30 Offset: 0xE5A030 VA: 0x180E5AC30
	internal static Exception TryToUInt16(string s, out ushort result) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0xE58DD0 Offset: 0xE581D0 VA: 0x180E58DD0
	public static uint ToUInt32(string s) { }

	// RVA: 0xE5ADB0 Offset: 0xE5A1B0 VA: 0x180E5ADB0
	internal static Exception TryToUInt32(string s, out uint result) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0xE58E00 Offset: 0xE58200 VA: 0x180E58E00
	public static ulong ToUInt64(string s) { }

	// RVA: 0xE5AF30 Offset: 0xE5A330 VA: 0x180E5AF30
	internal static Exception TryToUInt64(string s, out ulong result) { }

	// RVA: 0xE583D0 Offset: 0xE577D0 VA: 0x180E583D0
	public static float ToSingle(string s) { }

	// RVA: 0xE5A8E0 Offset: 0xE59CE0 VA: 0x180E5A8E0
	internal static Exception TryToSingle(string s, out float result) { }

	// RVA: 0xE580A0 Offset: 0xE574A0 VA: 0x180E580A0
	public static double ToDouble(string s) { }

	// RVA: 0xE59BB0 Offset: 0xE58FB0 VA: 0x180E59BB0
	internal static Exception TryToDouble(string s, out double result) { }

	// RVA: 0xE590C0 Offset: 0xE584C0 VA: 0x180E590C0
	internal static double ToXPathDouble(object o) { }

	// RVA: 0xE58C60 Offset: 0xE58060 VA: 0x180E58C60
	public static TimeSpan ToTimeSpan(string s) { }

	// RVA: 0xE5AB70 Offset: 0xE59F70 VA: 0x180E5AB70
	internal static Exception TryToTimeSpan(string s, out TimeSpan result) { }

	// RVA: 0xE5C370 Offset: 0xE5B770 VA: 0x180E5C370
	private static string[] get_AllDateTimeFormats() { }

	// RVA: 0xE54830 Offset: 0xE53C30 VA: 0x180E54830
	private static void CreateAllDateTimeFormats() { }

	[ObsoleteAttribute] // RVA: 0x83AD0 Offset: 0x82ED0 VA: 0x180083AD0
	// RVA: 0xE57DC0 Offset: 0xE571C0 VA: 0x180E57DC0
	public static DateTime ToDateTime(string s) { }

	// RVA: 0xE57F60 Offset: 0xE57360 VA: 0x180E57F60
	public static DateTime ToDateTime(string s, string[] formats) { }

	// RVA: 0xE57BB0 Offset: 0xE56FB0 VA: 0x180E57BB0
	public static DateTime ToDateTime(string s, XmlDateTimeSerializationMode dateTimeOption) { }

	// RVA: 0xE57AE0 Offset: 0xE56EE0 VA: 0x180E57AE0
	public static DateTimeOffset ToDateTimeOffset(string s) { }

	// RVA: 0xE58260 Offset: 0xE57660 VA: 0x180E58260
	public static Guid ToGuid(string s) { }

	// RVA: 0xE59E90 Offset: 0xE59290 VA: 0x180E59E90
	internal static Exception TryToGuid(string s, out Guid result) { }

	// RVA: 0xE576C0 Offset: 0xE56AC0 VA: 0x180E576C0
	private static DateTime SwitchToLocalTime(DateTime value) { }

	// RVA: 0xE57730 Offset: 0xE56B30 VA: 0x180E57730
	private static DateTime SwitchToUtcTime(DateTime value) { }

	// RVA: 0xE58E30 Offset: 0xE58230 VA: 0x180E58E30
	internal static Uri ToUri(string s) { }

	// RVA: 0xE5B0B0 Offset: 0xE5A4B0 VA: 0x180E5B0B0
	internal static Exception TryToUri(string s, out Uri result) { }

	// RVA: 0xE57620 Offset: 0xE56A20 VA: 0x180E57620
	internal static bool StrEqual(char[] chars, int strPos1, int strLen1, string str2) { }

	// RVA: 0xE59410 Offset: 0xE58810 VA: 0x180E59410
	internal static string TrimString(string value) { }

	// RVA: 0xE59390 Offset: 0xE58790 VA: 0x180E59390
	internal static string TrimStringStart(string value) { }

	// RVA: 0xE59310 Offset: 0xE58710 VA: 0x180E59310
	internal static string TrimStringEnd(string value) { }

	// RVA: 0xE575A0 Offset: 0xE569A0 VA: 0x180E575A0
	internal static string[] SplitString(string value) { }

	// RVA: 0xE57520 Offset: 0xE56920 VA: 0x180E57520
	internal static bool IsNegativeZero(double value) { }

	// RVA: 0xE569D0 Offset: 0xE55DD0 VA: 0x180E569D0
	private static long DoubleToInt64Bits(double value) { }

	// RVA: 0xE5B970 Offset: 0xE5AD70 VA: 0x180E5B970
	internal static void VerifyCharData(string data, ExceptionType invCharExceptionType, ExceptionType invSurrogateExceptionType) { }

	// RVA: 0xE55290 Offset: 0xE54690 VA: 0x180E55290
	internal static Exception CreateException(string res, ExceptionType exceptionType, int lineNo, int linePos) { }

	// RVA: 0xE55360 Offset: 0xE54760 VA: 0x180E55360
	internal static Exception CreateException(string res, string arg, ExceptionType exceptionType, int lineNo, int linePos) { }

	// RVA: 0xE55560 Offset: 0xE54960 VA: 0x180E55560
	internal static Exception CreateException(string res, string[] args, ExceptionType exceptionType) { }

	// RVA: 0xE554A0 Offset: 0xE548A0 VA: 0x180E554A0
	internal static Exception CreateException(string res, string[] args, ExceptionType exceptionType, int lineNo, int linePos) { }

	// RVA: 0xE55E10 Offset: 0xE55210 VA: 0x180E55E10
	internal static Exception CreateInvalidSurrogatePairException(char low, char hi) { }

	// RVA: 0xE55EC0 Offset: 0xE552C0 VA: 0x180E55EC0
	internal static Exception CreateInvalidSurrogatePairException(char low, char hi, ExceptionType exceptionType) { }

	// RVA: 0xE55F40 Offset: 0xE55340 VA: 0x180E55F40
	internal static Exception CreateInvalidSurrogatePairException(char low, char hi, ExceptionType exceptionType, int lineNo, int linePos) { }

	// RVA: 0xE55A90 Offset: 0xE54E90 VA: 0x180E55A90
	internal static Exception CreateInvalidHighSurrogateCharException(char hi) { }

	// RVA: 0xE558A0 Offset: 0xE54CA0 VA: 0x180E558A0
	internal static Exception CreateInvalidHighSurrogateCharException(char hi, ExceptionType exceptionType) { }

	// RVA: 0xE55AF0 Offset: 0xE54EF0 VA: 0x180E55AF0
	internal static Exception CreateInvalidHighSurrogateCharException(char hi, ExceptionType exceptionType, int lineNo, int linePos) { }

	// RVA: 0xE55800 Offset: 0xE54C00 VA: 0x180E55800
	internal static Exception CreateInvalidCharException(string data, int invCharPos, ExceptionType exceptionType) { }

	// RVA: 0xE555E0 Offset: 0xE549E0 VA: 0x180E555E0
	internal static Exception CreateInvalidCharException(char invChar, char nextChar) { }

	// RVA: 0xE55720 Offset: 0xE54B20 VA: 0x180E55720
	internal static Exception CreateInvalidCharException(char invChar, char nextChar, ExceptionType exceptionType) { }

	// RVA: 0xE55D60 Offset: 0xE55160 VA: 0x180E55D60
	internal static Exception CreateInvalidNameCharException(string name, int index, ExceptionType exceptionType) { }

	// RVA: 0xE55CB0 Offset: 0xE550B0 VA: 0x180E55CB0
	internal static ArgumentException CreateInvalidNameArgumentException(string name, string argumentName) { }

	// RVA: 0xE5C290 Offset: 0xE5B690 VA: 0x180E5C290
	private static void .cctor() { }

}

internal class XmlDownloadManager // TypeDefIndex: 2006
{	// Fields
	private Hashtable connections; // 0x10

	// Methods

	// RVA: 0x11B6630 Offset: 0x11B5A30 VA: 0x1811B6630
	internal Stream GetStream(Uri uri, ICredentials credentials, IWebProxy proxy, RequestCachePolicy cachePolicy) { }

	// RVA: 0x11B5F80 Offset: 0x11B5380 VA: 0x1811B5F80
	private Stream GetNonFileStream(Uri uri, ICredentials credentials, IWebProxy proxy, RequestCachePolicy cachePolicy) { }

	// RVA: 0x11B6730 Offset: 0x11B5B30 VA: 0x1811B6730
	internal void Remove(string host) { }

	// RVA: 0x11B63E0 Offset: 0x11B57E0 VA: 0x1811B63E0
	internal Task<Stream> GetStreamAsync(Uri uri, ICredentials credentials, IWebProxy proxy, RequestCachePolicy cachePolicy) { }

	[AsyncStateMachineAttribute] // RVA: 0x83BC0 Offset: 0x82FC0 VA: 0x180083BC0
	// RVA: 0x11B5E20 Offset: 0x11B5220 VA: 0x1811B5E20
	private Task<Stream> GetNonFileStreamAsync(Uri uri, ICredentials credentials, IWebProxy proxy, RequestCachePolicy cachePolicy) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

private sealed class XmlDownloadManager.<>c__DisplayClass4_0 // TypeDefIndex: 2007
{	// Fields
	public Uri uri; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x11B5350 Offset: 0x11B4750 VA: 0x1811B5350
	internal Stream <GetStreamAsync>b__0() { }

}

private struct XmlDownloadManager.<GetNonFileStreamAsync>d__5 : IAsyncStateMachine // TypeDefIndex: 2008
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<Stream> <>t__builder; // 0x8
	public Uri uri; // 0x20
	public ICredentials credentials; // 0x28
	public IWebProxy proxy; // 0x30
	public RequestCachePolicy cachePolicy; // 0x38
	private WebRequest <req>5__1; // 0x40
	public XmlDownloadManager <>4__this; // 0x48
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<WebResponse> <>u__1; // 0x50

	// Methods

	// RVA: 0x1D0BA0 Offset: 0x1CFFA0 VA: 0x1801D0BA0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1D0BB0 Offset: 0x1CFFB0 VA: 0x1801D0BB0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

internal class XmlRegisteredNonCachedStream : Stream // TypeDefIndex: 2010
{	// Fields
	protected Stream stream; // 0x28
	private XmlDownloadManager downloadManager; // 0x30
	private string host; // 0x38

	// Properties
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0xB9FFC0 Offset: 0xB9F3C0 VA: 0x180B9FFC0
	internal void .ctor(Stream stream, XmlDownloadManager downloadManager, string host) { }

	// RVA: 0xB9FDC0 Offset: 0xB9F1C0 VA: 0x180B9FDC0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0xB9FC20 Offset: 0xB9F020 VA: 0x180B9FC20 Slot: 17
	protected override void Dispose(bool disposing) { }

	// RVA: 0xB9FBC0 Offset: 0xB9EFC0 VA: 0x180B9FBC0 Slot: 19
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0xB9FBF0 Offset: 0xB9EFF0 VA: 0x180B9FBF0 Slot: 22
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0xB9FD60 Offset: 0xB9F160 VA: 0x180B9FD60 Slot: 20
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0xB9FD90 Offset: 0xB9F190 VA: 0x180B9FD90 Slot: 23
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0xB9FE70 Offset: 0xB9F270 VA: 0x180B9FE70 Slot: 18
	public override void Flush() { }

	// RVA: 0xB9FED0 Offset: 0xB9F2D0 VA: 0x180B9FED0 Slot: 27
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0xB9FEA0 Offset: 0xB9F2A0 VA: 0x180B9FEA0 Slot: 28
	public override int ReadByte() { }

	// RVA: 0xB9FF00 Offset: 0xB9F300 VA: 0x180B9FF00 Slot: 25
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0xB9FF30 Offset: 0xB9F330 VA: 0x180B9FF30 Slot: 26
	public override void SetLength(long value) { }

	// RVA: 0xB9FF90 Offset: 0xB9F390 VA: 0x180B9FF90 Slot: 29
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0xB9FF60 Offset: 0xB9F360 VA: 0x180B9FF60 Slot: 30
	public override void WriteByte(byte value) { }

	// RVA: 0xBA0070 Offset: 0xB9F470 VA: 0x180BA0070 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0xBA00A0 Offset: 0xB9F4A0 VA: 0x180BA00A0 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0xBA00D0 Offset: 0xB9F4D0 VA: 0x180BA00D0 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0xBA0100 Offset: 0xB9F500 VA: 0x180BA0100 Slot: 10
	public override long get_Length() { }

	// RVA: 0xBA0130 Offset: 0xB9F530 VA: 0x180BA0130 Slot: 11
	public override long get_Position() { }

	// RVA: 0xBA0160 Offset: 0xB9F560 VA: 0x180BA0160 Slot: 12
	public override void set_Position(long value) { }

}

internal class XmlCachedStream : MemoryStream // TypeDefIndex: 2011
{	// Fields
	private Uri uri; // 0x50

	// Methods

	// RVA: 0xE53240 Offset: 0xE52640 VA: 0x180E53240
	internal void .ctor(Uri uri, Stream stream) { }

}

public class XmlException : SystemException // TypeDefIndex: 2024
{	// Fields
	private string res; // 0x88
	private string[] args; // 0x90
	private int lineNumber; // 0x98
	private int linePosition; // 0x9C
	[OptionalFieldAttribute] // RVA: 0x7B530 Offset: 0x7A930 VA: 0x18007B530
	private string sourceUri; // 0xA0
	private string message; // 0xA8

	// Properties
	public int LineNumber { get; }
	public int LinePosition { get; }
	public override string Message { get; }
	internal string ResString { get; }

	// Methods

	// RVA: 0x11C1240 Offset: 0x11C0640 VA: 0x1811C1240
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x11C0690 Offset: 0x11BFA90 VA: 0x1811C0690 Slot: 10
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x11C0D40 Offset: 0x11C0140 VA: 0x1811C0D40
	public void .ctor() { }

	// RVA: 0x11C0E50 Offset: 0x11C0250 VA: 0x1811C0E50
	public void .ctor(string message) { }

	// RVA: 0x11C1720 Offset: 0x11C0B20 VA: 0x1811C1720
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x11C1210 Offset: 0x11C0610 VA: 0x1811C1210
	public void .ctor(string message, Exception innerException, int lineNumber, int linePosition) { }

	// RVA: 0x11C0A30 Offset: 0x11BFE30 VA: 0x1811C0A30
	internal void .ctor(string message, Exception innerException, int lineNumber, int linePosition, string sourceUri) { }

	// RVA: 0x11C1050 Offset: 0x11C0450 VA: 0x1811C1050
	internal void .ctor(string res, string[] args) { }

	// RVA: 0x11C1600 Offset: 0x11C0A00 VA: 0x1811C1600
	internal void .ctor(string res, string arg) { }

	// RVA: 0x11C07A0 Offset: 0x11BFBA0 VA: 0x1811C07A0
	internal void .ctor(string res, string arg, string sourceUri) { }

	// RVA: 0x11C1080 Offset: 0x11C0480 VA: 0x1811C1080
	internal void .ctor(string res, string arg, IXmlLineInfo lineInfo) { }

	// RVA: 0x11C0960 Offset: 0x11BFD60 VA: 0x1811C0960
	internal void .ctor(string res, string[] args, IXmlLineInfo lineInfo) { }

	// RVA: 0x11C0890 Offset: 0x11BFC90 VA: 0x1811C0890
	internal void .ctor(string res, string[] args, IXmlLineInfo lineInfo, string sourceUri) { }

	// RVA: 0x11C0C40 Offset: 0x11C0040 VA: 0x1811C0C40
	internal void .ctor(string res, string arg, int lineNumber, int linePosition) { }

	// RVA: 0x11C0F50 Offset: 0x11C0350 VA: 0x1811C0F50
	internal void .ctor(string res, string arg, int lineNumber, int linePosition, string sourceUri) { }

	// RVA: 0x11C1750 Offset: 0x11C0B50 VA: 0x1811C1750
	internal void .ctor(string res, string[] args, int lineNumber, int linePosition) { }

	// RVA: 0x11C16E0 Offset: 0x11C0AE0 VA: 0x1811C16E0
	internal void .ctor(string res, string[] args, int lineNumber, int linePosition, string sourceUri) { }

	// RVA: 0x11C11E0 Offset: 0x11C05E0 VA: 0x1811C11E0
	internal void .ctor(string res, string[] args, Exception innerException, int lineNumber, int linePosition) { }

	// RVA: 0x11C0E80 Offset: 0x11C0280 VA: 0x1811C0E80
	internal void .ctor(string res, string[] args, Exception innerException, int lineNumber, int linePosition, string sourceUri) { }

	// RVA: 0x11C0560 Offset: 0x11BF960 VA: 0x1811C0560
	private static string FormatUserMessage(string message, int lineNumber, int linePosition) { }

	// RVA: 0x11C0340 Offset: 0x11BF740 VA: 0x1811C0340
	private static string CreateMessage(string res, string[] args, int lineNumber, int linePosition) { }

	// RVA: 0x11BFEB0 Offset: 0x11BF2B0 VA: 0x1811BFEB0
	internal static string[] BuildCharExceptionArgs(string data, int invCharIndex) { }

	// RVA: 0x11BFF10 Offset: 0x11BF310 VA: 0x1811BFF10
	internal static string[] BuildCharExceptionArgs(char[] data, int length, int invCharIndex) { }

	// RVA: 0x11BFF90 Offset: 0x11BF390 VA: 0x1811BFF90
	internal static string[] BuildCharExceptionArgs(char invChar, char nextChar) { }

	// RVA: 0xB96A00 Offset: 0xB95E00 VA: 0x180B96A00
	public int get_LineNumber() { }

	// RVA: 0xB96A10 Offset: 0xB95E10 VA: 0x180B96A10
	public int get_LinePosition() { }

	// RVA: 0x11C1780 Offset: 0x11C0B80 VA: 0x1811C1780 Slot: 5
	public override string get_Message() { }

	// RVA: 0x58DBD0 Offset: 0x58CFD0 VA: 0x18058DBD0
	internal string get_ResString() { }

}

public abstract class XmlNameTable // TypeDefIndex: 2025
{	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract string Get(string array);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract string Add(char[] array, int offset, int length);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract string Add(string array);

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	protected void .ctor() { }

}

public enum XmlNamespaceScope // TypeDefIndex: 2026
{	// Fields
	public int value__; // 0x0
	public const XmlNamespaceScope All = 0;
	public const XmlNamespaceScope ExcludeXml = 1;
	public const XmlNamespaceScope Local = 2;

}

public class XmlNamespaceManager : IXmlNamespaceResolver, IEnumerable // TypeDefIndex: 2027
{	// Fields
	private XmlNamespaceManager.NamespaceDeclaration[] nsdecls; // 0x10
	private int lastDecl; // 0x18
	private XmlNameTable nameTable; // 0x20
	private int scopeId; // 0x28
	private Dictionary<string, int> hashTable; // 0x30
	private bool useHashtable; // 0x38
	private string xml; // 0x40
	private string xmlNs; // 0x48

	// Properties
	public virtual XmlNameTable NameTable { get; }
	public virtual string DefaultNamespace { get; }

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	internal void .ctor() { }

	// RVA: 0x11C8DB0 Offset: 0x11C81B0 VA: 0x1811C8DB0
	public void .ctor(XmlNameTable nameTable) { }

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00 Slot: 8
	public virtual XmlNameTable get_NameTable() { }

	// RVA: 0x11C9020 Offset: 0x11C8420 VA: 0x1811C9020 Slot: 9
	public virtual string get_DefaultNamespace() { }

	// RVA: 0xEC18D0 Offset: 0xEC0CD0 VA: 0x180EC18D0 Slot: 10
	public virtual void PushScope() { }

	// RVA: 0x11C8B00 Offset: 0x11C7F00 VA: 0x1811C8B00 Slot: 11
	public virtual bool PopScope() { }

	// RVA: 0x11C8120 Offset: 0x11C7520 VA: 0x1811C8120 Slot: 12
	public virtual void AddNamespace(string prefix, string uri) { }

	// RVA: 0x11C8C00 Offset: 0x11C8000 VA: 0x1811C8C00 Slot: 13
	public virtual void RemoveNamespace(string prefix, string uri) { }

	// RVA: 0x11C8530 Offset: 0x11C7930 VA: 0x1811C8530 Slot: 14
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x11C8660 Offset: 0x11C7A60 VA: 0x1811C8660 Slot: 15
	public virtual IDictionary<string, string> GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x11C89C0 Offset: 0x11C7DC0 VA: 0x1811C89C0 Slot: 16
	public virtual string LookupNamespace(string prefix) { }

	// RVA: 0x11C87F0 Offset: 0x11C7BF0 VA: 0x1811C87F0
	private int LookupNamespaceDecl(string prefix) { }

	// RVA: 0x11C8A20 Offset: 0x11C7E20 VA: 0x1811C8A20 Slot: 17
	public virtual string LookupPrefix(string uri) { }

}

private struct XmlNamespaceManager.NamespaceDeclaration // TypeDefIndex: 2028
{	// Fields
	public string prefix; // 0x0
	public string uri; // 0x8
	public int scopeId; // 0x10
	public int previousNsIndex; // 0x14

	// Methods

	// RVA: 0x1D0950 Offset: 0x1CFD50 VA: 0x1801D0950
	public void Set(string prefix, string uri, int scopeId, int previousNsIndex) { }

}

public enum XmlNodeType // TypeDefIndex: 2029
{	// Fields
	public int value__; // 0x0
	public const XmlNodeType None = 0;
	public const XmlNodeType Element = 1;
	public const XmlNodeType Attribute = 2;
	public const XmlNodeType Text = 3;
	public const XmlNodeType CDATA = 4;
	public const XmlNodeType EntityReference = 5;
	public const XmlNodeType Entity = 6;
	public const XmlNodeType ProcessingInstruction = 7;
	public const XmlNodeType Comment = 8;
	public const XmlNodeType Document = 9;
	public const XmlNodeType DocumentType = 10;
	public const XmlNodeType DocumentFragment = 11;
	public const XmlNodeType Notation = 12;
	public const XmlNodeType Whitespace = 13;
	public const XmlNodeType SignificantWhitespace = 14;
	public const XmlNodeType EndElement = 15;
	public const XmlNodeType EndEntity = 16;
	public const XmlNodeType XmlDeclaration = 17;

}

public class XmlQualifiedName // TypeDefIndex: 2030
{	// Fields
	private static XmlQualifiedName.HashCodeOfStringDelegate hashCodeDelegate; // 0x0
	private string name; // 0x10
	private string ns; // 0x18
	private int hash; // 0x20
	public static readonly XmlQualifiedName Empty; // 0x8

	// Properties
	public string Namespace { get; }
	public string Name { get; }
	public bool IsEmpty { get; }

	// Methods

	// RVA: 0xB9BE20 Offset: 0xB9B220 VA: 0x180B9BE20
	public void .ctor() { }

	// RVA: 0xB9BD50 Offset: 0xB9B150 VA: 0x180B9BD50
	public void .ctor(string name) { }

	// RVA: 0xB9BCA0 Offset: 0xB9B0A0 VA: 0x180B9BCA0
	public void .ctor(string name, string ns) { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public string get_Namespace() { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public string get_Name() { }

	// RVA: 0xB9B5D0 Offset: 0xB9A9D0 VA: 0x180B9B5D0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xB9BEE0 Offset: 0xB9B2E0 VA: 0x180B9BEE0
	public bool get_IsEmpty() { }

	// RVA: 0xB9BA60 Offset: 0xB9AE60 VA: 0x180B9BA60 Slot: 3
	public override string ToString() { }

	// RVA: 0xB9B310 Offset: 0xB9A710 VA: 0x180B9B310 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0xB9BF20 Offset: 0xB9B320 VA: 0x180B9BF20
	public static bool op_Equality(XmlQualifiedName a, XmlQualifiedName b) { }

	// RVA: 0xB9BF90 Offset: 0xB9B390 VA: 0x180B9BF90
	public static bool op_Inequality(XmlQualifiedName a, XmlQualifiedName b) { }

	// RVA: 0xB9B9F0 Offset: 0xB9ADF0 VA: 0x180B9B9F0
	public static string ToString(string name, string ns) { }

	// RVA: 0xB9B440 Offset: 0xB9A840 VA: 0x180B9B440
	private static XmlQualifiedName.HashCodeOfStringDelegate GetHashCodeDelegate() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0
	private static bool IsRandomizedHashingDisabled() { }

	// RVA: 0xB9B5A0 Offset: 0xB9A9A0 VA: 0x180B9B5A0
	private static int GetHashCodeOfString(string s, int length, long additionalEntropy) { }

	// RVA: 0xB9B820 Offset: 0xB9AC20 VA: 0x180B9B820
	internal void Init(string name, string ns) { }

	// RVA: 0x4D0180 Offset: 0x4CF580 VA: 0x1804D0180
	internal void SetNamespace(string ns) { }

	// RVA: 0xB9BAC0 Offset: 0xB9AEC0 VA: 0x180B9BAC0
	internal void Verify() { }

	// RVA: 0xB9B210 Offset: 0xB9A610 VA: 0x180B9B210
	internal void Atomize(XmlNameTable nameTable) { }

	// RVA: 0xB9B860 Offset: 0xB9AC60 VA: 0x180B9B860
	internal static XmlQualifiedName Parse(string s, IXmlNamespaceResolver nsmgr, out string prefix) { }

	// RVA: 0xB9B290 Offset: 0xB9A690 VA: 0x180B9B290
	internal XmlQualifiedName Clone() { }

	// RVA: 0xB9BB60 Offset: 0xB9AF60 VA: 0x180B9BB60
	private static void .cctor() { }

}

private sealed class XmlQualifiedName.HashCodeOfStringDelegate : MulticastDelegate // TypeDefIndex: 2031
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xB95ED0 Offset: 0xB952D0 VA: 0x180B95ED0 Slot: 12
	public virtual int Invoke(string s, int sLen, long additionalEntropy) { }

	// RVA: 0xB95E00 Offset: 0xB95200 VA: 0x180B95E00 Slot: 13
	public virtual IAsyncResult BeginInvoke(string s, int sLen, long additionalEntropy, AsyncCallback callback, object object) { }

	// RVA: 0xB95EA0 Offset: 0xB952A0 VA: 0x180B95EA0 Slot: 14
	public virtual int EndInvoke(IAsyncResult result) { }

}

public abstract class XmlResolver // TypeDefIndex: 2032
{	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract object GetEntity(Uri absoluteUri, string role, Type ofObjectToReturn);

	// RVA: 0xBA01E0 Offset: 0xB9F5E0 VA: 0x180BA01E0 Slot: 5
	public virtual Uri ResolveUri(Uri baseUri, string relativeUri) { }

	// RVA: 0xBA03C0 Offset: 0xB9F7C0 VA: 0x180BA03C0 Slot: 6
	public virtual bool SupportsType(Uri absoluteUri, Type type) { }

	// RVA: 0xBA0190 Offset: 0xB9F590 VA: 0x180BA0190 Slot: 7
	public virtual Task<object> GetEntityAsync(Uri absoluteUri, string role, Type ofObjectToReturn) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	protected void .ctor() { }

}

public class XmlUrlResolver : XmlResolver // TypeDefIndex: 2033
{	// Fields
	private static object s_DownloadManager; // 0x0
	private ICredentials _credentials; // 0x10
	private IWebProxy _proxy; // 0x18
	private RequestCachePolicy _cachePolicy; // 0x20

	// Properties
	private static XmlDownloadManager DownloadManager { get; }

	// Methods

	// RVA: 0x131A370 Offset: 0x1319770 VA: 0x18131A370
	private static XmlDownloadManager get_DownloadManager() { }

	// RVA: 0x7992B0 Offset: 0x7986B0 VA: 0x1807992B0
	public void .ctor() { }

	// RVA: 0x131A1D0 Offset: 0x13195D0 VA: 0x18131A1D0 Slot: 4
	public override object GetEntity(Uri absoluteUri, string role, Type ofObjectToReturn) { }

	// RVA: 0x131A360 Offset: 0x1319760 VA: 0x18131A360 Slot: 5
	public override Uri ResolveUri(Uri baseUri, string relativeUri) { }

	[AsyncStateMachineAttribute] // RVA: 0x84260 Offset: 0x83660 VA: 0x180084260
	// RVA: 0x131A090 Offset: 0x1319490 VA: 0x18131A090 Slot: 7
	public override Task<object> GetEntityAsync(Uri absoluteUri, string role, Type ofObjectToReturn) { }

}

private struct XmlUrlResolver.<GetEntityAsync>d__15 : IAsyncStateMachine // TypeDefIndex: 2034
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<object> <>t__builder; // 0x8
	public Type ofObjectToReturn; // 0x20
	public Uri absoluteUri; // 0x28
	public XmlUrlResolver <>4__this; // 0x30
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Stream> <>u__1; // 0x38

	// Methods

	// RVA: 0x1E1120 Offset: 0x1E0520 VA: 0x1801E1120 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1E1130 Offset: 0x1E0530 VA: 0x1801E1130 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

public class XPathDocument // TypeDefIndex: 2036
{	// Fields
	private XPathNode[] pageXmlNmsp; // 0x10
	private int idxXmlNmsp; // 0x18
	private XmlNameTable nameTable; // 0x20
	private bool hasLineInfo; // 0x28
	private Dictionary<XPathNodeRef, XPathNodeRef> mapNmsp; // 0x30

	// Properties
	internal XmlNameTable NameTable { get; }
	internal bool HasLineInfo { get; }

	// Methods

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	internal XmlNameTable get_NameTable() { }

	// RVA: 0x9775C0 Offset: 0x9769C0 VA: 0x1809775C0
	internal bool get_HasLineInfo() { }

	// RVA: 0xE4B0B0 Offset: 0xE4A4B0 VA: 0x180E4B0B0
	internal int GetXmlNamespaceNode(out XPathNode[] pageXmlNmsp) { }

	// RVA: 0xE4B0E0 Offset: 0xE4A4E0 VA: 0x180E4B0E0
	internal int LookupNamespaces(XPathNode[] pageElem, int idxElem, out XPathNode[] pageNmsp) { }

}

public class XPathException : SystemException // TypeDefIndex: 2037
{	// Fields
	private string res; // 0x88
	private string[] args; // 0x90
	private string message; // 0x98

	// Properties
	public override string Message { get; }

	// Methods

	// RVA: 0xE4B8E0 Offset: 0xE4ACE0 VA: 0x180E4B8E0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xE4B5C0 Offset: 0xE4A9C0 VA: 0x180E4B5C0 Slot: 10
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xE4B7E0 Offset: 0xE4ABE0 VA: 0x180E4B7E0
	public void .ctor() { }

	// RVA: 0xE4B700 Offset: 0xE4AB00 VA: 0x180E4B700
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0xE4B3A0 Offset: 0xE4A7A0 VA: 0x180E4B3A0
	internal static XPathException Create(string res) { }

	// RVA: 0xE4B280 Offset: 0xE4A680 VA: 0x180E4B280
	internal static XPathException Create(string res, string arg) { }

	// RVA: 0xE4B440 Offset: 0xE4A840 VA: 0x180E4B440
	internal static XPathException Create(string res, string arg, string arg2) { }

	// RVA: 0xE4BB20 Offset: 0xE4AF20 VA: 0x180E4BB20
	private void .ctor(string res, string[] args) { }

	// RVA: 0xE4B680 Offset: 0xE4AA80 VA: 0x180E4B680
	private void .ctor(string res, string[] args, Exception inner) { }

	// RVA: 0xE4B1E0 Offset: 0xE4A5E0 VA: 0x180E4B1E0
	private static string CreateMessage(string res, string[] args) { }

	// RVA: 0xE4BBA0 Offset: 0xE4AFA0 VA: 0x180E4BBA0 Slot: 5
	public override string get_Message() { }

}

public enum XPathResultType // TypeDefIndex: 2038
{	// Fields
	public int value__; // 0x0
	public const XPathResultType Number = 0;
	public const XPathResultType String = 1;
	public const XPathResultType Boolean = 2;
	public const XPathResultType NodeSet = 3;
	public const XPathResultType Navigator = 1;
	public const XPathResultType Any = 5;
	public const XPathResultType Error = 6;

}

public abstract class XPathItem // TypeDefIndex: 2039
{	// Properties
	public abstract XmlSchemaType XmlType { get; }
	public abstract string Value { get; }
	public abstract object TypedValue { get; }
	public abstract Type ValueType { get; }
	public abstract bool ValueAsBoolean { get; }
	public abstract DateTime ValueAsDateTime { get; }
	public abstract double ValueAsDouble { get; }
	public abstract int ValueAsInt { get; }
	public abstract long ValueAsLong { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract XmlSchemaType get_XmlType();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract string get_Value();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract object get_TypedValue();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract Type get_ValueType();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool get_ValueAsBoolean();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract DateTime get_ValueAsDateTime();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract double get_ValueAsDouble();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract int get_ValueAsInt();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract long get_ValueAsLong();

	// RVA: 0xE4BBC0 Offset: 0xE4AFC0 VA: 0x180E4BBC0 Slot: 13
	public virtual object ValueAs(Type returnType) { }

	// RVA: -1 Offset: -1 Slot: 14
	public abstract object ValueAs(Type returnType, IXmlNamespaceResolver nsResolver);

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	protected void .ctor() { }

}

public enum XPathNamespaceScope // TypeDefIndex: 2040
{	// Fields
	public int value__; // 0x0
	public const XPathNamespaceScope All = 0;
	public const XPathNamespaceScope ExcludeXml = 1;
	public const XPathNamespaceScope Local = 2;

}

public abstract class XPathNavigator : XPathItem, ICloneable, IXmlNamespaceResolver // TypeDefIndex: 2041
{	// Fields
	internal static readonly XPathNavigatorKeyComparer comparer; // 0x0
	internal static readonly char[] NodeTypeLetter; // 0x8
	internal static readonly char[] UniqueIdTbl; // 0x10
	internal static readonly int[] ContentKindMasks; // 0x18

	// Properties
	public override XmlSchemaType XmlType { get; }
	public override object TypedValue { get; }
	public override Type ValueType { get; }
	public override bool ValueAsBoolean { get; }
	public override DateTime ValueAsDateTime { get; }
	public override double ValueAsDouble { get; }
	public override int ValueAsInt { get; }
	public override long ValueAsLong { get; }
	public abstract XmlNameTable NameTable { get; }
	public abstract XPathNodeType NodeType { get; }
	public abstract string LocalName { get; }
	public abstract string NamespaceURI { get; }
	public abstract string Prefix { get; }
	public virtual object UnderlyingObject { get; }
	public virtual IXmlSchemaInfo SchemaInfo { get; }

	// Methods

	// RVA: 0x95B120 Offset: 0x95A520 VA: 0x18095B120 Slot: 3
	public override string ToString() { }

	// RVA: 0xE4D4B0 Offset: 0xE4C8B0 VA: 0x180E4D4B0 Slot: 4
	public override XmlSchemaType get_XmlType() { }

	// RVA: 0xE4C870 Offset: 0xE4BC70 VA: 0x180E4C870 Slot: 6
	public override object get_TypedValue() { }

	// RVA: 0xE4D3D0 Offset: 0xE4C7D0 VA: 0x180E4D3D0 Slot: 7
	public override Type get_ValueType() { }

	// RVA: 0xE4CA70 Offset: 0xE4BE70 VA: 0x180E4CA70 Slot: 8
	public override bool get_ValueAsBoolean() { }

	// RVA: 0xE4CC50 Offset: 0xE4C050 VA: 0x180E4CC50 Slot: 9
	public override DateTime get_ValueAsDateTime() { }

	// RVA: 0xE4CE30 Offset: 0xE4C230 VA: 0x180E4CE30 Slot: 10
	public override double get_ValueAsDouble() { }

	// RVA: 0xE4D010 Offset: 0xE4C410 VA: 0x180E4D010 Slot: 11
	public override int get_ValueAsInt() { }

	// RVA: 0xE4D1F0 Offset: 0xE4C5F0 VA: 0x180E4D1F0 Slot: 12
	public override long get_ValueAsLong() { }

	// RVA: 0xE4C4E0 Offset: 0xE4B8E0 VA: 0x180E4C4E0 Slot: 14
	public override object ValueAs(Type returnType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0xE4C4C0 Offset: 0xE4B8C0 VA: 0x180E4C4C0 Slot: 15
	private object System.ICloneable.Clone() { }

	// RVA: -1 Offset: -1 Slot: 19
	public abstract XmlNameTable get_NameTable();

	// RVA: 0xE4C0A0 Offset: 0xE4B4A0 VA: 0x180E4C0A0 Slot: 20
	public virtual string LookupNamespace(string prefix) { }

	// RVA: 0xE4C220 Offset: 0xE4B620 VA: 0x180E4C220 Slot: 21
	public virtual string LookupPrefix(string namespaceURI) { }

	// RVA: 0xE4BEC0 Offset: 0xE4B2C0 VA: 0x180E4BEC0 Slot: 22
	public virtual IDictionary<string, string> GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: -1 Offset: -1 Slot: 23
	public abstract XPathNavigator Clone();

	// RVA: -1 Offset: -1 Slot: 24
	public abstract XPathNodeType get_NodeType();

	// RVA: -1 Offset: -1 Slot: 25
	public abstract string get_LocalName();

	// RVA: -1 Offset: -1 Slot: 26
	public abstract string get_NamespaceURI();

	// RVA: -1 Offset: -1 Slot: 27
	public abstract string get_Prefix();

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 28
	public virtual object get_UnderlyingObject() { }

	// RVA: 0xE4C420 Offset: 0xE4B820 VA: 0x180E4C420 Slot: 29
	public virtual bool MoveToNamespace(string name) { }

	// RVA: -1 Offset: -1 Slot: 30
	public abstract bool MoveToFirstNamespace(XPathNamespaceScope namespaceScope);

	// RVA: -1 Offset: -1 Slot: 31
	public abstract bool MoveToNextNamespace(XPathNamespaceScope namespaceScope);

	// RVA: -1 Offset: -1 Slot: 32
	public abstract bool MoveToParent();

	// RVA: -1 Offset: -1 Slot: 33
	public abstract bool IsSamePosition(XPathNavigator other);

	// RVA: 0xE4C830 Offset: 0xE4BC30 VA: 0x180E4C830 Slot: 34
	public virtual IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0xE4C090 Offset: 0xE4B490 VA: 0x180E4C090
	internal static bool IsText(XPathNodeType type) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	protected void .ctor() { }

	// RVA: 0xE4C700 Offset: 0xE4BB00 VA: 0x180E4C700
	private static void .cctor() { }

}

internal class XPathNavigatorKeyComparer : IEqualityComparer // TypeDefIndex: 2042
{	// Methods

	// RVA: 0xE4BBE0 Offset: 0xE4AFE0 VA: 0x180E4BBE0 Slot: 4
	private bool System.Collections.IEqualityComparer.Equals(object obj1, object obj2) { }

	// RVA: 0xE4BCC0 Offset: 0xE4B0C0 VA: 0x180E4BCC0 Slot: 5
	private int System.Collections.IEqualityComparer.GetHashCode(object obj) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

public enum XPathNodeType // TypeDefIndex: 2043
{	// Fields
	public int value__; // 0x0
	public const XPathNodeType Root = 0;
	public const XPathNodeType Element = 1;
	public const XPathNodeType Attribute = 2;
	public const XPathNodeType Namespace = 3;
	public const XPathNodeType Text = 4;
	public const XPathNodeType SignificantWhitespace = 5;
	public const XPathNodeType Whitespace = 6;
	public const XPathNodeType ProcessingInstruction = 7;
	public const XPathNodeType Comment = 8;
	public const XPathNodeType All = 9;

}

public class XmlSerializerNamespaces // TypeDefIndex: 2045
{	// Fields
	private Hashtable namespaces; // 0x10

	// Properties
	public int Count { get; }
	internal ArrayList NamespaceList { get; }
	internal Hashtable Namespaces { get; set; }

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0xE61C60 Offset: 0xE61060 VA: 0x180E61C60
	public void Add(string prefix, string ns) { }

	// RVA: 0xE61BB0 Offset: 0xE60FB0 VA: 0x180E61BB0
	internal void AddInternal(string prefix, string ns) { }

	// RVA: 0xE61EB0 Offset: 0xE612B0 VA: 0x180E61EB0
	public XmlQualifiedName[] ToArray() { }

	// RVA: 0xE61FA0 Offset: 0xE613A0 VA: 0x180E61FA0
	public int get_Count() { }

	// RVA: 0xE62030 Offset: 0xE61430 VA: 0x180E62030
	internal ArrayList get_NamespaceList() { }

	// RVA: 0xE62350 Offset: 0xE61750 VA: 0x180E62350
	internal Hashtable get_Namespaces() { }

	// RVA: 0x4B94C0 Offset: 0x4B88C0 VA: 0x1804B94C0
	internal void set_Namespaces(Hashtable value) { }

}

public sealed class XmlAttributeEventHandler : MulticastDelegate // TypeDefIndex: 2046
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xADFD50 Offset: 0xADF150 VA: 0x180ADFD50 Slot: 12
	public virtual void Invoke(object sender, XmlAttributeEventArgs e) { }

	// RVA: 0xADFD10 Offset: 0xADF110 VA: 0x180ADFD10 Slot: 13
	public virtual IAsyncResult BeginInvoke(object sender, XmlAttributeEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public class XmlAttributeEventArgs : EventArgs // TypeDefIndex: 2047
{	// Fields
	private object o; // 0x10
	private XmlAttribute attr; // 0x18
	private string qnames; // 0x20
	private int lineNumber; // 0x28
	private int linePosition; // 0x2C

	// Methods

	// RVA: 0x11074B0 Offset: 0x11068B0 VA: 0x1811074B0
	internal void .ctor(XmlAttribute attr, int lineNumber, int linePosition, object o, string qnames) { }

}

public sealed class XmlElementEventHandler : MulticastDelegate // TypeDefIndex: 2048
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xADFD50 Offset: 0xADF150 VA: 0x180ADFD50 Slot: 12
	public virtual void Invoke(object sender, XmlElementEventArgs e) { }

	// RVA: 0xADFD10 Offset: 0xADF110 VA: 0x180ADFD10 Slot: 13
	public virtual IAsyncResult BeginInvoke(object sender, XmlElementEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public class XmlElementEventArgs : EventArgs // TypeDefIndex: 2049
{	// Fields
	private object o; // 0x10
	private XmlElement elem; // 0x18
	private string qnames; // 0x20
	private int lineNumber; // 0x28
	private int linePosition; // 0x2C

	// Methods

	// RVA: 0x1682EC0 Offset: 0x16822C0 VA: 0x181682EC0
	internal void .ctor(XmlElement elem, int lineNumber, int linePosition, object o, string qnames) { }

}

public sealed class XmlNodeEventHandler : MulticastDelegate // TypeDefIndex: 2050
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xADFD50 Offset: 0xADF150 VA: 0x180ADFD50 Slot: 12
	public virtual void Invoke(object sender, XmlNodeEventArgs e) { }

	// RVA: 0xADFD10 Offset: 0xADF110 VA: 0x180ADFD10 Slot: 13
	public virtual IAsyncResult BeginInvoke(object sender, XmlNodeEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public class XmlNodeEventArgs : EventArgs // TypeDefIndex: 2051
{	// Fields
	private object o; // 0x10
	private XmlNode xmlNode; // 0x18
	private int lineNumber; // 0x20
	private int linePosition; // 0x24

	// Methods

	// RVA: 0x1683060 Offset: 0x1682460 VA: 0x181683060
	internal void .ctor(XmlNode xmlNode, int lineNumber, int linePosition, object o) { }

}

internal class XmlTypeSerializationSource : SerializationSource // TypeDefIndex: 2060
{	// Fields
	private string attributeOverridesHash; // 0x28
	private Type type; // 0x30
	private string rootHash; // 0x38

	// Methods

	// RVA: 0xE66380 Offset: 0xE65780 VA: 0x180E66380
	public void .ctor(Type type, XmlRootAttribute root, XmlAttributeOverrides attributeOverrides, string namspace, Type[] includedTypes) { }

	// RVA: 0xE66250 Offset: 0xE65650 VA: 0x180E66250 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0xE66350 Offset: 0xE65750 VA: 0x180E66350 Slot: 2
	public override int GetHashCode() { }

}

internal class XmlTypeConvertorAttribute : Attribute // TypeDefIndex: 2061
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <Method>k__BackingField; // 0x10

	// Properties
	public string Method { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public string get_Method() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B94C0 Offset: 0x4B88C0 VA: 0x1804B94C0
	private void set_Method(string value) { }

	// RVA: 0x805E80 Offset: 0x805280 VA: 0x180805E80
	public void .ctor(string method) { }

}

public class XmlAnyAttributeAttribute : Attribute // TypeDefIndex: 2065
{	// Methods

	// RVA: 0x7992B0 Offset: 0x7986B0 VA: 0x1807992B0
	public void .ctor() { }

}

public class XmlAnyElementAttribute : Attribute // TypeDefIndex: 2066
{	// Fields
	private string elementName; // 0x10
	private string ns; // 0x18
	private int order; // 0x20

	// Properties
	public string Name { get; }
	public string Namespace { get; }
	public int Order { get; }

	// Methods

	// RVA: 0x1105EB0 Offset: 0x11052B0 VA: 0x181105EB0
	public void .ctor() { }

	// RVA: 0x1105EC0 Offset: 0x11052C0 VA: 0x181105EC0
	public string get_Name() { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public string get_Namespace() { }

	// RVA: 0x4D0170 Offset: 0x4CF570 VA: 0x1804D0170
	public int get_Order() { }

	// RVA: 0x1105CC0 Offset: 0x11050C0 VA: 0x181105CC0
	internal void AddKeyHash(StringBuilder sb) { }

}

public class XmlAnyElementAttributes : CollectionBase // TypeDefIndex: 2067
{	// Properties
	public XmlAnyElementAttribute Item { get; }
	internal int Order { get; }

	// Methods

	// RVA: 0x11060D0 Offset: 0x11054D0 VA: 0x1811060D0
	public XmlAnyElementAttribute get_Item(int index) { }

	// RVA: 0x1106060 Offset: 0x1105460 VA: 0x181106060
	public int Add(XmlAnyElementAttribute attribute) { }

	// RVA: 0x1105F10 Offset: 0x1105310 VA: 0x181105F10
	internal void AddKeyHash(StringBuilder sb) { }

	// RVA: 0x1106180 Offset: 0x1105580 VA: 0x181106180
	internal int get_Order() { }

	// RVA: 0x1057B30 Offset: 0x1056F30 VA: 0x181057B30
	public void .ctor() { }

}

public class XmlArrayAttribute : Attribute // TypeDefIndex: 2068
{	// Fields
	private string elementName; // 0x10
	private XmlSchemaForm form; // 0x18
	private bool isNullable; // 0x1C
	private string ns; // 0x20
	private int order; // 0x28

	// Properties
	public string ElementName { get; }
	public XmlSchemaForm Form { get; }
	public bool IsNullable { get; }
	public string Namespace { get; }
	public int Order { get; }

	// Methods

	// RVA: 0x11066A0 Offset: 0x1105AA0 VA: 0x1811066A0
	public string get_ElementName() { }

	// RVA: 0x4BE200 Offset: 0x4BD600 VA: 0x1804BE200
	public XmlSchemaForm get_Form() { }

	// RVA: 0x7E8DD0 Offset: 0x7E81D0 VA: 0x1807E8DD0
	public bool get_IsNullable() { }

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	public string get_Namespace() { }

	// RVA: 0x4BB390 Offset: 0x4BA790 VA: 0x1804BB390
	public int get_Order() { }

	// RVA: 0x1106330 Offset: 0x1105730 VA: 0x181106330
	internal void AddKeyHash(StringBuilder sb) { }

}

public class XmlArrayItemAttribute : Attribute // TypeDefIndex: 2069
{	// Fields
	private string dataType; // 0x10
	private string elementName; // 0x18
	private XmlSchemaForm form; // 0x20
	private string ns; // 0x28
	private bool isNullable; // 0x30
	private bool isNullableSpecified; // 0x31
	private int nestingLevel; // 0x34
	private Type type; // 0x38

	// Properties
	public string DataType { get; }
	public string ElementName { get; }
	public XmlSchemaForm Form { get; }
	public string Namespace { get; }
	public bool IsNullable { get; }
	internal bool IsNullableSpecified { get; }
	public Type Type { get; }
	public int NestingLevel { get; }

	// Methods

	// RVA: 0x1106C40 Offset: 0x1106040 VA: 0x181106C40
	public string get_DataType() { }

	// RVA: 0x1106C90 Offset: 0x1106090 VA: 0x181106C90
	public string get_ElementName() { }

	// RVA: 0x4D0170 Offset: 0x4CF570 VA: 0x1804D0170
	public XmlSchemaForm get_Form() { }

	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230
	public string get_Namespace() { }

	// RVA: 0x8298F0 Offset: 0x828CF0 VA: 0x1808298F0
	public bool get_IsNullable() { }

	// RVA: 0xFF6160 Offset: 0xFF5560 VA: 0x180FF6160
	internal bool get_IsNullableSpecified() { }

	// RVA: 0x5DCC00 Offset: 0x5DC000 VA: 0x1805DCC00
	public Type get_Type() { }

	// RVA: 0x5FC780 Offset: 0x5FBB80 VA: 0x1805FC780
	public int get_NestingLevel() { }

	// RVA: 0x11066F0 Offset: 0x1105AF0 VA: 0x1811066F0
	internal void AddKeyHash(StringBuilder sb) { }

}

public class XmlArrayItemAttributes : CollectionBase // TypeDefIndex: 2070
{	// Properties
	public XmlArrayItemAttribute Item { get; }

	// Methods

	// RVA: 0x1106EA0 Offset: 0x11062A0 VA: 0x181106EA0
	public XmlArrayItemAttribute get_Item(int index) { }

	// RVA: 0x1106E30 Offset: 0x1106230 VA: 0x181106E30
	public int Add(XmlArrayItemAttribute attribute) { }

	// RVA: 0x1106CE0 Offset: 0x11060E0 VA: 0x181106CE0
	internal void AddKeyHash(StringBuilder sb) { }

	// RVA: 0x1057B30 Offset: 0x1056F30 VA: 0x181057B30
	public void .ctor() { }

}

public class XmlAttributeAttribute : Attribute // TypeDefIndex: 2071
{	// Fields
	private string attributeName; // 0x10
	private string dataType; // 0x18
	private Type type; // 0x20
	private XmlSchemaForm form; // 0x28
	private string ns; // 0x30

	// Properties
	public string AttributeName { get; }
	public string DataType { get; set; }
	public XmlSchemaForm Form { get; }
	public string Namespace { get; }

	// Methods

	// RVA: 0x805E80 Offset: 0x805280 VA: 0x180805E80
	public void .ctor(string attributeName) { }

	// RVA: 0x1107410 Offset: 0x1106810 VA: 0x181107410
	public string get_AttributeName() { }

	// RVA: 0x1107460 Offset: 0x1106860 VA: 0x181107460
	public string get_DataType() { }

	// RVA: 0x4D0180 Offset: 0x4CF580 VA: 0x1804D0180
	public void set_DataType(string value) { }

	// RVA: 0x4BB390 Offset: 0x4BA790 VA: 0x1804BB390
	public XmlSchemaForm get_Form() { }

	// RVA: 0x4A2EE0 Offset: 0x4A22E0 VA: 0x1804A2EE0
	public string get_Namespace() { }

	// RVA: 0x1106F50 Offset: 0x1106350 VA: 0x181106F50
	internal void AddKeyHash(StringBuilder sb) { }

}

public class XmlAttributeOverrides // TypeDefIndex: 2072
{	// Fields
	private Hashtable overrides; // 0x10

	// Properties
	public XmlAttributes Item { get; }
	public XmlAttributes Item { get; }

	// Methods

	// RVA: 0x1107910 Offset: 0x1106D10 VA: 0x181107910
	public void .ctor() { }

	// RVA: 0x1107980 Offset: 0x1106D80 VA: 0x181107980
	public XmlAttributes get_Item(Type type) { }

	// RVA: 0x1107AC0 Offset: 0x1106EC0 VA: 0x181107AC0
	public XmlAttributes get_Item(Type type, string member) { }

	// RVA: 0x1107890 Offset: 0x1106C90 VA: 0x181107890
	private TypeMember GetKey(Type type, string member) { }

	// RVA: 0x1107560 Offset: 0x1106960 VA: 0x181107560
	internal void AddKeyHash(StringBuilder sb) { }

}

public class XmlAttributes // TypeDefIndex: 2073
{	// Fields
	private XmlAnyAttributeAttribute xmlAnyAttribute; // 0x10
	private XmlAnyElementAttributes xmlAnyElements; // 0x18
	private XmlArrayAttribute xmlArray; // 0x20
	private XmlArrayItemAttributes xmlArrayItems; // 0x28
	private XmlAttributeAttribute xmlAttribute; // 0x30
	private XmlChoiceIdentifierAttribute xmlChoiceIdentifier; // 0x38
	private object xmlDefaultValue; // 0x40
	private XmlElementAttributes xmlElements; // 0x48
	private XmlEnumAttribute xmlEnum; // 0x50
	private bool xmlIgnore; // 0x58
	private bool xmlns; // 0x59
	private XmlRootAttribute xmlRoot; // 0x60
	private XmlTextAttribute xmlText; // 0x68
	private XmlTypeAttribute xmlType; // 0x70

	// Properties
	public XmlAnyAttributeAttribute XmlAnyAttribute { get; }
	public XmlAnyElementAttributes XmlAnyElements { get; }
	public XmlArrayAttribute XmlArray { get; }
	public XmlArrayItemAttributes XmlArrayItems { get; }
	public XmlAttributeAttribute XmlAttribute { get; }
	public XmlChoiceIdentifierAttribute XmlChoiceIdentifier { get; }
	public object XmlDefaultValue { get; }
	public XmlElementAttributes XmlElements { get; }
	public bool XmlIgnore { get; }
	public bool Xmlns { get; }
	public XmlRootAttribute XmlRoot { get; }
	public XmlTextAttribute XmlText { get; }
	public XmlTypeAttribute XmlType { get; }
	internal Nullable<int> Order { get; }
	internal int SortableOrder { get; }

	// Methods

	// RVA: 0x1108DB0 Offset: 0x11081B0 VA: 0x181108DB0
	public void .ctor() { }

	// RVA: 0x11082D0 Offset: 0x11076D0 VA: 0x1811082D0
	public void .ctor(ICustomAttributeProvider provider) { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public XmlAnyAttributeAttribute get_XmlAnyAttribute() { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public XmlAnyElementAttributes get_XmlAnyElements() { }

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	public XmlArrayAttribute get_XmlArray() { }

	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230
	public XmlArrayItemAttributes get_XmlArrayItems() { }

	// RVA: 0x4A2EE0 Offset: 0x4A22E0 VA: 0x1804A2EE0
	public XmlAttributeAttribute get_XmlAttribute() { }

	// RVA: 0x5DCC00 Offset: 0x5DC000 VA: 0x1805DCC00
	public XmlChoiceIdentifierAttribute get_XmlChoiceIdentifier() { }

	// RVA: 0x4B9440 Offset: 0x4B8840 VA: 0x1804B9440
	public object get_XmlDefaultValue() { }

	// RVA: 0x5DCCA0 Offset: 0x5DC0A0 VA: 0x1805DCCA0
	public XmlElementAttributes get_XmlElements() { }

	// RVA: 0x5ABE90 Offset: 0x5AB290 VA: 0x1805ABE90
	public bool get_XmlIgnore() { }

	// RVA: 0xAF1470 Offset: 0xAF0870 VA: 0x180AF1470
	public bool get_Xmlns() { }

	// RVA: 0x54FB60 Offset: 0x54EF60 VA: 0x18054FB60
	public XmlRootAttribute get_XmlRoot() { }

	// RVA: 0x5334F0 Offset: 0x5328F0 VA: 0x1805334F0
	public XmlTextAttribute get_XmlText() { }

	// RVA: 0x58DC30 Offset: 0x58D030 VA: 0x18058DC30
	public XmlTypeAttribute get_XmlType() { }

	// RVA: 0x1107BE0 Offset: 0x1106FE0 VA: 0x181107BE0
	internal void AddKeyHash(StringBuilder sb) { }

	// RVA: 0x1108EB0 Offset: 0x11082B0 VA: 0x181108EB0
	internal Nullable<int> get_Order() { }

	// RVA: 0x1108F60 Offset: 0x1108360 VA: 0x181108F60
	internal int get_SortableOrder() { }

}

public class XmlChoiceIdentifierAttribute : Attribute // TypeDefIndex: 2074
{	// Fields
	private string memberName; // 0x10

	// Properties
	public string MemberName { get; }

	// Methods

	// RVA: 0x1109100 Offset: 0x1108500 VA: 0x181109100
	public string get_MemberName() { }

	// RVA: 0x1108FE0 Offset: 0x11083E0 VA: 0x181108FE0
	internal void AddKeyHash(StringBuilder sb) { }

}

internal class XmlCustomFormatter // TypeDefIndex: 2075
{	// Fields
	private static string[] allTimeFormats; // 0x2B0AAB0

	// Methods

	// RVA: 0x1109150 Offset: 0x1108550 VA: 0x181109150
	internal static string FromEnum(long value, string[] values, long[] ids, string typeName) { }

	// RVA: 0x11094D0 Offset: 0x11088D0 VA: 0x1811094D0
	internal static string FromXmlName(string name) { }

	// RVA: 0x1109470 Offset: 0x1108870 VA: 0x181109470
	internal static string FromXmlNCName(string ncName) { }

	// RVA: 0x1109E10 Offset: 0x1109210 VA: 0x181109E10
	internal static string ToXmlString(TypeData type, object value) { }

	// RVA: 0x1109530 Offset: 0x1108930 VA: 0x181109530
	internal static object FromXmlString(TypeData type, string value) { }

	// RVA: 0x110A980 Offset: 0x1109D80 VA: 0x18110A980
	private static void .cctor() { }

}

public class XmlElementAttribute : Attribute // TypeDefIndex: 2076
{	// Fields
	private string dataType; // 0x10
	private string elementName; // 0x18
	private XmlSchemaForm form; // 0x20
	private string ns; // 0x28
	private bool isNullable; // 0x30
	private Type type; // 0x38
	private int order; // 0x40

	// Properties
	public string DataType { get; }
	public string ElementName { get; }
	public XmlSchemaForm Form { get; }
	public string Namespace { get; }
	public bool IsNullable { get; }
	public int Order { get; }
	public Type Type { get; }

	// Methods

	// RVA: 0x110B8C0 Offset: 0x110ACC0 VA: 0x18110B8C0
	public void .ctor(string elementName) { }

	// RVA: 0x110B860 Offset: 0x110AC60 VA: 0x18110B860
	public void .ctor(string elementName, Type type) { }

	// RVA: 0x110B900 Offset: 0x110AD00 VA: 0x18110B900
	public string get_DataType() { }

	// RVA: 0x110B950 Offset: 0x110AD50 VA: 0x18110B950
	public string get_ElementName() { }

	// RVA: 0x4D0170 Offset: 0x4CF570 VA: 0x1804D0170
	public XmlSchemaForm get_Form() { }

	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230
	public string get_Namespace() { }

	// RVA: 0x8298F0 Offset: 0x828CF0 VA: 0x1808298F0
	public bool get_IsNullable() { }

	// RVA: 0x5F7C80 Offset: 0x5F7080 VA: 0x1805F7C80
	public int get_Order() { }

	// RVA: 0x5DCC00 Offset: 0x5DC000 VA: 0x1805DCC00
	public Type get_Type() { }

	// RVA: 0x110B370 Offset: 0x110A770 VA: 0x18110B370
	internal void AddKeyHash(StringBuilder sb) { }

}

public class XmlElementAttributes : CollectionBase // TypeDefIndex: 2077
{	// Properties
	public XmlElementAttribute Item { get; }
	internal int Order { get; }

	// Methods

	// RVA: 0x110BB60 Offset: 0x110AF60 VA: 0x18110BB60
	public XmlElementAttribute get_Item(int index) { }

	// RVA: 0x110BAF0 Offset: 0x110AEF0 VA: 0x18110BAF0
	public int Add(XmlElementAttribute attribute) { }

	// RVA: 0x110B9A0 Offset: 0x110ADA0 VA: 0x18110B9A0
	internal void AddKeyHash(StringBuilder sb) { }

	// RVA: 0x110BC10 Offset: 0x110B010 VA: 0x18110BC10
	internal int get_Order() { }

	// RVA: 0x1057B30 Offset: 0x1056F30 VA: 0x181057B30
	public void .ctor() { }

}

public class XmlEnumAttribute : Attribute // TypeDefIndex: 2078
{	// Fields
	private string name; // 0x10

	// Properties
	public string Name { get; }

	// Methods

	// RVA: 0x805E80 Offset: 0x805280 VA: 0x180805E80
	public void .ctor(string name) { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public string get_Name() { }

	// RVA: 0x1682F70 Offset: 0x1682370 VA: 0x181682F70
	internal void AddKeyHash(StringBuilder sb) { }

}

public class XmlIgnoreAttribute : Attribute // TypeDefIndex: 2079
{	// Methods

	// RVA: 0x7992B0 Offset: 0x7986B0 VA: 0x1807992B0
	public void .ctor() { }

}

public class XmlIncludeAttribute : Attribute // TypeDefIndex: 2080
{	// Fields
	private Type type; // 0x10

	// Properties
	public Type Type { get; }

	// Methods

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public Type get_Type() { }

}

public abstract class XmlMapping // TypeDefIndex: 2081
{	// Fields
	private ObjectMap map; // 0x10
	private ArrayList relatedMaps; // 0x18
	private SerializationFormat format; // 0x20
	private SerializationSource source; // 0x28
	internal string _elementName; // 0x30
	internal string _namespace; // 0x38
	private string key; // 0x40

	// Properties
	public string ElementName { get; }
	public string Namespace { get; }
	internal ObjectMap ObjectMap { get; set; }
	internal ArrayList RelatedMaps { get; set; }
	internal SerializationFormat Format { get; set; }
	internal SerializationSource Source { get; }

	// Methods

	// RVA: 0x1682FF0 Offset: 0x16823F0 VA: 0x181682FF0
	internal void .ctor(string elementName, string ns) { }

	// RVA: 0x4A2EE0 Offset: 0x4A22E0 VA: 0x1804A2EE0
	public string get_ElementName() { }

	// RVA: 0x5DCC00 Offset: 0x5DC000 VA: 0x1805DCC00
	public string get_Namespace() { }

	// RVA: 0x4B94A0 Offset: 0x4B88A0 VA: 0x1804B94A0
	public void SetKey(string key) { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	internal ObjectMap get_ObjectMap() { }

	// RVA: 0x4B94C0 Offset: 0x4B88C0 VA: 0x1804B94C0
	internal void set_ObjectMap(ObjectMap value) { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	internal ArrayList get_RelatedMaps() { }

	// RVA: 0x4D0180 Offset: 0x4CF580 VA: 0x1804D0180
	internal void set_RelatedMaps(ArrayList value) { }

	// RVA: 0x4D0170 Offset: 0x4CF570 VA: 0x1804D0170
	internal SerializationFormat get_Format() { }

	// RVA: 0x69CC40 Offset: 0x69C040 VA: 0x18069CC40
	internal void set_Format(SerializationFormat value) { }

	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230
	internal SerializationSource get_Source() { }

}

public class XmlMembersMapping : XmlMapping // TypeDefIndex: 2085
{
// Namespace: System.Xml.Serialization
[DefaultMemberAttribute] // RVA: 0x70A90 Offset: 0x6FE90 VA: 0x180070A90
public class XmlMembersMapping : XmlMapping // TypeDefIndex: 2085
	// Fields
	private bool _hasWrapperElement; // 0x48
	private XmlMemberMapping[] _mapping; // 0x50

	// Properties
	public int Count { get; }
	internal bool HasWrapperElement { get; }

	// Methods

	// RVA: 0x1683040 Offset: 0x1682440 VA: 0x181683040
	public int get_Count() { }

	// RVA: 0x4B9270 Offset: 0x4B8670 VA: 0x1804B9270
	internal bool get_HasWrapperElement() { }

}

public class XmlNamespaceDeclarationsAttribute : Attribute // TypeDefIndex: 2086
{	// Methods

	// RVA: 0x7992B0 Offset: 0x7986B0 VA: 0x1807992B0
	public void .ctor() { }

}

public class XmlReflectionImporter // TypeDefIndex: 2087
{	// Fields
	private string initialDefaultNamespace; // 0x10
	private XmlAttributeOverrides attributeOverrides; // 0x18
	private ArrayList includedTypes; // 0x20
	private ReflectionHelper helper; // 0x28
	private int arrayChoiceCount; // 0x30
	private ArrayList relatedMaps; // 0x38
	private bool allowPrivateTypes; // 0x40
	private static readonly string errSimple; // 0x0
	private static readonly string errSimple2; // 0x8

	// Methods

	// RVA: 0x1689F70 Offset: 0x1689370 VA: 0x181689F70
	public void .ctor(XmlAttributeOverrides attributeOverrides, string defaultNamespace) { }

	// RVA: 0x1689420 Offset: 0x1688820 VA: 0x181689420
	public XmlTypeMapping ImportTypeMapping(Type type) { }

	// RVA: 0x1689440 Offset: 0x1688840 VA: 0x181689440
	public XmlTypeMapping ImportTypeMapping(Type type, string defaultNamespace) { }

	// RVA: 0x1689270 Offset: 0x1688670 VA: 0x181689270
	public XmlTypeMapping ImportTypeMapping(Type type, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x1688E90 Offset: 0x1688290 VA: 0x181688E90
	private XmlTypeMapping ImportTypeMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x1683CF0 Offset: 0x16830F0 VA: 0x181683CF0
	private XmlTypeMapping CreateTypeMapping(TypeData typeData, XmlRootAttribute root, string defaultXmlType, string defaultNamespace) { }

	// RVA: 0x1686520 Offset: 0x1685920 VA: 0x181686520
	private XmlTypeMapping ImportClassMapping(Type type, XmlRootAttribute root, string defaultNamespace, bool isBaseType = False) { }

	// RVA: 0x1685490 Offset: 0x1684890 VA: 0x181685490
	private XmlTypeMapping ImportClassMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace, bool isBaseType = False) { }

	// RVA: 0x1689DD0 Offset: 0x16891D0 VA: 0x181689DD0
	private void RegisterDerivedMap(XmlTypeMapping map, XmlTypeMapping derivedMap) { }

	// RVA: 0x1684EB0 Offset: 0x16842B0 VA: 0x181684EB0
	private string GetTypeNamespace(TypeData typeData, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x1688900 Offset: 0x1687D00 VA: 0x181688900
	private XmlTypeMapping ImportListMapping(Type type, XmlRootAttribute root, string defaultNamespace, XmlAttributes atts, int nestingLevel) { }

	// RVA: 0x1687CC0 Offset: 0x16870C0 VA: 0x181687CC0
	private XmlTypeMapping ImportListMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace, XmlAttributes atts, int nestingLevel) { }

	// RVA: 0x1689460 Offset: 0x1688860 VA: 0x181689460
	private XmlTypeMapping ImportXmlNodeMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x16889A0 Offset: 0x1687DA0 VA: 0x1816889A0
	private XmlTypeMapping ImportPrimitiveMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x1687520 Offset: 0x1686920 VA: 0x181687520
	private XmlTypeMapping ImportEnumMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x1689800 Offset: 0x1688C00 VA: 0x181689800
	private XmlTypeMapping ImportXmlSerializableMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x1687B80 Offset: 0x1686F80 VA: 0x181687B80
	private void ImportIncludedTypes(Type type, string defaultNamespace) { }

	// RVA: 0x1684300 Offset: 0x1683700 VA: 0x181684300
	private List<XmlReflectionMember> GetReflectionMembers(Type type) { }

	// RVA: 0x1683140 Offset: 0x1682540 VA: 0x181683140
	private XmlTypeMapMember CreateMapMember(Type declaringType, XmlReflectionMember rmember, string defaultNamespace) { }

	// RVA: 0x16865C0 Offset: 0x16859C0 VA: 0x1816865C0
	private XmlTypeMapElementInfoList ImportElementInfo(Type cls, string defaultName, string defaultNamespace, Type defaultType, XmlTypeMapMemberElement member, XmlAttributes atts) { }

	// RVA: 0x1684FC0 Offset: 0x16843C0 VA: 0x181684FC0
	private XmlTypeMapElementInfoList ImportAnyElementInfo(string defaultNamespace, XmlReflectionMember rmember, XmlTypeMapMemberElement member, XmlAttributes atts) { }

	// RVA: 0x1688B40 Offset: 0x1687F40 VA: 0x181688B40
	private void ImportTextElementInfo(XmlTypeMapElementInfoList list, Type defaultType, XmlTypeMapMemberElement member, XmlAttributes atts, string defaultNamespace) { }

	// RVA: 0x1683100 Offset: 0x1682500 VA: 0x181683100
	private bool CanBeNull(TypeData type) { }

	// RVA: 0x16899F0 Offset: 0x1688DF0 VA: 0x1816899F0
	public void IncludeType(Type type) { }

	// RVA: 0x1684160 Offset: 0x1683560 VA: 0x181684160
	private object GetDefaultValue(TypeData typeData, object defaultValue) { }

	// RVA: 0x1689F00 Offset: 0x1689300 VA: 0x181689F00
	private static void .cctor() { }

}

private sealed class XmlReflectionImporter.<>c // TypeDefIndex: 2088
{	// Fields
	public static readonly XmlReflectionImporter.<>c <>9; // 0x0
	public static Comparison<XmlReflectionMember> <>9__28_0; // 0x8

	// Methods

	// RVA: 0x1682E60 Offset: 0x1682260 VA: 0x181682E60
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x1682D50 Offset: 0x1682150 VA: 0x181682D50
	internal int <ImportClassMapping>b__28_0(XmlReflectionMember m1, XmlReflectionMember m2) { }

}

public class XmlReflectionMember // TypeDefIndex: 2089
{	// Fields
	private bool isReturnValue; // 0x10
	private string memberName; // 0x18
	private Type memberType; // 0x20
	private XmlAttributes xmlAttributes; // 0x28
	private Type declaringType; // 0x30

	// Properties
	public bool IsReturnValue { get; }
	public string MemberName { get; }
	public Type MemberType { get; }
	public XmlAttributes XmlAttributes { get; }
	internal Type DeclaringType { get; set; }

	// Methods

	// RVA: 0x168A070 Offset: 0x1689470 VA: 0x18168A070
	internal void .ctor(string name, Type type, XmlAttributes attributes) { }

	// RVA: 0x497E20 Offset: 0x497220 VA: 0x180497E20
	public bool get_IsReturnValue() { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public string get_MemberName() { }

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	public Type get_MemberType() { }

	// RVA: 0x168A0E0 Offset: 0x16894E0 VA: 0x18168A0E0
	public XmlAttributes get_XmlAttributes() { }

	// RVA: 0x4A2EE0 Offset: 0x4A22E0 VA: 0x1804A2EE0
	internal Type get_DeclaringType() { }

	// RVA: 0x4A2F10 Offset: 0x4A2310 VA: 0x1804A2F10
	internal void set_DeclaringType(Type value) { }

}

public class XmlRootAttribute : Attribute // TypeDefIndex: 2090
{	// Fields
	private string dataType; // 0x10
	private string elementName; // 0x18
	private bool isNullable; // 0x20
	private string ns; // 0x28

	// Properties
	public string DataType { get; set; }
	public string ElementName { get; set; }
	public bool IsNullable { get; set; }
	public string Namespace { get; set; }

	// Methods

	// RVA: 0x168A200 Offset: 0x1689600 VA: 0x18168A200
	public void .ctor() { }

	// RVA: 0x168A210 Offset: 0x1689610 VA: 0x18168A210
	public void .ctor(string elementName) { }

	// RVA: 0x168A250 Offset: 0x1689650 VA: 0x18168A250
	public string get_DataType() { }

	// RVA: 0x4B94C0 Offset: 0x4B88C0 VA: 0x1804B94C0
	public void set_DataType(string value) { }

	// RVA: 0x168A2A0 Offset: 0x16896A0 VA: 0x18168A2A0
	public string get_ElementName() { }

	// RVA: 0x4D0180 Offset: 0x4CF580 VA: 0x1804D0180
	public void set_ElementName(string value) { }

	// RVA: 0xB0BB80 Offset: 0xB0AF80 VA: 0x180B0BB80
	public bool get_IsNullable() { }

	// RVA: 0x7D99E0 Offset: 0x7D8DE0 VA: 0x1807D99E0
	public void set_IsNullable(bool value) { }

	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230
	public string get_Namespace() { }

	// RVA: 0x7CE240 Offset: 0x7CD640 VA: 0x1807CE240
	public void set_Namespace(string value) { }

	// RVA: 0x168A150 Offset: 0x1689550 VA: 0x18168A150
	internal void AddKeyHash(StringBuilder sb) { }

}

public sealed class XmlSchemaProviderAttribute : Attribute // TypeDefIndex: 2091
{	// Fields
	private string _methodName; // 0x10
	private bool _isAny; // 0x18

	// Properties
	public string MethodName { get; }
	public bool IsAny { get; set; }

	// Methods

	// RVA: 0x805E80 Offset: 0x805280 VA: 0x180805E80
	public void .ctor(string methodName) { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public string get_MethodName() { }

	// RVA: 0x95B2D0 Offset: 0x95A6D0 VA: 0x18095B2D0
	public bool get_IsAny() { }

	// RVA: 0x95B2F0 Offset: 0x95A6F0 VA: 0x18095B2F0
	public void set_IsAny(bool value) { }

}

public sealed class XmlSerializationCollectionFixupCallback : MulticastDelegate // TypeDefIndex: 2092
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x168AB50 Offset: 0x1689F50 VA: 0x18168AB50 Slot: 12
	public virtual void Invoke(object collection, object collectionItems) { }

	// RVA: 0xADFD10 Offset: 0xADF110 VA: 0x180ADFD10 Slot: 13
	public virtual IAsyncResult BeginInvoke(object collection, object collectionItems, AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class XmlSerializationFixupCallback : MulticastDelegate // TypeDefIndex: 2093
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1424130 Offset: 0x1423530 VA: 0x181424130 Slot: 12
	public virtual void Invoke(object fixup) { }

	// RVA: 0x497210 Offset: 0x496610 VA: 0x180497210 Slot: 13
	public virtual IAsyncResult BeginInvoke(object fixup, AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public abstract class XmlSerializationGeneratedCode // TypeDefIndex: 2094
{	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	protected void .ctor() { }

}

public sealed class XmlSerializationReadCallback : MulticastDelegate // TypeDefIndex: 2095
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xD38490 Offset: 0xD37890 VA: 0x180D38490 Slot: 12
	public virtual object Invoke() { }

	// RVA: 0x497020 Offset: 0x496420 VA: 0x180497020 Slot: 13
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual object EndInvoke(IAsyncResult result) { }

}

public abstract class XmlSerializationReader : XmlSerializationGeneratedCode // TypeDefIndex: 2096
{	// Fields
	private XmlDocument document; // 0x10
	private XmlReader reader; // 0x18
	private ArrayList fixups; // 0x20
	private Hashtable collFixups; // 0x28
	private ArrayList collItemFixups; // 0x30
	private Hashtable typesCallbacks; // 0x38
	private ArrayList noIDTargets; // 0x40
	private Hashtable targets; // 0x48
	private Hashtable delayedListFixups; // 0x50
	private XmlSerializer eventSource; // 0x58
	private int delayedFixupId; // 0x60
	private Hashtable referencedObjects; // 0x68
	private int readCount; // 0x70
	private int whileIterationCount; // 0x74
	private string w3SchemaNS; // 0x78
	private string w3InstanceNS; // 0x80
	private string w3InstanceNS2000; // 0x88
	private string w3InstanceNS1999; // 0x90
	private string soapNS; // 0x98
	private string wsdlNS; // 0xA0
	private string nullX; // 0xA8
	private string nil; // 0xB0
	private string typeX; // 0xB8
	private string arrayType; // 0xC0
	private XmlQualifiedName arrayQName; // 0xC8

	// Properties
	protected XmlDocument Document { get; }
	protected XmlReader Reader { get; }

	// Methods

	// RVA: 0x1692E60 Offset: 0x1692260 VA: 0x181692E60
	internal void Initialize(XmlReader reader, XmlSerializer eventSource) { }

	// RVA: 0x1692910 Offset: 0x1691D10 VA: 0x181692910
	private ArrayList EnsureArrayList(ArrayList list) { }

	// RVA: 0x1692960 Offset: 0x1691D60 VA: 0x181692960
	private Hashtable EnsureHashtable(Hashtable hash) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	protected void .ctor() { }

	// RVA: 0x1696C20 Offset: 0x1696020 VA: 0x181696C20
	protected XmlDocument get_Document() { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	protected XmlReader get_Reader() { }

	// RVA: 0x1691E50 Offset: 0x1691250 VA: 0x181691E50
	protected void AddFixup(XmlSerializationReader.CollectionFixup fixup) { }

	// RVA: 0x1691F70 Offset: 0x1691370 VA: 0x181691F70
	protected void AddFixup(XmlSerializationReader.Fixup fixup) { }

	// RVA: 0x1691DB0 Offset: 0x16911B0 VA: 0x181691DB0
	private void AddFixup(XmlSerializationReader.CollectionItemFixup fixup) { }

	// RVA: 0x1692010 Offset: 0x1691410 VA: 0x181692010
	protected void AddReadCallback(string name, string ns, Type type, XmlSerializationReadCallback read) { }

	// RVA: 0x1692170 Offset: 0x1691570 VA: 0x181692170
	protected void AddTarget(string id, object o) { }

	// RVA: 0x1692710 Offset: 0x1691B10 VA: 0x181692710
	private string CurrentTag() { }

	// RVA: 0x16922C0 Offset: 0x16916C0 VA: 0x1816922C0
	protected Exception CreateReadOnlyCollectionException(string name) { }

	// RVA: 0x1692330 Offset: 0x1691730 VA: 0x181692330
	protected Exception CreateUnknownConstantException(string value, Type enumType) { }

	// RVA: 0x16923A0 Offset: 0x16917A0 VA: 0x1816923A0
	protected Exception CreateUnknownNodeException() { }

	// RVA: 0x1692420 Offset: 0x1691820 VA: 0x181692420
	protected Exception CreateUnknownTypeException(XmlQualifiedName type) { }

	// RVA: 0x1692880 Offset: 0x1691C80 VA: 0x181692880
	protected Array EnsureArrayIndex(Array a, int index, Type elementType) { }

	// RVA: 0x1692AB0 Offset: 0x1691EB0 VA: 0x181692AB0
	protected bool GetNullAttr() { }

	// RVA: 0x1692B90 Offset: 0x1691F90 VA: 0x181692B90
	protected object GetTarget(string id) { }

	// RVA: 0x1696430 Offset: 0x1695830 VA: 0x181696430
	private bool TargetReady(string id) { }

	// RVA: 0x1692C60 Offset: 0x1692060 VA: 0x181692C60
	protected XmlQualifiedName GetXsiType() { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract void InitCallbacks();

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract void InitIDs();

	// RVA: 0x1693210 Offset: 0x1692610 VA: 0x181693210
	protected bool IsXmlnsAttribute(string name) { }

	// RVA: 0x1693680 Offset: 0x1692A80 VA: 0x181693680
	protected void ParseWsdlArrayType(XmlAttribute attr) { }

	// RVA: 0x1693820 Offset: 0x1692C20 VA: 0x181693820
	protected XmlQualifiedName ReadElementQualifiedName() { }

	// RVA: 0x1693930 Offset: 0x1692D30 VA: 0x181693930
	protected void ReadEndElement() { }

	// RVA: 0x1693ED0 Offset: 0x16932D0 VA: 0x181693ED0
	protected bool ReadNull() { }

	// RVA: 0x1694130 Offset: 0x1693530 VA: 0x181694130
	protected XmlQualifiedName ReadNullableQualifiedName() { }

	// RVA: 0x1694160 Offset: 0x1693560 VA: 0x181694160
	protected string ReadNullableString() { }

	// RVA: 0x16941B0 Offset: 0x16935B0 VA: 0x1816941B0
	protected object ReadReferencedElement() { }

	// RVA: 0x16929B0 Offset: 0x1691DB0 VA: 0x1816929B0
	private XmlSerializationReader.WriteCallbackInfo GetCallbackInfo(XmlQualifiedName qname) { }

	// RVA: 0x1694220 Offset: 0x1693620 VA: 0x181694220
	protected object ReadReferencedElement(string name, string ns) { }

	// RVA: 0x16939F0 Offset: 0x1692DF0 VA: 0x1816939F0
	private bool ReadList(out object resultList) { }

	// RVA: 0x1694500 Offset: 0x1693900 VA: 0x181694500
	protected void ReadReferencedElements() { }

	// RVA: 0x16956D0 Offset: 0x1694AD0 VA: 0x1816956D0
	protected object ReadReferencingElement(out string fixupReference) { }

	// RVA: 0x16956B0 Offset: 0x1694AB0 VA: 0x1816956B0
	protected object ReadReferencingElement(string name, string ns, out string fixupReference) { }

	// RVA: 0x1695340 Offset: 0x1694740 VA: 0x181695340
	protected object ReadReferencingElement(string name, string ns, bool elementCanBeType, out string fixupReference) { }

	// RVA: 0x1695750 Offset: 0x1694B50 VA: 0x181695750
	protected IXmlSerializable ReadSerializable(IXmlSerializable serializable) { }

	// RVA: 0x16961C0 Offset: 0x16955C0 VA: 0x1816961C0
	protected object ReadTypedPrimitive(XmlQualifiedName type) { }

	// RVA: 0x1695940 Offset: 0x1694D40 VA: 0x181695940
	private object ReadTypedPrimitive(XmlQualifiedName qname, bool reportUnknown) { }

	// RVA: 0x1696300 Offset: 0x1695700 VA: 0x181696300
	protected XmlNode ReadXmlNode(bool wrapped) { }

	// RVA: 0x16961D0 Offset: 0x16955D0 VA: 0x1816961D0
	protected XmlDocument ReadXmlDocument(bool wrapped) { }

	// RVA: 0x1696370 Offset: 0x1695770 VA: 0x181696370
	protected Array ShrinkArray(Array a, int length, Type elementType, bool isNullable) { }

	// RVA: 0x1696450 Offset: 0x1695850 VA: 0x181696450
	protected XmlQualifiedName ToXmlQualifiedName(string value) { }

	// RVA: 0x1696670 Offset: 0x1695A70 VA: 0x181696670
	protected void UnknownAttribute(object o, XmlAttribute attr, string qnames) { }

	// RVA: 0x16968A0 Offset: 0x1695CA0 VA: 0x1816968A0
	protected void UnknownElement(object o, XmlElement elem, string qnames) { }

	// RVA: 0x168C370 Offset: 0x168B770 VA: 0x18168C370
	protected void UnknownNode(object o) { }

	// RVA: 0x1696B20 Offset: 0x1695F20 VA: 0x181696B20
	protected void UnknownNode(object o, string qnames) { }

	// RVA: 0x1693280 Offset: 0x1692680 VA: 0x181693280
	private void OnUnknownNode(XmlNode node, object o, string qnames) { }

	// RVA: 0x1696B90 Offset: 0x1695F90 VA: 0x181696B90
	protected void UnreferencedObject(string id, object o) { }

}

private class XmlSerializationReader.WriteCallbackInfo // TypeDefIndex: 2097
{	// Fields
	public Type Type; // 0x10
	public string TypeName; // 0x18
	public string TypeNs; // 0x20
	public XmlSerializationReadCallback Callback; // 0x28

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

private class XmlSerializationReader.CollectionItemFixup // TypeDefIndex: 2100
{	// Fields
	private Array list; // 0x10
	private int index; // 0x18
	private string id; // 0x20

	// Properties
	public Array Collection { get; }
	public int Index { get; }
	public string Id { get; }

	// Methods

	// RVA: 0xF59AC0 Offset: 0xF58EC0 VA: 0x180F59AC0
	public void .ctor(Array list, int index, string id) { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public Array get_Collection() { }

	// RVA: 0x4BE200 Offset: 0x4BD600 VA: 0x1804BE200
	public int get_Index() { }

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	public string get_Id() { }

}

internal class XmlSerializationReaderInterpreter : XmlSerializationReader // TypeDefIndex: 2101
{	// Fields
	private XmlMapping _typeMap; // 0xD0
	private SerializationFormat _format; // 0xD8
	private static readonly XmlQualifiedName AnyType; // 0x0
	private static readonly object[] empty_array; // 0x8

	// Methods

	// RVA: 0x1691D60 Offset: 0x1691160 VA: 0x181691D60
	public void .ctor(XmlMapping typeMap) { }

	// RVA: 0x168BFB0 Offset: 0x168B3B0 VA: 0x18168BFB0 Slot: 4
	protected override void InitCallbacks() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 5
	protected override void InitIDs() { }

	// RVA: 0x1690EF0 Offset: 0x16902F0 VA: 0x181690EF0
	public object ReadRoot() { }

	// RVA: 0x168CE70 Offset: 0x168C270 VA: 0x18168CE70
	private object ReadEncodedObject(XmlTypeMapping typeMap) { }

	// RVA: 0x16900D0 Offset: 0x168F4D0 VA: 0x1816900D0 Slot: 6
	protected virtual object ReadMessage(XmlMembersMapping typeMap) { }

	// RVA: 0x16911A0 Offset: 0x16905A0 VA: 0x1816911A0
	private object ReadRoot(XmlTypeMapping rootMap) { }

	// RVA: 0x1690A60 Offset: 0x168FE60 VA: 0x181690A60 Slot: 7
	protected virtual object ReadObject(XmlTypeMapping typeMap, bool isNullable, bool checkType) { }

	// RVA: 0x168CB70 Offset: 0x168BF70 VA: 0x18168CB70 Slot: 8
	protected virtual object ReadClassInstance(XmlTypeMapping typeMap, bool isNullable, bool checkType) { }

	// RVA: 0x168CAB0 Offset: 0x168BEB0 VA: 0x18168CAB0 Slot: 9
	protected virtual void ReadClassInstanceMembers(XmlTypeMapping typeMap, object ob) { }

	// RVA: 0x168C3E0 Offset: 0x168B7E0 VA: 0x18168C3E0
	private void ReadAttributeMembers(ClassMap map, object ob, bool isValueList) { }

	// RVA: 0x168D7E0 Offset: 0x168CBE0 VA: 0x18168D7E0
	private void ReadMembers(ClassMap map, object ob, bool isValueList, bool readBySoapOrder) { }

	// RVA: 0x16916C0 Offset: 0x1690AC0 VA: 0x1816916C0
	private void SetListMembersDefaults(ClassMap map, object ob, bool isValueList) { }

	// RVA: 0x168B750 Offset: 0x168AB50 VA: 0x18168B750
	internal void FixupMembers(ClassMap map, object obfixup, bool isValueList) { }

	// RVA: 0x168C370 Offset: 0x168B770 VA: 0x18168C370 Slot: 10
	protected virtual void ProcessUnknownAttribute(object target) { }

	// RVA: 0x168C370 Offset: 0x168B770 VA: 0x18168C370 Slot: 11
	protected virtual void ProcessUnknownElement(object target) { }

	// RVA: 0x168C2F0 Offset: 0x168B6F0 VA: 0x18168C2F0
	private bool IsReadOnly(XmlTypeMapMember member, TypeData memType, object ob, bool isValueList) { }

	// RVA: 0x1691AF0 Offset: 0x1690EF0 VA: 0x181691AF0
	private void SetMemberValue(XmlTypeMapMember member, object ob, object value, bool isValueList) { }

	// RVA: 0x16919F0 Offset: 0x1690DF0 VA: 0x1816919F0
	private void SetMemberValueFromAttr(XmlTypeMapMember member, object ob, object value, bool isValueList) { }

	// RVA: 0x168BDA0 Offset: 0x168B1A0 VA: 0x18168BDA0
	private object GetMemberValue(XmlTypeMapMember member, object ob, bool isValueList) { }

	// RVA: 0x16908A0 Offset: 0x168FCA0 VA: 0x1816908A0
	private object ReadObjectElement(XmlTypeMapElementInfo elem) { }

	// RVA: 0x1690D70 Offset: 0x1690170 VA: 0x181690D70
	private object ReadPrimitiveValue(XmlTypeMapElementInfo elem) { }

	// RVA: 0x168BE80 Offset: 0x168B280 VA: 0x18168BE80
	private object GetValueFromXmlString(string value, TypeData typeData, XmlTypeMapping typeMap) { }

	// RVA: 0x168D050 Offset: 0x168C450 VA: 0x18168D050
	private object ReadListElement(XmlTypeMapping typeMap, bool isNullable, object list, bool canCreateInstance) { }

	// RVA: 0x168D530 Offset: 0x168C930 VA: 0x18168D530
	private object ReadListString(XmlTypeMapping typeMap, string values) { }

	// RVA: 0x168AF50 Offset: 0x168A350 VA: 0x18168AF50
	private void AddListValue(TypeData listType, ref object list, int index, object value, bool canCreateInstance) { }

	// RVA: 0x168B680 Offset: 0x168AA80 VA: 0x18168B680
	private static object CreateInstance(Type type, bool nonPublic) { }

	// RVA: 0x168B610 Offset: 0x168AA10 VA: 0x18168B610
	private object CreateInstance(Type type) { }

	// RVA: 0x168B690 Offset: 0x168AA90 VA: 0x18168B690
	private object CreateList(Type listType) { }

	// RVA: 0x168C270 Offset: 0x168B670 VA: 0x18168C270
	private object InitializeList(TypeData listType) { }

	// RVA: 0x168B730 Offset: 0x168AB30 VA: 0x18168B730
	private void FillList(object list, object items) { }

	// RVA: 0x168B300 Offset: 0x168A700 VA: 0x18168B300
	private void CopyEnumerableList(object source, object dest) { }

	// RVA: 0x16912C0 Offset: 0x16906C0 VA: 0x1816912C0
	private object ReadXmlNodeElement(XmlTypeMapping typeMap, bool isNullable) { }

	// RVA: 0x16912F0 Offset: 0x16906F0 VA: 0x1816912F0
	private object ReadXmlNode(TypeData type, bool wrapped) { }

	// RVA: 0x1690CA0 Offset: 0x16900A0 VA: 0x181690CA0
	private object ReadPrimitiveElement(XmlTypeMapping typeMap, bool isNullable) { }

	// RVA: 0x168CFD0 Offset: 0x168C3D0 VA: 0x18168CFD0
	private object ReadEnumElement(XmlTypeMapping typeMap, bool isNullable) { }

	// RVA: 0x168BBD0 Offset: 0x168AFD0 VA: 0x18168BBD0
	private object GetEnumValue(XmlTypeMapping typeMap, string val) { }

	// RVA: 0x16914E0 Offset: 0x16908E0 VA: 0x1816914E0
	private object ReadXmlSerializableElement(XmlTypeMapping typeMap, bool isNullable) { }

	// RVA: 0x1691CC0 Offset: 0x16910C0 VA: 0x181691CC0
	private static void .cctor() { }

}

private class XmlSerializationReaderInterpreter.FixupCallbackInfo // TypeDefIndex: 2102
{	// Fields
	private XmlSerializationReaderInterpreter _sri; // 0x10
	private ClassMap _map; // 0x18
	private bool _isValueList; // 0x20

	// Methods

	// RVA: 0xFF6C00 Offset: 0xFF6000 VA: 0x180FF6C00
	public void .ctor(XmlSerializationReaderInterpreter sri, ClassMap map, bool isValueList) { }

	// RVA: 0x1682C30 Offset: 0x1682030 VA: 0x181682C30
	public void FixupMembers(object fixup) { }

}

private class XmlSerializationReaderInterpreter.ReaderCallbackInfo // TypeDefIndex: 2103
{	// Fields
	private XmlSerializationReaderInterpreter _sri; // 0x10
	private XmlTypeMapping _typeMap; // 0x18

	// Methods

	// RVA: 0x53C500 Offset: 0x53B900 VA: 0x18053C500
	public void .ctor(XmlSerializationReaderInterpreter sri, XmlTypeMapping typeMap) { }

	// RVA: 0x1682D10 Offset: 0x1682110 VA: 0x181682D10
	internal object ReadObject() { }

}

public sealed class XmlSerializationWriteCallback : MulticastDelegate // TypeDefIndex: 2104
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1424130 Offset: 0x1423530 VA: 0x181424130 Slot: 12
	public virtual void Invoke(object o) { }

	// RVA: 0x497210 Offset: 0x496610 VA: 0x180497210 Slot: 13
	public virtual IAsyncResult BeginInvoke(object o, AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public abstract class XmlSerializationWriter : XmlSerializationGeneratedCode // TypeDefIndex: 2105
{	// Fields
	private ObjectIDGenerator idGenerator; // 0x10
	private int qnameCount; // 0x18
	private bool topLevelElement; // 0x1C
	private ArrayList namespaces; // 0x20
	private XmlWriter writer; // 0x28
	private Queue referencedElements; // 0x30
	private Hashtable callbacks; // 0x38
	private Hashtable serializedObjects; // 0x40

	// Properties
	protected XmlWriter Writer { get; }

	// Methods

	// RVA: 0x169E940 Offset: 0x169DD40 VA: 0x18169E940
	protected void .ctor() { }

	// RVA: 0x169BE30 Offset: 0x169B230 VA: 0x18169BE30
	internal void Initialize(XmlWriter writer, XmlSerializerNamespaces nss) { }

	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230
	protected XmlWriter get_Writer() { }

	// RVA: 0x169B660 Offset: 0x169AA60 VA: 0x18169B660
	protected void AddWriteCallback(Type type, string typeName, string typeNs, XmlSerializationWriteCallback callback) { }

	// RVA: 0x169B840 Offset: 0x169AC40 VA: 0x18169B840
	protected Exception CreateUnknownAnyElementException(string name, string ns) { }

	// RVA: 0x169B920 Offset: 0x169AD20 VA: 0x18169B920
	protected Exception CreateUnknownTypeException(object o) { }

	// RVA: 0x169B8B0 Offset: 0x169ACB0 VA: 0x18169B8B0
	protected Exception CreateUnknownTypeException(Type type) { }

	// RVA: 0x169B9B0 Offset: 0x169ADB0 VA: 0x18169B9B0
	protected string FromXmlQualifiedName(XmlQualifiedName xmlQualifiedName) { }

	// RVA: 0x169BA90 Offset: 0x169AE90 VA: 0x18169BA90
	private string GetId(object o, bool addToReferencesList) { }

	// RVA: 0x169B780 Offset: 0x169AB80 VA: 0x18169B780
	private bool AlreadyQueued(object ob) { }

	// RVA: 0x169BB90 Offset: 0x169AF90 VA: 0x18169BB90
	private string GetNamespacePrefix(string ns) { }

	// RVA: 0x169BCA0 Offset: 0x169B0A0 VA: 0x18169BCA0
	private string GetQualifiedName(string name, string ns) { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract void InitCallbacks();

	// RVA: 0x169C060 Offset: 0x169B460 VA: 0x18169C060
	protected void TopLevelElement() { }

	// RVA: 0x169C340 Offset: 0x169B740 VA: 0x18169C340
	protected void WriteAttribute(string localName, string ns, string value) { }

	// RVA: 0x169C300 Offset: 0x169B700 VA: 0x18169C300
	protected void WriteAttribute(string prefix, string localName, string ns, string value) { }

	// RVA: 0x169E740 Offset: 0x169DB40 VA: 0x18169E740
	private void WriteXmlNode(XmlNode node) { }

	// RVA: 0x169C380 Offset: 0x169B780 VA: 0x18169C380
	protected void WriteElementEncoded(XmlNode node, string name, string ns, bool isNullable, bool any) { }

	// RVA: 0x169C470 Offset: 0x169B870 VA: 0x18169C470
	protected void WriteElementLiteral(XmlNode node, string name, string ns, bool isNullable, bool any) { }

	// RVA: 0x169C560 Offset: 0x169B960 VA: 0x18169C560
	protected void WriteElementQualifiedName(string localName, string ns, XmlQualifiedName value) { }

	// RVA: 0x169C580 Offset: 0x169B980 VA: 0x18169C580
	protected void WriteElementQualifiedName(string localName, string ns, XmlQualifiedName value, XmlQualifiedName xsiType) { }

	// RVA: 0x169C760 Offset: 0x169BB60 VA: 0x18169C760
	protected void WriteElementString(string localName, string ns, string value) { }

	// RVA: 0x169C780 Offset: 0x169BB80 VA: 0x18169C780
	protected void WriteElementString(string localName, string ns, string value, XmlQualifiedName xsiType) { }

	// RVA: 0xBA0100 Offset: 0xB9F500 VA: 0x180BA0100
	protected void WriteEndElement() { }

	// RVA: 0x169C8F0 Offset: 0x169BCF0 VA: 0x18169C8F0
	protected void WriteEndElement(object o) { }

	// RVA: 0x169C940 Offset: 0x169BD40 VA: 0x18169C940
	protected void WriteNamespaceDeclarations(XmlSerializerNamespaces xmlns) { }

	// RVA: 0x169CE00 Offset: 0x169C200 VA: 0x18169CE00
	protected void WriteNullableQualifiedNameEncoded(string name, string ns, XmlQualifiedName value, XmlQualifiedName xsiType) { }

	// RVA: 0x169CEB0 Offset: 0x169C2B0 VA: 0x18169CEB0
	protected void WriteNullableQualifiedNameLiteral(string name, string ns, XmlQualifiedName value) { }

	// RVA: 0x169CF60 Offset: 0x169C360 VA: 0x18169CF60
	protected void WriteNullableStringEncoded(string name, string ns, string value, XmlQualifiedName xsiType) { }

	// RVA: 0x169CF80 Offset: 0x169C380 VA: 0x18169CF80
	protected void WriteNullableStringLiteral(string name, string ns, string value) { }

	// RVA: 0x169CC90 Offset: 0x169C090 VA: 0x18169CC90
	protected void WriteNullTagEncoded(string name, string ns) { }

	// RVA: 0x169CD40 Offset: 0x169C140 VA: 0x18169CD40
	protected void WriteNullTagLiteral(string name, string ns) { }

	// RVA: 0x169CFB0 Offset: 0x169C3B0 VA: 0x18169CFB0
	protected void WritePotentiallyReferencingElement(string n, string ns, object o, Type ambientType, bool suppressReference, bool isNullable) { }

	// RVA: 0x169D410 Offset: 0x169C810 VA: 0x18169D410
	protected void WriteReferencedElements() { }

	// RVA: 0x169BF60 Offset: 0x169B360 VA: 0x18169BF60
	private bool IsPrimitiveArray(TypeData td) { }

	// RVA: 0x169C070 Offset: 0x169B470 VA: 0x18169C070
	private void WriteArray(object o, TypeData td) { }

	// RVA: 0x169D670 Offset: 0x169CA70 VA: 0x18169D670
	protected void WriteReferencingElement(string n, string ns, object o, bool isNullable) { }

	// RVA: 0x169B7C0 Offset: 0x169ABC0 VA: 0x18169B7C0
	private void CheckReferenceQueue() { }

	// RVA: 0x169D7C0 Offset: 0x169CBC0 VA: 0x18169D7C0
	protected void WriteSerializable(IXmlSerializable serializable, string name, string ns, bool isNullable) { }

	// RVA: 0x169D8F0 Offset: 0x169CCF0 VA: 0x18169D8F0
	protected void WriteSerializable(IXmlSerializable serializable, string name, string ns, bool isNullable, bool wrapped) { }

	// RVA: 0x169DA30 Offset: 0x169CE30 VA: 0x18169DA30
	protected void WriteStartDocument() { }

	// RVA: 0x169E110 Offset: 0x169D510 VA: 0x18169E110
	protected void WriteStartElement(string name, string ns) { }

	// RVA: 0x169E0B0 Offset: 0x169D4B0 VA: 0x18169E0B0
	protected void WriteStartElement(string name, string ns, bool writePrefixed) { }

	// RVA: 0x169E0E0 Offset: 0x169D4E0 VA: 0x18169E0E0
	protected void WriteStartElement(string name, string ns, object o) { }

	// RVA: 0x169DA90 Offset: 0x169CE90 VA: 0x18169DA90
	protected void WriteStartElement(string name, string ns, object o, bool writePrefixed) { }

	// RVA: 0x169DAC0 Offset: 0x169CEC0 VA: 0x18169DAC0
	private void WriteStartElement(string name, string ns, object o, bool writePrefixed, ICollection namespaces) { }

	// RVA: 0x169E140 Offset: 0x169D540 VA: 0x18169E140
	protected void WriteTypedPrimitive(string name, string ns, object o, bool xsiType) { }

	// RVA: 0x169E460 Offset: 0x169D860 VA: 0x18169E460
	protected void WriteValue(string value) { }

	// RVA: 0x169E4A0 Offset: 0x169D8A0 VA: 0x18169E4A0
	protected void WriteXmlAttribute(XmlNode node, object container) { }

	// RVA: 0x169E870 Offset: 0x169DC70 VA: 0x18169E870
	protected void WriteXsiType(string name, string ns) { }

}

private class XmlSerializationWriter.WriteCallbackInfo // TypeDefIndex: 2106
{	// Fields
	public Type Type; // 0x10
	public string TypeName; // 0x18
	public string TypeNs; // 0x20
	public XmlSerializationWriteCallback Callback; // 0x28

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

internal class XmlSerializationWriterInterpreter : XmlSerializationWriter // TypeDefIndex: 2107
{	// Fields
	private XmlMapping _typeMap; // 0x48
	private SerializationFormat _format; // 0x50

	// Methods

	// RVA: 0x169B5C0 Offset: 0x169A9C0 VA: 0x18169B5C0
	public void .ctor(XmlMapping typeMap) { }

	// RVA: 0x1697630 Offset: 0x1696A30 VA: 0x181697630 Slot: 4
	protected override void InitCallbacks() { }

	// RVA: 0x169B320 Offset: 0x169A720 VA: 0x18169B320
	public void WriteRoot(object ob) { }

	// RVA: 0x169A610 Offset: 0x1699A10 VA: 0x18169A610 Slot: 5
	protected virtual void WriteObject(XmlTypeMapping typeMap, object ob, string element, string namesp, bool isNullable, bool needType, bool writeWrappingElem) { }

	// RVA: 0x169A140 Offset: 0x1699540 VA: 0x18169A140 Slot: 6
	protected virtual void WriteMessage(XmlMembersMapping membersMap, object[] parameters) { }

	// RVA: 0x169A4C0 Offset: 0x16998C0 VA: 0x18169A4C0 Slot: 7
	protected virtual void WriteObjectElement(XmlTypeMapping typeMap, object ob, string element, string namesp) { }

	// RVA: 0x169A340 Offset: 0x1699740 VA: 0x18169A340 Slot: 8
	protected virtual void WriteObjectElementAttributes(XmlTypeMapping typeMap, object ob) { }

	// RVA: 0x169A400 Offset: 0x1699800 VA: 0x18169A400 Slot: 9
	protected virtual void WriteObjectElementElements(XmlTypeMapping typeMap, object ob) { }

	// RVA: 0x169A0E0 Offset: 0x16994E0 VA: 0x18169A0E0
	private void WriteMembers(ClassMap map, object ob, bool isValueList) { }

	// RVA: 0x1698420 Offset: 0x1697820 VA: 0x181698420
	private void WriteAttributeMembers(ClassMap map, object ob, bool isValueList) { }

	// RVA: 0x1698B90 Offset: 0x1697F90 VA: 0x181698B90
	private void WriteElementMembers(ClassMap map, object ob, bool isValueList) { }

	// RVA: 0x1696F50 Offset: 0x1696350 VA: 0x181696F50
	private object GetMemberValue(XmlTypeMapMember member, object ob, bool isValueList) { }

	// RVA: 0x16978F0 Offset: 0x1696CF0 VA: 0x1816978F0
	private bool MemberHasValue(XmlTypeMapMember member, object ob, bool isValueList) { }

	// RVA: 0x1699A40 Offset: 0x1698E40 VA: 0x181699A40
	private void WriteMemberElement(XmlTypeMapElementInfo elem, object memberValue) { }

	// RVA: 0x1697280 Offset: 0x1696680 VA: 0x181697280
	internal static object ImplicitConvert(object obj, Type type) { }

	// RVA: 0x169B020 Offset: 0x169A420 VA: 0x18169B020
	private void WritePrimitiveValueLiteral(object memberValue, string name, string ns, XmlTypeMapping mappedType, TypeData typeData, bool wrapped, bool isNullable) { }

	// RVA: 0x169ACF0 Offset: 0x169A0F0 VA: 0x18169ACF0
	private void WritePrimitiveValueEncoded(object memberValue, string name, string ns, XmlQualifiedName xsiType, XmlTypeMapping mappedType, TypeData typeData, bool wrapped, bool isNullable) { }

	// RVA: 0x16997E0 Offset: 0x1698BE0 VA: 0x1816997E0 Slot: 10
	protected virtual void WriteListElement(XmlTypeMapping typeMap, object ob, string element, string namesp) { }

	// RVA: 0x1699170 Offset: 0x1698570 VA: 0x181699170
	private void WriteListContent(object container, TypeData listType, ListMap map, object ob, StringBuilder targetString) { }

	// RVA: 0x1696DE0 Offset: 0x16961E0 VA: 0x181696DE0
	private int GetListCount(TypeData listType, object ob) { }

	// RVA: 0x1697B40 Offset: 0x1696F40 VA: 0x181697B40
	private void WriteAnyElementContent(XmlTypeMapMemberAnyElement member, object memberValue) { }

	// RVA: 0x169ACA0 Offset: 0x169A0A0 VA: 0x18169ACA0 Slot: 11
	protected virtual void WritePrimitiveElement(XmlTypeMapping typeMap, object ob, string element, string namesp) { }

	// RVA: 0x1699130 Offset: 0x1698530 VA: 0x181699130 Slot: 12
	protected virtual void WriteEnumElement(XmlTypeMapping typeMap, object ob, string element, string namesp) { }

	// RVA: 0x1697030 Offset: 0x1696430 VA: 0x181697030
	private string GetStringValue(XmlTypeMapping typeMap, TypeData type, object value) { }

	// RVA: 0x1696CC0 Offset: 0x16960C0 VA: 0x181696CC0
	private string GetEnumXmlValue(XmlTypeMapping typeMap, object ob) { }

}

private class XmlSerializationWriterInterpreter.CallbackInfo // TypeDefIndex: 2108
{	// Fields
	private XmlSerializationWriterInterpreter _swi; // 0x10
	private XmlTypeMapping _typeMap; // 0x18

	// Methods

	// RVA: 0x53C500 Offset: 0x53B900 VA: 0x18053C500
	public void .ctor(XmlSerializationWriterInterpreter swi, XmlTypeMapping typeMap) { }

	// RVA: 0xE47BE0 Offset: 0xE46FE0 VA: 0x180E47BE0
	internal void WriteObject(object ob) { }

	// RVA: 0xE47B80 Offset: 0xE46F80 VA: 0x180E47B80
	internal void WriteEnum(object ob) { }

}

public class XmlSerializer // TypeDefIndex: 2109
{	// Fields
	private static int generationThreshold; // 0x0
	private static bool backgroundGeneration; // 0x4
	private static bool deleteTempFiles; // 0x5
	private static bool generatorFallback; // 0x6
	private bool customSerializer; // 0x10
	private XmlMapping typeMapping; // 0x18
	private XmlSerializer.SerializerData serializerData; // 0x20
	private static Hashtable serializerTypes; // 0x8
	private UnreferencedObjectEventHandler onUnreferencedObject; // 0x28
	private XmlAttributeEventHandler onUnknownAttribute; // 0x30
	private XmlElementEventHandler onUnknownElement; // 0x38
	private XmlNodeEventHandler onUnknownNode; // 0x40
	private static Encoding DefaultEncoding; // 0x10

	// Properties
	internal XmlMapping Mapping { get; }

	// Methods

	// RVA: 0xE631E0 Offset: 0xE625E0 VA: 0x180E631E0
	private static void .cctor() { }

	// RVA: 0xE63450 Offset: 0xE62850 VA: 0x180E63450
	public void .ctor(Type type) { }

	// RVA: 0xE632D0 Offset: 0xE626D0 VA: 0x180E632D0
	public void .ctor(Type type, XmlAttributeOverrides overrides, Type[] extraTypes, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	internal XmlMapping get_Mapping() { }

	// RVA: 0xE62BD0 Offset: 0xE61FD0 VA: 0x180E62BD0 Slot: 4
	internal virtual void OnUnknownAttribute(XmlAttributeEventArgs e) { }

	// RVA: 0xE62BF0 Offset: 0xE61FF0 VA: 0x180E62BF0 Slot: 5
	internal virtual void OnUnknownElement(XmlElementEventArgs e) { }

	// RVA: 0xE62C10 Offset: 0xE62010 VA: 0x180E62C10 Slot: 6
	internal virtual void OnUnknownNode(XmlNodeEventArgs e) { }

	// RVA: 0xE62C30 Offset: 0xE62030 VA: 0x180E62C30 Slot: 7
	internal virtual void OnUnreferencedObject(UnreferencedObjectEventArgs e) { }

	// RVA: 0xE623C0 Offset: 0xE617C0 VA: 0x180E623C0 Slot: 8
	protected virtual XmlSerializationReader CreateReader() { }

	// RVA: 0xE62470 Offset: 0xE61870 VA: 0x180E62470 Slot: 9
	protected virtual XmlSerializationWriter CreateWriter() { }

	// RVA: 0xE62AB0 Offset: 0xE61EB0 VA: 0x180E62AB0
	public object Deserialize(TextReader textReader) { }

	// RVA: 0xE62770 Offset: 0xE61B70 VA: 0x180E62770
	public object Deserialize(XmlReader xmlReader) { }

	// RVA: 0xE62830 Offset: 0xE61C30 VA: 0x180E62830 Slot: 10
	protected virtual object Deserialize(XmlSerializationReader reader) { }

	// RVA: 0xE62F00 Offset: 0xE62300 VA: 0x180E62F00 Slot: 11
	protected virtual void Serialize(object o, XmlSerializationWriter writer) { }

	// RVA: 0xE63140 Offset: 0xE62540 VA: 0x180E63140
	public void Serialize(TextWriter textWriter, object o) { }

	// RVA: 0xE63120 Offset: 0xE62520 VA: 0x180E63120
	public void Serialize(XmlWriter xmlWriter, object o) { }

	// RVA: 0xE62C50 Offset: 0xE62050 VA: 0x180E62C50
	public void Serialize(XmlWriter xmlWriter, object o, XmlSerializerNamespaces namespaces) { }

	// RVA: 0xE624C0 Offset: 0xE618C0 VA: 0x180E624C0
	private XmlSerializationWriter CreateWriter(XmlMapping typeMapping) { }

	// RVA: 0xE62410 Offset: 0xE61810 VA: 0x180E62410
	private XmlSerializationReader CreateReader(XmlMapping typeMapping) { }

}

internal class XmlSerializer.SerializerData // TypeDefIndex: 2110
{	// Fields
	public MethodInfo ReaderMethod; // 0x10
	public Type WriterType; // 0x18
	public MethodInfo WriterMethod; // 0x20
	public XmlSerializerImplementation Implementation; // 0x28

	// Methods

	// RVA: 0xE47C40 Offset: 0xE47040 VA: 0x180E47C40
	public XmlSerializationWriter CreateWriter() { }

}

public class XmlSerializerFactory // TypeDefIndex: 2111
{	// Fields
	private static Hashtable serializersBySource; // 0x134C0

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0xE61720 Offset: 0xE60B20 VA: 0x180E61720
	public XmlSerializer CreateSerializer(Type type) { }

	// RVA: 0xE61750 Offset: 0xE60B50 VA: 0x180E61750
	public XmlSerializer CreateSerializer(Type type, XmlRootAttribute root) { }

	// RVA: 0xE61780 Offset: 0xE60B80 VA: 0x180E61780
	public XmlSerializer CreateSerializer(Type type, XmlAttributeOverrides overrides, Type[] extraTypes, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0xE61B00 Offset: 0xE60F00 VA: 0x180E61B00
	private static void .cctor() { }

}

public abstract class XmlSerializerImplementation // TypeDefIndex: 2112
{	// Properties
	public virtual XmlSerializationWriter Writer { get; }

	// Methods

	// RVA: 0xE61B60 Offset: 0xE60F60 VA: 0x180E61B60 Slot: 4
	public virtual XmlSerializationWriter get_Writer() { }

}

public class XmlTextAttribute : Attribute // TypeDefIndex: 2113
{	// Fields
	private string dataType; // 0x10
	private Type type; // 0x18

	// Properties
	public string DataType { get; }
	public Type Type { get; }

	// Methods

	// RVA: 0x7992B0 Offset: 0x7986B0 VA: 0x1807992B0
	public void .ctor() { }

	// RVA: 0xE63510 Offset: 0xE62910 VA: 0x180E63510
	public string get_DataType() { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public Type get_Type() { }

	// RVA: 0xE63480 Offset: 0xE62880 VA: 0x180E63480
	internal void AddKeyHash(StringBuilder sb) { }

}

public class XmlTypeAttribute : Attribute // TypeDefIndex: 2114
{	// Fields
	private bool includeInSchema; // 0x10
	private string ns; // 0x18
	private string typeName; // 0x20

	// Properties
	public bool IncludeInSchema { get; }
	public string Namespace { get; }
	public string TypeName { get; }

	// Methods

	// RVA: 0x497E20 Offset: 0x497220 VA: 0x180497E20
	public bool get_IncludeInSchema() { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public string get_Namespace() { }

	// RVA: 0xE63600 Offset: 0xE62A00 VA: 0x180E63600
	public string get_TypeName() { }

	// RVA: 0xE63560 Offset: 0xE62960 VA: 0x180E63560
	internal void AddKeyHash(StringBuilder sb) { }

}

internal class XmlTypeMapElementInfo // TypeDefIndex: 2115
{	// Fields
	private string _elementName; // 0x10
	private string _namespace; // 0x18
	private XmlSchemaForm _form; // 0x20
	private XmlTypeMapMember _member; // 0x28
	private object _choiceValue; // 0x30
	private bool _isNullable; // 0x38
	private int _nestingLevel; // 0x3C
	private XmlTypeMapping _mappedType; // 0x40
	private TypeData _type; // 0x48
	private bool _wrappedElement; // 0x50
	private int _explicitOrder; // 0x54

	// Properties
	public TypeData TypeData { get; }
	public object ChoiceValue { get; set; }
	public string ElementName { get; set; }
	public string Namespace { get; set; }
	public string DataTypeNamespace { get; }
	public string DataTypeName { get; }
	public XmlSchemaForm Form { get; set; }
	public XmlTypeMapping MappedType { get; set; }
	public bool IsNullable { get; set; }
	public XmlTypeMapMember Member { get; }
	public int NestingLevel { set; }
	public bool MultiReferenceType { get; }
	public bool WrappedElement { get; set; }
	public bool IsTextElement { get; set; }
	public bool IsUnnamedAnyElement { get; set; }
	public int ExplicitOrder { get; set; }

	// Methods

	// RVA: 0xE63800 Offset: 0xE62C00 VA: 0x180E63800
	public void .ctor(XmlTypeMapMember member, TypeData type) { }

	// RVA: 0x5DCCA0 Offset: 0x5DC0A0 VA: 0x1805DCCA0
	public TypeData get_TypeData() { }

	// RVA: 0x4A2EE0 Offset: 0x4A22E0 VA: 0x1804A2EE0
	public object get_ChoiceValue() { }

	// RVA: 0x4A2F10 Offset: 0x4A2310 VA: 0x1804A2F10
	public void set_ChoiceValue(object value) { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public string get_ElementName() { }

	// RVA: 0x4B94C0 Offset: 0x4B88C0 VA: 0x1804B94C0
	public void set_ElementName(string value) { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public string get_Namespace() { }

	// RVA: 0x4D0180 Offset: 0x4CF580 VA: 0x1804D0180
	public void set_Namespace(string value) { }

	// RVA: 0xE638F0 Offset: 0xE62CF0 VA: 0x180E638F0
	public string get_DataTypeNamespace() { }

	// RVA: 0xE638C0 Offset: 0xE62CC0 VA: 0x180E638C0
	public string get_DataTypeName() { }

	// RVA: 0x4D0170 Offset: 0x4CF570 VA: 0x1804D0170
	public XmlSchemaForm get_Form() { }

	// RVA: 0x69CC40 Offset: 0x69C040 VA: 0x18069CC40
	public void set_Form(XmlSchemaForm value) { }

	// RVA: 0x4B9440 Offset: 0x4B8840 VA: 0x1804B9440
	public XmlTypeMapping get_MappedType() { }

	// RVA: 0x4B94A0 Offset: 0x4B88A0 VA: 0x1804B94A0
	public void set_MappedType(XmlTypeMapping value) { }

	// RVA: 0x8B1120 Offset: 0x8B0520 VA: 0x1808B1120
	public bool get_IsNullable() { }

	// RVA: 0x78BED0 Offset: 0x78B2D0 VA: 0x18078BED0
	public void set_IsNullable(bool value) { }

	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230
	public XmlTypeMapMember get_Member() { }

	// RVA: 0x8B1150 Offset: 0x8B0550 VA: 0x1808B1150
	public void set_NestingLevel(int value) { }

	// RVA: 0xE63A00 Offset: 0xE62E00 VA: 0x180E63A00
	public bool get_MultiReferenceType() { }

	// RVA: 0x778E40 Offset: 0x778240 VA: 0x180778E40
	public bool get_WrappedElement() { }

	// RVA: 0xE63B70 Offset: 0xE62F70 VA: 0x180E63B70
	public void set_WrappedElement(bool value) { }

	// RVA: 0xE63970 Offset: 0xE62D70 VA: 0x180E63970
	public bool get_IsTextElement() { }

	// RVA: 0xE63A20 Offset: 0xE62E20 VA: 0x180E63A20
	public void set_IsTextElement(bool value) { }

	// RVA: 0xE639B0 Offset: 0xE62DB0 VA: 0x180E639B0
	public bool get_IsUnnamedAnyElement() { }

	// RVA: 0xE63AC0 Offset: 0xE62EC0 VA: 0x180E63AC0
	public void set_IsUnnamedAnyElement(bool value) { }

	// RVA: 0x5F8160 Offset: 0x5F7560 VA: 0x1805F8160
	public int get_ExplicitOrder() { }

	// RVA: 0xE63A10 Offset: 0xE62E10 VA: 0x180E63A10
	public void set_ExplicitOrder(int value) { }

	// RVA: 0xE636B0 Offset: 0xE62AB0 VA: 0x180E636B0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0xCC95C0 Offset: 0xCC89C0 VA: 0x180CC95C0 Slot: 2
	public override int GetHashCode() { }

}

internal class XmlTypeMapElementInfoList : ArrayList // TypeDefIndex: 2116
{	// Methods

	// RVA: 0xE63650 Offset: 0xE62A50 VA: 0x180E63650
	public void .ctor() { }

}

internal class XmlTypeMapMember // TypeDefIndex: 2117
{	// Fields
	private string _name; // 0x10
	private int _index; // 0x18
	private int _globalIndex; // 0x1C
	private int _specifiedGlobalIndex; // 0x20
	private TypeData _typeData; // 0x28
	private MemberInfo _member; // 0x30
	private MemberInfo _specifiedMember; // 0x38
	private MethodInfo _shouldSerialize; // 0x40
	private object _defaultValue; // 0x48
	private int _flags; // 0x50

	// Properties
	public string Name { get; set; }
	public object DefaultValue { get; set; }
	public TypeData TypeData { get; set; }
	public int Index { get; set; }
	public int GlobalIndex { get; set; }
	public bool IsOptionalValueType { get; set; }
	public bool IsReturnValue { get; set; }

	// Methods

	// RVA: 0xE65B70 Offset: 0xE64F70 VA: 0x180E65B70
	public void .ctor() { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public string get_Name() { }

	// RVA: 0x4B94C0 Offset: 0x4B88C0 VA: 0x1804B94C0
	public void set_Name(string value) { }

	// RVA: 0x5DCCA0 Offset: 0x5DC0A0 VA: 0x1805DCCA0
	public object get_DefaultValue() { }

	// RVA: 0x5F7050 Offset: 0x5F6450 VA: 0x1805F7050
	public void set_DefaultValue(object value) { }

	// RVA: 0xE651D0 Offset: 0xE645D0 VA: 0x180E651D0
	public bool IsReadOnly(Type type) { }

	// RVA: 0xE64A80 Offset: 0xE63E80 VA: 0x180E64A80
	public static object GetValue(object ob, string name) { }

	// RVA: 0xE64CB0 Offset: 0xE640B0 VA: 0x180E64CB0
	public object GetValue(object ob) { }

	// RVA: 0xE65700 Offset: 0xE64B00 VA: 0x180E65700
	public void SetValue(object ob, object value) { }

	// RVA: 0xE65930 Offset: 0xE64D30 VA: 0x180E65930
	public static void SetValue(object ob, string name, object value) { }

	// RVA: 0xE64EC0 Offset: 0xE642C0 VA: 0x180E64EC0
	private void InitMember(Type type) { }

	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230
	public TypeData get_TypeData() { }

	// RVA: 0x7CE240 Offset: 0x7CD640 VA: 0x1807CE240
	public void set_TypeData(TypeData value) { }

	// RVA: 0x4BE200 Offset: 0x4BD600 VA: 0x1804BE200
	public int get_Index() { }

	// RVA: 0x7E8E20 Offset: 0x7E8220 VA: 0x1807E8E20
	public void set_Index(int value) { }

	// RVA: 0x4BE1F0 Offset: 0x4BD5F0 VA: 0x1804BE1F0
	public int get_GlobalIndex() { }

	// RVA: 0x95B2E0 Offset: 0x95A6E0 VA: 0x18095B2E0
	public void set_GlobalIndex(int value) { }

	// RVA: 0xD80DD0 Offset: 0xD801D0 VA: 0x180D80DD0
	public bool get_IsOptionalValueType() { }

	// RVA: 0xE65C00 Offset: 0xE65000 VA: 0x180E65C00
	public void set_IsOptionalValueType(bool value) { }

	// RVA: 0xE65BF0 Offset: 0xE64FF0 VA: 0x180E65BF0
	public bool get_IsReturnValue() { }

	// RVA: 0xE65C20 Offset: 0xE65020 VA: 0x180E65C20
	public void set_IsReturnValue(bool value) { }

	// RVA: 0xE646A0 Offset: 0xE63AA0 VA: 0x180E646A0
	public void CheckOptionalValueType(Type type) { }

	// RVA: 0xE64720 Offset: 0xE63B20 VA: 0x180E64720
	public bool GetValueSpecified(object ob) { }

	// RVA: 0xE65310 Offset: 0xE64710 VA: 0x180E65310
	public void SetValueSpecified(object ob, bool value) { }

}

internal class XmlTypeMapMemberAttribute : XmlTypeMapMember // TypeDefIndex: 2118
{	// Fields
	private string _attributeName; // 0x58
	private string _namespace; // 0x60
	private XmlSchemaForm _form; // 0x68
	private XmlTypeMapping _mappedType; // 0x70

	// Properties
	public string AttributeName { get; set; }
	public string Namespace { get; set; }
	public XmlSchemaForm Form { set; }
	public XmlTypeMapping MappedType { get; set; }

	// Methods

	// RVA: 0xE64030 Offset: 0xE63430 VA: 0x180E64030
	public void .ctor() { }

	// RVA: 0x4CC340 Offset: 0x4CB740 VA: 0x1804CC340
	public string get_AttributeName() { }

	// RVA: 0x4CC360 Offset: 0x4CB760 VA: 0x1804CC360
	public void set_AttributeName(string value) { }

	// RVA: 0x54FB60 Offset: 0x54EF60 VA: 0x18054FB60
	public string get_Namespace() { }

	// RVA: 0x54FB70 Offset: 0x54EF70 VA: 0x18054FB70
	public void set_Namespace(string value) { }

	// RVA: 0x7E39B0 Offset: 0x7E2DB0 VA: 0x1807E39B0
	public void set_Form(XmlSchemaForm value) { }

	// RVA: 0x58DC30 Offset: 0x58D030 VA: 0x18058DC30
	public XmlTypeMapping get_MappedType() { }

	// RVA: 0x58DCC0 Offset: 0x58D0C0 VA: 0x18058DCC0
	public void set_MappedType(XmlTypeMapping value) { }

}

internal class XmlTypeMapMemberElement : XmlTypeMapMember // TypeDefIndex: 2119
{	// Fields
	private XmlTypeMapElementInfoList _elementInfo; // 0x58
	private string _choiceMember; // 0x60
	private bool _isTextCollector; // 0x68
	private TypeData _choiceTypeData; // 0x70

	// Properties
	public XmlTypeMapElementInfoList ElementInfo { get; set; }
	public string ChoiceMember { get; set; }
	public TypeData ChoiceTypeData { get; set; }
	public bool IsXmlTextCollector { get; set; }

	// Methods

	// RVA: 0xE63B80 Offset: 0xE62F80 VA: 0x180E63B80
	public void .ctor() { }

	// RVA: 0xE645E0 Offset: 0xE639E0 VA: 0x180E645E0
	public XmlTypeMapElementInfoList get_ElementInfo() { }

	// RVA: 0x4CC360 Offset: 0x4CB760 VA: 0x1804CC360
	public void set_ElementInfo(XmlTypeMapElementInfoList value) { }

	// RVA: 0x54FB60 Offset: 0x54EF60 VA: 0x18054FB60
	public string get_ChoiceMember() { }

	// RVA: 0x54FB70 Offset: 0x54EF70 VA: 0x18054FB70
	public void set_ChoiceMember(string value) { }

	// RVA: 0x58DC30 Offset: 0x58D030 VA: 0x18058DC30
	public TypeData get_ChoiceTypeData() { }

	// RVA: 0x58DCC0 Offset: 0x58D0C0 VA: 0x18058DCC0
	public void set_ChoiceTypeData(TypeData value) { }

	// RVA: 0xE64080 Offset: 0xE63480 VA: 0x180E64080
	public XmlTypeMapElementInfo FindElement(object ob, object memberValue) { }

	// RVA: 0xE645C0 Offset: 0xE639C0 VA: 0x180E645C0
	public void SetChoice(object ob, object choice) { }

	// RVA: 0x82A660 Offset: 0x829A60 VA: 0x18082A660
	public bool get_IsXmlTextCollector() { }

	// RVA: 0xE64690 Offset: 0xE63A90 VA: 0x180E64690
	public void set_IsXmlTextCollector(bool value) { }

}

internal class XmlTypeMapMemberList : XmlTypeMapMemberElement // TypeDefIndex: 2120
{	// Methods

	// RVA: 0xE63B80 Offset: 0xE62F80 VA: 0x180E63B80
	public void .ctor() { }

}

internal class XmlTypeMapMemberExpandable : XmlTypeMapMemberElement // TypeDefIndex: 2121
{	// Fields
	private int _flatArrayIndex; // 0x78

	// Properties
	public int FlatArrayIndex { get; set; }

	// Methods

	// RVA: 0xAF14F0 Offset: 0xAF08F0 VA: 0x180AF14F0
	public int get_FlatArrayIndex() { }

	// RVA: 0xB24460 Offset: 0xB23860 VA: 0x180B24460
	public void set_FlatArrayIndex(int value) { }

	// RVA: 0xE63B80 Offset: 0xE62F80 VA: 0x180E63B80
	public void .ctor() { }

}

internal class XmlTypeMapMemberFlatList : XmlTypeMapMemberExpandable // TypeDefIndex: 2122
{	// Fields
	private ListMap _listMap; // 0x80

	// Properties
	public ListMap ListMap { get; set; }

	// Methods

	// RVA: 0x58DC40 Offset: 0x58D040 VA: 0x18058DC40
	public ListMap get_ListMap() { }

	// RVA: 0x58DCD0 Offset: 0x58D0D0 VA: 0x18058DCD0
	public void set_ListMap(ListMap value) { }

	// RVA: 0xE63B80 Offset: 0xE62F80 VA: 0x180E63B80
	public void .ctor() { }

}

internal class XmlTypeMapMemberAnyElement : XmlTypeMapMemberExpandable // TypeDefIndex: 2123
{	// Properties
	public bool IsDefaultAny { get; }

	// Methods

	// RVA: 0xE63B90 Offset: 0xE62F90 VA: 0x180E63B90
	public bool IsElementDefined(string name, string ns) { }

	// RVA: 0xE63DE0 Offset: 0xE631E0 VA: 0x180E63DE0
	public bool get_IsDefaultAny() { }

	// RVA: 0xE63B80 Offset: 0xE62F80 VA: 0x180E63B80
	public void .ctor() { }

}

internal class XmlTypeMapMemberAnyAttribute : XmlTypeMapMember // TypeDefIndex: 2124
{	// Methods

	// RVA: 0xE63B80 Offset: 0xE62F80 VA: 0x180E63B80
	public void .ctor() { }

}

internal class XmlTypeMapMemberNamespaces : XmlTypeMapMember // TypeDefIndex: 2125
{	// Methods

	// RVA: 0xE63B80 Offset: 0xE62F80 VA: 0x180E63B80
	public void .ctor() { }

}

public class XmlTypeMapping : XmlMapping // TypeDefIndex: 2126
{	// Fields
	private string xmlType; // 0x48
	private string xmlTypeNamespace; // 0x50
	private TypeData type; // 0x58
	private XmlTypeMapping baseMap; // 0x60
	private bool multiReferenceType; // 0x68
	private bool includeInSchema; // 0x69
	private bool isNullable; // 0x6A
	private bool isAny; // 0x6B
	private ArrayList _derivedTypes; // 0x70

	// Properties
	public string TypeFullName { get; }
	internal TypeData TypeData { get; }
	internal string XmlType { get; set; }
	internal string XmlTypeNamespace { get; set; }
	internal bool HasXmlTypeNamespace { get; }
	internal ArrayList DerivedTypes { get; }
	internal bool MultiReferenceType { get; }
	internal XmlTypeMapping BaseMap { get; set; }
	internal bool IncludeInSchema { set; }
	internal bool IsNullable { get; set; }
	internal bool IsAny { get; set; }

	// Methods

	// RVA: 0xE660E0 Offset: 0xE654E0 VA: 0x180E660E0
	internal void .ctor(string elementName, string ns, TypeData typeData, string xmlType, string xmlTypeNamespace) { }

	// RVA: 0xE661D0 Offset: 0xE655D0 VA: 0x180E661D0
	public string get_TypeFullName() { }

	// RVA: 0x4CC340 Offset: 0x4CB740 VA: 0x1804CC340
	internal TypeData get_TypeData() { }

	// RVA: 0x5DCCA0 Offset: 0x5DC0A0 VA: 0x1805DCCA0
	internal string get_XmlType() { }

	// RVA: 0x5F7050 Offset: 0x5F6450 VA: 0x1805F7050
	internal void set_XmlType(string value) { }

	// RVA: 0xE661F0 Offset: 0xE655F0 VA: 0x180E661F0
	internal string get_XmlTypeNamespace() { }

	// RVA: 0x4CC370 Offset: 0x4CB770 VA: 0x1804CC370
	internal void set_XmlTypeNamespace(string value) { }

	// RVA: 0xE661B0 Offset: 0xE655B0 VA: 0x180E661B0
	internal bool get_HasXmlTypeNamespace() { }

	// RVA: 0x58DC30 Offset: 0x58D030 VA: 0x18058DC30
	internal ArrayList get_DerivedTypes() { }

	// RVA: 0x82A660 Offset: 0x829A60 VA: 0x18082A660
	internal bool get_MultiReferenceType() { }

	// RVA: 0x54FB60 Offset: 0x54EF60 VA: 0x18054FB60
	internal XmlTypeMapping get_BaseMap() { }

	// RVA: 0x54FB70 Offset: 0x54EF70 VA: 0x18054FB70
	internal void set_BaseMap(XmlTypeMapping value) { }

	// RVA: 0xB9D7D0 Offset: 0xB9CBD0 VA: 0x180B9D7D0
	internal void set_IncludeInSchema(bool value) { }

	// RVA: 0xB9D240 Offset: 0xB9C640 VA: 0x180B9D240
	internal bool get_IsNullable() { }

	// RVA: 0xB9D5A0 Offset: 0xB9C9A0 VA: 0x180B9D5A0
	internal void set_IsNullable(bool value) { }

	// RVA: 0xE661C0 Offset: 0xE655C0 VA: 0x180E661C0
	internal bool get_IsAny() { }

	// RVA: 0xE66240 Offset: 0xE65640 VA: 0x180E66240
	internal void set_IsAny(bool value) { }

	// RVA: 0xE65EA0 Offset: 0xE652A0 VA: 0x180E65EA0
	internal XmlTypeMapping GetRealTypeMap(Type objectType) { }

	// RVA: 0xE65C40 Offset: 0xE65040 VA: 0x180E65C40
	internal XmlTypeMapping GetRealElementMap(string name, string ens) { }

	// RVA: 0xE66050 Offset: 0xE65450 VA: 0x180E66050
	internal void UpdateRoot(XmlQualifiedName qname) { }

}

public enum XmlSchemaDatatypeVariety // TypeDefIndex: 2174
{	// Fields
	public int value__; // 0x0
	public const XmlSchemaDatatypeVariety Atomic = 0;
	public const XmlSchemaDatatypeVariety List = 1;
	public const XmlSchemaDatatypeVariety Union = 2;

}

internal class XsdSimpleValue // TypeDefIndex: 2175
{	// Fields
	private XmlSchemaSimpleType xmlType; // 0x10
	private object typedValue; // 0x18

	// Properties
	public XmlSchemaSimpleType XmlType { get; }
	public object TypedValue { get; }

	// Methods

	// RVA: 0x53C500 Offset: 0x53B900 VA: 0x18053C500
	public void .ctor(XmlSchemaSimpleType st, object value) { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public XmlSchemaSimpleType get_XmlType() { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public object get_TypedValue() { }

}

internal enum XmlSchemaWhiteSpace // TypeDefIndex: 2177
{	// Fields
	public int value__; // 0x0
	public const XmlSchemaWhiteSpace Preserve = 0;
	public const XmlSchemaWhiteSpace Replace = 1;
	public const XmlSchemaWhiteSpace Collapse = 2;

}

public sealed class XmlSchemaInference // TypeDefIndex: 2259
{	// Fields
	internal static XmlQualifiedName ST_boolean; // 0x0
	internal static XmlQualifiedName ST_byte; // 0x8
	internal static XmlQualifiedName ST_unsignedByte; // 0x10
	internal static XmlQualifiedName ST_short; // 0x18
	internal static XmlQualifiedName ST_unsignedShort; // 0x20
	internal static XmlQualifiedName ST_int; // 0x28
	internal static XmlQualifiedName ST_unsignedInt; // 0x30
	internal static XmlQualifiedName ST_long; // 0x38
	internal static XmlQualifiedName ST_unsignedLong; // 0x40
	internal static XmlQualifiedName ST_integer; // 0x48
	internal static XmlQualifiedName ST_decimal; // 0x50
	internal static XmlQualifiedName ST_float; // 0x58
	internal static XmlQualifiedName ST_double; // 0x60
	internal static XmlQualifiedName ST_duration; // 0x68
	internal static XmlQualifiedName ST_dateTime; // 0x70
	internal static XmlQualifiedName ST_time; // 0x78
	internal static XmlQualifiedName ST_date; // 0x80
	internal static XmlQualifiedName ST_gYearMonth; // 0x88
	internal static XmlQualifiedName ST_string; // 0x90
	internal static XmlQualifiedName ST_anySimpleType; // 0x98
	internal static XmlQualifiedName[] SimpleTypes; // 0xA0
	private XmlSchema rootSchema; // 0x10
	private XmlSchemaSet schemaSet; // 0x18
	private XmlReader xtr; // 0x20
	private NameTable nametable; // 0x28
	private string TargetNamespace; // 0x30
	private XmlNamespaceManager NamespaceManager; // 0x38
	private ArrayList schemaList; // 0x40
	private XmlSchemaInference.InferenceOption occurrence; // 0x48
	private XmlSchemaInference.InferenceOption typeInference; // 0x4C

	// Properties
	public XmlSchemaInference.InferenceOption Occurrence { get; set; }
	public XmlSchemaInference.InferenceOption TypeInference { set; }

	// Methods

	// RVA: 0x5B1C90 Offset: 0x5B1090 VA: 0x1805B1C90
	public void set_Occurrence(XmlSchemaInference.InferenceOption value) { }

	// RVA: 0x5B1C80 Offset: 0x5B1080 VA: 0x1805B1C80
	public XmlSchemaInference.InferenceOption get_Occurrence() { }

	// RVA: 0x5B3950 Offset: 0x5B2D50 VA: 0x1805B3950
	public void set_TypeInference(XmlSchemaInference.InferenceOption value) { }

	// RVA: 0x10570B0 Offset: 0x10564B0 VA: 0x1810570B0
	public void .ctor() { }

	// RVA: 0x10532D0 Offset: 0x10526D0 VA: 0x1810532D0
	public XmlSchemaSet InferSchema(XmlReader instanceDocument) { }

	// RVA: 0x1052B50 Offset: 0x1051F50 VA: 0x181052B50
	internal XmlSchemaSet InferSchema1(XmlReader instanceDocument, XmlSchemaSet schemas) { }

	// RVA: 0x104CD90 Offset: 0x104C190 VA: 0x18104CD90
	private XmlSchemaAttribute AddAttribute(string localName, string prefix, string childURI, string attrValue, bool bCreatingNewType, XmlSchema parentSchema, XmlSchemaObjectCollection addLocation, XmlSchemaObjectTable compiledAttributes) { }

	// RVA: 0x104E330 Offset: 0x104D730 VA: 0x18104E330
	private XmlSchema CreateXmlSchema(string targetNS) { }

	// RVA: 0x104D6B0 Offset: 0x104CAB0 VA: 0x18104D6B0
	private XmlSchemaElement AddElement(string localName, string prefix, string childURI, XmlSchema parentSchema, XmlSchemaObjectCollection addLocation, int positionWithinCollection) { }

	// RVA: 0x1051000 Offset: 0x1050400 VA: 0x181051000
	internal void InferElement(XmlSchemaElement xse, bool bCreatingNewType, XmlSchema parentSchema) { }

	// RVA: 0x104DE60 Offset: 0x104D260 VA: 0x18104DE60
	private XmlSchemaSimpleContentExtension CheckSimpleContentExtension(XmlSchemaComplexType ct) { }

	// RVA: 0x10501B0 Offset: 0x104F5B0 VA: 0x1810501B0
	private XmlSchemaType GetEffectiveSchemaType(XmlSchemaElement elem, bool bCreatingNewType) { }

	// RVA: 0x104EE00 Offset: 0x104E200 VA: 0x18104EE00
	internal XmlSchemaElement FindMatchingElement(bool bCreatingNewType, XmlReader xtr, XmlSchemaComplexType ct, ref int lastUsedSeqItem, ref bool bParticleChanged, XmlSchema parentSchema, bool setMaxoccurs) { }

	// RVA: 0x1054920 Offset: 0x1053D20 VA: 0x181054920
	internal void ProcessAttributes(ref XmlSchemaElement xse, XmlSchemaType effectiveSchemaType, bool bCreatingNewType, XmlSchema parentSchema) { }

	// RVA: 0x1054810 Offset: 0x1053C10 VA: 0x181054810
	private void MoveAttributes(XmlSchemaSimpleContentExtension scExtension, XmlSchemaComplexType ct) { }

	// RVA: 0x10544E0 Offset: 0x10538E0 VA: 0x1810544E0
	private void MoveAttributes(XmlSchemaComplexType ct, XmlSchemaSimpleContentExtension simpleContentExtension, bool bCreatingNewType) { }

	// RVA: 0x104E720 Offset: 0x104DB20 VA: 0x18104E720
	internal XmlSchemaAttribute FindAttribute(ICollection attributes, string attrName) { }

	// RVA: 0x104EBD0 Offset: 0x104DFD0 VA: 0x18104EBD0
	internal XmlSchemaElement FindGlobalElement(string namespaceURI, string localName, out XmlSchema parentSchema) { }

	// RVA: 0x104EA90 Offset: 0x104DE90 VA: 0x18104EA90
	internal XmlSchemaElement FindElement(XmlSchemaObjectCollection elements, string elementName) { }

	// RVA: 0x104E4C0 Offset: 0x104D8C0 VA: 0x18104E4C0
	internal XmlSchemaAttribute FindAttributeRef(ICollection attributes, string attributeName, string nsURI) { }

	// RVA: 0x104E930 Offset: 0x104DD30 VA: 0x18104E930
	internal XmlSchemaElement FindElementRef(XmlSchemaObjectCollection elements, string elementName, string nsURI) { }

	// RVA: 0x1054410 Offset: 0x1053810 VA: 0x181054410
	internal void MakeExistingAttributesOptional(XmlSchemaComplexType ct, XmlSchemaObjectCollection attributesInInstance) { }

	// RVA: 0x10561C0 Offset: 0x10555C0 VA: 0x1810561C0
	private void SwitchUseToOptional(XmlSchemaObjectCollection attributes, XmlSchemaObjectCollection attributesInInstance) { }

	// RVA: 0x10550B0 Offset: 0x10544B0 VA: 0x1810550B0
	internal XmlQualifiedName RefineSimpleType(string s, ref int iTypeFlags) { }

	// RVA: 0x1053350 Offset: 0x1052750 VA: 0x181053350
	internal static int InferSimpleType(string s, ref bool bNeedsRangeCheck) { }

	// RVA: 0x104E3D0 Offset: 0x104D7D0 VA: 0x18104E3D0
	internal static int DateTime(string s, bool bDate, bool bTime) { }

	// RVA: 0x104DFC0 Offset: 0x104D3C0 VA: 0x18104DFC0
	private XmlSchemaElement CreateNewElementforChoice(XmlSchemaElement copyElement) { }

	// RVA: 0x1050330 Offset: 0x104F730 VA: 0x181050330
	private static int GetSchemaType(XmlQualifiedName qname) { }

	// RVA: 0x1055FB0 Offset: 0x10553B0 VA: 0x181055FB0
	internal void SetMinMaxOccurs(XmlSchemaElement el, bool setMaxOccurs) { }

	// RVA: 0x1056300 Offset: 0x1055700 VA: 0x181056300
	private static void .cctor() { }

}

public enum XmlSchemaInference.InferenceOption // TypeDefIndex: 2260
{	// Fields
	public int value__; // 0x0
	public const XmlSchemaInference.InferenceOption Restricted = 0;
	public const XmlSchemaInference.InferenceOption Relaxed = 1;

}

public class XmlSchemaInferenceException : XmlSchemaException // TypeDefIndex: 2261
{	// Methods

	// RVA: 0xD22A50 Offset: 0xD21E50 VA: 0x180D22A50
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x104B770 Offset: 0x104AB70 VA: 0x18104B770 Slot: 10
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x104C490 Offset: 0x104B890 VA: 0x18104C490
	public void .ctor() { }

	// RVA: 0x104CC20 Offset: 0x104C020 VA: 0x18104CC20
	internal void .ctor(string res, string arg) { }

	// RVA: 0x104CD60 Offset: 0x104C160 VA: 0x18104CD60
	internal void .ctor(string res, int lineNumber, int linePosition) { }

}

public sealed class XmlAtomicValue : XPathItem, ICloneable // TypeDefIndex: 2303
{	// Fields
	private XmlSchemaType xmlType; // 0x10
	private object objVal; // 0x18
	private TypeCode clrType; // 0x20
	private XmlAtomicValue.Union unionVal; // 0x28
	private XmlAtomicValue.NamespacePrefixForQName nsPrefix; // 0x30

	// Properties
	public override XmlSchemaType XmlType { get; }
	public override Type ValueType { get; }
	public override object TypedValue { get; }
	public override bool ValueAsBoolean { get; }
	public override DateTime ValueAsDateTime { get; }
	public override double ValueAsDouble { get; }
	public override int ValueAsInt { get; }
	public override long ValueAsLong { get; }
	public override string Value { get; }

	// Methods

	// RVA: 0x142D180 Offset: 0x142C580 VA: 0x18142D180
	internal void .ctor(XmlSchemaType xmlType, bool value) { }

	// RVA: 0x142CF60 Offset: 0x142C360 VA: 0x18142CF60
	internal void .ctor(XmlSchemaType xmlType, DateTime value) { }

	// RVA: 0x142D4C0 Offset: 0x142C8C0 VA: 0x18142D4C0
	internal void .ctor(XmlSchemaType xmlType, double value) { }

	// RVA: 0x142D220 Offset: 0x142C620 VA: 0x18142D220
	internal void .ctor(XmlSchemaType xmlType, int value) { }

	// RVA: 0x142D0E0 Offset: 0x142C4E0 VA: 0x18142D0E0
	internal void .ctor(XmlSchemaType xmlType, long value) { }

	// RVA: 0x142D560 Offset: 0x142C960 VA: 0x18142D560
	internal void .ctor(XmlSchemaType xmlType, string value) { }

	// RVA: 0x142D2C0 Offset: 0x142C6C0 VA: 0x18142D2C0
	internal void .ctor(XmlSchemaType xmlType, string value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x142D000 Offset: 0x142C400 VA: 0x18142D000
	internal void .ctor(XmlSchemaType xmlType, object value) { }

	// RVA: 0x142D640 Offset: 0x142CA40 VA: 0x18142D640
	internal void .ctor(XmlSchemaType xmlType, object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x4B0E80 Offset: 0x4B0280 VA: 0x1804B0E80 Slot: 15
	private object System.ICloneable.Clone() { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460 Slot: 4
	public override XmlSchemaType get_XmlType() { }

	// RVA: 0x142DF40 Offset: 0x142D340 VA: 0x18142DF40 Slot: 7
	public override Type get_ValueType() { }

	// RVA: 0x142D850 Offset: 0x142CC50 VA: 0x18142D850 Slot: 6
	public override object get_TypedValue() { }

	// RVA: 0x142DA40 Offset: 0x142CE40 VA: 0x18142DA40 Slot: 8
	public override bool get_ValueAsBoolean() { }

	// RVA: 0x142DB40 Offset: 0x142CF40 VA: 0x18142DB40 Slot: 9
	public override DateTime get_ValueAsDateTime() { }

	// RVA: 0x142DC40 Offset: 0x142D040 VA: 0x18142DC40 Slot: 10
	public override double get_ValueAsDouble() { }

	// RVA: 0x142DD40 Offset: 0x142D140 VA: 0x18142DD40 Slot: 11
	public override int get_ValueAsInt() { }

	// RVA: 0x142DE40 Offset: 0x142D240 VA: 0x18142DE40 Slot: 12
	public override long get_ValueAsLong() { }

	// RVA: 0x142CD40 Offset: 0x142C140 VA: 0x18142CD40 Slot: 14
	public override object ValueAs(Type type, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x142DF80 Offset: 0x142D380 VA: 0x18142DF80 Slot: 5
	public override string get_Value() { }

	// RVA: 0x95B120 Offset: 0x95A520 VA: 0x18095B120 Slot: 3
	public override string ToString() { }

	// RVA: 0x142CC90 Offset: 0x142C090 VA: 0x18142CC90
	private string GetPrefixFromQName(string value) { }

}

private struct XmlAtomicValue.Union // TypeDefIndex: 2304
{	// Fields
	public bool boolVal; // 0x0
	public double dblVal; // 0x0
	public long i64Val; // 0x0
	public int i32Val; // 0x0
	public DateTime dtVal; // 0x0

}

private class XmlAtomicValue.NamespacePrefixForQName : IXmlNamespaceResolver // TypeDefIndex: 2305
{	// Fields
	public string prefix; // 0x10
	public string ns; // 0x18

	// Methods

	// RVA: 0x1424000 Offset: 0x1423400 VA: 0x181424000
	public void .ctor(string prefix, string ns) { }

	// RVA: 0x1423F90 Offset: 0x1423390 VA: 0x181423F90 Slot: 5
	public string LookupNamespace(string prefix) { }

	// RVA: 0x1423FD0 Offset: 0x14233D0 VA: 0x181423FD0 Slot: 6
	public string LookupPrefix(string namespaceName) { }

	// RVA: 0x1423F10 Offset: 0x1423310 VA: 0x181423F10 Slot: 4
	public IDictionary<string, string> GetNamespacesInScope(XmlNamespaceScope scope) { }

}

public class XmlSchema : XmlSchemaObject // TypeDefIndex: 2306
{	// Fields
	private XmlSchemaForm attributeFormDefault; // 0x38
	private XmlSchemaForm elementFormDefault; // 0x3C
	private XmlSchemaDerivationMethod blockDefault; // 0x40
	private XmlSchemaDerivationMethod finalDefault; // 0x44
	private string targetNs; // 0x48
	private string version; // 0x50
	private XmlSchemaObjectCollection includes; // 0x58
	private XmlSchemaObjectCollection items; // 0x60
	private string id; // 0x68
	private XmlAttribute[] moreAttributes; // 0x70
	private bool isCompiled; // 0x78
	private bool isCompiledBySet; // 0x79
	private bool isPreprocessed; // 0x7A
	private bool isRedefined; // 0x7B
	private int errorCount; // 0x7C
	private XmlSchemaObjectTable attributes; // 0x80
	private XmlSchemaObjectTable attributeGroups; // 0x88
	private XmlSchemaObjectTable elements; // 0x90
	private XmlSchemaObjectTable types; // 0x98
	private XmlSchemaObjectTable groups; // 0xA0
	private XmlSchemaObjectTable notations; // 0xA8
	private XmlSchemaObjectTable identityConstraints; // 0xB0
	private static int globalIdCounter; // 0x0
	private ArrayList importedSchemas; // 0xB8
	private ArrayList importedNamespaces; // 0xC0
	private int schemaId; // 0xC8
	private Uri baseUri; // 0xD0
	private bool isChameleon; // 0xD8
	private Hashtable ids; // 0xE0
	private XmlDocument document; // 0xE8

	// Properties
	[XmlAttributeAttribute] // RVA: 0x87910 Offset: 0x86D10 VA: 0x180087910
	[DefaultValueAttribute] // RVA: 0x87910 Offset: 0x86D10 VA: 0x180087910
	public XmlSchemaForm AttributeFormDefault { get; set; }
	[XmlAttributeAttribute] // RVA: 0x87BC0 Offset: 0x86FC0 VA: 0x180087BC0
	[DefaultValueAttribute] // RVA: 0x87BC0 Offset: 0x86FC0 VA: 0x180087BC0
	public XmlSchemaDerivationMethod BlockDefault { get; set; }
	[DefaultValueAttribute] // RVA: 0x87FC0 Offset: 0x873C0 VA: 0x180087FC0
	[XmlAttributeAttribute] // RVA: 0x87FC0 Offset: 0x873C0 VA: 0x180087FC0
	public XmlSchemaDerivationMethod FinalDefault { get; set; }
	[DefaultValueAttribute] // RVA: 0x882C0 Offset: 0x876C0 VA: 0x1800882C0
	[XmlAttributeAttribute] // RVA: 0x882C0 Offset: 0x876C0 VA: 0x1800882C0
	public XmlSchemaForm ElementFormDefault { get; set; }
	[XmlAttributeAttribute] // RVA: 0x88660 Offset: 0x87A60 VA: 0x180088660
	public string TargetNamespace { get; set; }
	[XmlAttributeAttribute] // RVA: 0x88730 Offset: 0x87B30 VA: 0x180088730
	public string Version { get; set; }
	[XmlElementAttribute] // RVA: 0x88900 Offset: 0x87D00 VA: 0x180088900
	[XmlElementAttribute] // RVA: 0x88900 Offset: 0x87D00 VA: 0x180088900
	[XmlElementAttribute] // RVA: 0x88900 Offset: 0x87D00 VA: 0x180088900
	public XmlSchemaObjectCollection Includes { get; }
	[XmlElementAttribute] // RVA: 0x88CE0 Offset: 0x880E0 VA: 0x180088CE0
	[XmlElementAttribute] // RVA: 0x88CE0 Offset: 0x880E0 VA: 0x180088CE0
	[XmlElementAttribute] // RVA: 0x88CE0 Offset: 0x880E0 VA: 0x180088CE0
	[XmlElementAttribute] // RVA: 0x88CE0 Offset: 0x880E0 VA: 0x180088CE0
	[XmlElementAttribute] // RVA: 0x88CE0 Offset: 0x880E0 VA: 0x180088CE0
	[XmlElementAttribute] // RVA: 0x88CE0 Offset: 0x880E0 VA: 0x180088CE0
	[XmlElementAttribute] // RVA: 0x88CE0 Offset: 0x880E0 VA: 0x180088CE0
	[XmlElementAttribute] // RVA: 0x88CE0 Offset: 0x880E0 VA: 0x180088CE0
	public XmlSchemaObjectCollection Items { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal bool IsCompiledBySet { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal bool IsPreprocessed { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal bool IsRedefined { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public XmlSchemaObjectTable Attributes { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public XmlSchemaObjectTable AttributeGroups { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public XmlSchemaObjectTable SchemaTypes { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public XmlSchemaObjectTable Elements { get; }
	[XmlAttributeAttribute] // RVA: 0x8A9C0 Offset: 0x89DC0 VA: 0x18008A9C0
	public string Id { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public XmlSchemaObjectTable Groups { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public XmlSchemaObjectTable Notations { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal XmlSchemaObjectTable IdentityConstraints { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal Uri BaseUri { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal int SchemaId { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal bool IsChameleon { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal Hashtable Ids { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal XmlDocument Document { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal int ErrorCount { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal override string IdAttribute { get; set; }
	internal ArrayList ImportedSchemas { get; }
	internal ArrayList ImportedNamespaces { get; }

	// Methods

	// RVA: 0x1444920 Offset: 0x1443D20 VA: 0x181444920
	public void .ctor() { }

	// RVA: 0x1444780 Offset: 0x1443B80 VA: 0x181444780
	public static XmlSchema Read(XmlReader reader, ValidationEventHandler validationEventHandler) { }

	// RVA: 0x1443FF0 Offset: 0x14433F0 VA: 0x181443FF0
	internal bool CompileSchema(XmlSchemaCollection xsc, XmlResolver resolver, SchemaInfo schemaInfo, string ns, ValidationEventHandler validationEventHandler, XmlNameTable nameTable, bool CompileContentModel) { }

	// RVA: 0x1443F30 Offset: 0x1443330 VA: 0x181443F30
	internal void CompileSchemaInSet(XmlNameTable nameTable, ValidationEventHandler eventHandler, XmlSchemaCompilationSettings compilationSettings) { }

	// RVA: 0x516B70 Offset: 0x515F70 VA: 0x180516B70
	public XmlSchemaForm get_AttributeFormDefault() { }

	// RVA: 0xC53FC0 Offset: 0xC533C0 VA: 0x180C53FC0
	public void set_AttributeFormDefault(XmlSchemaForm value) { }

	// RVA: 0x5F7C80 Offset: 0x5F7080 VA: 0x1805F7C80
	public XmlSchemaDerivationMethod get_BlockDefault() { }

	// RVA: 0x6B9860 Offset: 0x6B8C60 VA: 0x1806B9860
	public void set_BlockDefault(XmlSchemaDerivationMethod value) { }

	// RVA: 0x5F7C90 Offset: 0x5F7090 VA: 0x1805F7C90
	public XmlSchemaDerivationMethod get_FinalDefault() { }

	// RVA: 0x8B0DE0 Offset: 0x8B01E0 VA: 0x1808B0DE0
	public void set_FinalDefault(XmlSchemaDerivationMethod value) { }

	// RVA: 0x5FC790 Offset: 0x5FBB90 VA: 0x1805FC790
	public XmlSchemaForm get_ElementFormDefault() { }

	// RVA: 0x8B1150 Offset: 0x8B0550 VA: 0x1808B1150
	public void set_ElementFormDefault(XmlSchemaForm value) { }

	// RVA: 0x5DCCA0 Offset: 0x5DC0A0 VA: 0x1805DCCA0
	public string get_TargetNamespace() { }

	// RVA: 0x5F7050 Offset: 0x5F6450 VA: 0x1805F7050
	public void set_TargetNamespace(string value) { }

	// RVA: 0x4CC350 Offset: 0x4CB750 VA: 0x1804CC350
	public string get_Version() { }

	// RVA: 0x4CC370 Offset: 0x4CB770 VA: 0x1804CC370
	public void set_Version(string value) { }

	// RVA: 0x4CC340 Offset: 0x4CB740 VA: 0x1804CC340
	public XmlSchemaObjectCollection get_Includes() { }

	// RVA: 0x54FB60 Offset: 0x54EF60 VA: 0x18054FB60
	public XmlSchemaObjectCollection get_Items() { }

	// RVA: 0x104B3D0 Offset: 0x104A7D0 VA: 0x18104B3D0
	internal bool get_IsCompiledBySet() { }

	// RVA: 0x10F9DD0 Offset: 0x10F91D0 VA: 0x1810F9DD0
	internal void set_IsCompiledBySet(bool value) { }

	// RVA: 0x104B420 Offset: 0x104A820 VA: 0x18104B420
	internal bool get_IsPreprocessed() { }

	// RVA: 0x1444F30 Offset: 0x1444330 VA: 0x181444F30
	internal void set_IsPreprocessed(bool value) { }

	// RVA: 0x104B410 Offset: 0x104A810 VA: 0x18104B410
	internal bool get_IsRedefined() { }

	// RVA: 0x1444F40 Offset: 0x1444340 VA: 0x181444F40
	internal void set_IsRedefined(bool value) { }

	// RVA: 0x1444B80 Offset: 0x1443F80 VA: 0x181444B80
	public XmlSchemaObjectTable get_Attributes() { }

	// RVA: 0x1444B00 Offset: 0x1443F00 VA: 0x181444B00
	public XmlSchemaObjectTable get_AttributeGroups() { }

	// RVA: 0x1444E90 Offset: 0x1444290 VA: 0x181444E90
	public XmlSchemaObjectTable get_SchemaTypes() { }

	// RVA: 0x1444C80 Offset: 0x1444080 VA: 0x181444C80
	public XmlSchemaObjectTable get_Elements() { }

	// RVA: 0x5334F0 Offset: 0x5328F0 VA: 0x1805334F0
	public string get_Id() { }

	// RVA: 0x5336F0 Offset: 0x532AF0 VA: 0x1805336F0
	public void set_Id(string value) { }

	// RVA: 0x58DBC0 Offset: 0x58CFC0 VA: 0x18058DBC0
	public XmlSchemaObjectTable get_Groups() { }

	// RVA: 0x9321E0 Offset: 0x9315E0 VA: 0x1809321E0
	public XmlSchemaObjectTable get_Notations() { }

	// RVA: 0x972280 Offset: 0x971680 VA: 0x180972280
	internal XmlSchemaObjectTable get_IdentityConstraints() { }

	// RVA: 0xC53130 Offset: 0xC52530 VA: 0x180C53130
	internal Uri get_BaseUri() { }

	// RVA: 0xC53280 Offset: 0xC52680 VA: 0x180C53280
	internal void set_BaseUri(Uri value) { }

	// RVA: 0x1444E10 Offset: 0x1444210 VA: 0x181444E10
	internal int get_SchemaId() { }

	// RVA: 0x1444E00 Offset: 0x1444200 VA: 0x181444E00
	internal bool get_IsChameleon() { }

	// RVA: 0x1444F20 Offset: 0x1444320 VA: 0x181444F20
	internal void set_IsChameleon(bool value) { }

	// RVA: 0x4EBD40 Offset: 0x4EB140 VA: 0x1804EBD40
	internal Hashtable get_Ids() { }

	// RVA: 0x1444C00 Offset: 0x1444000 VA: 0x181444C00
	internal XmlDocument get_Document() { }

	// RVA: 0x100ADE0 Offset: 0x100A1E0 VA: 0x18100ADE0
	internal int get_ErrorCount() { }

	// RVA: 0x1444F10 Offset: 0x1444310 VA: 0x181444F10
	internal void set_ErrorCount(int value) { }

	// RVA: 0x1443E40 Offset: 0x1443240 VA: 0x181443E40
	internal XmlSchema Clone() { }

	// RVA: 0x14441B0 Offset: 0x14435B0 VA: 0x1814441B0
	internal XmlSchema DeepClone() { }

	// RVA: 0x5334F0 Offset: 0x5328F0 VA: 0x1805334F0 Slot: 7
	internal override string get_IdAttribute() { }

	// RVA: 0x5336F0 Offset: 0x532AF0 VA: 0x1805336F0 Slot: 8
	internal override void set_IdAttribute(string value) { }

	// RVA: 0x14448D0 Offset: 0x1443CD0 VA: 0x1814448D0
	internal void SetIsCompiled(bool isCompiled) { }

	// RVA: 0x58DCC0 Offset: 0x58D0C0 VA: 0x18058DCC0 Slot: 9
	internal override void SetUnhandledAttributes(XmlAttribute[] moreAttributes) { }

	// RVA: 0x1443E20 Offset: 0x1443220 VA: 0x181443E20 Slot: 10
	internal override void AddAnnotation(XmlSchemaAnnotation annotation) { }

	// RVA: 0x1444D80 Offset: 0x1444180 VA: 0x181444D80
	internal ArrayList get_ImportedSchemas() { }

	// RVA: 0x1444D00 Offset: 0x1444100 VA: 0x181444D00
	internal ArrayList get_ImportedNamespaces() { }

	// RVA: 0x1444550 Offset: 0x1443950 VA: 0x181444550
	internal void GetExternalSchemasList(IList extList, XmlSchema schema) { }

	// RVA: 0x14448E0 Offset: 0x1443CE0 VA: 0x1814448E0
	private static void .cctor() { }

}

public class XmlSchemaAll : XmlSchemaGroupBase // TypeDefIndex: 2307
{	// Fields
	private XmlSchemaObjectCollection items; // 0x78

	// Properties
	[XmlElementAttribute] // RVA: 0x8AFB0 Offset: 0x8A3B0 VA: 0x18008AFB0
	public override XmlSchemaObjectCollection Items { get; }
	internal override bool IsEmpty { get; }

	// Methods

	// RVA: 0x4E4EC0 Offset: 0x4E42C0 VA: 0x1804E4EC0 Slot: 16
	public override XmlSchemaObjectCollection get_Items() { }

	// RVA: 0x1045B60 Offset: 0x1044F60 VA: 0x181045B60 Slot: 14
	internal override bool get_IsEmpty() { }

	// RVA: 0x4E51E0 Offset: 0x4E45E0 VA: 0x1804E51E0 Slot: 17
	internal override void SetItems(XmlSchemaObjectCollection newItems) { }

	// RVA: 0x1045AC0 Offset: 0x1044EC0 VA: 0x181045AC0
	public void .ctor() { }

}

public class XmlSchemaAnnotated : XmlSchemaObject // TypeDefIndex: 2308
{	// Fields
	private string id; // 0x38
	private XmlSchemaAnnotation annotation; // 0x40
	private XmlAttribute[] moreAttributes; // 0x48

	// Properties
	[XmlAttributeAttribute] // RVA: 0x8A9C0 Offset: 0x89DC0 VA: 0x18008A9C0
	public string Id { get; set; }
	[XmlElementAttribute] // RVA: 0x8B140 Offset: 0x8A540 VA: 0x18008B140
	public XmlSchemaAnnotation Annotation { get; set; }
	[XmlAnyAttributeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public XmlAttribute[] UnhandledAttributes { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal override string IdAttribute { get; set; }

	// Methods

	// RVA: 0x5DCC00 Offset: 0x5DC000 VA: 0x1805DCC00
	public string get_Id() { }

	// RVA: 0x5089D0 Offset: 0x507DD0 VA: 0x1805089D0
	public void set_Id(string value) { }

	// RVA: 0x4B9440 Offset: 0x4B8840 VA: 0x1804B9440
	public XmlSchemaAnnotation get_Annotation() { }

	// RVA: 0x4B94A0 Offset: 0x4B88A0 VA: 0x1804B94A0
	public void set_Annotation(XmlSchemaAnnotation value) { }

	// RVA: 0x5DCCA0 Offset: 0x5DC0A0 VA: 0x1805DCCA0
	public XmlAttribute[] get_UnhandledAttributes() { }

	// RVA: 0x5F7050 Offset: 0x5F6450 VA: 0x1805F7050
	public void set_UnhandledAttributes(XmlAttribute[] value) { }

	// RVA: 0x5DCC00 Offset: 0x5DC000 VA: 0x1805DCC00 Slot: 7
	internal override string get_IdAttribute() { }

	// RVA: 0x5089D0 Offset: 0x507DD0 VA: 0x1805089D0 Slot: 8
	internal override void set_IdAttribute(string value) { }

	// RVA: 0x5F7050 Offset: 0x5F6450 VA: 0x1805F7050 Slot: 9
	internal override void SetUnhandledAttributes(XmlAttribute[] moreAttributes) { }

	// RVA: 0x4B94A0 Offset: 0x4B88A0 VA: 0x1804B94A0 Slot: 10
	internal override void AddAnnotation(XmlSchemaAnnotation annotation) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

public class XmlSchemaAnnotation : XmlSchemaObject // TypeDefIndex: 2309
{	// Fields
	private string id; // 0x38
	private XmlSchemaObjectCollection items; // 0x40
	private XmlAttribute[] moreAttributes; // 0x48

	// Properties
	[XmlAttributeAttribute] // RVA: 0x8A9C0 Offset: 0x89DC0 VA: 0x18008A9C0
	public string Id { get; set; }
	[XmlElementAttribute] // RVA: 0x8C6A0 Offset: 0x8BAA0 VA: 0x18008C6A0
	[XmlElementAttribute] // RVA: 0x8C6A0 Offset: 0x8BAA0 VA: 0x18008C6A0
	public XmlSchemaObjectCollection Items { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal override string IdAttribute { get; set; }

	// Methods

	// RVA: 0x5DCC00 Offset: 0x5DC000 VA: 0x1805DCC00
	public string get_Id() { }

	// RVA: 0x5089D0 Offset: 0x507DD0 VA: 0x1805089D0
	public void set_Id(string value) { }

	// RVA: 0x4B9440 Offset: 0x4B8840 VA: 0x1804B9440
	public XmlSchemaObjectCollection get_Items() { }

	// RVA: 0x5DCC00 Offset: 0x5DC000 VA: 0x1805DCC00 Slot: 7
	internal override string get_IdAttribute() { }

	// RVA: 0x5089D0 Offset: 0x507DD0 VA: 0x1805089D0 Slot: 8
	internal override void set_IdAttribute(string value) { }

	// RVA: 0x5F7050 Offset: 0x5F6450 VA: 0x1805F7050 Slot: 9
	internal override void SetUnhandledAttributes(XmlAttribute[] moreAttributes) { }

	// RVA: 0x1045BA0 Offset: 0x1044FA0 VA: 0x181045BA0
	public void .ctor() { }

}

public class XmlSchemaAny : XmlSchemaParticle // TypeDefIndex: 2310
{	// Fields
	private string ns; // 0x78
	private XmlSchemaContentProcessing processContents; // 0x80
	private NamespaceList namespaceList; // 0x88

	// Properties
	[XmlAttributeAttribute] // RVA: 0x8C9A0 Offset: 0x8BDA0 VA: 0x18008C9A0
	public string Namespace { get; set; }
	[DefaultValueAttribute] // RVA: 0x8CA30 Offset: 0x8BE30 VA: 0x18008CA30
	[XmlAttributeAttribute] // RVA: 0x8CA30 Offset: 0x8BE30 VA: 0x18008CA30
	public XmlSchemaContentProcessing ProcessContents { set; }
	[XmlIgnoreAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal NamespaceList NamespaceList { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal string ResolvedNamespace { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal XmlSchemaContentProcessing ProcessContentsCorrect { get; }
	internal override string NameString { get; }

	// Methods

	// RVA: 0x4E4EC0 Offset: 0x4E42C0 VA: 0x1804E4EC0
	public string get_Namespace() { }

	// RVA: 0x4E51E0 Offset: 0x4E45E0 VA: 0x1804E51E0
	public void set_Namespace(string value) { }

	// RVA: 0x59C1B0 Offset: 0x59B5B0 VA: 0x18059C1B0
	public void set_ProcessContents(XmlSchemaContentProcessing value) { }

	// RVA: 0x58DBD0 Offset: 0x58CFD0 VA: 0x18058DBD0
	internal NamespaceList get_NamespaceList() { }

	// RVA: 0x10464D0 Offset: 0x10458D0 VA: 0x1810464D0
	internal string get_ResolvedNamespace() { }

	// RVA: 0x10464B0 Offset: 0x10458B0 VA: 0x1810464B0
	internal XmlSchemaContentProcessing get_ProcessContentsCorrect() { }

	// RVA: 0x1046150 Offset: 0x1045550 VA: 0x181046150 Slot: 15
	internal override string get_NameString() { }

	// RVA: 0x1046050 Offset: 0x1045450 VA: 0x181046050
	internal void BuildNamespaceList(string targetNamespace) { }

	// RVA: 0x1045FA0 Offset: 0x10453A0 VA: 0x181045FA0
	internal void BuildNamespaceListV1Compat(string targetNamespace) { }

	// RVA: 0x1045F60 Offset: 0x1045360 VA: 0x181045F60
	internal bool Allows(XmlQualifiedName qname) { }

	// RVA: 0x10460F0 Offset: 0x10454F0 VA: 0x1810460F0
	public void .ctor() { }

}

public class XmlSchemaAnyAttribute : XmlSchemaAnnotated // TypeDefIndex: 2311
{	// Fields
	private string ns; // 0x50
	private XmlSchemaContentProcessing processContents; // 0x58
	private NamespaceList namespaceList; // 0x60

	// Properties
	[XmlAttributeAttribute] // RVA: 0x8C9A0 Offset: 0x8BDA0 VA: 0x18008C9A0
	public string Namespace { set; }
	[XmlAttributeAttribute] // RVA: 0x8CE40 Offset: 0x8C240 VA: 0x18008CE40
	[DefaultValueAttribute] // RVA: 0x8CE40 Offset: 0x8C240 VA: 0x18008CE40
	public XmlSchemaContentProcessing ProcessContents { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal NamespaceList NamespaceList { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal XmlSchemaContentProcessing ProcessContentsCorrect { get; }

	// Methods

	// RVA: 0x4CC370 Offset: 0x4CB770 VA: 0x1804CC370
	public void set_Namespace(string value) { }

	// RVA: 0xAE4F70 Offset: 0xAE4370 VA: 0x180AE4F70
	public XmlSchemaContentProcessing get_ProcessContents() { }

	// RVA: 0xD229D0 Offset: 0xD21DD0 VA: 0x180D229D0
	public void set_ProcessContents(XmlSchemaContentProcessing value) { }

	// RVA: 0x54FB60 Offset: 0x54EF60 VA: 0x18054FB60
	internal NamespaceList get_NamespaceList() { }

	// RVA: 0x1045F50 Offset: 0x1045350 VA: 0x181045F50
	internal XmlSchemaContentProcessing get_ProcessContentsCorrect() { }

	// RVA: 0x1045CF0 Offset: 0x10450F0 VA: 0x181045CF0
	internal void BuildNamespaceList(string targetNamespace) { }

	// RVA: 0x1045C50 Offset: 0x1045050 VA: 0x181045C50
	internal void BuildNamespaceListV1Compat(string targetNamespace) { }

	// RVA: 0x1045C10 Offset: 0x1045010 VA: 0x181045C10
	internal bool Allows(XmlQualifiedName qname) { }

	// RVA: 0x1045E50 Offset: 0x1045250 VA: 0x181045E50
	internal static bool IsSubset(XmlSchemaAnyAttribute sub, XmlSchemaAnyAttribute super) { }

	// RVA: 0x1045D80 Offset: 0x1045180 VA: 0x181045D80
	internal static XmlSchemaAnyAttribute Intersection(XmlSchemaAnyAttribute o1, XmlSchemaAnyAttribute o2, bool v1Compat) { }

	// RVA: 0x1045E80 Offset: 0x1045280 VA: 0x181045E80
	internal static XmlSchemaAnyAttribute Union(XmlSchemaAnyAttribute o1, XmlSchemaAnyAttribute o2, bool v1Compat) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

public class XmlSchemaAppInfo : XmlSchemaObject // TypeDefIndex: 2312
{	// Fields
	private string source; // 0x38
	private XmlNode[] markup; // 0x40

	// Properties
	[XmlAttributeAttribute] // RVA: 0x8D1F0 Offset: 0x8C5F0 VA: 0x18008D1F0
	public string Source { set; }
	[XmlTextAttribute] // RVA: 0x8D280 Offset: 0x8C680 VA: 0x18008D280
	[XmlAnyElementAttribute] // RVA: 0x8D280 Offset: 0x8C680 VA: 0x18008D280
	public XmlNode[] Markup { get; set; }

	// Methods

	// RVA: 0x5089D0 Offset: 0x507DD0 VA: 0x1805089D0
	public void set_Source(string value) { }

	// RVA: 0x4B9440 Offset: 0x4B8840 VA: 0x1804B9440
	public XmlNode[] get_Markup() { }

	// RVA: 0x4B94A0 Offset: 0x4B88A0 VA: 0x1804B94A0
	public void set_Markup(XmlNode[] value) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

public class XmlSchemaAttribute : XmlSchemaAnnotated // TypeDefIndex: 2313
{	// Fields
	private string defaultValue; // 0x50
	private string fixedValue; // 0x58
	private string name; // 0x60
	private XmlSchemaForm form; // 0x68
	private XmlSchemaUse use; // 0x6C
	private XmlQualifiedName refName; // 0x70
	private XmlQualifiedName typeName; // 0x78
	private XmlQualifiedName qualifiedName; // 0x80
	private XmlSchemaSimpleType type; // 0x88
	private XmlSchemaSimpleType attributeType; // 0x90
	private SchemaAttDef attDef; // 0x98

	// Properties
	[XmlAttributeAttribute] // RVA: 0x8D420 Offset: 0x8C820 VA: 0x18008D420
	[DefaultValueAttribute] // RVA: 0x8D420 Offset: 0x8C820 VA: 0x18008D420
	public string DefaultValue { get; set; }
	[DefaultValueAttribute] // RVA: 0x8D4A0 Offset: 0x8C8A0 VA: 0x18008D4A0
	[XmlAttributeAttribute] // RVA: 0x8D4A0 Offset: 0x8C8A0 VA: 0x18008D4A0
	public string FixedValue { get; set; }
	[DefaultValueAttribute] // RVA: 0x8D6B0 Offset: 0x8CAB0 VA: 0x18008D6B0
	[XmlAttributeAttribute] // RVA: 0x8D6B0 Offset: 0x8CAB0 VA: 0x18008D6B0
	public XmlSchemaForm Form { get; set; }
	[XmlAttributeAttribute] // RVA: 0x8D890 Offset: 0x8CC90 VA: 0x18008D890
	public string Name { get; set; }
	[XmlAttributeAttribute] // RVA: 0x8D9C0 Offset: 0x8CDC0 VA: 0x18008D9C0
	public XmlQualifiedName RefName { get; set; }
	[XmlAttributeAttribute] // RVA: 0x8DA50 Offset: 0x8CE50 VA: 0x18008DA50
	public XmlQualifiedName SchemaTypeName { get; set; }
	[XmlElementAttribute] // RVA: 0x8DBE0 Offset: 0x8CFE0 VA: 0x18008DBE0
	public XmlSchemaSimpleType SchemaType { get; set; }
	[XmlAttributeAttribute] // RVA: 0x8DCD0 Offset: 0x8D0D0 VA: 0x18008DCD0
	[DefaultValueAttribute] // RVA: 0x8DCD0 Offset: 0x8D0D0 VA: 0x18008DCD0
	public XmlSchemaUse Use { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public XmlQualifiedName QualifiedName { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public XmlSchemaSimpleType AttributeSchemaType { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal XmlSchemaDatatype Datatype { get; }
	internal SchemaAttDef AttDef { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal override string NameAttribute { get; set; }

	// Methods

	// RVA: 0x4CC350 Offset: 0x4CB750 VA: 0x1804CC350
	public string get_DefaultValue() { }

	// RVA: 0x4CC370 Offset: 0x4CB770 VA: 0x1804CC370
	public void set_DefaultValue(string value) { }

	// RVA: 0x4CC340 Offset: 0x4CB740 VA: 0x1804CC340
	public string get_FixedValue() { }

	// RVA: 0x4CC360 Offset: 0x4CB760 VA: 0x1804CC360
	public void set_FixedValue(string value) { }

	// RVA: 0x7E3980 Offset: 0x7E2D80 VA: 0x1807E3980
	public XmlSchemaForm get_Form() { }

	// RVA: 0x7E39B0 Offset: 0x7E2DB0 VA: 0x1807E39B0
	public void set_Form(XmlSchemaForm value) { }

	// RVA: 0x54FB60 Offset: 0x54EF60 VA: 0x18054FB60
	public string get_Name() { }

	// RVA: 0x54FB70 Offset: 0x54EF70 VA: 0x18054FB70
	public void set_Name(string value) { }

	// RVA: 0x58DC30 Offset: 0x58D030 VA: 0x18058DC30
	public XmlQualifiedName get_RefName() { }

	// RVA: 0x1046A80 Offset: 0x1045E80 VA: 0x181046A80
	public void set_RefName(XmlQualifiedName value) { }

	// RVA: 0x4E4EC0 Offset: 0x4E42C0 VA: 0x1804E4EC0
	public XmlQualifiedName get_SchemaTypeName() { }

	// RVA: 0x1046B40 Offset: 0x1045F40 VA: 0x181046B40
	public void set_SchemaTypeName(XmlQualifiedName value) { }

	// RVA: 0x58DBD0 Offset: 0x58CFD0 VA: 0x18058DBD0
	public XmlSchemaSimpleType get_SchemaType() { }

	// RVA: 0x58DC60 Offset: 0x58D060 VA: 0x18058DC60
	public void set_SchemaType(XmlSchemaSimpleType value) { }

	// RVA: 0x7E3960 Offset: 0x7E2D60 VA: 0x1807E3960
	public XmlSchemaUse get_Use() { }

	// RVA: 0x7E3990 Offset: 0x7E2D90 VA: 0x1807E3990
	public void set_Use(XmlSchemaUse value) { }

	// RVA: 0x58DC40 Offset: 0x58D040 VA: 0x18058DC40
	public XmlQualifiedName get_QualifiedName() { }

	// RVA: 0x4E09F0 Offset: 0x4DFDF0 VA: 0x1804E09F0
	public XmlSchemaSimpleType get_AttributeSchemaType() { }

	// RVA: 0x1046A60 Offset: 0x1045E60 VA: 0x181046A60
	internal XmlSchemaDatatype get_Datatype() { }

	// RVA: 0x58DCD0 Offset: 0x58D0D0 VA: 0x18058DCD0
	internal void SetQualifiedName(XmlQualifiedName value) { }

	// RVA: 0x4E0A00 Offset: 0x4DFE00 VA: 0x1804E0A00
	internal void SetAttributeType(XmlSchemaSimpleType value) { }

	// RVA: 0x58DBE0 Offset: 0x58CFE0 VA: 0x18058DBE0
	internal SchemaAttDef get_AttDef() { }

	// RVA: 0x58DC70 Offset: 0x58D070 VA: 0x18058DC70
	internal void set_AttDef(SchemaAttDef value) { }

	// RVA: 0x54FB60 Offset: 0x54EF60 VA: 0x18054FB60 Slot: 11
	internal override string get_NameAttribute() { }

	// RVA: 0x54FB70 Offset: 0x54EF70 VA: 0x18054FB70 Slot: 12
	internal override void set_NameAttribute(string value) { }

	// RVA: 0x10468A0 Offset: 0x1045CA0 VA: 0x1810468A0 Slot: 13
	internal override XmlSchemaObject Clone() { }

	// RVA: 0x10469A0 Offset: 0x1045DA0 VA: 0x1810469A0
	public void .ctor() { }

}

public class XmlSchemaAttributeGroup : XmlSchemaAnnotated // TypeDefIndex: 2314
{	// Fields
	private string name; // 0x50
	private XmlSchemaObjectCollection attributes; // 0x58
	private XmlSchemaAnyAttribute anyAttribute; // 0x60
	private XmlQualifiedName qname; // 0x68
	private XmlSchemaAttributeGroup redefined; // 0x70
	private XmlSchemaObjectTable attributeUses; // 0x78
	private XmlSchemaAnyAttribute attributeWildcard; // 0x80
	private int selfReferenceCount; // 0x88

	// Properties
	[XmlAttributeAttribute] // RVA: 0x8D890 Offset: 0x8CC90 VA: 0x18008D890
	public string Name { get; set; }
	[XmlElementAttribute] // RVA: 0x8E2B0 Offset: 0x8D6B0 VA: 0x18008E2B0
	[XmlElementAttribute] // RVA: 0x8E2B0 Offset: 0x8D6B0 VA: 0x18008E2B0
	public XmlSchemaObjectCollection Attributes { get; }
	[XmlElementAttribute] // RVA: 0x8E4F0 Offset: 0x8D8F0 VA: 0x18008E4F0
	public XmlSchemaAnyAttribute AnyAttribute { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public XmlQualifiedName QualifiedName { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal XmlSchemaObjectTable AttributeUses { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal XmlSchemaAnyAttribute AttributeWildcard { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public XmlSchemaAttributeGroup RedefinedAttributeGroup { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal XmlSchemaAttributeGroup Redefined { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal int SelfReferenceCount { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal override string NameAttribute { get; set; }

	// Methods

	// RVA: 0x4CC350 Offset: 0x4CB750 VA: 0x1804CC350
	public string get_Name() { }

	// RVA: 0x4CC370 Offset: 0x4CB770 VA: 0x1804CC370
	public void set_Name(string value) { }

	// RVA: 0x4CC340 Offset: 0x4CB740 VA: 0x1804CC340
	public XmlSchemaObjectCollection get_Attributes() { }

	// RVA: 0x54FB60 Offset: 0x54EF60 VA: 0x18054FB60
	public XmlSchemaAnyAttribute get_AnyAttribute() { }

	// RVA: 0x54FB70 Offset: 0x54EF70 VA: 0x18054FB70
	public void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	// RVA: 0x5334F0 Offset: 0x5328F0 VA: 0x1805334F0
	public XmlQualifiedName get_QualifiedName() { }

	// RVA: 0x1046830 Offset: 0x1045C30 VA: 0x181046830
	internal XmlSchemaObjectTable get_AttributeUses() { }

	// RVA: 0x58DC40 Offset: 0x58D040 VA: 0x18058DC40
	internal XmlSchemaAnyAttribute get_AttributeWildcard() { }

	// RVA: 0x58DCD0 Offset: 0x58D0D0 VA: 0x18058DCD0
	internal void set_AttributeWildcard(XmlSchemaAnyAttribute value) { }

	// RVA: 0x58DC30 Offset: 0x58D030 VA: 0x18058DC30
	public XmlSchemaAttributeGroup get_RedefinedAttributeGroup() { }

	// RVA: 0x58DC30 Offset: 0x58D030 VA: 0x18058DC30
	internal XmlSchemaAttributeGroup get_Redefined() { }

	// RVA: 0x58DCC0 Offset: 0x58D0C0 VA: 0x18058DCC0
	internal void set_Redefined(XmlSchemaAttributeGroup value) { }

	// RVA: 0x5A44D0 Offset: 0x5A38D0 VA: 0x1805A44D0
	internal int get_SelfReferenceCount() { }

	// RVA: 0xF86EB0 Offset: 0xF862B0 VA: 0x180F86EB0
	internal void set_SelfReferenceCount(int value) { }

	// RVA: 0x4CC350 Offset: 0x4CB750 VA: 0x1804CC350 Slot: 11
	internal override string get_NameAttribute() { }

	// RVA: 0x4CC370 Offset: 0x4CB770 VA: 0x1804CC370 Slot: 12
	internal override void set_NameAttribute(string value) { }

	// RVA: 0x5336F0 Offset: 0x532AF0 VA: 0x1805336F0
	internal void SetQualifiedName(XmlQualifiedName value) { }

	// RVA: 0x1046650 Offset: 0x1045A50 VA: 0x181046650 Slot: 13
	internal override XmlSchemaObject Clone() { }

	// RVA: 0x1046780 Offset: 0x1045B80 VA: 0x181046780
	public void .ctor() { }

}

public class XmlSchemaAttributeGroupRef : XmlSchemaAnnotated // TypeDefIndex: 2315
{	// Fields
	private XmlQualifiedName refName; // 0x50

	// Properties
	[XmlAttributeAttribute] // RVA: 0x8D9C0 Offset: 0x8CDC0 VA: 0x18008D9C0
	public XmlQualifiedName RefName { get; set; }

	// Methods

	// RVA: 0x4CC350 Offset: 0x4CB750 VA: 0x1804CC350
	public XmlQualifiedName get_RefName() { }

	// RVA: 0x1046590 Offset: 0x1045990 VA: 0x181046590
	public void set_RefName(XmlQualifiedName value) { }

	// RVA: 0x1046510 Offset: 0x1045910 VA: 0x181046510
	public void .ctor() { }

}

public class XmlSchemaChoice : XmlSchemaGroupBase // TypeDefIndex: 2316
{	// Fields
	private XmlSchemaObjectCollection items; // 0x78

	// Properties
	[XmlElementAttribute] // RVA: 0x8E910 Offset: 0x8DD10 VA: 0x18008E910
	[XmlElementAttribute] // RVA: 0x8E910 Offset: 0x8DD10 VA: 0x18008E910
	[XmlElementAttribute] // RVA: 0x8E910 Offset: 0x8DD10 VA: 0x18008E910
	[XmlElementAttribute] // RVA: 0x8E910 Offset: 0x8DD10 VA: 0x18008E910
	[XmlElementAttribute] // RVA: 0x8E910 Offset: 0x8DD10 VA: 0x18008E910
	public override XmlSchemaObjectCollection Items { get; }
	internal override bool IsEmpty { get; }

	// Methods

	// RVA: 0x4E4EC0 Offset: 0x4E42C0 VA: 0x1804E4EC0 Slot: 16
	public override XmlSchemaObjectCollection get_Items() { }

	// RVA: 0x1046CA0 Offset: 0x10460A0 VA: 0x181046CA0 Slot: 14
	internal override bool get_IsEmpty() { }

	// RVA: 0x4E51E0 Offset: 0x4E45E0 VA: 0x1804E51E0 Slot: 17
	internal override void SetItems(XmlSchemaObjectCollection newItems) { }

	// RVA: 0x1046C00 Offset: 0x1046000 VA: 0x181046C00
	public void .ctor() { }

}

public sealed class XmlSchemaCollection : ICollection, IEnumerable // TypeDefIndex: 2317
{	// Fields
	private Hashtable collection; // 0x10
	private XmlNameTable nameTable; // 0x18
	private SchemaNames schemaNames; // 0x20
	private ReaderWriterLock wLock; // 0x28
	private int timeout; // 0x30
	private bool isThreadSafe; // 0x34
	private ValidationEventHandler validationEventHandler; // 0x38
	private XmlResolver xmlResolver; // 0x40

	// Properties
	public int Count { get; }
	public XmlNameTable NameTable { get; }
	internal XmlResolver XmlResolver { set; }
	public XmlSchema Item { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	private int System.Collections.ICollection.Count { get; }
	internal ValidationEventHandler EventHandler { get; set; }

	// Methods

	// RVA: 0x10477C0 Offset: 0x1046BC0 VA: 0x1810477C0
	public void .ctor(XmlNameTable nametable) { }

	// RVA: 0x1047700 Offset: 0x1046B00 VA: 0x181047700
	public int get_Count() { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public XmlNameTable get_NameTable() { }

	// RVA: 0x4B94A0 Offset: 0x4B88A0 VA: 0x1804B94A0
	internal void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x10478D0 Offset: 0x1046CD0 VA: 0x1810478D0
	public XmlSchema get_Item(string ns) { }

	// RVA: 0x1047730 Offset: 0x1046B30 VA: 0x181047730 Slot: 7
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1047340 Offset: 0x1046740 VA: 0x181047340
	public XmlSchemaCollectionEnumerator GetEnumerator() { }

	// RVA: 0x1047520 Offset: 0x1046920 VA: 0x181047520 Slot: 4
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x4B0E80 Offset: 0x4B0280 VA: 0x1804B0E80 Slot: 6
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x1047700 Offset: 0x1046B00 VA: 0x181047700 Slot: 5
	private int System.Collections.ICollection.get_Count() { }

	// RVA: 0x10473D0 Offset: 0x10467D0 VA: 0x1810473D0
	internal SchemaInfo GetSchemaInfo(string ns) { }

	// RVA: 0x1047470 Offset: 0x1046870 VA: 0x181047470
	internal SchemaNames GetSchemaNames(XmlNameTable nt) { }

	// RVA: 0x1046EF0 Offset: 0x10462F0 VA: 0x181046EF0
	internal XmlSchema Add(string ns, SchemaInfo schemaInfo, XmlSchema schema, bool compile) { }

	// RVA: 0x10471C0 Offset: 0x10465C0 VA: 0x1810471C0
	private XmlSchema Add(string ns, SchemaInfo schemaInfo, XmlSchema schema, bool compile, XmlResolver resolver) { }

	// RVA: 0x1047070 Offset: 0x1046470 VA: 0x181047070
	private void Add(string ns, XmlSchemaCollectionNode node) { }

	// RVA: 0x5DCC00 Offset: 0x5DC000 VA: 0x1805DCC00
	internal ValidationEventHandler get_EventHandler() { }

	// RVA: 0x5089D0 Offset: 0x507DD0 VA: 0x1805089D0
	internal void set_EventHandler(ValidationEventHandler value) { }

}

internal sealed class XmlSchemaCollectionNode // TypeDefIndex: 2318
{	// Fields
	private string namespaceUri; // 0x10
	private SchemaInfo schemaInfo; // 0x18
	private XmlSchema schema; // 0x20

	// Properties
	internal string NamespaceURI { set; }
	internal SchemaInfo SchemaInfo { get; set; }
	internal XmlSchema Schema { get; set; }

	// Methods

	// RVA: 0x4B94C0 Offset: 0x4B88C0 VA: 0x1804B94C0
	internal void set_NamespaceURI(string value) { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	internal SchemaInfo get_SchemaInfo() { }

	// RVA: 0x4D0180 Offset: 0x4CF580 VA: 0x1804D0180
	internal void set_SchemaInfo(SchemaInfo value) { }

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	internal XmlSchema get_Schema() { }

	// RVA: 0x497E30 Offset: 0x497230 VA: 0x180497E30
	internal void set_Schema(XmlSchema value) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

public sealed class XmlSchemaCollectionEnumerator : IEnumerator // TypeDefIndex: 2319
{	// Fields
	private IDictionaryEnumerator enumerator; // 0x10

	// Properties
	private object System.Collections.IEnumerator.Current { get; }
	public XmlSchema Current { get; }
	internal XmlSchemaCollectionNode CurrentNode { get; }

	// Methods

	// RVA: 0x1046DB0 Offset: 0x10461B0 VA: 0x181046DB0
	internal void .ctor(Hashtable collection) { }

	// RVA: 0x1046D50 Offset: 0x1046150 VA: 0x181046D50 Slot: 6
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x1046D00 Offset: 0x1046100 VA: 0x181046D00 Slot: 4
	private bool System.Collections.IEnumerator.MoveNext() { }

	// RVA: 0x1046CB0 Offset: 0x10460B0 VA: 0x181046CB0
	public bool MoveNext() { }

	// RVA: 0x1046DA0 Offset: 0x10461A0 VA: 0x181046DA0 Slot: 5
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x1046E70 Offset: 0x1046270 VA: 0x181046E70
	public XmlSchema get_Current() { }

	// RVA: 0x1046E00 Offset: 0x1046200 VA: 0x181046E00
	internal XmlSchemaCollectionNode get_CurrentNode() { }

}

public sealed class XmlSchemaCompilationSettings // TypeDefIndex: 2320
{	// Fields
	private bool enableUpaCheck; // 0x10

	// Properties
	public bool EnableUpaCheck { get; }

	// Methods

	// RVA: 0x1047970 Offset: 0x1046D70 VA: 0x181047970
	public void .ctor() { }

	// RVA: 0x497E20 Offset: 0x497220 VA: 0x180497E20
	public bool get_EnableUpaCheck() { }

}

public class XmlSchemaComplexContent : XmlSchemaContentModel // TypeDefIndex: 2321
{	// Fields
	private XmlSchemaContent content; // 0x50
	private bool isMixed; // 0x58
	private bool hasMixedAttribute; // 0x59

	// Properties
	[XmlAttributeAttribute] // RVA: 0x8EDE0 Offset: 0x8E1E0 VA: 0x18008EDE0
	public bool IsMixed { get; set; }
	[XmlElementAttribute] // RVA: 0x8F050 Offset: 0x8E450 VA: 0x18008F050
	[XmlElementAttribute] // RVA: 0x8F050 Offset: 0x8E450 VA: 0x18008F050
	public override XmlSchemaContent Content { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal bool HasMixedAttribute { get; }

	// Methods

	// RVA: 0x5ABE90 Offset: 0x5AB290 VA: 0x1805ABE90
	public bool get_IsMixed() { }

	// RVA: 0x1047C70 Offset: 0x1047070 VA: 0x181047C70
	public void set_IsMixed(bool value) { }

	// RVA: 0x4CC350 Offset: 0x4CB750 VA: 0x1804CC350 Slot: 14
	public override XmlSchemaContent get_Content() { }

	// RVA: 0x4CC370 Offset: 0x4CB770 VA: 0x1804CC370 Slot: 15
	public override void set_Content(XmlSchemaContent value) { }

	// RVA: 0xAF1470 Offset: 0xAF0870 VA: 0x180AF1470
	internal bool get_HasMixedAttribute() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

public class XmlSchemaComplexContentExtension : XmlSchemaContent // TypeDefIndex: 2322
{	// Fields
	private XmlSchemaParticle particle; // 0x50
	private XmlSchemaObjectCollection attributes; // 0x58
	private XmlSchemaAnyAttribute anyAttribute; // 0x60
	private XmlQualifiedName baseTypeName; // 0x68

	// Properties
	[XmlAttributeAttribute] // RVA: 0x8F380 Offset: 0x8E780 VA: 0x18008F380
	public XmlQualifiedName BaseTypeName { get; set; }
	[XmlElementAttribute] // RVA: 0x8F580 Offset: 0x8E980 VA: 0x18008F580
	[XmlElementAttribute] // RVA: 0x8F580 Offset: 0x8E980 VA: 0x18008F580
	[XmlElementAttribute] // RVA: 0x8F580 Offset: 0x8E980 VA: 0x18008F580
	[XmlElementAttribute] // RVA: 0x8F580 Offset: 0x8E980 VA: 0x18008F580
	public XmlSchemaParticle Particle { get; set; }
	[XmlElementAttribute] // RVA: 0x8F820 Offset: 0x8EC20 VA: 0x18008F820
	[XmlElementAttribute] // RVA: 0x8F820 Offset: 0x8EC20 VA: 0x18008F820
	public XmlSchemaObjectCollection Attributes { get; }
	[XmlElementAttribute] // RVA: 0x8E4F0 Offset: 0x8D8F0 VA: 0x18008E4F0
	public XmlSchemaAnyAttribute AnyAttribute { get; set; }

	// Methods

	// RVA: 0x5334F0 Offset: 0x5328F0 VA: 0x1805334F0
	public XmlQualifiedName get_BaseTypeName() { }

	// RVA: 0x1047A40 Offset: 0x1046E40 VA: 0x181047A40
	public void set_BaseTypeName(XmlQualifiedName value) { }

	// RVA: 0x4CC350 Offset: 0x4CB750 VA: 0x1804CC350
	public XmlSchemaParticle get_Particle() { }

	// RVA: 0x4CC370 Offset: 0x4CB770 VA: 0x1804CC370
	public void set_Particle(XmlSchemaParticle value) { }

	// RVA: 0x4CC340 Offset: 0x4CB740 VA: 0x1804CC340
	public XmlSchemaObjectCollection get_Attributes() { }

	// RVA: 0x54FB60 Offset: 0x54EF60 VA: 0x18054FB60
	public XmlSchemaAnyAttribute get_AnyAttribute() { }

	// RVA: 0x54FB70 Offset: 0x54EF70 VA: 0x18054FB70
	public void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	// RVA: 0x4CC360 Offset: 0x4CB760 VA: 0x1804CC360
	internal void SetAttributes(XmlSchemaObjectCollection newAttributes) { }

	// RVA: 0x1047990 Offset: 0x1046D90 VA: 0x181047990
	public void .ctor() { }

}

public class XmlSchemaComplexContentRestriction : XmlSchemaContent // TypeDefIndex: 2323
{	// Fields
	private XmlSchemaParticle particle; // 0x50
	private XmlSchemaObjectCollection attributes; // 0x58
	private XmlSchemaAnyAttribute anyAttribute; // 0x60
	private XmlQualifiedName baseTypeName; // 0x68

	// Properties
	[XmlAttributeAttribute] // RVA: 0x8F380 Offset: 0x8E780 VA: 0x18008F380
	public XmlQualifiedName BaseTypeName { get; set; }
	[XmlElementAttribute] // RVA: 0x8FBA0 Offset: 0x8EFA0 VA: 0x18008FBA0
	[XmlElementAttribute] // RVA: 0x8FBA0 Offset: 0x8EFA0 VA: 0x18008FBA0
	[XmlElementAttribute] // RVA: 0x8FBA0 Offset: 0x8EFA0 VA: 0x18008FBA0
	[XmlElementAttribute] // RVA: 0x8FBA0 Offset: 0x8EFA0 VA: 0x18008FBA0
	public XmlSchemaParticle Particle { get; set; }
	[XmlElementAttribute] // RVA: 0x8FF10 Offset: 0x8F310 VA: 0x18008FF10
	[XmlElementAttribute] // RVA: 0x8FF10 Offset: 0x8F310 VA: 0x18008FF10
	public XmlSchemaObjectCollection Attributes { get; }
	[XmlElementAttribute] // RVA: 0x8E4F0 Offset: 0x8D8F0 VA: 0x18008E4F0
	public XmlSchemaAnyAttribute AnyAttribute { get; set; }

	// Methods

	// RVA: 0x5334F0 Offset: 0x5328F0 VA: 0x1805334F0
	public XmlQualifiedName get_BaseTypeName() { }

	// RVA: 0x1047BB0 Offset: 0x1046FB0 VA: 0x181047BB0
	public void set_BaseTypeName(XmlQualifiedName value) { }

	// RVA: 0x4CC350 Offset: 0x4CB750 VA: 0x1804CC350
	public XmlSchemaParticle get_Particle() { }

	// RVA: 0x4CC370 Offset: 0x4CB770 VA: 0x1804CC370
	public void set_Particle(XmlSchemaParticle value) { }

	// RVA: 0x4CC340 Offset: 0x4CB740 VA: 0x1804CC340
	public XmlSchemaObjectCollection get_Attributes() { }

	// RVA: 0x54FB60 Offset: 0x54EF60 VA: 0x18054FB60
	public XmlSchemaAnyAttribute get_AnyAttribute() { }

	// RVA: 0x54FB70 Offset: 0x54EF70 VA: 0x18054FB70
	public void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	// RVA: 0x4CC360 Offset: 0x4CB760 VA: 0x1804CC360
	internal void SetAttributes(XmlSchemaObjectCollection newAttributes) { }

	// RVA: 0x1047B00 Offset: 0x1046F00 VA: 0x181047B00
	public void .ctor() { }

}

public class XmlSchemaComplexType : XmlSchemaType // TypeDefIndex: 2324
{	// Fields
	private XmlSchemaDerivationMethod block; // 0x98
	private XmlSchemaContentModel contentModel; // 0xA0
	private XmlSchemaParticle particle; // 0xA8
	private XmlSchemaObjectCollection attributes; // 0xB0
	private XmlSchemaAnyAttribute anyAttribute; // 0xB8
	private XmlSchemaParticle contentTypeParticle; // 0xC0
	private XmlSchemaDerivationMethod blockResolved; // 0xC8
	private XmlSchemaObjectTable localElements; // 0xD0
	private XmlSchemaObjectTable attributeUses; // 0xD8
	private XmlSchemaAnyAttribute attributeWildcard; // 0xE0
	private static XmlSchemaComplexType anyTypeLax; // 0x0
	private static XmlSchemaComplexType anyTypeSkip; // 0x8
	private static XmlSchemaComplexType untypedAnyType; // 0x10
	private byte pvFlags; // 0xE8

	// Properties
	[XmlIgnoreAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal static XmlSchemaComplexType AnyType { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal static XmlSchemaComplexType UntypedAnyType { get; }
	internal static ContentValidator AnyTypeContentValidator { get; }
	[XmlAttributeAttribute] // RVA: 0x902E0 Offset: 0x8F6E0 VA: 0x1800902E0
	[DefaultValueAttribute] // RVA: 0x902E0 Offset: 0x8F6E0 VA: 0x1800902E0
	public bool IsAbstract { get; set; }
	[XmlAttributeAttribute] // RVA: 0x90430 Offset: 0x8F830 VA: 0x180090430
	[DefaultValueAttribute] // RVA: 0x90430 Offset: 0x8F830 VA: 0x180090430
	public XmlSchemaDerivationMethod Block { get; set; }
	[XmlAttributeAttribute] // RVA: 0x90720 Offset: 0x8FB20 VA: 0x180090720
	[DefaultValueAttribute] // RVA: 0x90720 Offset: 0x8FB20 VA: 0x180090720
	public override bool IsMixed { get; set; }
	[XmlElementAttribute] // RVA: 0x90850 Offset: 0x8FC50 VA: 0x180090850
	[XmlElementAttribute] // RVA: 0x90850 Offset: 0x8FC50 VA: 0x180090850
	public XmlSchemaContentModel ContentModel { get; set; }
	[XmlElementAttribute] // RVA: 0x90BA0 Offset: 0x8FFA0 VA: 0x180090BA0
	[XmlElementAttribute] // RVA: 0x90BA0 Offset: 0x8FFA0 VA: 0x180090BA0
	[XmlElementAttribute] // RVA: 0x90BA0 Offset: 0x8FFA0 VA: 0x180090BA0
	[XmlElementAttribute] // RVA: 0x90BA0 Offset: 0x8FFA0 VA: 0x180090BA0
	public XmlSchemaParticle Particle { get; set; }
	[XmlElementAttribute] // RVA: 0x90FA0 Offset: 0x903A0 VA: 0x180090FA0
	[XmlElementAttribute] // RVA: 0x90FA0 Offset: 0x903A0 VA: 0x180090FA0
	public XmlSchemaObjectCollection Attributes { get; }
	[XmlElementAttribute] // RVA: 0x8E4F0 Offset: 0x8D8F0 VA: 0x18008E4F0
	public XmlSchemaAnyAttribute AnyAttribute { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public XmlSchemaContentType ContentType { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public XmlSchemaParticle ContentTypeParticle { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public XmlSchemaDerivationMethod BlockResolved { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public XmlSchemaObjectTable AttributeUses { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public XmlSchemaAnyAttribute AttributeWildcard { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal XmlSchemaObjectTable LocalElements { get; }
	internal bool HasWildCard { set; }

	// Methods

	// RVA: 0x1049B30 Offset: 0x1048F30 VA: 0x181049B30
	private static void .cctor() { }

	// RVA: 0x1049230 Offset: 0x1048630 VA: 0x181049230
	private static XmlSchemaComplexType CreateAnyType(XmlSchemaContentProcessing processContents) { }

	// RVA: 0x1049E00 Offset: 0x1049200 VA: 0x181049E00
	public void .ctor() { }

	// RVA: 0x1049F00 Offset: 0x1049300 VA: 0x181049F00
	internal static XmlSchemaComplexType get_AnyType() { }

	// RVA: 0x104A110 Offset: 0x1049510 VA: 0x18104A110
	internal static XmlSchemaComplexType get_UntypedAnyType() { }

	// RVA: 0x1049E80 Offset: 0x1049280 VA: 0x181049E80
	internal static ContentValidator get_AnyTypeContentValidator() { }

	// RVA: 0x104A070 Offset: 0x1049470 VA: 0x18104A070
	public bool get_IsAbstract() { }

	// RVA: 0x104A1B0 Offset: 0x10495B0 VA: 0x18104A1B0
	public void set_IsAbstract(bool value) { }

	// RVA: 0xB96A00 Offset: 0xB95E00 VA: 0x180B96A00
	public XmlSchemaDerivationMethod get_Block() { }

	// RVA: 0x104A170 Offset: 0x1049570 VA: 0x18104A170
	public void set_Block(XmlSchemaDerivationMethod value) { }

	// RVA: 0x104A080 Offset: 0x1049480 VA: 0x18104A080 Slot: 14
	public override bool get_IsMixed() { }

	// RVA: 0x104A1E0 Offset: 0x10495E0 VA: 0x18104A1E0 Slot: 15
	public override void set_IsMixed(bool value) { }

	// RVA: 0x58DBC0 Offset: 0x58CFC0 VA: 0x18058DBC0
	public XmlSchemaContentModel get_ContentModel() { }

	// RVA: 0x58DC50 Offset: 0x58D050 VA: 0x18058DC50
	public void set_ContentModel(XmlSchemaContentModel value) { }

	// RVA: 0x9321E0 Offset: 0x9315E0 VA: 0x1809321E0
	public XmlSchemaParticle get_Particle() { }

	// RVA: 0xC53340 Offset: 0xC52740 VA: 0x180C53340
	public void set_Particle(XmlSchemaParticle value) { }

	// RVA: 0x1049FE0 Offset: 0x10493E0 VA: 0x181049FE0
	public XmlSchemaObjectCollection get_Attributes() { }

	// RVA: 0x7AACD0 Offset: 0x7AA0D0 VA: 0x1807AACD0
	public XmlSchemaAnyAttribute get_AnyAttribute() { }

	// RVA: 0xA2BE10 Offset: 0xA2B210 VA: 0x180A2BE10
	public void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	// RVA: 0xD22840 Offset: 0xD21C40 VA: 0x180D22840
	public XmlSchemaContentType get_ContentType() { }

	// RVA: 0x104A060 Offset: 0x1049460 VA: 0x18104A060
	public XmlSchemaParticle get_ContentTypeParticle() { }

	// RVA: 0xADE1D0 Offset: 0xADD5D0 VA: 0x180ADE1D0
	public XmlSchemaDerivationMethod get_BlockResolved() { }

	// RVA: 0x1049F60 Offset: 0x1049360 VA: 0x181049F60
	public XmlSchemaObjectTable get_AttributeUses() { }

	// RVA: 0x4EBD40 Offset: 0x4EB140 VA: 0x1804EBD40
	public XmlSchemaAnyAttribute get_AttributeWildcard() { }

	// RVA: 0x104A090 Offset: 0x1049490 VA: 0x18104A090
	internal XmlSchemaObjectTable get_LocalElements() { }

	// RVA: 0xEF5DD0 Offset: 0xEF51D0 VA: 0x180EF5DD0
	internal void SetContentTypeParticle(XmlSchemaParticle value) { }

	// RVA: 0x1049B20 Offset: 0x1048F20 VA: 0x181049B20
	internal void SetBlockResolved(XmlSchemaDerivationMethod value) { }

	// RVA: 0x4EBD50 Offset: 0x4EB150 VA: 0x1804EBD50
	internal void SetAttributeWildcard(XmlSchemaAnyAttribute value) { }

	// RVA: 0x104A180 Offset: 0x1049580 VA: 0x18104A180
	internal void set_HasWildCard(bool value) { }

	// RVA: 0xA2BE00 Offset: 0xA2B200 VA: 0x180A2BE00
	internal void SetAttributes(XmlSchemaObjectCollection newAttributes) { }

	// RVA: 0x1049000 Offset: 0x1048400 VA: 0x181049000
	internal bool ContainsIdAttribute(bool findAll) { }

	// RVA: 0x1048FF0 Offset: 0x10483F0 VA: 0x181048FF0 Slot: 13
	internal override XmlSchemaObject Clone() { }

	// RVA: 0x10485E0 Offset: 0x10479E0 VA: 0x1810485E0
	internal XmlSchemaObject Clone(XmlSchema parentSchema) { }

	// RVA: 0x1047C80 Offset: 0x1047080 VA: 0x181047C80
	private void ClearCompiledState() { }

	// RVA: 0x1047D40 Offset: 0x1047140 VA: 0x181047D40
	internal static XmlSchemaObjectCollection CloneAttributes(XmlSchemaObjectCollection attributes) { }

	// RVA: 0x1047FD0 Offset: 0x10473D0 VA: 0x181047FD0
	private static XmlSchemaObjectCollection CloneGroupBaseParticles(XmlSchemaObjectCollection groupBaseParticles, XmlSchema parentSchema) { }

	// RVA: 0x1048110 Offset: 0x1047510 VA: 0x181048110
	internal static XmlSchemaParticle CloneParticle(XmlSchemaParticle particle, XmlSchema parentSchema) { }

	// RVA: 0x1049670 Offset: 0x1048A70 VA: 0x181049670
	private static XmlSchemaForm GetResolvedElementForm(XmlSchema parentSchema, XmlSchemaElement element) { }

	// RVA: 0x1049810 Offset: 0x1048C10 VA: 0x181049810
	internal static bool HasParticleRef(XmlSchemaParticle particle, XmlSchema parentSchema) { }

	// RVA: 0x10496A0 Offset: 0x1048AA0 VA: 0x1810496A0
	internal static bool HasAttributeQNameRef(XmlSchemaObjectCollection attributes) { }

}

public abstract class XmlSchemaContent : XmlSchemaAnnotated // TypeDefIndex: 2325
{	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	protected void .ctor() { }

}

public abstract class XmlSchemaContentModel : XmlSchemaAnnotated // TypeDefIndex: 2326
{	// Properties
	[XmlIgnoreAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public abstract XmlSchemaContent Content { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 14
	public abstract XmlSchemaContent get_Content();

	// RVA: -1 Offset: -1 Slot: 15
	public abstract void set_Content(XmlSchemaContent value);

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	protected void .ctor() { }

}

public enum XmlSchemaContentProcessing // TypeDefIndex: 2327
{	// Fields
	public int value__; // 0x0
	[XmlIgnoreAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public const XmlSchemaContentProcessing None = 0;
	[XmlEnumAttribute] // RVA: 0x91610 Offset: 0x90A10 VA: 0x180091610
	public const XmlSchemaContentProcessing Skip = 1;
	[XmlEnumAttribute] // RVA: 0x91790 Offset: 0x90B90 VA: 0x180091790
	public const XmlSchemaContentProcessing Lax = 2;
	[XmlEnumAttribute] // RVA: 0x91840 Offset: 0x90C40 VA: 0x180091840
	public const XmlSchemaContentProcessing Strict = 3;

}

public enum XmlSchemaContentType // TypeDefIndex: 2328
{	// Fields
	public int value__; // 0x0
	public const XmlSchemaContentType TextOnly = 0;
	public const XmlSchemaContentType Empty = 1;
	public const XmlSchemaContentType ElementOnly = 2;
	public const XmlSchemaContentType Mixed = 3;

}

public abstract class XmlSchemaDatatype // TypeDefIndex: 2329
{	// Properties
	public abstract Type ValueType { get; }
	public abstract XmlTokenizedType TokenizedType { get; }
	public virtual XmlSchemaDatatypeVariety Variety { get; }
	public virtual XmlTypeCode TypeCode { get; }
	internal abstract bool HasLexicalFacets { get; }
	internal abstract bool HasValueFacets { get; }
	internal abstract XmlValueConverter ValueConverter { get; }
	internal abstract RestrictionFacets Restriction { get; }
	internal abstract FacetsChecker FacetsChecker { get; }
	internal abstract XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	internal string TypeCodeString { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract Type get_ValueType();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract XmlTokenizedType get_TokenizedType();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr);

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 7
	public virtual XmlSchemaDatatypeVariety get_Variety() { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 8
	public virtual XmlTypeCode get_TypeCode() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 9
	public virtual bool IsDerivedFrom(XmlSchemaDatatype datatype) { }

	// RVA: -1 Offset: -1 Slot: 10
	internal abstract bool get_HasLexicalFacets();

	// RVA: -1 Offset: -1 Slot: 11
	internal abstract bool get_HasValueFacets();

	// RVA: -1 Offset: -1 Slot: 12
	internal abstract XmlValueConverter get_ValueConverter();

	// RVA: -1 Offset: -1 Slot: 13
	internal abstract RestrictionFacets get_Restriction();

	// RVA: -1 Offset: -1 Slot: 14
	internal abstract int Compare(object value1, object value2);

	// RVA: -1 Offset: -1 Slot: 15
	internal abstract object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, bool createAtomicValue);

	// RVA: -1 Offset: -1 Slot: 16
	internal abstract Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue);

	// RVA: -1 Offset: -1 Slot: 17
	internal abstract Exception TryParseValue(object value, XmlNameTable nameTable, IXmlNamespaceResolver namespaceResolver, out object typedValue);

	// RVA: -1 Offset: -1 Slot: 18
	internal abstract FacetsChecker get_FacetsChecker();

	// RVA: -1 Offset: -1 Slot: 19
	internal abstract XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet();

	// RVA: -1 Offset: -1 Slot: 20
	internal abstract XmlSchemaDatatype DeriveByRestriction(XmlSchemaObjectCollection facets, XmlNameTable nameTable, XmlSchemaType schemaType);

	// RVA: -1 Offset: -1 Slot: 21
	internal abstract XmlSchemaDatatype DeriveByList(XmlSchemaType schemaType);

	// RVA: -1 Offset: -1 Slot: 22
	internal abstract void VerifySchemaValid(XmlSchemaObjectTable notations, XmlSchemaObject caller);

	// RVA: -1 Offset: -1 Slot: 23
	internal abstract bool IsEqual(object o1, object o2);

	// RVA: -1 Offset: -1 Slot: 24
	internal abstract bool IsComparable(XmlSchemaDatatype dtype);

	// RVA: 0x104AD00 Offset: 0x104A100 VA: 0x18104AD00
	internal string get_TypeCodeString() { }

	// RVA: 0x104A7D0 Offset: 0x1049BD0 VA: 0x18104A7D0
	internal string TypeCodeToString(XmlTypeCode typeCode) { }

	// RVA: 0x104A210 Offset: 0x1049610 VA: 0x18104A210
	internal static string ConcatenatedToString(object value) { }

	// RVA: 0x104A780 Offset: 0x1049B80 VA: 0x18104A780
	internal static XmlSchemaDatatype FromXmlTokenizedType(XmlTokenizedType token) { }

	// RVA: 0x104A730 Offset: 0x1049B30 VA: 0x18104A730
	internal static XmlSchemaDatatype FromXmlTokenizedTypeXsd(XmlTokenizedType token) { }

	// RVA: 0x104A6D0 Offset: 0x1049AD0 VA: 0x18104A6D0
	internal static XmlSchemaDatatype FromXdrName(string name) { }

	// RVA: 0x104A660 Offset: 0x1049A60 VA: 0x18104A660
	internal static XmlSchemaDatatype DeriveByUnion(XmlSchemaSimpleType[] types, XmlSchemaType schemaType) { }

	// RVA: 0x104AB60 Offset: 0x1049F60 VA: 0x18104AB60
	internal static string XdrCanonizeUri(string uri, XmlNameTable nameTable, SchemaNames schemaNames) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	protected void .ctor() { }

}

public enum XmlSchemaDerivationMethod // TypeDefIndex: 2330
{	// Fields
	public int value__; // 0x0
	[XmlEnumAttribute] // RVA: 0x91A80 Offset: 0x90E80 VA: 0x180091A80
	public const XmlSchemaDerivationMethod Empty = 0;
	[XmlEnumAttribute] // RVA: 0x92E30 Offset: 0x92230 VA: 0x180092E30
	public const XmlSchemaDerivationMethod Substitution = 1;
	[XmlEnumAttribute] // RVA: 0x92EF0 Offset: 0x922F0 VA: 0x180092EF0
	public const XmlSchemaDerivationMethod Extension = 2;
	[XmlEnumAttribute] // RVA: 0x92F50 Offset: 0x92350 VA: 0x180092F50
	public const XmlSchemaDerivationMethod Restriction = 4;
	[XmlEnumAttribute] // RVA: 0x93000 Offset: 0x92400 VA: 0x180093000
	public const XmlSchemaDerivationMethod List = 8;
	[XmlEnumAttribute] // RVA: 0x93110 Offset: 0x92510 VA: 0x180093110
	public const XmlSchemaDerivationMethod Union = 16;
	[XmlEnumAttribute] // RVA: 0x93270 Offset: 0x92670 VA: 0x180093270
	public const XmlSchemaDerivationMethod All = 255;
	[XmlIgnoreAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public const XmlSchemaDerivationMethod None = 256;

}

public class XmlSchemaDocumentation : XmlSchemaObject // TypeDefIndex: 2331
{	// Fields
	private string source; // 0x38
	private string language; // 0x40
	private XmlNode[] markup; // 0x48
	private static XmlSchemaSimpleType languageType; // 0x0

	// Properties
	[XmlAttributeAttribute] // RVA: 0x8D1F0 Offset: 0x8C5F0 VA: 0x18008D1F0
	public string Source { set; }
	[XmlAttributeAttribute] // RVA: 0x93460 Offset: 0x92860 VA: 0x180093460
	public string Language { set; }
	[XmlAnyElementAttribute] // RVA: 0x93530 Offset: 0x92930 VA: 0x180093530
	[XmlTextAttribute] // RVA: 0x93530 Offset: 0x92930 VA: 0x180093530
	public XmlNode[] Markup { set; }

	// Methods

	// RVA: 0x5089D0 Offset: 0x507DD0 VA: 0x1805089D0
	public void set_Source(string value) { }

	// RVA: 0x104AEC0 Offset: 0x104A2C0 VA: 0x18104AEC0
	public void set_Language(string value) { }

	// RVA: 0x5F7050 Offset: 0x5F6450 VA: 0x1805F7050
	public void set_Markup(XmlNode[] value) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x104AE30 Offset: 0x104A230 VA: 0x18104AE30
	private static void .cctor() { }

}

public class XmlSchemaElement : XmlSchemaParticle // TypeDefIndex: 2332
{	// Fields
	private bool isAbstract; // 0x78
	private bool hasAbstractAttribute; // 0x79
	private bool isNillable; // 0x7A
	private bool hasNillableAttribute; // 0x7B
	private bool isLocalTypeDerivationChecked; // 0x7C
	private XmlSchemaDerivationMethod block; // 0x80
	private XmlSchemaDerivationMethod final; // 0x84
	private XmlSchemaForm form; // 0x88
	private string defaultValue; // 0x90
	private string fixedValue; // 0x98
	private string name; // 0xA0
	private XmlQualifiedName refName; // 0xA8
	private XmlQualifiedName substitutionGroup; // 0xB0
	private XmlQualifiedName typeName; // 0xB8
	private XmlSchemaType type; // 0xC0
	private XmlQualifiedName qualifiedName; // 0xC8
	private XmlSchemaType elementType; // 0xD0
	private XmlSchemaDerivationMethod blockResolved; // 0xD8
	private XmlSchemaDerivationMethod finalResolved; // 0xDC
	private XmlSchemaObjectCollection constraints; // 0xE0
	private SchemaElementDecl elementDecl; // 0xE8

	// Properties
	[XmlAttributeAttribute] // RVA: 0x902E0 Offset: 0x8F6E0 VA: 0x1800902E0
	[DefaultValueAttribute] // RVA: 0x902E0 Offset: 0x8F6E0 VA: 0x1800902E0
	public bool IsAbstract { get; set; }
	[DefaultValueAttribute] // RVA: 0x93700 Offset: 0x92B00 VA: 0x180093700
	[XmlAttributeAttribute] // RVA: 0x93700 Offset: 0x92B00 VA: 0x180093700
	public XmlSchemaDerivationMethod Block { get; set; }
	[XmlAttributeAttribute] // RVA: 0x8D420 Offset: 0x8C820 VA: 0x18008D420
	[DefaultValueAttribute] // RVA: 0x8D420 Offset: 0x8C820 VA: 0x18008D420
	public string DefaultValue { get; set; }
	[DefaultValueAttribute] // RVA: 0x938C0 Offset: 0x92CC0 VA: 0x1800938C0
	[XmlAttributeAttribute] // RVA: 0x938C0 Offset: 0x92CC0 VA: 0x1800938C0
	public XmlSchemaDerivationMethod Final { get; set; }
	[DefaultValueAttribute] // RVA: 0x8D4A0 Offset: 0x8C8A0 VA: 0x18008D4A0
	[XmlAttributeAttribute] // RVA: 0x8D4A0 Offset: 0x8C8A0 VA: 0x18008D4A0
	public string FixedValue { get; set; }
	[DefaultValueAttribute] // RVA: 0x93AF0 Offset: 0x92EF0 VA: 0x180093AF0
	[XmlAttributeAttribute] // RVA: 0x93AF0 Offset: 0x92EF0 VA: 0x180093AF0
	public XmlSchemaForm Form { get; set; }
	[DefaultValueAttribute] // RVA: 0x93CA0 Offset: 0x930A0 VA: 0x180093CA0
	[XmlAttributeAttribute] // RVA: 0x93CA0 Offset: 0x930A0 VA: 0x180093CA0
	public string Name { get; set; }
	[XmlAttributeAttribute] // RVA: 0x93D90 Offset: 0x93190 VA: 0x180093D90
	[DefaultValueAttribute] // RVA: 0x93D90 Offset: 0x93190 VA: 0x180093D90
	public bool IsNillable { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal bool HasNillableAttribute { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal bool HasAbstractAttribute { get; }
	[XmlAttributeAttribute] // RVA: 0x8D9C0 Offset: 0x8CDC0 VA: 0x18008D9C0
	public XmlQualifiedName RefName { get; set; }
	[XmlAttributeAttribute] // RVA: 0x94040 Offset: 0x93440 VA: 0x180094040
	public XmlQualifiedName SubstitutionGroup { get; set; }
	[XmlAttributeAttribute] // RVA: 0x8DA50 Offset: 0x8CE50 VA: 0x18008DA50
	public XmlQualifiedName SchemaTypeName { get; set; }
	[XmlElementAttribute] // RVA: 0x94110 Offset: 0x93510 VA: 0x180094110
	[XmlElementAttribute] // RVA: 0x94110 Offset: 0x93510 VA: 0x180094110
	public XmlSchemaType SchemaType { get; set; }
	[XmlElementAttribute] // RVA: 0x94270 Offset: 0x93670 VA: 0x180094270
	[XmlElementAttribute] // RVA: 0x94270 Offset: 0x93670 VA: 0x180094270
	[XmlElementAttribute] // RVA: 0x94270 Offset: 0x93670 VA: 0x180094270
	public XmlSchemaObjectCollection Constraints { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public XmlQualifiedName QualifiedName { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public XmlSchemaType ElementSchemaType { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public XmlSchemaDerivationMethod BlockResolved { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public XmlSchemaDerivationMethod FinalResolved { get; }
	internal bool HasConstraints { get; }
	internal bool IsLocalTypeDerivationChecked { get; set; }
	internal SchemaElementDecl ElementDecl { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal override string NameAttribute { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal override string NameString { get; }

	// Methods

	// RVA: 0x935050 Offset: 0x934450 VA: 0x180935050
	public bool get_IsAbstract() { }

	// RVA: 0x104B470 Offset: 0x104A870 VA: 0x18104B470
	public void set_IsAbstract(bool value) { }

	// RVA: 0x59C1A0 Offset: 0x59B5A0 VA: 0x18059C1A0
	public XmlSchemaDerivationMethod get_Block() { }

	// RVA: 0x59C1B0 Offset: 0x59B5B0 VA: 0x18059C1B0
	public void set_Block(XmlSchemaDerivationMethod value) { }

	// RVA: 0x4E09F0 Offset: 0x4DFDF0 VA: 0x1804E09F0
	public string get_DefaultValue() { }

	// RVA: 0x4E0A00 Offset: 0x4DFE00 VA: 0x1804E0A00
	public void set_DefaultValue(string value) { }

	// RVA: 0x104B3C0 Offset: 0x104A7C0 VA: 0x18104B3C0
	public XmlSchemaDerivationMethod get_Final() { }

	// RVA: 0x104B460 Offset: 0x104A860 VA: 0x18104B460
	public void set_Final(XmlSchemaDerivationMethod value) { }

	// RVA: 0x58DBE0 Offset: 0x58CFE0 VA: 0x18058DBE0
	public string get_FixedValue() { }

	// RVA: 0x58DC70 Offset: 0x58D070 VA: 0x18058DC70
	public void set_FixedValue(string value) { }

	// RVA: 0x5A44D0 Offset: 0x5A38D0 VA: 0x1805A44D0
	public XmlSchemaForm get_Form() { }

	// RVA: 0xF86EB0 Offset: 0xF862B0 VA: 0x180F86EB0
	public void set_Form(XmlSchemaForm value) { }

	// RVA: 0x58DBC0 Offset: 0x58CFC0 VA: 0x18058DBC0
	public string get_Name() { }

	// RVA: 0x58DC50 Offset: 0x58D050 VA: 0x18058DC50
	public void set_Name(string value) { }

	// RVA: 0x104B420 Offset: 0x104A820 VA: 0x18104B420
	public bool get_IsNillable() { }

	// RVA: 0x104B480 Offset: 0x104A880 VA: 0x18104B480
	public void set_IsNillable(bool value) { }

	// RVA: 0x104B410 Offset: 0x104A810 VA: 0x18104B410
	internal bool get_HasNillableAttribute() { }

	// RVA: 0x104B3D0 Offset: 0x104A7D0 VA: 0x18104B3D0
	internal bool get_HasAbstractAttribute() { }

	// RVA: 0x9321E0 Offset: 0x9315E0 VA: 0x1809321E0
	public XmlQualifiedName get_RefName() { }

	// RVA: 0x104B490 Offset: 0x104A890 VA: 0x18104B490
	public void set_RefName(XmlQualifiedName value) { }

	// RVA: 0x972280 Offset: 0x971680 VA: 0x180972280
	public XmlQualifiedName get_SubstitutionGroup() { }

	// RVA: 0x104B610 Offset: 0x104AA10 VA: 0x18104B610
	public void set_SubstitutionGroup(XmlQualifiedName value) { }

	// RVA: 0x7AACD0 Offset: 0x7AA0D0 VA: 0x1807AACD0
	public XmlQualifiedName get_SchemaTypeName() { }

	// RVA: 0x104B550 Offset: 0x104A950 VA: 0x18104B550
	public void set_SchemaTypeName(XmlQualifiedName value) { }

	// RVA: 0x104A060 Offset: 0x1049460 VA: 0x18104A060
	public XmlSchemaType get_SchemaType() { }

	// RVA: 0xEF5DD0 Offset: 0xEF51D0 VA: 0x180EF5DD0
	public void set_SchemaType(XmlSchemaType value) { }

	// RVA: 0x104B330 Offset: 0x104A730 VA: 0x18104B330
	public XmlSchemaObjectCollection get_Constraints() { }

	// RVA: 0xD9B0A0 Offset: 0xD9A4A0 VA: 0x180D9B0A0
	public XmlQualifiedName get_QualifiedName() { }

	// RVA: 0xC53130 Offset: 0xC52530 VA: 0x180C53130
	public XmlSchemaType get_ElementSchemaType() { }

	// RVA: 0x104B320 Offset: 0x104A720 VA: 0x18104B320
	public XmlSchemaDerivationMethod get_BlockResolved() { }

	// RVA: 0x104B3B0 Offset: 0x104A7B0 VA: 0x18104B3B0
	public XmlSchemaDerivationMethod get_FinalResolved() { }

	// RVA: 0xD9B480 Offset: 0xD9A880 VA: 0x180D9B480
	internal void SetQualifiedName(XmlQualifiedName value) { }

	// RVA: 0xC53280 Offset: 0xC52680 VA: 0x180C53280
	internal void SetElementType(XmlSchemaType value) { }

	// RVA: 0x104B1F0 Offset: 0x104A5F0 VA: 0x18104B1F0
	internal void SetBlockResolved(XmlSchemaDerivationMethod value) { }

	// RVA: 0x104B200 Offset: 0x104A600 VA: 0x18104B200
	internal void SetFinalResolved(XmlSchemaDerivationMethod value) { }

	// RVA: 0x104B3E0 Offset: 0x104A7E0 VA: 0x18104B3E0
	internal bool get_HasConstraints() { }

	// RVA: 0x9619E0 Offset: 0x960DE0 VA: 0x1809619E0
	internal bool get_IsLocalTypeDerivationChecked() { }

	// RVA: 0x9619F0 Offset: 0x960DF0 VA: 0x1809619F0
	internal void set_IsLocalTypeDerivationChecked(bool value) { }

	// RVA: 0x94E830 Offset: 0x94DC30 VA: 0x18094E830
	internal SchemaElementDecl get_ElementDecl() { }

	// RVA: 0x94E8B0 Offset: 0x94DCB0 VA: 0x18094E8B0
	internal void set_ElementDecl(SchemaElementDecl value) { }

	// RVA: 0x58DBC0 Offset: 0x58CFC0 VA: 0x18058DBC0 Slot: 11
	internal override string get_NameAttribute() { }

	// RVA: 0x58DC50 Offset: 0x58D050 VA: 0x18058DC50 Slot: 12
	internal override void set_NameAttribute(string value) { }

	// RVA: 0x104B430 Offset: 0x104A830 VA: 0x18104B430 Slot: 15
	internal override string get_NameString() { }

	// RVA: 0x104B1E0 Offset: 0x104A5E0 VA: 0x18104B1E0 Slot: 13
	internal override XmlSchemaObject Clone() { }

	// RVA: 0x104AF90 Offset: 0x104A390 VA: 0x18104AF90
	internal XmlSchemaObject Clone(XmlSchema parentSchema) { }

	// RVA: 0x104B210 Offset: 0x104A610 VA: 0x18104B210
	public void .ctor() { }

}

public class XmlSchemaException : SystemException // TypeDefIndex: 2333
{	// Fields
	private string res; // 0x88
	private string[] args; // 0x90
	private string sourceUri; // 0x98
	private int lineNumber; // 0xA0
	private int linePosition; // 0xA4
	private XmlSchemaObject sourceSchemaObject; // 0xA8
	private string message; // 0xB0

	// Properties
	internal string GetRes { get; }
	internal string[] Args { get; }
	public string SourceUri { get; }
	public int LineNumber { get; }
	public int LinePosition { get; }
	public XmlSchemaObject SourceSchemaObject { get; }
	public override string Message { get; }

	// Methods

	// RVA: 0x104C0A0 Offset: 0x104B4A0 VA: 0x18104C0A0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x104B770 Offset: 0x104AB70 VA: 0x18104B770 Slot: 10
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x104C490 Offset: 0x104B890 VA: 0x18104C490
	public void .ctor() { }

	// RVA: 0x104BB00 Offset: 0x104AF00 VA: 0x18104BB00
	public void .ctor(string message) { }

	// RVA: 0x104BF90 Offset: 0x104B390 VA: 0x18104BF90
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x104BC50 Offset: 0x104B050 VA: 0x18104BC50
	public void .ctor(string message, Exception innerException, int lineNumber, int linePosition) { }

	// RVA: 0x104C3F0 Offset: 0x104B7F0 VA: 0x18104C3F0
	internal void .ctor(string res, string[] args) { }

	// RVA: 0x104B9C0 Offset: 0x104ADC0 VA: 0x18104B9C0
	internal void .ctor(string res, string arg) { }

	// RVA: 0x104BE80 Offset: 0x104B280 VA: 0x18104BE80
	internal void .ctor(string res, string arg, string sourceUri, int lineNumber, int linePosition) { }

	// RVA: 0x104B980 Offset: 0x104AD80 VA: 0x18104B980
	internal void .ctor(string res, string sourceUri, int lineNumber, int linePosition) { }

	// RVA: 0xD22B90 Offset: 0xD21F90 VA: 0x180D22B90
	internal void .ctor(string res, string[] args, string sourceUri, int lineNumber, int linePosition) { }

	// RVA: 0x104B930 Offset: 0x104AD30 VA: 0x18104B930
	internal void .ctor(string res, XmlSchemaObject source) { }

	// RVA: 0x104BD70 Offset: 0x104B170 VA: 0x18104BD70
	internal void .ctor(string res, string arg, XmlSchemaObject source) { }

	// RVA: 0x104BC00 Offset: 0x104B000 VA: 0x18104BC00
	internal void .ctor(string res, string[] args, XmlSchemaObject source) { }

	// RVA: 0x104C550 Offset: 0x104B950 VA: 0x18104C550
	internal void .ctor(string res, string[] args, Exception innerException, string sourceUri, int lineNumber, int linePosition, XmlSchemaObject source) { }

	// RVA: 0x104B6F0 Offset: 0x104AAF0 VA: 0x18104B6F0
	internal static string CreateMessage(string res, string[] args) { }

	// RVA: 0x58DBD0 Offset: 0x58CFD0 VA: 0x18058DBD0
	internal string get_GetRes() { }

	// RVA: 0x4E09F0 Offset: 0x4DFDF0 VA: 0x1804E09F0
	internal string[] get_Args() { }

	// RVA: 0x58DBE0 Offset: 0x58CFE0 VA: 0x18058DBE0
	public string get_SourceUri() { }

	// RVA: 0x104C610 Offset: 0x104BA10 VA: 0x18104C610
	public int get_LineNumber() { }

	// RVA: 0x104C620 Offset: 0x104BA20 VA: 0x18104C620
	public int get_LinePosition() { }

	// RVA: 0x9321E0 Offset: 0x9315E0 VA: 0x1809321E0
	public XmlSchemaObject get_SourceSchemaObject() { }

	// RVA: 0x104B880 Offset: 0x104AC80 VA: 0x18104B880
	internal void SetSource(string sourceUri, int lineNumber, int linePosition) { }

	// RVA: 0xC53340 Offset: 0xC52740 VA: 0x180C53340
	internal void SetSchemaObject(XmlSchemaObject source) { }

	// RVA: 0x104B8D0 Offset: 0x104ACD0 VA: 0x18104B8D0
	internal void SetSource(XmlSchemaObject source) { }

	// RVA: 0x104C630 Offset: 0x104BA30 VA: 0x18104C630 Slot: 5
	public override string get_Message() { }

}

public abstract class XmlSchemaExternal : XmlSchemaObject // TypeDefIndex: 2334
{	// Fields
	private string location; // 0x38
	private Uri baseUri; // 0x40
	private XmlSchema schema; // 0x48
	private string id; // 0x50
	private XmlAttribute[] moreAttributes; // 0x58
	private Compositor compositor; // 0x60

	// Properties
	[XmlAttributeAttribute] // RVA: 0x94840 Offset: 0x93C40 VA: 0x180094840
	public string SchemaLocation { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public XmlSchema Schema { get; set; }
	[XmlAttributeAttribute] // RVA: 0x8A9C0 Offset: 0x89DC0 VA: 0x18008A9C0
	public string Id { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal Uri BaseUri { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal override string IdAttribute { get; set; }
	internal Compositor Compositor { get; set; }

	// Methods

	// RVA: 0x5DCC00 Offset: 0x5DC000 VA: 0x1805DCC00
	public string get_SchemaLocation() { }

	// RVA: 0x5089D0 Offset: 0x507DD0 VA: 0x1805089D0
	public void set_SchemaLocation(string value) { }

	// RVA: 0x5DCCA0 Offset: 0x5DC0A0 VA: 0x1805DCCA0
	public XmlSchema get_Schema() { }

	// RVA: 0x5F7050 Offset: 0x5F6450 VA: 0x1805F7050
	public void set_Schema(XmlSchema value) { }

	// RVA: 0x4CC350 Offset: 0x4CB750 VA: 0x1804CC350
	public string get_Id() { }

	// RVA: 0x4CC370 Offset: 0x4CB770 VA: 0x1804CC370
	public void set_Id(string value) { }

	// RVA: 0x4B9440 Offset: 0x4B8840 VA: 0x1804B9440
	internal Uri get_BaseUri() { }

	// RVA: 0x4B94A0 Offset: 0x4B88A0 VA: 0x1804B94A0
	internal void set_BaseUri(Uri value) { }

	// RVA: 0x4CC350 Offset: 0x4CB750 VA: 0x1804CC350 Slot: 7
	internal override string get_IdAttribute() { }

	// RVA: 0x4CC370 Offset: 0x4CB770 VA: 0x1804CC370 Slot: 8
	internal override void set_IdAttribute(string value) { }

	// RVA: 0x4CC360 Offset: 0x4CB760 VA: 0x1804CC360 Slot: 9
	internal override void SetUnhandledAttributes(XmlAttribute[] moreAttributes) { }

	// RVA: 0x58DC10 Offset: 0x58D010 VA: 0x18058DC10
	internal Compositor get_Compositor() { }

	// RVA: 0x58DCA0 Offset: 0x58D0A0 VA: 0x18058DCA0
	internal void set_Compositor(Compositor value) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	protected void .ctor() { }

}

public abstract class XmlSchemaFacet : XmlSchemaAnnotated // TypeDefIndex: 2336
{	// Fields
	private string value; // 0x50
	private bool isFixed; // 0x58
	private FacetType facetType; // 0x5C

	// Properties
	[XmlAttributeAttribute] // RVA: 0x94BA0 Offset: 0x93FA0 VA: 0x180094BA0
	public string Value { get; set; }
	[DefaultValueAttribute] // RVA: 0x94C60 Offset: 0x94060 VA: 0x180094C60
	[XmlAttributeAttribute] // RVA: 0x94C60 Offset: 0x94060 VA: 0x180094C60
	public virtual bool IsFixed { get; set; }
	internal FacetType FacetType { get; set; }

	// Methods

	// RVA: 0x4CC350 Offset: 0x4CB750 VA: 0x1804CC350
	public string get_Value() { }

	// RVA: 0x4CC370 Offset: 0x4CB770 VA: 0x1804CC370
	public void set_Value(string value) { }

	// RVA: 0x5ABE90 Offset: 0x5AB290 VA: 0x1805ABE90 Slot: 14
	public virtual bool get_IsFixed() { }

	// RVA: 0x104C650 Offset: 0x104BA50 VA: 0x18104C650 Slot: 15
	public virtual void set_IsFixed(bool value) { }

	// RVA: 0x58DC00 Offset: 0x58D000 VA: 0x18058DC00
	internal FacetType get_FacetType() { }

	// RVA: 0x58DC90 Offset: 0x58D090 VA: 0x18058DC90
	internal void set_FacetType(FacetType value) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	protected void .ctor() { }

}

public abstract class XmlSchemaNumericFacet : XmlSchemaFacet // TypeDefIndex: 2337
{	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	protected void .ctor() { }

}

public class XmlSchemaLengthFacet : XmlSchemaNumericFacet // TypeDefIndex: 2338
{	// Methods

	// RVA: 0x10575B0 Offset: 0x10569B0 VA: 0x1810575B0
	public void .ctor() { }

}

public class XmlSchemaMinLengthFacet : XmlSchemaNumericFacet // TypeDefIndex: 2339
{	// Methods

	// RVA: 0x1057670 Offset: 0x1056A70 VA: 0x181057670
	public void .ctor() { }

}

public class XmlSchemaMaxLengthFacet : XmlSchemaNumericFacet // TypeDefIndex: 2340
{	// Methods

	// RVA: 0x1057610 Offset: 0x1056A10 VA: 0x181057610
	public void .ctor() { }

}

public class XmlSchemaPatternFacet : XmlSchemaFacet // TypeDefIndex: 2341
{	// Methods

	// RVA: 0x1059330 Offset: 0x1058730 VA: 0x181059330
	public void .ctor() { }

}

public class XmlSchemaEnumerationFacet : XmlSchemaFacet // TypeDefIndex: 2342
{	// Methods

	// RVA: 0x104B6D0 Offset: 0x104AAD0 VA: 0x18104B6D0
	public void .ctor() { }

}

public class XmlSchemaMinExclusiveFacet : XmlSchemaFacet // TypeDefIndex: 2343
{	// Methods

	// RVA: 0x1057630 Offset: 0x1056A30 VA: 0x181057630
	public void .ctor() { }

}

public class XmlSchemaMinInclusiveFacet : XmlSchemaFacet // TypeDefIndex: 2344
{	// Methods

	// RVA: 0x1057650 Offset: 0x1056A50 VA: 0x181057650
	public void .ctor() { }

}

public class XmlSchemaMaxExclusiveFacet : XmlSchemaFacet // TypeDefIndex: 2345
{	// Methods

	// RVA: 0x10575D0 Offset: 0x10569D0 VA: 0x1810575D0
	public void .ctor() { }

}

public class XmlSchemaMaxInclusiveFacet : XmlSchemaFacet // TypeDefIndex: 2346
{	// Methods

	// RVA: 0x10575F0 Offset: 0x10569F0 VA: 0x1810575F0
	public void .ctor() { }

}

public class XmlSchemaTotalDigitsFacet : XmlSchemaNumericFacet // TypeDefIndex: 2347
{	// Methods

	// RVA: 0xD22200 Offset: 0xD21600 VA: 0x180D22200
	public void .ctor() { }

}

public class XmlSchemaFractionDigitsFacet : XmlSchemaNumericFacet // TypeDefIndex: 2348
{	// Methods

	// RVA: 0x104C710 Offset: 0x104BB10 VA: 0x18104C710
	public void .ctor() { }

}

public class XmlSchemaWhiteSpaceFacet : XmlSchemaFacet // TypeDefIndex: 2349
{	// Methods

	// RVA: 0xD300E0 Offset: 0xD2F4E0 VA: 0x180D300E0
	public void .ctor() { }

}

public enum XmlSchemaForm // TypeDefIndex: 2350
{	// Fields
	public int value__; // 0x0
	[XmlIgnoreAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public const XmlSchemaForm None = 0;
	[XmlEnumAttribute] // RVA: 0x94D80 Offset: 0x94180 VA: 0x180094D80
	public const XmlSchemaForm Qualified = 1;
	[XmlEnumAttribute] // RVA: 0x94EF0 Offset: 0x942F0 VA: 0x180094EF0
	public const XmlSchemaForm Unqualified = 2;

}

public class XmlSchemaGroup : XmlSchemaAnnotated // TypeDefIndex: 2351
{	// Fields
	private string name; // 0x50
	private XmlSchemaGroupBase particle; // 0x58
	private XmlSchemaParticle canonicalParticle; // 0x60
	private XmlQualifiedName qname; // 0x68
	private XmlSchemaGroup redefined; // 0x70
	private int selfReferenceCount; // 0x78

	// Properties
	[XmlAttributeAttribute] // RVA: 0x8D890 Offset: 0x8CC90 VA: 0x18008D890
	public string Name { get; set; }
	[XmlElementAttribute] // RVA: 0x95080 Offset: 0x94480 VA: 0x180095080
	[XmlElementAttribute] // RVA: 0x95080 Offset: 0x94480 VA: 0x180095080
	[XmlElementAttribute] // RVA: 0x95080 Offset: 0x94480 VA: 0x180095080
	public XmlSchemaGroupBase Particle { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public XmlQualifiedName QualifiedName { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal XmlSchemaParticle CanonicalParticle { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal XmlSchemaGroup Redefined { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal int SelfReferenceCount { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal override string NameAttribute { get; set; }

	// Methods

	// RVA: 0x4CC350 Offset: 0x4CB750 VA: 0x1804CC350
	public string get_Name() { }

	// RVA: 0x4CC370 Offset: 0x4CB770 VA: 0x1804CC370
	public void set_Name(string value) { }

	// RVA: 0x4CC340 Offset: 0x4CB740 VA: 0x1804CC340
	public XmlSchemaGroupBase get_Particle() { }

	// RVA: 0x4CC360 Offset: 0x4CB760 VA: 0x1804CC360
	public void set_Particle(XmlSchemaGroupBase value) { }

	// RVA: 0x5334F0 Offset: 0x5328F0 VA: 0x1805334F0
	public XmlQualifiedName get_QualifiedName() { }

	// RVA: 0x54FB60 Offset: 0x54EF60 VA: 0x18054FB60
	internal XmlSchemaParticle get_CanonicalParticle() { }

	// RVA: 0x54FB70 Offset: 0x54EF70 VA: 0x18054FB70
	internal void set_CanonicalParticle(XmlSchemaParticle value) { }

	// RVA: 0x58DC30 Offset: 0x58D030 VA: 0x18058DC30
	internal XmlSchemaGroup get_Redefined() { }

	// RVA: 0x58DCC0 Offset: 0x58D0C0 VA: 0x18058DCC0
	internal void set_Redefined(XmlSchemaGroup value) { }

	// RVA: 0xAF14F0 Offset: 0xAF08F0 VA: 0x180AF14F0
	internal int get_SelfReferenceCount() { }

	// RVA: 0xB24460 Offset: 0xB23860 VA: 0x180B24460
	internal void set_SelfReferenceCount(int value) { }

	// RVA: 0x4CC350 Offset: 0x4CB750 VA: 0x1804CC350 Slot: 11
	internal override string get_NameAttribute() { }

	// RVA: 0x4CC370 Offset: 0x4CB770 VA: 0x1804CC370 Slot: 12
	internal override void set_NameAttribute(string value) { }

	// RVA: 0x5336F0 Offset: 0x532AF0 VA: 0x1805336F0
	internal void SetQualifiedName(XmlQualifiedName value) { }

	// RVA: 0x104C8E0 Offset: 0x104BCE0 VA: 0x18104C8E0 Slot: 13
	internal override XmlSchemaObject Clone() { }

	// RVA: 0x104C8F0 Offset: 0x104BCF0 VA: 0x18104C8F0
	internal XmlSchemaObject Clone(XmlSchema parentSchema) { }

	// RVA: 0x104CAB0 Offset: 0x104BEB0 VA: 0x18104CAB0
	public void .ctor() { }

}

public abstract class XmlSchemaGroupBase : XmlSchemaParticle // TypeDefIndex: 2352
{	// Properties
	[XmlIgnoreAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public abstract XmlSchemaObjectCollection Items { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 16
	public abstract XmlSchemaObjectCollection get_Items();

	// RVA: -1 Offset: -1 Slot: 17
	internal abstract void SetItems(XmlSchemaObjectCollection newItems);

	// RVA: 0x104C730 Offset: 0x104BB30 VA: 0x18104C730
	protected void .ctor() { }

}

public class XmlSchemaGroupRef : XmlSchemaParticle // TypeDefIndex: 2353
{	// Fields
	private XmlQualifiedName refName; // 0x78
	private XmlSchemaGroupBase particle; // 0x80
	private XmlSchemaGroup refined; // 0x88

	// Properties
	[XmlAttributeAttribute] // RVA: 0x8D9C0 Offset: 0x8CDC0 VA: 0x18008D9C0
	public XmlQualifiedName RefName { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public XmlSchemaGroupBase Particle { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal XmlSchemaGroup Redefined { get; set; }

	// Methods

	// RVA: 0x4E4EC0 Offset: 0x4E42C0 VA: 0x1804E4EC0
	public XmlQualifiedName get_RefName() { }

	// RVA: 0x104C820 Offset: 0x104BC20 VA: 0x18104C820
	public void set_RefName(XmlQualifiedName value) { }

	// RVA: 0x58DC40 Offset: 0x58D040 VA: 0x18058DC40
	public XmlSchemaGroupBase get_Particle() { }

	// RVA: 0x58DCD0 Offset: 0x58D0D0 VA: 0x18058DCD0
	internal void SetParticle(XmlSchemaGroupBase value) { }

	// RVA: 0x58DBD0 Offset: 0x58CFD0 VA: 0x18058DBD0
	internal XmlSchemaGroup get_Redefined() { }

	// RVA: 0x58DC60 Offset: 0x58D060 VA: 0x18058DC60
	internal void set_Redefined(XmlSchemaGroup value) { }

	// RVA: 0x104C790 Offset: 0x104BB90 VA: 0x18104C790
	public void .ctor() { }

}

public class XmlSchemaIdentityConstraint : XmlSchemaAnnotated // TypeDefIndex: 2354
{	// Fields
	private string name; // 0x50
	private XmlSchemaXPath selector; // 0x58
	private XmlSchemaObjectCollection fields; // 0x60
	private XmlQualifiedName qualifiedName; // 0x68
	private CompiledIdentityConstraint compiledConstraint; // 0x70

	// Properties
	[XmlAttributeAttribute] // RVA: 0x8D890 Offset: 0x8CC90 VA: 0x18008D890
	public string Name { get; set; }
	[XmlElementAttribute] // RVA: 0x958B0 Offset: 0x94CB0 VA: 0x1800958B0
	public XmlSchemaXPath Selector { get; set; }
	[XmlElementAttribute] // RVA: 0x959C0 Offset: 0x94DC0 VA: 0x1800959C0
	public XmlSchemaObjectCollection Fields { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public XmlQualifiedName QualifiedName { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal CompiledIdentityConstraint CompiledConstraint { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal override string NameAttribute { get; set; }

	// Methods

	// RVA: 0x4CC350 Offset: 0x4CB750 VA: 0x1804CC350
	public string get_Name() { }

	// RVA: 0x4CC370 Offset: 0x4CB770 VA: 0x1804CC370
	public void set_Name(string value) { }

	// RVA: 0x4CC340 Offset: 0x4CB740 VA: 0x1804CC340
	public XmlSchemaXPath get_Selector() { }

	// RVA: 0x4CC360 Offset: 0x4CB760 VA: 0x1804CC360
	public void set_Selector(XmlSchemaXPath value) { }

	// RVA: 0x54FB60 Offset: 0x54EF60 VA: 0x18054FB60
	public XmlSchemaObjectCollection get_Fields() { }

	// RVA: 0x5334F0 Offset: 0x5328F0 VA: 0x1805334F0
	public XmlQualifiedName get_QualifiedName() { }

	// RVA: 0x5336F0 Offset: 0x532AF0 VA: 0x1805336F0
	internal void SetQualifiedName(XmlQualifiedName value) { }

	// RVA: 0x58DC30 Offset: 0x58D030 VA: 0x18058DC30
	internal CompiledIdentityConstraint get_CompiledConstraint() { }

	// RVA: 0x58DCC0 Offset: 0x58D0C0 VA: 0x18058DCC0
	internal void set_CompiledConstraint(CompiledIdentityConstraint value) { }

	// RVA: 0x4CC350 Offset: 0x4CB750 VA: 0x1804CC350 Slot: 11
	internal override string get_NameAttribute() { }

	// RVA: 0x4CC370 Offset: 0x4CB770 VA: 0x1804CC370 Slot: 12
	internal override void set_NameAttribute(string value) { }

	// RVA: 0x104CB30 Offset: 0x104BF30 VA: 0x18104CB30
	public void .ctor() { }

}

public class XmlSchemaXPath : XmlSchemaAnnotated // TypeDefIndex: 2355
{	// Fields
	private string xpath; // 0x50

	// Properties
	[XmlAttributeAttribute] // RVA: 0x95EA0 Offset: 0x952A0 VA: 0x180095EA0
	[DefaultValueAttribute] // RVA: 0x95EA0 Offset: 0x952A0 VA: 0x180095EA0
	public string XPath { get; set; }

	// Methods

	// RVA: 0x4CC350 Offset: 0x4CB750 VA: 0x1804CC350
	public string get_XPath() { }

	// RVA: 0x4CC370 Offset: 0x4CB770 VA: 0x1804CC370
	public void set_XPath(string value) { }

	// RVA: 0x7992B0 Offset: 0x7986B0 VA: 0x1807992B0
	public void .ctor() { }

}

public class XmlSchemaUnique : XmlSchemaIdentityConstraint // TypeDefIndex: 2356
{	// Methods

	// RVA: 0xD229E0 Offset: 0xD21DE0 VA: 0x180D229E0
	public void .ctor() { }

}

public class XmlSchemaKey : XmlSchemaIdentityConstraint // TypeDefIndex: 2357
{	// Methods

	// RVA: 0xD229E0 Offset: 0xD21DE0 VA: 0x180D229E0
	public void .ctor() { }

}

public class XmlSchemaKeyref : XmlSchemaIdentityConstraint // TypeDefIndex: 2358
{	// Fields
	private XmlQualifiedName refer; // 0x78

	// Properties
	[XmlAttributeAttribute] // RVA: 0x96050 Offset: 0x95450 VA: 0x180096050
	public XmlQualifiedName Refer { get; set; }

	// Methods

	// RVA: 0x4E4EC0 Offset: 0x4E42C0 VA: 0x1804E4EC0
	public XmlQualifiedName get_Refer() { }

	// RVA: 0x10574F0 Offset: 0x10568F0 VA: 0x1810574F0
	public void set_Refer(XmlQualifiedName value) { }

	// RVA: 0x1057470 Offset: 0x1056870 VA: 0x181057470
	public void .ctor() { }

}

public class XmlSchemaImport : XmlSchemaExternal // TypeDefIndex: 2359
{	// Fields
	private string ns; // 0x68
	private XmlSchemaAnnotation annotation; // 0x70

	// Properties
	[XmlAttributeAttribute] // RVA: 0x961B0 Offset: 0x955B0 VA: 0x1800961B0
	public string Namespace { get; set; }

	// Methods

	// RVA: 0x104CBE0 Offset: 0x104BFE0 VA: 0x18104CBE0
	public void .ctor() { }

	// RVA: 0x5334F0 Offset: 0x5328F0 VA: 0x1805334F0
	public string get_Namespace() { }

	// RVA: 0x5336F0 Offset: 0x532AF0 VA: 0x1805336F0
	public void set_Namespace(string value) { }

	// RVA: 0x58DCC0 Offset: 0x58D0C0 VA: 0x18058DCC0 Slot: 10
	internal override void AddAnnotation(XmlSchemaAnnotation annotation) { }

}

public class XmlSchemaInclude : XmlSchemaExternal // TypeDefIndex: 2360
{	// Fields
	private XmlSchemaAnnotation annotation; // 0x68

	// Methods

	// RVA: 0x104CC00 Offset: 0x104C000 VA: 0x18104CC00
	public void .ctor() { }

	// RVA: 0x5336F0 Offset: 0x532AF0 VA: 0x1805336F0 Slot: 10
	internal override void AddAnnotation(XmlSchemaAnnotation annotation) { }

}

public class XmlSchemaInfo : IXmlSchemaInfo // TypeDefIndex: 2361
{	// Fields
	private bool isDefault; // 0x10
	private bool isNil; // 0x11
	private XmlSchemaElement schemaElement; // 0x18
	private XmlSchemaAttribute schemaAttribute; // 0x20
	private XmlSchemaType schemaType; // 0x28
	private XmlSchemaSimpleType memberType; // 0x30
	private XmlSchemaValidity validity; // 0x38
	private XmlSchemaContentType contentType; // 0x3C

	// Properties
	public XmlSchemaValidity Validity { get; set; }
	public bool IsDefault { get; set; }
	public bool IsNil { get; set; }
	public XmlSchemaSimpleType MemberType { get; set; }
	public XmlSchemaType SchemaType { get; set; }
	public XmlSchemaElement SchemaElement { get; set; }
	public XmlSchemaAttribute SchemaAttribute { get; set; }
	public XmlSchemaContentType ContentType { get; }
	internal XmlSchemaType XmlType { get; }
	internal bool HasDefaultValue { get; }
	internal bool IsUnionType { get; }

	// Methods

	// RVA: 0x10572A0 Offset: 0x10566A0 VA: 0x1810572A0
	public void .ctor() { }

	// RVA: 0x1057220 Offset: 0x1056620 VA: 0x181057220
	internal void .ctor(XmlSchemaValidity validity) { }

	// RVA: 0x516B70 Offset: 0x515F70 VA: 0x180516B70 Slot: 4
	public XmlSchemaValidity get_Validity() { }

	// RVA: 0xC53FC0 Offset: 0xC533C0 VA: 0x180C53FC0
	public void set_Validity(XmlSchemaValidity value) { }

	// RVA: 0x497E20 Offset: 0x497220 VA: 0x180497E20 Slot: 5
	public bool get_IsDefault() { }

	// RVA: 0x497E50 Offset: 0x497250 VA: 0x180497E50
	public void set_IsDefault(bool value) { }

	// RVA: 0xF86260 Offset: 0xF85660 VA: 0x180F86260 Slot: 6
	public bool get_IsNil() { }

	// RVA: 0xF86270 Offset: 0xF85670 VA: 0x180F86270
	public void set_IsNil(bool value) { }

	// RVA: 0x4A2EE0 Offset: 0x4A22E0 VA: 0x1804A2EE0 Slot: 7
	public XmlSchemaSimpleType get_MemberType() { }

	// RVA: 0x4A2F10 Offset: 0x4A2310 VA: 0x1804A2F10
	public void set_MemberType(XmlSchemaSimpleType value) { }

	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230 Slot: 8
	public XmlSchemaType get_SchemaType() { }

	// RVA: 0x1057420 Offset: 0x1056820 VA: 0x181057420
	public void set_SchemaType(XmlSchemaType value) { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 9
	public XmlSchemaElement get_SchemaElement() { }

	// RVA: 0x10573E0 Offset: 0x10567E0 VA: 0x1810573E0
	public void set_SchemaElement(XmlSchemaElement value) { }

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00 Slot: 10
	public XmlSchemaAttribute get_SchemaAttribute() { }

	// RVA: 0x10573A0 Offset: 0x10567A0 VA: 0x1810573A0
	public void set_SchemaAttribute(XmlSchemaAttribute value) { }

	// RVA: 0x5FC790 Offset: 0x5FBB90 VA: 0x1805FC790
	public XmlSchemaContentType get_ContentType() { }

	// RVA: 0x1057390 Offset: 0x1056790 VA: 0x181057390
	internal XmlSchemaType get_XmlType() { }

	// RVA: 0x1057310 Offset: 0x1056710 VA: 0x181057310
	internal bool get_HasDefaultValue() { }

	// RVA: 0x1057350 Offset: 0x1056750 VA: 0x181057350
	internal bool get_IsUnionType() { }

	// RVA: 0x10571B0 Offset: 0x10565B0 VA: 0x1810571B0
	internal void Clear() { }

}

public class XmlSchemaNotation : XmlSchemaAnnotated // TypeDefIndex: 2362
{	// Fields
	private string name; // 0x50
	private string publicId; // 0x58
	private string systemId; // 0x60
	private XmlQualifiedName qname; // 0x68

	// Properties
	[XmlAttributeAttribute] // RVA: 0x8D890 Offset: 0x8CC90 VA: 0x18008D890
	public string Name { get; set; }
	[XmlAttributeAttribute] // RVA: 0x96200 Offset: 0x95600 VA: 0x180096200
	public string Public { get; set; }
	[XmlAttributeAttribute] // RVA: 0x96330 Offset: 0x95730 VA: 0x180096330
	public string System { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal XmlQualifiedName QualifiedName { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal override string NameAttribute { get; set; }

	// Methods

	// RVA: 0x4CC350 Offset: 0x4CB750 VA: 0x1804CC350
	public string get_Name() { }

	// RVA: 0x4CC370 Offset: 0x4CB770 VA: 0x1804CC370
	public void set_Name(string value) { }

	// RVA: 0x4CC340 Offset: 0x4CB740 VA: 0x1804CC340
	public string get_Public() { }

	// RVA: 0x4CC360 Offset: 0x4CB760 VA: 0x1804CC360
	public void set_Public(string value) { }

	// RVA: 0x54FB60 Offset: 0x54EF60 VA: 0x18054FB60
	public string get_System() { }

	// RVA: 0x54FB70 Offset: 0x54EF70 VA: 0x18054FB70
	public void set_System(string value) { }

	// RVA: 0x5334F0 Offset: 0x5328F0 VA: 0x1805334F0
	internal XmlQualifiedName get_QualifiedName() { }

	// RVA: 0x5336F0 Offset: 0x532AF0 VA: 0x1805336F0
	internal void set_QualifiedName(XmlQualifiedName value) { }

	// RVA: 0x4CC350 Offset: 0x4CB750 VA: 0x1804CC350 Slot: 11
	internal override string get_NameAttribute() { }

	// RVA: 0x4CC370 Offset: 0x4CB770 VA: 0x1804CC370 Slot: 12
	internal override void set_NameAttribute(string value) { }

	// RVA: 0x1057690 Offset: 0x1056A90 VA: 0x181057690
	public void .ctor() { }

}

public abstract class XmlSchemaObject // TypeDefIndex: 2363
{	// Fields
	private int lineNum; // 0x10
	private int linePos; // 0x14
	private string sourceUri; // 0x18
	private XmlSerializerNamespaces namespaces; // 0x20
	private XmlSchemaObject parent; // 0x28
	private bool isProcessing; // 0x30

	// Properties
	[XmlIgnoreAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public int LineNumber { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public int LinePosition { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public string SourceUri { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public XmlSchemaObject Parent { get; set; }
	[XmlNamespaceDeclarationsAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public XmlSerializerNamespaces Namespaces { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal virtual string IdAttribute { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal virtual string NameAttribute { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal bool IsProcessing { get; set; }

	// Methods

	// RVA: 0x36A480 Offset: 0x369880 VA: 0x18036A480
	public int get_LineNumber() { }

	// RVA: 0x596240 Offset: 0x595640 VA: 0x180596240
	public void set_LineNumber(int value) { }

	// RVA: 0x596230 Offset: 0x595630 VA: 0x180596230
	public int get_LinePosition() { }

	// RVA: 0x596250 Offset: 0x595650 VA: 0x180596250
	public void set_LinePosition(int value) { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public string get_SourceUri() { }

	// RVA: 0x4D0180 Offset: 0x4CF580 VA: 0x1804D0180
	public void set_SourceUri(string value) { }

	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230
	public XmlSchemaObject get_Parent() { }

	// RVA: 0x7CE240 Offset: 0x7CD640 VA: 0x1807CE240
	public void set_Parent(XmlSchemaObject value) { }

	// RVA: 0x1058720 Offset: 0x1057B20 VA: 0x181058720
	public XmlSerializerNamespaces get_Namespaces() { }

	// RVA: 0x497E30 Offset: 0x497230 VA: 0x180497E30
	public void set_Namespaces(XmlSerializerNamespaces value) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 4
	internal virtual void OnAdd(XmlSchemaObjectCollection container, object item) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 5
	internal virtual void OnRemove(XmlSchemaObjectCollection container, object item) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 6
	internal virtual void OnClear(XmlSchemaObjectCollection container) { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 7
	internal virtual string get_IdAttribute() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 8
	internal virtual void set_IdAttribute(string value) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 9
	internal virtual void SetUnhandledAttributes(XmlAttribute[] moreAttributes) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 10
	internal virtual void AddAnnotation(XmlSchemaAnnotation annotation) { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 11
	internal virtual string get_NameAttribute() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 12
	internal virtual void set_NameAttribute(string value) { }

	// RVA: 0x8298F0 Offset: 0x828CF0 VA: 0x1808298F0
	internal bool get_IsProcessing() { }

	// RVA: 0x829920 Offset: 0x828D20 VA: 0x180829920
	internal void set_IsProcessing(bool value) { }

	// RVA: 0x10586A0 Offset: 0x1057AA0 VA: 0x1810586A0 Slot: 13
	internal virtual XmlSchemaObject Clone() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	protected void .ctor() { }

}

public class XmlSchemaObjectCollection : CollectionBase // TypeDefIndex: 2364
{	// Fields
	private XmlSchemaObject parent; // 0x18

	// Properties
	public virtual XmlSchemaObject Item { get; set; }

	// Methods

	// RVA: 0x1057B30 Offset: 0x1056F30 VA: 0x181057B30
	public void .ctor() { }

	// RVA: 0x1057B40 Offset: 0x1056F40 VA: 0x181057B40 Slot: 28
	public virtual XmlSchemaObject get_Item(int index) { }

	// RVA: 0x1057C60 Offset: 0x1057060 VA: 0x181057C60 Slot: 29
	public virtual void set_Item(int index, XmlSchemaObject value) { }

	// RVA: 0x10578A0 Offset: 0x1056CA0 VA: 0x1810578A0
	public XmlSchemaObjectEnumerator GetEnumerator() { }

	// RVA: 0x1057750 Offset: 0x1056B50 VA: 0x181057750
	public int Add(XmlSchemaObject item) { }

	// RVA: 0x1057930 Offset: 0x1056D30 VA: 0x181057930
	public void Insert(int index, XmlSchemaObject item) { }

	// RVA: 0x1057A70 Offset: 0x1056E70 VA: 0x181057A70
	public void Remove(XmlSchemaObject item) { }

	// RVA: 0x10579D0 Offset: 0x1056DD0 VA: 0x1810579D0 Slot: 20
	protected override void OnInsert(int index, object item) { }

	// RVA: 0x1057A10 Offset: 0x1056E10 VA: 0x181057A10 Slot: 19
	protected override void OnSet(int index, object oldValue, object newValue) { }

	// RVA: 0x10579B0 Offset: 0x1056DB0 VA: 0x1810579B0 Slot: 21
	protected override void OnClear() { }

	// RVA: 0x10579F0 Offset: 0x1056DF0 VA: 0x1810579F0 Slot: 22
	protected override void OnRemove(int index, object item) { }

	// RVA: 0x1057810 Offset: 0x1056C10 VA: 0x181057810
	internal XmlSchemaObjectCollection Clone() { }

	// RVA: 0x1057710 Offset: 0x1056B10 VA: 0x181057710
	private void Add(XmlSchemaObjectCollection collToAdd) { }

}

public class XmlSchemaObjectEnumerator : IEnumerator // TypeDefIndex: 2365
{	// Fields
	private IEnumerator enumerator; // 0x10

	// Properties
	public XmlSchemaObject Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x6C0000 Offset: 0x6BF400 VA: 0x1806C0000
	internal void .ctor(IEnumerator enumerator) { }

	// RVA: 0x1057CE0 Offset: 0x10570E0 VA: 0x181057CE0
	public bool MoveNext() { }

	// RVA: 0x1057E20 Offset: 0x1057220 VA: 0x181057E20
	public XmlSchemaObject get_Current() { }

	// RVA: 0x1057D80 Offset: 0x1057180 VA: 0x181057D80 Slot: 6
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x1057D30 Offset: 0x1057130 VA: 0x181057D30 Slot: 4
	private bool System.Collections.IEnumerator.MoveNext() { }

	// RVA: 0x1057DD0 Offset: 0x10571D0 VA: 0x181057DD0 Slot: 5
	private object System.Collections.IEnumerator.get_Current() { }

}

public class XmlSchemaObjectTable // TypeDefIndex: 2366
{	// Fields
	private Dictionary<XmlQualifiedName, XmlSchemaObject> table; // 0x10
	private List<XmlSchemaObjectTable.XmlSchemaObjectEntry> entries; // 0x18

	// Properties
	public int Count { get; }
	public XmlSchemaObject Item { get; }
	public ICollection Values { get; }

	// Methods

	// RVA: 0x10584A0 Offset: 0x10578A0 VA: 0x1810584A0
	internal void .ctor() { }

	// RVA: 0x1057EC0 Offset: 0x10572C0 VA: 0x181057EC0
	internal void Add(XmlQualifiedName name, XmlSchemaObject value) { }

	// RVA: 0x10581A0 Offset: 0x10575A0 VA: 0x1810581A0
	internal void Insert(XmlQualifiedName name, XmlSchemaObject value) { }

	// RVA: 0x1058380 Offset: 0x1057780 VA: 0x181058380
	internal void Replace(XmlQualifiedName name, XmlSchemaObject value) { }

	// RVA: 0x1057F80 Offset: 0x1057380 VA: 0x181057F80
	internal void Clear() { }

	// RVA: 0x10582D0 Offset: 0x10576D0 VA: 0x1810582D0
	internal void Remove(XmlQualifiedName name) { }

	// RVA: 0x1058040 Offset: 0x1057440 VA: 0x181058040
	private int FindIndexByValue(XmlSchemaObject xso) { }

	// RVA: 0x1058540 Offset: 0x1057940 VA: 0x181058540
	public int get_Count() { }

	// RVA: 0x1057FE0 Offset: 0x10573E0 VA: 0x181057FE0
	public bool Contains(XmlQualifiedName name) { }

	// RVA: 0x1058590 Offset: 0x1057990 VA: 0x181058590
	public XmlSchemaObject get_Item(XmlQualifiedName name) { }

	// RVA: 0x1058610 Offset: 0x1057A10 VA: 0x181058610
	public ICollection get_Values() { }

	// RVA: 0x1058100 Offset: 0x1057500 VA: 0x181058100
	public IDictionaryEnumerator GetEnumerator() { }

}

internal enum XmlSchemaObjectTable.EnumeratorType // TypeDefIndex: 2367
{	// Fields
	public int value__; // 0x0
	public const XmlSchemaObjectTable.EnumeratorType Keys = 0;
	public const XmlSchemaObjectTable.EnumeratorType Values = 1;
	public const XmlSchemaObjectTable.EnumeratorType DictionaryEntry = 2;

}

internal struct XmlSchemaObjectTable.XmlSchemaObjectEntry // TypeDefIndex: 2368
{	// Fields
	internal XmlQualifiedName qname; // 0x0
	internal XmlSchemaObject xso; // 0x8

	// Methods

	// RVA: 0xF5940 Offset: 0xF4D40 VA: 0x1800F5940
	public void .ctor(XmlQualifiedName name, XmlSchemaObject value) { }

}

internal class XmlSchemaObjectTable.ValuesCollection : ICollection, IEnumerable // TypeDefIndex: 2369
{	// Fields
	private List<XmlSchemaObjectTable.XmlSchemaObjectEntry> entries; // 0x10
	private int size; // 0x18

	// Properties
	public int Count { get; }
	public object SyncRoot { get; }

	// Methods

	// RVA: 0xADFC40 Offset: 0xADF040 VA: 0x180ADFC40
	internal void .ctor(List<XmlSchemaObjectTable.XmlSchemaObjectEntry> entries, int size) { }

	// RVA: 0x4BE200 Offset: 0x4BD600 VA: 0x1804BE200 Slot: 5
	public int get_Count() { }

	// RVA: 0x1045290 Offset: 0x1044690 VA: 0x181045290 Slot: 6
	public object get_SyncRoot() { }

	// RVA: 0x10450E0 Offset: 0x10444E0 VA: 0x1810450E0 Slot: 4
	public void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x1045210 Offset: 0x1044610 VA: 0x181045210 Slot: 7
	public IEnumerator GetEnumerator() { }

}

internal class XmlSchemaObjectTable.XSOEnumerator : IEnumerator // TypeDefIndex: 2370
{	// Fields
	private List<XmlSchemaObjectTable.XmlSchemaObjectEntry> entries; // 0x10
	private XmlSchemaObjectTable.EnumeratorType enumType; // 0x18
	protected int currentIndex; // 0x1C
	protected int size; // 0x20
	protected XmlQualifiedName currentKey; // 0x28
	protected XmlSchemaObject currentValue; // 0x30

	// Properties
	public object Current { get; }

	// Methods

	// RVA: 0x10452E0 Offset: 0x10446E0 VA: 0x1810452E0
	internal void .ctor(List<XmlSchemaObjectTable.XmlSchemaObjectEntry> entries, int size, XmlSchemaObjectTable.EnumeratorType enumType) { }

	// RVA: 0x10458E0 Offset: 0x1044CE0 VA: 0x1810458E0 Slot: 5
	public object get_Current() { }

	// RVA: 0x10457A0 Offset: 0x1044BA0 VA: 0x1810457A0 Slot: 4
	public bool MoveNext() { }

	// RVA: 0x10458A0 Offset: 0x1044CA0 VA: 0x1810458A0 Slot: 6
	public void Reset() { }

}

internal class XmlSchemaObjectTable.XSODictionaryEnumerator : XmlSchemaObjectTable.XSOEnumerator, IDictionaryEnumerator, IEnumerator // TypeDefIndex: 2371
{	// Properties
	public DictionaryEntry Entry { get; }
	public object Key { get; }
	public object Value { get; }

	// Methods

	// RVA: 0x10452E0 Offset: 0x10446E0 VA: 0x1810452E0
	internal void .ctor(List<XmlSchemaObjectTable.XmlSchemaObjectEntry> entries, int size, XmlSchemaObjectTable.EnumeratorType enumType) { }

	// RVA: 0x1045340 Offset: 0x1044740 VA: 0x181045340 Slot: 9
	public DictionaryEntry get_Entry() { }

	// RVA: 0x10454C0 Offset: 0x10448C0 VA: 0x1810454C0 Slot: 7
	public object get_Key() { }

	// RVA: 0x1045630 Offset: 0x1044A30 VA: 0x181045630 Slot: 8
	public object get_Value() { }

}

public abstract class XmlSchemaParticle : XmlSchemaAnnotated // TypeDefIndex: 2372
{	// Fields
	private Decimal minOccurs; // 0x50
	private Decimal maxOccurs; // 0x60
	private XmlSchemaParticle.Occurs flags; // 0x70
	internal static readonly XmlSchemaParticle Empty; // 0x0

	// Properties
	[XmlAttributeAttribute] // RVA: 0x96D10 Offset: 0x96110 VA: 0x180096D10
	public string MinOccursString { get; set; }
	[XmlAttributeAttribute] // RVA: 0x96E70 Offset: 0x96270 VA: 0x180096E70
	public string MaxOccursString { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public Decimal MinOccurs { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public Decimal MaxOccurs { get; set; }
	internal virtual bool IsEmpty { get; }
	internal virtual string NameString { get; }

	// Methods

	// RVA: 0x1058BD0 Offset: 0x1057FD0 VA: 0x181058BD0
	public string get_MinOccursString() { }

	// RVA: 0x1059080 Offset: 0x1058480 VA: 0x181059080
	public void set_MinOccursString(string value) { }

	// RVA: 0x1058AC0 Offset: 0x1057EC0 VA: 0x181058AC0
	public string get_MaxOccursString() { }

	// RVA: 0x1058CA0 Offset: 0x10580A0 VA: 0x181058CA0
	public void set_MaxOccursString(string value) { }

	// RVA: 0x1058C50 Offset: 0x1058050 VA: 0x181058C50
	public Decimal get_MinOccurs() { }

	// RVA: 0x10591F0 Offset: 0x10585F0 VA: 0x1810591F0
	public void set_MinOccurs(Decimal value) { }

	// RVA: 0xC2D5D0 Offset: 0xC2C9D0 VA: 0x180C2D5D0
	public Decimal get_MaxOccurs() { }

	// RVA: 0x1058ED0 Offset: 0x10582D0 VA: 0x181058ED0
	public void set_MaxOccurs(Decimal value) { }

	// RVA: 0x1058A30 Offset: 0x1057E30 VA: 0x181058A30 Slot: 14
	internal virtual bool get_IsEmpty() { }

	// RVA: 0x1058C60 Offset: 0x1058060 VA: 0x181058C60 Slot: 15
	internal virtual string get_NameString() { }

	// RVA: 0x1058790 Offset: 0x1057B90 VA: 0x181058790
	internal XmlQualifiedName GetQualifiedName() { }

	// RVA: 0x10589B0 Offset: 0x1057DB0 VA: 0x1810589B0
	protected void .ctor() { }

	// RVA: 0x1058910 Offset: 0x1057D10 VA: 0x181058910
	private static void .cctor() { }

}

private enum XmlSchemaParticle.Occurs // TypeDefIndex: 2373
{	// Fields
	public int value__; // 0x0
	public const XmlSchemaParticle.Occurs None = 0;
	public const XmlSchemaParticle.Occurs Min = 1;
	public const XmlSchemaParticle.Occurs Max = 2;

}

private class XmlSchemaParticle.EmptyParticle : XmlSchemaParticle // TypeDefIndex: 2374
{	// Properties
	internal override bool IsEmpty { get; }

	// Methods

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 14
	internal override bool get_IsEmpty() { }

	// RVA: 0x1045080 Offset: 0x1044480 VA: 0x181045080
	public void .ctor() { }

}

public class XmlSchemaRedefine : XmlSchemaExternal // TypeDefIndex: 2375
{	// Fields
	private XmlSchemaObjectCollection items; // 0x68
	private XmlSchemaObjectTable attributeGroups; // 0x70
	private XmlSchemaObjectTable types; // 0x78
	private XmlSchemaObjectTable groups; // 0x80

	// Properties
	[XmlElementAttribute] // RVA: 0x97350 Offset: 0x96750 VA: 0x180097350
	[XmlElementAttribute] // RVA: 0x97350 Offset: 0x96750 VA: 0x180097350
	[XmlElementAttribute] // RVA: 0x97350 Offset: 0x96750 VA: 0x180097350
	[XmlElementAttribute] // RVA: 0x97350 Offset: 0x96750 VA: 0x180097350
	[XmlElementAttribute] // RVA: 0x97350 Offset: 0x96750 VA: 0x180097350
	public XmlSchemaObjectCollection Items { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public XmlSchemaObjectTable AttributeGroups { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public XmlSchemaObjectTable SchemaTypes { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public XmlSchemaObjectTable Groups { get; }

	// Methods

	// RVA: 0x1059370 Offset: 0x1058770 VA: 0x181059370
	public void .ctor() { }

	// RVA: 0x5334F0 Offset: 0x5328F0 VA: 0x1805334F0
	public XmlSchemaObjectCollection get_Items() { }

	// RVA: 0x58DC30 Offset: 0x58D030 VA: 0x18058DC30
	public XmlSchemaObjectTable get_AttributeGroups() { }

	// RVA: 0x4E4EC0 Offset: 0x4E42C0 VA: 0x1804E4EC0
	public XmlSchemaObjectTable get_SchemaTypes() { }

	// RVA: 0x58DC40 Offset: 0x58D040 VA: 0x18058DC40
	public XmlSchemaObjectTable get_Groups() { }

	// RVA: 0x1059350 Offset: 0x1058750 VA: 0x181059350 Slot: 10
	internal override void AddAnnotation(XmlSchemaAnnotation annotation) { }

}

public class XmlSchemaSequence : XmlSchemaGroupBase // TypeDefIndex: 2376
{	// Fields
	private XmlSchemaObjectCollection items; // 0x78

	// Properties
	[XmlElementAttribute] // RVA: 0x97970 Offset: 0x96D70 VA: 0x180097970
	[XmlElementAttribute] // RVA: 0x97970 Offset: 0x96D70 VA: 0x180097970
	[XmlElementAttribute] // RVA: 0x97970 Offset: 0x96D70 VA: 0x180097970
	[XmlElementAttribute] // RVA: 0x97970 Offset: 0x96D70 VA: 0x180097970
	[XmlElementAttribute] // RVA: 0x97970 Offset: 0x96D70 VA: 0x180097970
	public override XmlSchemaObjectCollection Items { get; }
	internal override bool IsEmpty { get; }

	// Methods

	// RVA: 0x4E4EC0 Offset: 0x4E42C0 VA: 0x1804E4EC0 Slot: 16
	public override XmlSchemaObjectCollection get_Items() { }

	// RVA: 0x1045B60 Offset: 0x1044F60 VA: 0x181045B60 Slot: 14
	internal override bool get_IsEmpty() { }

	// RVA: 0x4E51E0 Offset: 0x4E45E0 VA: 0x1804E51E0 Slot: 17
	internal override void SetItems(XmlSchemaObjectCollection newItems) { }

	// RVA: 0x1059460 Offset: 0x1058860 VA: 0x181059460
	public void .ctor() { }

}

public class XmlSchemaSet // TypeDefIndex: 2377
{	// Fields
	private XmlNameTable nameTable; // 0x10
	private SchemaNames schemaNames; // 0x18
	private SortedList schemas; // 0x20
	private ValidationEventHandler internalEventHandler; // 0x28
	private ValidationEventHandler eventHandler; // 0x30
	private bool isCompiled; // 0x38
	private Hashtable schemaLocations; // 0x40
	private Hashtable chameleonSchemas; // 0x48
	private Hashtable targetNamespaces; // 0x50
	private bool compileAll; // 0x58
	private SchemaInfo cachedCompiledInfo; // 0x60
	private XmlReaderSettings readerSettings; // 0x68
	private XmlSchema schemaForSchema; // 0x70
	private XmlSchemaCompilationSettings compilationSettings; // 0x78
	internal XmlSchemaObjectTable elements; // 0x80
	internal XmlSchemaObjectTable attributes; // 0x88
	internal XmlSchemaObjectTable schemaTypes; // 0x90
	internal XmlSchemaObjectTable substitutionGroups; // 0x98
	private XmlSchemaObjectTable typeExtensions; // 0xA0
	private object internalSyncObject; // 0xA8

	// Properties
	internal object InternalSyncObject { get; }
	public bool IsCompiled { get; }
	public XmlResolver XmlResolver { set; }
	public XmlSchemaCompilationSettings CompilationSettings { get; set; }
	public int Count { get; }
	public XmlSchemaObjectTable GlobalElements { get; }
	public XmlSchemaObjectTable GlobalAttributes { get; }
	public XmlSchemaObjectTable GlobalTypes { get; }
	internal XmlSchemaObjectTable SubstitutionGroups { get; }
	internal Hashtable SchemaLocations { get; }
	internal XmlSchemaObjectTable TypeExtensions { get; }
	internal SchemaInfo CompiledInfo { get; }
	internal XmlReaderSettings ReaderSettings { get; }
	internal SortedList SortedSchemas { get; }

	// Methods

	// RVA: 0x1062260 Offset: 0x1061660 VA: 0x181062260
	internal object get_InternalSyncObject() { }

	// RVA: 0x1061CD0 Offset: 0x10610D0 VA: 0x181061CD0
	public void .ctor() { }

	// RVA: 0x1061D30 Offset: 0x1061130 VA: 0x181061D30
	public void .ctor(XmlNameTable nameTable) { }

	// RVA: 0x1061FC0 Offset: 0x10613C0 VA: 0x181061FC0
	public void add_ValidationEventHandler(ValidationEventHandler value) { }

	// RVA: 0x10623E0 Offset: 0x10617E0 VA: 0x1810623E0
	public void remove_ValidationEventHandler(ValidationEventHandler value) { }

	// RVA: 0x8B1120 Offset: 0x8B0520 VA: 0x1808B1120
	public bool get_IsCompiled() { }

	// RVA: 0x1062480 Offset: 0x1061880 VA: 0x181062480
	public void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x4E4EC0 Offset: 0x4E42C0 VA: 0x1804E4EC0
	public XmlSchemaCompilationSettings get_CompilationSettings() { }

	// RVA: 0x4E51E0 Offset: 0x4E45E0 VA: 0x1804E51E0
	public void set_CompilationSettings(XmlSchemaCompilationSettings value) { }

	// RVA: 0x10620B0 Offset: 0x10614B0 VA: 0x1810620B0
	public int get_Count() { }

	// RVA: 0x1062160 Offset: 0x1061560 VA: 0x181062160
	public XmlSchemaObjectTable get_GlobalElements() { }

	// RVA: 0x10620E0 Offset: 0x10614E0 VA: 0x1810620E0
	public XmlSchemaObjectTable get_GlobalAttributes() { }

	// RVA: 0x10621E0 Offset: 0x10615E0 VA: 0x1810621E0
	public XmlSchemaObjectTable get_GlobalTypes() { }

	// RVA: 0x10622E0 Offset: 0x10616E0 VA: 0x1810622E0
	internal XmlSchemaObjectTable get_SubstitutionGroups() { }

	// RVA: 0x4B9440 Offset: 0x4B8840 VA: 0x1804B9440
	internal Hashtable get_SchemaLocations() { }

	// RVA: 0x1062360 Offset: 0x1061760 VA: 0x181062360
	internal XmlSchemaObjectTable get_TypeExtensions() { }

	// RVA: 0x1059CA0 Offset: 0x10590A0 VA: 0x181059CA0
	public void Add(XmlSchemaSet schemas) { }

	// RVA: 0x105A830 Offset: 0x1059C30 VA: 0x18105A830
	public XmlSchema Add(XmlSchema schema) { }

	// RVA: 0x105F430 Offset: 0x105E830 VA: 0x18105F430
	public bool RemoveRecursive(XmlSchema schemaToRemove) { }

	// RVA: 0x105B5B0 Offset: 0x105A9B0 VA: 0x18105B5B0
	public bool Contains(string targetNamespace) { }

	// RVA: 0x105B070 Offset: 0x105A470 VA: 0x18105B070
	public void Compile() { }

	// RVA: 0x1060E30 Offset: 0x1060230 VA: 0x181060E30
	public XmlSchema Reprocess(XmlSchema schema) { }

	// RVA: 0x105D460 Offset: 0x105C860 VA: 0x18105D460
	public void CopyTo(XmlSchema[] schemas, int index) { }

	// RVA: 0x1061AC0 Offset: 0x1060EC0 VA: 0x181061AC0
	public ICollection Schemas() { }

	// RVA: 0x1061910 Offset: 0x1060D10 VA: 0x181061910
	public ICollection Schemas(string targetNamespace) { }

	// RVA: 0x105A7D0 Offset: 0x1059BD0 VA: 0x18105A7D0
	private XmlSchema Add(string targetNamespace, XmlSchema schema) { }

	// RVA: 0x105A9F0 Offset: 0x1059DF0 VA: 0x18105A9F0
	internal void Add(string targetNamespace, XmlReader reader, Hashtable validatedNamespaces) { }

	// RVA: 0x105D5D0 Offset: 0x105C9D0 VA: 0x18105D5D0
	internal XmlSchema FindSchemaByNSAndUrl(Uri schemaUri, string ns, DictionaryEntry[] locationsTable) { }

	// RVA: 0x1059500 Offset: 0x1058900 VA: 0x181059500
	private void AddSchemaToSet(XmlSchema schema) { }

	// RVA: 0x105E9D0 Offset: 0x105DDD0 VA: 0x18105E9D0
	private void ProcessNewSubstitutionGroups(XmlSchemaObjectTable substitutionGroupsTable, bool resolve) { }

	// RVA: 0x1061560 Offset: 0x1060960 VA: 0x181061560
	private void ResolveSubstitutionGroup(XmlSchemaSubstitutionGroup substitutionGroup, XmlSchemaObjectTable substTable) { }

	// RVA: 0x1060B20 Offset: 0x105FF20 VA: 0x181060B20
	internal XmlSchema Remove(XmlSchema schema, bool forceCompile) { }

	// RVA: 0x105AE20 Offset: 0x105A220 VA: 0x18105AE20
	private void ClearTables() { }

	// RVA: 0x105E880 Offset: 0x105DC80 VA: 0x18105E880
	internal bool PreprocessSchema(ref XmlSchema schema, string targetNamespace) { }

	// RVA: 0x105E760 Offset: 0x105DB60 VA: 0x18105E760
	internal XmlSchema ParseSchema(string targetNamespace, XmlReader reader) { }

	// RVA: 0x105B630 Offset: 0x105AA30 VA: 0x18105B630
	internal void CopyFromCompiledSet(XmlSchemaSet otherSet) { }

	// RVA: 0x54FB60 Offset: 0x54EF60 VA: 0x18054FB60
	internal SchemaInfo get_CompiledInfo() { }

	// RVA: 0x5334F0 Offset: 0x5328F0 VA: 0x1805334F0
	internal XmlReaderSettings get_ReaderSettings() { }

	// RVA: 0x105D8D0 Offset: 0x105CCD0 VA: 0x18105D8D0
	internal XmlResolver GetResolver() { }

	// RVA: 0x4A2EE0 Offset: 0x4A22E0 VA: 0x1804A2EE0
	internal ValidationEventHandler GetEventHandler() { }

	// RVA: 0x105DA80 Offset: 0x105CE80 VA: 0x18105DA80
	internal SchemaNames GetSchemaNames(XmlNameTable nt) { }

	// RVA: 0x105DBE0 Offset: 0x105CFE0 VA: 0x18105DBE0
	internal bool IsSchemaLoaded(Uri schemaUri, string targetNamespace, out XmlSchema schema) { }

	// RVA: 0x105D8F0 Offset: 0x105CCF0 VA: 0x18105D8F0
	internal bool GetSchemaByUri(Uri schemaUri, out XmlSchema schema) { }

	// RVA: 0x105DB30 Offset: 0x105CF30 VA: 0x18105DB30
	internal string GetTargetNamespace(XmlSchema schema) { }

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	internal SortedList get_SortedSchemas() { }

	// RVA: 0x105FC70 Offset: 0x105F070 VA: 0x18105FC70
	private void RemoveSchemaFromCaches(XmlSchema schema) { }

	// RVA: 0x10600D0 Offset: 0x105F4D0 VA: 0x1810600D0
	private void RemoveSchemaFromGlobalTables(XmlSchema schema) { }

	// RVA: 0x1059910 Offset: 0x1058D10 VA: 0x181059910
	private bool AddToTable(XmlSchemaObjectTable table, XmlQualifiedName qname, XmlSchemaObject item) { }

	// RVA: 0x1061BA0 Offset: 0x1060FA0 VA: 0x181061BA0
	private void VerifyTables() { }

	// RVA: 0x105DB80 Offset: 0x105CF80 VA: 0x18105DB80
	private void InternalValidationCallback(object sender, ValidationEventArgs e) { }

	// RVA: 0x1061AF0 Offset: 0x1060EF0 VA: 0x181061AF0
	private void SendValidationEvent(XmlSchemaException e, XmlSeverityType severity) { }

}

public class XmlSchemaSimpleContent : XmlSchemaContentModel // TypeDefIndex: 2378
{	// Fields
	private XmlSchemaContent content; // 0x50

	// Properties
	[XmlElementAttribute] // RVA: 0x97E00 Offset: 0x97200 VA: 0x180097E00
	[XmlElementAttribute] // RVA: 0x97E00 Offset: 0x97200 VA: 0x180097E00
	public override XmlSchemaContent Content { get; set; }

	// Methods

	// RVA: 0x4CC350 Offset: 0x4CB750 VA: 0x1804CC350 Slot: 14
	public override XmlSchemaContent get_Content() { }

	// RVA: 0x4CC370 Offset: 0x4CB770 VA: 0x1804CC370 Slot: 15
	public override void set_Content(XmlSchemaContent value) { }

	// RVA: 0x7992B0 Offset: 0x7986B0 VA: 0x1807992B0
	public void .ctor() { }

}

public class XmlSchemaSimpleContentExtension : XmlSchemaContent // TypeDefIndex: 2379
{	// Fields
	private XmlSchemaObjectCollection attributes; // 0x50
	private XmlSchemaAnyAttribute anyAttribute; // 0x58
	private XmlQualifiedName baseTypeName; // 0x60

	// Properties
	[XmlAttributeAttribute] // RVA: 0x8F380 Offset: 0x8E780 VA: 0x18008F380
	public XmlQualifiedName BaseTypeName { get; set; }
	[XmlElementAttribute] // RVA: 0x98130 Offset: 0x97530 VA: 0x180098130
	[XmlElementAttribute] // RVA: 0x98130 Offset: 0x97530 VA: 0x180098130
	public XmlSchemaObjectCollection Attributes { get; }
	[XmlElementAttribute] // RVA: 0x8E4F0 Offset: 0x8D8F0 VA: 0x18008E4F0
	public XmlSchemaAnyAttribute AnyAttribute { get; set; }

	// Methods

	// RVA: 0x54FB60 Offset: 0x54EF60 VA: 0x18054FB60
	public XmlQualifiedName get_BaseTypeName() { }

	// RVA: 0xD215C0 Offset: 0xD209C0 VA: 0x180D215C0
	public void set_BaseTypeName(XmlQualifiedName value) { }

	// RVA: 0x4CC350 Offset: 0x4CB750 VA: 0x1804CC350
	public XmlSchemaObjectCollection get_Attributes() { }

	// RVA: 0x4CC340 Offset: 0x4CB740 VA: 0x1804CC340
	public XmlSchemaAnyAttribute get_AnyAttribute() { }

	// RVA: 0x4CC360 Offset: 0x4CB760 VA: 0x1804CC360
	public void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	// RVA: 0x4CC370 Offset: 0x4CB770 VA: 0x1804CC370
	internal void SetAttributes(XmlSchemaObjectCollection newAttributes) { }

	// RVA: 0xD21510 Offset: 0xD20910 VA: 0x180D21510
	public void .ctor() { }

}

public class XmlSchemaSimpleContentRestriction : XmlSchemaContent // TypeDefIndex: 2380
{	// Fields
	private XmlQualifiedName baseTypeName; // 0x50
	private XmlSchemaSimpleType baseType; // 0x58
	private XmlSchemaObjectCollection facets; // 0x60
	private XmlSchemaObjectCollection attributes; // 0x68
	private XmlSchemaAnyAttribute anyAttribute; // 0x70

	// Properties
	[XmlAttributeAttribute] // RVA: 0x8F380 Offset: 0x8E780 VA: 0x18008F380
	public XmlQualifiedName BaseTypeName { get; set; }
	[XmlElementAttribute] // RVA: 0x98430 Offset: 0x97830 VA: 0x180098430
	public XmlSchemaSimpleType BaseType { get; set; }
	[XmlElementAttribute] // RVA: 0x98550 Offset: 0x97950 VA: 0x180098550
	[XmlElementAttribute] // RVA: 0x98550 Offset: 0x97950 VA: 0x180098550
	[XmlElementAttribute] // RVA: 0x98550 Offset: 0x97950 VA: 0x180098550
	[XmlElementAttribute] // RVA: 0x98550 Offset: 0x97950 VA: 0x180098550
	[XmlElementAttribute] // RVA: 0x98550 Offset: 0x97950 VA: 0x180098550
	[XmlElementAttribute] // RVA: 0x98550 Offset: 0x97950 VA: 0x180098550
	[XmlElementAttribute] // RVA: 0x98550 Offset: 0x97950 VA: 0x180098550
	[XmlElementAttribute] // RVA: 0x98550 Offset: 0x97950 VA: 0x180098550
	[XmlElementAttribute] // RVA: 0x98550 Offset: 0x97950 VA: 0x180098550
	[XmlElementAttribute] // RVA: 0x98550 Offset: 0x97950 VA: 0x180098550
	[XmlElementAttribute] // RVA: 0x98550 Offset: 0x97950 VA: 0x180098550
	[XmlElementAttribute] // RVA: 0x98550 Offset: 0x97950 VA: 0x180098550
	public XmlSchemaObjectCollection Facets { get; }
	[XmlElementAttribute] // RVA: 0x98FD0 Offset: 0x983D0 VA: 0x180098FD0
	[XmlElementAttribute] // RVA: 0x98FD0 Offset: 0x983D0 VA: 0x180098FD0
	public XmlSchemaObjectCollection Attributes { get; }
	[XmlElementAttribute] // RVA: 0x8E4F0 Offset: 0x8D8F0 VA: 0x18008E4F0
	public XmlSchemaAnyAttribute AnyAttribute { get; set; }

	// Methods

	// RVA: 0x4CC350 Offset: 0x4CB750 VA: 0x1804CC350
	public XmlQualifiedName get_BaseTypeName() { }

	// RVA: 0xD21750 Offset: 0xD20B50 VA: 0x180D21750
	public void set_BaseTypeName(XmlQualifiedName value) { }

	// RVA: 0x4CC340 Offset: 0x4CB740 VA: 0x1804CC340
	public XmlSchemaSimpleType get_BaseType() { }

	// RVA: 0x4CC360 Offset: 0x4CB760 VA: 0x1804CC360
	public void set_BaseType(XmlSchemaSimpleType value) { }

	// RVA: 0x54FB60 Offset: 0x54EF60 VA: 0x18054FB60
	public XmlSchemaObjectCollection get_Facets() { }

	// RVA: 0x5334F0 Offset: 0x5328F0 VA: 0x1805334F0
	public XmlSchemaObjectCollection get_Attributes() { }

	// RVA: 0x58DC30 Offset: 0x58D030 VA: 0x18058DC30
	public XmlSchemaAnyAttribute get_AnyAttribute() { }

	// RVA: 0x58DCC0 Offset: 0x58D0C0 VA: 0x18058DCC0
	public void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	// RVA: 0x5336F0 Offset: 0x532AF0 VA: 0x1805336F0
	internal void SetAttributes(XmlSchemaObjectCollection newAttributes) { }

	// RVA: 0xD21680 Offset: 0xD20A80 VA: 0x180D21680
	public void .ctor() { }

}

public class XmlSchemaSimpleType : XmlSchemaType // TypeDefIndex: 2381
{	// Fields
	private XmlSchemaSimpleTypeContent content; // 0x98

	// Properties
	[XmlElementAttribute] // RVA: 0x99530 Offset: 0x98930 VA: 0x180099530
	[XmlElementAttribute] // RVA: 0x99530 Offset: 0x98930 VA: 0x180099530
	[XmlElementAttribute] // RVA: 0x99530 Offset: 0x98930 VA: 0x180099530
	public XmlSchemaSimpleTypeContent Content { get; set; }

	// Methods

	// RVA: 0xD21FD0 Offset: 0xD213D0 VA: 0x180D21FD0
	public void .ctor() { }

	// RVA: 0x58DBE0 Offset: 0x58CFE0 VA: 0x18058DBE0
	public XmlSchemaSimpleTypeContent get_Content() { }

	// RVA: 0x58DC70 Offset: 0x58D070 VA: 0x18058DC70
	public void set_Content(XmlSchemaSimpleTypeContent value) { }

	// RVA: 0xD21EA0 Offset: 0xD212A0 VA: 0x180D21EA0 Slot: 13
	internal override XmlSchemaObject Clone() { }

}

public abstract class XmlSchemaSimpleTypeContent : XmlSchemaAnnotated // TypeDefIndex: 2382
{	// Methods

	// RVA: 0x7992B0 Offset: 0x7986B0 VA: 0x1807992B0
	protected void .ctor() { }

}

public class XmlSchemaSimpleTypeList : XmlSchemaSimpleTypeContent // TypeDefIndex: 2383
{	// Fields
	private XmlQualifiedName itemTypeName; // 0x50
	private XmlSchemaSimpleType itemType; // 0x58
	private XmlSchemaSimpleType baseItemType; // 0x60

	// Properties
	[XmlAttributeAttribute] // RVA: 0x99AA0 Offset: 0x98EA0 VA: 0x180099AA0
	public XmlQualifiedName ItemTypeName { get; set; }
	[XmlElementAttribute] // RVA: 0x99C50 Offset: 0x99050 VA: 0x180099C50
	public XmlSchemaSimpleType ItemType { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public XmlSchemaSimpleType BaseItemType { get; set; }

	// Methods

	// RVA: 0x4CC350 Offset: 0x4CB750 VA: 0x1804CC350
	public XmlQualifiedName get_ItemTypeName() { }

	// RVA: 0xD21950 Offset: 0xD20D50 VA: 0x180D21950
	public void set_ItemTypeName(XmlQualifiedName value) { }

	// RVA: 0x4CC340 Offset: 0x4CB740 VA: 0x1804CC340
	public XmlSchemaSimpleType get_ItemType() { }

	// RVA: 0x4CC360 Offset: 0x4CB760 VA: 0x1804CC360
	public void set_ItemType(XmlSchemaSimpleType value) { }

	// RVA: 0x54FB60 Offset: 0x54EF60 VA: 0x18054FB60
	public XmlSchemaSimpleType get_BaseItemType() { }

	// RVA: 0x54FB70 Offset: 0x54EF70 VA: 0x18054FB70
	public void set_BaseItemType(XmlSchemaSimpleType value) { }

	// RVA: 0xD21810 Offset: 0xD20C10 VA: 0x180D21810 Slot: 13
	internal override XmlSchemaObject Clone() { }

	// RVA: 0xD218D0 Offset: 0xD20CD0 VA: 0x180D218D0
	public void .ctor() { }

}

public class XmlSchemaSimpleTypeRestriction : XmlSchemaSimpleTypeContent // TypeDefIndex: 2384
{	// Fields
	private XmlQualifiedName baseTypeName; // 0x50
	private XmlSchemaSimpleType baseType; // 0x58
	private XmlSchemaObjectCollection facets; // 0x60

	// Properties
	[XmlAttributeAttribute] // RVA: 0x8F380 Offset: 0x8E780 VA: 0x18008F380
	public XmlQualifiedName BaseTypeName { get; set; }
	[XmlElementAttribute] // RVA: 0x9A040 Offset: 0x99440 VA: 0x18009A040
	public XmlSchemaSimpleType BaseType { get; set; }
	[XmlElementAttribute] // RVA: 0x9A230 Offset: 0x99630 VA: 0x18009A230
	[XmlElementAttribute] // RVA: 0x9A230 Offset: 0x99630 VA: 0x18009A230
	[XmlElementAttribute] // RVA: 0x9A230 Offset: 0x99630 VA: 0x18009A230
	[XmlElementAttribute] // RVA: 0x9A230 Offset: 0x99630 VA: 0x18009A230
	[XmlElementAttribute] // RVA: 0x9A230 Offset: 0x99630 VA: 0x18009A230
	[XmlElementAttribute] // RVA: 0x9A230 Offset: 0x99630 VA: 0x18009A230
	[XmlElementAttribute] // RVA: 0x9A230 Offset: 0x99630 VA: 0x18009A230
	[XmlElementAttribute] // RVA: 0x9A230 Offset: 0x99630 VA: 0x18009A230
	[XmlElementAttribute] // RVA: 0x9A230 Offset: 0x99630 VA: 0x18009A230
	[XmlElementAttribute] // RVA: 0x9A230 Offset: 0x99630 VA: 0x18009A230
	[XmlElementAttribute] // RVA: 0x9A230 Offset: 0x99630 VA: 0x18009A230
	[XmlElementAttribute] // RVA: 0x9A230 Offset: 0x99630 VA: 0x18009A230
	public XmlSchemaObjectCollection Facets { get; }

	// Methods

	// RVA: 0x4CC350 Offset: 0x4CB750 VA: 0x1804CC350
	public XmlQualifiedName get_BaseTypeName() { }

	// RVA: 0xD21B80 Offset: 0xD20F80 VA: 0x180D21B80
	public void set_BaseTypeName(XmlQualifiedName value) { }

	// RVA: 0x4CC340 Offset: 0x4CB740 VA: 0x1804CC340
	public XmlSchemaSimpleType get_BaseType() { }

	// RVA: 0x4CC360 Offset: 0x4CB760 VA: 0x1804CC360
	public void set_BaseType(XmlSchemaSimpleType value) { }

	// RVA: 0x54FB60 Offset: 0x54EF60 VA: 0x18054FB60
	public XmlSchemaObjectCollection get_Facets() { }

	// RVA: 0xD21A10 Offset: 0xD20E10 VA: 0x180D21A10 Slot: 13
	internal override XmlSchemaObject Clone() { }

	// RVA: 0xD21AD0 Offset: 0xD20ED0 VA: 0x180D21AD0
	public void .ctor() { }

}

public class XmlSchemaSimpleTypeUnion : XmlSchemaSimpleTypeContent // TypeDefIndex: 2385
{	// Fields
	private XmlSchemaObjectCollection baseTypes; // 0x50
	private XmlQualifiedName[] memberTypes; // 0x58
	private XmlSchemaSimpleType[] baseMemberTypes; // 0x60

	// Properties
	[XmlElementAttribute] // RVA: 0x9A950 Offset: 0x99D50 VA: 0x18009A950
	public XmlSchemaObjectCollection BaseTypes { get; }
	[XmlAttributeAttribute] // RVA: 0x9ABD0 Offset: 0x99FD0 VA: 0x18009ABD0
	public XmlQualifiedName[] MemberTypes { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public XmlSchemaSimpleType[] BaseMemberTypes { get; }

	// Methods

	// RVA: 0x4CC350 Offset: 0x4CB750 VA: 0x1804CC350
	public XmlSchemaObjectCollection get_BaseTypes() { }

	// RVA: 0x4CC340 Offset: 0x4CB740 VA: 0x1804CC340
	public XmlQualifiedName[] get_MemberTypes() { }

	// RVA: 0x4CC360 Offset: 0x4CB760 VA: 0x1804CC360
	public void set_MemberTypes(XmlQualifiedName[] value) { }

	// RVA: 0x54FB60 Offset: 0x54EF60 VA: 0x18054FB60
	public XmlSchemaSimpleType[] get_BaseMemberTypes() { }

	// RVA: 0x54FB70 Offset: 0x54EF70 VA: 0x18054FB70
	internal void SetBaseMemberTypes(XmlSchemaSimpleType[] baseMemberTypes) { }

	// RVA: 0xD21C40 Offset: 0xD21040 VA: 0x180D21C40 Slot: 13
	internal override XmlSchemaObject Clone() { }

	// RVA: 0xD21E30 Offset: 0xD21230 VA: 0x180D21E30
	public void .ctor() { }

}

internal class XmlSchemaSubstitutionGroup : XmlSchemaObject // TypeDefIndex: 2386
{	// Fields
	private ArrayList membersList; // 0x38
	private XmlQualifiedName examplar; // 0x40

	// Properties
	[XmlIgnoreAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal ArrayList Members { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal XmlQualifiedName Examplar { get; set; }

	// Methods

	// RVA: 0x5DCC00 Offset: 0x5DC000 VA: 0x1805DCC00
	internal ArrayList get_Members() { }

	// RVA: 0x4B9440 Offset: 0x4B8840 VA: 0x1804B9440
	internal XmlQualifiedName get_Examplar() { }

	// RVA: 0x4B94A0 Offset: 0x4B88A0 VA: 0x1804B94A0
	internal void set_Examplar(XmlQualifiedName value) { }

	// RVA: 0xD22150 Offset: 0xD21550 VA: 0x180D22150
	public void .ctor() { }

}

internal class XmlSchemaSubstitutionGroupV1Compat : XmlSchemaSubstitutionGroup // TypeDefIndex: 2387
{	// Fields
	private XmlSchemaChoice choice; // 0x48

	// Properties
	[XmlIgnoreAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal XmlSchemaChoice Choice { get; }

	// Methods

	// RVA: 0x5DCCA0 Offset: 0x5DC0A0 VA: 0x1805DCCA0
	internal XmlSchemaChoice get_Choice() { }

	// RVA: 0xD22060 Offset: 0xD21460 VA: 0x180D22060
	public void .ctor() { }

}

public class XmlSchemaType : XmlSchemaAnnotated // TypeDefIndex: 2388
{	// Fields
	private string name; // 0x50
	private XmlSchemaDerivationMethod final; // 0x58
	private XmlSchemaDerivationMethod derivedBy; // 0x5C
	private XmlSchemaType baseSchemaType; // 0x60
	private XmlSchemaDatatype datatype; // 0x68
	private XmlSchemaDerivationMethod finalResolved; // 0x70
	private SchemaElementDecl elementDecl; // 0x78
	private XmlQualifiedName qname; // 0x80
	private XmlSchemaType redefined; // 0x88
	private XmlSchemaContentType contentType; // 0x90

	// Properties
	[XmlAttributeAttribute] // RVA: 0x8D890 Offset: 0x8CC90 VA: 0x18008D890
	public string Name { get; set; }
	[XmlAttributeAttribute] // RVA: 0x9B010 Offset: 0x9A410 VA: 0x18009B010
	[DefaultValueAttribute] // RVA: 0x9B010 Offset: 0x9A410 VA: 0x18009B010
	public XmlSchemaDerivationMethod Final { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public XmlQualifiedName QualifiedName { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public XmlSchemaDerivationMethod FinalResolved { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public XmlSchemaType BaseXmlSchemaType { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public XmlSchemaDerivationMethod DerivedBy { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public XmlSchemaDatatype Datatype { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public virtual bool IsMixed { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public XmlTypeCode TypeCode { get; }
	[XmlIgnoreAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal XmlValueConverter ValueConverter { get; }
	internal XmlSchemaContentType SchemaContentType { get; }
	internal SchemaElementDecl ElementDecl { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal XmlSchemaType Redefined { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal override string NameAttribute { get; set; }

	// Methods

	// RVA: 0xD22470 Offset: 0xD21870 VA: 0x180D22470
	public static XmlSchemaSimpleType GetBuiltInSimpleType(XmlQualifiedName qualifiedName) { }

	// RVA: 0xD22420 Offset: 0xD21820 VA: 0x180D22420
	public static XmlSchemaSimpleType GetBuiltInSimpleType(XmlTypeCode typeCode) { }

	// RVA: 0xD22220 Offset: 0xD21620 VA: 0x180D22220
	public static XmlSchemaComplexType GetBuiltInComplexType(XmlQualifiedName qualifiedName) { }

	// RVA: 0x4CC350 Offset: 0x4CB750 VA: 0x1804CC350
	public string get_Name() { }

	// RVA: 0x4CC370 Offset: 0x4CB770 VA: 0x1804CC370
	public void set_Name(string value) { }

	// RVA: 0xAE4F70 Offset: 0xAE4370 VA: 0x180AE4F70
	public XmlSchemaDerivationMethod get_Final() { }

	// RVA: 0xD229D0 Offset: 0xD21DD0 VA: 0x180D229D0
	public void set_Final(XmlSchemaDerivationMethod value) { }

	// RVA: 0xD22820 Offset: 0xD21C20 VA: 0x180D22820
	public XmlQualifiedName get_QualifiedName() { }

	// RVA: 0x7E3970 Offset: 0x7E2D70 VA: 0x1807E3970
	public XmlSchemaDerivationMethod get_FinalResolved() { }

	// RVA: 0x54FB60 Offset: 0x54EF60 VA: 0x18054FB60
	public XmlSchemaType get_BaseXmlSchemaType() { }

	// RVA: 0x58DC00 Offset: 0x58D000 VA: 0x18058DC00
	public XmlSchemaDerivationMethod get_DerivedBy() { }

	// RVA: 0x5334F0 Offset: 0x5328F0 VA: 0x1805334F0
	public XmlSchemaDatatype get_Datatype() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 14
	public virtual bool get_IsMixed() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 15
	public virtual void set_IsMixed(bool value) { }

	// RVA: 0xD22850 Offset: 0xD21C50 VA: 0x180D22850
	public XmlTypeCode get_TypeCode() { }

	// RVA: 0xD22920 Offset: 0xD21D20 VA: 0x180D22920
	internal XmlValueConverter get_ValueConverter() { }

	// RVA: 0xD22840 Offset: 0xD21C40 VA: 0x180D22840
	internal XmlSchemaContentType get_SchemaContentType() { }

	// RVA: 0xD227C0 Offset: 0xD21BC0 VA: 0x180D227C0
	internal void SetQualifiedName(XmlQualifiedName value) { }

	// RVA: 0x7E39A0 Offset: 0x7E2DA0 VA: 0x1807E39A0
	internal void SetFinalResolved(XmlSchemaDerivationMethod value) { }

	// RVA: 0x54FB70 Offset: 0x54EF70 VA: 0x18054FB70
	internal void SetBaseSchemaType(XmlSchemaType value) { }

	// RVA: 0x58DC90 Offset: 0x58D090 VA: 0x18058DC90
	internal void SetDerivedBy(XmlSchemaDerivationMethod value) { }

	// RVA: 0x5336F0 Offset: 0x532AF0 VA: 0x1805336F0
	internal void SetDatatype(XmlSchemaDatatype value) { }

	// RVA: 0xD22800 Offset: 0xD21C00 VA: 0x180D22800
	internal SchemaElementDecl get_ElementDecl() { }

	// RVA: 0xD229A0 Offset: 0xD21DA0 VA: 0x180D229A0
	internal void set_ElementDecl(SchemaElementDecl value) { }

	// RVA: 0x58DBD0 Offset: 0x58CFD0 VA: 0x18058DBD0
	internal XmlSchemaType get_Redefined() { }

	// RVA: 0x58DC60 Offset: 0x58D060 VA: 0x18058DC60
	internal void set_Redefined(XmlSchemaType value) { }

	// RVA: 0xD227B0 Offset: 0xD21BB0 VA: 0x180D227B0
	internal void SetContentType(XmlSchemaContentType value) { }

	// RVA: 0xD22620 Offset: 0xD21A20 VA: 0x180D22620
	public static bool IsDerivedFrom(XmlSchemaType derivedType, XmlSchemaType baseType, XmlSchemaDerivationMethod except) { }

	// RVA: 0xD22530 Offset: 0xD21930 VA: 0x180D22530
	internal static bool IsDerivedFromDatatype(XmlSchemaDatatype derivedDataType, XmlSchemaDatatype baseDataType, XmlSchemaDerivationMethod except) { }

	// RVA: 0x4CC350 Offset: 0x4CB750 VA: 0x1804CC350 Slot: 11
	internal override string get_NameAttribute() { }

	// RVA: 0x4CC370 Offset: 0x4CB770 VA: 0x1804CC370 Slot: 12
	internal override void set_NameAttribute(string value) { }

	// RVA: 0xD21FD0 Offset: 0xD213D0 VA: 0x180D21FD0
	public void .ctor() { }

}

public enum XmlSchemaUse // TypeDefIndex: 2389
{	// Fields
	public int value__; // 0x0
	[XmlIgnoreAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public const XmlSchemaUse None = 0;
	[XmlEnumAttribute] // RVA: 0x9CE90 Offset: 0x9C290 VA: 0x18009CE90
	public const XmlSchemaUse Optional = 1;
	[XmlEnumAttribute] // RVA: 0x9CFC0 Offset: 0x9C3C0 VA: 0x18009CFC0
	public const XmlSchemaUse Prohibited = 2;
	[XmlEnumAttribute] // RVA: 0x9D1B0 Offset: 0x9C5B0 VA: 0x18009D1B0
	public const XmlSchemaUse Required = 3;

}

public class XmlSchemaValidationException : XmlSchemaException // TypeDefIndex: 2390
{	// Methods

	// RVA: 0xD22A50 Offset: 0xD21E50 VA: 0x180D22A50
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xD229F0 Offset: 0xD21DF0 VA: 0x180D229F0 Slot: 10
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xD22A70 Offset: 0xD21E70 VA: 0x180D22A70
	public void .ctor() { }

	// RVA: 0xD22A80 Offset: 0xD21E80 VA: 0x180D22A80
	internal void .ctor(string res, string arg, string sourceUri, int lineNumber, int linePosition) { }

	// RVA: 0xD22B90 Offset: 0xD21F90 VA: 0x180D22B90
	internal void .ctor(string res, string[] args, string sourceUri, int lineNumber, int linePosition) { }

	// RVA: 0xD22A10 Offset: 0xD21E10 VA: 0x180D22A10
	internal void .ctor(string res, string[] args, Exception innerException, string sourceUri, int lineNumber, int linePosition) { }

}

public sealed class XmlValueGetter : MulticastDelegate // TypeDefIndex: 2391
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xD38490 Offset: 0xD37890 VA: 0x180D38490 Slot: 12
	public virtual object Invoke() { }

	// RVA: 0x497020 Offset: 0x496420 VA: 0x180497020 Slot: 13
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual object EndInvoke(IAsyncResult result) { }

}

public enum XmlSchemaValidationFlags // TypeDefIndex: 2392
{	// Fields
	public int value__; // 0x0
	public const XmlSchemaValidationFlags None = 0;
	public const XmlSchemaValidationFlags ProcessInlineSchema = 1;
	public const XmlSchemaValidationFlags ProcessSchemaLocation = 2;
	public const XmlSchemaValidationFlags ReportValidationWarnings = 4;
	public const XmlSchemaValidationFlags ProcessIdentityConstraints = 8;
	public const XmlSchemaValidationFlags AllowXmlAttributes = 16;

}

public sealed class XmlSchemaValidator // TypeDefIndex: 2395
{	// Fields
	private XmlSchemaSet schemaSet; // 0x10
	private XmlSchemaValidationFlags validationFlags; // 0x18
	private int startIDConstraint; // 0x1C
	private bool isRoot; // 0x20
	private bool rootHasSchema; // 0x21
	private bool attrValid; // 0x22
	private bool checkEntity; // 0x23
	private SchemaInfo compiledSchemaInfo; // 0x28
	private IDtdInfo dtdSchemaInfo; // 0x30
	private Hashtable validatedNamespaces; // 0x38
	private HWStack validationStack; // 0x40
	private ValidationState context; // 0x48
	private ValidatorState currentState; // 0x50
	private Hashtable attPresence; // 0x58
	private SchemaAttDef wildID; // 0x60
	private Hashtable IDs; // 0x68
	private IdRefNode idRefListHead; // 0x70
	private XmlQualifiedName contextQName; // 0x78
	private string NsXs; // 0x80
	private string NsXsi; // 0x88
	private string NsXmlNs; // 0x90
	private string NsXml; // 0x98
	private XmlSchemaObject partialValidationType; // 0xA0
	private StringBuilder textValue; // 0xA8
	private ValidationEventHandler eventHandler; // 0xB0
	private object validationEventSender; // 0xB8
	private XmlNameTable nameTable; // 0xC0
	private IXmlLineInfo positionInfo; // 0xC8
	private IXmlLineInfo dummyPositionInfo; // 0xD0
	private XmlResolver xmlResolver; // 0xD8
	private Uri sourceUri; // 0xE0
	private string sourceUriString; // 0xE8
	private IXmlNamespaceResolver nsResolver; // 0xF0
	private XmlSchemaContentProcessing processContents; // 0xF8
	private string xsiTypeString; // 0x100
	private string xsiNilString; // 0x108
	private string xsiSchemaLocationString; // 0x110
	private string xsiNoNamespaceSchemaLocationString; // 0x118
	private static readonly XmlSchemaDatatype dtQName; // 0x0
	private static readonly XmlSchemaDatatype dtCDATA; // 0x8
	private static readonly XmlSchemaDatatype dtStringArray; // 0x10
	private static XmlSchemaParticle[] EmptyParticleArray; // 0x18
	private static XmlSchemaAttribute[] EmptyAttributeArray; // 0x20
	private XmlCharType xmlCharType; // 0x120
	internal static bool[,] ValidStates; // 0x28
	private static string[] MethodNames; // 0x30

	// Properties
	public XmlResolver XmlResolver { set; }
	public IXmlLineInfo LineInfoProvider { set; }
	public Uri SourceUri { set; }
	public object ValidationEventSender { set; }
	internal XmlSchemaSet SchemaSet { get; }
	internal XmlSchemaValidationFlags ValidationFlags { get; }
	internal XmlSchemaContentType CurrentContentType { get; }
	private bool StrictlyAssessed { get; }
	private bool HasSchema { get; }
	private bool HasIdentityConstraints { get; }
	internal bool ProcessIdentityConstraints { get; }
	internal bool ReportValidationWarnings { get; }
	internal bool ProcessSchemaHints { get; }

	// Methods

	// RVA: 0xD2FBE0 Offset: 0xD2EFE0 VA: 0x180D2FBE0
	public void .ctor(XmlNameTable nameTable, XmlSchemaSet schemas, IXmlNamespaceResolver namespaceResolver, XmlSchemaValidationFlags validationFlags) { }

	// RVA: 0xD29230 Offset: 0xD28630 VA: 0x180D29230
	private void Init() { }

	// RVA: 0xD2BDD0 Offset: 0xD2B1D0 VA: 0x180D2BDD0
	private void Reset() { }

	// RVA: 0xD300D0 Offset: 0xD2F4D0 VA: 0x180D300D0
	public void set_XmlResolver(XmlResolver value) { }

	// RVA: 0xD30050 Offset: 0xD2F450 VA: 0x180D30050
	public void set_LineInfoProvider(IXmlLineInfo value) { }

	// RVA: 0xD30070 Offset: 0xD2F470 VA: 0x180D30070
	public void set_SourceUri(Uri value) { }

	// RVA: 0xA2BE10 Offset: 0xA2B210 VA: 0x180A2BE10
	public void set_ValidationEventSender(object value) { }

	// RVA: 0xD2FE30 Offset: 0xD2F230 VA: 0x180D2FE30
	public void add_ValidationEventHandler(ValidationEventHandler value) { }

	// RVA: 0xD2FFD0 Offset: 0xD2F3D0 VA: 0x180D2FFD0
	public void remove_ValidationEventHandler(ValidationEventHandler value) { }

	// RVA: 0xD23150 Offset: 0xD22550 VA: 0x180D23150
	public void AddSchema(XmlSchema schema) { }

	// RVA: 0xD29880 Offset: 0xD28C80 VA: 0x180D29880
	public void Initialize() { }

	// RVA: 0xD295B0 Offset: 0xD289B0 VA: 0x180D295B0
	public void Initialize(XmlSchemaObject partialValidationType) { }

	// RVA: 0xD2E750 Offset: 0xD2DB50 VA: 0x180D2E750
	public void ValidateElement(string localName, string namespaceUri, XmlSchemaInfo schemaInfo, string xsiType, string xsiNil, string xsiSchemaLocation, string xsiNoNamespaceSchemaLocation) { }

	// RVA: 0xD2D780 Offset: 0xD2CB80 VA: 0x180D2D780
	public object ValidateAttribute(string localName, string namespaceUri, XmlValueGetter attributeValue, XmlSchemaInfo schemaInfo) { }

	// RVA: 0xD2D830 Offset: 0xD2CC30 VA: 0x180D2D830
	private object ValidateAttribute(string lName, string ns, XmlValueGetter attributeValueGetter, string attributeStringValue, XmlSchemaInfo schemaInfo) { }

	// RVA: 0xD2EC40 Offset: 0xD2E040 VA: 0x180D2EC40
	public void ValidateEndOfAttributes(XmlSchemaInfo schemaInfo) { }

	// RVA: 0xD2F220 Offset: 0xD2E620 VA: 0x180D2F220
	public void ValidateText(XmlValueGetter elementValue) { }

	// RVA: 0xD2ED80 Offset: 0xD2E180 VA: 0x180D2ED80
	private void ValidateText(string elementStringValue, XmlValueGetter elementValueGetter) { }

	// RVA: 0xD2F500 Offset: 0xD2E900 VA: 0x180D2F500
	public void ValidateWhitespace(XmlValueGetter elementValue) { }

	// RVA: 0xD2F2A0 Offset: 0xD2E6A0 VA: 0x180D2F2A0
	private void ValidateWhitespace(string elementStringValue, XmlValueGetter elementValueGetter) { }

	// RVA: 0xD2EC30 Offset: 0xD2E030 VA: 0x180D2EC30
	public object ValidateEndElement(XmlSchemaInfo schemaInfo) { }

	// RVA: 0xD2CAD0 Offset: 0xD2BED0 VA: 0x180D2CAD0
	public void SkipToEndElement(XmlSchemaInfo schemaInfo) { }

	// RVA: 0xD27CC0 Offset: 0xD270C0 VA: 0x180D27CC0
	public void EndValidation() { }

	// RVA: 0xD28BD0 Offset: 0xD27FD0 VA: 0x180D28BD0
	internal void GetUnspecifiedDefaultAttributes(ArrayList defaultAttributes, bool createNodeData) { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	internal XmlSchemaSet get_SchemaSet() { }

	// RVA: 0x4BE200 Offset: 0x4BD600 VA: 0x1804BE200
	internal XmlSchemaValidationFlags get_ValidationFlags() { }

	// RVA: 0xD2FEB0 Offset: 0xD2F2B0 VA: 0x180D2FEB0
	internal XmlSchemaContentType get_CurrentContentType() { }

	// RVA: 0xD2CAB0 Offset: 0xD2BEB0 VA: 0x180D2CAB0
	internal void SetDtdSchemaInfo(IDtdInfo dtdSchemaInfo) { }

	// RVA: 0xD2FF90 Offset: 0xD2F390 VA: 0x180D2FF90
	private bool get_StrictlyAssessed() { }

	// RVA: 0xD2FF10 Offset: 0xD2F310 VA: 0x180D2FF10
	private bool get_HasSchema() { }

	// RVA: 0xD28440 Offset: 0xD27840 VA: 0x180D28440
	internal string GetConcatenatedValue() { }

	// RVA: 0xD29A00 Offset: 0xD28E00 VA: 0x180D29A00
	private object InternalValidateEndElement(XmlSchemaInfo schemaInfo, object typedValue) { }

	// RVA: 0xD2B420 Offset: 0xD2A820 VA: 0x180D2B420
	private void ProcessSchemaLocations(string xsiSchemaLocation, string xsiNoNamespaceSchemaLocation) { }

	// RVA: 0xD2E280 Offset: 0xD2D680 VA: 0x180D2E280
	private object ValidateElementContext(XmlQualifiedName elementName, out bool invalidElementInContext) { }

	// RVA: 0xD28840 Offset: 0xD27C40 VA: 0x180D28840
	private XmlSchemaElement GetSubstitutionGroupHead(XmlQualifiedName member) { }

	// RVA: 0xD2CF40 Offset: 0xD2C340 VA: 0x180D2CF40
	private object ValidateAtomicValue(string stringValue, out XmlSchemaSimpleType memberType) { }

	// RVA: 0xD2D290 Offset: 0xD2C690 VA: 0x180D2D290
	private object ValidateAtomicValue(object parsedValue, out XmlSchemaSimpleType memberType) { }

	// RVA: 0xD28B60 Offset: 0xD27F60 VA: 0x180D28B60
	private string GetTypeName(SchemaDeclBase decl) { }

	// RVA: 0xD2BE80 Offset: 0xD2B280 VA: 0x180D2BE80
	private void SaveTextValue(object value) { }

	// RVA: 0xD2BAE0 Offset: 0xD2AEE0 VA: 0x180D2BAE0
	private void Push(XmlQualifiedName elementName) { }

	// RVA: 0xD2A530 Offset: 0xD29930 VA: 0x180D2A530
	private void Pop() { }

	// RVA: 0xD280E0 Offset: 0xD274E0 VA: 0x180D280E0
	private SchemaElementDecl FastGetElementDecl(XmlQualifiedName elementName, object particle) { }

	// RVA: 0xD24D60 Offset: 0xD24160 VA: 0x180D24D60
	private SchemaElementDecl CheckXsiTypeAndNil(SchemaElementDecl elementDecl, string xsiType, string xsiNil, ref bool declFound) { }

	// RVA: 0xD2CD00 Offset: 0xD2C100 VA: 0x180D2CD00
	private void ThrowDeclNotFoundWarningOrError(bool declFound) { }

	// RVA: 0xD23F40 Offset: 0xD23340 VA: 0x180D23F40
	private void CheckElementProperties() { }

	// RVA: 0xD2ED20 Offset: 0xD2E120 VA: 0x180D2ED20
	private void ValidateStartElementIdentityConstraints() { }

	// RVA: 0xD24540 Offset: 0xD23940 VA: 0x180D24540
	private SchemaAttDef CheckIsXmlAttribute(XmlQualifiedName attQName) { }

	// RVA: 0xD235C0 Offset: 0xD229C0 VA: 0x180D235C0
	private void AddXmlNamespaceSchema() { }

	// RVA: 0xD24680 Offset: 0xD23A80 VA: 0x180D24680
	internal object CheckMixedValueConstraint(string elementValue) { }

	// RVA: 0xD2A020 Offset: 0xD29420 VA: 0x180D2A020
	private void LoadSchema(string uri, string url) { }

	// RVA: 0xD2BD30 Offset: 0xD2B130 VA: 0x180D2BD30
	internal void RecompileSchemaSet() { }

	// RVA: 0xD2B810 Offset: 0xD2AC10 VA: 0x180D2B810
	private void ProcessTokenizedType(XmlTokenizedType ttype, string name, bool attrValue) { }

	// RVA: 0xD23BB0 Offset: 0xD22FB0 VA: 0x180D23BB0
	private object CheckAttributeValue(object value, SchemaAttDef attdef) { }

	// RVA: 0xD24020 Offset: 0xD23420 VA: 0x180D24020
	private object CheckElementValue(string stringValue) { }

	// RVA: 0xD24BE0 Offset: 0xD23FE0 VA: 0x180D24BE0
	private void CheckTokenizedTypes(XmlSchemaDatatype dtype, object typedValue, bool attrValue) { }

	// RVA: 0xD28420 Offset: 0xD27820 VA: 0x180D28420
	private object FindId(string name) { }

	// RVA: 0xD24420 Offset: 0xD23820 VA: 0x180D24420
	private void CheckForwardRefs() { }

	// RVA: 0xD2FEF0 Offset: 0xD2F2F0 VA: 0x180D2FEF0
	private bool get_HasIdentityConstraints() { }

	// RVA: 0xD2FF60 Offset: 0xD2F360 VA: 0x180D2FF60
	internal bool get_ProcessIdentityConstraints() { }

	// RVA: 0xD2FF80 Offset: 0xD2F380 VA: 0x180D2FF80
	internal bool get_ReportValidationWarnings() { }

	// RVA: 0xD2FF70 Offset: 0xD2F370 VA: 0x180D2FF70
	internal bool get_ProcessSchemaHints() { }

	// RVA: 0xD24930 Offset: 0xD23D30 VA: 0x180D24930
	private void CheckStateTransition(ValidatorState toState, string methodName) { }

	// RVA: 0xD25570 Offset: 0xD24970 VA: 0x180D25570
	private void ClearPSVI() { }

	// RVA: 0xD24780 Offset: 0xD23B80 VA: 0x180D24780
	private void CheckRequiredAttributes(SchemaElementDecl currentElementDecl) { }

	// RVA: 0xD286E0 Offset: 0xD27AE0 VA: 0x180D286E0
	private XmlSchemaElement GetSchemaElement() { }

	// RVA: 0xD28470 Offset: 0xD27870 VA: 0x180D28470
	internal string GetDefaultAttributePrefix(string attributeNS) { }

	// RVA: 0xD22BD0 Offset: 0xD21FD0 VA: 0x180D22BD0
	private void AddIdentityConstraints() { }

	// RVA: 0xD25D70 Offset: 0xD25170 VA: 0x180D25D70
	private void ElementIdentityConstraints() { }

	// RVA: 0xD23660 Offset: 0xD22A60 VA: 0x180D23660
	private void AttributeIdentityConstraints(string name, string ns, object obj, string sobj, XmlSchemaDatatype datatype) { }

	// RVA: 0xD26E40 Offset: 0xD26240 VA: 0x180D26E40
	private void EndElementIdentityConstraints(object typedValue, string stringValue, XmlSchemaDatatype datatype) { }

	// RVA: 0xD26120 Offset: 0xD25520 VA: 0x180D26120
	internal static void ElementValidationError(XmlQualifiedName name, ValidationState context, ValidationEventHandler eventHandler, object sender, string sourceUri, int lineNo, int linePos, XmlSchemaSet schemaSet) { }

	// RVA: 0xD255D0 Offset: 0xD249D0 VA: 0x180D255D0
	internal static void CompleteValidationError(ValidationState context, ValidationEventHandler eventHandler, object sender, string sourceUri, int lineNo, int linePos, XmlSchemaSet schemaSet) { }

	// RVA: 0xD2A670 Offset: 0xD29A70 VA: 0x180D2A670
	internal static string PrintExpectedElements(ArrayList expected, bool getParticles) { }

	// RVA: 0xD2B1A0 Offset: 0xD2A5A0 VA: 0x180D2B1A0
	private static string PrintNames(ArrayList expected) { }

	// RVA: 0xD2ABC0 Offset: 0xD29FC0 VA: 0x180D2ABC0
	private static void PrintNamesWithNS(ArrayList expected, StringBuilder builder) { }

	// RVA: 0xD27ED0 Offset: 0xD272D0 VA: 0x180D27ED0
	private static void EnumerateAny(StringBuilder builder, string namespaces) { }

	// RVA: 0xD2BCC0 Offset: 0xD2B0C0 VA: 0x180D2BCC0
	internal static string QNameString(string localName, string ns) { }

	// RVA: 0xD23990 Offset: 0xD22D90 VA: 0x180D23990
	internal static string BuildElementName(XmlQualifiedName qname) { }

	// RVA: 0xD23A10 Offset: 0xD22E10 VA: 0x180D23A10
	internal static string BuildElementName(string localName, string ns) { }

	// RVA: 0xD2B310 Offset: 0xD2A710 VA: 0x180D2B310
	private void ProcessEntity(string name) { }

	// RVA: 0xD2C5F0 Offset: 0xD2B9F0 VA: 0x180D2C5F0
	private void SendValidationEvent(string code) { }

	// RVA: 0xD2C7D0 Offset: 0xD2BBD0 VA: 0x180D2C7D0
	private void SendValidationEvent(string code, string[] args) { }

	// RVA: 0xD2C3A0 Offset: 0xD2B7A0 VA: 0x180D2C3A0
	private void SendValidationEvent(string code, string arg) { }

	// RVA: 0xD2C8E0 Offset: 0xD2BCE0 VA: 0x180D2C8E0
	private void SendValidationEvent(string code, string arg1, string arg2) { }

	// RVA: 0xD2C160 Offset: 0xD2B560 VA: 0x180D2C160
	private void SendValidationEvent(string code, string[] args, Exception innerException, XmlSeverityType severity) { }

	// RVA: 0xD2C650 Offset: 0xD2BA50 VA: 0x180D2C650
	private void SendValidationEvent(string code, string[] args, Exception innerException) { }

	// RVA: 0xD2C0A0 Offset: 0xD2B4A0 VA: 0x180D2C0A0
	private void SendValidationEvent(XmlSchemaValidationException e) { }

	// RVA: 0xD2C490 Offset: 0xD2B890 VA: 0x180D2C490
	private void SendValidationEvent(XmlSchemaException e) { }

	// RVA: 0xD2BED0 Offset: 0xD2B2D0 VA: 0x180D2BED0
	private void SendValidationEvent(string code, string msg, XmlSeverityType severity) { }

	// RVA: 0xD2C2A0 Offset: 0xD2B6A0 VA: 0x180D2C2A0
	private void SendValidationEvent(XmlSchemaValidationException e, XmlSeverityType severity) { }

	// RVA: 0xD2BFF0 Offset: 0xD2B3F0 VA: 0x180D2BFF0
	internal static void SendValidationEvent(ValidationEventHandler eventHandler, object sender, XmlSchemaValidationException e, XmlSeverityType severity) { }

	// RVA: 0xD2F580 Offset: 0xD2E980 VA: 0x180D2F580
	private static void .cctor() { }

}

public enum XmlSchemaValidity // TypeDefIndex: 2396
{	// Fields
	public int value__; // 0x0
	public const XmlSchemaValidity NotKnown = 0;
	public const XmlSchemaValidity Valid = 1;
	public const XmlSchemaValidity Invalid = 2;

}

public enum XmlSeverityType // TypeDefIndex: 2397
{	// Fields
	public int value__; // 0x0
	public const XmlSeverityType Error = 0;
	public const XmlSeverityType Warning = 1;

}

public enum XmlTypeCode // TypeDefIndex: 2398
{	// Fields
	public int value__; // 0x0
	public const XmlTypeCode None = 0;
	public const XmlTypeCode Item = 1;
	public const XmlTypeCode Node = 2;
	public const XmlTypeCode Document = 3;
	public const XmlTypeCode Element = 4;
	public const XmlTypeCode Attribute = 5;
	public const XmlTypeCode Namespace = 6;
	public const XmlTypeCode ProcessingInstruction = 7;
	public const XmlTypeCode Comment = 8;
	public const XmlTypeCode Text = 9;
	public const XmlTypeCode AnyAtomicType = 10;
	public const XmlTypeCode UntypedAtomic = 11;
	public const XmlTypeCode String = 12;
	public const XmlTypeCode Boolean = 13;
	public const XmlTypeCode Decimal = 14;
	public const XmlTypeCode Float = 15;
	public const XmlTypeCode Double = 16;
	public const XmlTypeCode Duration = 17;
	public const XmlTypeCode DateTime = 18;
	public const XmlTypeCode Time = 19;
	public const XmlTypeCode Date = 20;
	public const XmlTypeCode GYearMonth = 21;
	public const XmlTypeCode GYear = 22;
	public const XmlTypeCode GMonthDay = 23;
	public const XmlTypeCode GDay = 24;
	public const XmlTypeCode GMonth = 25;
	public const XmlTypeCode HexBinary = 26;
	public const XmlTypeCode Base64Binary = 27;
	public const XmlTypeCode AnyUri = 28;
	public const XmlTypeCode QName = 29;
	public const XmlTypeCode Notation = 30;
	public const XmlTypeCode NormalizedString = 31;
	public const XmlTypeCode Token = 32;
	public const XmlTypeCode Language = 33;
	public const XmlTypeCode NmToken = 34;
	public const XmlTypeCode Name = 35;
	public const XmlTypeCode NCName = 36;
	public const XmlTypeCode Id = 37;
	public const XmlTypeCode Idref = 38;
	public const XmlTypeCode Entity = 39;
	public const XmlTypeCode Integer = 40;
	public const XmlTypeCode NonPositiveInteger = 41;
	public const XmlTypeCode NegativeInteger = 42;
	public const XmlTypeCode Long = 43;
	public const XmlTypeCode Int = 44;
	public const XmlTypeCode Short = 45;
	public const XmlTypeCode Byte = 46;
	public const XmlTypeCode NonNegativeInteger = 47;
	public const XmlTypeCode UnsignedLong = 48;
	public const XmlTypeCode UnsignedInt = 49;
	public const XmlTypeCode UnsignedShort = 50;
	public const XmlTypeCode UnsignedByte = 51;
	public const XmlTypeCode PositiveInteger = 52;
	public const XmlTypeCode YearMonthDuration = 53;
	public const XmlTypeCode DayTimeDuration = 54;

}

internal abstract class XmlValueConverter // TypeDefIndex: 2399
{	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool ToBoolean(long value);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool ToBoolean(int value);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool ToBoolean(double value);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool ToBoolean(DateTime value);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool ToBoolean(string value);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract bool ToBoolean(object value);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract int ToInt32(bool value);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract int ToInt32(long value);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract int ToInt32(double value);

	// RVA: -1 Offset: -1 Slot: 13
	public abstract int ToInt32(DateTime value);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract int ToInt32(string value);

	// RVA: -1 Offset: -1 Slot: 15
	public abstract int ToInt32(object value);

	// RVA: -1 Offset: -1 Slot: 16
	public abstract long ToInt64(bool value);

	// RVA: -1 Offset: -1 Slot: 17
	public abstract long ToInt64(int value);

	// RVA: -1 Offset: -1 Slot: 18
	public abstract long ToInt64(double value);

	// RVA: -1 Offset: -1 Slot: 19
	public abstract long ToInt64(DateTime value);

	// RVA: -1 Offset: -1 Slot: 20
	public abstract long ToInt64(string value);

	// RVA: -1 Offset: -1 Slot: 21
	public abstract long ToInt64(object value);

	// RVA: -1 Offset: -1 Slot: 22
	public abstract Decimal ToDecimal(string value);

	// RVA: -1 Offset: -1 Slot: 23
	public abstract Decimal ToDecimal(object value);

	// RVA: -1 Offset: -1 Slot: 24
	public abstract double ToDouble(bool value);

	// RVA: -1 Offset: -1 Slot: 25
	public abstract double ToDouble(int value);

	// RVA: -1 Offset: -1 Slot: 26
	public abstract double ToDouble(long value);

	// RVA: -1 Offset: -1 Slot: 27
	public abstract double ToDouble(DateTime value);

	// RVA: -1 Offset: -1 Slot: 28
	public abstract double ToDouble(string value);

	// RVA: -1 Offset: -1 Slot: 29
	public abstract double ToDouble(object value);

	// RVA: -1 Offset: -1 Slot: 30
	public abstract float ToSingle(double value);

	// RVA: -1 Offset: -1 Slot: 31
	public abstract float ToSingle(string value);

	// RVA: -1 Offset: -1 Slot: 32
	public abstract float ToSingle(object value);

	// RVA: -1 Offset: -1 Slot: 33
	public abstract DateTime ToDateTime(bool value);

	// RVA: -1 Offset: -1 Slot: 34
	public abstract DateTime ToDateTime(int value);

	// RVA: -1 Offset: -1 Slot: 35
	public abstract DateTime ToDateTime(long value);

	// RVA: -1 Offset: -1 Slot: 36
	public abstract DateTime ToDateTime(double value);

	// RVA: -1 Offset: -1 Slot: 37
	public abstract DateTime ToDateTime(DateTimeOffset value);

	// RVA: -1 Offset: -1 Slot: 38
	public abstract DateTime ToDateTime(string value);

	// RVA: -1 Offset: -1 Slot: 39
	public abstract DateTime ToDateTime(object value);

	// RVA: -1 Offset: -1 Slot: 40
	public abstract DateTimeOffset ToDateTimeOffset(DateTime value);

	// RVA: -1 Offset: -1 Slot: 41
	public abstract DateTimeOffset ToDateTimeOffset(string value);

	// RVA: -1 Offset: -1 Slot: 42
	public abstract DateTimeOffset ToDateTimeOffset(object value);

	// RVA: -1 Offset: -1 Slot: 43
	public abstract string ToString(bool value);

	// RVA: -1 Offset: -1 Slot: 44
	public abstract string ToString(int value);

	// RVA: -1 Offset: -1 Slot: 45
	public abstract string ToString(long value);

	// RVA: -1 Offset: -1 Slot: 46
	public abstract string ToString(Decimal value);

	// RVA: -1 Offset: -1 Slot: 47
	public abstract string ToString(float value);

	// RVA: -1 Offset: -1 Slot: 48
	public abstract string ToString(double value);

	// RVA: -1 Offset: -1 Slot: 49
	public abstract string ToString(DateTime value);

	// RVA: -1 Offset: -1 Slot: 50
	public abstract string ToString(DateTimeOffset value);

	// RVA: -1 Offset: -1 Slot: 51
	public abstract string ToString(object value);

	// RVA: -1 Offset: -1 Slot: 52
	public abstract string ToString(object value, IXmlNamespaceResolver nsResolver);

	// RVA: -1 Offset: -1 Slot: 53
	public abstract object ChangeType(bool value, Type destinationType);

	// RVA: -1 Offset: -1 Slot: 54
	public abstract object ChangeType(int value, Type destinationType);

	// RVA: -1 Offset: -1 Slot: 55
	public abstract object ChangeType(long value, Type destinationType);

	// RVA: -1 Offset: -1 Slot: 56
	public abstract object ChangeType(Decimal value, Type destinationType);

	// RVA: -1 Offset: -1 Slot: 57
	public abstract object ChangeType(double value, Type destinationType);

	// RVA: -1 Offset: -1 Slot: 58
	public abstract object ChangeType(DateTime value, Type destinationType);

	// RVA: -1 Offset: -1 Slot: 59
	public abstract object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver);

	// RVA: -1 Offset: -1 Slot: 60
	public abstract object ChangeType(object value, Type destinationType);

	// RVA: -1 Offset: -1 Slot: 61
	public abstract object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver);

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	protected void .ctor() { }

}

internal abstract class XmlBaseConverter : XmlValueConverter // TypeDefIndex: 2400
{	// Fields
	private XmlSchemaType schemaType; // 0x10
	private XmlTypeCode typeCode; // 0x18
	private Type clrTypeDefault; // 0x20
	protected static readonly Type ICollectionType; // 0x0
	protected static readonly Type IEnumerableType; // 0x8
	protected static readonly Type IListType; // 0x10
	protected static readonly Type ObjectArrayType; // 0x18
	protected static readonly Type StringArrayType; // 0x20
	protected static readonly Type XmlAtomicValueArrayType; // 0x28
	protected static readonly Type DecimalType; // 0x30
	protected static readonly Type Int32Type; // 0x38
	protected static readonly Type Int64Type; // 0x40
	protected static readonly Type StringType; // 0x48
	protected static readonly Type XmlAtomicValueType; // 0x50
	protected static readonly Type ObjectType; // 0x58
	protected static readonly Type ByteType; // 0x60
	protected static readonly Type Int16Type; // 0x68
	protected static readonly Type SByteType; // 0x70
	protected static readonly Type UInt16Type; // 0x78
	protected static readonly Type UInt32Type; // 0x80
	protected static readonly Type UInt64Type; // 0x88
	protected static readonly Type XPathItemType; // 0x90
	protected static readonly Type DoubleType; // 0x98
	protected static readonly Type SingleType; // 0xA0
	protected static readonly Type DateTimeType; // 0xA8
	protected static readonly Type DateTimeOffsetType; // 0xB0
	protected static readonly Type BooleanType; // 0xB8
	protected static readonly Type ByteArrayType; // 0xC0
	protected static readonly Type XmlQualifiedNameType; // 0xC8
	protected static readonly Type UriType; // 0xD0
	protected static readonly Type TimeSpanType; // 0xD8
	protected static readonly Type XPathNavigatorType; // 0xE0

	// Properties
	protected XmlSchemaType SchemaType { get; }
	protected XmlTypeCode TypeCode { get; }
	protected string XmlTypeName { get; }
	protected Type DefaultClrType { get; }

	// Methods

	// RVA: 0x1433A40 Offset: 0x1432E40 VA: 0x181433A40
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x1433B50 Offset: 0x1432F50 VA: 0x181433B50
	protected void .ctor(XmlTypeCode typeCode) { }

	// RVA: 0x14339D0 Offset: 0x1432DD0 VA: 0x1814339D0
	protected void .ctor(XmlBaseConverter converterAtomic) { }

	// RVA: 0x1433970 Offset: 0x1432D70 VA: 0x181433970
	protected void .ctor(XmlBaseConverter converterAtomic, Type clrTypeDefault) { }

	// RVA: 0x1430E80 Offset: 0x1430280 VA: 0x181430E80 Slot: 7
	public override bool ToBoolean(DateTime value) { }

	// RVA: 0x1430CC0 Offset: 0x14300C0 VA: 0x181430CC0 Slot: 6
	public override bool ToBoolean(double value) { }

	// RVA: 0x1430DA0 Offset: 0x14301A0 VA: 0x181430DA0 Slot: 5
	public override bool ToBoolean(int value) { }

	// RVA: 0x1430BE0 Offset: 0x142FFE0 VA: 0x181430BE0 Slot: 4
	public override bool ToBoolean(long value) { }

	// RVA: 0x1430B20 Offset: 0x142FF20 VA: 0x181430B20 Slot: 8
	public override bool ToBoolean(string value) { }

	// RVA: 0x1430F60 Offset: 0x1430360 VA: 0x181430F60 Slot: 9
	public override bool ToBoolean(object value) { }

	// RVA: 0x14317D0 Offset: 0x1430BD0 VA: 0x1814317D0 Slot: 33
	public override DateTime ToDateTime(bool value) { }

	// RVA: 0x1431610 Offset: 0x1430A10 VA: 0x181431610 Slot: 37
	public override DateTime ToDateTime(DateTimeOffset value) { }

	// RVA: 0x14316F0 Offset: 0x1430AF0 VA: 0x1814316F0 Slot: 36
	public override DateTime ToDateTime(double value) { }

	// RVA: 0x14312D0 Offset: 0x14306D0 VA: 0x1814312D0 Slot: 34
	public override DateTime ToDateTime(int value) { }

	// RVA: 0x1431470 Offset: 0x1430870 VA: 0x181431470 Slot: 35
	public override DateTime ToDateTime(long value) { }

	// RVA: 0x1431550 Offset: 0x1430950 VA: 0x181431550 Slot: 38
	public override DateTime ToDateTime(string value) { }

	// RVA: 0x14313B0 Offset: 0x14307B0 VA: 0x1814313B0 Slot: 39
	public override DateTime ToDateTime(object value) { }

	// RVA: 0x1431020 Offset: 0x1430420 VA: 0x181431020 Slot: 40
	public override DateTimeOffset ToDateTimeOffset(DateTime value) { }

	// RVA: 0x1431110 Offset: 0x1430510 VA: 0x181431110 Slot: 41
	public override DateTimeOffset ToDateTimeOffset(string value) { }

	// RVA: 0x14311F0 Offset: 0x14305F0 VA: 0x1814311F0 Slot: 42
	public override DateTimeOffset ToDateTimeOffset(object value) { }

	// RVA: 0x1431980 Offset: 0x1430D80 VA: 0x181431980 Slot: 22
	public override Decimal ToDecimal(string value) { }

	// RVA: 0x14318B0 Offset: 0x1430CB0 VA: 0x1814318B0 Slot: 23
	public override Decimal ToDecimal(object value) { }

	// RVA: 0x1431CD0 Offset: 0x14310D0 VA: 0x181431CD0 Slot: 24
	public override double ToDouble(bool value) { }

	// RVA: 0x1431E70 Offset: 0x1431270 VA: 0x181431E70 Slot: 27
	public override double ToDouble(DateTime value) { }

	// RVA: 0x1431B30 Offset: 0x1430F30 VA: 0x181431B30 Slot: 25
	public override double ToDouble(int value) { }

	// RVA: 0x1431A50 Offset: 0x1430E50 VA: 0x181431A50 Slot: 26
	public override double ToDouble(long value) { }

	// RVA: 0x1431C10 Offset: 0x1431010 VA: 0x181431C10 Slot: 28
	public override double ToDouble(string value) { }

	// RVA: 0x1431DB0 Offset: 0x14311B0 VA: 0x181431DB0 Slot: 29
	public override double ToDouble(object value) { }

	// RVA: 0x14320F0 Offset: 0x14314F0 VA: 0x1814320F0 Slot: 10
	public override int ToInt32(bool value) { }

	// RVA: 0x14321C0 Offset: 0x14315C0 VA: 0x1814321C0 Slot: 13
	public override int ToInt32(DateTime value) { }

	// RVA: 0x1432010 Offset: 0x1431410 VA: 0x181432010 Slot: 12
	public override int ToInt32(double value) { }

	// RVA: 0x1432290 Offset: 0x1431690 VA: 0x181432290 Slot: 11
	public override int ToInt32(long value) { }

	// RVA: 0x1431F50 Offset: 0x1431350 VA: 0x181431F50 Slot: 14
	public override int ToInt32(string value) { }

	// RVA: 0x1432360 Offset: 0x1431760 VA: 0x181432360 Slot: 15
	public override int ToInt32(object value) { }

	// RVA: 0x1432670 Offset: 0x1431A70 VA: 0x181432670 Slot: 16
	public override long ToInt64(bool value) { }

	// RVA: 0x1432820 Offset: 0x1431C20 VA: 0x181432820 Slot: 19
	public override long ToInt64(DateTime value) { }

	// RVA: 0x1432740 Offset: 0x1431B40 VA: 0x181432740 Slot: 18
	public override long ToInt64(double value) { }

	// RVA: 0x14325A0 Offset: 0x14319A0 VA: 0x1814325A0 Slot: 17
	public override long ToInt64(int value) { }

	// RVA: 0x14324E0 Offset: 0x14318E0 VA: 0x1814324E0 Slot: 20
	public override long ToInt64(string value) { }

	// RVA: 0x1432420 Offset: 0x1431820 VA: 0x181432420 Slot: 21
	public override long ToInt64(object value) { }

	// RVA: 0x14329C0 Offset: 0x1431DC0 VA: 0x1814329C0 Slot: 30
	public override float ToSingle(double value) { }

	// RVA: 0x1432900 Offset: 0x1431D00 VA: 0x181432900 Slot: 31
	public override float ToSingle(string value) { }

	// RVA: 0x1432AA0 Offset: 0x1431EA0 VA: 0x181432AA0 Slot: 32
	public override float ToSingle(object value) { }

	// RVA: 0x1432B60 Offset: 0x1431F60 VA: 0x181432B60 Slot: 43
	public override string ToString(bool value) { }

	// RVA: 0x1432CE0 Offset: 0x14320E0 VA: 0x181432CE0 Slot: 49
	public override string ToString(DateTime value) { }

	// RVA: 0x1432E80 Offset: 0x1432280 VA: 0x181432E80 Slot: 50
	public override string ToString(DateTimeOffset value) { }

	// RVA: 0x1432DB0 Offset: 0x14321B0 VA: 0x181432DB0 Slot: 46
	public override string ToString(Decimal value) { }

	// RVA: 0x14331D0 Offset: 0x14325D0 VA: 0x1814331D0 Slot: 48
	public override string ToString(double value) { }

	// RVA: 0x1433020 Offset: 0x1432420 VA: 0x181433020 Slot: 44
	public override string ToString(int value) { }

	// RVA: 0x1432F50 Offset: 0x1432350 VA: 0x181432F50 Slot: 45
	public override string ToString(long value) { }

	// RVA: 0x14330E0 Offset: 0x14324E0 VA: 0x1814330E0 Slot: 47
	public override string ToString(float value) { }

	// RVA: 0x1432C20 Offset: 0x1432020 VA: 0x181432C20 Slot: 52
	public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x14331B0 Offset: 0x14325B0 VA: 0x1814331B0 Slot: 51
	public override string ToString(object value) { }

	// RVA: 0x142E3B0 Offset: 0x142D7B0 VA: 0x18142E3B0 Slot: 53
	public override object ChangeType(bool value, Type destinationType) { }

	// RVA: 0x142E210 Offset: 0x142D610 VA: 0x18142E210 Slot: 58
	public override object ChangeType(DateTime value, Type destinationType) { }

	// RVA: 0x142E460 Offset: 0x142D860 VA: 0x18142E460 Slot: 56
	public override object ChangeType(Decimal value, Type destinationType) { }

	// RVA: 0x142E310 Offset: 0x142D710 VA: 0x18142E310 Slot: 57
	public override object ChangeType(double value, Type destinationType) { }

	// RVA: 0x142E190 Offset: 0x142D590 VA: 0x18142E190 Slot: 54
	public override object ChangeType(int value, Type destinationType) { }

	// RVA: 0x142E290 Offset: 0x142D690 VA: 0x18142E290 Slot: 55
	public override object ChangeType(long value, Type destinationType) { }

	// RVA: 0x142E390 Offset: 0x142D790 VA: 0x18142E390 Slot: 59
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x142E430 Offset: 0x142D830 VA: 0x18142E430 Slot: 60
	public override object ChangeType(object value, Type destinationType) { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	protected XmlSchemaType get_SchemaType() { }

	// RVA: 0x4BE200 Offset: 0x4BD600 VA: 0x1804BE200
	protected XmlTypeCode get_TypeCode() { }

	// RVA: 0x1433C50 Offset: 0x1433050 VA: 0x181433C50
	protected string get_XmlTypeName() { }

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	protected Type get_DefaultClrType() { }

	// RVA: 0x142F960 Offset: 0x142ED60 VA: 0x18142F960
	protected static bool IsDerivedFrom(Type derivedType, Type baseType) { }

	// RVA: 0x142E4E0 Offset: 0x142D8E0 VA: 0x18142E4E0
	protected Exception CreateInvalidClrMappingException(Type sourceType, Type destinationType) { }

	// RVA: 0x142FBC0 Offset: 0x142EFC0 VA: 0x18142FBC0
	protected static string QNameToString(XmlQualifiedName name) { }

	// RVA: 0x142E120 Offset: 0x142D520 VA: 0x18142E120 Slot: 62
	protected virtual object ChangeListType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x142FCA0 Offset: 0x142F0A0 VA: 0x18142FCA0
	protected static byte[] StringToBase64Binary(string value) { }

	// RVA: 0x142FEE0 Offset: 0x142F2E0 VA: 0x18142FEE0
	protected static DateTime StringToDate(string value) { }

	// RVA: 0x142FE60 Offset: 0x142F260 VA: 0x18142FE60
	protected static DateTime StringToDateTime(string value) { }

	// RVA: 0x142FF60 Offset: 0x142F360 VA: 0x18142FF60
	protected static TimeSpan StringToDayTimeDuration(string value) { }

	// RVA: 0x142FFC0 Offset: 0x142F3C0 VA: 0x18142FFC0
	protected static TimeSpan StringToDuration(string value) { }

	// RVA: 0x14300C0 Offset: 0x142F4C0 VA: 0x1814300C0
	protected static DateTime StringToGDay(string value) { }

	// RVA: 0x1430300 Offset: 0x142F700 VA: 0x181430300
	protected static DateTime StringToGMonth(string value) { }

	// RVA: 0x14301E0 Offset: 0x142F5E0 VA: 0x1814301E0
	protected static DateTime StringToGMonthDay(string value) { }

	// RVA: 0x1430540 Offset: 0x142F940 VA: 0x181430540
	protected static DateTime StringToGYear(string value) { }

	// RVA: 0x1430420 Offset: 0x142F820 VA: 0x181430420
	protected static DateTime StringToGYearMonth(string value) { }

	// RVA: 0x142FD20 Offset: 0x142F120 VA: 0x18142FD20
	protected static DateTimeOffset StringToDateOffset(string value) { }

	// RVA: 0x142FDC0 Offset: 0x142F1C0 VA: 0x18142FDC0
	protected static DateTimeOffset StringToDateTimeOffset(string value) { }

	// RVA: 0x1430020 Offset: 0x142F420 VA: 0x181430020
	protected static DateTimeOffset StringToGDayOffset(string value) { }

	// RVA: 0x1430260 Offset: 0x142F660 VA: 0x181430260
	protected static DateTimeOffset StringToGMonthOffset(string value) { }

	// RVA: 0x1430140 Offset: 0x142F540 VA: 0x181430140
	protected static DateTimeOffset StringToGMonthDayOffset(string value) { }

	// RVA: 0x14304A0 Offset: 0x142F8A0 VA: 0x1814304A0
	protected static DateTimeOffset StringToGYearOffset(string value) { }

	// RVA: 0x1430380 Offset: 0x142F780 VA: 0x181430380
	protected static DateTimeOffset StringToGYearMonthOffset(string value) { }

	// RVA: 0x14305C0 Offset: 0x142F9C0 VA: 0x1814305C0
	protected static byte[] StringToHexBinary(string value) { }

	// RVA: 0x1430690 Offset: 0x142FA90 VA: 0x181430690
	protected static XmlQualifiedName StringToQName(string value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x14309B0 Offset: 0x142FDB0 VA: 0x1814309B0
	protected static DateTime StringToTime(string value) { }

	// RVA: 0x1430910 Offset: 0x142FD10 VA: 0x181430910
	protected static DateTimeOffset StringToTimeOffset(string value) { }

	// RVA: 0x1430A30 Offset: 0x142FE30 VA: 0x181430A30
	protected static TimeSpan StringToYearMonthDuration(string value) { }

	// RVA: 0x142E0A0 Offset: 0x142D4A0 VA: 0x18142E0A0
	protected static string AnyUriToString(Uri value) { }

	// RVA: 0x142E0C0 Offset: 0x142D4C0 VA: 0x18142E0C0
	protected static string Base64BinaryToString(byte[] value) { }

	// RVA: 0x142E900 Offset: 0x142DD00 VA: 0x18142E900
	protected static string DateToString(DateTime value) { }

	// RVA: 0x142E8C0 Offset: 0x142DCC0 VA: 0x18142E8C0
	protected static string DateTimeToString(DateTime value) { }

	// RVA: 0x142E940 Offset: 0x142DD40 VA: 0x18142E940
	protected static string DayTimeDurationToString(TimeSpan value) { }

	// RVA: 0x142EFC0 Offset: 0x142E3C0 VA: 0x18142EFC0
	protected static string DurationToString(TimeSpan value) { }

	// RVA: 0x142F070 Offset: 0x142E470 VA: 0x18142F070
	protected static string GDayToString(DateTime value) { }

	// RVA: 0x142F190 Offset: 0x142E590 VA: 0x18142F190
	protected static string GMonthToString(DateTime value) { }

	// RVA: 0x142F100 Offset: 0x142E500 VA: 0x18142F100
	protected static string GMonthDayToString(DateTime value) { }

	// RVA: 0x142F2B0 Offset: 0x142E6B0 VA: 0x18142F2B0
	protected static string GYearToString(DateTime value) { }

	// RVA: 0x142F220 Offset: 0x142E620 VA: 0x18142F220
	protected static string GYearMonthToString(DateTime value) { }

	// RVA: 0x142E810 Offset: 0x142DC10 VA: 0x18142E810
	protected static string DateOffsetToString(DateTimeOffset value) { }

	// RVA: 0x142E870 Offset: 0x142DC70 VA: 0x18142E870
	protected static string DateTimeOffsetToString(DateTimeOffset value) { }

	// RVA: 0x142F020 Offset: 0x142E420 VA: 0x18142F020
	protected static string GDayOffsetToString(DateTimeOffset value) { }

	// RVA: 0x142F140 Offset: 0x142E540 VA: 0x18142F140
	protected static string GMonthOffsetToString(DateTimeOffset value) { }

	// RVA: 0x142F0B0 Offset: 0x142E4B0 VA: 0x18142F0B0
	protected static string GMonthDayOffsetToString(DateTimeOffset value) { }

	// RVA: 0x142F260 Offset: 0x142E660 VA: 0x18142F260
	protected static string GYearOffsetToString(DateTimeOffset value) { }

	// RVA: 0x142F1D0 Offset: 0x142E5D0 VA: 0x18142F1D0
	protected static string GYearMonthOffsetToString(DateTimeOffset value) { }

	// RVA: 0x142FA30 Offset: 0x142EE30 VA: 0x18142FA30
	protected static string QNameToString(XmlQualifiedName qname, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1430AE0 Offset: 0x142FEE0 VA: 0x181430AE0
	protected static string TimeToString(DateTime value) { }

	// RVA: 0x1430A90 Offset: 0x142FE90 VA: 0x181430A90
	protected static string TimeOffsetToString(DateTimeOffset value) { }

	// RVA: 0x14333C0 Offset: 0x14327C0 VA: 0x1814333C0
	protected static string YearMonthDurationToString(TimeSpan value) { }

	// RVA: 0x142E860 Offset: 0x142DC60 VA: 0x18142E860
	internal static DateTime DateTimeOffsetToDateTime(DateTimeOffset value) { }

	// RVA: 0x142E9A0 Offset: 0x142DDA0 VA: 0x18142E9A0
	internal static int DecimalToInt32(Decimal value) { }

	// RVA: 0x142EBB0 Offset: 0x142DFB0 VA: 0x18142EBB0
	protected static long DecimalToInt64(Decimal value) { }

	// RVA: 0x142EDC0 Offset: 0x142E1C0 VA: 0x18142EDC0
	protected static ulong DecimalToUInt64(Decimal value) { }

	// RVA: 0x142F2F0 Offset: 0x142E6F0 VA: 0x18142F2F0
	protected static byte Int32ToByte(int value) { }

	// RVA: 0x142F400 Offset: 0x142E800 VA: 0x18142F400
	protected static short Int32ToInt16(int value) { }

	// RVA: 0x142F510 Offset: 0x142E910 VA: 0x18142F510
	protected static sbyte Int32ToSByte(int value) { }

	// RVA: 0x142F620 Offset: 0x142EA20 VA: 0x18142F620
	protected static ushort Int32ToUInt16(int value) { }

	// RVA: 0x142F730 Offset: 0x142EB30 VA: 0x18142F730
	protected static int Int64ToInt32(long value) { }

	// RVA: 0x142F850 Offset: 0x142EC50 VA: 0x18142F850
	protected static uint Int64ToUInt32(long value) { }

	// RVA: 0x1433340 Offset: 0x1432740 VA: 0x181433340
	protected static DateTime UntypedAtomicToDateTime(string value) { }

	// RVA: 0x14332A0 Offset: 0x14326A0 VA: 0x1814332A0
	protected static DateTimeOffset UntypedAtomicToDateTimeOffset(string value) { }

	// RVA: 0x1433420 Offset: 0x1432820 VA: 0x181433420
	private static void .cctor() { }

}

internal class XmlNumeric10Converter : XmlBaseConverter // TypeDefIndex: 2401
{	// Methods

	// RVA: 0x1441990 Offset: 0x1440D90 VA: 0x181441990
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x1440230 Offset: 0x143F630 VA: 0x181440230
	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	// RVA: 0x14402C0 Offset: 0x143F6C0 VA: 0x1814402C0 Slot: 22
	public override Decimal ToDecimal(string value) { }

	// RVA: 0x14403A0 Offset: 0x143F7A0 VA: 0x1814403A0 Slot: 23
	public override Decimal ToDecimal(object value) { }

	// RVA: 0x1440870 Offset: 0x143FC70 VA: 0x181440870 Slot: 11
	public override int ToInt32(long value) { }

	// RVA: 0x1440D30 Offset: 0x1440130 VA: 0x181440D30 Slot: 14
	public override int ToInt32(string value) { }

	// RVA: 0x14408D0 Offset: 0x143FCD0 VA: 0x1814408D0 Slot: 15
	public override int ToInt32(object value) { }

	// RVA: 0x1440E40 Offset: 0x1440240 VA: 0x181440E40 Slot: 17
	public override long ToInt64(int value) { }

	// RVA: 0x1441280 Offset: 0x1440680 VA: 0x181441280 Slot: 20
	public override long ToInt64(string value) { }

	// RVA: 0x1440E50 Offset: 0x1440250 VA: 0x181440E50 Slot: 21
	public override long ToInt64(object value) { }

	// RVA: 0x1441850 Offset: 0x1440C50 VA: 0x181441850 Slot: 46
	public override string ToString(Decimal value) { }

	// RVA: 0x1441940 Offset: 0x1440D40 VA: 0x181441940 Slot: 44
	public override string ToString(int value) { }

	// RVA: 0x1441390 Offset: 0x1440790 VA: 0x181441390 Slot: 45
	public override string ToString(long value) { }

	// RVA: 0x14413F0 Offset: 0x14407F0 VA: 0x1814413F0 Slot: 52
	public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x143D540 Offset: 0x143C940 VA: 0x18143D540 Slot: 56
	public override object ChangeType(Decimal value, Type destinationType) { }

	// RVA: 0x143FCE0 Offset: 0x143F0E0 VA: 0x18143FCE0 Slot: 54
	public override object ChangeType(int value, Type destinationType) { }

	// RVA: 0x143DB60 Offset: 0x143CF60 VA: 0x18143DB60 Slot: 55
	public override object ChangeType(long value, Type destinationType) { }

	// RVA: 0x143E0E0 Offset: 0x143D4E0 VA: 0x18143E0E0 Slot: 59
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x143E650 Offset: 0x143DA50 VA: 0x18143E650 Slot: 61
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x143CBB0 Offset: 0x143BFB0 VA: 0x18143CBB0
	private object ChangeTypeWildcardDestination(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x143D030 Offset: 0x143C430 VA: 0x18143D030
	private object ChangeTypeWildcardSource(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

}

internal class XmlNumeric2Converter : XmlBaseConverter // TypeDefIndex: 2402
{	// Methods

	// RVA: 0x1443DB0 Offset: 0x14431B0 VA: 0x181443DB0
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x1442F20 Offset: 0x1442320 VA: 0x181442F20
	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	// RVA: 0x1442FB0 Offset: 0x14423B0 VA: 0x181442FB0 Slot: 28
	public override double ToDouble(string value) { }

	// RVA: 0x1443080 Offset: 0x1442480 VA: 0x181443080 Slot: 29
	public override double ToDouble(object value) { }

	// RVA: 0x14437F0 Offset: 0x1442BF0 VA: 0x1814437F0 Slot: 30
	public override float ToSingle(double value) { }

	// RVA: 0x1443800 Offset: 0x1442C00 VA: 0x181443800 Slot: 31
	public override float ToSingle(string value) { }

	// RVA: 0x1443410 Offset: 0x1442810 VA: 0x181443410 Slot: 32
	public override float ToSingle(object value) { }

	// RVA: 0x1443C60 Offset: 0x1443060 VA: 0x181443C60 Slot: 48
	public override string ToString(double value) { }

	// RVA: 0x1443D10 Offset: 0x1443110 VA: 0x181443D10 Slot: 47
	public override string ToString(float value) { }

	// RVA: 0x14438D0 Offset: 0x1442CD0 VA: 0x1814438D0 Slot: 52
	public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1442580 Offset: 0x1441980 VA: 0x181442580 Slot: 57
	public override object ChangeType(double value, Type destinationType) { }

	// RVA: 0x1442A30 Offset: 0x1441E30 VA: 0x181442A30 Slot: 59
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1441A00 Offset: 0x1440E00 VA: 0x181441A00 Slot: 61
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

}

internal class XmlDateTimeConverter : XmlBaseConverter // TypeDefIndex: 2403
{	// Methods

	// RVA: 0x1438470 Offset: 0x1437870 VA: 0x181438470
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x1436DC0 Offset: 0x14361C0 VA: 0x181436DC0
	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	// RVA: 0x1437C60 Offset: 0x1437060 VA: 0x181437C60 Slot: 37
	public override DateTime ToDateTime(DateTimeOffset value) { }

	// RVA: 0x1437940 Offset: 0x1436D40 VA: 0x181437940 Slot: 38
	public override DateTime ToDateTime(string value) { }

	// RVA: 0x14375A0 Offset: 0x14369A0 VA: 0x1814375A0 Slot: 39
	public override DateTime ToDateTime(object value) { }

	// RVA: 0x1436E50 Offset: 0x1436250 VA: 0x181436E50 Slot: 40
	public override DateTimeOffset ToDateTimeOffset(DateTime value) { }

	// RVA: 0x1437260 Offset: 0x1436660 VA: 0x181437260 Slot: 41
	public override DateTimeOffset ToDateTimeOffset(string value) { }

	// RVA: 0x1436E80 Offset: 0x1436280 VA: 0x181436E80 Slot: 42
	public override DateTimeOffset ToDateTimeOffset(object value) { }

	// RVA: 0x1438060 Offset: 0x1437460 VA: 0x181438060 Slot: 49
	public override string ToString(DateTime value) { }

	// RVA: 0x1438250 Offset: 0x1437650 VA: 0x181438250 Slot: 50
	public override string ToString(DateTimeOffset value) { }

	// RVA: 0x1437CC0 Offset: 0x14370C0 VA: 0x181437CC0 Slot: 52
	public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1435790 Offset: 0x1434B90 VA: 0x181435790 Slot: 58
	public override object ChangeType(DateTime value, Type destinationType) { }

	// RVA: 0x1435C60 Offset: 0x1435060 VA: 0x181435C60 Slot: 59
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1436150 Offset: 0x1435550 VA: 0x181436150 Slot: 61
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

}

internal class XmlBooleanConverter : XmlBaseConverter // TypeDefIndex: 2404
{	// Methods

	// RVA: 0x1435720 Offset: 0x1434B20 VA: 0x181435720
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x1434FB0 Offset: 0x14343B0 VA: 0x181434FB0
	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	// RVA: 0x1435330 Offset: 0x1434730 VA: 0x181435330 Slot: 8
	public override bool ToBoolean(string value) { }

	// RVA: 0x1435040 Offset: 0x1434440 VA: 0x181435040 Slot: 9
	public override bool ToBoolean(object value) { }

	// RVA: 0x14356C0 Offset: 0x1434AC0 VA: 0x1814356C0 Slot: 43
	public override string ToString(bool value) { }

	// RVA: 0x14353C0 Offset: 0x14347C0 VA: 0x1814353C0 Slot: 52
	public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1434700 Offset: 0x1433B00 VA: 0x181434700 Slot: 53
	public override object ChangeType(bool value, Type destinationType) { }

	// RVA: 0x1434B40 Offset: 0x1433F40 VA: 0x181434B40 Slot: 59
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1433E10 Offset: 0x1433210 VA: 0x181433E10 Slot: 61
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

}

internal class XmlMiscConverter : XmlBaseConverter // TypeDefIndex: 2405
{	// Methods

	// RVA: 0x143CB40 Offset: 0x143BF40 VA: 0x18143CB40
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x143C2A0 Offset: 0x143B6A0 VA: 0x18143C2A0
	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	// RVA: 0x143C330 Offset: 0x143B730 VA: 0x18143C330 Slot: 52
	public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x143BBD0 Offset: 0x143AFD0 VA: 0x18143BBD0 Slot: 59
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x143A780 Offset: 0x1439B80 VA: 0x18143A780 Slot: 61
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x143A4B0 Offset: 0x14398B0 VA: 0x18143A4B0
	private object ChangeTypeWildcardDestination(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x143A5F0 Offset: 0x14399F0 VA: 0x18143A5F0
	private object ChangeTypeWildcardSource(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

}

internal class XmlStringConverter : XmlBaseConverter // TypeDefIndex: 2406
{	// Methods

	// RVA: 0xD30C10 Offset: 0xD30010 VA: 0x180D30C10
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0xD30940 Offset: 0xD2FD40 VA: 0x180D30940
	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	// RVA: 0xD309D0 Offset: 0xD2FDD0 VA: 0x180D309D0 Slot: 52
	public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0xD30100 Offset: 0xD2F500 VA: 0x180D30100 Slot: 59
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0xD303F0 Offset: 0xD2F7F0 VA: 0x180D303F0 Slot: 61
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

}

internal class XmlUntypedConverter : XmlListConverter // TypeDefIndex: 2407
{	// Fields
	private bool allowListToList; // 0x30
	public static readonly XmlValueConverter Untyped; // 0x0
	public static readonly XmlValueConverter UntypedList; // 0x8

	// Methods

	// RVA: 0xD383E0 Offset: 0xD377E0 VA: 0x180D383E0
	protected void .ctor() { }

	// RVA: 0xD38310 Offset: 0xD37710 VA: 0x180D38310
	protected void .ctor(XmlUntypedConverter atomicConverter, bool allowListToList) { }

	// RVA: 0xD35D20 Offset: 0xD35120 VA: 0x180D35D20 Slot: 8
	public override bool ToBoolean(string value) { }

	// RVA: 0xD35B50 Offset: 0xD34F50 VA: 0x180D35B50 Slot: 9
	public override bool ToBoolean(object value) { }

	// RVA: 0xD36210 Offset: 0xD35610 VA: 0x180D36210 Slot: 38
	public override DateTime ToDateTime(string value) { }

	// RVA: 0xD36040 Offset: 0xD35440 VA: 0x180D36040 Slot: 39
	public override DateTime ToDateTime(object value) { }

	// RVA: 0xD35DB0 Offset: 0xD351B0 VA: 0x180D35DB0 Slot: 41
	public override DateTimeOffset ToDateTimeOffset(string value) { }

	// RVA: 0xD35E60 Offset: 0xD35260 VA: 0x180D35E60 Slot: 42
	public override DateTimeOffset ToDateTimeOffset(object value) { }

	// RVA: 0xD36480 Offset: 0xD35880 VA: 0x180D36480 Slot: 22
	public override Decimal ToDecimal(string value) { }

	// RVA: 0xD362A0 Offset: 0xD356A0 VA: 0x180D362A0 Slot: 23
	public override Decimal ToDecimal(object value) { }

	// RVA: 0xD36530 Offset: 0xD35930 VA: 0x180D36530 Slot: 28
	public override double ToDouble(string value) { }

	// RVA: 0xD365C0 Offset: 0xD359C0 VA: 0x180D365C0 Slot: 29
	public override double ToDouble(object value) { }

	// RVA: 0xD36950 Offset: 0xD35D50 VA: 0x180D36950 Slot: 14
	public override int ToInt32(string value) { }

	// RVA: 0xD36790 Offset: 0xD35B90 VA: 0x180D36790 Slot: 15
	public override int ToInt32(object value) { }

	// RVA: 0xD36BB0 Offset: 0xD35FB0 VA: 0x180D36BB0 Slot: 20
	public override long ToInt64(string value) { }

	// RVA: 0xD369E0 Offset: 0xD35DE0 VA: 0x180D369E0 Slot: 21
	public override long ToInt64(object value) { }

	// RVA: 0xD36C40 Offset: 0xD36040 VA: 0x180D36C40 Slot: 31
	public override float ToSingle(string value) { }

	// RVA: 0xD36CD0 Offset: 0xD360D0 VA: 0x180D36CD0 Slot: 32
	public override float ToSingle(object value) { }

	// RVA: 0xD38120 Offset: 0xD37520 VA: 0x180D38120 Slot: 43
	public override string ToString(bool value) { }

	// RVA: 0xD36EA0 Offset: 0xD362A0 VA: 0x180D36EA0 Slot: 49
	public override string ToString(DateTime value) { }

	// RVA: 0xD38000 Offset: 0xD37400 VA: 0x180D38000 Slot: 50
	public override string ToString(DateTimeOffset value) { }

	// RVA: 0xD37FA0 Offset: 0xD373A0 VA: 0x180D37FA0 Slot: 46
	public override string ToString(Decimal value) { }

	// RVA: 0xD380C0 Offset: 0xD374C0 VA: 0x180D380C0 Slot: 48
	public override string ToString(double value) { }

	// RVA: 0xD36F00 Offset: 0xD36300 VA: 0x180D36F00 Slot: 44
	public override string ToString(int value) { }

	// RVA: 0xD38060 Offset: 0xD37460 VA: 0x180D38060 Slot: 45
	public override string ToString(long value) { }

	// RVA: 0xD36F50 Offset: 0xD36350 VA: 0x180D36F50 Slot: 47
	public override string ToString(float value) { }

	// RVA: 0xD36FB0 Offset: 0xD363B0 VA: 0x180D36FB0 Slot: 52
	public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0xD34FD0 Offset: 0xD343D0 VA: 0x180D34FD0 Slot: 53
	public override object ChangeType(bool value, Type destinationType) { }

	// RVA: 0xD351C0 Offset: 0xD345C0 VA: 0x180D351C0 Slot: 58
	public override object ChangeType(DateTime value, Type destinationType) { }

	// RVA: 0xD31F50 Offset: 0xD31350 VA: 0x180D31F50 Slot: 56
	public override object ChangeType(Decimal value, Type destinationType) { }

	// RVA: 0xD31D60 Offset: 0xD31160 VA: 0x180D31D60 Slot: 57
	public override object ChangeType(double value, Type destinationType) { }

	// RVA: 0xD32150 Offset: 0xD31550 VA: 0x180D32150 Slot: 54
	public override object ChangeType(int value, Type destinationType) { }

	// RVA: 0xD31B70 Offset: 0xD30F70 VA: 0x180D31B70 Slot: 55
	public override object ChangeType(long value, Type destinationType) { }

	// RVA: 0xD32330 Offset: 0xD31730 VA: 0x180D32330 Slot: 59
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0xD332B0 Offset: 0xD326B0 VA: 0x180D332B0 Slot: 61
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0xD318A0 Offset: 0xD30CA0 VA: 0x180D318A0
	private object ChangeTypeWildcardDestination(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0xD319E0 Offset: 0xD30DE0 VA: 0x180D319E0
	private object ChangeTypeWildcardSource(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0xD31570 Offset: 0xD30970 VA: 0x180D31570 Slot: 62
	protected override object ChangeListType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0xD353B0 Offset: 0xD347B0 VA: 0x180D353B0
	private bool SupportsType(Type clrType) { }

	// RVA: 0xD38180 Offset: 0xD37580 VA: 0x180D38180
	private static void .cctor() { }

}

internal class XmlAnyConverter : XmlBaseConverter // TypeDefIndex: 2408
{	// Fields
	public static readonly XmlValueConverter Item; // 0x0
	public static readonly XmlValueConverter AnyAtomic; // 0x8

	// Methods

	// RVA: 0x142C720 Offset: 0x142BB20 VA: 0x18142C720
	protected void .ctor(XmlTypeCode typeCode) { }

	// RVA: 0x142B5D0 Offset: 0x142A9D0 VA: 0x18142B5D0 Slot: 9
	public override bool ToBoolean(object value) { }

	// RVA: 0x142B9A0 Offset: 0x142ADA0 VA: 0x18142B9A0 Slot: 39
	public override DateTime ToDateTime(object value) { }

	// RVA: 0x142B780 Offset: 0x142AB80 VA: 0x18142B780 Slot: 42
	public override DateTimeOffset ToDateTimeOffset(object value) { }

	// RVA: 0x142BB50 Offset: 0x142AF50 VA: 0x18142BB50 Slot: 23
	public override Decimal ToDecimal(object value) { }

	// RVA: 0x142BD70 Offset: 0x142B170 VA: 0x18142BD70 Slot: 29
	public override double ToDouble(object value) { }

	// RVA: 0x142BF20 Offset: 0x142B320 VA: 0x18142BF20 Slot: 15
	public override int ToInt32(object value) { }

	// RVA: 0x142C0D0 Offset: 0x142B4D0 VA: 0x18142C0D0 Slot: 21
	public override long ToInt64(object value) { }

	// RVA: 0x142C340 Offset: 0x142B740 VA: 0x18142C340 Slot: 32
	public override float ToSingle(object value) { }

	// RVA: 0x14282E0 Offset: 0x14276E0 VA: 0x1814282E0 Slot: 53
	public override object ChangeType(bool value, Type destinationType) { }

	// RVA: 0x142AC70 Offset: 0x142A070 VA: 0x18142AC70 Slot: 58
	public override object ChangeType(DateTime value, Type destinationType) { }

	// RVA: 0x1428530 Offset: 0x1427930 VA: 0x181428530 Slot: 56
	public override object ChangeType(Decimal value, Type destinationType) { }

	// RVA: 0x1428090 Offset: 0x1427490 VA: 0x181428090 Slot: 57
	public override object ChangeType(double value, Type destinationType) { }

	// RVA: 0x142B110 Offset: 0x142A510 VA: 0x18142B110 Slot: 54
	public override object ChangeType(int value, Type destinationType) { }

	// RVA: 0x142AEC0 Offset: 0x142A2C0 VA: 0x18142AEC0 Slot: 55
	public override object ChangeType(long value, Type destinationType) { }

	// RVA: 0x142B350 Offset: 0x142A750 VA: 0x18142B350 Slot: 59
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x14287E0 Offset: 0x1427BE0 VA: 0x1814287E0 Slot: 61
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1427DC0 Offset: 0x14271C0 VA: 0x181427DC0
	private object ChangeTypeWildcardDestination(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1427F00 Offset: 0x1427300 VA: 0x181427F00
	private object ChangeTypeWildcardSource(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x142C280 Offset: 0x142B680 VA: 0x18142C280
	private XPathNavigator ToNavigator(XPathNavigator nav) { }

	// RVA: 0x142C550 Offset: 0x142B950 VA: 0x18142C550
	private static void .cctor() { }

}

internal class XmlAnyListConverter : XmlListConverter // TypeDefIndex: 2409
{	// Fields
	public static readonly XmlValueConverter ItemList; // 0x0
	public static readonly XmlValueConverter AnyAtomicList; // 0x8

	// Methods

	// RVA: 0x142CC80 Offset: 0x142C080 VA: 0x18142CC80
	protected void .ctor(XmlBaseConverter atomicConverter) { }

	// RVA: 0x142C860 Offset: 0x142BC60 VA: 0x18142C860 Slot: 61
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x142CAF0 Offset: 0x142BEF0 VA: 0x18142CAF0
	private static void .cctor() { }

}

internal class XmlListConverter : XmlBaseConverter // TypeDefIndex: 2410
{	// Fields
	protected XmlValueConverter atomicConverter; // 0x28

	// Methods

	// RVA: 0x143A3F0 Offset: 0x14397F0 VA: 0x18143A3F0
	protected void .ctor(XmlBaseConverter atomicConverter) { }

	// RVA: 0x143A340 Offset: 0x1439740 VA: 0x18143A340
	protected void .ctor(XmlBaseConverter atomicConverter, Type clrTypeDefault) { }

	// RVA: 0x143A2D0 Offset: 0x14396D0 VA: 0x18143A2D0
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x14398C0 Offset: 0x1438CC0 VA: 0x1814398C0
	public static XmlValueConverter Create(XmlValueConverter atomicConverter) { }

	// RVA: 0x1439480 Offset: 0x1438880 VA: 0x181439480 Slot: 61
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x14384E0 Offset: 0x14378E0 VA: 0x1814384E0 Slot: 62
	protected override object ChangeListType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1439AA0 Offset: 0x1438EA0 VA: 0x181439AA0
	private bool IsListType(Type type) { }

	// RVA: -1 Offset: -1
	private T[] ToArray<T>(object list, IXmlNamespaceResolver nsResolver) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1AA2FA0 Offset: 0x1AA23A0 VA: 0x181AA2FA0
	|-XmlListConverter.ToArray<bool>
	|
	|-RVA: 0x1AA33E0 Offset: 0x1AA27E0 VA: 0x181AA33E0
	|-XmlListConverter.ToArray<byte>
	|
	|-RVA: 0x1AA55E0 Offset: 0x1AA49E0 VA: 0x181AA55E0
	|-XmlListConverter.ToArray<byte[]>
	|-XmlListConverter.ToArray<object>
	|-XmlListConverter.ToArray<string>
	|-XmlListConverter.ToArray<Uri>
	|-XmlListConverter.ToArray<XmlAtomicValue>
	|-XmlListConverter.ToArray<XPathItem>
	|-XmlListConverter.ToArray<XPathNavigator>
	|-XmlListConverter.ToArray<XmlQualifiedName>
	|
	|-RVA: 0x1AA3C60 Offset: 0x1AA3060 VA: 0x181AA3C60
	|-XmlListConverter.ToArray<DateTime>
	|
	|-RVA: 0x1AA3820 Offset: 0x1AA2C20 VA: 0x181AA3820
	|-XmlListConverter.ToArray<DateTimeOffset>
	|
	|-RVA: 0x1AA40A0 Offset: 0x1AA34A0 VA: 0x181AA40A0
	|-XmlListConverter.ToArray<Decimal>
	|
	|-RVA: 0x1AA44E0 Offset: 0x1AA38E0 VA: 0x181AA44E0
	|-XmlListConverter.ToArray<double>
	|
	|-RVA: 0x1AA4920 Offset: 0x1AA3D20 VA: 0x181AA4920
	|-XmlListConverter.ToArray<short>
	|
	|-RVA: 0x1AA4D60 Offset: 0x1AA4160 VA: 0x181AA4D60
	|-XmlListConverter.ToArray<int>
	|
	|-RVA: 0x1AA51A0 Offset: 0x1AA45A0 VA: 0x181AA51A0
	|-XmlListConverter.ToArray<long>
	|
	|-RVA: 0x1AA5A00 Offset: 0x1AA4E00 VA: 0x181AA5A00
	|-XmlListConverter.ToArray<sbyte>
	|
	|-RVA: 0x1AA5E40 Offset: 0x1AA5240 VA: 0x181AA5E40
	|-XmlListConverter.ToArray<float>
	|
	|-RVA: 0x1AA6280 Offset: 0x1AA5680 VA: 0x181AA6280
	|-XmlListConverter.ToArray<TimeSpan>
	|
	|-RVA: 0x1AA66C0 Offset: 0x1AA5AC0 VA: 0x181AA66C0
	|-XmlListConverter.ToArray<ushort>
	|
	|-RVA: 0x1AA6B00 Offset: 0x1AA5F00 VA: 0x181AA6B00
	|-XmlListConverter.ToArray<uint>
	|
	|-RVA: 0x1AA6F40 Offset: 0x1AA6340 VA: 0x181AA6F40
	|-XmlListConverter.ToArray<ulong>
	*/

	// RVA: 0x1439F80 Offset: 0x1439380 VA: 0x181439F80
	private IList ToList(object list, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1439EF0 Offset: 0x14392F0 VA: 0x181439EF0
	private List<string> StringAsList(string value) { }

	// RVA: 0x1439C90 Offset: 0x1439090 VA: 0x181439C90
	private string ListAsString(IEnumerable list, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1439590 Offset: 0x1438990 VA: 0x181439590
	private Exception CreateInvalidClrMappingException(Type sourceType, Type destinationType) { }

}

internal class XmlUnionConverter : XmlBaseConverter // TypeDefIndex: 2411
{	// Fields
	private XmlValueConverter[] converters; // 0x28
	private bool hasAtomicMember; // 0x30
	private bool hasListMember; // 0x31

	// Methods

	// RVA: 0xD311C0 Offset: 0xD305C0 VA: 0x180D311C0
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0xD31160 Offset: 0xD30560 VA: 0x180D31160
	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	// RVA: 0xD30C80 Offset: 0xD30080 VA: 0x180D30C80 Slot: 61
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

}

internal sealed class XsdBuilder : SchemaBuilder // TypeDefIndex: 2412
{	// Fields
	private static readonly XsdBuilder.State[] SchemaElement; // 0x0
	private static readonly XsdBuilder.State[] SchemaSubelements; // 0x8
	private static readonly XsdBuilder.State[] AttributeSubelements; // 0x10
	private static readonly XsdBuilder.State[] ElementSubelements; // 0x18
	private static readonly XsdBuilder.State[] ComplexTypeSubelements; // 0x20
	private static readonly XsdBuilder.State[] SimpleContentSubelements; // 0x28
	private static readonly XsdBuilder.State[] SimpleContentExtensionSubelements; // 0x30
	private static readonly XsdBuilder.State[] SimpleContentRestrictionSubelements; // 0x38
	private static readonly XsdBuilder.State[] ComplexContentSubelements; // 0x40
	private static readonly XsdBuilder.State[] ComplexContentExtensionSubelements; // 0x48
	private static readonly XsdBuilder.State[] ComplexContentRestrictionSubelements; // 0x50
	private static readonly XsdBuilder.State[] SimpleTypeSubelements; // 0x58
	private static readonly XsdBuilder.State[] SimpleTypeRestrictionSubelements; // 0x60
	private static readonly XsdBuilder.State[] SimpleTypeListSubelements; // 0x68
	private static readonly XsdBuilder.State[] SimpleTypeUnionSubelements; // 0x70
	private static readonly XsdBuilder.State[] RedefineSubelements; // 0x78
	private static readonly XsdBuilder.State[] AttributeGroupSubelements; // 0x80
	private static readonly XsdBuilder.State[] GroupSubelements; // 0x88
	private static readonly XsdBuilder.State[] AllSubelements; // 0x90
	private static readonly XsdBuilder.State[] ChoiceSequenceSubelements; // 0x98
	private static readonly XsdBuilder.State[] IdentityConstraintSubelements; // 0xA0
	private static readonly XsdBuilder.State[] AnnotationSubelements; // 0xA8
	private static readonly XsdBuilder.State[] AnnotatedSubelements; // 0xB0
	private static readonly XsdBuilder.XsdAttributeEntry[] SchemaAttributes; // 0xB8
	private static readonly XsdBuilder.XsdAttributeEntry[] AttributeAttributes; // 0xC0
	private static readonly XsdBuilder.XsdAttributeEntry[] ElementAttributes; // 0xC8
	private static readonly XsdBuilder.XsdAttributeEntry[] ComplexTypeAttributes; // 0xD0
	private static readonly XsdBuilder.XsdAttributeEntry[] SimpleContentAttributes; // 0xD8
	private static readonly XsdBuilder.XsdAttributeEntry[] SimpleContentExtensionAttributes; // 0xE0
	private static readonly XsdBuilder.XsdAttributeEntry[] SimpleContentRestrictionAttributes; // 0xE8
	private static readonly XsdBuilder.XsdAttributeEntry[] ComplexContentAttributes; // 0xF0
	private static readonly XsdBuilder.XsdAttributeEntry[] ComplexContentExtensionAttributes; // 0xF8
	private static readonly XsdBuilder.XsdAttributeEntry[] ComplexContentRestrictionAttributes; // 0x100
	private static readonly XsdBuilder.XsdAttributeEntry[] SimpleTypeAttributes; // 0x108
	private static readonly XsdBuilder.XsdAttributeEntry[] SimpleTypeRestrictionAttributes; // 0x110
	private static readonly XsdBuilder.XsdAttributeEntry[] SimpleTypeUnionAttributes; // 0x118
	private static readonly XsdBuilder.XsdAttributeEntry[] SimpleTypeListAttributes; // 0x120
	private static readonly XsdBuilder.XsdAttributeEntry[] AttributeGroupAttributes; // 0x128
	private static readonly XsdBuilder.XsdAttributeEntry[] AttributeGroupRefAttributes; // 0x130
	private static readonly XsdBuilder.XsdAttributeEntry[] GroupAttributes; // 0x138
	private static readonly XsdBuilder.XsdAttributeEntry[] GroupRefAttributes; // 0x140
	private static readonly XsdBuilder.XsdAttributeEntry[] ParticleAttributes; // 0x148
	private static readonly XsdBuilder.XsdAttributeEntry[] AnyAttributes; // 0x150
	private static readonly XsdBuilder.XsdAttributeEntry[] IdentityConstraintAttributes; // 0x158
	private static readonly XsdBuilder.XsdAttributeEntry[] SelectorAttributes; // 0x160
	private static readonly XsdBuilder.XsdAttributeEntry[] FieldAttributes; // 0x168
	private static readonly XsdBuilder.XsdAttributeEntry[] NotationAttributes; // 0x170
	private static readonly XsdBuilder.XsdAttributeEntry[] IncludeAttributes; // 0x178
	private static readonly XsdBuilder.XsdAttributeEntry[] ImportAttributes; // 0x180
	private static readonly XsdBuilder.XsdAttributeEntry[] FacetAttributes; // 0x188
	private static readonly XsdBuilder.XsdAttributeEntry[] AnyAttributeAttributes; // 0x190
	private static readonly XsdBuilder.XsdAttributeEntry[] DocumentationAttributes; // 0x198
	private static readonly XsdBuilder.XsdAttributeEntry[] AppinfoAttributes; // 0x1A0
	private static readonly XsdBuilder.XsdAttributeEntry[] RedefineAttributes; // 0x1A8
	private static readonly XsdBuilder.XsdAttributeEntry[] AnnotationAttributes; // 0x1B0
	private static readonly XsdBuilder.XsdEntry[] SchemaEntries; // 0x1B8
	private static readonly int[] DerivationMethodValues; // 0x1C0
	private static readonly string[] DerivationMethodStrings; // 0x1C8
	private static readonly string[] FormStringValues; // 0x1D0
	private static readonly string[] UseStringValues; // 0x1D8
	private static readonly string[] ProcessContentsStringValues; // 0x1E0
	private XmlReader reader; // 0x10
	private PositionInfo positionInfo; // 0x18
	private XsdBuilder.XsdEntry currentEntry; // 0x20
	private XsdBuilder.XsdEntry nextEntry; // 0x28
	private bool hasChild; // 0x30
	private HWStack stateHistory; // 0x38
	private Stack containerStack; // 0x40
	private XmlNameTable nameTable; // 0x48
	private SchemaNames schemaNames; // 0x50
	private XmlNamespaceManager namespaceManager; // 0x58
	private bool canIncludeImport; // 0x60
	private XmlSchema schema; // 0x68
	private XmlSchemaObject xso; // 0x70
	private XmlSchemaElement element; // 0x78
	private XmlSchemaAny anyElement; // 0x80
	private XmlSchemaAttribute attribute; // 0x88
	private XmlSchemaAnyAttribute anyAttribute; // 0x90
	private XmlSchemaComplexType complexType; // 0x98
	private XmlSchemaSimpleType simpleType; // 0xA0
	private XmlSchemaComplexContent complexContent; // 0xA8
	private XmlSchemaComplexContentExtension complexContentExtension; // 0xB0
	private XmlSchemaComplexContentRestriction complexContentRestriction; // 0xB8
	private XmlSchemaSimpleContent simpleContent; // 0xC0
	private XmlSchemaSimpleContentExtension simpleContentExtension; // 0xC8
	private XmlSchemaSimpleContentRestriction simpleContentRestriction; // 0xD0
	private XmlSchemaSimpleTypeUnion simpleTypeUnion; // 0xD8
	private XmlSchemaSimpleTypeList simpleTypeList; // 0xE0
	private XmlSchemaSimpleTypeRestriction simpleTypeRestriction; // 0xE8
	private XmlSchemaGroup group; // 0xF0
	private XmlSchemaGroupRef groupRef; // 0xF8
	private XmlSchemaAll all; // 0x100
	private XmlSchemaChoice choice; // 0x108
	private XmlSchemaSequence sequence; // 0x110
	private XmlSchemaParticle particle; // 0x118
	private XmlSchemaAttributeGroup attributeGroup; // 0x120
	private XmlSchemaAttributeGroupRef attributeGroupRef; // 0x128
	private XmlSchemaNotation notation; // 0x130
	private XmlSchemaIdentityConstraint identityConstraint; // 0x138
	private XmlSchemaXPath xpath; // 0x140
	private XmlSchemaInclude include; // 0x148
	private XmlSchemaImport import; // 0x150
	private XmlSchemaAnnotation annotation; // 0x158
	private XmlSchemaAppInfo appInfo; // 0x160
	private XmlSchemaDocumentation documentation; // 0x168
	private XmlSchemaFacet facet; // 0x170
	private XmlNode[] markup; // 0x178
	private XmlSchemaRedefine redefine; // 0x180
	private ValidationEventHandler validationEventHandler; // 0x188
	private ArrayList unhandledAttributes; // 0x190
	private Hashtable namespaces; // 0x198

	// Properties
	private SchemaNames.Token CurrentElement { get; }
	private SchemaNames.Token ParentElement { get; }
	private XmlSchemaObject ParentContainer { get; }

	// Methods

	// RVA: 0xD47CA0 Offset: 0xD470A0 VA: 0x180D47CA0
	internal void .ctor(XmlReader reader, XmlNamespaceManager curmgr, XmlSchema schema, XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventhandler) { }

	// RVA: 0xD3E520 Offset: 0xD3D920 VA: 0x180D3E520 Slot: 4
	internal override bool ProcessElement(string prefix, string name, string ns) { }

	// RVA: 0xD3DFE0 Offset: 0xD3D3E0 VA: 0x180D3DFE0 Slot: 5
	internal override void ProcessAttribute(string prefix, string name, string ns, string value) { }

	// RVA: 0xD3D960 Offset: 0xD3CD60 VA: 0x180D3D960 Slot: 6
	internal override bool IsContentParsed() { }

	// RVA: 0xD3E6F0 Offset: 0xD3DAF0 VA: 0x180D3E6F0 Slot: 7
	internal override void ProcessMarkup(XmlNode[] markup) { }

	// RVA: 0xD3E4D0 Offset: 0xD3D8D0 VA: 0x180D3E4D0 Slot: 8
	internal override void ProcessCData(string value) { }

	// RVA: 0xD40000 Offset: 0xD3F400 VA: 0x180D40000 Slot: 9
	internal override void StartChildren() { }

	// RVA: 0xD3AAC0 Offset: 0xD39EC0 VA: 0x180D3AAC0 Slot: 10
	internal override void EndChildren() { }

	// RVA: 0xD3E700 Offset: 0xD3DB00 VA: 0x180D3E700
	private void Push() { }

	// RVA: 0xD3DF20 Offset: 0xD3D320 VA: 0x180D3DF20
	private void Pop() { }

	// RVA: 0xD47ED0 Offset: 0xD472D0 VA: 0x180D47ED0
	private SchemaNames.Token get_CurrentElement() { }

	// RVA: 0xD47F90 Offset: 0xD47390 VA: 0x180D47F90
	private SchemaNames.Token get_ParentElement() { }

	// RVA: 0xD47EF0 Offset: 0xD472F0 VA: 0x180D47EF0
	private XmlSchemaObject get_ParentContainer() { }

	// RVA: 0xD3AC00 Offset: 0xD3A000 VA: 0x180D3AC00
	private XmlSchemaObject GetContainer(XsdBuilder.State state) { }

	// RVA: 0xD3F090 Offset: 0xD3E490 VA: 0x180D3F090
	private void SetContainer(XsdBuilder.State state, object container) { }

	// RVA: 0xD38D00 Offset: 0xD38100 VA: 0x180D38D00
	private static void BuildAnnotated_Id(XsdBuilder builder, string value) { }

	// RVA: 0xD3A260 Offset: 0xD39660 VA: 0x180D3A260
	private static void BuildSchema_AttributeFormDefault(XsdBuilder builder, string value) { }

	// RVA: 0xD3A380 Offset: 0xD39780 VA: 0x180D3A380
	private static void BuildSchema_ElementFormDefault(XsdBuilder builder, string value) { }

	// RVA: 0xD3A4A0 Offset: 0xD398A0 VA: 0x180D3A4A0
	private static void BuildSchema_TargetNamespace(XsdBuilder builder, string value) { }

	// RVA: 0xD3A4D0 Offset: 0xD398D0 VA: 0x180D3A4D0
	private static void BuildSchema_Version(XsdBuilder builder, string value) { }

	// RVA: 0xD3A430 Offset: 0xD39830 VA: 0x180D3A430
	private static void BuildSchema_FinalDefault(XsdBuilder builder, string value) { }

	// RVA: 0xD3A310 Offset: 0xD39710 VA: 0x180D3A310
	private static void BuildSchema_BlockDefault(XsdBuilder builder, string value) { }

	// RVA: 0xD3CB80 Offset: 0xD3BF80 VA: 0x180D3CB80
	private static void InitSchema(XsdBuilder builder, string value) { }

	// RVA: 0xD3C930 Offset: 0xD3BD30 VA: 0x180D3C930
	private static void InitInclude(XsdBuilder builder, string value) { }

	// RVA: 0xD3A110 Offset: 0xD39510 VA: 0x180D3A110
	private static void BuildInclude_SchemaLocation(XsdBuilder builder, string value) { }

	// RVA: 0xD3C860 Offset: 0xD3BC60 VA: 0x180D3C860
	private static void InitImport(XsdBuilder builder, string value) { }

	// RVA: 0xD3A0B0 Offset: 0xD394B0 VA: 0x180D3A0B0
	private static void BuildImport_Namespace(XsdBuilder builder, string value) { }

	// RVA: 0xD3A0E0 Offset: 0xD394E0 VA: 0x180D3A0E0
	private static void BuildImport_SchemaLocation(XsdBuilder builder, string value) { }

	// RVA: 0xD3CAB0 Offset: 0xD3BEB0 VA: 0x180D3CAB0
	private static void InitRedefine(XsdBuilder builder, string value) { }

	// RVA: 0xD3A230 Offset: 0xD39630 VA: 0x180D3A230
	private static void BuildRedefine_SchemaLocation(XsdBuilder builder, string value) { }

	// RVA: 0xD3ABE0 Offset: 0xD39FE0 VA: 0x180D3ABE0
	private static void EndRedefine(XsdBuilder builder) { }

	// RVA: 0xD3B870 Offset: 0xD3AC70 VA: 0x180D3B870
	private static void InitAttribute(XsdBuilder builder, string value) { }

	// RVA: 0xD39020 Offset: 0xD38420 VA: 0x180D39020
	private static void BuildAttribute_Default(XsdBuilder builder, string value) { }

	// RVA: 0xD39050 Offset: 0xD38450 VA: 0x180D39050
	private static void BuildAttribute_Fixed(XsdBuilder builder, string value) { }

	// RVA: 0xD39080 Offset: 0xD38480 VA: 0x180D39080
	private static void BuildAttribute_Form(XsdBuilder builder, string value) { }

	// RVA: 0xD39260 Offset: 0xD38660 VA: 0x180D39260
	private static void BuildAttribute_Use(XsdBuilder builder, string value) { }

	// RVA: 0xD39160 Offset: 0xD38560 VA: 0x180D39160
	private static void BuildAttribute_Ref(XsdBuilder builder, string value) { }

	// RVA: 0xD39130 Offset: 0xD38530 VA: 0x180D39130
	private static void BuildAttribute_Name(XsdBuilder builder, string value) { }

	// RVA: 0xD391E0 Offset: 0xD385E0 VA: 0x180D391E0
	private static void BuildAttribute_Type(XsdBuilder builder, string value) { }

	// RVA: 0xD3BFC0 Offset: 0xD3B3C0 VA: 0x180D3BFC0
	private static void InitElement(XsdBuilder builder, string value) { }

	// RVA: 0xD39870 Offset: 0xD38C70 VA: 0x180D39870
	private static void BuildElement_Abstract(XsdBuilder builder, string value) { }

	// RVA: 0xD398F0 Offset: 0xD38CF0 VA: 0x180D398F0
	private static void BuildElement_Block(XsdBuilder builder, string value) { }

	// RVA: 0xD39960 Offset: 0xD38D60 VA: 0x180D39960
	private static void BuildElement_Default(XsdBuilder builder, string value) { }

	// RVA: 0xD39A30 Offset: 0xD38E30 VA: 0x180D39A30
	private static void BuildElement_Form(XsdBuilder builder, string value) { }

	// RVA: 0xD39C70 Offset: 0xD39070 VA: 0x180D39C70
	private static void BuildElement_SubstitutionGroup(XsdBuilder builder, string value) { }

	// RVA: 0xD39990 Offset: 0xD38D90 VA: 0x180D39990
	private static void BuildElement_Final(XsdBuilder builder, string value) { }

	// RVA: 0xD39A00 Offset: 0xD38E00 VA: 0x180D39A00
	private static void BuildElement_Fixed(XsdBuilder builder, string value) { }

	// RVA: 0xD39AE0 Offset: 0xD38EE0 VA: 0x180D39AE0
	private static void BuildElement_MaxOccurs(XsdBuilder builder, string value) { }

	// RVA: 0xD39B10 Offset: 0xD38F10 VA: 0x180D39B10
	private static void BuildElement_MinOccurs(XsdBuilder builder, string value) { }

	// RVA: 0xD39B40 Offset: 0xD38F40 VA: 0x180D39B40
	private static void BuildElement_Name(XsdBuilder builder, string value) { }

	// RVA: 0xD39B70 Offset: 0xD38F70 VA: 0x180D39B70
	private static void BuildElement_Nillable(XsdBuilder builder, string value) { }

	// RVA: 0xD39BF0 Offset: 0xD38FF0 VA: 0x180D39BF0
	private static void BuildElement_Ref(XsdBuilder builder, string value) { }

	// RVA: 0xD39CF0 Offset: 0xD390F0 VA: 0x180D39CF0
	private static void BuildElement_Type(XsdBuilder builder, string value) { }

	// RVA: 0xD3D530 Offset: 0xD3C930 VA: 0x180D3D530
	private static void InitSimpleType(XsdBuilder builder, string value) { }

	// RVA: 0xD3AA50 Offset: 0xD39E50 VA: 0x180D3AA50
	private static void BuildSimpleType_Name(XsdBuilder builder, string value) { }

	// RVA: 0xD3A9E0 Offset: 0xD39DE0 VA: 0x180D3A9E0
	private static void BuildSimpleType_Final(XsdBuilder builder, string value) { }

	// RVA: 0xD3D410 Offset: 0xD3C810 VA: 0x180D3D410
	private static void InitSimpleTypeUnion(XsdBuilder builder, string value) { }

	// RVA: 0xD3A820 Offset: 0xD39C20 VA: 0x180D3A820
	private static void BuildSimpleTypeUnion_MemberTypes(XsdBuilder builder, string value) { }

	// RVA: 0xD3D170 Offset: 0xD3C570 VA: 0x180D3D170
	private static void InitSimpleTypeList(XsdBuilder builder, string value) { }

	// RVA: 0xD3A720 Offset: 0xD39B20 VA: 0x180D3A720
	private static void BuildSimpleTypeList_ItemType(XsdBuilder builder, string value) { }

	// RVA: 0xD3D2B0 Offset: 0xD3C6B0 VA: 0x180D3D2B0
	private static void InitSimpleTypeRestriction(XsdBuilder builder, string value) { }

	// RVA: 0xD3A7A0 Offset: 0xD39BA0 VA: 0x180D3A7A0
	private static void BuildSimpleTypeRestriction_Base(XsdBuilder builder, string value) { }

	// RVA: 0xD3BD10 Offset: 0xD3B110 VA: 0x180D3BD10
	private static void InitComplexType(XsdBuilder builder, string value) { }

	// RVA: 0xD39490 Offset: 0xD38890 VA: 0x180D39490
	private static void BuildComplexType_Abstract(XsdBuilder builder, string value) { }

	// RVA: 0xD39510 Offset: 0xD38910 VA: 0x180D39510
	private static void BuildComplexType_Block(XsdBuilder builder, string value) { }

	// RVA: 0xD39590 Offset: 0xD38990 VA: 0x180D39590
	private static void BuildComplexType_Final(XsdBuilder builder, string value) { }

	// RVA: 0xD39600 Offset: 0xD38A00 VA: 0x180D39600
	private static void BuildComplexType_Mixed(XsdBuilder builder, string value) { }

	// RVA: 0xD39690 Offset: 0xD38A90 VA: 0x180D39690
	private static void BuildComplexType_Name(XsdBuilder builder, string value) { }

	// RVA: 0xD3BBE0 Offset: 0xD3AFE0 VA: 0x180D3BBE0
	private static void InitComplexContent(XsdBuilder builder, string value) { }

	// RVA: 0xD39410 Offset: 0xD38810 VA: 0x180D39410
	private static void BuildComplexContent_Mixed(XsdBuilder builder, string value) { }

	// RVA: 0xD3BA40 Offset: 0xD3AE40 VA: 0x180D3BA40
	private static void InitComplexContentExtension(XsdBuilder builder, string value) { }

	// RVA: 0xD39310 Offset: 0xD38710 VA: 0x180D39310
	private static void BuildComplexContentExtension_Base(XsdBuilder builder, string value) { }

	// RVA: 0xD3BB30 Offset: 0xD3AF30 VA: 0x180D3BB30
	private static void InitComplexContentRestriction(XsdBuilder builder, string value) { }

	// RVA: 0xD39390 Offset: 0xD38790 VA: 0x180D39390
	private static void BuildComplexContentRestriction_Base(XsdBuilder builder, string value) { }

	// RVA: 0xD3D040 Offset: 0xD3C440 VA: 0x180D3D040
	private static void InitSimpleContent(XsdBuilder builder, string value) { }

	// RVA: 0xD3CD30 Offset: 0xD3C130 VA: 0x180D3CD30
	private static void InitSimpleContentExtension(XsdBuilder builder, string value) { }

	// RVA: 0xD3A500 Offset: 0xD39900 VA: 0x180D3A500
	private static void BuildSimpleContentExtension_Base(XsdBuilder builder, string value) { }

	// RVA: 0xD3CEA0 Offset: 0xD3C2A0 VA: 0x180D3CEA0
	private static void InitSimpleContentRestriction(XsdBuilder builder, string value) { }

	// RVA: 0xD3A610 Offset: 0xD39A10 VA: 0x180D3A610
	private static void BuildSimpleContentRestriction_Base(XsdBuilder builder, string value) { }

	// RVA: 0xD3B740 Offset: 0xD3AB40 VA: 0x180D3B740
	private static void InitAttributeGroup(XsdBuilder builder, string value) { }

	// RVA: 0xD38FF0 Offset: 0xD383F0 VA: 0x180D38FF0
	private static void BuildAttributeGroup_Name(XsdBuilder builder, string value) { }

	// RVA: 0xD3B6A0 Offset: 0xD3AAA0 VA: 0x180D3B6A0
	private static void InitAttributeGroupRef(XsdBuilder builder, string value) { }

	// RVA: 0xD38F70 Offset: 0xD38370 VA: 0x180D38F70
	private static void BuildAttributeGroupRef_Ref(XsdBuilder builder, string value) { }

	// RVA: 0xD3B210 Offset: 0xD3A610 VA: 0x180D3B210
	private static void InitAnyAttribute(XsdBuilder builder, string value) { }

	// RVA: 0xD38D30 Offset: 0xD38130 VA: 0x180D38D30
	private static void BuildAnyAttribute_Namespace(XsdBuilder builder, string value) { }

	// RVA: 0xD38D60 Offset: 0xD38160 VA: 0x180D38D60
	private static void BuildAnyAttribute_ProcessContents(XsdBuilder builder, string value) { }

	// RVA: 0xD3C5F0 Offset: 0xD3B9F0 VA: 0x180D3C5F0
	private static void InitGroup(XsdBuilder builder, string value) { }

	// RVA: 0xD39EE0 Offset: 0xD392E0 VA: 0x180D39EE0
	private static void BuildGroup_Name(XsdBuilder builder, string value) { }

	// RVA: 0xD3C540 Offset: 0xD3B940 VA: 0x180D3C540
	private static void InitGroupRef(XsdBuilder builder, string value) { }

	// RVA: 0xD3A1D0 Offset: 0xD395D0 VA: 0x180D3A1D0
	private static void BuildParticle_MaxOccurs(XsdBuilder builder, string value) { }

	// RVA: 0xD3A200 Offset: 0xD39600 VA: 0x180D3A200
	private static void BuildParticle_MinOccurs(XsdBuilder builder, string value) { }

	// RVA: 0xD39E60 Offset: 0xD39260 VA: 0x180D39E60
	private static void BuildGroupRef_Ref(XsdBuilder builder, string value) { }

	// RVA: 0xD3B070 Offset: 0xD3A470 VA: 0x180D3B070
	private static void InitAll(XsdBuilder builder, string value) { }

	// RVA: 0xD3B990 Offset: 0xD3AD90 VA: 0x180D3B990
	private static void InitChoice(XsdBuilder builder, string value) { }

	// RVA: 0xD3CC80 Offset: 0xD3C080 VA: 0x180D3CC80
	private static void InitSequence(XsdBuilder builder, string value) { }

	// RVA: 0xD3B520 Offset: 0xD3A920 VA: 0x180D3B520
	private static void InitAny(XsdBuilder builder, string value) { }

	// RVA: 0xD38E10 Offset: 0xD38210 VA: 0x180D38E10
	private static void BuildAny_Namespace(XsdBuilder builder, string value) { }

	// RVA: 0xD38E40 Offset: 0xD38240 VA: 0x180D38E40
	private static void BuildAny_ProcessContents(XsdBuilder builder, string value) { }

	// RVA: 0xD3CA00 Offset: 0xD3BE00 VA: 0x180D3CA00
	private static void InitNotation(XsdBuilder builder, string value) { }

	// RVA: 0xD3A140 Offset: 0xD39540 VA: 0x180D3A140
	private static void BuildNotation_Name(XsdBuilder builder, string value) { }

	// RVA: 0xD3A170 Offset: 0xD39570 VA: 0x180D3A170
	private static void BuildNotation_Public(XsdBuilder builder, string value) { }

	// RVA: 0xD3A1A0 Offset: 0xD395A0 VA: 0x180D3A1A0
	private static void BuildNotation_System(XsdBuilder builder, string value) { }

	// RVA: 0xD3C120 Offset: 0xD3B520 VA: 0x180D3C120
	private static void InitFacet(XsdBuilder builder, string value) { }

	// RVA: 0xD39D70 Offset: 0xD39170 VA: 0x180D39D70
	private static void BuildFacet_Fixed(XsdBuilder builder, string value) { }

	// RVA: 0xD39E00 Offset: 0xD39200 VA: 0x180D39E00
	private static void BuildFacet_Value(XsdBuilder builder, string value) { }

	// RVA: 0xD3C720 Offset: 0xD3BB20 VA: 0x180D3C720
	private static void InitIdentityConstraint(XsdBuilder builder, string value) { }

	// RVA: 0xD39F10 Offset: 0xD39310 VA: 0x180D39F10
	private static void BuildIdentityConstraint_Name(XsdBuilder builder, string value) { }

	// RVA: 0xD39F40 Offset: 0xD39340 VA: 0x180D39F40
	private static void BuildIdentityConstraint_Refer(XsdBuilder builder, string value) { }

	// RVA: 0xD3CBB0 Offset: 0xD3BFB0 VA: 0x180D3CBB0
	private static void InitSelector(XsdBuilder builder, string value) { }

	// RVA: 0xD39E30 Offset: 0xD39230 VA: 0x180D39E30
	private static void BuildSelector_XPath(XsdBuilder builder, string value) { }

	// RVA: 0xD3C460 Offset: 0xD3B860 VA: 0x180D3C460
	private static void InitField(XsdBuilder builder, string value) { }

	// RVA: 0xD39E30 Offset: 0xD39230 VA: 0x180D39E30
	private static void BuildField_XPath(XsdBuilder builder, string value) { }

	// RVA: 0xD3B120 Offset: 0xD3A520 VA: 0x180D3B120
	private static void InitAnnotation(XsdBuilder builder, string value) { }

	// RVA: 0xD3B5D0 Offset: 0xD3A9D0 VA: 0x180D3B5D0
	private static void InitAppinfo(XsdBuilder builder, string value) { }

	// RVA: 0xD38EF0 Offset: 0xD382F0 VA: 0x180D38EF0
	private static void BuildAppinfo_Source(XsdBuilder builder, string value) { }

	// RVA: 0xD3AA80 Offset: 0xD39E80 VA: 0x180D3AA80
	private static void EndAppinfo(XsdBuilder builder) { }

	// RVA: 0xD3BEF0 Offset: 0xD3B2F0 VA: 0x180D3BEF0
	private static void InitDocumentation(XsdBuilder builder, string value) { }

	// RVA: 0xD396C0 Offset: 0xD38AC0 VA: 0x180D396C0
	private static void BuildDocumentation_Source(XsdBuilder builder, string value) { }

	// RVA: 0xD39740 Offset: 0xD38B40 VA: 0x180D39740
	private static void BuildDocumentation_XmlLang(XsdBuilder builder, string value) { }

	// RVA: 0xD3ABA0 Offset: 0xD39FA0 VA: 0x180D3ABA0
	private static void EndDocumentation(XsdBuilder builder) { }

	// RVA: 0xD38690 Offset: 0xD37A90 VA: 0x180D38690
	private void AddAttribute(XmlSchemaObject value) { }

	// RVA: 0xD38940 Offset: 0xD37D40 VA: 0x180D38940
	private void AddParticle(XmlSchemaParticle particle) { }

	// RVA: 0xD3AE50 Offset: 0xD3A250 VA: 0x180D3AE50
	private bool GetNextState(XmlQualifiedName qname) { }

	// RVA: 0xD3D980 Offset: 0xD3CD80 VA: 0x180D3D980
	private bool IsSkipableElement(XmlQualifiedName qname) { }

	// RVA: 0xD3FF70 Offset: 0xD3F370 VA: 0x180D3FF70
	private void SetMinOccurs(XmlSchemaParticle particle, string value) { }

	// RVA: 0xD3FEE0 Offset: 0xD3F2E0 VA: 0x180D3FEE0
	private void SetMaxOccurs(XmlSchemaParticle particle, string value) { }

	// RVA: 0xD3DC90 Offset: 0xD3D090 VA: 0x180D3DC90
	private bool ParseBoolean(string value, string attributeName) { }

	// RVA: 0xD3DD30 Offset: 0xD3D130 VA: 0x180D3DD30
	private int ParseEnum(string value, string attributeName, string[] values) { }

	// RVA: 0xD3DE20 Offset: 0xD3D220 VA: 0x180D3DE20
	private XmlQualifiedName ParseQName(string value, string attributeName) { }

	// RVA: 0xD3D9B0 Offset: 0xD3CDB0 VA: 0x180D3D9B0
	private int ParseBlockFinalEnum(string value, string attributeName) { }

	// RVA: 0x4B0E80 Offset: 0x4B0280 VA: 0x1804B0E80
	private static string ParseUriReference(string s) { }

	// RVA: 0xD3ED60 Offset: 0xD3E160 VA: 0x180D3ED60
	private void SendValidationEvent(string code, string arg0, string arg1, string arg2) { }

	// RVA: 0xD3EF90 Offset: 0xD3E390 VA: 0x180D3EF90
	private void SendValidationEvent(string code, string msg) { }

	// RVA: 0xD3EB70 Offset: 0xD3DF70 VA: 0x180D3EB70
	private void SendValidationEvent(string code, string[] args, XmlSeverityType severity) { }

	// RVA: 0xD3EC90 Offset: 0xD3E090 VA: 0x180D3EC90
	private void SendValidationEvent(XmlSchemaException e, XmlSeverityType severity) { }

	// RVA: 0xD3EAB0 Offset: 0xD3DEB0 VA: 0x180D3EAB0
	private void SendValidationEvent(XmlSchemaException e) { }

	// RVA: 0xD3E9E0 Offset: 0xD3DDE0 VA: 0x180D3E9E0
	private void RecordPosition() { }

	// RVA: 0xD401B0 Offset: 0xD3F5B0 VA: 0x180D401B0
	private static void .cctor() { }

}

private enum XsdBuilder.State // TypeDefIndex: 2413
{	// Fields
	public int value__; // 0x0
	public const XsdBuilder.State Root = 0;
	public const XsdBuilder.State Schema = 1;
	public const XsdBuilder.State Annotation = 2;
	public const XsdBuilder.State Include = 3;
	public const XsdBuilder.State Import = 4;
	public const XsdBuilder.State Element = 5;
	public const XsdBuilder.State Attribute = 6;
	public const XsdBuilder.State AttributeGroup = 7;
	public const XsdBuilder.State AttributeGroupRef = 8;
	public const XsdBuilder.State AnyAttribute = 9;
	public const XsdBuilder.State Group = 10;
	public const XsdBuilder.State GroupRef = 11;
	public const XsdBuilder.State All = 12;
	public const XsdBuilder.State Choice = 13;
	public const XsdBuilder.State Sequence = 14;
	public const XsdBuilder.State Any = 15;
	public const XsdBuilder.State Notation = 16;
	public const XsdBuilder.State SimpleType = 17;
	public const XsdBuilder.State ComplexType = 18;
	public const XsdBuilder.State ComplexContent = 19;
	public const XsdBuilder.State ComplexContentRestriction = 20;
	public const XsdBuilder.State ComplexContentExtension = 21;
	public const XsdBuilder.State SimpleContent = 22;
	public const XsdBuilder.State SimpleContentExtension = 23;
	public const XsdBuilder.State SimpleContentRestriction = 24;
	public const XsdBuilder.State SimpleTypeUnion = 25;
	public const XsdBuilder.State SimpleTypeList = 26;
	public const XsdBuilder.State SimpleTypeRestriction = 27;
	public const XsdBuilder.State Unique = 28;
	public const XsdBuilder.State Key = 29;
	public const XsdBuilder.State KeyRef = 30;
	public const XsdBuilder.State Selector = 31;
	public const XsdBuilder.State Field = 32;
	public const XsdBuilder.State MinExclusive = 33;
	public const XsdBuilder.State MinInclusive = 34;
	public const XsdBuilder.State MaxExclusive = 35;
	public const XsdBuilder.State MaxInclusive = 36;
	public const XsdBuilder.State TotalDigits = 37;
	public const XsdBuilder.State FractionDigits = 38;
	public const XsdBuilder.State Length = 39;
	public const XsdBuilder.State MinLength = 40;
	public const XsdBuilder.State MaxLength = 41;
	public const XsdBuilder.State Enumeration = 42;
	public const XsdBuilder.State Pattern = 43;
	public const XsdBuilder.State WhiteSpace = 44;
	public const XsdBuilder.State AppInfo = 45;
	public const XsdBuilder.State Documentation = 46;
	public const XsdBuilder.State Redefine = 47;

}

private sealed class XsdBuilder.XsdBuildFunction : MulticastDelegate // TypeDefIndex: 2414
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x110BDC0 Offset: 0x110B1C0 VA: 0x18110BDC0 Slot: 12
	public virtual void Invoke(XsdBuilder builder, string value) { }

	// RVA: 0xADFD10 Offset: 0xADF110 VA: 0x180ADFD10 Slot: 13
	public virtual IAsyncResult BeginInvoke(XsdBuilder builder, string value, AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

private sealed class XsdBuilder.XsdInitFunction : MulticastDelegate // TypeDefIndex: 2415
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x110BDC0 Offset: 0x110B1C0 VA: 0x18110BDC0 Slot: 12
	public virtual void Invoke(XsdBuilder builder, string value) { }

	// RVA: 0xADFD10 Offset: 0xADF110 VA: 0x180ADFD10 Slot: 13
	public virtual IAsyncResult BeginInvoke(XsdBuilder builder, string value, AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

private sealed class XsdBuilder.XsdEndChildFunction : MulticastDelegate // TypeDefIndex: 2416
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x59D680 Offset: 0x59CA80 VA: 0x18059D680 Slot: 12
	public virtual void Invoke(XsdBuilder builder) { }

	// RVA: 0x497210 Offset: 0x496610 VA: 0x180497210 Slot: 13
	public virtual IAsyncResult BeginInvoke(XsdBuilder builder, AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

private sealed class XsdBuilder.XsdAttributeEntry // TypeDefIndex: 2417
{	// Fields
	public SchemaNames.Token Attribute; // 0x10
	public XsdBuilder.XsdBuildFunction BuildFunc; // 0x18

	// Methods

	// RVA: 0xC44770 Offset: 0xC43B70 VA: 0x180C44770
	public void .ctor(SchemaNames.Token a, XsdBuilder.XsdBuildFunction build) { }

}

private sealed class XsdBuilder.XsdEntry // TypeDefIndex: 2418
{	// Fields
	public SchemaNames.Token Name; // 0x10
	public XsdBuilder.State CurrentState; // 0x14
	public XsdBuilder.State[] NextStates; // 0x18
	public XsdBuilder.XsdAttributeEntry[] Attributes; // 0x20
	public XsdBuilder.XsdInitFunction InitFunc; // 0x28
	public XsdBuilder.XsdEndChildFunction EndChildFunc; // 0x30
	public bool ParseContent; // 0x38

	// Methods

	// RVA: 0x1110030 Offset: 0x110F430 VA: 0x181110030
	public void .ctor(SchemaNames.Token n, XsdBuilder.State state, XsdBuilder.State[] nextStates, XsdBuilder.XsdAttributeEntry[] attributes, XsdBuilder.XsdInitFunction init, XsdBuilder.XsdEndChildFunction end, bool parseContent) { }

}

private class XsdBuilder.BuilderNamespaceManager : XmlNamespaceManager // TypeDefIndex: 2419
{	// Fields
	private XmlNamespaceManager nsMgr; // 0x50
	private XmlReader reader; // 0x58

	// Methods

	// RVA: 0x10F8A30 Offset: 0x10F7E30 VA: 0x1810F8A30
	public void .ctor(XmlNamespaceManager nsMgr, XmlReader reader) { }

	// RVA: 0x10F89D0 Offset: 0x10F7DD0 VA: 0x1810F89D0 Slot: 16
	public override string LookupNamespace(string prefix) { }

}

internal enum XsdDateTimeFlags // TypeDefIndex: 2420
{	// Fields
	public int value__; // 0x0
	public const XsdDateTimeFlags DateTime = 1;
	public const XsdDateTimeFlags Time = 2;
	public const XsdDateTimeFlags Date = 4;
	public const XsdDateTimeFlags GYearMonth = 8;
	public const XsdDateTimeFlags GYear = 16;
	public const XsdDateTimeFlags GMonthDay = 32;
	public const XsdDateTimeFlags GDay = 64;
	public const XsdDateTimeFlags GMonth = 128;
	public const XsdDateTimeFlags XdrDateTimeNoTz = 256;
	public const XsdDateTimeFlags XdrDateTime = 512;
	public const XsdDateTimeFlags XdrTimeNoTz = 1024;
	public const XsdDateTimeFlags AllXsd = 255;

}

internal struct XsdDateTime // TypeDefIndex: 2421
{	// Fields
	private DateTime dt; // 0x0
	private uint extra; // 0x8
	private static readonly int Lzyyyy; // 0x0
	private static readonly int Lzyyyy_; // 0x4
	private static readonly int Lzyyyy_MM; // 0x8
	private static readonly int Lzyyyy_MM_; // 0xC
	private static readonly int Lzyyyy_MM_dd; // 0x10
	private static readonly int Lzyyyy_MM_ddT; // 0x14
	private static readonly int LzHH; // 0x18
	private static readonly int LzHH_; // 0x1C
	private static readonly int LzHH_mm; // 0x20
	private static readonly int LzHH_mm_; // 0x24
	private static readonly int LzHH_mm_ss; // 0x28
	private static readonly int Lz_; // 0x2C
	private static readonly int Lz_zz; // 0x30
	private static readonly int Lz_zz_; // 0x34
	private static readonly int Lz_zz_zz; // 0x38
	private static readonly int Lz__; // 0x3C
	private static readonly int Lz__mm; // 0x40
	private static readonly int Lz__mm_; // 0x44
	private static readonly int Lz__mm__; // 0x48
	private static readonly int Lz__mm_dd; // 0x4C
	private static readonly int Lz___; // 0x50
	private static readonly int Lz___dd; // 0x54
	private static readonly XmlTypeCode[] typeCodes; // 0x58

	// Properties
	private XsdDateTime.DateTimeTypeCode InternalTypeCode { get; }
	private XsdDateTime.XsdDateTimeKind InternalKind { get; }
	public int Year { get; }
	public int Month { get; }
	public int Day { get; }
	public int Hour { get; }
	public int Minute { get; }
	public int Second { get; }
	public int Fraction { get; }
	public int ZoneHour { get; }
	public int ZoneMinute { get; }

	// Methods

	// RVA: 0x1ADE40 Offset: 0x1AD240 VA: 0x1801ADE40
	public void .ctor(string text, XsdDateTimeFlags kinds) { }

	// RVA: 0x1ADDA0 Offset: 0x1AD1A0 VA: 0x1801ADDA0
	private void .ctor(XsdDateTime.Parser parser) { }

	// RVA: 0x1ADC20 Offset: 0x1AD020 VA: 0x1801ADC20
	private void InitiateXsdDateTime(XsdDateTime.Parser parser) { }

	// RVA: 0x110D310 Offset: 0x110C710 VA: 0x18110D310
	internal static bool TryParse(string text, XsdDateTimeFlags kinds, out XsdDateTime result) { }

	// RVA: 0x1ADFD0 Offset: 0x1AD3D0 VA: 0x1801ADFD0
	public void .ctor(DateTime dateTime, XsdDateTimeFlags kinds) { }

	// RVA: 0x1ADDF0 Offset: 0x1AD1F0 VA: 0x1801ADDF0
	public void .ctor(DateTimeOffset dateTimeOffset) { }

	// RVA: 0x1ADE20 Offset: 0x1AD220 VA: 0x1801ADE20
	public void .ctor(DateTimeOffset dateTimeOffset, XsdDateTimeFlags kinds) { }

	// RVA: 0x1AE130 Offset: 0x1AD530 VA: 0x1801AE130
	private XsdDateTime.DateTimeTypeCode get_InternalTypeCode() { }

	// RVA: 0x1AE120 Offset: 0x1AD520 VA: 0x1801AE120
	private XsdDateTime.XsdDateTimeKind get_InternalKind() { }

	// RVA: 0x1AE170 Offset: 0x1AD570 VA: 0x1801AE170
	public int get_Year() { }

	// RVA: 0x1AE150 Offset: 0x1AD550 VA: 0x1801AE150
	public int get_Month() { }

	// RVA: 0x1AE0F0 Offset: 0x1AD4F0 VA: 0x1801AE0F0
	public int get_Day() { }

	// RVA: 0x1AE110 Offset: 0x1AD510 VA: 0x1801AE110
	public int get_Hour() { }

	// RVA: 0x1AE140 Offset: 0x1AD540 VA: 0x1801AE140
	public int get_Minute() { }

	// RVA: 0x1AE160 Offset: 0x1AD560 VA: 0x1801AE160
	public int get_Second() { }

	// RVA: 0x1AE100 Offset: 0x1AD500 VA: 0x1801AE100
	public int get_Fraction() { }

	// RVA: 0x1AE180 Offset: 0x1AD580 VA: 0x1801AE180
	public int get_ZoneHour() { }

	// RVA: 0x14B660 Offset: 0x14AA60 VA: 0x18014B660
	public int get_ZoneMinute() { }

	// RVA: 0x110DE70 Offset: 0x110D270 VA: 0x18110DE70
	public static DateTime op_Implicit(XsdDateTime xdt) { }

	// RVA: 0x110DC20 Offset: 0x110D020 VA: 0x18110DC20
	public static DateTimeOffset op_Implicit(XsdDateTime xdt) { }

	// RVA: 0x1ADD90 Offset: 0x1AD190 VA: 0x1801ADD90 Slot: 3
	public override string ToString() { }

	// RVA: 0x1ADCE0 Offset: 0x1AD0E0 VA: 0x1801ADCE0
	private void PrintDate(StringBuilder sb) { }

	// RVA: 0x1ADCF0 Offset: 0x1AD0F0 VA: 0x1801ADCF0
	private void PrintTime(StringBuilder sb) { }

	// RVA: 0x1ADD00 Offset: 0x1AD100 VA: 0x1801ADD00
	private void PrintZone(StringBuilder sb) { }

	// RVA: 0x1ADC60 Offset: 0x1AD060 VA: 0x1801ADC60
	private void IntToCharArray(char[] text, int start, int value, int digits) { }

	// RVA: 0x1ADD10 Offset: 0x1AD110 VA: 0x1801ADD10
	private void ShortToCharArray(char[] text, int start, int value) { }

	// RVA: 0x110D3C0 Offset: 0x110C7C0 VA: 0x18110D3C0
	private static void .cctor() { }

}

private enum XsdDateTime.DateTimeTypeCode // TypeDefIndex: 2422
{	// Fields
	public int value__; // 0x0
	public const XsdDateTime.DateTimeTypeCode DateTime = 0;
	public const XsdDateTime.DateTimeTypeCode Time = 1;
	public const XsdDateTime.DateTimeTypeCode Date = 2;
	public const XsdDateTime.DateTimeTypeCode GYearMonth = 3;
	public const XsdDateTime.DateTimeTypeCode GYear = 4;
	public const XsdDateTime.DateTimeTypeCode GMonthDay = 5;
	public const XsdDateTime.DateTimeTypeCode GDay = 6;
	public const XsdDateTime.DateTimeTypeCode GMonth = 7;
	public const XsdDateTime.DateTimeTypeCode XdrDateTime = 8;

}

private enum XsdDateTime.XsdDateTimeKind // TypeDefIndex: 2423
{	// Fields
	public int value__; // 0x0
	public const XsdDateTime.XsdDateTimeKind Unspecified = 0;
	public const XsdDateTime.XsdDateTimeKind Zulu = 1;
	public const XsdDateTime.XsdDateTimeKind LocalWestOfZulu = 2;
	public const XsdDateTime.XsdDateTimeKind LocalEastOfZulu = 3;

}

private struct XsdDateTime.Parser // TypeDefIndex: 2424
{	// Fields
	public XsdDateTime.DateTimeTypeCode typeCode; // 0x0
	public int year; // 0x4
	public int month; // 0x8
	public int day; // 0xC
	public int hour; // 0x10
	public int minute; // 0x14
	public int second; // 0x18
	public int fraction; // 0x1C
	public XsdDateTime.XsdDateTimeKind kind; // 0x20
	public int zoneHour; // 0x24
	public int zoneMinute; // 0x28
	private string text; // 0x30
	private int length; // 0x38
	private static int[] Power10; // 0x0

	// Methods

	// RVA: 0x1ADB00 Offset: 0x1ACF00 VA: 0x1801ADB00
	public bool Parse(string text, XsdDateTimeFlags kinds) { }

	// RVA: 0x1ADA40 Offset: 0x1ACE40 VA: 0x1801ADA40
	private bool ParseDate(int start) { }

	// RVA: 0x1ADA90 Offset: 0x1ACE90 VA: 0x1801ADA90
	private bool ParseTimeAndZoneAndWhitespace(int start) { }

	// RVA: 0x1ADA50 Offset: 0x1ACE50 VA: 0x1801ADA50
	private bool ParseTimeAndWhitespace(int start) { }

	// RVA: 0x1ADAE0 Offset: 0x1ACEE0 VA: 0x1801ADAE0
	private bool ParseTime(ref int start) { }

	// RVA: 0x1ADAF0 Offset: 0x1ACEF0 VA: 0x1801ADAF0
	private bool ParseZoneAndWhitespace(int start) { }

	// RVA: 0x1AD9F0 Offset: 0x1ACDF0 VA: 0x1801AD9F0
	private bool Parse4Dig(int start, ref int num) { }

	// RVA: 0x1AD9E0 Offset: 0x1ACDE0 VA: 0x1801AD9E0
	private bool Parse2Dig(int start, ref int num) { }

	// RVA: 0x1ADA00 Offset: 0x1ACE00 VA: 0x1801ADA00
	private bool ParseChar(int start, char ch) { }

	// RVA: 0x10FDFD0 Offset: 0x10FD3D0 VA: 0x1810FDFD0
	private static bool Test(XsdDateTimeFlags left, XsdDateTimeFlags right) { }

	// RVA: 0x10FDFE0 Offset: 0x10FD3E0 VA: 0x1810FDFE0
	private static void .cctor() { }

}

internal struct XsdDuration // TypeDefIndex: 2425
{	// Fields
	private int years; // 0x0
	private int months; // 0x4
	private int days; // 0x8
	private int hours; // 0xC
	private int minutes; // 0x10
	private int seconds; // 0x14
	private uint nanoseconds; // 0x18

	// Properties
	public bool IsNegative { get; }
	public int Years { get; }
	public int Months { get; }
	public int Days { get; }
	public int Hours { get; }
	public int Minutes { get; }
	public int Seconds { get; }
	public int Nanoseconds { get; }

	// Methods

	// RVA: 0x1AE2A0 Offset: 0x1AD6A0 VA: 0x1801AE2A0
	public void .ctor(bool isNegative, int years, int months, int days, int hours, int minutes, int seconds, int nanoseconds) { }

	// RVA: 0x1AE290 Offset: 0x1AD690 VA: 0x1801AE290
	public void .ctor(TimeSpan timeSpan) { }

	// RVA: 0x1AE270 Offset: 0x1AD670 VA: 0x1801AE270
	public void .ctor(TimeSpan timeSpan, XsdDuration.DurationType durationType) { }

	// RVA: 0x1AE280 Offset: 0x1AD680 VA: 0x1801AE280
	public void .ctor(string s) { }

	// RVA: 0x1AE2B0 Offset: 0x1AD6B0 VA: 0x1801AE2B0
	public void .ctor(string s, XsdDuration.DurationType durationType) { }

	// RVA: 0x1AE2D0 Offset: 0x1AD6D0 VA: 0x1801AE2D0
	public bool get_IsNegative() { }

	// RVA: 0xF3850 Offset: 0xF2C50 VA: 0x1800F3850
	public int get_Years() { }

	// RVA: 0x14B670 Offset: 0x14AA70 VA: 0x18014B670
	public int get_Months() { }

	// RVA: 0x122CA0 Offset: 0x1220A0 VA: 0x180122CA0
	public int get_Days() { }

	// RVA: 0x1AE2C0 Offset: 0x1AD6C0 VA: 0x1801AE2C0
	public int get_Hours() { }

	// RVA: 0xF3DA0 Offset: 0xF31A0 VA: 0x1800F3DA0
	public int get_Minutes() { }

	// RVA: 0x1AE2F0 Offset: 0x1AD6F0 VA: 0x1801AE2F0
	public int get_Seconds() { }

	// RVA: 0x1AE2E0 Offset: 0x1AD6E0 VA: 0x1801AE2E0
	public int get_Nanoseconds() { }

	// RVA: 0x1AE1E0 Offset: 0x1AD5E0 VA: 0x1801AE1E0
	public TimeSpan ToTimeSpan() { }

	// RVA: 0x1AE1D0 Offset: 0x1AD5D0 VA: 0x1801AE1D0
	public TimeSpan ToTimeSpan(XsdDuration.DurationType durationType) { }

	// RVA: 0x1AE240 Offset: 0x1AD640 VA: 0x1801AE240
	internal Exception TryToTimeSpan(out TimeSpan result) { }

	// RVA: 0x1AE260 Offset: 0x1AD660 VA: 0x1801AE260
	internal Exception TryToTimeSpan(XsdDuration.DurationType durationType, out TimeSpan result) { }

	// RVA: 0x1AE1C0 Offset: 0x1AD5C0 VA: 0x1801AE1C0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1AE1B0 Offset: 0x1AD5B0 VA: 0x1801AE1B0
	internal string ToString(XsdDuration.DurationType durationType) { }

	// RVA: 0x110F590 Offset: 0x110E990 VA: 0x18110F590
	internal static Exception TryParse(string s, out XsdDuration result) { }

	// RVA: 0x110E950 Offset: 0x110DD50 VA: 0x18110E950
	internal static Exception TryParse(string s, XsdDuration.DurationType durationType, out XsdDuration result) { }

	// RVA: 0x110E7E0 Offset: 0x110DBE0 VA: 0x18110E7E0
	private static string TryParseDigits(string s, ref int offset, bool eatDigits, out int result, out int numDigits) { }

}

private enum XsdDuration.Parts // TypeDefIndex: 2426
{	// Fields
	public int value__; // 0x0
	public const XsdDuration.Parts HasNone = 0;
	public const XsdDuration.Parts HasYears = 1;
	public const XsdDuration.Parts HasMonths = 2;
	public const XsdDuration.Parts HasDays = 4;
	public const XsdDuration.Parts HasHours = 8;
	public const XsdDuration.Parts HasMinutes = 16;
	public const XsdDuration.Parts HasSeconds = 32;

}

public enum XsdDuration.DurationType // TypeDefIndex: 2427
{	// Fields
	public int value__; // 0x0
	public const XsdDuration.DurationType Duration = 0;
	public const XsdDuration.DurationType YearMonthDuration = 1;
	public const XsdDuration.DurationType DayTimeDuration = 2;

}

internal sealed class XsdValidator : BaseValidator // TypeDefIndex: 2428
{	// Fields
	private int startIDConstraint; // 0x80
	private HWStack validationStack; // 0x88
	private Hashtable attPresence; // 0x90
	private XmlNamespaceManager nsManager; // 0x98
	private bool bManageNamespaces; // 0xA0
	private Hashtable IDs; // 0xA8
	private IdRefNode idRefListHead; // 0xB0
	private Parser inlineSchemaParser; // 0xB8
	private XmlSchemaContentProcessing processContents; // 0xC0
	private static readonly XmlSchemaDatatype dtCDATA; // 0x0
	private static readonly XmlSchemaDatatype dtQName; // 0x8
	private static readonly XmlSchemaDatatype dtStringArray; // 0x10
	private string NsXmlNs; // 0xC8
	private string NsXs; // 0xD0
	private string NsXsi; // 0xD8
	private string XsiType; // 0xE0
	private string XsiNil; // 0xE8
	private string XsiSchemaLocation; // 0xF0
	private string XsiNoNamespaceSchemaLocation; // 0xF8
	private string XsdSchema; // 0x100

	// Properties
	private bool IsInlineSchemaStarted { get; }
	private bool HasSchema { get; }
	public override bool PreserveWhitespace { get; }
	private bool HasIdentityConstraints { get; }

	// Methods

	// RVA: 0x1115E70 Offset: 0x1115270 VA: 0x181115E70
	internal void .ctor(BaseValidator validator) { }

	// RVA: 0x1115EA0 Offset: 0x11152A0 VA: 0x181115EA0
	internal void .ctor(XmlValidatingReaderImpl reader, XmlSchemaCollection schemaCollection, IValidationEventHandling eventHandling) { }

	// RVA: 0x1112420 Offset: 0x1111820 VA: 0x181112420
	private void Init() { }

	// RVA: 0x1115CE0 Offset: 0x11150E0 VA: 0x181115CE0 Slot: 5
	public override void Validate() { }

	// RVA: 0x1110A60 Offset: 0x110FE60 VA: 0x181110A60 Slot: 6
	public override void CompleteValidation() { }

	// RVA: 0x1115F00 Offset: 0x1115300 VA: 0x181115F00
	private bool get_IsInlineSchemaStarted() { }

	// RVA: 0x11137C0 Offset: 0x1112BC0 VA: 0x1811137C0
	private void ProcessInlineSchema() { }

	// RVA: 0x1114D40 Offset: 0x1114140 VA: 0x181114D40
	private void ValidateElement() { }

	// RVA: 0x1114AF0 Offset: 0x1113EF0 VA: 0x181114AF0
	private object ValidateChildElement() { }

	// RVA: 0x1113030 Offset: 0x1112430 VA: 0x181113030
	private void ProcessElement(object particle) { }

	// RVA: 0x1113D00 Offset: 0x1113100 VA: 0x181113D00
	private void ProcessXsiAttributes(out XmlQualifiedName xsiType, out string xsiNil) { }

	// RVA: 0x1114F20 Offset: 0x1114320 VA: 0x181114F20
	private void ValidateEndElement() { }

	// RVA: 0x1112300 Offset: 0x1111700 VA: 0x181112300
	private SchemaElementDecl FastGetElementDecl(object particle) { }

	// RVA: 0x1114630 Offset: 0x1113A30 VA: 0x181114630
	private SchemaElementDecl ThoroughGetElementDecl(SchemaElementDecl elementDecl, XmlQualifiedName xsiType, string xsiNil) { }

	// RVA: 0x11156A0 Offset: 0x1114AA0 VA: 0x1811156A0
	private void ValidateStartElement() { }

	// RVA: 0x1115220 Offset: 0x1114620 VA: 0x181115220
	private void ValidateEndStartElement() { }

	// RVA: 0x11127E0 Offset: 0x1111BE0 VA: 0x1811127E0
	private void LoadSchemaFromLocation(string uri, string url) { }

	// RVA: 0x1112DB0 Offset: 0x11121B0 VA: 0x181112DB0
	private void LoadSchema(string uri, string url) { }

	// RVA: 0x1115EE0 Offset: 0x11152E0 VA: 0x181115EE0
	private bool get_HasSchema() { }

	// RVA: 0x1115F10 Offset: 0x1115310 VA: 0x181115F10 Slot: 4
	public override bool get_PreserveWhitespace() { }

	// RVA: 0x1113A80 Offset: 0x1112E80 VA: 0x181113A80
	private void ProcessTokenizedType(XmlTokenizedType ttype, string name) { }

	// RVA: 0x1110BA0 Offset: 0x110FFA0 VA: 0x181110BA0
	private void CheckValue(string value, SchemaAttDef attdef) { }

	// RVA: 0x11100C0 Offset: 0x110F4C0 VA: 0x1811100C0
	internal void AddID(string name, object node) { }

	// RVA: 0x1112400 Offset: 0x1111800 VA: 0x181112400 Slot: 7
	public override object FindId(string name) { }

	// RVA: 0x1112790 Offset: 0x1111B90 VA: 0x181112790
	public bool IsXSDRoot(string localName, string ns) { }

	// RVA: 0x11144B0 Offset: 0x11138B0 VA: 0x1811144B0
	private void Push(XmlQualifiedName elementName) { }

	// RVA: 0x1112F70 Offset: 0x1112370 VA: 0x181112F70
	private void Pop() { }

	// RVA: 0x1110A60 Offset: 0x110FE60 VA: 0x181110A60
	private void CheckForwardRefs() { }

	// RVA: 0x1115650 Offset: 0x1114A50 VA: 0x181115650
	private void ValidateStartElementIdentityConstraints() { }

	// RVA: 0x1115ED0 Offset: 0x11152D0 VA: 0x181115ED0
	private bool get_HasIdentityConstraints() { }

	// RVA: 0x1110170 Offset: 0x110F570 VA: 0x181110170
	private void AddIdentityConstraints() { }

	// RVA: 0x1110FC0 Offset: 0x11103C0 VA: 0x181110FC0
	private void ElementIdentityConstraints() { }

	// RVA: 0x1110710 Offset: 0x110FB10 VA: 0x181110710
	private void AttributeIdentityConstraints(string name, string ns, object obj, string sobj, SchemaAttDef attdef) { }

	// RVA: 0x1114A70 Offset: 0x1113E70 VA: 0x181114A70
	private object UnWrapUnion(object typedValue) { }

	// RVA: 0x11113D0 Offset: 0x11107D0 VA: 0x1811113D0
	private void EndElementIdentityConstraints() { }

	// RVA: 0x1115DB0 Offset: 0x11151B0 VA: 0x181115DB0
	private static void .cctor() { }

}

public sealed class XmlReaderSection // TypeDefIndex: 2429
{	// Properties
	internal static bool ProhibitDefaultUrlResolver { get; }
	internal static bool CollapseWhiteSpaceIntoEmptyString { get; }

	// Methods

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0
	internal static bool get_ProhibitDefaultUrlResolver() { }

	// RVA: 0xE616D0 Offset: 0xE60AD0 VA: 0x180E616D0
	internal static XmlResolver CreateDefaultResolver() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0
	internal static bool get_CollapseWhiteSpaceIntoEmptyString() { }

}

public enum XRNode // TypeDefIndex: 4139
{	// Fields
	public int value__; // 0x0
	public const XRNode LeftEye = 0;
	public const XRNode RightEye = 1;
	public const XRNode CenterEye = 2;
	public const XRNode Head = 3;
	public const XRNode LeftHand = 4;
	public const XRNode RightHand = 5;
	public const XRNode GameController = 6;
	public const XRNode TrackingReference = 7;
	public const XRNode HardwareTracker = 8;

}

public struct XRNodeState // TypeDefIndex: 4141
{	// Fields
	private XRNode m_Type; // 0x0
	private AvailableTrackingData m_AvailableFields; // 0x4
	private Vector3 m_Position; // 0x8
	private Quaternion m_Rotation; // 0x14
	private Vector3 m_Velocity; // 0x24
	private Vector3 m_AngularVelocity; // 0x30
	private Vector3 m_Acceleration; // 0x3C
	private Vector3 m_AngularAcceleration; // 0x48
	private int m_Tracked; // 0x54
	private ulong m_UniqueID; // 0x58

	// Properties
	public ulong uniqueID { set; }
	public XRNode nodeType { set; }
	public bool tracked { set; }

	// Methods

	// RVA: 0x23EA90 Offset: 0x23DE90 VA: 0x18023EA90
	public void set_uniqueID(ulong value) { }

	// RVA: 0xF3A80 Offset: 0xF2E80 VA: 0x1800F3A80
	public void set_nodeType(XRNode value) { }

	// RVA: 0x23EA80 Offset: 0x23DE80 VA: 0x18023EA80
	public void set_tracked(bool value) { }

}

public class XRDisplaySubsystem : IntegratedSubsystem<XRDisplaySubsystemDescriptor> // TypeDefIndex: 4150
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	[DebuggerBrowsableAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	private static Action<bool> displayFocusChanged; // 0x2B0AA90

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x22F6590 Offset: 0x22F5990 VA: 0x1822F6590
	private static void InvokeDisplayFocusChanged(bool focus) { }

	// RVA: 0x22F65F0 Offset: 0x22F59F0 VA: 0x1822F65F0
	public void .ctor() { }

}

public struct XRDisplaySubsystem.XRRenderPass // TypeDefIndex: 4151
{	// Fields
	private IntPtr displaySubsystemInstance; // 0x0
	public int renderPassIndex; // 0x8
	public RenderTargetIdentifier renderTarget; // 0x10
	public RenderTextureDescriptor renderTargetDesc; // 0x38
	public bool shouldFillOutDepth; // 0x6C
	public int cullingPassIndex; // 0x70

}

public struct XRDisplaySubsystem.XRMirrorViewBlitDesc // TypeDefIndex: 4152
{	// Fields
	private IntPtr displaySubsystemInstance; // 0x0
	public bool nativeBlitAvailable; // 0x8
	public bool nativeBlitInvalidStates; // 0x9
	public int blitParamsCount; // 0xC

}

public class XRDisplaySubsystemDescriptor : IntegratedSubsystemDescriptor<XRDisplaySubsystem> // TypeDefIndex: 4153
{	// Methods

	// RVA: 0x22F6550 Offset: 0x22F5950 VA: 0x1822F6550
	public void .ctor() { }

}

public class XRInputSubsystem : IntegratedSubsystem<XRInputSubsystemDescriptor> // TypeDefIndex: 4154
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	[DebuggerBrowsableAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	private Action<XRInputSubsystem> trackingOriginUpdated; // 0x20
	[DebuggerBrowsableAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	[CompilerGeneratedAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	private Action<XRInputSubsystem> boundaryChanged; // 0x28

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x97750 Offset: 0x96B50 VA: 0x180097750
	// RVA: 0x22F6720 Offset: 0x22F5B20 VA: 0x1822F6720
	private static void InvokeTrackingOriginUpdatedEvent(IntPtr internalPtr) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x97750 Offset: 0x96B50 VA: 0x180097750
	// RVA: 0x22F6670 Offset: 0x22F5A70 VA: 0x1822F6670
	private static void InvokeBoundaryChangedEvent(IntPtr internalPtr) { }

	// RVA: 0x22F67D0 Offset: 0x22F5BD0 VA: 0x1822F67D0
	public void .ctor() { }

}

public class XRInputSubsystemDescriptor : IntegratedSubsystemDescriptor<XRInputSubsystem> // TypeDefIndex: 4155
{	// Methods

	// RVA: 0x22F6630 Offset: 0x22F5A30 VA: 0x1822F6630
	public void .ctor() { }

}

public class XRMeshSubsystem : IntegratedSubsystem<XRMeshSubsystemDescriptor> // TypeDefIndex: 4161
{	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x22F6850 Offset: 0x22F5C50 VA: 0x1822F6850
	private void InvokeMeshReadyDelegate(MeshGenerationResult result, Action<MeshGenerationResult> onMeshGenerationComplete) { }

	// RVA: 0x22F68C0 Offset: 0x22F5CC0 VA: 0x1822F68C0
	public void .ctor() { }

}

public class XRMeshSubsystemDescriptor : IntegratedSubsystemDescriptor<XRMeshSubsystem> // TypeDefIndex: 4162
{	// Methods

	// RVA: 0x22F6810 Offset: 0x22F5C10 VA: 0x1822F6810
	public void .ctor() { }

}

internal sealed class XDRSchema : XMLSchema // TypeDefIndex: 4313
{	// Fields
	internal string _schemaName; // 0x10
	internal string _schemaUri; // 0x18
	internal XmlElement _schemaRoot; // 0x20
	internal DataSet _ds; // 0x28
	private static readonly char[] s_colonArray; // 0x0
	private static XDRSchema.NameType[] s_mapNameTypeXdr; // 0x8
	private static XDRSchema.NameType s_enumerationNameType; // 0x10

	// Methods

	// RVA: 0xCCE830 Offset: 0xCCDC30 VA: 0x180CCE830
	internal void .ctor(DataSet ds, bool fInline) { }

	// RVA: 0xCCBFB0 Offset: 0xCCB3B0 VA: 0x180CCBFB0
	internal void LoadSchema(XmlElement schemaRoot, DataSet ds) { }

	// RVA: 0xCC9D00 Offset: 0xCC9100 VA: 0x180CC9D00
	internal XmlElement FindTypeNode(XmlElement node) { }

	// RVA: 0xCCBB70 Offset: 0xCCAF70 VA: 0x180CCBB70
	internal bool IsTextOnlyContent(XmlElement node) { }

	// RVA: 0xCCBCC0 Offset: 0xCCB0C0 VA: 0x180CCBCC0
	internal bool IsXDRField(XmlElement node, XmlElement typeNode) { }

	// RVA: 0xCCB030 Offset: 0xCCA430 VA: 0x180CCB030
	internal DataTable HandleTable(XmlElement node) { }

	// RVA: 0xCC9C10 Offset: 0xCC9010 VA: 0x180CC9C10
	private static XDRSchema.NameType FindNameType(string name) { }

	// RVA: 0xCCCF00 Offset: 0xCCC300 VA: 0x180CCCF00
	private Type ParseDataType(string dt, string dtValues) { }

	// RVA: 0xCCA1C0 Offset: 0xCC95C0 VA: 0x180CCA1C0
	internal string GetInstanceName(XmlElement node) { }

	// RVA: 0xCCA6B0 Offset: 0xCC9AB0 VA: 0x180CCA6B0
	internal void HandleColumn(XmlElement node, DataTable table) { }

	// RVA: 0xCCA680 Offset: 0xCC9A80 VA: 0x180CCA680
	internal void GetMinMax(XmlElement elNode, ref int minOccurs, ref int maxOccurs) { }

	// RVA: 0xCCA360 Offset: 0xCC9760 VA: 0x180CCA360
	internal void GetMinMax(XmlElement elNode, bool isAttribute, ref int minOccurs, ref int maxOccurs) { }

	// RVA: 0xCCB1C0 Offset: 0xCCA5C0 VA: 0x180CCB1C0
	internal void HandleTypeNode(XmlElement typeNode, DataTable table, ArrayList tableChildren) { }

	// RVA: 0xCCB610 Offset: 0xCCAA10 VA: 0x180CCB610
	internal DataTable InstantiateTable(DataSet dataSet, XmlElement node, XmlElement typeNode) { }

	// RVA: 0xCCB3D0 Offset: 0xCCA7D0 VA: 0x180CCB3D0
	internal DataTable InstantiateSimpleTable(DataSet dataSet, XmlElement node) { }

	// RVA: 0xCCD030 Offset: 0xCCC430 VA: 0x180CCD030
	private static void .cctor() { }

}

private sealed class XDRSchema.NameType : IComparable // TypeDefIndex: 4314
{	// Fields
	public string name; // 0x10
	public Type type; // 0x18

	// Methods

	// RVA: 0x53C500 Offset: 0x53B900 VA: 0x18053C500
	public void .ctor(string n, Type t) { }

	// RVA: 0xCBAD40 Offset: 0xCBA140 VA: 0x180CBAD40 Slot: 4
	public int CompareTo(object obj) { }

}

internal sealed class XMLDiffLoader // TypeDefIndex: 4315
{	// Fields
	private ArrayList _tables; // 0x10
	private DataSet _dataSet; // 0x18
	private DataTable _dataTable; // 0x20

	// Methods

	// RVA: 0xCCEF90 Offset: 0xCCE390 VA: 0x180CCEF90
	internal void LoadDiffGram(DataSet ds, XmlReader dataTextReader) { }

	// RVA: 0xCCE8D0 Offset: 0xCCDCD0 VA: 0x180CCE8D0
	private void CreateTablesHierarchy(DataTable dt) { }

	// RVA: 0xCCEDB0 Offset: 0xCCE1B0 VA: 0x180CCEDB0
	internal void LoadDiffGram(DataTable dt, XmlReader dataTextReader) { }

	// RVA: 0xCCF410 Offset: 0xCCE810 VA: 0x180CCF410
	internal void ProcessDiffs(DataSet ds, XmlReader ssync) { }

	// RVA: 0xCCF100 Offset: 0xCCE500 VA: 0x180CCF100
	internal void ProcessDiffs(ArrayList tableList, XmlReader ssync) { }

	// RVA: 0xCCFCA0 Offset: 0xCCF0A0 VA: 0x180CCFCA0
	internal void ProcessErrors(DataSet ds, XmlReader ssync) { }

	// RVA: 0xCCF770 Offset: 0xCCEB70 VA: 0x180CCF770
	internal void ProcessErrors(ArrayList dt, XmlReader ssync) { }

	// RVA: 0xCCEB90 Offset: 0xCCDF90 VA: 0x180CCEB90
	private DataTable GetTable(string tableName, string ns) { }

	// RVA: 0xCD0070 Offset: 0xCCF470 VA: 0x180CD0070
	private int ReadOldRowData(DataSet ds, ref DataTable table, ref int pos, XmlReader row) { }

	// RVA: 0xCD0D80 Offset: 0xCD0180 VA: 0x180CD0D80
	internal void SkipWhitespaces(XmlReader reader) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

internal class XMLSchema // TypeDefIndex: 4316
{	// Methods

	// RVA: 0xCD10C0 Offset: 0xCD04C0 VA: 0x180CD10C0
	internal static TypeConverter GetConverter(Type type) { }

	// RVA: 0xCD1120 Offset: 0xCD0520 VA: 0x180CD1120
	internal static void SetProperties(object instance, XmlAttributeCollection attrs) { }

	// RVA: 0xCD0DF0 Offset: 0xCD01F0 VA: 0x180CD0DF0
	internal static bool FEqualIdentity(XmlNode node, string name, string ns) { }

	// RVA: 0xCD0FB0 Offset: 0xCD03B0 VA: 0x180CD0FB0
	internal static bool GetBooleanAttribute(XmlElement element, string attrName, string attrNS, bool defVal) { }

	// RVA: 0xCD0E80 Offset: 0xCD0280 VA: 0x180CD0E80
	internal static string GenUniqueColumnName(string proposedName, DataTable table) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

internal sealed class XSDSchema : XMLSchema // TypeDefIndex: 4318
{	// Fields
	private XmlSchemaSet _schemaSet; // 0x10
	private XmlSchemaElement _dsElement; // 0x18
	private DataSet _ds; // 0x20
	private string _schemaName; // 0x28
	private ArrayList _columnExpressions; // 0x30
	private Hashtable _constraintNodes; // 0x38
	private ArrayList _refTables; // 0x40
	private ArrayList _complexTypes; // 0x48
	private XmlSchemaObjectCollection _annotations; // 0x50
	private XmlSchemaObjectCollection _elements; // 0x58
	private Hashtable _attributes; // 0x60
	private Hashtable _elementsTable; // 0x68
	private Hashtable _attributeGroups; // 0x70
	private Hashtable _schemaTypes; // 0x78
	private Hashtable _expressions; // 0x80
	private Dictionary<DataTable, List<DataTable>> _tableDictionary; // 0x88
	private Hashtable _udSimpleTypes; // 0x90
	private Hashtable _existingSimpleTypeMap; // 0x98
	private bool _fromInference; // 0xA0
	private static readonly XSDSchema.NameType[] s_mapNameTypeXsd; // 0x0

	// Properties
	internal bool FromInference { get; set; }

	// Methods

	// RVA: 0xC26F70 Offset: 0xC26370 VA: 0x180C26F70
	internal bool get_FromInference() { }

	// RVA: 0xC27450 Offset: 0xC26850 VA: 0x180C27450
	internal void set_FromInference(bool value) { }

	// RVA: 0xCD21E0 Offset: 0xCD15E0 VA: 0x180CD21E0
	private void CollectElementsAnnotations(XmlSchema schema) { }

	// RVA: 0xCD1880 Offset: 0xCD0C80 VA: 0x180CD1880
	private void CollectElementsAnnotations(XmlSchema schema, ArrayList schemaList) { }

	// RVA: 0xCE2E30 Offset: 0xCE2230 VA: 0x180CE2E30
	internal static string QualifiedName(string name) { }

	// RVA: 0xCE3490 Offset: 0xCE2890 VA: 0x180CE3490
	internal static void SetProperties(object instance, XmlAttribute[] attrs) { }

	// RVA: 0xCE30E0 Offset: 0xCE24E0 VA: 0x180CE30E0
	private static void SetExtProperties(object instance, XmlAttribute[] attrs) { }

	// RVA: 0xCD5580 Offset: 0xCD4980 VA: 0x180CD5580
	private void HandleColumnExpression(object instance, XmlAttribute[] attrs) { }

	// RVA: 0xCD3360 Offset: 0xCD2760 VA: 0x180CD3360
	internal static string GetMsdataAttribute(XmlSchemaAnnotated node, string ln) { }

	// RVA: 0xCE2EA0 Offset: 0xCE22A0 VA: 0x180CE2EA0
	private static void SetExtProperties(object instance, XmlAttributeCollection attrs) { }

	// RVA: 0xCDA330 Offset: 0xCD9730 VA: 0x180CDA330
	internal void HandleRefTableProperties(ArrayList RefTables, XmlSchemaElement element) { }

	// RVA: 0xCDA430 Offset: 0xCD9830 VA: 0x180CDA430
	internal void HandleRelation(XmlElement node, bool fNested) { }

	// RVA: 0xCDC2A0 Offset: 0xCDB6A0 VA: 0x180CDC2A0
	private bool HasAttributes(XmlSchemaObjectCollection attributes) { }

	// RVA: 0xCDF810 Offset: 0xCDEC10 VA: 0x180CDF810
	private bool IsDatasetParticle(XmlSchemaParticle pt) { }

	// RVA: 0xCD2270 Offset: 0xCD1670 VA: 0x180CD2270
	private int DatasetElementCount(XmlSchemaObjectCollection elements) { }

	// RVA: 0xCD2410 Offset: 0xCD1810 VA: 0x180CD2410
	private XmlSchemaElement FindDatasetElement(XmlSchemaObjectCollection elements) { }

	// RVA: 0xCE2B30 Offset: 0xCE1F30 VA: 0x180CE2B30
	public void LoadSchema(XmlSchemaSet schemaSet, DataTable dt) { }

	// RVA: 0xCE0350 Offset: 0xCDF750 VA: 0x180CE0350
	public void LoadSchema(XmlSchemaSet schemaSet, DataSet ds) { }

	// RVA: 0xCDAD00 Offset: 0xCDA100 VA: 0x180CDAD00
	private void HandleRelations(XmlSchemaAnnotation ann, bool fNested) { }

	// RVA: 0xCD3790 Offset: 0xCD2B90 VA: 0x180CD3790
	internal XmlSchemaObjectCollection GetParticleItems(XmlSchemaParticle pt) { }

	// RVA: 0xCD93F0 Offset: 0xCD87F0 VA: 0x180CD93F0
	internal void HandleParticle(XmlSchemaParticle pt, DataTable table, ArrayList tableChildren, bool isBase) { }

	// RVA: 0xCD52D0 Offset: 0xCD46D0 VA: 0x180CD52D0
	internal void HandleAttributes(XmlSchemaObjectCollection attributes, DataTable table, bool isBase) { }

	// RVA: 0xCD4F30 Offset: 0xCD4330 VA: 0x180CD4F30
	private void HandleAttributeGroup(XmlSchemaAttributeGroup attributeGroup, DataTable table, bool isBase) { }

	// RVA: 0xCD57A0 Offset: 0xCD4BA0 VA: 0x180CD57A0
	internal void HandleComplexType(XmlSchemaComplexType ct, DataTable table, ArrayList tableChildren, bool isNillable) { }

	// RVA: 0xCD3BD0 Offset: 0xCD2FD0 VA: 0x180CD3BD0
	internal XmlSchemaParticle GetParticle(XmlSchemaComplexType ct) { }

	// RVA: 0xCD29C0 Offset: 0xCD1DC0 VA: 0x180CD29C0
	internal DataColumn FindField(DataTable table, string field) { }

	// RVA: 0xCD1650 Offset: 0xCD0A50 VA: 0x180CD1650
	internal DataColumn[] BuildKey(XmlSchemaIdentityConstraint keyNode, DataTable table) { }

	// RVA: 0xCD30E0 Offset: 0xCD24E0 VA: 0x180CD30E0
	internal bool GetBooleanAttribute(XmlSchemaAnnotated element, string attrName, bool defVal) { }

	// RVA: 0xCD4120 Offset: 0xCD3520 VA: 0x180CD4120
	internal string GetStringAttribute(XmlSchemaAnnotated element, string attrName, string defVal) { }

	// RVA: 0xCE3970 Offset: 0xCE2D70 VA: 0x180CE3970
	internal static AcceptRejectRule TranslateAcceptRejectRule(string strRule) { }

	// RVA: 0xCE39D0 Offset: 0xCE2DD0 VA: 0x180CE39D0
	internal static Rule TranslateRule(string strRule) { }

	// RVA: 0xCD8B00 Offset: 0xCD7F00 VA: 0x180CD8B00
	internal void HandleKeyref(XmlSchemaKeyref keyref) { }

	// RVA: 0xCD60A0 Offset: 0xCD54A0 VA: 0x180CD60A0
	internal void HandleConstraint(XmlSchemaIdentityConstraint keyNode) { }

	// RVA: 0xCDC4E0 Offset: 0xCDB8E0 VA: 0x180CDC4E0
	internal DataTable InstantiateSimpleTable(XmlSchemaElement node) { }

	// RVA: 0xCD3200 Offset: 0xCD2600 VA: 0x180CD3200
	internal string GetInstanceName(XmlSchemaAnnotated node) { }

	// RVA: 0xCDD460 Offset: 0xCDC860 VA: 0x180CDD460
	internal DataTable InstantiateTable(XmlSchemaElement node, XmlSchemaComplexType typeNode, bool isRef) { }

	// RVA: 0xCE3A80 Offset: 0xCE2E80 VA: 0x180CE3A80
	public static Type XsdtoClr(string xsdTypeName) { }

	// RVA: 0xCD2BA0 Offset: 0xCD1FA0 VA: 0x180CD2BA0
	private static XSDSchema.NameType FindNameType(string name) { }

	// RVA: 0xCE2B60 Offset: 0xCE1F60 VA: 0x180CE2B60
	private Type ParseDataType(string dt) { }

	// RVA: 0xCE02E0 Offset: 0xCDF6E0 VA: 0x180CE02E0
	internal static bool IsXsdType(string name) { }

	// RVA: 0xCD2C90 Offset: 0xCD2090 VA: 0x180CD2C90
	internal XmlSchemaAnnotated FindTypeNode(XmlSchemaAnnotated node) { }

	// RVA: 0xCDB750 Offset: 0xCDAB50 VA: 0x180CDB750
	internal void HandleSimpleTypeSimpleContentColumn(XmlSchemaSimpleType typeNode, string strType, DataTable table, bool isBase, XmlAttribute[] attrs, bool isNillable) { }

	// RVA: 0xCDAFF0 Offset: 0xCDA3F0 VA: 0x180CDAFF0
	internal void HandleSimpleContentColumn(string strType, DataTable table, bool isBase, XmlAttribute[] attrs, bool isNillable) { }

	// RVA: 0xCD44A0 Offset: 0xCD38A0 VA: 0x180CD44A0
	internal void HandleAttributeColumn(XmlSchemaAttribute attrib, DataTable table, bool isBase) { }

	// RVA: 0xCD7AB0 Offset: 0xCD6EB0 VA: 0x180CD7AB0
	internal void HandleElementColumn(XmlSchemaElement elem, DataTable table, bool isBase) { }

	// RVA: 0xCD6580 Offset: 0xCD5980 VA: 0x180CD6580
	internal void HandleDataSet(XmlSchemaElement node, bool isNewDataSet) { }

	// RVA: 0xCD14E0 Offset: 0xCD08E0 VA: 0x180CD14E0
	private void AddTablesToList(List<DataTable> tableList, DataTable dt) { }

	// RVA: 0xCD3E50 Offset: 0xCD3250 VA: 0x180CD3E50
	private string GetPrefix(string ns) { }

	// RVA: 0xCD34B0 Offset: 0xCD28B0 VA: 0x180CD34B0
	private string GetNamespaceFromPrefix(string prefix) { }

	// RVA: 0xCD42E0 Offset: 0xCD36E0 VA: 0x180CD42E0
	private string GetTableNamespace(XmlSchemaIdentityConstraint key) { }

	// RVA: 0xCD41A0 Offset: 0xCD35A0 VA: 0x180CD41A0
	private string GetTableName(XmlSchemaIdentityConstraint key) { }

	// RVA: 0xCDFFC0 Offset: 0xCDF3C0 VA: 0x180CDFFC0
	internal bool IsTable(XmlSchemaElement node) { }

	// RVA: 0xCDC0E0 Offset: 0xCDB4E0 VA: 0x180CDC0E0
	internal DataTable HandleTable(XmlSchemaElement node) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0xCE3B80 Offset: 0xCE2F80 VA: 0x180CE3B80
	private static void .cctor() { }

}

private sealed class XSDSchema.NameType : IComparable // TypeDefIndex: 4319
{	// Fields
	public readonly string name; // 0x10
	public readonly Type type; // 0x18

	// Methods

	// RVA: 0x53C500 Offset: 0x53B900 VA: 0x18053C500
	public void .ctor(string n, Type t) { }

	// RVA: 0x1AC14A0 Offset: 0x1AC08A0 VA: 0x181AC14A0 Slot: 4
	public int CompareTo(object obj) { }

}

internal sealed class XmlIgnoreNamespaceReader : XmlNodeReader // TypeDefIndex: 4320
{	// Fields
	private List<string> _namespacesToIgnore; // 0x30

	// Methods

	// RVA: 0x1ACB3B0 Offset: 0x1ACA7B0 VA: 0x181ACB3B0
	internal void .ctor(XmlDocument xdoc, string[] namespacesToIgnore) { }

	// RVA: 0x1ACB1C0 Offset: 0x1ACA5C0 VA: 0x181ACB1C0 Slot: 27
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x1ACB2C0 Offset: 0x1ACA6C0 VA: 0x181ACB2C0 Slot: 28
	public override bool MoveToNextAttribute() { }

}

internal sealed class XmlDataLoader // TypeDefIndex: 4321
{	// Fields
	private DataSet _dataSet; // 0x10
	private XmlToDatasetMap _nodeToSchemaMap; // 0x18
	private Hashtable _nodeToRowMap; // 0x20
	private Stack _childRowsStack; // 0x28
	private Hashtable _htableExcludedNS; // 0x30
	private bool _fIsXdr; // 0x38
	internal bool _isDiffgram; // 0x39
	private XmlElement _topMostNode; // 0x40
	private bool _ignoreSchema; // 0x48
	private DataTable _dataTable; // 0x50
	private bool _isTableLevel; // 0x58
	private bool _fromInference; // 0x59
	private XmlReader _dataReader; // 0x60
	private object _XSD_XMLNS_NS; // 0x68
	private object _XDR_SCHEMA; // 0x70
	private object _XDRNS; // 0x78
	private object _SQL_SYNC; // 0x80
	private object _UPDGNS; // 0x88
	private object _XSD_SCHEMA; // 0x90
	private object _XSDNS; // 0x98
	private object _DFFNS; // 0xA0
	private object _MSDNS; // 0xA8
	private object _DIFFID; // 0xB0
	private object _HASCHANGES; // 0xB8
	private object _ROWORDER; // 0xC0

	// Properties
	internal bool FromInference { get; set; }

	// Methods

	// RVA: 0x1AC8020 Offset: 0x1AC7420 VA: 0x181AC8020
	internal void .ctor(DataSet dataset, bool IsXdr, bool ignoreSchema) { }

	// RVA: 0x1AC8180 Offset: 0x1AC7580 VA: 0x181AC8180
	internal void .ctor(DataSet dataset, bool IsXdr, XmlElement topNode, bool ignoreSchema) { }

	// RVA: 0x1AC80C0 Offset: 0x1AC74C0 VA: 0x181AC80C0
	internal void .ctor(DataTable datatable, bool IsXdr, bool ignoreSchema) { }

	// RVA: 0x1AC7F30 Offset: 0x1AC7330 VA: 0x181AC7F30
	internal void .ctor(DataTable datatable, bool IsXdr, XmlElement topNode, bool ignoreSchema) { }

	// RVA: 0xAF1470 Offset: 0xAF0870 VA: 0x180AF1470
	internal bool get_FromInference() { }

	// RVA: 0xFFA690 Offset: 0xFF9A90 VA: 0x180FFA690
	internal void set_FromInference(bool value) { }

	// RVA: 0x1AC15C0 Offset: 0x1AC09C0 VA: 0x181AC15C0
	private void AttachRows(DataRow parentRow, XmlNode parentElement) { }

	// RVA: 0x1AC1740 Offset: 0x1AC0B40 VA: 0x181AC1740
	private int CountNonNSAttributes(XmlNode node) { }

	// RVA: 0x1AC2220 Offset: 0x1AC1620 VA: 0x181AC2220
	private string GetValueForTextOnlyColums(XmlNode n) { }

	// RVA: 0x1AC1DB0 Offset: 0x1AC11B0 VA: 0x181AC1DB0
	private string GetInitialTextFromNodes(ref XmlNode n) { }

	// RVA: 0x1AC2170 Offset: 0x1AC1570 VA: 0x181AC2170
	private DataColumn GetTextOnlyColumn(DataRow row) { }

	// RVA: 0x1AC20C0 Offset: 0x1AC14C0 VA: 0x181AC20C0
	internal DataRow GetRowFromElement(XmlElement e) { }

	// RVA: 0x1AC18D0 Offset: 0x1AC0CD0 VA: 0x181AC18D0
	internal bool FColumnElement(XmlElement e) { }

	// RVA: 0x1AC1B30 Offset: 0x1AC0F30 VA: 0x181AC1B30
	private bool FExcludedNamespace(string ns) { }

	// RVA: 0x1AC1C50 Offset: 0x1AC1050 VA: 0x181AC1C50
	private bool FIgnoreNamespace(XmlNode node) { }

	// RVA: 0x1AC1BC0 Offset: 0x1AC0FC0 VA: 0x181AC1BC0
	private bool FIgnoreNamespace(XmlReader node) { }

	// RVA: 0x1AC2790 Offset: 0x1AC1B90 VA: 0x181AC2790
	internal bool IsTextLikeNode(XmlNodeType n) { }

	// RVA: 0x1AC27F0 Offset: 0x1AC1BF0 VA: 0x181AC27F0
	internal bool IsTextOnly(DataColumn c) { }

	// RVA: 0x1AC3240 Offset: 0x1AC2640 VA: 0x181AC3240
	internal void LoadData(XmlDocument xdoc) { }

	// RVA: 0x1AC3900 Offset: 0x1AC2D00 VA: 0x181AC3900
	private void LoadRowData(DataRow row, XmlElement rowElement) { }

	// RVA: 0x1AC50A0 Offset: 0x1AC44A0 VA: 0x181AC50A0
	private void LoadRows(DataRow parentRow, XmlNode parentElement) { }

	// RVA: 0x1AC7EE0 Offset: 0x1AC72E0 VA: 0x181AC7EE0
	private void SetRowValueFromXmlText(DataRow row, DataColumn col, string xmlText) { }

	// RVA: 0x1AC2520 Offset: 0x1AC1920 VA: 0x181AC2520
	private void InitNameTable() { }

	// RVA: 0x1AC3520 Offset: 0x1AC2920 VA: 0x181AC3520
	internal void LoadData(XmlReader reader) { }

	// RVA: 0x1AC6E20 Offset: 0x1AC6220 VA: 0x181AC6E20
	private void LoadTopMostTable(DataTable table) { }

	// RVA: 0x1AC5FC0 Offset: 0x1AC53C0 VA: 0x181AC5FC0
	private void LoadTable(DataTable table, bool isNested) { }

	// RVA: 0x1AC2820 Offset: 0x1AC1C20 VA: 0x181AC2820
	private void LoadColumn(DataColumn column, object[] foundColumns) { }

	// RVA: 0x1AC7C90 Offset: 0x1AC7090 VA: 0x181AC7C90
	private bool ProcessXsdSchema() { }

}

public enum XmlReadMode // TypeDefIndex: 4322
{	// Fields
	public int value__; // 0x0
	public const XmlReadMode Auto = 0;
	public const XmlReadMode ReadSchema = 1;
	public const XmlReadMode IgnoreSchema = 2;
	public const XmlReadMode InferSchema = 3;
	public const XmlReadMode DiffGram = 4;
	public const XmlReadMode Fragment = 5;
	public const XmlReadMode InferTypedSchema = 6;

}

internal sealed class XmlToDatasetMap // TypeDefIndex: 4323
{	// Fields
	private XmlToDatasetMap.XmlNodeIdHashtable _tableSchemaMap; // 0x10
	private XmlToDatasetMap.TableSchemaInfo _lastTableSchemaInfo; // 0x18

	// Methods

	// RVA: 0x1ACEED0 Offset: 0x1ACE2D0 VA: 0x181ACEED0
	public void .ctor(DataSet dataSet, XmlNameTable nameTable) { }

	// RVA: 0x1ACEE10 Offset: 0x1ACE210 VA: 0x181ACEE10
	public void .ctor(XmlNameTable nameTable, DataSet dataSet) { }

	// RVA: 0x1ACEE90 Offset: 0x1ACE290 VA: 0x181ACEE90
	public void .ctor(DataTable dataTable, XmlNameTable nameTable) { }

	// RVA: 0x1ACEE50 Offset: 0x1ACE250 VA: 0x181ACEE50
	public void .ctor(XmlNameTable nameTable, DataTable dataTable) { }

	// RVA: 0x1ACEDE0 Offset: 0x1ACE1E0 VA: 0x181ACEDE0
	internal static bool IsMappedColumn(DataColumn c) { }

	// RVA: 0x1ACBD00 Offset: 0x1ACB100 VA: 0x181ACBD00
	private XmlToDatasetMap.TableSchemaInfo AddTableSchema(DataTable table, XmlNameTable nameTable) { }

	// RVA: 0x1ACBB50 Offset: 0x1ACAF50 VA: 0x181ACBB50
	private XmlToDatasetMap.TableSchemaInfo AddTableSchema(XmlNameTable nameTable, DataTable table) { }

	// RVA: 0x1ACB800 Offset: 0x1ACAC00 VA: 0x181ACB800
	private bool AddColumnSchema(DataColumn col, XmlNameTable nameTable, XmlToDatasetMap.XmlNodeIdHashtable columns) { }

	// RVA: 0x1ACB960 Offset: 0x1ACAD60 VA: 0x181ACB960
	private bool AddColumnSchema(XmlNameTable nameTable, DataColumn col, XmlToDatasetMap.XmlNodeIdHashtable columns) { }

	// RVA: 0x1ACBE40 Offset: 0x1ACB240 VA: 0x181ACBE40
	private void BuildIdentityMap(DataSet dataSet, XmlNameTable nameTable) { }

	// RVA: 0x1ACD1C0 Offset: 0x1ACC5C0 VA: 0x181ACD1C0
	private void BuildIdentityMap(XmlNameTable nameTable, DataSet dataSet) { }

	// RVA: 0x1ACDDE0 Offset: 0x1ACD1E0 VA: 0x181ACDDE0
	private void BuildIdentityMap(DataTable dataTable, XmlNameTable nameTable) { }

	// RVA: 0x1ACC5D0 Offset: 0x1ACB9D0 VA: 0x181ACC5D0
	private void BuildIdentityMap(XmlNameTable nameTable, DataTable dataTable) { }

	// RVA: 0x1ACE830 Offset: 0x1ACDC30 VA: 0x181ACE830
	private ArrayList GetSelfAndDescendants(DataTable dt) { }

	// RVA: 0x1ACE440 Offset: 0x1ACD840 VA: 0x181ACE440
	public object GetColumnSchema(XmlNode node, bool fIgnoreNamespace) { }

	// RVA: 0x1ACE290 Offset: 0x1ACD690 VA: 0x181ACE290
	public object GetColumnSchema(DataTable table, XmlReader dataReader, bool fIgnoreNamespace) { }

	// RVA: 0x1ACE730 Offset: 0x1ACDB30 VA: 0x181ACE730
	public object GetSchemaForNode(XmlNode node, bool fIgnoreNamespace) { }

	// RVA: 0x1ACEB70 Offset: 0x1ACDF70 VA: 0x181ACEB70
	public DataTable GetTableForNode(XmlReader node, bool fIgnoreNamespace) { }

	// RVA: 0x1ACEC60 Offset: 0x1ACE060 VA: 0x181ACEC60
	private void HandleSpecialColumn(DataColumn col, XmlNameTable nameTable, XmlToDatasetMap.XmlNodeIdHashtable columns) { }

}

private sealed class XmlToDatasetMap.XmlNodeIdentety // TypeDefIndex: 4324
{	// Fields
	public string LocalName; // 0x10
	public string NamespaceURI; // 0x18

	// Methods

	// RVA: 0x53C500 Offset: 0x53B900 VA: 0x18053C500
	public void .ctor(string localName, string namespaceURI) { }

	// RVA: 0xDDCF60 Offset: 0xDDC360 VA: 0x180DDCF60 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1ACB750 Offset: 0x1ACAB50 VA: 0x181ACB750 Slot: 0
	public override bool Equals(object obj) { }

}

internal sealed class XmlToDatasetMap.XmlNodeIdHashtable : Hashtable // TypeDefIndex: 4325
{	// Fields
	private XmlToDatasetMap.XmlNodeIdentety _id; // 0x50

	// Properties
	public object Item { get; }
	public object Item { get; }
	public object Item { get; }
	public object Item { get; }

	// Methods

	// RVA: 0x1ACB430 Offset: 0x1ACA830 VA: 0x181ACB430
	public void .ctor(int capacity) { }

	// RVA: 0x1ACB610 Offset: 0x1ACAA10 VA: 0x181ACB610
	public object get_Item(XmlNode node) { }

	// RVA: 0x1ACB6B0 Offset: 0x1ACAAB0 VA: 0x181ACB6B0
	public object get_Item(XmlReader dataReader) { }

	// RVA: 0x1ACB580 Offset: 0x1ACA980 VA: 0x181ACB580
	public object get_Item(DataTable table) { }

	// RVA: 0x1ACB4E0 Offset: 0x1ACA8E0 VA: 0x181ACB4E0
	public object get_Item(string name) { }

}

private sealed class XmlToDatasetMap.TableSchemaInfo // TypeDefIndex: 4326
{	// Fields
	public DataTable TableSchema; // 0x10
	public XmlToDatasetMap.XmlNodeIdHashtable ColumnsSchemaMap; // 0x18

	// Methods

	// RVA: 0x1AC1510 Offset: 0x1AC0910 VA: 0x181AC1510
	public void .ctor(DataTable tableSchema) { }

}

public enum XmlWriteMode // TypeDefIndex: 4327
{	// Fields
	public int value__; // 0x0
	public const XmlWriteMode WriteSchema = 0;
	public const XmlWriteMode IgnoreSchema = 1;
	public const XmlWriteMode DiffGram = 2;

}

internal sealed class XmlTreeGen // TypeDefIndex: 4330
{	// Fields
	private ArrayList _constraintNames; // 0x10
	private Hashtable _namespaces; // 0x18
	private Hashtable _autogenerated; // 0x20
	private Hashtable _prefixes; // 0x28
	private DataSet _ds; // 0x30
	private ArrayList _tables; // 0x38
	private ArrayList _relations; // 0x40
	private XmlDocument _dc; // 0x48
	private XmlElement _sRoot; // 0x50
	private int _prefixCount; // 0x58
	private SchemaFormat _schFormat; // 0x5C
	private string _filePath; // 0x60
	private string _fileName; // 0x68
	private string _fileExt; // 0x70
	private XmlElement _dsElement; // 0x78
	private XmlElement _constraintSeparator; // 0x80
	private Converter<Type, string> _targetConverter; // 0x88

	// Methods

	// RVA: 0x1ADBC70 Offset: 0x1ADB070 VA: 0x181ADBC70
	internal void .ctor(SchemaFormat format) { }

	// RVA: 0x1ACF4C0 Offset: 0x1ACE8C0 VA: 0x181ACF4C0
	internal static void AddExtendedProperties(PropertyCollection props, XmlElement node) { }

	// RVA: 0x1ACF4D0 Offset: 0x1ACE8D0 VA: 0x181ACF4D0
	internal static void AddExtendedProperties(PropertyCollection props, XmlElement node, Type type) { }

	// RVA: 0x1ACFA00 Offset: 0x1ACEE00 VA: 0x181ACFA00
	internal void AddXdoProperties(object instance, XmlElement root, XmlDocument xd) { }

	// RVA: 0x1ACFBD0 Offset: 0x1ACEFD0 VA: 0x181ACFBD0
	internal void AddXdoProperty(PropertyDescriptor pd, object instance, XmlElement root, XmlDocument xd) { }

	// RVA: 0x1ADB050 Offset: 0x1ADA450 VA: 0x181ADB050
	internal static string XmlDataTypeName(Type type) { }

	// RVA: 0x1AD22F0 Offset: 0x1AD16F0 VA: 0x181AD22F0
	private void GenerateConstraintNames(DataTable table, bool fromTable) { }

	// RVA: 0x1AD1FF0 Offset: 0x1AD13F0 VA: 0x181AD1FF0
	private void GenerateConstraintNames(ArrayList tables) { }

	// RVA: 0x1AD20F0 Offset: 0x1AD14F0 VA: 0x181AD20F0
	private void GenerateConstraintNames(DataSet ds) { }

	// RVA: 0x1ADBC40 Offset: 0x1ADB040 VA: 0x181ADBC40
	private static bool _PropsNotEmpty(PropertyCollection props) { }

	// RVA: 0x1AD6890 Offset: 0x1AD5C90 VA: 0x181AD6890
	private bool HaveExtendedProperties(DataSet ds) { }

	// RVA: 0x1ADAEC0 Offset: 0x1ADA2C0 VA: 0x181ADAEC0
	internal void WriteSchemaRoot(XmlDocument xd, XmlElement rootSchema, string targetNamespace) { }

	// RVA: 0x1ADAE50 Offset: 0x1ADA250 VA: 0x181ADAE50
	internal static void ValidateColumnMapping(Type columnType) { }

	// RVA: 0x1AD9DD0 Offset: 0x1AD91D0 VA: 0x181AD9DD0
	internal void SetupAutoGenerated(DataSet ds) { }

	// RVA: 0x1AD9FD0 Offset: 0x1AD93D0 VA: 0x181AD9FD0
	internal void SetupAutoGenerated(ArrayList dt) { }

	// RVA: 0x1ADA0D0 Offset: 0x1AD94D0 VA: 0x181ADA0D0
	internal void SetupAutoGenerated(DataTable dt) { }

	// RVA: 0x1AD1020 Offset: 0x1AD0420 VA: 0x181AD1020
	private void CreateTablesHierarchy(DataTable dt) { }

	// RVA: 0x1AD0DA0 Offset: 0x1AD01A0 VA: 0x181AD0DA0
	private void CreateRelations(DataTable dt) { }

	// RVA: 0x1AD12E0 Offset: 0x1AD06E0 VA: 0x181AD12E0
	private DataTable[] CreateToplevelTables() { }

	// RVA: 0x1AD72B0 Offset: 0x1AD66B0 VA: 0x181AD72B0
	internal void SchemaTree(XmlDocument xd, XmlWriter xmlWriter, DataSet ds, DataTable dt, bool writeHierarchy) { }

	// RVA: 0x1AD6E10 Offset: 0x1AD6210 VA: 0x181AD6E10
	internal XmlElement SchemaTree(XmlDocument xd, DataTable dt) { }

	// RVA: 0x1AD15A0 Offset: 0x1AD09A0 VA: 0x181AD15A0
	internal XmlElement FillDataSetElement(XmlDocument xd, DataSet ds, DataTable dt) { }

	// RVA: 0x1AD9BE0 Offset: 0x1AD8FE0 VA: 0x181AD9BE0
	internal void SetPath(XmlWriter xw) { }

	// RVA: 0x1AD6A90 Offset: 0x1AD5E90 VA: 0x181AD6A90
	internal void Save(DataSet ds, XmlWriter xw) { }

	// RVA: 0x1AD6C10 Offset: 0x1AD6010 VA: 0x181AD6C10
	internal void Save(DataTable dt, XmlWriter xw) { }

	// RVA: 0x1AD6AC0 Offset: 0x1AD5EC0 VA: 0x181AD6AC0
	internal void Save(DataSet ds, DataTable dt, XmlWriter xw) { }

	// RVA: 0x1AD6AE0 Offset: 0x1AD5EE0 VA: 0x181AD6AE0
	internal void Save(DataSet ds, DataTable dt, XmlWriter xw, bool writeHierarchy) { }

	// RVA: 0x1AD6CE0 Offset: 0x1AD60E0 VA: 0x181AD6CE0
	internal void Save(DataSet ds, DataTable dt, XmlWriter xw, bool writeHierarchy, Converter<Type, string> multipleTargetConverter) { }

	// RVA: 0x1AD3800 Offset: 0x1AD2C00 VA: 0x181AD3800
	internal XmlElement HandleRelation(DataRelation rel, XmlDocument dc) { }

	// RVA: 0x1AD1BA0 Offset: 0x1AD0FA0 VA: 0x181AD1BA0
	private static XmlElement FindSimpleType(XmlElement schema, string name) { }

	// RVA: 0x1AD2730 Offset: 0x1AD1B30 VA: 0x181AD2730
	internal XmlElement GetSchema(string NamespaceURI) { }

	// RVA: 0x1AD2990 Offset: 0x1AD1D90 VA: 0x181AD2990
	internal void HandleColumnType(DataColumn col, XmlDocument dc, XmlElement root, XmlElement schema) { }

	// RVA: 0x1ACEF10 Offset: 0x1ACE310 VA: 0x181ACEF10
	internal void AddColumnProperties(DataColumn col, XmlElement root) { }

	// RVA: 0x1AD1CF0 Offset: 0x1AD10F0 VA: 0x181AD1CF0
	private string FindTargetNamespace(DataTable table) { }

	// RVA: 0x1AD2E00 Offset: 0x1AD2200 VA: 0x181AD2E00
	internal XmlElement HandleColumn(DataColumn col, XmlDocument dc, XmlElement schema, bool fWriteOrdinal) { }

	// RVA: 0x1ADAD80 Offset: 0x1ADA180 VA: 0x181ADAD80
	internal static string TranslateAcceptRejectRule(AcceptRejectRule rule) { }

	// RVA: 0x1ADADD0 Offset: 0x1ADA1D0 VA: 0x181ADADD0
	internal static string TranslateRule(Rule rule) { }

	// RVA: 0x1AD04B0 Offset: 0x1ACF8B0 VA: 0x181AD04B0
	internal void AppendChildWithoutRef(XmlElement node, string Namespace, XmlElement el, string refString) { }

	// RVA: 0x1AD1E20 Offset: 0x1AD1220 VA: 0x181AD1E20
	internal XmlElement FindTypeNode(XmlElement node, string strType) { }

	// RVA: 0x1AD3DA0 Offset: 0x1AD31A0 VA: 0x181AD3DA0
	internal XmlElement HandleTable(DataTable table, XmlDocument dc, XmlElement schema) { }

	// RVA: 0x1AD6630 Offset: 0x1AD5A30 VA: 0x181AD6630
	private bool HasMixedColumns(DataTable table) { }

	// RVA: 0x1AD0880 Offset: 0x1ACFC80 VA: 0x181AD0880
	internal static bool AutoGenerated(DataColumn col) { }

	// RVA: 0x1AD0C90 Offset: 0x1AD0090 VA: 0x181AD0C90
	internal static bool AutoGenerated(DataRelation rel) { }

	// RVA: 0x1AD0560 Offset: 0x1ACF960 VA: 0x181AD0560
	internal static bool AutoGenerated(UniqueConstraint unique) { }

	// RVA: 0x1AD0C80 Offset: 0x1AD0080 VA: 0x181AD0C80
	private bool AutoGenerated(ForeignKeyConstraint fk) { }

	// RVA: 0x1AD0640 Offset: 0x1ACFA40 VA: 0x181AD0640
	internal static bool AutoGenerated(ForeignKeyConstraint fk, bool checkRelation) { }

	// RVA: 0x1AD6A50 Offset: 0x1AD5E50 VA: 0x181AD6A50
	private bool IsAutoGenerated(object o) { }

	// RVA: 0x1AD3DC0 Offset: 0x1AD31C0 VA: 0x181AD3DC0
	internal XmlElement HandleTable(DataTable table, XmlDocument dc, XmlElement schema, bool genNested) { }

	// RVA: 0x1AD9A30 Offset: 0x1AD8E30 VA: 0x181AD9A30
	private void SetMSDataAttribute(XmlElement root, Type type) { }

}

internal sealed class XmlDataTreeWriter // TypeDefIndex: 4332
{	// Fields
	private XmlWriter _xmlw; // 0x10
	private DataSet _ds; // 0x18
	private DataTable _dt; // 0x20
	private ArrayList _dTables; // 0x28
	private DataTable[] _topLevelTables; // 0x30
	private bool _fFromTable; // 0x38
	private bool _isDiffgram; // 0x39
	private Hashtable _rowsOrder; // 0x40
	private bool _writeHierarchy; // 0x48

	// Methods

	// RVA: 0x1ACAD30 Offset: 0x1ACA130 VA: 0x181ACAD30
	internal void .ctor(DataSet ds) { }

	// RVA: 0x1ACAFB0 Offset: 0x1ACA3B0 VA: 0x181ACAFB0
	internal void .ctor(DataTable dt, bool writeHierarchy) { }

	// RVA: 0x1AC8520 Offset: 0x1AC7920 VA: 0x181AC8520
	private DataTable[] CreateToplevelTables() { }

	// RVA: 0x1AC8260 Offset: 0x1AC7660 VA: 0x181AC8260
	private void CreateTablesHierarchy(DataTable dt) { }

	// RVA: 0x1AC8B00 Offset: 0x1AC7F00 VA: 0x181AC8B00
	internal static bool RowHasErrors(DataRow row) { }

	// RVA: 0x1AC8BE0 Offset: 0x1AC7FE0 VA: 0x181AC8BE0
	internal void SaveDiffgramData(XmlWriter xw, Hashtable rowsOrder) { }

	// RVA: 0x1AC9170 Offset: 0x1AC8570 VA: 0x181AC9170
	internal void Save(XmlWriter xw, bool writeSchema) { }

	// RVA: 0x1AC87E0 Offset: 0x1AC7BE0 VA: 0x181AC87E0
	private ArrayList GetNestedChildRelations(DataRow row) { }

	// RVA: 0x1AC99F0 Offset: 0x1AC8DF0 VA: 0x181AC99F0
	internal void XmlDataRowWriter(DataRow row, string encodedTableName) { }

	// RVA: 0x1AC8A50 Offset: 0x1AC7E50 VA: 0x181AC8A50
	internal static bool PreserveSpace(object value) { }

}

public sealed class SqlXml : INullable, IXmlSerializable // TypeDefIndex: 4359
{	// Fields
	private static readonly Func<Stream, XmlReaderSettings, XmlParserContext, XmlReader> s_sqlReaderDelegate; // 0x0
	private static readonly XmlReaderSettings s_defaultXmlReaderSettings; // 0x8
	private static readonly XmlReaderSettings s_defaultXmlReaderSettingsCloseInput; // 0x10
	private static MethodInfo s_createSqlReaderMethodInfo; // 0x18
	private MethodInfo _createSqlReaderMethodInfo; // 0x10
	private bool _fNotNull; // 0x18
	private Stream _stream; // 0x20
	private bool _firstCreateReader; // 0x28

	// Properties
	private static MethodInfo CreateSqlReaderMethodInfo { get; }
	public bool IsNull { get; }

	// Methods

	// RVA: 0xCC7580 Offset: 0xCC6980 VA: 0x180CC7580
	public void .ctor() { }

	// RVA: 0xCC6C60 Offset: 0xCC6060 VA: 0x180CC6C60
	public XmlReader CreateReader() { }

	// RVA: 0xCC6EE0 Offset: 0xCC62E0 VA: 0x180CC6EE0
	internal static XmlReader CreateSqlXmlReader(Stream stream, bool closeInput = False, bool throwTargetInvocationExceptions = False) { }

	// RVA: 0xCC6E10 Offset: 0xCC6210 VA: 0x180CC6E10
	private static Func<Stream, XmlReaderSettings, XmlParserContext, XmlReader> CreateSqlReaderDelegate() { }

	// RVA: 0xCC75B0 Offset: 0xCC69B0 VA: 0x180CC75B0
	private static MethodInfo get_CreateSqlReaderMethodInfo() { }

	// RVA: 0xCC57D0 Offset: 0xCC4BD0 VA: 0x180CC57D0 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0xCC70D0 Offset: 0xCC64D0 VA: 0x180CC70D0
	private void SetNull() { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 5
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0xCC7100 Offset: 0xCC6500 VA: 0x180CC7100 Slot: 6
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader r) { }

	// RVA: 0xCC72C0 Offset: 0xCC66C0 VA: 0x180CC72C0 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xCC7070 Offset: 0xCC6470 VA: 0x180CC7070
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xCC73D0 Offset: 0xCC67D0 VA: 0x180CC73D0
	private static void .cctor() { }

}

internal sealed class SqlXmlStreamWrapper : Stream // TypeDefIndex: 4360
{	// Fields
	private Stream _stream; // 0x28
	private long _lPosition; // 0x30
	private bool _isClosed; // 0x38

	// Properties
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0xCC6960 Offset: 0xCC5D60 VA: 0x180CC6960
	internal void .ctor(Stream stream) { }

	// RVA: 0xCC69E0 Offset: 0xCC5DE0 VA: 0x180CC69E0 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0xCC6A30 Offset: 0xCC5E30 VA: 0x180CC6A30 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0xCC6A80 Offset: 0xCC5E80 VA: 0x180CC6A80 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0xCC6AD0 Offset: 0xCC5ED0 VA: 0x180CC6AD0 Slot: 10
	public override long get_Length() { }

	// RVA: 0xCC6B40 Offset: 0xCC5F40 VA: 0x180CC6B40 Slot: 11
	public override long get_Position() { }

	// RVA: 0xCC6BA0 Offset: 0xCC5FA0 VA: 0x180CC6BA0 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0xCC61B0 Offset: 0xCC55B0 VA: 0x180CC61B0 Slot: 25
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0xCC5FD0 Offset: 0xCC53D0 VA: 0x180CC5FD0 Slot: 27
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0xCC6790 Offset: 0xCC5B90 VA: 0x180CC6790 Slot: 29
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0xCC5EA0 Offset: 0xCC52A0 VA: 0x180CC5EA0 Slot: 28
	public override int ReadByte() { }

	// RVA: 0xCC66B0 Offset: 0xCC5AB0 VA: 0x180CC66B0 Slot: 30
	public override void WriteByte(byte value) { }

	// RVA: 0xCC63C0 Offset: 0xCC57C0 VA: 0x180CC63C0 Slot: 26
	public override void SetLength(long value) { }

	// RVA: 0xCC5E00 Offset: 0xCC5200 VA: 0x180CC5E00 Slot: 18
	public override void Flush() { }

	// RVA: 0xCC5D90 Offset: 0xCC5190 VA: 0x180CC5D90 Slot: 17
	protected override void Dispose(bool disposing) { }

	// RVA: 0xCC64F0 Offset: 0xCC58F0 VA: 0x180CC64F0
	private void ThrowIfStreamCannotSeek(string method) { }

	// RVA: 0xCC6450 Offset: 0xCC5850 VA: 0x180CC6450
	private void ThrowIfStreamCannotRead(string method) { }

	// RVA: 0xCC6590 Offset: 0xCC5990 VA: 0x180CC6590
	private void ThrowIfStreamCannotWrite(string method) { }

	// RVA: 0xCC6630 Offset: 0xCC5A30 VA: 0x180CC6630
	private void ThrowIfStreamClosed(string method) { }

	// RVA: 0xCC5E20 Offset: 0xCC5220 VA: 0x180CC5E20
	private bool IsStreamClosed() { }

}

public static class XRDevice // TypeDefIndex: 4768
{
// Namespace: 
internal class <Module> // TypeDefIndex: 4767

// Namespace: UnityEngine.XR
[NativeConditionalAttribute] // RVA: 0xC1A00 Offset: 0xC0E00 VA: 0x1800C1A00
public static class XRDevice // TypeDefIndex: 4768
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	[DebuggerBrowsableAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	private static Action<string> deviceLoaded; // 0x2B0AAC4

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x231D380 Offset: 0x231C780 VA: 0x18231D380
	private static void InvokeDeviceLoaded(string loadedDeviceName) { }

	// RVA: 0x231D430 Offset: 0x231C830 VA: 0x18231D430
	private static void .cctor() { }

}

public sealed class XName : IEquatable<XName>, ISerializable // TypeDefIndex: 5815
{
// Namespace: 
internal class <Module> // TypeDefIndex: 5814

// Namespace: System.Xml.Linq
[KnownTypeAttribute] // RVA: 0xE0C40 Offset: 0xE0040 VA: 0x1800E0C40
[Serializable]
public sealed class XName : IEquatable<XName>, ISerializable // TypeDefIndex: 5815
	// Fields
	private XNamespace ns; // 0x10
	private string localName; // 0x18
	private int hashCode; // 0x20

	// Properties
	public string LocalName { get; }
	public XNamespace Namespace { get; }
	public string NamespaceName { get; }

	// Methods

	// RVA: 0x22195C0 Offset: 0x22189C0 VA: 0x1822195C0
	internal void .ctor(XNamespace ns, string localName) { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public string get_LocalName() { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public XNamespace get_Namespace() { }

	// RVA: 0xB242C0 Offset: 0xB236C0 VA: 0x180B242C0
	public string get_NamespaceName() { }

	// RVA: 0x2219540 Offset: 0x2218940 VA: 0x182219540 Slot: 3
	public override string ToString() { }

	// RVA: 0x2219140 Offset: 0x2218540 VA: 0x182219140
	public static XName Get(string expandedName) { }

	// RVA: 0x2219370 Offset: 0x2218770 VA: 0x182219370
	public static XName Get(string localName, string namespaceName) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x22196D0 Offset: 0x2218AD0 VA: 0x1822196D0
	public static XName op_Implicit(string expandedName) { }

	// RVA: 0xAE1170 Offset: 0xAE0570 VA: 0x180AE1170 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x4D0170 Offset: 0x4CF570 VA: 0x1804D0170 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xAE1170 Offset: 0xAE0570 VA: 0x180AE1170
	public static bool op_Equality(XName left, XName right) { }

	// RVA: 0xAE1170 Offset: 0xAE0570 VA: 0x180AE1170 Slot: 4
	private bool System.IEquatable<System.Xml.Linq.XName>.Equals(XName other) { }

	// RVA: 0x2219470 Offset: 0x2218870 VA: 0x182219470 Slot: 5
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x22196A0 Offset: 0x2218AA0 VA: 0x1822196A0
	internal void .ctor() { }

}

public sealed class XNamespace // TypeDefIndex: 5817
{	// Fields
	private static XHashtable<WeakReference> namespaces; // 0x0
	private static WeakReference refNone; // 0x8
	private static WeakReference refXml; // 0x10
	private static WeakReference refXmlns; // 0x18
	private string namespaceName; // 0x10
	private int hashCode; // 0x18
	private XHashtable<XName> names; // 0x20

	// Properties
	public string NamespaceName { get; }
	public static XNamespace None { get; }
	public static XNamespace Xml { get; }
	public static XNamespace Xmlns { get; }

	// Methods

	// RVA: 0x2219E20 Offset: 0x2219220 VA: 0x182219E20
	internal void .ctor(string namespaceName) { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public string get_NamespaceName() { }

	// RVA: 0x22199D0 Offset: 0x2218DD0 VA: 0x1822199D0
	public XName GetName(string localName) { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460 Slot: 3
	public override string ToString() { }

	// RVA: 0x2219F00 Offset: 0x2219300 VA: 0x182219F00
	public static XNamespace get_None() { }

	// RVA: 0x2219F50 Offset: 0x2219350 VA: 0x182219F50
	public static XNamespace get_Xml() { }

	// RVA: 0x2219FA0 Offset: 0x22193A0 VA: 0x182219FA0
	public static XNamespace get_Xmlns() { }

	// RVA: 0x2219A60 Offset: 0x2218E60 VA: 0x182219A60
	public static XNamespace Get(string namespaceName) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x2219FF0 Offset: 0x22193F0 VA: 0x182219FF0
	public static XNamespace op_Implicit(string namespaceName) { }

	// RVA: 0xAE1170 Offset: 0xAE0570 VA: 0x180AE1170 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x4BE200 Offset: 0x4BD600 VA: 0x1804BE200 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xAE1170 Offset: 0xAE0570 VA: 0x180AE1170
	public static bool op_Equality(XNamespace left, XNamespace right) { }

	// RVA: 0x129EBD0 Offset: 0x129DFD0 VA: 0x18129EBD0
	public static bool op_Inequality(XNamespace left, XNamespace right) { }

	// RVA: 0x2219850 Offset: 0x2218C50 VA: 0x182219850
	internal XName GetName(string localName, int index, int count) { }

	// RVA: 0x2219AD0 Offset: 0x2218ED0 VA: 0x182219AD0
	internal static XNamespace Get(string namespaceName, int index, int count) { }

	// RVA: 0x14EF1B0 Offset: 0x14EE5B0 VA: 0x1814EF1B0
	private static string ExtractLocalName(XName n) { }

	// RVA: 0x22197D0 Offset: 0x2218BD0 VA: 0x1822197D0
	private static string ExtractNamespace(WeakReference r) { }

	// RVA: 0x22196E0 Offset: 0x2218AE0 VA: 0x1822196E0
	private static XNamespace EnsureNamespace(ref WeakReference refNmsp, string namespaceName) { }

}

public abstract class XObject : IXmlLineInfo // TypeDefIndex: 5822
{	// Fields
	internal XContainer parent; // 0x10
	internal object annotations; // 0x18

	// Properties
	public string BaseUri { get; }
	public abstract XmlNodeType NodeType { get; }
	public XElement Parent { get; }
	private int System.Xml.IXmlLineInfo.LineNumber { get; }
	private int System.Xml.IXmlLineInfo.LinePosition { get; }
	internal bool HasBaseUri { get; }

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	internal void .ctor() { }

	// RVA: 0x221B030 Offset: 0x221A430 VA: 0x18221B030
	public string get_BaseUri() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract XmlNodeType get_NodeType();

	// RVA: 0x221B0F0 Offset: 0x221A4F0 VA: 0x18221B0F0
	public XElement get_Parent() { }

	// RVA: 0x221A650 Offset: 0x2219A50 VA: 0x18221A650
	public void AddAnnotation(object annotation) { }

	// RVA: 0x221A920 Offset: 0x2219D20 VA: 0x18221A920
	public object Annotation(Type type) { }

	// RVA: -1 Offset: -1
	public T Annotation<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBDBF70 Offset: 0xBDB370 VA: 0x180BDBF70
	|-XObject.Annotation<object>
	|-XObject.Annotation<BaseUriAnnotation>
	|-XObject.Annotation<LineInfoAnnotation>
	|-XObject.Annotation<XObjectChangeAnnotation>
	*/

	[IteratorStateMachineAttribute] // RVA: 0xE0E10 Offset: 0xE0210 VA: 0x1800E0E10
	// RVA: -1 Offset: -1
	public IEnumerable<T> Annotations<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B17B0 Offset: 0x4B0BB0 VA: 0x1804B17B0
	|-XObject.Annotations<object>
	|-XObject.Annotations<XObjectChangeAnnotation>
	*/

	// RVA: 0x221AF50 Offset: 0x221A350 VA: 0x18221AF50 Slot: 4
	private bool System.Xml.IXmlLineInfo.HasLineInfo() { }

	// RVA: 0x221AF90 Offset: 0x221A390 VA: 0x18221AF90 Slot: 5
	private int System.Xml.IXmlLineInfo.get_LineNumber() { }

	// RVA: 0x221AFE0 Offset: 0x221A3E0 VA: 0x18221AFE0 Slot: 6
	private int System.Xml.IXmlLineInfo.get_LinePosition() { }

	// RVA: 0x221B0B0 Offset: 0x221A4B0 VA: 0x18221B0B0
	internal bool get_HasBaseUri() { }

	// RVA: 0x221AC90 Offset: 0x221A090 VA: 0x18221AC90
	internal bool NotifyChanged(object sender, XObjectChangeEventArgs e) { }

	// RVA: 0x221AD40 Offset: 0x221A140 VA: 0x18221AD40
	internal bool NotifyChanging(object sender, XObjectChangeEventArgs e) { }

	// RVA: 0x221ADF0 Offset: 0x221A1F0 VA: 0x18221ADF0
	internal void SetBaseUri(string baseUri) { }

	// RVA: 0x221AE70 Offset: 0x221A270 VA: 0x18221AE70
	internal void SetLineInfo(int lineNumber, int linePosition) { }

	// RVA: 0x221AEF0 Offset: 0x221A2F0 VA: 0x18221AEF0
	internal bool SkipNotify() { }

	// RVA: 0x221AA80 Offset: 0x2219E80 VA: 0x18221AA80
	internal SaveOptions GetSaveOptionsFromAnnotations() { }

}

private sealed class XObject.<Annotations>d__16<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IDisposable, IEnumerator // TypeDefIndex: 5823
{	// Fields
	private int <>1__state; // 0x0
	private T <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	public XObject <>4__this; // 0x0
	private object[] <a>5__1; // 0x0
	private int <i>5__2; // 0x0

	// Properties
	private T System.Collections.Generic.IEnumerator<T>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1446280 Offset: 0x1445680 VA: 0x181446280
	|-XObject.<Annotations>d__16<object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	|-XObject.<Annotations>d__16<object>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A511D0 Offset: 0x1A505D0 VA: 0x181A511D0
	|-XObject.<Annotations>d__16<object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 6
	private T System.Collections.Generic.IEnumerator<T>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	|-XObject.<Annotations>d__16<object>.System.Collections.Generic.IEnumerator<T>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A514E0 Offset: 0x1A508E0 VA: 0x181A514E0
	|-XObject.<Annotations>d__16<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	|-XObject.<Annotations>d__16<object>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A51420 Offset: 0x1A50820 VA: 0x181A51420
	|-XObject.<Annotations>d__16<object>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x175BBD0 Offset: 0x175AFD0 VA: 0x18175BBD0
	|-XObject.<Annotations>d__16<object>.System.Collections.IEnumerable.GetEnumerator
	*/

}

internal class XObjectChangeAnnotation // TypeDefIndex: 5827
{	// Fields
	internal EventHandler<XObjectChangeEventArgs> changing; // 0x10
	internal EventHandler<XObjectChangeEventArgs> changed; // 0x18

}

public enum XObjectChange // TypeDefIndex: 5828
{	// Fields
	public int value__; // 0x0
	public const XObjectChange Add = 0;
	public const XObjectChange Remove = 1;
	public const XObjectChange Name = 2;
	public const XObjectChange Value = 3;

}

public class XObjectChangeEventArgs : EventArgs // TypeDefIndex: 5829
{	// Fields
	private XObjectChange objectChange; // 0x10
	public static readonly XObjectChangeEventArgs Add; // 0x0
	public static readonly XObjectChangeEventArgs Remove; // 0x8
	public static readonly XObjectChangeEventArgs Name; // 0x10
	public static readonly XObjectChangeEventArgs Value; // 0x18

	// Methods

	// RVA: 0x221A5F0 Offset: 0x22199F0 VA: 0x18221A5F0
	public void .ctor(XObjectChange objectChange) { }

	// RVA: 0x221A3F0 Offset: 0x22197F0 VA: 0x18221A3F0
	private static void .cctor() { }

}

public abstract class XNode : XObject // TypeDefIndex: 5830
{	// Fields
	internal XNode next; // 0x20

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	internal void .ctor() { }

	// RVA: 0x221A330 Offset: 0x2219730 VA: 0x18221A330
	public void Remove() { }

	// RVA: 0x221A3C0 Offset: 0x22197C0 VA: 0x18221A3C0 Slot: 3
	public override string ToString() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void WriteTo(XmlWriter writer);

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 9
	internal virtual void AppendText(StringBuilder sb) { }

	// RVA: -1 Offset: -1 Slot: 10
	internal abstract XNode CloneNode();

	// RVA: 0x221A040 Offset: 0x2219440 VA: 0x18221A040
	private string GetXmlString(SaveOptions o) { }

}

public class XText : XNode // TypeDefIndex: 5831
{	// Fields
	internal string text; // 0x28

	// Properties
	public override XmlNodeType NodeType { get; }
	public string Value { get; set; }

	// Methods

	// RVA: 0x2212450 Offset: 0x2211850 VA: 0x182212450
	public void .ctor(string value) { }

	// RVA: 0x22123C0 Offset: 0x22117C0 VA: 0x1822123C0
	public void .ctor(XText other) { }

	// RVA: 0xABD0E0 Offset: 0xABC4E0 VA: 0x180ABD0E0 Slot: 7
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230
	public string get_Value() { }

	// RVA: 0x221B7A0 Offset: 0x221ABA0 VA: 0x18221B7A0
	public void set_Value(string value) { }

	// RVA: 0x221B6B0 Offset: 0x221AAB0 VA: 0x18221B6B0 Slot: 8
	public override void WriteTo(XmlWriter writer) { }

	// RVA: 0x221B5D0 Offset: 0x221A9D0 VA: 0x18221B5D0 Slot: 9
	internal override void AppendText(StringBuilder sb) { }

	// RVA: 0x221B600 Offset: 0x221AA00 VA: 0x18221B600 Slot: 10
	internal override XNode CloneNode() { }

}

public class XCData : XText // TypeDefIndex: 5832
{	// Properties
	public override XmlNodeType NodeType { get; }

	// Methods

	// RVA: 0x2212450 Offset: 0x2211850 VA: 0x182212450
	public void .ctor(string value) { }

	// RVA: 0x22123C0 Offset: 0x22117C0 VA: 0x1822123C0
	public void .ctor(XCData other) { }

	// RVA: 0xE32BD0 Offset: 0xE31FD0 VA: 0x180E32BD0 Slot: 7
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x2212330 Offset: 0x2211730 VA: 0x182212330 Slot: 8
	public override void WriteTo(XmlWriter writer) { }

	// RVA: 0x2212280 Offset: 0x2211680 VA: 0x182212280 Slot: 10
	internal override XNode CloneNode() { }

}

public abstract class XContainer : XNode // TypeDefIndex: 5833
{	// Fields
	internal object content; // 0x28

	// Properties
	public XNode LastNode { get; }

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	internal void .ctor() { }

	// RVA: 0x22163C0 Offset: 0x22157C0 VA: 0x1822163C0
	internal void .ctor(XContainer other) { }

	// RVA: 0x2216500 Offset: 0x2215900 VA: 0x182216500
	public XNode get_LastNode() { }

	// RVA: 0x2213610 Offset: 0x2212A10 VA: 0x182213610
	public void Add(object content) { }

	[IteratorStateMachineAttribute] // RVA: 0xE16D0 Offset: 0xE0AD0 VA: 0x1800E16D0
	// RVA: 0x22143A0 Offset: 0x22137A0 VA: 0x1822143A0
	public IEnumerable<XNode> Nodes() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 11
	internal virtual void AddAttribute(XAttribute a) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 12
	internal virtual void AddAttributeSkipNotify(XAttribute a) { }

	// RVA: 0x2212740 Offset: 0x2211B40 VA: 0x182212740
	internal void AddContentSkipNotify(object content) { }

	// RVA: 0x2212FC0 Offset: 0x22123C0 VA: 0x182212FC0
	internal void AddNode(XNode n) { }

	// RVA: 0x2212F20 Offset: 0x2212320 VA: 0x182212F20
	internal void AddNodeSkipNotify(XNode n) { }

	// RVA: 0x2213230 Offset: 0x2212630 VA: 0x182213230
	internal void AddString(string s) { }

	// RVA: 0x2213060 Offset: 0x2212460 VA: 0x182213060
	internal void AddStringSkipNotify(string s) { }

	// RVA: 0x2213B60 Offset: 0x2212F60 VA: 0x182213B60
	internal void AppendNode(XNode n) { }

	// RVA: 0x2213A60 Offset: 0x2212E60 VA: 0x182213A60
	internal void AppendNodeSkipNotify(XNode n) { }

	// RVA: 0x2213C90 Offset: 0x2213090 VA: 0x182213C90 Slot: 9
	internal override void AppendText(StringBuilder sb) { }

	// RVA: 0x2213D90 Offset: 0x2213190 VA: 0x182213D90
	internal void ConvertTextToNode() { }

	// RVA: 0x2213E80 Offset: 0x2213280 VA: 0x182213E80
	internal static string GetDateTimeString(DateTime value) { }

	// RVA: 0x2213EE0 Offset: 0x22132E0 VA: 0x182213EE0
	internal static string GetStringValue(object value) { }

	// RVA: 0x22153C0 Offset: 0x22147C0 VA: 0x1822153C0
	internal void ReadContentFrom(XmlReader r) { }

	// RVA: 0x2214410 Offset: 0x2213810 VA: 0x182214410
	internal void ReadContentFrom(XmlReader r, LoadOptions o) { }

	// RVA: 0x2216010 Offset: 0x2215410 VA: 0x182216010
	internal void RemoveNode(XNode n) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 13
	internal virtual void ValidateNode(XNode node, XNode previous) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 14
	internal virtual void ValidateString(string s) { }

	// RVA: 0x2216220 Offset: 0x2215620 VA: 0x182216220
	internal void WriteContentTo(XmlWriter writer) { }

}

private sealed class XContainer.<Nodes>d__18 : IEnumerable<XNode>, IEnumerable, IEnumerator<XNode>, IDisposable, IEnumerator // TypeDefIndex: 5834
{	// Fields
	private int <>1__state; // 0x10
	private XNode <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	public XContainer <>4__this; // 0x28
	private XNode <n>5__1; // 0x30

	// Properties
	private XNode System.Collections.Generic.IEnumerator<System.Xml.Linq.XNode>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xD824F0 Offset: 0xD818F0 VA: 0x180D824F0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x22114F0 Offset: 0x22108F0 VA: 0x1822114F0 Slot: 8
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 6
	private XNode System.Collections.Generic.IEnumerator<System.Xml.Linq.XNode>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x22117B0 Offset: 0x2210BB0 VA: 0x1822117B0 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2211710 Offset: 0x2210B10 VA: 0x182211710 Slot: 4
	private IEnumerator<XNode> System.Collections.Generic.IEnumerable<System.Xml.Linq.XNode>.GetEnumerator() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2211710 Offset: 0x2210B10 VA: 0x182211710 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

public class XElement : XContainer, IXmlSerializable // TypeDefIndex: 5836
{	// Fields
	internal XName name; // 0x30
	internal XAttribute lastAttr; // 0x38

	// Properties
	public bool IsEmpty { get; }
	public XName Name { get; }
	public override XmlNodeType NodeType { get; }
	public string Value { get; }

	// Methods

	// RVA: 0x2218F40 Offset: 0x2218340 VA: 0x182218F40
	public void .ctor(XName name) { }

	// RVA: 0x2218DC0 Offset: 0x22181C0 VA: 0x182218DC0
	public void .ctor(XElement other) { }

	// RVA: 0x2218FD0 Offset: 0x22183D0 VA: 0x182218FD0
	public void .ctor(XStreamingElement other) { }

	// RVA: 0x2219070 Offset: 0x2218470 VA: 0x182219070
	public bool get_IsEmpty() { }

	// RVA: 0x4A2EE0 Offset: 0x4A22E0 VA: 0x1804A2EE0
	public XName get_Name() { }

	// RVA: 0x5CB140 Offset: 0x5CA540 VA: 0x1805CB140 Slot: 7
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x2219080 Offset: 0x2218480 VA: 0x182219080
	public string get_Value() { }

	// RVA: 0x2217BA0 Offset: 0x2216FA0 VA: 0x182217BA0
	public XAttribute Attribute(XName name) { }

	// RVA: 0x2217BE0 Offset: 0x2216FE0 VA: 0x182217BE0
	public IEnumerable<XAttribute> Attributes() { }

	// RVA: 0x2217FD0 Offset: 0x22173D0 VA: 0x182217FD0
	public string GetPrefixOfNamespace(XNamespace ns) { }

	// RVA: 0x2218CF0 Offset: 0x22180F0 VA: 0x182218CF0 Slot: 8
	public override void WriteTo(XmlWriter writer) { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 15
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x2218920 Offset: 0x2217D20 VA: 0x182218920 Slot: 16
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0xE53EE0 Offset: 0xE532E0 VA: 0x180E53EE0 Slot: 17
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x2217730 Offset: 0x2216B30 VA: 0x182217730 Slot: 11
	internal override void AddAttribute(XAttribute a) { }

	// RVA: 0x22175B0 Offset: 0x22169B0 VA: 0x1822175B0 Slot: 12
	internal override void AddAttributeSkipNotify(XAttribute a) { }

	// RVA: 0x2217A20 Offset: 0x2216E20 VA: 0x182217A20
	internal void AppendAttribute(XAttribute a) { }

	// RVA: 0x22179A0 Offset: 0x2216DA0 VA: 0x1822179A0
	internal void AppendAttributeSkipNotify(XAttribute a) { }

	// RVA: 0x2217C70 Offset: 0x2217070 VA: 0x182217C70 Slot: 10
	internal override XNode CloneNode() { }

	[IteratorStateMachineAttribute] // RVA: 0xE5D00 Offset: 0xE5100 VA: 0x1800E5D00
	// RVA: 0x2217E20 Offset: 0x2217220 VA: 0x182217E20
	private IEnumerable<XAttribute> GetAttributes(XName name) { }

	// RVA: 0x2217EB0 Offset: 0x22172B0 VA: 0x182217EB0
	private string GetNamespaceOfPrefixInScope(string prefix, XElement outOfScope) { }

	// RVA: 0x2218220 Offset: 0x2217620 VA: 0x182218220
	private void ReadElementFrom(XmlReader r, LoadOptions o) { }

	// RVA: 0x22188A0 Offset: 0x2217CA0 VA: 0x1822188A0
	internal void SetEndElementLineInfo(int lineNumber, int linePosition) { }

	// RVA: 0x2218B10 Offset: 0x2217F10 VA: 0x182218B10 Slot: 13
	internal override void ValidateNode(XNode node, XNode previous) { }

}

private sealed class XElement.<GetAttributes>d__105 : IEnumerable<XAttribute>, IEnumerable, IEnumerator<XAttribute>, IDisposable, IEnumerator // TypeDefIndex: 5837
{	// Fields
	private int <>1__state; // 0x10
	private XAttribute <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	public XElement <>4__this; // 0x28
	private XAttribute <a>5__1; // 0x30
	private XName name; // 0x38
	public XName <>3__name; // 0x40

	// Properties
	private XAttribute System.Collections.Generic.IEnumerator<System.Xml.Linq.XAttribute>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xD824F0 Offset: 0xD818F0 VA: 0x180D824F0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x2211310 Offset: 0x2210710 VA: 0x182211310 Slot: 8
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 6
	private XAttribute System.Collections.Generic.IEnumerator<System.Xml.Linq.XAttribute>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x22114A0 Offset: 0x22108A0 VA: 0x1822114A0 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x22113F0 Offset: 0x22107F0 VA: 0x1822113F0 Slot: 4
	private IEnumerator<XAttribute> System.Collections.Generic.IEnumerable<System.Xml.Linq.XAttribute>.GetEnumerator() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x22113F0 Offset: 0x22107F0 VA: 0x1822113F0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

public class XDocument : XContainer // TypeDefIndex: 5843
{	// Fields
	private XDeclaration declaration; // 0x30

	// Properties
	public XDeclaration Declaration { get; set; }
	public override XmlNodeType NodeType { get; }
	public XElement Root { get; }

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x2217490 Offset: 0x2216890 VA: 0x182217490
	public void .ctor(XDocument other) { }

	// RVA: 0x4A2EE0 Offset: 0x4A22E0 VA: 0x1804A2EE0
	public XDeclaration get_Declaration() { }

	// RVA: 0x4A2F10 Offset: 0x4A2310 VA: 0x1804A2F10
	public void set_Declaration(XDeclaration value) { }

	// RVA: 0xE61370 Offset: 0xE60770 VA: 0x180E61370 Slot: 7
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x2217570 Offset: 0x2216970 VA: 0x182217570
	public XElement get_Root() { }

	// RVA: 0x2217370 Offset: 0x2216770 VA: 0x182217370 Slot: 8
	public override void WriteTo(XmlWriter writer) { }

	// RVA: 0x2216CF0 Offset: 0x22160F0 VA: 0x182216CF0 Slot: 11
	internal override void AddAttribute(XAttribute a) { }

	// RVA: 0x2216C80 Offset: 0x2216080 VA: 0x182216C80 Slot: 12
	internal override void AddAttributeSkipNotify(XAttribute a) { }

	// RVA: 0x2216D60 Offset: 0x2216160 VA: 0x182216D60 Slot: 10
	internal override XNode CloneNode() { }

	// RVA: -1 Offset: -1
	private T GetFirstNode<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBDBE80 Offset: 0xBDB280 VA: 0x180BDBE80
	|-XDocument.GetFirstNode<object>
	|-XDocument.GetFirstNode<XElement>
	*/

	// RVA: 0x2216E70 Offset: 0x2216270 VA: 0x182216E70
	internal static bool IsWhitespace(string s) { }

	// RVA: 0x2217020 Offset: 0x2216420 VA: 0x182217020 Slot: 13
	internal override void ValidateNode(XNode node, XNode previous) { }

	// RVA: 0x2216EF0 Offset: 0x22162F0 VA: 0x182216EF0
	private void ValidateDocument(XNode previous, XmlNodeType allowBefore, XmlNodeType allowAfter) { }

	// RVA: 0x22172B0 Offset: 0x22166B0 VA: 0x1822172B0 Slot: 14
	internal override void ValidateString(string s) { }

}

public class XComment : XNode // TypeDefIndex: 5844
{	// Fields
	internal string value; // 0x28

	// Properties
	public override XmlNodeType NodeType { get; }
	public string Value { get; }

	// Methods

	// RVA: 0x22126B0 Offset: 0x2211AB0 VA: 0x1822126B0
	public void .ctor(string value) { }

	// RVA: 0x2212620 Offset: 0x2211A20 VA: 0x182212620
	public void .ctor(XComment other) { }

	// RVA: 0x8B0DD0 Offset: 0x8B01D0 VA: 0x1808B0DD0 Slot: 7
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230
	public string get_Value() { }

	// RVA: 0x2212590 Offset: 0x2211990 VA: 0x182212590 Slot: 8
	public override void WriteTo(XmlWriter writer) { }

	// RVA: 0x22124E0 Offset: 0x22118E0 VA: 0x1822124E0 Slot: 10
	internal override XNode CloneNode() { }

}

public class XProcessingInstruction : XNode // TypeDefIndex: 5845
{	// Fields
	internal string target; // 0x28
	internal string data; // 0x30

	// Properties
	public string Data { get; }
	public override XmlNodeType NodeType { get; }
	public string Target { get; }

	// Methods

	// RVA: 0x221B3B0 Offset: 0x221A7B0 VA: 0x18221B3B0
	public void .ctor(string target, string data) { }

	// RVA: 0x221B530 Offset: 0x221A930 VA: 0x18221B530
	public void .ctor(XProcessingInstruction other) { }

	// RVA: 0x4A2EE0 Offset: 0x4A22E0 VA: 0x1804A2EE0
	public string get_Data() { }

	// RVA: 0xB9B120 Offset: 0xB9A520 VA: 0x180B9B120 Slot: 7
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230
	public string get_Target() { }

	// RVA: 0x221B320 Offset: 0x221A720 VA: 0x18221B320 Slot: 8
	public override void WriteTo(XmlWriter writer) { }

	// RVA: 0x221B170 Offset: 0x221A570 VA: 0x18221B170 Slot: 10
	internal override XNode CloneNode() { }

	// RVA: 0x221B230 Offset: 0x221A630 VA: 0x18221B230
	private static void ValidateName(string name) { }

}

public class XDeclaration // TypeDefIndex: 5846
{	// Fields
	private string version; // 0x10
	private string encoding; // 0x18
	private string standalone; // 0x20

	// Properties
	public string Encoding { get; }
	public string Standalone { get; }
	public string Version { get; }

	// Methods

	// RVA: 0x146E710 Offset: 0x146DB10 VA: 0x18146E710
	public void .ctor(string version, string encoding, string standalone) { }

	// RVA: 0x22167E0 Offset: 0x2215BE0 VA: 0x1822167E0
	public void .ctor(XDeclaration other) { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public string get_Encoding() { }

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	public string get_Standalone() { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public string get_Version() { }

	// RVA: 0x2216690 Offset: 0x2215A90 VA: 0x182216690 Slot: 3
	public override string ToString() { }

}

public class XDocumentType : XNode // TypeDefIndex: 5847
{	// Fields
	private string name; // 0x28
	private string publicId; // 0x30
	private string systemId; // 0x38
	private string internalSubset; // 0x40
	private IDtdInfo dtdInfo; // 0x48

	// Properties
	public string InternalSubset { get; }
	public string Name { get; }
	public override XmlNodeType NodeType { get; }
	public string PublicId { get; }
	public string SystemId { get; }

	// Methods

	// RVA: 0x2216BC0 Offset: 0x2215FC0 VA: 0x182216BC0
	public void .ctor(string name, string publicId, string systemId, string internalSubset) { }

	// RVA: 0x2216A20 Offset: 0x2215E20 VA: 0x182216A20
	public void .ctor(XDocumentType other) { }

	// RVA: 0x2216AF0 Offset: 0x2215EF0 VA: 0x182216AF0
	internal void .ctor(string name, string publicId, string systemId, string internalSubset, IDtdInfo dtdInfo) { }

	// RVA: 0x4B9440 Offset: 0x4B8840 VA: 0x1804B9440
	public string get_InternalSubset() { }

	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230
	public string get_Name() { }

	// RVA: 0x4A2F20 Offset: 0x4A2320 VA: 0x1804A2F20 Slot: 7
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x4A2EE0 Offset: 0x4A22E0 VA: 0x1804A2EE0
	public string get_PublicId() { }

	// RVA: 0x5DCC00 Offset: 0x5DC000 VA: 0x1805DCC00
	public string get_SystemId() { }

	// RVA: 0x2216980 Offset: 0x2215D80 VA: 0x182216980 Slot: 8
	public override void WriteTo(XmlWriter writer) { }

	// RVA: 0x2216890 Offset: 0x2215C90 VA: 0x182216890 Slot: 10
	internal override XNode CloneNode() { }

}

public class XAttribute : XObject // TypeDefIndex: 5848
{	// Fields
	internal XAttribute next; // 0x20
	internal XName name; // 0x28
	internal string value; // 0x30

	// Properties
	public bool IsNamespaceDeclaration { get; }
	public XName Name { get; }
	public override XmlNodeType NodeType { get; }
	public string Value { get; }

	// Methods

	// RVA: 0x2212060 Offset: 0x2211460 VA: 0x182212060
	public void .ctor(XName name, object value) { }

	// RVA: 0x2212160 Offset: 0x2211560 VA: 0x182212160
	public void .ctor(XAttribute other) { }

	// RVA: 0x2212200 Offset: 0x2211600 VA: 0x182212200
	public bool get_IsNamespaceDeclaration() { }

	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230
	public XName get_Name() { }

	// RVA: 0x54B2D0 Offset: 0x54A6D0 VA: 0x18054B2D0 Slot: 7
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x4A2EE0 Offset: 0x4A22E0 VA: 0x1804A2EE0
	public string get_Value() { }

	// RVA: 0x2211950 Offset: 0x2210D50 VA: 0x182211950 Slot: 3
	public override string ToString() { }

	// RVA: 0x2211800 Offset: 0x2210C00 VA: 0x182211800
	internal string GetPrefixOfNamespace(XNamespace ns) { }

	// RVA: 0x2211CF0 Offset: 0x22110F0 VA: 0x182211CF0
	private static void ValidateAttribute(XName name, string value) { }

}

public class XStreamingElement // TypeDefIndex: 5849
{	// Fields
	internal XName name; // 0x10
	internal object content; // 0x18

}

internal class XmlDocumentWrapper : XmlNodeWrapper, IXmlDocument, IXmlNode // TypeDefIndex: 6111
{	// Fields
	private readonly XmlDocument _document; // 0x28

	// Properties
	public IXmlElement DocumentElement { get; }

	// Methods

	// RVA: 0xF9BA60 Offset: 0xF9AE60 VA: 0x180F9BA60
	public void .ctor(XmlDocument document) { }

	// RVA: 0xF9BD90 Offset: 0xF9B190 VA: 0x180F9BD90 Slot: 15
	public IXmlNode CreateComment(string data) { }

	// RVA: 0xF9C080 Offset: 0xF9B480 VA: 0x180F9C080 Slot: 16
	public IXmlNode CreateTextNode(string text) { }

	// RVA: 0xF9BD00 Offset: 0xF9B100 VA: 0x180F9BD00 Slot: 17
	public IXmlNode CreateCDataSection(string data) { }

	// RVA: 0xF9C110 Offset: 0xF9B510 VA: 0x180F9C110 Slot: 18
	public IXmlNode CreateWhitespace(string text) { }

	// RVA: 0xF9BFF0 Offset: 0xF9B3F0 VA: 0x180F9BFF0 Slot: 19
	public IXmlNode CreateSignificantWhitespace(string text) { }

	// RVA: 0xF9C1A0 Offset: 0xF9B5A0 VA: 0x180F9C1A0 Slot: 20
	public IXmlNode CreateXmlDeclaration(string version, string encoding, string standalone) { }

	// RVA: 0xF9C260 Offset: 0xF9B660 VA: 0x180F9C260 Slot: 21
	public IXmlNode CreateXmlDocumentType(string name, string publicId, string systemId, string internalSubset) { }

	// RVA: 0xF9BF50 Offset: 0xF9B350 VA: 0x180F9BF50 Slot: 22
	public IXmlNode CreateProcessingInstruction(string target, string data) { }

	// RVA: 0xF9BEC0 Offset: 0xF9B2C0 VA: 0x180F9BEC0 Slot: 23
	public IXmlElement CreateElement(string elementName) { }

	// RVA: 0xF9BE20 Offset: 0xF9B220 VA: 0x180F9BE20 Slot: 24
	public IXmlElement CreateElement(string qualifiedName, string namespaceUri) { }

	// RVA: 0xF9BB80 Offset: 0xF9AF80 VA: 0x180F9BB80 Slot: 25
	public IXmlNode CreateAttribute(string name, string value) { }

	// RVA: 0xF9BC40 Offset: 0xF9B040 VA: 0x180F9BC40 Slot: 26
	public IXmlNode CreateAttribute(string qualifiedName, string namespaceUri, string value) { }

	// RVA: 0xF9C330 Offset: 0xF9B730 VA: 0x180F9C330 Slot: 27
	public IXmlElement get_DocumentElement() { }

}

internal class XmlElementWrapper : XmlNodeWrapper, IXmlElement, IXmlNode // TypeDefIndex: 6112
{	// Fields
	private readonly XmlElement _element; // 0x28

	// Properties
	public bool IsEmpty { get; }

	// Methods

	// RVA: 0xF9BA60 Offset: 0xF9AE60 VA: 0x180F9BA60
	public void .ctor(XmlElement element) { }

	// RVA: 0xF9C410 Offset: 0xF9B810 VA: 0x180F9C410 Slot: 15
	public void SetAttributeNode(IXmlNode attribute) { }

	// RVA: 0xF9C3E0 Offset: 0xF9B7E0 VA: 0x180F9C3E0 Slot: 16
	public string GetPrefixOfNamespace(string namespaceUri) { }

	// RVA: 0xF9C510 Offset: 0xF9B910 VA: 0x180F9C510 Slot: 17
	public bool get_IsEmpty() { }

}

internal class XmlDeclarationWrapper : XmlNodeWrapper, IXmlDeclaration, IXmlNode // TypeDefIndex: 6113
{	// Fields
	private readonly XmlDeclaration _declaration; // 0x28

	// Properties
	public string Version { get; }
	public string Encoding { get; }
	public string Standalone { get; }

	// Methods

	// RVA: 0xF9BA60 Offset: 0xF9AE60 VA: 0x180F9BA60
	public void .ctor(XmlDeclaration declaration) { }

	// RVA: 0xF9BAE0 Offset: 0xF9AEE0 VA: 0x180F9BAE0 Slot: 15
	public string get_Version() { }

	// RVA: 0xF9BAA0 Offset: 0xF9AEA0 VA: 0x180F9BAA0 Slot: 16
	public string get_Encoding() { }

	// RVA: 0xF9BAC0 Offset: 0xF9AEC0 VA: 0x180F9BAC0 Slot: 17
	public string get_Standalone() { }

}

internal class XmlDocumentTypeWrapper : XmlNodeWrapper, IXmlDocumentType, IXmlNode // TypeDefIndex: 6114
{	// Fields
	private readonly XmlDocumentType _documentType; // 0x28

	// Properties
	public string Name { get; }
	public string System { get; }
	public string Public { get; }
	public string InternalSubset { get; }
	public override string LocalName { get; }

	// Methods

	// RVA: 0xF9BA60 Offset: 0xF9AE60 VA: 0x180F9BA60
	public void .ctor(XmlDocumentType documentType) { }

	// RVA: 0xF9BB50 Offset: 0xF9AF50 VA: 0x180F9BB50 Slot: 15
	public string get_Name() { }

	// RVA: 0xF9BAC0 Offset: 0xF9AEC0 VA: 0x180F9BAC0 Slot: 16
	public string get_System() { }

	// RVA: 0xF9BAA0 Offset: 0xF9AEA0 VA: 0x180F9BAA0 Slot: 17
	public string get_Public() { }

	// RVA: 0xF9BB00 Offset: 0xF9AF00 VA: 0x180F9BB00 Slot: 18
	public string get_InternalSubset() { }

	// RVA: 0xF9BB20 Offset: 0xF9AF20 VA: 0x180F9BB20 Slot: 13
	public override string get_LocalName() { }

}

internal class XmlNodeWrapper : IXmlNode // TypeDefIndex: 6115
{	// Fields
	private readonly XmlNode _node; // 0x10
	private List<IXmlNode> _childNodes; // 0x18
	private List<IXmlNode> _attributes; // 0x20

	// Properties
	public object WrappedNode { get; }
	public XmlNodeType NodeType { get; }
	public virtual string LocalName { get; }
	public List<IXmlNode> ChildNodes { get; }
	public List<IXmlNode> Attributes { get; }
	public IXmlNode ParentNode { get; }
	public string Value { get; set; }
	public string NamespaceUri { get; }

	// Methods

	// RVA: 0x6C0000 Offset: 0x6BF400 VA: 0x1806C0000
	public void .ctor(XmlNode node) { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460 Slot: 12
	public object get_WrappedNode() { }

	// RVA: 0xBC42E0 Offset: 0xBC36E0 VA: 0x180BC42E0 Slot: 4
	public XmlNodeType get_NodeType() { }

	// RVA: 0xBC4250 Offset: 0xBC3650 VA: 0x180BC4250 Slot: 13
	public virtual string get_LocalName() { }

	// RVA: 0xFA27C0 Offset: 0xFA1BC0 VA: 0x180FA27C0 Slot: 6
	public List<IXmlNode> get_ChildNodes() { }

	// RVA: 0xFA2130 Offset: 0xFA1530 VA: 0x180FA2130
	internal static IXmlNode WrapNode(XmlNode node) { }

	// RVA: 0xFA2320 Offset: 0xFA1720 VA: 0x180FA2320 Slot: 7
	public List<IXmlNode> get_Attributes() { }

	// RVA: 0xFA2C30 Offset: 0xFA2030 VA: 0x180FA2C30 Slot: 8
	public IXmlNode get_ParentNode() { }

	// RVA: 0xBC4280 Offset: 0xBC3680 VA: 0x180BC4280 Slot: 9
	public string get_Value() { }

	// RVA: 0xFA2D70 Offset: 0xFA2170 VA: 0x180FA2D70 Slot: 14
	public void set_Value(string value) { }

	// RVA: 0xFA2060 Offset: 0xFA1460 VA: 0x180FA2060 Slot: 10
	public IXmlNode AppendChild(IXmlNode newChild) { }

	// RVA: 0xB9A5D0 Offset: 0xB999D0 VA: 0x180B9A5D0 Slot: 11
	public string get_NamespaceUri() { }

}

internal class XDeclarationWrapper : XObjectWrapper, IXmlDeclaration, IXmlNode // TypeDefIndex: 6121
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private XDeclaration <Declaration>k__BackingField; // 0x18

	// Properties
	internal XDeclaration Declaration { get; set; }
	public override XmlNodeType NodeType { get; }
	public string Version { get; }
	public string Encoding { get; }
	public string Standalone { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	internal XDeclaration get_Declaration() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4D0180 Offset: 0x4CF580 VA: 0x1804D0180
	private void set_Declaration(XDeclaration value) { }

	// RVA: 0xF9A190 Offset: 0xF99590 VA: 0x180F9A190
	public void .ctor(XDeclaration declaration) { }

	// RVA: 0xE5C8E0 Offset: 0xE5BCE0 VA: 0x180E5C8E0 Slot: 13
	public override XmlNodeType get_NodeType() { }

	// RVA: 0xE51E50 Offset: 0xE51250 VA: 0x180E51E50 Slot: 21
	public string get_Version() { }

	// RVA: 0x8FB8A0 Offset: 0x8FACA0 VA: 0x1808FB8A0 Slot: 22
	public string get_Encoding() { }

	// RVA: 0xE51D90 Offset: 0xE51190 VA: 0x180E51D90 Slot: 23
	public string get_Standalone() { }

}

internal class XDocumentTypeWrapper : XObjectWrapper, IXmlDocumentType, IXmlNode // TypeDefIndex: 6122
{	// Fields
	private readonly XDocumentType _documentType; // 0x18

	// Properties
	public string Name { get; }
	public string System { get; }
	public string Public { get; }
	public string InternalSubset { get; }
	public override string LocalName { get; }

	// Methods

	// RVA: 0xF9A210 Offset: 0xF99610 VA: 0x180F9A210
	public void .ctor(XDocumentType documentType) { }

	// RVA: 0xF9A2E0 Offset: 0xF996E0 VA: 0x180F9A2E0 Slot: 21
	public string get_Name() { }

	// RVA: 0xE51DB0 Offset: 0xE511B0 VA: 0x180E51DB0 Slot: 22
	public string get_System() { }

	// RVA: 0x8FB880 Offset: 0x8FAC80 VA: 0x1808FB880 Slot: 23
	public string get_Public() { }

	// RVA: 0xF9A290 Offset: 0xF99690 VA: 0x180F9A290 Slot: 24
	public string get_InternalSubset() { }

	// RVA: 0xF9A2B0 Offset: 0xF996B0 VA: 0x180F9A2B0 Slot: 14
	public override string get_LocalName() { }

}

internal class XDocumentWrapper : XContainerWrapper, IXmlDocument, IXmlNode // TypeDefIndex: 6123
{	// Properties
	private XDocument Document { get; }
	public override List<IXmlNode> ChildNodes { get; }
	public IXmlElement DocumentElement { get; }

	// Methods

	// RVA: 0xF9ADD0 Offset: 0xF9A1D0 VA: 0x180F9ADD0
	private XDocument get_Document() { }

	// RVA: 0xF99E30 Offset: 0xF99230 VA: 0x180F99E30
	public void .ctor(XDocument document) { }

	// RVA: 0xF9AC40 Offset: 0xF9A040 VA: 0x180F9AC40 Slot: 15
	public override List<IXmlNode> get_ChildNodes() { }

	// RVA: 0xF9A680 Offset: 0xF99A80 VA: 0x180F9A680 Slot: 21
	public IXmlNode CreateComment(string text) { }

	// RVA: 0xF9AA00 Offset: 0xF99E00 VA: 0x180F9AA00 Slot: 22
	public IXmlNode CreateTextNode(string text) { }

	// RVA: 0xF9A600 Offset: 0xF99A00 VA: 0x180F9A600 Slot: 23
	public IXmlNode CreateCDataSection(string data) { }

	// RVA: 0xF9AA80 Offset: 0xF99E80 VA: 0x180F9AA80 Slot: 24
	public IXmlNode CreateWhitespace(string text) { }

	// RVA: 0xF9A980 Offset: 0xF99D80 VA: 0x180F9A980 Slot: 25
	public IXmlNode CreateSignificantWhitespace(string text) { }

	// RVA: 0xF9AB00 Offset: 0xF99F00 VA: 0x180F9AB00 Slot: 26
	public IXmlNode CreateXmlDeclaration(string version, string encoding, string standalone) { }

	// RVA: 0xF9ABA0 Offset: 0xF99FA0 VA: 0x180F9ABA0 Slot: 27
	public IXmlNode CreateXmlDocumentType(string name, string publicId, string systemId, string internalSubset) { }

	// RVA: 0xF9A8B0 Offset: 0xF99CB0 VA: 0x180F9A8B0 Slot: 28
	public IXmlNode CreateProcessingInstruction(string target, string data) { }

	// RVA: 0xF9A7E0 Offset: 0xF99BE0 VA: 0x180F9A7E0 Slot: 29
	public IXmlElement CreateElement(string elementName) { }

	// RVA: 0xF9A700 Offset: 0xF99B00 VA: 0x180F9A700 Slot: 30
	public IXmlElement CreateElement(string qualifiedName, string namespaceUri) { }

	// RVA: 0xF9A520 Offset: 0xF99920 VA: 0x180F9A520 Slot: 31
	public IXmlNode CreateAttribute(string name, string value) { }

	// RVA: 0xF9A430 Offset: 0xF99830 VA: 0x180F9A430 Slot: 32
	public IXmlNode CreateAttribute(string qualifiedName, string namespaceUri, string value) { }

	// RVA: 0xF9AD30 Offset: 0xF9A130 VA: 0x180F9AD30 Slot: 33
	public IXmlElement get_DocumentElement() { }

	// RVA: 0xF9A300 Offset: 0xF99700 VA: 0x180F9A300 Slot: 19
	public override IXmlNode AppendChild(IXmlNode newChild) { }

}

internal class XTextWrapper : XObjectWrapper // TypeDefIndex: 6124
{	// Properties
	private XText Text { get; }
	public override string Value { get; }
	public override IXmlNode ParentNode { get; }

	// Methods

	// RVA: 0xF9B9C0 Offset: 0xF9ADC0 VA: 0x180F9B9C0
	private XText get_Text() { }

	// RVA: 0xF9B8F0 Offset: 0xF9ACF0 VA: 0x180F9B8F0
	public void .ctor(XText text) { }

	// RVA: 0xF9BA40 Offset: 0xF9AE40 VA: 0x180F9BA40 Slot: 18
	public override string get_Value() { }

	// RVA: 0xF9B960 Offset: 0xF9AD60 VA: 0x180F9B960 Slot: 17
	public override IXmlNode get_ParentNode() { }

}

internal class XCommentWrapper : XObjectWrapper // TypeDefIndex: 6125
{	// Properties
	private XComment Text { get; }
	public override string Value { get; }
	public override IXmlNode ParentNode { get; }

	// Methods

	// RVA: 0xF99640 Offset: 0xF98A40 VA: 0x180F99640
	private XComment get_Text() { }

	// RVA: 0xF99570 Offset: 0xF98970 VA: 0x180F99570
	public void .ctor(XComment text) { }

	// RVA: 0xF996C0 Offset: 0xF98AC0 VA: 0x180F996C0 Slot: 18
	public override string get_Value() { }

	// RVA: 0xF995E0 Offset: 0xF989E0 VA: 0x180F995E0 Slot: 17
	public override IXmlNode get_ParentNode() { }

}

internal class XProcessingInstructionWrapper : XObjectWrapper // TypeDefIndex: 6126
{	// Properties
	private XProcessingInstruction ProcessingInstruction { get; }
	public override string LocalName { get; }
	public override string Value { get; }

	// Methods

	// RVA: 0xF9B850 Offset: 0xF9AC50 VA: 0x180F9B850
	private XProcessingInstruction get_ProcessingInstruction() { }

	// RVA: 0xF9B7C0 Offset: 0xF9ABC0 VA: 0x180F9B7C0
	public void .ctor(XProcessingInstruction processingInstruction) { }

	// RVA: 0xF9B830 Offset: 0xF9AC30 VA: 0x180F9B830 Slot: 14
	public override string get_LocalName() { }

	// RVA: 0xF9B8D0 Offset: 0xF9ACD0 VA: 0x180F9B8D0 Slot: 18
	public override string get_Value() { }

}

internal class XContainerWrapper : XObjectWrapper // TypeDefIndex: 6127
{	// Fields
	private List<IXmlNode> _childNodes; // 0x18

	// Properties
	private XContainer Container { get; }
	public override List<IXmlNode> ChildNodes { get; }
	public override IXmlNode ParentNode { get; }

	// Methods

	// RVA: 0xF9A0B0 Offset: 0xF994B0 VA: 0x180F9A0B0
	private XContainer get_Container() { }

	// RVA: 0xF99E30 Offset: 0xF99230 VA: 0x180F99E30
	public void .ctor(XContainer container) { }

	// RVA: 0xF99EA0 Offset: 0xF992A0 VA: 0x180F99EA0 Slot: 15
	public override List<IXmlNode> get_ChildNodes() { }

	// RVA: 0xF9A130 Offset: 0xF99530 VA: 0x180F9A130 Slot: 17
	public override IXmlNode get_ParentNode() { }

	// RVA: 0xF99780 Offset: 0xF98B80 VA: 0x180F99780
	internal static IXmlNode WrapNode(XObject node) { }

	// RVA: 0xF996E0 Offset: 0xF98AE0 VA: 0x180F996E0 Slot: 19
	public override IXmlNode AppendChild(IXmlNode newChild) { }

}

internal class XObjectWrapper : IXmlNode // TypeDefIndex: 6128
{	// Fields
	private static readonly List<IXmlNode> EmptyChildNodes; // 0x0
	private readonly XObject _xmlObject; // 0x10

	// Properties
	public object WrappedNode { get; }
	public virtual XmlNodeType NodeType { get; }
	public virtual string LocalName { get; }
	public virtual List<IXmlNode> ChildNodes { get; }
	public virtual List<IXmlNode> Attributes { get; }
	public virtual IXmlNode ParentNode { get; }
	public virtual string Value { get; }
	public virtual string NamespaceUri { get; }

	// Methods

	// RVA: 0x6C0000 Offset: 0x6BF400 VA: 0x1806C0000
	public void .ctor(XObject xmlObject) { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460 Slot: 12
	public object get_WrappedNode() { }

	// RVA: 0xBC4280 Offset: 0xBC3680 VA: 0x180BC4280 Slot: 13
	public virtual XmlNodeType get_NodeType() { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 14
	public virtual string get_LocalName() { }

	// RVA: 0xF9B760 Offset: 0xF9AB60 VA: 0x180F9B760 Slot: 15
	public virtual List<IXmlNode> get_ChildNodes() { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 16
	public virtual List<IXmlNode> get_Attributes() { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 17
	public virtual IXmlNode get_ParentNode() { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 18
	public virtual string get_Value() { }

	// RVA: 0xF9B6B0 Offset: 0xF9AAB0 VA: 0x180F9B6B0 Slot: 19
	public virtual IXmlNode AppendChild(IXmlNode newChild) { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 20
	public virtual string get_NamespaceUri() { }

	// RVA: 0xF9B700 Offset: 0xF9AB00 VA: 0x180F9B700
	private static void .cctor() { }

}

internal class XAttributeWrapper : XObjectWrapper // TypeDefIndex: 6129
{	// Properties
	private XAttribute Attribute { get; }
	public override string Value { get; }
	public override string LocalName { get; }
	public override string NamespaceUri { get; }
	public override IXmlNode ParentNode { get; }

	// Methods

	// RVA: 0xF99410 Offset: 0xF98810 VA: 0x180F99410
	private XAttribute get_Attribute() { }

	// RVA: 0xF993A0 Offset: 0xF987A0 VA: 0x180F993A0
	public void .ctor(XAttribute attribute) { }

	// RVA: 0xF99550 Offset: 0xF98950 VA: 0x180F99550 Slot: 18
	public override string get_Value() { }

	// RVA: 0xF99490 Offset: 0xF98890 VA: 0x180F99490 Slot: 14
	public override string get_LocalName() { }

	// RVA: 0xF994C0 Offset: 0xF988C0 VA: 0x180F994C0 Slot: 20
	public override string get_NamespaceUri() { }

	// RVA: 0xF994F0 Offset: 0xF988F0 VA: 0x180F994F0 Slot: 17
	public override IXmlNode get_ParentNode() { }

}

internal class XElementWrapper : XContainerWrapper, IXmlElement, IXmlNode // TypeDefIndex: 6130
{	// Fields
	private List<IXmlNode> _attributes; // 0x20

	// Properties
	private XElement Element { get; }
	public override List<IXmlNode> Attributes { get; }
	public override string Value { get; }
	public override string LocalName { get; }
	public override string NamespaceUri { get; }
	public bool IsEmpty { get; }

	// Methods

	// RVA: 0xF9B570 Offset: 0xF9A970 VA: 0x180F9B570
	private XElement get_Element() { }

	// RVA: 0xF99E30 Offset: 0xF99230 VA: 0x180F99E30
	public void .ctor(XElement element) { }

	// RVA: 0xF9AF40 Offset: 0xF9A340 VA: 0x180F9AF40 Slot: 21
	public void SetAttributeNode(IXmlNode attribute) { }

	// RVA: 0xF9B010 Offset: 0xF9A410 VA: 0x180F9B010 Slot: 16
	public override List<IXmlNode> get_Attributes() { }

	// RVA: 0xF9AE50 Offset: 0xF9A250 VA: 0x180F9AE50 Slot: 19
	public override IXmlNode AppendChild(IXmlNode newChild) { }

	// RVA: 0xF9B680 Offset: 0xF9AA80 VA: 0x180F9B680 Slot: 18
	public override string get_Value() { }

	// RVA: 0xF9B620 Offset: 0xF9AA20 VA: 0x180F9B620 Slot: 14
	public override string get_LocalName() { }

	// RVA: 0xF9B650 Offset: 0xF9AA50 VA: 0x180F9B650 Slot: 20
	public override string get_NamespaceUri() { }

	// RVA: 0xF9AEF0 Offset: 0xF9A2F0 VA: 0x180F9AEF0 Slot: 22
	public string GetPrefixOfNamespace(string namespaceUri) { }

	// RVA: 0xF9B5F0 Offset: 0xF9A9F0 VA: 0x180F9B5F0 Slot: 23
	public bool get_IsEmpty() { }

}

public class XmlNodeConverter : JsonConverter // TypeDefIndex: 6131
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <DeserializeRootElementName>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <WriteArrayAttribute>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <OmitRootObject>k__BackingField; // 0x19

	// Properties
	public string DeserializeRootElementName { get; }
	public bool WriteArrayAttribute { get; }
	public bool OmitRootObject { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public string get_DeserializeRootElementName() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x95B2D0 Offset: 0x95A6D0 VA: 0x18095B2D0
	public bool get_WriteArrayAttribute() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xFA2050 Offset: 0xFA1450 VA: 0x180FA2050
	public bool get_OmitRootObject() { }

	// RVA: 0xFA1F30 Offset: 0xFA1330 VA: 0x180FA1F30 Slot: 4
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0xFA1DC0 Offset: 0xFA11C0 VA: 0x180FA1DC0
	private IXmlNode WrapXml(object value) { }

	// RVA: 0xF9F5D0 Offset: 0xF9E9D0 VA: 0x180F9F5D0
	private void PushParentNamespaces(IXmlNode node, XmlNamespaceManager manager) { }

	// RVA: 0xFA0A70 Offset: 0xF9FE70 VA: 0x180FA0A70
	private string ResolveFullName(IXmlNode node, XmlNamespaceManager manager) { }

	// RVA: 0xF9F020 Offset: 0xF9E420 VA: 0x180F9F020
	private string GetPropertyName(IXmlNode node, XmlNamespaceManager manager) { }

	// RVA: 0xF9F2E0 Offset: 0xF9E6E0 VA: 0x180F9F2E0
	private bool IsArray(IXmlNode node) { }

	// RVA: 0xFA0C00 Offset: 0xFA0000 VA: 0x180FA0C00
	private void SerializeGroupedNodes(JsonWriter writer, IXmlNode node, XmlNamespaceManager manager, bool writePropertyName) { }

	// RVA: 0xFA1030 Offset: 0xFA0430 VA: 0x180FA1030
	private void SerializeNode(JsonWriter writer, IXmlNode node, XmlNamespaceManager manager, bool writePropertyName) { }

	// RVA: 0xF9C880 Offset: 0xF9BC80 VA: 0x180F9C880
	private static bool AllSameName(IXmlNode node) { }

	// RVA: 0xFA0580 Offset: 0xF9F980 VA: 0x180FA0580 Slot: 5
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0xF9ED10 Offset: 0xF9E110 VA: 0x180F9ED10
	private void DeserializeValue(JsonReader reader, IXmlDocument document, XmlNamespaceManager manager, string propertyName, IXmlNode currentNode) { }

	// RVA: 0xFA02F0 Offset: 0xF9F6F0 VA: 0x180FA02F0
	private void ReadElement(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string propertyName, XmlNamespaceManager manager) { }

	// RVA: 0xF9D620 Offset: 0xF9CA20 VA: 0x180F9D620
	private void CreateElement(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string elementName, XmlNamespaceManager manager, string elementPrefix, Dictionary<string, string> attributeNameValues) { }

	// RVA: 0xF9C530 Offset: 0xF9B930 VA: 0x180F9C530
	private static void AddAttribute(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string attributeName, XmlNamespaceManager manager, string attributePrefix) { }

	// RVA: 0xF9CB20 Offset: 0xF9BF20 VA: 0x180F9CB20
	private string ConvertTokenToXmlValue(JsonReader reader) { }

	// RVA: 0xF9FA50 Offset: 0xF9EE50 VA: 0x180F9FA50
	private void ReadArrayElements(JsonReader reader, IXmlDocument document, string propertyName, IXmlNode currentNode, XmlNamespaceManager manager) { }

	// RVA: 0xF9C6D0 Offset: 0xF9BAD0 VA: 0x180F9C6D0
	private void AddJsonArrayAttribute(IXmlElement element, IXmlDocument document) { }

	// RVA: 0xF9FCF0 Offset: 0xF9F0F0 VA: 0x180F9FCF0
	private Dictionary<string, string> ReadAttributeElements(JsonReader reader, XmlNamespaceManager manager) { }

	// RVA: 0xF9DAA0 Offset: 0xF9CEA0 VA: 0x180F9DAA0
	private void CreateInstruction(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string propertyName) { }

	// RVA: 0xF9D1B0 Offset: 0xF9C5B0 VA: 0x180F9D1B0
	private void CreateDocumentType(JsonReader reader, IXmlDocument document, IXmlNode currentNode) { }

	// RVA: 0xF9D510 Offset: 0xF9C910 VA: 0x180F9D510
	private IXmlElement CreateElement(string elementName, IXmlDocument document, string elementPrefix, XmlNamespaceManager manager) { }

	// RVA: 0xF9DDD0 Offset: 0xF9D1D0 VA: 0x180F9DDD0
	private void DeserializeNode(JsonReader reader, IXmlDocument document, XmlNamespaceManager manager, IXmlNode currentNode) { }

	// RVA: 0xF9F4F0 Offset: 0xF9E8F0 VA: 0x180F9F4F0
	private bool IsNamespaceAttribute(string attributeName, out string prefix) { }

	// RVA: 0xFA1C50 Offset: 0xFA1050 VA: 0x180FA1C50
	private bool ValueAttributes(List<IXmlNode> c) { }

	// RVA: 0xF9CA30 Offset: 0xF9BE30 VA: 0x180F9CA30 Slot: 6
	public override bool CanConvert(Type valueType) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

public class XORSwitch : IOEntity // TypeDefIndex: 9805
{	// Fields
	private int input1Amount; // 0x288
	private int input2Amount; // 0x28C

	// Methods

	// RVA: 0x1A93510 Offset: 0x1A92910 VA: 0x181A93510
	public void .ctor() { }

}

