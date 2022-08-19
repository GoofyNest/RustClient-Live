public class DamageProperties : ScriptableObject // TypeDefIndex: 9978
{	// Fields
	public DamageProperties fallback; // 0x18
	[HorizontalAttribute] // RVA: 0xAA1B0 Offset: 0xA95B0 VA: 0x1800AA1B0
	public DamageProperties.HitAreaProperty[] bones; // 0x20

	// Methods

	// RVA: 0x522F20 Offset: 0x522320 VA: 0x180522F20
	public float GetMultiplier(HitArea area) { }

	// RVA: 0x523020 Offset: 0x522420 VA: 0x180523020
	public void ScaleDamage(HitInfo info) { }

	// RVA: 0x4C0870 Offset: 0x4BFC70 VA: 0x1804C0870
	public void .ctor() { }

}

public class DamageProperties.HitAreaProperty // TypeDefIndex: 9979
{	// Fields
	public HitArea area; // 0x10
	public float damage; // 0x14

	// Methods

	// RVA: 0x524990 Offset: 0x523D90 VA: 0x180524990
	public void .ctor() { }

}

