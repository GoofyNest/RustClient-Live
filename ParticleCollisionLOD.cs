public class ParticleCollisionLOD : LODComponentParticleSystem // TypeDefIndex: 9945
{	[HorizontalAttribute] // RVA: 0xAA1B0 Offset: 0xA95B0 VA: 0x1800AA1B0
	public ParticleCollisionLOD.State[] States; // 0xA8


	private void UpdateLOD(int newlod) { }

	protected override void SetLOD(int newlod) { }

	protected override int GetLOD(float distance) { }

	public void .ctor() { }

}

public enum ParticleCollisionLOD.QualityLevel // TypeDefIndex: 9946
{	public int value__; // 0x0
	public const ParticleCollisionLOD.QualityLevel Disabled = -1;
	public const ParticleCollisionLOD.QualityLevel HighQuality = 0;
	public const ParticleCollisionLOD.QualityLevel MediumQuality = 1;
	public const ParticleCollisionLOD.QualityLevel LowQuality = 2;

}

public class ParticleCollisionLOD.State // TypeDefIndex: 9947
{	public float distance; // 0x10
	public ParticleCollisionLOD.QualityLevel quality; // 0x14


	public void .ctor() { }

}

