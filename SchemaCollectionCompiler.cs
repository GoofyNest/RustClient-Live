internal sealed class SchemaCollectionCompiler : BaseProcessor // TypeDefIndex: 2272
{	// Fields
	private bool compileContentModel; // 0x40
	private XmlSchemaObjectTable examplars; // 0x48
	private Stack complexTypeStack; // 0x50
	private XmlSchema schema; // 0x58

	// Methods

	// RVA: 0xB36EC0 Offset: 0xB362C0 VA: 0x180B36EC0
	public void .ctor(XmlNameTable nameTable, ValidationEventHandler eventHandler) { }

	// RVA: 0xB33880 Offset: 0xB32C80 VA: 0x180B33880
	public bool Execute(XmlSchema schema, SchemaInfo schemaInfo, bool compileContentModel) { }

	// RVA: 0xB36B60 Offset: 0xB35F60 VA: 0x180B36B60
	private void Prepare() { }

	// RVA: 0xB289B0 Offset: 0xB27DB0 VA: 0x180B289B0
	private void Cleanup() { }

	// RVA: 0xB29660 Offset: 0xB28A60 VA: 0x180B29660
	internal static void Cleanup(XmlSchema schema) { }

	// RVA: 0xB31410 Offset: 0xB30810 VA: 0x180B31410
	private void Compile() { }

	// RVA: 0xB35F10 Offset: 0xB35310 VA: 0x180B35F10
	private void Output(SchemaInfo schemaInfo) { }

	// RVA: 0xB27EE0 Offset: 0xB272E0 VA: 0x180B27EE0
	private static void CleanupAttribute(XmlSchemaAttribute attribute) { }

	// RVA: 0xB27E80 Offset: 0xB27280 VA: 0x180B27E80
	private static void CleanupAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0xB28030 Offset: 0xB27430 VA: 0x180B28030
	private static void CleanupComplexType(XmlSchemaComplexType complexType) { }

	// RVA: 0xB28990 Offset: 0xB27D90 VA: 0x180B28990
	private static void CleanupSimpleType(XmlSchemaSimpleType simpleType) { }

	// RVA: 0xB284F0 Offset: 0xB278F0 VA: 0x180B284F0
	private static void CleanupElement(XmlSchemaElement element) { }

	// RVA: 0xB27F30 Offset: 0xB27330 VA: 0x180B27F30
	private static void CleanupAttributes(XmlSchemaObjectCollection attributes) { }

	// RVA: 0xB28700 Offset: 0xB27B00 VA: 0x180B28700
	private static void CleanupGroup(XmlSchemaGroup group) { }

	// RVA: 0xB28740 Offset: 0xB27B40 VA: 0x180B28740
	private static void CleanupParticle(XmlSchemaParticle particle) { }

	// RVA: 0xB30ED0 Offset: 0xB302D0 VA: 0x180B30ED0
	private void CompileSubstitutionGroup(XmlSchemaSubstitutionGroupV1Compat substitutionGroup) { }

	// RVA: 0xB27B10 Offset: 0xB26F10 VA: 0x180B27B10
	private void CheckSubstitutionGroup(XmlSchemaSubstitutionGroup substitutionGroup) { }

	// RVA: 0xB2E490 Offset: 0xB2D890 VA: 0x180B2E490
	private void CompileGroup(XmlSchemaGroup group) { }

	// RVA: 0xB30650 Offset: 0xB2FA50 VA: 0x180B30650
	private void CompileSimpleType(XmlSchemaSimpleType simpleType) { }

	// RVA: 0xB2B030 Offset: 0xB2A430 VA: 0x180B2B030
	private XmlSchemaSimpleType[] CompileBaseMemberTypes(XmlSchemaSimpleType simpleType) { }

	// RVA: 0xB27D50 Offset: 0xB27150 VA: 0x180B27D50
	private void CheckUnionType(XmlSchemaSimpleType unionMember, ArrayList memberTypeDefinitions, XmlSchemaSimpleType parentType) { }

	// RVA: 0xB2CB40 Offset: 0xB2BF40 VA: 0x180B2CB40
	private void CompileComplexType(XmlSchemaComplexType complexType) { }

	// RVA: 0xB2FFD0 Offset: 0xB2F3D0 VA: 0x180B2FFD0
	private void CompileSimpleContentExtension(XmlSchemaComplexType complexType, XmlSchemaSimpleContentExtension simpleExtension) { }

	// RVA: 0xB30260 Offset: 0xB2F660 VA: 0x180B30260
	private void CompileSimpleContentRestriction(XmlSchemaComplexType complexType, XmlSchemaSimpleContentRestriction simpleRestriction) { }

	// RVA: 0xB2B590 Offset: 0xB2A990 VA: 0x180B2B590
	private void CompileComplexContentExtension(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaComplexContentExtension complexExtension) { }

	// RVA: 0xB2BA30 Offset: 0xB2AE30 VA: 0x180B2BA30
	private void CompileComplexContentRestriction(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaComplexContentRestriction complexRestriction) { }

	// RVA: 0xB279C0 Offset: 0xB26DC0 VA: 0x180B279C0
	private void CheckParticleDerivation(XmlSchemaComplexType complexType) { }

	// RVA: 0xB2D640 Offset: 0xB2CA40 VA: 0x180B2D640
	private XmlSchemaParticle CompileContentTypeParticle(XmlSchemaParticle particle, bool substitution) { }

	// RVA: 0xB26FE0 Offset: 0xB263E0 VA: 0x180B26FE0
	private XmlSchemaParticle CannonicalizeParticle(XmlSchemaParticle particle, bool root, bool substitution) { }

	// RVA: 0xB26790 Offset: 0xB25B90 VA: 0x180B26790
	private XmlSchemaParticle CannonicalizeElement(XmlSchemaElement element, bool substitution) { }

	// RVA: 0xB26950 Offset: 0xB25D50 VA: 0x180B26950
	private XmlSchemaParticle CannonicalizeGroupRef(XmlSchemaGroupRef groupRef, bool root, bool substitution) { }

	// RVA: 0xB25B60 Offset: 0xB24F60 VA: 0x180B25B60
	private XmlSchemaParticle CannonicalizeAll(XmlSchemaAll all, bool root, bool substitution) { }

	// RVA: 0xB260F0 Offset: 0xB254F0 VA: 0x180B260F0
	private XmlSchemaParticle CannonicalizeChoice(XmlSchemaChoice choice, bool root, bool substitution) { }

	// RVA: 0xB27390 Offset: 0xB26790 VA: 0x180B27390
	private XmlSchemaParticle CannonicalizeSequence(XmlSchemaSequence sequence, bool root, bool substitution) { }

	// RVA: 0xB352E0 Offset: 0xB346E0 VA: 0x180B352E0
	private bool IsValidRestriction(XmlSchemaParticle derivedParticle, XmlSchemaParticle baseParticle) { }

	// RVA: 0xB33F90 Offset: 0xB33390 VA: 0x180B33F90
	private bool IsElementFromElement(XmlSchemaElement derivedElement, XmlSchemaElement baseElement) { }

	// RVA: 0xB33F20 Offset: 0xB33320 VA: 0x180B33F20
	private bool IsElementFromAny(XmlSchemaElement derivedElement, XmlSchemaAny baseAny) { }

	// RVA: 0xB33EC0 Offset: 0xB332C0 VA: 0x180B33EC0
	private bool IsAnyFromAny(XmlSchemaAny derivedAny, XmlSchemaAny baseAny) { }

	// RVA: 0xB34460 Offset: 0xB33860 VA: 0x180B34460
	private bool IsGroupBaseFromAny(XmlSchemaGroupBase derivedGroupBase, XmlSchemaAny baseAny) { }

	// RVA: 0xB340C0 Offset: 0xB334C0 VA: 0x180B340C0
	private bool IsElementFromGroupBase(XmlSchemaElement derivedElement, XmlSchemaGroupBase baseGroupBase, bool skipEmptableOnly) { }

	// RVA: 0xB34730 Offset: 0xB33B30 VA: 0x180B34730
	private bool IsGroupBaseFromGroupBase(XmlSchemaGroupBase derivedGroupBase, XmlSchemaGroupBase baseGroupBase, bool skipEmptableOnly) { }

	// RVA: 0xB34AC0 Offset: 0xB33EC0 VA: 0x180B34AC0
	private bool IsSequenceFromAll(XmlSchemaSequence derivedSequence, XmlSchemaAll baseAll) { }

	// RVA: 0xB34E10 Offset: 0xB34210 VA: 0x180B34E10
	private bool IsSequenceFromChoice(XmlSchemaSequence derivedSequence, XmlSchemaChoice baseChoice) { }

	// RVA: 0xB25710 Offset: 0xB24B10 VA: 0x180B25710
	private void CalculateSequenceRange(XmlSchemaSequence sequence, out Decimal minOccurs, out Decimal maxOccurs) { }

	// RVA: 0xB350E0 Offset: 0xB344E0 VA: 0x180B350E0
	private bool IsValidOccurrenceRangeRestriction(XmlSchemaParticle derivedParticle, XmlSchemaParticle baseParticle) { }

	// RVA: 0xB35200 Offset: 0xB34600 VA: 0x180B35200
	private bool IsValidOccurrenceRangeRestriction(Decimal minOccurs, Decimal maxOccurs, Decimal baseMinOccurs, Decimal baseMaxOccurs) { }

	// RVA: 0xB33BB0 Offset: 0xB32FB0 VA: 0x180B33BB0
	private int GetMappingParticle(XmlSchemaParticle particle, XmlSchemaObjectCollection collection) { }

	// RVA: 0xB34A00 Offset: 0xB33E00 VA: 0x180B34A00
	private bool IsParticleEmptiable(XmlSchemaParticle particle) { }

	// RVA: 0xB24DF0 Offset: 0xB241F0 VA: 0x180B24DF0
	private void CalculateEffectiveTotalRange(XmlSchemaParticle particle, out Decimal minOccurs, out Decimal maxOccurs) { }

	// RVA: 0xB36E90 Offset: 0xB36290 VA: 0x180B36E90
	private void PushComplexType(XmlSchemaComplexType complexType) { }

	// RVA: 0xB33CC0 Offset: 0xB330C0 VA: 0x180B33CC0
	private XmlSchemaContentType GetSchemaContentType(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaParticle particle) { }

	// RVA: 0xB29FC0 Offset: 0xB293C0 VA: 0x180B29FC0
	private void CompileAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0xB2EB40 Offset: 0xB2DF40 VA: 0x180B2EB40
	private void CompileLocalAttributes(XmlSchemaComplexType baseType, XmlSchemaComplexType derivedType, XmlSchemaObjectCollection attributes, XmlSchemaAnyAttribute anyAttribute, XmlSchemaDerivationMethod derivedBy) { }

	// RVA: 0xB29F20 Offset: 0xB29320 VA: 0x180B29F20
	private XmlSchemaAnyAttribute CompileAnyAttributeUnion(XmlSchemaAnyAttribute a, XmlSchemaAnyAttribute b) { }

	// RVA: 0xB29E80 Offset: 0xB29280 VA: 0x180B29E80
	private XmlSchemaAnyAttribute CompileAnyAttributeIntersection(XmlSchemaAnyAttribute a, XmlSchemaAnyAttribute b) { }

	// RVA: 0xB2A6B0 Offset: 0xB29AB0 VA: 0x180B2A6B0
	private void CompileAttribute(XmlSchemaAttribute xa) { }

	// RVA: 0xB2E580 Offset: 0xB2D980 VA: 0x180B2E580
	private void CompileIdentityConstraint(XmlSchemaIdentityConstraint xi) { }

	// RVA: 0xB2D7F0 Offset: 0xB2CBF0 VA: 0x180B2D7F0
	private void CompileElement(XmlSchemaElement xe) { }

	// RVA: 0xB2BD50 Offset: 0xB2B150 VA: 0x180B2BD50
	private ContentValidator CompileComplexContent(XmlSchemaComplexType complexType) { }

	// RVA: 0xB244B0 Offset: 0xB238B0 VA: 0x180B244B0
	private void BuildParticleContentModel(ParticleContentValidator contentValidator, XmlSchemaParticle particle) { }

	// RVA: 0xB2FC40 Offset: 0xB2F040 VA: 0x180B2FC40
	private void CompileParticleElements(XmlSchemaComplexType complexType, XmlSchemaParticle particle) { }

	// RVA: 0xB2B4C0 Offset: 0xB2A8C0 VA: 0x180B2B4C0
	private void CompileCompexTypeElements(XmlSchemaComplexType complexType) { }

	// RVA: 0xB33D40 Offset: 0xB33140 VA: 0x180B33D40
	private XmlSchemaSimpleType GetSimpleType(XmlQualifiedName name) { }

	// RVA: 0xB33AE0 Offset: 0xB32EE0 VA: 0x180B33AE0
	private XmlSchemaComplexType GetComplexType(XmlQualifiedName name) { }

	// RVA: 0xB33900 Offset: 0xB32D00 VA: 0x180B33900
	private XmlSchemaType GetAnySchemaType(XmlQualifiedName name) { }

}

