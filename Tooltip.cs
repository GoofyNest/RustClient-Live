public class Tooltip : BaseMonoBehaviour, IClientComponent, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler // TypeDefIndex: 11237
{	// Fields
	public static GameObject Current; // 0x0
	[TextAreaAttribute] // RVA: 0x72060 Offset: 0x71460 VA: 0x180072060
	public string Text; // 0x18
	public GameObject TooltipObject; // 0x20
	public string token; // 0x28

	// Properties
	public string english { get; }

	// Methods

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public string get_english() { }

	// RVA: 0x9E8890 Offset: 0x9E7C90 VA: 0x1809E8890 Slot: 6
	public void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0x9E89A0 Offset: 0x9E7DA0 VA: 0x1809E89A0
	public void OpenTooltip() { }

	// RVA: 0x9E8930 Offset: 0x9E7D30 VA: 0x1809E8930 Slot: 7
	public void OnPointerExit(PointerEventData eventData) { }

	// RVA: 0x9E87B0 Offset: 0x9E7BB0 VA: 0x1809E87B0
	public static void KillTooltip() { }

	// RVA: 0x9E8660 Offset: 0x9E7A60 VA: 0x1809E8660
	private Canvas GetTopMostCanvas() { }

	// RVA: 0x9E82D0 Offset: 0x9E76D0 VA: 0x1809E82D0
	private void CreateTextTooltip() { }

	// RVA: 0x9E89C0 Offset: 0x9E7DC0 VA: 0x1809E89C0
	private static string ParseTokens(string text) { }

	// RVA: 0x9E8D20 Offset: 0x9E8120 VA: 0x1809E8D20
	public void .ctor() { }

}

