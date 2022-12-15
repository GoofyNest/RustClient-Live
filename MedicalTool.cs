public class MedicalTool : AttackEntity // TypeDefIndex: 10329
{
	public float healDurationSelf;
	public float healDurationOther;
	public float healDurationOtherWounded;
	public float maxDistanceOther;
	public bool canUseOnOther;
	public bool canRevive;
	private BasePlayer useTarget;
	private float resetTime;


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public BasePlayer GetTarget() { }

	public bool AnyPressed() { }

	public override void OnInput() { }

	public override void OnViewmodelEvent(string name) { }

	[BaseEntity.RPC_Client]
	public void Reset() { }

	public override void OnDeploy() { }

	public override void OnHolstered() { }

	public override void ProcessSpectatorViewmodelEvent(ViewModel vm, BaseEntity.Signal signal, string arg) { }

	public void .ctor() { }

}

