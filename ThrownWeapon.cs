public class ThrownWeapon : AttackEntity // TypeDefIndex: 10380
{
	[HeaderAttribute]
	public GameObjectRef prefabToThrow;
	public float maxThrowVelocity;
	public float tumbleVelocity;
	public Vector3 overrideAngle;
	public bool canStick;
	public bool canThrowUnderwater;


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public override Vector3 GetInheritedVelocity(BasePlayer player, Vector3 direction) { }

	public override void OnInput() { }

	public override void OnViewmodelEvent(string name) { }

	public void .ctor() { }

}

