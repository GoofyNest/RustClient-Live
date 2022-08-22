public class TeslaCoil : IOEntity // TypeDefIndex: 8717
{	public TargetTrigger targetTrigger; // 0x288
	public TriggerMovement movementTrigger; // 0x290
	public float powerToDamageRatio; // 0x298
	public float dischargeTickRate; // 0x29C
	public float maxDischargeSelfDamageSeconds; // 0x2A0
	public float maxDamageOutput; // 0x2A4
	public Transform damageEyes; // 0x2A8
	public const BaseEntity.Flags Flag_WeakShorting = 128;
	public const BaseEntity.Flags Flag_StrongShorting = 256;
	public int powerForHeavyShorting; // 0x2B0


	public override int ConsumptionAmount() { }

	public override void PostNetworkUpdate() { }

	public void .ctor() { }

}

