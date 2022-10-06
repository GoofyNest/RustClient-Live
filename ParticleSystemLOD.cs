public class ParticleSystemLOD : LODComponentParticleSystem // TypeDefIndex: 11662
{
	[HorizontalAttribute] 
	public ParticleSystemLOD.State[] States; 


	protected override void SetLOD(int newlod) { }

	protected override int GetLOD(float distance) { }

	public void .ctor() { }

}

public class ParticleSystemLOD.State // TypeDefIndex: 11663
{
	public float distance; 
	[RangeAttribute] 
	public float emission; 


	public void .ctor() { }

}

