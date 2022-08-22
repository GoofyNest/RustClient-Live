public class ProtectionProperties : ScriptableObject // TypeDefIndex: 10750
{	[TextAreaAttribute] // RVA: 0x72060 Offset: 0x71460 VA: 0x180072060
	public string comments; // 0x18
	[RangeAttribute] // RVA: 0x77CA0 Offset: 0x770A0 VA: 0x180077CA0
	public float density; // 0x20
	[ArrayIndexIsEnumRanged] // RVA: 0x77E20 Offset: 0x77220 VA: 0x180077E20
	public float[] amounts; // 0x28


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

