public enum AmmoTypes // TypeDefIndex: 6619
{	// Fields
	public int value__; // 0x0
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

public class AmmoBelowAIEvent : BaseAIEvent // TypeDefIndex: 9388
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float <Value>k__BackingField; // 0x40

	// Properties
	public float Value { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x54D6A0 Offset: 0x54CAA0 VA: 0x18054D6A0
	public float get_Value() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x54D6B0 Offset: 0x54CAB0 VA: 0x18054D6B0
	private void set_Value(float value) { }

	// RVA: 0x820C60 Offset: 0x820060 VA: 0x180820C60
	public void .ctor() { }

}

public class AmmoBelowEventUI : BaseEventUI // TypeDefIndex: 10784
{	// Methods

	// RVA: 0x820D00 Offset: 0x820100 VA: 0x180820D00 Slot: 5
	public override AIEventData Save() { }

	// RVA: 0x820C90 Offset: 0x820090 VA: 0x180820C90 Slot: 6
	public override void Load(AIEventData data) { }

	// RVA: 0x4B7D40 Offset: 0x4B7140 VA: 0x1804B7D40
	public void .ctor() { }

}

public class AmmoInformationPanel : ItemInformationPanel // TypeDefIndex: 10979
{	// Fields
	public ItemStatValue damageDisplay; // 0x18
	public ItemStatValue velocityDisplay; // 0x20
	public ItemStatValue spreadDisplay; // 0x28
	public ItemTextValue pelletsDisplay; // 0x30
	public ItemStatValue falloffRangeDisplay; // 0x38
	public ItemTextValue thicknessDisplay; // 0x40

	// Methods

	// RVA: 0x820DB0 Offset: 0x8201B0 VA: 0x180820DB0 Slot: 4
	public override bool EligableForDisplay(ItemDefinition info) { }

	// RVA: 0x820F40 Offset: 0x820340 VA: 0x180820F40 Slot: 5
	public override void SetupForItem(ItemDefinition info, Item item) { }

	// RVA: 0x4B7D40 Offset: 0x4B7140 VA: 0x1804B7D40
	public void .ctor() { }

}

