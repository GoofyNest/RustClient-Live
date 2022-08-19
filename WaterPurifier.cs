public class WaterPurifier : LiquidContainer // TypeDefIndex: 9522
{	// Fields
	public GameObjectRef storagePrefab; // 0x3F8
	public Transform storagePrefabAnchor; // 0x400
	public ItemDefinition freshWater; // 0x408
	public int waterToProcessPerMinute; // 0x410
	public int freshWaterRatio; // 0x414
	public bool stopWhenOutputFull; // 0x418

	// Methods

	// RVA: 0x4989F0 Offset: 0x497DF0 VA: 0x1804989F0
	public bool IsBoiling() { }

	// RVA: 0xC159F0 Offset: 0xC14DF0 VA: 0x180C159F0
	public void .ctor() { }

}

public static class WaterPurifier.WaterPurifierFlags // TypeDefIndex: 9523
{	// Fields
	public const BaseEntity.Flags Boiling = 128;

}

