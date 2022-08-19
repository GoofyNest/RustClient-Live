public class RepairBench : StorageContainer // TypeDefIndex: 8633
{	// Fields
	public float maxConditionLostOnRepair; // 0x3D0
	public GameObjectRef skinchangeEffect; // 0x3D8
	public const float REPAIR_COST_FRACTION = 0,2;

	// Methods

	// RVA: 0x9327E0 Offset: 0x931BE0 VA: 0x1809327E0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x932910 Offset: 0x931D10 VA: 0x180932910
	public void TryRepair() { }

	// RVA: 0x9321F0 Offset: 0x9315F0 VA: 0x1809321F0
	public void ChangeSkinTo(int id) { }

	// RVA: 0x9327B0 Offset: 0x931BB0 VA: 0x1809327B0
	public static float GetRepairFraction(Item itemToRepair) { }

	// RVA: 0x9328D0 Offset: 0x931CD0 VA: 0x1809328D0
	public static float RepairCostFraction(Item itemToRepair) { }

	// RVA: 0x932240 Offset: 0x931640 VA: 0x180932240
	public static void GetRepairCostList(ItemBlueprint bp, List<ItemAmount> allIngredients) { }

	// RVA: 0x932950 Offset: 0x931D50 VA: 0x180932950
	public void .ctor() { }

}

