public class FlameTurret : StorageContainer // TypeDefIndex: 10293
{
	public Transform upper;
	public Vector3 aimDir;
	public float arc;
	public float triggeredDuration;
	public float flameRange;
	public float flameRadius;
	public float fuelPerSec;
	public Transform eyeTransform;
	public List<DamageTypeEntry> damagePerSec;
	public GameObjectRef triggeredEffect;
	public GameObjectRef fireballPrefab;
	public GameObjectRef explosionEffect;
	public TargetTrigger trigger;


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public bool IsTriggered() { }

	public Vector3 GetEyePosition() { }

	public void Update() { }

	public override bool CanPickup(BasePlayer player) { }

	public void ClientThink() { }

	[BaseEntity.RPC_Client]
	public void CLIENT_ReceiveAimDir(BaseEntity.RPCMessage rpc) { }

	public void UpdateAiming() { }

	public void .ctor() { }

}

