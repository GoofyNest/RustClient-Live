public class Toolgun : Hammer // TypeDefIndex: 8655
{	// Fields
	public GameObjectRef attackEffect; // 0x2E0
	public GameObjectRef beamEffect; // 0x2E8
	public GameObjectRef beamImpactEffect; // 0x2F0
	public GameObjectRef errorEffect; // 0x2F8
	public GameObjectRef beamEffectClassic; // 0x300
	public GameObjectRef beamImpactEffectClassic; // 0x308
	public Transform muzzlePoint; // 0x310
	[ClientVar] // RVA: 0x811C0 Offset: 0x805C0 VA: 0x1800811C0
	public static bool classiceffects; // 0x0

	// Methods

	// RVA: 0x8536F0 Offset: 0x852AF0 VA: 0x1808536F0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x853020 Offset: 0x852420 VA: 0x180853020 Slot: 138
	public override void OnInput() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 166
	public override void DoViewmodelImpact(HitTest test) { }

	// RVA: 0x8527F0 Offset: 0x851BF0 VA: 0x1808527F0
	public void DoTGEffect(Vector3 endPos, Vector3 endNormal) { }

	// RVA: 0x852570 Offset: 0x851970 VA: 0x180852570
	public void DoAttackEffect(Vector3 endPos, Vector3 normal) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x852CC0 Offset: 0x8520C0 VA: 0x180852CC0
	public void EffectSpawn(BaseEntity.RPCMessage msg) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0 Slot: 163
	public override void ClientAttack() { }

	// RVA: 0x852630 Offset: 0x851A30 VA: 0x180852630 Slot: 160
	public override void DoAttackShared(HitInfo info) { }

	// RVA: 0x853B40 Offset: 0x852F40 VA: 0x180853B40
	public void .ctor() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	private static void .cctor() { }

}

