public abstract class LODComponentParticleSystem : LODComponent // TypeDefIndex: 11645
{
	[TooltipAttribute] 
	public bool playOnShow; 
	protected ParticleSystem particleSystem; 
	protected Renderer particleSystemRenderer; 
	protected float maxEmission; 
	protected int curlod; 
	protected bool force; 
	private bool initialized; 


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

