public class AchievementGroup // TypeDefIndex: 12587
{
	public Translate.Phrase groupTitle;
	public static AchievementGroup[] All;
	public AchievementGroup.AchievementItem[] Items;

	public bool Unlocked { get; }


	public void .ctor(string token = "", string english = "") { }

	public bool get_Unlocked() { }

	private static void .cctor() { }

}

public class AchievementGroup.AchievementItem // TypeDefIndex: 12588
{
	public string Name;
	public Translate.Phrase Phrase;

	public IAchievement Achievement { get; }
	public bool Unlocked { get; }


	public IAchievement get_Achievement() { }

	public void .ctor(string name, string phrase) { }

	public bool get_Unlocked() { }

}

private sealed class AchievementGroup.<>c // TypeDefIndex: 12589
{
	public static readonly AchievementGroup.<>c <>9;
	public static Func<AchievementGroup.AchievementItem, bool> <>9__6_0;


	private static void .cctor() { }

	public void .ctor() { }

	internal bool <get_Unlocked>

}

