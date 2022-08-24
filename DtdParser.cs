internal class DtdParser : IDtdParser // TypeDefIndex: 1993
{
	private IDtdParserAdapter readerAdapter; 
	private IDtdParserAdapterWithValidation readerAdapterWithValidation; 
	private XmlNameTable nameTable; 
	private SchemaInfo schemaInfo; 
	private XmlCharType xmlCharType; 
	private string systemId; 
	private string publicId; 
	private bool normalize; 
	private bool validate; 
	private bool supportNamespaces; 
	private bool v1Compat; 
	private char[] chars; 
	private int charsUsed; 
	private int curPos; 
	private DtdParser.ScanningFunction scanningFunction; 
	private DtdParser.ScanningFunction nextScaningFunction; 
	private DtdParser.ScanningFunction savedScanningFunction; 
	private bool whitespaceSeen; 
	private int tokenStartPos; 
	private int colonPos; 
	private StringBuilder internalSubsetValueSb; 
	private int externalEntitiesDepth; 
	private int currentEntityId; 
	private bool freeFloatingDtd; 
	private bool hasFreeFloatingInternalSubset; 
	private StringBuilder stringBuilder; 
	private int condSectionDepth; 
	private LineInfo literalLineInfo; 
	private char literalQuoteChar; 
	private string documentBaseUri; 
	private string externalDtdBaseUri; 
	private Dictionary<string, DtdParser.UndeclaredNotation> undeclaredNotations; 
	private int[] condSectionEntityIds; 

	private bool ParsingInternalSubset { get; }
	private bool IgnoreEntityReferences { get; }
	private bool SaveInternalSubsetValue { get; }
	private bool ParsingTopLevelMarkup { get; }
	private bool SupportNamespaces { get; }
	private bool Normalize { get; }
	private int LineNo { get; }
	private int LinePos { get; }
	private string BaseUriStr { get; }


	private void .ctor() { }

	internal static IDtdParser Create() { }

	private void Initialize(IDtdParserAdapter readerAdapter) { }

	private void InitializeFreeFloatingDtd(string baseUri, string docTypeName, string publicId, string systemId, string internalSubset, IDtdParserAdapter adapter) { }

	private IDtdInfo System.Xml.IDtdParser.ParseInternalDtd(IDtdParserAdapter adapter, bool saveInternalSubset) { }

	private IDtdInfo System.Xml.IDtdParser.ParseFreeFloatingDtd(string baseUri, string docTypeName, string publicId, string systemId, string internalSubset, IDtdParserAdapter adapter) { }

	private bool get_ParsingInternalSubset() { }

	private bool get_IgnoreEntityReferences() { }

	private bool get_SaveInternalSubsetValue() { }

	private bool get_ParsingTopLevelMarkup() { }

	private bool get_SupportNamespaces() { }

	private bool get_Normalize() { }

	private void Parse(bool saveInternalSubset) { }

	private void ParseInDocumentDtd(bool saveInternalSubset) { }

	private void ParseFreeFloatingDtd() { }

	private void ParseInternalSubset() { }

	private void ParseExternalSubset() { }

	private void ParseSubset() { }

	private void ParseAttlistDecl() { }

	private void ParseAttlistType(SchemaAttDef attrDef, SchemaElementDecl elementDecl, bool ignoreErrors) { }

	private void ParseAttlistDefault(SchemaAttDef attrDef, bool ignoreErrors) { }

	private void ParseElementDecl() { }

	private void ParseElementOnlyContent(ParticleContentValidator pcv, int startParenEntityId) { }

	private void ParseHowMany(ParticleContentValidator pcv) { }

	private void ParseElementMixedContent(ParticleContentValidator pcv, int startParenEntityId) { }

	private void ParseEntityDecl() { }

	private void ParseNotationDecl() { }

	private void AddUndeclaredNotation(string notationName) { }

	private void ParseComment() { }

	private void ParsePI() { }

	private void ParseCondSection() { }

	private void ParseExternalId(DtdParser.Token idTokenType, DtdParser.Token declType, out string publicId, out string systemId) { }

	private DtdParser.Token GetToken(bool needWhiteSpace) { }

	private DtdParser.Token ScanSubsetContent() { }

	private DtdParser.Token ScanNameExpected() { }

	private DtdParser.Token ScanQNameExpected() { }

	private DtdParser.Token ScanNmtokenExpected() { }

	private DtdParser.Token ScanDoctype1() { }

	private DtdParser.Token ScanDoctype2() { }

	private DtdParser.Token ScanClosingTag() { }

	private DtdParser.Token ScanElement1() { }

	private DtdParser.Token ScanElement2() { }

	private DtdParser.Token ScanElement3() { }

	private DtdParser.Token ScanElement4() { }

	private DtdParser.Token ScanElement5() { }

	private DtdParser.Token ScanElement6() { }

	private DtdParser.Token ScanElement7() { }

	private DtdParser.Token ScanAttlist1() { }

	private DtdParser.Token ScanAttlist2() { }

	private DtdParser.Token ScanAttlist3() { }

	private DtdParser.Token ScanAttlist4() { }

	private DtdParser.Token ScanAttlist5() { }

	private DtdParser.Token ScanAttlist6() { }

	private DtdParser.Token ScanAttlist7() { }

	private DtdParser.Token ScanLiteral(DtdParser.LiteralType literalType) { }

	private XmlQualifiedName ScanEntityName() { }

	private DtdParser.Token ScanNotation1() { }

	private DtdParser.Token ScanSystemId() { }

	private DtdParser.Token ScanEntity1() { }

	private DtdParser.Token ScanEntity2() { }

	private DtdParser.Token ScanEntity3() { }

	private DtdParser.Token ScanPublicId1() { }

	private DtdParser.Token ScanPublicId2() { }

	private DtdParser.Token ScanCondSection1() { }

	private DtdParser.Token ScanCondSection2() { }

	private DtdParser.Token ScanCondSection3() { }

	private void ScanName() { }

	private void ScanQName() { }

	private void ScanQName(bool isQName) { }

	private bool ReadDataInName() { }

	private void ScanNmtoken() { }

	private bool EatPublicKeyword() { }

	private bool EatSystemKeyword() { }

	private XmlQualifiedName GetNameQualified(bool canHavePrefix) { }

	private string GetNameString() { }

	private string GetNmtokenString() { }

	private string GetValue() { }

	private string GetValueWithStrippedSpaces() { }

	private int ReadData() { }

	private void LoadParsingBuffer() { }

	private void SaveParsingBuffer() { }

	private void SaveParsingBuffer(int internalSubsetValueEndPos) { }

	private bool HandleEntityReference(bool paramEntity, bool inLiteral, bool inAttribute) { }

	private bool HandleEntityReference(XmlQualifiedName entityName, bool paramEntity, bool inLiteral, bool inAttribute) { }

	private bool HandleEntityEnd(bool inLiteral) { }

	private SchemaEntity VerifyEntityReference(XmlQualifiedName entityName, bool paramEntity, bool mustBeDeclared, bool inAttribute) { }

	private void SendValidationEvent(int pos, XmlSeverityType severity, string code, string arg) { }

	private void SendValidationEvent(XmlSeverityType severity, string code, string arg) { }

	private void SendValidationEvent(XmlSeverityType severity, XmlSchemaException e) { }

	private bool IsAttributeValueType(DtdParser.Token token) { }

	private int get_LineNo() { }

	private int get_LinePos() { }

	private string get_BaseUriStr() { }

	private void OnUnexpectedError() { }

	private void Throw(int curPos, string res) { }

	private void Throw(int curPos, string res, string arg) { }

	private void Throw(int curPos, string res, string[] args) { }

	private void Throw(string res, string arg, int lineNo, int linePos) { }

	private void ThrowInvalidChar(int pos, string data, int invCharPos) { }

	private void ThrowInvalidChar(char[] data, int length, int invCharPos) { }

	private void ThrowUnexpectedToken(int pos, string expectedToken) { }

	private void ThrowUnexpectedToken(int pos, string expectedToken1, string expectedToken2) { }

	private string ParseUnexpectedToken(int startPos) { }

	internal static string StripSpaces(string value) { }

}

