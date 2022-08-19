internal class TypeData // TypeDefIndex: 2062
{	// Fields
	private Type type; // 0x10
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

	// Properties
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

	// Methods

	// RVA: 0x1101960 Offset: 0x1100D60 VA: 0x181101960
	public void .ctor(Type type, string elementName, bool isPrimitive) { }

	// RVA: 0x1101470 Offset: 0x1100870 VA: 0x181101470
	public void .ctor(Type type, string elementName, bool isPrimitive, TypeData mappedType, XmlSchemaPatternFacet facet) { }

	// RVA: 0x10FF350 Offset: 0x10FE750 VA: 0x1810FF350
	private void LookupTypeConvertor() { }

	// RVA: 0x10FEDF0 Offset: 0x10FE1F0 VA: 0x1810FEDF0
	internal void ConvertForAssignment(ref object value) { }

	// RVA: 0x4A2EE0 Offset: 0x4A22E0 VA: 0x1804A2EE0
	public string get_TypeName() { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public string get_XmlType() { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public Type get_Type() { }

	// RVA: 0x5DCC00 Offset: 0x5DC000 VA: 0x1805DCC00
	public string get_FullTypeName() { }

	// RVA: 0x4D0170 Offset: 0x4CF570 VA: 0x1804D0170
	public SchemaTypes get_SchemaType() { }

	// RVA: 0x8B10E0 Offset: 0x8B04E0 VA: 0x1808B10E0
	public bool get_IsListType() { }

	// RVA: 0x1101980 Offset: 0x1100D80 VA: 0x181101980
	public bool get_IsComplexType() { }

	// RVA: 0x1101B30 Offset: 0x1100F30 VA: 0x181101B30
	public bool get_IsValueType() { }

	// RVA: 0x11019A0 Offset: 0x1100DA0 VA: 0x1811019A0
	public bool get_IsNullable() { }

	// RVA: 0x10814A0 Offset: 0x10808A0 VA: 0x1810814A0
	public void set_IsNullable(bool value) { }

	// RVA: 0x1101BD0 Offset: 0x1100FD0 VA: 0x181101BD0
	public TypeData get_ListItemTypeData() { }

	// RVA: 0x1101CA0 Offset: 0x11010A0 VA: 0x181101CA0
	public Type get_ListItemType() { }

	// RVA: 0x82F580 Offset: 0x82E980 VA: 0x18082F580
	public bool get_IsXsdType() { }

	// RVA: 0xA2DBD0 Offset: 0xA2CFD0 VA: 0x180A2DBD0
	public bool get_HasPublicConstructor() { }

	// RVA: 0x10FF200 Offset: 0x10FE600 VA: 0x1810FF200
	public static PropertyInfo GetIndexerProperty(Type collectionType) { }

	// RVA: 0x10FEEF0 Offset: 0x10FE2F0 VA: 0x1810FEEF0
	private static InvalidOperationException CreateMissingAddMethodException(Type type, string inheritFrom, Type argumentType) { }

	// RVA: 0x10FEFF0 Offset: 0x10FE3F0 VA: 0x1810FEFF0
	internal static Type GetGenericListItemType(Type type) { }

	// RVA: 0x10FF400 Offset: 0x10FE800 VA: 0x1810FF400
	private static void .cctor() { }

}

