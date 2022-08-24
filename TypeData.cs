internal class TypeData // TypeDefIndex: 2062
{
	private Type type; 
	private string elementName; 
	private SchemaTypes sType; 
	private Type listItemType; 
	private string typeName; 
	private string fullTypeName; 
	private TypeData listItemTypeData; 
	private TypeData mappedType; 
	private XmlSchemaPatternFacet facet; 
	private MethodInfo typeConvertor; 
	private bool hasPublicConstructor; 
	private bool nullableOverride; 
	private static string[] keywords; 

	public string TypeName { get; }
	public string XmlType { get; }
	public Type Type { get; }
	public string FullTypeName { get; }
	public SchemaTypes SchemaType { get; }
	public bool IsListType { get; }
	public bool IsComplexType { get; }
	public bool IsValueType { get; }
	public bool IsNullable { get; set; }
	public TypeData ListItemTypeData { get; }
	public Type ListItemType { get; }
	public bool IsXsdType { get; }
	public bool HasPublicConstructor { get; }


	public void .ctor(Type type, string elementName, bool isPrimitive) { }

	public void .ctor(Type type, string elementName, bool isPrimitive, TypeData mappedType, XmlSchemaPatternFacet facet) { }

	private void LookupTypeConvertor() { }

	internal void ConvertForAssignment(ref object value) { }

	public string get_TypeName() { }

	public string get_XmlType() { }

	public Type get_Type() { }

	public string get_FullTypeName() { }

	public SchemaTypes get_SchemaType() { }

	public bool get_IsListType() { }

	public bool get_IsComplexType() { }

	public bool get_IsValueType() { }

	public bool get_IsNullable() { }

	public void set_IsNullable(bool value) { }

	public TypeData get_ListItemTypeData() { }

	public Type get_ListItemType() { }

	public bool get_IsXsdType() { }

	public bool get_HasPublicConstructor() { }

	public static PropertyInfo GetIndexerProperty(Type collectionType) { }

	private static InvalidOperationException CreateMissingAddMethodException(Type type, string inheritFrom, Type argumentType) { }

	internal static Type GetGenericListItemType(Type type) { }

	private static void .cctor() { }

}

