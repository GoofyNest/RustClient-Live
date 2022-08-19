public class ProtectionProperties : ScriptableObject // TypeDefIndex: 10750
{	// Fields
	[TextAreaAttribute] // RVA: 0x72060 Offset: 0x71460 VA: 0x180072060
	public string comments; // 0x18
	[RangeAttribute] // RVA: 0x77CA0 Offset: 0x770A0 VA: 0x180077CA0
	public float density; // 0x20
	[ArrayIndexIsEnumRanged] // RVA: 0x77E20 Offset: 0x77220 VA: 0x180077E20
	public float[] amounts; // 0x28

	// Methods

	// RVA: 0x6993C0 Offset: 0x6987C0 VA: 0x1806993C0
	public void OnValidate() { }

	// RVA: 0x699260 Offset: 0x698660 VA: 0x180699260
	public void Clear() { }

	// RVA: 0x698F70 Offset: 0x698370 VA: 0x180698F70
	public void Add(float amount) { }

	// RVA: 0x699100 Offset: 0x698500 VA: 0x180699100
	public void Add(DamageType index, float amount) { }

	// RVA: 0x698FE0 Offset: 0x6983E0 VA: 0x180698FE0
	public void Add(ProtectionProperties other, float scale) { }

	// RVA: 0x699140 Offset: 0x698540 VA: 0x180699140
	public void Add(List<Item> items, HitArea area = -1) { }

	// RVA: 0x699310 Offset: 0x698710 VA: 0x180699310
	public void Multiply(float multiplier) { }

	// RVA: 0x699380 Offset: 0x698780 VA: 0x180699380
	public void Multiply(DamageType index, float multiplier) { }

	// RVA: 0x6994D0 Offset: 0x6988D0 VA: 0x1806994D0
	public void Scale(DamageTypeList damageList, float ProtectionAmount = 1) { }

	// RVA: 0x6992D0 Offset: 0x6986D0 VA: 0x1806992D0
	public float Get(DamageType damageType) { }

	// RVA: 0x699630 Offset: 0x698A30 VA: 0x180699630
	public void .ctor() { }

}

