public class FlameTurret : StorageContainer // TypeDefIndex: 8569
{	public Transform upper; // 0x3D0
	public Vector3 aimDir; // 0x3D8
	public float arc; // 0x3E4
	public float triggeredDuration; // 0x3E8
	public float flameRange; // 0x3EC
	public float flameRadius; // 0x3F0
	public float fuelPerSec; // 0x3F4
	public Transform eyeTransform; // 0x3F8
	public List<DamageTypeEntry> damagePerSec; // 0x400
	public GameObjectRef triggeredEffect; // 0x408
	public GameObjectRef fireballPrefab; // 0x410
	public GameObjectRef explosionEffect; // 0x418
	public TargetTrigger trigger; // 0x420


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public bool IsTriggered() { }

	public Vector3 GetEyePosition() { }

	public void Update() { }

	public override bool CanPickup(BasePlayer player) { }

	public void ClientThink() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void CLIENT_ReceiveAimDir(BaseEntity.RPCMessage rpc) { }

	public void UpdateAiming() { }

	public void .ctor() { }

}

