public class EasterBasket : AttackEntity // TypeDefIndex: 10239
{
	public GameObjectRef eggProjectile; 
	public ItemDefinition ammoType; 
	public int lastCollectedIndex; 
	private bool aiming; 
	private float nextAmmoCheckTime; 
	private bool didHaveAmmo; 


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public override Vector3 GetInheritedVelocity(BasePlayer player) { }

	public Item GetAmmo() { }

	public bool HasAmmo() { }

	public void LaunchProjectile() { }

	public override void OnViewmodelEvent(string name) { }

	public override void OnInput() { }

	public void .ctor() { }

}

