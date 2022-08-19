public class CompoundBowWeapon : BowWeapon // TypeDefIndex: 8561
{	// Fields
	public float stringHoldDurationMax; // 0x390
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

	// Methods

	// RVA: 0x6CFD90 Offset: 0x6CF190 VA: 0x1806CFD90 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x6D0530 Offset: 0x6CF930 VA: 0x1806D0530
	public void UpdateMovementPenalty(float delta) { }

	// RVA: 0x6CF7E0 Offset: 0x6CEBE0 VA: 0x1806CF7E0 Slot: 165
	public override void DidAttackClientside() { }

	// RVA: 0x6CFA50 Offset: 0x6CEE50 VA: 0x1806CFA50 Slot: 138
	public override void OnInput() { }

	// RVA: 0x6CF9B0 Offset: 0x6CEDB0 VA: 0x1806CF9B0 Slot: 143
	public override void OnHolstered() { }

	// RVA: 0x6CFF80 Offset: 0x6CF380 VA: 0x1806CFF80
	public void SetStringHeld(bool isHeld) { }

	// RVA: 0x6CFE80 Offset: 0x6CF280 VA: 0x1806CFE80 Slot: 144
	public override void OnViewmodelEvent(string name) { }

	// RVA: 0x6CF880 Offset: 0x6CEC80 VA: 0x1806CF880
	public float GetLastPlayerMovementTime() { }

	// RVA: 0x6CF8F0 Offset: 0x6CECF0 VA: 0x1806CF8F0
	public float GetStringBonusScale() { }

	// RVA: 0x6CF800 Offset: 0x6CEC00 VA: 0x1806CF800 Slot: 160
	public override float GetDamageScale(bool getMax = False) { }

	// RVA: 0x6CF840 Offset: 0x6CEC40 VA: 0x1806CF840 Slot: 161
	public override float GetDistanceScale(bool getMax = False) { }

	// RVA: 0x6CF8B0 Offset: 0x6CECB0 VA: 0x1806CF8B0 Slot: 162
	public override float GetProjectileVelocityScale(bool getMax = False) { }

	// RVA: 0x6CFFF0 Offset: 0x6CF3F0 VA: 0x1806CFFF0
	private void StopDrawSounds() { }

	// RVA: 0x6D0120 Offset: 0x6CF520 VA: 0x1806D0120
	private void UpdateDrawSounds() { }

	// RVA: 0x6D06C0 Offset: 0x6CFAC0 VA: 0x1806D06C0
	public void .ctor() { }

}

