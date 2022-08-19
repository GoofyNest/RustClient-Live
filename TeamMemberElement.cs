public class TeamMemberElement : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerClickHandler // TypeDefIndex: 11230
{	// Fields
	public RustText nameText; // 0x18
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

	// Methods

	// RVA: 0x7A7110 Offset: 0x7A6510 VA: 0x1807A7110
	public void UpdateState(string name, bool isOnline, bool isAlive = True, bool isLeader = False, bool isWounded = False) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public void OnEnable() { }

	// RVA: 0x7A6B50 Offset: 0x7A5F50 VA: 0x1807A6B50
	public void OnDisable() { }

	// RVA: 0x7A6BB0 Offset: 0x7A5FB0 VA: 0x1807A6BB0 Slot: 4
	public void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0x7A6C00 Offset: 0x7A6000 VA: 0x1807A6C00 Slot: 5
	public void OnPointerExit(PointerEventData eventData) { }

	// RVA: 0x7A6B60 Offset: 0x7A5F60 VA: 0x1807A6B60 Slot: 6
	public void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x7A6C50 Offset: 0x7A6050 VA: 0x1807A6C50
	public void OverlayClick() { }

	// RVA: 0x7A6E40 Offset: 0x7A6240 VA: 0x1807A6E40
	public void SetOverlayVisible(bool wantsVisible) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

