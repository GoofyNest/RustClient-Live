public class WaterCatcher : LiquidContainer // TypeDefIndex: 9520
{	[HeaderAttribute] // RVA: 0x75EE0 Offset: 0x752E0 VA: 0x180075EE0
	public ItemDefinition itemToCreate; // 0x3F8
	public float maxItemToCreate; // 0x400
	[HeaderAttribute] // RVA: 0x76000 Offset: 0x75400 VA: 0x180076000
	public Vector3 rainTestPosition; // 0x404
	public float rainTestSize; // 0x410
	private const float collectInterval = 60;


	public void .ctor() { }

}

