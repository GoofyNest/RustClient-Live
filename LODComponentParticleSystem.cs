public abstract class LODComponentParticleSystem : LODComponent // TypeDefIndex: 9932
{	[TooltipAttribute] // RVA: 0xA9CF0 Offset: 0xA90F0 VA: 0x1800A9CF0
	public bool playOnShow; // 0x80
	protected ParticleSystem particleSystem; // 0x88
	protected Renderer particleSystemRenderer; // 0x90
	protected float maxEmission; // 0x98
	protected int curlod; // 0x9C
	protected bool force; // 0xA0
	private bool initialized; // 0xA1


	protected override void InitLOD() { }

	protected override void EnableLOD() { }

	protected override void DisableLOD() { }

	protected override void Show() { }

	protected override void Hide() { }

	private void EnableParticleRenderer() { }

	private void DisableParticleRenderer() { }

	protected void SetEmissionRate(float rate) { }

	protected void .ctor() { }

}

