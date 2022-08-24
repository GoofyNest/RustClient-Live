public struct Playable : IEquatable<Playable> // TypeDefIndex: 3864
{
	private PlayableHandle m_Handle; 
	private static readonly Playable m_NullPlayable; 

public static Playable Null { get; }


public static Playable get_Null() { }

	[VisibleToOtherModulesAttribute] 
internal void .ctor(PlayableHandle handle) { }

public PlayableHandle GetHandle() { }

public bool Equals(Playable other) { }

private static void .cctor() { }

}

