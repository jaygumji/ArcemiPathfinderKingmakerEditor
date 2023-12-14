﻿using System;
using System.Collections.Generic;

namespace Arcemi.Models.Warhammer40KRogueTrader
{
    public class W40KRTBlueprintTypeProvider : IBlueprintTypeProvider
    {
        public BlueprintType Get(BlueprintTypeId id)
        {
            return LookupId[id];
        }

        public BlueprintType Get(string fullName)
        {
            return LookupFullName.TryGetValue(fullName, out var type) ? type : new BlueprintType("<Unknown>", fullName);
        }

        public static BlueprintType AbilitiesUnlockTable { get; } = new BlueprintType("", "Warhammer.SpaceCombat.Blueprints.Progression.BlueprintAbilitiesUnlockTable, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType Ability { get; } = new BlueprintType("", "Kingmaker.UnitLogic.Abilities.Blueprints.BlueprintAbility, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType AbilityAdditionalEffect { get; } = new BlueprintType("", "Kingmaker.UnitLogic.Abilities.Blueprints.BlueprintAbilityAdditionalEffect, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType AbilityAreaEffect { get; } = new BlueprintType("", "Kingmaker.UnitLogic.Abilities.Blueprints.BlueprintAbilityAreaEffect, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType AbilityFXSettings { get; } = new BlueprintType("", "Kingmaker.UnitLogic.Abilities.Blueprints.BlueprintAbilityFXSettings, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType AbilityGroup { get; } = new BlueprintType("", "Kingmaker.Blueprints.BlueprintAbilityGroup, RogueTrader.GameCore, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType AbilityResource { get; } = new BlueprintType("", "Kingmaker.Blueprints.BlueprintAbilityResource, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType AbilitySoundFXSettings { get; } = new BlueprintType("", "Kingmaker.UnitLogic.Abilities.Blueprints.BlueprintAbilitySoundFXSettings, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType AbilityVisualFXSettings { get; } = new BlueprintType("", "Kingmaker.UnitLogic.Abilities.Visual.Blueprints.BlueprintAbilityVisualFXSettings, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType AchievementData { get; } = new BlueprintType("", "Kingmaker.Achievements.AchievementData, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType AchievementsRoot { get; } = new BlueprintType("", "Kingmaker.Blueprints.Root.BlueprintAchievementsRoot, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType ActionCameraSettings { get; } = new BlueprintType("", "Kingmaker.Blueprints.Camera.BlueprintActionCameraSettings, RogueTrader.GameCore, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType ActionsHolder { get; } = new BlueprintType("", "Kingmaker.ElementsSystem.ActionsHolder, RogueTrader.GameCore, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType ActivatableAbility { get; } = new BlueprintType("", "Kingmaker.UnitLogic.ActivatableAbilities.BlueprintActivatableAbility, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType AnimationActionExternalHandler { get; } = new BlueprintType("", "Kingmaker.Blueprints.BlueprintAnimationActionExternalHandler, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType Anomaly { get; } = new BlueprintType("", "Kingmaker.Globalmap.Blueprints.Exploration.BlueprintAnomaly, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType AnomalyGroupSpawnSettings { get; } = new BlueprintType("", "Kingmaker.Globalmap.Blueprints.Exploration.BlueprintAnomalyGroupSpawnSettings, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType Answer { get; } = new BlueprintType("", "Kingmaker.DialogSystem.Blueprints.BlueprintAnswer, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType AnswersList { get; } = new BlueprintType("", "Kingmaker.DialogSystem.Blueprints.BlueprintAnswersList, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType ArbiterInstruction { get; } = new BlueprintType("", "Kingmaker.QA.Arbiter.BlueprintArbiterInstruction, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType ArbiterRoot { get; } = new BlueprintType("", "Kingmaker.QA.Arbiter.BlueprintArbiterRoot, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType Area { get; } = new BlueprintType("", "Kingmaker.Blueprints.Area.BlueprintArea, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType AreaEffectPitVisualSettings { get; } = new BlueprintType("", "Kingmaker.UnitLogic.Abilities.Visual.Blueprints.BlueprintAreaEffectPitVisualSettings, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType AreaEnterPoint { get; } = new BlueprintType("", "Kingmaker.Blueprints.Area.BlueprintAreaEnterPoint, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType AreaMechanics { get; } = new BlueprintType("", "Kingmaker.Blueprints.Area.BlueprintAreaMechanics, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType AreaPart { get; } = new BlueprintType("", "Kingmaker.Blueprints.Area.BlueprintAreaPart, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType AreaPreset { get; } = new BlueprintType("", "Kingmaker.Blueprints.Area.BlueprintAreaPreset, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType AreaTransition { get; } = new BlueprintType("", "Kingmaker.Blueprints.Area.BlueprintAreaTransition, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType ArmorType { get; } = new BlueprintType("", "Kingmaker.Blueprints.Items.Armors.BlueprintArmorType, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType ArmyDescription { get; } = new BlueprintType("", "Kingmaker.Blueprints.BlueprintArmyDescription, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType ArtificialObject { get; } = new BlueprintType("", "Kingmaker.Globalmap.Blueprints.SystemMap.BlueprintArtificialObject, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType Asteroid { get; } = new BlueprintType("", "Kingmaker.Globalmap.Blueprints.SystemMap.BlueprintAsteroid, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType AstropathBrief { get; } = new BlueprintType("", "Kingmaker.Globalmap.Blueprints.BlueprintAstropathBrief, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType AttackPattern { get; } = new BlueprintType("", "Kingmaker.Blueprints.BlueprintAttackPattern, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType AttributeAdvancement { get; } = new BlueprintType("", "Kingmaker.UnitLogic.Progression.Features.Advancements.BlueprintAttributeAdvancement, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType BarkBanter { get; } = new BlueprintType("", "Kingmaker.BarkBanters.BlueprintBarkBanter, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType BarkBanterList { get; } = new BlueprintType("", "Kingmaker.BarkBanters.BlueprintBarkBanterList, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType BookPage { get; } = new BlueprintType("", "Kingmaker.DialogSystem.Blueprints.BlueprintBookPage, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType Brain { get; } = new BlueprintType("", "Kingmaker.AI.Blueprints.BlueprintBrain, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType Buff { get; } = new BlueprintType("", "Kingmaker.UnitLogic.Buffs.Blueprints.BlueprintBuff, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType CameraFollowSettings { get; } = new BlueprintType("", "Kingmaker.Blueprints.Camera.BlueprintCameraFollowSettings, RogueTrader.GameCore, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType CameraRecorderData { get; } = new BlueprintType("", "RogueTrader.Editor.CameraRecorder.CameraRecorderData, RogueTrader.GameCore, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType CameraRoot { get; } = new BlueprintType("", "Kingmaker.Blueprints.Camera.CameraRoot, RogueTrader.GameCore, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType CameraSettings { get; } = new BlueprintType("", "Kingmaker.Blueprints.Camera.BlueprintCameraSettings, RogueTrader.GameCore, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType CareerPath { get; } = new BlueprintType("", "Kingmaker.UnitLogic.Progression.Paths.BlueprintCareerPath, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType Cargo { get; } = new BlueprintType("", "Kingmaker.Blueprints.Cargo.BlueprintCargo, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType CargoRoot { get; } = new BlueprintType("", "Kingmaker.Blueprints.Cargo.BlueprintCargoRoot, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType CategoryDefaults { get; } = new BlueprintType("", "Kingmaker.Blueprints.Items.Weapons.BlueprintCategoryDefaults, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType CharacterClass { get; } = new BlueprintType("", "Kingmaker.UnitLogic.Levelup.Obsolete.Blueprints.BlueprintCharacterClass, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType CharacterNameSelection { get; } = new BlueprintType("", "Kingmaker.UnitLogic.Levelup.Selections.CharacterName.BlueprintCharacterNameSelection, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType CharGenRoot { get; } = new BlueprintType("", "Kingmaker.Blueprints.Root.BlueprintCharGenRoot, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType Check { get; } = new BlueprintType("", "Kingmaker.DialogSystem.Blueprints.BlueprintCheck, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType Colony { get; } = new BlueprintType("", "Kingmaker.Globalmap.Blueprints.Colonization.BlueprintColony, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType ColonyChronicle { get; } = new BlueprintType("", "Kingmaker.Globalmap.Blueprints.Colonization.BlueprintColonyChronicle, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType ColonyEvent { get; } = new BlueprintType("", "Kingmaker.Globalmap.Blueprints.Colonization.BlueprintColonyEvent, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType ColonyEventResult { get; } = new BlueprintType("", "Kingmaker.Globalmap.Blueprints.Colonization.BlueprintColonyEventResult, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType ColonyEventsRoot { get; } = new BlueprintType("", "Kingmaker.Globalmap.Blueprints.Colonization.BlueprintColonyEventsRoot, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType ColonyProject { get; } = new BlueprintType("", "Kingmaker.Globalmap.Blueprints.Colonization.BlueprintColonyProject, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType ColonyRoot { get; } = new BlueprintType("", "Kingmaker.Globalmap.Blueprints.Colonization.BlueprintColonyRoot, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType ColonyTrait { get; } = new BlueprintType("", "Kingmaker.Globalmap.Blueprints.Colonization.BlueprintColonyTrait, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType CombatRandomEncountersRoot { get; } = new BlueprintType("", "Kingmaker.Globalmap.Blueprints.CombatRandomEncounters.BlueprintCombatRandomEncountersRoot, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType CombatRoot { get; } = new BlueprintType("", "Kingmaker.Blueprints.Root.SystemMechanics.BlueprintCombatRoot, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType CommandAction { get; } = new BlueprintType("", "Kingmaker.AreaLogic.Cutscenes.CommandAction, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType CommandActivateGate { get; } = new BlueprintType("", "Kingmaker.AreaLogic.Cutscenes.CommandActivateGate, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType CommandAddFogOfWarRevealer { get; } = new BlueprintType("", "Kingmaker.AreaLogic.Cutscenes.Commands.CommandAddFogOfWarRevealer, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType CommandAttachBuffSpan { get; } = new BlueprintType("", "Kingmaker.AreaLogic.Cutscenes.Commands.CommandAttachBuffSpan, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType CommandBark { get; } = new BlueprintType("", "Kingmaker.AreaLogic.Cutscenes.Commands.CommandBark, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType CommandCameraFollow { get; } = new BlueprintType("", "Kingmaker.AreaLogic.Cutscenes.Commands.CommandCameraFollow, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType CommandCameraShake { get; } = new BlueprintType("", "Kingmaker.AreaLogic.Cutscenes.Commands.CommandCameraShake, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType CommandControlCamera { get; } = new BlueprintType("", "Kingmaker.AreaLogic.Cutscenes.Commands.CommandControlCamera, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType CommandCrossfadeToIdle { get; } = new BlueprintType("", "Kingmaker.AreaLogic.Cutscenes.Commands.CommandCrossfadeToIdle, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType CommandCustomeCutsceneController { get; } = new BlueprintType("", "Kingmaker.AreaLogic.Cutscenes.Commands.CommandCustomeCutsceneController, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType CommandDefaultTeleport { get; } = new BlueprintType("", "Kingmaker.AreaLogic.Cutscenes.CommandDefaultTeleport, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType CommandDelay { get; } = new BlueprintType("", "Kingmaker.AreaLogic.Cutscenes.Commands.CommandDelay, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType CommandFadeout { get; } = new BlueprintType("", "Kingmaker.AreaLogic.Cutscenes.Commands.CommandFadeout, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType CommandIgnoreCombat { get; } = new BlueprintType("", "Kingmaker.AreaLogic.Cutscenes.Commands.CommandIgnoreCombat, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType CommandMarkHiddenSpan { get; } = new BlueprintType("", "Kingmaker.AreaLogic.Cutscenes.Commands.CommandMarkHiddenSpan, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType CommandMarkOnElevatorSpan { get; } = new BlueprintType("", "Kingmaker.AreaLogic.Cutscenes.Commands.CommandMarkOnElevatorSpan, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType CommandMarkPartyHiddenSpan { get; } = new BlueprintType("", "Kingmaker.AreaLogic.Cutscenes.Commands.CommandMarkPartyHiddenSpan, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType CommandMarkPartyOnElevatorSpan { get; } = new BlueprintType("", "Kingmaker.AreaLogic.Cutscenes.Commands.CommandMarkPartyOnElevatorSpan, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType CommandMarkUnitControlled { get; } = new BlueprintType("", "Kingmaker.AreaLogic.Cutscenes.Commands.CommandMarkUnitControlled, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType CommandMarkUntargetableSpan { get; } = new BlueprintType("", "Kingmaker.AreaLogic.Cutscenes.Commands.CommandMarkUntargetableSpan, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType CommandMoveCamera { get; } = new BlueprintType("", "Kingmaker.AreaLogic.Cutscenes.Commands.CommandMoveCamera, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType CommandMoveParty { get; } = new BlueprintType("", "Kingmaker.AreaLogic.Cutscenes.Commands.CommandMoveParty, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType CommandMoveUnit { get; } = new BlueprintType("", "Kingmaker.AreaLogic.Cutscenes.Commands.CommandMoveUnit, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType CommandPlayTimeline { get; } = new BlueprintType("", "Kingmaker.AreaLogic.Cutscenes.Commands.Timeline.CommandPlayTimeline, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType CommandPlayVideo { get; } = new BlueprintType("", "Kingmaker.AreaLogic.Cutscenes.Commands.CommandPlayVideo, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType CommandSaveFogOfWar { get; } = new BlueprintType("", "Kingmaker.AreaLogic.Cutscenes.Commands.CommandSaveFogOfWar, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType CommandSetCombatMode { get; } = new BlueprintType("", "Kingmaker.AreaLogic.Cutscenes.Commands.CommandSetCombatMode, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType CommandSkipTime { get; } = new BlueprintType("", "Kingmaker.AreaLogic.Cutscenes.Commands.CommandSkipTime, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType CommandStartDialog { get; } = new BlueprintType("", "Kingmaker.AreaLogic.Cutscenes.Commands.CommandStartDialog, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType CommandStopUnit { get; } = new BlueprintType("", "Kingmaker.AreaLogic.Cutscenes.Commands.CommandStopUnit, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType CommandSwitchDoor { get; } = new BlueprintType("", "Kingmaker.AreaLogic.Cutscenes.CommandSwitchDoor, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType CommandTeleport { get; } = new BlueprintType("", "Kingmaker.AreaLogic.Cutscenes.Commands.CommandTeleport, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType CommandTranslocateParty { get; } = new BlueprintType("", "Kingmaker.AreaLogic.Cutscenes.Commands.CommandTranslocateParty, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType CommandUnitAnimationCoverBlocker { get; } = new BlueprintType("", "Kingmaker.AreaLogic.Cutscenes.Commands.CommandUnitAnimationCoverBlocker, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType CommandUnitAttack { get; } = new BlueprintType("", "Kingmaker.AreaLogic.Cutscenes.Commands.CommandUnitAttack, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType CommandUnitCastSpell { get; } = new BlueprintType("", "Kingmaker.AreaLogic.Cutscenes.Commands.CommandUnitCastSpell, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType CommandUnitLookAt { get; } = new BlueprintType("", "Kingmaker.AreaLogic.Cutscenes.Commands.CommandUnitLookAt, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType CommandUnitPlayCutsceneAnimation { get; } = new BlueprintType("", "Kingmaker.AreaLogic.Cutscenes.Commands.CommandUnitPlayCutsceneAnimation, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType CommandWaitForCombatEnd { get; } = new BlueprintType("", "Kingmaker.AreaLogic.Cutscenes.Commands.CommandWaitForCombatEnd, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType CompanionStory { get; } = new BlueprintType("", "Kingmaker.Blueprints.BlueprintCompanionStory, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType ComponentList { get; } = new BlueprintType("", "Kingmaker.Blueprints.BlueprintComponentList, RogueTrader.GameCore, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType ConditionsHolder { get; } = new BlueprintType("", "Kingmaker.ElementsSystem.ConditionsHolder, RogueTrader.GameCore, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType ConsoleRoot { get; } = new BlueprintType("", "Kingmaker.Blueprints.Root.ConsoleRoot, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType CreditsGroup { get; } = new BlueprintType("", "Kingmaker.Blueprints.Credits.BlueprintCreditsGroup, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType CreditsRoles { get; } = new BlueprintType("", "Kingmaker.Blueprints.Credits.BlueprintCreditsRoles, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType CreditsTeams { get; } = new BlueprintType("", "Kingmaker.Blueprints.Credits.BlueprintCreditsTeams, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType Cue { get; } = new BlueprintType("", "Kingmaker.DialogSystem.Blueprints.BlueprintCue, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType CueSequence { get; } = new BlueprintType("", "Kingmaker.DialogSystem.Blueprints.BlueprintCueSequence, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType Cutscene { get; } = new BlueprintType("", "Kingmaker.AreaLogic.Cutscenes.Cutscene, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType CutscenesRoot { get; } = new BlueprintType("", "Kingmaker.Blueprints.Root.CutscenesRoot, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType DamageSkillCheckRoot { get; } = new BlueprintType("", "Kingmaker.Blueprints.Root.DamageSkillCheckRoot, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType DebuffSkillCheckRoot { get; } = new BlueprintType("", "Kingmaker.Blueprints.Root.DebuffSkillCheckRoot, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType DestructibleObject { get; } = new BlueprintType("", "Kingmaker.UnitLogic.Mechanics.Blueprints.BlueprintDestructibleObject, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType DestructibleObjectsRoot { get; } = new BlueprintType("", "Kingmaker.Blueprints.Root.SystemMechanics.BlueprintDestructibleObjectsRoot, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType Dialog { get; } = new BlueprintType("", "Kingmaker.DialogSystem.Blueprints.BlueprintDialog, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType DifficultyRoot { get; } = new BlueprintType("", "Kingmaker.Blueprints.Root.SystemMechanics.BlueprintDifficultyRoot, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType DismembermentRoot { get; } = new BlueprintType("", "Kingmaker.Blueprints.Root.BlueprintDismembermentRoot, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType Dlc { get; } = new BlueprintType("", "Kingmaker.DLC.BlueprintDlc, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType DlcReward { get; } = new BlueprintType("", "Kingmaker.DLC.BlueprintDlcReward, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType DynamicMapObject { get; } = new BlueprintType("", "Kingmaker.Blueprints.Area.BlueprintDynamicMapObject, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType EncyclopediaAstropathBriefPage { get; } = new BlueprintType("", "Kingmaker.Blueprints.Encyclopedia.BlueprintEncyclopediaAstropathBriefPage, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType EncyclopediaBookEventPage { get; } = new BlueprintType("", "Kingmaker.Blueprints.Encyclopedia.BlueprintEncyclopediaBookEventPage, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType EncyclopediaChapter { get; } = new BlueprintType("", "Kingmaker.Blueprints.Encyclopedia.BlueprintEncyclopediaChapter, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType EncyclopediaGlossaryChapter { get; } = new BlueprintType("", "Kingmaker.Blueprints.Encyclopedia.BlueprintEncyclopediaGlossaryChapter, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType EncyclopediaGlossaryEntry { get; } = new BlueprintType("", "Kingmaker.Blueprints.Encyclopedia.BlueprintEncyclopediaGlossaryEntry, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType EncyclopediaPage { get; } = new BlueprintType("", "Kingmaker.Blueprints.Encyclopedia.BlueprintEncyclopediaPage, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType EncyclopediaPlanetTypePage { get; } = new BlueprintType("", "Kingmaker.Blueprints.Encyclopedia.BlueprintEncyclopediaPlanetTypePage, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType EnumUnitSubtypeIcons { get; } = new BlueprintType("", "Kingmaker.UI.Common.UIConfigComponents.EnumUnitSubtypeIcons, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType EquipmentEnchantment { get; } = new BlueprintType("", "Kingmaker.Blueprints.Items.Ecnchantments.BlueprintEquipmentEnchantment, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType Etude { get; } = new BlueprintType("", "Kingmaker.AreaLogic.Etudes.BlueprintEtude, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType EtudeConflictingGroup { get; } = new BlueprintType("", "Kingmaker.AreaLogic.Etudes.BlueprintEtudeConflictingGroup, RogueTrader.GameCore, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType Faction { get; } = new BlueprintType("", "Kingmaker.Blueprints.BlueprintFaction, RogueTrader.GameCore, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType FamiliarsRoot { get; } = new BlueprintType("", "Kingmaker.Blueprints.Root.FamiliarsRoot, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType Feature { get; } = new BlueprintType("", "Kingmaker.UnitLogic.Progression.Features.BlueprintFeature, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType FeatureSelection_Obsolete { get; } = new BlueprintType("", "Kingmaker.UnitLogic.Levelup.Obsolete.Blueprints.Selection.BlueprintFeatureSelection_Obsolete, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType FollowersFormation { get; } = new BlueprintType("", "Kingmaker.Formations.FollowersFormation, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType FormationsRoot { get; } = new BlueprintType("", "Kingmaker.Blueprints.Root.FormationsRoot, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType FxLocatorGroup { get; } = new BlueprintType("", "Kingmaker.Visual.Particles.Blueprints.BlueprintFxLocatorGroup, RogueTrader.GameCore, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType FxRoot { get; } = new BlueprintType("", "Kingmaker.Blueprints.Root.Fx.FxRoot, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType GamePadTexts { get; } = new BlueprintType("", "Kingmaker.Blueprints.Console.GamePadTexts, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType Gate { get; } = new BlueprintType("", "Kingmaker.AreaLogic.Cutscenes.Gate, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType GenderSelection { get; } = new BlueprintType("", "Kingmaker.UnitLogic.Levelup.Selections.CharacterGender.BlueprintGenderSelection, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType HitSystemRoot { get; } = new BlueprintType("", "Kingmaker.Visual.HitSystem.HitSystemRoot, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType InteractionRoot { get; } = new BlueprintType("", "Kingmaker.Interaction.BlueprintInteractionRoot, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType InteractionVariantVisualSetsBlueprint { get; } = new BlueprintType("", "Kingmaker.Interaction.InteractionVariantVisualSetsBlueprint, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType Item { get; } = new BlueprintType("Other", "Kingmaker.Blueprints.Items.BlueprintItem, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType ItemArmor { get; } = new BlueprintType("Armor", "Kingmaker.Blueprints.Items.Armors.BlueprintItemArmor, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType ItemArmorPlating { get; } = new BlueprintType("Armor Plating", "Warhammer.SpaceCombat.Blueprints.BlueprintItemArmorPlating, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType ItemAugerArray { get; } = new BlueprintType("Auger Array", "Warhammer.SpaceCombat.Blueprints.BlueprintItemAugerArray, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType ItemEquipmentFeet { get; } = new BlueprintType("Feet", "Kingmaker.Blueprints.Items.Equipment.BlueprintItemEquipmentFeet, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType ItemEquipmentGloves { get; } = new BlueprintType("Gloves", "Kingmaker.Blueprints.Items.Equipment.BlueprintItemEquipmentGloves, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType ItemEquipmentHead { get; } = new BlueprintType("Head", "Kingmaker.Blueprints.Items.Equipment.BlueprintItemEquipmentHead, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType ItemEquipmentNeck { get; } = new BlueprintType("Neck", "Kingmaker.Blueprints.Items.Equipment.BlueprintItemEquipmentNeck, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType ItemEquipmentRing { get; } = new BlueprintType("Ring", "Kingmaker.Blueprints.Items.Equipment.BlueprintItemEquipmentRing, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType ItemEquipmentShoulders { get; } = new BlueprintType("Shoulders", "Kingmaker.Blueprints.Items.Equipment.BlueprintItemEquipmentShoulders, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType ItemEquipmentUsable { get; } = new BlueprintType("Usable", "Kingmaker.Blueprints.Items.Equipment.BlueprintItemEquipmentUsable, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType ItemKey { get; } = new BlueprintType("Key", "Kingmaker.Blueprints.Items.BlueprintItemKey, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType ItemLifeSustainer { get; } = new BlueprintType("Life Sustainer", "Warhammer.SpaceCombat.Blueprints.BlueprintItemLifeSustainer, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType ItemMechadendrite { get; } = new BlueprintType("Mechadendrite", "Kingmaker.Blueprints.Items.Equipment.BlueprintItemMechadendrite, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType ItemNote { get; } = new BlueprintType("Note", "Kingmaker.Blueprints.Items.BlueprintItemNote, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType ItemPlasmaDrives { get; } = new BlueprintType("Plasma Drives", "Warhammer.SpaceCombat.Blueprints.BlueprintItemPlasmaDrives, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType ItemResourceMiner { get; } = new BlueprintType("Resource Miner", "Kingmaker.Blueprints.Items.BlueprintItemResourceMiner, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType ItemsList { get; } = new BlueprintType("Items List", "Kingmaker.Blueprints.Items.BlueprintItemsList, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType ItemsStash { get; } = new BlueprintType("Items Stash", "Kingmaker.Blueprints.BlueprintItemsStash, RogueTrader.GameCore, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType ItemVoidShieldGenerator { get; } = new BlueprintType("Void Shield Generator", "Warhammer.SpaceCombat.Blueprints.BlueprintItemVoidShieldGenerator, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType ItemWeapon { get; } = new BlueprintType("Weapon", "Kingmaker.Blueprints.Items.Weapons.BlueprintItemWeapon, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType KingmakerEquipmentEntity { get; } = new BlueprintType("", "Kingmaker.Visual.CharacterSystem.KingmakerEquipmentEntity, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType Loot { get; } = new BlueprintType("Loot", "Kingmaker.Blueprints.Loot.BlueprintLoot, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType MechanicEntityFact { get; } = new BlueprintType("", "Kingmaker.UnitLogic.Mechanics.Blueprints.BlueprintMechanicEntityFact, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType Meteor { get; } = new BlueprintType("", "Warhammer.SpaceCombat.Blueprints.BlueprintMeteor, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType MeteorStream { get; } = new BlueprintType("", "Kingmaker.Blueprints.BlueprintMeteorStream, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType MomentumGroup { get; } = new BlueprintType("", "Kingmaker.Blueprints.BlueprintMomentumGroup, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType MomentumRoot { get; } = new BlueprintType("", "Kingmaker.Blueprints.BlueprintMomentumRoot, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType MultiEntrance { get; } = new BlueprintType("", "Kingmaker.Globalmap.Blueprints.BlueprintMultiEntrance, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType MultiEntranceEntry { get; } = new BlueprintType("", "Kingmaker.Globalmap.Blueprints.BlueprintMultiEntranceEntry, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType MythicInfo { get; } = new BlueprintType("", "Kingmaker.DialogSystem.Blueprints.BlueprintMythicInfo, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType MythicsSettings { get; } = new BlueprintType("", "Kingmaker.DialogSystem.Blueprints.BlueprintMythicsSettings, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType NodeLinkRoot { get; } = new BlueprintType("", "Kingmaker.Blueprints.NodeLink.BlueprintNodeLinkRoot, RogueTrader.GameCore, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType OriginPath { get; } = new BlueprintType("", "Kingmaker.UnitLogic.Progression.Paths.BlueprintOriginPath, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType PartsCargo { get; } = new BlueprintType("", "Warhammer.SpaceCombat.Blueprints.BlueprintPartsCargo, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType PartyFormation { get; } = new BlueprintType("", "Kingmaker.Formations.BlueprintPartyFormation, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType Planet { get; } = new BlueprintType("", "Kingmaker.Globalmap.Blueprints.SystemMap.BlueprintPlanet, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType PlanetPrefab { get; } = new BlueprintType("", "Kingmaker.Globalmap.Blueprints.SystemMap.BlueprintPlanetPrefab, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType PlanetSettingsRoot { get; } = new BlueprintType("", "Kingmaker.Globalmap.Blueprints.SystemMap.BlueprintPlanetSettingsRoot, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType PlayerUpgradeActionsRoot { get; } = new BlueprintType("", "Kingmaker.Blueprints.Root.PlayerUpgradeActionsRoot, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType PlayerUpgrader { get; } = new BlueprintType("", "Kingmaker.EntitySystem.Persistence.Versioning.BlueprintPlayerUpgrader, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType PointOfInterestBookEvent { get; } = new BlueprintType("", "Kingmaker.Globalmap.Blueprints.Exploration.BlueprintPointOfInterestBookEvent, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType PointOfInterestCargo { get; } = new BlueprintType("", "Kingmaker.Globalmap.Blueprints.Exploration.BlueprintPointOfInterestCargo, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType PointOfInterestColonyTrait { get; } = new BlueprintType("", "Kingmaker.Globalmap.Blueprints.Exploration.BlueprintPointOfInterestColonyTrait, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType PointOfInterestExpedition { get; } = new BlueprintType("", "Kingmaker.Globalmap.Blueprints.Exploration.BlueprintPointOfInterestExpedition, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType PointOfInterestGroundOperation { get; } = new BlueprintType("", "Kingmaker.Globalmap.Blueprints.Exploration.BlueprintPointOfInterestGroundOperation, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType PointOfInterestLoot { get; } = new BlueprintType("", "Kingmaker.Globalmap.Blueprints.Exploration.BlueprintPointOfInterestLoot, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType PointOfInterestResources { get; } = new BlueprintType("", "Kingmaker.Globalmap.Blueprints.Exploration.BlueprintPointOfInterestResources, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType PointOfInterestStatCheckLoot { get; } = new BlueprintType("", "Kingmaker.Globalmap.Blueprints.Exploration.BlueprintPointOfInterestStatCheckLoot, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType Portrait { get; } = new BlueprintType("", "Kingmaker.Blueprints.BlueprintPortrait, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType PortraitSelection { get; } = new BlueprintType("", "Kingmaker.UnitLogic.Levelup.Selections.Portrait.BlueprintPortraitSelection, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType PostProcessingEffectsLibrary { get; } = new BlueprintType("", "Kingmaker.Blueprints.Root.PostProcessingEffectsLibrary, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType ProfitFactorRoot { get; } = new BlueprintType("", "Kingmaker.Blueprints.Root.BlueprintProfitFactorRoot, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType Progression { get; } = new BlueprintType("", "Kingmaker.UnitLogic.Levelup.Obsolete.Blueprints.BlueprintProgression, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType Projectile { get; } = new BlueprintType("", "Kingmaker.Blueprints.BlueprintProjectile, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType ProjectileTrajectory { get; } = new BlueprintType("", "Kingmaker.Blueprints.BlueprintProjectileTrajectory, RogueTrader.GameCore, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType PropertyCalculatorBlueprint { get; } = new BlueprintType("", "Kingmaker.EntitySystem.Properties.PropertyCalculatorBlueprint, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType PSNObjectsRoot { get; } = new BlueprintType("", "Kingmaker.Console.PS5.PSNObjects.BlueprintPSNObjectsRoot, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType PsychicPhenomenaRoot { get; } = new BlueprintType("", "Kingmaker.Designers.WarhammerSurfaceCombatPrototype.BlueprintPsychicPhenomenaRoot, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType PushSettingRoot { get; } = new BlueprintType("", "Kingmaker.Blueprints.Root.PushSettingRoot, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType Quest { get; } = new BlueprintType("", "Kingmaker.Blueprints.Quests.BlueprintQuest, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType QuestContract { get; } = new BlueprintType("", "Kingmaker.Code.Blueprints.Quests.BlueprintQuestContract, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType QuestGroups { get; } = new BlueprintType("", "Kingmaker.Blueprints.Quests.BlueprintQuestGroups, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType QuestObjective { get; } = new BlueprintType("", "Kingmaker.Blueprints.Quests.BlueprintQuestObjective, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType Race { get; } = new BlueprintType("", "Kingmaker.UnitLogic.Progression.Features.BlueprintRace, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType RaceGenderDistribution { get; } = new BlueprintType("", "Kingmaker.UnitLogic.Customization.RaceGenderDistribution, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType RaceVisualPreset { get; } = new BlueprintType("", "Kingmaker.UnitLogic.Levelup.CharGen.BlueprintRaceVisualPreset, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType RandomGroupOfUnits { get; } = new BlueprintType("", "Kingmaker.Globalmap.Blueprints.CombatRandomEncounters.BlueprintRandomGroupOfUnits, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType Resource { get; } = new BlueprintType("", "Kingmaker.Globalmap.Blueprints.Colonization.BlueprintResource, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType RestrictionsHolder { get; } = new BlueprintType("", "Kingmaker.Blueprints.RestrictionsHolder, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType Root { get; } = new BlueprintType("", "Kingmaker.Blueprints.Root.BlueprintRoot, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType ScrapRoot { get; } = new BlueprintType("", "Kingmaker.Blueprints.Root.BlueprintScrapRoot, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType ScriptZone { get; } = new BlueprintType("", "Kingmaker.Blueprints.Area.BlueprintScriptZone, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType SectorMapArea { get; } = new BlueprintType("", "Kingmaker.Globalmap.Blueprints.BlueprintSectorMapArea, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType SectorMapPoint { get; } = new BlueprintType("", "Kingmaker.Globalmap.Blueprints.SectorMap.BlueprintSectorMapPoint, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType SectorMapPointStarSystem { get; } = new BlueprintType("", "Kingmaker.Globalmap.Blueprints.SectorMap.BlueprintSectorMapPointStarSystem, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType SelectionDoll { get; } = new BlueprintType("", "Kingmaker.UnitLogic.Levelup.Selections.Doll.BlueprintSelectionDoll, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType SelectionFeature { get; } = new BlueprintType("", "Kingmaker.UnitLogic.Levelup.Selections.Feature.BlueprintSelectionFeature, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType SelectionShip { get; } = new BlueprintType("", "Kingmaker.UnitLogic.Levelup.Selections.Ship.BlueprintSelectionShip, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType SequenceExit { get; } = new BlueprintType("", "Kingmaker.DialogSystem.Blueprints.BlueprintSequenceExit, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType SharedVendorTable { get; } = new BlueprintType("", "Kingmaker.Blueprints.Items.BlueprintSharedVendorTable, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType ShipComponentsUnlockTable { get; } = new BlueprintType("", "Warhammer.SpaceCombat.Blueprints.Progression.BlueprintShipComponentsUnlockTable, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType ShipPostExpertise { get; } = new BlueprintType("", "Kingmaker.SpaceCombat.Blueprints.BlueprintShipPostExpertise, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType ShipSystemComponent { get; } = new BlueprintType("", "Warhammer.SpaceCombat.Blueprints.BlueprintShipSystemComponent, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType SkillAdvancement { get; } = new BlueprintType("", "Kingmaker.UnitLogic.Progression.Features.Advancements.BlueprintSkillAdvancement, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType SkillCheckRoot { get; } = new BlueprintType("", "Kingmaker.Blueprints.Root.SkillCheckRoot, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType SoulMark { get; } = new BlueprintType("", "Kingmaker.UnitLogic.BlueprintSoulMark, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType SoulMarksRoot { get; } = new BlueprintType("", "Kingmaker.Blueprints.Root.BlueprintSoulMarksRoot, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType SoundRagdollSettings { get; } = new BlueprintType("", "Kingmaker.Blueprints.Root.SoundRagdollSettings, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType SpaceCombatArea { get; } = new BlueprintType("", "Warhammer.SpaceCombat.Blueprints.BlueprintSpaceCombatArea, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType SpawnersList { get; } = new BlueprintType("", "Kingmaker.AreaLogic.TimeSurvival.BlueprintSpawnersList, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType StackingUnitProperty { get; } = new BlueprintType("", "Kingmaker.Mechanics.Blueprints.BlueprintStackingUnitProperty, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType Star { get; } = new BlueprintType("", "Kingmaker.Globalmap.Blueprints.SystemMap.BlueprintStar, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType Starship { get; } = new BlueprintType("", "Warhammer.SpaceCombat.Blueprints.BlueprintStarship, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType StarshipAmmo { get; } = new BlueprintType("", "Warhammer.SpaceCombat.Blueprints.BlueprintStarshipAmmo, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType StarshipBrain { get; } = new BlueprintType("", "Warhammer.SpaceCombat.AI.BlueprintStarshipBrain, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType StarshipSoundSettings { get; } = new BlueprintType("", "Warhammer.SpaceCombat.Blueprints.BlueprintStarshipSoundSettings, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType StarshipWeapon { get; } = new BlueprintType("", "Warhammer.SpaceCombat.Blueprints.BlueprintStarshipWeapon, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType StarSystemMap { get; } = new BlueprintType("", "Kingmaker.Globalmap.Blueprints.BlueprintStarSystemMap, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType StarSystemObject { get; } = new BlueprintType("", "Kingmaker.Globalmap.Blueprints.SystemMap.BlueprintStarSystemObject, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType StatProgression { get; } = new BlueprintType("", "Kingmaker.UnitLogic.Levelup.Obsolete.Blueprints.BlueprintStatProgression, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType SummonPool { get; } = new BlueprintType("", "Kingmaker.Blueprints.BlueprintSummonPool, RogueTrader.GameCore, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType SystemAnomaliesRoot { get; } = new BlueprintType("", "Kingmaker.Blueprints.Root.BlueprintSystemAnomaliesRoot, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType TimeOfDaySettings { get; } = new BlueprintType("", "Kingmaker.Visual.LightSelector.BlueprintTimeOfDaySettings, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType TrapSettings { get; } = new BlueprintType("", "Kingmaker.Blueprints.BlueprintTrapSettings, RogueTrader.GameCore, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType TrapSettingsRoot { get; } = new BlueprintType("", "Kingmaker.Blueprints.BlueprintTrapSettingsRoot, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType TrashLootSettings { get; } = new BlueprintType("", "Kingmaker.Blueprints.Loot.TrashLootSettings, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType TraumaRoot { get; } = new BlueprintType("", "Kingmaker.Blueprints.Root.BlueprintTraumaRoot, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType Tutorial { get; } = new BlueprintType("", "Kingmaker.Tutorial.BlueprintTutorial, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType UIConfig { get; } = new BlueprintType("", "Kingmaker.Blueprints.Root.UIConfig, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType UILocalMapLegend { get; } = new BlueprintType("", "Kingmaker.UI.Common.BlueprintUILocalMapLegend, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType UINetLobbyTutorial { get; } = new BlueprintType("", "Kingmaker.UI.Common.BlueprintUINetLobbyTutorial, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType UISound { get; } = new BlueprintType("", "Kingmaker.UI.Sound.BlueprintUISound, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType UIViewConfigs { get; } = new BlueprintType("", "Kingmaker.Blueprints.Root.UIViewConfigs, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType UnclotheRT { get; } = new BlueprintType("", "Kingmaker.AreaLogic.Cutscenes.Commands.UnclotheRT, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType Unit { get; } = new BlueprintType("", "Kingmaker.Blueprints.BlueprintUnit, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType UnitAsksList { get; } = new BlueprintType("", "Kingmaker.Visual.Sound.BlueprintUnitAsksList, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType UnitConditionBuffsRoot { get; } = new BlueprintType("", "Kingmaker.Blueprints.Root.SystemMechanics.UnitConditionBuffsRoot, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType UnitCustomizationPreset { get; } = new BlueprintType("", "Kingmaker.UnitLogic.Customization.UnitCustomizationPreset, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType UnitFact { get; } = new BlueprintType("", "Kingmaker.Blueprints.Facts.BlueprintUnitFact, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType UnitLoot { get; } = new BlueprintType("", "Kingmaker.Blueprints.Loot.BlueprintUnitLoot, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType UnitsList { get; } = new BlueprintType("", "Kingmaker.AreaLogic.TimeSurvival.BlueprintUnitsList, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType UnitType { get; } = new BlueprintType("", "Kingmaker.Blueprints.BlueprintUnitType, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType UnitVisualSettings { get; } = new BlueprintType("", "Kingmaker.UnitLogic.Visual.Blueprints.BlueprintUnitVisualSettings, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType UnlockableFlag { get; } = new BlueprintType("", "Kingmaker.Blueprints.BlueprintUnlockableFlag, RogueTrader.GameCore, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType VendorFaction { get; } = new BlueprintType("", "Kingmaker.Blueprints.BlueprintVendorFaction, RogueTrader.GameCore, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType VendorFactionsRoot { get; } = new BlueprintType("", "Kingmaker.Blueprints.Root.BlueprintVendorFactionsRoot, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType VoiceSelection { get; } = new BlueprintType("", "Kingmaker.UnitLogic.Levelup.Selections.Voice.BlueprintVoiceSelection, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType WaitFlag { get; } = new BlueprintType("", "Kingmaker.AreaLogic.Cutscenes.Commands.WaitFlag, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType WarhammerArmorType { get; } = new BlueprintType("", "Kingmaker.Blueprints.Items.Armors.BlueprintWarhammerArmorType, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType WarhammerRoot { get; } = new BlueprintType("", "Kingmaker.Blueprints.Root.BlueprintWarhammerRoot, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType WarpRoutesSettings { get; } = new BlueprintType("", "Kingmaker.Globalmap.Blueprints.SectorMap.BlueprintWarpRoutesSettings, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType WarpWeatherRoot { get; } = new BlueprintType("", "Kingmaker.Blueprints.Root.BlueprintWarpWeatherRoot, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType WeaponEnchantment { get; } = new BlueprintType("", "Kingmaker.Blueprints.Items.Ecnchantments.BlueprintWeaponEnchantment, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        public static BlueprintType WeaponType { get; } = new BlueprintType("", "Kingmaker.Blueprints.Items.Weapons.BlueprintWeaponType, Code, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");

        private static readonly Dictionary<string, BlueprintType> LookupFullName = new Dictionary<string, BlueprintType>(StringComparer.Ordinal) {
            {AbilitiesUnlockTable.FullName, AbilitiesUnlockTable},
            {Ability.FullName, Ability},
            {AbilityAdditionalEffect.FullName, AbilityAdditionalEffect},
            {AbilityAreaEffect.FullName, AbilityAreaEffect},
            {AbilityFXSettings.FullName, AbilityFXSettings},
            {AbilityGroup.FullName, AbilityGroup},
            {AbilityResource.FullName, AbilityResource},
            {AbilitySoundFXSettings.FullName, AbilitySoundFXSettings},
            {AbilityVisualFXSettings.FullName, AbilityVisualFXSettings},
            {AchievementData.FullName, AchievementData},
            {AchievementsRoot.FullName, AchievementsRoot},
            {ActionCameraSettings.FullName, ActionCameraSettings},
            {ActionsHolder.FullName, ActionsHolder},
            {ActivatableAbility.FullName, ActivatableAbility},
            {AnimationActionExternalHandler.FullName, AnimationActionExternalHandler},
            {Anomaly.FullName, Anomaly},
            {AnomalyGroupSpawnSettings.FullName, AnomalyGroupSpawnSettings},
            {Answer.FullName, Answer},
            {AnswersList.FullName, AnswersList},
            {ArbiterInstruction.FullName, ArbiterInstruction},
            {ArbiterRoot.FullName, ArbiterRoot},
            {Area.FullName, Area},
            {AreaEffectPitVisualSettings.FullName, AreaEffectPitVisualSettings},
            {AreaEnterPoint.FullName, AreaEnterPoint},
            {AreaMechanics.FullName, AreaMechanics},
            {AreaPart.FullName, AreaPart},
            {AreaPreset.FullName, AreaPreset},
            {AreaTransition.FullName, AreaTransition},
            {ArmorType.FullName, ArmorType},
            {ArmyDescription.FullName, ArmyDescription},
            {ArtificialObject.FullName, ArtificialObject},
            {Asteroid.FullName, Asteroid},
            {AstropathBrief.FullName, AstropathBrief},
            {AttackPattern.FullName, AttackPattern},
            {AttributeAdvancement.FullName, AttributeAdvancement},
            {BarkBanter.FullName, BarkBanter},
            {BarkBanterList.FullName, BarkBanterList},
            {BookPage.FullName, BookPage},
            {Brain.FullName, Brain},
            {Buff.FullName, Buff},
            {CameraFollowSettings.FullName, CameraFollowSettings},
            {CameraRecorderData.FullName, CameraRecorderData},
            {CameraRoot.FullName, CameraRoot},
            {CameraSettings.FullName, CameraSettings},
            {CareerPath.FullName, CareerPath},
            {Cargo.FullName, Cargo},
            {CargoRoot.FullName, CargoRoot},
            {CategoryDefaults.FullName, CategoryDefaults},
            {CharacterClass.FullName, CharacterClass},
            {CharacterNameSelection.FullName, CharacterNameSelection},
            {CharGenRoot.FullName, CharGenRoot},
            {Check.FullName, Check},
            {Colony.FullName, Colony},
            {ColonyChronicle.FullName, ColonyChronicle},
            {ColonyEvent.FullName, ColonyEvent},
            {ColonyEventResult.FullName, ColonyEventResult},
            {ColonyEventsRoot.FullName, ColonyEventsRoot},
            {ColonyProject.FullName, ColonyProject},
            {ColonyRoot.FullName, ColonyRoot},
            {ColonyTrait.FullName, ColonyTrait},
            {CombatRandomEncountersRoot.FullName, CombatRandomEncountersRoot},
            {CombatRoot.FullName, CombatRoot},
            {CommandAction.FullName, CommandAction},
            {CommandActivateGate.FullName, CommandActivateGate},
            {CommandAddFogOfWarRevealer.FullName, CommandAddFogOfWarRevealer},
            {CommandAttachBuffSpan.FullName, CommandAttachBuffSpan},
            {CommandBark.FullName, CommandBark},
            {CommandCameraFollow.FullName, CommandCameraFollow},
            {CommandCameraShake.FullName, CommandCameraShake},
            {CommandControlCamera.FullName, CommandControlCamera},
            {CommandCrossfadeToIdle.FullName, CommandCrossfadeToIdle},
            {CommandCustomeCutsceneController.FullName, CommandCustomeCutsceneController},
            {CommandDefaultTeleport.FullName, CommandDefaultTeleport},
            {CommandDelay.FullName, CommandDelay},
            {CommandFadeout.FullName, CommandFadeout},
            {CommandIgnoreCombat.FullName, CommandIgnoreCombat},
            {CommandMarkHiddenSpan.FullName, CommandMarkHiddenSpan},
            {CommandMarkOnElevatorSpan.FullName, CommandMarkOnElevatorSpan},
            {CommandMarkPartyHiddenSpan.FullName, CommandMarkPartyHiddenSpan},
            {CommandMarkPartyOnElevatorSpan.FullName, CommandMarkPartyOnElevatorSpan},
            {CommandMarkUnitControlled.FullName, CommandMarkUnitControlled},
            {CommandMarkUntargetableSpan.FullName, CommandMarkUntargetableSpan},
            {CommandMoveCamera.FullName, CommandMoveCamera},
            {CommandMoveParty.FullName, CommandMoveParty},
            {CommandMoveUnit.FullName, CommandMoveUnit},
            {CommandPlayTimeline.FullName, CommandPlayTimeline},
            {CommandPlayVideo.FullName, CommandPlayVideo},
            {CommandSaveFogOfWar.FullName, CommandSaveFogOfWar},
            {CommandSetCombatMode.FullName, CommandSetCombatMode},
            {CommandSkipTime.FullName, CommandSkipTime},
            {CommandStartDialog.FullName, CommandStartDialog},
            {CommandStopUnit.FullName, CommandStopUnit},
            {CommandSwitchDoor.FullName, CommandSwitchDoor},
            {CommandTeleport.FullName, CommandTeleport},
            {CommandTranslocateParty.FullName, CommandTranslocateParty},
            {CommandUnitAnimationCoverBlocker.FullName, CommandUnitAnimationCoverBlocker},
            {CommandUnitAttack.FullName, CommandUnitAttack},
            {CommandUnitCastSpell.FullName, CommandUnitCastSpell},
            {CommandUnitLookAt.FullName, CommandUnitLookAt},
            {CommandUnitPlayCutsceneAnimation.FullName, CommandUnitPlayCutsceneAnimation},
            {CommandWaitForCombatEnd.FullName, CommandWaitForCombatEnd},
            {CompanionStory.FullName, CompanionStory},
            {ComponentList.FullName, ComponentList},
            {ConditionsHolder.FullName, ConditionsHolder},
            {ConsoleRoot.FullName, ConsoleRoot},
            {CreditsGroup.FullName, CreditsGroup},
            {CreditsRoles.FullName, CreditsRoles},
            {CreditsTeams.FullName, CreditsTeams},
            {Cue.FullName, Cue},
            {CueSequence.FullName, CueSequence},
            {Cutscene.FullName, Cutscene},
            {CutscenesRoot.FullName, CutscenesRoot},
            {DamageSkillCheckRoot.FullName, DamageSkillCheckRoot},
            {DebuffSkillCheckRoot.FullName, DebuffSkillCheckRoot},
            {DestructibleObject.FullName, DestructibleObject},
            {DestructibleObjectsRoot.FullName, DestructibleObjectsRoot},
            {Dialog.FullName, Dialog},
            {DifficultyRoot.FullName, DifficultyRoot},
            {DismembermentRoot.FullName, DismembermentRoot},
            {Dlc.FullName, Dlc},
            {DlcReward.FullName, DlcReward},
            {DynamicMapObject.FullName, DynamicMapObject},
            {EncyclopediaAstropathBriefPage.FullName, EncyclopediaAstropathBriefPage},
            {EncyclopediaBookEventPage.FullName, EncyclopediaBookEventPage},
            {EncyclopediaChapter.FullName, EncyclopediaChapter},
            {EncyclopediaGlossaryChapter.FullName, EncyclopediaGlossaryChapter},
            {EncyclopediaGlossaryEntry.FullName, EncyclopediaGlossaryEntry},
            {EncyclopediaPage.FullName, EncyclopediaPage},
            {EncyclopediaPlanetTypePage.FullName, EncyclopediaPlanetTypePage},
            {EnumUnitSubtypeIcons.FullName, EnumUnitSubtypeIcons},
            {EquipmentEnchantment.FullName, EquipmentEnchantment},
            {Etude.FullName, Etude},
            {EtudeConflictingGroup.FullName, EtudeConflictingGroup},
            {Faction.FullName, Faction},
            {FamiliarsRoot.FullName, FamiliarsRoot},
            {Feature.FullName, Feature},
            {FeatureSelection_Obsolete.FullName, FeatureSelection_Obsolete},
            {FollowersFormation.FullName, FollowersFormation},
            {FormationsRoot.FullName, FormationsRoot},
            {FxLocatorGroup.FullName, FxLocatorGroup},
            {FxRoot.FullName, FxRoot},
            {GamePadTexts.FullName, GamePadTexts},
            {Gate.FullName, Gate},
            {GenderSelection.FullName, GenderSelection},
            {HitSystemRoot.FullName, HitSystemRoot},
            {InteractionRoot.FullName, InteractionRoot},
            {InteractionVariantVisualSetsBlueprint.FullName, InteractionVariantVisualSetsBlueprint},
            {Item.FullName, Item},
            {ItemArmor.FullName, ItemArmor},
            {ItemArmorPlating.FullName, ItemArmorPlating},
            {ItemAugerArray.FullName, ItemAugerArray},
            {ItemEquipmentFeet.FullName, ItemEquipmentFeet},
            {ItemEquipmentGloves.FullName, ItemEquipmentGloves},
            {ItemEquipmentHead.FullName, ItemEquipmentHead},
            {ItemEquipmentNeck.FullName, ItemEquipmentNeck},
            {ItemEquipmentRing.FullName, ItemEquipmentRing},
            {ItemEquipmentShoulders.FullName, ItemEquipmentShoulders},
            {ItemEquipmentUsable.FullName, ItemEquipmentUsable},
            {ItemKey.FullName, ItemKey},
            {ItemLifeSustainer.FullName, ItemLifeSustainer},
            {ItemMechadendrite.FullName, ItemMechadendrite},
            {ItemNote.FullName, ItemNote},
            {ItemPlasmaDrives.FullName, ItemPlasmaDrives},
            {ItemResourceMiner.FullName, ItemResourceMiner},
            {ItemsList.FullName, ItemsList},
            {ItemsStash.FullName, ItemsStash},
            {ItemVoidShieldGenerator.FullName, ItemVoidShieldGenerator},
            {ItemWeapon.FullName, ItemWeapon},
            {KingmakerEquipmentEntity.FullName, KingmakerEquipmentEntity},
            {Loot.FullName, Loot},
            {MechanicEntityFact.FullName, MechanicEntityFact},
            {Meteor.FullName, Meteor},
            {MeteorStream.FullName, MeteorStream},
            {MomentumGroup.FullName, MomentumGroup},
            {MomentumRoot.FullName, MomentumRoot},
            {MultiEntrance.FullName, MultiEntrance},
            {MultiEntranceEntry.FullName, MultiEntranceEntry},
            {MythicInfo.FullName, MythicInfo},
            {MythicsSettings.FullName, MythicsSettings},
            {NodeLinkRoot.FullName, NodeLinkRoot},
            {OriginPath.FullName, OriginPath},
            {PartsCargo.FullName, PartsCargo},
            {PartyFormation.FullName, PartyFormation},
            {Planet.FullName, Planet},
            {PlanetPrefab.FullName, PlanetPrefab},
            {PlanetSettingsRoot.FullName, PlanetSettingsRoot},
            {PlayerUpgradeActionsRoot.FullName, PlayerUpgradeActionsRoot},
            {PlayerUpgrader.FullName, PlayerUpgrader},
            {PointOfInterestBookEvent.FullName, PointOfInterestBookEvent},
            {PointOfInterestCargo.FullName, PointOfInterestCargo},
            {PointOfInterestColonyTrait.FullName, PointOfInterestColonyTrait},
            {PointOfInterestExpedition.FullName, PointOfInterestExpedition},
            {PointOfInterestGroundOperation.FullName, PointOfInterestGroundOperation},
            {PointOfInterestLoot.FullName, PointOfInterestLoot},
            {PointOfInterestResources.FullName, PointOfInterestResources},
            {PointOfInterestStatCheckLoot.FullName, PointOfInterestStatCheckLoot},
            {Portrait.FullName, Portrait},
            {PortraitSelection.FullName, PortraitSelection},
            {PostProcessingEffectsLibrary.FullName, PostProcessingEffectsLibrary},
            {ProfitFactorRoot.FullName, ProfitFactorRoot},
            {Progression.FullName, Progression},
            {Projectile.FullName, Projectile},
            {ProjectileTrajectory.FullName, ProjectileTrajectory},
            {PropertyCalculatorBlueprint.FullName, PropertyCalculatorBlueprint},
            {PSNObjectsRoot.FullName, PSNObjectsRoot},
            {PsychicPhenomenaRoot.FullName, PsychicPhenomenaRoot},
            {PushSettingRoot.FullName, PushSettingRoot},
            {Quest.FullName, Quest},
            {QuestContract.FullName, QuestContract},
            {QuestGroups.FullName, QuestGroups},
            {QuestObjective.FullName, QuestObjective},
            {Race.FullName, Race},
            {RaceGenderDistribution.FullName, RaceGenderDistribution},
            {RaceVisualPreset.FullName, RaceVisualPreset},
            {RandomGroupOfUnits.FullName, RandomGroupOfUnits},
            {Resource.FullName, Resource},
            {RestrictionsHolder.FullName, RestrictionsHolder},
            {Root.FullName, Root},
            {ScrapRoot.FullName, ScrapRoot},
            {ScriptZone.FullName, ScriptZone},
            {SectorMapArea.FullName, SectorMapArea},
            {SectorMapPoint.FullName, SectorMapPoint},
            {SectorMapPointStarSystem.FullName, SectorMapPointStarSystem},
            {SelectionDoll.FullName, SelectionDoll},
            {SelectionFeature.FullName, SelectionFeature},
            {SelectionShip.FullName, SelectionShip},
            {SequenceExit.FullName, SequenceExit},
            {SharedVendorTable.FullName, SharedVendorTable},
            {ShipComponentsUnlockTable.FullName, ShipComponentsUnlockTable},
            {ShipPostExpertise.FullName, ShipPostExpertise},
            {ShipSystemComponent.FullName, ShipSystemComponent},
            {SkillAdvancement.FullName, SkillAdvancement},
            {SkillCheckRoot.FullName, SkillCheckRoot},
            {SoulMark.FullName, SoulMark},
            {SoulMarksRoot.FullName, SoulMarksRoot},
            {SoundRagdollSettings.FullName, SoundRagdollSettings},
            {SpaceCombatArea.FullName, SpaceCombatArea},
            {SpawnersList.FullName, SpawnersList},
            {StackingUnitProperty.FullName, StackingUnitProperty},
            {Star.FullName, Star},
            {Starship.FullName, Starship},
            {StarshipAmmo.FullName, StarshipAmmo},
            {StarshipBrain.FullName, StarshipBrain},
            {StarshipSoundSettings.FullName, StarshipSoundSettings},
            {StarshipWeapon.FullName, StarshipWeapon},
            {StarSystemMap.FullName, StarSystemMap},
            {StarSystemObject.FullName, StarSystemObject},
            {StatProgression.FullName, StatProgression},
            {SummonPool.FullName, SummonPool},
            {SystemAnomaliesRoot.FullName, SystemAnomaliesRoot},
            {TimeOfDaySettings.FullName, TimeOfDaySettings},
            {TrapSettings.FullName, TrapSettings},
            {TrapSettingsRoot.FullName, TrapSettingsRoot},
            {TrashLootSettings.FullName, TrashLootSettings},
            {TraumaRoot.FullName, TraumaRoot},
            {Tutorial.FullName, Tutorial},
            {UIConfig.FullName, UIConfig},
            {UILocalMapLegend.FullName, UILocalMapLegend},
            {UINetLobbyTutorial.FullName, UINetLobbyTutorial},
            {UISound.FullName, UISound},
            {UIViewConfigs.FullName, UIViewConfigs},
            {UnclotheRT.FullName, UnclotheRT},
            {Unit.FullName, Unit},
            {UnitAsksList.FullName, UnitAsksList},
            {UnitConditionBuffsRoot.FullName, UnitConditionBuffsRoot},
            {UnitCustomizationPreset.FullName, UnitCustomizationPreset},
            {UnitFact.FullName, UnitFact},
            {UnitLoot.FullName, UnitLoot},
            {UnitsList.FullName, UnitsList},
            {UnitType.FullName, UnitType},
            {UnitVisualSettings.FullName, UnitVisualSettings},
            {UnlockableFlag.FullName, UnlockableFlag},
            {VendorFaction.FullName, VendorFaction},
            {VendorFactionsRoot.FullName, VendorFactionsRoot},
            {VoiceSelection.FullName, VoiceSelection},
            {WaitFlag.FullName, WaitFlag},
            {WarhammerArmorType.FullName, WarhammerArmorType},
            {WarhammerRoot.FullName, WarhammerRoot},
            {WarpRoutesSettings.FullName, WarpRoutesSettings},
            {WarpWeatherRoot.FullName, WarpWeatherRoot},
            {WeaponEnchantment.FullName, WeaponEnchantment},
            {WeaponType.FullName, WeaponType}
        };

        private static readonly Dictionary<BlueprintTypeId, BlueprintType> LookupId = new Dictionary<BlueprintTypeId, BlueprintType> {
            {BlueprintTypeId.UnitAsksList, UnitAsksList},
            {BlueprintTypeId.Portrait, Portrait},
            {BlueprintTypeId.Ability, Ability},
            {BlueprintTypeId.Item, Item},
            {BlueprintTypeId.ItemEquipmentHead, ItemEquipmentHead},
            {BlueprintTypeId.ItemEquipmentNeck, ItemEquipmentNeck},
            {BlueprintTypeId.ItemArmor, ItemArmor},
            {BlueprintTypeId.ItemEquipmentShoulders, ItemEquipmentShoulders},
            {BlueprintTypeId.ItemEquipmentRing, ItemEquipmentRing},
            {BlueprintTypeId.ItemEquipmentGloves, ItemEquipmentGloves},
            {BlueprintTypeId.ItemEquipmentFeet, ItemEquipmentFeet},
            {BlueprintTypeId.ItemWeapon, ItemWeapon},
            {BlueprintTypeId.ItemEquipmentUsable, ItemEquipmentUsable},
            {BlueprintTypeId.Feature, Feature},
            {BlueprintTypeId.Etude, Etude},
            {BlueprintTypeId.UnlockableFlag, UnlockableFlag},
            {BlueprintTypeId.RaceVisualPreset, RaceVisualPreset},
            {BlueprintTypeId.Unit, Unit},
            {BlueprintTypeId.AbilityResource, AbilityResource},
        };
    }
}