private enum DtdParser.Token // TypeDefIndex: 1994
{
	public int value__; 
	public const DtdParser.Token CDATA = 0;
	public const DtdParser.Token ID = 1;
	public const DtdParser.Token IDREF = 2;
	public const DtdParser.Token IDREFS = 3;
	public const DtdParser.Token ENTITY = 4;
	public const DtdParser.Token ENTITIES = 5;
	public const DtdParser.Token NMTOKEN = 6;
	public const DtdParser.Token NMTOKENS = 7;
	public const DtdParser.Token NOTATION = 8;
	public const DtdParser.Token None = 9;
	public const DtdParser.Token PERef = 10;
	public const DtdParser.Token AttlistDecl = 11;
	public const DtdParser.Token ElementDecl = 12;
	public const DtdParser.Token EntityDecl = 13;
	public const DtdParser.Token NotationDecl = 14;
	public const DtdParser.Token Comment = 15;
	public const DtdParser.Token PI = 16;
	public const DtdParser.Token CondSectionStart = 17;
	public const DtdParser.Token CondSectionEnd = 18;
	public const DtdParser.Token Eof = 19;
	public const DtdParser.Token REQUIRED = 20;
	public const DtdParser.Token IMPLIED = 21;
	public const DtdParser.Token FIXED = 22;
	public const DtdParser.Token QName = 23;
	public const DtdParser.Token Name = 24;
	public const DtdParser.Token Nmtoken = 25;
	public const DtdParser.Token Quote = 26;
	public const DtdParser.Token LeftParen = 27;
	public const DtdParser.Token RightParen = 28;
	public const DtdParser.Token GreaterThan = 29;
	public const DtdParser.Token Or = 30;
	public const DtdParser.Token LeftBracket = 31;
	public const DtdParser.Token RightBracket = 32;
	public const DtdParser.Token PUBLIC = 33;
	public const DtdParser.Token SYSTEM = 34;
	public const DtdParser.Token Literal = 35;
	public const DtdParser.Token DOCTYPE = 36;
	public const DtdParser.Token NData = 37;
	public const DtdParser.Token Percent = 38;
	public const DtdParser.Token Star = 39;
	public const DtdParser.Token QMark = 40;
	public const DtdParser.Token Plus = 41;
	public const DtdParser.Token PCDATA = 42;
	public const DtdParser.Token Comma = 43;
	public const DtdParser.Token ANY = 44;
	public const DtdParser.Token EMPTY = 45;
	public const DtdParser.Token IGNORE = 46;
	public const DtdParser.Token INCLUDE = 47;

}

