public class LargeShredder : BaseEntity // TypeDefIndex: 11375
{
	public Transform shredRail;
	public Transform shredRailStartPos;
	public Transform shredRailEndPos;
	public Vector3 shredRailStartRotation;
	public Vector3 shredRailEndRotation;
	public LargeShredderTrigger trigger;
	public float shredDurationRotation;
	public float shredDurationPosition;
	public float shredSwayAmount;
	public float shredSwaySpeed;
	public BaseEntity currentlyShredding;
	public GameObject[] shreddingWheels;
	public float shredRotorSpeed;
	public GameObjectRef shredSoundEffect;
	public Transform resourceSpawnPoint;
	private Quaternion entryRotation;
	public const string SHRED_STAT = "cars_shredded";


	public override void PostNetworkUpdate() { }

	public void ClientUpdate() { }

	private void Update() { }

	public void .ctor() { }

}

