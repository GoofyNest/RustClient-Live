public class WorkshopBase : ScriptableObject // TypeDefIndex: 7692
{
	[TooltipAttribute] 
	public ulong itemID; 
	public string title; 
	[TextAreaAttribute] 
	public string description; 
	public Texture2D previewImage; 


	public void .ctor() { }

}

