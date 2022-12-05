public class BaseLauncher : BaseProjectile // TypeDefIndex: 10244
{
	private int lastSpectatorReloadAmmo;
	private TimeSince lastSpectatorAmmoInsert;


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public override void LaunchProjectile() { }

	public override void OnFrame() { }

	public override void ProcessSpectatorViewmodelEvent(ViewModel vm, BaseEntity.Signal signal, string arg) { }

	private void SpectatorInsertAmmo() { }

	public void .ctor() { }

}

