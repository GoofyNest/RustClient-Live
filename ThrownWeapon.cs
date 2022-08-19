public class ThrownWeapon : AttackEntity // TypeDefIndex: 8654
{	// Fields
	[HeaderAttribute] // RVA: 0xB6D10 Offset: 0xB6110 VA: 0x1800B6D10
	public GameObjectRef prefabToThrow; // 0x280
	public float maxThrowVelocity; // 0x288
	public float tumbleVelocity; // 0x28C
	public Vector3 overrideAngle; // 0x290
	public bool canStick; // 0x29C

	// Methods

	// RVA: 0x84E090 Offset: 0x84D490 VA: 0x18084E090 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x84DCC0 Offset: 0x84D0C0 VA: 0x18084DCC0 Slot: 157
	public override Vector3 GetInheritedVelocity(BasePlayer player) { }

	// RVA: 0x84DD10 Offset: 0x84D110 VA: 0x18084DD10 Slot: 138
	public override void OnInput() { }

	// RVA: 0x84E180 Offset: 0x84D580 VA: 0x18084E180 Slot: 144
	public override void OnViewmodelEvent(string name) { }

	// RVA: 0x84E190 Offset: 0x84D590 VA: 0x18084E190
	public void .ctor() { }

}

