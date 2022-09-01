public struct Option // TypeDefIndex: 7028
{
	public Icons Icon; 
	public string Value; 
	public Translate.Phrase Label; 
	public bool Default; 


	public void .ctor(string token, string english, string value, bool isdefault = False, Icons icon = 0) { }

	public void .ctor(Translate.Phrase phrase, string value, bool isdefault = False, Icons icon = 0) { }

	public void .ctor(Icons icon, string value, bool isdefault = False) { }

}

public struct Option // TypeDefIndex: 11698
{
	public string title; 
	public string desc; 
	public string requirements; 
	public string icon; 
	public bool showOnItem; 
	public int order; 
	public float time; 
	public bool usableWhileWounded; 
	public bool longUseOnly; 
	public bool showDisabled; 
	public bool show; 
	public Action<BasePlayer> function; 
	public Action timeStart; 
	public Action timeProgress; 
	public Sprite iconSprite; 
	public string command; 

	public BaseEntity.Menu.Option copyOptionsFrom { set; }


	public void set_copyOptionsFrom(BaseEntity.Menu.Option value) { }

	public void RunTimeStart() { }

	public void RunTimeProgress() { }

}

