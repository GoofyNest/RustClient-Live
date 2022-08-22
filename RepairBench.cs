public class RepairBench : StorageContainer // TypeDefIndex: 8633
{	public float maxConditionLostOnRepair; // 0x3D0
	public GameObjectRef skinchangeEffect; // 0x3D8
	public const float REPAIR_COST_FRACTION = 0,2;


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public void TryRepair() { }

	public void ChangeSkinTo(int id) { }

	public static float GetRepairFraction(Item itemToRepair) { }

	public static float RepairCostFraction(Item itemToRepair) { }

	public static void GetRepairCostList(ItemBlueprint bp, List<ItemAmount> allIngredients) { }

	public void .ctor() { }

}

