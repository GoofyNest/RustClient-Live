public class PlayableDirector : Behaviour // TypeDefIndex: 4518
{
// Namespace: UnityEngine.Playables
[RequiredByNativeCodeAttribute] // RVA: 0xDBA60 Offset: 0xDAE60 VA: 0x1800DBA60
[NativeHeaderAttribute] // RVA: 0xDBA60 Offset: 0xDAE60 VA: 0x1800DBA60
[NativeHeaderAttribute] // RVA: 0xDBA60 Offset: 0xDAE60 VA: 0x1800DBA60
public class PlayableDirector : Behaviour // TypeDefIndex: 4518
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	[DebuggerBrowsableAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	private Action<PlayableDirector> played; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	[DebuggerBrowsableAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	private Action<PlayableDirector> paused; // 0x20
	[DebuggerBrowsableAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	[CompilerGeneratedAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	private Action<PlayableDirector> stopped; // 0x28

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x231D6B0 Offset: 0x231CAB0 VA: 0x18231D6B0
	private void SendOnPlayableDirectorPlay() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x231D660 Offset: 0x231CA60 VA: 0x18231D660
	private void SendOnPlayableDirectorPause() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x231D700 Offset: 0x231CB00 VA: 0x18231D700
	private void SendOnPlayableDirectorStop() { }

}

