public class ThrownWeapon : AttackEntity // TypeDefIndex: 8654
{	[HeaderAttribute] // RVA: 0xB6D10 Offset: 0xB6110 VA: 0x1800B6D10
	public GameObjectRef prefabToThrow; // 0x280
	public float maxThrowVelocity; // 0x288
	public float tumbleVelocity; // 0x28C
	public Vector3 overrideAngle; // 0x290
	public bool canStick; // 0x29C


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public override Vector3 GetInheritedVelocity(BasePlayer player) { }

	public override void OnInput() { }

	public override void OnViewmodelEvent(string name) { }

	public void .ctor() { }

}

