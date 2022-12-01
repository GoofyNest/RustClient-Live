public class BunkerEntrance : BaseEntity, IMissionEntityListener // TypeDefIndex: 10566
{
	public GameObjectRef portalPrefab;
	public GameObjectRef doorPrefab;
	public Transform portalSpawnPoint;
	public Transform doorSpawnPoint;
	public Door doorInstance;
	public BasePortal portalInstance;


	public void .ctor() { }

}

