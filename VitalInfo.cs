public class VitalInfo : MonoBehaviour, IClientComponent, IVitalNotice // TypeDefIndex: 11278
{	// Fields
	public HudElement Element; // 0x18
	public Image InfoImage; // 0x20
	public VitalInfo.Vital VitalType; // 0x28
	public TextMeshProUGUI text; // 0x30
	private bool show; // 0x38

	// Properties
	public bool IsActive { get; }

	// Methods

	// RVA: 0x7DFAE0 Offset: 0x7DEEE0 VA: 0x1807DFAE0
	private void Awake() { }

	// RVA: 0x7DFBE0 Offset: 0x7DEFE0 VA: 0x1807DFBE0 Slot: 4
	public void Refresh() { }

	[IteratorStateMachineAttribute] // RVA: 0xA2D30 Offset: 0xA2130 VA: 0x1800A2D30
	// RVA: 0x7DFB50 Offset: 0x7DEF50 VA: 0x1807DFB50
	private IEnumerator FlashInfoIcon(int count, float interval) { }

	// RVA: 0x7DFB10 Offset: 0x7DEF10 VA: 0x1807DFB10
	private void Hide() { }

	// RVA: 0x7E06C0 Offset: 0x7DFAC0 VA: 0x1807E06C0
	private void Show() { }

	// RVA: 0x7DFB10 Offset: 0x7DEF10 VA: 0x1807DFB10
	private void ClientConnected() { }

	// RVA: 0x7667C0 Offset: 0x765BC0 VA: 0x1807667C0 Slot: 5
	public bool get_IsActive() { }

	// RVA: 0x7E0700 Offset: 0x7DFB00 VA: 0x1807E0700
	public void .ctor() { }

}

public enum VitalInfo.Vital // TypeDefIndex: 11279
{	// Fields
	public int value__; // 0x0
	public const VitalInfo.Vital BuildingBlocked = 0;
	public const VitalInfo.Vital CanBuild = 1;
	public const VitalInfo.Vital Crafting = 2;
	public const VitalInfo.Vital CraftLevel1 = 3;
	public const VitalInfo.Vital CraftLevel2 = 4;
	public const VitalInfo.Vital CraftLevel3 = 5;
	public const VitalInfo.Vital DecayProtected = 6;
	public const VitalInfo.Vital Decaying = 7;
	public const VitalInfo.Vital SafeZone = 8;
	public const VitalInfo.Vital Buffed = 9;
	public const VitalInfo.Vital Pet = 10;

}

private sealed class VitalInfo.<FlashInfoIcon>d__7 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 11280
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public VitalInfo <>4__this; // 0x20
	public float interval; // 0x28
	public int count; // 0x2C
	private int <i>5__2; // 0x30

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

	// RVA: 0x7CFB60 Offset: 0x7CEF60 VA: 0x1807CFB60 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7CFCD0 Offset: 0x7CF0D0 VA: 0x1807CFCD0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

