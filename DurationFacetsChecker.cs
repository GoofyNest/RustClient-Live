internal class DurationFacetsChecker : FacetsChecker // TypeDefIndex: 2250
{	// Methods

	// RVA: 0x1532260 Offset: 0x1531660 VA: 0x181532260 Slot: 5
	internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1532370 Offset: 0x1531770 VA: 0x181532370 Slot: 15
	internal override Exception CheckValueFacets(TimeSpan value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1532720 Offset: 0x1531B20 VA: 0x181532720 Slot: 17
	internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x15327B0 Offset: 0x1531BB0 VA: 0x1815327B0
	private bool MatchEnumeration(TimeSpan value, ArrayList enumeration) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

