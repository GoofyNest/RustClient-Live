internal class SmallXmlParser // TypeDefIndex: 24
{
	private SmallXmlParser.IContentHandler handler; 
	private TextReader reader; 
	private Stack elementNames; 
	private Stack xmlSpaces; 
	private string xmlSpace; 
	private StringBuilder buffer; 
	private char[] nameBuffer; 
	private bool isWhitespace; 
	private SmallXmlParser.AttrListImpl attributes; 
	private int line; 
	private int column; 
	private bool resetColumn; 


public void .ctor() { }

private Exception Error(string msg) { }

private Exception UnexpectedEndError() { }

private bool IsNameChar(char c, bool start) { }

private bool IsWhitespace(int c) { }

public void SkipWhitespaces() { }

private void HandleWhitespaces() { }

public void SkipWhitespaces(bool expected) { }

private int Peek() { }

private int Read() { }

public void Expect(int c) { }

private string ReadUntil(char until, bool handleReferences) { }

public string ReadName() { }

public void Parse(TextReader input, SmallXmlParser.IContentHandler handler) { }

private void Cleanup() { }

public void ReadContent() { }

private void HandleBufferedContent() { }

private void ReadCharacters() { }

private void ReadReference() { }

private int ReadCharacterReference() { }

private void ReadAttribute(SmallXmlParser.AttrListImpl a) { }

private void ReadCDATASection() { }

private void ReadComment() { }

}

private class SmallXmlParser.AttrListImpl : SmallXmlParser.IAttrList // TypeDefIndex: 27
{
	private List<string> attrNames; 
	private List<string> attrValues; 

public int Length { get; }
public string[] Names { get; }
public string[] Values { get; }


public int get_Length() { }

public string GetName(int i) { }

public string GetValue(int i) { }

public string GetValue(string name) { }

public string[] get_Names() { }

public string[] get_Values() { }

internal void Clear() { }

internal void Add(string name, string value) { }

public void .ctor() { }

}

internal class SmallXmlParserException : SystemException // TypeDefIndex: 28
{
	private int line; 
	private int column; 


public void .ctor(string msg, int line, int column) { }

}

public sealed class XmlSyntaxException : SystemException // TypeDefIndex: 909
{

public void .ctor() { }

public void .ctor(int lineNumber) { }

public void .ctor(int lineNumber, string message) { }

public void .ctor(string message) { }

public void .ctor(string message, Exception inner) { }

internal void .ctor(SerializationInfo info, StreamingContext context) { }

}

internal class XPathParser // TypeDefIndex: 1800
{
	private XPathScanner scanner; 
	private int parseDepth; 
	private static readonly XPathResultType[] temparray1; 
	private static readonly XPathResultType[] temparray2; 
	private static readonly XPathResultType[] temparray3; 
	private static readonly XPathResultType[] temparray4; 
	private static readonly XPathResultType[] temparray5; 
	private static readonly XPathResultType[] temparray6; 
	private static readonly XPathResultType[] temparray7; 
	private static readonly XPathResultType[] temparray8; 
	private static readonly XPathResultType[] temparray9; 
	private static Hashtable functionTable; 
	private static Hashtable AxesTable; 


private void .ctor(XPathScanner scanner) { }

public static AstNode ParseXPathExpresion(string xpathExpresion) { }

private AstNode ParseExpresion(AstNode qyInput) { }

private AstNode ParseOrExpr(AstNode qyInput) { }

private AstNode ParseAndExpr(AstNode qyInput) { }

private AstNode ParseEqualityExpr(AstNode qyInput) { }

private AstNode ParseRelationalExpr(AstNode qyInput) { }

private AstNode ParseAdditiveExpr(AstNode qyInput) { }

private AstNode ParseMultiplicativeExpr(AstNode qyInput) { }

private AstNode ParseUnaryExpr(AstNode qyInput) { }

private AstNode ParseUnionExpr(AstNode qyInput) { }

private static bool IsNodeType(XPathScanner scaner) { }

private AstNode ParsePathExpr(AstNode qyInput) { }

private AstNode ParseFilterExpr(AstNode qyInput) { }

private AstNode ParsePredicate(AstNode qyInput) { }

private AstNode ParseLocationPath(AstNode qyInput) { }

private AstNode ParseRelativeLocationPath(AstNode qyInput) { }

private static bool IsStep(XPathScanner.LexKind lexKind) { }

private AstNode ParseStep(AstNode qyInput) { }

private AstNode ParseNodeTest(AstNode qyInput, Axis.AxisType axisType, XPathNodeType nodeType) { }

private static bool IsPrimaryExpr(XPathScanner scanner) { }

private AstNode ParsePrimaryExpr(AstNode qyInput) { }

private AstNode ParseMethod(AstNode qyInput) { }

private void CheckToken(XPathScanner.LexKind t) { }

private void PassToken(XPathScanner.LexKind t) { }

private void NextLex() { }

private bool TestOp(string op) { }

private void CheckNodeSet(XPathResultType t) { }

private static Hashtable CreateFunctionTable() { }

private static Hashtable CreateAxesTable() { }

private Axis.AxisType GetAxis(XPathScanner scaner) { }

private static void .cctor() { }

}

private class XPathParser.ParamInfo // TypeDefIndex: 1801
{
	private Function.FunctionType ftype; 
	private int minargs; 
	private int maxargs; 
	private XPathResultType[] argTypes; 

public Function.FunctionType FType { get; }
public int Minargs { get; }
public int Maxargs { get; }
public XPathResultType[] ArgTypes { get; }


public Function.FunctionType get_FType() { }

public int get_Minargs() { }

public int get_Maxargs() { }

public XPathResultType[] get_ArgTypes() { }

internal void .ctor(Function.FunctionType ftype, int minargs, int maxargs, XPathResultType[] argTypes) { }

}

internal sealed class XPathScanner // TypeDefIndex: 1802
{
	private string xpathExpr; 
	private int xpathExprIndex; 
	private XPathScanner.LexKind kind; 
	private char currentChar; 
	private string name; 
	private string prefix; 
	private string stringValue; 
	private double numberValue; 
	private bool canBeFunction; 
	private XmlCharType xmlCharType; 

public string SourceText { get; }
private char CurerntChar { get; }
public XPathScanner.LexKind Kind { get; }
public string Name { get; }
public string Prefix { get; }
public string StringValue { get; }
public double NumberValue { get; }
public bool CanBeFunction { get; }


public void .ctor(string xpathExpr) { }

public string get_SourceText() { }

private char get_CurerntChar() { }

private bool NextChar() { }

public XPathScanner.LexKind get_Kind() { }

public string get_Name() { }

public string get_Prefix() { }

public string get_StringValue() { }

public double get_NumberValue() { }

public bool get_CanBeFunction() { }

private void SkipSpace() { }

public bool NextLex() { }

private double ScanNumber() { }

private double ScanFraction() { }

private string ScanString() { }

private string ScanName() { }

}

public enum XPathScanner.LexKind // TypeDefIndex: 1803
{
	public int value__; 
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
{
	private XPathNode[] pageCurrent; 
	private XPathNode[] pageParent; 
	private int idxCurrent; 
	private int idxParent; 

public override string Value { get; }
public override XPathNodeType NodeType { get; }
public override string LocalName { get; }
public override string NamespaceURI { get; }
public override string Prefix { get; }
public override XmlNameTable NameTable { get; }
public override object UnderlyingObject { get; }
public int LineNumber { get; }
public int LinePosition { get; }


public void .ctor(XPathNode[] pageCurrent, int idxCurrent, XPathNode[] pageParent, int idxParent) { }

public override string get_Value() { }

public override XPathNavigator Clone() { }

public override XPathNodeType get_NodeType() { }

public override string get_LocalName() { }

public override string get_NamespaceURI() { }

public override string get_Prefix() { }

public override XmlNameTable get_NameTable() { }

public override bool MoveToFirstNamespace(XPathNamespaceScope namespaceScope) { }

public override bool MoveToNextNamespace(XPathNamespaceScope scope) { }

public override bool MoveToParent() { }

public override bool IsSamePosition(XPathNavigator other) { }

public override object get_UnderlyingObject() { }

public bool HasLineInfo() { }

public int get_LineNumber() { }

public int get_LinePosition() { }

public int GetPositionHashCode() { }

}

internal struct XPathNode // TypeDefIndex: 1805
{
	private XPathNodeInfoAtom info; 
	private ushort idxSibling; 
	private ushort idxParent; 
	private ushort idxSimilar; 
	private ushort posOffset; 
	private uint props; 
	private string value; 

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


public XPathNodeType get_NodeType() { }

public string get_Prefix() { }

public string get_LocalName() { }

public string get_NamespaceUri() { }

public XPathDocument get_Document() { }

public int get_LineNumber() { }

public int get_LinePosition() { }

public int get_CollapsedLinePosition() { }

public XPathNodePageInfo get_PageInfo() { }

public int GetParent(out XPathNode[] pageNode) { }

public int GetSibling(out XPathNode[] pageNode) { }

public bool get_IsXmlNamespaceNode() { }

public bool get_HasSibling() { }

public bool get_HasCollapsedText() { }

public bool get_IsText() { }

public bool get_HasNamespaceDecls() { }

public string get_Value() { }

}

internal struct XPathNodeRef // TypeDefIndex: 1806
{
	private XPathNode[] page; 
	private int idx; 

public XPathNode[] Page { get; }
public int Index { get; }


public void .ctor(XPathNode[] page, int idx) { }

public XPathNode[] get_Page() { }

public int get_Index() { }

public override int GetHashCode() { }

}

internal abstract class XPathNodeHelper // TypeDefIndex: 1807
{

public static int GetLocalNamespaces(XPathNode[] pageElem, int idxElem, out XPathNode[] pageNmsp) { }

public static int GetInScopeNamespaces(XPathNode[] pageElem, int idxElem, out XPathNode[] pageNmsp) { }

public static bool GetParent(ref XPathNode[] pageNode, ref int idxNode) { }

public static int GetLocation(XPathNode[] pageNode, int idxNode) { }

public static bool GetTextFollowing(ref XPathNode[] pageCurrent, ref int idxCurrent, XPathNode[] pageEnd, int idxEnd) { }

public static bool GetNonDescendant(ref XPathNode[] pageNode, ref int idxNode) { }

}

internal sealed class XPathNodePageInfo // TypeDefIndex: 1808
{
	private int pageNum; 
	private int nodeCount; 
	private XPathNode[] pageNext; 

public int PageNumber { get; }
public int NodeCount { get; }
public XPathNode[] NextPage { get; }


public int get_PageNumber() { }

public int get_NodeCount() { }

public XPathNode[] get_NextPage() { }

}

internal sealed class XPathNodeInfoAtom // TypeDefIndex: 1809
{
	private string localName; 
	private string namespaceUri; 
	private string prefix; 
	private XPathNode[] pageParent; 
	private XPathNode[] pageSibling; 
	private XPathDocument doc; 
	private int lineNumBase; 
	private int linePosBase; 
	private XPathNodePageInfo pageInfo; 

public XPathNodePageInfo PageInfo { get; }
public string LocalName { get; }
public string NamespaceUri { get; }
public string Prefix { get; }
public XPathNode[] SiblingPage { get; }
public XPathNode[] ParentPage { get; }
public XPathDocument Document { get; }
public int LineNumberBase { get; }
public int LinePositionBase { get; }


public XPathNodePageInfo get_PageInfo() { }

public string get_LocalName() { }

public string get_NamespaceUri() { }

public string get_Prefix() { }

public XPathNode[] get_SiblingPage() { }

public XPathNode[] get_ParentPage() { }

public XPathDocument get_Document() { }

public int get_LineNumberBase() { }

public int get_LinePositionBase() { }

}

internal class XmlRawWriterBase64Encoder : Base64Encoder // TypeDefIndex: 1814
{
	private XmlRawWriter rawWriter; 


internal void .ctor(XmlRawWriter rawWriter) { }

internal override void WriteChars(char[] chars, int index, int count) { }

}

internal class XmlTextWriterBase64Encoder : Base64Encoder // TypeDefIndex: 1815
{
	private XmlTextEncoder xmlTextEncoder; 


internal void .ctor(XmlTextEncoder xmlTextEncoder) { }

internal override void WriteChars(char[] chars, int index, int count) { }

}

internal enum BinXmlToken // TypeDefIndex: 1818
{
	public int value__; 
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
{
	internal byte m_bLen; 
	internal byte m_bPrec; 
	internal byte m_bScale; 
	internal byte m_bSign; 
	internal uint m_data1; 
	internal uint m_data2; 
	internal uint m_data3; 
	internal uint m_data4; 
	private static readonly byte NUMERIC_MAX_PRECISION; 
	private static readonly byte MaxPrecision; 
	private static readonly byte MaxScale; 
	private static readonly int x_cNumeMax; 
	private static readonly long x_lInt32Base; 
	private static readonly ulong x_ulInt32Base; 
	private static readonly ulong x_ulInt32BaseForMod; 
	internal static readonly ulong x_llMax; 
	private static readonly double DUINT_BASE; 
	private static readonly double DUINT_BASE2; 
	private static readonly double DUINT_BASE3; 
	private static readonly uint[] x_rgulShiftBase; 
	private static readonly byte[] rgCLenFromPrec; 

public bool IsPositive { get; }


public bool get_IsPositive() { }

public void .ctor(byte[] data, int offset, bool trim) { }

private static uint UIntFromByteArray(byte[] data, int offset) { }

private static void MpDiv1(uint[] rgulU, ref int ciulU, uint iulD, out uint iulR) { }

private static void MpNormalize(uint[] rgulU, ref int ciulU) { }

private static char ChFromDigit(uint uiDigit) { }

public Decimal ToDecimal() { }

private void TrimTrailingZeros() { }

public override string ToString() { }

private static void .cctor() { }

}

internal struct BinXmlSqlMoney // TypeDefIndex: 1820
{
	private long data; 


public void .ctor(int v) { }

public void .ctor(long v) { }

public Decimal ToDecimal() { }

public override string ToString() { }

}

internal abstract class BinXmlDateTime // TypeDefIndex: 1821
{
	internal static int[] KatmaiTimeScaleMultiplicator; 
	private static readonly double SQLTicksPerMillisecond; 
	public static readonly int SQLTicksPerSecond; 
	public static readonly int SQLTicksPerMinute; 
	public static readonly int SQLTicksPerHour; 
	private static readonly int SQLTicksPerDay; 


private static void Write2Dig(StringBuilder sb, int val) { }

private static void Write4DigNeg(StringBuilder sb, int val) { }

private static void Write3Dec(StringBuilder sb, int val) { }

private static void WriteDate(StringBuilder sb, int yr, int mnth, int day) { }

private static void WriteTime(StringBuilder sb, int hr, int min, int sec, int ms) { }

private static void WriteTimeFullPrecision(StringBuilder sb, int hr, int min, int sec, int fraction) { }

private static void WriteTimeZone(StringBuilder sb, TimeSpan zone) { }

private static void WriteTimeZone(StringBuilder sb, bool negTimeZone, int hr, int min) { }

private static void BreakDownXsdDateTime(long val, out int yr, out int mnth, out int day, out int hr, out int min, out int sec, out int ms) { }

private static void BreakDownXsdDate(long val, out int yr, out int mnth, out int day, out bool negTimeZone, out int hr, out int min) { }

private static void BreakDownXsdTime(long val, out int hr, out int min, out int sec, out int ms) { }

public static string XsdDateTimeToString(long val) { }

public static string XsdDateToString(long val) { }

public static string XsdTimeToString(long val) { }

public static string SqlDateTimeToString(int dateticks, uint timeticks) { }

public static DateTime SqlDateTimeToDateTime(int dateticks, uint timeticks) { }

public static string SqlSmallDateTimeToString(short dateticks, ushort timeticks) { }

public static DateTime SqlSmallDateTimeToDateTime(short dateticks, ushort timeticks) { }

public static DateTime XsdKatmaiDateToDateTime(byte[] data, int offset) { }

public static DateTime XsdKatmaiDateTimeToDateTime(byte[] data, int offset) { }

public static DateTime XsdKatmaiTimeToDateTime(byte[] data, int offset) { }

public static DateTimeOffset XsdKatmaiDateOffsetToDateTimeOffset(byte[] data, int offset) { }

public static DateTimeOffset XsdKatmaiDateTimeOffsetToDateTimeOffset(byte[] data, int offset) { }

public static DateTimeOffset XsdKatmaiTimeOffsetToDateTimeOffset(byte[] data, int offset) { }

public static string XsdKatmaiDateToString(byte[] data, int offset) { }

public static string XsdKatmaiDateTimeToString(byte[] data, int offset) { }

public static string XsdKatmaiTimeToString(byte[] data, int offset) { }

public static string XsdKatmaiDateOffsetToString(byte[] data, int offset) { }

public static string XsdKatmaiDateTimeOffsetToString(byte[] data, int offset) { }

public static string XsdKatmaiTimeOffsetToString(byte[] data, int offset) { }

private static long GetKatmaiDateTicks(byte[] data, ref int pos) { }

private static long GetKatmaiTimeTicks(byte[] data, ref int pos) { }

private static long GetKatmaiTimeZoneTicks(byte[] data, int pos) { }

private static int GetFractions(DateTime dt) { }

private static int GetFractions(DateTimeOffset dt) { }

private static void .cctor() { }

}

internal sealed class XmlSqlBinaryReader : XmlReader, IXmlNamespaceResolver // TypeDefIndex: 1822
{
	internal static readonly Type TypeOfObject; 
	internal static readonly Type TypeOfString; 
	private static Type[] TokenTypeMap; 
	private static byte[] XsdKatmaiTimeScaleToValueLengthMap; 
	private static ReadState[] ScanState2ReadState; 
	private Stream inStrm; 
	private byte[] data; 
	private int pos; 
	private int mark; 
	private int end; 
	private long offset; 
	private bool eof; 
	private bool sniffed; 
	private bool isEmpty; 
	private int docState; 
	private XmlSqlBinaryReader.SymbolTables symbolTables; 
	private XmlNameTable xnt; 
	private bool xntFromSettings; 
	private string xml; 
	private string xmlns; 
	private string nsxmlns; 
	private string baseUri; 
	private XmlSqlBinaryReader.ScanState state; 
	private XmlNodeType nodetype; 
	private BinXmlToken token; 
	private int attrIndex; 
	private XmlSqlBinaryReader.QName qnameOther; 
	private XmlSqlBinaryReader.QName qnameElement; 
	private XmlNodeType parentNodeType; 
	private XmlSqlBinaryReader.ElemInfo[] elementStack; 
	private int elemDepth; 
	private XmlSqlBinaryReader.AttrInfo[] attributes; 
	private int[] attrHashTbl; 
	private int attrCount; 
	private int posAfterAttrs; 
	private bool xmlspacePreserve; 
	private int tokLen; 
	private int tokDataPos; 
	private bool hasTypedValue; 
	private Type valueType; 
	private string stringValue; 
	private Dictionary<string, XmlSqlBinaryReader.NamespaceDecl> namespaces; 
	private XmlSqlBinaryReader.NestedBinXml prevNameInfo; 
	private XmlReader textXmlReader; 
	private bool closeInput; 
	private bool checkCharacters; 
	private bool ignoreWhitespace; 
	private bool ignorePIs; 
	private bool ignoreComments; 
	private DtdProcessing dtdProcessing; 
	private SecureStringHasher hasher; 
	private XmlCharType xmlCharType; 
	private Encoding unicode; 
	private byte version; 

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


public void .ctor(Stream stream, byte[] data, int len, string baseUri, bool closeInput, XmlReaderSettings settings) { }

public override XmlReaderSettings get_Settings() { }

public override XmlNodeType get_NodeType() { }

public override string get_LocalName() { }

public override string get_NamespaceURI() { }

public override string get_Prefix() { }

public override string get_Value() { }

public override int get_Depth() { }

public override string get_BaseURI() { }

public override bool get_IsEmptyElement() { }

public override XmlSpace get_XmlSpace() { }

public override string get_XmlLang() { }

public override Type get_ValueType() { }

public override int get_AttributeCount() { }

public override string GetAttribute(string name, string ns) { }

public override string GetAttribute(string name) { }

public override string GetAttribute(int i) { }

public override bool MoveToAttribute(string name) { }

public override void MoveToAttribute(int i) { }

public override bool MoveToFirstAttribute() { }

public override bool MoveToNextAttribute() { }

public override bool MoveToElement() { }

public override bool get_EOF() { }

public override bool ReadAttributeValue() { }

public override void Close() { }

public override XmlNameTable get_NameTable() { }

public override string LookupNamespace(string prefix) { }

public override void ResolveEntity() { }

public override ReadState get_ReadState() { }

public override bool Read() { }

private IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

private void VerifyVersion(int requiredVersion, BinXmlToken token) { }

private void AddInitNamespace(string prefix, string uri) { }

private void AddName() { }

private void AddQName() { }

private void NameFlush() { }

private void SkipExtn() { }

private int ReadQNameRef() { }

private int ReadNameRef() { }

private bool FillAllowEOF() { }

private void Fill_(int require) { }

private void Fill(int require) { }

private byte ReadByte() { }

private ushort ReadUShort() { }

private int ParseMB32() { }

private int ParseMB32_(byte b) { }

private int ParseMB32(int pos) { }

private int ParseMB64() { }

private BinXmlToken PeekToken() { }

private BinXmlToken ReadToken() { }

private BinXmlToken NextToken2(BinXmlToken token) { }

private BinXmlToken NextToken1() { }

private BinXmlToken NextToken() { }

private BinXmlToken PeekNextToken() { }

private BinXmlToken RescanNextToken() { }

private string ParseText() { }

private int ScanText(out int start) { }

private string GetString(int pos, int cch) { }

private string GetStringAligned(byte[] data, int offset, int cch) { }

private string GetAttributeText(int i) { }

private int LocateAttribute(string name, string ns) { }

private int LocateAttribute(string name) { }

private void PositionOnAttribute(int i) { }

private void GrowElements() { }

private void GrowAttributes() { }

private void ClearAttributes() { }

private void PushNamespace(string prefix, string ns, bool implied) { }

private void PopNamespaces(XmlSqlBinaryReader.NamespaceDecl firstInScopeChain) { }

private void GenerateImpliedXmlnsAttrs() { }

private bool ReadInit(bool skipXmlDecl) { }

private void ScanAttributes() { }

private void SimpleCheckForDuplicateAttributes() { }

private void HashCheckForDuplicateAttributes() { }

private string XmlDeclValue() { }

private string CDATAValue() { }

private void FinishCDATA() { }

private void FinishEndElement() { }

private bool ReadDoc() { }

private void ImplReadData(BinXmlToken tokenType) { }

private void ImplReadElement() { }

private void ImplReadEndElement() { }

private void ImplReadDoctype() { }

private void ImplReadPI() { }

private void ImplReadComment() { }

private void ImplReadCDATA() { }

private void ImplReadNest() { }

private void ImplReadEndNest() { }

private void ImplReadXmlText() { }

private void UpdateFromTextReader() { }

private bool UpdateFromTextReader(bool needUpdate) { }

private void CheckAllowContent() { }

private void GenerateTokenTypeMap() { }

private Type GetValueType(BinXmlToken token) { }

private void ReScanOverValue(BinXmlToken token) { }

private XmlNodeType ScanOverValue(BinXmlToken token, bool attr, bool checkChars) { }

private XmlNodeType ScanOverAnyValue(BinXmlToken token, bool attr, bool checkChars) { }

private XmlNodeType CheckText(bool attr) { }

private XmlNodeType CheckTextIsWS() { }

private void CheckValueTokenBounds() { }

private int GetXsdKatmaiTokenLength(BinXmlToken token) { }

private int XsdKatmaiTimeScaleToValueLength(byte scale) { }

private long ValueAsLong() { }

private ulong ValueAsULong() { }

private Decimal ValueAsDecimal() { }

private double ValueAsDouble() { }

private string ValueAsDateTimeString() { }

private string ValueAsString(BinXmlToken token) { }

private short GetInt16(int pos) { }

private ushort GetUInt16(int pos) { }

private int GetInt32(int pos) { }

private uint GetUInt32(int pos) { }

private long GetInt64(int pos) { }

private ulong GetUInt64(int pos) { }

private float GetSingle(int offset) { }

private double GetDouble(int offset) { }

private Exception ThrowUnexpectedToken(BinXmlToken token) { }

private Exception ThrowXmlException(string res) { }

private Exception ThrowXmlException(string res, string arg1, string arg2) { }

private Exception ThrowNotSupported(string res) { }

private static void .cctor() { }

}

private enum XmlSqlBinaryReader.ScanState // TypeDefIndex: 1823
{
	public int value__; 
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
{
	public string prefix; 
	public string localname; 
	public string namespaceUri; 


public void .ctor(string prefix, string lname, string nsUri) { }

public void Set(string prefix, string lname, string nsUri) { }

public void Clear() { }

public bool MatchNs(string lname, string nsUri) { }

public bool MatchPrefix(string prefix, string lname) { }

public void CheckPrefixNS(string prefix, string namespaceUri) { }

public override int GetHashCode() { }

public int GetNSHashCode(SecureStringHasher hasher) { }

public override bool Equals(object other) { }

public override string ToString() { }

public static bool op_Equality(XmlSqlBinaryReader.QName a, XmlSqlBinaryReader.QName b) { }

}

private struct XmlSqlBinaryReader.ElemInfo // TypeDefIndex: 1825
{
	public XmlSqlBinaryReader.QName name; 
	public string xmlLang; 
	public XmlSpace xmlSpace; 
	public bool xmlspacePreserve; 
	public XmlSqlBinaryReader.NamespaceDecl nsdecls; 


public void Set(XmlSqlBinaryReader.QName name, bool xmlspacePreserve) { }

public XmlSqlBinaryReader.NamespaceDecl Clear() { }

}

private struct XmlSqlBinaryReader.AttrInfo // TypeDefIndex: 1826
{
	public XmlSqlBinaryReader.QName name; 
	public string val; 
	public int contentPos; 
	public int hashCode; 
	public int prevHash; 


public void Set(XmlSqlBinaryReader.QName n, string v) { }

public void Set(XmlSqlBinaryReader.QName n, int pos) { }

public void GetLocalnameAndNamespaceUri(out string localname, out string namespaceUri) { }

public int GetLocalnameAndNamespaceUriAndHash(SecureStringHasher hasher, out string localname, out string namespaceUri) { }

public bool MatchNS(string localname, string namespaceUri) { }

public bool MatchHashNS(int hash, string localname, string namespaceUri) { }

public void AdjustPosition(int adj) { }

}

private class XmlSqlBinaryReader.NamespaceDecl // TypeDefIndex: 1827
{
	public string prefix; 
	public string uri; 
	public XmlSqlBinaryReader.NamespaceDecl scopeLink; 
	public XmlSqlBinaryReader.NamespaceDecl prevLink; 
	public int scope; 
	public bool implied; 


public void .ctor(string prefix, string nsuri, XmlSqlBinaryReader.NamespaceDecl nextInScope, XmlSqlBinaryReader.NamespaceDecl prevDecl, int scope, bool implied) { }

}

private struct XmlSqlBinaryReader.SymbolTables // TypeDefIndex: 1828
{
	public string[] symtable; 
	public int symCount; 
	public XmlSqlBinaryReader.QName[] qnametable; 
	public int qnameCount; 


public void Init() { }

}

private class XmlSqlBinaryReader.NestedBinXml // TypeDefIndex: 1829
{
	public XmlSqlBinaryReader.SymbolTables symbolTables; 
	public int docState; 
	public XmlSqlBinaryReader.NestedBinXml next; 


public void .ctor(XmlSqlBinaryReader.SymbolTables symbolTables, int docState, XmlSqlBinaryReader.NestedBinXml next) { }

}

internal class XmlAsyncCheckReader : XmlReader // TypeDefIndex: 1873
{
	private readonly XmlReader coreReader; 
	private Task lastTask; 

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


internal XmlReader get_CoreReader() { }

public static XmlAsyncCheckReader CreateAsyncCheckWrapper(XmlReader reader) { }

public void .ctor(XmlReader reader) { }

private void CheckAsync() { }

public override XmlReaderSettings get_Settings() { }

public override XmlNodeType get_NodeType() { }

public override string get_Name() { }

public override string get_LocalName() { }

public override string get_NamespaceURI() { }

public override string get_Prefix() { }

public override string get_Value() { }

public override int get_Depth() { }

public override string get_BaseURI() { }

public override bool get_IsEmptyElement() { }

public override bool get_IsDefault() { }

public override char get_QuoteChar() { }

public override XmlSpace get_XmlSpace() { }

public override string get_XmlLang() { }

public override IXmlSchemaInfo get_SchemaInfo() { }

public override Type get_ValueType() { }

public override int get_AttributeCount() { }

public override string GetAttribute(string name) { }

public override string GetAttribute(string name, string namespaceURI) { }

public override string GetAttribute(int i) { }

public override bool MoveToAttribute(string name) { }

public override void MoveToAttribute(int i) { }

public override bool MoveToFirstAttribute() { }

public override bool MoveToNextAttribute() { }

public override bool MoveToElement() { }

public override bool ReadAttributeValue() { }

public override bool Read() { }

public override bool get_EOF() { }

public override void Close() { }

public override ReadState get_ReadState() { }

public override void Skip() { }

public override XmlNameTable get_NameTable() { }

public override string LookupNamespace(string prefix) { }

public override bool get_CanResolveEntity() { }

public override void ResolveEntity() { }

public override bool get_CanReadValueChunk() { }

public override int ReadValueChunk(char[] buffer, int index, int count) { }

public override string ReadString() { }

public override XmlNodeType MoveToContent() { }

public override void ReadStartElement() { }

public override string ReadElementString() { }

public override void ReadEndElement() { }

public override bool IsStartElement(string localname, string ns) { }

public override string ReadInnerXml() { }

public override bool get_HasAttributes() { }

protected override void Dispose(bool disposing) { }

internal override XmlNamespaceManager get_NamespaceManager() { }

internal override IDtdInfo get_DtdInfo() { }

}

internal class XmlAsyncCheckReaderWithNS : XmlAsyncCheckReader, IXmlNamespaceResolver // TypeDefIndex: 1874
{
	private readonly IXmlNamespaceResolver readerAsIXmlNamespaceResolver; 


public void .ctor(XmlReader reader) { }

private IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

}

internal class XmlAsyncCheckReaderWithLineInfo : XmlAsyncCheckReader, IXmlLineInfo // TypeDefIndex: 1875
{
	private readonly IXmlLineInfo readerAsIXmlLineInfo; 

public virtual int LineNumber { get; }
public virtual int LinePosition { get; }


public void .ctor(XmlReader reader) { }

public virtual bool HasLineInfo() { }

public virtual int get_LineNumber() { }

public virtual int get_LinePosition() { }

}

internal class XmlAsyncCheckReaderWithLineInfoNS : XmlAsyncCheckReaderWithLineInfo, IXmlNamespaceResolver // TypeDefIndex: 1876
{
	private readonly IXmlNamespaceResolver readerAsIXmlNamespaceResolver; 


public void .ctor(XmlReader reader) { }

private IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

}

internal class XmlAsyncCheckReaderWithLineInfoNSSchema : XmlAsyncCheckReaderWithLineInfoNS, IXmlSchemaInfo // TypeDefIndex: 1877
{
	private readonly IXmlSchemaInfo readerAsIXmlSchemaInfo; 

private XmlSchemaValidity System.Xml.Schema.IXmlSchemaInfo.Validity { get; }
private bool System.Xml.Schema.IXmlSchemaInfo.IsDefault { get; }
private bool System.Xml.Schema.IXmlSchemaInfo.IsNil { get; }
private XmlSchemaSimpleType System.Xml.Schema.IXmlSchemaInfo.MemberType { get; }
private XmlSchemaType System.Xml.Schema.IXmlSchemaInfo.SchemaType { get; }
private XmlSchemaElement System.Xml.Schema.IXmlSchemaInfo.SchemaElement { get; }
private XmlSchemaAttribute System.Xml.Schema.IXmlSchemaInfo.SchemaAttribute { get; }


public void .ctor(XmlReader reader) { }

private XmlSchemaValidity System.Xml.Schema.IXmlSchemaInfo.get_Validity() { }

private bool System.Xml.Schema.IXmlSchemaInfo.get_IsDefault() { }

private bool System.Xml.Schema.IXmlSchemaInfo.get_IsNil() { }

private XmlSchemaSimpleType System.Xml.Schema.IXmlSchemaInfo.get_MemberType() { }

private XmlSchemaType System.Xml.Schema.IXmlSchemaInfo.get_SchemaType() { }

private XmlSchemaElement System.Xml.Schema.IXmlSchemaInfo.get_SchemaElement() { }

private XmlSchemaAttribute System.Xml.Schema.IXmlSchemaInfo.get_SchemaAttribute() { }

}

internal class XmlAsyncCheckWriter : XmlWriter // TypeDefIndex: 1878
{
	private readonly XmlWriter coreWriter; 
	private Task lastTask; 

public override WriteState WriteState { get; }


public void .ctor(XmlWriter writer) { }

private void CheckAsync() { }

public override void WriteStartDocument() { }

public override void WriteStartDocument(bool standalone) { }

public override void WriteEndDocument() { }

public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

public override void WriteStartElement(string prefix, string localName, string ns) { }

public override void WriteEndElement() { }

public override void WriteFullEndElement() { }

public override void WriteStartAttribute(string prefix, string localName, string ns) { }

public override void WriteEndAttribute() { }

public override void WriteCData(string text) { }

public override void WriteComment(string text) { }

public override void WriteProcessingInstruction(string name, string text) { }

public override void WriteEntityRef(string name) { }

public override void WriteCharEntity(char ch) { }

public override void WriteWhitespace(string ws) { }

public override void WriteString(string text) { }

public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

public override void WriteChars(char[] buffer, int index, int count) { }

public override void WriteRaw(char[] buffer, int index, int count) { }

public override void WriteRaw(string data) { }

public override void WriteBase64(byte[] buffer, int index, int count) { }

public override void WriteBinHex(byte[] buffer, int index, int count) { }

public override WriteState get_WriteState() { }

public override void Close() { }

public override void Flush() { }

public override string LookupPrefix(string ns) { }

public override void WriteValue(string value) { }

public override void WriteAttributes(XmlReader reader, bool defattr) { }

public override void WriteNode(XmlReader reader, bool defattr) { }

protected override void Dispose(bool disposing) { }

}

internal class XmlAutoDetectWriter : XmlRawWriter // TypeDefIndex: 1879
{
	private XmlRawWriter wrapped; 
	private OnRemoveWriter onRemove; 
	private XmlWriterSettings writerSettings; 
	private XmlEventCache eventCache; 
	private TextWriter textWriter; 
	private Stream strm; 

internal override IXmlNamespaceResolver NamespaceResolver { set; }
internal override bool SupportsNamespaceDeclarationInChunks { get; }


private void .ctor(XmlWriterSettings writerSettings) { }

public void .ctor(TextWriter textWriter, XmlWriterSettings writerSettings) { }

public void .ctor(Stream strm, XmlWriterSettings writerSettings) { }

public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

public override void WriteStartElement(string prefix, string localName, string ns) { }

public override void WriteStartAttribute(string prefix, string localName, string ns) { }

public override void WriteEndAttribute() { }

public override void WriteCData(string text) { }

public override void WriteComment(string text) { }

public override void WriteProcessingInstruction(string name, string text) { }

public override void WriteWhitespace(string ws) { }

public override void WriteString(string text) { }

public override void WriteChars(char[] buffer, int index, int count) { }

public override void WriteRaw(char[] buffer, int index, int count) { }

public override void WriteRaw(string data) { }

public override void WriteEntityRef(string name) { }

public override void WriteCharEntity(char ch) { }

public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

public override void WriteBase64(byte[] buffer, int index, int count) { }

public override void WriteBinHex(byte[] buffer, int index, int count) { }

public override void Close() { }

public override void Flush() { }

public override void WriteValue(string value) { }

internal override void set_NamespaceResolver(IXmlNamespaceResolver value) { }

internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

internal override void WriteXmlDeclaration(string xmldecl) { }

internal override void StartElementContent() { }

internal override void WriteEndElement(string prefix, string localName, string ns) { }

internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

internal override void WriteNamespaceDeclaration(string prefix, string ns) { }

internal override bool get_SupportsNamespaceDeclarationInChunks() { }

internal override void WriteStartNamespaceDeclaration(string prefix) { }

internal override void WriteEndNamespaceDeclaration() { }

private static bool IsHtmlTag(string tagName) { }

private void EnsureWrappedWriter(XmlOutputMethod outMethod) { }

private bool TextBlockCreatesWriter(string textBlock) { }

private void CreateWrappedWriter(XmlOutputMethod outMethod) { }

}

internal class XmlEncodedRawTextWriter : XmlRawWriter // TypeDefIndex: 1880
{
	private readonly bool useAsync; 
	protected byte[] bufBytes; 
	protected Stream stream; 
	protected Encoding encoding; 
	protected XmlCharType xmlCharType; 
	protected int bufPos; 
	protected int textPos; 
	protected int contentPos; 
	protected int cdataPos; 
	protected int attrEndPos; 
	protected int bufLen; 
	protected bool writeToNull; 
	protected bool hadDoubleBracket; 
	protected bool inAttributeValue; 
	protected int bufBytesUsed; 
	protected char[] bufChars; 
	protected Encoder encoder; 
	protected TextWriter writer; 
	protected bool trackTextContent; 
	protected bool inTextContent; 
	private int lastMarkPos; 
	private int[] textContentMarks; 
	private CharEntityEncoderFallback charEntityFallback; 
	protected NewLineHandling newLineHandling; 
	protected bool closeOutput; 
	protected bool omitXmlDeclaration; 
	protected string newLineChars; 
	protected bool checkCharacters; 
	protected XmlStandalone standalone; 
	protected XmlOutputMethod outputMethod; 
	protected bool autoXmlDeclaration; 
	protected bool mergeCDataSections; 

internal override bool SupportsNamespaceDeclarationInChunks { get; }


protected void .ctor(XmlWriterSettings settings) { }

public void .ctor(TextWriter writer, XmlWriterSettings settings) { }

public void .ctor(Stream stream, XmlWriterSettings settings) { }

internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

internal override void WriteXmlDeclaration(string xmldecl) { }

public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

public override void WriteStartElement(string prefix, string localName, string ns) { }

internal override void StartElementContent() { }

internal override void WriteEndElement(string prefix, string localName, string ns) { }

internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

public override void WriteStartAttribute(string prefix, string localName, string ns) { }

public override void WriteEndAttribute() { }

internal override void WriteNamespaceDeclaration(string prefix, string namespaceName) { }

internal override bool get_SupportsNamespaceDeclarationInChunks() { }

internal override void WriteStartNamespaceDeclaration(string prefix) { }

internal override void WriteEndNamespaceDeclaration() { }

public override void WriteCData(string text) { }

public override void WriteComment(string text) { }

public override void WriteProcessingInstruction(string name, string text) { }

public override void WriteEntityRef(string name) { }

public override void WriteCharEntity(char ch) { }

public override void WriteWhitespace(string ws) { }

public override void WriteString(string text) { }

public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

public override void WriteChars(char[] buffer, int index, int count) { }

public override void WriteRaw(char[] buffer, int index, int count) { }

public override void WriteRaw(string data) { }

public override void Close() { }

public override void Flush() { }

protected virtual void FlushBuffer() { }

private void EncodeChars(int startOffset, int endOffset, bool writeAllToStream) { }

private void FlushEncoder() { }

protected void WriteAttributeTextBlock(char* pSrc, char* pSrcEnd) { }

protected void WriteElementTextBlock(char* pSrc, char* pSrcEnd) { }

protected void RawText(string s) { }

protected void RawText(char* pSrcBegin, char* pSrcEnd) { }

protected void WriteRawWithCharChecking(char* pSrcBegin, char* pSrcEnd) { }

protected void WriteCommentOrPi(string text, int stopChar) { }

protected void WriteCDataSection(string text) { }

private static char* EncodeSurrogate(char* pSrc, char* pSrcEnd, char* pDst) { }

private char* InvalidXmlChar(int ch, char* pDst, bool entitize) { }

internal void EncodeChar(ref char* pSrc, char* pSrcEnd, ref char* pDst) { }

protected void ChangeTextContentMark(bool value) { }

private void GrowTextContentMarks() { }

protected char* WriteNewLine(char* pDst) { }

protected static char* LtEntity(char* pDst) { }

protected static char* GtEntity(char* pDst) { }

protected static char* AmpEntity(char* pDst) { }

protected static char* QuoteEntity(char* pDst) { }

protected static char* TabEntity(char* pDst) { }

protected static char* LineFeedEntity(char* pDst) { }

protected static char* CarriageReturnEntity(char* pDst) { }

private static char* CharEntity(char* pDst, char ch) { }

protected static char* RawStartCData(char* pDst) { }

protected static char* RawEndCData(char* pDst) { }

protected void ValidateContentChars(string chars, string propertyName, bool allowOnlyWhitespace) { }

}

internal class XmlEncodedRawTextWriterIndent : XmlEncodedRawTextWriter // TypeDefIndex: 1881
{
	protected int indentLevel; 
	protected bool newLineOnAttributes; 
	protected string indentChars; 
	protected bool mixedContent; 
	private BitStack mixedContentStack; 
	protected ConformanceLevel conformanceLevel; 


public void .ctor(TextWriter writer, XmlWriterSettings settings) { }

public void .ctor(Stream stream, XmlWriterSettings settings) { }

public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

public override void WriteStartElement(string prefix, string localName, string ns) { }

internal override void StartElementContent() { }

internal override void OnRootElement(ConformanceLevel currentConformanceLevel) { }

internal override void WriteEndElement(string prefix, string localName, string ns) { }

internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

public override void WriteStartAttribute(string prefix, string localName, string ns) { }

public override void WriteCData(string text) { }

public override void WriteComment(string text) { }

public override void WriteProcessingInstruction(string target, string text) { }

public override void WriteEntityRef(string name) { }

public override void WriteCharEntity(char ch) { }

public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

public override void WriteWhitespace(string ws) { }

public override void WriteString(string text) { }

public override void WriteChars(char[] buffer, int index, int count) { }

public override void WriteRaw(char[] buffer, int index, int count) { }

public override void WriteRaw(string data) { }

public override void WriteBase64(byte[] buffer, int index, int count) { }

private void Init(XmlWriterSettings settings) { }

private void WriteIndent() { }

}

internal sealed class XmlEventCache : XmlRawWriter // TypeDefIndex: 1882
{
	private List<XmlEventCache.XmlEvent[]> pages; 
	private XmlEventCache.XmlEvent[] pageCurr; 
	private int pageSize; 
	private bool hasRootNode; 
	private StringConcat singleText; 
	private string baseUri; 


public void .ctor(string baseUri, bool hasRootNode) { }

public void EndEvents() { }

public void EventsToWriter(XmlWriter writer) { }

public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

public override void WriteStartElement(string prefix, string localName, string ns) { }

public override void WriteStartAttribute(string prefix, string localName, string ns) { }

public override void WriteEndAttribute() { }

public override void WriteCData(string text) { }

public override void WriteComment(string text) { }

public override void WriteProcessingInstruction(string name, string text) { }

public override void WriteWhitespace(string ws) { }

public override void WriteString(string text) { }

public override void WriteChars(char[] buffer, int index, int count) { }

public override void WriteRaw(char[] buffer, int index, int count) { }

public override void WriteRaw(string data) { }

public override void WriteEntityRef(string name) { }

public override void WriteCharEntity(char ch) { }

public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

public override void WriteBase64(byte[] buffer, int index, int count) { }

public override void WriteBinHex(byte[] buffer, int index, int count) { }

public override void Close() { }

public override void Flush() { }

public override void WriteValue(string value) { }

protected override void Dispose(bool disposing) { }

internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

internal override void WriteXmlDeclaration(string xmldecl) { }

internal override void StartElementContent() { }

internal override void WriteEndElement(string prefix, string localName, string ns) { }

internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

internal override void WriteNamespaceDeclaration(string prefix, string ns) { }

internal override void WriteEndBase64() { }

private void AddEvent(XmlEventCache.XmlEventType eventType) { }

private void AddEvent(XmlEventCache.XmlEventType eventType, string s1) { }

private void AddEvent(XmlEventCache.XmlEventType eventType, string s1, string s2) { }

private void AddEvent(XmlEventCache.XmlEventType eventType, string s1, string s2, string s3) { }

private void AddEvent(XmlEventCache.XmlEventType eventType, string s1, string s2, string s3, object o) { }

private void AddEvent(XmlEventCache.XmlEventType eventType, object o) { }

private int NewEvent() { }

private static byte[] ToBytes(byte[] buffer, int index, int count) { }

}

private enum XmlEventCache.XmlEventType // TypeDefIndex: 1883
{
	public int value__; 
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
{
	private XmlEventCache.XmlEventType eventType; 
	private string s1; 
	private string s2; 
	private string s3; 
	private object o; 

public XmlEventCache.XmlEventType EventType { get; }
public string String1 { get; }
public string String2 { get; }
public string String3 { get; }
public object Object { get; }


public void InitEvent(XmlEventCache.XmlEventType eventType) { }

public void InitEvent(XmlEventCache.XmlEventType eventType, string s1) { }

public void InitEvent(XmlEventCache.XmlEventType eventType, string s1, string s2) { }

public void InitEvent(XmlEventCache.XmlEventType eventType, string s1, string s2, string s3) { }

public void InitEvent(XmlEventCache.XmlEventType eventType, string s1, string s2, string s3, object o) { }

public void InitEvent(XmlEventCache.XmlEventType eventType, object o) { }

public XmlEventCache.XmlEventType get_EventType() { }

public string get_String1() { }

public string get_String2() { }

public string get_String3() { }

public object get_Object() { }

}

public class XmlParserContext // TypeDefIndex: 1885
{
	private XmlNameTable _nt; 
	private XmlNamespaceManager _nsMgr; 
	private string _docTypeName; 
	private string _pubId; 
	private string _sysId; 
	private string _internalSubset; 
	private string _xmlLang; 
	private XmlSpace _xmlSpace; 
	private string _baseURI; 
	private Encoding _encoding; 

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


public void .ctor(XmlNameTable nt, XmlNamespaceManager nsMgr, string xmlLang, XmlSpace xmlSpace) { }

public void .ctor(XmlNameTable nt, XmlNamespaceManager nsMgr, string docTypeName, string pubId, string sysId, string internalSubset, string baseURI, string xmlLang, XmlSpace xmlSpace) { }

public void .ctor(XmlNameTable nt, XmlNamespaceManager nsMgr, string docTypeName, string pubId, string sysId, string internalSubset, string baseURI, string xmlLang, XmlSpace xmlSpace, Encoding enc) { }

public XmlNameTable get_NameTable() { }

public XmlNamespaceManager get_NamespaceManager() { }

public string get_DocTypeName() { }

public string get_PublicId() { }

public string get_SystemId() { }

public string get_BaseURI() { }

public string get_InternalSubset() { }

public string get_XmlLang() { }

public XmlSpace get_XmlSpace() { }

public Encoding get_Encoding() { }

internal bool get_HasDtdInfo() { }

}

internal abstract class XmlRawWriter : XmlWriter // TypeDefIndex: 1886
{
	protected XmlRawWriterBase64Encoder base64Encoder; 
	protected IXmlNamespaceResolver resolver; 

public override WriteState WriteState { get; }
internal virtual IXmlNamespaceResolver NamespaceResolver { set; }
internal virtual bool SupportsNamespaceDeclarationInChunks { get; }


public override void WriteStartDocument() { }

public override void WriteStartDocument(bool standalone) { }

public override void WriteEndDocument() { }

public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

public override void WriteEndElement() { }

public override void WriteFullEndElement() { }

public override void WriteBase64(byte[] buffer, int index, int count) { }

public override string LookupPrefix(string ns) { }

public override WriteState get_WriteState() { }

public override void WriteCData(string text) { }

public override void WriteCharEntity(char ch) { }

public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

public override void WriteWhitespace(string ws) { }

public override void WriteChars(char[] buffer, int index, int count) { }

public override void WriteRaw(char[] buffer, int index, int count) { }

public override void WriteRaw(string data) { }

public override void WriteValue(string value) { }

public override void WriteAttributes(XmlReader reader, bool defattr) { }

public override void WriteNode(XmlReader reader, bool defattr) { }

internal virtual void set_NamespaceResolver(IXmlNamespaceResolver value) { }

internal virtual void WriteXmlDeclaration(XmlStandalone standalone) { }

internal virtual void WriteXmlDeclaration(string xmldecl) { }

internal abstract void StartElementContent();

internal virtual void OnRootElement(ConformanceLevel conformanceLevel) { }

internal abstract void WriteEndElement(string prefix, string localName, string ns);

internal virtual void WriteFullEndElement(string prefix, string localName, string ns) { }

internal abstract void WriteNamespaceDeclaration(string prefix, string ns);

internal virtual bool get_SupportsNamespaceDeclarationInChunks() { }

internal virtual void WriteStartNamespaceDeclaration(string prefix) { }

internal virtual void WriteEndNamespaceDeclaration() { }

internal virtual void WriteEndBase64() { }

internal virtual void Close(WriteState currentState) { }

protected void .ctor() { }

}

public abstract class XmlReader : IDisposable // TypeDefIndex: 1887
{
	private static uint IsTextualNodeBitmap; 
	private static uint CanReadContentAsBitmap; 
	private static uint HasValueBitmap; 

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


public virtual XmlReaderSettings get_Settings() { }

public abstract XmlNodeType get_NodeType();

public virtual string get_Name() { }

public abstract string get_LocalName();

public abstract string get_NamespaceURI();

public abstract string get_Prefix();

public abstract string get_Value();

public abstract int get_Depth();

public abstract string get_BaseURI();

public abstract bool get_IsEmptyElement();

public virtual bool get_IsDefault() { }

public virtual char get_QuoteChar() { }

public virtual XmlSpace get_XmlSpace() { }

public virtual string get_XmlLang() { }

public virtual IXmlSchemaInfo get_SchemaInfo() { }

public virtual Type get_ValueType() { }

public abstract int get_AttributeCount();

public abstract string GetAttribute(string name);

public abstract string GetAttribute(string name, string namespaceURI);

public abstract string GetAttribute(int i);

public abstract bool MoveToAttribute(string name);

public virtual void MoveToAttribute(int i) { }

public abstract bool MoveToFirstAttribute();

public abstract bool MoveToNextAttribute();

public abstract bool MoveToElement();

public abstract bool ReadAttributeValue();

public abstract bool Read();

public abstract bool get_EOF();

public virtual void Close() { }

public abstract ReadState get_ReadState();

public virtual void Skip() { }

public abstract XmlNameTable get_NameTable();

public abstract string LookupNamespace(string prefix);

public virtual bool get_CanResolveEntity() { }

public abstract void ResolveEntity();

public virtual bool get_CanReadValueChunk() { }

public virtual int ReadValueChunk(char[] buffer, int index, int count) { }

	[EditorBrowsableAttribute] 
public virtual string ReadString() { }

public virtual XmlNodeType MoveToContent() { }

public virtual void ReadStartElement() { }

	[EditorBrowsableAttribute] 
public virtual string ReadElementString() { }

public virtual void ReadEndElement() { }

public virtual bool IsStartElement(string localname, string ns) { }

public virtual string ReadInnerXml() { }

private void WriteNode(XmlWriter xtw, bool defattr) { }

private void WriteAttributeValue(XmlWriter xtw) { }

private XmlWriter CreateWriterForInnerOuterXml(StringWriter sw) { }

private void SetNamespacesFlag(XmlTextWriter xtw) { }

public virtual bool get_HasAttributes() { }

public void Dispose() { }

protected virtual void Dispose(bool disposing) { }

internal virtual XmlNamespaceManager get_NamespaceManager() { }

internal static bool IsTextualNode(XmlNodeType nodeType) { }

internal static bool HasValueInternal(XmlNodeType nodeType) { }

private bool SkipSubtree() { }

internal bool get_IsDefaultInternal() { }

internal virtual IDtdInfo get_DtdInfo() { }

public static XmlReader Create(Stream input, XmlReaderSettings settings, string baseUri) { }

public static XmlReader Create(TextReader input, XmlReaderSettings settings, string baseUri) { }

internal static XmlReader CreateSqlReader(Stream input, XmlReaderSettings settings, XmlParserContext inputContext) { }

internal static int CalcBufferSize(Stream input) { }

protected void .ctor() { }

private static void .cctor() { }

}

public sealed class XmlReaderSettings // TypeDefIndex: 1888
{
	private bool useAsync; 
	private XmlNameTable nameTable; 
	private XmlResolver xmlResolver; 
	private int lineNumberOffset; 
	private int linePositionOffset; 
	private ConformanceLevel conformanceLevel; 
	private bool checkCharacters; 
	private long maxCharactersInDocument; 
	private long maxCharactersFromEntities; 
	private bool ignoreWhitespace; 
	private bool ignorePIs; 
	private bool ignoreComments; 
	private DtdProcessing dtdProcessing; 
	private ValidationType validationType; 
	private XmlSchemaValidationFlags validationFlags; 
	private XmlSchemaSet schemas; 
	private ValidationEventHandler valEventHandler; 
	private bool closeInput; 
	private bool isReadOnly; 
	[CompilerGeneratedAttribute] 
	private bool <IsXmlResolverSet>k__BackingField; 
	private static Nullable<bool> s_enableLegacyXmlSettings; 

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


public void .ctor() { }

public bool get_Async() { }

public void set_Async(bool value) { }

public XmlNameTable get_NameTable() { }

public void set_NameTable(XmlNameTable value) { }

	[CompilerGeneratedAttribute] 
internal bool get_IsXmlResolverSet() { }

	[CompilerGeneratedAttribute] 
internal void set_IsXmlResolverSet(bool value) { }

public void set_XmlResolver(XmlResolver value) { }

internal XmlResolver GetXmlResolver() { }

internal XmlResolver GetXmlResolver_CheckConfig() { }

public int get_LineNumberOffset() { }

public void set_LineNumberOffset(int value) { }

public int get_LinePositionOffset() { }

public void set_LinePositionOffset(int value) { }

public ConformanceLevel get_ConformanceLevel() { }

public void set_ConformanceLevel(ConformanceLevel value) { }

public bool get_CheckCharacters() { }

public void set_CheckCharacters(bool value) { }

public long get_MaxCharactersInDocument() { }

public void set_MaxCharactersInDocument(long value) { }

public long get_MaxCharactersFromEntities() { }

public void set_MaxCharactersFromEntities(long value) { }

public bool get_IgnoreWhitespace() { }

public void set_IgnoreWhitespace(bool value) { }

public bool get_IgnoreProcessingInstructions() { }

public void set_IgnoreProcessingInstructions(bool value) { }

public bool get_IgnoreComments() { }

public void set_IgnoreComments(bool value) { }

public DtdProcessing get_DtdProcessing() { }

public void set_DtdProcessing(DtdProcessing value) { }

public bool get_CloseInput() { }

public void set_CloseInput(bool value) { }

public ValidationType get_ValidationType() { }

public void set_ValidationType(ValidationType value) { }

public XmlSchemaValidationFlags get_ValidationFlags() { }

public void set_ValidationFlags(XmlSchemaValidationFlags value) { }

public XmlSchemaSet get_Schemas() { }

public void set_Schemas(XmlSchemaSet value) { }

public XmlReaderSettings Clone() { }

internal ValidationEventHandler GetEventHandler() { }

internal XmlReader CreateReader(Stream input, Uri baseUri, string baseUriString, XmlParserContext inputContext) { }

internal XmlReader CreateReader(TextReader input, string baseUriString, XmlParserContext inputContext) { }

internal void set_ReadOnly(bool value) { }

private void CheckReadOnly(string propertyName) { }

private void Initialize() { }

private void Initialize(XmlResolver resolver) { }

private static XmlResolver CreateDefaultResolver() { }

internal XmlReader AddValidation(XmlReader reader) { }

private XmlValidatingReaderImpl CreateDtdValidatingReader(XmlReader baseReader) { }

internal static bool EnableLegacyXmlSettings() { }

}

public enum XmlSpace // TypeDefIndex: 1889
{
	public int value__; 
public const XmlSpace None = 0;
public const XmlSpace Default = 1;
public const XmlSpace Preserve = 2;

}

internal class XmlTextEncoder // TypeDefIndex: 1890
{
	private TextWriter textWriter; 
	private bool inAttribute; 
	private char quoteChar; 
	private StringBuilder attrValue; 
	private bool cacheAttrValue; 
	private XmlCharType xmlCharType; 

internal char QuoteChar { set; }
internal string AttributeValue { get; }


internal void .ctor(TextWriter textWriter) { }

internal void set_QuoteChar(char value) { }

internal void StartAttribute(bool cacheAttrValue) { }

internal void EndAttribute() { }

internal string get_AttributeValue() { }

internal void WriteSurrogateChar(char lowChar, char highChar) { }

internal void Write(char[] array, int offset, int count) { }

internal void WriteSurrogateCharEntity(char lowChar, char highChar) { }

internal void Write(string text) { }

internal void WriteRawWithSurrogateChecking(string text) { }

internal void WriteRaw(char[] array, int offset, int count) { }

internal void WriteCharEntity(char ch) { }

internal void WriteEntityRef(string name) { }

private void WriteStringFragment(string str, int offset, int count, char[] helperBuffer) { }

private void WriteCharEntityImpl(char ch) { }

private void WriteCharEntityImpl(string strVal) { }

private void WriteEntityRefImpl(string name) { }

}

public class XmlTextReader : XmlReader, IXmlLineInfo, IXmlNamespaceResolver // TypeDefIndex: 1891
{
	private XmlTextReaderImpl impl; 

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


public void .ctor(Stream input) { }

public void .ctor(string url, Stream input, XmlNameTable nt) { }

public void .ctor(TextReader input) { }

public void .ctor(TextReader input, XmlNameTable nt) { }

public override XmlNodeType get_NodeType() { }

public override string get_Name() { }

public override string get_LocalName() { }

public override string get_NamespaceURI() { }

public override string get_Prefix() { }

public override string get_Value() { }

public override int get_Depth() { }

public override string get_BaseURI() { }

public override bool get_IsEmptyElement() { }

public override bool get_IsDefault() { }

public override char get_QuoteChar() { }

public override XmlSpace get_XmlSpace() { }

public override string get_XmlLang() { }

public override int get_AttributeCount() { }

public override string GetAttribute(string name) { }

public override string GetAttribute(string localName, string namespaceURI) { }

public override string GetAttribute(int i) { }

public override bool MoveToAttribute(string name) { }

public override void MoveToAttribute(int i) { }

public override bool MoveToFirstAttribute() { }

public override bool MoveToNextAttribute() { }

public override bool MoveToElement() { }

public override bool ReadAttributeValue() { }

public override bool Read() { }

public override bool get_EOF() { }

public override void Close() { }

public override ReadState get_ReadState() { }

public override void Skip() { }

public override XmlNameTable get_NameTable() { }

public override string LookupNamespace(string prefix) { }

public override bool get_CanResolveEntity() { }

public override void ResolveEntity() { }

public override bool get_CanReadValueChunk() { }

public override string ReadString() { }

public bool HasLineInfo() { }

public int get_LineNumber() { }

public int get_LinePosition() { }

private IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

public bool get_Namespaces() { }

public bool get_Normalization() { }

public void set_Normalization(bool value) { }

public void set_WhitespaceHandling(WhitespaceHandling value) { }

public void set_EntityHandling(EntityHandling value) { }

public void set_XmlResolver(XmlResolver value) { }

internal XmlTextReaderImpl get_Impl() { }

internal override XmlNamespaceManager get_NamespaceManager() { }

internal void set_XmlValidatingReaderCompatibilityMode(bool value) { }

internal override IDtdInfo get_DtdInfo() { }

}

internal class XmlTextReaderImpl : XmlReader, IXmlLineInfo, IXmlNamespaceResolver // TypeDefIndex: 1892
{
	private readonly bool useAsync; 
	private XmlTextReaderImpl.LaterInitParam laterInitParam; 
	private XmlCharType xmlCharType; 
	private XmlTextReaderImpl.ParsingState ps; 
	private XmlTextReaderImpl.ParsingFunction parsingFunction; 
	private XmlTextReaderImpl.ParsingFunction nextParsingFunction; 
	private XmlTextReaderImpl.ParsingFunction nextNextParsingFunction; 
	private XmlTextReaderImpl.NodeData[] nodes; 
	private XmlTextReaderImpl.NodeData curNode; 
	private int index; 
	private int curAttrIndex; 
	private int attrCount; 
	private int attrHashtable; 
	private int attrDuplWalkCount; 
	private bool attrNeedNamespaceLookup; 
	private bool fullAttrCleanup; 
	private XmlTextReaderImpl.NodeData[] attrDuplSortingArray; 
	private XmlNameTable nameTable; 
	private bool nameTableFromSettings; 
	private XmlResolver xmlResolver; 
	private string url; 
	private bool normalize; 
	private bool supportNamespaces; 
	private WhitespaceHandling whitespaceHandling; 
	private DtdProcessing dtdProcessing; 
	private EntityHandling entityHandling; 
	private bool ignorePIs; 
	private bool ignoreComments; 
	private bool checkCharacters; 
	private int lineNumberOffset; 
	private int linePositionOffset; 
	private bool closeInput; 
	private long maxCharactersInDocument; 
	private long maxCharactersFromEntities; 
	private bool v1Compat; 
	private XmlNamespaceManager namespaceManager; 
	private string lastPrefix; 
	private XmlTextReaderImpl.XmlContext xmlContext; 
	private XmlTextReaderImpl.ParsingState[] parsingStatesStack; 
	private int parsingStatesStackTop; 
	private string reportedBaseUri; 
	private Encoding reportedEncoding; 
	private IDtdInfo dtdInfo; 
	private XmlNodeType fragmentType; 
	private XmlParserContext fragmentParserContext; 
	private bool fragment; 
	private IncrementalReadDecoder incReadDecoder; 
	private XmlTextReaderImpl.IncrementalReadState incReadState; 
	private LineInfo incReadLineInfo; 
	private int incReadDepth; 
	private int incReadLeftStartPos; 
	private int incReadLeftEndPos; 
	private int attributeValueBaseEntityId; 
	private bool emptyEntityInAttributeResolved; 
	private IValidationEventHandling validationEventHandling; 
	private XmlTextReaderImpl.OnDefaultAttributeUseDelegate onDefaultAttributeUse; 
	private bool validatingReaderCompatFlag; 
	private bool addDefaultAttributesAndNormalize; 
	private StringBuilder stringBuilder; 
	private bool rootElementParsed; 
	private bool standalone; 
	private int nextEntityId; 
	private XmlTextReaderImpl.ParsingMode parsingMode; 
	private ReadState readState; 
	private IDtdEntityInfo lastEntity; 
	private bool afterResetState; 
	private int documentStartBytePos; 
	private int readValueOffset; 
	private long charactersInDocument; 
	private long charactersFromEntities; 
	private Dictionary<IDtdEntityInfo, IDtdEntityInfo> currentEntities; 
	private bool disableUndeclaredEntityCheck; 
	private XmlReader outerReader; 
	private bool xmlResolverIsSet; 
	private string Xml; 
	private string XmlNs; 
	private Task<Tuple<int, int, int, bool>> parseText_dummyTask; 

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


internal void .ctor(XmlNameTable nt) { }

private void .ctor(XmlResolver resolver, XmlReaderSettings settings, XmlParserContext context) { }

internal void .ctor(Stream input) { }

internal void .ctor(string url, Stream input, XmlNameTable nt) { }

internal void .ctor(TextReader input) { }

internal void .ctor(TextReader input, XmlNameTable nt) { }

internal void .ctor(string url, TextReader input, XmlNameTable nt) { }

internal void .ctor(string xmlFragment, XmlNodeType fragType, XmlParserContext context) { }

internal void .ctor(string xmlFragment, XmlParserContext context) { }

private void FinishInitUriString() { }

internal void .ctor(Stream stream, byte[] bytes, int byteCount, XmlReaderSettings settings, Uri baseUri, string baseUriStr, XmlParserContext context, bool closeInput) { }

private void FinishInitStream() { }

internal void .ctor(TextReader input, XmlReaderSettings settings, string baseUriStr, XmlParserContext context) { }

private void FinishInitTextReader() { }

internal void .ctor(string xmlFragment, XmlParserContext context, XmlReaderSettings settings) { }

public override XmlReaderSettings get_Settings() { }

public override XmlNodeType get_NodeType() { }

public override string get_Name() { }

public override string get_LocalName() { }

public override string get_NamespaceURI() { }

public override string get_Prefix() { }

public override string get_Value() { }

public override int get_Depth() { }

public override string get_BaseURI() { }

public override bool get_IsEmptyElement() { }

public override bool get_IsDefault() { }

public override char get_QuoteChar() { }

public override XmlSpace get_XmlSpace() { }

public override string get_XmlLang() { }

public override ReadState get_ReadState() { }

public override bool get_EOF() { }

public override XmlNameTable get_NameTable() { }

public override bool get_CanResolveEntity() { }

public override int get_AttributeCount() { }

public override string GetAttribute(string name) { }

public override string GetAttribute(string localName, string namespaceURI) { }

public override string GetAttribute(int i) { }

public override bool MoveToAttribute(string name) { }

public override void MoveToAttribute(int i) { }

public override bool MoveToFirstAttribute() { }

public override bool MoveToNextAttribute() { }

public override bool MoveToElement() { }

private void FinishInit() { }

public override bool Read() { }

public override void Close() { }

public override void Skip() { }

public override string LookupNamespace(string prefix) { }

public override bool ReadAttributeValue() { }

public override void ResolveEntity() { }

internal void set_OuterReader(XmlReader value) { }

internal void MoveOffEntityReference() { }

public override string ReadString() { }

public override bool get_CanReadValueChunk() { }

public override int ReadValueChunk(char[] buffer, int index, int count) { }

public bool HasLineInfo() { }

public int get_LineNumber() { }

public int get_LinePosition() { }

private IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

internal IDictionary<string, string> GetNamespacesInScope(XmlNamespaceScope scope) { }

internal string LookupPrefix(string namespaceName) { }

internal bool get_Namespaces() { }

internal void set_Namespaces(bool value) { }

internal bool get_Normalization() { }

internal void set_Normalization(bool value) { }

internal void set_WhitespaceHandling(WhitespaceHandling value) { }

internal void set_EntityHandling(EntityHandling value) { }

internal bool get_IsResolverSet() { }

internal void set_XmlResolver(XmlResolver value) { }

internal XmlNameTable get_DtdParserProxy_NameTable() { }

internal IXmlNamespaceResolver get_DtdParserProxy_NamespaceResolver() { }

internal bool get_DtdParserProxy_DtdValidation() { }

internal bool get_DtdParserProxy_Normalization() { }

internal bool get_DtdParserProxy_Namespaces() { }

internal bool get_DtdParserProxy_V1CompatibilityMode() { }

internal Uri get_DtdParserProxy_BaseUri() { }

internal bool get_DtdParserProxy_IsEof() { }

internal char[] get_DtdParserProxy_ParsingBuffer() { }

internal int get_DtdParserProxy_ParsingBufferLength() { }

internal int get_DtdParserProxy_CurrentPosition() { }

internal void set_DtdParserProxy_CurrentPosition(int value) { }

internal int get_DtdParserProxy_EntityStackLength() { }

internal bool get_DtdParserProxy_IsEntityEolNormalized() { }

internal IValidationEventHandling get_DtdParserProxy_ValidationEventHandling() { }

internal void DtdParserProxy_OnNewLine(int pos) { }

internal int get_DtdParserProxy_LineNo() { }

internal int get_DtdParserProxy_LineStartPosition() { }

internal int DtdParserProxy_ReadData() { }

internal int DtdParserProxy_ParseNumericCharRef(StringBuilder internalSubsetBuilder) { }

internal int DtdParserProxy_ParseNamedCharRef(bool expand, StringBuilder internalSubsetBuilder) { }

internal void DtdParserProxy_ParsePI(StringBuilder sb) { }

internal void DtdParserProxy_ParseComment(StringBuilder sb) { }

private bool get_IsResolverNull() { }

private XmlResolver GetTempResolver() { }

internal bool DtdParserProxy_PushEntity(IDtdEntityInfo entity, out int entityId) { }

internal bool DtdParserProxy_PopEntity(out IDtdEntityInfo oldEntity, out int newEntityId) { }

internal bool DtdParserProxy_PushExternalSubset(string systemId, string publicId) { }

internal void DtdParserProxy_PushInternalDtd(string baseUri, string internalDtd) { }

internal void DtdParserProxy_Throw(Exception e) { }

internal void DtdParserProxy_OnSystemId(string systemId, LineInfo keywordLineInfo, LineInfo systemLiteralLineInfo) { }

internal void DtdParserProxy_OnPublicId(string publicId, LineInfo keywordLineInfo, LineInfo publicLiteralLineInfo) { }

private void Throw(int pos, string res, string arg) { }

private void Throw(int pos, string res, string[] args) { }

private void Throw(int pos, string res) { }

private void Throw(string res) { }

private void Throw(string res, int lineNo, int linePos) { }

private void Throw(string res, string arg) { }

private void Throw(string res, string arg, int lineNo, int linePos) { }

private void Throw(string res, string[] args) { }

private void Throw(string res, string arg, Exception innerException) { }

private void Throw(string res, string[] args, Exception innerException) { }

private void Throw(Exception e) { }

private void ReThrow(Exception e, int lineNo, int linePos) { }

private void ThrowWithoutLineInfo(string res) { }

private void ThrowWithoutLineInfo(string res, string arg) { }

private void ThrowWithoutLineInfo(string res, string[] args, Exception innerException) { }

private void ThrowInvalidChar(char[] data, int length, int invCharPos) { }

private void SetErrorState() { }

private void SendValidationEvent(XmlSeverityType severity, string code, string arg, int lineNo, int linePos) { }

private void SendValidationEvent(XmlSeverityType severity, XmlSchemaException exception) { }

private bool get_InAttributeValueIterator() { }

private void FinishAttributeValueIterator() { }

private bool get_DtdValidation() { }

private void InitStreamInput(Stream stream, Encoding encoding) { }

private void InitStreamInput(string baseUriStr, Stream stream, Encoding encoding) { }

private void InitStreamInput(Uri baseUri, Stream stream, Encoding encoding) { }

private void InitStreamInput(Uri baseUri, string baseUriStr, Stream stream, Encoding encoding) { }

private void InitStreamInput(Uri baseUri, string baseUriStr, Stream stream, byte[] bytes, int byteCount, Encoding encoding) { }

private void InitTextReaderInput(string baseUriStr, TextReader input) { }

private void InitTextReaderInput(string baseUriStr, Uri baseUri, TextReader input) { }

private void InitStringInput(string baseUriStr, Encoding originalEncoding, string str) { }

private void InitFragmentReader(XmlNodeType fragmentType, XmlParserContext parserContext, bool allowXmlDeclFragment) { }

private void ProcessDtdFromParserContext(XmlParserContext context) { }

private void OpenUrl() { }

private void OpenUrlDelegate(object xmlResolver) { }

private Encoding DetectEncoding() { }

private void SetupEncoding(Encoding encoding) { }

private void SwitchEncoding(Encoding newEncoding) { }

private Encoding CheckEncoding(string newEncodingName) { }

private void UnDecodeChars() { }

private void SwitchEncodingToUTF8() { }

private int ReadData() { }

private int GetChars(int maxCharsCount) { }

private void InvalidCharRecovery(ref int bytesCount, out int charsCount) { }

internal void Close(bool closeInput) { }

private void ShiftBuffer(int sourcePos, int destPos, int count) { }

private bool ParseXmlDeclaration(bool isTextDecl) { }

private bool ParseDocumentContent() { }

private bool ParseElementContent() { }

private void ThrowUnclosedElements() { }

private void ParseElement() { }

private void AddDefaultAttributesAndNormalize() { }

private void ParseEndElement() { }

private void ThrowTagMismatch(XmlTextReaderImpl.NodeData startTag) { }

private void ParseAttributes() { }

private void ElementNamespaceLookup() { }

private void AttributeNamespaceLookup() { }

private void AttributeDuplCheck() { }

private void OnDefaultNamespaceDecl(XmlTextReaderImpl.NodeData attr) { }

private void OnNamespaceDecl(XmlTextReaderImpl.NodeData attr) { }

private void OnXmlReservedAttribute(XmlTextReaderImpl.NodeData attr) { }

private void ParseAttributeValueSlow(int curPos, char quoteChar, XmlTextReaderImpl.NodeData attr) { }

private void AddAttributeChunkToList(XmlTextReaderImpl.NodeData attr, XmlTextReaderImpl.NodeData chunk, ref XmlTextReaderImpl.NodeData lastChunk) { }

private bool ParseText() { }

private bool ParseText(out int startPos, out int endPos, ref int outOrChars) { }

private void FinishPartialValue() { }

private void FinishOtherValueIterator() { }

private void SkipPartialTextValue() { }

private void FinishReadValueChunk() { }

private void FinishReadContentAsBinary() { }

private void FinishReadElementContentAsBinary() { }

private bool ParseRootLevelWhitespace() { }

private void ParseEntityReference() { }

private XmlTextReaderImpl.EntityType HandleEntityReference(bool isInAttributeValue, XmlTextReaderImpl.EntityExpandType expandType, out int charRefEndPos) { }

private XmlTextReaderImpl.EntityType HandleGeneralEntityReference(string name, bool isInAttributeValue, bool pushFakeEntityIfNullResolver, int entityStartLinePos) { }

private bool get_InEntity() { }

private bool HandleEntityEnd(bool checkEntityNesting) { }

private void SetupEndEntityNodeInContent() { }

private void SetupEndEntityNodeInAttribute() { }

private bool ParsePI() { }

private bool ParsePI(StringBuilder piInDtdStringBuilder) { }

private bool ParsePIValue(out int outStartPos, out int outEndPos) { }

private bool ParseComment() { }

private void ParseCData() { }

private void ParseCDataOrComment(XmlNodeType type) { }

private bool ParseCDataOrComment(XmlNodeType type, out int outStartPos, out int outEndPos) { }

private bool ParseDoctypeDecl() { }

private void ParseDtd() { }

private void SkipDtd() { }

private void SkipPublicOrSystemIdLiteral() { }

private void SkipUntil(char stopChar, bool recognizeLiterals) { }

private int EatWhitespaces(StringBuilder sb) { }

private int ParseCharRefInline(int startPos, out int charCount, out XmlTextReaderImpl.EntityType entityType) { }

private int ParseNumericCharRef(bool expand, StringBuilder internalSubsetBuilder, out XmlTextReaderImpl.EntityType entityType) { }

private int ParseNumericCharRefInline(int startPos, bool expand, StringBuilder internalSubsetBuilder, out int charCount, out XmlTextReaderImpl.EntityType entityType) { }

private int ParseNamedCharRef(bool expand, StringBuilder internalSubsetBuilder) { }

private int ParseNamedCharRefInline(int startPos, bool expand, StringBuilder internalSubsetBuilder) { }

private int ParseName() { }

private int ParseQName(out int colonPos) { }

private int ParseQName(bool isQName, int startOffset, out int colonPos) { }

private bool ReadDataInName(ref int pos) { }

private string ParseEntityName() { }

private XmlTextReaderImpl.NodeData AddNode(int nodeIndex, int nodeDepth) { }

private XmlTextReaderImpl.NodeData AllocNode(int nodeIndex, int nodeDepth) { }

private XmlTextReaderImpl.NodeData AddAttributeNoChecks(string name, int attrDepth) { }

private XmlTextReaderImpl.NodeData AddAttribute(int endNamePos, int colonPos) { }

private XmlTextReaderImpl.NodeData AddAttribute(string localName, string prefix, string nameWPrefix) { }

private void PopElementContext() { }

private void OnNewLine(int pos) { }

private void OnEof() { }

private string LookupNamespace(XmlTextReaderImpl.NodeData node) { }

private void AddNamespace(string prefix, string uri, XmlTextReaderImpl.NodeData attr) { }

private void ResetAttributes() { }

private void FullAttributeCleanup() { }

private void PushXmlContext() { }

private void PopXmlContext() { }

private XmlNodeType GetWhitespaceType() { }

private XmlNodeType GetTextNodeType(int orChars) { }

private void PushExternalEntityOrSubset(string publicId, string systemId, Uri baseUri, string entityName) { }

private bool OpenAndPush(Uri uri) { }

private bool PushExternalEntity(IDtdEntityInfo entity) { }

private void PushInternalEntity(IDtdEntityInfo entity) { }

private void PopEntity() { }

private void RegisterEntity(IDtdEntityInfo entity) { }

private void UnregisterEntity() { }

private void PushParsingState() { }

private void PopParsingState() { }

private int IncrementalRead() { }

private void FinishIncrementalRead() { }

private bool ParseFragmentAttribute() { }

private bool ParseAttributeValueChunk() { }

private void ParseXmlDeclarationFragment() { }

private void ThrowUnexpectedToken(int pos, string expectedToken) { }

private void ThrowUnexpectedToken(string expectedToken1) { }

private void ThrowUnexpectedToken(int pos, string expectedToken1, string expectedToken2) { }

private void ThrowUnexpectedToken(string expectedToken1, string expectedToken2) { }

private string ParseUnexpectedToken(int pos) { }

private string ParseUnexpectedToken() { }

private void ThrowExpectingWhitespace(int pos) { }

private int GetIndexOfAttributeWithoutPrefix(string name) { }

private int GetIndexOfAttributeWithPrefix(string name) { }

private bool ZeroEndingStream(int pos) { }

private void ParseDtdFromParserContext() { }

private bool MoveToNextContentNode(bool moveIfOnContentNode) { }

private void SetupFromParserContext(XmlParserContext context, XmlReaderSettings settings) { }

internal override IDtdInfo get_DtdInfo() { }

internal void SetDtdInfo(IDtdInfo newDtdInfo) { }

internal void set_ValidationEventHandling(IValidationEventHandling value) { }

internal void set_OnDefaultAttributeUse(XmlTextReaderImpl.OnDefaultAttributeUseDelegate value) { }

internal void set_XmlValidatingReaderCompatibilityMode(bool value) { }

internal XmlNodeType get_FragmentType() { }

internal void ChangeCurrentNodeType(XmlNodeType newNodeType) { }

internal XmlResolver GetResolver() { }

internal void set_InternalSchemaType(object value) { }

internal object get_InternalTypedValue() { }

internal void set_InternalTypedValue(object value) { }

internal bool get_StandAlone() { }

internal override XmlNamespaceManager get_NamespaceManager() { }

internal bool get_V1Compat() { }

private bool AddDefaultAttributeDtd(IDtdDefaultAttributeInfo defAttrInfo, bool definedInDtd, XmlTextReaderImpl.NodeData[] nameSortedNodeData) { }

internal bool AddDefaultAttributeNonDtd(SchemaAttDef attrDef) { }

private XmlTextReaderImpl.NodeData AddDefaultAttributeInternal(string localName, string ns, string prefix, string value, int lineNo, int linePos, int valueLineNo, int valueLinePos, bool isXmlAttribute) { }

internal void set_DisableUndeclaredEntityCheck(bool value) { }

private bool UriEqual(Uri uri1, string uri1Str, string uri2Str, XmlResolver resolver) { }

private void RegisterConsumedCharacters(long characters, bool inEntityReference) { }

internal static string StripSpaces(string value) { }

internal static void StripSpaces(char[] value, int index, ref int len) { }

internal static void BlockCopyChars(char[] src, int srcOffset, char[] dst, int dstOffset, int count) { }

internal static void BlockCopy(byte[] src, int srcOffset, byte[] dst, int dstOffset, int count) { }

}

private enum XmlTextReaderImpl.ParsingFunction // TypeDefIndex: 1893
{
	public int value__; 
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
{
	public int value__; 
public const XmlTextReaderImpl.ParsingMode Full = 0;
public const XmlTextReaderImpl.ParsingMode SkipNode = 1;
public const XmlTextReaderImpl.ParsingMode SkipContent = 2;

}

private enum XmlTextReaderImpl.EntityType // TypeDefIndex: 1895
{
	public int value__; 
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
{
	public int value__; 
public const XmlTextReaderImpl.EntityExpandType All = 0;
public const XmlTextReaderImpl.EntityExpandType OnlyGeneral = 1;
public const XmlTextReaderImpl.EntityExpandType OnlyCharacter = 2;

}

private enum XmlTextReaderImpl.IncrementalReadState // TypeDefIndex: 1897
{
	public int value__; 
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
{
	public bool useAsync; 
	public Stream inputStream; 
	public byte[] inputBytes; 
	public int inputByteCount; 
	public Uri inputbaseUri; 
	public string inputUriStr; 
	public XmlResolver inputUriResolver; 
	public XmlParserContext inputContext; 
	public TextReader inputTextReader; 
	public XmlTextReaderImpl.InitInputType initType; 


public void .ctor() { }

}

private enum XmlTextReaderImpl.InitInputType // TypeDefIndex: 1899
{
	public int value__; 
public const XmlTextReaderImpl.InitInputType UriString = 0;
public const XmlTextReaderImpl.InitInputType Stream = 1;
public const XmlTextReaderImpl.InitInputType TextReader = 2;
public const XmlTextReaderImpl.InitInputType Invalid = 3;

}

private struct XmlTextReaderImpl.ParsingState // TypeDefIndex: 1900
{
	internal char[] chars; 
	internal int charPos; 
	internal int charsUsed; 
	internal Encoding encoding; 
	internal bool appendMode; 
	internal Stream stream; 
	internal Decoder decoder; 
	internal byte[] bytes; 
	internal int bytePos; 
	internal int bytesUsed; 
	internal TextReader textReader; 
	internal int lineNo; 
	internal int lineStartPos; 
	internal string baseUriStr; 
	internal Uri baseUri; 
	internal bool isEof; 
	internal bool isStreamEof; 
	internal IDtdEntityInfo entity; 
	internal int entityId; 
	internal bool eolNormalized; 
	internal bool entityResolvedManually; 

internal int LineNo { get; }
internal int LinePos { get; }


internal void Clear() { }

internal void Close(bool closeInput) { }

internal int get_LineNo() { }

internal int get_LinePos() { }

}

private class XmlTextReaderImpl.XmlContext // TypeDefIndex: 1901
{
	internal XmlSpace xmlSpace; 
	internal string xmlLang; 
	internal string defaultNamespace; 
	internal XmlTextReaderImpl.XmlContext previousContext; 


internal void .ctor() { }

internal void .ctor(XmlTextReaderImpl.XmlContext previousContext) { }

}

private class XmlTextReaderImpl.NoNamespaceManager : XmlNamespaceManager // TypeDefIndex: 1902
{
public override string DefaultNamespace { get; }


public void .ctor() { }

public override string get_DefaultNamespace() { }

public override void PushScope() { }

public override bool PopScope() { }

public override void AddNamespace(string prefix, string uri) { }

public override void RemoveNamespace(string prefix, string uri) { }

public override IEnumerator GetEnumerator() { }

public override IDictionary<string, string> GetNamespacesInScope(XmlNamespaceScope scope) { }

public override string LookupNamespace(string prefix) { }

public override string LookupPrefix(string uri) { }

}

internal class XmlTextReaderImpl.DtdParserProxy : IDtdParserAdapterV1, IDtdParserAdapterWithValidation, IDtdParserAdapter // TypeDefIndex: 1903
{
	private XmlTextReaderImpl reader; 

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


internal void .ctor(XmlTextReaderImpl reader) { }

private XmlNameTable System.Xml.IDtdParserAdapter.get_NameTable() { }

private IXmlNamespaceResolver System.Xml.IDtdParserAdapter.get_NamespaceResolver() { }

private Uri System.Xml.IDtdParserAdapter.get_BaseUri() { }

private bool System.Xml.IDtdParserAdapter.get_IsEof() { }

private char[] System.Xml.IDtdParserAdapter.get_ParsingBuffer() { }

private int System.Xml.IDtdParserAdapter.get_ParsingBufferLength() { }

private int System.Xml.IDtdParserAdapter.get_CurrentPosition() { }

private void System.Xml.IDtdParserAdapter.set_CurrentPosition(int value) { }

private int System.Xml.IDtdParserAdapter.get_EntityStackLength() { }

private bool System.Xml.IDtdParserAdapter.get_IsEntityEolNormalized() { }

private void System.Xml.IDtdParserAdapter.OnNewLine(int pos) { }

private int System.Xml.IDtdParserAdapter.get_LineNo() { }

private int System.Xml.IDtdParserAdapter.get_LineStartPosition() { }

private int System.Xml.IDtdParserAdapter.ReadData() { }

private int System.Xml.IDtdParserAdapter.ParseNumericCharRef(StringBuilder internalSubsetBuilder) { }

private int System.Xml.IDtdParserAdapter.ParseNamedCharRef(bool expand, StringBuilder internalSubsetBuilder) { }

private void System.Xml.IDtdParserAdapter.ParsePI(StringBuilder sb) { }

private void System.Xml.IDtdParserAdapter.ParseComment(StringBuilder sb) { }

private bool System.Xml.IDtdParserAdapter.PushEntity(IDtdEntityInfo entity, out int entityId) { }

private bool System.Xml.IDtdParserAdapter.PopEntity(out IDtdEntityInfo oldEntity, out int newEntityId) { }

private bool System.Xml.IDtdParserAdapter.PushExternalSubset(string systemId, string publicId) { }

private void System.Xml.IDtdParserAdapter.PushInternalDtd(string baseUri, string internalDtd) { }

private void System.Xml.IDtdParserAdapter.Throw(Exception e) { }

private void System.Xml.IDtdParserAdapter.OnSystemId(string systemId, LineInfo keywordLineInfo, LineInfo systemLiteralLineInfo) { }

private void System.Xml.IDtdParserAdapter.OnPublicId(string publicId, LineInfo keywordLineInfo, LineInfo publicLiteralLineInfo) { }

private bool System.Xml.IDtdParserAdapterWithValidation.get_DtdValidation() { }

private IValidationEventHandling System.Xml.IDtdParserAdapterWithValidation.get_ValidationEventHandling() { }

private bool System.Xml.IDtdParserAdapterV1.get_Normalization() { }

private bool System.Xml.IDtdParserAdapterV1.get_Namespaces() { }

private bool System.Xml.IDtdParserAdapterV1.get_V1CompatibilityMode() { }

}

private class XmlTextReaderImpl.NodeData : IComparable // TypeDefIndex: 1904
{
	private static XmlTextReaderImpl.NodeData s_None; 
	internal XmlNodeType type; 
	internal string localName; 
	internal string prefix; 
	internal string ns; 
	internal string nameWPrefix; 
	private string value; 
	private char[] chars; 
	private int valueStartPos; 
	private int valueLength; 
	internal LineInfo lineInfo; 
	internal LineInfo lineInfo2; 
	internal char quoteChar; 
	internal int depth; 
	private bool isEmptyOrDefault; 
	internal int entityId; 
	internal bool xmlContextPushed; 
	internal XmlTextReaderImpl.NodeData nextAttrValueChunk; 
	internal object schemaType; 
	internal object typedValue; 

internal static XmlTextReaderImpl.NodeData None { get; }
internal int LineNo { get; }
internal int LinePos { get; }
internal bool IsEmptyElement { get; set; }
internal bool IsDefaultAttribute { get; set; }
internal bool ValueBuffered { get; }
internal string StringValue { get; }


internal static XmlTextReaderImpl.NodeData get_None() { }

internal void .ctor() { }

internal int get_LineNo() { }

internal int get_LinePos() { }

internal bool get_IsEmptyElement() { }

internal void set_IsEmptyElement(bool value) { }

internal bool get_IsDefaultAttribute() { }

internal void set_IsDefaultAttribute(bool value) { }

internal bool get_ValueBuffered() { }

internal string get_StringValue() { }

internal void TrimSpacesInValue() { }

internal void Clear(XmlNodeType type) { }

internal void ClearName() { }

internal void SetLineInfo(int lineNo, int linePos) { }

internal void SetLineInfo2(int lineNo, int linePos) { }

internal void SetValueNode(XmlNodeType type, string value) { }

internal void SetValueNode(XmlNodeType type, char[] chars, int startPos, int len) { }

internal void SetNamedNode(XmlNodeType type, string localName) { }

internal void SetNamedNode(XmlNodeType type, string localName, string prefix, string nameWPrefix) { }

internal void SetValue(string value) { }

internal void SetValue(char[] chars, int startPos, int len) { }

internal void OnBufferInvalidated() { }

internal void CopyTo(int valueOffset, StringBuilder sb) { }

internal int CopyTo(int valueOffset, char[] buffer, int offset, int length) { }

internal string GetNameWPrefix(XmlNameTable nt) { }

internal string CreateNameWPrefix(XmlNameTable nt) { }

private int System.IComparable.CompareTo(object obj) { }

}

private class XmlTextReaderImpl.DtdDefaultAttributeInfoToNodeDataComparer : IComparer<object> // TypeDefIndex: 1905
{
	private static IComparer<object> s_instance; 

internal static IComparer<object> Instance { get; }


internal static IComparer<object> get_Instance() { }

public int Compare(object x, object y) { }

public void .ctor() { }

private static void .cctor() { }

}

internal sealed class XmlTextReaderImpl.OnDefaultAttributeUseDelegate : MulticastDelegate // TypeDefIndex: 1906
{

public void .ctor(object object, IntPtr method) { }

public virtual void Invoke(IDtdDefaultAttributeInfo defaultAttribute, XmlTextReaderImpl coreReader) { }

public virtual IAsyncResult BeginInvoke(IDtdDefaultAttributeInfo defaultAttribute, XmlTextReaderImpl coreReader, AsyncCallback callback, object object) { }

public virtual void EndInvoke(IAsyncResult result) { }

}

public class XmlTextWriter : XmlWriter // TypeDefIndex: 1908
{
	private TextWriter textWriter; 
	private XmlTextEncoder xmlEncoder; 
	private Encoding encoding; 
	private Formatting formatting; 
	private bool indented; 
	private int indentation; 
	private char indentChar; 
	private XmlTextWriter.TagInfo[] stack; 
	private int top; 
	private XmlTextWriter.State[] stateTable; 
	private XmlTextWriter.State currentState; 
	private XmlTextWriter.Token lastToken; 
	private XmlTextWriterBase64Encoder base64Encoder; 
	private char quoteChar; 
	private char curQuoteChar; 
	private bool namespaces; 
	private XmlTextWriter.SpecialAttr specialAttr; 
	private string prefixForXmlNs; 
	private bool flush; 
	private XmlTextWriter.Namespace[] nsStack; 
	private int nsTop; 
	private Dictionary<string, int> nsHashtable; 
	private bool useNsHashtable; 
	private XmlCharType xmlCharType; 
	private static string[] stateName; 
	private static string[] tokenName; 
	private static readonly XmlTextWriter.State[] stateTableDefault; 
	private static readonly XmlTextWriter.State[] stateTableDocument; 

public Stream BaseStream { get; }
public bool Namespaces { set; }
public Formatting Formatting { set; }
public char QuoteChar { set; }
public override WriteState WriteState { get; }


internal void .ctor() { }

public void .ctor(Stream w, Encoding encoding) { }

public void .ctor(string filename, Encoding encoding) { }

public void .ctor(TextWriter w) { }

public Stream get_BaseStream() { }

public void set_Namespaces(bool value) { }

public void set_Formatting(Formatting value) { }

public void set_QuoteChar(char value) { }

public override void WriteStartDocument() { }

public override void WriteStartDocument(bool standalone) { }

public override void WriteEndDocument() { }

public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

public override void WriteStartElement(string prefix, string localName, string ns) { }

public override void WriteEndElement() { }

public override void WriteFullEndElement() { }

public override void WriteStartAttribute(string prefix, string localName, string ns) { }

public override void WriteEndAttribute() { }

public override void WriteCData(string text) { }

public override void WriteComment(string text) { }

public override void WriteProcessingInstruction(string name, string text) { }

public override void WriteEntityRef(string name) { }

public override void WriteCharEntity(char ch) { }

public override void WriteWhitespace(string ws) { }

public override void WriteString(string text) { }

public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

public override void WriteChars(char[] buffer, int index, int count) { }

public override void WriteRaw(char[] buffer, int index, int count) { }

public override void WriteRaw(string data) { }

public override void WriteBase64(byte[] buffer, int index, int count) { }

public override void WriteBinHex(byte[] buffer, int index, int count) { }

public override WriteState get_WriteState() { }

public override void Close() { }

public override void Flush() { }

public override string LookupPrefix(string ns) { }

private void StartDocument(int standalone) { }

private void AutoComplete(XmlTextWriter.Token token) { }

private void AutoCompleteAll() { }

private void InternalWriteEndElement(bool longFormat) { }

private void WriteEndStartTag(bool empty) { }

private void WriteEndAttributeQuote() { }

private void Indent(bool beforeEndElement) { }

private void PushNamespace(string prefix, string ns, bool declared) { }

private void AddNamespace(string prefix, string ns, bool declared) { }

private void AddToNamespaceHashtable(int namespaceIndex) { }

private void PopNamespaces(int indexFrom, int indexTo) { }

private string GeneratePrefix() { }

private void InternalWriteProcessingInstruction(string name, string text) { }

private int LookupNamespace(string prefix) { }

private int LookupNamespaceInCurrentScope(string prefix) { }

private string FindPrefix(string ns) { }

private void ValidateName(string name, bool isNCName) { }

private void HandleSpecialAttribute() { }

private void VerifyPrefixXml(string prefix, string ns) { }

private void PushStack() { }

private void FlushEncoders() { }

private static void .cctor() { }

}

private enum XmlTextWriter.NamespaceState // TypeDefIndex: 1909
{
	public int value__; 
public const XmlTextWriter.NamespaceState Uninitialized = 0;
public const XmlTextWriter.NamespaceState NotDeclaredButInScope = 1;
public const XmlTextWriter.NamespaceState DeclaredButNotWrittenOut = 2;
public const XmlTextWriter.NamespaceState DeclaredAndWrittenOut = 3;

}

private struct XmlTextWriter.TagInfo // TypeDefIndex: 1910
{
	internal string name; 
	internal string prefix; 
	internal string defaultNs; 
	internal XmlTextWriter.NamespaceState defaultNsState; 
	internal XmlSpace xmlSpace; 
	internal string xmlLang; 
	internal int prevNsTop; 
	internal int prefixCount; 
	internal bool mixed; 


internal void Init(int nsTop) { }

}

private struct XmlTextWriter.Namespace // TypeDefIndex: 1911
{
	internal string prefix; 
	internal string ns; 
	internal bool declared; 
	internal int prevNsIndex; 


internal void Set(string prefix, string ns, bool declared) { }

}

private enum XmlTextWriter.SpecialAttr // TypeDefIndex: 1912
{
	public int value__; 
public const XmlTextWriter.SpecialAttr None = 0;
public const XmlTextWriter.SpecialAttr XmlSpace = 1;
public const XmlTextWriter.SpecialAttr XmlLang = 2;
public const XmlTextWriter.SpecialAttr XmlNs = 3;

}

private enum XmlTextWriter.State // TypeDefIndex: 1913
{
	public int value__; 
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
{
	public int value__; 
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
{
	private readonly bool useAsync; 
	protected byte[] bufBytes; 
	protected Stream stream; 
	protected Encoding encoding; 
	protected XmlCharType xmlCharType; 
	protected int bufPos; 
	protected int textPos; 
	protected int contentPos; 
	protected int cdataPos; 
	protected int attrEndPos; 
	protected int bufLen; 
	protected bool writeToNull; 
	protected bool hadDoubleBracket; 
	protected bool inAttributeValue; 
	protected NewLineHandling newLineHandling; 
	protected bool closeOutput; 
	protected bool omitXmlDeclaration; 
	protected string newLineChars; 
	protected bool checkCharacters; 
	protected XmlStandalone standalone; 
	protected XmlOutputMethod outputMethod; 
	protected bool autoXmlDeclaration; 
	protected bool mergeCDataSections; 

internal override bool SupportsNamespaceDeclarationInChunks { get; }


protected void .ctor(XmlWriterSettings settings) { }

public void .ctor(Stream stream, XmlWriterSettings settings) { }

internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

internal override void WriteXmlDeclaration(string xmldecl) { }

public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

public override void WriteStartElement(string prefix, string localName, string ns) { }

internal override void StartElementContent() { }

internal override void WriteEndElement(string prefix, string localName, string ns) { }

internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

public override void WriteStartAttribute(string prefix, string localName, string ns) { }

public override void WriteEndAttribute() { }

internal override void WriteNamespaceDeclaration(string prefix, string namespaceName) { }

internal override bool get_SupportsNamespaceDeclarationInChunks() { }

internal override void WriteStartNamespaceDeclaration(string prefix) { }

internal override void WriteEndNamespaceDeclaration() { }

public override void WriteCData(string text) { }

public override void WriteComment(string text) { }

public override void WriteProcessingInstruction(string name, string text) { }

public override void WriteEntityRef(string name) { }

public override void WriteCharEntity(char ch) { }

public override void WriteWhitespace(string ws) { }

public override void WriteString(string text) { }

public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

public override void WriteChars(char[] buffer, int index, int count) { }

public override void WriteRaw(char[] buffer, int index, int count) { }

public override void WriteRaw(string data) { }

public override void Close() { }

public override void Flush() { }

protected virtual void FlushBuffer() { }

private void FlushEncoder() { }

protected void WriteAttributeTextBlock(char* pSrc, char* pSrcEnd) { }

protected void WriteElementTextBlock(char* pSrc, char* pSrcEnd) { }

protected void RawText(string s) { }

protected void RawText(char* pSrcBegin, char* pSrcEnd) { }

protected void WriteRawWithCharChecking(char* pSrcBegin, char* pSrcEnd) { }

protected void WriteCommentOrPi(string text, int stopChar) { }

protected void WriteCDataSection(string text) { }

private static bool IsSurrogateByte(byte b) { }

private static byte* EncodeSurrogate(char* pSrc, char* pSrcEnd, byte* pDst) { }

private byte* InvalidXmlChar(int ch, byte* pDst, bool entitize) { }

internal void EncodeChar(ref char* pSrc, char* pSrcEnd, ref byte* pDst) { }

internal static byte* EncodeMultibyteUTF8(int ch, byte* pDst) { }

internal static void CharToUTF8(ref char* pSrc, char* pSrcEnd, ref byte* pDst) { }

protected byte* WriteNewLine(byte* pDst) { }

protected static byte* LtEntity(byte* pDst) { }

protected static byte* GtEntity(byte* pDst) { }

protected static byte* AmpEntity(byte* pDst) { }

protected static byte* QuoteEntity(byte* pDst) { }

protected static byte* TabEntity(byte* pDst) { }

protected static byte* LineFeedEntity(byte* pDst) { }

protected static byte* CarriageReturnEntity(byte* pDst) { }

private static byte* CharEntity(byte* pDst, char ch) { }

protected static byte* RawStartCData(byte* pDst) { }

protected static byte* RawEndCData(byte* pDst) { }

protected void ValidateContentChars(string chars, string propertyName, bool allowOnlyWhitespace) { }

}

internal class XmlUtf8RawTextWriterIndent : XmlUtf8RawTextWriter // TypeDefIndex: 1916
{
	protected int indentLevel; 
	protected bool newLineOnAttributes; 
	protected string indentChars; 
	protected bool mixedContent; 
	private BitStack mixedContentStack; 
	protected ConformanceLevel conformanceLevel; 


public void .ctor(Stream stream, XmlWriterSettings settings) { }

public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

public override void WriteStartElement(string prefix, string localName, string ns) { }

internal override void StartElementContent() { }

internal override void OnRootElement(ConformanceLevel currentConformanceLevel) { }

internal override void WriteEndElement(string prefix, string localName, string ns) { }

internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

public override void WriteStartAttribute(string prefix, string localName, string ns) { }

public override void WriteCData(string text) { }

public override void WriteComment(string text) { }

public override void WriteProcessingInstruction(string target, string text) { }

public override void WriteEntityRef(string name) { }

public override void WriteCharEntity(char ch) { }

public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

public override void WriteWhitespace(string ws) { }

public override void WriteString(string text) { }

public override void WriteChars(char[] buffer, int index, int count) { }

public override void WriteRaw(char[] buffer, int index, int count) { }

public override void WriteRaw(string data) { }

public override void WriteBase64(byte[] buffer, int index, int count) { }

private void Init(XmlWriterSettings settings) { }

private void WriteIndent() { }

}

public class XmlValidatingReader : XmlReader // TypeDefIndex: 1917
{
	private XmlValidatingReaderImpl impl; 

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


public override XmlNodeType get_NodeType() { }

public override string get_LocalName() { }

public override string get_NamespaceURI() { }

public override string get_Prefix() { }

public override string get_Value() { }

public override int get_Depth() { }

public override string get_BaseURI() { }

public override bool get_IsEmptyElement() { }

public override int get_AttributeCount() { }

public override string GetAttribute(string name) { }

public override string GetAttribute(string localName, string namespaceURI) { }

public override string GetAttribute(int i) { }

public override bool MoveToAttribute(string name) { }

public override bool MoveToFirstAttribute() { }

public override bool MoveToNextAttribute() { }

public override bool MoveToElement() { }

public override bool ReadAttributeValue() { }

public override bool Read() { }

public override bool get_EOF() { }

public override ReadState get_ReadState() { }

public override XmlNameTable get_NameTable() { }

public override string LookupNamespace(string prefix) { }

public override void ResolveEntity() { }

public bool get_Namespaces() { }

}

internal sealed class XmlValidatingReaderImpl : XmlReader, IXmlLineInfo, IXmlNamespaceResolver // TypeDefIndex: 1918
{
	private XmlReader coreReader; 
	private XmlTextReaderImpl coreReaderImpl; 
	private IXmlNamespaceResolver coreReaderNSResolver; 
	private ValidationType validationType; 
	private BaseValidator validator; 
	private XmlSchemaCollection schemaCollection; 
	private bool processIdentityConstraints; 
	private XmlValidatingReaderImpl.ParsingFunction parsingFunction; 
	private XmlValidatingReaderImpl.ValidationEventHandling eventHandling; 
	private XmlParserContext parserContext; 
	private ReadContentAsBinaryHelper readBinaryHelper; 
	private XmlReader outerReader; 
	private static XmlResolver s_tempResolver; 

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


internal void .ctor(XmlReader reader, ValidationEventHandler settingsEventHandler, bool processIdentityConstraints) { }

public override XmlReaderSettings get_Settings() { }

public override XmlNodeType get_NodeType() { }

public override string get_Name() { }

public override string get_LocalName() { }

public override string get_NamespaceURI() { }

public override string get_Prefix() { }

public override string get_Value() { }

public override int get_Depth() { }

public override string get_BaseURI() { }

public override bool get_IsEmptyElement() { }

public override bool get_IsDefault() { }

public override char get_QuoteChar() { }

public override XmlSpace get_XmlSpace() { }

public override string get_XmlLang() { }

public override ReadState get_ReadState() { }

public override bool get_EOF() { }

public override XmlNameTable get_NameTable() { }

public override int get_AttributeCount() { }

public override string GetAttribute(string name) { }

public override string GetAttribute(string localName, string namespaceURI) { }

public override string GetAttribute(int i) { }

public override bool MoveToAttribute(string name) { }

public override void MoveToAttribute(int i) { }

public override bool MoveToFirstAttribute() { }

public override bool MoveToNextAttribute() { }

public override bool MoveToElement() { }

public override bool Read() { }

public override void Close() { }

public override string LookupNamespace(string prefix) { }

public override bool ReadAttributeValue() { }

public override bool get_CanResolveEntity() { }

public override void ResolveEntity() { }

internal void MoveOffEntityReference() { }

public override string ReadString() { }

public bool HasLineInfo() { }

public int get_LineNumber() { }

public int get_LinePosition() { }

private IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

internal IDictionary<string, string> GetNamespacesInScope(XmlNamespaceScope scope) { }

internal string LookupPrefix(string namespaceName) { }

internal ValidationType get_ValidationType() { }

internal XmlSchemaCollection get_Schemas() { }

internal bool get_Namespaces() { }

private void ParseDtdFromParserContext() { }

private void ValidateDtd() { }

private void ResolveEntityInternally() { }

private void SetupValidation(ValidationType valType) { }

private XmlResolver GetResolver() { }

private void ProcessCoreReaderEvent() { }

internal BaseValidator get_Validator() { }

internal void set_Validator(BaseValidator value) { }

internal override XmlNamespaceManager get_NamespaceManager() { }

internal bool get_StandAlone() { }

internal void set_SchemaTypeObject(object value) { }

internal object get_TypedValueObject() { }

internal void set_TypedValueObject(object value) { }

internal bool AddDefaultAttribute(SchemaAttDef attdef) { }

internal override IDtdInfo get_DtdInfo() { }

internal void ValidateDefaultAttributeOnUse(IDtdDefaultAttributeInfo defaultAttribute, XmlTextReaderImpl coreReader) { }

}

private enum XmlValidatingReaderImpl.ParsingFunction // TypeDefIndex: 1919
{
	public int value__; 
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
{
	private XmlValidatingReaderImpl reader; 
	private ValidationEventHandler eventHandler; 

private object System.Xml.IValidationEventHandling.EventHandler { get; }


internal void .ctor(XmlValidatingReaderImpl reader) { }

private object System.Xml.IValidationEventHandling.get_EventHandler() { }

private void System.Xml.IValidationEventHandling.SendEvent(Exception exception, XmlSeverityType severity) { }

internal void AddHandler(ValidationEventHandler handler) { }

}

internal class XmlWellFormedWriter : XmlWriter // TypeDefIndex: 1921
{
	private XmlWriter writer; 
	private XmlRawWriter rawWriter; 
	private IXmlNamespaceResolver predefinedNamespaces; 
	private XmlWellFormedWriter.Namespace[] nsStack; 
	private int nsTop; 
	private Dictionary<string, int> nsHashtable; 
	private bool useNsHashtable; 
	private XmlWellFormedWriter.ElementScope[] elemScopeStack; 
	private int elemTop; 
	private XmlWellFormedWriter.AttrName[] attrStack; 
	private int attrCount; 
	private Dictionary<string, int> attrHashTable; 
	private XmlWellFormedWriter.SpecialAttribute specAttr; 
	private XmlWellFormedWriter.AttributeValueCache attrValueCache; 
	private string curDeclPrefix; 
	private XmlWellFormedWriter.State[] stateTable; 
	private XmlWellFormedWriter.State currentState; 
	private bool checkCharacters; 
	private bool omitDuplNamespaces; 
	private bool writeEndDocumentOnClose; 
	private ConformanceLevel conformanceLevel; 
	private bool dtdWritten; 
	private bool xmlDeclFollows; 
	private XmlCharType xmlCharType; 
	private SecureStringHasher hasher; 
	internal static readonly string[] stateName; 
	internal static readonly string[] tokenName; 
	private static WriteState[] state2WriteState; 
	private static readonly XmlWellFormedWriter.State[] StateTableDocument; 
	private static readonly XmlWellFormedWriter.State[] StateTableAuto; 

public override WriteState WriteState { get; }
internal XmlRawWriter RawWriter { get; }
private bool SaveAttrValue { get; }
private bool InBase64 { get; }
private bool IsClosedOrErrorState { get; }


internal void .ctor(XmlWriter writer, XmlWriterSettings settings) { }

public override WriteState get_WriteState() { }

public override void WriteStartDocument() { }

public override void WriteStartDocument(bool standalone) { }

public override void WriteEndDocument() { }

public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

public override void WriteStartElement(string prefix, string localName, string ns) { }

public override void WriteEndElement() { }

public override void WriteFullEndElement() { }

public override void WriteStartAttribute(string prefix, string localName, string namespaceName) { }

public override void WriteEndAttribute() { }

public override void WriteCData(string text) { }

public override void WriteComment(string text) { }

public override void WriteProcessingInstruction(string name, string text) { }

public override void WriteEntityRef(string name) { }

public override void WriteCharEntity(char ch) { }

public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

public override void WriteWhitespace(string ws) { }

public override void WriteString(string text) { }

public override void WriteChars(char[] buffer, int index, int count) { }

public override void WriteRaw(char[] buffer, int index, int count) { }

public override void WriteRaw(string data) { }

public override void WriteBase64(byte[] buffer, int index, int count) { }

public override void Close() { }

public override void Flush() { }

public override string LookupPrefix(string ns) { }

public override void WriteValue(string value) { }

public override void WriteBinHex(byte[] buffer, int index, int count) { }

internal XmlRawWriter get_RawWriter() { }

private bool get_SaveAttrValue() { }

private bool get_InBase64() { }

private void SetSpecialAttribute(XmlWellFormedWriter.SpecialAttribute special) { }

private void WriteStartDocumentImpl(XmlStandalone standalone) { }

private void StartFragment() { }

private void PushNamespaceImplicit(string prefix, string ns) { }

private bool PushNamespaceExplicit(string prefix, string ns) { }

private void AddNamespace(string prefix, string ns, XmlWellFormedWriter.NamespaceKind kind) { }

private void AddToNamespaceHashtable(int namespaceIndex) { }

private int LookupNamespaceIndex(string prefix) { }

private void PopNamespaces(int indexFrom, int indexTo) { }

private static XmlException DupAttrException(string prefix, string localName) { }

private void AdvanceState(XmlWellFormedWriter.Token token) { }

private void StartElementContent() { }

private static string GetStateName(XmlWellFormedWriter.State state) { }

internal string LookupNamespace(string prefix) { }

private string LookupLocalNamespace(string prefix) { }

private string GeneratePrefix() { }

private void CheckNCName(string ncname) { }

private static Exception InvalidCharsException(string name, int badCharIndex) { }

private void ThrowInvalidStateTransition(XmlWellFormedWriter.Token token, XmlWellFormedWriter.State currentState) { }

private bool get_IsClosedOrErrorState() { }

private void AddAttribute(string prefix, string localName, string namespaceName) { }

private void AddToAttrHashTable(int attributeIndex) { }

private static void .cctor() { }

}

private enum XmlWellFormedWriter.State // TypeDefIndex: 1922
{
	public int value__; 
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
{
	public int value__; 
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
{
	private XmlWellFormedWriter wfWriter; 


internal void .ctor(XmlWellFormedWriter wfWriter) { }

private IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

}

private struct XmlWellFormedWriter.ElementScope // TypeDefIndex: 1925
{
	internal int prevNSTop; 
	internal string prefix; 
	internal string localName; 
	internal string namespaceUri; 
	internal XmlSpace xmlSpace; 
	internal string xmlLang; 


internal void Set(string prefix, string localName, string namespaceUri, int prevNSTop) { }

internal void WriteEndElement(XmlRawWriter rawWriter) { }

internal void WriteFullEndElement(XmlRawWriter rawWriter) { }

}

private enum XmlWellFormedWriter.NamespaceKind // TypeDefIndex: 1926
{
	public int value__; 
public const XmlWellFormedWriter.NamespaceKind Written = 0;
public const XmlWellFormedWriter.NamespaceKind NeedToWrite = 1;
public const XmlWellFormedWriter.NamespaceKind Implied = 2;
public const XmlWellFormedWriter.NamespaceKind Special = 3;

}

private struct XmlWellFormedWriter.Namespace // TypeDefIndex: 1927
{
	internal string prefix; 
	internal string namespaceUri; 
	internal XmlWellFormedWriter.NamespaceKind kind; 
	internal int prevNsIndex; 


internal void Set(string prefix, string namespaceUri, XmlWellFormedWriter.NamespaceKind kind) { }

internal void WriteDecl(XmlWriter writer, XmlRawWriter rawWriter) { }

}

private struct XmlWellFormedWriter.AttrName // TypeDefIndex: 1928
{
	internal string prefix; 
	internal string namespaceUri; 
	internal string localName; 
	internal int prev; 


internal void Set(string prefix, string localName, string namespaceUri) { }

internal bool IsDuplicate(string prefix, string localName, string namespaceUri) { }

}

private enum XmlWellFormedWriter.SpecialAttribute // TypeDefIndex: 1929
{
	public int value__; 
public const XmlWellFormedWriter.SpecialAttribute No = 0;
public const XmlWellFormedWriter.SpecialAttribute DefaultXmlns = 1;
public const XmlWellFormedWriter.SpecialAttribute PrefixedXmlns = 2;
public const XmlWellFormedWriter.SpecialAttribute XmlSpace = 3;
public const XmlWellFormedWriter.SpecialAttribute XmlLang = 4;

}

private class XmlWellFormedWriter.AttributeValueCache // TypeDefIndex: 1930
{
	private StringBuilder stringValue; 
	private string singleStringValue; 
	private XmlWellFormedWriter.AttributeValueCache.Item[] items; 
	private int firstItem; 
	private int lastItem; 

internal string StringValue { get; }


internal string get_StringValue() { }

internal void WriteEntityRef(string name) { }

internal void WriteCharEntity(char ch) { }

internal void WriteSurrogateCharEntity(char lowChar, char highChar) { }

internal void WriteWhitespace(string ws) { }

internal void WriteString(string text) { }

internal void WriteChars(char[] buffer, int index, int count) { }

internal void WriteRaw(char[] buffer, int index, int count) { }

internal void WriteRaw(string data) { }

internal void WriteValue(string value) { }

internal void Replay(XmlWriter writer) { }

internal void Trim() { }

internal void Clear() { }

private void StartComplexValue() { }

private void AddItem(XmlWellFormedWriter.AttributeValueCache.ItemType type, object data) { }

public void .ctor() { }

}

private enum XmlWellFormedWriter.AttributeValueCache.ItemType // TypeDefIndex: 1931
{
	public int value__; 
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
{
	internal XmlWellFormedWriter.AttributeValueCache.ItemType type; 
	internal object data; 


internal void .ctor() { }

internal void Set(XmlWellFormedWriter.AttributeValueCache.ItemType type, object data) { }

}

private class XmlWellFormedWriter.AttributeValueCache.BufferChunk // TypeDefIndex: 1933
{
	internal char[] buffer; 
	internal int index; 
	internal int count; 


internal void .ctor(char[] buffer, int index, int count) { }

}

public abstract class XmlWriter : IDisposable // TypeDefIndex: 1935
{
	private char[] writeNodeBuffer; 

public abstract WriteState WriteState { get; }


public abstract void WriteStartDocument();

public abstract void WriteStartDocument(bool standalone);

public abstract void WriteEndDocument();

public abstract void WriteDocType(string name, string pubid, string sysid, string subset);

public void WriteStartElement(string localName, string ns) { }

public abstract void WriteStartElement(string prefix, string localName, string ns);

public abstract void WriteEndElement();

public abstract void WriteFullEndElement();

public void WriteAttributeString(string localName, string ns, string value) { }

public void WriteAttributeString(string localName, string value) { }

public void WriteAttributeString(string prefix, string localName, string ns, string value) { }

public abstract void WriteStartAttribute(string prefix, string localName, string ns);

public abstract void WriteEndAttribute();

public abstract void WriteCData(string text);

public abstract void WriteComment(string text);

public abstract void WriteProcessingInstruction(string name, string text);

public abstract void WriteEntityRef(string name);

public abstract void WriteCharEntity(char ch);

public abstract void WriteWhitespace(string ws);

public abstract void WriteString(string text);

public abstract void WriteSurrogateCharEntity(char lowChar, char highChar);

public abstract void WriteChars(char[] buffer, int index, int count);

public abstract void WriteRaw(char[] buffer, int index, int count);

public abstract void WriteRaw(string data);

public abstract void WriteBase64(byte[] buffer, int index, int count);

public virtual void WriteBinHex(byte[] buffer, int index, int count) { }

public abstract WriteState get_WriteState();

public virtual void Close() { }

public abstract void Flush();

public abstract string LookupPrefix(string ns);

public virtual void WriteValue(string value) { }

public virtual void WriteAttributes(XmlReader reader, bool defattr) { }

public virtual void WriteNode(XmlReader reader, bool defattr) { }

public void WriteElementString(string localName, string ns, string value) { }

public void Dispose() { }

protected virtual void Dispose(bool disposing) { }

public static XmlWriter Create(Stream output, XmlWriterSettings settings) { }

public static XmlWriter Create(TextWriter output, XmlWriterSettings settings) { }

protected void .ctor() { }

}

public enum XmlOutputMethod // TypeDefIndex: 1936
{
	public int value__; 
public const XmlOutputMethod Xml = 0;
public const XmlOutputMethod Html = 1;
public const XmlOutputMethod Text = 2;
public const XmlOutputMethod AutoDetect = 3;

}

internal enum XmlStandalone // TypeDefIndex: 1938
{
	public int value__; 
public const XmlStandalone Omit = 0;
public const XmlStandalone Yes = 1;
public const XmlStandalone No = 2;

}

public sealed class XmlWriterSettings // TypeDefIndex: 1939
{
	private bool useAsync; 
	private Encoding encoding; 
	private bool omitXmlDecl; 
	private NewLineHandling newLineHandling; 
	private string newLineChars; 
	private TriState indent; 
	private string indentChars; 
	private bool newLineOnAttributes; 
	private bool closeOutput; 
	private NamespaceHandling namespaceHandling; 
	private ConformanceLevel conformanceLevel; 
	private bool checkCharacters; 
	private bool writeEndDocumentOnClose; 
	private XmlOutputMethod outputMethod; 
	private List<XmlQualifiedName> cdataSections; 
	private bool doNotEscapeUriAttributes; 
	private bool mergeCDataSections; 
	private string mediaType; 
	private string docTypeSystem; 
	private string docTypePublic; 
	private XmlStandalone standalone; 
	private bool autoXmlDecl; 
	private bool isReadOnly; 

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


public void .ctor() { }

public bool get_Async() { }

public Encoding get_Encoding() { }

public bool get_OmitXmlDeclaration() { }

public void set_OmitXmlDeclaration(bool value) { }

public NewLineHandling get_NewLineHandling() { }

public string get_NewLineChars() { }

public bool get_Indent() { }

public void set_Indent(bool value) { }

public string get_IndentChars() { }

public bool get_NewLineOnAttributes() { }

public bool get_CloseOutput() { }

public ConformanceLevel get_ConformanceLevel() { }

public void set_ConformanceLevel(ConformanceLevel value) { }

public bool get_CheckCharacters() { }

public NamespaceHandling get_NamespaceHandling() { }

public void set_NamespaceHandling(NamespaceHandling value) { }

public bool get_WriteEndDocumentOnClose() { }

public XmlOutputMethod get_OutputMethod() { }

internal void set_OutputMethod(XmlOutputMethod value) { }

public XmlWriterSettings Clone() { }

internal List<XmlQualifiedName> get_CDataSectionElements() { }

public bool get_DoNotEscapeUriAttributes() { }

internal bool get_MergeCDataSections() { }

internal string get_MediaType() { }

internal string get_DocTypeSystem() { }

internal string get_DocTypePublic() { }

internal XmlStandalone get_Standalone() { }

internal bool get_AutoXmlDeclaration() { }

internal TriState get_IndentInternal() { }

internal bool get_IsQuerySpecific() { }

internal XmlWriter CreateWriter(Stream output) { }

internal XmlWriter CreateWriter(TextWriter output) { }

internal void set_ReadOnly(bool value) { }

private void CheckReadOnly(string propertyName) { }

private void Initialize() { }

}

internal class XsdCachingReader : XmlReader, IXmlLineInfo // TypeDefIndex: 1940
{
	private XmlReader coreReader; 
	private XmlNameTable coreReaderNameTable; 
	private ValidatingReaderNodeData[] contentEvents; 
	private ValidatingReaderNodeData[] attributeEvents; 
	private ValidatingReaderNodeData cachedNode; 
	private XsdCachingReader.CachingReaderState cacheState; 
	private int contentIndex; 
	private int attributeCount; 
	private bool returnOriginalStringValues; 
	private CachingEventHandler cacheHandler; 
	private int currentAttrIndex; 
	private int currentContentIndex; 
	private bool readAhead; 
	private IXmlLineInfo lineInfo; 
	private ValidatingReaderNodeData textNode; 

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


internal void .ctor(XmlReader reader, IXmlLineInfo lineInfo, CachingEventHandler handlerMethod) { }

private void Init() { }

internal void Reset(XmlReader reader) { }

public override XmlReaderSettings get_Settings() { }

public override XmlNodeType get_NodeType() { }

public override string get_Name() { }

public override string get_LocalName() { }

public override string get_NamespaceURI() { }

public override string get_Prefix() { }

public override string get_Value() { }

public override int get_Depth() { }

public override string get_BaseURI() { }

public override bool get_IsEmptyElement() { }

public override bool get_IsDefault() { }

public override char get_QuoteChar() { }

public override XmlSpace get_XmlSpace() { }

public override string get_XmlLang() { }

public override int get_AttributeCount() { }

public override string GetAttribute(string name) { }

public override string GetAttribute(string name, string namespaceURI) { }

public override string GetAttribute(int i) { }

public override bool MoveToAttribute(string name) { }

public override void MoveToAttribute(int i) { }

public override bool MoveToFirstAttribute() { }

public override bool MoveToNextAttribute() { }

public override bool MoveToElement() { }

public override bool Read() { }

internal ValidatingReaderNodeData RecordTextNode(string textValue, string originalStringValue, int depth, int lineNo, int linePos) { }

internal void SwitchTextNodeAndEndElement(string textValue, string originalStringValue) { }

internal void RecordEndElementNode() { }

public override bool get_EOF() { }

public override void Close() { }

public override ReadState get_ReadState() { }

public override void Skip() { }

public override XmlNameTable get_NameTable() { }

public override string LookupNamespace(string prefix) { }

public override void ResolveEntity() { }

public override bool ReadAttributeValue() { }

private bool System.Xml.IXmlLineInfo.HasLineInfo() { }

private int System.Xml.IXmlLineInfo.get_LineNumber() { }

private int System.Xml.IXmlLineInfo.get_LinePosition() { }

internal void SetToReplayMode() { }

internal XmlReader GetCoreReader() { }

internal IXmlLineInfo GetLineInfo() { }

private void ClearAttributesInfo() { }

private ValidatingReaderNodeData AddAttribute(int attIndex) { }

private ValidatingReaderNodeData AddContent(XmlNodeType nodeType) { }

private void RecordAttributes() { }

private int GetAttributeIndexWithoutPrefix(string name) { }

private int GetAttributeIndexWithPrefix(string name) { }

private ValidatingReaderNodeData CreateDummyTextNode(string attributeValue, int depth) { }

}

private enum XsdCachingReader.CachingReaderState // TypeDefIndex: 1941
{
	public int value__; 
public const XsdCachingReader.CachingReaderState None = 0;
public const XsdCachingReader.CachingReaderState Init = 1;
public const XsdCachingReader.CachingReaderState Record = 2;
public const XsdCachingReader.CachingReaderState Replay = 3;
public const XsdCachingReader.CachingReaderState ReaderClosed = 4;
public const XsdCachingReader.CachingReaderState Error = 5;

}

internal class XsdValidatingReader : XmlReader, IXmlSchemaInfo, IXmlLineInfo, IXmlNamespaceResolver // TypeDefIndex: 1944
{
	private XmlReader coreReader; 
	private IXmlNamespaceResolver coreReaderNSResolver; 
	private IXmlNamespaceResolver thisNSResolver; 
	private XmlSchemaValidator validator; 
	private XmlResolver xmlResolver; 
	private ValidationEventHandler validationEvent; 
	private XsdValidatingReader.ValidatingReaderState validationState; 
	private XmlValueGetter valueGetter; 
	private XmlNamespaceManager nsManager; 
	private bool manageNamespaces; 
	private bool processInlineSchema; 
	private bool replayCache; 
	private ValidatingReaderNodeData cachedNode; 
	private AttributePSVIInfo attributePSVI; 
	private int attributeCount; 
	private int coreReaderAttributeCount; 
	private int currentAttrIndex; 
	private AttributePSVIInfo[] attributePSVINodes; 
	private ArrayList defaultAttributes; 
	private Parser inlineSchemaParser; 
	private object atomicValue; 
	private XmlSchemaInfo xmlSchemaInfo; 
	private string originalAtomicValueString; 
	private XmlNameTable coreReaderNameTable; 
	private XsdCachingReader cachingReader; 
	private ValidatingReaderNodeData textNode; 
	private string NsXmlNs; 
	private string NsXs; 
	private string NsXsi; 
	private string XsiType; 
	private string XsiNil; 
	private string XsdSchema; 
	private string XsiSchemaLocation; 
	private string XsiNoNamespaceSchemaLocation; 
	private XmlCharType xmlCharType; 
	private IXmlLineInfo lineInfo; 
	private ReadContentAsBinaryHelper readBinaryHelper; 
	private XsdValidatingReader.ValidatingReaderState savedState; 
	private static Type TypeOfString; 

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


internal void .ctor(XmlReader reader, XmlResolver xmlResolver, XmlReaderSettings readerSettings, XmlSchemaObject partialValidationType) { }

internal void .ctor(XmlReader reader, XmlResolver xmlResolver, XmlReaderSettings readerSettings) { }

private void Init() { }

private void SetupValidator(XmlReaderSettings readerSettings, XmlReader reader, XmlSchemaObject partialValidationType) { }

public override XmlReaderSettings get_Settings() { }

public override XmlNodeType get_NodeType() { }

public override string get_Name() { }

public override string get_LocalName() { }

public override string get_NamespaceURI() { }

public override string get_Prefix() { }

public override string get_Value() { }

public override int get_Depth() { }

public override string get_BaseURI() { }

public override bool get_IsEmptyElement() { }

public override bool get_IsDefault() { }

public override char get_QuoteChar() { }

public override XmlSpace get_XmlSpace() { }

public override string get_XmlLang() { }

public override IXmlSchemaInfo get_SchemaInfo() { }

public override Type get_ValueType() { }

public override int get_AttributeCount() { }

public override string GetAttribute(string name) { }

public override string GetAttribute(string name, string namespaceURI) { }

public override string GetAttribute(int i) { }

public override bool MoveToAttribute(string name) { }

public override void MoveToAttribute(int i) { }

public override bool MoveToFirstAttribute() { }

public override bool MoveToNextAttribute() { }

public override bool MoveToElement() { }

public override bool Read() { }

public override bool get_EOF() { }

public override void Close() { }

public override ReadState get_ReadState() { }

public override void Skip() { }

public override XmlNameTable get_NameTable() { }

public override string LookupNamespace(string prefix) { }

public override void ResolveEntity() { }

public override bool ReadAttributeValue() { }

private bool System.Xml.Schema.IXmlSchemaInfo.get_IsDefault() { }

private bool System.Xml.Schema.IXmlSchemaInfo.get_IsNil() { }

private XmlSchemaValidity System.Xml.Schema.IXmlSchemaInfo.get_Validity() { }

private XmlSchemaSimpleType System.Xml.Schema.IXmlSchemaInfo.get_MemberType() { }

private XmlSchemaType System.Xml.Schema.IXmlSchemaInfo.get_SchemaType() { }

private XmlSchemaElement System.Xml.Schema.IXmlSchemaInfo.get_SchemaElement() { }

private XmlSchemaAttribute System.Xml.Schema.IXmlSchemaInfo.get_SchemaAttribute() { }

public bool HasLineInfo() { }

public int get_LineNumber() { }

public int get_LinePosition() { }

private IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

private object GetStringValue() { }

private XmlSchemaInfo get_AttributeSchemaInfo() { }

private void ProcessReaderEvent() { }

private void ProcessElementEvent() { }

private void ProcessEndElementEvent() { }

private void ValidateAttributes() { }

private void ClearAttributesInfo() { }

private AttributePSVIInfo GetAttributePSVI(string name) { }

private AttributePSVIInfo GetAttributePSVI(string localName, string ns) { }

private ValidatingReaderNodeData GetDefaultAttribute(string name, bool updatePosition) { }

private ValidatingReaderNodeData GetDefaultAttribute(string attrLocalName, string ns, bool updatePosition) { }

private AttributePSVIInfo AddAttributePSVI(int attIndex) { }

private bool IsXSDRoot(string localName, string ns) { }

private void ProcessInlineSchema() { }

private void ReadAheadForMemberType() { }

private void GetIsDefault() { }

private void GetMemberType() { }

private XsdCachingReader GetCachingReader() { }

internal ValidatingReaderNodeData CreateDummyTextNode(string attributeValue, int depth) { }

internal void CachingCallBack(XsdCachingReader cachingReader) { }

private string GetOriginalAtomicValueStringOfElement() { }

}

private enum XsdValidatingReader.ValidatingReaderState // TypeDefIndex: 1945
{
	public int value__; 
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
{
	private XmlName name; 
	private XmlLinkedNode lastChild; 

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


internal void .ctor(XmlName name, XmlDocument doc) { }

internal int get_LocalNameHash() { }

protected internal void .ctor(string prefix, string localName, string namespaceURI, XmlDocument doc) { }

internal XmlName get_XmlName() { }

internal void set_XmlName(XmlName value) { }

public override XmlNode CloneNode(bool deep) { }

public override XmlNode get_ParentNode() { }

public override string get_Name() { }

public override string get_LocalName() { }

public override string get_NamespaceURI() { }

public override string get_Prefix() { }

public override void set_Prefix(string value) { }

public override XmlNodeType get_NodeType() { }

public override XmlDocument get_OwnerDocument() { }

public override string get_Value() { }

public override void set_Value(string value) { }

public override IXmlSchemaInfo get_SchemaInfo() { }

public override void set_InnerText(string value) { }

internal bool PrepareOwnerElementInElementIdAttrMap() { }

internal void ResetOwnerElementInElementIdAttrMap(string oldInnerText) { }

internal override bool get_IsContainer() { }

internal override XmlNode AppendChildForLoad(XmlNode newChild, XmlDocument doc) { }

internal override XmlLinkedNode get_LastNode() { }

internal override void set_LastNode(XmlLinkedNode value) { }

internal override bool IsValidChildType(XmlNodeType type) { }

public virtual bool get_Specified() { }

public override XmlNode InsertBefore(XmlNode newChild, XmlNode refChild) { }

public override XmlNode InsertAfter(XmlNode newChild, XmlNode refChild) { }

public override XmlNode RemoveChild(XmlNode oldChild) { }

public override XmlNode PrependChild(XmlNode newChild) { }

public override XmlNode AppendChild(XmlNode newChild) { }

public virtual XmlElement get_OwnerElement() { }

public override void set_InnerXml(string value) { }

public override void WriteTo(XmlWriter w) { }

public override void WriteContentTo(XmlWriter w) { }

public override string get_BaseURI() { }

internal override void SetParent(XmlNode node) { }

internal override XmlSpace get_XmlSpace() { }

internal override string get_XmlLang() { }

}

public sealed class XmlAttributeCollection : XmlNamedNodeMap, ICollection, IEnumerable // TypeDefIndex: 1948
{
public XmlAttribute ItemOf { get; }
public XmlAttribute ItemOf { get; }
public XmlAttribute ItemOf { get; }
private object System.Collections.ICollection.SyncRoot { get; }
private int System.Collections.ICollection.Count { get; }


internal void .ctor(XmlNode parent) { }

public XmlAttribute get_ItemOf(int i) { }

public XmlAttribute get_ItemOf(string name) { }

public XmlAttribute get_ItemOf(string localName, string namespaceURI) { }

internal int FindNodeOffsetNS(XmlAttribute node) { }

public override XmlNode SetNamedItem(XmlNode node) { }

public XmlAttribute Append(XmlAttribute node) { }

public XmlAttribute Remove(XmlAttribute node) { }

public XmlAttribute RemoveAt(int i) { }

public void RemoveAll() { }

private void System.Collections.ICollection.CopyTo(Array array, int index) { }

private object System.Collections.ICollection.get_SyncRoot() { }

private int System.Collections.ICollection.get_Count() { }

internal override XmlNode AddNode(XmlNode node) { }

internal override XmlNode InsertNodeAt(int i, XmlNode node) { }

internal override XmlNode RemoveNodeAt(int i) { }

internal void Detach(XmlAttribute attr) { }

internal void InsertParentIntoElementIdAttrMap(XmlAttribute attr) { }

internal void RemoveParentFromElementIdAttrMap(XmlAttribute attr) { }

internal int RemoveDuplicateAttribute(XmlAttribute attr) { }

internal bool PrepareParentInElementIdAttrMap(string attrPrefix, string attrLocalName) { }

internal void ResetParentInElementIdAttrMap(string oldVal, string newVal) { }

internal XmlAttribute InternalAppendAttribute(XmlAttribute node) { }

}

public class XmlCDataSection : XmlCharacterData // TypeDefIndex: 1949
{
public override string Name { get; }
public override string LocalName { get; }
public override XmlNodeType NodeType { get; }
public override XmlNode ParentNode { get; }
internal override bool IsText { get; }


protected internal void .ctor(string data, XmlDocument doc) { }

public override string get_Name() { }

public override string get_LocalName() { }

public override XmlNodeType get_NodeType() { }

public override XmlNode get_ParentNode() { }

public override XmlNode CloneNode(bool deep) { }

public override void WriteTo(XmlWriter w) { }

public override void WriteContentTo(XmlWriter w) { }

internal override bool get_IsText() { }

}

public abstract class XmlCharacterData : XmlLinkedNode // TypeDefIndex: 1950
{
	private string data; 

public override string Value { get; set; }
public override string InnerText { get; set; }
public virtual string Data { get; set; }


protected internal void .ctor(string data, XmlDocument doc) { }

public override string get_Value() { }

public override void set_Value(string value) { }

public override string get_InnerText() { }

public override void set_InnerText(string value) { }

public virtual string get_Data() { }

public virtual void set_Data(string value) { }

internal bool CheckOnData(string data) { }

}

internal sealed class XmlChildEnumerator : IEnumerator // TypeDefIndex: 1951
{
	internal XmlNode container; 
	internal XmlNode child; 
	internal bool isFirst; 

private object System.Collections.IEnumerator.Current { get; }
internal XmlNode Current { get; }


internal void .ctor(XmlNode container) { }

private bool System.Collections.IEnumerator.MoveNext() { }

internal bool MoveNext() { }

private void System.Collections.IEnumerator.Reset() { }

private object System.Collections.IEnumerator.get_Current() { }

internal XmlNode get_Current() { }

}

internal class XmlChildNodes : XmlNodeList // TypeDefIndex: 1952
{
	private XmlNode container; 

public override int Count { get; }


public void .ctor(XmlNode container) { }

public override XmlNode Item(int i) { }

public override int get_Count() { }

public override IEnumerator GetEnumerator() { }

}

public class XmlComment : XmlCharacterData // TypeDefIndex: 1953
{
public override string Name { get; }
public override string LocalName { get; }
public override XmlNodeType NodeType { get; }


protected internal void .ctor(string comment, XmlDocument doc) { }

public override string get_Name() { }

public override string get_LocalName() { }

public override XmlNodeType get_NodeType() { }

public override XmlNode CloneNode(bool deep) { }

public override void WriteTo(XmlWriter w) { }

public override void WriteContentTo(XmlWriter w) { }

}

public class XmlDeclaration : XmlLinkedNode // TypeDefIndex: 1954
{
	private string version; 
	private string encoding; 
	private string standalone; 

public string Version { get; set; }
public string Encoding { get; set; }
public string Standalone { get; set; }
public override string Value { get; set; }
public override string InnerText { get; set; }
public override string Name { get; }
public override string LocalName { get; }
public override XmlNodeType NodeType { get; }


protected internal void .ctor(string version, string encoding, string standalone, XmlDocument doc) { }

public string get_Version() { }

internal void set_Version(string value) { }

public string get_Encoding() { }

public void set_Encoding(string value) { }

public string get_Standalone() { }

public void set_Standalone(string value) { }

public override string get_Value() { }

public override void set_Value(string value) { }

public override string get_InnerText() { }

public override void set_InnerText(string value) { }

public override string get_Name() { }

public override string get_LocalName() { }

public override XmlNodeType get_NodeType() { }

public override XmlNode CloneNode(bool deep) { }

public override void WriteTo(XmlWriter w) { }

public override void WriteContentTo(XmlWriter w) { }

private bool IsValidXmlVersion(string ver) { }

}

public class XmlDocument : XmlNode // TypeDefIndex: 1955
{
	private XmlImplementation implementation; 
	private DomNameTable domNameTable; 
	private XmlLinkedNode lastChild; 
	private XmlNamedNodeMap entities; 
	private Hashtable htElementIdMap; 
	private Hashtable htElementIDAttrDecl; 
	private SchemaInfo schemaInfo; 
	private XmlSchemaSet schemas; 
	private bool reportValidity; 
	private bool actualLoadingStatus; 
	private XmlNodeChangedEventHandler onNodeInsertingDelegate; 
	private XmlNodeChangedEventHandler onNodeInsertedDelegate; 
	private XmlNodeChangedEventHandler onNodeRemovingDelegate; 
	private XmlNodeChangedEventHandler onNodeRemovedDelegate; 
	private XmlNodeChangedEventHandler onNodeChangingDelegate; 
	private XmlNodeChangedEventHandler onNodeChangedDelegate; 
	internal bool fEntRefNodesPresent; 
	internal bool fCDataNodesPresent; 
	private bool preserveWhitespace; 
	private bool isLoading; 
	internal string strDocumentName; 
	internal string strDocumentFragmentName; 
	internal string strCommentName; 
	internal string strTextName; 
	internal string strCDataSectionName; 
	internal string strEntityName; 
	internal string strID; 
	internal string strXmlns; 
	internal string strXml; 
	internal string strSpace; 
	internal string strLang; 
	internal string strEmpty; 
	internal string strNonSignificantWhitespaceName; 
	internal string strSignificantWhitespaceName; 
	internal string strReservedXmlns; 
	internal string strReservedXml; 
	internal string baseURI; 
	private XmlResolver resolver; 
	internal bool bSetResolver; 
	internal object objLock; 
	internal static EmptyEnumerator EmptyEnumerator; 
	internal static IXmlSchemaInfo NotKnownSchemaInfo; 
	internal static IXmlSchemaInfo ValidSchemaInfo; 
	internal static IXmlSchemaInfo InvalidSchemaInfo; 

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


public void .ctor() { }

public void .ctor(XmlNameTable nt) { }

protected internal void .ctor(XmlImplementation imp) { }

internal SchemaInfo get_DtdSchemaInfo() { }

internal void set_DtdSchemaInfo(SchemaInfo value) { }

internal static void CheckName(string name) { }

internal XmlName AddXmlName(string prefix, string localName, string namespaceURI, IXmlSchemaInfo schemaInfo) { }

internal XmlName GetXmlName(string prefix, string localName, string namespaceURI, IXmlSchemaInfo schemaInfo) { }

internal XmlName AddAttrXmlName(string prefix, string localName, string namespaceURI, IXmlSchemaInfo schemaInfo) { }

internal bool AddIdInfo(XmlName eleName, XmlName attrName) { }

private XmlName GetIDInfoByElement_(XmlName eleName) { }

internal XmlName GetIDInfoByElement(XmlName eleName) { }

private WeakReference GetElement(ArrayList elementList, XmlElement elem) { }

internal void AddElementWithId(string id, XmlElement elem) { }

internal void RemoveElementWithId(string id, XmlElement elem) { }

public override XmlNode CloneNode(bool deep) { }

public override XmlNodeType get_NodeType() { }

public override XmlNode get_ParentNode() { }

public virtual XmlDocumentType get_DocumentType() { }

internal virtual XmlDeclaration get_Declaration() { }

public XmlImplementation get_Implementation() { }

public override string get_Name() { }

public override string get_LocalName() { }

public XmlElement get_DocumentElement() { }

internal override bool get_IsContainer() { }

internal override XmlLinkedNode get_LastNode() { }

internal override void set_LastNode(XmlLinkedNode value) { }

public override XmlDocument get_OwnerDocument() { }

public void set_Schemas(XmlSchemaSet value) { }

internal bool get_CanReportValidity() { }

internal bool get_HasSetResolver() { }

internal XmlResolver GetResolver() { }

public virtual void set_XmlResolver(XmlResolver value) { }

internal override bool IsValidChildType(XmlNodeType type) { }

private bool HasNodeTypeInPrevSiblings(XmlNodeType nt, XmlNode refNode) { }

private bool HasNodeTypeInNextSiblings(XmlNodeType nt, XmlNode refNode) { }

internal override bool CanInsertBefore(XmlNode newChild, XmlNode refChild) { }

internal override bool CanInsertAfter(XmlNode newChild, XmlNode refChild) { }

public XmlAttribute CreateAttribute(string name) { }

internal void SetDefaultNamespace(string prefix, string localName, ref string namespaceURI) { }

public virtual XmlCDataSection CreateCDataSection(string data) { }

public virtual XmlComment CreateComment(string data) { }

public virtual XmlDocumentType CreateDocumentType(string name, string publicId, string systemId, string internalSubset) { }

public virtual XmlDocumentFragment CreateDocumentFragment() { }

public XmlElement CreateElement(string name) { }

internal void AddDefaultAttributes(XmlElement elem) { }

private SchemaElementDecl GetSchemaElementDecl(XmlElement elem) { }

private XmlAttribute PrepareDefaultAttribute(SchemaAttDef attdef, string attrPrefix, string attrLocalname, string attrNamespaceURI) { }

public virtual XmlEntityReference CreateEntityReference(string name) { }

public virtual XmlProcessingInstruction CreateProcessingInstruction(string target, string data) { }

public virtual XmlDeclaration CreateXmlDeclaration(string version, string encoding, string standalone) { }

public virtual XmlText CreateTextNode(string text) { }

public virtual XmlSignificantWhitespace CreateSignificantWhitespace(string text) { }

public virtual XmlWhitespace CreateWhitespace(string text) { }

public XmlAttribute CreateAttribute(string qualifiedName, string namespaceURI) { }

public XmlElement CreateElement(string qualifiedName, string namespaceURI) { }

private XmlNode ImportNodeInternal(XmlNode node, bool deep) { }

private void ImportAttributes(XmlNode fromElem, XmlNode toElem) { }

private void ImportChildren(XmlNode fromNode, XmlNode toNode, bool deep) { }

public XmlNameTable get_NameTable() { }

public virtual XmlAttribute CreateAttribute(string prefix, string localName, string namespaceURI) { }

protected internal virtual XmlAttribute CreateDefaultAttribute(string prefix, string localName, string namespaceURI) { }

public virtual XmlElement CreateElement(string prefix, string localName, string namespaceURI) { }

public override bool get_IsReadOnly() { }

internal XmlNamedNodeMap get_Entities() { }

internal void set_Entities(XmlNamedNodeMap value) { }

internal bool get_IsLoading() { }

internal void set_IsLoading(bool value) { }

internal bool get_ActualLoadingStatus() { }

public virtual XmlNode ReadNode(XmlReader reader) { }

private XmlTextReader SetupReader(XmlTextReader tr) { }

public virtual void Load(XmlReader reader) { }

public virtual void LoadXml(string xml) { }

public override void set_InnerText(string value) { }

public override void set_InnerXml(string value) { }

public virtual void Save(XmlWriter w) { }

public override void WriteTo(XmlWriter w) { }

public override void WriteContentTo(XmlWriter xw) { }

internal override XmlNodeChangedEventArgs GetEventArgs(XmlNode node, XmlNode oldParent, XmlNode newParent, string oldValue, string newValue, XmlNodeChangedAction action) { }

internal XmlNodeChangedEventArgs GetInsertEventArgsForLoad(XmlNode node, XmlNode newParent) { }

internal override void BeforeEvent(XmlNodeChangedEventArgs args) { }

internal override void AfterEvent(XmlNodeChangedEventArgs args) { }

internal XmlAttribute GetDefaultAttribute(XmlElement elem, string attrPrefix, string attrLocalname, string attrNamespaceURI) { }

internal string get_Version() { }

internal string get_Encoding() { }

internal string get_Standalone() { }

internal XmlEntity GetEntityNode(string name) { }

public override IXmlSchemaInfo get_SchemaInfo() { }

public override string get_BaseURI() { }

internal void SetBaseURI(string inBaseURI) { }

internal override XmlNode AppendChildForLoad(XmlNode newChild, XmlDocument doc) { }

private static void .cctor() { }

}

public class XmlDocumentFragment : XmlNode // TypeDefIndex: 1956
{
	private XmlLinkedNode lastChild; 

public override string Name { get; }
public override string LocalName { get; }
public override XmlNodeType NodeType { get; }
public override XmlNode ParentNode { get; }
public override XmlDocument OwnerDocument { get; }
public override string InnerXml { set; }
internal override bool IsContainer { get; }
internal override XmlLinkedNode LastNode { get; set; }


protected internal void .ctor(XmlDocument ownerDocument) { }

public override string get_Name() { }

public override string get_LocalName() { }

public override XmlNodeType get_NodeType() { }

public override XmlNode get_ParentNode() { }

public override XmlDocument get_OwnerDocument() { }

public override void set_InnerXml(string value) { }

public override XmlNode CloneNode(bool deep) { }

internal override bool get_IsContainer() { }

internal override XmlLinkedNode get_LastNode() { }

internal override void set_LastNode(XmlLinkedNode value) { }

internal override bool IsValidChildType(XmlNodeType type) { }

internal override bool CanInsertAfter(XmlNode newChild, XmlNode refChild) { }

internal override bool CanInsertBefore(XmlNode newChild, XmlNode refChild) { }

public override void WriteTo(XmlWriter w) { }

public override void WriteContentTo(XmlWriter w) { }

}

public class XmlDocumentType : XmlLinkedNode // TypeDefIndex: 1957
{
	private string name; 
	private string publicId; 
	private string systemId; 
	private string internalSubset; 
	private bool namespaces; 
	private XmlNamedNodeMap entities; 
	private XmlNamedNodeMap notations; 
	private SchemaInfo schemaInfo; 

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


protected internal void .ctor(string name, string publicId, string systemId, string internalSubset, XmlDocument doc) { }

public override string get_Name() { }

public override string get_LocalName() { }

public override XmlNodeType get_NodeType() { }

public override XmlNode CloneNode(bool deep) { }

public override bool get_IsReadOnly() { }

public XmlNamedNodeMap get_Entities() { }

public XmlNamedNodeMap get_Notations() { }

public string get_PublicId() { }

public string get_SystemId() { }

public string get_InternalSubset() { }

internal bool get_ParseWithNamespaces() { }

public override void WriteTo(XmlWriter w) { }

public override void WriteContentTo(XmlWriter w) { }

internal SchemaInfo get_DtdSchemaInfo() { }

internal void set_DtdSchemaInfo(SchemaInfo value) { }

}

public class XmlElement : XmlLinkedNode // TypeDefIndex: 1958
{
	private XmlName name; 
	private XmlAttributeCollection attributes; 
	private XmlLinkedNode lastChild; 

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


internal void .ctor(XmlName name, bool empty, XmlDocument doc) { }

protected internal void .ctor(string prefix, string localName, string namespaceURI, XmlDocument doc) { }

internal XmlName get_XmlName() { }

internal void set_XmlName(XmlName value) { }

public override XmlNode CloneNode(bool deep) { }

public override string get_Name() { }

public override string get_LocalName() { }

public override string get_NamespaceURI() { }

public override string get_Prefix() { }

public override void set_Prefix(string value) { }

public override XmlNodeType get_NodeType() { }

public override XmlNode get_ParentNode() { }

public override XmlDocument get_OwnerDocument() { }

internal override bool get_IsContainer() { }

internal override XmlNode AppendChildForLoad(XmlNode newChild, XmlDocument doc) { }

public bool get_IsEmpty() { }

public void set_IsEmpty(bool value) { }

internal override XmlLinkedNode get_LastNode() { }

internal override void set_LastNode(XmlLinkedNode value) { }

internal override bool IsValidChildType(XmlNodeType type) { }

public override XmlAttributeCollection get_Attributes() { }

public virtual bool get_HasAttributes() { }

public virtual string GetAttribute(string name) { }

public virtual void SetAttribute(string name, string value) { }

public virtual XmlAttribute GetAttributeNode(string name) { }

public virtual XmlAttribute SetAttributeNode(XmlAttribute newAttr) { }

public virtual string GetAttribute(string localName, string namespaceURI) { }

public virtual string SetAttribute(string localName, string namespaceURI, string value) { }

public virtual XmlAttribute GetAttributeNode(string localName, string namespaceURI) { }

public virtual XmlAttribute SetAttributeNode(string localName, string namespaceURI) { }

public virtual bool HasAttribute(string name) { }

public override void WriteTo(XmlWriter w) { }

private static void WriteElementTo(XmlWriter writer, XmlElement e) { }

private void WriteStartElement(XmlWriter w) { }

public override void WriteContentTo(XmlWriter w) { }

public virtual void RemoveAllAttributes() { }

public override void RemoveAll() { }

internal void RemoveAllChildren() { }

public override IXmlSchemaInfo get_SchemaInfo() { }

public override void set_InnerXml(string value) { }

public override string get_InnerText() { }

public override void set_InnerText(string value) { }

public override XmlNode get_NextSibling() { }

internal override void SetParent(XmlNode node) { }

}

public class XmlEntity : XmlNode // TypeDefIndex: 1959
{
	private string publicId; 
	private string systemId; 
	private string notationName; 
	private string name; 
	private string unparsedReplacementStr; 
	private string baseURI; 
	private XmlLinkedNode lastChild; 
	private bool childrenFoliating; 

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


internal void .ctor(string name, string strdata, string publicId, string systemId, string notationName, XmlDocument doc) { }

public override XmlNode CloneNode(bool deep) { }

public override bool get_IsReadOnly() { }

public override string get_Name() { }

public override string get_LocalName() { }

public override string get_InnerText() { }

public override void set_InnerText(string value) { }

internal override bool get_IsContainer() { }

internal override XmlLinkedNode get_LastNode() { }

internal override void set_LastNode(XmlLinkedNode value) { }

internal override bool IsValidChildType(XmlNodeType type) { }

public override XmlNodeType get_NodeType() { }

public string get_SystemId() { }

public override void set_InnerXml(string value) { }

public override void WriteTo(XmlWriter w) { }

public override void WriteContentTo(XmlWriter w) { }

public override string get_BaseURI() { }

internal void SetBaseURI(string inBaseURI) { }

}

public class XmlEntityReference : XmlLinkedNode // TypeDefIndex: 1960
{
	private string name; 
	private XmlLinkedNode lastChild; 

public override string Name { get; }
public override string LocalName { get; }
public override string Value { get; set; }
public override XmlNodeType NodeType { get; }
public override bool IsReadOnly { get; }
internal override bool IsContainer { get; }
internal override XmlLinkedNode LastNode { get; set; }
public override string BaseURI { get; }
internal string ChildBaseURI { get; }


protected internal void .ctor(string name, XmlDocument doc) { }

public override string get_Name() { }

public override string get_LocalName() { }

public override string get_Value() { }

public override void set_Value(string value) { }

public override XmlNodeType get_NodeType() { }

public override XmlNode CloneNode(bool deep) { }

public override bool get_IsReadOnly() { }

internal override bool get_IsContainer() { }

internal override void SetParent(XmlNode node) { }

internal override void SetParentForLoad(XmlNode node) { }

internal override XmlLinkedNode get_LastNode() { }

internal override void set_LastNode(XmlLinkedNode value) { }

internal override bool IsValidChildType(XmlNodeType type) { }

public override void WriteTo(XmlWriter w) { }

public override void WriteContentTo(XmlWriter w) { }

public override string get_BaseURI() { }

private string ConstructBaseURI(string baseURI, string systemId) { }

internal string get_ChildBaseURI() { }

}

public enum XmlNodeChangedAction // TypeDefIndex: 1961
{
	public int value__; 
public const XmlNodeChangedAction Insert = 0;
public const XmlNodeChangedAction Remove = 1;
public const XmlNodeChangedAction Change = 2;

}

public class XmlImplementation // TypeDefIndex: 1962
{
	private XmlNameTable nameTable; 

internal XmlNameTable NameTable { get; }


public void .ctor() { }

public void .ctor(XmlNameTable nt) { }

public virtual XmlDocument CreateDocument() { }

internal XmlNameTable get_NameTable() { }

}

public abstract class XmlLinkedNode : XmlNode // TypeDefIndex: 1963
{
	internal XmlLinkedNode next; 

public override XmlNode PreviousSibling { get; }
public override XmlNode NextSibling { get; }


internal void .ctor(XmlDocument doc) { }

public override XmlNode get_PreviousSibling() { }

public override XmlNode get_NextSibling() { }

}

internal class XmlLoader // TypeDefIndex: 1964
{
	private XmlDocument doc; 
	private XmlReader reader; 
	private bool preserveWhitespace; 


public void .ctor() { }

internal void Load(XmlDocument doc, XmlReader reader, bool preserveWhitespace) { }

private void LoadDocSequence(XmlDocument parentDoc) { }

internal XmlNode ReadCurrentNode(XmlDocument doc, XmlReader reader) { }

private XmlNode LoadNode(bool skipOverWhitespace) { }

private XmlAttribute LoadAttributeNode() { }

private XmlAttribute LoadDefaultAttribute() { }

private void LoadAttributeValue(XmlNode parent, bool direct) { }

private XmlEntityReference LoadEntityReferenceNode(bool direct) { }

private XmlDeclaration LoadDeclarationNode() { }

private XmlDocumentType LoadDocumentTypeNode() { }

private XmlNode LoadNodeDirect() { }

private XmlAttribute LoadAttributeNodeDirect() { }

internal void ParseDocumentType(XmlDocumentType dtNode) { }

private void ParseDocumentType(XmlDocumentType dtNode, bool bUseResolver, XmlResolver resolver) { }

private void LoadDocumentType(IDtdInfo dtdInfo, XmlDocumentType dtNode) { }

private XmlParserContext GetContext(XmlNode node) { }

internal XmlNamespaceManager ParsePartialContent(XmlNode parentNode, string innerxmltext, XmlNodeType nt) { }

internal void LoadInnerXmlElement(XmlElement node, string innerxmltext) { }

internal void LoadInnerXmlAttribute(XmlAttribute node, string innerxmltext) { }

private void RemoveDuplicateNamespace(XmlElement elem, XmlNamespaceManager mgr, bool fCheckElemAttrs) { }

private string EntitizeName(string name) { }

internal void ExpandEntity(XmlEntity ent) { }

internal void ExpandEntityReference(XmlEntityReference eref) { }

private XmlReader CreateInnerXmlReader(string xmlFragment, XmlNodeType nt, XmlParserContext context, XmlDocument doc) { }

internal static void ParseXmlDeclarationValue(string strValue, out string version, out string encoding, out string standalone) { }

internal static Exception UnexpectedNodeType(XmlNodeType nodetype) { }

}

internal class XmlName : IXmlSchemaInfo // TypeDefIndex: 1965
{
	private string prefix; 
	private string localName; 
	private string ns; 
	private string name; 
	private int hashCode; 
	internal XmlDocument ownerDoc; 
	internal XmlName next; 

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


public static XmlName Create(string prefix, string localName, string ns, int hashCode, XmlDocument ownerDoc, XmlName next, IXmlSchemaInfo schemaInfo) { }

internal void .ctor(string prefix, string localName, string ns, int hashCode, XmlDocument ownerDoc, XmlName next) { }

public string get_LocalName() { }

public string get_NamespaceURI() { }

public string get_Prefix() { }

public int get_HashCode() { }

public XmlDocument get_OwnerDocument() { }

public string get_Name() { }

public virtual XmlSchemaValidity get_Validity() { }

public virtual bool get_IsDefault() { }

public virtual bool get_IsNil() { }

public virtual XmlSchemaSimpleType get_MemberType() { }

public virtual XmlSchemaType get_SchemaType() { }

public virtual XmlSchemaElement get_SchemaElement() { }

public virtual XmlSchemaAttribute get_SchemaAttribute() { }

public virtual bool Equals(IXmlSchemaInfo schemaInfo) { }

public static int GetHashCode(string name) { }

}

internal sealed class XmlNameEx : XmlName // TypeDefIndex: 1966
{
	private byte flags; 
	private XmlSchemaSimpleType memberType; 
	private XmlSchemaType schemaType; 
	private object decl; 

public override XmlSchemaValidity Validity { get; }
public override bool IsDefault { get; }
public override bool IsNil { get; }
public override XmlSchemaSimpleType MemberType { get; }
public override XmlSchemaType SchemaType { get; }
public override XmlSchemaElement SchemaElement { get; }
public override XmlSchemaAttribute SchemaAttribute { get; }


internal void .ctor(string prefix, string localName, string ns, int hashCode, XmlDocument ownerDoc, XmlName next, IXmlSchemaInfo schemaInfo) { }

public override XmlSchemaValidity get_Validity() { }

public override bool get_IsDefault() { }

public override bool get_IsNil() { }

public override XmlSchemaSimpleType get_MemberType() { }

public override XmlSchemaType get_SchemaType() { }

public override XmlSchemaElement get_SchemaElement() { }

public override XmlSchemaAttribute get_SchemaAttribute() { }

public void SetValidity(XmlSchemaValidity value) { }

public void SetIsDefault(bool value) { }

public void SetIsNil(bool value) { }

public override bool Equals(IXmlSchemaInfo schemaInfo) { }

}

public class XmlNamedNodeMap : IEnumerable // TypeDefIndex: 1967
{
	internal XmlNode parent; 
	internal XmlNamedNodeMap.SmallXmlNodeList nodes; 

public virtual int Count { get; }


internal void .ctor(XmlNode parent) { }

public virtual XmlNode GetNamedItem(string name) { }

public virtual XmlNode SetNamedItem(XmlNode node) { }

public virtual int get_Count() { }

public virtual IEnumerator GetEnumerator() { }

internal int FindNodeOffset(string name) { }

internal int FindNodeOffset(string localName, string namespaceURI) { }

internal virtual XmlNode AddNode(XmlNode node) { }

internal virtual XmlNode AddNodeForLoad(XmlNode node, XmlDocument doc) { }

internal virtual XmlNode RemoveNodeAt(int i) { }

internal XmlNode ReplaceNodeAt(int i, XmlNode node) { }

internal virtual XmlNode InsertNodeAt(int i, XmlNode node) { }

}

internal struct XmlNamedNodeMap.SmallXmlNodeList // TypeDefIndex: 1968
{
	private object field; 

public int Count { get; }
public object Item { get; }


public int get_Count() { }

public object get_Item(int index) { }

public void Add(object value) { }

public void RemoveAt(int index) { }

public void Insert(int index, object value) { }

public IEnumerator GetEnumerator() { }

}

private class XmlNamedNodeMap.SmallXmlNodeList.SingleObjectEnumerator : IEnumerator // TypeDefIndex: 1969
{
	private object loneValue; 
	private int position; 

public object Current { get; }


public void .ctor(object value) { }

public object get_Current() { }

public bool MoveNext() { }

public void Reset() { }

}

public abstract class XmlNode : ICloneable, IEnumerable // TypeDefIndex: 1970
{
	internal XmlNode parentNode; 

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


internal void .ctor() { }

internal void .ctor(XmlDocument doc) { }

public abstract string get_Name();

public virtual string get_Value() { }

public virtual void set_Value(string value) { }

public abstract XmlNodeType get_NodeType();

public virtual XmlNode get_ParentNode() { }

public virtual XmlNodeList get_ChildNodes() { }

public virtual XmlNode get_PreviousSibling() { }

public virtual XmlNode get_NextSibling() { }

public virtual XmlAttributeCollection get_Attributes() { }

public virtual XmlDocument get_OwnerDocument() { }

public virtual XmlNode get_FirstChild() { }

public virtual XmlNode get_LastChild() { }

internal virtual bool get_IsContainer() { }

internal virtual XmlLinkedNode get_LastNode() { }

internal virtual void set_LastNode(XmlLinkedNode value) { }

internal bool AncestorNode(XmlNode node) { }

public virtual XmlNode InsertBefore(XmlNode newChild, XmlNode refChild) { }

public virtual XmlNode InsertAfter(XmlNode newChild, XmlNode refChild) { }

public virtual XmlNode RemoveChild(XmlNode oldChild) { }

public virtual XmlNode PrependChild(XmlNode newChild) { }

public virtual XmlNode AppendChild(XmlNode newChild) { }

internal virtual XmlNode AppendChildForLoad(XmlNode newChild, XmlDocument doc) { }

internal virtual bool IsValidChildType(XmlNodeType type) { }

internal virtual bool CanInsertBefore(XmlNode newChild, XmlNode refChild) { }

internal virtual bool CanInsertAfter(XmlNode newChild, XmlNode refChild) { }

public virtual bool get_HasChildNodes() { }

public abstract XmlNode CloneNode(bool deep);

internal virtual void CopyChildren(XmlDocument doc, XmlNode container, bool deep) { }

public virtual string get_NamespaceURI() { }

public virtual string get_Prefix() { }

public virtual void set_Prefix(string value) { }

public abstract string get_LocalName();

public virtual bool get_IsReadOnly() { }

internal static bool HasReadOnlyParent(XmlNode n) { }

private object System.ICloneable.Clone() { }

private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

public IEnumerator GetEnumerator() { }

private void AppendChildText(StringBuilder builder) { }

public virtual string get_InnerText() { }

public virtual void set_InnerText(string value) { }

public virtual void set_InnerXml(string value) { }

public virtual IXmlSchemaInfo get_SchemaInfo() { }

public virtual string get_BaseURI() { }

public abstract void WriteTo(XmlWriter w);

public abstract void WriteContentTo(XmlWriter w);

public virtual void RemoveAll() { }

internal XmlDocument get_Document() { }

public virtual string GetPrefixOfNamespace(string namespaceURI) { }

internal string GetPrefixOfNamespaceStrict(string namespaceURI) { }

internal virtual void SetParent(XmlNode node) { }

internal virtual void SetParentForLoad(XmlNode node) { }

internal static void SplitName(string name, out string prefix, out string localName) { }

internal virtual XmlNode FindChild(XmlNodeType type) { }

internal virtual XmlNodeChangedEventArgs GetEventArgs(XmlNode node, XmlNode oldParent, XmlNode newParent, string oldValue, string newValue, XmlNodeChangedAction action) { }

internal virtual void BeforeEvent(XmlNodeChangedEventArgs args) { }

internal virtual void AfterEvent(XmlNodeChangedEventArgs args) { }

internal virtual XmlSpace get_XmlSpace() { }

internal virtual string get_XmlLang() { }

internal virtual bool get_IsText() { }

internal static void NestTextNodes(XmlNode prevNode, XmlNode nextNode) { }

internal static void UnnestTextNodes(XmlNode prevNode, XmlNode nextNode) { }

}

public class XmlNodeChangedEventArgs : EventArgs // TypeDefIndex: 1971
{
	private XmlNodeChangedAction action; 
	private XmlNode node; 
	private XmlNode oldParent; 
	private XmlNode newParent; 
	private string oldValue; 
	private string newValue; 

public XmlNodeChangedAction Action { get; }


public void .ctor(XmlNode node, XmlNode oldParent, XmlNode newParent, string oldValue, string newValue, XmlNodeChangedAction action) { }

public XmlNodeChangedAction get_Action() { }

}

public sealed class XmlNodeChangedEventHandler : MulticastDelegate // TypeDefIndex: 1972
{

public void .ctor(object object, IntPtr method) { }

public virtual void Invoke(object sender, XmlNodeChangedEventArgs e) { }

public virtual IAsyncResult BeginInvoke(object sender, XmlNodeChangedEventArgs e, AsyncCallback callback, object object) { }

public virtual void EndInvoke(IAsyncResult result) { }

}

public abstract class XmlNodeList : IEnumerable, IDisposable // TypeDefIndex: 1973
{
public abstract int Count { get; }
public virtual XmlNode ItemOf { get; }


public abstract XmlNode Item(int index);

public abstract int get_Count();

public abstract IEnumerator GetEnumerator();

public virtual XmlNode get_ItemOf(int i) { }

private void System.IDisposable.Dispose() { }

protected virtual void PrivateDisposeNodeList() { }

protected void .ctor() { }

}

internal class XmlNodeReaderNavigator // TypeDefIndex: 1974
{
	private XmlNode curNode; 
	private XmlNode elemNode; 
	private XmlNode logNode; 
	private int attrIndex; 
	private int logAttrIndex; 
	private XmlNameTable nameTable; 
	private XmlDocument doc; 
	private int nAttrInd; 
	private int nDeclarationAttrCount; 
	private int nDocTypeAttrCount; 
	private int nLogLevel; 
	private int nLogAttrInd; 
	private bool bLogOnAttrVal; 
	private bool bCreatedOnAttribute; 
	internal XmlNodeReaderNavigator.VirtualAttribute[] decNodeAttributes; 
	internal XmlNodeReaderNavigator.VirtualAttribute[] docTypeNodeAttributes; 
	private bool bOnAttrVal; 

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


public void .ctor(XmlNode node) { }

public XmlNodeType get_NodeType() { }

public string get_NamespaceURI() { }

public string get_Name() { }

public string get_LocalName() { }

internal bool get_CreatedOnAttribute() { }

private bool IsLocalNameEmpty(XmlNodeType nt) { }

public string get_Prefix() { }

public string get_Value() { }

public string get_BaseURI() { }

public XmlSpace get_XmlSpace() { }

public string get_XmlLang() { }

public bool get_IsEmptyElement() { }

public bool get_IsDefault() { }

public IXmlSchemaInfo get_SchemaInfo() { }

public XmlNameTable get_NameTable() { }

public int get_AttributeCount() { }

private void CheckIndexCondition(int attributeIndex) { }

private void InitDecAttr() { }

public string GetDeclarationAttr(XmlDeclaration decl, string name) { }

public string GetDeclarationAttr(int i) { }

public int GetDecAttrInd(string name) { }

private void InitDocTypeAttr() { }

public string GetDocumentTypeAttr(XmlDocumentType docType, string name) { }

public string GetDocumentTypeAttr(int i) { }

public int GetDocTypeAttrInd(string name) { }

private string GetAttributeFromElement(XmlElement elem, string name) { }

public string GetAttribute(string name) { }

private string GetAttributeFromElement(XmlElement elem, string name, string ns) { }

public string GetAttribute(string name, string ns) { }

public string GetAttribute(int attributeIndex) { }

public void LogMove(int level) { }

public void RollBackMove(ref int level) { }

private bool get_IsOnDeclOrDocType() { }

public void ResetToAttribute(ref int level) { }

public void ResetMove(ref int level, ref XmlNodeType nt) { }

public bool MoveToAttribute(string name) { }

private bool MoveToAttributeFromElement(XmlElement elem, string name, string ns) { }

public bool MoveToAttribute(string name, string namespaceURI) { }

public void MoveToAttribute(int attributeIndex) { }

public bool MoveToNextAttribute(ref int level) { }

public bool MoveToParent() { }

public bool MoveToFirstChild() { }

private bool MoveToNextSibling(XmlNode node) { }

public bool MoveToNext() { }

public bool MoveToElement() { }

public string LookupNamespace(string prefix) { }

internal string DefaultLookupNamespace(string prefix) { }

internal string LookupPrefix(string namespaceName) { }

internal IDictionary<string, string> GetNamespacesInScope(XmlNamespaceScope scope) { }

public bool ReadAttributeValue(ref int level, ref bool bResolveEntity, ref XmlNodeType nt) { }

public XmlDocument get_Document() { }

}

internal struct XmlNodeReaderNavigator.VirtualAttribute // TypeDefIndex: 1975
{
	internal string name; 
	internal string value; 


internal void .ctor(string name, string value) { }

}

public class XmlNodeReader : XmlReader, IXmlNamespaceResolver // TypeDefIndex: 1976
{
	private XmlNodeReaderNavigator readerNav; 
	private XmlNodeType nodeType; 
	private int curDepth; 
	private ReadState readState; 
	private bool fEOF; 
	private bool bResolveEntity; 
	private bool bStartFromDocument; 
	private bool bInReadBinary; 
	private ReadContentAsBinaryHelper readBinaryHelper; 

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


public void .ctor(XmlNode node) { }

internal bool IsInReadingStates() { }

public override XmlNodeType get_NodeType() { }

public override string get_Name() { }

public override string get_LocalName() { }

public override string get_NamespaceURI() { }

public override string get_Prefix() { }

public override string get_Value() { }

public override int get_Depth() { }

public override string get_BaseURI() { }

public override bool get_CanResolveEntity() { }

public override bool get_IsEmptyElement() { }

public override bool get_IsDefault() { }

public override XmlSpace get_XmlSpace() { }

public override string get_XmlLang() { }

public override IXmlSchemaInfo get_SchemaInfo() { }

public override int get_AttributeCount() { }

public override string GetAttribute(string name) { }

public override string GetAttribute(string name, string namespaceURI) { }

public override string GetAttribute(int attributeIndex) { }

public override bool MoveToAttribute(string name) { }

public override void MoveToAttribute(int attributeIndex) { }

public override bool MoveToFirstAttribute() { }

public override bool MoveToNextAttribute() { }

public override bool MoveToElement() { }

public override bool Read() { }

private bool Read(bool fSkipChildren) { }

private bool ReadNextNode(bool fSkipChildren) { }

private void SetEndOfFile() { }

private bool ReadAtZeroLevel(bool fSkipChildren) { }

private bool ReadForward(bool fSkipChildren) { }

private void ReSetReadingMarks() { }

public override bool get_EOF() { }

public override void Close() { }

public override ReadState get_ReadState() { }

public override void Skip() { }

public override string ReadString() { }

public override bool get_HasAttributes() { }

public override XmlNameTable get_NameTable() { }

public override string LookupNamespace(string prefix) { }

public override void ResolveEntity() { }

public override bool ReadAttributeValue() { }

private void FinishReadBinary() { }

private IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

internal override IDtdInfo get_DtdInfo() { }

}

public class XmlNotation : XmlNode // TypeDefIndex: 1977
{
	private string publicId; 
	private string systemId; 
	private string name; 

public override string Name { get; }
public override string LocalName { get; }
public override XmlNodeType NodeType { get; }
public override bool IsReadOnly { get; }
public override string InnerXml { set; }


internal void .ctor(string name, string publicId, string systemId, XmlDocument doc) { }

public override string get_Name() { }

public override string get_LocalName() { }

public override XmlNodeType get_NodeType() { }

public override XmlNode CloneNode(bool deep) { }

public override bool get_IsReadOnly() { }

public override void set_InnerXml(string value) { }

public override void WriteTo(XmlWriter w) { }

public override void WriteContentTo(XmlWriter w) { }

}

public class XmlProcessingInstruction : XmlLinkedNode // TypeDefIndex: 1978
{
	private string target; 
	private string data; 

public override string Name { get; }
public override string LocalName { get; }
public override string Value { get; set; }
public string Data { set; }
public override string InnerText { get; set; }
public override XmlNodeType NodeType { get; }


protected internal void .ctor(string target, string data, XmlDocument doc) { }

public override string get_Name() { }

public override string get_LocalName() { }

public override string get_Value() { }

public override void set_Value(string value) { }

public void set_Data(string value) { }

public override string get_InnerText() { }

public override void set_InnerText(string value) { }

public override XmlNodeType get_NodeType() { }

public override XmlNode CloneNode(bool deep) { }

public override void WriteTo(XmlWriter w) { }

public override void WriteContentTo(XmlWriter w) { }

}

public class XmlSignificantWhitespace : XmlCharacterData // TypeDefIndex: 1979
{
public override string Name { get; }
public override string LocalName { get; }
public override XmlNodeType NodeType { get; }
public override XmlNode ParentNode { get; }
public override string Value { get; set; }
internal override bool IsText { get; }


protected internal void .ctor(string strData, XmlDocument doc) { }

public override string get_Name() { }

public override string get_LocalName() { }

public override XmlNodeType get_NodeType() { }

public override XmlNode get_ParentNode() { }

public override XmlNode CloneNode(bool deep) { }

public override string get_Value() { }

public override void set_Value(string value) { }

public override void WriteTo(XmlWriter w) { }

public override void WriteContentTo(XmlWriter w) { }

internal override bool get_IsText() { }

}

public class XmlText : XmlCharacterData // TypeDefIndex: 1980
{
public override string Name { get; }
public override string LocalName { get; }
public override XmlNodeType NodeType { get; }
public override XmlNode ParentNode { get; }
public override string Value { get; set; }
internal override bool IsText { get; }


internal void .ctor(string strData) { }

protected internal void .ctor(string strData, XmlDocument doc) { }

public override string get_Name() { }

public override string get_LocalName() { }

public override XmlNodeType get_NodeType() { }

public override XmlNode get_ParentNode() { }

public override XmlNode CloneNode(bool deep) { }

public override string get_Value() { }

public override void set_Value(string value) { }

public override void WriteTo(XmlWriter w) { }

public override void WriteContentTo(XmlWriter w) { }

internal override bool get_IsText() { }

}

internal class XmlUnspecifiedAttribute : XmlAttribute // TypeDefIndex: 1981
{
	private bool fSpecified; 

public override bool Specified { get; }
public override string InnerText { set; }


protected internal void .ctor(string prefix, string localName, string namespaceURI, XmlDocument doc) { }

public override bool get_Specified() { }

public override XmlNode CloneNode(bool deep) { }

public override void set_InnerText(string value) { }

public override XmlNode InsertBefore(XmlNode newChild, XmlNode refChild) { }

public override XmlNode InsertAfter(XmlNode newChild, XmlNode refChild) { }

public override XmlNode RemoveChild(XmlNode oldChild) { }

public override XmlNode AppendChild(XmlNode newChild) { }

public override void WriteTo(XmlWriter w) { }

internal void SetSpecified(bool f) { }

}

public class XmlWhitespace : XmlCharacterData // TypeDefIndex: 1982
{
public override string Name { get; }
public override string LocalName { get; }
public override XmlNodeType NodeType { get; }
public override XmlNode ParentNode { get; }
public override string Value { get; set; }
internal override bool IsText { get; }


protected internal void .ctor(string strData, XmlDocument doc) { }

public override string get_Name() { }

public override string get_LocalName() { }

public override XmlNodeType get_NodeType() { }

public override XmlNode get_ParentNode() { }

public override string get_Value() { }

public override void set_Value(string value) { }

public override XmlNode CloneNode(bool deep) { }

public override void WriteTo(XmlWriter w) { }

public override void WriteContentTo(XmlWriter w) { }

internal override bool get_IsText() { }

}

public enum XmlTokenizedType // TypeDefIndex: 1999
{
	public int value__; 
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
{
	private static object s_Lock; 
	private static byte[] s_CharProperties; 
	internal byte[] charProperties; 

private static object StaticLock { get; }
public static XmlCharType Instance { get; }


private static object get_StaticLock() { }

private static void InitInstance() { }

private static void SetProperties(string ranges, byte value) { }

private void .ctor(byte[] charProperties) { }

public static XmlCharType get_Instance() { }

public bool IsWhiteSpace(char ch) { }

public bool IsNCNameSingleChar(char ch) { }

public bool IsStartNCNameSingleChar(char ch) { }

public bool IsNameSingleChar(char ch) { }

public bool IsCharData(char ch) { }

public bool IsPubidChar(char ch) { }

internal bool IsTextChar(char ch) { }

public bool IsLetter(char ch) { }

public bool IsNCNameCharXml4e(char ch) { }

public bool IsStartNCNameCharXml4e(char ch) { }

public bool IsNameCharXml4e(char ch) { }

public static bool IsDigit(char ch) { }

internal static bool IsHighSurrogate(int ch) { }

internal static bool IsLowSurrogate(int ch) { }

internal static bool IsSurrogate(int ch) { }

internal static int CombineSurrogateChar(int lowChar, int highChar) { }

internal static void SplitSurrogateChar(int combinedChar, out char lowChar, out char highChar) { }

internal bool IsOnlyWhitespace(string str) { }

internal int IsOnlyWhitespaceWithPos(string str) { }

internal int IsOnlyCharData(string str) { }

internal static bool IsOnlyDigits(string str, int startPos, int len) { }

internal int IsPublicId(string str) { }

private static bool InRange(int value, int start, int end) { }

}

internal static class XmlComplianceUtil // TypeDefIndex: 2002
{

public static string NonCDataNormalize(string value) { }

public static string CDataNormalize(string value) { }

}

public enum XmlDateTimeSerializationMode // TypeDefIndex: 2004
{
	public int value__; 
public const XmlDateTimeSerializationMode Local = 0;
public const XmlDateTimeSerializationMode Utc = 1;
public const XmlDateTimeSerializationMode Unspecified = 2;
public const XmlDateTimeSerializationMode RoundtripKind = 3;

}

public class XmlConvert // TypeDefIndex: 2005
{
	private static XmlCharType xmlCharType; 
	internal static char[] crt; 
	private static readonly int c_EncodedCharLength; 
	private static Regex c_EncodeCharPattern; 
	private static Regex c_DecodeCharPattern; 
	private static string[] s_allDateTimeFormats; 
	internal static readonly char[] WhitespaceChars; 

private static string[] AllDateTimeFormats { get; }


public static string EncodeName(string name) { }

public static string EncodeLocalName(string name) { }

public static string DecodeName(string name) { }

private static string EncodeName(string name, bool first, bool local) { }

private static int FromHex(char digit) { }

internal static byte[] FromBinHexString(string s) { }

internal static byte[] FromBinHexString(string s, bool allowOddCount) { }

internal static string ToBinHexString(byte[] inArray) { }

public static string VerifyName(string name) { }

internal static Exception TryVerifyName(string name) { }

internal static string VerifyQName(string name, ExceptionType exceptionType) { }

public static string VerifyNCName(string name) { }

internal static string VerifyNCName(string name, ExceptionType exceptionType) { }

internal static Exception TryVerifyNCName(string name) { }

public static string VerifyTOKEN(string token) { }

internal static Exception TryVerifyTOKEN(string token) { }

internal static Exception TryVerifyNMTOKEN(string name) { }

internal static Exception TryVerifyNormalizedString(string str) { }

public static string ToString(bool value) { }

public static string ToString(char value) { }

public static string ToString(Decimal value) { }

	[CLSCompliantAttribute] 
public static string ToString(sbyte value) { }

public static string ToString(short value) { }

public static string ToString(int value) { }

public static string ToString(long value) { }

public static string ToString(byte value) { }

	[CLSCompliantAttribute] 
public static string ToString(ushort value) { }

	[CLSCompliantAttribute] 
public static string ToString(uint value) { }

	[CLSCompliantAttribute] 
public static string ToString(ulong value) { }

public static string ToString(float value) { }

public static string ToString(double value) { }

public static string ToString(TimeSpan value) { }

public static string ToString(DateTime value, string format) { }

public static string ToString(DateTime value, XmlDateTimeSerializationMode dateTimeOption) { }

public static string ToString(DateTimeOffset value) { }

public static string ToString(Guid value) { }

public static bool ToBoolean(string s) { }

internal static Exception TryToBoolean(string s, out bool result) { }

public static char ToChar(string s) { }

internal static Exception TryToChar(string s, out char result) { }

public static Decimal ToDecimal(string s) { }

internal static Exception TryToDecimal(string s, out Decimal result) { }

internal static Decimal ToInteger(string s) { }

internal static Exception TryToInteger(string s, out Decimal result) { }

	[CLSCompliantAttribute] 
public static sbyte ToSByte(string s) { }

internal static Exception TryToSByte(string s, out sbyte result) { }

public static short ToInt16(string s) { }

internal static Exception TryToInt16(string s, out short result) { }

public static int ToInt32(string s) { }

internal static Exception TryToInt32(string s, out int result) { }

public static long ToInt64(string s) { }

internal static Exception TryToInt64(string s, out long result) { }

public static byte ToByte(string s) { }

internal static Exception TryToByte(string s, out byte result) { }

	[CLSCompliantAttribute] 
public static ushort ToUInt16(string s) { }

internal static Exception TryToUInt16(string s, out ushort result) { }

	[CLSCompliantAttribute] 
public static uint ToUInt32(string s) { }

internal static Exception TryToUInt32(string s, out uint result) { }

	[CLSCompliantAttribute] 
public static ulong ToUInt64(string s) { }

internal static Exception TryToUInt64(string s, out ulong result) { }

public static float ToSingle(string s) { }

internal static Exception TryToSingle(string s, out float result) { }

public static double ToDouble(string s) { }

internal static Exception TryToDouble(string s, out double result) { }

internal static double ToXPathDouble(object o) { }

public static TimeSpan ToTimeSpan(string s) { }

internal static Exception TryToTimeSpan(string s, out TimeSpan result) { }

private static string[] get_AllDateTimeFormats() { }

private static void CreateAllDateTimeFormats() { }

	[ObsoleteAttribute] 
public static DateTime ToDateTime(string s) { }

public static DateTime ToDateTime(string s, string[] formats) { }

public static DateTime ToDateTime(string s, XmlDateTimeSerializationMode dateTimeOption) { }

public static DateTimeOffset ToDateTimeOffset(string s) { }

public static Guid ToGuid(string s) { }

internal static Exception TryToGuid(string s, out Guid result) { }

private static DateTime SwitchToLocalTime(DateTime value) { }

private static DateTime SwitchToUtcTime(DateTime value) { }

internal static Uri ToUri(string s) { }

internal static Exception TryToUri(string s, out Uri result) { }

internal static bool StrEqual(char[] chars, int strPos1, int strLen1, string str2) { }

internal static string TrimString(string value) { }

internal static string TrimStringStart(string value) { }

internal static string TrimStringEnd(string value) { }

internal static string[] SplitString(string value) { }

internal static bool IsNegativeZero(double value) { }

private static long DoubleToInt64Bits(double value) { }

internal static void VerifyCharData(string data, ExceptionType invCharExceptionType, ExceptionType invSurrogateExceptionType) { }

internal static Exception CreateException(string res, ExceptionType exceptionType, int lineNo, int linePos) { }

internal static Exception CreateException(string res, string arg, ExceptionType exceptionType, int lineNo, int linePos) { }

internal static Exception CreateException(string res, string[] args, ExceptionType exceptionType) { }

internal static Exception CreateException(string res, string[] args, ExceptionType exceptionType, int lineNo, int linePos) { }

internal static Exception CreateInvalidSurrogatePairException(char low, char hi) { }

internal static Exception CreateInvalidSurrogatePairException(char low, char hi, ExceptionType exceptionType) { }

internal static Exception CreateInvalidSurrogatePairException(char low, char hi, ExceptionType exceptionType, int lineNo, int linePos) { }

internal static Exception CreateInvalidHighSurrogateCharException(char hi) { }

internal static Exception CreateInvalidHighSurrogateCharException(char hi, ExceptionType exceptionType) { }

internal static Exception CreateInvalidHighSurrogateCharException(char hi, ExceptionType exceptionType, int lineNo, int linePos) { }

internal static Exception CreateInvalidCharException(string data, int invCharPos, ExceptionType exceptionType) { }

internal static Exception CreateInvalidCharException(char invChar, char nextChar) { }

internal static Exception CreateInvalidCharException(char invChar, char nextChar, ExceptionType exceptionType) { }

internal static Exception CreateInvalidNameCharException(string name, int index, ExceptionType exceptionType) { }

internal static ArgumentException CreateInvalidNameArgumentException(string name, string argumentName) { }

private static void .cctor() { }

}

internal class XmlDownloadManager // TypeDefIndex: 2006
{
	private Hashtable connections; 


internal Stream GetStream(Uri uri, ICredentials credentials, IWebProxy proxy, RequestCachePolicy cachePolicy) { }

private Stream GetNonFileStream(Uri uri, ICredentials credentials, IWebProxy proxy, RequestCachePolicy cachePolicy) { }

internal void Remove(string host) { }

internal Task<Stream> GetStreamAsync(Uri uri, ICredentials credentials, IWebProxy proxy, RequestCachePolicy cachePolicy) { }

	[AsyncStateMachineAttribute] 
private Task<Stream> GetNonFileStreamAsync(Uri uri, ICredentials credentials, IWebProxy proxy, RequestCachePolicy cachePolicy) { }

public void .ctor() { }

}

private sealed class XmlDownloadManager.<>c__DisplayClass4_0 // TypeDefIndex: 2007
{
	public Uri uri; 


public void .ctor() { }

internal Stream <GetStreamAsync>b__0() { }

}

private struct XmlDownloadManager.<GetNonFileStreamAsync>d__5 : IAsyncStateMachine // TypeDefIndex: 2008
{
	public int <>1__state; 
	public AsyncTaskMethodBuilder<Stream> <>t__builder; 
	public Uri uri; 
	public ICredentials credentials; 
	public IWebProxy proxy; 
	public RequestCachePolicy cachePolicy; 
	private WebRequest <req>5__1; 
	public XmlDownloadManager <>4__this; 
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<WebResponse> <>u__1; 


private void MoveNext() { }

	[DebuggerHiddenAttribute] 
private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

internal class XmlRegisteredNonCachedStream : Stream // TypeDefIndex: 2010
{
	protected Stream stream; 
	private XmlDownloadManager downloadManager; 
	private string host; 

public override bool CanRead { get; }
public override bool CanSeek { get; }
public override bool CanWrite { get; }
public override long Length { get; }
public override long Position { get; set; }


internal void .ctor(Stream stream, XmlDownloadManager downloadManager, string host) { }

protected override void Finalize() { }

protected override void Dispose(bool disposing) { }

public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

public override int EndRead(IAsyncResult asyncResult) { }

public override void EndWrite(IAsyncResult asyncResult) { }

public override void Flush() { }

public override int Read(byte[] buffer, int offset, int count) { }

public override int ReadByte() { }

public override long Seek(long offset, SeekOrigin origin) { }

public override void SetLength(long value) { }

public override void Write(byte[] buffer, int offset, int count) { }

public override void WriteByte(byte value) { }

public override bool get_CanRead() { }

public override bool get_CanSeek() { }

public override bool get_CanWrite() { }

public override long get_Length() { }

public override long get_Position() { }

public override void set_Position(long value) { }

}

internal class XmlCachedStream : MemoryStream // TypeDefIndex: 2011
{
	private Uri uri; 


internal void .ctor(Uri uri, Stream stream) { }

}

public class XmlException : SystemException // TypeDefIndex: 2024
{
	private string res; 
	private string[] args; 
	private int lineNumber; 
	private int linePosition; 
	[OptionalFieldAttribute] 
	private string sourceUri; 
	private string message; 

public int LineNumber { get; }
public int LinePosition { get; }
public override string Message { get; }
internal string ResString { get; }


protected void .ctor(SerializationInfo info, StreamingContext context) { }

public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

public void .ctor() { }

public void .ctor(string message) { }

public void .ctor(string message, Exception innerException) { }

public void .ctor(string message, Exception innerException, int lineNumber, int linePosition) { }

internal void .ctor(string message, Exception innerException, int lineNumber, int linePosition, string sourceUri) { }

internal void .ctor(string res, string[] args) { }

internal void .ctor(string res, string arg) { }

internal void .ctor(string res, string arg, string sourceUri) { }

internal void .ctor(string res, string arg, IXmlLineInfo lineInfo) { }

internal void .ctor(string res, string[] args, IXmlLineInfo lineInfo) { }

internal void .ctor(string res, string[] args, IXmlLineInfo lineInfo, string sourceUri) { }

internal void .ctor(string res, string arg, int lineNumber, int linePosition) { }

internal void .ctor(string res, string arg, int lineNumber, int linePosition, string sourceUri) { }

internal void .ctor(string res, string[] args, int lineNumber, int linePosition) { }

internal void .ctor(string res, string[] args, int lineNumber, int linePosition, string sourceUri) { }

internal void .ctor(string res, string[] args, Exception innerException, int lineNumber, int linePosition) { }

internal void .ctor(string res, string[] args, Exception innerException, int lineNumber, int linePosition, string sourceUri) { }

private static string FormatUserMessage(string message, int lineNumber, int linePosition) { }

private static string CreateMessage(string res, string[] args, int lineNumber, int linePosition) { }

internal static string[] BuildCharExceptionArgs(string data, int invCharIndex) { }

internal static string[] BuildCharExceptionArgs(char[] data, int length, int invCharIndex) { }

internal static string[] BuildCharExceptionArgs(char invChar, char nextChar) { }

public int get_LineNumber() { }

public int get_LinePosition() { }

public override string get_Message() { }

internal string get_ResString() { }

}

public abstract class XmlNameTable // TypeDefIndex: 2025
{

public abstract string Get(string array);

public abstract string Add(char[] array, int offset, int length);

public abstract string Add(string array);

protected void .ctor() { }

}

public enum XmlNamespaceScope // TypeDefIndex: 2026
{
	public int value__; 
public const XmlNamespaceScope All = 0;
public const XmlNamespaceScope ExcludeXml = 1;
public const XmlNamespaceScope Local = 2;

}

public class XmlNamespaceManager : IXmlNamespaceResolver, IEnumerable // TypeDefIndex: 2027
{
	private XmlNamespaceManager.NamespaceDeclaration[] nsdecls; 
	private int lastDecl; 
	private XmlNameTable nameTable; 
	private int scopeId; 
	private Dictionary<string, int> hashTable; 
	private bool useHashtable; 
	private string xml; 
	private string xmlNs; 

public virtual XmlNameTable NameTable { get; }
public virtual string DefaultNamespace { get; }


internal void .ctor() { }

public void .ctor(XmlNameTable nameTable) { }

public virtual XmlNameTable get_NameTable() { }

public virtual string get_DefaultNamespace() { }

public virtual void PushScope() { }

public virtual bool PopScope() { }

public virtual void AddNamespace(string prefix, string uri) { }

public virtual void RemoveNamespace(string prefix, string uri) { }

public virtual IEnumerator GetEnumerator() { }

public virtual IDictionary<string, string> GetNamespacesInScope(XmlNamespaceScope scope) { }

public virtual string LookupNamespace(string prefix) { }

private int LookupNamespaceDecl(string prefix) { }

public virtual string LookupPrefix(string uri) { }

}

private struct XmlNamespaceManager.NamespaceDeclaration // TypeDefIndex: 2028
{
	public string prefix; 
	public string uri; 
	public int scopeId; 
	public int previousNsIndex; 


public void Set(string prefix, string uri, int scopeId, int previousNsIndex) { }

}

public enum XmlNodeType // TypeDefIndex: 2029
{
	public int value__; 
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
{
	private static XmlQualifiedName.HashCodeOfStringDelegate hashCodeDelegate; 
	private string name; 
	private string ns; 
	private int hash; 
	public static readonly XmlQualifiedName Empty; 

public string Namespace { get; }
public string Name { get; }
public bool IsEmpty { get; }


public void .ctor() { }

public void .ctor(string name) { }

public void .ctor(string name, string ns) { }

public string get_Namespace() { }

public string get_Name() { }

public override int GetHashCode() { }

public bool get_IsEmpty() { }

public override string ToString() { }

public override bool Equals(object other) { }

public static bool op_Equality(XmlQualifiedName a, XmlQualifiedName b) { }

public static bool op_Inequality(XmlQualifiedName a, XmlQualifiedName b) { }

public static string ToString(string name, string ns) { }

private static XmlQualifiedName.HashCodeOfStringDelegate GetHashCodeDelegate() { }

private static bool IsRandomizedHashingDisabled() { }

private static int GetHashCodeOfString(string s, int length, long additionalEntropy) { }

internal void Init(string name, string ns) { }

internal void SetNamespace(string ns) { }

internal void Verify() { }

internal void Atomize(XmlNameTable nameTable) { }

internal static XmlQualifiedName Parse(string s, IXmlNamespaceResolver nsmgr, out string prefix) { }

internal XmlQualifiedName Clone() { }

private static void .cctor() { }

}

private sealed class XmlQualifiedName.HashCodeOfStringDelegate : MulticastDelegate // TypeDefIndex: 2031
{

public void .ctor(object object, IntPtr method) { }

public virtual int Invoke(string s, int sLen, long additionalEntropy) { }

public virtual IAsyncResult BeginInvoke(string s, int sLen, long additionalEntropy, AsyncCallback callback, object object) { }

public virtual int EndInvoke(IAsyncResult result) { }

}

public abstract class XmlResolver // TypeDefIndex: 2032
{

public abstract object GetEntity(Uri absoluteUri, string role, Type ofObjectToReturn);

public virtual Uri ResolveUri(Uri baseUri, string relativeUri) { }

public virtual bool SupportsType(Uri absoluteUri, Type type) { }

public virtual Task<object> GetEntityAsync(Uri absoluteUri, string role, Type ofObjectToReturn) { }

protected void .ctor() { }

}

public class XmlUrlResolver : XmlResolver // TypeDefIndex: 2033
{
	private static object s_DownloadManager; 
	private ICredentials _credentials; 
	private IWebProxy _proxy; 
	private RequestCachePolicy _cachePolicy; 

private static XmlDownloadManager DownloadManager { get; }


private static XmlDownloadManager get_DownloadManager() { }

public void .ctor() { }

public override object GetEntity(Uri absoluteUri, string role, Type ofObjectToReturn) { }

public override Uri ResolveUri(Uri baseUri, string relativeUri) { }

	[AsyncStateMachineAttribute] 
public override Task<object> GetEntityAsync(Uri absoluteUri, string role, Type ofObjectToReturn) { }

}

private struct XmlUrlResolver.<GetEntityAsync>d__15 : IAsyncStateMachine // TypeDefIndex: 2034
{
	public int <>1__state; 
	public AsyncTaskMethodBuilder<object> <>t__builder; 
	public Type ofObjectToReturn; 
	public Uri absoluteUri; 
	public XmlUrlResolver <>4__this; 
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Stream> <>u__1; 


private void MoveNext() { }

	[DebuggerHiddenAttribute] 
private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

public class XPathDocument // TypeDefIndex: 2036
{
	private XPathNode[] pageXmlNmsp; 
	private int idxXmlNmsp; 
	private XmlNameTable nameTable; 
	private bool hasLineInfo; 
	private Dictionary<XPathNodeRef, XPathNodeRef> mapNmsp; 

internal XmlNameTable NameTable { get; }
internal bool HasLineInfo { get; }


internal XmlNameTable get_NameTable() { }

internal bool get_HasLineInfo() { }

internal int GetXmlNamespaceNode(out XPathNode[] pageXmlNmsp) { }

internal int LookupNamespaces(XPathNode[] pageElem, int idxElem, out XPathNode[] pageNmsp) { }

}

public class XPathException : SystemException // TypeDefIndex: 2037
{
	private string res; 
	private string[] args; 
	private string message; 

public override string Message { get; }


protected void .ctor(SerializationInfo info, StreamingContext context) { }

public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

public void .ctor() { }

public void .ctor(string message, Exception innerException) { }

internal static XPathException Create(string res) { }

internal static XPathException Create(string res, string arg) { }

internal static XPathException Create(string res, string arg, string arg2) { }

private void .ctor(string res, string[] args) { }

private void .ctor(string res, string[] args, Exception inner) { }

private static string CreateMessage(string res, string[] args) { }

public override string get_Message() { }

}

public enum XPathResultType // TypeDefIndex: 2038
{
	public int value__; 
public const XPathResultType Number = 0;
public const XPathResultType String = 1;
public const XPathResultType Boolean = 2;
public const XPathResultType NodeSet = 3;
public const XPathResultType Navigator = 1;
public const XPathResultType Any = 5;
public const XPathResultType Error = 6;

}

public abstract class XPathItem // TypeDefIndex: 2039
{
public abstract XmlSchemaType XmlType { get; }
public abstract string Value { get; }
public abstract object TypedValue { get; }
public abstract Type ValueType { get; }
public abstract bool ValueAsBoolean { get; }
public abstract DateTime ValueAsDateTime { get; }
public abstract double ValueAsDouble { get; }
public abstract int ValueAsInt { get; }
public abstract long ValueAsLong { get; }


public abstract XmlSchemaType get_XmlType();

public abstract string get_Value();

public abstract object get_TypedValue();

public abstract Type get_ValueType();

public abstract bool get_ValueAsBoolean();

public abstract DateTime get_ValueAsDateTime();

public abstract double get_ValueAsDouble();

public abstract int get_ValueAsInt();

public abstract long get_ValueAsLong();

public virtual object ValueAs(Type returnType) { }

public abstract object ValueAs(Type returnType, IXmlNamespaceResolver nsResolver);

protected void .ctor() { }

}

public enum XPathNamespaceScope // TypeDefIndex: 2040
{
	public int value__; 
public const XPathNamespaceScope All = 0;
public const XPathNamespaceScope ExcludeXml = 1;
public const XPathNamespaceScope Local = 2;

}

public abstract class XPathNavigator : XPathItem, ICloneable, IXmlNamespaceResolver // TypeDefIndex: 2041
{
	internal static readonly XPathNavigatorKeyComparer comparer; 
	internal static readonly char[] NodeTypeLetter; 
	internal static readonly char[] UniqueIdTbl; 
	internal static readonly int[] ContentKindMasks; 

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


public override string ToString() { }

public override XmlSchemaType get_XmlType() { }

public override object get_TypedValue() { }

public override Type get_ValueType() { }

public override bool get_ValueAsBoolean() { }

public override DateTime get_ValueAsDateTime() { }

public override double get_ValueAsDouble() { }

public override int get_ValueAsInt() { }

public override long get_ValueAsLong() { }

public override object ValueAs(Type returnType, IXmlNamespaceResolver nsResolver) { }

private object System.ICloneable.Clone() { }

public abstract XmlNameTable get_NameTable();

public virtual string LookupNamespace(string prefix) { }

public virtual string LookupPrefix(string namespaceURI) { }

public virtual IDictionary<string, string> GetNamespacesInScope(XmlNamespaceScope scope) { }

public abstract XPathNavigator Clone();

public abstract XPathNodeType get_NodeType();

public abstract string get_LocalName();

public abstract string get_NamespaceURI();

public abstract string get_Prefix();

public virtual object get_UnderlyingObject() { }

public virtual bool MoveToNamespace(string name) { }

public abstract bool MoveToFirstNamespace(XPathNamespaceScope namespaceScope);

public abstract bool MoveToNextNamespace(XPathNamespaceScope namespaceScope);

public abstract bool MoveToParent();

public abstract bool IsSamePosition(XPathNavigator other);

public virtual IXmlSchemaInfo get_SchemaInfo() { }

internal static bool IsText(XPathNodeType type) { }

protected void .ctor() { }

private static void .cctor() { }

}

internal class XPathNavigatorKeyComparer : IEqualityComparer // TypeDefIndex: 2042
{

private bool System.Collections.IEqualityComparer.Equals(object obj1, object obj2) { }

private int System.Collections.IEqualityComparer.GetHashCode(object obj) { }

public void .ctor() { }

}

public enum XPathNodeType // TypeDefIndex: 2043
{
	public int value__; 
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
{
	private Hashtable namespaces; 

public int Count { get; }
internal ArrayList NamespaceList { get; }
internal Hashtable Namespaces { get; set; }


public void .ctor() { }

public void Add(string prefix, string ns) { }

internal void AddInternal(string prefix, string ns) { }

public XmlQualifiedName[] ToArray() { }

public int get_Count() { }

internal ArrayList get_NamespaceList() { }

internal Hashtable get_Namespaces() { }

internal void set_Namespaces(Hashtable value) { }

}

public sealed class XmlAttributeEventHandler : MulticastDelegate // TypeDefIndex: 2046
{

public void .ctor(object object, IntPtr method) { }

public virtual void Invoke(object sender, XmlAttributeEventArgs e) { }

public virtual IAsyncResult BeginInvoke(object sender, XmlAttributeEventArgs e, AsyncCallback callback, object object) { }

public virtual void EndInvoke(IAsyncResult result) { }

}

public class XmlAttributeEventArgs : EventArgs // TypeDefIndex: 2047
{
	private object o; 
	private XmlAttribute attr; 
	private string qnames; 
	private int lineNumber; 
	private int linePosition; 


internal void .ctor(XmlAttribute attr, int lineNumber, int linePosition, object o, string qnames) { }

}

public sealed class XmlElementEventHandler : MulticastDelegate // TypeDefIndex: 2048
{

public void .ctor(object object, IntPtr method) { }

public virtual void Invoke(object sender, XmlElementEventArgs e) { }

public virtual IAsyncResult BeginInvoke(object sender, XmlElementEventArgs e, AsyncCallback callback, object object) { }

public virtual void EndInvoke(IAsyncResult result) { }

}

public class XmlElementEventArgs : EventArgs // TypeDefIndex: 2049
{
	private object o; 
	private XmlElement elem; 
	private string qnames; 
	private int lineNumber; 
	private int linePosition; 


internal void .ctor(XmlElement elem, int lineNumber, int linePosition, object o, string qnames) { }

}

public sealed class XmlNodeEventHandler : MulticastDelegate // TypeDefIndex: 2050
{

public void .ctor(object object, IntPtr method) { }

public virtual void Invoke(object sender, XmlNodeEventArgs e) { }

public virtual IAsyncResult BeginInvoke(object sender, XmlNodeEventArgs e, AsyncCallback callback, object object) { }

public virtual void EndInvoke(IAsyncResult result) { }

}

public class XmlNodeEventArgs : EventArgs // TypeDefIndex: 2051
{
	private object o; 
	private XmlNode xmlNode; 
	private int lineNumber; 
	private int linePosition; 


internal void .ctor(XmlNode xmlNode, int lineNumber, int linePosition, object o) { }

}

internal class XmlTypeSerializationSource : SerializationSource // TypeDefIndex: 2060
{
	private string attributeOverridesHash; 
	private Type type; 
	private string rootHash; 


public void .ctor(Type type, XmlRootAttribute root, XmlAttributeOverrides attributeOverrides, string namspace, Type[] includedTypes) { }

public override bool Equals(object o) { }

public override int GetHashCode() { }

}

internal class XmlTypeConvertorAttribute : Attribute // TypeDefIndex: 2061
{
	[CompilerGeneratedAttribute] 
	private string <Method>k__BackingField; 

public string Method { get; set; }


	[CompilerGeneratedAttribute] 
public string get_Method() { }

	[CompilerGeneratedAttribute] 
private void set_Method(string value) { }

public void .ctor(string method) { }

}

public class XmlAnyAttributeAttribute : Attribute // TypeDefIndex: 2065
{

public void .ctor() { }

}

public class XmlAnyElementAttribute : Attribute // TypeDefIndex: 2066
{
	private string elementName; 
	private string ns; 
	private int order; 

public string Name { get; }
public string Namespace { get; }
public int Order { get; }


public void .ctor() { }

public string get_Name() { }

public string get_Namespace() { }

public int get_Order() { }

internal void AddKeyHash(StringBuilder sb) { }

}

public class XmlAnyElementAttributes : CollectionBase // TypeDefIndex: 2067
{
public XmlAnyElementAttribute Item { get; }
internal int Order { get; }


public XmlAnyElementAttribute get_Item(int index) { }

public int Add(XmlAnyElementAttribute attribute) { }

internal void AddKeyHash(StringBuilder sb) { }

internal int get_Order() { }

public void .ctor() { }

}

public class XmlArrayAttribute : Attribute // TypeDefIndex: 2068
{
	private string elementName; 
	private XmlSchemaForm form; 
	private bool isNullable; 
	private string ns; 
	private int order; 

public string ElementName { get; }
public XmlSchemaForm Form { get; }
public bool IsNullable { get; }
public string Namespace { get; }
public int Order { get; }


public string get_ElementName() { }

public XmlSchemaForm get_Form() { }

public bool get_IsNullable() { }

public string get_Namespace() { }

public int get_Order() { }

internal void AddKeyHash(StringBuilder sb) { }

}

public class XmlArrayItemAttribute : Attribute // TypeDefIndex: 2069
{
	private string dataType; 
	private string elementName; 
	private XmlSchemaForm form; 
	private string ns; 
	private bool isNullable; 
	private bool isNullableSpecified; 
	private int nestingLevel; 
	private Type type; 

public string DataType { get; }
public string ElementName { get; }
public XmlSchemaForm Form { get; }
public string Namespace { get; }
public bool IsNullable { get; }
internal bool IsNullableSpecified { get; }
public Type Type { get; }
public int NestingLevel { get; }


public string get_DataType() { }

public string get_ElementName() { }

public XmlSchemaForm get_Form() { }

public string get_Namespace() { }

public bool get_IsNullable() { }

internal bool get_IsNullableSpecified() { }

public Type get_Type() { }

public int get_NestingLevel() { }

internal void AddKeyHash(StringBuilder sb) { }

}

public class XmlArrayItemAttributes : CollectionBase // TypeDefIndex: 2070
{
public XmlArrayItemAttribute Item { get; }


public XmlArrayItemAttribute get_Item(int index) { }

public int Add(XmlArrayItemAttribute attribute) { }

internal void AddKeyHash(StringBuilder sb) { }

public void .ctor() { }

}

public class XmlAttributeAttribute : Attribute // TypeDefIndex: 2071
{
	private string attributeName; 
	private string dataType; 
	private Type type; 
	private XmlSchemaForm form; 
	private string ns; 

public string AttributeName { get; }
public string DataType { get; set; }
public XmlSchemaForm Form { get; }
public string Namespace { get; }


public void .ctor(string attributeName) { }

public string get_AttributeName() { }

public string get_DataType() { }

public void set_DataType(string value) { }

public XmlSchemaForm get_Form() { }

public string get_Namespace() { }

internal void AddKeyHash(StringBuilder sb) { }

}

public class XmlAttributeOverrides // TypeDefIndex: 2072
{
	private Hashtable overrides; 

public XmlAttributes Item { get; }
public XmlAttributes Item { get; }


public void .ctor() { }

public XmlAttributes get_Item(Type type) { }

public XmlAttributes get_Item(Type type, string member) { }

private TypeMember GetKey(Type type, string member) { }

internal void AddKeyHash(StringBuilder sb) { }

}

public class XmlAttributes // TypeDefIndex: 2073
{
	private XmlAnyAttributeAttribute xmlAnyAttribute; 
	private XmlAnyElementAttributes xmlAnyElements; 
	private XmlArrayAttribute xmlArray; 
	private XmlArrayItemAttributes xmlArrayItems; 
	private XmlAttributeAttribute xmlAttribute; 
	private XmlChoiceIdentifierAttribute xmlChoiceIdentifier; 
	private object xmlDefaultValue; 
	private XmlElementAttributes xmlElements; 
	private XmlEnumAttribute xmlEnum; 
	private bool xmlIgnore; 
	private bool xmlns; 
	private XmlRootAttribute xmlRoot; 
	private XmlTextAttribute xmlText; 
	private XmlTypeAttribute xmlType; 

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


public void .ctor() { }

public void .ctor(ICustomAttributeProvider provider) { }

public XmlAnyAttributeAttribute get_XmlAnyAttribute() { }

public XmlAnyElementAttributes get_XmlAnyElements() { }

public XmlArrayAttribute get_XmlArray() { }

public XmlArrayItemAttributes get_XmlArrayItems() { }

public XmlAttributeAttribute get_XmlAttribute() { }

public XmlChoiceIdentifierAttribute get_XmlChoiceIdentifier() { }

public object get_XmlDefaultValue() { }

public XmlElementAttributes get_XmlElements() { }

public bool get_XmlIgnore() { }

public bool get_Xmlns() { }

public XmlRootAttribute get_XmlRoot() { }

public XmlTextAttribute get_XmlText() { }

public XmlTypeAttribute get_XmlType() { }

internal void AddKeyHash(StringBuilder sb) { }

internal Nullable<int> get_Order() { }

internal int get_SortableOrder() { }

}

public class XmlChoiceIdentifierAttribute : Attribute // TypeDefIndex: 2074
{
	private string memberName; 

public string MemberName { get; }


public string get_MemberName() { }

internal void AddKeyHash(StringBuilder sb) { }

}

internal class XmlCustomFormatter // TypeDefIndex: 2075
{
	private static string[] allTimeFormats; 


internal static string FromEnum(long value, string[] values, long[] ids, string typeName) { }

internal static string FromXmlName(string name) { }

internal static string FromXmlNCName(string ncName) { }

internal static string ToXmlString(TypeData type, object value) { }

internal static object FromXmlString(TypeData type, string value) { }

private static void .cctor() { }

}

public class XmlElementAttribute : Attribute // TypeDefIndex: 2076
{
	private string dataType; 
	private string elementName; 
	private XmlSchemaForm form; 
	private string ns; 
	private bool isNullable; 
	private Type type; 
	private int order; 

public string DataType { get; }
public string ElementName { get; }
public XmlSchemaForm Form { get; }
public string Namespace { get; }
public bool IsNullable { get; }
public int Order { get; }
public Type Type { get; }


public void .ctor(string elementName) { }

public void .ctor(string elementName, Type type) { }

public string get_DataType() { }

public string get_ElementName() { }

public XmlSchemaForm get_Form() { }

public string get_Namespace() { }

public bool get_IsNullable() { }

public int get_Order() { }

public Type get_Type() { }

internal void AddKeyHash(StringBuilder sb) { }

}

public class XmlElementAttributes : CollectionBase // TypeDefIndex: 2077
{
public XmlElementAttribute Item { get; }
internal int Order { get; }


public XmlElementAttribute get_Item(int index) { }

public int Add(XmlElementAttribute attribute) { }

internal void AddKeyHash(StringBuilder sb) { }

internal int get_Order() { }

public void .ctor() { }

}

public class XmlEnumAttribute : Attribute // TypeDefIndex: 2078
{
	private string name; 

public string Name { get; }


public void .ctor(string name) { }

public string get_Name() { }

internal void AddKeyHash(StringBuilder sb) { }

}

public class XmlIgnoreAttribute : Attribute // TypeDefIndex: 2079
{

public void .ctor() { }

}

public class XmlIncludeAttribute : Attribute // TypeDefIndex: 2080
{
	private Type type; 

public Type Type { get; }


public Type get_Type() { }

}

public abstract class XmlMapping // TypeDefIndex: 2081
{
	private ObjectMap map; 
	private ArrayList relatedMaps; 
	private SerializationFormat format; 
	private SerializationSource source; 
	internal string _elementName; 
	internal string _namespace; 
	private string key; 

public string ElementName { get; }
public string Namespace { get; }
internal ObjectMap ObjectMap { get; set; }
internal ArrayList RelatedMaps { get; set; }
internal SerializationFormat Format { get; set; }
internal SerializationSource Source { get; }


internal void .ctor(string elementName, string ns) { }

public string get_ElementName() { }

public string get_Namespace() { }

public void SetKey(string key) { }

internal ObjectMap get_ObjectMap() { }

internal void set_ObjectMap(ObjectMap value) { }

internal ArrayList get_RelatedMaps() { }

internal void set_RelatedMaps(ArrayList value) { }

internal SerializationFormat get_Format() { }

internal void set_Format(SerializationFormat value) { }

internal SerializationSource get_Source() { }

}

public class XmlMembersMapping : XmlMapping // TypeDefIndex: 2085
{

[DefaultMemberAttribute] 
public class XmlMembersMapping : XmlMapping 
	private bool _hasWrapperElement; 
	private XmlMemberMapping[] _mapping; 

public int Count { get; }
internal bool HasWrapperElement { get; }


public int get_Count() { }

internal bool get_HasWrapperElement() { }

}

public class XmlNamespaceDeclarationsAttribute : Attribute // TypeDefIndex: 2086
{

public void .ctor() { }

}

public class XmlReflectionImporter // TypeDefIndex: 2087
{
	private string initialDefaultNamespace; 
	private XmlAttributeOverrides attributeOverrides; 
	private ArrayList includedTypes; 
	private ReflectionHelper helper; 
	private int arrayChoiceCount; 
	private ArrayList relatedMaps; 
	private bool allowPrivateTypes; 
	private static readonly string errSimple; 
	private static readonly string errSimple2; 


public void .ctor(XmlAttributeOverrides attributeOverrides, string defaultNamespace) { }

public XmlTypeMapping ImportTypeMapping(Type type) { }

public XmlTypeMapping ImportTypeMapping(Type type, string defaultNamespace) { }

public XmlTypeMapping ImportTypeMapping(Type type, XmlRootAttribute root, string defaultNamespace) { }

private XmlTypeMapping ImportTypeMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace) { }

private XmlTypeMapping CreateTypeMapping(TypeData typeData, XmlRootAttribute root, string defaultXmlType, string defaultNamespace) { }

private XmlTypeMapping ImportClassMapping(Type type, XmlRootAttribute root, string defaultNamespace, bool isBaseType = False) { }

private XmlTypeMapping ImportClassMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace, bool isBaseType = False) { }

private void RegisterDerivedMap(XmlTypeMapping map, XmlTypeMapping derivedMap) { }

private string GetTypeNamespace(TypeData typeData, XmlRootAttribute root, string defaultNamespace) { }

private XmlTypeMapping ImportListMapping(Type type, XmlRootAttribute root, string defaultNamespace, XmlAttributes atts, int nestingLevel) { }

private XmlTypeMapping ImportListMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace, XmlAttributes atts, int nestingLevel) { }

private XmlTypeMapping ImportXmlNodeMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace) { }

private XmlTypeMapping ImportPrimitiveMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace) { }

private XmlTypeMapping ImportEnumMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace) { }

private XmlTypeMapping ImportXmlSerializableMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace) { }

private void ImportIncludedTypes(Type type, string defaultNamespace) { }

private List<XmlReflectionMember> GetReflectionMembers(Type type) { }

private XmlTypeMapMember CreateMapMember(Type declaringType, XmlReflectionMember rmember, string defaultNamespace) { }

private XmlTypeMapElementInfoList ImportElementInfo(Type cls, string defaultName, string defaultNamespace, Type defaultType, XmlTypeMapMemberElement member, XmlAttributes atts) { }

private XmlTypeMapElementInfoList ImportAnyElementInfo(string defaultNamespace, XmlReflectionMember rmember, XmlTypeMapMemberElement member, XmlAttributes atts) { }

private void ImportTextElementInfo(XmlTypeMapElementInfoList list, Type defaultType, XmlTypeMapMemberElement member, XmlAttributes atts, string defaultNamespace) { }

private bool CanBeNull(TypeData type) { }

public void IncludeType(Type type) { }

private object GetDefaultValue(TypeData typeData, object defaultValue) { }

private static void .cctor() { }

}

private sealed class XmlReflectionImporter.<>c // TypeDefIndex: 2088
{
	public static readonly XmlReflectionImporter.<>c <>9; 
	public static Comparison<XmlReflectionMember> <>9__28_0; 


private static void .cctor() { }

public void .ctor() { }

internal int <ImportClassMapping>b__28_0(XmlReflectionMember m1, XmlReflectionMember m2) { }

}

public class XmlReflectionMember // TypeDefIndex: 2089
{
	private bool isReturnValue; 
	private string memberName; 
	private Type memberType; 
	private XmlAttributes xmlAttributes; 
	private Type declaringType; 

public bool IsReturnValue { get; }
public string MemberName { get; }
public Type MemberType { get; }
public XmlAttributes XmlAttributes { get; }
internal Type DeclaringType { get; set; }


internal void .ctor(string name, Type type, XmlAttributes attributes) { }

public bool get_IsReturnValue() { }

public string get_MemberName() { }

public Type get_MemberType() { }

public XmlAttributes get_XmlAttributes() { }

internal Type get_DeclaringType() { }

internal void set_DeclaringType(Type value) { }

}

public class XmlRootAttribute : Attribute // TypeDefIndex: 2090
{
	private string dataType; 
	private string elementName; 
	private bool isNullable; 
	private string ns; 

public string DataType { get; set; }
public string ElementName { get; set; }
public bool IsNullable { get; set; }
public string Namespace { get; set; }


public void .ctor() { }

public void .ctor(string elementName) { }

public string get_DataType() { }

public void set_DataType(string value) { }

public string get_ElementName() { }

public void set_ElementName(string value) { }

public bool get_IsNullable() { }

public void set_IsNullable(bool value) { }

public string get_Namespace() { }

public void set_Namespace(string value) { }

internal void AddKeyHash(StringBuilder sb) { }

}

public sealed class XmlSchemaProviderAttribute : Attribute // TypeDefIndex: 2091
{
	private string _methodName; 
	private bool _isAny; 

public string MethodName { get; }
public bool IsAny { get; set; }


public void .ctor(string methodName) { }

public string get_MethodName() { }

public bool get_IsAny() { }

public void set_IsAny(bool value) { }

}

public sealed class XmlSerializationCollectionFixupCallback : MulticastDelegate // TypeDefIndex: 2092
{

public void .ctor(object object, IntPtr method) { }

public virtual void Invoke(object collection, object collectionItems) { }

public virtual IAsyncResult BeginInvoke(object collection, object collectionItems, AsyncCallback callback, object object) { }

public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class XmlSerializationFixupCallback : MulticastDelegate // TypeDefIndex: 2093
{

public void .ctor(object object, IntPtr method) { }

public virtual void Invoke(object fixup) { }

public virtual IAsyncResult BeginInvoke(object fixup, AsyncCallback callback, object object) { }

public virtual void EndInvoke(IAsyncResult result) { }

}

public abstract class XmlSerializationGeneratedCode // TypeDefIndex: 2094
{

protected void .ctor() { }

}

public sealed class XmlSerializationReadCallback : MulticastDelegate // TypeDefIndex: 2095
{

public void .ctor(object object, IntPtr method) { }

public virtual object Invoke() { }

public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

public virtual object EndInvoke(IAsyncResult result) { }

}

public abstract class XmlSerializationReader : XmlSerializationGeneratedCode // TypeDefIndex: 2096
{
	private XmlDocument document; 
	private XmlReader reader; 
	private ArrayList fixups; 
	private Hashtable collFixups; 
	private ArrayList collItemFixups; 
	private Hashtable typesCallbacks; 
	private ArrayList noIDTargets; 
	private Hashtable targets; 
	private Hashtable delayedListFixups; 
	private XmlSerializer eventSource; 
	private int delayedFixupId; 
	private Hashtable referencedObjects; 
	private int readCount; 
	private int whileIterationCount; 
	private string w3SchemaNS; 
	private string w3InstanceNS; 
	private string w3InstanceNS2000; 
	private string w3InstanceNS1999; 
	private string soapNS; 
	private string wsdlNS; 
	private string nullX; 
	private string nil; 
	private string typeX; 
	private string arrayType; 
	private XmlQualifiedName arrayQName; 

protected XmlDocument Document { get; }
protected XmlReader Reader { get; }


internal void Initialize(XmlReader reader, XmlSerializer eventSource) { }

private ArrayList EnsureArrayList(ArrayList list) { }

private Hashtable EnsureHashtable(Hashtable hash) { }

protected void .ctor() { }

protected XmlDocument get_Document() { }

protected XmlReader get_Reader() { }

protected void AddFixup(XmlSerializationReader.CollectionFixup fixup) { }

protected void AddFixup(XmlSerializationReader.Fixup fixup) { }

private void AddFixup(XmlSerializationReader.CollectionItemFixup fixup) { }

protected void AddReadCallback(string name, string ns, Type type, XmlSerializationReadCallback read) { }

protected void AddTarget(string id, object o) { }

private string CurrentTag() { }

protected Exception CreateReadOnlyCollectionException(string name) { }

protected Exception CreateUnknownConstantException(string value, Type enumType) { }

protected Exception CreateUnknownNodeException() { }

protected Exception CreateUnknownTypeException(XmlQualifiedName type) { }

protected Array EnsureArrayIndex(Array a, int index, Type elementType) { }

protected bool GetNullAttr() { }

protected object GetTarget(string id) { }

private bool TargetReady(string id) { }

protected XmlQualifiedName GetXsiType() { }

protected abstract void InitCallbacks();

protected abstract void InitIDs();

protected bool IsXmlnsAttribute(string name) { }

protected void ParseWsdlArrayType(XmlAttribute attr) { }

protected XmlQualifiedName ReadElementQualifiedName() { }

protected void ReadEndElement() { }

protected bool ReadNull() { }

protected XmlQualifiedName ReadNullableQualifiedName() { }

protected string ReadNullableString() { }

protected object ReadReferencedElement() { }

private XmlSerializationReader.WriteCallbackInfo GetCallbackInfo(XmlQualifiedName qname) { }

protected object ReadReferencedElement(string name, string ns) { }

private bool ReadList(out object resultList) { }

protected void ReadReferencedElements() { }

protected object ReadReferencingElement(out string fixupReference) { }

protected object ReadReferencingElement(string name, string ns, out string fixupReference) { }

protected object ReadReferencingElement(string name, string ns, bool elementCanBeType, out string fixupReference) { }

protected IXmlSerializable ReadSerializable(IXmlSerializable serializable) { }

protected object ReadTypedPrimitive(XmlQualifiedName type) { }

private object ReadTypedPrimitive(XmlQualifiedName qname, bool reportUnknown) { }

protected XmlNode ReadXmlNode(bool wrapped) { }

protected XmlDocument ReadXmlDocument(bool wrapped) { }

protected Array ShrinkArray(Array a, int length, Type elementType, bool isNullable) { }

protected XmlQualifiedName ToXmlQualifiedName(string value) { }

protected void UnknownAttribute(object o, XmlAttribute attr, string qnames) { }

protected void UnknownElement(object o, XmlElement elem, string qnames) { }

protected void UnknownNode(object o) { }

protected void UnknownNode(object o, string qnames) { }

private void OnUnknownNode(XmlNode node, object o, string qnames) { }

protected void UnreferencedObject(string id, object o) { }

}

private class XmlSerializationReader.WriteCallbackInfo // TypeDefIndex: 2097
{
	public Type Type; 
	public string TypeName; 
	public string TypeNs; 
	public XmlSerializationReadCallback Callback; 


public void .ctor() { }

}

private class XmlSerializationReader.CollectionItemFixup // TypeDefIndex: 2100
{
	private Array list; 
	private int index; 
	private string id; 

public Array Collection { get; }
public int Index { get; }
public string Id { get; }


public void .ctor(Array list, int index, string id) { }

public Array get_Collection() { }

public int get_Index() { }

public string get_Id() { }

}

internal class XmlSerializationReaderInterpreter : XmlSerializationReader // TypeDefIndex: 2101
{
	private XmlMapping _typeMap; 
	private SerializationFormat _format; 
	private static readonly XmlQualifiedName AnyType; 
	private static readonly object[] empty_array; 


public void .ctor(XmlMapping typeMap) { }

protected override void InitCallbacks() { }

protected override void InitIDs() { }

public object ReadRoot() { }

private object ReadEncodedObject(XmlTypeMapping typeMap) { }

protected virtual object ReadMessage(XmlMembersMapping typeMap) { }

private object ReadRoot(XmlTypeMapping rootMap) { }

protected virtual object ReadObject(XmlTypeMapping typeMap, bool isNullable, bool checkType) { }

protected virtual object ReadClassInstance(XmlTypeMapping typeMap, bool isNullable, bool checkType) { }

protected virtual void ReadClassInstanceMembers(XmlTypeMapping typeMap, object ob) { }

private void ReadAttributeMembers(ClassMap map, object ob, bool isValueList) { }

private void ReadMembers(ClassMap map, object ob, bool isValueList, bool readBySoapOrder) { }

private void SetListMembersDefaults(ClassMap map, object ob, bool isValueList) { }

internal void FixupMembers(ClassMap map, object obfixup, bool isValueList) { }

protected virtual void ProcessUnknownAttribute(object target) { }

protected virtual void ProcessUnknownElement(object target) { }

private bool IsReadOnly(XmlTypeMapMember member, TypeData memType, object ob, bool isValueList) { }

private void SetMemberValue(XmlTypeMapMember member, object ob, object value, bool isValueList) { }

private void SetMemberValueFromAttr(XmlTypeMapMember member, object ob, object value, bool isValueList) { }

private object GetMemberValue(XmlTypeMapMember member, object ob, bool isValueList) { }

private object ReadObjectElement(XmlTypeMapElementInfo elem) { }

private object ReadPrimitiveValue(XmlTypeMapElementInfo elem) { }

private object GetValueFromXmlString(string value, TypeData typeData, XmlTypeMapping typeMap) { }

private object ReadListElement(XmlTypeMapping typeMap, bool isNullable, object list, bool canCreateInstance) { }

private object ReadListString(XmlTypeMapping typeMap, string values) { }

private void AddListValue(TypeData listType, ref object list, int index, object value, bool canCreateInstance) { }

private static object CreateInstance(Type type, bool nonPublic) { }

private object CreateInstance(Type type) { }

private object CreateList(Type listType) { }

private object InitializeList(TypeData listType) { }

private void FillList(object list, object items) { }

private void CopyEnumerableList(object source, object dest) { }

private object ReadXmlNodeElement(XmlTypeMapping typeMap, bool isNullable) { }

private object ReadXmlNode(TypeData type, bool wrapped) { }

private object ReadPrimitiveElement(XmlTypeMapping typeMap, bool isNullable) { }

private object ReadEnumElement(XmlTypeMapping typeMap, bool isNullable) { }

private object GetEnumValue(XmlTypeMapping typeMap, string val) { }

private object ReadXmlSerializableElement(XmlTypeMapping typeMap, bool isNullable) { }

private static void .cctor() { }

}

private class XmlSerializationReaderInterpreter.FixupCallbackInfo // TypeDefIndex: 2102
{
	private XmlSerializationReaderInterpreter _sri; 
	private ClassMap _map; 
	private bool _isValueList; 


public void .ctor(XmlSerializationReaderInterpreter sri, ClassMap map, bool isValueList) { }

public void FixupMembers(object fixup) { }

}

private class XmlSerializationReaderInterpreter.ReaderCallbackInfo // TypeDefIndex: 2103
{
	private XmlSerializationReaderInterpreter _sri; 
	private XmlTypeMapping _typeMap; 


public void .ctor(XmlSerializationReaderInterpreter sri, XmlTypeMapping typeMap) { }

internal object ReadObject() { }

}

public sealed class XmlSerializationWriteCallback : MulticastDelegate // TypeDefIndex: 2104
{

public void .ctor(object object, IntPtr method) { }

public virtual void Invoke(object o) { }

public virtual IAsyncResult BeginInvoke(object o, AsyncCallback callback, object object) { }

public virtual void EndInvoke(IAsyncResult result) { }

}

public abstract class XmlSerializationWriter : XmlSerializationGeneratedCode // TypeDefIndex: 2105
{
	private ObjectIDGenerator idGenerator; 
	private int qnameCount; 
	private bool topLevelElement; 
	private ArrayList namespaces; 
	private XmlWriter writer; 
	private Queue referencedElements; 
	private Hashtable callbacks; 
	private Hashtable serializedObjects; 

protected XmlWriter Writer { get; }


protected void .ctor() { }

internal void Initialize(XmlWriter writer, XmlSerializerNamespaces nss) { }

protected XmlWriter get_Writer() { }

protected void AddWriteCallback(Type type, string typeName, string typeNs, XmlSerializationWriteCallback callback) { }

protected Exception CreateUnknownAnyElementException(string name, string ns) { }

protected Exception CreateUnknownTypeException(object o) { }

protected Exception CreateUnknownTypeException(Type type) { }

protected string FromXmlQualifiedName(XmlQualifiedName xmlQualifiedName) { }

private string GetId(object o, bool addToReferencesList) { }

private bool AlreadyQueued(object ob) { }

private string GetNamespacePrefix(string ns) { }

private string GetQualifiedName(string name, string ns) { }

protected abstract void InitCallbacks();

protected void TopLevelElement() { }

protected void WriteAttribute(string localName, string ns, string value) { }

protected void WriteAttribute(string prefix, string localName, string ns, string value) { }

private void WriteXmlNode(XmlNode node) { }

protected void WriteElementEncoded(XmlNode node, string name, string ns, bool isNullable, bool any) { }

protected void WriteElementLiteral(XmlNode node, string name, string ns, bool isNullable, bool any) { }

protected void WriteElementQualifiedName(string localName, string ns, XmlQualifiedName value) { }

protected void WriteElementQualifiedName(string localName, string ns, XmlQualifiedName value, XmlQualifiedName xsiType) { }

protected void WriteElementString(string localName, string ns, string value) { }

protected void WriteElementString(string localName, string ns, string value, XmlQualifiedName xsiType) { }

protected void WriteEndElement() { }

protected void WriteEndElement(object o) { }

protected void WriteNamespaceDeclarations(XmlSerializerNamespaces xmlns) { }

protected void WriteNullableQualifiedNameEncoded(string name, string ns, XmlQualifiedName value, XmlQualifiedName xsiType) { }

protected void WriteNullableQualifiedNameLiteral(string name, string ns, XmlQualifiedName value) { }

protected void WriteNullableStringEncoded(string name, string ns, string value, XmlQualifiedName xsiType) { }

protected void WriteNullableStringLiteral(string name, string ns, string value) { }

protected void WriteNullTagEncoded(string name, string ns) { }

protected void WriteNullTagLiteral(string name, string ns) { }

protected void WritePotentiallyReferencingElement(string n, string ns, object o, Type ambientType, bool suppressReference, bool isNullable) { }

protected void WriteReferencedElements() { }

private bool IsPrimitiveArray(TypeData td) { }

private void WriteArray(object o, TypeData td) { }

protected void WriteReferencingElement(string n, string ns, object o, bool isNullable) { }

private void CheckReferenceQueue() { }

protected void WriteSerializable(IXmlSerializable serializable, string name, string ns, bool isNullable) { }

protected void WriteSerializable(IXmlSerializable serializable, string name, string ns, bool isNullable, bool wrapped) { }

protected void WriteStartDocument() { }

protected void WriteStartElement(string name, string ns) { }

protected void WriteStartElement(string name, string ns, bool writePrefixed) { }

protected void WriteStartElement(string name, string ns, object o) { }

protected void WriteStartElement(string name, string ns, object o, bool writePrefixed) { }

private void WriteStartElement(string name, string ns, object o, bool writePrefixed, ICollection namespaces) { }

protected void WriteTypedPrimitive(string name, string ns, object o, bool xsiType) { }

protected void WriteValue(string value) { }

protected void WriteXmlAttribute(XmlNode node, object container) { }

protected void WriteXsiType(string name, string ns) { }

}

private class XmlSerializationWriter.WriteCallbackInfo // TypeDefIndex: 2106
{
	public Type Type; 
	public string TypeName; 
	public string TypeNs; 
	public XmlSerializationWriteCallback Callback; 


public void .ctor() { }

}

internal class XmlSerializationWriterInterpreter : XmlSerializationWriter // TypeDefIndex: 2107
{
	private XmlMapping _typeMap; 
	private SerializationFormat _format; 


public void .ctor(XmlMapping typeMap) { }

protected override void InitCallbacks() { }

public void WriteRoot(object ob) { }

protected virtual void WriteObject(XmlTypeMapping typeMap, object ob, string element, string namesp, bool isNullable, bool needType, bool writeWrappingElem) { }

protected virtual void WriteMessage(XmlMembersMapping membersMap, object[] parameters) { }

protected virtual void WriteObjectElement(XmlTypeMapping typeMap, object ob, string element, string namesp) { }

protected virtual void WriteObjectElementAttributes(XmlTypeMapping typeMap, object ob) { }

protected virtual void WriteObjectElementElements(XmlTypeMapping typeMap, object ob) { }

private void WriteMembers(ClassMap map, object ob, bool isValueList) { }

private void WriteAttributeMembers(ClassMap map, object ob, bool isValueList) { }

private void WriteElementMembers(ClassMap map, object ob, bool isValueList) { }

private object GetMemberValue(XmlTypeMapMember member, object ob, bool isValueList) { }

private bool MemberHasValue(XmlTypeMapMember member, object ob, bool isValueList) { }

private void WriteMemberElement(XmlTypeMapElementInfo elem, object memberValue) { }

internal static object ImplicitConvert(object obj, Type type) { }

private void WritePrimitiveValueLiteral(object memberValue, string name, string ns, XmlTypeMapping mappedType, TypeData typeData, bool wrapped, bool isNullable) { }

private void WritePrimitiveValueEncoded(object memberValue, string name, string ns, XmlQualifiedName xsiType, XmlTypeMapping mappedType, TypeData typeData, bool wrapped, bool isNullable) { }

protected virtual void WriteListElement(XmlTypeMapping typeMap, object ob, string element, string namesp) { }

private void WriteListContent(object container, TypeData listType, ListMap map, object ob, StringBuilder targetString) { }

private int GetListCount(TypeData listType, object ob) { }

private void WriteAnyElementContent(XmlTypeMapMemberAnyElement member, object memberValue) { }

protected virtual void WritePrimitiveElement(XmlTypeMapping typeMap, object ob, string element, string namesp) { }

protected virtual void WriteEnumElement(XmlTypeMapping typeMap, object ob, string element, string namesp) { }

private string GetStringValue(XmlTypeMapping typeMap, TypeData type, object value) { }

private string GetEnumXmlValue(XmlTypeMapping typeMap, object ob) { }

}

private class XmlSerializationWriterInterpreter.CallbackInfo // TypeDefIndex: 2108
{
	private XmlSerializationWriterInterpreter _swi; 
	private XmlTypeMapping _typeMap; 


public void .ctor(XmlSerializationWriterInterpreter swi, XmlTypeMapping typeMap) { }

internal void WriteObject(object ob) { }

internal void WriteEnum(object ob) { }

}

public class XmlSerializer // TypeDefIndex: 2109
{
	private static int generationThreshold; 
	private static bool backgroundGeneration; 
	private static bool deleteTempFiles; 
	private static bool generatorFallback; 
	private bool customSerializer; 
	private XmlMapping typeMapping; 
	private XmlSerializer.SerializerData serializerData; 
	private static Hashtable serializerTypes; 
	private UnreferencedObjectEventHandler onUnreferencedObject; 
	private XmlAttributeEventHandler onUnknownAttribute; 
	private XmlElementEventHandler onUnknownElement; 
	private XmlNodeEventHandler onUnknownNode; 
	private static Encoding DefaultEncoding; 

internal XmlMapping Mapping { get; }


private static void .cctor() { }

public void .ctor(Type type) { }

public void .ctor(Type type, XmlAttributeOverrides overrides, Type[] extraTypes, XmlRootAttribute root, string defaultNamespace) { }

internal XmlMapping get_Mapping() { }

internal virtual void OnUnknownAttribute(XmlAttributeEventArgs e) { }

internal virtual void OnUnknownElement(XmlElementEventArgs e) { }

internal virtual void OnUnknownNode(XmlNodeEventArgs e) { }

internal virtual void OnUnreferencedObject(UnreferencedObjectEventArgs e) { }

protected virtual XmlSerializationReader CreateReader() { }

protected virtual XmlSerializationWriter CreateWriter() { }

public object Deserialize(TextReader textReader) { }

public object Deserialize(XmlReader xmlReader) { }

protected virtual object Deserialize(XmlSerializationReader reader) { }

protected virtual void Serialize(object o, XmlSerializationWriter writer) { }

public void Serialize(TextWriter textWriter, object o) { }

public void Serialize(XmlWriter xmlWriter, object o) { }

public void Serialize(XmlWriter xmlWriter, object o, XmlSerializerNamespaces namespaces) { }

private XmlSerializationWriter CreateWriter(XmlMapping typeMapping) { }

private XmlSerializationReader CreateReader(XmlMapping typeMapping) { }

}

internal class XmlSerializer.SerializerData // TypeDefIndex: 2110
{
	public MethodInfo ReaderMethod; 
	public Type WriterType; 
	public MethodInfo WriterMethod; 
	public XmlSerializerImplementation Implementation; 


public XmlSerializationWriter CreateWriter() { }

}

public class XmlSerializerFactory // TypeDefIndex: 2111
{
	private static Hashtable serializersBySource; 


public void .ctor() { }

public XmlSerializer CreateSerializer(Type type) { }

public XmlSerializer CreateSerializer(Type type, XmlRootAttribute root) { }

public XmlSerializer CreateSerializer(Type type, XmlAttributeOverrides overrides, Type[] extraTypes, XmlRootAttribute root, string defaultNamespace) { }

private static void .cctor() { }

}

public abstract class XmlSerializerImplementation // TypeDefIndex: 2112
{
public virtual XmlSerializationWriter Writer { get; }


public virtual XmlSerializationWriter get_Writer() { }

}

public class XmlTextAttribute : Attribute // TypeDefIndex: 2113
{
	private string dataType; 
	private Type type; 

public string DataType { get; }
public Type Type { get; }


public void .ctor() { }

public string get_DataType() { }

public Type get_Type() { }

internal void AddKeyHash(StringBuilder sb) { }

}

public class XmlTypeAttribute : Attribute // TypeDefIndex: 2114
{
	private bool includeInSchema; 
	private string ns; 
	private string typeName; 

public bool IncludeInSchema { get; }
public string Namespace { get; }
public string TypeName { get; }


public bool get_IncludeInSchema() { }

public string get_Namespace() { }

public string get_TypeName() { }

internal void AddKeyHash(StringBuilder sb) { }

}

internal class XmlTypeMapElementInfo // TypeDefIndex: 2115
{
	private string _elementName; 
	private string _namespace; 
	private XmlSchemaForm _form; 
	private XmlTypeMapMember _member; 
	private object _choiceValue; 
	private bool _isNullable; 
	private int _nestingLevel; 
	private XmlTypeMapping _mappedType; 
	private TypeData _type; 
	private bool _wrappedElement; 
	private int _explicitOrder; 

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


public void .ctor(XmlTypeMapMember member, TypeData type) { }

public TypeData get_TypeData() { }

public object get_ChoiceValue() { }

public void set_ChoiceValue(object value) { }

public string get_ElementName() { }

public void set_ElementName(string value) { }

public string get_Namespace() { }

public void set_Namespace(string value) { }

public string get_DataTypeNamespace() { }

public string get_DataTypeName() { }

public XmlSchemaForm get_Form() { }

public void set_Form(XmlSchemaForm value) { }

public XmlTypeMapping get_MappedType() { }

public void set_MappedType(XmlTypeMapping value) { }

public bool get_IsNullable() { }

public void set_IsNullable(bool value) { }

public XmlTypeMapMember get_Member() { }

public void set_NestingLevel(int value) { }

public bool get_MultiReferenceType() { }

public bool get_WrappedElement() { }

public void set_WrappedElement(bool value) { }

public bool get_IsTextElement() { }

public void set_IsTextElement(bool value) { }

public bool get_IsUnnamedAnyElement() { }

public void set_IsUnnamedAnyElement(bool value) { }

public int get_ExplicitOrder() { }

public void set_ExplicitOrder(int value) { }

public override bool Equals(object other) { }

public override int GetHashCode() { }

}

internal class XmlTypeMapElementInfoList : ArrayList // TypeDefIndex: 2116
{

public void .ctor() { }

}

internal class XmlTypeMapMember // TypeDefIndex: 2117
{
	private string _name; 
	private int _index; 
	private int _globalIndex; 
	private int _specifiedGlobalIndex; 
	private TypeData _typeData; 
	private MemberInfo _member; 
	private MemberInfo _specifiedMember; 
	private MethodInfo _shouldSerialize; 
	private object _defaultValue; 
	private int _flags; 

public string Name { get; set; }
public object DefaultValue { get; set; }
public TypeData TypeData { get; set; }
public int Index { get; set; }
public int GlobalIndex { get; set; }
public bool IsOptionalValueType { get; set; }
public bool IsReturnValue { get; set; }


public void .ctor() { }

public string get_Name() { }

public void set_Name(string value) { }

public object get_DefaultValue() { }

public void set_DefaultValue(object value) { }

public bool IsReadOnly(Type type) { }

public static object GetValue(object ob, string name) { }

public object GetValue(object ob) { }

public void SetValue(object ob, object value) { }

public static void SetValue(object ob, string name, object value) { }

private void InitMember(Type type) { }

public TypeData get_TypeData() { }

public void set_TypeData(TypeData value) { }

public int get_Index() { }

public void set_Index(int value) { }

public int get_GlobalIndex() { }

public void set_GlobalIndex(int value) { }

public bool get_IsOptionalValueType() { }

public void set_IsOptionalValueType(bool value) { }

public bool get_IsReturnValue() { }

public void set_IsReturnValue(bool value) { }

public void CheckOptionalValueType(Type type) { }

public bool GetValueSpecified(object ob) { }

public void SetValueSpecified(object ob, bool value) { }

}

internal class XmlTypeMapMemberAttribute : XmlTypeMapMember // TypeDefIndex: 2118
{
	private string _attributeName; 
	private string _namespace; 
	private XmlSchemaForm _form; 
	private XmlTypeMapping _mappedType; 

public string AttributeName { get; set; }
public string Namespace { get; set; }
public XmlSchemaForm Form { set; }
public XmlTypeMapping MappedType { get; set; }


public void .ctor() { }

public string get_AttributeName() { }

public void set_AttributeName(string value) { }

public string get_Namespace() { }

public void set_Namespace(string value) { }

public void set_Form(XmlSchemaForm value) { }

public XmlTypeMapping get_MappedType() { }

public void set_MappedType(XmlTypeMapping value) { }

}

internal class XmlTypeMapMemberElement : XmlTypeMapMember // TypeDefIndex: 2119
{
	private XmlTypeMapElementInfoList _elementInfo; 
	private string _choiceMember; 
	private bool _isTextCollector; 
	private TypeData _choiceTypeData; 

public XmlTypeMapElementInfoList ElementInfo { get; set; }
public string ChoiceMember { get; set; }
public TypeData ChoiceTypeData { get; set; }
public bool IsXmlTextCollector { get; set; }


public void .ctor() { }

public XmlTypeMapElementInfoList get_ElementInfo() { }

public void set_ElementInfo(XmlTypeMapElementInfoList value) { }

public string get_ChoiceMember() { }

public void set_ChoiceMember(string value) { }

public TypeData get_ChoiceTypeData() { }

public void set_ChoiceTypeData(TypeData value) { }

public XmlTypeMapElementInfo FindElement(object ob, object memberValue) { }

public void SetChoice(object ob, object choice) { }

public bool get_IsXmlTextCollector() { }

public void set_IsXmlTextCollector(bool value) { }

}

internal class XmlTypeMapMemberList : XmlTypeMapMemberElement // TypeDefIndex: 2120
{

public void .ctor() { }

}

internal class XmlTypeMapMemberExpandable : XmlTypeMapMemberElement // TypeDefIndex: 2121
{
	private int _flatArrayIndex; 

public int FlatArrayIndex { get; set; }


public int get_FlatArrayIndex() { }

public void set_FlatArrayIndex(int value) { }

public void .ctor() { }

}

internal class XmlTypeMapMemberFlatList : XmlTypeMapMemberExpandable // TypeDefIndex: 2122
{
	private ListMap _listMap; 

public ListMap ListMap { get; set; }


public ListMap get_ListMap() { }

public void set_ListMap(ListMap value) { }

public void .ctor() { }

}

internal class XmlTypeMapMemberAnyElement : XmlTypeMapMemberExpandable // TypeDefIndex: 2123
{
public bool IsDefaultAny { get; }


public bool IsElementDefined(string name, string ns) { }

public bool get_IsDefaultAny() { }

public void .ctor() { }

}

internal class XmlTypeMapMemberAnyAttribute : XmlTypeMapMember // TypeDefIndex: 2124
{

public void .ctor() { }

}

internal class XmlTypeMapMemberNamespaces : XmlTypeMapMember // TypeDefIndex: 2125
{

public void .ctor() { }

}

public class XmlTypeMapping : XmlMapping // TypeDefIndex: 2126
{
	private string xmlType; 
	private string xmlTypeNamespace; 
	private TypeData type; 
	private XmlTypeMapping baseMap; 
	private bool multiReferenceType; 
	private bool includeInSchema; 
	private bool isNullable; 
	private bool isAny; 
	private ArrayList _derivedTypes; 

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


internal void .ctor(string elementName, string ns, TypeData typeData, string xmlType, string xmlTypeNamespace) { }

public string get_TypeFullName() { }

internal TypeData get_TypeData() { }

internal string get_XmlType() { }

internal void set_XmlType(string value) { }

internal string get_XmlTypeNamespace() { }

internal void set_XmlTypeNamespace(string value) { }

internal bool get_HasXmlTypeNamespace() { }

internal ArrayList get_DerivedTypes() { }

internal bool get_MultiReferenceType() { }

internal XmlTypeMapping get_BaseMap() { }

internal void set_BaseMap(XmlTypeMapping value) { }

internal void set_IncludeInSchema(bool value) { }

internal bool get_IsNullable() { }

internal void set_IsNullable(bool value) { }

internal bool get_IsAny() { }

internal void set_IsAny(bool value) { }

internal XmlTypeMapping GetRealTypeMap(Type objectType) { }

internal XmlTypeMapping GetRealElementMap(string name, string ens) { }

internal void UpdateRoot(XmlQualifiedName qname) { }

}

public enum XmlSchemaDatatypeVariety // TypeDefIndex: 2174
{
	public int value__; 
public const XmlSchemaDatatypeVariety Atomic = 0;
public const XmlSchemaDatatypeVariety List = 1;
public const XmlSchemaDatatypeVariety Union = 2;

}

internal class XsdSimpleValue // TypeDefIndex: 2175
{
	private XmlSchemaSimpleType xmlType; 
	private object typedValue; 

public XmlSchemaSimpleType XmlType { get; }
public object TypedValue { get; }


public void .ctor(XmlSchemaSimpleType st, object value) { }

public XmlSchemaSimpleType get_XmlType() { }

public object get_TypedValue() { }

}

internal enum XmlSchemaWhiteSpace // TypeDefIndex: 2177
{
	public int value__; 
public const XmlSchemaWhiteSpace Preserve = 0;
public const XmlSchemaWhiteSpace Replace = 1;
public const XmlSchemaWhiteSpace Collapse = 2;

}

public sealed class XmlSchemaInference // TypeDefIndex: 2259
{
	internal static XmlQualifiedName ST_boolean; 
	internal static XmlQualifiedName ST_byte; 
	internal static XmlQualifiedName ST_unsignedByte; 
	internal static XmlQualifiedName ST_short; 
	internal static XmlQualifiedName ST_unsignedShort; 
	internal static XmlQualifiedName ST_int; 
	internal static XmlQualifiedName ST_unsignedInt; 
	internal static XmlQualifiedName ST_long; 
	internal static XmlQualifiedName ST_unsignedLong; 
	internal static XmlQualifiedName ST_integer; 
	internal static XmlQualifiedName ST_decimal; 
	internal static XmlQualifiedName ST_float; 
	internal static XmlQualifiedName ST_double; 
	internal static XmlQualifiedName ST_duration; 
	internal static XmlQualifiedName ST_dateTime; 
	internal static XmlQualifiedName ST_time; 
	internal static XmlQualifiedName ST_date; 
	internal static XmlQualifiedName ST_gYearMonth; 
	internal static XmlQualifiedName ST_string; 
	internal static XmlQualifiedName ST_anySimpleType; 
	internal static XmlQualifiedName[] SimpleTypes; 
	private XmlSchema rootSchema; 
	private XmlSchemaSet schemaSet; 
	private XmlReader xtr; 
	private NameTable nametable; 
	private string TargetNamespace; 
	private XmlNamespaceManager NamespaceManager; 
	private ArrayList schemaList; 
	private XmlSchemaInference.InferenceOption occurrence; 
	private XmlSchemaInference.InferenceOption typeInference; 

public XmlSchemaInference.InferenceOption Occurrence { get; set; }
public XmlSchemaInference.InferenceOption TypeInference { set; }


public void set_Occurrence(XmlSchemaInference.InferenceOption value) { }

public XmlSchemaInference.InferenceOption get_Occurrence() { }

public void set_TypeInference(XmlSchemaInference.InferenceOption value) { }

public void .ctor() { }

public XmlSchemaSet InferSchema(XmlReader instanceDocument) { }

internal XmlSchemaSet InferSchema1(XmlReader instanceDocument, XmlSchemaSet schemas) { }

private XmlSchemaAttribute AddAttribute(string localName, string prefix, string childURI, string attrValue, bool bCreatingNewType, XmlSchema parentSchema, XmlSchemaObjectCollection addLocation, XmlSchemaObjectTable compiledAttributes) { }

private XmlSchema CreateXmlSchema(string targetNS) { }

private XmlSchemaElement AddElement(string localName, string prefix, string childURI, XmlSchema parentSchema, XmlSchemaObjectCollection addLocation, int positionWithinCollection) { }

internal void InferElement(XmlSchemaElement xse, bool bCreatingNewType, XmlSchema parentSchema) { }

private XmlSchemaSimpleContentExtension CheckSimpleContentExtension(XmlSchemaComplexType ct) { }

private XmlSchemaType GetEffectiveSchemaType(XmlSchemaElement elem, bool bCreatingNewType) { }

internal XmlSchemaElement FindMatchingElement(bool bCreatingNewType, XmlReader xtr, XmlSchemaComplexType ct, ref int lastUsedSeqItem, ref bool bParticleChanged, XmlSchema parentSchema, bool setMaxoccurs) { }

internal void ProcessAttributes(ref XmlSchemaElement xse, XmlSchemaType effectiveSchemaType, bool bCreatingNewType, XmlSchema parentSchema) { }

private void MoveAttributes(XmlSchemaSimpleContentExtension scExtension, XmlSchemaComplexType ct) { }

private void MoveAttributes(XmlSchemaComplexType ct, XmlSchemaSimpleContentExtension simpleContentExtension, bool bCreatingNewType) { }

internal XmlSchemaAttribute FindAttribute(ICollection attributes, string attrName) { }

internal XmlSchemaElement FindGlobalElement(string namespaceURI, string localName, out XmlSchema parentSchema) { }

internal XmlSchemaElement FindElement(XmlSchemaObjectCollection elements, string elementName) { }

internal XmlSchemaAttribute FindAttributeRef(ICollection attributes, string attributeName, string nsURI) { }

internal XmlSchemaElement FindElementRef(XmlSchemaObjectCollection elements, string elementName, string nsURI) { }

internal void MakeExistingAttributesOptional(XmlSchemaComplexType ct, XmlSchemaObjectCollection attributesInInstance) { }

private void SwitchUseToOptional(XmlSchemaObjectCollection attributes, XmlSchemaObjectCollection attributesInInstance) { }

internal XmlQualifiedName RefineSimpleType(string s, ref int iTypeFlags) { }

internal static int InferSimpleType(string s, ref bool bNeedsRangeCheck) { }

internal static int DateTime(string s, bool bDate, bool bTime) { }

private XmlSchemaElement CreateNewElementforChoice(XmlSchemaElement copyElement) { }

private static int GetSchemaType(XmlQualifiedName qname) { }

internal void SetMinMaxOccurs(XmlSchemaElement el, bool setMaxOccurs) { }

private static void .cctor() { }

}

public enum XmlSchemaInference.InferenceOption // TypeDefIndex: 2260
{
	public int value__; 
public const XmlSchemaInference.InferenceOption Restricted = 0;
public const XmlSchemaInference.InferenceOption Relaxed = 1;

}

public class XmlSchemaInferenceException : XmlSchemaException // TypeDefIndex: 2261
{

protected void .ctor(SerializationInfo info, StreamingContext context) { }

public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

public void .ctor() { }

internal void .ctor(string res, string arg) { }

internal void .ctor(string res, int lineNumber, int linePosition) { }

}

public sealed class XmlAtomicValue : XPathItem, ICloneable // TypeDefIndex: 2303
{
	private XmlSchemaType xmlType; 
	private object objVal; 
	private TypeCode clrType; 
	private XmlAtomicValue.Union unionVal; 
	private XmlAtomicValue.NamespacePrefixForQName nsPrefix; 

public override XmlSchemaType XmlType { get; }
public override Type ValueType { get; }
public override object TypedValue { get; }
public override bool ValueAsBoolean { get; }
public override DateTime ValueAsDateTime { get; }
public override double ValueAsDouble { get; }
public override int ValueAsInt { get; }
public override long ValueAsLong { get; }
public override string Value { get; }


internal void .ctor(XmlSchemaType xmlType, bool value) { }

internal void .ctor(XmlSchemaType xmlType, DateTime value) { }

internal void .ctor(XmlSchemaType xmlType, double value) { }

internal void .ctor(XmlSchemaType xmlType, int value) { }

internal void .ctor(XmlSchemaType xmlType, long value) { }

internal void .ctor(XmlSchemaType xmlType, string value) { }

internal void .ctor(XmlSchemaType xmlType, string value, IXmlNamespaceResolver nsResolver) { }

internal void .ctor(XmlSchemaType xmlType, object value) { }

internal void .ctor(XmlSchemaType xmlType, object value, IXmlNamespaceResolver nsResolver) { }

private object System.ICloneable.Clone() { }

public override XmlSchemaType get_XmlType() { }

public override Type get_ValueType() { }

public override object get_TypedValue() { }

public override bool get_ValueAsBoolean() { }

public override DateTime get_ValueAsDateTime() { }

public override double get_ValueAsDouble() { }

public override int get_ValueAsInt() { }

public override long get_ValueAsLong() { }

public override object ValueAs(Type type, IXmlNamespaceResolver nsResolver) { }

public override string get_Value() { }

public override string ToString() { }

private string GetPrefixFromQName(string value) { }

}

private struct XmlAtomicValue.Union // TypeDefIndex: 2304
{
	public bool boolVal; 
	public double dblVal; 
	public long i64Val; 
	public int i32Val; 
	public DateTime dtVal; 

}

private class XmlAtomicValue.NamespacePrefixForQName : IXmlNamespaceResolver // TypeDefIndex: 2305
{
	public string prefix; 
	public string ns; 


public void .ctor(string prefix, string ns) { }

public string LookupNamespace(string prefix) { }

public string LookupPrefix(string namespaceName) { }

public IDictionary<string, string> GetNamespacesInScope(XmlNamespaceScope scope) { }

}

public class XmlSchema : XmlSchemaObject // TypeDefIndex: 2306
{
	private XmlSchemaForm attributeFormDefault; 
	private XmlSchemaForm elementFormDefault; 
	private XmlSchemaDerivationMethod blockDefault; 
	private XmlSchemaDerivationMethod finalDefault; 
	private string targetNs; 
	private string version; 
	private XmlSchemaObjectCollection includes; 
	private XmlSchemaObjectCollection items; 
	private string id; 
	private XmlAttribute[] moreAttributes; 
	private bool isCompiled; 
	private bool isCompiledBySet; 
	private bool isPreprocessed; 
	private bool isRedefined; 
	private int errorCount; 
	private XmlSchemaObjectTable attributes; 
	private XmlSchemaObjectTable attributeGroups; 
	private XmlSchemaObjectTable elements; 
	private XmlSchemaObjectTable types; 
	private XmlSchemaObjectTable groups; 
	private XmlSchemaObjectTable notations; 
	private XmlSchemaObjectTable identityConstraints; 
	private static int globalIdCounter; 
	private ArrayList importedSchemas; 
	private ArrayList importedNamespaces; 
	private int schemaId; 
	private Uri baseUri; 
	private bool isChameleon; 
	private Hashtable ids; 
	private XmlDocument document; 

	[XmlAttributeAttribute] 
	[DefaultValueAttribute] 
public XmlSchemaForm AttributeFormDefault { get; set; }
	[XmlAttributeAttribute] 
	[DefaultValueAttribute] 
public XmlSchemaDerivationMethod BlockDefault { get; set; }
	[DefaultValueAttribute] 
	[XmlAttributeAttribute] 
public XmlSchemaDerivationMethod FinalDefault { get; set; }
	[DefaultValueAttribute] 
	[XmlAttributeAttribute] 
public XmlSchemaForm ElementFormDefault { get; set; }
	[XmlAttributeAttribute] 
public string TargetNamespace { get; set; }
	[XmlAttributeAttribute] 
public string Version { get; set; }
	[XmlElementAttribute] 
	[XmlElementAttribute] 
	[XmlElementAttribute] 
public XmlSchemaObjectCollection Includes { get; }
	[XmlElementAttribute] 
	[XmlElementAttribute] 
	[XmlElementAttribute] 
	[XmlElementAttribute] 
	[XmlElementAttribute] 
	[XmlElementAttribute] 
	[XmlElementAttribute] 
	[XmlElementAttribute] 
public XmlSchemaObjectCollection Items { get; }
	[XmlIgnoreAttribute] 
internal bool IsCompiledBySet { get; set; }
	[XmlIgnoreAttribute] 
internal bool IsPreprocessed { get; set; }
	[XmlIgnoreAttribute] 
internal bool IsRedefined { get; set; }
	[XmlIgnoreAttribute] 
public XmlSchemaObjectTable Attributes { get; }
	[XmlIgnoreAttribute] 
public XmlSchemaObjectTable AttributeGroups { get; }
	[XmlIgnoreAttribute] 
public XmlSchemaObjectTable SchemaTypes { get; }
	[XmlIgnoreAttribute] 
public XmlSchemaObjectTable Elements { get; }
	[XmlAttributeAttribute] 
public string Id { get; set; }
	[XmlIgnoreAttribute] 
public XmlSchemaObjectTable Groups { get; }
	[XmlIgnoreAttribute] 
public XmlSchemaObjectTable Notations { get; }
	[XmlIgnoreAttribute] 
internal XmlSchemaObjectTable IdentityConstraints { get; }
	[XmlIgnoreAttribute] 
internal Uri BaseUri { get; set; }
	[XmlIgnoreAttribute] 
internal int SchemaId { get; }
	[XmlIgnoreAttribute] 
internal bool IsChameleon { get; set; }
	[XmlIgnoreAttribute] 
internal Hashtable Ids { get; }
	[XmlIgnoreAttribute] 
internal XmlDocument Document { get; }
	[XmlIgnoreAttribute] 
internal int ErrorCount { get; set; }
	[XmlIgnoreAttribute] 
internal override string IdAttribute { get; set; }
internal ArrayList ImportedSchemas { get; }
internal ArrayList ImportedNamespaces { get; }


public void .ctor() { }

public static XmlSchema Read(XmlReader reader, ValidationEventHandler validationEventHandler) { }

internal bool CompileSchema(XmlSchemaCollection xsc, XmlResolver resolver, SchemaInfo schemaInfo, string ns, ValidationEventHandler validationEventHandler, XmlNameTable nameTable, bool CompileContentModel) { }

internal void CompileSchemaInSet(XmlNameTable nameTable, ValidationEventHandler eventHandler, XmlSchemaCompilationSettings compilationSettings) { }

public XmlSchemaForm get_AttributeFormDefault() { }

public void set_AttributeFormDefault(XmlSchemaForm value) { }

public XmlSchemaDerivationMethod get_BlockDefault() { }

public void set_BlockDefault(XmlSchemaDerivationMethod value) { }

public XmlSchemaDerivationMethod get_FinalDefault() { }

public void set_FinalDefault(XmlSchemaDerivationMethod value) { }

public XmlSchemaForm get_ElementFormDefault() { }

public void set_ElementFormDefault(XmlSchemaForm value) { }

public string get_TargetNamespace() { }

public void set_TargetNamespace(string value) { }

public string get_Version() { }

public void set_Version(string value) { }

public XmlSchemaObjectCollection get_Includes() { }

public XmlSchemaObjectCollection get_Items() { }

internal bool get_IsCompiledBySet() { }

internal void set_IsCompiledBySet(bool value) { }

internal bool get_IsPreprocessed() { }

internal void set_IsPreprocessed(bool value) { }

internal bool get_IsRedefined() { }

internal void set_IsRedefined(bool value) { }

public XmlSchemaObjectTable get_Attributes() { }

public XmlSchemaObjectTable get_AttributeGroups() { }

public XmlSchemaObjectTable get_SchemaTypes() { }

public XmlSchemaObjectTable get_Elements() { }

public string get_Id() { }

public void set_Id(string value) { }

public XmlSchemaObjectTable get_Groups() { }

public XmlSchemaObjectTable get_Notations() { }

internal XmlSchemaObjectTable get_IdentityConstraints() { }

internal Uri get_BaseUri() { }

internal void set_BaseUri(Uri value) { }

internal int get_SchemaId() { }

internal bool get_IsChameleon() { }

internal void set_IsChameleon(bool value) { }

internal Hashtable get_Ids() { }

internal XmlDocument get_Document() { }

internal int get_ErrorCount() { }

internal void set_ErrorCount(int value) { }

internal XmlSchema Clone() { }

internal XmlSchema DeepClone() { }

internal override string get_IdAttribute() { }

internal override void set_IdAttribute(string value) { }

internal void SetIsCompiled(bool isCompiled) { }

internal override void SetUnhandledAttributes(XmlAttribute[] moreAttributes) { }

internal override void AddAnnotation(XmlSchemaAnnotation annotation) { }

internal ArrayList get_ImportedSchemas() { }

internal ArrayList get_ImportedNamespaces() { }

internal void GetExternalSchemasList(IList extList, XmlSchema schema) { }

private static void .cctor() { }

}

public class XmlSchemaAll : XmlSchemaGroupBase // TypeDefIndex: 2307
{
	private XmlSchemaObjectCollection items; 

	[XmlElementAttribute] 
public override XmlSchemaObjectCollection Items { get; }
internal override bool IsEmpty { get; }


public override XmlSchemaObjectCollection get_Items() { }

internal override bool get_IsEmpty() { }

internal override void SetItems(XmlSchemaObjectCollection newItems) { }

public void .ctor() { }

}

public class XmlSchemaAnnotated : XmlSchemaObject // TypeDefIndex: 2308
{
	private string id; 
	private XmlSchemaAnnotation annotation; 
	private XmlAttribute[] moreAttributes; 

	[XmlAttributeAttribute] 
public string Id { get; set; }
	[XmlElementAttribute] 
public XmlSchemaAnnotation Annotation { get; set; }
	[XmlAnyAttributeAttribute] 
public XmlAttribute[] UnhandledAttributes { get; set; }
	[XmlIgnoreAttribute] 
internal override string IdAttribute { get; set; }


public string get_Id() { }

public void set_Id(string value) { }

public XmlSchemaAnnotation get_Annotation() { }

public void set_Annotation(XmlSchemaAnnotation value) { }

public XmlAttribute[] get_UnhandledAttributes() { }

public void set_UnhandledAttributes(XmlAttribute[] value) { }

internal override string get_IdAttribute() { }

internal override void set_IdAttribute(string value) { }

internal override void SetUnhandledAttributes(XmlAttribute[] moreAttributes) { }

internal override void AddAnnotation(XmlSchemaAnnotation annotation) { }

public void .ctor() { }

}

public class XmlSchemaAnnotation : XmlSchemaObject // TypeDefIndex: 2309
{
	private string id; 
	private XmlSchemaObjectCollection items; 
	private XmlAttribute[] moreAttributes; 

	[XmlAttributeAttribute] 
public string Id { get; set; }
	[XmlElementAttribute] 
	[XmlElementAttribute] 
public XmlSchemaObjectCollection Items { get; }
	[XmlIgnoreAttribute] 
internal override string IdAttribute { get; set; }


public string get_Id() { }

public void set_Id(string value) { }

public XmlSchemaObjectCollection get_Items() { }

internal override string get_IdAttribute() { }

internal override void set_IdAttribute(string value) { }

internal override void SetUnhandledAttributes(XmlAttribute[] moreAttributes) { }

public void .ctor() { }

}

public class XmlSchemaAny : XmlSchemaParticle // TypeDefIndex: 2310
{
	private string ns; 
	private XmlSchemaContentProcessing processContents; 
	private NamespaceList namespaceList; 

	[XmlAttributeAttribute] 
public string Namespace { get; set; }
	[DefaultValueAttribute] 
	[XmlAttributeAttribute] 
public XmlSchemaContentProcessing ProcessContents { set; }
	[XmlIgnoreAttribute] 
internal NamespaceList NamespaceList { get; }
	[XmlIgnoreAttribute] 
internal string ResolvedNamespace { get; }
	[XmlIgnoreAttribute] 
internal XmlSchemaContentProcessing ProcessContentsCorrect { get; }
internal override string NameString { get; }


public string get_Namespace() { }

public void set_Namespace(string value) { }

public void set_ProcessContents(XmlSchemaContentProcessing value) { }

internal NamespaceList get_NamespaceList() { }

internal string get_ResolvedNamespace() { }

internal XmlSchemaContentProcessing get_ProcessContentsCorrect() { }

internal override string get_NameString() { }

internal void BuildNamespaceList(string targetNamespace) { }

internal void BuildNamespaceListV1Compat(string targetNamespace) { }

internal bool Allows(XmlQualifiedName qname) { }

public void .ctor() { }

}

public class XmlSchemaAnyAttribute : XmlSchemaAnnotated // TypeDefIndex: 2311
{
	private string ns; 
	private XmlSchemaContentProcessing processContents; 
	private NamespaceList namespaceList; 

	[XmlAttributeAttribute] 
public string Namespace { set; }
	[XmlAttributeAttribute] 
	[DefaultValueAttribute] 
public XmlSchemaContentProcessing ProcessContents { get; set; }
	[XmlIgnoreAttribute] 
internal NamespaceList NamespaceList { get; }
	[XmlIgnoreAttribute] 
internal XmlSchemaContentProcessing ProcessContentsCorrect { get; }


public void set_Namespace(string value) { }

public XmlSchemaContentProcessing get_ProcessContents() { }

public void set_ProcessContents(XmlSchemaContentProcessing value) { }

internal NamespaceList get_NamespaceList() { }

internal XmlSchemaContentProcessing get_ProcessContentsCorrect() { }

internal void BuildNamespaceList(string targetNamespace) { }

internal void BuildNamespaceListV1Compat(string targetNamespace) { }

internal bool Allows(XmlQualifiedName qname) { }

internal static bool IsSubset(XmlSchemaAnyAttribute sub, XmlSchemaAnyAttribute super) { }

internal static XmlSchemaAnyAttribute Intersection(XmlSchemaAnyAttribute o1, XmlSchemaAnyAttribute o2, bool v1Compat) { }

internal static XmlSchemaAnyAttribute Union(XmlSchemaAnyAttribute o1, XmlSchemaAnyAttribute o2, bool v1Compat) { }

public void .ctor() { }

}

public class XmlSchemaAppInfo : XmlSchemaObject // TypeDefIndex: 2312
{
	private string source; 
	private XmlNode[] markup; 

	[XmlAttributeAttribute] 
public string Source { set; }
	[XmlTextAttribute] 
	[XmlAnyElementAttribute] 
public XmlNode[] Markup { get; set; }


public void set_Source(string value) { }

public XmlNode[] get_Markup() { }

public void set_Markup(XmlNode[] value) { }

public void .ctor() { }

}

public class XmlSchemaAttribute : XmlSchemaAnnotated // TypeDefIndex: 2313
{
	private string defaultValue; 
	private string fixedValue; 
	private string name; 
	private XmlSchemaForm form; 
	private XmlSchemaUse use; 
	private XmlQualifiedName refName; 
	private XmlQualifiedName typeName; 
	private XmlQualifiedName qualifiedName; 
	private XmlSchemaSimpleType type; 
	private XmlSchemaSimpleType attributeType; 
	private SchemaAttDef attDef; 

	[XmlAttributeAttribute] 
	[DefaultValueAttribute] 
public string DefaultValue { get; set; }
	[DefaultValueAttribute] 
	[XmlAttributeAttribute] 
public string FixedValue { get; set; }
	[DefaultValueAttribute] 
	[XmlAttributeAttribute] 
public XmlSchemaForm Form { get; set; }
	[XmlAttributeAttribute] 
public string Name { get; set; }
	[XmlAttributeAttribute] 
public XmlQualifiedName RefName { get; set; }
	[XmlAttributeAttribute] 
public XmlQualifiedName SchemaTypeName { get; set; }
	[XmlElementAttribute] 
public XmlSchemaSimpleType SchemaType { get; set; }
	[XmlAttributeAttribute] 
	[DefaultValueAttribute] 
public XmlSchemaUse Use { get; set; }
	[XmlIgnoreAttribute] 
public XmlQualifiedName QualifiedName { get; }
	[XmlIgnoreAttribute] 
public XmlSchemaSimpleType AttributeSchemaType { get; }
	[XmlIgnoreAttribute] 
internal XmlSchemaDatatype Datatype { get; }
internal SchemaAttDef AttDef { get; set; }
	[XmlIgnoreAttribute] 
internal override string NameAttribute { get; set; }


public string get_DefaultValue() { }

public void set_DefaultValue(string value) { }

public string get_FixedValue() { }

public void set_FixedValue(string value) { }

public XmlSchemaForm get_Form() { }

public void set_Form(XmlSchemaForm value) { }

public string get_Name() { }

public void set_Name(string value) { }

public XmlQualifiedName get_RefName() { }

public void set_RefName(XmlQualifiedName value) { }

public XmlQualifiedName get_SchemaTypeName() { }

public void set_SchemaTypeName(XmlQualifiedName value) { }

public XmlSchemaSimpleType get_SchemaType() { }

public void set_SchemaType(XmlSchemaSimpleType value) { }

public XmlSchemaUse get_Use() { }

public void set_Use(XmlSchemaUse value) { }

public XmlQualifiedName get_QualifiedName() { }

public XmlSchemaSimpleType get_AttributeSchemaType() { }

internal XmlSchemaDatatype get_Datatype() { }

internal void SetQualifiedName(XmlQualifiedName value) { }

internal void SetAttributeType(XmlSchemaSimpleType value) { }

internal SchemaAttDef get_AttDef() { }

internal void set_AttDef(SchemaAttDef value) { }

internal override string get_NameAttribute() { }

internal override void set_NameAttribute(string value) { }

internal override XmlSchemaObject Clone() { }

public void .ctor() { }

}

public class XmlSchemaAttributeGroup : XmlSchemaAnnotated // TypeDefIndex: 2314
{
	private string name; 
	private XmlSchemaObjectCollection attributes; 
	private XmlSchemaAnyAttribute anyAttribute; 
	private XmlQualifiedName qname; 
	private XmlSchemaAttributeGroup redefined; 
	private XmlSchemaObjectTable attributeUses; 
	private XmlSchemaAnyAttribute attributeWildcard; 
	private int selfReferenceCount; 

	[XmlAttributeAttribute] 
public string Name { get; set; }
	[XmlElementAttribute] 
	[XmlElementAttribute] 
public XmlSchemaObjectCollection Attributes { get; }
	[XmlElementAttribute] 
public XmlSchemaAnyAttribute AnyAttribute { get; set; }
	[XmlIgnoreAttribute] 
public XmlQualifiedName QualifiedName { get; }
	[XmlIgnoreAttribute] 
internal XmlSchemaObjectTable AttributeUses { get; }
	[XmlIgnoreAttribute] 
internal XmlSchemaAnyAttribute AttributeWildcard { get; set; }
	[XmlIgnoreAttribute] 
public XmlSchemaAttributeGroup RedefinedAttributeGroup { get; }
	[XmlIgnoreAttribute] 
internal XmlSchemaAttributeGroup Redefined { get; set; }
	[XmlIgnoreAttribute] 
internal int SelfReferenceCount { get; set; }
	[XmlIgnoreAttribute] 
internal override string NameAttribute { get; set; }


public string get_Name() { }

public void set_Name(string value) { }

public XmlSchemaObjectCollection get_Attributes() { }

public XmlSchemaAnyAttribute get_AnyAttribute() { }

public void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

public XmlQualifiedName get_QualifiedName() { }

internal XmlSchemaObjectTable get_AttributeUses() { }

internal XmlSchemaAnyAttribute get_AttributeWildcard() { }

internal void set_AttributeWildcard(XmlSchemaAnyAttribute value) { }

public XmlSchemaAttributeGroup get_RedefinedAttributeGroup() { }

internal XmlSchemaAttributeGroup get_Redefined() { }

internal void set_Redefined(XmlSchemaAttributeGroup value) { }

internal int get_SelfReferenceCount() { }

internal void set_SelfReferenceCount(int value) { }

internal override string get_NameAttribute() { }

internal override void set_NameAttribute(string value) { }

internal void SetQualifiedName(XmlQualifiedName value) { }

internal override XmlSchemaObject Clone() { }

public void .ctor() { }

}

public class XmlSchemaAttributeGroupRef : XmlSchemaAnnotated // TypeDefIndex: 2315
{
	private XmlQualifiedName refName; 

	[XmlAttributeAttribute] 
public XmlQualifiedName RefName { get; set; }


public XmlQualifiedName get_RefName() { }

public void set_RefName(XmlQualifiedName value) { }

public void .ctor() { }

}

public class XmlSchemaChoice : XmlSchemaGroupBase // TypeDefIndex: 2316
{
	private XmlSchemaObjectCollection items; 

	[XmlElementAttribute] 
	[XmlElementAttribute] 
	[XmlElementAttribute] 
	[XmlElementAttribute] 
	[XmlElementAttribute] 
public override XmlSchemaObjectCollection Items { get; }
internal override bool IsEmpty { get; }


public override XmlSchemaObjectCollection get_Items() { }

internal override bool get_IsEmpty() { }

internal override void SetItems(XmlSchemaObjectCollection newItems) { }

public void .ctor() { }

}

public sealed class XmlSchemaCollection : ICollection, IEnumerable // TypeDefIndex: 2317
{
	private Hashtable collection; 
	private XmlNameTable nameTable; 
	private SchemaNames schemaNames; 
	private ReaderWriterLock wLock; 
	private int timeout; 
	private bool isThreadSafe; 
	private ValidationEventHandler validationEventHandler; 
	private XmlResolver xmlResolver; 

public int Count { get; }
public XmlNameTable NameTable { get; }
internal XmlResolver XmlResolver { set; }
public XmlSchema Item { get; }
private object System.Collections.ICollection.SyncRoot { get; }
private int System.Collections.ICollection.Count { get; }
internal ValidationEventHandler EventHandler { get; set; }


public void .ctor(XmlNameTable nametable) { }

public int get_Count() { }

public XmlNameTable get_NameTable() { }

internal void set_XmlResolver(XmlResolver value) { }

public XmlSchema get_Item(string ns) { }

private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

public XmlSchemaCollectionEnumerator GetEnumerator() { }

private void System.Collections.ICollection.CopyTo(Array array, int index) { }

private object System.Collections.ICollection.get_SyncRoot() { }

private int System.Collections.ICollection.get_Count() { }

internal SchemaInfo GetSchemaInfo(string ns) { }

internal SchemaNames GetSchemaNames(XmlNameTable nt) { }

internal XmlSchema Add(string ns, SchemaInfo schemaInfo, XmlSchema schema, bool compile) { }

private XmlSchema Add(string ns, SchemaInfo schemaInfo, XmlSchema schema, bool compile, XmlResolver resolver) { }

private void Add(string ns, XmlSchemaCollectionNode node) { }

internal ValidationEventHandler get_EventHandler() { }

internal void set_EventHandler(ValidationEventHandler value) { }

}

internal sealed class XmlSchemaCollectionNode // TypeDefIndex: 2318
{
	private string namespaceUri; 
	private SchemaInfo schemaInfo; 
	private XmlSchema schema; 

internal string NamespaceURI { set; }
internal SchemaInfo SchemaInfo { get; set; }
internal XmlSchema Schema { get; set; }


internal void set_NamespaceURI(string value) { }

internal SchemaInfo get_SchemaInfo() { }

internal void set_SchemaInfo(SchemaInfo value) { }

internal XmlSchema get_Schema() { }

internal void set_Schema(XmlSchema value) { }

public void .ctor() { }

}

public sealed class XmlSchemaCollectionEnumerator : IEnumerator // TypeDefIndex: 2319
{
	private IDictionaryEnumerator enumerator; 

private object System.Collections.IEnumerator.Current { get; }
public XmlSchema Current { get; }
internal XmlSchemaCollectionNode CurrentNode { get; }


internal void .ctor(Hashtable collection) { }

private void System.Collections.IEnumerator.Reset() { }

private bool System.Collections.IEnumerator.MoveNext() { }

public bool MoveNext() { }

private object System.Collections.IEnumerator.get_Current() { }

public XmlSchema get_Current() { }

internal XmlSchemaCollectionNode get_CurrentNode() { }

}

public sealed class XmlSchemaCompilationSettings // TypeDefIndex: 2320
{
	private bool enableUpaCheck; 

public bool EnableUpaCheck { get; }


public void .ctor() { }

public bool get_EnableUpaCheck() { }

}

public class XmlSchemaComplexContent : XmlSchemaContentModel // TypeDefIndex: 2321
{
	private XmlSchemaContent content; 
	private bool isMixed; 
	private bool hasMixedAttribute; 

	[XmlAttributeAttribute] 
public bool IsMixed { get; set; }
	[XmlElementAttribute] 
	[XmlElementAttribute] 
public override XmlSchemaContent Content { get; set; }
	[XmlIgnoreAttribute] 
internal bool HasMixedAttribute { get; }


public bool get_IsMixed() { }

public void set_IsMixed(bool value) { }

public override XmlSchemaContent get_Content() { }

public override void set_Content(XmlSchemaContent value) { }

internal bool get_HasMixedAttribute() { }

public void .ctor() { }

}

public class XmlSchemaComplexContentExtension : XmlSchemaContent // TypeDefIndex: 2322
{
	private XmlSchemaParticle particle; 
	private XmlSchemaObjectCollection attributes; 
	private XmlSchemaAnyAttribute anyAttribute; 
	private XmlQualifiedName baseTypeName; 

	[XmlAttributeAttribute] 
public XmlQualifiedName BaseTypeName { get; set; }
	[XmlElementAttribute] 
	[XmlElementAttribute] 
	[XmlElementAttribute] 
	[XmlElementAttribute] 
public XmlSchemaParticle Particle { get; set; }
	[XmlElementAttribute] 
	[XmlElementAttribute] 
public XmlSchemaObjectCollection Attributes { get; }
	[XmlElementAttribute] 
public XmlSchemaAnyAttribute AnyAttribute { get; set; }


public XmlQualifiedName get_BaseTypeName() { }

public void set_BaseTypeName(XmlQualifiedName value) { }

public XmlSchemaParticle get_Particle() { }

public void set_Particle(XmlSchemaParticle value) { }

public XmlSchemaObjectCollection get_Attributes() { }

public XmlSchemaAnyAttribute get_AnyAttribute() { }

public void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

internal void SetAttributes(XmlSchemaObjectCollection newAttributes) { }

public void .ctor() { }

}

public class XmlSchemaComplexContentRestriction : XmlSchemaContent // TypeDefIndex: 2323
{
	private XmlSchemaParticle particle; 
	private XmlSchemaObjectCollection attributes; 
	private XmlSchemaAnyAttribute anyAttribute; 
	private XmlQualifiedName baseTypeName; 

	[XmlAttributeAttribute] 
public XmlQualifiedName BaseTypeName { get; set; }
	[XmlElementAttribute] 
	[XmlElementAttribute] 
	[XmlElementAttribute] 
	[XmlElementAttribute] 
public XmlSchemaParticle Particle { get; set; }
	[XmlElementAttribute] 
	[XmlElementAttribute] 
public XmlSchemaObjectCollection Attributes { get; }
	[XmlElementAttribute] 
public XmlSchemaAnyAttribute AnyAttribute { get; set; }


public XmlQualifiedName get_BaseTypeName() { }

public void set_BaseTypeName(XmlQualifiedName value) { }

public XmlSchemaParticle get_Particle() { }

public void set_Particle(XmlSchemaParticle value) { }

public XmlSchemaObjectCollection get_Attributes() { }

public XmlSchemaAnyAttribute get_AnyAttribute() { }

public void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

internal void SetAttributes(XmlSchemaObjectCollection newAttributes) { }

public void .ctor() { }

}

public class XmlSchemaComplexType : XmlSchemaType // TypeDefIndex: 2324
{
	private XmlSchemaDerivationMethod block; 
	private XmlSchemaContentModel contentModel; 
	private XmlSchemaParticle particle; 
	private XmlSchemaObjectCollection attributes; 
	private XmlSchemaAnyAttribute anyAttribute; 
	private XmlSchemaParticle contentTypeParticle; 
	private XmlSchemaDerivationMethod blockResolved; 
	private XmlSchemaObjectTable localElements; 
	private XmlSchemaObjectTable attributeUses; 
	private XmlSchemaAnyAttribute attributeWildcard; 
	private static XmlSchemaComplexType anyTypeLax; 
	private static XmlSchemaComplexType anyTypeSkip; 
	private static XmlSchemaComplexType untypedAnyType; 
	private byte pvFlags; 

	[XmlIgnoreAttribute] 
internal static XmlSchemaComplexType AnyType { get; }
	[XmlIgnoreAttribute] 
internal static XmlSchemaComplexType UntypedAnyType { get; }
internal static ContentValidator AnyTypeContentValidator { get; }
	[XmlAttributeAttribute] 
	[DefaultValueAttribute] 
public bool IsAbstract { get; set; }
	[XmlAttributeAttribute] 
	[DefaultValueAttribute] 
public XmlSchemaDerivationMethod Block { get; set; }
	[XmlAttributeAttribute] 
	[DefaultValueAttribute] 
public override bool IsMixed { get; set; }
	[XmlElementAttribute] 
	[XmlElementAttribute] 
public XmlSchemaContentModel ContentModel { get; set; }
	[XmlElementAttribute] 
	[XmlElementAttribute] 
	[XmlElementAttribute] 
	[XmlElementAttribute] 
public XmlSchemaParticle Particle { get; set; }
	[XmlElementAttribute] 
	[XmlElementAttribute] 
public XmlSchemaObjectCollection Attributes { get; }
	[XmlElementAttribute] 
public XmlSchemaAnyAttribute AnyAttribute { get; set; }
	[XmlIgnoreAttribute] 
public XmlSchemaContentType ContentType { get; }
	[XmlIgnoreAttribute] 
public XmlSchemaParticle ContentTypeParticle { get; }
	[XmlIgnoreAttribute] 
public XmlSchemaDerivationMethod BlockResolved { get; }
	[XmlIgnoreAttribute] 
public XmlSchemaObjectTable AttributeUses { get; }
	[XmlIgnoreAttribute] 
public XmlSchemaAnyAttribute AttributeWildcard { get; }
	[XmlIgnoreAttribute] 
internal XmlSchemaObjectTable LocalElements { get; }
internal bool HasWildCard { set; }


private static void .cctor() { }

private static XmlSchemaComplexType CreateAnyType(XmlSchemaContentProcessing processContents) { }

public void .ctor() { }

internal static XmlSchemaComplexType get_AnyType() { }

internal static XmlSchemaComplexType get_UntypedAnyType() { }

internal static ContentValidator get_AnyTypeContentValidator() { }

public bool get_IsAbstract() { }

public void set_IsAbstract(bool value) { }

public XmlSchemaDerivationMethod get_Block() { }

public void set_Block(XmlSchemaDerivationMethod value) { }

public override bool get_IsMixed() { }

public override void set_IsMixed(bool value) { }

public XmlSchemaContentModel get_ContentModel() { }

public void set_ContentModel(XmlSchemaContentModel value) { }

public XmlSchemaParticle get_Particle() { }

public void set_Particle(XmlSchemaParticle value) { }

public XmlSchemaObjectCollection get_Attributes() { }

public XmlSchemaAnyAttribute get_AnyAttribute() { }

public void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

public XmlSchemaContentType get_ContentType() { }

public XmlSchemaParticle get_ContentTypeParticle() { }

public XmlSchemaDerivationMethod get_BlockResolved() { }

public XmlSchemaObjectTable get_AttributeUses() { }

public XmlSchemaAnyAttribute get_AttributeWildcard() { }

internal XmlSchemaObjectTable get_LocalElements() { }

internal void SetContentTypeParticle(XmlSchemaParticle value) { }

internal void SetBlockResolved(XmlSchemaDerivationMethod value) { }

internal void SetAttributeWildcard(XmlSchemaAnyAttribute value) { }

internal void set_HasWildCard(bool value) { }

internal void SetAttributes(XmlSchemaObjectCollection newAttributes) { }

internal bool ContainsIdAttribute(bool findAll) { }

internal override XmlSchemaObject Clone() { }

internal XmlSchemaObject Clone(XmlSchema parentSchema) { }

private void ClearCompiledState() { }

internal static XmlSchemaObjectCollection CloneAttributes(XmlSchemaObjectCollection attributes) { }

private static XmlSchemaObjectCollection CloneGroupBaseParticles(XmlSchemaObjectCollection groupBaseParticles, XmlSchema parentSchema) { }

internal static XmlSchemaParticle CloneParticle(XmlSchemaParticle particle, XmlSchema parentSchema) { }

private static XmlSchemaForm GetResolvedElementForm(XmlSchema parentSchema, XmlSchemaElement element) { }

internal static bool HasParticleRef(XmlSchemaParticle particle, XmlSchema parentSchema) { }

internal static bool HasAttributeQNameRef(XmlSchemaObjectCollection attributes) { }

}

public abstract class XmlSchemaContent : XmlSchemaAnnotated // TypeDefIndex: 2325
{

protected void .ctor() { }

}

public abstract class XmlSchemaContentModel : XmlSchemaAnnotated // TypeDefIndex: 2326
{
	[XmlIgnoreAttribute] 
public abstract XmlSchemaContent Content { get; set; }


public abstract XmlSchemaContent get_Content();

public abstract void set_Content(XmlSchemaContent value);

protected void .ctor() { }

}

public enum XmlSchemaContentProcessing // TypeDefIndex: 2327
{
	public int value__; 
	[XmlIgnoreAttribute] 
public const XmlSchemaContentProcessing None = 0;
	[XmlEnumAttribute] 
public const XmlSchemaContentProcessing Skip = 1;
	[XmlEnumAttribute] 
public const XmlSchemaContentProcessing Lax = 2;
	[XmlEnumAttribute] 
public const XmlSchemaContentProcessing Strict = 3;

}

public enum XmlSchemaContentType // TypeDefIndex: 2328
{
	public int value__; 
public const XmlSchemaContentType TextOnly = 0;
public const XmlSchemaContentType Empty = 1;
public const XmlSchemaContentType ElementOnly = 2;
public const XmlSchemaContentType Mixed = 3;

}

public abstract class XmlSchemaDatatype // TypeDefIndex: 2329
{
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


public abstract Type get_ValueType();

public abstract XmlTokenizedType get_TokenizedType();

public abstract object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr);

public virtual XmlSchemaDatatypeVariety get_Variety() { }

public virtual XmlTypeCode get_TypeCode() { }

public virtual bool IsDerivedFrom(XmlSchemaDatatype datatype) { }

internal abstract bool get_HasLexicalFacets();

internal abstract bool get_HasValueFacets();

internal abstract XmlValueConverter get_ValueConverter();

internal abstract RestrictionFacets get_Restriction();

internal abstract int Compare(object value1, object value2);

internal abstract object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, bool createAtomicValue);

internal abstract Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue);

internal abstract Exception TryParseValue(object value, XmlNameTable nameTable, IXmlNamespaceResolver namespaceResolver, out object typedValue);

internal abstract FacetsChecker get_FacetsChecker();

internal abstract XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet();

internal abstract XmlSchemaDatatype DeriveByRestriction(XmlSchemaObjectCollection facets, XmlNameTable nameTable, XmlSchemaType schemaType);

internal abstract XmlSchemaDatatype DeriveByList(XmlSchemaType schemaType);

internal abstract void VerifySchemaValid(XmlSchemaObjectTable notations, XmlSchemaObject caller);

internal abstract bool IsEqual(object o1, object o2);

internal abstract bool IsComparable(XmlSchemaDatatype dtype);

internal string get_TypeCodeString() { }

internal string TypeCodeToString(XmlTypeCode typeCode) { }

internal static string ConcatenatedToString(object value) { }

internal static XmlSchemaDatatype FromXmlTokenizedType(XmlTokenizedType token) { }

internal static XmlSchemaDatatype FromXmlTokenizedTypeXsd(XmlTokenizedType token) { }

internal static XmlSchemaDatatype FromXdrName(string name) { }

internal static XmlSchemaDatatype DeriveByUnion(XmlSchemaSimpleType[] types, XmlSchemaType schemaType) { }

internal static string XdrCanonizeUri(string uri, XmlNameTable nameTable, SchemaNames schemaNames) { }

protected void .ctor() { }

}

public enum XmlSchemaDerivationMethod // TypeDefIndex: 2330
{
	public int value__; 
	[XmlEnumAttribute] 
public const XmlSchemaDerivationMethod Empty = 0;
	[XmlEnumAttribute] 
public const XmlSchemaDerivationMethod Substitution = 1;
	[XmlEnumAttribute] 
public const XmlSchemaDerivationMethod Extension = 2;
	[XmlEnumAttribute] 
public const XmlSchemaDerivationMethod Restriction = 4;
	[XmlEnumAttribute] 
public const XmlSchemaDerivationMethod List = 8;
	[XmlEnumAttribute] 
public const XmlSchemaDerivationMethod Union = 16;
	[XmlEnumAttribute] 
public const XmlSchemaDerivationMethod All = 255;
	[XmlIgnoreAttribute] 
public const XmlSchemaDerivationMethod None = 256;

}

public class XmlSchemaDocumentation : XmlSchemaObject // TypeDefIndex: 2331
{
	private string source; 
	private string language; 
	private XmlNode[] markup; 
	private static XmlSchemaSimpleType languageType; 

	[XmlAttributeAttribute] 
public string Source { set; }
	[XmlAttributeAttribute] 
public string Language { set; }
	[XmlAnyElementAttribute] 
	[XmlTextAttribute] 
public XmlNode[] Markup { set; }


public void set_Source(string value) { }

public void set_Language(string value) { }

public void set_Markup(XmlNode[] value) { }

public void .ctor() { }

private static void .cctor() { }

}

public class XmlSchemaElement : XmlSchemaParticle // TypeDefIndex: 2332
{
	private bool isAbstract; 
	private bool hasAbstractAttribute; 
	private bool isNillable; 
	private bool hasNillableAttribute; 
	private bool isLocalTypeDerivationChecked; 
	private XmlSchemaDerivationMethod block; 
	private XmlSchemaDerivationMethod final; 
	private XmlSchemaForm form; 
	private string defaultValue; 
	private string fixedValue; 
	private string name; 
	private XmlQualifiedName refName; 
	private XmlQualifiedName substitutionGroup; 
	private XmlQualifiedName typeName; 
	private XmlSchemaType type; 
	private XmlQualifiedName qualifiedName; 
	private XmlSchemaType elementType; 
	private XmlSchemaDerivationMethod blockResolved; 
	private XmlSchemaDerivationMethod finalResolved; 
	private XmlSchemaObjectCollection constraints; 
	private SchemaElementDecl elementDecl; 

	[XmlAttributeAttribute] 
	[DefaultValueAttribute] 
public bool IsAbstract { get; set; }
	[DefaultValueAttribute] 
	[XmlAttributeAttribute] 
public XmlSchemaDerivationMethod Block { get; set; }
	[XmlAttributeAttribute] 
	[DefaultValueAttribute] 
public string DefaultValue { get; set; }
	[DefaultValueAttribute] 
	[XmlAttributeAttribute] 
public XmlSchemaDerivationMethod Final { get; set; }
	[DefaultValueAttribute] 
	[XmlAttributeAttribute] 
public string FixedValue { get; set; }
	[DefaultValueAttribute] 
	[XmlAttributeAttribute] 
public XmlSchemaForm Form { get; set; }
	[DefaultValueAttribute] 
	[XmlAttributeAttribute] 
public string Name { get; set; }
	[XmlAttributeAttribute] 
	[DefaultValueAttribute] 
public bool IsNillable { get; set; }
	[XmlIgnoreAttribute] 
internal bool HasNillableAttribute { get; }
	[XmlIgnoreAttribute] 
internal bool HasAbstractAttribute { get; }
	[XmlAttributeAttribute] 
public XmlQualifiedName RefName { get; set; }
	[XmlAttributeAttribute] 
public XmlQualifiedName SubstitutionGroup { get; set; }
	[XmlAttributeAttribute] 
public XmlQualifiedName SchemaTypeName { get; set; }
	[XmlElementAttribute] 
	[XmlElementAttribute] 
public XmlSchemaType SchemaType { get; set; }
	[XmlElementAttribute] 
	[XmlElementAttribute] 
	[XmlElementAttribute] 
public XmlSchemaObjectCollection Constraints { get; }
	[XmlIgnoreAttribute] 
public XmlQualifiedName QualifiedName { get; }
	[XmlIgnoreAttribute] 
public XmlSchemaType ElementSchemaType { get; }
	[XmlIgnoreAttribute] 
public XmlSchemaDerivationMethod BlockResolved { get; }
	[XmlIgnoreAttribute] 
public XmlSchemaDerivationMethod FinalResolved { get; }
internal bool HasConstraints { get; }
internal bool IsLocalTypeDerivationChecked { get; set; }
internal SchemaElementDecl ElementDecl { get; set; }
	[XmlIgnoreAttribute] 
internal override string NameAttribute { get; set; }
	[XmlIgnoreAttribute] 
internal override string NameString { get; }


public bool get_IsAbstract() { }

public void set_IsAbstract(bool value) { }

public XmlSchemaDerivationMethod get_Block() { }

public void set_Block(XmlSchemaDerivationMethod value) { }

public string get_DefaultValue() { }

public void set_DefaultValue(string value) { }

public XmlSchemaDerivationMethod get_Final() { }

public void set_Final(XmlSchemaDerivationMethod value) { }

public string get_FixedValue() { }

public void set_FixedValue(string value) { }

public XmlSchemaForm get_Form() { }

public void set_Form(XmlSchemaForm value) { }

public string get_Name() { }

public void set_Name(string value) { }

public bool get_IsNillable() { }

public void set_IsNillable(bool value) { }

internal bool get_HasNillableAttribute() { }

internal bool get_HasAbstractAttribute() { }

public XmlQualifiedName get_RefName() { }

public void set_RefName(XmlQualifiedName value) { }

public XmlQualifiedName get_SubstitutionGroup() { }

public void set_SubstitutionGroup(XmlQualifiedName value) { }

public XmlQualifiedName get_SchemaTypeName() { }

public void set_SchemaTypeName(XmlQualifiedName value) { }

public XmlSchemaType get_SchemaType() { }

public void set_SchemaType(XmlSchemaType value) { }

public XmlSchemaObjectCollection get_Constraints() { }

public XmlQualifiedName get_QualifiedName() { }

public XmlSchemaType get_ElementSchemaType() { }

public XmlSchemaDerivationMethod get_BlockResolved() { }

public XmlSchemaDerivationMethod get_FinalResolved() { }

internal void SetQualifiedName(XmlQualifiedName value) { }

internal void SetElementType(XmlSchemaType value) { }

internal void SetBlockResolved(XmlSchemaDerivationMethod value) { }

internal void SetFinalResolved(XmlSchemaDerivationMethod value) { }

internal bool get_HasConstraints() { }

internal bool get_IsLocalTypeDerivationChecked() { }

internal void set_IsLocalTypeDerivationChecked(bool value) { }

internal SchemaElementDecl get_ElementDecl() { }

internal void set_ElementDecl(SchemaElementDecl value) { }

internal override string get_NameAttribute() { }

internal override void set_NameAttribute(string value) { }

internal override string get_NameString() { }

internal override XmlSchemaObject Clone() { }

internal XmlSchemaObject Clone(XmlSchema parentSchema) { }

public void .ctor() { }

}

public class XmlSchemaException : SystemException // TypeDefIndex: 2333
{
	private string res; 
	private string[] args; 
	private string sourceUri; 
	private int lineNumber; 
	private int linePosition; 
	private XmlSchemaObject sourceSchemaObject; 
	private string message; 

internal string GetRes { get; }
internal string[] Args { get; }
public string SourceUri { get; }
public int LineNumber { get; }
public int LinePosition { get; }
public XmlSchemaObject SourceSchemaObject { get; }
public override string Message { get; }


protected void .ctor(SerializationInfo info, StreamingContext context) { }

public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

public void .ctor() { }

public void .ctor(string message) { }

public void .ctor(string message, Exception innerException) { }

public void .ctor(string message, Exception innerException, int lineNumber, int linePosition) { }

internal void .ctor(string res, string[] args) { }

internal void .ctor(string res, string arg) { }

internal void .ctor(string res, string arg, string sourceUri, int lineNumber, int linePosition) { }

internal void .ctor(string res, string sourceUri, int lineNumber, int linePosition) { }

internal void .ctor(string res, string[] args, string sourceUri, int lineNumber, int linePosition) { }

internal void .ctor(string res, XmlSchemaObject source) { }

internal void .ctor(string res, string arg, XmlSchemaObject source) { }

internal void .ctor(string res, string[] args, XmlSchemaObject source) { }

internal void .ctor(string res, string[] args, Exception innerException, string sourceUri, int lineNumber, int linePosition, XmlSchemaObject source) { }

internal static string CreateMessage(string res, string[] args) { }

internal string get_GetRes() { }

internal string[] get_Args() { }

public string get_SourceUri() { }

public int get_LineNumber() { }

public int get_LinePosition() { }

public XmlSchemaObject get_SourceSchemaObject() { }

internal void SetSource(string sourceUri, int lineNumber, int linePosition) { }

internal void SetSchemaObject(XmlSchemaObject source) { }

internal void SetSource(XmlSchemaObject source) { }

public override string get_Message() { }

}

public abstract class XmlSchemaExternal : XmlSchemaObject // TypeDefIndex: 2334
{
	private string location; 
	private Uri baseUri; 
	private XmlSchema schema; 
	private string id; 
	private XmlAttribute[] moreAttributes; 
	private Compositor compositor; 

	[XmlAttributeAttribute] 
public string SchemaLocation { get; set; }
	[XmlIgnoreAttribute] 
public XmlSchema Schema { get; set; }
	[XmlAttributeAttribute] 
public string Id { get; set; }
	[XmlIgnoreAttribute] 
internal Uri BaseUri { get; set; }
	[XmlIgnoreAttribute] 
internal override string IdAttribute { get; set; }
internal Compositor Compositor { get; set; }


public string get_SchemaLocation() { }

public void set_SchemaLocation(string value) { }

public XmlSchema get_Schema() { }

public void set_Schema(XmlSchema value) { }

public string get_Id() { }

public void set_Id(string value) { }

internal Uri get_BaseUri() { }

internal void set_BaseUri(Uri value) { }

internal override string get_IdAttribute() { }

internal override void set_IdAttribute(string value) { }

internal override void SetUnhandledAttributes(XmlAttribute[] moreAttributes) { }

internal Compositor get_Compositor() { }

internal void set_Compositor(Compositor value) { }

protected void .ctor() { }

}

public abstract class XmlSchemaFacet : XmlSchemaAnnotated // TypeDefIndex: 2336
{
	private string value; 
	private bool isFixed; 
	private FacetType facetType; 

	[XmlAttributeAttribute] 
public string Value { get; set; }
	[DefaultValueAttribute] 
	[XmlAttributeAttribute] 
public virtual bool IsFixed { get; set; }
internal FacetType FacetType { get; set; }


public string get_Value() { }

public void set_Value(string value) { }

public virtual bool get_IsFixed() { }

public virtual void set_IsFixed(bool value) { }

internal FacetType get_FacetType() { }

internal void set_FacetType(FacetType value) { }

protected void .ctor() { }

}

public abstract class XmlSchemaNumericFacet : XmlSchemaFacet // TypeDefIndex: 2337
{

protected void .ctor() { }

}

public class XmlSchemaLengthFacet : XmlSchemaNumericFacet // TypeDefIndex: 2338
{

public void .ctor() { }

}

public class XmlSchemaMinLengthFacet : XmlSchemaNumericFacet // TypeDefIndex: 2339
{

public void .ctor() { }

}

public class XmlSchemaMaxLengthFacet : XmlSchemaNumericFacet // TypeDefIndex: 2340
{

public void .ctor() { }

}

public class XmlSchemaPatternFacet : XmlSchemaFacet // TypeDefIndex: 2341
{

public void .ctor() { }

}

public class XmlSchemaEnumerationFacet : XmlSchemaFacet // TypeDefIndex: 2342
{

public void .ctor() { }

}

public class XmlSchemaMinExclusiveFacet : XmlSchemaFacet // TypeDefIndex: 2343
{

public void .ctor() { }

}

public class XmlSchemaMinInclusiveFacet : XmlSchemaFacet // TypeDefIndex: 2344
{

public void .ctor() { }

}

public class XmlSchemaMaxExclusiveFacet : XmlSchemaFacet // TypeDefIndex: 2345
{

public void .ctor() { }

}

public class XmlSchemaMaxInclusiveFacet : XmlSchemaFacet // TypeDefIndex: 2346
{

public void .ctor() { }

}

public class XmlSchemaTotalDigitsFacet : XmlSchemaNumericFacet // TypeDefIndex: 2347
{

public void .ctor() { }

}

public class XmlSchemaFractionDigitsFacet : XmlSchemaNumericFacet // TypeDefIndex: 2348
{

public void .ctor() { }

}

public class XmlSchemaWhiteSpaceFacet : XmlSchemaFacet // TypeDefIndex: 2349
{

public void .ctor() { }

}

public enum XmlSchemaForm // TypeDefIndex: 2350
{
	public int value__; 
	[XmlIgnoreAttribute] 
public const XmlSchemaForm None = 0;
	[XmlEnumAttribute] 
public const XmlSchemaForm Qualified = 1;
	[XmlEnumAttribute] 
public const XmlSchemaForm Unqualified = 2;

}

public class XmlSchemaGroup : XmlSchemaAnnotated // TypeDefIndex: 2351
{
	private string name; 
	private XmlSchemaGroupBase particle; 
	private XmlSchemaParticle canonicalParticle; 
	private XmlQualifiedName qname; 
	private XmlSchemaGroup redefined; 
	private int selfReferenceCount; 

	[XmlAttributeAttribute] 
public string Name { get; set; }
	[XmlElementAttribute] 
	[XmlElementAttribute] 
	[XmlElementAttribute] 
public XmlSchemaGroupBase Particle { get; set; }
	[XmlIgnoreAttribute] 
public XmlQualifiedName QualifiedName { get; }
	[XmlIgnoreAttribute] 
internal XmlSchemaParticle CanonicalParticle { get; set; }
	[XmlIgnoreAttribute] 
internal XmlSchemaGroup Redefined { get; set; }
	[XmlIgnoreAttribute] 
internal int SelfReferenceCount { get; set; }
	[XmlIgnoreAttribute] 
internal override string NameAttribute { get; set; }


public string get_Name() { }

public void set_Name(string value) { }

public XmlSchemaGroupBase get_Particle() { }

public void set_Particle(XmlSchemaGroupBase value) { }

public XmlQualifiedName get_QualifiedName() { }

internal XmlSchemaParticle get_CanonicalParticle() { }

internal void set_CanonicalParticle(XmlSchemaParticle value) { }

internal XmlSchemaGroup get_Redefined() { }

internal void set_Redefined(XmlSchemaGroup value) { }

internal int get_SelfReferenceCount() { }

internal void set_SelfReferenceCount(int value) { }

internal override string get_NameAttribute() { }

internal override void set_NameAttribute(string value) { }

internal void SetQualifiedName(XmlQualifiedName value) { }

internal override XmlSchemaObject Clone() { }

internal XmlSchemaObject Clone(XmlSchema parentSchema) { }

public void .ctor() { }

}

public abstract class XmlSchemaGroupBase : XmlSchemaParticle // TypeDefIndex: 2352
{
	[XmlIgnoreAttribute] 
public abstract XmlSchemaObjectCollection Items { get; }


public abstract XmlSchemaObjectCollection get_Items();

internal abstract void SetItems(XmlSchemaObjectCollection newItems);

protected void .ctor() { }

}

public class XmlSchemaGroupRef : XmlSchemaParticle // TypeDefIndex: 2353
{
	private XmlQualifiedName refName; 
	private XmlSchemaGroupBase particle; 
	private XmlSchemaGroup refined; 

	[XmlAttributeAttribute] 
public XmlQualifiedName RefName { get; set; }
	[XmlIgnoreAttribute] 
public XmlSchemaGroupBase Particle { get; }
	[XmlIgnoreAttribute] 
internal XmlSchemaGroup Redefined { get; set; }


public XmlQualifiedName get_RefName() { }

public void set_RefName(XmlQualifiedName value) { }

public XmlSchemaGroupBase get_Particle() { }

internal void SetParticle(XmlSchemaGroupBase value) { }

internal XmlSchemaGroup get_Redefined() { }

internal void set_Redefined(XmlSchemaGroup value) { }

public void .ctor() { }

}

public class XmlSchemaIdentityConstraint : XmlSchemaAnnotated // TypeDefIndex: 2354
{
	private string name; 
	private XmlSchemaXPath selector; 
	private XmlSchemaObjectCollection fields; 
	private XmlQualifiedName qualifiedName; 
	private CompiledIdentityConstraint compiledConstraint; 

	[XmlAttributeAttribute] 
public string Name { get; set; }
	[XmlElementAttribute] 
public XmlSchemaXPath Selector { get; set; }
	[XmlElementAttribute] 
public XmlSchemaObjectCollection Fields { get; }
	[XmlIgnoreAttribute] 
public XmlQualifiedName QualifiedName { get; }
	[XmlIgnoreAttribute] 
internal CompiledIdentityConstraint CompiledConstraint { get; set; }
	[XmlIgnoreAttribute] 
internal override string NameAttribute { get; set; }


public string get_Name() { }

public void set_Name(string value) { }

public XmlSchemaXPath get_Selector() { }

public void set_Selector(XmlSchemaXPath value) { }

public XmlSchemaObjectCollection get_Fields() { }

public XmlQualifiedName get_QualifiedName() { }

internal void SetQualifiedName(XmlQualifiedName value) { }

internal CompiledIdentityConstraint get_CompiledConstraint() { }

internal void set_CompiledConstraint(CompiledIdentityConstraint value) { }

internal override string get_NameAttribute() { }

internal override void set_NameAttribute(string value) { }

public void .ctor() { }

}

public class XmlSchemaXPath : XmlSchemaAnnotated // TypeDefIndex: 2355
{
	private string xpath; 

	[XmlAttributeAttribute] 
	[DefaultValueAttribute] 
public string XPath { get; set; }


public string get_XPath() { }

public void set_XPath(string value) { }

public void .ctor() { }

}

public class XmlSchemaUnique : XmlSchemaIdentityConstraint // TypeDefIndex: 2356
{

public void .ctor() { }

}

public class XmlSchemaKey : XmlSchemaIdentityConstraint // TypeDefIndex: 2357
{

public void .ctor() { }

}

public class XmlSchemaKeyref : XmlSchemaIdentityConstraint // TypeDefIndex: 2358
{
	private XmlQualifiedName refer; 

	[XmlAttributeAttribute] 
public XmlQualifiedName Refer { get; set; }


public XmlQualifiedName get_Refer() { }

public void set_Refer(XmlQualifiedName value) { }

public void .ctor() { }

}

public class XmlSchemaImport : XmlSchemaExternal // TypeDefIndex: 2359
{
	private string ns; 
	private XmlSchemaAnnotation annotation; 

	[XmlAttributeAttribute] 
public string Namespace { get; set; }


public void .ctor() { }

public string get_Namespace() { }

public void set_Namespace(string value) { }

internal override void AddAnnotation(XmlSchemaAnnotation annotation) { }

}

public class XmlSchemaInclude : XmlSchemaExternal // TypeDefIndex: 2360
{
	private XmlSchemaAnnotation annotation; 


public void .ctor() { }

internal override void AddAnnotation(XmlSchemaAnnotation annotation) { }

}

public class XmlSchemaInfo : IXmlSchemaInfo // TypeDefIndex: 2361
{
	private bool isDefault; 
	private bool isNil; 
	private XmlSchemaElement schemaElement; 
	private XmlSchemaAttribute schemaAttribute; 
	private XmlSchemaType schemaType; 
	private XmlSchemaSimpleType memberType; 
	private XmlSchemaValidity validity; 
	private XmlSchemaContentType contentType; 

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


public void .ctor() { }

internal void .ctor(XmlSchemaValidity validity) { }

public XmlSchemaValidity get_Validity() { }

public void set_Validity(XmlSchemaValidity value) { }

public bool get_IsDefault() { }

public void set_IsDefault(bool value) { }

public bool get_IsNil() { }

public void set_IsNil(bool value) { }

public XmlSchemaSimpleType get_MemberType() { }

public void set_MemberType(XmlSchemaSimpleType value) { }

public XmlSchemaType get_SchemaType() { }

public void set_SchemaType(XmlSchemaType value) { }

public XmlSchemaElement get_SchemaElement() { }

public void set_SchemaElement(XmlSchemaElement value) { }

public XmlSchemaAttribute get_SchemaAttribute() { }

public void set_SchemaAttribute(XmlSchemaAttribute value) { }

public XmlSchemaContentType get_ContentType() { }

internal XmlSchemaType get_XmlType() { }

internal bool get_HasDefaultValue() { }

internal bool get_IsUnionType() { }

internal void Clear() { }

}

public class XmlSchemaNotation : XmlSchemaAnnotated // TypeDefIndex: 2362
{
	private string name; 
	private string publicId; 
	private string systemId; 
	private XmlQualifiedName qname; 

	[XmlAttributeAttribute] 
public string Name { get; set; }
	[XmlAttributeAttribute] 
public string Public { get; set; }
	[XmlAttributeAttribute] 
public string System { get; set; }
	[XmlIgnoreAttribute] 
internal XmlQualifiedName QualifiedName { get; set; }
	[XmlIgnoreAttribute] 
internal override string NameAttribute { get; set; }


public string get_Name() { }

public void set_Name(string value) { }

public string get_Public() { }

public void set_Public(string value) { }

public string get_System() { }

public void set_System(string value) { }

internal XmlQualifiedName get_QualifiedName() { }

internal void set_QualifiedName(XmlQualifiedName value) { }

internal override string get_NameAttribute() { }

internal override void set_NameAttribute(string value) { }

public void .ctor() { }

}

public abstract class XmlSchemaObject // TypeDefIndex: 2363
{
	private int lineNum; 
	private int linePos; 
	private string sourceUri; 
	private XmlSerializerNamespaces namespaces; 
	private XmlSchemaObject parent; 
	private bool isProcessing; 

	[XmlIgnoreAttribute] 
public int LineNumber { get; set; }
	[XmlIgnoreAttribute] 
public int LinePosition { get; set; }
	[XmlIgnoreAttribute] 
public string SourceUri { get; set; }
	[XmlIgnoreAttribute] 
public XmlSchemaObject Parent { get; set; }
	[XmlNamespaceDeclarationsAttribute] 
public XmlSerializerNamespaces Namespaces { get; set; }
	[XmlIgnoreAttribute] 
internal virtual string IdAttribute { get; set; }
	[XmlIgnoreAttribute] 
internal virtual string NameAttribute { get; set; }
	[XmlIgnoreAttribute] 
internal bool IsProcessing { get; set; }


public int get_LineNumber() { }

public void set_LineNumber(int value) { }

public int get_LinePosition() { }

public void set_LinePosition(int value) { }

public string get_SourceUri() { }

public void set_SourceUri(string value) { }

public XmlSchemaObject get_Parent() { }

public void set_Parent(XmlSchemaObject value) { }

public XmlSerializerNamespaces get_Namespaces() { }

public void set_Namespaces(XmlSerializerNamespaces value) { }

internal virtual void OnAdd(XmlSchemaObjectCollection container, object item) { }

internal virtual void OnRemove(XmlSchemaObjectCollection container, object item) { }

internal virtual void OnClear(XmlSchemaObjectCollection container) { }

internal virtual string get_IdAttribute() { }

internal virtual void set_IdAttribute(string value) { }

internal virtual void SetUnhandledAttributes(XmlAttribute[] moreAttributes) { }

internal virtual void AddAnnotation(XmlSchemaAnnotation annotation) { }

internal virtual string get_NameAttribute() { }

internal virtual void set_NameAttribute(string value) { }

internal bool get_IsProcessing() { }

internal void set_IsProcessing(bool value) { }

internal virtual XmlSchemaObject Clone() { }

protected void .ctor() { }

}

public class XmlSchemaObjectCollection : CollectionBase // TypeDefIndex: 2364
{
	private XmlSchemaObject parent; 

public virtual XmlSchemaObject Item { get; set; }


public void .ctor() { }

public virtual XmlSchemaObject get_Item(int index) { }

public virtual void set_Item(int index, XmlSchemaObject value) { }

public XmlSchemaObjectEnumerator GetEnumerator() { }

public int Add(XmlSchemaObject item) { }

public void Insert(int index, XmlSchemaObject item) { }

public void Remove(XmlSchemaObject item) { }

protected override void OnInsert(int index, object item) { }

protected override void OnSet(int index, object oldValue, object newValue) { }

protected override void OnClear() { }

protected override void OnRemove(int index, object item) { }

internal XmlSchemaObjectCollection Clone() { }

private void Add(XmlSchemaObjectCollection collToAdd) { }

}

public class XmlSchemaObjectEnumerator : IEnumerator // TypeDefIndex: 2365
{
	private IEnumerator enumerator; 

public XmlSchemaObject Current { get; }
private object System.Collections.IEnumerator.Current { get; }


internal void .ctor(IEnumerator enumerator) { }

public bool MoveNext() { }

public XmlSchemaObject get_Current() { }

private void System.Collections.IEnumerator.Reset() { }

private bool System.Collections.IEnumerator.MoveNext() { }

private object System.Collections.IEnumerator.get_Current() { }

}

public class XmlSchemaObjectTable // TypeDefIndex: 2366
{
	private Dictionary<XmlQualifiedName, XmlSchemaObject> table; 
	private List<XmlSchemaObjectTable.XmlSchemaObjectEntry> entries; 

public int Count { get; }
public XmlSchemaObject Item { get; }
public ICollection Values { get; }


internal void .ctor() { }

internal void Add(XmlQualifiedName name, XmlSchemaObject value) { }

internal void Insert(XmlQualifiedName name, XmlSchemaObject value) { }

internal void Replace(XmlQualifiedName name, XmlSchemaObject value) { }

internal void Clear() { }

internal void Remove(XmlQualifiedName name) { }

private int FindIndexByValue(XmlSchemaObject xso) { }

public int get_Count() { }

public bool Contains(XmlQualifiedName name) { }

public XmlSchemaObject get_Item(XmlQualifiedName name) { }

public ICollection get_Values() { }

public IDictionaryEnumerator GetEnumerator() { }

}

internal enum XmlSchemaObjectTable.EnumeratorType // TypeDefIndex: 2367
{
	public int value__; 
public const XmlSchemaObjectTable.EnumeratorType Keys = 0;
public const XmlSchemaObjectTable.EnumeratorType Values = 1;
public const XmlSchemaObjectTable.EnumeratorType DictionaryEntry = 2;

}

internal struct XmlSchemaObjectTable.XmlSchemaObjectEntry // TypeDefIndex: 2368
{
	internal XmlQualifiedName qname; 
	internal XmlSchemaObject xso; 


public void .ctor(XmlQualifiedName name, XmlSchemaObject value) { }

}

internal class XmlSchemaObjectTable.ValuesCollection : ICollection, IEnumerable // TypeDefIndex: 2369
{
	private List<XmlSchemaObjectTable.XmlSchemaObjectEntry> entries; 
	private int size; 

public int Count { get; }
public object SyncRoot { get; }


internal void .ctor(List<XmlSchemaObjectTable.XmlSchemaObjectEntry> entries, int size) { }

public int get_Count() { }

public object get_SyncRoot() { }

public void CopyTo(Array array, int arrayIndex) { }

public IEnumerator GetEnumerator() { }

}

internal class XmlSchemaObjectTable.XSOEnumerator : IEnumerator // TypeDefIndex: 2370
{
	private List<XmlSchemaObjectTable.XmlSchemaObjectEntry> entries; 
	private XmlSchemaObjectTable.EnumeratorType enumType; 
	protected int currentIndex; 
	protected int size; 
	protected XmlQualifiedName currentKey; 
	protected XmlSchemaObject currentValue; 

public object Current { get; }


internal void .ctor(List<XmlSchemaObjectTable.XmlSchemaObjectEntry> entries, int size, XmlSchemaObjectTable.EnumeratorType enumType) { }

public object get_Current() { }

public bool MoveNext() { }

public void Reset() { }

}

internal class XmlSchemaObjectTable.XSODictionaryEnumerator : XmlSchemaObjectTable.XSOEnumerator, IDictionaryEnumerator, IEnumerator // TypeDefIndex: 2371
{
public DictionaryEntry Entry { get; }
public object Key { get; }
public object Value { get; }


internal void .ctor(List<XmlSchemaObjectTable.XmlSchemaObjectEntry> entries, int size, XmlSchemaObjectTable.EnumeratorType enumType) { }

public DictionaryEntry get_Entry() { }

public object get_Key() { }

public object get_Value() { }

}

public abstract class XmlSchemaParticle : XmlSchemaAnnotated // TypeDefIndex: 2372
{
	private Decimal minOccurs; 
	private Decimal maxOccurs; 
	private XmlSchemaParticle.Occurs flags; 
	internal static readonly XmlSchemaParticle Empty; 

	[XmlAttributeAttribute] 
public string MinOccursString { get; set; }
	[XmlAttributeAttribute] 
public string MaxOccursString { get; set; }
	[XmlIgnoreAttribute] 
public Decimal MinOccurs { get; set; }
	[XmlIgnoreAttribute] 
public Decimal MaxOccurs { get; set; }
internal virtual bool IsEmpty { get; }
internal virtual string NameString { get; }


public string get_MinOccursString() { }

public void set_MinOccursString(string value) { }

public string get_MaxOccursString() { }

public void set_MaxOccursString(string value) { }

public Decimal get_MinOccurs() { }

public void set_MinOccurs(Decimal value) { }

public Decimal get_MaxOccurs() { }

public void set_MaxOccurs(Decimal value) { }

internal virtual bool get_IsEmpty() { }

internal virtual string get_NameString() { }

internal XmlQualifiedName GetQualifiedName() { }

protected void .ctor() { }

private static void .cctor() { }

}

private enum XmlSchemaParticle.Occurs // TypeDefIndex: 2373
{
	public int value__; 
public const XmlSchemaParticle.Occurs None = 0;
public const XmlSchemaParticle.Occurs Min = 1;
public const XmlSchemaParticle.Occurs Max = 2;

}

private class XmlSchemaParticle.EmptyParticle : XmlSchemaParticle // TypeDefIndex: 2374
{
internal override bool IsEmpty { get; }


internal override bool get_IsEmpty() { }

public void .ctor() { }

}

public class XmlSchemaRedefine : XmlSchemaExternal // TypeDefIndex: 2375
{
	private XmlSchemaObjectCollection items; 
	private XmlSchemaObjectTable attributeGroups; 
	private XmlSchemaObjectTable types; 
	private XmlSchemaObjectTable groups; 

	[XmlElementAttribute] 
	[XmlElementAttribute] 
	[XmlElementAttribute] 
	[XmlElementAttribute] 
	[XmlElementAttribute] 
public XmlSchemaObjectCollection Items { get; }
	[XmlIgnoreAttribute] 
public XmlSchemaObjectTable AttributeGroups { get; }
	[XmlIgnoreAttribute] 
public XmlSchemaObjectTable SchemaTypes { get; }
	[XmlIgnoreAttribute] 
public XmlSchemaObjectTable Groups { get; }


public void .ctor() { }

public XmlSchemaObjectCollection get_Items() { }

public XmlSchemaObjectTable get_AttributeGroups() { }

public XmlSchemaObjectTable get_SchemaTypes() { }

public XmlSchemaObjectTable get_Groups() { }

internal override void AddAnnotation(XmlSchemaAnnotation annotation) { }

}

public class XmlSchemaSequence : XmlSchemaGroupBase // TypeDefIndex: 2376
{
	private XmlSchemaObjectCollection items; 

	[XmlElementAttribute] 
	[XmlElementAttribute] 
	[XmlElementAttribute] 
	[XmlElementAttribute] 
	[XmlElementAttribute] 
public override XmlSchemaObjectCollection Items { get; }
internal override bool IsEmpty { get; }


public override XmlSchemaObjectCollection get_Items() { }

internal override bool get_IsEmpty() { }

internal override void SetItems(XmlSchemaObjectCollection newItems) { }

public void .ctor() { }

}

public class XmlSchemaSet // TypeDefIndex: 2377
{
	private XmlNameTable nameTable; 
	private SchemaNames schemaNames; 
	private SortedList schemas; 
	private ValidationEventHandler internalEventHandler; 
	private ValidationEventHandler eventHandler; 
	private bool isCompiled; 
	private Hashtable schemaLocations; 
	private Hashtable chameleonSchemas; 
	private Hashtable targetNamespaces; 
	private bool compileAll; 
	private SchemaInfo cachedCompiledInfo; 
	private XmlReaderSettings readerSettings; 
	private XmlSchema schemaForSchema; 
	private XmlSchemaCompilationSettings compilationSettings; 
	internal XmlSchemaObjectTable elements; 
	internal XmlSchemaObjectTable attributes; 
	internal XmlSchemaObjectTable schemaTypes; 
	internal XmlSchemaObjectTable substitutionGroups; 
	private XmlSchemaObjectTable typeExtensions; 
	private object internalSyncObject; 

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


internal object get_InternalSyncObject() { }

public void .ctor() { }

public void .ctor(XmlNameTable nameTable) { }

public void add_ValidationEventHandler(ValidationEventHandler value) { }

public void remove_ValidationEventHandler(ValidationEventHandler value) { }

public bool get_IsCompiled() { }

public void set_XmlResolver(XmlResolver value) { }

public XmlSchemaCompilationSettings get_CompilationSettings() { }

public void set_CompilationSettings(XmlSchemaCompilationSettings value) { }

public int get_Count() { }

public XmlSchemaObjectTable get_GlobalElements() { }

public XmlSchemaObjectTable get_GlobalAttributes() { }

public XmlSchemaObjectTable get_GlobalTypes() { }

internal XmlSchemaObjectTable get_SubstitutionGroups() { }

internal Hashtable get_SchemaLocations() { }

internal XmlSchemaObjectTable get_TypeExtensions() { }

public void Add(XmlSchemaSet schemas) { }

public XmlSchema Add(XmlSchema schema) { }

public bool RemoveRecursive(XmlSchema schemaToRemove) { }

public bool Contains(string targetNamespace) { }

public void Compile() { }

public XmlSchema Reprocess(XmlSchema schema) { }

public void CopyTo(XmlSchema[] schemas, int index) { }

public ICollection Schemas() { }

public ICollection Schemas(string targetNamespace) { }

private XmlSchema Add(string targetNamespace, XmlSchema schema) { }

internal void Add(string targetNamespace, XmlReader reader, Hashtable validatedNamespaces) { }

internal XmlSchema FindSchemaByNSAndUrl(Uri schemaUri, string ns, DictionaryEntry[] locationsTable) { }

private void AddSchemaToSet(XmlSchema schema) { }

private void ProcessNewSubstitutionGroups(XmlSchemaObjectTable substitutionGroupsTable, bool resolve) { }

private void ResolveSubstitutionGroup(XmlSchemaSubstitutionGroup substitutionGroup, XmlSchemaObjectTable substTable) { }

internal XmlSchema Remove(XmlSchema schema, bool forceCompile) { }

private void ClearTables() { }

internal bool PreprocessSchema(ref XmlSchema schema, string targetNamespace) { }

internal XmlSchema ParseSchema(string targetNamespace, XmlReader reader) { }

internal void CopyFromCompiledSet(XmlSchemaSet otherSet) { }

internal SchemaInfo get_CompiledInfo() { }

internal XmlReaderSettings get_ReaderSettings() { }

internal XmlResolver GetResolver() { }

internal ValidationEventHandler GetEventHandler() { }

internal SchemaNames GetSchemaNames(XmlNameTable nt) { }

internal bool IsSchemaLoaded(Uri schemaUri, string targetNamespace, out XmlSchema schema) { }

internal bool GetSchemaByUri(Uri schemaUri, out XmlSchema schema) { }

internal string GetTargetNamespace(XmlSchema schema) { }

internal SortedList get_SortedSchemas() { }

private void RemoveSchemaFromCaches(XmlSchema schema) { }

private void RemoveSchemaFromGlobalTables(XmlSchema schema) { }

private bool AddToTable(XmlSchemaObjectTable table, XmlQualifiedName qname, XmlSchemaObject item) { }

private void VerifyTables() { }

private void InternalValidationCallback(object sender, ValidationEventArgs e) { }

private void SendValidationEvent(XmlSchemaException e, XmlSeverityType severity) { }

}

public class XmlSchemaSimpleContent : XmlSchemaContentModel // TypeDefIndex: 2378
{
	private XmlSchemaContent content; 

	[XmlElementAttribute] 
	[XmlElementAttribute] 
public override XmlSchemaContent Content { get; set; }


public override XmlSchemaContent get_Content() { }

public override void set_Content(XmlSchemaContent value) { }

public void .ctor() { }

}

public class XmlSchemaSimpleContentExtension : XmlSchemaContent // TypeDefIndex: 2379
{
	private XmlSchemaObjectCollection attributes; 
	private XmlSchemaAnyAttribute anyAttribute; 
	private XmlQualifiedName baseTypeName; 

	[XmlAttributeAttribute] 
public XmlQualifiedName BaseTypeName { get; set; }
	[XmlElementAttribute] 
	[XmlElementAttribute] 
public XmlSchemaObjectCollection Attributes { get; }
	[XmlElementAttribute] 
public XmlSchemaAnyAttribute AnyAttribute { get; set; }


public XmlQualifiedName get_BaseTypeName() { }

public void set_BaseTypeName(XmlQualifiedName value) { }

public XmlSchemaObjectCollection get_Attributes() { }

public XmlSchemaAnyAttribute get_AnyAttribute() { }

public void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

internal void SetAttributes(XmlSchemaObjectCollection newAttributes) { }

public void .ctor() { }

}

public class XmlSchemaSimpleContentRestriction : XmlSchemaContent // TypeDefIndex: 2380
{
	private XmlQualifiedName baseTypeName; 
	private XmlSchemaSimpleType baseType; 
	private XmlSchemaObjectCollection facets; 
	private XmlSchemaObjectCollection attributes; 
	private XmlSchemaAnyAttribute anyAttribute; 

	[XmlAttributeAttribute] 
public XmlQualifiedName BaseTypeName { get; set; }
	[XmlElementAttribute] 
public XmlSchemaSimpleType BaseType { get; set; }
	[XmlElementAttribute] 
	[XmlElementAttribute] 
	[XmlElementAttribute] 
	[XmlElementAttribute] 
	[XmlElementAttribute] 
	[XmlElementAttribute] 
	[XmlElementAttribute] 
	[XmlElementAttribute] 
	[XmlElementAttribute] 
	[XmlElementAttribute] 
	[XmlElementAttribute] 
	[XmlElementAttribute] 
public XmlSchemaObjectCollection Facets { get; }
	[XmlElementAttribute] 
	[XmlElementAttribute] 
public XmlSchemaObjectCollection Attributes { get; }
	[XmlElementAttribute] 
public XmlSchemaAnyAttribute AnyAttribute { get; set; }


public XmlQualifiedName get_BaseTypeName() { }

public void set_BaseTypeName(XmlQualifiedName value) { }

public XmlSchemaSimpleType get_BaseType() { }

public void set_BaseType(XmlSchemaSimpleType value) { }

public XmlSchemaObjectCollection get_Facets() { }

public XmlSchemaObjectCollection get_Attributes() { }

public XmlSchemaAnyAttribute get_AnyAttribute() { }

public void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

internal void SetAttributes(XmlSchemaObjectCollection newAttributes) { }

public void .ctor() { }

}

public class XmlSchemaSimpleType : XmlSchemaType // TypeDefIndex: 2381
{
	private XmlSchemaSimpleTypeContent content; 

	[XmlElementAttribute] 
	[XmlElementAttribute] 
	[XmlElementAttribute] 
public XmlSchemaSimpleTypeContent Content { get; set; }


public void .ctor() { }

public XmlSchemaSimpleTypeContent get_Content() { }

public void set_Content(XmlSchemaSimpleTypeContent value) { }

internal override XmlSchemaObject Clone() { }

}

public abstract class XmlSchemaSimpleTypeContent : XmlSchemaAnnotated // TypeDefIndex: 2382
{

protected void .ctor() { }

}

public class XmlSchemaSimpleTypeList : XmlSchemaSimpleTypeContent // TypeDefIndex: 2383
{
	private XmlQualifiedName itemTypeName; 
	private XmlSchemaSimpleType itemType; 
	private XmlSchemaSimpleType baseItemType; 

	[XmlAttributeAttribute] 
public XmlQualifiedName ItemTypeName { get; set; }
	[XmlElementAttribute] 
public XmlSchemaSimpleType ItemType { get; set; }
	[XmlIgnoreAttribute] 
public XmlSchemaSimpleType BaseItemType { get; set; }


public XmlQualifiedName get_ItemTypeName() { }

public void set_ItemTypeName(XmlQualifiedName value) { }

public XmlSchemaSimpleType get_ItemType() { }

public void set_ItemType(XmlSchemaSimpleType value) { }

public XmlSchemaSimpleType get_BaseItemType() { }

public void set_BaseItemType(XmlSchemaSimpleType value) { }

internal override XmlSchemaObject Clone() { }

public void .ctor() { }

}

public class XmlSchemaSimpleTypeRestriction : XmlSchemaSimpleTypeContent // TypeDefIndex: 2384
{
	private XmlQualifiedName baseTypeName; 
	private XmlSchemaSimpleType baseType; 
	private XmlSchemaObjectCollection facets; 

	[XmlAttributeAttribute] 
public XmlQualifiedName BaseTypeName { get; set; }
	[XmlElementAttribute] 
public XmlSchemaSimpleType BaseType { get; set; }
	[XmlElementAttribute] 
	[XmlElementAttribute] 
	[XmlElementAttribute] 
	[XmlElementAttribute] 
	[XmlElementAttribute] 
	[XmlElementAttribute] 
	[XmlElementAttribute] 
	[XmlElementAttribute] 
	[XmlElementAttribute] 
	[XmlElementAttribute] 
	[XmlElementAttribute] 
	[XmlElementAttribute] 
public XmlSchemaObjectCollection Facets { get; }


public XmlQualifiedName get_BaseTypeName() { }

public void set_BaseTypeName(XmlQualifiedName value) { }

public XmlSchemaSimpleType get_BaseType() { }

public void set_BaseType(XmlSchemaSimpleType value) { }

public XmlSchemaObjectCollection get_Facets() { }

internal override XmlSchemaObject Clone() { }

public void .ctor() { }

}

public class XmlSchemaSimpleTypeUnion : XmlSchemaSimpleTypeContent // TypeDefIndex: 2385
{
	private XmlSchemaObjectCollection baseTypes; 
	private XmlQualifiedName[] memberTypes; 
	private XmlSchemaSimpleType[] baseMemberTypes; 

	[XmlElementAttribute] 
public XmlSchemaObjectCollection BaseTypes { get; }
	[XmlAttributeAttribute] 
public XmlQualifiedName[] MemberTypes { get; set; }
	[XmlIgnoreAttribute] 
public XmlSchemaSimpleType[] BaseMemberTypes { get; }


public XmlSchemaObjectCollection get_BaseTypes() { }

public XmlQualifiedName[] get_MemberTypes() { }

public void set_MemberTypes(XmlQualifiedName[] value) { }

public XmlSchemaSimpleType[] get_BaseMemberTypes() { }

internal void SetBaseMemberTypes(XmlSchemaSimpleType[] baseMemberTypes) { }

internal override XmlSchemaObject Clone() { }

public void .ctor() { }

}

internal class XmlSchemaSubstitutionGroup : XmlSchemaObject // TypeDefIndex: 2386
{
	private ArrayList membersList; 
	private XmlQualifiedName examplar; 

	[XmlIgnoreAttribute] 
internal ArrayList Members { get; }
	[XmlIgnoreAttribute] 
internal XmlQualifiedName Examplar { get; set; }


internal ArrayList get_Members() { }

internal XmlQualifiedName get_Examplar() { }

internal void set_Examplar(XmlQualifiedName value) { }

public void .ctor() { }

}

internal class XmlSchemaSubstitutionGroupV1Compat : XmlSchemaSubstitutionGroup // TypeDefIndex: 2387
{
	private XmlSchemaChoice choice; 

	[XmlIgnoreAttribute] 
internal XmlSchemaChoice Choice { get; }


internal XmlSchemaChoice get_Choice() { }

public void .ctor() { }

}

public class XmlSchemaType : XmlSchemaAnnotated // TypeDefIndex: 2388
{
	private string name; 
	private XmlSchemaDerivationMethod final; 
	private XmlSchemaDerivationMethod derivedBy; 
	private XmlSchemaType baseSchemaType; 
	private XmlSchemaDatatype datatype; 
	private XmlSchemaDerivationMethod finalResolved; 
	private SchemaElementDecl elementDecl; 
	private XmlQualifiedName qname; 
	private XmlSchemaType redefined; 
	private XmlSchemaContentType contentType; 

	[XmlAttributeAttribute] 
public string Name { get; set; }
	[XmlAttributeAttribute] 
	[DefaultValueAttribute] 
public XmlSchemaDerivationMethod Final { get; set; }
	[XmlIgnoreAttribute] 
public XmlQualifiedName QualifiedName { get; }
	[XmlIgnoreAttribute] 
public XmlSchemaDerivationMethod FinalResolved { get; }
	[XmlIgnoreAttribute] 
public XmlSchemaType BaseXmlSchemaType { get; }
	[XmlIgnoreAttribute] 
public XmlSchemaDerivationMethod DerivedBy { get; }
	[XmlIgnoreAttribute] 
public XmlSchemaDatatype Datatype { get; }
	[XmlIgnoreAttribute] 
public virtual bool IsMixed { get; set; }
	[XmlIgnoreAttribute] 
public XmlTypeCode TypeCode { get; }
	[XmlIgnoreAttribute] 
internal XmlValueConverter ValueConverter { get; }
internal XmlSchemaContentType SchemaContentType { get; }
internal SchemaElementDecl ElementDecl { get; set; }
	[XmlIgnoreAttribute] 
internal XmlSchemaType Redefined { get; set; }
	[XmlIgnoreAttribute] 
internal override string NameAttribute { get; set; }


public static XmlSchemaSimpleType GetBuiltInSimpleType(XmlQualifiedName qualifiedName) { }

public static XmlSchemaSimpleType GetBuiltInSimpleType(XmlTypeCode typeCode) { }

public static XmlSchemaComplexType GetBuiltInComplexType(XmlQualifiedName qualifiedName) { }

public string get_Name() { }

public void set_Name(string value) { }

public XmlSchemaDerivationMethod get_Final() { }

public void set_Final(XmlSchemaDerivationMethod value) { }

public XmlQualifiedName get_QualifiedName() { }

public XmlSchemaDerivationMethod get_FinalResolved() { }

public XmlSchemaType get_BaseXmlSchemaType() { }

public XmlSchemaDerivationMethod get_DerivedBy() { }

public XmlSchemaDatatype get_Datatype() { }

public virtual bool get_IsMixed() { }

public virtual void set_IsMixed(bool value) { }

public XmlTypeCode get_TypeCode() { }

internal XmlValueConverter get_ValueConverter() { }

internal XmlSchemaContentType get_SchemaContentType() { }

internal void SetQualifiedName(XmlQualifiedName value) { }

internal void SetFinalResolved(XmlSchemaDerivationMethod value) { }

internal void SetBaseSchemaType(XmlSchemaType value) { }

internal void SetDerivedBy(XmlSchemaDerivationMethod value) { }

internal void SetDatatype(XmlSchemaDatatype value) { }

internal SchemaElementDecl get_ElementDecl() { }

internal void set_ElementDecl(SchemaElementDecl value) { }

internal XmlSchemaType get_Redefined() { }

internal void set_Redefined(XmlSchemaType value) { }

internal void SetContentType(XmlSchemaContentType value) { }

public static bool IsDerivedFrom(XmlSchemaType derivedType, XmlSchemaType baseType, XmlSchemaDerivationMethod except) { }

internal static bool IsDerivedFromDatatype(XmlSchemaDatatype derivedDataType, XmlSchemaDatatype baseDataType, XmlSchemaDerivationMethod except) { }

internal override string get_NameAttribute() { }

internal override void set_NameAttribute(string value) { }

public void .ctor() { }

}

public enum XmlSchemaUse // TypeDefIndex: 2389
{
	public int value__; 
	[XmlIgnoreAttribute] 
public const XmlSchemaUse None = 0;
	[XmlEnumAttribute] 
public const XmlSchemaUse Optional = 1;
	[XmlEnumAttribute] 
public const XmlSchemaUse Prohibited = 2;
	[XmlEnumAttribute] 
public const XmlSchemaUse Required = 3;

}

public class XmlSchemaValidationException : XmlSchemaException // TypeDefIndex: 2390
{

protected void .ctor(SerializationInfo info, StreamingContext context) { }

public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

public void .ctor() { }

internal void .ctor(string res, string arg, string sourceUri, int lineNumber, int linePosition) { }

internal void .ctor(string res, string[] args, string sourceUri, int lineNumber, int linePosition) { }

internal void .ctor(string res, string[] args, Exception innerException, string sourceUri, int lineNumber, int linePosition) { }

}

public sealed class XmlValueGetter : MulticastDelegate // TypeDefIndex: 2391
{

public void .ctor(object object, IntPtr method) { }

public virtual object Invoke() { }

public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

public virtual object EndInvoke(IAsyncResult result) { }

}

public enum XmlSchemaValidationFlags // TypeDefIndex: 2392
{
	public int value__; 
public const XmlSchemaValidationFlags None = 0;
public const XmlSchemaValidationFlags ProcessInlineSchema = 1;
public const XmlSchemaValidationFlags ProcessSchemaLocation = 2;
public const XmlSchemaValidationFlags ReportValidationWarnings = 4;
public const XmlSchemaValidationFlags ProcessIdentityConstraints = 8;
public const XmlSchemaValidationFlags AllowXmlAttributes = 16;

}

public sealed class XmlSchemaValidator // TypeDefIndex: 2395
{
	private XmlSchemaSet schemaSet; 
	private XmlSchemaValidationFlags validationFlags; 
	private int startIDConstraint; 
	private bool isRoot; 
	private bool rootHasSchema; 
	private bool attrValid; 
	private bool checkEntity; 
	private SchemaInfo compiledSchemaInfo; 
	private IDtdInfo dtdSchemaInfo; 
	private Hashtable validatedNamespaces; 
	private HWStack validationStack; 
	private ValidationState context; 
	private ValidatorState currentState; 
	private Hashtable attPresence; 
	private SchemaAttDef wildID; 
	private Hashtable IDs; 
	private IdRefNode idRefListHead; 
	private XmlQualifiedName contextQName; 
	private string NsXs; 
	private string NsXsi; 
	private string NsXmlNs; 
	private string NsXml; 
	private XmlSchemaObject partialValidationType; 
	private StringBuilder textValue; 
	private ValidationEventHandler eventHandler; 
	private object validationEventSender; 
	private XmlNameTable nameTable; 
	private IXmlLineInfo positionInfo; 
	private IXmlLineInfo dummyPositionInfo; 
	private XmlResolver xmlResolver; 
	private Uri sourceUri; 
	private string sourceUriString; 
	private IXmlNamespaceResolver nsResolver; 
	private XmlSchemaContentProcessing processContents; 
	private string xsiTypeString; 
	private string xsiNilString; 
	private string xsiSchemaLocationString; 
	private string xsiNoNamespaceSchemaLocationString; 
	private static readonly XmlSchemaDatatype dtQName; 
	private static readonly XmlSchemaDatatype dtCDATA; 
	private static readonly XmlSchemaDatatype dtStringArray; 
	private static XmlSchemaParticle[] EmptyParticleArray; 
	private static XmlSchemaAttribute[] EmptyAttributeArray; 
	private XmlCharType xmlCharType; 
	internal static bool[,] ValidStates; 
	private static string[] MethodNames; 

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


public void .ctor(XmlNameTable nameTable, XmlSchemaSet schemas, IXmlNamespaceResolver namespaceResolver, XmlSchemaValidationFlags validationFlags) { }

private void Init() { }

private void Reset() { }

public void set_XmlResolver(XmlResolver value) { }

public void set_LineInfoProvider(IXmlLineInfo value) { }

public void set_SourceUri(Uri value) { }

public void set_ValidationEventSender(object value) { }

public void add_ValidationEventHandler(ValidationEventHandler value) { }

public void remove_ValidationEventHandler(ValidationEventHandler value) { }

public void AddSchema(XmlSchema schema) { }

public void Initialize() { }

public void Initialize(XmlSchemaObject partialValidationType) { }

public void ValidateElement(string localName, string namespaceUri, XmlSchemaInfo schemaInfo, string xsiType, string xsiNil, string xsiSchemaLocation, string xsiNoNamespaceSchemaLocation) { }

public object ValidateAttribute(string localName, string namespaceUri, XmlValueGetter attributeValue, XmlSchemaInfo schemaInfo) { }

private object ValidateAttribute(string lName, string ns, XmlValueGetter attributeValueGetter, string attributeStringValue, XmlSchemaInfo schemaInfo) { }

public void ValidateEndOfAttributes(XmlSchemaInfo schemaInfo) { }

public void ValidateText(XmlValueGetter elementValue) { }

private void ValidateText(string elementStringValue, XmlValueGetter elementValueGetter) { }

public void ValidateWhitespace(XmlValueGetter elementValue) { }

private void ValidateWhitespace(string elementStringValue, XmlValueGetter elementValueGetter) { }

public object ValidateEndElement(XmlSchemaInfo schemaInfo) { }

public void SkipToEndElement(XmlSchemaInfo schemaInfo) { }

public void EndValidation() { }

internal void GetUnspecifiedDefaultAttributes(ArrayList defaultAttributes, bool createNodeData) { }

internal XmlSchemaSet get_SchemaSet() { }

internal XmlSchemaValidationFlags get_ValidationFlags() { }

internal XmlSchemaContentType get_CurrentContentType() { }

internal void SetDtdSchemaInfo(IDtdInfo dtdSchemaInfo) { }

private bool get_StrictlyAssessed() { }

private bool get_HasSchema() { }

internal string GetConcatenatedValue() { }

private object InternalValidateEndElement(XmlSchemaInfo schemaInfo, object typedValue) { }

private void ProcessSchemaLocations(string xsiSchemaLocation, string xsiNoNamespaceSchemaLocation) { }

private object ValidateElementContext(XmlQualifiedName elementName, out bool invalidElementInContext) { }

private XmlSchemaElement GetSubstitutionGroupHead(XmlQualifiedName member) { }

private object ValidateAtomicValue(string stringValue, out XmlSchemaSimpleType memberType) { }

private object ValidateAtomicValue(object parsedValue, out XmlSchemaSimpleType memberType) { }

private string GetTypeName(SchemaDeclBase decl) { }

private void SaveTextValue(object value) { }

private void Push(XmlQualifiedName elementName) { }

private void Pop() { }

private SchemaElementDecl FastGetElementDecl(XmlQualifiedName elementName, object particle) { }

private SchemaElementDecl CheckXsiTypeAndNil(SchemaElementDecl elementDecl, string xsiType, string xsiNil, ref bool declFound) { }

private void ThrowDeclNotFoundWarningOrError(bool declFound) { }

private void CheckElementProperties() { }

private void ValidateStartElementIdentityConstraints() { }

private SchemaAttDef CheckIsXmlAttribute(XmlQualifiedName attQName) { }

private void AddXmlNamespaceSchema() { }

internal object CheckMixedValueConstraint(string elementValue) { }

private void LoadSchema(string uri, string url) { }

internal void RecompileSchemaSet() { }

private void ProcessTokenizedType(XmlTokenizedType ttype, string name, bool attrValue) { }

private object CheckAttributeValue(object value, SchemaAttDef attdef) { }

private object CheckElementValue(string stringValue) { }

private void CheckTokenizedTypes(XmlSchemaDatatype dtype, object typedValue, bool attrValue) { }

private object FindId(string name) { }

private void CheckForwardRefs() { }

private bool get_HasIdentityConstraints() { }

internal bool get_ProcessIdentityConstraints() { }

internal bool get_ReportValidationWarnings() { }

internal bool get_ProcessSchemaHints() { }

private void CheckStateTransition(ValidatorState toState, string methodName) { }

private void ClearPSVI() { }

private void CheckRequiredAttributes(SchemaElementDecl currentElementDecl) { }

private XmlSchemaElement GetSchemaElement() { }

internal string GetDefaultAttributePrefix(string attributeNS) { }

private void AddIdentityConstraints() { }

private void ElementIdentityConstraints() { }

private void AttributeIdentityConstraints(string name, string ns, object obj, string sobj, XmlSchemaDatatype datatype) { }

private void EndElementIdentityConstraints(object typedValue, string stringValue, XmlSchemaDatatype datatype) { }

internal static void ElementValidationError(XmlQualifiedName name, ValidationState context, ValidationEventHandler eventHandler, object sender, string sourceUri, int lineNo, int linePos, XmlSchemaSet schemaSet) { }

internal static void CompleteValidationError(ValidationState context, ValidationEventHandler eventHandler, object sender, string sourceUri, int lineNo, int linePos, XmlSchemaSet schemaSet) { }

internal static string PrintExpectedElements(ArrayList expected, bool getParticles) { }

private static string PrintNames(ArrayList expected) { }

private static void PrintNamesWithNS(ArrayList expected, StringBuilder builder) { }

private static void EnumerateAny(StringBuilder builder, string namespaces) { }

internal static string QNameString(string localName, string ns) { }

internal static string BuildElementName(XmlQualifiedName qname) { }

internal static string BuildElementName(string localName, string ns) { }

private void ProcessEntity(string name) { }

private void SendValidationEvent(string code) { }

private void SendValidationEvent(string code, string[] args) { }

private void SendValidationEvent(string code, string arg) { }

private void SendValidationEvent(string code, string arg1, string arg2) { }

private void SendValidationEvent(string code, string[] args, Exception innerException, XmlSeverityType severity) { }

private void SendValidationEvent(string code, string[] args, Exception innerException) { }

private void SendValidationEvent(XmlSchemaValidationException e) { }

private void SendValidationEvent(XmlSchemaException e) { }

private void SendValidationEvent(string code, string msg, XmlSeverityType severity) { }

private void SendValidationEvent(XmlSchemaValidationException e, XmlSeverityType severity) { }

internal static void SendValidationEvent(ValidationEventHandler eventHandler, object sender, XmlSchemaValidationException e, XmlSeverityType severity) { }

private static void .cctor() { }

}

public enum XmlSchemaValidity // TypeDefIndex: 2396
{
	public int value__; 
public const XmlSchemaValidity NotKnown = 0;
public const XmlSchemaValidity Valid = 1;
public const XmlSchemaValidity Invalid = 2;

}

public enum XmlSeverityType // TypeDefIndex: 2397
{
	public int value__; 
public const XmlSeverityType Error = 0;
public const XmlSeverityType Warning = 1;

}

public enum XmlTypeCode // TypeDefIndex: 2398
{
	public int value__; 
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
{

public abstract bool ToBoolean(long value);

public abstract bool ToBoolean(int value);

public abstract bool ToBoolean(double value);

public abstract bool ToBoolean(DateTime value);

public abstract bool ToBoolean(string value);

public abstract bool ToBoolean(object value);

public abstract int ToInt32(bool value);

public abstract int ToInt32(long value);

public abstract int ToInt32(double value);

public abstract int ToInt32(DateTime value);

public abstract int ToInt32(string value);

public abstract int ToInt32(object value);

public abstract long ToInt64(bool value);

public abstract long ToInt64(int value);

public abstract long ToInt64(double value);

public abstract long ToInt64(DateTime value);

public abstract long ToInt64(string value);

public abstract long ToInt64(object value);

public abstract Decimal ToDecimal(string value);

public abstract Decimal ToDecimal(object value);

public abstract double ToDouble(bool value);

public abstract double ToDouble(int value);

public abstract double ToDouble(long value);

public abstract double ToDouble(DateTime value);

public abstract double ToDouble(string value);

public abstract double ToDouble(object value);

public abstract float ToSingle(double value);

public abstract float ToSingle(string value);

public abstract float ToSingle(object value);

public abstract DateTime ToDateTime(bool value);

public abstract DateTime ToDateTime(int value);

public abstract DateTime ToDateTime(long value);

public abstract DateTime ToDateTime(double value);

public abstract DateTime ToDateTime(DateTimeOffset value);

public abstract DateTime ToDateTime(string value);

public abstract DateTime ToDateTime(object value);

public abstract DateTimeOffset ToDateTimeOffset(DateTime value);

public abstract DateTimeOffset ToDateTimeOffset(string value);

public abstract DateTimeOffset ToDateTimeOffset(object value);

public abstract string ToString(bool value);

public abstract string ToString(int value);

public abstract string ToString(long value);

public abstract string ToString(Decimal value);

public abstract string ToString(float value);

public abstract string ToString(double value);

public abstract string ToString(DateTime value);

public abstract string ToString(DateTimeOffset value);

public abstract string ToString(object value);

public abstract string ToString(object value, IXmlNamespaceResolver nsResolver);

public abstract object ChangeType(bool value, Type destinationType);

public abstract object ChangeType(int value, Type destinationType);

public abstract object ChangeType(long value, Type destinationType);

public abstract object ChangeType(Decimal value, Type destinationType);

public abstract object ChangeType(double value, Type destinationType);

public abstract object ChangeType(DateTime value, Type destinationType);

public abstract object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver);

public abstract object ChangeType(object value, Type destinationType);

public abstract object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver);

protected void .ctor() { }

}

internal abstract class XmlBaseConverter : XmlValueConverter // TypeDefIndex: 2400
{
	private XmlSchemaType schemaType; 
	private XmlTypeCode typeCode; 
	private Type clrTypeDefault; 
	protected static readonly Type ICollectionType; 
	protected static readonly Type IEnumerableType; 
	protected static readonly Type IListType; 
	protected static readonly Type ObjectArrayType; 
	protected static readonly Type StringArrayType; 
	protected static readonly Type XmlAtomicValueArrayType; 
	protected static readonly Type DecimalType; 
	protected static readonly Type Int32Type; 
	protected static readonly Type Int64Type; 
	protected static readonly Type StringType; 
	protected static readonly Type XmlAtomicValueType; 
	protected static readonly Type ObjectType; 
	protected static readonly Type ByteType; 
	protected static readonly Type Int16Type; 
	protected static readonly Type SByteType; 
	protected static readonly Type UInt16Type; 
	protected static readonly Type UInt32Type; 
	protected static readonly Type UInt64Type; 
	protected static readonly Type XPathItemType; 
	protected static readonly Type DoubleType; 
	protected static readonly Type SingleType; 
	protected static readonly Type DateTimeType; 
	protected static readonly Type DateTimeOffsetType; 
	protected static readonly Type BooleanType; 
	protected static readonly Type ByteArrayType; 
	protected static readonly Type XmlQualifiedNameType; 
	protected static readonly Type UriType; 
	protected static readonly Type TimeSpanType; 
	protected static readonly Type XPathNavigatorType; 

protected XmlSchemaType SchemaType { get; }
protected XmlTypeCode TypeCode { get; }
protected string XmlTypeName { get; }
protected Type DefaultClrType { get; }


protected void .ctor(XmlSchemaType schemaType) { }

protected void .ctor(XmlTypeCode typeCode) { }

protected void .ctor(XmlBaseConverter converterAtomic) { }

protected void .ctor(XmlBaseConverter converterAtomic, Type clrTypeDefault) { }

public override bool ToBoolean(DateTime value) { }

public override bool ToBoolean(double value) { }

public override bool ToBoolean(int value) { }

public override bool ToBoolean(long value) { }

public override bool ToBoolean(string value) { }

public override bool ToBoolean(object value) { }

public override DateTime ToDateTime(bool value) { }

public override DateTime ToDateTime(DateTimeOffset value) { }

public override DateTime ToDateTime(double value) { }

public override DateTime ToDateTime(int value) { }

public override DateTime ToDateTime(long value) { }

public override DateTime ToDateTime(string value) { }

public override DateTime ToDateTime(object value) { }

public override DateTimeOffset ToDateTimeOffset(DateTime value) { }

public override DateTimeOffset ToDateTimeOffset(string value) { }

public override DateTimeOffset ToDateTimeOffset(object value) { }

public override Decimal ToDecimal(string value) { }

public override Decimal ToDecimal(object value) { }

public override double ToDouble(bool value) { }

public override double ToDouble(DateTime value) { }

public override double ToDouble(int value) { }

public override double ToDouble(long value) { }

public override double ToDouble(string value) { }

public override double ToDouble(object value) { }

public override int ToInt32(bool value) { }

public override int ToInt32(DateTime value) { }

public override int ToInt32(double value) { }

public override int ToInt32(long value) { }

public override int ToInt32(string value) { }

public override int ToInt32(object value) { }

public override long ToInt64(bool value) { }

public override long ToInt64(DateTime value) { }

public override long ToInt64(double value) { }

public override long ToInt64(int value) { }

public override long ToInt64(string value) { }

public override long ToInt64(object value) { }

public override float ToSingle(double value) { }

public override float ToSingle(string value) { }

public override float ToSingle(object value) { }

public override string ToString(bool value) { }

public override string ToString(DateTime value) { }

public override string ToString(DateTimeOffset value) { }

public override string ToString(Decimal value) { }

public override string ToString(double value) { }

public override string ToString(int value) { }

public override string ToString(long value) { }

public override string ToString(float value) { }

public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

public override string ToString(object value) { }

public override object ChangeType(bool value, Type destinationType) { }

public override object ChangeType(DateTime value, Type destinationType) { }

public override object ChangeType(Decimal value, Type destinationType) { }

public override object ChangeType(double value, Type destinationType) { }

public override object ChangeType(int value, Type destinationType) { }

public override object ChangeType(long value, Type destinationType) { }

public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

public override object ChangeType(object value, Type destinationType) { }

protected XmlSchemaType get_SchemaType() { }

protected XmlTypeCode get_TypeCode() { }

protected string get_XmlTypeName() { }

protected Type get_DefaultClrType() { }

protected static bool IsDerivedFrom(Type derivedType, Type baseType) { }

protected Exception CreateInvalidClrMappingException(Type sourceType, Type destinationType) { }

protected static string QNameToString(XmlQualifiedName name) { }

protected virtual object ChangeListType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

protected static byte[] StringToBase64Binary(string value) { }

protected static DateTime StringToDate(string value) { }

protected static DateTime StringToDateTime(string value) { }

protected static TimeSpan StringToDayTimeDuration(string value) { }

protected static TimeSpan StringToDuration(string value) { }

protected static DateTime StringToGDay(string value) { }

protected static DateTime StringToGMonth(string value) { }

protected static DateTime StringToGMonthDay(string value) { }

protected static DateTime StringToGYear(string value) { }

protected static DateTime StringToGYearMonth(string value) { }

protected static DateTimeOffset StringToDateOffset(string value) { }

protected static DateTimeOffset StringToDateTimeOffset(string value) { }

protected static DateTimeOffset StringToGDayOffset(string value) { }

protected static DateTimeOffset StringToGMonthOffset(string value) { }

protected static DateTimeOffset StringToGMonthDayOffset(string value) { }

protected static DateTimeOffset StringToGYearOffset(string value) { }

protected static DateTimeOffset StringToGYearMonthOffset(string value) { }

protected static byte[] StringToHexBinary(string value) { }

protected static XmlQualifiedName StringToQName(string value, IXmlNamespaceResolver nsResolver) { }

protected static DateTime StringToTime(string value) { }

protected static DateTimeOffset StringToTimeOffset(string value) { }

protected static TimeSpan StringToYearMonthDuration(string value) { }

protected static string AnyUriToString(Uri value) { }

protected static string Base64BinaryToString(byte[] value) { }

protected static string DateToString(DateTime value) { }

protected static string DateTimeToString(DateTime value) { }

protected static string DayTimeDurationToString(TimeSpan value) { }

protected static string DurationToString(TimeSpan value) { }

protected static string GDayToString(DateTime value) { }

protected static string GMonthToString(DateTime value) { }

protected static string GMonthDayToString(DateTime value) { }

protected static string GYearToString(DateTime value) { }

protected static string GYearMonthToString(DateTime value) { }

protected static string DateOffsetToString(DateTimeOffset value) { }

protected static string DateTimeOffsetToString(DateTimeOffset value) { }

protected static string GDayOffsetToString(DateTimeOffset value) { }

protected static string GMonthOffsetToString(DateTimeOffset value) { }

protected static string GMonthDayOffsetToString(DateTimeOffset value) { }

protected static string GYearOffsetToString(DateTimeOffset value) { }

protected static string GYearMonthOffsetToString(DateTimeOffset value) { }

protected static string QNameToString(XmlQualifiedName qname, IXmlNamespaceResolver nsResolver) { }

protected static string TimeToString(DateTime value) { }

protected static string TimeOffsetToString(DateTimeOffset value) { }

protected static string YearMonthDurationToString(TimeSpan value) { }

internal static DateTime DateTimeOffsetToDateTime(DateTimeOffset value) { }

internal static int DecimalToInt32(Decimal value) { }

protected static long DecimalToInt64(Decimal value) { }

protected static ulong DecimalToUInt64(Decimal value) { }

protected static byte Int32ToByte(int value) { }

protected static short Int32ToInt16(int value) { }

protected static sbyte Int32ToSByte(int value) { }

protected static ushort Int32ToUInt16(int value) { }

protected static int Int64ToInt32(long value) { }

protected static uint Int64ToUInt32(long value) { }

protected static DateTime UntypedAtomicToDateTime(string value) { }

protected static DateTimeOffset UntypedAtomicToDateTimeOffset(string value) { }

private static void .cctor() { }

}

internal class XmlNumeric10Converter : XmlBaseConverter // TypeDefIndex: 2401
{

protected void .ctor(XmlSchemaType schemaType) { }

public static XmlValueConverter Create(XmlSchemaType schemaType) { }

public override Decimal ToDecimal(string value) { }

public override Decimal ToDecimal(object value) { }

public override int ToInt32(long value) { }

public override int ToInt32(string value) { }

public override int ToInt32(object value) { }

public override long ToInt64(int value) { }

public override long ToInt64(string value) { }

public override long ToInt64(object value) { }

public override string ToString(Decimal value) { }

public override string ToString(int value) { }

public override string ToString(long value) { }

public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

public override object ChangeType(Decimal value, Type destinationType) { }

public override object ChangeType(int value, Type destinationType) { }

public override object ChangeType(long value, Type destinationType) { }

public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

private object ChangeTypeWildcardDestination(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

private object ChangeTypeWildcardSource(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

}

internal class XmlNumeric2Converter : XmlBaseConverter // TypeDefIndex: 2402
{

protected void .ctor(XmlSchemaType schemaType) { }

public static XmlValueConverter Create(XmlSchemaType schemaType) { }

public override double ToDouble(string value) { }

public override double ToDouble(object value) { }

public override float ToSingle(double value) { }

public override float ToSingle(string value) { }

public override float ToSingle(object value) { }

public override string ToString(double value) { }

public override string ToString(float value) { }

public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

public override object ChangeType(double value, Type destinationType) { }

public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

}

internal class XmlDateTimeConverter : XmlBaseConverter // TypeDefIndex: 2403
{

protected void .ctor(XmlSchemaType schemaType) { }

public static XmlValueConverter Create(XmlSchemaType schemaType) { }

public override DateTime ToDateTime(DateTimeOffset value) { }

public override DateTime ToDateTime(string value) { }

public override DateTime ToDateTime(object value) { }

public override DateTimeOffset ToDateTimeOffset(DateTime value) { }

public override DateTimeOffset ToDateTimeOffset(string value) { }

public override DateTimeOffset ToDateTimeOffset(object value) { }

public override string ToString(DateTime value) { }

public override string ToString(DateTimeOffset value) { }

public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

public override object ChangeType(DateTime value, Type destinationType) { }

public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

}

internal class XmlBooleanConverter : XmlBaseConverter // TypeDefIndex: 2404
{

protected void .ctor(XmlSchemaType schemaType) { }

public static XmlValueConverter Create(XmlSchemaType schemaType) { }

public override bool ToBoolean(string value) { }

public override bool ToBoolean(object value) { }

public override string ToString(bool value) { }

public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

public override object ChangeType(bool value, Type destinationType) { }

public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

}

internal class XmlMiscConverter : XmlBaseConverter // TypeDefIndex: 2405
{

protected void .ctor(XmlSchemaType schemaType) { }

public static XmlValueConverter Create(XmlSchemaType schemaType) { }

public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

private object ChangeTypeWildcardDestination(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

private object ChangeTypeWildcardSource(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

}

internal class XmlStringConverter : XmlBaseConverter // TypeDefIndex: 2406
{

protected void .ctor(XmlSchemaType schemaType) { }

public static XmlValueConverter Create(XmlSchemaType schemaType) { }

public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

}

internal class XmlUntypedConverter : XmlListConverter // TypeDefIndex: 2407
{
	private bool allowListToList; 
	public static readonly XmlValueConverter Untyped; 
	public static readonly XmlValueConverter UntypedList; 


protected void .ctor() { }

protected void .ctor(XmlUntypedConverter atomicConverter, bool allowListToList) { }

public override bool ToBoolean(string value) { }

public override bool ToBoolean(object value) { }

public override DateTime ToDateTime(string value) { }

public override DateTime ToDateTime(object value) { }

public override DateTimeOffset ToDateTimeOffset(string value) { }

public override DateTimeOffset ToDateTimeOffset(object value) { }

public override Decimal ToDecimal(string value) { }

public override Decimal ToDecimal(object value) { }

public override double ToDouble(string value) { }

public override double ToDouble(object value) { }

public override int ToInt32(string value) { }

public override int ToInt32(object value) { }

public override long ToInt64(string value) { }

public override long ToInt64(object value) { }

public override float ToSingle(string value) { }

public override float ToSingle(object value) { }

public override string ToString(bool value) { }

public override string ToString(DateTime value) { }

public override string ToString(DateTimeOffset value) { }

public override string ToString(Decimal value) { }

public override string ToString(double value) { }

public override string ToString(int value) { }

public override string ToString(long value) { }

public override string ToString(float value) { }

public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

public override object ChangeType(bool value, Type destinationType) { }

public override object ChangeType(DateTime value, Type destinationType) { }

public override object ChangeType(Decimal value, Type destinationType) { }

public override object ChangeType(double value, Type destinationType) { }

public override object ChangeType(int value, Type destinationType) { }

public override object ChangeType(long value, Type destinationType) { }

public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

private object ChangeTypeWildcardDestination(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

private object ChangeTypeWildcardSource(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

protected override object ChangeListType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

private bool SupportsType(Type clrType) { }

private static void .cctor() { }

}

internal class XmlAnyConverter : XmlBaseConverter // TypeDefIndex: 2408
{
	public static readonly XmlValueConverter Item; 
	public static readonly XmlValueConverter AnyAtomic; 


protected void .ctor(XmlTypeCode typeCode) { }

public override bool ToBoolean(object value) { }

public override DateTime ToDateTime(object value) { }

public override DateTimeOffset ToDateTimeOffset(object value) { }

public override Decimal ToDecimal(object value) { }

public override double ToDouble(object value) { }

public override int ToInt32(object value) { }

public override long ToInt64(object value) { }

public override float ToSingle(object value) { }

public override object ChangeType(bool value, Type destinationType) { }

public override object ChangeType(DateTime value, Type destinationType) { }

public override object ChangeType(Decimal value, Type destinationType) { }

public override object ChangeType(double value, Type destinationType) { }

public override object ChangeType(int value, Type destinationType) { }

public override object ChangeType(long value, Type destinationType) { }

public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

private object ChangeTypeWildcardDestination(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

private object ChangeTypeWildcardSource(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

private XPathNavigator ToNavigator(XPathNavigator nav) { }

private static void .cctor() { }

}

internal class XmlAnyListConverter : XmlListConverter // TypeDefIndex: 2409
{
	public static readonly XmlValueConverter ItemList; 
	public static readonly XmlValueConverter AnyAtomicList; 


protected void .ctor(XmlBaseConverter atomicConverter) { }

public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

private static void .cctor() { }

}

internal class XmlListConverter : XmlBaseConverter // TypeDefIndex: 2410
{
	protected XmlValueConverter atomicConverter; 


protected void .ctor(XmlBaseConverter atomicConverter) { }

protected void .ctor(XmlBaseConverter atomicConverter, Type clrTypeDefault) { }

protected void .ctor(XmlSchemaType schemaType) { }

public static XmlValueConverter Create(XmlValueConverter atomicConverter) { }

public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

protected override object ChangeListType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

private bool IsListType(Type type) { }

private T[] ToArray<T>(object list, IXmlNamespaceResolver nsResolver) { }
/* GenericInstMethod :
|
|-XmlListConverter.ToArray<bool>
|
|-XmlListConverter.ToArray<byte>
|
|-XmlListConverter.ToArray<byte[]>
|-XmlListConverter.ToArray<object>
|-XmlListConverter.ToArray<string>
|-XmlListConverter.ToArray<Uri>
|-XmlListConverter.ToArray<XmlAtomicValue>
|-XmlListConverter.ToArray<XPathItem>
|-XmlListConverter.ToArray<XPathNavigator>
|-XmlListConverter.ToArray<XmlQualifiedName>
|
|-XmlListConverter.ToArray<DateTime>
|
|-XmlListConverter.ToArray<DateTimeOffset>
|
|-XmlListConverter.ToArray<Decimal>
|
|-XmlListConverter.ToArray<double>
|
|-XmlListConverter.ToArray<short>
|
|-XmlListConverter.ToArray<int>
|
|-XmlListConverter.ToArray<long>
|
|-XmlListConverter.ToArray<sbyte>
|
|-XmlListConverter.ToArray<float>
|
|-XmlListConverter.ToArray<TimeSpan>
|
|-XmlListConverter.ToArray<ushort>
|
|-XmlListConverter.ToArray<uint>
|
|-XmlListConverter.ToArray<ulong>
*/

private IList ToList(object list, IXmlNamespaceResolver nsResolver) { }

private List<string> StringAsList(string value) { }

private string ListAsString(IEnumerable list, IXmlNamespaceResolver nsResolver) { }

private Exception CreateInvalidClrMappingException(Type sourceType, Type destinationType) { }

}

internal class XmlUnionConverter : XmlBaseConverter // TypeDefIndex: 2411
{
	private XmlValueConverter[] converters; 
	private bool hasAtomicMember; 
	private bool hasListMember; 


protected void .ctor(XmlSchemaType schemaType) { }

public static XmlValueConverter Create(XmlSchemaType schemaType) { }

public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

}

internal sealed class XsdBuilder : SchemaBuilder // TypeDefIndex: 2412
{
	private static readonly XsdBuilder.State[] SchemaElement; 
	private static readonly XsdBuilder.State[] SchemaSubelements; 
	private static readonly XsdBuilder.State[] AttributeSubelements; 
	private static readonly XsdBuilder.State[] ElementSubelements; 
	private static readonly XsdBuilder.State[] ComplexTypeSubelements; 
	private static readonly XsdBuilder.State[] SimpleContentSubelements; 
	private static readonly XsdBuilder.State[] SimpleContentExtensionSubelements; 
	private static readonly XsdBuilder.State[] SimpleContentRestrictionSubelements; 
	private static readonly XsdBuilder.State[] ComplexContentSubelements; 
	private static readonly XsdBuilder.State[] ComplexContentExtensionSubelements; 
	private static readonly XsdBuilder.State[] ComplexContentRestrictionSubelements; 
	private static readonly XsdBuilder.State[] SimpleTypeSubelements; 
	private static readonly XsdBuilder.State[] SimpleTypeRestrictionSubelements; 
	private static readonly XsdBuilder.State[] SimpleTypeListSubelements; 
	private static readonly XsdBuilder.State[] SimpleTypeUnionSubelements; 
	private static readonly XsdBuilder.State[] RedefineSubelements; 
	private static readonly XsdBuilder.State[] AttributeGroupSubelements; 
	private static readonly XsdBuilder.State[] GroupSubelements; 
	private static readonly XsdBuilder.State[] AllSubelements; 
	private static readonly XsdBuilder.State[] ChoiceSequenceSubelements; 
	private static readonly XsdBuilder.State[] IdentityConstraintSubelements; 
	private static readonly XsdBuilder.State[] AnnotationSubelements; 
	private static readonly XsdBuilder.State[] AnnotatedSubelements; 
	private static readonly XsdBuilder.XsdAttributeEntry[] SchemaAttributes; 
	private static readonly XsdBuilder.XsdAttributeEntry[] AttributeAttributes; 
	private static readonly XsdBuilder.XsdAttributeEntry[] ElementAttributes; 
	private static readonly XsdBuilder.XsdAttributeEntry[] ComplexTypeAttributes; 
	private static readonly XsdBuilder.XsdAttributeEntry[] SimpleContentAttributes; 
	private static readonly XsdBuilder.XsdAttributeEntry[] SimpleContentExtensionAttributes; 
	private static readonly XsdBuilder.XsdAttributeEntry[] SimpleContentRestrictionAttributes; 
	private static readonly XsdBuilder.XsdAttributeEntry[] ComplexContentAttributes; 
	private static readonly XsdBuilder.XsdAttributeEntry[] ComplexContentExtensionAttributes; 
	private static readonly XsdBuilder.XsdAttributeEntry[] ComplexContentRestrictionAttributes; 
	private static readonly XsdBuilder.XsdAttributeEntry[] SimpleTypeAttributes; 
	private static readonly XsdBuilder.XsdAttributeEntry[] SimpleTypeRestrictionAttributes; 
	private static readonly XsdBuilder.XsdAttributeEntry[] SimpleTypeUnionAttributes; 
	private static readonly XsdBuilder.XsdAttributeEntry[] SimpleTypeListAttributes; 
	private static readonly XsdBuilder.XsdAttributeEntry[] AttributeGroupAttributes; 
	private static readonly XsdBuilder.XsdAttributeEntry[] AttributeGroupRefAttributes; 
	private static readonly XsdBuilder.XsdAttributeEntry[] GroupAttributes; 
	private static readonly XsdBuilder.XsdAttributeEntry[] GroupRefAttributes; 
	private static readonly XsdBuilder.XsdAttributeEntry[] ParticleAttributes; 
	private static readonly XsdBuilder.XsdAttributeEntry[] AnyAttributes; 
	private static readonly XsdBuilder.XsdAttributeEntry[] IdentityConstraintAttributes; 
	private static readonly XsdBuilder.XsdAttributeEntry[] SelectorAttributes; 
	private static readonly XsdBuilder.XsdAttributeEntry[] FieldAttributes; 
	private static readonly XsdBuilder.XsdAttributeEntry[] NotationAttributes; 
	private static readonly XsdBuilder.XsdAttributeEntry[] IncludeAttributes; 
	private static readonly XsdBuilder.XsdAttributeEntry[] ImportAttributes; 
	private static readonly XsdBuilder.XsdAttributeEntry[] FacetAttributes; 
	private static readonly XsdBuilder.XsdAttributeEntry[] AnyAttributeAttributes; 
	private static readonly XsdBuilder.XsdAttributeEntry[] DocumentationAttributes; 
	private static readonly XsdBuilder.XsdAttributeEntry[] AppinfoAttributes; 
	private static readonly XsdBuilder.XsdAttributeEntry[] RedefineAttributes; 
	private static readonly XsdBuilder.XsdAttributeEntry[] AnnotationAttributes; 
	private static readonly XsdBuilder.XsdEntry[] SchemaEntries; 
	private static readonly int[] DerivationMethodValues; 
	private static readonly string[] DerivationMethodStrings; 
	private static readonly string[] FormStringValues; 
	private static readonly string[] UseStringValues; 
	private static readonly string[] ProcessContentsStringValues; 
	private XmlReader reader; 
	private PositionInfo positionInfo; 
	private XsdBuilder.XsdEntry currentEntry; 
	private XsdBuilder.XsdEntry nextEntry; 
	private bool hasChild; 
	private HWStack stateHistory; 
	private Stack containerStack; 
	private XmlNameTable nameTable; 
	private SchemaNames schemaNames; 
	private XmlNamespaceManager namespaceManager; 
	private bool canIncludeImport; 
	private XmlSchema schema; 
	private XmlSchemaObject xso; 
	private XmlSchemaElement element; 
	private XmlSchemaAny anyElement; 
	private XmlSchemaAttribute attribute; 
	private XmlSchemaAnyAttribute anyAttribute; 
	private XmlSchemaComplexType complexType; 
	private XmlSchemaSimpleType simpleType; 
	private XmlSchemaComplexContent complexContent; 
	private XmlSchemaComplexContentExtension complexContentExtension; 
	private XmlSchemaComplexContentRestriction complexContentRestriction; 
	private XmlSchemaSimpleContent simpleContent; 
	private XmlSchemaSimpleContentExtension simpleContentExtension; 
	private XmlSchemaSimpleContentRestriction simpleContentRestriction; 
	private XmlSchemaSimpleTypeUnion simpleTypeUnion; 
	private XmlSchemaSimpleTypeList simpleTypeList; 
	private XmlSchemaSimpleTypeRestriction simpleTypeRestriction; 
	private XmlSchemaGroup group; 
	private XmlSchemaGroupRef groupRef; 
	private XmlSchemaAll all; 
	private XmlSchemaChoice choice; 
	private XmlSchemaSequence sequence; 
	private XmlSchemaParticle particle; 
	private XmlSchemaAttributeGroup attributeGroup; 
	private XmlSchemaAttributeGroupRef attributeGroupRef; 
	private XmlSchemaNotation notation; 
	private XmlSchemaIdentityConstraint identityConstraint; 
	private XmlSchemaXPath xpath; 
	private XmlSchemaInclude include; 
	private XmlSchemaImport import; 
	private XmlSchemaAnnotation annotation; 
	private XmlSchemaAppInfo appInfo; 
	private XmlSchemaDocumentation documentation; 
	private XmlSchemaFacet facet; 
	private XmlNode[] markup; 
	private XmlSchemaRedefine redefine; 
	private ValidationEventHandler validationEventHandler; 
	private ArrayList unhandledAttributes; 
	private Hashtable namespaces; 

private SchemaNames.Token CurrentElement { get; }
private SchemaNames.Token ParentElement { get; }
private XmlSchemaObject ParentContainer { get; }


internal void .ctor(XmlReader reader, XmlNamespaceManager curmgr, XmlSchema schema, XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventhandler) { }

internal override bool ProcessElement(string prefix, string name, string ns) { }

internal override void ProcessAttribute(string prefix, string name, string ns, string value) { }

internal override bool IsContentParsed() { }

internal override void ProcessMarkup(XmlNode[] markup) { }

internal override void ProcessCData(string value) { }

internal override void StartChildren() { }

internal override void EndChildren() { }

private void Push() { }

private void Pop() { }

private SchemaNames.Token get_CurrentElement() { }

private SchemaNames.Token get_ParentElement() { }

private XmlSchemaObject get_ParentContainer() { }

private XmlSchemaObject GetContainer(XsdBuilder.State state) { }

private void SetContainer(XsdBuilder.State state, object container) { }

private static void BuildAnnotated_Id(XsdBuilder builder, string value) { }

private static void BuildSchema_AttributeFormDefault(XsdBuilder builder, string value) { }

private static void BuildSchema_ElementFormDefault(XsdBuilder builder, string value) { }

private static void BuildSchema_TargetNamespace(XsdBuilder builder, string value) { }

private static void BuildSchema_Version(XsdBuilder builder, string value) { }

private static void BuildSchema_FinalDefault(XsdBuilder builder, string value) { }

private static void BuildSchema_BlockDefault(XsdBuilder builder, string value) { }

private static void InitSchema(XsdBuilder builder, string value) { }

private static void InitInclude(XsdBuilder builder, string value) { }

private static void BuildInclude_SchemaLocation(XsdBuilder builder, string value) { }

private static void InitImport(XsdBuilder builder, string value) { }

private static void BuildImport_Namespace(XsdBuilder builder, string value) { }

private static void BuildImport_SchemaLocation(XsdBuilder builder, string value) { }

private static void InitRedefine(XsdBuilder builder, string value) { }

private static void BuildRedefine_SchemaLocation(XsdBuilder builder, string value) { }

private static void EndRedefine(XsdBuilder builder) { }

private static void InitAttribute(XsdBuilder builder, string value) { }

private static void BuildAttribute_Default(XsdBuilder builder, string value) { }

private static void BuildAttribute_Fixed(XsdBuilder builder, string value) { }

private static void BuildAttribute_Form(XsdBuilder builder, string value) { }

private static void BuildAttribute_Use(XsdBuilder builder, string value) { }

private static void BuildAttribute_Ref(XsdBuilder builder, string value) { }

private static void BuildAttribute_Name(XsdBuilder builder, string value) { }

private static void BuildAttribute_Type(XsdBuilder builder, string value) { }

private static void InitElement(XsdBuilder builder, string value) { }

private static void BuildElement_Abstract(XsdBuilder builder, string value) { }

private static void BuildElement_Block(XsdBuilder builder, string value) { }

private static void BuildElement_Default(XsdBuilder builder, string value) { }

private static void BuildElement_Form(XsdBuilder builder, string value) { }

private static void BuildElement_SubstitutionGroup(XsdBuilder builder, string value) { }

private static void BuildElement_Final(XsdBuilder builder, string value) { }

private static void BuildElement_Fixed(XsdBuilder builder, string value) { }

private static void BuildElement_MaxOccurs(XsdBuilder builder, string value) { }

private static void BuildElement_MinOccurs(XsdBuilder builder, string value) { }

private static void BuildElement_Name(XsdBuilder builder, string value) { }

private static void BuildElement_Nillable(XsdBuilder builder, string value) { }

private static void BuildElement_Ref(XsdBuilder builder, string value) { }

private static void BuildElement_Type(XsdBuilder builder, string value) { }

private static void InitSimpleType(XsdBuilder builder, string value) { }

private static void BuildSimpleType_Name(XsdBuilder builder, string value) { }

private static void BuildSimpleType_Final(XsdBuilder builder, string value) { }

private static void InitSimpleTypeUnion(XsdBuilder builder, string value) { }

private static void BuildSimpleTypeUnion_MemberTypes(XsdBuilder builder, string value) { }

private static void InitSimpleTypeList(XsdBuilder builder, string value) { }

private static void BuildSimpleTypeList_ItemType(XsdBuilder builder, string value) { }

private static void InitSimpleTypeRestriction(XsdBuilder builder, string value) { }

private static void BuildSimpleTypeRestriction_Base(XsdBuilder builder, string value) { }

private static void InitComplexType(XsdBuilder builder, string value) { }

private static void BuildComplexType_Abstract(XsdBuilder builder, string value) { }

private static void BuildComplexType_Block(XsdBuilder builder, string value) { }

private static void BuildComplexType_Final(XsdBuilder builder, string value) { }

private static void BuildComplexType_Mixed(XsdBuilder builder, string value) { }

private static void BuildComplexType_Name(XsdBuilder builder, string value) { }

private static void InitComplexContent(XsdBuilder builder, string value) { }

private static void BuildComplexContent_Mixed(XsdBuilder builder, string value) { }

private static void InitComplexContentExtension(XsdBuilder builder, string value) { }

private static void BuildComplexContentExtension_Base(XsdBuilder builder, string value) { }

private static void InitComplexContentRestriction(XsdBuilder builder, string value) { }

private static void BuildComplexContentRestriction_Base(XsdBuilder builder, string value) { }

private static void InitSimpleContent(XsdBuilder builder, string value) { }

private static void InitSimpleContentExtension(XsdBuilder builder, string value) { }

private static void BuildSimpleContentExtension_Base(XsdBuilder builder, string value) { }

private static void InitSimpleContentRestriction(XsdBuilder builder, string value) { }

private static void BuildSimpleContentRestriction_Base(XsdBuilder builder, string value) { }

private static void InitAttributeGroup(XsdBuilder builder, string value) { }

private static void BuildAttributeGroup_Name(XsdBuilder builder, string value) { }

private static void InitAttributeGroupRef(XsdBuilder builder, string value) { }

private static void BuildAttributeGroupRef_Ref(XsdBuilder builder, string value) { }

private static void InitAnyAttribute(XsdBuilder builder, string value) { }

private static void BuildAnyAttribute_Namespace(XsdBuilder builder, string value) { }

private static void BuildAnyAttribute_ProcessContents(XsdBuilder builder, string value) { }

private static void InitGroup(XsdBuilder builder, string value) { }

private static void BuildGroup_Name(XsdBuilder builder, string value) { }

private static void InitGroupRef(XsdBuilder builder, string value) { }

private static void BuildParticle_MaxOccurs(XsdBuilder builder, string value) { }

private static void BuildParticle_MinOccurs(XsdBuilder builder, string value) { }

private static void BuildGroupRef_Ref(XsdBuilder builder, string value) { }

private static void InitAll(XsdBuilder builder, string value) { }

private static void InitChoice(XsdBuilder builder, string value) { }

private static void InitSequence(XsdBuilder builder, string value) { }

private static void InitAny(XsdBuilder builder, string value) { }

private static void BuildAny_Namespace(XsdBuilder builder, string value) { }

private static void BuildAny_ProcessContents(XsdBuilder builder, string value) { }

private static void InitNotation(XsdBuilder builder, string value) { }

private static void BuildNotation_Name(XsdBuilder builder, string value) { }

private static void BuildNotation_Public(XsdBuilder builder, string value) { }

private static void BuildNotation_System(XsdBuilder builder, string value) { }

private static void InitFacet(XsdBuilder builder, string value) { }

private static void BuildFacet_Fixed(XsdBuilder builder, string value) { }

private static void BuildFacet_Value(XsdBuilder builder, string value) { }

private static void InitIdentityConstraint(XsdBuilder builder, string value) { }

private static void BuildIdentityConstraint_Name(XsdBuilder builder, string value) { }

private static void BuildIdentityConstraint_Refer(XsdBuilder builder, string value) { }

private static void InitSelector(XsdBuilder builder, string value) { }

private static void BuildSelector_XPath(XsdBuilder builder, string value) { }

private static void InitField(XsdBuilder builder, string value) { }

private static void BuildField_XPath(XsdBuilder builder, string value) { }

private static void InitAnnotation(XsdBuilder builder, string value) { }

private static void InitAppinfo(XsdBuilder builder, string value) { }

private static void BuildAppinfo_Source(XsdBuilder builder, string value) { }

private static void EndAppinfo(XsdBuilder builder) { }

private static void InitDocumentation(XsdBuilder builder, string value) { }

private static void BuildDocumentation_Source(XsdBuilder builder, string value) { }

private static void BuildDocumentation_XmlLang(XsdBuilder builder, string value) { }

private static void EndDocumentation(XsdBuilder builder) { }

private void AddAttribute(XmlSchemaObject value) { }

private void AddParticle(XmlSchemaParticle particle) { }

private bool GetNextState(XmlQualifiedName qname) { }

private bool IsSkipableElement(XmlQualifiedName qname) { }

private void SetMinOccurs(XmlSchemaParticle particle, string value) { }

private void SetMaxOccurs(XmlSchemaParticle particle, string value) { }

private bool ParseBoolean(string value, string attributeName) { }

private int ParseEnum(string value, string attributeName, string[] values) { }

private XmlQualifiedName ParseQName(string value, string attributeName) { }

private int ParseBlockFinalEnum(string value, string attributeName) { }

private static string ParseUriReference(string s) { }

private void SendValidationEvent(string code, string arg0, string arg1, string arg2) { }

private void SendValidationEvent(string code, string msg) { }

private void SendValidationEvent(string code, string[] args, XmlSeverityType severity) { }

private void SendValidationEvent(XmlSchemaException e, XmlSeverityType severity) { }

private void SendValidationEvent(XmlSchemaException e) { }

private void RecordPosition() { }

private static void .cctor() { }

}

private enum XsdBuilder.State // TypeDefIndex: 2413
{
	public int value__; 
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
{

public void .ctor(object object, IntPtr method) { }

public virtual void Invoke(XsdBuilder builder, string value) { }

public virtual IAsyncResult BeginInvoke(XsdBuilder builder, string value, AsyncCallback callback, object object) { }

public virtual void EndInvoke(IAsyncResult result) { }

}

private sealed class XsdBuilder.XsdInitFunction : MulticastDelegate // TypeDefIndex: 2415
{

public void .ctor(object object, IntPtr method) { }

public virtual void Invoke(XsdBuilder builder, string value) { }

public virtual IAsyncResult BeginInvoke(XsdBuilder builder, string value, AsyncCallback callback, object object) { }

public virtual void EndInvoke(IAsyncResult result) { }

}

private sealed class XsdBuilder.XsdEndChildFunction : MulticastDelegate // TypeDefIndex: 2416
{

public void .ctor(object object, IntPtr method) { }

public virtual void Invoke(XsdBuilder builder) { }

public virtual IAsyncResult BeginInvoke(XsdBuilder builder, AsyncCallback callback, object object) { }

public virtual void EndInvoke(IAsyncResult result) { }

}

private sealed class XsdBuilder.XsdAttributeEntry // TypeDefIndex: 2417
{
	public SchemaNames.Token Attribute; 
	public XsdBuilder.XsdBuildFunction BuildFunc; 


public void .ctor(SchemaNames.Token a, XsdBuilder.XsdBuildFunction build) { }

}

private sealed class XsdBuilder.XsdEntry // TypeDefIndex: 2418
{
	public SchemaNames.Token Name; 
	public XsdBuilder.State CurrentState; 
	public XsdBuilder.State[] NextStates; 
	public XsdBuilder.XsdAttributeEntry[] Attributes; 
	public XsdBuilder.XsdInitFunction InitFunc; 
	public XsdBuilder.XsdEndChildFunction EndChildFunc; 
	public bool ParseContent; 


public void .ctor(SchemaNames.Token n, XsdBuilder.State state, XsdBuilder.State[] nextStates, XsdBuilder.XsdAttributeEntry[] attributes, XsdBuilder.XsdInitFunction init, XsdBuilder.XsdEndChildFunction end, bool parseContent) { }

}

private class XsdBuilder.BuilderNamespaceManager : XmlNamespaceManager // TypeDefIndex: 2419
{
	private XmlNamespaceManager nsMgr; 
	private XmlReader reader; 


public void .ctor(XmlNamespaceManager nsMgr, XmlReader reader) { }

public override string LookupNamespace(string prefix) { }

}

internal enum XsdDateTimeFlags // TypeDefIndex: 2420
{
	public int value__; 
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
{
	private DateTime dt; 
	private uint extra; 
	private static readonly int Lzyyyy; 
	private static readonly int Lzyyyy_; 
	private static readonly int Lzyyyy_MM; 
	private static readonly int Lzyyyy_MM_; 
	private static readonly int Lzyyyy_MM_dd; 
	private static readonly int Lzyyyy_MM_ddT; 
	private static readonly int LzHH; 
	private static readonly int LzHH_; 
	private static readonly int LzHH_mm; 
	private static readonly int LzHH_mm_; 
	private static readonly int LzHH_mm_ss; 
	private static readonly int Lz_; 
	private static readonly int Lz_zz; 
	private static readonly int Lz_zz_; 
	private static readonly int Lz_zz_zz; 
	private static readonly int Lz__; 
	private static readonly int Lz__mm; 
	private static readonly int Lz__mm_; 
	private static readonly int Lz__mm__; 
	private static readonly int Lz__mm_dd; 
	private static readonly int Lz___; 
	private static readonly int Lz___dd; 
	private static readonly XmlTypeCode[] typeCodes; 

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


public void .ctor(string text, XsdDateTimeFlags kinds) { }

private void .ctor(XsdDateTime.Parser parser) { }

private void InitiateXsdDateTime(XsdDateTime.Parser parser) { }

internal static bool TryParse(string text, XsdDateTimeFlags kinds, out XsdDateTime result) { }

public void .ctor(DateTime dateTime, XsdDateTimeFlags kinds) { }

public void .ctor(DateTimeOffset dateTimeOffset) { }

public void .ctor(DateTimeOffset dateTimeOffset, XsdDateTimeFlags kinds) { }

private XsdDateTime.DateTimeTypeCode get_InternalTypeCode() { }

private XsdDateTime.XsdDateTimeKind get_InternalKind() { }

public int get_Year() { }

public int get_Month() { }

public int get_Day() { }

public int get_Hour() { }

public int get_Minute() { }

public int get_Second() { }

public int get_Fraction() { }

public int get_ZoneHour() { }

public int get_ZoneMinute() { }

public static DateTime op_Implicit(XsdDateTime xdt) { }

public static DateTimeOffset op_Implicit(XsdDateTime xdt) { }

public override string ToString() { }

private void PrintDate(StringBuilder sb) { }

private void PrintTime(StringBuilder sb) { }

private void PrintZone(StringBuilder sb) { }

private void IntToCharArray(char[] text, int start, int value, int digits) { }

private void ShortToCharArray(char[] text, int start, int value) { }

private static void .cctor() { }

}

private enum XsdDateTime.DateTimeTypeCode // TypeDefIndex: 2422
{
	public int value__; 
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
{
	public int value__; 
public const XsdDateTime.XsdDateTimeKind Unspecified = 0;
public const XsdDateTime.XsdDateTimeKind Zulu = 1;
public const XsdDateTime.XsdDateTimeKind LocalWestOfZulu = 2;
public const XsdDateTime.XsdDateTimeKind LocalEastOfZulu = 3;

}

private struct XsdDateTime.Parser // TypeDefIndex: 2424
{
	public XsdDateTime.DateTimeTypeCode typeCode; 
	public int year; 
	public int month; 
	public int day; 
	public int hour; 
	public int minute; 
	public int second; 
	public int fraction; 
	public XsdDateTime.XsdDateTimeKind kind; 
	public int zoneHour; 
	public int zoneMinute; 
	private string text; 
	private int length; 
	private static int[] Power10; 


public bool Parse(string text, XsdDateTimeFlags kinds) { }

private bool ParseDate(int start) { }

private bool ParseTimeAndZoneAndWhitespace(int start) { }

private bool ParseTimeAndWhitespace(int start) { }

private bool ParseTime(ref int start) { }

private bool ParseZoneAndWhitespace(int start) { }

private bool Parse4Dig(int start, ref int num) { }

private bool Parse2Dig(int start, ref int num) { }

private bool ParseChar(int start, char ch) { }

private static bool Test(XsdDateTimeFlags left, XsdDateTimeFlags right) { }

private static void .cctor() { }

}

internal struct XsdDuration // TypeDefIndex: 2425
{
	private int years; 
	private int months; 
	private int days; 
	private int hours; 
	private int minutes; 
	private int seconds; 
	private uint nanoseconds; 

public bool IsNegative { get; }
public int Years { get; }
public int Months { get; }
public int Days { get; }
public int Hours { get; }
public int Minutes { get; }
public int Seconds { get; }
public int Nanoseconds { get; }


public void .ctor(bool isNegative, int years, int months, int days, int hours, int minutes, int seconds, int nanoseconds) { }

public void .ctor(TimeSpan timeSpan) { }

public void .ctor(TimeSpan timeSpan, XsdDuration.DurationType durationType) { }

public void .ctor(string s) { }

public void .ctor(string s, XsdDuration.DurationType durationType) { }

public bool get_IsNegative() { }

public int get_Years() { }

public int get_Months() { }

public int get_Days() { }

public int get_Hours() { }

public int get_Minutes() { }

public int get_Seconds() { }

public int get_Nanoseconds() { }

public TimeSpan ToTimeSpan() { }

public TimeSpan ToTimeSpan(XsdDuration.DurationType durationType) { }

internal Exception TryToTimeSpan(out TimeSpan result) { }

internal Exception TryToTimeSpan(XsdDuration.DurationType durationType, out TimeSpan result) { }

public override string ToString() { }

internal string ToString(XsdDuration.DurationType durationType) { }

internal static Exception TryParse(string s, out XsdDuration result) { }

internal static Exception TryParse(string s, XsdDuration.DurationType durationType, out XsdDuration result) { }

private static string TryParseDigits(string s, ref int offset, bool eatDigits, out int result, out int numDigits) { }

}

private enum XsdDuration.Parts // TypeDefIndex: 2426
{
	public int value__; 
public const XsdDuration.Parts HasNone = 0;
public const XsdDuration.Parts HasYears = 1;
public const XsdDuration.Parts HasMonths = 2;
public const XsdDuration.Parts HasDays = 4;
public const XsdDuration.Parts HasHours = 8;
public const XsdDuration.Parts HasMinutes = 16;
public const XsdDuration.Parts HasSeconds = 32;

}

public enum XsdDuration.DurationType // TypeDefIndex: 2427
{
	public int value__; 
public const XsdDuration.DurationType Duration = 0;
public const XsdDuration.DurationType YearMonthDuration = 1;
public const XsdDuration.DurationType DayTimeDuration = 2;

}

internal sealed class XsdValidator : BaseValidator // TypeDefIndex: 2428
{
	private int startIDConstraint; 
	private HWStack validationStack; 
	private Hashtable attPresence; 
	private XmlNamespaceManager nsManager; 
	private bool bManageNamespaces; 
	private Hashtable IDs; 
	private IdRefNode idRefListHead; 
	private Parser inlineSchemaParser; 
	private XmlSchemaContentProcessing processContents; 
	private static readonly XmlSchemaDatatype dtCDATA; 
	private static readonly XmlSchemaDatatype dtQName; 
	private static readonly XmlSchemaDatatype dtStringArray; 
	private string NsXmlNs; 
	private string NsXs; 
	private string NsXsi; 
	private string XsiType; 
	private string XsiNil; 
	private string XsiSchemaLocation; 
	private string XsiNoNamespaceSchemaLocation; 
	private string XsdSchema; 

private bool IsInlineSchemaStarted { get; }
private bool HasSchema { get; }
public override bool PreserveWhitespace { get; }
private bool HasIdentityConstraints { get; }


internal void .ctor(BaseValidator validator) { }

internal void .ctor(XmlValidatingReaderImpl reader, XmlSchemaCollection schemaCollection, IValidationEventHandling eventHandling) { }

private void Init() { }

public override void Validate() { }

public override void CompleteValidation() { }

private bool get_IsInlineSchemaStarted() { }

private void ProcessInlineSchema() { }

private void ValidateElement() { }

private object ValidateChildElement() { }

private void ProcessElement(object particle) { }

private void ProcessXsiAttributes(out XmlQualifiedName xsiType, out string xsiNil) { }

private void ValidateEndElement() { }

private SchemaElementDecl FastGetElementDecl(object particle) { }

private SchemaElementDecl ThoroughGetElementDecl(SchemaElementDecl elementDecl, XmlQualifiedName xsiType, string xsiNil) { }

private void ValidateStartElement() { }

private void ValidateEndStartElement() { }

private void LoadSchemaFromLocation(string uri, string url) { }

private void LoadSchema(string uri, string url) { }

private bool get_HasSchema() { }

public override bool get_PreserveWhitespace() { }

private void ProcessTokenizedType(XmlTokenizedType ttype, string name) { }

private void CheckValue(string value, SchemaAttDef attdef) { }

internal void AddID(string name, object node) { }

public override object FindId(string name) { }

public bool IsXSDRoot(string localName, string ns) { }

private void Push(XmlQualifiedName elementName) { }

private void Pop() { }

private void CheckForwardRefs() { }

private void ValidateStartElementIdentityConstraints() { }

private bool get_HasIdentityConstraints() { }

private void AddIdentityConstraints() { }

private void ElementIdentityConstraints() { }

private void AttributeIdentityConstraints(string name, string ns, object obj, string sobj, SchemaAttDef attdef) { }

private object UnWrapUnion(object typedValue) { }

private void EndElementIdentityConstraints() { }

private static void .cctor() { }

}

public sealed class XmlReaderSection // TypeDefIndex: 2429
{
internal static bool ProhibitDefaultUrlResolver { get; }
internal static bool CollapseWhiteSpaceIntoEmptyString { get; }


internal static bool get_ProhibitDefaultUrlResolver() { }

internal static XmlResolver CreateDefaultResolver() { }

internal static bool get_CollapseWhiteSpaceIntoEmptyString() { }

}

public enum XRNode // TypeDefIndex: 4139
{
	public int value__; 
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
{
	private XRNode m_Type; 
	private AvailableTrackingData m_AvailableFields; 
	private Vector3 m_Position; 
	private Quaternion m_Rotation; 
	private Vector3 m_Velocity; 
	private Vector3 m_AngularVelocity; 
	private Vector3 m_Acceleration; 
	private Vector3 m_AngularAcceleration; 
	private int m_Tracked; 
	private ulong m_UniqueID; 

public ulong uniqueID { set; }
public XRNode nodeType { set; }
public bool tracked { set; }


public void set_uniqueID(ulong value) { }

public void set_nodeType(XRNode value) { }

public void set_tracked(bool value) { }

}

public class XRDisplaySubsystem : IntegratedSubsystem<XRDisplaySubsystemDescriptor> // TypeDefIndex: 4150
{
	[CompilerGeneratedAttribute] 
	[DebuggerBrowsableAttribute] 
	private static Action<bool> displayFocusChanged; 


	[RequiredByNativeCodeAttribute] 
private static void InvokeDisplayFocusChanged(bool focus) { }

public void .ctor() { }

}

public struct XRDisplaySubsystem.XRRenderPass // TypeDefIndex: 4151
{
	private IntPtr displaySubsystemInstance; 
	public int renderPassIndex; 
	public RenderTargetIdentifier renderTarget; 
	public RenderTextureDescriptor renderTargetDesc; 
	public bool shouldFillOutDepth; 
	public int cullingPassIndex; 

}

public struct XRDisplaySubsystem.XRMirrorViewBlitDesc // TypeDefIndex: 4152
{
	private IntPtr displaySubsystemInstance; 
	public bool nativeBlitAvailable; 
	public bool nativeBlitInvalidStates; 
	public int blitParamsCount; 

}

public class XRDisplaySubsystemDescriptor : IntegratedSubsystemDescriptor<XRDisplaySubsystem> // TypeDefIndex: 4153
{

public void .ctor() { }

}

public class XRInputSubsystem : IntegratedSubsystem<XRInputSubsystemDescriptor> // TypeDefIndex: 4154
{
	[CompilerGeneratedAttribute] 
	[DebuggerBrowsableAttribute] 
	private Action<XRInputSubsystem> trackingOriginUpdated; 
	[DebuggerBrowsableAttribute] 
	[CompilerGeneratedAttribute] 
	private Action<XRInputSubsystem> boundaryChanged; 


	[RequiredByNativeCodeAttribute] 
private static void InvokeTrackingOriginUpdatedEvent(IntPtr internalPtr) { }

	[RequiredByNativeCodeAttribute] 
private static void InvokeBoundaryChangedEvent(IntPtr internalPtr) { }

public void .ctor() { }

}

public class XRInputSubsystemDescriptor : IntegratedSubsystemDescriptor<XRInputSubsystem> // TypeDefIndex: 4155
{

public void .ctor() { }

}

public class XRMeshSubsystem : IntegratedSubsystem<XRMeshSubsystemDescriptor> // TypeDefIndex: 4161
{

	[RequiredByNativeCodeAttribute] 
private void InvokeMeshReadyDelegate(MeshGenerationResult result, Action<MeshGenerationResult> onMeshGenerationComplete) { }

public void .ctor() { }

}

public class XRMeshSubsystemDescriptor : IntegratedSubsystemDescriptor<XRMeshSubsystem> // TypeDefIndex: 4162
{

public void .ctor() { }

}

internal sealed class XDRSchema : XMLSchema // TypeDefIndex: 4313
{
	internal string _schemaName; 
	internal string _schemaUri; 
	internal XmlElement _schemaRoot; 
	internal DataSet _ds; 
	private static readonly char[] s_colonArray; 
	private static XDRSchema.NameType[] s_mapNameTypeXdr; 
	private static XDRSchema.NameType s_enumerationNameType; 


internal void .ctor(DataSet ds, bool fInline) { }

internal void LoadSchema(XmlElement schemaRoot, DataSet ds) { }

internal XmlElement FindTypeNode(XmlElement node) { }

internal bool IsTextOnlyContent(XmlElement node) { }

internal bool IsXDRField(XmlElement node, XmlElement typeNode) { }

internal DataTable HandleTable(XmlElement node) { }

private static XDRSchema.NameType FindNameType(string name) { }

private Type ParseDataType(string dt, string dtValues) { }

internal string GetInstanceName(XmlElement node) { }

internal void HandleColumn(XmlElement node, DataTable table) { }

internal void GetMinMax(XmlElement elNode, ref int minOccurs, ref int maxOccurs) { }

internal void GetMinMax(XmlElement elNode, bool isAttribute, ref int minOccurs, ref int maxOccurs) { }

internal void HandleTypeNode(XmlElement typeNode, DataTable table, ArrayList tableChildren) { }

internal DataTable InstantiateTable(DataSet dataSet, XmlElement node, XmlElement typeNode) { }

internal DataTable InstantiateSimpleTable(DataSet dataSet, XmlElement node) { }

private static void .cctor() { }

}

private sealed class XDRSchema.NameType : IComparable // TypeDefIndex: 4314
{
	public string name; 
	public Type type; 


public void .ctor(string n, Type t) { }

public int CompareTo(object obj) { }

}

internal sealed class XMLDiffLoader // TypeDefIndex: 4315
{
	private ArrayList _tables; 
	private DataSet _dataSet; 
	private DataTable _dataTable; 


internal void LoadDiffGram(DataSet ds, XmlReader dataTextReader) { }

private void CreateTablesHierarchy(DataTable dt) { }

internal void LoadDiffGram(DataTable dt, XmlReader dataTextReader) { }

internal void ProcessDiffs(DataSet ds, XmlReader ssync) { }

internal void ProcessDiffs(ArrayList tableList, XmlReader ssync) { }

internal void ProcessErrors(DataSet ds, XmlReader ssync) { }

internal void ProcessErrors(ArrayList dt, XmlReader ssync) { }

private DataTable GetTable(string tableName, string ns) { }

private int ReadOldRowData(DataSet ds, ref DataTable table, ref int pos, XmlReader row) { }

internal void SkipWhitespaces(XmlReader reader) { }

public void .ctor() { }

}

internal class XMLSchema // TypeDefIndex: 4316
{

internal static TypeConverter GetConverter(Type type) { }

internal static void SetProperties(object instance, XmlAttributeCollection attrs) { }

internal static bool FEqualIdentity(XmlNode node, string name, string ns) { }

internal static bool GetBooleanAttribute(XmlElement element, string attrName, string attrNS, bool defVal) { }

internal static string GenUniqueColumnName(string proposedName, DataTable table) { }

public void .ctor() { }

}

internal sealed class XSDSchema : XMLSchema // TypeDefIndex: 4318
{
	private XmlSchemaSet _schemaSet; 
	private XmlSchemaElement _dsElement; 
	private DataSet _ds; 
	private string _schemaName; 
	private ArrayList _columnExpressions; 
	private Hashtable _constraintNodes; 
	private ArrayList _refTables; 
	private ArrayList _complexTypes; 
	private XmlSchemaObjectCollection _annotations; 
	private XmlSchemaObjectCollection _elements; 
	private Hashtable _attributes; 
	private Hashtable _elementsTable; 
	private Hashtable _attributeGroups; 
	private Hashtable _schemaTypes; 
	private Hashtable _expressions; 
	private Dictionary<DataTable, List<DataTable>> _tableDictionary; 
	private Hashtable _udSimpleTypes; 
	private Hashtable _existingSimpleTypeMap; 
	private bool _fromInference; 
	private static readonly XSDSchema.NameType[] s_mapNameTypeXsd; 

internal bool FromInference { get; set; }


internal bool get_FromInference() { }

internal void set_FromInference(bool value) { }

private void CollectElementsAnnotations(XmlSchema schema) { }

private void CollectElementsAnnotations(XmlSchema schema, ArrayList schemaList) { }

internal static string QualifiedName(string name) { }

internal static void SetProperties(object instance, XmlAttribute[] attrs) { }

private static void SetExtProperties(object instance, XmlAttribute[] attrs) { }

private void HandleColumnExpression(object instance, XmlAttribute[] attrs) { }

internal static string GetMsdataAttribute(XmlSchemaAnnotated node, string ln) { }

private static void SetExtProperties(object instance, XmlAttributeCollection attrs) { }

internal void HandleRefTableProperties(ArrayList RefTables, XmlSchemaElement element) { }

internal void HandleRelation(XmlElement node, bool fNested) { }

private bool HasAttributes(XmlSchemaObjectCollection attributes) { }

private bool IsDatasetParticle(XmlSchemaParticle pt) { }

private int DatasetElementCount(XmlSchemaObjectCollection elements) { }

private XmlSchemaElement FindDatasetElement(XmlSchemaObjectCollection elements) { }

public void LoadSchema(XmlSchemaSet schemaSet, DataTable dt) { }

public void LoadSchema(XmlSchemaSet schemaSet, DataSet ds) { }

private void HandleRelations(XmlSchemaAnnotation ann, bool fNested) { }

internal XmlSchemaObjectCollection GetParticleItems(XmlSchemaParticle pt) { }

internal void HandleParticle(XmlSchemaParticle pt, DataTable table, ArrayList tableChildren, bool isBase) { }

internal void HandleAttributes(XmlSchemaObjectCollection attributes, DataTable table, bool isBase) { }

private void HandleAttributeGroup(XmlSchemaAttributeGroup attributeGroup, DataTable table, bool isBase) { }

internal void HandleComplexType(XmlSchemaComplexType ct, DataTable table, ArrayList tableChildren, bool isNillable) { }

internal XmlSchemaParticle GetParticle(XmlSchemaComplexType ct) { }

internal DataColumn FindField(DataTable table, string field) { }

internal DataColumn[] BuildKey(XmlSchemaIdentityConstraint keyNode, DataTable table) { }

internal bool GetBooleanAttribute(XmlSchemaAnnotated element, string attrName, bool defVal) { }

internal string GetStringAttribute(XmlSchemaAnnotated element, string attrName, string defVal) { }

internal static AcceptRejectRule TranslateAcceptRejectRule(string strRule) { }

internal static Rule TranslateRule(string strRule) { }

internal void HandleKeyref(XmlSchemaKeyref keyref) { }

internal void HandleConstraint(XmlSchemaIdentityConstraint keyNode) { }

internal DataTable InstantiateSimpleTable(XmlSchemaElement node) { }

internal string GetInstanceName(XmlSchemaAnnotated node) { }

internal DataTable InstantiateTable(XmlSchemaElement node, XmlSchemaComplexType typeNode, bool isRef) { }

public static Type XsdtoClr(string xsdTypeName) { }

private static XSDSchema.NameType FindNameType(string name) { }

private Type ParseDataType(string dt) { }

internal static bool IsXsdType(string name) { }

internal XmlSchemaAnnotated FindTypeNode(XmlSchemaAnnotated node) { }

internal void HandleSimpleTypeSimpleContentColumn(XmlSchemaSimpleType typeNode, string strType, DataTable table, bool isBase, XmlAttribute[] attrs, bool isNillable) { }

internal void HandleSimpleContentColumn(string strType, DataTable table, bool isBase, XmlAttribute[] attrs, bool isNillable) { }

internal void HandleAttributeColumn(XmlSchemaAttribute attrib, DataTable table, bool isBase) { }

internal void HandleElementColumn(XmlSchemaElement elem, DataTable table, bool isBase) { }

internal void HandleDataSet(XmlSchemaElement node, bool isNewDataSet) { }

private void AddTablesToList(List<DataTable> tableList, DataTable dt) { }

private string GetPrefix(string ns) { }

private string GetNamespaceFromPrefix(string prefix) { }

private string GetTableNamespace(XmlSchemaIdentityConstraint key) { }

private string GetTableName(XmlSchemaIdentityConstraint key) { }

internal bool IsTable(XmlSchemaElement node) { }

internal DataTable HandleTable(XmlSchemaElement node) { }

public void .ctor() { }

private static void .cctor() { }

}

private sealed class XSDSchema.NameType : IComparable // TypeDefIndex: 4319
{
	public readonly string name; 
	public readonly Type type; 


public void .ctor(string n, Type t) { }

public int CompareTo(object obj) { }

}

internal sealed class XmlIgnoreNamespaceReader : XmlNodeReader // TypeDefIndex: 4320
{
	private List<string> _namespacesToIgnore; 


internal void .ctor(XmlDocument xdoc, string[] namespacesToIgnore) { }

public override bool MoveToFirstAttribute() { }

public override bool MoveToNextAttribute() { }

}

internal sealed class XmlDataLoader // TypeDefIndex: 4321
{
	private DataSet _dataSet; 
	private XmlToDatasetMap _nodeToSchemaMap; 
	private Hashtable _nodeToRowMap; 
	private Stack _childRowsStack; 
	private Hashtable _htableExcludedNS; 
	private bool _fIsXdr; 
	internal bool _isDiffgram; 
	private XmlElement _topMostNode; 
	private bool _ignoreSchema; 
	private DataTable _dataTable; 
	private bool _isTableLevel; 
	private bool _fromInference; 
	private XmlReader _dataReader; 
	private object _XSD_XMLNS_NS; 
	private object _XDR_SCHEMA; 
	private object _XDRNS; 
	private object _SQL_SYNC; 
	private object _UPDGNS; 
	private object _XSD_SCHEMA; 
	private object _XSDNS; 
	private object _DFFNS; 
	private object _MSDNS; 
	private object _DIFFID; 
	private object _HASCHANGES; 
	private object _ROWORDER; 

internal bool FromInference { get; set; }


internal void .ctor(DataSet dataset, bool IsXdr, bool ignoreSchema) { }

internal void .ctor(DataSet dataset, bool IsXdr, XmlElement topNode, bool ignoreSchema) { }

internal void .ctor(DataTable datatable, bool IsXdr, bool ignoreSchema) { }

internal void .ctor(DataTable datatable, bool IsXdr, XmlElement topNode, bool ignoreSchema) { }

internal bool get_FromInference() { }

internal void set_FromInference(bool value) { }

private void AttachRows(DataRow parentRow, XmlNode parentElement) { }

private int CountNonNSAttributes(XmlNode node) { }

private string GetValueForTextOnlyColums(XmlNode n) { }

private string GetInitialTextFromNodes(ref XmlNode n) { }

private DataColumn GetTextOnlyColumn(DataRow row) { }

internal DataRow GetRowFromElement(XmlElement e) { }

internal bool FColumnElement(XmlElement e) { }

private bool FExcludedNamespace(string ns) { }

private bool FIgnoreNamespace(XmlNode node) { }

private bool FIgnoreNamespace(XmlReader node) { }

internal bool IsTextLikeNode(XmlNodeType n) { }

internal bool IsTextOnly(DataColumn c) { }

internal void LoadData(XmlDocument xdoc) { }

private void LoadRowData(DataRow row, XmlElement rowElement) { }

private void LoadRows(DataRow parentRow, XmlNode parentElement) { }

private void SetRowValueFromXmlText(DataRow row, DataColumn col, string xmlText) { }

private void InitNameTable() { }

internal void LoadData(XmlReader reader) { }

private void LoadTopMostTable(DataTable table) { }

private void LoadTable(DataTable table, bool isNested) { }

private void LoadColumn(DataColumn column, object[] foundColumns) { }

private bool ProcessXsdSchema() { }

}

public enum XmlReadMode // TypeDefIndex: 4322
{
	public int value__; 
public const XmlReadMode Auto = 0;
public const XmlReadMode ReadSchema = 1;
public const XmlReadMode IgnoreSchema = 2;
public const XmlReadMode InferSchema = 3;
public const XmlReadMode DiffGram = 4;
public const XmlReadMode Fragment = 5;
public const XmlReadMode InferTypedSchema = 6;

}

internal sealed class XmlToDatasetMap // TypeDefIndex: 4323
{
	private XmlToDatasetMap.XmlNodeIdHashtable _tableSchemaMap; 
	private XmlToDatasetMap.TableSchemaInfo _lastTableSchemaInfo; 


public void .ctor(DataSet dataSet, XmlNameTable nameTable) { }

public void .ctor(XmlNameTable nameTable, DataSet dataSet) { }

public void .ctor(DataTable dataTable, XmlNameTable nameTable) { }

public void .ctor(XmlNameTable nameTable, DataTable dataTable) { }

internal static bool IsMappedColumn(DataColumn c) { }

private XmlToDatasetMap.TableSchemaInfo AddTableSchema(DataTable table, XmlNameTable nameTable) { }

private XmlToDatasetMap.TableSchemaInfo AddTableSchema(XmlNameTable nameTable, DataTable table) { }

private bool AddColumnSchema(DataColumn col, XmlNameTable nameTable, XmlToDatasetMap.XmlNodeIdHashtable columns) { }

private bool AddColumnSchema(XmlNameTable nameTable, DataColumn col, XmlToDatasetMap.XmlNodeIdHashtable columns) { }

private void BuildIdentityMap(DataSet dataSet, XmlNameTable nameTable) { }

private void BuildIdentityMap(XmlNameTable nameTable, DataSet dataSet) { }

private void BuildIdentityMap(DataTable dataTable, XmlNameTable nameTable) { }

private void BuildIdentityMap(XmlNameTable nameTable, DataTable dataTable) { }

private ArrayList GetSelfAndDescendants(DataTable dt) { }

public object GetColumnSchema(XmlNode node, bool fIgnoreNamespace) { }

public object GetColumnSchema(DataTable table, XmlReader dataReader, bool fIgnoreNamespace) { }

public object GetSchemaForNode(XmlNode node, bool fIgnoreNamespace) { }

public DataTable GetTableForNode(XmlReader node, bool fIgnoreNamespace) { }

private void HandleSpecialColumn(DataColumn col, XmlNameTable nameTable, XmlToDatasetMap.XmlNodeIdHashtable columns) { }

}

private sealed class XmlToDatasetMap.XmlNodeIdentety // TypeDefIndex: 4324
{
	public string LocalName; 
	public string NamespaceURI; 


public void .ctor(string localName, string namespaceURI) { }

public override int GetHashCode() { }

public override bool Equals(object obj) { }

}

internal sealed class XmlToDatasetMap.XmlNodeIdHashtable : Hashtable // TypeDefIndex: 4325
{
	private XmlToDatasetMap.XmlNodeIdentety _id; 

public object Item { get; }
public object Item { get; }
public object Item { get; }
public object Item { get; }


public void .ctor(int capacity) { }

public object get_Item(XmlNode node) { }

public object get_Item(XmlReader dataReader) { }

public object get_Item(DataTable table) { }

public object get_Item(string name) { }

}

private sealed class XmlToDatasetMap.TableSchemaInfo // TypeDefIndex: 4326
{
	public DataTable TableSchema; 
	public XmlToDatasetMap.XmlNodeIdHashtable ColumnsSchemaMap; 


public void .ctor(DataTable tableSchema) { }

}

public enum XmlWriteMode // TypeDefIndex: 4327
{
	public int value__; 
public const XmlWriteMode WriteSchema = 0;
public const XmlWriteMode IgnoreSchema = 1;
public const XmlWriteMode DiffGram = 2;

}

internal sealed class XmlTreeGen // TypeDefIndex: 4330
{
	private ArrayList _constraintNames; 
	private Hashtable _namespaces; 
	private Hashtable _autogenerated; 
	private Hashtable _prefixes; 
	private DataSet _ds; 
	private ArrayList _tables; 
	private ArrayList _relations; 
	private XmlDocument _dc; 
	private XmlElement _sRoot; 
	private int _prefixCount; 
	private SchemaFormat _schFormat; 
	private string _filePath; 
	private string _fileName; 
	private string _fileExt; 
	private XmlElement _dsElement; 
	private XmlElement _constraintSeparator; 
	private Converter<Type, string> _targetConverter; 


internal void .ctor(SchemaFormat format) { }

internal static void AddExtendedProperties(PropertyCollection props, XmlElement node) { }

internal static void AddExtendedProperties(PropertyCollection props, XmlElement node, Type type) { }

internal void AddXdoProperties(object instance, XmlElement root, XmlDocument xd) { }

internal void AddXdoProperty(PropertyDescriptor pd, object instance, XmlElement root, XmlDocument xd) { }

internal static string XmlDataTypeName(Type type) { }

private void GenerateConstraintNames(DataTable table, bool fromTable) { }

private void GenerateConstraintNames(ArrayList tables) { }

private void GenerateConstraintNames(DataSet ds) { }

private static bool _PropsNotEmpty(PropertyCollection props) { }

private bool HaveExtendedProperties(DataSet ds) { }

internal void WriteSchemaRoot(XmlDocument xd, XmlElement rootSchema, string targetNamespace) { }

internal static void ValidateColumnMapping(Type columnType) { }

internal void SetupAutoGenerated(DataSet ds) { }

internal void SetupAutoGenerated(ArrayList dt) { }

internal void SetupAutoGenerated(DataTable dt) { }

private void CreateTablesHierarchy(DataTable dt) { }

private void CreateRelations(DataTable dt) { }

private DataTable[] CreateToplevelTables() { }

internal void SchemaTree(XmlDocument xd, XmlWriter xmlWriter, DataSet ds, DataTable dt, bool writeHierarchy) { }

internal XmlElement SchemaTree(XmlDocument xd, DataTable dt) { }

internal XmlElement FillDataSetElement(XmlDocument xd, DataSet ds, DataTable dt) { }

internal void SetPath(XmlWriter xw) { }

internal void Save(DataSet ds, XmlWriter xw) { }

internal void Save(DataTable dt, XmlWriter xw) { }

internal void Save(DataSet ds, DataTable dt, XmlWriter xw) { }

internal void Save(DataSet ds, DataTable dt, XmlWriter xw, bool writeHierarchy) { }

internal void Save(DataSet ds, DataTable dt, XmlWriter xw, bool writeHierarchy, Converter<Type, string> multipleTargetConverter) { }

internal XmlElement HandleRelation(DataRelation rel, XmlDocument dc) { }

private static XmlElement FindSimpleType(XmlElement schema, string name) { }

internal XmlElement GetSchema(string NamespaceURI) { }

internal void HandleColumnType(DataColumn col, XmlDocument dc, XmlElement root, XmlElement schema) { }

internal void AddColumnProperties(DataColumn col, XmlElement root) { }

private string FindTargetNamespace(DataTable table) { }

internal XmlElement HandleColumn(DataColumn col, XmlDocument dc, XmlElement schema, bool fWriteOrdinal) { }

internal static string TranslateAcceptRejectRule(AcceptRejectRule rule) { }

internal static string TranslateRule(Rule rule) { }

internal void AppendChildWithoutRef(XmlElement node, string Namespace, XmlElement el, string refString) { }

internal XmlElement FindTypeNode(XmlElement node, string strType) { }

internal XmlElement HandleTable(DataTable table, XmlDocument dc, XmlElement schema) { }

private bool HasMixedColumns(DataTable table) { }

internal static bool AutoGenerated(DataColumn col) { }

internal static bool AutoGenerated(DataRelation rel) { }

internal static bool AutoGenerated(UniqueConstraint unique) { }

private bool AutoGenerated(ForeignKeyConstraint fk) { }

internal static bool AutoGenerated(ForeignKeyConstraint fk, bool checkRelation) { }

private bool IsAutoGenerated(object o) { }

internal XmlElement HandleTable(DataTable table, XmlDocument dc, XmlElement schema, bool genNested) { }

private void SetMSDataAttribute(XmlElement root, Type type) { }

}

internal sealed class XmlDataTreeWriter // TypeDefIndex: 4332
{
	private XmlWriter _xmlw; 
	private DataSet _ds; 
	private DataTable _dt; 
	private ArrayList _dTables; 
	private DataTable[] _topLevelTables; 
	private bool _fFromTable; 
	private bool _isDiffgram; 
	private Hashtable _rowsOrder; 
	private bool _writeHierarchy; 


internal void .ctor(DataSet ds) { }

internal void .ctor(DataTable dt, bool writeHierarchy) { }

private DataTable[] CreateToplevelTables() { }

private void CreateTablesHierarchy(DataTable dt) { }

internal static bool RowHasErrors(DataRow row) { }

internal void SaveDiffgramData(XmlWriter xw, Hashtable rowsOrder) { }

internal void Save(XmlWriter xw, bool writeSchema) { }

private ArrayList GetNestedChildRelations(DataRow row) { }

internal void XmlDataRowWriter(DataRow row, string encodedTableName) { }

internal static bool PreserveSpace(object value) { }

}

public sealed class SqlXml : INullable, IXmlSerializable // TypeDefIndex: 4359
{
	private static readonly Func<Stream, XmlReaderSettings, XmlParserContext, XmlReader> s_sqlReaderDelegate; 
	private static readonly XmlReaderSettings s_defaultXmlReaderSettings; 
	private static readonly XmlReaderSettings s_defaultXmlReaderSettingsCloseInput; 
	private static MethodInfo s_createSqlReaderMethodInfo; 
	private MethodInfo _createSqlReaderMethodInfo; 
	private bool _fNotNull; 
	private Stream _stream; 
	private bool _firstCreateReader; 

private static MethodInfo CreateSqlReaderMethodInfo { get; }
public bool IsNull { get; }


public void .ctor() { }

public XmlReader CreateReader() { }

internal static XmlReader CreateSqlXmlReader(Stream stream, bool closeInput = False, bool throwTargetInvocationExceptions = False) { }

private static Func<Stream, XmlReaderSettings, XmlParserContext, XmlReader> CreateSqlReaderDelegate() { }

private static MethodInfo get_CreateSqlReaderMethodInfo() { }

public bool get_IsNull() { }

private void SetNull() { }

private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader r) { }

private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

private static void .cctor() { }

}

internal sealed class SqlXmlStreamWrapper : Stream // TypeDefIndex: 4360
{
	private Stream _stream; 
	private long _lPosition; 
	private bool _isClosed; 

public override bool CanRead { get; }
public override bool CanSeek { get; }
public override bool CanWrite { get; }
public override long Length { get; }
public override long Position { get; set; }


internal void .ctor(Stream stream) { }

public override bool get_CanRead() { }

public override bool get_CanSeek() { }

public override bool get_CanWrite() { }

public override long get_Length() { }

public override long get_Position() { }

public override void set_Position(long value) { }

public override long Seek(long offset, SeekOrigin origin) { }

public override int Read(byte[] buffer, int offset, int count) { }

public override void Write(byte[] buffer, int offset, int count) { }

public override int ReadByte() { }

public override void WriteByte(byte value) { }

public override void SetLength(long value) { }

public override void Flush() { }

protected override void Dispose(bool disposing) { }

private void ThrowIfStreamCannotSeek(string method) { }

private void ThrowIfStreamCannotRead(string method) { }

private void ThrowIfStreamCannotWrite(string method) { }

private void ThrowIfStreamClosed(string method) { }

private bool IsStreamClosed() { }

}

public static class XRDevice // TypeDefIndex: 4768
{

internal class <Module> 

[NativeConditionalAttribute] 
public static class XRDevice 
	[CompilerGeneratedAttribute] 
	[DebuggerBrowsableAttribute] 
	private static Action<string> deviceLoaded; 


	[RequiredByNativeCodeAttribute] 
private static void InvokeDeviceLoaded(string loadedDeviceName) { }

private static void .cctor() { }

}

public sealed class XName : IEquatable<XName>, ISerializable // TypeDefIndex: 5815
{

internal class <Module> 

[KnownTypeAttribute] 
[Serializable]
public sealed class XName : IEquatable<XName>, ISerializable 
	private XNamespace ns; 
	private string localName; 
	private int hashCode; 

public string LocalName { get; }
public XNamespace Namespace { get; }
public string NamespaceName { get; }


internal void .ctor(XNamespace ns, string localName) { }

public string get_LocalName() { }

public XNamespace get_Namespace() { }

public string get_NamespaceName() { }

public override string ToString() { }

public static XName Get(string expandedName) { }

public static XName Get(string localName, string namespaceName) { }

	[CLSCompliantAttribute] 
public static XName op_Implicit(string expandedName) { }

public override bool Equals(object obj) { }

public override int GetHashCode() { }

public static bool op_Equality(XName left, XName right) { }

private bool System.IEquatable<System.Xml.Linq.XName>.Equals(XName other) { }

private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

internal void .ctor() { }

}

public sealed class XNamespace // TypeDefIndex: 5817
{
	private static XHashtable<WeakReference> namespaces; 
	private static WeakReference refNone; 
	private static WeakReference refXml; 
	private static WeakReference refXmlns; 
	private string namespaceName; 
	private int hashCode; 
	private XHashtable<XName> names; 

public string NamespaceName { get; }
public static XNamespace None { get; }
public static XNamespace Xml { get; }
public static XNamespace Xmlns { get; }


internal void .ctor(string namespaceName) { }

public string get_NamespaceName() { }

public XName GetName(string localName) { }

public override string ToString() { }

public static XNamespace get_None() { }

public static XNamespace get_Xml() { }

public static XNamespace get_Xmlns() { }

public static XNamespace Get(string namespaceName) { }

	[CLSCompliantAttribute] 
public static XNamespace op_Implicit(string namespaceName) { }

public override bool Equals(object obj) { }

public override int GetHashCode() { }

public static bool op_Equality(XNamespace left, XNamespace right) { }

public static bool op_Inequality(XNamespace left, XNamespace right) { }

internal XName GetName(string localName, int index, int count) { }

internal static XNamespace Get(string namespaceName, int index, int count) { }

private static string ExtractLocalName(XName n) { }

private static string ExtractNamespace(WeakReference r) { }

private static XNamespace EnsureNamespace(ref WeakReference refNmsp, string namespaceName) { }

}

public abstract class XObject : IXmlLineInfo // TypeDefIndex: 5822
{
	internal XContainer parent; 
	internal object annotations; 

public string BaseUri { get; }
public abstract XmlNodeType NodeType { get; }
public XElement Parent { get; }
private int System.Xml.IXmlLineInfo.LineNumber { get; }
private int System.Xml.IXmlLineInfo.LinePosition { get; }
internal bool HasBaseUri { get; }


internal void .ctor() { }

public string get_BaseUri() { }

public abstract XmlNodeType get_NodeType();

public XElement get_Parent() { }

public void AddAnnotation(object annotation) { }

public object Annotation(Type type) { }

public T Annotation<T>() { }
/* GenericInstMethod :
|
|-XObject.Annotation<object>
|-XObject.Annotation<BaseUriAnnotation>
|-XObject.Annotation<LineInfoAnnotation>
|-XObject.Annotation<XObjectChangeAnnotation>
*/

	[IteratorStateMachineAttribute] 
public IEnumerable<T> Annotations<T>() { }
/* GenericInstMethod :
|
|-XObject.Annotations<object>
|-XObject.Annotations<XObjectChangeAnnotation>
*/

private bool System.Xml.IXmlLineInfo.HasLineInfo() { }

private int System.Xml.IXmlLineInfo.get_LineNumber() { }

private int System.Xml.IXmlLineInfo.get_LinePosition() { }

internal bool get_HasBaseUri() { }

internal bool NotifyChanged(object sender, XObjectChangeEventArgs e) { }

internal bool NotifyChanging(object sender, XObjectChangeEventArgs e) { }

internal void SetBaseUri(string baseUri) { }

internal void SetLineInfo(int lineNumber, int linePosition) { }

internal bool SkipNotify() { }

internal SaveOptions GetSaveOptionsFromAnnotations() { }

}

private sealed class XObject.<Annotations>d__16<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IDisposable, IEnumerator // TypeDefIndex: 5823
{
	private int <>1__state; 
	private T <>2__current; 
	private int <>l__initialThreadId; 
	public XObject <>4__this; 
	private object[] <a>5__1; 
	private int <i>5__2; 

private T System.Collections.Generic.IEnumerator<T>.Current { get; }
private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] 
public void .ctor(int <>1__state) { }
/* GenericInstMethod :
|
|-XObject.<Annotations>d__16<object>..ctor
*/

	[DebuggerHiddenAttribute] 
private void System.IDisposable.Dispose() { }
/* GenericInstMethod :
|
|-XObject.<Annotations>d__16<object>.System.IDisposable.Dispose
*/

private bool MoveNext() { }
/* GenericInstMethod :
|
|-XObject.<Annotations>d__16<object>.MoveNext
*/

	[DebuggerHiddenAttribute] 
private T System.Collections.Generic.IEnumerator<T>.get_Current() { }
/* GenericInstMethod :
|
|-XObject.<Annotations>d__16<object>.System.Collections.Generic.IEnumerator<T>.get_Current
*/

	[DebuggerHiddenAttribute] 
private void System.Collections.IEnumerator.Reset() { }
/* GenericInstMethod :
|
|-XObject.<Annotations>d__16<object>.System.Collections.IEnumerator.Reset
*/

	[DebuggerHiddenAttribute] 
private object System.Collections.IEnumerator.get_Current() { }
/* GenericInstMethod :
|
|-XObject.<Annotations>d__16<object>.System.Collections.IEnumerator.get_Current
*/

	[DebuggerHiddenAttribute] 
private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
/* GenericInstMethod :
|
|-XObject.<Annotations>d__16<object>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
*/

	[DebuggerHiddenAttribute] 
private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
/* GenericInstMethod :
|
|-XObject.<Annotations>d__16<object>.System.Collections.IEnumerable.GetEnumerator
*/

}

internal class XObjectChangeAnnotation // TypeDefIndex: 5827
{
	internal EventHandler<XObjectChangeEventArgs> changing; 
	internal EventHandler<XObjectChangeEventArgs> changed; 

}

public enum XObjectChange // TypeDefIndex: 5828
{
	public int value__; 
public const XObjectChange Add = 0;
public const XObjectChange Remove = 1;
public const XObjectChange Name = 2;
public const XObjectChange Value = 3;

}

public class XObjectChangeEventArgs : EventArgs // TypeDefIndex: 5829
{
	private XObjectChange objectChange; 
	public static readonly XObjectChangeEventArgs Add; 
	public static readonly XObjectChangeEventArgs Remove; 
	public static readonly XObjectChangeEventArgs Name; 
	public static readonly XObjectChangeEventArgs Value; 


public void .ctor(XObjectChange objectChange) { }

private static void .cctor() { }

}

public abstract class XNode : XObject // TypeDefIndex: 5830
{
	internal XNode next; 


internal void .ctor() { }

public void Remove() { }

public override string ToString() { }

public abstract void WriteTo(XmlWriter writer);

internal virtual void AppendText(StringBuilder sb) { }

internal abstract XNode CloneNode();

private string GetXmlString(SaveOptions o) { }

}

public class XText : XNode // TypeDefIndex: 5831
{
	internal string text; 

public override XmlNodeType NodeType { get; }
public string Value { get; set; }


public void .ctor(string value) { }

public void .ctor(XText other) { }

public override XmlNodeType get_NodeType() { }

public string get_Value() { }

public void set_Value(string value) { }

public override void WriteTo(XmlWriter writer) { }

internal override void AppendText(StringBuilder sb) { }

internal override XNode CloneNode() { }

}

public class XCData : XText // TypeDefIndex: 5832
{
public override XmlNodeType NodeType { get; }


public void .ctor(string value) { }

public void .ctor(XCData other) { }

public override XmlNodeType get_NodeType() { }

public override void WriteTo(XmlWriter writer) { }

internal override XNode CloneNode() { }

}

public abstract class XContainer : XNode // TypeDefIndex: 5833
{
	internal object content; 

public XNode LastNode { get; }


internal void .ctor() { }

internal void .ctor(XContainer other) { }

public XNode get_LastNode() { }

public void Add(object content) { }

	[IteratorStateMachineAttribute] 
public IEnumerable<XNode> Nodes() { }

internal virtual void AddAttribute(XAttribute a) { }

internal virtual void AddAttributeSkipNotify(XAttribute a) { }

internal void AddContentSkipNotify(object content) { }

internal void AddNode(XNode n) { }

internal void AddNodeSkipNotify(XNode n) { }

internal void AddString(string s) { }

internal void AddStringSkipNotify(string s) { }

internal void AppendNode(XNode n) { }

internal void AppendNodeSkipNotify(XNode n) { }

internal override void AppendText(StringBuilder sb) { }

internal void ConvertTextToNode() { }

internal static string GetDateTimeString(DateTime value) { }

internal static string GetStringValue(object value) { }

internal void ReadContentFrom(XmlReader r) { }

internal void ReadContentFrom(XmlReader r, LoadOptions o) { }

internal void RemoveNode(XNode n) { }

internal virtual void ValidateNode(XNode node, XNode previous) { }

internal virtual void ValidateString(string s) { }

internal void WriteContentTo(XmlWriter writer) { }

}

private sealed class XContainer.<Nodes>d__18 : IEnumerable<XNode>, IEnumerable, IEnumerator<XNode>, IDisposable, IEnumerator // TypeDefIndex: 5834
{
	private int <>1__state; 
	private XNode <>2__current; 
	private int <>l__initialThreadId; 
	public XContainer <>4__this; 
	private XNode <n>5__1; 

private XNode System.Collections.Generic.IEnumerator<System.Xml.Linq.XNode>.Current { get; }
private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] 
public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] 
private void System.IDisposable.Dispose() { }

private bool MoveNext() { }

	[DebuggerHiddenAttribute] 
private XNode System.Collections.Generic.IEnumerator<System.Xml.Linq.XNode>.get_Current() { }

	[DebuggerHiddenAttribute] 
private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] 
private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHiddenAttribute] 
private IEnumerator<XNode> System.Collections.Generic.IEnumerable<System.Xml.Linq.XNode>.GetEnumerator() { }

	[DebuggerHiddenAttribute] 
private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

public class XElement : XContainer, IXmlSerializable // TypeDefIndex: 5836
{
	internal XName name; 
	internal XAttribute lastAttr; 

public bool IsEmpty { get; }
public XName Name { get; }
public override XmlNodeType NodeType { get; }
public string Value { get; }


public void .ctor(XName name) { }

public void .ctor(XElement other) { }

public void .ctor(XStreamingElement other) { }

public bool get_IsEmpty() { }

public XName get_Name() { }

public override XmlNodeType get_NodeType() { }

public string get_Value() { }

public XAttribute Attribute(XName name) { }

public IEnumerable<XAttribute> Attributes() { }

public string GetPrefixOfNamespace(XNamespace ns) { }

public override void WriteTo(XmlWriter writer) { }

private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

internal override void AddAttribute(XAttribute a) { }

internal override void AddAttributeSkipNotify(XAttribute a) { }

internal void AppendAttribute(XAttribute a) { }

internal void AppendAttributeSkipNotify(XAttribute a) { }

internal override XNode CloneNode() { }

	[IteratorStateMachineAttribute] 
private IEnumerable<XAttribute> GetAttributes(XName name) { }

private string GetNamespaceOfPrefixInScope(string prefix, XElement outOfScope) { }

private void ReadElementFrom(XmlReader r, LoadOptions o) { }

internal void SetEndElementLineInfo(int lineNumber, int linePosition) { }

internal override void ValidateNode(XNode node, XNode previous) { }

}

private sealed class XElement.<GetAttributes>d__105 : IEnumerable<XAttribute>, IEnumerable, IEnumerator<XAttribute>, IDisposable, IEnumerator // TypeDefIndex: 5837
{
	private int <>1__state; 
	private XAttribute <>2__current; 
	private int <>l__initialThreadId; 
	public XElement <>4__this; 
	private XAttribute <a>5__1; 
	private XName name; 
	public XName <>3__name; 

private XAttribute System.Collections.Generic.IEnumerator<System.Xml.Linq.XAttribute>.Current { get; }
private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] 
public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] 
private void System.IDisposable.Dispose() { }

private bool MoveNext() { }

	[DebuggerHiddenAttribute] 
private XAttribute System.Collections.Generic.IEnumerator<System.Xml.Linq.XAttribute>.get_Current() { }

	[DebuggerHiddenAttribute] 
private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] 
private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHiddenAttribute] 
private IEnumerator<XAttribute> System.Collections.Generic.IEnumerable<System.Xml.Linq.XAttribute>.GetEnumerator() { }

	[DebuggerHiddenAttribute] 
private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

public class XDocument : XContainer // TypeDefIndex: 5843
{
	private XDeclaration declaration; 

public XDeclaration Declaration { get; set; }
public override XmlNodeType NodeType { get; }
public XElement Root { get; }


public void .ctor() { }

public void .ctor(XDocument other) { }

public XDeclaration get_Declaration() { }

public void set_Declaration(XDeclaration value) { }

public override XmlNodeType get_NodeType() { }

public XElement get_Root() { }

public override void WriteTo(XmlWriter writer) { }

internal override void AddAttribute(XAttribute a) { }

internal override void AddAttributeSkipNotify(XAttribute a) { }

internal override XNode CloneNode() { }

private T GetFirstNode<T>() { }
/* GenericInstMethod :
|
|-XDocument.GetFirstNode<object>
|-XDocument.GetFirstNode<XElement>
*/

internal static bool IsWhitespace(string s) { }

internal override void ValidateNode(XNode node, XNode previous) { }

private void ValidateDocument(XNode previous, XmlNodeType allowBefore, XmlNodeType allowAfter) { }

internal override void ValidateString(string s) { }

}

public class XComment : XNode // TypeDefIndex: 5844
{
	internal string value; 

public override XmlNodeType NodeType { get; }
public string Value { get; }


public void .ctor(string value) { }

public void .ctor(XComment other) { }

public override XmlNodeType get_NodeType() { }

public string get_Value() { }

public override void WriteTo(XmlWriter writer) { }

internal override XNode CloneNode() { }

}

public class XProcessingInstruction : XNode // TypeDefIndex: 5845
{
	internal string target; 
	internal string data; 

public string Data { get; }
public override XmlNodeType NodeType { get; }
public string Target { get; }


public void .ctor(string target, string data) { }

public void .ctor(XProcessingInstruction other) { }

public string get_Data() { }

public override XmlNodeType get_NodeType() { }

public string get_Target() { }

public override void WriteTo(XmlWriter writer) { }

internal override XNode CloneNode() { }

private static void ValidateName(string name) { }

}

public class XDeclaration // TypeDefIndex: 5846
{
	private string version; 
	private string encoding; 
	private string standalone; 

public string Encoding { get; }
public string Standalone { get; }
public string Version { get; }


public void .ctor(string version, string encoding, string standalone) { }

public void .ctor(XDeclaration other) { }

public string get_Encoding() { }

public string get_Standalone() { }

public string get_Version() { }

public override string ToString() { }

}

public class XDocumentType : XNode // TypeDefIndex: 5847
{
	private string name; 
	private string publicId; 
	private string systemId; 
	private string internalSubset; 
	private IDtdInfo dtdInfo; 

public string InternalSubset { get; }
public string Name { get; }
public override XmlNodeType NodeType { get; }
public string PublicId { get; }
public string SystemId { get; }


public void .ctor(string name, string publicId, string systemId, string internalSubset) { }

public void .ctor(XDocumentType other) { }

internal void .ctor(string name, string publicId, string systemId, string internalSubset, IDtdInfo dtdInfo) { }

public string get_InternalSubset() { }

public string get_Name() { }

public override XmlNodeType get_NodeType() { }

public string get_PublicId() { }

public string get_SystemId() { }

public override void WriteTo(XmlWriter writer) { }

internal override XNode CloneNode() { }

}

public class XAttribute : XObject // TypeDefIndex: 5848
{
	internal XAttribute next; 
	internal XName name; 
	internal string value; 

public bool IsNamespaceDeclaration { get; }
public XName Name { get; }
public override XmlNodeType NodeType { get; }
public string Value { get; }


public void .ctor(XName name, object value) { }

public void .ctor(XAttribute other) { }

public bool get_IsNamespaceDeclaration() { }

public XName get_Name() { }

public override XmlNodeType get_NodeType() { }

public string get_Value() { }

public override string ToString() { }

internal string GetPrefixOfNamespace(XNamespace ns) { }

private static void ValidateAttribute(XName name, string value) { }

}

public class XStreamingElement // TypeDefIndex: 5849
{
	internal XName name; 
	internal object content; 

}

internal class XmlDocumentWrapper : XmlNodeWrapper, IXmlDocument, IXmlNode // TypeDefIndex: 6111
{
	private readonly XmlDocument _document; 

public IXmlElement DocumentElement { get; }


public void .ctor(XmlDocument document) { }

public IXmlNode CreateComment(string data) { }

public IXmlNode CreateTextNode(string text) { }

public IXmlNode CreateCDataSection(string data) { }

public IXmlNode CreateWhitespace(string text) { }

public IXmlNode CreateSignificantWhitespace(string text) { }

public IXmlNode CreateXmlDeclaration(string version, string encoding, string standalone) { }

public IXmlNode CreateXmlDocumentType(string name, string publicId, string systemId, string internalSubset) { }

public IXmlNode CreateProcessingInstruction(string target, string data) { }

public IXmlElement CreateElement(string elementName) { }

public IXmlElement CreateElement(string qualifiedName, string namespaceUri) { }

public IXmlNode CreateAttribute(string name, string value) { }

public IXmlNode CreateAttribute(string qualifiedName, string namespaceUri, string value) { }

public IXmlElement get_DocumentElement() { }

}

internal class XmlElementWrapper : XmlNodeWrapper, IXmlElement, IXmlNode // TypeDefIndex: 6112
{
	private readonly XmlElement _element; 

public bool IsEmpty { get; }


public void .ctor(XmlElement element) { }

public void SetAttributeNode(IXmlNode attribute) { }

public string GetPrefixOfNamespace(string namespaceUri) { }

public bool get_IsEmpty() { }

}

internal class XmlDeclarationWrapper : XmlNodeWrapper, IXmlDeclaration, IXmlNode // TypeDefIndex: 6113
{
	private readonly XmlDeclaration _declaration; 

public string Version { get; }
public string Encoding { get; }
public string Standalone { get; }


public void .ctor(XmlDeclaration declaration) { }

public string get_Version() { }

public string get_Encoding() { }

public string get_Standalone() { }

}

internal class XmlDocumentTypeWrapper : XmlNodeWrapper, IXmlDocumentType, IXmlNode // TypeDefIndex: 6114
{
	private readonly XmlDocumentType _documentType; 

public string Name { get; }
public string System { get; }
public string Public { get; }
public string InternalSubset { get; }
public override string LocalName { get; }


public void .ctor(XmlDocumentType documentType) { }

public string get_Name() { }

public string get_System() { }

public string get_Public() { }

public string get_InternalSubset() { }

public override string get_LocalName() { }

}

internal class XmlNodeWrapper : IXmlNode // TypeDefIndex: 6115
{
	private readonly XmlNode _node; 
	private List<IXmlNode> _childNodes; 
	private List<IXmlNode> _attributes; 

public object WrappedNode { get; }
public XmlNodeType NodeType { get; }
public virtual string LocalName { get; }
public List<IXmlNode> ChildNodes { get; }
public List<IXmlNode> Attributes { get; }
public IXmlNode ParentNode { get; }
public string Value { get; set; }
public string NamespaceUri { get; }


public void .ctor(XmlNode node) { }

public object get_WrappedNode() { }

public XmlNodeType get_NodeType() { }

public virtual string get_LocalName() { }

public List<IXmlNode> get_ChildNodes() { }

internal static IXmlNode WrapNode(XmlNode node) { }

public List<IXmlNode> get_Attributes() { }

public IXmlNode get_ParentNode() { }

public string get_Value() { }

public void set_Value(string value) { }

public IXmlNode AppendChild(IXmlNode newChild) { }

public string get_NamespaceUri() { }

}

internal class XDeclarationWrapper : XObjectWrapper, IXmlDeclaration, IXmlNode // TypeDefIndex: 6121
{
	[CompilerGeneratedAttribute] 
	private XDeclaration <Declaration>k__BackingField; 

internal XDeclaration Declaration { get; set; }
public override XmlNodeType NodeType { get; }
public string Version { get; }
public string Encoding { get; }
public string Standalone { get; }


	[CompilerGeneratedAttribute] 
internal XDeclaration get_Declaration() { }

	[CompilerGeneratedAttribute] 
private void set_Declaration(XDeclaration value) { }

public void .ctor(XDeclaration declaration) { }

public override XmlNodeType get_NodeType() { }

public string get_Version() { }

public string get_Encoding() { }

public string get_Standalone() { }

}

internal class XDocumentTypeWrapper : XObjectWrapper, IXmlDocumentType, IXmlNode // TypeDefIndex: 6122
{
	private readonly XDocumentType _documentType; 

public string Name { get; }
public string System { get; }
public string Public { get; }
public string InternalSubset { get; }
public override string LocalName { get; }


public void .ctor(XDocumentType documentType) { }

public string get_Name() { }

public string get_System() { }

public string get_Public() { }

public string get_InternalSubset() { }

public override string get_LocalName() { }

}

internal class XDocumentWrapper : XContainerWrapper, IXmlDocument, IXmlNode // TypeDefIndex: 6123
{
private XDocument Document { get; }
public override List<IXmlNode> ChildNodes { get; }
public IXmlElement DocumentElement { get; }


private XDocument get_Document() { }

public void .ctor(XDocument document) { }

public override List<IXmlNode> get_ChildNodes() { }

public IXmlNode CreateComment(string text) { }

public IXmlNode CreateTextNode(string text) { }

public IXmlNode CreateCDataSection(string data) { }

public IXmlNode CreateWhitespace(string text) { }

public IXmlNode CreateSignificantWhitespace(string text) { }

public IXmlNode CreateXmlDeclaration(string version, string encoding, string standalone) { }

public IXmlNode CreateXmlDocumentType(string name, string publicId, string systemId, string internalSubset) { }

public IXmlNode CreateProcessingInstruction(string target, string data) { }

public IXmlElement CreateElement(string elementName) { }

public IXmlElement CreateElement(string qualifiedName, string namespaceUri) { }

public IXmlNode CreateAttribute(string name, string value) { }

public IXmlNode CreateAttribute(string qualifiedName, string namespaceUri, string value) { }

public IXmlElement get_DocumentElement() { }

public override IXmlNode AppendChild(IXmlNode newChild) { }

}

internal class XTextWrapper : XObjectWrapper // TypeDefIndex: 6124
{
private XText Text { get; }
public override string Value { get; }
public override IXmlNode ParentNode { get; }


private XText get_Text() { }

public void .ctor(XText text) { }

public override string get_Value() { }

public override IXmlNode get_ParentNode() { }

}

internal class XCommentWrapper : XObjectWrapper // TypeDefIndex: 6125
{
private XComment Text { get; }
public override string Value { get; }
public override IXmlNode ParentNode { get; }


private XComment get_Text() { }

public void .ctor(XComment text) { }

public override string get_Value() { }

public override IXmlNode get_ParentNode() { }

}

internal class XProcessingInstructionWrapper : XObjectWrapper // TypeDefIndex: 6126
{
private XProcessingInstruction ProcessingInstruction { get; }
public override string LocalName { get; }
public override string Value { get; }


private XProcessingInstruction get_ProcessingInstruction() { }

public void .ctor(XProcessingInstruction processingInstruction) { }

public override string get_LocalName() { }

public override string get_Value() { }

}

internal class XContainerWrapper : XObjectWrapper // TypeDefIndex: 6127
{
	private List<IXmlNode> _childNodes; 

private XContainer Container { get; }
public override List<IXmlNode> ChildNodes { get; }
public override IXmlNode ParentNode { get; }


private XContainer get_Container() { }

public void .ctor(XContainer container) { }

public override List<IXmlNode> get_ChildNodes() { }

public override IXmlNode get_ParentNode() { }

internal static IXmlNode WrapNode(XObject node) { }

public override IXmlNode AppendChild(IXmlNode newChild) { }

}

internal class XObjectWrapper : IXmlNode // TypeDefIndex: 6128
{
	private static readonly List<IXmlNode> EmptyChildNodes; 
	private readonly XObject _xmlObject; 

public object WrappedNode { get; }
public virtual XmlNodeType NodeType { get; }
public virtual string LocalName { get; }
public virtual List<IXmlNode> ChildNodes { get; }
public virtual List<IXmlNode> Attributes { get; }
public virtual IXmlNode ParentNode { get; }
public virtual string Value { get; }
public virtual string NamespaceUri { get; }


public void .ctor(XObject xmlObject) { }

public object get_WrappedNode() { }

public virtual XmlNodeType get_NodeType() { }

public virtual string get_LocalName() { }

public virtual List<IXmlNode> get_ChildNodes() { }

public virtual List<IXmlNode> get_Attributes() { }

public virtual IXmlNode get_ParentNode() { }

public virtual string get_Value() { }

public virtual IXmlNode AppendChild(IXmlNode newChild) { }

public virtual string get_NamespaceUri() { }

private static void .cctor() { }

}

internal class XAttributeWrapper : XObjectWrapper // TypeDefIndex: 6129
{
private XAttribute Attribute { get; }
public override string Value { get; }
public override string LocalName { get; }
public override string NamespaceUri { get; }
public override IXmlNode ParentNode { get; }


private XAttribute get_Attribute() { }

public void .ctor(XAttribute attribute) { }

public override string get_Value() { }

public override string get_LocalName() { }

public override string get_NamespaceUri() { }

public override IXmlNode get_ParentNode() { }

}

internal class XElementWrapper : XContainerWrapper, IXmlElement, IXmlNode // TypeDefIndex: 6130
{
	private List<IXmlNode> _attributes; 

private XElement Element { get; }
public override List<IXmlNode> Attributes { get; }
public override string Value { get; }
public override string LocalName { get; }
public override string NamespaceUri { get; }
public bool IsEmpty { get; }


private XElement get_Element() { }

public void .ctor(XElement element) { }

public void SetAttributeNode(IXmlNode attribute) { }

public override List<IXmlNode> get_Attributes() { }

public override IXmlNode AppendChild(IXmlNode newChild) { }

public override string get_Value() { }

public override string get_LocalName() { }

public override string get_NamespaceUri() { }

public string GetPrefixOfNamespace(string namespaceUri) { }

public bool get_IsEmpty() { }

}

public class XmlNodeConverter : JsonConverter // TypeDefIndex: 6131
{
	[CompilerGeneratedAttribute] 
	private string <DeserializeRootElementName>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private bool <WriteArrayAttribute>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private bool <OmitRootObject>k__BackingField; 

public string DeserializeRootElementName { get; }
public bool WriteArrayAttribute { get; }
public bool OmitRootObject { get; }


	[CompilerGeneratedAttribute] 
public string get_DeserializeRootElementName() { }

	[CompilerGeneratedAttribute] 
public bool get_WriteArrayAttribute() { }

	[CompilerGeneratedAttribute] 
public bool get_OmitRootObject() { }

public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

private IXmlNode WrapXml(object value) { }

private void PushParentNamespaces(IXmlNode node, XmlNamespaceManager manager) { }

private string ResolveFullName(IXmlNode node, XmlNamespaceManager manager) { }

private string GetPropertyName(IXmlNode node, XmlNamespaceManager manager) { }

private bool IsArray(IXmlNode node) { }

private void SerializeGroupedNodes(JsonWriter writer, IXmlNode node, XmlNamespaceManager manager, bool writePropertyName) { }

private void SerializeNode(JsonWriter writer, IXmlNode node, XmlNamespaceManager manager, bool writePropertyName) { }

private static bool AllSameName(IXmlNode node) { }

public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

private void DeserializeValue(JsonReader reader, IXmlDocument document, XmlNamespaceManager manager, string propertyName, IXmlNode currentNode) { }

private void ReadElement(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string propertyName, XmlNamespaceManager manager) { }

private void CreateElement(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string elementName, XmlNamespaceManager manager, string elementPrefix, Dictionary<string, string> attributeNameValues) { }

private static void AddAttribute(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string attributeName, XmlNamespaceManager manager, string attributePrefix) { }

private string ConvertTokenToXmlValue(JsonReader reader) { }

private void ReadArrayElements(JsonReader reader, IXmlDocument document, string propertyName, IXmlNode currentNode, XmlNamespaceManager manager) { }

private void AddJsonArrayAttribute(IXmlElement element, IXmlDocument document) { }

private Dictionary<string, string> ReadAttributeElements(JsonReader reader, XmlNamespaceManager manager) { }

private void CreateInstruction(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string propertyName) { }

private void CreateDocumentType(JsonReader reader, IXmlDocument document, IXmlNode currentNode) { }

private IXmlElement CreateElement(string elementName, IXmlDocument document, string elementPrefix, XmlNamespaceManager manager) { }

private void DeserializeNode(JsonReader reader, IXmlDocument document, XmlNamespaceManager manager, IXmlNode currentNode) { }

private bool IsNamespaceAttribute(string attributeName, out string prefix) { }

private bool ValueAttributes(List<IXmlNode> c) { }

public override bool CanConvert(Type valueType) { }

public void .ctor() { }

}

public class XORSwitch : IOEntity // TypeDefIndex: 9805
{
	private int input1Amount; 
	private int input2Amount; 


public void .ctor() { }

}

