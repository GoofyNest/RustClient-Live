public class GenericSpawnPoint : BaseSpawnPoint // TypeDefIndex: 9998
{
	public bool dropToGround; 
	public bool randomRot; 
	[RangeAttribute] 
	public float randomRotSnapDegrees; 
	public GameObjectRef spawnEffect; 
	public UnityEvent OnObjectSpawnedEvent; 
	public UnityEvent OnObjectRetiredEvent; 


	public Quaternion GetRandomRotation() { }

	public void .ctor() { }

}

