public class CH47HelicopterAIController : CH47Helicopter // TypeDefIndex: 9715
{	// Fields
	public GameObjectRef scientistPrefab; // 0x4D8
	public GameObjectRef dismountablePrefab; // 0x4E0
	public GameObjectRef weakDismountablePrefab; // 0x4E8
	public float maxTiltAngle; // 0x4F0
	public float AiAltitudeForce; // 0x4F4
	public GameObjectRef lockedCratePrefab; // 0x4F8
	public const BaseEntity.Flags Flag_Damaged = 32768;
	public const BaseEntity.Flags Flag_NearDeath = 4;
	public const BaseEntity.Flags Flag_DropDoorOpen = 65536;
	public GameObject triggerHurt; // 0x500
	public Vector3 landingTarget; // 0x508

	// Methods

	// RVA: 0x70F010 Offset: 0x70E410 VA: 0x18070F010 Slot: 184
	public override bool MountMenuVisible(BasePlayer player) { }

	// RVA: 0x6D0C70 Offset: 0x6D0070 VA: 0x1806D0C70 Slot: 31
	public override void DestroyShared() { }

	// RVA: 0x70F050 Offset: 0x70E450 VA: 0x18070F050
	public void .ctor() { }

}

