public class BaseLiquidVessel : AttackEntity // TypeDefIndex: 8522
{	[HeaderAttribute] // RVA: 0xA2820 Offset: 0xA1C20 VA: 0x1800A2820
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


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public int AmountHeld() { }

	public float HeldFraction() { }

	public int MaxHoldable() { }

	public bool CanDrink() { }

	private bool IsWeaponBusy() { }

	private void SetBusyFor(float dur) { }

	private void ClearBusy() { }

	public virtual void CLThrow() { }

	public override void OnInput() { }

	public virtual void DoSendFilling(bool flag) { }

	public virtual void OnPrimaryAttackPressed() { }

	public virtual void OnEmptyPrimaryAttackPressed() { }

	public virtual void OnPrimaryAttackReleased() { }

	public virtual void OnReloadPressed() { }

	public virtual void OnReloadHeld() { }

	public virtual void OnPrimaryAttackHeld(Item ammo, BasePlayer player) { }

	public override void OnViewmodelEvent(string name) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void CLIENT_StartFillingSoundsContainer(BaseEntity.RPCMessage rpc) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void CLIENT_StartFillingSoundsWorld(BaseEntity.RPCMessage rpc) { }

	private void StartFillingSounds(bool fromContainer = True) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void CLIENT_StopFillingSounds(BaseEntity.RPCMessage rpc) { }

	private void StopFillingSounds() { }

	public override void ProcessSpectatorViewmodelEvent(ViewModel vm, BaseEntity.Signal signal, string arg) { }

	public bool CanFillFromWorld() { }

	public bool CanThrow() { }

	public LiquidContainer GetFacingLiquidContainer() { }

	public void .ctor() { }

}

