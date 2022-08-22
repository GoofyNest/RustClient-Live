public class BaseCorpse : BaseCombatEntity // TypeDefIndex: 9456
{	public GameObjectRef prefabRagdoll; // 0x240
	public BaseEntity parentEnt; // 0x248
	internal ResourceDispenser resourceDispenser; // 0x250
	internal GameObject ragdollObject; // 0x258

	public override BaseEntity.TraitFlag Traits { get; }


	protected override void ClientInit(Entity info) { }

	public override void ClientOnEnable() { }

	protected override void DoClientDestroy() { }

	public override void PostNetworkUpdate() { }

	private Rigidbody SetupRigidBody() { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	private void Load(Corpse corpse) { }

	public override void OnAttacked(HitInfo info) { }

	public override string Categorize() { }

	public override BaseEntity.TraitFlag get_Traits() { }

	public override bool ShouldInheritNetworkGroup() { }

	public void .ctor() { }

}

