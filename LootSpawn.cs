public class LootSpawn : ScriptableObject // TypeDefIndex: 10742
{
	public ItemAmountRanged[] items; 
	public LootSpawn.Entry[] subSpawn; 


	public void .ctor() { }

}

public struct LootSpawn.Entry // TypeDefIndex: 10743
{
	[TooltipAttribute] 
	public int extraSpawns; 
	[TooltipAttribute] 
	public LootSpawn category; 
	[TooltipAttribute] 
	public int weight; 

}

