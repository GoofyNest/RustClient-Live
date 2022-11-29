public class PlayableDirector : Behaviour // TypeDefIndex: 4523
{

[NativeHeaderAttribute] 
[RequiredByNativeCodeAttribute] 
[NativeHeaderAttribute] 
public class PlayableDirector : Behaviour
	[DebuggerBrowsableAttribute] 
	[CompilerGeneratedAttribute] 
	private Action<PlayableDirector> played; 
	[CompilerGeneratedAttribute] 
	[DebuggerBrowsableAttribute] 
	private Action<PlayableDirector> paused; 
	[CompilerGeneratedAttribute] 
	[DebuggerBrowsableAttribute] 
	private Action<PlayableDirector> stopped; 

	public PlayState state { get; }
	public double time { set; }


	public PlayState get_state() { }

	public void set_time(double value) { }

	public void Evaluate() { }

	public void Play() { }

	private PlayState GetPlayState() { }

	[RequiredByNativeCodeAttribute] 
	private void SendOnPlayableDirectorPlay() { }

	[RequiredByNativeCodeAttribute] 
	private void SendOnPlayableDirectorPause() { }

	[RequiredByNativeCodeAttribute] 
	private void SendOnPlayableDirectorStop() { }

}

