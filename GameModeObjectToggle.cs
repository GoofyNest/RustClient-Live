public class GameModeObjectToggle : BaseMonoBehaviour // TypeDefIndex: 11621
{
	public string[] gameModeTags; 
	public string[] tagsToDisable; 
	public GameObject[] toToggle; 
	public bool defaultState; 


	public void Awake() { }

	public void OnDestroy() { }

	public void OnGameModeChanged(BaseGameMode newGameMode) { }

	public void SetToggle(bool wantsOn) { }

	public bool ShouldBeVisible(BaseGameMode newGameMode) { }

	public void .ctor() { }

}

