public class IconSkin : MonoBehaviour, IItemIconChanged, IClientComponent // TypeDefIndex: 10925
{
	public Image icon;
	public Text text;
	public Action<int> onChanged;
	internal ItemDefinition item;
	internal int skinId;
	[CompilerGeneratedAttribute]
	private string <searchString>k__BackingField;

	public string searchString { get; set; }


	[CompilerGeneratedAttribute]
	public string get_searchString() { }

	[CompilerGeneratedAttribute]
	private void set_searchString(string value) { }

	protected void OnEnable() { }

	protected void OnDisable() { }

	public void OnItemIconChanged() { }

	internal void Setup(ItemDefinition item, int skinid, string text, bool canUse) { }

	public void Select() { }

	public void .ctor() { }

}

