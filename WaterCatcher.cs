public class WaterCatcher : LiquidContainer // TypeDefIndex: 11262
{
	[HeaderAttribute]
	public ItemDefinition itemToCreate;
	public float maxItemToCreate;
	[HeaderAttribute]
	public Vector3 rainTestPosition;
	public float rainTestSize;
	private const float collectInterval = 60;


	public void .ctor() { }

}

