public class ProtectionProperties : ScriptableObject // TypeDefIndex: 12510
{
	[TextAreaAttribute]
	public string comments;
	[RangeAttribute]
	public float density;
	[ArrayIndexIsEnumRanged]
	public float[] amounts;


	public void OnValidate() { }

	public void Clear() { }

	public void Add(float amount) { }

	public void Add(DamageType index, float amount) { }

	public void Add(ProtectionProperties other, float scale) { }

	public void Add(List<Item> items, HitArea area = -1) { }

	public void Multiply(float multiplier) { }

	public void Multiply(DamageType index, float multiplier) { }

	public void Scale(DamageTypeList damageList, float ProtectionAmount = 1) { }

	public float Get(DamageType damageType) { }

	public void .ctor() { }

}

