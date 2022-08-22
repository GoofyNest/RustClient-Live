public class Detonator : HeldEntity, IRFObject // TypeDefIndex: 8565
{	public int frequency; // 0x1F8
	private float timeSinceDeploy; // 0x1FC
	public GameObjectRef frequencyPanelPrefab; // 0x200
	public GameObjectRef attackEffect; // 0x208
	public GameObjectRef unAttackEffect; // 0x210
	private float deployDelay; // 0x218
	private bool wasAttacking; // 0x21C
	private float configProgress; // 0x220
	private float attackHeldTime; // 0x224
	private float attackReleasedTime; // 0x228


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public virtual bool IsFullyDeployed() { }

	protected void ProcessInputTime() { }

	public override void OnDeploy() { }

	public override void OnHolstered() { }

	private void OpenConfigPanel() { }

	public override void OnInput() { }

	public void BeginSounds() { }

	public override void OnViewmodelEvent(string name) { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public int GetFrequency() { }

	public void ClientSetFrequency(int newFreq) { }

	public void .ctor() { }

}

