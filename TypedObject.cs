internal class TypedObject // TypeDefIndex: 2149
{	private TypedObject.DecimalStruct dstruct; // 0x10
	private object ovalue; // 0x18
	private string svalue; // 0x20
	private XmlSchemaDatatype xsdtype; // 0x28
	private int dim; // 0x30
	private bool isList; // 0x34

	public int Dim { get; }
	public bool IsList { get; }
	public bool IsDecimal { get; }
	public Decimal[] Dvalue { get; }
	public object Value { get; }
	public XmlSchemaDatatype Type { get; }


	public int get_Dim() { }

	public bool get_IsList() { }

	public bool get_IsDecimal() { }

	public Decimal[] get_Dvalue() { }

	public object get_Value() { }

	public XmlSchemaDatatype get_Type() { }

	public void .ctor(object obj, string svalue, XmlSchemaDatatype xsdtype) { }

	public override string ToString() { }

	public void SetDecimal() { }

	private bool ListDValueEquals(TypedObject other) { }

	public bool Equals(TypedObject other) { }

}

private class TypedObject.DecimalStruct // TypeDefIndex: 2150
{	private bool isDecimal; // 0x10
	private Decimal[] dvalue; // 0x18

	public bool IsDecimal { get; set; }
	public Decimal[] Dvalue { get; }


	public bool get_IsDecimal() { }

	public void set_IsDecimal(bool value) { }

	public Decimal[] get_Dvalue() { }

	public void .ctor() { }

	public void .ctor(int dim) { }

}

