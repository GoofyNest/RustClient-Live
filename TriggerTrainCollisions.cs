public class TriggerTrainCollisions : TriggerBase // TypeDefIndex: 9777
{
	public Collider triggerCollider; 
	public TriggerTrainCollisions.Location location; 
	public TrainCar owner; 
	public HashSet<GameObject> staticContents; 
	public HashSet<TrainCar> trainContents; 
	public HashSet<Rigidbody> otherRigidbodyContents; 
	public HashSet<Collider> colliderContents; 


public void .ctor() { }

}

public enum TriggerTrainCollisions.Location // TypeDefIndex: 9778
{
	public int value__; 
public const TriggerTrainCollisions.Location Front = 0;
public const TriggerTrainCollisions.Location Rear = 1;

}

