public class GingerbreadNPC : HumanNPC, IClientBrainStateListener // TypeDefIndex: 10665
{
	public GameObjectRef OverrideCorpseMale;
	public GameObjectRef OverrideCorpseFemale;
	public PhysicMaterial HitMaterial;
	public bool RoamAroundHomePoint;


	public override void OnAttacked(HitInfo info) { }

	public void StartAggroBlendShape() { }

	public void StopAggroBlendShape() { }

	public void OnClientStateChanged(AIState state) { }

	public void .ctor() { }

}

