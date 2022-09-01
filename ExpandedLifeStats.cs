public class ExpandedLifeStats : MonoBehaviour // TypeDefIndex: 10934
{
	public GameObject DisplayRoot; 
	public GameObjectRef GenericStatRow; 
	[HeaderAttribute] 
	public Transform ResourcesStatRoot; 
	public List<ExpandedLifeStats.GenericStatDisplay> ResourceStats; 
	[HeaderAttribute] 
	public GameObjectRef WeaponStatRow; 
	public Transform WeaponsRoot; 
	[HeaderAttribute] 
	public Transform MiscRoot; 
	public List<ExpandedLifeStats.GenericStatDisplay> MiscStats; 
	public LifeInfographic Infographic; 
	public RectTransform MoveRoot; 
	public Vector2 OpenPosition; 
	public Vector2 ClosedPosition; 
	public GameObject OpenButtonRoot; 
	public GameObject CloseButtonRoot; 
	public GameObject ScrollGradient; 
	public ScrollRect Scroller; 
	private bool state; 
	private List<GameObject> rowsToRetire; 


	public void Toggle() { }

	public void Toggle(bool newState) { }

	private void PopulateDynamicStats() { }

	[IteratorStateMachineAttribute] 
	private IEnumerator WaitAndRelayout() { }

	private void PopulateGenericStats(List<ExpandedLifeStats.GenericStatDisplay> stats, Transform parent, PlayerLifeStory life) { }

	private void PopulateWeaponStats(List<PlayerLifeStory.WeaponStats> stats, Transform parent) { }

	public void UpdateScrollGradient() { }

	public void .ctor() { }

}

public struct ExpandedLifeStats.GenericStatDisplay // TypeDefIndex: 10935
{
	public string statKey; 
	public Sprite statSprite; 
	public Translate.Phrase displayPhrase; 

}

private sealed class ExpandedLifeStats.<>c // TypeDefIndex: 10936
{
	public static readonly ExpandedLifeStats.<>c <>9; 
	public static Comparison<PlayerLifeStory.WeaponStats> <>9__21_0; 


	private static void .cctor() { }

	public void .ctor() { }

	internal int <PopulateDynamicStats>b__21_0(PlayerLifeStory.WeaponStats a, PlayerLifeStory.WeaponStats b) { }

}

private sealed class ExpandedLifeStats.<WaitAndRelayout>d__22 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 10937
{
	private int <>1__state; 
	private object <>2__current; 
	public ExpandedLifeStats <>4__this; 

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] 
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] 
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute] 
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] 
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] 
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class ExpandedLifeStats.<>c__DisplayClass23_0 // TypeDefIndex: 10938
{
	public ExpandedLifeStats.GenericStatDisplay genericStatDisplay; 


	public void .ctor() { }

	internal bool <PopulateGenericStats>b__0(PlayerLifeStory.GenericStat p) { }

}

