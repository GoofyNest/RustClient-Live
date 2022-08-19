public static class ContextMenuUI // TypeDefIndex: 10839
{	// Fields
	public static ContextMenuUI.MenuType type; // 0x2460

	// Methods

	// RVA: 0x515250 Offset: 0x514650 VA: 0x180515250
	public static void Start(ContextMenuUI.MenuType menuType) { }

	// RVA: 0x514430 Offset: 0x513830 VA: 0x180514430
	public static void AddOption(string name, string desc, Sprite icon, Action<BasePlayer> action, int order = 0, bool disabled = False, bool selected = False, string requirements = "", bool allowMerge = False, Nullable<PieMenu.MenuOption.ColorMode> colorMode) { }

	// RVA: 0x514820 Offset: 0x513C20 VA: 0x180514820
	public static void End() { }

	// RVA: 0x514E80 Offset: 0x514280 VA: 0x180514E80
	public static bool IsOpen() { }

	// RVA: 0x514630 Offset: 0x513A30 VA: 0x180514630
	public static void Cancel(bool playSound = True) { }

	// RVA: 0x514760 Offset: 0x513B60 VA: 0x180514760
	public static void DoSelect() { }

	// RVA: 0x514EF0 Offset: 0x5142F0 VA: 0x180514EF0
	public static void Open(List<Option> options, ContextMenuUI.MenuType menuType) { }

	// RVA: 0x514890 Offset: 0x513C90 VA: 0x180514890
	public static void FrameUpdate(BasePlayer player) { }

	// RVA: 0x514CA0 Offset: 0x5140A0 VA: 0x180514CA0
	public static bool IsButtonDownRaw(string bind) { }

}

public enum ContextMenuUI.MenuType // TypeDefIndex: 10840
{	// Fields
	public int value__; // 0x0
	public const ContextMenuUI.MenuType Use = 0;
	public const ContextMenuUI.MenuType RightClick = 1;
	public const ContextMenuUI.MenuType Reload = 2;
	public const ContextMenuUI.MenuType Gesture = 3;
	public const ContextMenuUI.MenuType Pet = 4;

}

