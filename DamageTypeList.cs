public class DamageTypeList // TypeDefIndex: 12027
{	// Fields
	public float[] types; // 0x10

	// Methods

	// RVA: 0x4B99A0 Offset: 0x4B8DA0 VA: 0x1804B99A0
	public void Set(DamageType index, float amount) { }

	// RVA: 0x4B97D0 Offset: 0x4B8BD0 VA: 0x1804B97D0
	public float Get(DamageType index) { }

	// RVA: 0x4B9520 Offset: 0x4B8920 VA: 0x1804B9520
	public void Add(DamageType index, float amount) { }

	// RVA: 0x4B9960 Offset: 0x4B8D60 VA: 0x1804B9960
	public void Scale(DamageType index, float amount) { }

	// RVA: 0x4B9810 Offset: 0x4B8C10 VA: 0x1804B9810
	public bool Has(DamageType index) { }

	// RVA: 0x4B99E0 Offset: 0x4B8DE0 VA: 0x1804B99E0
	public float Total() { }

	// RVA: 0x4B96A0 Offset: 0x4B8AA0 VA: 0x1804B96A0
	public void Clear() { }

	// RVA: 0x4B9560 Offset: 0x4B8960 VA: 0x1804B9560
	public void Add(List<DamageTypeEntry> entries) { }

	// RVA: 0x4B98F0 Offset: 0x4B8CF0 VA: 0x1804B98F0
	public void ScaleAll(float amount) { }

	// RVA: 0x4B9710 Offset: 0x4B8B10 VA: 0x1804B9710
	public DamageType GetMajorityDamageType() { }

	// RVA: 0x4B98C0 Offset: 0x4B8CC0 VA: 0x1804B98C0
	public bool IsMeleeType() { }

	// RVA: 0x4B9860 Offset: 0x4B8C60 VA: 0x1804B9860
	public bool IsBleedCausing() { }

	// RVA: 0x4B9890 Offset: 0x4B8C90 VA: 0x1804B9890
	public bool IsConsideredAnAttack() { }

	// RVA: 0x4B9A90 Offset: 0x4B8E90 VA: 0x1804B9A90
	public void .ctor() { }

}

