public class ElectricBattery : IOEntity, IInstanceDataReceiver // TypeDefIndex: 8700
{	public int maxOutput; // 0x288
	public float maxCapactiySeconds; // 0x28C
	public float rustWattSeconds; // 0x290
	private int activeDrain; // 0x294
	public bool rechargable; // 0x298
	[TooltipAttribute] // RVA: 0xBC150 Offset: 0xBB550 VA: 0x1800BC150
	public float maximumInboundEnergyRatio; // 0x29C
	public float chargeRatio; // 0x2A0
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

