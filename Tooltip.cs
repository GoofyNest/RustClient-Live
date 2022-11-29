public class Tooltip : BaseMonoBehaviour, IClientComponent, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler // TypeDefIndex: 13019
{
	public static GameObject Current; 
	[TextAreaAttribute] 
	public string Text; 
	public GameObject TooltipObject; 
	public string token; 

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

