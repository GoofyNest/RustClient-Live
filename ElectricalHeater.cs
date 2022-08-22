public class ElectricalHeater : IOEntity // TypeDefIndex: 8705
{	public float fadeDuration; // 0x288
	public Light sourceLight; // 0x290
	public GrowableHeatSource growableHeatSource; // 0x298
	private float initialIntensity; // 0x2A0
	private float currentScale; // 0x2A4
	private bool wasOn; // 0x2A8


	public override int ConsumptionAmount() { }

	public override void ResetState() { }

	protected override void ClientInit(Entity info) { }

	public override void PostNetworkUpdate() { }

	public void LightLerp() { }

	public void .ctor() { }

}

