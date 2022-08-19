public class FlameTurret : StorageContainer // TypeDefIndex: 8569
{	// Fields
	public Transform upper; // 0x3D0
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

	// Methods

	// RVA: 0x78DC70 Offset: 0x78D070 VA: 0x18078DC70 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x7518E0 Offset: 0x750CE0 VA: 0x1807518E0
	public bool IsTriggered() { }

	// RVA: 0x78DC30 Offset: 0x78D030 VA: 0x18078DC30
	public Vector3 GetEyePosition() { }

	// RVA: 0x78E320 Offset: 0x78D720 VA: 0x18078E320
	public void Update() { }

	// RVA: 0x78DBE0 Offset: 0x78CFE0 VA: 0x18078DBE0 Slot: 134
	public override bool CanPickup(BasePlayer player) { }

	// RVA: 0x78DC20 Offset: 0x78D020 VA: 0x18078DC20
	public void ClientThink() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x78DB80 Offset: 0x78CF80 VA: 0x18078DB80
	public void CLIENT_ReceiveAimDir(BaseEntity.RPCMessage rpc) { }

	// RVA: 0x78E0D0 Offset: 0x78D4D0 VA: 0x18078E0D0
	public void UpdateAiming() { }

	// RVA: 0x78E350 Offset: 0x78D750 VA: 0x18078E350
	public void .ctor() { }

}

