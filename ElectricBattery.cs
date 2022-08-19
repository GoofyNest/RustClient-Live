public class ElectricBattery : IOEntity, IInstanceDataReceiver // TypeDefIndex: 8700
{	// Fields
	public int maxOutput; // 0x288
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

	// Methods

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 145
	public override bool IsRootEntity() { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 150
	public override int ConsumptionAmount() { }

	// RVA: 0xABB240 Offset: 0xABA640 VA: 0x180ABB240 Slot: 151
	public override int MaximalPowerOutput() { }

	// RVA: 0xABB1B0 Offset: 0xABA5B0 VA: 0x180ABB1B0
	public int GetActiveDrain() { }

	// RVA: 0xABB250 Offset: 0xABA650 VA: 0x180ABB250 Slot: 155
	public override void ProcessAdditionalData(int first, int second, float third, float fourth) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 159
	public void ReceiveInstanceData(Item.InstanceData data) { }

	// RVA: 0xABB1E0 Offset: 0xABA5E0 VA: 0x180ABB1E0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0xABB2B0 Offset: 0xABA6B0 VA: 0x180ABB2B0
	public void .ctor() { }

}

