public class AchievementGroup // TypeDefIndex: 10818
{	// Fields
	public Translate.Phrase groupTitle; // 0x10
	public static AchievementGroup[] All; // 0x0
	public AchievementGroup.AchievementItem[] Items; // 0x18

	// Properties
	public bool Unlocked { get; }

	// Methods

	// RVA: 0xA94260 Offset: 0xA93660 VA: 0x180A94260
	public void .ctor(string token = "", string english = "") { }

	// RVA: 0xA94330 Offset: 0xA93730 VA: 0x180A94330
	public bool get_Unlocked() { }

	// RVA: 0xA920B0 Offset: 0xA914B0 VA: 0x180A920B0
	private static void .cctor() { }

}

public class AchievementGroup.AchievementItem // TypeDefIndex: 10819
{	// Fields
	public string Name; // 0x10
	public Translate.Phrase Phrase; // 0x18

	// Properties
	public IAchievement Achievement { get; }
	public bool Unlocked { get; }

	// Methods

	// RVA: 0xA944F0 Offset: 0xA938F0 VA: 0x180A944F0
	public IAchievement get_Achievement() { }

	// RVA: 0xA94430 Offset: 0xA93830 VA: 0x180A94430
	public void .ctor(string name, string phrase) { }

	// RVA: 0xA945E0 Offset: 0xA939E0 VA: 0x180A945E0
	public bool get_Unlocked() { }

}

private sealed class AchievementGroup.<>c // TypeDefIndex: 10820
{	// Fields
	public static readonly AchievementGroup.<>c <>9; // 0x0
	public static Func<AchievementGroup.AchievementItem, bool> <>9__6_0; // 0x8

	// Methods

	// RVA: 0xAA6D50 Offset: 0xAA6150 VA: 0x180AA6D50
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0xAA6AB0 Offset: 0xAA5EB0 VA: 0x180AA6AB0
	internal bool <get_Unlocked>b__6_0(AchievementGroup.AchievementItem x) { }

}

