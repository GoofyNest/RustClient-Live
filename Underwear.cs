public class Underwear : ScriptableObject // TypeDefIndex: 10773
{	// Fields
	public string shortname; // 0x18
	public Translate.Phrase displayName; // 0x20
	public Sprite icon; // 0x28
	public Sprite iconFemale; // 0x30
	public SkinReplacement[] replacementsMale; // 0x38
	public SkinReplacement[] replacementsFemale; // 0x40
	[TooltipAttribute] // RVA: 0x7B540 Offset: 0x7A940 VA: 0x18007B540
	public SteamInventoryItem steamItem; // 0x48
	[TooltipAttribute] // RVA: 0x7B650 Offset: 0x7AA50 VA: 0x18007B650
	public SteamDLCItem steamDLC; // 0x50
	public bool adminOnly; // 0x58

	// Methods

	// RVA: 0x9E67F0 Offset: 0x9E5BF0 VA: 0x1809E67F0
	public uint GetID() { }

	// RVA: 0x9E6870 Offset: 0x9E5C70 VA: 0x1809E6870
	public bool HasMaleParts() { }

	// RVA: 0x9E6850 Offset: 0x9E5C50 VA: 0x1809E6850
	public bool HasFemaleParts() { }

	// RVA: 0x9E69E0 Offset: 0x9E5DE0 VA: 0x1809E69E0
	public bool ValidForPlayer(BasePlayer player) { }

	// RVA: 0x9E6890 Offset: 0x9E5C90 VA: 0x1809E6890
	public static bool IsFemale(BasePlayer player) { }

	// RVA: 0x9E6B90 Offset: 0x9E5F90 VA: 0x1809E6B90
	public static bool Validate(Underwear underwear, BasePlayer player) { }

	// RVA: 0x9E6ED0 Offset: 0x9E62D0 VA: 0x1809E6ED0
	public void .ctor() { }

}

