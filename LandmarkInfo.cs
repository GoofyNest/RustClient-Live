public class LandmarkInfo : MonoBehaviour // TypeDefIndex: 11684
{
	[HeaderAttribute] 
	public bool shouldDisplayOnMap; 
	public bool isLayerSpecific; 
	public Translate.Phrase displayPhrase; 
	public Sprite mapIcon; 

	public virtual MapLayer MapLayer { get; }


	public virtual MapLayer get_MapLayer() { }

	protected virtual void Awake() { }

	public void .ctor() { }

}

