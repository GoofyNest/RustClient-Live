public class SolarPanel : IOEntity // TypeDefIndex: 8712
{	public Transform sunSampler; // 0x288
	private const int tickrateSeconds = 60;
	public int maximalPowerOutput; // 0x290
	public float dot_minimum; // 0x294
	public float dot_maximum; // 0x298


	public override bool IsRootEntity() { }

	public override int MaximalPowerOutput() { }

	public override int ConsumptionAmount() { }

	public void .ctor() { }

}

