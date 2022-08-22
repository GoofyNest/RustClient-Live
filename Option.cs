public struct Option // TypeDefIndex: 7027
{	public Icons Icon; // 0x0
	public string Value; // 0x8
	public Translate.Phrase Label; // 0x10
	public bool Default; // 0x18


	public void .ctor(string token, string english, string value, bool isdefault = False, Icons icon = 0) { }

	public void .ctor(Translate.Phrase phrase, string value, bool isdefault = False, Icons icon = 0) { }

	public void .ctor(Icons icon, string value, bool isdefault = False) { }

}

public struct Option // TypeDefIndex: 11670
{	public string title; // 0x0
	public string desc; // 0x8
	public string requirements; // 0x10
	public string icon; // 0x18
	public bool showOnItem; // 0x20
	public int order; // 0x24
	public float time; // 0x28
	public bool usableWhileWounded; // 0x2C
	public bool longUseOnly; // 0x2D
	public bool showDisabled; // 0x2E
	public bool show; // 0x2F
	public Action<BasePlayer> function; // 0x30
	public Action timeStart; // 0x38
	public Action timeProgress; // 0x40
	public Sprite iconSprite; // 0x48
	public string command; // 0x50

	public BaseEntity.Menu.Option copyOptionsFrom { set; }


	public void set_copyOptionsFrom(BaseEntity.Menu.Option value) { }

	public void RunTimeStart() { }

	public void RunTimeProgress() { }

}

