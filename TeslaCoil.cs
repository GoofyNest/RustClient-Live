public class TeslaCoil : IOEntity // TypeDefIndex: 10446
{
	public TargetTrigger targetTrigger;
	public TriggerMovement movementTrigger;
	public float powerToDamageRatio;
	public float dischargeTickRate;
	public float maxDischargeSelfDamageSeconds;
	public float maxDamageOutput;
	public Transform damageEyes;
	public const BaseEntity.Flags Flag_WeakShorting = 128;
	public const BaseEntity.Flags Flag_StrongShorting = 256;
	public int powerForHeavyShorting;


	public override int ConsumptionAmount() { }

	public override void PostNetworkUpdate() { }

	public void .ctor() { }

}