private enum DtdParser.ScanningFunction // TypeDefIndex: 1995
{
	public int value__; 
	public const DtdParser.ScanningFunction SubsetContent = 0;
	public const DtdParser.ScanningFunction Name = 1;
	public const DtdParser.ScanningFunction QName = 2;
	public const DtdParser.ScanningFunction Nmtoken = 3;
	public const DtdParser.ScanningFunction Doctype1 = 4;
	public const DtdParser.ScanningFunction Doctype2 = 5;
	public const DtdParser.ScanningFunction Element1 = 6;
	public const DtdParser.ScanningFunction Element2 = 7;
	public const DtdParser.ScanningFunction Element3 = 8;
	public const DtdParser.ScanningFunction Element4 = 9;
	public const DtdParser.ScanningFunction Element5 = 10;
	public const DtdParser.ScanningFunction Element6 = 11;
	public const DtdParser.ScanningFunction Element7 = 12;
	public const DtdParser.ScanningFunction Attlist1 = 13;
	public const DtdParser.ScanningFunction Attlist2 = 14;
	public const DtdParser.ScanningFunction Attlist3 = 15;
	public const DtdParser.ScanningFunction Attlist4 = 16;
	public const DtdParser.ScanningFunction Attlist5 = 17;
	public const DtdParser.ScanningFunction Attlist6 = 18;
	public const DtdParser.ScanningFunction Attlist7 = 19;
	public const DtdParser.ScanningFunction Entity1 = 20;
	public const DtdParser.ScanningFunction Entity2 = 21;
	public const DtdParser.ScanningFunction Entity3 = 22;
	public const DtdParser.ScanningFunction Notation1 = 23;
	public const DtdParser.ScanningFunction CondSection1 = 24;
	public const DtdParser.ScanningFunction CondSection2 = 25;
	public const DtdParser.ScanningFunction CondSection3 = 26;
	public const DtdParser.ScanningFunction Literal = 27;
	public const DtdParser.ScanningFunction SystemId = 28;
	public const DtdParser.ScanningFunction PublicId1 = 29;
	public const DtdParser.ScanningFunction PublicId2 = 30;
	public const DtdParser.ScanningFunction ClosingTag = 31;
	public const DtdParser.ScanningFunction ParamEntitySpace = 32;
	public const DtdParser.ScanningFunction None = 33;

}

private enum DtdParser.LiteralType // TypeDefIndex: 1996
{
	public int value__; 
	public const DtdParser.LiteralType AttributeValue = 0;
	public const DtdParser.LiteralType EntityReplText = 1;
	public const DtdParser.LiteralType SystemOrPublicID = 2;

}

private class DtdParser.UndeclaredNotation // TypeDefIndex: 1997
{
	internal string name; 
	internal int lineNo; 
	internal int linePos; 
	internal DtdParser.UndeclaredNotation next; 


	internal void .ctor(string name, int lineNo, int linePos) { }

}

private class DtdParser.ParseElementOnlyContent_LocalFrame // TypeDefIndex: 1998
{
	public int startParenEntityId; 
	public DtdParser.Token parsingSchema; 


	public void .ctor(int startParentEntityIdParam) { }

}

