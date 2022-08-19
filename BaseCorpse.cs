public class BaseCorpse : BaseCombatEntity // TypeDefIndex: 9456
{	// Fields
	public GameObjectRef prefabRagdoll; // 0x240
	public BaseEntity parentEnt; // 0x248
	internal ResourceDispenser resourceDispenser; // 0x250
	internal GameObject ragdollObject; // 0x258

	// Properties
	public override BaseEntity.TraitFlag Traits { get; }

	// Methods

	// RVA: 0x7F0FC0 Offset: 0x7F03C0 VA: 0x1807F0FC0 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x7F1540 Offset: 0x7F0940 VA: 0x1807F1540 Slot: 13
	public override void ClientOnEnable() { }

	// RVA: 0x7F1740 Offset: 0x7F0B40 VA: 0x1807F1740 Slot: 19
	protected override void DoClientDestroy() { }

	// RVA: 0x7F1DB0 Offset: 0x7F11B0 VA: 0x1807F1DB0 Slot: 16
	public override void PostNetworkUpdate() { }

	// RVA: 0x7F1F10 Offset: 0x7F1310 VA: 0x1807F1F10
	private Rigidbody SetupRigidBody() { }

	// RVA: 0x7F1950 Offset: 0x7F0D50 VA: 0x1807F1950 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x7F1860 Offset: 0x7F0C60 VA: 0x1807F1860
	private void Load(Corpse corpse) { }

	// RVA: 0x7F1B00 Offset: 0x7F0F00 VA: 0x1807F1B00 Slot: 116
	public override void OnAttacked(HitInfo info) { }

	// RVA: 0x7F0F90 Offset: 0x7F0390 VA: 0x1807F0F90 Slot: 122
	public override string Categorize() { }

	// RVA: 0x7F2080 Offset: 0x7F1480 VA: 0x1807F2080 Slot: 86
	public override BaseEntity.TraitFlag get_Traits() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 128
	public override bool ShouldInheritNetworkGroup() { }

	// RVA: 0x499120 Offset: 0x498520 VA: 0x180499120
	public void .ctor() { }

}

