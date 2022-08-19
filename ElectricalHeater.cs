public class ElectricalHeater : IOEntity // TypeDefIndex: 8705
{	// Fields
	public float fadeDuration; // 0x288
	public Light sourceLight; // 0x290
	public GrowableHeatSource growableHeatSource; // 0x298
	private float initialIntensity; // 0x2A0
	private float currentScale; // 0x2A4
	private bool wasOn; // 0x2A8

	// Methods

	// RVA: 0xABD0E0 Offset: 0xABC4E0 VA: 0x180ABD0E0 Slot: 150
	public override int ConsumptionAmount() { }

	// RVA: 0xABD330 Offset: 0xABC730 VA: 0x180ABD330 Slot: 27
	public override void ResetState() { }

	// RVA: 0xABD090 Offset: 0xABC490 VA: 0x180ABD090 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0xABD280 Offset: 0xABC680 VA: 0x180ABD280 Slot: 16
	public override void PostNetworkUpdate() { }

	// RVA: 0xABD0F0 Offset: 0xABC4F0 VA: 0x180ABD0F0
	public void LightLerp() { }

	// RVA: 0xABD3F0 Offset: 0xABC7F0 VA: 0x180ABD3F0
	public void .ctor() { }

}

