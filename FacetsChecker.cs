internal abstract class FacetsChecker // TypeDefIndex: 2245
{	// Methods

	// RVA: 0x15328B0 Offset: 0x1531CB0 VA: 0x1815328B0 Slot: 4
	internal virtual Exception CheckLexicalFacets(ref string parseString, XmlSchemaDatatype datatype) { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 5
	internal virtual Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 6
	internal virtual Exception CheckValueFacets(Decimal value, XmlSchemaDatatype datatype) { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 7
	internal virtual Exception CheckValueFacets(long value, XmlSchemaDatatype datatype) { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 8
	internal virtual Exception CheckValueFacets(int value, XmlSchemaDatatype datatype) { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 9
	internal virtual Exception CheckValueFacets(short value, XmlSchemaDatatype datatype) { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 10
	internal virtual Exception CheckValueFacets(DateTime value, XmlSchemaDatatype datatype) { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 11
	internal virtual Exception CheckValueFacets(double value, XmlSchemaDatatype datatype) { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 12
	internal virtual Exception CheckValueFacets(float value, XmlSchemaDatatype datatype) { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 13
	internal virtual Exception CheckValueFacets(string value, XmlSchemaDatatype datatype) { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 14
	internal virtual Exception CheckValueFacets(byte[] value, XmlSchemaDatatype datatype) { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 15
	internal virtual Exception CheckValueFacets(TimeSpan value, XmlSchemaDatatype datatype) { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 16
	internal virtual Exception CheckValueFacets(XmlQualifiedName value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1532AB0 Offset: 0x1531EB0 VA: 0x181532AB0
	internal void CheckWhitespaceFacets(ref string s, XmlSchemaDatatype datatype) { }

	// RVA: 0x1532910 Offset: 0x1531D10 VA: 0x181532910
	internal Exception CheckPatternFacets(RestrictionFacets restriction, string value) { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 17
	internal virtual bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x1532BA0 Offset: 0x1531FA0 VA: 0x181532BA0 Slot: 18
	internal virtual RestrictionFacets ConstructRestriction(DatatypeImplementation datatype, XmlSchemaObjectCollection facets, XmlNameTable nameTable) { }

	// RVA: 0x1533330 Offset: 0x1532730 VA: 0x181533330
	internal static Decimal Power(int x, int y) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	protected void .ctor() { }

}

private struct FacetsChecker.FacetsCompiler // TypeDefIndex: 2246
{	// Fields
	private DatatypeImplementation datatype; // 0x0
	private RestrictionFacets derivedRestriction; // 0x8
	private RestrictionFlags baseFlags; // 0x10
	private RestrictionFlags baseFixedFlags; // 0x14
	private RestrictionFlags validRestrictionFlags; // 0x18
	private XmlSchemaDatatype nonNegativeInt; // 0x20
	private XmlSchemaDatatype builtInType; // 0x28
	private XmlTypeCode builtInEnum; // 0x30
	private bool firstPattern; // 0x34
	private StringBuilder regStr; // 0x38
	private XmlSchemaPatternFacet pattern_facet; // 0x40
	private static readonly FacetsChecker.FacetsCompiler.Map[] c_map; // 0x0

	// Methods

	// RVA: 0x1F1BE0 Offset: 0x1F0FE0 VA: 0x1801F1BE0
	public void .ctor(DatatypeImplementation baseDatatype, RestrictionFacets restriction) { }

	// RVA: 0x1F1A80 Offset: 0x1F0E80 VA: 0x1801F1A80
	internal void CompileLengthFacet(XmlSchemaFacet facet) { }

	// RVA: 0x1F1AE0 Offset: 0x1F0EE0 VA: 0x1801F1AE0
	internal void CompileMinLengthFacet(XmlSchemaFacet facet) { }

	// RVA: 0x1F1AB0 Offset: 0x1F0EB0 VA: 0x1801F1AB0
	internal void CompileMaxLengthFacet(XmlSchemaFacet facet) { }

	// RVA: 0x1F1AF0 Offset: 0x1F0EF0 VA: 0x1801F1AF0
	internal void CompilePatternFacet(XmlSchemaPatternFacet facet) { }

	// RVA: 0x1F1A50 Offset: 0x1F0E50 VA: 0x1801F1A50
	internal void CompileEnumerationFacet(XmlSchemaFacet facet, IXmlNamespaceResolver nsmgr, XmlNameTable nameTable) { }

	// RVA: 0x1F1B10 Offset: 0x1F0F10 VA: 0x1801F1B10
	internal void CompileWhitespaceFacet(XmlSchemaFacet facet) { }

	// RVA: 0x1F1AA0 Offset: 0x1F0EA0 VA: 0x1801F1AA0
	internal void CompileMaxInclusiveFacet(XmlSchemaFacet facet) { }

	// RVA: 0x1F1A90 Offset: 0x1F0E90 VA: 0x1801F1A90
	internal void CompileMaxExclusiveFacet(XmlSchemaFacet facet) { }

	// RVA: 0x1F1AD0 Offset: 0x1F0ED0 VA: 0x1801F1AD0
	internal void CompileMinInclusiveFacet(XmlSchemaFacet facet) { }

	// RVA: 0x1F1AC0 Offset: 0x1F0EC0 VA: 0x1801F1AC0
	internal void CompileMinExclusiveFacet(XmlSchemaFacet facet) { }

	// RVA: 0x1F1B00 Offset: 0x1F0F00 VA: 0x1801F1B00
	internal void CompileTotalDigitsFacet(XmlSchemaFacet facet) { }

	// RVA: 0x1F1A70 Offset: 0x1F0E70 VA: 0x1801F1A70
	internal void CompileFractionDigitsFacet(XmlSchemaFacet facet) { }

	// RVA: 0x1F1B30 Offset: 0x1F0F30 VA: 0x1801F1B30
	internal void FinishFacetCompile() { }

	// RVA: 0x1F1A40 Offset: 0x1F0E40 VA: 0x1801F1A40
	private void CheckValue(object value, XmlSchemaFacet facet) { }

	// RVA: 0x1F1A60 Offset: 0x1F0E60 VA: 0x1801F1A60
	internal void CompileFacetCombinations() { }

	// RVA: 0x1F1B20 Offset: 0x1F0F20 VA: 0x1801F1B20
	private void CopyFacetsFromBaseType() { }

	// RVA: 0x1F1B40 Offset: 0x1F0F40 VA: 0x1801F1B40
	private object ParseFacetValue(XmlSchemaDatatype datatype, XmlSchemaFacet facet, string code, IXmlNamespaceResolver nsmgr, XmlNameTable nameTable) { }

	// RVA: 0x15365A0 Offset: 0x15359A0 VA: 0x1815365A0
	private static string Preprocess(string pattern) { }

	// RVA: 0x1F1A30 Offset: 0x1F0E30 VA: 0x1801F1A30
	private void CheckProhibitedFlag(XmlSchemaFacet facet, RestrictionFlags flag, string errorCode) { }

	// RVA: 0x1F1A20 Offset: 0x1F0E20 VA: 0x1801F1A20
	private void CheckDupFlag(XmlSchemaFacet facet, RestrictionFlags flag, string errorCode) { }

	// RVA: 0x1F1B50 Offset: 0x1F0F50 VA: 0x1801F1B50
	private void SetFlag(XmlSchemaFacet facet, RestrictionFlags flag) { }

	// RVA: 0x1F1BB0 Offset: 0x1F0FB0 VA: 0x1801F1BB0
	private void SetFlag(RestrictionFlags flag) { }

	// RVA: 0x1536870 Offset: 0x1535C70 VA: 0x181536870
	private static void .cctor() { }

}

private struct FacetsChecker.FacetsCompiler.Map // TypeDefIndex: 2247
{	// Fields
	internal char match; // 0x0
	internal string replacement; // 0x8

	// Methods

	// RVA: 0xFC8F0 Offset: 0xFBCF0 VA: 0x1800FC8F0
	internal void .ctor(char m, string r) { }

}

