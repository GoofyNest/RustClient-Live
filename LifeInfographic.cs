public class LifeInfographic : MonoBehaviour // TypeDefIndex: 11069
{	// Fields
	public PlayerLifeStory life; // 0x18
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

	// Methods

	// RVA: 0x6C2760 Offset: 0x6C1B60 VA: 0x1806C2760
	private void OnEnable() { }

	// RVA: 0x6C28F0 Offset: 0x6C1CF0 VA: 0x1806C28F0
	public void Refresh() { }

	// RVA: 0x6C27E0 Offset: 0x6C1BE0 VA: 0x1806C27E0
	private void Refresh_Age() { }

	// RVA: 0x6C2850 Offset: 0x6C1C50 VA: 0x1806C2850
	private void Refresh_Death() { }

	// RVA: 0x6C3070 Offset: 0x6C2470 VA: 0x1806C3070
	private void Show(string name) { }

	// RVA: 0x6C37D0 Offset: 0x6C2BD0 VA: 0x1806C37D0
	private void UpdateKilledByAvatar(ulong id) { }

	// RVA: 0x6C3130 Offset: 0x6C2530 VA: 0x1806C3130
	public static bool TryGetDefinitionFromEntityName(string entityName, out ItemDefinition def) { }

	// RVA: 0x6C38C0 Offset: 0x6C2CC0 VA: 0x1806C38C0
	private void UpdateKilledByWeaponImage(string weaponName) { }

	// RVA: 0x6C26D0 Offset: 0x6C1AD0 VA: 0x1806C26D0
	public bool GetDamageDisplay(DamageType forType, out LifeInfographic.DamageSetting setting) { }

	// RVA: 0x6C25F0 Offset: 0x6C19F0 VA: 0x1806C25F0
	public void AnimateIn() { }

	[IteratorStateMachineAttribute] // RVA: 0x94720 Offset: 0x93B20 VA: 0x180094720
	// RVA: 0x6C2660 Offset: 0x6C1A60 VA: 0x1806C2660
	private IEnumerator Animate() { }

	// RVA: 0x6C2760 Offset: 0x6C1B60 VA: 0x1806C2760
	public void ResetAnimators() { }

	// RVA: 0x6C3660 Offset: 0x6C2A60 VA: 0x1806C3660
	public bool TryGetPrefabInformationForAttacker(string attackerName, out PrefabInformation info) { }

	// RVA: 0x6C3A00 Offset: 0x6C2E00 VA: 0x1806C3A00
	public void .ctor() { }

}

public struct LifeInfographic.DamageSetting // TypeDefIndex: 11070
{	// Fields
	public DamageType ForType; // 0x0
	public string Display; // 0x8
	public Sprite DamageSprite; // 0x10

}

private sealed class LifeInfographic.<Animate>d__26 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 11071
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public LifeInfographic <>4__this; // 0x20
	private Animator[] <>7__wrap1; // 0x28
	private int <>7__wrap2; // 0x30

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

	// RVA: 0x6C5420 Offset: 0x6C4820 VA: 0x1806C5420 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x6C5580 Offset: 0x6C4980 VA: 0x1806C5580 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

