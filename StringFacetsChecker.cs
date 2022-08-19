internal class StringFacetsChecker : FacetsChecker // TypeDefIndex: 2252
{	// Fields
	private static Regex languagePattern; // 0x2B0AA90

	// Properties
	private static Regex LanguagePattern { get; }

	// Methods

	// RVA: 0xEEB050 Offset: 0xEEA450 VA: 0x180EEB050
	private static Regex get_LanguagePattern() { }

	// RVA: 0xEEAD30 Offset: 0xEEA130 VA: 0x180EEAD30 Slot: 5
	internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0xEEAAF0 Offset: 0xEE9EF0 VA: 0x180EEAAF0 Slot: 13
	internal override Exception CheckValueFacets(string value, XmlSchemaDatatype datatype) { }

	// RVA: 0xEEAB10 Offset: 0xEE9F10 VA: 0x180EEAB10
	internal Exception CheckValueFacets(string value, XmlSchemaDatatype datatype, bool verifyUri) { }

	// RVA: 0xEEAFC0 Offset: 0xEEA3C0 VA: 0x180EEAFC0 Slot: 17
	internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0xEEADB0 Offset: 0xEEA1B0 VA: 0x180EEADB0
	private bool MatchEnumeration(string value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0xEEA810 Offset: 0xEE9C10 VA: 0x180EEA810
	private Exception CheckBuiltInFacets(string s, XmlTypeCode typeCode, bool verifyUri) { }

	// RVA: 0x7992B0 Offset: 0x7986B0 VA: 0x1807992B0
	public void .ctor() { }

}

