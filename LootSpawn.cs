public class LootSpawn : ScriptableObject // TypeDefIndex: 10742
{	public ItemAmountRanged[] items; // 0x18
	public LootSpawn.Entry[] subSpawn; // 0x20


	public void .ctor() { }

}

public struct LootSpawn.Entry // TypeDefIndex: 10743
{	[TooltipAttribute] // RVA: 0x77440 Offset: 0x76840 VA: 0x180077440
	public int extraSpawns; // 0x0
	[TooltipAttribute] // RVA: 0x77590 Offset: 0x76990 VA: 0x180077590
	public LootSpawn category; // 0x8
	[TooltipAttribute] // RVA: 0x77710 Offset: 0x76B10 VA: 0x180077710
	public int weight; // 0x10

}

