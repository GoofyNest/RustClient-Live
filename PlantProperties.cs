public class PlantProperties : ScriptableObject // TypeDefIndex: 11391
{
	public Translate.Phrase Description;
	public GrowableGeneProperties Genes;
	[ArrayIndexIsEnum]
	public PlantProperties.Stage[] stages;
	[HeaderAttribute]
	public AnimationCurve timeOfDayHappiness;
	public AnimationCurve temperatureHappiness;
	public AnimationCurve temperatureWaterRequirementMultiplier;
	public AnimationCurve fruitVisualScaleCurve;
	public int MaxSeasons;
	public float WaterIntake;
	public float OptimalLightQuality;
	public float OptimalWaterQuality;
	public float OptimalGroundQuality;
	public float OptimalTemperatureQuality;
	[HeaderAttribute]
	public BaseEntity.Menu.Option pickOption;
	public BaseEntity.Menu.Option pickAllOption;
	public BaseEntity.Menu.Option eatOption;
	public ItemDefinition pickupItem;
	public BaseEntity.Menu.Option cloneOption;
	public BaseEntity.Menu.Option cloneAllOption;
	public BaseEntity.Menu.Option removeDyingOption;
	public BaseEntity.Menu.Option removeDyingAllOption;
	public ItemDefinition removeDyingItem;
	public GameObjectRef removeDyingEffect;
	public int pickupMultiplier;
	public GameObjectRef pickEffect;
	public int maxHarvests;
	public bool disappearAfterHarvest;
	[HeaderAttribute]
	public GameObjectRef CrossBreedEffect;
	public ItemDefinition SeedItem;
	public ItemDefinition CloneItem;
	public int BaseCloneCount;
	[HeaderAttribute]
	public int BaseMarketValue;


	public void .ctor() { }

}

public enum PlantProperties.State // TypeDefIndex: 11392
{
	public int value__;
	public const PlantProperties.State Seed = 0;
	public const PlantProperties.State Seedling = 1;
	public const PlantProperties.State Sapling = 2;
	public const PlantProperties.State Crossbreed = 3;
	public const PlantProperties.State Mature = 4;
	public const PlantProperties.State Fruiting = 5;
	public const PlantProperties.State Ripe = 6;
	public const PlantProperties.State Dying = 7;

}

public struct PlantProperties.Stage // TypeDefIndex: 11393
{
	public PlantProperties.State nextState;
	public float lifeLength;
	public float health;
	public float resources;
	public float yield;
	public GameObjectRef skinObject;
	public bool IgnoreConditions;

	public float lifeLengthSeconds { get; }


	public float get_lifeLengthSeconds() { }

}

