public class ParticleCollisionLOD : LODComponentParticleSystem // TypeDefIndex: 11694
{
	[HorizontalAttribute]
	public ParticleCollisionLOD.State[] States;


	private void UpdateLOD(int newlod) { }

	protected override void SetLOD(int newlod) { }

	protected override int GetLOD(float distance) { }

	public void .ctor() { }

}

public enum ParticleCollisionLOD.QualityLevel // TypeDefIndex: 11695
{
	public int value__;
	public const ParticleCollisionLOD.QualityLevel Disabled = -1;
	public const ParticleCollisionLOD.QualityLevel HighQuality = 0;
	public const ParticleCollisionLOD.QualityLevel MediumQuality = 1;
	public const ParticleCollisionLOD.QualityLevel LowQuality = 2;

}

public class ParticleCollisionLOD.State // TypeDefIndex: 11696
{
	public float distance;
	public ParticleCollisionLOD.QualityLevel quality;


	public void .ctor() { }

}

