internal class TypedObject // TypeDefIndex: 2149
{
	private TypedObject.DecimalStruct dstruct; 
	private object ovalue; 
	private string svalue; 
	private XmlSchemaDatatype xsdtype; 
	private int dim; 
	private bool isList; 

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
{
	private bool isDecimal; 
	private Decimal[] dvalue; 

	public bool IsDecimal { get; set; }
	public Decimal[] Dvalue { get; }


	public bool get_IsDecimal() { }

	public void set_IsDecimal(bool value) { }

	public Decimal[] get_Dvalue() { }

	public void .ctor() { }

	public void .ctor(int dim) { }

}

