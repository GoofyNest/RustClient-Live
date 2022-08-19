public class ParticleSystemLOD : LODComponentParticleSystem // TypeDefIndex: 9949
{	// Fields
	[HorizontalAttribute] // RVA: 0xAA1B0 Offset: 0xA95B0 VA: 0x1800AA1B0
	public ParticleSystemLOD.State[] States; // 0xA8

	// Methods

	// RVA: 0x93B980 Offset: 0x93AD80 VA: 0x18093B980 Slot: 12
	protected override void SetLOD(int newlod) { }

	// RVA: 0x93B820 Offset: 0x93AC20 VA: 0x18093B820 Slot: 11
	protected override int GetLOD(float distance) { }

	// RVA: 0x9389E0 Offset: 0x937DE0 VA: 0x1809389E0
	public void .ctor() { }

}

public class ParticleSystemLOD.State // TypeDefIndex: 9950
{	// Fields
	public float distance; // 0x10
	[RangeAttribute] // RVA: 0x71260 Offset: 0x70660 VA: 0x180071260
	public float emission; // 0x14

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

