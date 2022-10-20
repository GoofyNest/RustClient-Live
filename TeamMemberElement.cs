public class TeamMemberElement : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerClickHandler // TypeDefIndex: 12982
{
	public RustText nameText; 
	public RawImage icon; 
	public Color onlineColor; 
	public Color offlineColor; 
	public Color deadColor; 
	public Color woundedColor; 
	public GameObject hoverOverlay; 
	public RawImage memberIcon; 
	public RawImage leaderIcon; 
	public RawImage deadIcon; 
	public RawImage woundedIcon; 
	public int teamIndex; 


	public void UpdateState(string name, bool isOnline, bool isAlive = True, bool isLeader = False, bool isWounded = False) { }

	public void OnEnable() { }

	public void OnDisable() { }

	public void OnPointerEnter(PointerEventData eventData) { }

	public void OnPointerExit(PointerEventData eventData) { }

	public void OnPointerClick(PointerEventData eventData) { }

	public void OverlayClick() { }

	public void SetOverlayVisible(bool wantsVisible) { }

	public void .ctor() { }

}

