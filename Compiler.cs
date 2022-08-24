internal sealed class Compiler : BaseProcessor // TypeDefIndex: 2285
{
	private string restrictionErrorMsg; 
	private XmlSchemaObjectTable attributes; 
	private XmlSchemaObjectTable attributeGroups; 
	private XmlSchemaObjectTable elements; 
	private XmlSchemaObjectTable schemaTypes; 
	private XmlSchemaObjectTable groups; 
	private XmlSchemaObjectTable notations; 
	private XmlSchemaObjectTable examplars; 
	private XmlSchemaObjectTable identityConstraints; 
	private Stack complexTypeStack; 
	private Hashtable schemasToCompile; 
	private Hashtable importedSchemas; 
	private XmlSchema schemaForSchema; 


	public void .ctor(XmlNameTable nameTable, ValidationEventHandler eventHandler, XmlSchema schemaForSchema, XmlSchemaCompilationSettings compilationSettings) { }

	public bool Execute(XmlSchemaSet schemaSet, SchemaInfo schemaCompiledInfo) { }

	internal void Prepare(XmlSchema schema, bool cleanup) { }

	private void UpdateSForSSimpleTypes() { }

	private void Output(SchemaInfo schemaInfo) { }

	internal void ImportAllCompiledSchemas(XmlSchemaSet schemaSet) { }

	internal bool Compile() { }

	private void CleanupAttribute(XmlSchemaAttribute attribute) { }

	private void CleanupAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	private void CleanupComplexType(XmlSchemaComplexType complexType) { }

	private void CleanupSimpleType(XmlSchemaSimpleType simpleType) { }

	private void CleanupElement(XmlSchemaElement element) { }

	private void CleanupAttributes(XmlSchemaObjectCollection attributes) { }

	private void CleanupGroup(XmlSchemaGroup group) { }

	private void CleanupParticle(XmlSchemaParticle particle) { }

	private void ProcessSubstitutionGroups() { }

	private void CompileSubstitutionGroup(XmlSchemaSubstitutionGroup substitutionGroup) { }

	private void RecursivelyCheckRedefinedGroups(XmlSchemaGroup redefinedGroup, XmlSchemaGroup baseGroup) { }

	private void RecursivelyCheckRedefinedAttributeGroups(XmlSchemaAttributeGroup attributeGroup, XmlSchemaAttributeGroup baseAttributeGroup) { }

	private void CompileGroup(XmlSchemaGroup group) { }

	private void CompileSimpleType(XmlSchemaSimpleType simpleType) { }

	private XmlSchemaSimpleType[] CompileBaseMemberTypes(XmlSchemaSimpleType simpleType) { }

	private void CheckUnionType(XmlSchemaSimpleType unionMember, ArrayList memberTypeDefinitions, XmlSchemaSimpleType parentType) { }

	private void CompileComplexType(XmlSchemaComplexType complexType) { }

	private void CompileSimpleContentExtension(XmlSchemaComplexType complexType, XmlSchemaSimpleContentExtension simpleExtension) { }

	private void CompileSimpleContentRestriction(XmlSchemaComplexType complexType, XmlSchemaSimpleContentRestriction simpleRestriction) { }

	private void CompileComplexContentExtension(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaComplexContentExtension complexExtension) { }

	private void CompileComplexContentRestriction(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaComplexContentRestriction complexRestriction) { }

	private void CheckParticleDerivation(XmlSchemaComplexType complexType) { }

	private void CheckParticleDerivation(XmlSchemaParticle derivedParticle, XmlSchemaParticle baseParticle) { }

	private XmlSchemaParticle CompileContentTypeParticle(XmlSchemaParticle particle) { }

	private XmlSchemaParticle CannonicalizeParticle(XmlSchemaParticle particle, bool root) { }

	private XmlSchemaParticle CannonicalizeElement(XmlSchemaElement element) { }

	private XmlSchemaParticle CannonicalizeGroupRef(XmlSchemaGroupRef groupRef, bool root) { }

	private XmlSchemaParticle CannonicalizeAll(XmlSchemaAll all, bool root) { }

	private XmlSchemaParticle CannonicalizeChoice(XmlSchemaChoice choice, bool root) { }

	private XmlSchemaParticle CannonicalizeSequence(XmlSchemaSequence sequence, bool root) { }

	private XmlSchemaParticle CannonicalizePointlessRoot(XmlSchemaParticle particle) { }

	private bool IsValidRestriction(XmlSchemaParticle derivedParticle, XmlSchemaParticle baseParticle) { }

	private bool IsElementFromElement(XmlSchemaElement derivedElement, XmlSchemaElement baseElement) { }

	private bool IsElementFromAny(XmlSchemaElement derivedElement, XmlSchemaAny baseAny) { }

	private bool IsAnyFromAny(XmlSchemaAny derivedAny, XmlSchemaAny baseAny) { }

	private bool IsGroupBaseFromAny(XmlSchemaGroupBase derivedGroupBase, XmlSchemaAny baseAny) { }

	private bool IsElementFromGroupBase(XmlSchemaElement derivedElement, XmlSchemaGroupBase baseGroupBase) { }

	private bool IsChoiceFromChoiceSubstGroup(XmlSchemaChoice derivedChoice, XmlSchemaChoice baseChoice) { }

	private bool IsGroupBaseFromGroupBase(XmlSchemaGroupBase derivedGroupBase, XmlSchemaGroupBase baseGroupBase, bool skipEmptableOnly) { }

	private bool IsSequenceFromAll(XmlSchemaSequence derivedSequence, XmlSchemaAll baseAll) { }

	private bool IsSequenceFromChoice(XmlSchemaSequence derivedSequence, XmlSchemaChoice baseChoice) { }

	private bool IsValidOccurrenceRangeRestriction(XmlSchemaParticle derivedParticle, XmlSchemaParticle baseParticle) { }

	private bool IsValidOccurrenceRangeRestriction(Decimal minOccurs, Decimal maxOccurs, Decimal baseMinOccurs, Decimal baseMaxOccurs) { }

	private int GetMappingParticle(XmlSchemaParticle particle, XmlSchemaObjectCollection collection) { }

	private bool IsParticleEmptiable(XmlSchemaParticle particle) { }

	private void CalculateEffectiveTotalRange(XmlSchemaParticle particle, out Decimal minOccurs, out Decimal maxOccurs) { }

	private void PushComplexType(XmlSchemaComplexType complexType) { }

	private XmlSchemaContentType GetSchemaContentType(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaParticle particle) { }

	private void CompileAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	private void CompileLocalAttributes(XmlSchemaComplexType baseType, XmlSchemaComplexType derivedType, XmlSchemaObjectCollection attributes, XmlSchemaAnyAttribute anyAttribute, XmlSchemaDerivationMethod derivedBy) { }

	private void CheckAtrributeGroupRestriction(XmlSchemaAttributeGroup baseAttributeGroup, XmlSchemaAttributeGroup derivedAttributeGroup) { }

	private bool IsProcessContentsRestricted(XmlSchemaComplexType baseType, XmlSchemaAnyAttribute derivedAttributeWildcard, XmlSchemaAnyAttribute baseAttributeWildcard) { }

	private XmlSchemaAnyAttribute CompileAnyAttributeUnion(XmlSchemaAnyAttribute a, XmlSchemaAnyAttribute b) { }

	private XmlSchemaAnyAttribute CompileAnyAttributeIntersection(XmlSchemaAnyAttribute a, XmlSchemaAnyAttribute b) { }

	private void CompileAttribute(XmlSchemaAttribute xa) { }

	private void SetDefaultFixed(XmlSchemaAttribute xa, SchemaAttDef decl) { }

	private void CompileIdentityConstraint(XmlSchemaIdentityConstraint xi) { }

	private void CompileElement(XmlSchemaElement xe) { }

	private ContentValidator CompileComplexContent(XmlSchemaComplexType complexType) { }

	private bool BuildParticleContentModel(ParticleContentValidator contentValidator, XmlSchemaParticle particle) { }

	private void CompileParticleElements(XmlSchemaComplexType complexType, XmlSchemaParticle particle) { }

	private void CompileParticleElements(XmlSchemaParticle particle) { }

	private void CompileComplexTypeElements(XmlSchemaComplexType complexType) { }

	private XmlSchemaSimpleType GetSimpleType(XmlQualifiedName name) { }

	private XmlSchemaComplexType GetComplexType(XmlQualifiedName name) { }

	private XmlSchemaType GetAnySchemaType(XmlQualifiedName name) { }

	private void CopyPosition(XmlSchemaAnnotated to, XmlSchemaAnnotated from, bool copyParent) { }

	private bool IsFixedEqual(SchemaDeclBase baseDecl, SchemaDeclBase derivedDecl) { }

}

