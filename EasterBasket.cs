public class EasterBasket : AttackEntity // TypeDefIndex: 8567
{	// Fields
	public GameObjectRef eggProjectile; // 0x280
	public ItemDefinition ammoType; // 0x288
	public int lastCollectedIndex; // 0x290
	private bool aiming; // 0x294
	private float nextAmmoCheckTime; // 0x298
	private bool didHaveAmmo; // 0x29C

	// Methods

	// RVA: 0xAB3A00 Offset: 0xAB2E00 VA: 0x180AB3A00 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x903120 Offset: 0x902520 VA: 0x180903120 Slot: 157
	public override Vector3 GetInheritedVelocity(BasePlayer player) { }

	// RVA: 0xAB2E40 Offset: 0xAB2240 VA: 0x180AB2E40
	public Item GetAmmo() { }

	// RVA: 0xAB2F30 Offset: 0xAB2330 VA: 0x180AB2F30
	public bool HasAmmo() { }

	// RVA: 0xAB2F50 Offset: 0xAB2350 VA: 0x180AB2F50
	public void LaunchProjectile() { }

	// RVA: 0xAB3AF0 Offset: 0xAB2EF0 VA: 0x180AB3AF0 Slot: 144
	public override void OnViewmodelEvent(string name) { }

	// RVA: 0xAB3210 Offset: 0xAB2610 VA: 0x180AB3210 Slot: 138
	public override void OnInput() { }

	// RVA: 0xAB3D00 Offset: 0xAB3100 VA: 0x180AB3D00
	public void .ctor() { }

}

