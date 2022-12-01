internal class StringFacetsChecker : FacetsChecker // TypeDefIndex: 2252
{
	private static Regex languagePattern;

	private static Regex LanguagePattern { get; }


	private static Regex get_LanguagePattern() { }

	internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	internal override Exception CheckValueFacets(string value, XmlSchemaDatatype datatype) { }

	internal Exception CheckValueFacets(string value, XmlSchemaDatatype datatype, bool verifyUri) { }

	internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	private bool MatchEnumeration(string value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	private Exception CheckBuiltInFacets(string s, XmlTypeCode typeCode, bool verifyUri) { }

	public void .ctor() { }

}

