public class BowWeapon : BaseProjectile // TypeDefIndex: 10243
{
	protected bool attackReady; 
	private float arrowBack; 
	private SwapArrows swapArrows; 
	private bool wasAiming; 


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	protected override void ClientInit(Entity info) { }

	public override void OnSignal(BaseEntity.Signal signal, string arg) { }

	public void UpdatePullbackThink() { }

	public void CancelPullbackThink() { }

	public void PullbackThink() { }

	public override void OnInput() { }

	public override void OnHolstered() { }

	public override void DoAttack() { }

	public bool IsAiming() { }

	public override void OnViewmodelEvent(string name) { }

	public override void OnFrame() { }

	public override void PostNetworkUpdate() { }

	private void TryReload() { }

	public override void ProcessSpectatorViewmodel(ViewModel vm) { }

	public void .ctor() { }

}

