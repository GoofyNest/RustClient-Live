public class PlayableDirector : Behaviour // TypeDefIndex: 4518
{

[RequiredByNativeCodeAttribute] 
[NativeHeaderAttribute] 
[NativeHeaderAttribute] 
public class PlayableDirector : Behaviour
	[CompilerGeneratedAttribute] 
	[DebuggerBrowsableAttribute] 
	private Action<PlayableDirector> played; 
	[CompilerGeneratedAttribute] 
	[DebuggerBrowsableAttribute] 
	private Action<PlayableDirector> paused; 
	[DebuggerBrowsableAttribute] 
	[CompilerGeneratedAttribute] 
	private Action<PlayableDirector> stopped; 


	[RequiredByNativeCodeAttribute] 
	private void SendOnPlayableDirectorPlay() { }

	[RequiredByNativeCodeAttribute] 
	private void SendOnPlayableDirectorPause() { }

	[RequiredByNativeCodeAttribute] 
	private void SendOnPlayableDirectorStop() { }

}

