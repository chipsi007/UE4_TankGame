// Copyrigth Dominik Pavl��ek.

using UnrealBuildTool;
using System.Collections.Generic;

public class TankGameEditorTarget : TargetRules
{
	public TankGameEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;

		ExtraModuleNames.AddRange( new string[] { "TankGame" } );
	}
}