public class ResourceDispenser : EntityComponent<BaseEntity>, IServerComponent // TypeDefIndex: 11176
{
	public ResourceDispenser.GatherType gatherType; 
	public List<ItemAmount> containedItems; 
	public float maxDestroyFractionForFinishBonus; 
	public List<ItemAmount> finishBonus; 
	public float fractionRemaining; 


	public void .ctor() { }

}

public enum ResourceDispenser.GatherType // TypeDefIndex: 11177
{
	public int value__; 
	public const ResourceDispenser.GatherType Tree = 0;
	public const ResourceDispenser.GatherType Ore = 1;
	public const ResourceDispenser.GatherType Flesh = 2;
	public const ResourceDispenser.GatherType UNSET = 3;
	public const ResourceDispenser.GatherType LAST = 4;

}

public class ResourceDispenser.GatherPropertyEntry // TypeDefIndex: 11178
{
	public float gatherDamage; 
	public float destroyFraction; 
	public float conditionLost; 


	public void .ctor() { }

}

public class ResourceDispenser.GatherProperties // TypeDefIndex: 11179
{
	public ResourceDispenser.GatherPropertyEntry Tree; 
	public ResourceDispenser.GatherPropertyEntry Ore; 
	public ResourceDispenser.GatherPropertyEntry Flesh; 


	public float GetProficiency() { }

	public bool Any() { }

	public ResourceDispenser.GatherPropertyEntry GetFromIndex(int index) { }

	public ResourceDispenser.GatherPropertyEntry GetFromIndex(ResourceDispenser.GatherType index) { }

	public void .ctor() { }

}

