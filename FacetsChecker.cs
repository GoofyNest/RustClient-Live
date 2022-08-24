internal abstract class FacetsChecker // TypeDefIndex: 2245
{

	internal virtual Exception CheckLexicalFacets(ref string parseString, XmlSchemaDatatype datatype) { }

	internal virtual Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	internal virtual Exception CheckValueFacets(Decimal value, XmlSchemaDatatype datatype) { }

	internal virtual Exception CheckValueFacets(long value, XmlSchemaDatatype datatype) { }

	internal virtual Exception CheckValueFacets(int value, XmlSchemaDatatype datatype) { }

	internal virtual Exception CheckValueFacets(short value, XmlSchemaDatatype datatype) { }

	internal virtual Exception CheckValueFacets(DateTime value, XmlSchemaDatatype datatype) { }

	internal virtual Exception CheckValueFacets(double value, XmlSchemaDatatype datatype) { }

	internal virtual Exception CheckValueFacets(float value, XmlSchemaDatatype datatype) { }

	internal virtual Exception CheckValueFacets(string value, XmlSchemaDatatype datatype) { }

	internal virtual Exception CheckValueFacets(byte[] value, XmlSchemaDatatype datatype) { }

	internal virtual Exception CheckValueFacets(TimeSpan value, XmlSchemaDatatype datatype) { }

	internal virtual Exception CheckValueFacets(XmlQualifiedName value, XmlSchemaDatatype datatype) { }

	internal void CheckWhitespaceFacets(ref string s, XmlSchemaDatatype datatype) { }

	internal Exception CheckPatternFacets(RestrictionFacets restriction, string value) { }

	internal virtual bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	internal virtual RestrictionFacets ConstructRestriction(DatatypeImplementation datatype, XmlSchemaObjectCollection facets, XmlNameTable nameTable) { }

	internal static Decimal Power(int x, int y) { }

	protected void .ctor() { }

}

private struct FacetsChecker.FacetsCompiler // TypeDefIndex: 2246
{
	private DatatypeImplementation datatype; 
	private RestrictionFacets derivedRestriction; 
	private RestrictionFlags baseFlags; 
	private RestrictionFlags baseFixedFlags; 
	private RestrictionFlags validRestrictionFlags; 
	private XmlSchemaDatatype nonNegativeInt; 
	private XmlSchemaDatatype builtInType; 
	private XmlTypeCode builtInEnum; 
	private bool firstPattern; 
	private StringBuilder regStr; 
	private XmlSchemaPatternFacet pattern_facet; 
	private static readonly FacetsChecker.FacetsCompiler.Map[] c_map; 


	public void .ctor(DatatypeImplementation baseDatatype, RestrictionFacets restriction) { }

	internal void CompileLengthFacet(XmlSchemaFacet facet) { }

	internal void CompileMinLengthFacet(XmlSchemaFacet facet) { }

	internal void CompileMaxLengthFacet(XmlSchemaFacet facet) { }

	internal void CompilePatternFacet(XmlSchemaPatternFacet facet) { }

	internal void CompileEnumerationFacet(XmlSchemaFacet facet, IXmlNamespaceResolver nsmgr, XmlNameTable nameTable) { }

	internal void CompileWhitespaceFacet(XmlSchemaFacet facet) { }

	internal void CompileMaxInclusiveFacet(XmlSchemaFacet facet) { }

	internal void CompileMaxExclusiveFacet(XmlSchemaFacet facet) { }

	internal void CompileMinInclusiveFacet(XmlSchemaFacet facet) { }

	internal void CompileMinExclusiveFacet(XmlSchemaFacet facet) { }

	internal void CompileTotalDigitsFacet(XmlSchemaFacet facet) { }

	internal void CompileFractionDigitsFacet(XmlSchemaFacet facet) { }

	internal void FinishFacetCompile() { }

	private void CheckValue(object value, XmlSchemaFacet facet) { }

	internal void CompileFacetCombinations() { }

	private void CopyFacetsFromBaseType() { }

	private object ParseFacetValue(XmlSchemaDatatype datatype, XmlSchemaFacet facet, string code, IXmlNamespaceResolver nsmgr, XmlNameTable nameTable) { }

	private static string Preprocess(string pattern) { }

	private void CheckProhibitedFlag(XmlSchemaFacet facet, RestrictionFlags flag, string errorCode) { }

	private void CheckDupFlag(XmlSchemaFacet facet, RestrictionFlags flag, string errorCode) { }

	private void SetFlag(XmlSchemaFacet facet, RestrictionFlags flag) { }

	private void SetFlag(RestrictionFlags flag) { }

	private static void .cctor() { }

}

private struct FacetsChecker.FacetsCompiler.Map // TypeDefIndex: 2247
{
	internal char match; 
	internal string replacement; 


	internal void .ctor(char m, string r) { }

}

