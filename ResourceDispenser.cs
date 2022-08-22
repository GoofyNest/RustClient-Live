public class ResourceDispenser : EntityComponent<BaseEntity>, IServerComponent // TypeDefIndex: 9504
{	public ResourceDispenser.GatherType gatherType; // 0x20
	public List<ItemAmount> containedItems; // 0x28
	public float maxDestroyFractionForFinishBonus; // 0x30
	public List<ItemAmount> finishBonus; // 0x38
	public float fractionRemaining; // 0x40


	public void .ctor() { }

}

public enum ResourceDispenser.GatherType // TypeDefIndex: 9505
{	public int value__; // 0x0
	public const ResourceDispenser.GatherType Tree = 0;
	public const ResourceDispenser.GatherType Ore = 1;
	public const ResourceDispenser.GatherType Flesh = 2;
	public const ResourceDispenser.GatherType UNSET = 3;
	public const ResourceDispenser.GatherType LAST = 4;

}

public class ResourceDispenser.GatherPropertyEntry // TypeDefIndex: 9506
{	public float gatherDamage; // 0x10
	public float destroyFraction; // 0x14
	public float conditionLost; // 0x18


	public void .ctor() { }

}

public class ResourceDispenser.GatherProperties // TypeDefIndex: 9507
{	public ResourceDispenser.GatherPropertyEntry Tree; // 0x10
	public ResourceDispenser.GatherPropertyEntry Ore; // 0x18
	public ResourceDispenser.GatherPropertyEntry Flesh; // 0x20


	public float GetProficiency() { }

	public bool Any() { }

	public ResourceDispenser.GatherPropertyEntry GetFromIndex(int index) { }

	public ResourceDispenser.GatherPropertyEntry GetFromIndex(ResourceDispenser.GatherType index) { }

	public void .ctor() { }

}

