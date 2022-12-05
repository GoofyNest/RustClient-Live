public class SolarPanel : IOEntity // TypeDefIndex: 10439
{
	public Transform sunSampler;
	private const int tickrateSeconds = 60;
	public int maximalPowerOutput;
	public float dot_minimum;
	public float dot_maximum;


	public override bool IsRootEntity() { }

	public override int MaximalPowerOutput() { }

	public override int ConsumptionAmount() { }

	public void .ctor() { }

}

