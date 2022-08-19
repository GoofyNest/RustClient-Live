public class BaseLiquidVessel : AttackEntity // TypeDefIndex: 8522
{	// Fields
	[HeaderAttribute] // RVA: 0xA2820 Offset: 0xA1C20 VA: 0x1800A2820
	public GameObjectRef thrownWaterObject; // 0x280
	public GameObjectRef ThrowEffect3P; // 0x288
	public SoundDefinition throwSound3P; // 0x290
	public GameObjectRef fillFromContainer; // 0x298
	public GameObjectRef fillFromWorld; // 0x2A0
	public SoundDefinition fillFromContainerStartSoundDef; // 0x2A8
	public SoundDefinition fillFromContainerSoundDef; // 0x2B0
	public SoundDefinition fillFromWorldStartSoundDef; // 0x2B8
	public SoundDefinition fillFromWorldSoundDef; // 0x2C0
	public bool hasLid; // 0x2C8
	public float throwScale; // 0x2CC
	public bool canDrinkFrom; // 0x2D0
	public bool updateVMWater; // 0x2D1
	public float minThrowFrac; // 0x2D4
	public bool useThrowAnim; // 0x2D8
	public float fillMlPerSec; // 0x2DC
	private Sound fillSound; // 0x2E0
	private float timeSinceLastAttack; // 0x2E8
	private bool wasFilling; // 0x2EC
	private float nextFreeTime; // 0x2F0

	// Methods

	// RVA: 0xA225D0 Offset: 0xA219D0 VA: 0x180A225D0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0xA215E0 Offset: 0xA209E0 VA: 0x180A215E0
	public int AmountHeld() { }

	// RVA: 0xA21D00 Offset: 0xA21100 VA: 0x180A21D00
	public float HeldFraction() { }

	// RVA: 0xA21DD0 Offset: 0xA211D0 VA: 0x180A21DD0
	public int MaxHoldable() { }

	// RVA: 0xA21810 Offset: 0xA20C10 VA: 0x180A21810
	public bool CanDrink() { }

	// RVA: 0xA21DA0 Offset: 0xA211A0 VA: 0x180A21DA0
	private bool IsWeaponBusy() { }

	// RVA: 0xA231F0 Offset: 0xA225F0 VA: 0x180A231F0
	private void SetBusyFor(float dur) { }

	// RVA: 0xA21A00 Offset: 0xA20E00 VA: 0x180A21A00
	private void ClearBusy() { }

	// RVA: 0xA216F0 Offset: 0xA20AF0 VA: 0x180A216F0 Slot: 160
	public virtual void CLThrow() { }

	// RVA: 0xA21E60 Offset: 0xA21260 VA: 0x180A21E60 Slot: 138
	public override void OnInput() { }

	// RVA: 0xA21A30 Offset: 0xA20E30 VA: 0x180A21A30 Slot: 161
	public virtual void DoSendFilling(bool flag) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 162
	public virtual void OnPrimaryAttackPressed() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 163
	public virtual void OnEmptyPrimaryAttackPressed() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 164
	public virtual void OnPrimaryAttackReleased() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 165
	public virtual void OnReloadPressed() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 166
	public virtual void OnReloadHeld() { }

	// RVA: 0xA223D0 Offset: 0xA217D0 VA: 0x180A223D0 Slot: 167
	public virtual void OnPrimaryAttackHeld(Item ammo, BasePlayer player) { }

	// RVA: 0xA230A0 Offset: 0xA224A0 VA: 0x180A230A0 Slot: 144
	public override void OnViewmodelEvent(string name) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xA21620 Offset: 0xA20A20 VA: 0x180A21620
	public void CLIENT_StartFillingSoundsContainer(BaseEntity.RPCMessage rpc) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xA21630 Offset: 0xA20A30 VA: 0x180A21630
	public void CLIENT_StartFillingSoundsWorld(BaseEntity.RPCMessage rpc) { }

	// RVA: 0xA23220 Offset: 0xA22620 VA: 0x180A23220
	private void StartFillingSounds(bool fromContainer = True) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xA21640 Offset: 0xA20A40 VA: 0x180A21640
	public void CLIENT_StopFillingSounds(BaseEntity.RPCMessage rpc) { }

	// RVA: 0xA21640 Offset: 0xA20A40 VA: 0x180A21640
	private void StopFillingSounds() { }

	// RVA: 0xA23140 Offset: 0xA22540 VA: 0x180A23140 Slot: 153
	public override void ProcessSpectatorViewmodelEvent(ViewModel vm, BaseEntity.Signal signal, string arg) { }

	// RVA: 0xA218F0 Offset: 0xA20CF0 VA: 0x180A218F0
	public bool CanFillFromWorld() { }

	// RVA: 0xA219E0 Offset: 0xA20DE0 VA: 0x180A219E0
	public bool CanThrow() { }

	// RVA: 0xA21A80 Offset: 0xA20E80 VA: 0x180A21A80
	public LiquidContainer GetFacingLiquidContainer() { }

	// RVA: 0xA23500 Offset: 0xA22900 VA: 0x180A23500
	public void .ctor() { }

}

