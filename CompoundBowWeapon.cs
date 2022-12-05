public class CompoundBowWeapon : BowWeapon // TypeDefIndex: 10285
{
	public float stringHoldDurationMax;
	public float stringBonusDamage;
	public float stringBonusDistance;
	public float stringBonusVelocity;
	public float movementPenaltyRampUpTime;
	public float conditionLossPerSecondHeld;
	public float conditionLossHeldDelay;
	public SoundDefinition chargeUpSoundDef;
	public SoundDefinition stringHeldSoundDef;
	public SoundDefinition drawFinishSoundDef;
	private Sound chargeUpSound;
	private Sound stringHeldSound;
	protected float movementPenalty;
	private float lastMoveTime;
	private float currentHoldProgress;
	internal float stringHoldTimeStart;
	private bool drawFinishPlayed;


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public void UpdateMovementPenalty(float delta) { }

	public override void DidAttackClientside() { }

	public override void OnInput() { }

	public override void OnHolstered() { }

	public void SetStringHeld(bool isHeld) { }

	public override void OnViewmodelEvent(string name) { }

	public float GetLastPlayerMovementTime() { }

	public float GetStringBonusScale() { }

	public override float GetDamageScale(bool getMax = False) { }

	public override float GetDistanceScale(bool getMax = False) { }

	public override float GetProjectileVelocityScale(bool getMax = False) { }

	private void StopDrawSounds() { }

	private void UpdateDrawSounds() { }

	public void .ctor() { }

}

