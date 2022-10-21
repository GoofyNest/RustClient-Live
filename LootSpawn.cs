public class LootSpawn : ScriptableObject // TypeDefIndex: 12473
{
	public ItemAmountRanged[] items; 
	public LootSpawn.Entry[] subSpawn; 


	public void .ctor() { }

}

public struct LootSpawn.Entry // TypeDefIndex: 12474
{
	[TooltipAttribute] 
	public int extraSpawns; 
	[TooltipAttribute] 
	public LootSpawn category; 
	[TooltipAttribute] 
	public int weight; 

}

