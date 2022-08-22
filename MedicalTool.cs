public class MedicalTool : AttackEntity // TypeDefIndex: 8603
{	public float healDurationSelf; // 0x280
	public float healDurationOther; // 0x284
	public float healDurationOtherWounded; // 0x288
	public float maxDistanceOther; // 0x28C
	public bool canUseOnOther; // 0x290
	public bool canRevive; // 0x291
	private BasePlayer useTarget; // 0x298
	private float resetTime; // 0x2A0


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public BasePlayer GetTarget() { }

	public bool AnyPressed() { }

	public override void OnInput() { }

	public override void OnViewmodelEvent(string name) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void Reset() { }

	public override void OnDeploy() { }

	public override void OnHolstered() { }

	public override void ProcessSpectatorViewmodelEvent(ViewModel vm, BaseEntity.Signal signal, string arg) { }

	public void .ctor() { }

}

