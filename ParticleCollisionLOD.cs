public class ParticleCollisionLOD : LODComponentParticleSystem // TypeDefIndex: 9945
{	// Fields
	[HorizontalAttribute] // RVA: 0xAA1B0 Offset: 0xA95B0 VA: 0x1800AA1B0
	public ParticleCollisionLOD.State[] States; // 0xA8

	// Methods

	// RVA: 0x938900 Offset: 0x937D00 VA: 0x180938900
	private void UpdateLOD(int newlod) { }

	// RVA: 0x9388A0 Offset: 0x937CA0 VA: 0x1809388A0 Slot: 12
	protected override void SetLOD(int newlod) { }

	// RVA: 0x938800 Offset: 0x937C00 VA: 0x180938800 Slot: 11
	protected override int GetLOD(float distance) { }

	// RVA: 0x9389E0 Offset: 0x937DE0 VA: 0x1809389E0
	public void .ctor() { }

}

public enum ParticleCollisionLOD.QualityLevel // TypeDefIndex: 9946
{	// Fields
	public int value__; // 0x0
	public const ParticleCollisionLOD.QualityLevel Disabled = -1;
	public const ParticleCollisionLOD.QualityLevel HighQuality = 0;
	public const ParticleCollisionLOD.QualityLevel MediumQuality = 1;
	public const ParticleCollisionLOD.QualityLevel LowQuality = 2;

}

public class ParticleCollisionLOD.State // TypeDefIndex: 9947
{	// Fields
	public float distance; // 0x10
	public ParticleCollisionLOD.QualityLevel quality; // 0x14

	// Methods

	// RVA: 0x951AA0 Offset: 0x950EA0 VA: 0x180951AA0
	public void .ctor() { }

}

