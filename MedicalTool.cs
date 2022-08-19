public class MedicalTool : AttackEntity // TypeDefIndex: 8603
{	// Fields
	public float healDurationSelf; // 0x280
	public float healDurationOther; // 0x284
	public float healDurationOtherWounded; // 0x288
	public float maxDistanceOther; // 0x28C
	public bool canUseOnOther; // 0x290
	public bool canRevive; // 0x291
	private BasePlayer useTarget; // 0x298
	private float resetTime; // 0x2A0

	// Methods

	// RVA: 0x957D80 Offset: 0x957180 VA: 0x180957D80 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x957620 Offset: 0x956A20 VA: 0x180957620
	public BasePlayer GetTarget() { }

	// RVA: 0x957550 Offset: 0x956950 VA: 0x180957550
	public bool AnyPressed() { }

	// RVA: 0x9579D0 Offset: 0x956DD0 VA: 0x1809579D0 Slot: 138
	public override void OnInput() { }

	// RVA: 0x958150 Offset: 0x957550 VA: 0x180958150 Slot: 144
	public override void OnViewmodelEvent(string name) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x958360 Offset: 0x957760 VA: 0x180958360
	public void Reset() { }

	// RVA: 0x957970 Offset: 0x956D70 VA: 0x180957970 Slot: 140
	public override void OnDeploy() { }

	// RVA: 0x9579A0 Offset: 0x956DA0 VA: 0x1809579A0 Slot: 143
	public override void OnHolstered() { }

	// RVA: 0x9582A0 Offset: 0x9576A0 VA: 0x1809582A0 Slot: 153
	public override void ProcessSpectatorViewmodelEvent(ViewModel vm, BaseEntity.Signal signal, string arg) { }

	// RVA: 0x958380 Offset: 0x957780 VA: 0x180958380
	public void .ctor() { }

}

