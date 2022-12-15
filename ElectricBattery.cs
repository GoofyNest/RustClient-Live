public class ElectricBattery : IOEntity, IInstanceDataReceiver // TypeDefIndex: 10429
{
	public int maxOutput;
	public float maxCapactiySeconds;
	public float rustWattSeconds;
	private int activeDrain;
	public bool rechargable;
	[TooltipAttribute]
	public float maximumInboundEnergyRatio;
	public float chargeRatio;
	private const float tickRateSeconds = 1;
	public const BaseEntity.Flags Flag_HalfFull = 2048;
	public const BaseEntity.Flags Flag_VeryFull = 16384;


	public override bool IsRootEntity() { }

	public override int ConsumptionAmount() { }

	public override int MaximalPowerOutput() { }

	public int GetActiveDrain() { }

	public override void ProcessAdditionalData(int first, int second, float third, float fourth) { }

	public void ReceiveInstanceData(Item.InstanceData data) { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public void .ctor() { }

}

