public class LifeInfographic : MonoBehaviour // TypeDefIndex: 11069
{	public PlayerLifeStory life; // 0x18
	public GameObject container; // 0x20
	public RawImage AttackerAvatarImage; // 0x28
	public Image DamageSourceImage; // 0x30
	public LifeInfographicStat[] Stats; // 0x38
	public Animator[] AllAnimators; // 0x40
	public GameObject WeaponRoot; // 0x48
	public GameObject DistanceRoot; // 0x50
	public GameObject DistanceDivider; // 0x58
	public Image WeaponImage; // 0x60
	public LifeInfographic.DamageSetting[] DamageDisplays; // 0x68
	public BaseEntity[] NpcDeathInfo; // 0x70
	public bool ShowDebugData; // 0x78
	private int triggerParam; // 0x7C
	private int closeState; // 0x80


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

	[IteratorStateMachineAttribute] // RVA: 0x94720 Offset: 0x93B20 VA: 0x180094720
	private IEnumerator Animate() { }

	public void ResetAnimators() { }

	public bool TryGetPrefabInformationForAttacker(string attackerName, out PrefabInformation info) { }

	public void .ctor() { }

}

public struct LifeInfographic.DamageSetting // TypeDefIndex: 11070
{	public DamageType ForType; // 0x0
	public string Display; // 0x8
	public Sprite DamageSprite; // 0x10

}

private sealed class LifeInfographic.<Animate>d__26 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 11071
{	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public LifeInfographic <>4__this; // 0x20
	private Animator[] <>7__wrap1; // 0x28
	private int <>7__wrap2; // 0x30

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private object System.Collections.IEnumerator.get_Current() { }

}

