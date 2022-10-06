public class BaseLiquidVessel : AttackEntity // TypeDefIndex: 10229
{
	[HeaderAttribute] 
	public GameObjectRef thrownWaterObject; 
	public GameObjectRef ThrowEffect3P; 
	public SoundDefinition throwSound3P; 
	public GameObjectRef fillFromContainer; 
	public GameObjectRef fillFromWorld; 
	public SoundDefinition fillFromContainerStartSoundDef; 
	public SoundDefinition fillFromContainerSoundDef; 
	public SoundDefinition fillFromWorldStartSoundDef; 
	public SoundDefinition fillFromWorldSoundDef; 
	public bool hasLid; 
	public float throwScale; 
	public bool canDrinkFrom; 
	public bool updateVMWater; 
	public float minThrowFrac; 
	public bool useThrowAnim; 
	public float fillMlPerSec; 
	private Sound fillSound; 
	private float timeSinceLastAttack; 
	private bool wasFilling; 
	private float nextFreeTime; 


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

	[BaseEntity.RPC_Client] 
	public void CLIENT_StartFillingSoundsContainer(BaseEntity.RPCMessage rpc) { }

	[BaseEntity.RPC_Client] 
	public void CLIENT_StartFillingSoundsWorld(BaseEntity.RPCMessage rpc) { }

	private void StartFillingSounds(bool fromContainer = True) { }

	[BaseEntity.RPC_Client] 
	public void CLIENT_StopFillingSounds(BaseEntity.RPCMessage rpc) { }

	private void StopFillingSounds() { }

	public override void ProcessSpectatorViewmodelEvent(ViewModel vm, BaseEntity.Signal signal, string arg) { }

	public bool CanFillFromWorld() { }

	public bool CanThrow() { }

	public LiquidContainer GetFacingLiquidContainer() { }

	public void .ctor() { }

}

