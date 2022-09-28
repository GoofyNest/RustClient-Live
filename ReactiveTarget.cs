public class ReactiveTarget : IOEntity // TypeDefIndex: 10104
{
	private Option __menuOption_Lower_Target; 
	private Option __menuOption_Reset_target; 
	public Animator myAnimator; 
	public GameObjectRef bullseyeEffect; 
	public GameObjectRef knockdownEffect; 
	public float activationPowerTime; 
	public int activationPowerAmount; 
	private float lastToggleTime; 

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public void OnHitShared(HitInfo info) { }

	public bool IsKnockedDown() { }

	public override void OnAttacked(HitInfo info) { }

	public override bool CanPickup(BasePlayer player) { }

	public bool CanToggle() { }

	[BaseEntity.RPC_Client] 
	public void HitEffect(BaseEntity.RPCMessage msg) { }

	public override void ClientOnEnable() { }

	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	private void UpdateAnimationParameters(bool isOn) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Reset_target(BasePlayer player) { }

	public bool Menu_Reset_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Lower_Target(BasePlayer player) { }

	public bool Menu_Lower_ShowIf(BasePlayer player) { }

	public void .ctor() { }

}

