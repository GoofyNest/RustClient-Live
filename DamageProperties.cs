public class DamageProperties : ScriptableObject // TypeDefIndex: 11727
{
	public DamageProperties fallback;
	[HorizontalAttribute]
	public DamageProperties.HitAreaProperty[] bones;


	public float GetMultiplier(HitArea area) { }

	public void ScaleDamage(HitInfo info) { }

	public void .ctor() { }

}

public class DamageProperties.HitAreaProperty // TypeDefIndex: 11728
{
	public HitArea area;
	public float damage;


	public void .ctor() { }

}

