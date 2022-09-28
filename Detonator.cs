public class Detonator : HeldEntity, IRFObject // TypeDefIndex: 10237
{
	public int frequency; 
	private float timeSinceDeploy; 
	public GameObjectRef frequencyPanelPrefab; 
	public GameObjectRef attackEffect; 
	public GameObjectRef unAttackEffect; 
	private float deployDelay; 
	private bool wasAttacking; 
	private float configProgress; 
	private float attackHeldTime; 
	private float attackReleasedTime; 


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

