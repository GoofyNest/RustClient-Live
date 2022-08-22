public class LootContainer : StorageContainer // TypeDefIndex: 9589
{
public interface ISplashable // TypeDefIndex: 9588

public class LootContainer : StorageContainer // TypeDefIndex: 9589
	public bool destroyOnEmpty; // 0x3D0
	public LootSpawn lootDefinition; // 0x3D8
	public int maxDefinitionsToSpawn; // 0x3E0
	public float minSecondsBetweenRefresh; // 0x3E4
	public float maxSecondsBetweenRefresh; // 0x3E8
	public bool initialLootSpawn; // 0x3EC
	public float xpLootedScale; // 0x3F0
	public float xpDestroyedScale; // 0x3F4
	public bool BlockPlayerItemInput; // 0x3F8
	public int scrapAmount; // 0x3FC
	public string deathStat; // 0x400
	public LootContainer.LootSpawnSlot[] LootSpawnSlots; // 0x408
	public LootContainer.spawnType SpawnType; // 0x410
	private bool localPlayerInvolved; // 0x414

	public bool shouldRefreshContents { get; }


	public bool get_shouldRefreshContents() { }

	public override bool DisplayHealthInfo(BasePlayer player) { }

	public override void DoDestroyEffects(BaseNetworkable.DestroyMode mode, Message msg) { }

	public override void OnAttacked(HitInfo info) { }

	public override void InitShared() { }

	public void .ctor() { }

}

public enum LootContainer.spawnType // TypeDefIndex: 9590
{	public int value__; // 0x0
	public const LootContainer.spawnType GENERIC = 0;
	public const LootContainer.spawnType PLAYER = 1;
	public const LootContainer.spawnType TOWN = 2;
	public const LootContainer.spawnType AIRDROP = 3;
	public const LootContainer.spawnType CRASHSITE = 4;
	public const LootContainer.spawnType ROADSIDE = 5;

}

public struct LootContainer.LootSpawnSlot // TypeDefIndex: 9591
{	public LootSpawn definition; // 0x0
	public int numberToSpawn; // 0x8
	public float probability; // 0xC

}

