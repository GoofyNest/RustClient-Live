internal class DtdParser : IDtdParser // TypeDefIndex: 1993
{	// Fields
	private IDtdParserAdapter readerAdapter; // 0x10
	private IDtdParserAdapterWithValidation readerAdapterWithValidation; // 0x18
	private XmlNameTable nameTable; // 0x20
	private SchemaInfo schemaInfo; // 0x28
	private XmlCharType xmlCharType; // 0x30
	private string systemId; // 0x38
	private string publicId; // 0x40
	private bool normalize; // 0x48
	private bool validate; // 0x49
	private bool supportNamespaces; // 0x4A
	private bool v1Compat; // 0x4B
	private char[] chars; // 0x50
	private int charsUsed; // 0x58
	private int curPos; // 0x5C
	private DtdParser.ScanningFunction scanningFunction; // 0x60
	private DtdParser.ScanningFunction nextScaningFunction; // 0x64
	private DtdParser.ScanningFunction savedScanningFunction; // 0x68
	private bool whitespaceSeen; // 0x6C
	private int tokenStartPos; // 0x70
	private int colonPos; // 0x74
	private StringBuilder internalSubsetValueSb; // 0x78
	private int externalEntitiesDepth; // 0x80
	private int currentEntityId; // 0x84
	private bool freeFloatingDtd; // 0x88
	private bool hasFreeFloatingInternalSubset; // 0x89
	private StringBuilder stringBuilder; // 0x90
	private int condSectionDepth; // 0x98
	private LineInfo literalLineInfo; // 0x9C
	private char literalQuoteChar; // 0xA4
	private string documentBaseUri; // 0xA8
	private string externalDtdBaseUri; // 0xB0
	private Dictionary<string, DtdParser.UndeclaredNotation> undeclaredNotations; // 0xB8
	private int[] condSectionEntityIds; // 0xC0

	// Properties
	private bool ParsingInternalSubset { get; }
	private bool IgnoreEntityReferences { get; }
	private bool SaveInternalSubsetValue { get; }
	private bool ParsingTopLevelMarkup { get; }
	private bool SupportNamespaces { get; }
	private bool Normalize { get; }
	private int LineNo { get; }
	private int LinePos { get; }
	private string BaseUriStr { get; }

	// Methods

	// RVA: 0x12EAAC0 Offset: 0x12E9EC0 VA: 0x1812EAAC0
	private void .ctor() { }

	// RVA: 0x12DEF20 Offset: 0x12DE320 VA: 0x1812DEF20
	internal static IDtdParser Create() { }

	// RVA: 0x12E1130 Offset: 0x12E0530 VA: 0x1812E1130
	private void Initialize(IDtdParserAdapter readerAdapter) { }

	// RVA: 0x12E0D70 Offset: 0x12E0170 VA: 0x1812E0D70
	private void InitializeFreeFloatingDtd(string baseUri, string docTypeName, string publicId, string systemId, string internalSubset, IDtdParserAdapter adapter) { }

	// RVA: 0x12E9FC0 Offset: 0x12E93C0 VA: 0x1812E9FC0 Slot: 4
	private IDtdInfo System.Xml.IDtdParser.ParseInternalDtd(IDtdParserAdapter adapter, bool saveInternalSubset) { }

	// RVA: 0x12E9F70 Offset: 0x12E9370 VA: 0x1812E9F70 Slot: 5
	private IDtdInfo System.Xml.IDtdParser.ParseFreeFloatingDtd(string baseUri, string docTypeName, string publicId, string systemId, string internalSubset, IDtdParserAdapter adapter) { }

	// RVA: 0x12EAD40 Offset: 0x12EA140 VA: 0x1812EAD40
	private bool get_ParsingInternalSubset() { }

	// RVA: 0x12EAC80 Offset: 0x12EA080 VA: 0x1812EAC80
	private bool get_IgnoreEntityReferences() { }

	// RVA: 0x12EAD70 Offset: 0x12EA170 VA: 0x1812EAD70
	private bool get_SaveInternalSubsetValue() { }

	// RVA: 0x12EAD50 Offset: 0x12EA150 VA: 0x1812EAD50
	private bool get_ParsingTopLevelMarkup() { }

	// RVA: 0xB9D220 Offset: 0xB9C620 VA: 0x180B9D220
	private bool get_SupportNamespaces() { }

	// RVA: 0x4B9270 Offset: 0x4B8670 VA: 0x1804B9270
	private bool get_Normalize() { }

	// RVA: 0x12E4810 Offset: 0x12E3C10 VA: 0x1812E4810
	private void Parse(bool saveInternalSubset) { }

	// RVA: 0x12E3DC0 Offset: 0x12E31C0 VA: 0x1812E3DC0
	private void ParseInDocumentDtd(bool saveInternalSubset) { }

	// RVA: 0x12E3CF0 Offset: 0x12E30F0 VA: 0x1812E3CF0
	private void ParseFreeFloatingDtd() { }

	// RVA: 0x12E3F30 Offset: 0x12E3330 VA: 0x1812E3F30
	private void ParseInternalSubset() { }

	// RVA: 0x12E3B70 Offset: 0x12E2F70 VA: 0x1812E3B70
	private void ParseExternalSubset() { }

	// RVA: 0x12E4240 Offset: 0x12E3640 VA: 0x1812E4240
	private void ParseSubset() { }

	// RVA: 0x12E1550 Offset: 0x12E0950 VA: 0x1812E1550
	private void ParseAttlistDecl() { }

	// RVA: 0x12E1CE0 Offset: 0x12E10E0 VA: 0x1812E1CE0
	private void ParseAttlistType(SchemaAttDef attrDef, SchemaElementDecl elementDecl, bool ignoreErrors) { }

	// RVA: 0x12E1AB0 Offset: 0x12E0EB0 VA: 0x1812E1AB0
	private void ParseAttlistDefault(SchemaAttDef attrDef, bool ignoreErrors) { }

	// RVA: 0x12E27B0 Offset: 0x12E1BB0 VA: 0x1812E27B0
	private void ParseElementDecl() { }

	// RVA: 0x12E2E80 Offset: 0x12E2280 VA: 0x1812E2E80
	private void ParseElementOnlyContent(ParticleContentValidator pcv, int startParenEntityId) { }

	// RVA: 0x12E3D50 Offset: 0x12E3150 VA: 0x1812E3D50
	private void ParseHowMany(ParticleContentValidator pcv) { }

	// RVA: 0x12E2B90 Offset: 0x12E1F90 VA: 0x1812E2B90
	private void ParseElementMixedContent(ParticleContentValidator pcv, int startParenEntityId) { }

	// RVA: 0x12E3290 Offset: 0x12E2690 VA: 0x1812E3290
	private void ParseEntityDecl() { }

	// RVA: 0x12E3F40 Offset: 0x12E3340 VA: 0x1812E3F40
	private void ParseNotationDecl() { }

	// RVA: 0x12DED30 Offset: 0x12DE130 VA: 0x1812DED30
	private void AddUndeclaredNotation(string notationName) { }

	// RVA: 0x12E2370 Offset: 0x12E1770 VA: 0x1812E2370
	private void ParseComment() { }

	// RVA: 0x12E4140 Offset: 0x12E3540 VA: 0x1812E4140
	private void ParsePI() { }

	// RVA: 0x12E2500 Offset: 0x12E1900 VA: 0x1812E2500
	private void ParseCondSection() { }

	// RVA: 0x12E3600 Offset: 0x12E2A00 VA: 0x1812E3600
	private void ParseExternalId(DtdParser.Token idTokenType, DtdParser.Token declType, out string publicId, out string systemId) { }

	// RVA: 0x12DF450 Offset: 0x12DE850 VA: 0x1812DF450
	private DtdParser.Token GetToken(bool needWhiteSpace) { }

	// RVA: 0x12E9010 Offset: 0x12E8410 VA: 0x1812E9010
	private DtdParser.Token ScanSubsetContent() { }

	// RVA: 0x12E8810 Offset: 0x12E7C10 VA: 0x1812E8810
	private DtdParser.Token ScanNameExpected() { }

	// RVA: 0x12E8C80 Offset: 0x12E8080 VA: 0x1812E8C80
	private DtdParser.Token ScanQNameExpected() { }

	// RVA: 0x12E8850 Offset: 0x12E7C50 VA: 0x1812E8850
	private DtdParser.Token ScanNmtokenExpected() { }

	// RVA: 0x12E6A90 Offset: 0x12E5E90 VA: 0x1812E6A90
	private DtdParser.Token ScanDoctype1() { }

	// RVA: 0x12E6BD0 Offset: 0x12E5FD0 VA: 0x1812E6BD0
	private DtdParser.Token ScanDoctype2() { }

	// RVA: 0x12E5F00 Offset: 0x12E5300 VA: 0x1812E5F00
	private DtdParser.Token ScanClosingTag() { }

	// RVA: 0x12E6C80 Offset: 0x12E6080 VA: 0x1812E6C80
	private DtdParser.Token ScanElement1() { }

	// RVA: 0x12E6F90 Offset: 0x12E6390 VA: 0x1812E6F90
	private DtdParser.Token ScanElement2() { }

	// RVA: 0x12E7210 Offset: 0x12E6610 VA: 0x1812E7210
	private DtdParser.Token ScanElement3() { }

	// RVA: 0x12E72A0 Offset: 0x12E66A0 VA: 0x1812E72A0
	private DtdParser.Token ScanElement4() { }

	// RVA: 0x12E73C0 Offset: 0x12E67C0 VA: 0x1812E73C0
	private DtdParser.Token ScanElement5() { }

	// RVA: 0x12E74C0 Offset: 0x12E68C0 VA: 0x1812E74C0
	private DtdParser.Token ScanElement6() { }

	// RVA: 0x12E7590 Offset: 0x12E6990 VA: 0x1812E7590
	private DtdParser.Token ScanElement7() { }

	// RVA: 0x12E4D10 Offset: 0x12E4110 VA: 0x1812E4D10
	private DtdParser.Token ScanAttlist1() { }

	// RVA: 0x12E4DF0 Offset: 0x12E41F0 VA: 0x1812E4DF0
	private DtdParser.Token ScanAttlist2() { }

	// RVA: 0x12E56C0 Offset: 0x12E4AC0 VA: 0x1812E56C0
	private DtdParser.Token ScanAttlist3() { }

	// RVA: 0x12E5760 Offset: 0x12E4B60 VA: 0x1812E5760
	private DtdParser.Token ScanAttlist4() { }

	// RVA: 0x12E5830 Offset: 0x12E4C30 VA: 0x1812E5830
	private DtdParser.Token ScanAttlist5() { }

	// RVA: 0x12E5900 Offset: 0x12E4D00 VA: 0x1812E5900
	private DtdParser.Token ScanAttlist6() { }

	// RVA: 0x12E5E50 Offset: 0x12E5250 VA: 0x1812E5E50
	private DtdParser.Token ScanAttlist7() { }

	// RVA: 0x12E7A00 Offset: 0x12E6E00 VA: 0x1812E7A00
	private DtdParser.Token ScanLiteral(DtdParser.LiteralType literalType) { }

	// RVA: 0x12E7900 Offset: 0x12E6D00 VA: 0x1812E7900
	private XmlQualifiedName ScanEntityName() { }

	// RVA: 0x12E8A60 Offset: 0x12E7E60 VA: 0x1812E8A60
	private DtdParser.Token ScanNotation1() { }

	// RVA: 0x12E9950 Offset: 0x12E8D50 VA: 0x1812E9950
	private DtdParser.Token ScanSystemId() { }

	// RVA: 0x12E75F0 Offset: 0x12E69F0 VA: 0x1812E75F0
	private DtdParser.Token ScanEntity1() { }

	// RVA: 0x12E7670 Offset: 0x12E6A70 VA: 0x1812E7670
	private DtdParser.Token ScanEntity2() { }

	// RVA: 0x12E77B0 Offset: 0x12E6BB0 VA: 0x1812E77B0
	private DtdParser.Token ScanEntity3() { }

	// RVA: 0x12E8B60 Offset: 0x12E7F60 VA: 0x1812E8B60
	private DtdParser.Token ScanPublicId1() { }

	// RVA: 0x12E8C00 Offset: 0x12E8000 VA: 0x1812E8C00
	private DtdParser.Token ScanPublicId2() { }

	// RVA: 0x12E5F90 Offset: 0x12E5390 VA: 0x1812E5F90
	private DtdParser.Token ScanCondSection1() { }

	// RVA: 0x12E63B0 Offset: 0x12E57B0 VA: 0x1812E63B0
	private DtdParser.Token ScanCondSection2() { }

	// RVA: 0x12E6440 Offset: 0x12E5840 VA: 0x1812E6440
	private DtdParser.Token ScanCondSection3() { }

	// RVA: 0x12E8840 Offset: 0x12E7C40 VA: 0x1812E8840
	private void ScanName() { }

	// RVA: 0x12E9000 Offset: 0x12E8400 VA: 0x1812E9000
	private void ScanQName() { }

	// RVA: 0x12E8CB0 Offset: 0x12E80B0 VA: 0x1812E8CB0
	private void ScanQName(bool isQName) { }

	// RVA: 0x12E4B60 Offset: 0x12E3F60 VA: 0x1812E4B60
	private bool ReadDataInName() { }

	// RVA: 0x12E8880 Offset: 0x12E7C80 VA: 0x1812E8880
	private void ScanNmtoken() { }

	// RVA: 0x12DF060 Offset: 0x12DE460 VA: 0x1812DF060
	private bool EatPublicKeyword() { }

	// RVA: 0x12DF170 Offset: 0x12DE570 VA: 0x1812DF170
	private bool EatSystemKeyword() { }

	// RVA: 0x12DF280 Offset: 0x12DE680 VA: 0x1812DF280
	private XmlQualifiedName GetNameQualified(bool canHavePrefix) { }

	// RVA: 0x12DF420 Offset: 0x12DE820 VA: 0x1812DF420
	private string GetNameString() { }

	// RVA: 0x12DF420 Offset: 0x12DE820 VA: 0x1812DF420
	private string GetNmtokenString() { }

	// RVA: 0x12E08F0 Offset: 0x12DFCF0 VA: 0x1812E08F0
	private string GetValue() { }

	// RVA: 0x12E0860 Offset: 0x12DFC60 VA: 0x1812E0860
	private string GetValueWithStrippedSpaces() { }

	// RVA: 0x12E4BB0 Offset: 0x12E3FB0 VA: 0x1812E4BB0
	private int ReadData() { }

	// RVA: 0x12E13B0 Offset: 0x12E07B0 VA: 0x1812E13B0
	private void LoadParsingBuffer() { }

	// RVA: 0x12E4C20 Offset: 0x12E4020 VA: 0x1812E4C20
	private void SaveParsingBuffer() { }

	// RVA: 0x12E4C30 Offset: 0x12E4030 VA: 0x1812E4C30
	private void SaveParsingBuffer(int internalSubsetValueEndPos) { }

	// RVA: 0x12E0AB0 Offset: 0x12DFEB0 VA: 0x1812E0AB0
	private bool HandleEntityReference(bool paramEntity, bool inLiteral, bool inAttribute) { }

	// RVA: 0x12E0B20 Offset: 0x12DFF20 VA: 0x1812E0B20
	private bool HandleEntityReference(XmlQualifiedName entityName, bool paramEntity, bool inLiteral, bool inAttribute) { }

	// RVA: 0x12E0960 Offset: 0x12DFD60 VA: 0x1812E0960
	private bool HandleEntityEnd(bool inLiteral) { }

	// RVA: 0x12EA8B0 Offset: 0x12E9CB0 VA: 0x1812EA8B0
	private SchemaEntity VerifyEntityReference(XmlQualifiedName entityName, bool paramEntity, bool mustBeDeclared, bool inAttribute) { }

	// RVA: 0x12E99F0 Offset: 0x12E8DF0 VA: 0x1812E99F0
	private void SendValidationEvent(int pos, XmlSeverityType severity, string code, string arg) { }

	// RVA: 0x12E9C40 Offset: 0x12E9040 VA: 0x1812E9C40
	private void SendValidationEvent(XmlSeverityType severity, string code, string arg) { }

	// RVA: 0x12E9B50 Offset: 0x12E8F50 VA: 0x1812E9B50
	private void SendValidationEvent(XmlSeverityType severity, XmlSchemaException e) { }

	// RVA: 0x12E13A0 Offset: 0x12E07A0 VA: 0x1812E13A0
	private bool IsAttributeValueType(DtdParser.Token token) { }

	// RVA: 0x12EAC90 Offset: 0x12EA090 VA: 0x1812EAC90
	private int get_LineNo() { }

	// RVA: 0x12EACE0 Offset: 0x12EA0E0 VA: 0x1812EACE0
	private int get_LinePos() { }

	// RVA: 0x12EABD0 Offset: 0x12E9FD0 VA: 0x1812EABD0
	private string get_BaseUriStr() { }

	// RVA: 0x12E14C0 Offset: 0x12E08C0 VA: 0x1812E14C0
	private void OnUnexpectedError() { }

	// RVA: 0x12EA560 Offset: 0x12E9960 VA: 0x1812EA560
	private void Throw(int curPos, string res) { }

	// RVA: 0x12EA700 Offset: 0x12E9B00 VA: 0x1812EA700
	private void Throw(int curPos, string res, string arg) { }

	// RVA: 0x12EA3B0 Offset: 0x12E97B0 VA: 0x1812EA3B0
	private void Throw(int curPos, string res, string[] args) { }

	// RVA: 0x12EA5D0 Offset: 0x12E99D0 VA: 0x1812EA5D0
	private void Throw(string res, string arg, int lineNo, int linePos) { }

	// RVA: 0x12EA000 Offset: 0x12E9400 VA: 0x1812EA000
	private void ThrowInvalidChar(int pos, string data, int invCharPos) { }

	// RVA: 0x12EA080 Offset: 0x12E9480 VA: 0x1812EA080
	private void ThrowInvalidChar(char[] data, int length, int invCharPos) { }

	// RVA: 0x12EA100 Offset: 0x12E9500 VA: 0x1812EA100
	private void ThrowUnexpectedToken(int pos, string expectedToken) { }

	// RVA: 0x12EA120 Offset: 0x12E9520 VA: 0x1812EA120
	private void ThrowUnexpectedToken(int pos, string expectedToken1, string expectedToken2) { }

	// RVA: 0x12E4720 Offset: 0x12E3B20 VA: 0x1812E4720
	private string ParseUnexpectedToken(int startPos) { }

	// RVA: 0x12E9D90 Offset: 0x12E9190 VA: 0x1812E9D90
	internal static string StripSpaces(string value) { }

}

private enum DtdParser.Token // TypeDefIndex: 1994
{	// Fields
	public int value__; // 0x0
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
{	// Fields
	public int value__; // 0x0
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
{	// Fields
	public int value__; // 0x0
	public const DtdParser.LiteralType AttributeValue = 0;
	public const DtdParser.LiteralType EntityReplText = 1;
	public const DtdParser.LiteralType SystemOrPublicID = 2;

}

private class DtdParser.UndeclaredNotation // TypeDefIndex: 1997
{	// Fields
	internal string name; // 0x10
	internal int lineNo; // 0x18
	internal int linePos; // 0x1C
	internal DtdParser.UndeclaredNotation next; // 0x20

	// Methods

	// RVA: 0x12EF240 Offset: 0x12EE640 VA: 0x1812EF240
	internal void .ctor(string name, int lineNo, int linePos) { }

}

private class DtdParser.ParseElementOnlyContent_LocalFrame // TypeDefIndex: 1998
{	// Fields
	public int startParenEntityId; // 0x10
	public DtdParser.Token parsingSchema; // 0x14

	// Methods

	// RVA: 0x12EF190 Offset: 0x12EE590 VA: 0x1812EF190
	public void .ctor(int startParentEntityIdParam) { }

}

