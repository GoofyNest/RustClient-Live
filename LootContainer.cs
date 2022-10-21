public class LootContainer : StorageContainer // TypeDefIndex: 11311
{

public interface ISplashable

public class LootContainer : StorageContainer
	public bool destroyOnEmpty; 
	public LootSpawn lootDefinition; 
	public int maxDefinitionsToSpawn; 
	public float minSecondsBetweenRefresh; 
	public float maxSecondsBetweenRefresh; 
	public bool initialLootSpawn; 
	public float xpLootedScale; 
	public float xpDestroyedScale; 
	public bool BlockPlayerItemInput; 
	public int scrapAmount; 
	public string deathStat; 
	public LootContainer.LootSpawnSlot[] LootSpawnSlots; 
	public LootContainer.spawnType SpawnType; 
	private bool localPlayerInvolved; 

	public bool shouldRefreshContents { get; }


	public bool get_shouldRefreshContents() { }

	public override bool DisplayHealthInfo(BasePlayer player) { }

	public override void DoDestroyEffects(BaseNetworkable.DestroyMode mode, Message msg) { }

	public override void OnAttacked(HitInfo info) { }

	public override void InitShared() { }

	public void .ctor() { }

}

public enum LootContainer.spawnType // TypeDefIndex: 11312
{
	public int value__; 
	public const LootContainer.spawnType GENERIC = 0;
	public const LootContainer.spawnType PLAYER = 1;
	public const LootContainer.spawnType TOWN = 2;
	public const LootContainer.spawnType AIRDROP = 3;
	public const LootContainer.spawnType CRASHSITE = 4;
	public const LootContainer.spawnType ROADSIDE = 5;

}

public struct LootContainer.LootSpawnSlot // TypeDefIndex: 11313
{
	public LootSpawn definition; 
	public int numberToSpawn; 
	public float probability; 

}

