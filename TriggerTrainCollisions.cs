public class TriggerTrainCollisions : TriggerBase // TypeDefIndex: 9777
{	// Fields
	public Collider triggerCollider; // 0x30
	public TriggerTrainCollisions.Location location; // 0x38
	public TrainCar owner; // 0x40
	public HashSet<GameObject> staticContents; // 0x48
	public HashSet<TrainCar> trainContents; // 0x50
	public HashSet<Rigidbody> otherRigidbodyContents; // 0x58
	public HashSet<Collider> colliderContents; // 0x60

	// Methods

	// RVA: 0x4D0440 Offset: 0x4CF840 VA: 0x1804D0440
	public void .ctor() { }

}

public enum TriggerTrainCollisions.Location // TypeDefIndex: 9778
{	// Fields
	public int value__; // 0x0
	public const TriggerTrainCollisions.Location Front = 0;
	public const TriggerTrainCollisions.Location Rear = 1;

}

