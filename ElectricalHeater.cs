public class ElectricalHeater : IOEntity // TypeDefIndex: 10427
{
	public float fadeDuration; 
	public Light sourceLight; 
	public GrowableHeatSource growableHeatSource; 
	private float initialIntensity; 
	private float currentScale; 
	private bool wasOn; 


	public override int ConsumptionAmount() { }

	public override void ResetState() { }

	protected override void ClientInit(Entity info) { }

	public override void PostNetworkUpdate() { }

	public void LightLerp() { }

	public void .ctor() { }

}

