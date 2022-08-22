public class ParticleSystemLOD : LODComponentParticleSystem // TypeDefIndex: 9949
{	[HorizontalAttribute] // RVA: 0xAA1B0 Offset: 0xA95B0 VA: 0x1800AA1B0
	public ParticleSystemLOD.State[] States; // 0xA8


	protected override void SetLOD(int newlod) { }

	protected override int GetLOD(float distance) { }

	public void .ctor() { }

}

public class ParticleSystemLOD.State // TypeDefIndex: 9950
{	public float distance; // 0x10
	[RangeAttribute] // RVA: 0x71260 Offset: 0x70660 VA: 0x180071260
	public float emission; // 0x14


	public void .ctor() { }

}

