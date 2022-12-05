public class RepairBench : StorageContainer // TypeDefIndex: 10358
{
	public float maxConditionLostOnRepair;
	public GameObjectRef skinchangeEffect;
	public const float REPAIR_COST_FRACTION = 0,2;


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public void TryRepair() { }

	public void ChangeSkinTo(int id) { }

	public static float GetRepairFraction(Item itemToRepair) { }

	public static float RepairCostFraction(Item itemToRepair) { }

	public static void GetRepairCostList(ItemBlueprint bp, List<ItemAmount> allIngredients) { }

	public static void StripComponentRepairCost(List<ItemAmount> allIngredients) { }

	public void .ctor() { }

}

