public class TechTreeWidget : BaseMonoBehaviour // TypeDefIndex: 10917
{	// Fields
	public int id; // 0x18
	private Vector3 originalPos; // 0x1C

	// Properties
	public RectTransform rectTransform { get; }

	// Methods

	// RVA: 0x7ADB70 Offset: 0x7ACF70 VA: 0x1807ADB70
	public RectTransform get_rectTransform() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 6
	public virtual bool IsLocked() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 7
	public virtual bool HasPathToUnlock() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 8
	public virtual void SetLocked(bool isLocked) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 9
	public virtual void SetSelected(bool isSelected) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 10
	public virtual void SetAbleToUnlock(bool wants) { }

	// RVA: 0x7ADA30 Offset: 0x7ACE30 VA: 0x1807ADA30 Slot: 11
	public virtual void UnlockPunch(float scale = 1) { }

	// RVA: 0x7AD840 Offset: 0x7ACC40 VA: 0x1807AD840
	public void PunchSim() { }

	// RVA: 0x7AC980 Offset: 0x7ABD80 VA: 0x1807AC980
	public void .ctor() { }

}

