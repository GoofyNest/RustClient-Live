public class TechTreeWidget : BaseMonoBehaviour // TypeDefIndex: 12678
{
	public int id; 
	private Vector3 originalPos; 

	public RectTransform rectTransform { get; }


	public RectTransform get_rectTransform() { }

	public virtual bool IsLocked() { }

	public virtual bool HasPathToUnlock() { }

	public virtual void SetLocked(bool isLocked) { }

	public virtual void SetSelected(bool isSelected) { }

	public virtual void SetAbleToUnlock(bool wants) { }

	public virtual void UnlockPunch(float scale = 1) { }

	public void PunchSim() { }

	public void .ctor() { }

}

