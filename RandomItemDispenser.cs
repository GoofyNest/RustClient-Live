public class RandomItemDispenser : PrefabAttribute, IServerComponent // TypeDefIndex: 9673
{	// Fields
	public RandomItemDispenser.RandomItemChance[] Chances; // 0x98
	public bool OnlyAwardOne; // 0xA0

	// Methods

	// RVA: 0x6A6E50 Offset: 0x6A6250 VA: 0x1806A6E50 Slot: 7
	protected override Type GetIndexedType() { }

	// RVA: 0x6A6EB0 Offset: 0x6A62B0 VA: 0x1806A6EB0
	public void .ctor() { }

}

public struct RandomItemDispenser.RandomItemChance // TypeDefIndex: 9674
{	// Fields
	public ItemDefinition Item; // 0x0
	public int Amount; // 0x8
	[RangeAttribute] // RVA: 0x71260 Offset: 0x70660 VA: 0x180071260
	public float Chance; // 0xC

}

