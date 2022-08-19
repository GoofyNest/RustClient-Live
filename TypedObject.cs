internal class TypedObject // TypeDefIndex: 2149
{	// Fields
	private TypedObject.DecimalStruct dstruct; // 0x10
	private object ovalue; // 0x18
	private string svalue; // 0x20
	private XmlSchemaDatatype xsdtype; // 0x28
	private int dim; // 0x30
	private bool isList; // 0x34

	// Properties
	public int Dim { get; }
	public bool IsList { get; }
	public bool IsDecimal { get; }
	public Decimal[] Dvalue { get; }
	public object Value { get; }
	public XmlSchemaDatatype Type { get; }

	// Methods

	// RVA: 0xA178C0 Offset: 0xA16CC0 VA: 0x180A178C0
	public int get_Dim() { }

	// RVA: 0xB9D210 Offset: 0xB9C610 VA: 0x180B9D210
	public bool get_IsList() { }

	// RVA: 0xEECB00 Offset: 0xEEBF00 VA: 0x180EECB00
	public bool get_IsDecimal() { }

	// RVA: 0x4CEC00 Offset: 0x4CE000 VA: 0x1804CEC00
	public Decimal[] get_Dvalue() { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public object get_Value() { }

	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230
	public XmlSchemaDatatype get_Type() { }

	// RVA: 0xEEC930 Offset: 0xEEBD30 VA: 0x180EEC930
	public void .ctor(object obj, string svalue, XmlSchemaDatatype xsdtype) { }

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00 Slot: 3
	public override string ToString() { }

	// RVA: 0xEEC600 Offset: 0xEEBA00 VA: 0x180EEC600
	public void SetDecimal() { }

	// RVA: 0xEEC4C0 Offset: 0xEEB8C0 VA: 0x180EEC4C0
	private bool ListDValueEquals(TypedObject other) { }

	// RVA: 0xEEC130 Offset: 0xEEB530 VA: 0x180EEC130
	public bool Equals(TypedObject other) { }

}

private class TypedObject.DecimalStruct // TypeDefIndex: 2150
{	// Fields
	private bool isDecimal; // 0x10
	private Decimal[] dvalue; // 0x18

	// Properties
	public bool IsDecimal { get; set; }
	public Decimal[] Dvalue { get; }

	// Methods

	// RVA: 0x497E20 Offset: 0x497220 VA: 0x180497E20
	public bool get_IsDecimal() { }

	// RVA: 0x497E50 Offset: 0x497250 VA: 0x180497E50
	public void set_IsDecimal(bool value) { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public Decimal[] get_Dvalue() { }

	// RVA: 0xED5210 Offset: 0xED4610 VA: 0x180ED5210
	public void .ctor() { }

	// RVA: 0xED5270 Offset: 0xED4670 VA: 0x180ED5270
	public void .ctor(int dim) { }

}

