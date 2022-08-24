internal sealed class SchemaCollectionCompiler : BaseProcessor // TypeDefIndex: 2272
{
	private bool compileContentModel; 
	private XmlSchemaObjectTable examplars; 
	private Stack complexTypeStack; 
	private XmlSchema schema; 


	public void .ctor(XmlNameTable nameTable, ValidationEventHandler eventHandler) { }

	public bool Execute(XmlSchema schema, SchemaInfo schemaInfo, bool compileContentModel) { }

	private void Prepare() { }

	private void Cleanup() { }

	internal static void Cleanup(XmlSchema schema) { }

	private void Compile() { }

	private void Output(SchemaInfo schemaInfo) { }

	private static void CleanupAttribute(XmlSchemaAttribute attribute) { }

	private static void CleanupAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	private static void CleanupComplexType(XmlSchemaComplexType complexType) { }

	private static void CleanupSimpleType(XmlSchemaSimpleType simpleType) { }

	private static void CleanupElement(XmlSchemaElement element) { }

	private static void CleanupAttributes(XmlSchemaObjectCollection attributes) { }

	private static void CleanupGroup(XmlSchemaGroup group) { }

	private static void CleanupParticle(XmlSchemaParticle particle) { }

	private void CompileSubstitutionGroup(XmlSchemaSubstitutionGroupV1Compat substitutionGroup) { }

	private void CheckSubstitutionGroup(XmlSchemaSubstitutionGroup substitutionGroup) { }

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

	private XmlSchemaParticle CompileContentTypeParticle(XmlSchemaParticle particle, bool substitution) { }

	private XmlSchemaParticle CannonicalizeParticle(XmlSchemaParticle particle, bool root, bool substitution) { }

	private XmlSchemaParticle CannonicalizeElement(XmlSchemaElement element, bool substitution) { }

	private XmlSchemaParticle CannonicalizeGroupRef(XmlSchemaGroupRef groupRef, bool root, bool substitution) { }

	private XmlSchemaParticle CannonicalizeAll(XmlSchemaAll all, bool root, bool substitution) { }

	private XmlSchemaParticle CannonicalizeChoice(XmlSchemaChoice choice, bool root, bool substitution) { }

	private XmlSchemaParticle CannonicalizeSequence(XmlSchemaSequence sequence, bool root, bool substitution) { }

	private bool IsValidRestriction(XmlSchemaParticle derivedParticle, XmlSchemaParticle baseParticle) { }

	private bool IsElementFromElement(XmlSchemaElement derivedElement, XmlSchemaElement baseElement) { }

	private bool IsElementFromAny(XmlSchemaElement derivedElement, XmlSchemaAny baseAny) { }

	private bool IsAnyFromAny(XmlSchemaAny derivedAny, XmlSchemaAny baseAny) { }

	private bool IsGroupBaseFromAny(XmlSchemaGroupBase derivedGroupBase, XmlSchemaAny baseAny) { }

	private bool IsElementFromGroupBase(XmlSchemaElement derivedElement, XmlSchemaGroupBase baseGroupBase, bool skipEmptableOnly) { }

	private bool IsGroupBaseFromGroupBase(XmlSchemaGroupBase derivedGroupBase, XmlSchemaGroupBase baseGroupBase, bool skipEmptableOnly) { }

	private bool IsSequenceFromAll(XmlSchemaSequence derivedSequence, XmlSchemaAll baseAll) { }

	private bool IsSequenceFromChoice(XmlSchemaSequence derivedSequence, XmlSchemaChoice baseChoice) { }

	private void CalculateSequenceRange(XmlSchemaSequence sequence, out Decimal minOccurs, out Decimal maxOccurs) { }

	private bool IsValidOccurrenceRangeRestriction(XmlSchemaParticle derivedParticle, XmlSchemaParticle baseParticle) { }

	private bool IsValidOccurrenceRangeRestriction(Decimal minOccurs, Decimal maxOccurs, Decimal baseMinOccurs, Decimal baseMaxOccurs) { }

	private int GetMappingParticle(XmlSchemaParticle particle, XmlSchemaObjectCollection collection) { }

	private bool IsParticleEmptiable(XmlSchemaParticle particle) { }

	private void CalculateEffectiveTotalRange(XmlSchemaParticle particle, out Decimal minOccurs, out Decimal maxOccurs) { }

	private void PushComplexType(XmlSchemaComplexType complexType) { }

	private XmlSchemaContentType GetSchemaContentType(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaParticle particle) { }

	private void CompileAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	private void CompileLocalAttributes(XmlSchemaComplexType baseType, XmlSchemaComplexType derivedType, XmlSchemaObjectCollection attributes, XmlSchemaAnyAttribute anyAttribute, XmlSchemaDerivationMethod derivedBy) { }

	private XmlSchemaAnyAttribute CompileAnyAttributeUnion(XmlSchemaAnyAttribute a, XmlSchemaAnyAttribute b) { }

	private XmlSchemaAnyAttribute CompileAnyAttributeIntersection(XmlSchemaAnyAttribute a, XmlSchemaAnyAttribute b) { }

	private void CompileAttribute(XmlSchemaAttribute xa) { }

	private void CompileIdentityConstraint(XmlSchemaIdentityConstraint xi) { }

	private void CompileElement(XmlSchemaElement xe) { }

	private ContentValidator CompileComplexContent(XmlSchemaComplexType complexType) { }

	private void BuildParticleContentModel(ParticleContentValidator contentValidator, XmlSchemaParticle particle) { }

	private void CompileParticleElements(XmlSchemaComplexType complexType, XmlSchemaParticle particle) { }

	private void CompileCompexTypeElements(XmlSchemaComplexType complexType) { }

	private XmlSchemaSimpleType GetSimpleType(XmlQualifiedName name) { }

	private XmlSchemaComplexType GetComplexType(XmlQualifiedName name) { }

	private XmlSchemaType GetAnySchemaType(XmlQualifiedName name) { }

}

