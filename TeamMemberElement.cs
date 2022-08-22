public class TeamMemberElement : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerClickHandler // TypeDefIndex: 11230
{	public RustText nameText; // 0x18
	public RawImage icon; // 0x20
	public Color onlineColor; // 0x28
	public Color offlineColor; // 0x38
	public Color deadColor; // 0x48
	public Color woundedColor; // 0x58
	public GameObject hoverOverlay; // 0x68
	public RawImage memberIcon; // 0x70
	public RawImage leaderIcon; // 0x78
	public RawImage deadIcon; // 0x80
	public RawImage woundedIcon; // 0x88
	public int teamIndex; // 0x90


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

