public class Toolgun : Hammer // TypeDefIndex: 10365
{
	public GameObjectRef attackEffect; 
	public GameObjectRef beamEffect; 
	public GameObjectRef beamImpactEffect; 
	public GameObjectRef errorEffect; 
	public GameObjectRef beamEffectClassic; 
	public GameObjectRef beamImpactEffectClassic; 
	public Transform muzzlePoint; 
	[ClientVar] 
	public static bool classiceffects; 


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public override void OnInput() { }

	public override void DoViewmodelImpact(HitTest test) { }

	public void DoTGEffect(Vector3 endPos, Vector3 endNormal) { }

	public void DoAttackEffect(Vector3 endPos, Vector3 normal) { }

	[BaseEntity.RPC_Client] 
	public void EffectSpawn(BaseEntity.RPCMessage msg) { }

	public override void ClientAttack() { }

	public override void DoAttackShared(HitInfo info) { }

	public void .ctor() { }

	private static void .cctor() { }

}

