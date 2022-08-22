public class CH47HelicopterAIController : CH47Helicopter // TypeDefIndex: 9715
{	public GameObjectRef scientistPrefab; // 0x4D8
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


	public override bool MountMenuVisible(BasePlayer player) { }

	public override void DestroyShared() { }

	public void .ctor() { }

}

