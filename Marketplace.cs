public class Marketplace : BaseEntity // TypeDefIndex: 10529
{
	[HeaderAttribute]
	public GameObjectRef terminalPrefab;
	public Transform[] terminalPoints;
	public Transform droneLaunchPoint;
	public GameObjectRef deliveryDronePrefab;


	public void .ctor() { }

}

