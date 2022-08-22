public class Tooltip : BaseMonoBehaviour, IClientComponent, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler // TypeDefIndex: 11237
{	public static GameObject Current; // 0x0
	[TextAreaAttribute] // RVA: 0x72060 Offset: 0x71460 VA: 0x180072060
	public string Text; // 0x18
	public GameObject TooltipObject; // 0x20
	public string token; // 0x28

	public string english { get; }


	public string get_english() { }

	public void OnPointerEnter(PointerEventData eventData) { }

	public void OpenTooltip() { }

	public void OnPointerExit(PointerEventData eventData) { }

	public static void KillTooltip() { }

	private Canvas GetTopMostCanvas() { }

	private void CreateTextTooltip() { }

	private static string ParseTokens(string text) { }

	public void .ctor() { }

}

