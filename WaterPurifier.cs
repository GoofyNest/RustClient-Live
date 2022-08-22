public class WaterPurifier : LiquidContainer // TypeDefIndex: 9522
{	public GameObjectRef storagePrefab; // 0x3F8
	public Transform storagePrefabAnchor; // 0x400
	public ItemDefinition freshWater; // 0x408
	public int waterToProcessPerMinute; // 0x410
	public int freshWaterRatio; // 0x414
	public bool stopWhenOutputFull; // 0x418


	public bool IsBoiling() { }

	public void .ctor() { }

}

public static class WaterPurifier.WaterPurifierFlags // TypeDefIndex: 9523
{	public const BaseEntity.Flags Boiling = 128;

}

