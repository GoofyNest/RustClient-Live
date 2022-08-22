public class CompoundBowWeapon : BowWeapon // TypeDefIndex: 8561
{	public float stringHoldDurationMax; // 0x390
	public float stringBonusDamage; // 0x394
	public float stringBonusDistance; // 0x398
	public float stringBonusVelocity; // 0x39C
	public float movementPenaltyRampUpTime; // 0x3A0
	public float conditionLossPerSecondHeld; // 0x3A4
	public float conditionLossHeldDelay; // 0x3A8
	public SoundDefinition chargeUpSoundDef; // 0x3B0
	public SoundDefinition stringHeldSoundDef; // 0x3B8
	public SoundDefinition drawFinishSoundDef; // 0x3C0
	private Sound chargeUpSound; // 0x3C8
	private Sound stringHeldSound; // 0x3D0
	protected float movementPenalty; // 0x3D8
	private float lastMoveTime; // 0x3DC
	private float currentHoldProgress; // 0x3E0
	internal float stringHoldTimeStart; // 0x3E4
	private bool drawFinishPlayed; // 0x3E8


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

