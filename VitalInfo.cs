public class VitalInfo : MonoBehaviour, IClientComponent, IVitalNotice // TypeDefIndex: 13030
{
	public HudElement Element; 
	public Image InfoImage; 
	public VitalInfo.Vital VitalType; 
	public TextMeshProUGUI text; 
	private bool show; 

	public bool IsActive { get; }


	private void Awake() { }

	public void Refresh() { }

	[IteratorStateMachineAttribute] 
	private IEnumerator FlashInfoIcon(int count, float interval) { }

	private void Hide() { }

	private void Show() { }

	private void ClientConnected() { }

	public bool get_IsActive() { }

	public void .ctor() { }

}

public enum VitalInfo.Vital // TypeDefIndex: 13031
{
	public int value__; 
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

private sealed class VitalInfo.<FlashInfoIcon>d__7 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 13032
{
	private int <>1__state; 
	private object <>2__current; 
	public VitalInfo <>4__this; 
	public float interval; 
	public int count; 
	private int <i>5__2; 

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

