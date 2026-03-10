// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class SamandCollinHorror : ModuleRules
{
	public SamandCollinHorror(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"SamandCollinHorror",
			"SamandCollinHorror/Variant_Horror",
			"SamandCollinHorror/Variant_Horror/UI",
			"SamandCollinHorror/Variant_Shooter",
			"SamandCollinHorror/Variant_Shooter/AI",
			"SamandCollinHorror/Variant_Shooter/UI",
			"SamandCollinHorror/Variant_Shooter/Weapons"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
