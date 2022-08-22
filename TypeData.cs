internal class TypeData // TypeDefIndex: 2062
{	private Type type; // 0x10
	private string elementName; // 0x18
	private SchemaTypes sType; // 0x20
	private Type listItemType; // 0x28
	private string typeName; // 0x30
	private string fullTypeName; // 0x38
	private TypeData listItemTypeData; // 0x40
	private TypeData mappedType; // 0x48
	private XmlSchemaPatternFacet facet; // 0x50
	private MethodInfo typeConvertor; // 0x58
	private bool hasPublicConstructor; // 0x60
	private bool nullableOverride; // 0x61
	private static string[] keywords; // 0x0

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

