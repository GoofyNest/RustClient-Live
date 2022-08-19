public class ResourceDispenser : EntityComponent<BaseEntity>, IServerComponent // TypeDefIndex: 9504
{	// Fields
	public ResourceDispenser.GatherType gatherType; // 0x20
	public List<ItemAmount> containedItems; // 0x28
	public float maxDestroyFractionForFinishBonus; // 0x30
	public List<ItemAmount> finishBonus; // 0x38
	public float fractionRemaining; // 0x40

	// Methods

	// RVA: 0x9354B0 Offset: 0x9348B0 VA: 0x1809354B0
	public void .ctor() { }

}

public enum ResourceDispenser.GatherType // TypeDefIndex: 9505
{	// Fields
	public int value__; // 0x0
	public const ResourceDispenser.GatherType Tree = 0;
	public const ResourceDispenser.GatherType Ore = 1;
	public const ResourceDispenser.GatherType Flesh = 2;
	public const ResourceDispenser.GatherType UNSET = 3;
	public const ResourceDispenser.GatherType LAST = 4;

}

public class ResourceDispenser.GatherPropertyEntry // TypeDefIndex: 9506
{	// Fields
	public float gatherDamage; // 0x10
	public float destroyFraction; // 0x14
	public float conditionLost; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

public class ResourceDispenser.GatherProperties // TypeDefIndex: 9507
{	// Fields
	public ResourceDispenser.GatherPropertyEntry Tree; // 0x10
	public ResourceDispenser.GatherPropertyEntry Ore; // 0x18
	public ResourceDispenser.GatherPropertyEntry Flesh; // 0x20

	// Methods

	// RVA: 0x91AC10 Offset: 0x91A010 VA: 0x18091AC10
	public float GetProficiency() { }

	// RVA: 0x91AB80 Offset: 0x919F80 VA: 0x18091AB80
	public bool Any() { }

	// RVA: 0x91ABF0 Offset: 0x919FF0 VA: 0x18091ABF0
	public ResourceDispenser.GatherPropertyEntry GetFromIndex(int index) { }

	// RVA: 0x91ABF0 Offset: 0x919FF0 VA: 0x18091ABF0
	public ResourceDispenser.GatherPropertyEntry GetFromIndex(ResourceDispenser.GatherType index) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

