public class ResourceDepositManager : BaseEntity // TypeDefIndex: 9575
{
	public static ResourceDepositManager _manager; 
	private const int resolution = 20;
	public Dictionary<Vector2i, ResourceDepositManager.ResourceDeposit> _deposits; 


	public void .ctor() { }

}

public class ResourceDepositManager.ResourceDeposit // TypeDefIndex: 9576
{
	public float lastSurveyTime; 
	public Vector3 origin; 
	public List<ResourceDepositManager.ResourceDeposit.ResourceDepositEntry> _resources; 


	public void .ctor() { }

	public void Add(ItemDefinition type, float efficiency, int amount, float workNeeded, ResourceDepositManager.ResourceDeposit.surveySpawnType spawnType, bool liquid = False) { }

}

public enum ResourceDepositManager.ResourceDeposit.surveySpawnType // TypeDefIndex: 9577
{
	public int value__; 
	public const ResourceDepositManager.ResourceDeposit.surveySpawnType ITEM = 0;
	public const ResourceDepositManager.ResourceDeposit.surveySpawnType OIL = 1;
	public const ResourceDepositManager.ResourceDeposit.surveySpawnType WATER = 2;

}

public class ResourceDepositManager.ResourceDeposit.ResourceDepositEntry // TypeDefIndex: 9578
{
	public ItemDefinition type; 
	public float efficiency; 
	public int amount; 
	public int startAmount; 
	public float workNeeded; 
	public float workDone; 
	public ResourceDepositManager.ResourceDeposit.surveySpawnType spawnType; 
	public bool isLiquid; 


	public void Subtract(int subamount) { }

	public void .ctor() { }

}

