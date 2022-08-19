internal class Numeric10FacetsChecker : FacetsChecker // TypeDefIndex: 2248
{	// Fields
	private static readonly char[] signs; // 0x0
	private Decimal maxValue; // 0x10
	private Decimal minValue; // 0x20

	// Methods

	// RVA: 0xB0FDD0 Offset: 0xB0F1D0 VA: 0x180B0FDD0
	internal void .ctor(Decimal minVal, Decimal maxVal) { }

	// RVA: 0xB0FA00 Offset: 0xB0EE00 VA: 0x180B0FA00 Slot: 5
	internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0xB0F2A0 Offset: 0xB0E6A0 VA: 0x180B0F2A0 Slot: 6
	internal override Exception CheckValueFacets(Decimal value, XmlSchemaDatatype datatype) { }

	// RVA: 0xB0F200 Offset: 0xB0E600 VA: 0x180B0F200 Slot: 7
	internal override Exception CheckValueFacets(long value, XmlSchemaDatatype datatype) { }

	// RVA: 0xB0F960 Offset: 0xB0ED60 VA: 0x180B0F960 Slot: 8
	internal override Exception CheckValueFacets(int value, XmlSchemaDatatype datatype) { }

	// RVA: 0xB0F8C0 Offset: 0xB0ECC0 VA: 0x180B0F8C0 Slot: 9
	internal override Exception CheckValueFacets(short value, XmlSchemaDatatype datatype) { }

	// RVA: 0xB0FBB0 Offset: 0xB0EFB0 VA: 0x180B0FBB0 Slot: 17
	internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0xB0FA90 Offset: 0xB0EE90 VA: 0x180B0FA90
	internal bool MatchEnumeration(Decimal value, ArrayList enumeration, XmlValueConverter valueConverter) { }

	// RVA: 0xB0EF40 Offset: 0xB0E340 VA: 0x180B0EF40
	internal Exception CheckTotalAndFractionDigits(Decimal value, int totalDigits, int fractionDigits, bool checkTotal, bool checkFraction) { }

	// RVA: 0xB0FD30 Offset: 0xB0F130 VA: 0x180B0FD30
	private static void .cctor() { }

}

