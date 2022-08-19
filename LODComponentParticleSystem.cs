public abstract class LODComponentParticleSystem : LODComponent // TypeDefIndex: 9932
{	// Fields
	[TooltipAttribute] // RVA: 0xA9CF0 Offset: 0xA90F0 VA: 0x1800A9CF0
	public bool playOnShow; // 0x80
	protected ParticleSystem particleSystem; // 0x88
	protected Renderer particleSystemRenderer; // 0x90
	protected float maxEmission; // 0x98
	protected int curlod; // 0x9C
	protected bool force; // 0xA0
	private bool initialized; // 0xA1

	// Methods

	// RVA: 0x6B8230 Offset: 0x6B7630 VA: 0x1806B8230 Slot: 8
	protected override void InitLOD() { }

	// RVA: 0x6B8140 Offset: 0x6B7540 VA: 0x1806B8140 Slot: 9
	protected override void EnableLOD() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 10
	protected override void DisableLOD() { }

	// RVA: 0x6B8390 Offset: 0x6B7790 VA: 0x1806B8390 Slot: 13
	protected override void Show() { }

	// RVA: 0x6B8180 Offset: 0x6B7580 VA: 0x1806B8180 Slot: 14
	protected override void Hide() { }

	// RVA: 0x6B8150 Offset: 0x6B7550 VA: 0x1806B8150
	private void EnableParticleRenderer() { }

	// RVA: 0x6B8110 Offset: 0x6B7510 VA: 0x1806B8110
	private void DisableParticleRenderer() { }

	// RVA: 0x6B82F0 Offset: 0x6B76F0 VA: 0x1806B82F0
	protected void SetEmissionRate(float rate) { }

	// RVA: 0x6B8440 Offset: 0x6B7840 VA: 0x1806B8440
	protected void .ctor() { }

}

