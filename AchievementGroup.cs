public class AchievementGroup // TypeDefIndex: 10818
{	public Translate.Phrase groupTitle; // 0x10
	public static AchievementGroup[] All; // 0x0
	public AchievementGroup.AchievementItem[] Items; // 0x18

	public bool Unlocked { get; }


	public void .ctor(string token = "", string english = "") { }

	public bool get_Unlocked() { }

	private static void .cctor() { }

}

public class AchievementGroup.AchievementItem // TypeDefIndex: 10819
{	public string Name; // 0x10
	public Translate.Phrase Phrase; // 0x18

	public IAchievement Achievement { get; }
	public bool Unlocked { get; }


	public IAchievement get_Achievement() { }

	public void .ctor(string name, string phrase) { }

	public bool get_Unlocked() { }

}

private sealed class AchievementGroup.<>c // TypeDefIndex: 10820
{	public static readonly AchievementGroup.<>c <>9; // 0x0
	public static Func<AchievementGroup.AchievementItem, bool> <>9__6_0; // 0x8


	private static void .cctor() { }

	public void .ctor() { }

	internal bool <get_Unlocked>b__6_0(AchievementGroup.AchievementItem x) { }

}

