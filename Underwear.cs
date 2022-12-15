public class Underwear : ScriptableObject // TypeDefIndex: 12543
{
	public string shortname;
	public Translate.Phrase displayName;
	public Sprite icon;
	public Sprite iconFemale;
	public SkinReplacement[] replacementsMale;
	public SkinReplacement[] replacementsFemale;
	[TooltipAttribute]
	public SteamInventoryItem steamItem;
	[TooltipAttribute]
	public SteamDLCItem steamDLC;
	public bool adminOnly;


	public uint GetID() { }

	public bool HasMaleParts() { }

	public bool HasFemaleParts() { }

	public bool ValidForPlayer(BasePlayer player) { }

	public static bool IsFemale(BasePlayer player) { }

	public static bool Validate(Underwear underwear, BasePlayer player) { }

	public void .ctor() { }

}

