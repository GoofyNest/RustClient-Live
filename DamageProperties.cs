public class DamageProperties : ScriptableObject // TypeDefIndex: 9978
{	public DamageProperties fallback; // 0x18
	[HorizontalAttribute] // RVA: 0xAA1B0 Offset: 0xA95B0 VA: 0x1800AA1B0
	public DamageProperties.HitAreaProperty[] bones; // 0x20


	public float GetMultiplier(HitArea area) { }

	public void ScaleDamage(HitInfo info) { }

	public void .ctor() { }

}

public class DamageProperties.HitAreaProperty // TypeDefIndex: 9979
{	public HitArea area; // 0x10
	public float damage; // 0x14


	public void .ctor() { }

}

