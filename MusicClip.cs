public class MusicClip : ScriptableObject // TypeDefIndex: 9001
{
	public AudioClip audioClip; 
	public int lengthInBars; 
	public int lengthInBarsWithTail; 
	public List<float> fadeInPoints; 


	public float GetNextFadeInPoint(float currentClipTimeBars) { }

	public void .ctor() { }

}

