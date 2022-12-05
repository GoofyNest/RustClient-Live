public class LootSpawn : ScriptableObject // TypeDefIndex: 12502
{
	public ItemAmountRanged[] items;
	public LootSpawn.Entry[] subSpawn;


	public void .ctor() { }

}

public struct LootSpawn.Entry // TypeDefIndex: 12503
{
	[TooltipAttribute]
	public int extraSpawns;
	[TooltipAttribute]
	public LootSpawn category;
	[TooltipAttribute]
	public int weight;

}

