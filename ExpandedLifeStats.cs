public class ExpandedLifeStats : MonoBehaviour // TypeDefIndex: 10923
{	// Fields
	public GameObject DisplayRoot; // 0x18
	public GameObjectRef GenericStatRow; // 0x20
	[HeaderAttribute] // RVA: 0x8AAB0 Offset: 0x89EB0 VA: 0x18008AAB0
	public Transform ResourcesStatRoot; // 0x28
	public List<ExpandedLifeStats.GenericStatDisplay> ResourceStats; // 0x30
	[HeaderAttribute] // RVA: 0x8AB80 Offset: 0x89F80 VA: 0x18008AB80
	public GameObjectRef WeaponStatRow; // 0x38
	public Transform WeaponsRoot; // 0x40
	[HeaderAttribute] // RVA: 0x71D40 Offset: 0x71140 VA: 0x180071D40
	public Transform MiscRoot; // 0x48
	public List<ExpandedLifeStats.GenericStatDisplay> MiscStats; // 0x50
	public LifeInfographic Infographic; // 0x58
	public RectTransform MoveRoot; // 0x60
	public Vector2 OpenPosition; // 0x68
	public Vector2 ClosedPosition; // 0x70
	public GameObject OpenButtonRoot; // 0x78
	public GameObject CloseButtonRoot; // 0x80
	public GameObject ScrollGradient; // 0x88
	public ScrollRect Scroller; // 0x90
	private bool state; // 0x98
	private List<GameObject> rowsToRetire; // 0xA0

	// Methods

	// RVA: 0x8BF3F0 Offset: 0x8BE7F0 VA: 0x1808BF3F0
	public void Toggle() { }

	// RVA: 0x8BF0E0 Offset: 0x8BE4E0 VA: 0x1808BF0E0
	public void Toggle(bool newState) { }

	// RVA: 0x8BE7E0 Offset: 0x8BDBE0 VA: 0x1808BE7E0
	private void PopulateDynamicStats() { }

	[IteratorStateMachineAttribute] // RVA: 0x8AD30 Offset: 0x8A130 VA: 0x18008AD30
	// RVA: 0x8BF510 Offset: 0x8BE910 VA: 0x1808BF510
	private IEnumerator WaitAndRelayout() { }

	// RVA: 0x8BEB20 Offset: 0x8BDF20 VA: 0x1808BEB20
	private void PopulateGenericStats(List<ExpandedLifeStats.GenericStatDisplay> stats, Transform parent, PlayerLifeStory life) { }

	// RVA: 0x8BEE60 Offset: 0x8BE260 VA: 0x1808BEE60
	private void PopulateWeaponStats(List<PlayerLifeStory.WeaponStats> stats, Transform parent) { }

	// RVA: 0x8BF410 Offset: 0x8BE810 VA: 0x1808BF410
	public void UpdateScrollGradient() { }

	// RVA: 0x8BF580 Offset: 0x8BE980 VA: 0x1808BF580
	public void .ctor() { }

}

public struct ExpandedLifeStats.GenericStatDisplay // TypeDefIndex: 10924
{	// Fields
	public string statKey; // 0x0
	public Sprite statSprite; // 0x8
	public Translate.Phrase displayPhrase; // 0x10

}

private sealed class ExpandedLifeStats.<>c // TypeDefIndex: 10925
{	// Fields
	public static readonly ExpandedLifeStats.<>c <>9; // 0x0
	public static Comparison<PlayerLifeStory.WeaponStats> <>9__21_0; // 0x8

	// Methods

	// RVA: 0x8C9610 Offset: 0x8C8A10 VA: 0x1808C9610
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x8C9380 Offset: 0x8C8780 VA: 0x1808C9380
	internal int <PopulateDynamicStats>b__21_0(PlayerLifeStory.WeaponStats a, PlayerLifeStory.WeaponStats b) { }

}

private sealed class ExpandedLifeStats.<WaitAndRelayout>d__22 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 10926
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public ExpandedLifeStats <>4__this; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497770 Offset: 0x496B70 VA: 0x180497770
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x8C9970 Offset: 0x8C8D70 VA: 0x1808C9970 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x8C9B20 Offset: 0x8C8F20 VA: 0x1808C9B20 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class ExpandedLifeStats.<>c__DisplayClass23_0 // TypeDefIndex: 10927
{	// Fields
	public ExpandedLifeStats.GenericStatDisplay genericStatDisplay; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x8C9480 Offset: 0x8C8880 VA: 0x1808C9480
	internal bool <PopulateGenericStats>b__0(PlayerLifeStory.GenericStat p) { }

}

