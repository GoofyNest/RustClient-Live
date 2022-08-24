public class LifeInfographic : MonoBehaviour // TypeDefIndex: 11069
{
	public PlayerLifeStory life; 
	public GameObject container; 
	public RawImage AttackerAvatarImage; 
	public Image DamageSourceImage; 
	public LifeInfographicStat[] Stats; 
	public Animator[] AllAnimators; 
	public GameObject WeaponRoot; 
	public GameObject DistanceRoot; 
	public GameObject DistanceDivider; 
	public Image WeaponImage; 
	public LifeInfographic.DamageSetting[] DamageDisplays; 
	public BaseEntity[] NpcDeathInfo; 
	public bool ShowDebugData; 
	private int triggerParam; 
	private int closeState; 


private void OnEnable() { }

public void Refresh() { }

private void Refresh_Age() { }

private void Refresh_Death() { }

private void Show(string name) { }

private void UpdateKilledByAvatar(ulong id) { }

public static bool TryGetDefinitionFromEntityName(string entityName, out ItemDefinition def) { }

private void UpdateKilledByWeaponImage(string weaponName) { }

public bool GetDamageDisplay(DamageType forType, out LifeInfographic.DamageSetting setting) { }

public void AnimateIn() { }

	[IteratorStateMachineAttribute] 
private IEnumerator Animate() { }

public void ResetAnimators() { }

public bool TryGetPrefabInformationForAttacker(string attackerName, out PrefabInformation info) { }

public void .ctor() { }

}

public struct LifeInfographic.DamageSetting // TypeDefIndex: 11070
{
	public DamageType ForType; 
	public string Display; 
	public Sprite DamageSprite; 

}

private sealed class LifeInfographic.<Animate>d__26 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 11071
{
	private int <>1__state; 
	private object <>2__current; 
	public LifeInfographic <>4__this; 
	private Animator[] <>7__wrap1; 
	private int <>7__wrap2; 

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

