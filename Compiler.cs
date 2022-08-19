internal sealed class Compiler : BaseProcessor // TypeDefIndex: 2285
{	// Fields
	private string restrictionErrorMsg; // 0x40
	private XmlSchemaObjectTable attributes; // 0x48
	private XmlSchemaObjectTable attributeGroups; // 0x50
	private XmlSchemaObjectTable elements; // 0x58
	private XmlSchemaObjectTable schemaTypes; // 0x60
	private XmlSchemaObjectTable groups; // 0x68
	private XmlSchemaObjectTable notations; // 0x70
	private XmlSchemaObjectTable examplars; // 0x78
	private XmlSchemaObjectTable identityConstraints; // 0x80
	private Stack complexTypeStack; // 0x88
	private Hashtable schemasToCompile; // 0x90
	private Hashtable importedSchemas; // 0x98
	private XmlSchema schemaForSchema; // 0xA0

	// Methods

	// RVA: 0xF59860 Offset: 0xF58C60 VA: 0x180F59860
	public void .ctor(XmlNameTable nameTable, ValidationEventHandler eventHandler, XmlSchema schemaForSchema, XmlSchemaCompilationSettings compilationSettings) { }

	// RVA: 0xF51240 Offset: 0xF50640 VA: 0x180F51240
	public bool Execute(XmlSchemaSet schemaSet, SchemaInfo schemaCompiledInfo) { }

	// RVA: 0xF56A40 Offset: 0xF55E40 VA: 0x180F56A40
	internal void Prepare(XmlSchema schema, bool cleanup) { }

	// RVA: 0xF596E0 Offset: 0xF58AE0 VA: 0x180F596E0
	private void UpdateSForSSimpleTypes() { }

	// RVA: 0xF55CD0 Offset: 0xF550D0 VA: 0x180F55CD0
	private void Output(SchemaInfo schemaInfo) { }

	// RVA: 0xF51780 Offset: 0xF50B80 VA: 0x180F51780
	internal void ImportAllCompiledSchemas(XmlSchemaSet schemaSet) { }

	// RVA: 0xF4F310 Offset: 0xF4E710 VA: 0x180F4F310
	internal bool Compile() { }

	// RVA: 0xF46EC0 Offset: 0xF462C0 VA: 0x180F46EC0
	private void CleanupAttribute(XmlSchemaAttribute attribute) { }

	// RVA: 0xF46E40 Offset: 0xF46240 VA: 0x180F46E40
	private void CleanupAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0xF47150 Offset: 0xF46550 VA: 0x180F47150
	private void CleanupComplexType(XmlSchemaComplexType complexType) { }

	// RVA: 0xF47DD0 Offset: 0xF471D0 VA: 0x180F47DD0
	private void CleanupSimpleType(XmlSchemaSimpleType simpleType) { }

	// RVA: 0xF476A0 Offset: 0xF46AA0 VA: 0x180F476A0
	private void CleanupElement(XmlSchemaElement element) { }

	// RVA: 0xF46FB0 Offset: 0xF463B0 VA: 0x180F46FB0
	private void CleanupAttributes(XmlSchemaObjectCollection attributes) { }

	// RVA: 0xF47940 Offset: 0xF46D40 VA: 0x180F47940
	private void CleanupGroup(XmlSchemaGroup group) { }

	// RVA: 0xF479A0 Offset: 0xF46DA0 VA: 0x180F479A0
	private void CleanupParticle(XmlSchemaParticle particle) { }

	// RVA: 0xF58C80 Offset: 0xF58080 VA: 0x180F58C80
	private void ProcessSubstitutionGroups() { }

	// RVA: 0xF4EE00 Offset: 0xF4E200 VA: 0x180F4EE00
	private void CompileSubstitutionGroup(XmlSchemaSubstitutionGroup substitutionGroup) { }

	// RVA: 0xF593C0 Offset: 0xF587C0 VA: 0x180F593C0
	private void RecursivelyCheckRedefinedGroups(XmlSchemaGroup redefinedGroup, XmlSchemaGroup baseGroup) { }

	// RVA: 0xF59330 Offset: 0xF58730 VA: 0x180F59330
	private void RecursivelyCheckRedefinedAttributeGroups(XmlSchemaAttributeGroup attributeGroup, XmlSchemaAttributeGroup baseAttributeGroup) { }

	// RVA: 0xF4C0B0 Offset: 0xF4B4B0 VA: 0x180F4C0B0
	private void CompileGroup(XmlSchemaGroup group) { }

	// RVA: 0xF4E550 Offset: 0xF4D950 VA: 0x180F4E550
	private void CompileSimpleType(XmlSchemaSimpleType simpleType) { }

	// RVA: 0xF48E90 Offset: 0xF48290 VA: 0x180F48E90
	private XmlSchemaSimpleType[] CompileBaseMemberTypes(XmlSchemaSimpleType simpleType) { }

	// RVA: 0xF46D10 Offset: 0xF46110 VA: 0x180F46D10
	private void CheckUnionType(XmlSchemaSimpleType unionMember, ArrayList memberTypeDefinitions, XmlSchemaSimpleType parentType) { }

	// RVA: 0xF4A8D0 Offset: 0xF49CD0 VA: 0x180F4A8D0
	private void CompileComplexType(XmlSchemaComplexType complexType) { }

	// RVA: 0xF4DED0 Offset: 0xF4D2D0 VA: 0x180F4DED0
	private void CompileSimpleContentExtension(XmlSchemaComplexType complexType, XmlSchemaSimpleContentExtension simpleExtension) { }

	// RVA: 0xF4E160 Offset: 0xF4D560 VA: 0x180F4E160
	private void CompileSimpleContentRestriction(XmlSchemaComplexType complexType, XmlSchemaSimpleContentRestriction simpleRestriction) { }

	// RVA: 0xF49320 Offset: 0xF48720 VA: 0x180F49320
	private void CompileComplexContentExtension(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaComplexContentExtension complexExtension) { }

	// RVA: 0xF49700 Offset: 0xF48B00 VA: 0x180F49700
	private void CompileComplexContentRestriction(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaComplexContentRestriction complexRestriction) { }

	// RVA: 0xF467B0 Offset: 0xF45BB0 VA: 0x180F467B0
	private void CheckParticleDerivation(XmlSchemaComplexType complexType) { }

	// RVA: 0xF46C40 Offset: 0xF46040 VA: 0x180F46C40
	private void CheckParticleDerivation(XmlSchemaParticle derivedParticle, XmlSchemaParticle baseParticle) { }

	// RVA: 0xF4B1E0 Offset: 0xF4A5E0 VA: 0x180F4B1E0
	private XmlSchemaParticle CompileContentTypeParticle(XmlSchemaParticle particle) { }

	// RVA: 0xF45190 Offset: 0xF44590 VA: 0x180F45190
	private XmlSchemaParticle CannonicalizeParticle(XmlSchemaParticle particle, bool root) { }

	// RVA: 0xF44890 Offset: 0xF43C90 VA: 0x180F44890
	private XmlSchemaParticle CannonicalizeElement(XmlSchemaElement element) { }

	// RVA: 0xF44B20 Offset: 0xF43F20 VA: 0x180F44B20
	private XmlSchemaParticle CannonicalizeGroupRef(XmlSchemaGroupRef groupRef, bool root) { }

	// RVA: 0xF43EF0 Offset: 0xF432F0 VA: 0x180F43EF0
	private XmlSchemaParticle CannonicalizeAll(XmlSchemaAll all, bool root) { }

	// RVA: 0xF441D0 Offset: 0xF435D0 VA: 0x180F441D0
	private XmlSchemaParticle CannonicalizeChoice(XmlSchemaChoice choice, bool root) { }

	// RVA: 0xF45A10 Offset: 0xF44E10 VA: 0x180F45A10
	private XmlSchemaParticle CannonicalizeSequence(XmlSchemaSequence sequence, bool root) { }

	// RVA: 0xF454F0 Offset: 0xF448F0 VA: 0x180F454F0
	private XmlSchemaParticle CannonicalizePointlessRoot(XmlSchemaParticle particle) { }

	// RVA: 0xF54000 Offset: 0xF53400 VA: 0x180F54000
	private bool IsValidRestriction(XmlSchemaParticle derivedParticle, XmlSchemaParticle baseParticle) { }

	// RVA: 0xF51D10 Offset: 0xF51110 VA: 0x180F51D10
	private bool IsElementFromElement(XmlSchemaElement derivedElement, XmlSchemaElement baseElement) { }

	// RVA: 0xF51B20 Offset: 0xF50F20 VA: 0x180F51B20
	private bool IsElementFromAny(XmlSchemaElement derivedElement, XmlSchemaAny baseAny) { }

	// RVA: 0xF51890 Offset: 0xF50C90 VA: 0x180F51890
	private bool IsAnyFromAny(XmlSchemaAny derivedAny, XmlSchemaAny baseAny) { }

	// RVA: 0xF52C40 Offset: 0xF52040 VA: 0x180F52C40
	private bool IsGroupBaseFromAny(XmlSchemaGroupBase derivedGroupBase, XmlSchemaAny baseAny) { }

	// RVA: 0xF51F80 Offset: 0xF51380 VA: 0x180F51F80
	private bool IsElementFromGroupBase(XmlSchemaElement derivedElement, XmlSchemaGroupBase baseGroupBase) { }

	// RVA: 0xF51970 Offset: 0xF50D70 VA: 0x180F51970
	private bool IsChoiceFromChoiceSubstGroup(XmlSchemaChoice derivedChoice, XmlSchemaChoice baseChoice) { }

	// RVA: 0xF53140 Offset: 0xF52540 VA: 0x180F53140
	private bool IsGroupBaseFromGroupBase(XmlSchemaGroupBase derivedGroupBase, XmlSchemaGroupBase baseGroupBase, bool skipEmptableOnly) { }

	// RVA: 0xF53630 Offset: 0xF52A30 VA: 0x180F53630
	private bool IsSequenceFromAll(XmlSchemaSequence derivedSequence, XmlSchemaAll baseAll) { }

	// RVA: 0xF539B0 Offset: 0xF52DB0 VA: 0x180F539B0
	private bool IsSequenceFromChoice(XmlSchemaSequence derivedSequence, XmlSchemaChoice baseChoice) { }

	// RVA: 0xF53EE0 Offset: 0xF532E0 VA: 0x180F53EE0
	private bool IsValidOccurrenceRangeRestriction(XmlSchemaParticle derivedParticle, XmlSchemaParticle baseParticle) { }

	// RVA: 0xF53E00 Offset: 0xF53200 VA: 0x180F53E00
	private bool IsValidOccurrenceRangeRestriction(Decimal minOccurs, Decimal maxOccurs, Decimal baseMinOccurs, Decimal baseMaxOccurs) { }

	// RVA: 0xF51580 Offset: 0xF50980 VA: 0x180F51580
	private int GetMappingParticle(XmlSchemaParticle particle, XmlSchemaObjectCollection collection) { }

	// RVA: 0xF53470 Offset: 0xF52870 VA: 0x180F53470
	private bool IsParticleEmptiable(XmlSchemaParticle particle) { }

	// RVA: 0xF43680 Offset: 0xF42A80 VA: 0x180F43680
	private void CalculateEffectiveTotalRange(XmlSchemaParticle particle, out Decimal minOccurs, out Decimal maxOccurs) { }

	// RVA: 0xF59300 Offset: 0xF58700 VA: 0x180F59300
	private void PushComplexType(XmlSchemaComplexType complexType) { }

	// RVA: 0xB33CC0 Offset: 0xB330C0 VA: 0x180B33CC0
	private XmlSchemaContentType GetSchemaContentType(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaParticle particle) { }

	// RVA: 0xF47FD0 Offset: 0xF473D0 VA: 0x180F47FD0
	private void CompileAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0xF4C750 Offset: 0xF4BB50 VA: 0x180F4C750
	private void CompileLocalAttributes(XmlSchemaComplexType baseType, XmlSchemaComplexType derivedType, XmlSchemaObjectCollection attributes, XmlSchemaAnyAttribute anyAttribute, XmlSchemaDerivationMethod derivedBy) { }

	// RVA: 0xF46030 Offset: 0xF45430 VA: 0x180F46030
	private void CheckAtrributeGroupRestriction(XmlSchemaAttributeGroup baseAttributeGroup, XmlSchemaAttributeGroup derivedAttributeGroup) { }

	// RVA: 0xF53530 Offset: 0xF52930 VA: 0x180F53530
	private bool IsProcessContentsRestricted(XmlSchemaComplexType baseType, XmlSchemaAnyAttribute derivedAttributeWildcard, XmlSchemaAnyAttribute baseAttributeWildcard) { }

	// RVA: 0xF47F30 Offset: 0xF47330 VA: 0x180F47F30
	private XmlSchemaAnyAttribute CompileAnyAttributeUnion(XmlSchemaAnyAttribute a, XmlSchemaAnyAttribute b) { }

	// RVA: 0xF47E90 Offset: 0xF47290 VA: 0x180F47E90
	private XmlSchemaAnyAttribute CompileAnyAttributeIntersection(XmlSchemaAnyAttribute a, XmlSchemaAnyAttribute b) { }

	// RVA: 0xF48740 Offset: 0xF47B40 VA: 0x180F48740
	private void CompileAttribute(XmlSchemaAttribute xa) { }

	// RVA: 0xF59540 Offset: 0xF58940 VA: 0x180F59540
	private void SetDefaultFixed(XmlSchemaAttribute xa, SchemaAttDef decl) { }

	// RVA: 0xF4C1A0 Offset: 0xF4B5A0 VA: 0x180F4C1A0
	private void CompileIdentityConstraint(XmlSchemaIdentityConstraint xi) { }

	// RVA: 0xF4B380 Offset: 0xF4A780 VA: 0x180F4B380
	private void CompileElement(XmlSchemaElement xe) { }

	// RVA: 0xF49A00 Offset: 0xF48E00 VA: 0x180F49A00
	private ContentValidator CompileComplexContent(XmlSchemaComplexType complexType) { }

	// RVA: 0xF42F50 Offset: 0xF42350 VA: 0x180F42F50
	private bool BuildParticleContentModel(ParticleContentValidator contentValidator, XmlSchemaParticle particle) { }

	// RVA: 0xF4D8C0 Offset: 0xF4CCC0 VA: 0x180F4D8C0
	private void CompileParticleElements(XmlSchemaComplexType complexType, XmlSchemaParticle particle) { }

	// RVA: 0xF4DC50 Offset: 0xF4D050 VA: 0x180F4DC50
	private void CompileParticleElements(XmlSchemaParticle particle) { }

	// RVA: 0xF4A7A0 Offset: 0xF49BA0 VA: 0x180F4A7A0
	private void CompileComplexTypeElements(XmlSchemaComplexType complexType) { }

	// RVA: 0xF51690 Offset: 0xF50A90 VA: 0x180F51690
	private XmlSchemaSimpleType GetSimpleType(XmlQualifiedName name) { }

	// RVA: 0xF514C0 Offset: 0xF508C0 VA: 0x180F514C0
	private XmlSchemaComplexType GetComplexType(XmlQualifiedName name) { }

	// RVA: 0xF512F0 Offset: 0xF506F0 VA: 0x180F512F0
	private XmlSchemaType GetAnySchemaType(XmlQualifiedName name) { }

	// RVA: 0xF511B0 Offset: 0xF505B0 VA: 0x180F511B0
	private void CopyPosition(XmlSchemaAnnotated to, XmlSchemaAnnotated from, bool copyParent) { }

	// RVA: 0xF52AC0 Offset: 0xF51EC0 VA: 0x180F52AC0
	private bool IsFixedEqual(SchemaDeclBase baseDecl, SchemaDeclBase derivedDecl) { }

}

