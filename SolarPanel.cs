public class SolarPanel : IOEntity // TypeDefIndex: 8712
{	// Fields
	public Transform sunSampler; // 0x288
	private const int tickrateSeconds = 60;
	public int maximalPowerOutput; // 0x290
	public float dot_minimum; // 0x294
	public float dot_maximum; // 0x298

	// Methods

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 145
	public override bool IsRootEntity() { }

	// RVA: 0x5D92B0 Offset: 0x5D86B0 VA: 0x1805D92B0 Slot: 151
	public override int MaximalPowerOutput() { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 150
	public override int ConsumptionAmount() { }

	// RVA: 0x5D92C0 Offset: 0x5D86C0 VA: 0x1805D92C0
	public void .ctor() { }

}

