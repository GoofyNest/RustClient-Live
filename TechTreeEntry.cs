public class TechTreeEntry : TechTreeWidget // TypeDefIndex: 10913
{
	public RawImage icon; 
	public GameObject ableToUnlockBackground; 
	public GameObject unlockedBackground; 
	public GameObject lockedBackground; 
	public GameObject lockOverlay; 
	public GameObject selectedBackground; 
	public Image radialUnlock; 
	public float holdTime; 
	private bool locked; 
	private bool pathToUnlock; 
	private bool isSelected; 
	private float radialFillTime; 


public override bool IsLocked() { }

public override void SetSelected(bool wantsSelected) { }

private void UpdateRadialFill() { }

public override void SetLocked(bool isLocked) { }

public override void SetAbleToUnlock(bool wants) { }

public override bool HasPathToUnlock() { }

public void Refresh() { }

public void .ctor() { }

}

