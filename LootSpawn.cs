public class LootSpawn : ScriptableObject // TypeDefIndex: 12501
{
	public ItemAmountRanged[] items;
	public LootSpawn.Entry[] subSpawn;


	public void .ctor() { }

}

public struct LootSpawn.Entry // TypeDefIndex: 12502
{
	[TooltipAttribute]
	public int extraSpawns;
	[TooltipAttribute]
	public LootSpawn category;
	[TooltipAttribute]
	public int weight;

}

