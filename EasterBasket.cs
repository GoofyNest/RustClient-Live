public class EasterBasket : AttackEntity // TypeDefIndex: 8567
{	public GameObjectRef eggProjectile; // 0x280
	public ItemDefinition ammoType; // 0x288
	public int lastCollectedIndex; // 0x290
	private bool aiming; // 0x294
	private float nextAmmoCheckTime; // 0x298
	private bool didHaveAmmo; // 0x29C


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public override Vector3 GetInheritedVelocity(BasePlayer player) { }

	public Item GetAmmo() { }

	public bool HasAmmo() { }

	public void LaunchProjectile() { }

	public override void OnViewmodelEvent(string name) { }

	public override void OnInput() { }

	public void .ctor() { }

}

