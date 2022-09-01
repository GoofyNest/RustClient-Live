public class CH47HelicopterAIController : CH47Helicopter // TypeDefIndex: 9720
{
	public GameObjectRef scientistPrefab; 
	public GameObjectRef dismountablePrefab; 
	public GameObjectRef weakDismountablePrefab; 
	public float maxTiltAngle; 
	public float AiAltitudeForce; 
	public GameObjectRef lockedCratePrefab; 
	public const BaseEntity.Flags Flag_Damaged = 32768;
	public const BaseEntity.Flags Flag_NearDeath = 4;
	public const BaseEntity.Flags Flag_DropDoorOpen = 65536;
	public GameObject triggerHurt; 
	public Vector3 landingTarget; 


	public override bool MountMenuVisible(BasePlayer player) { }

	public override void DestroyShared() { }

	public void .ctor() { }

}

