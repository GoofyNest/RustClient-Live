public enum AmmoTypes // TypeDefIndex: 6624
{
	public int value__; 
	public const AmmoTypes PISTOL_9MM = 1;
	public const AmmoTypes RIFLE_556MM = 2;
	public const AmmoTypes SHOTGUN_12GUAGE = 4;
	public const AmmoTypes BOW_ARROW = 8;
	public const AmmoTypes HANDMADE_SHELL = 16;
	public const AmmoTypes ROCKET = 32;
	public const AmmoTypes NAILS = 64;
	public const AmmoTypes AMMO_40MM = 128;
	public const AmmoTypes SNOWBALL = 256;
	public const AmmoTypes SPEARGUN_BOLT = 512;
	public const AmmoTypes TORPEDO = 1024;
	public const AmmoTypes MLRS_ROCKET = 2048;

}

public class AmmoBelowAIEvent : BaseAIEvent // TypeDefIndex: 11107
{
	[CompilerGeneratedAttribute] 
	private float <Value>k__BackingField; 

	public float Value { get; set; }


	[CompilerGeneratedAttribute] 
	public float get_Value() { }

	[CompilerGeneratedAttribute] 
	private void set_Value(float value) { }

	public void .ctor() { }

}

public class AmmoBelowEventUI : BaseEventUI // TypeDefIndex: 12515
{

	public override AIEventData Save() { }

	public override void Load(AIEventData data) { }

	public void .ctor() { }

}

public class AmmoInformationPanel : ItemInformationPanel // TypeDefIndex: 12712
{
	public ItemStatValue damageDisplay; 
	public ItemStatValue velocityDisplay; 
	public ItemStatValue spreadDisplay; 
	public ItemTextValue pelletsDisplay; 
	public ItemStatValue falloffRangeDisplay; 
	public ItemTextValue thicknessDisplay; 


	public override bool EligableForDisplay(ItemDefinition info) { }

	public override void SetupForItem(ItemDefinition info, Item item) { }

	public void .ctor() { }

}

