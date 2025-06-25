using System;
using System.Collections.Generic;
using RimWorld;
using RimWorld.QuestGen;
using RimWorld.Planet;
using UnityEngine;
using Verse;

namespace RimworldSLP_MorePermits
{
	public class RoyalTitlePermitWorker_SLP_CallTroopers : RoyalTitlePermitWorker
	{
		public override IEnumerable<FloatMenuOption> GetRoyalAidOptions(Map map, Pawn pawn, Faction faction)
		{
			RoyalTitlePermitWorker_SLP_CallTroopers workerCallTroopers = this;
			string reason;
			if (workerCallTroopers.AidDisabled(map, pawn, faction, out reason))
			{
				yield return new FloatMenuOption((string)(workerCallTroopers.def.LabelCap + ": " + reason), (Action)null);
			}
			else
			{
				Action action = (Action)null;
				string description = (string)(workerCallTroopers.def.LabelCap + " (" + "CommandCallTroopersNumTroopers".Translate((NamedArgument)workerCallTroopers.def.royalAid.pawnCount) + "): ");
				bool free;
				if (workerCallTroopers.FillAidOption(pawn, faction, ref description, out free))
					action = (Action)(() => this.SLPCallTroopers(pawn, map, faction, free));
				yield return new FloatMenuOption(description, action, faction.def.FactionIcon, faction.Color);
			}
		}

		private void SLPCallTroopers(Pawn pawn, Map map, Faction faction, bool free)
		{
			if (faction.HostileTo(Faction.OfPlayer))
			{
				return;
			}
			QuestScriptDef Permit_SLP_CallTroopers = QuestScriptDefOfSLP.Permit_SLP_CallTroopers;
			Slate slate = new Slate();
			slate.Set<Map>("map", map, false);
			slate.Set<int>("laborersCount", this.def.royalAid.pawnCount, false);
			slate.Set<Faction>("permitFaction", faction, false);
			slate.Set<PawnKindDef>("laborersPawnKind", this.def.royalAid.pawnKindDef, false);
			slate.Set<float>("laborersDurationDays", this.def.royalAid.aidDurationDays, false);
			QuestUtility.GenerateQuestAndMakeAvailable(Permit_SLP_CallTroopers, slate);
			pawn.royalty.GetPermit(this.def, faction).Notify_Used();
			if (!free)
			{
				pawn.royalty.TryRemoveFavor(faction, this.def.royalAid.favorCost);
			}
		}
	}

	public class RoyalTitlePermitWorker_SLP_CallJanissary : RoyalTitlePermitWorker
	{
		public override IEnumerable<FloatMenuOption> GetRoyalAidOptions(Map map, Pawn pawn, Faction faction)
		{
			RoyalTitlePermitWorker_SLP_CallJanissary workerCallJTroopers = this;
			string reason;
			if (workerCallJTroopers.AidDisabled(map, pawn, faction, out reason))
			{
				yield return new FloatMenuOption((string)(workerCallJTroopers.def.LabelCap + ": " + reason), (Action)null);
			}
			else
			{
				Action action = (Action)null;
				string description = (string)(workerCallJTroopers.def.LabelCap + " (" + "CommandCallJanissariesNumJanissaries".Translate((NamedArgument)workerCallJTroopers.def.royalAid.pawnCount) + "): ");
				bool free;
				if (workerCallJTroopers.FillAidOption(pawn, faction, ref description, out free))
					action = (Action)(() => this.SLPCallJanissary(pawn, map, faction, free));
				yield return new FloatMenuOption(description, action, faction.def.FactionIcon, faction.Color);
			}
		}

		private void SLPCallJanissary(Pawn pawn, Map map, Faction faction, bool free)
		{
			if (faction.HostileTo(Faction.OfPlayer))
			{
				return;
			}
			QuestScriptDef Permit_SLP_CallJanissary = QuestScriptDefOfSLP.Permit_SLP_CallJanissary;
			Slate slate = new Slate();
			slate.Set<Map>("map", map, false);
			slate.Set<int>("laborersCount", this.def.royalAid.pawnCount, false);
			slate.Set<Faction>("permitFaction", faction, false);
			slate.Set<PawnKindDef>("laborersPawnKind", this.def.royalAid.pawnKindDef, false);
			slate.Set<float>("laborersDurationDays", this.def.royalAid.aidDurationDays, false);
			QuestUtility.GenerateQuestAndMakeAvailable(Permit_SLP_CallJanissary, slate);
			pawn.royalty.GetPermit(this.def, faction).Notify_Used();
			if (!free)
			{
				pawn.royalty.TryRemoveFavor(faction, this.def.royalAid.favorCost);
			}
		}
	}

	public class RoyalTitlePermitWorker_SLP_CallCataphract : RoyalTitlePermitWorker
	{
		public override IEnumerable<FloatMenuOption> GetRoyalAidOptions(Map map, Pawn pawn, Faction faction)
		{
			RoyalTitlePermitWorker_SLP_CallCataphract workerCallCTroopers = this;
			string reason;
			if (workerCallCTroopers.AidDisabled(map, pawn, faction, out reason))
			{
				yield return new FloatMenuOption((string)(workerCallCTroopers.def.LabelCap + ": " + reason), (Action)null);
			}
			else
			{
				Action action = (Action)null;
				string description = (string)(workerCallCTroopers.def.LabelCap + " (" + "CommandCallCataphractsNumCataphracts".Translate((NamedArgument)workerCallCTroopers.def.royalAid.pawnCount) + "): ");
				bool free;
				if (workerCallCTroopers.FillAidOption(pawn, faction, ref description, out free))
					action = (Action)(() => this.SLPCallCataphract(pawn, map, faction, free));
				yield return new FloatMenuOption(description, action, faction.def.FactionIcon, faction.Color);
			}
		}

		private void SLPCallCataphract(Pawn pawn, Map map, Faction faction, bool free)
		{
			if (faction.HostileTo(Faction.OfPlayer))
			{
				return;
			}
			QuestScriptDef Permit_SLP_CallCataphract = QuestScriptDefOfSLP.Permit_SLP_CallCataphract;
			Slate slate = new Slate();
			slate.Set<Map>("map", map, false);
			slate.Set<int>("laborersCount", this.def.royalAid.pawnCount, false);
			slate.Set<Faction>("permitFaction", faction, false);
			slate.Set<PawnKindDef>("laborersPawnKind", this.def.royalAid.pawnKindDef, false);
			slate.Set<float>("laborersDurationDays", this.def.royalAid.aidDurationDays, false);
			QuestUtility.GenerateQuestAndMakeAvailable(Permit_SLP_CallCataphract, slate);
			pawn.royalty.GetPermit(this.def, faction).Notify_Used();
			if (!free)
			{
				pawn.royalty.TryRemoveFavor(faction, this.def.royalAid.favorCost);
			}
		}
	}

	public class RoyalTitlePermitWorker_SLP_CallStellicGuardMelee : RoyalTitlePermitWorker
	{
		public override IEnumerable<FloatMenuOption> GetRoyalAidOptions(Map map, Pawn pawn, Faction faction)
		{
			RoyalTitlePermitWorker_SLP_CallStellicGuardMelee workerCallSGMTroopers = this;
			string reason;
			if (workerCallSGMTroopers.AidDisabled(map, pawn, faction, out reason))
			{
				yield return new FloatMenuOption((string)(workerCallSGMTroopers.def.LabelCap + ": " + reason), (Action)null);
			}
			else
			{
				Action action = (Action)null;
				string description = (string)(workerCallSGMTroopers.def.LabelCap + " (" + "CommandCallStellicMGNumStellicMG".Translate((NamedArgument)workerCallSGMTroopers.def.royalAid.pawnCount) + "): ");
				bool free;
				if (workerCallSGMTroopers.FillAidOption(pawn, faction, ref description, out free))
					action = (Action)(() => this.CallStellicGuardMelee(pawn, map, faction, free));
				yield return new FloatMenuOption(description, action, faction.def.FactionIcon, faction.Color);
			}
		}

		private void CallStellicGuardMelee(Pawn pawn, Map map, Faction faction, bool free)
		{
			if (faction.HostileTo(Faction.OfPlayer))
			{
				return;
			}
			QuestScriptDef Permit_SLP_CallStellicGuardMelee = QuestScriptDefOfSLP.Permit_SLP_CallStellicGuardMelee;
			Slate slate = new Slate();
			slate.Set<Map>("map", map, false);
			slate.Set<int>("laborersCount", this.def.royalAid.pawnCount, false);
			slate.Set<Faction>("permitFaction", faction, false);
			slate.Set<PawnKindDef>("laborersPawnKind", this.def.royalAid.pawnKindDef, false);
			slate.Set<float>("laborersDurationDays", this.def.royalAid.aidDurationDays, false);
			QuestUtility.GenerateQuestAndMakeAvailable(Permit_SLP_CallStellicGuardMelee, slate);
			pawn.royalty.GetPermit(this.def, faction).Notify_Used();
			if (!free)
			{
				pawn.royalty.TryRemoveFavor(faction, this.def.royalAid.favorCost);
			}
		}
	}

	public class RoyalTitlePermitWorker_SLP_CallStellicGuardRanged : RoyalTitlePermitWorker
	{
		public override IEnumerable<FloatMenuOption> GetRoyalAidOptions(Map map, Pawn pawn, Faction faction)
		{
			RoyalTitlePermitWorker_SLP_CallStellicGuardRanged workerCallSGRTroopers = this;
			string reason;
			if (workerCallSGRTroopers.AidDisabled(map, pawn, faction, out reason))
			{
				yield return new FloatMenuOption((string)(workerCallSGRTroopers.def.LabelCap + ": " + reason), (Action)null);
			}
			else
			{
				Action action = (Action)null;
				string description = (string)(workerCallSGRTroopers.def.LabelCap + " (" + "CommandCallStellicRGNumStellicRG".Translate((NamedArgument)workerCallSGRTroopers.def.royalAid.pawnCount) + "): ");
				bool free;
				if (workerCallSGRTroopers.FillAidOption(pawn, faction, ref description, out free))
					action = (Action)(() => this.CallStellicGuardRanged(pawn, map, faction, free));
				yield return new FloatMenuOption(description, action, faction.def.FactionIcon, faction.Color);
			}
		}

		private void CallStellicGuardRanged(Pawn pawn, Map map, Faction faction, bool free)
		{
			if (faction.HostileTo(Faction.OfPlayer))
			{
				return;
			}
			QuestScriptDef Permit_SLP_CallStellicGuardRanged = QuestScriptDefOfSLP.Permit_SLP_CallStellicGuardRanged;
			Slate slate = new Slate();
			slate.Set<Map>("map", map, false);
			slate.Set<int>("laborersCount", this.def.royalAid.pawnCount, false);
			slate.Set<Faction>("permitFaction", faction, false);
			slate.Set<PawnKindDef>("laborersPawnKind", this.def.royalAid.pawnKindDef, false);
			slate.Set<float>("laborersDurationDays", this.def.royalAid.aidDurationDays, false);
			QuestUtility.GenerateQuestAndMakeAvailable(Permit_SLP_CallStellicGuardRanged, slate);
			pawn.royalty.GetPermit(this.def, faction).Notify_Used();
			if (!free)
			{
				pawn.royalty.TryRemoveFavor(faction, this.def.royalAid.favorCost);
			}
		}
	}

	public class RoyalTitlePermitWorker_SLP_CallChampions : RoyalTitlePermitWorker
	{
		public override IEnumerable<FloatMenuOption> GetRoyalAidOptions(Map map, Pawn pawn, Faction faction)
		{
			RoyalTitlePermitWorker_SLP_CallChampions workerCallChampTroopers = this;
			string reason;
			if (workerCallChampTroopers.AidDisabled(map, pawn, faction, out reason))
			{
				yield return new FloatMenuOption((string)(workerCallChampTroopers.def.LabelCap + ": " + reason), (Action)null);
			}
			else
			{
				Action action = (Action)null;
				string description = (string)(workerCallChampTroopers.def.LabelCap + " (" + "CommandCallNumChampions".Translate((NamedArgument)workerCallChampTroopers.def.royalAid.pawnCount) + "): ");
				bool free;
				if (workerCallChampTroopers.FillAidOption(pawn, faction, ref description, out free))
					action = (Action)(() => this.SLPCallChampions(pawn, map, faction, free));
				yield return new FloatMenuOption(description, action, faction.def.FactionIcon, faction.Color);
			}
		}

		private void SLPCallChampions(Pawn pawn, Map map, Faction faction, bool free)
		{
			if (faction.HostileTo(Faction.OfPlayer))
			{
				return;
			}
			QuestScriptDef Permit_SLP_CallChampions = QuestScriptDefOfSLP.Permit_SLP_CallChampions;
			Slate slate = new Slate();
			slate.Set<Map>("map", map, false);
			slate.Set<int>("laborersCount", this.def.royalAid.pawnCount, false);
			slate.Set<Faction>("permitFaction", faction, false);
			slate.Set<PawnKindDef>("laborersPawnKind", this.def.royalAid.pawnKindDef, false);
			slate.Set<float>("laborersDurationDays", this.def.royalAid.aidDurationDays, false);
			QuestUtility.GenerateQuestAndMakeAvailable(Permit_SLP_CallChampions, slate);
			pawn.royalty.GetPermit(this.def, faction).Notify_Used();
			if (!free)
			{
				pawn.royalty.TryRemoveFavor(faction, this.def.royalAid.favorCost);
			}
		}
	}

	public class RoyalTitlePermitWorker_SLP_CallParamedics : RoyalTitlePermitWorker
	{
		public override IEnumerable<FloatMenuOption> GetRoyalAidOptions(Map map, Pawn pawn, Faction faction)
		{
			RoyalTitlePermitWorker_SLP_CallParamedics workerCallParaCTroopers = this;
			string reason;
			if (workerCallParaCTroopers.AidDisabled(map, pawn, faction, out reason))
			{
				yield return new FloatMenuOption((string)(workerCallParaCTroopers.def.LabelCap + ": " + reason), (Action)null);
			}
			else
			{
				Action action = (Action)null;
				string description = (string)(workerCallParaCTroopers.def.LabelCap + " (" + "CommandCallNumParamedics".Translate((NamedArgument)workerCallParaCTroopers.def.royalAid.pawnCount) + "): ");
				bool free;
				if (workerCallParaCTroopers.FillAidOption(pawn, faction, ref description, out free))
					action = (Action)(() => this.SLPCallParamedics(pawn, map, faction, free));
				yield return new FloatMenuOption(description, action, faction.def.FactionIcon, faction.Color);
			}
		}

		private void SLPCallParamedics(Pawn pawn, Map map, Faction faction, bool free)
		{
			if (faction.HostileTo(Faction.OfPlayer))
			{
				return;
			}
			QuestScriptDef Permit_SLP_CallParamedics = QuestScriptDefOfSLP.Permit_SLP_CallParamedics;
			Slate slate = new Slate();
			slate.Set<Map>("map", map, false);
			slate.Set<int>("laborersCount", this.def.royalAid.pawnCount, false);
			slate.Set<Faction>("permitFaction", faction, false);
			slate.Set<PawnKindDef>("laborersPawnKind", this.def.royalAid.pawnKindDef, false);
			slate.Set<float>("laborersDurationDays", this.def.royalAid.aidDurationDays, false);
			QuestUtility.GenerateQuestAndMakeAvailable(Permit_SLP_CallParamedics, slate);
			pawn.royalty.GetPermit(this.def, faction).Notify_Used();
			if (!free)
			{
				pawn.royalty.TryRemoveFavor(faction, this.def.royalAid.favorCost);
			}
		}
	}

	public class RoyalTitlePermitWorker_SLP_CallCombatParamedics : RoyalTitlePermitWorker
	{
		public override IEnumerable<FloatMenuOption> GetRoyalAidOptions(Map map, Pawn pawn, Faction faction)
		{
			RoyalTitlePermitWorker_SLP_CallCombatParamedics workerCallParaSoTroopers = this;
			string reason;
			if (workerCallParaSoTroopers.AidDisabled(map, pawn, faction, out reason))
			{
				yield return new FloatMenuOption((string)(workerCallParaSoTroopers.def.LabelCap + ": " + reason), (Action)null);
			}
			else
			{
				Action action = (Action)null;
				string description = (string)(workerCallParaSoTroopers.def.LabelCap + " (" + "CommandCallNumCombatParamedics".Translate((NamedArgument)workerCallParaSoTroopers.def.royalAid.pawnCount) + "): ");
				bool free;
				if (workerCallParaSoTroopers.FillAidOption(pawn, faction, ref description, out free))
					action = (Action)(() => this.SLPCallCombatParamedics(pawn, map, faction, free));
				yield return new FloatMenuOption(description, action, faction.def.FactionIcon, faction.Color);
			}
		}

		private void SLPCallCombatParamedics(Pawn pawn, Map map, Faction faction, bool free)
		{
			if (faction.HostileTo(Faction.OfPlayer))
			{
				return;
			}
			QuestScriptDef Permit_SLP_CallCombatParamedics = QuestScriptDefOfSLP.Permit_SLP_CallCombatParamedics;
			Slate slate = new Slate();
			slate.Set<Map>("map", map, false);
			slate.Set<int>("laborersCount", this.def.royalAid.pawnCount, false);
			slate.Set<Faction>("permitFaction", faction, false);
			slate.Set<PawnKindDef>("laborersPawnKind", this.def.royalAid.pawnKindDef, false);
			slate.Set<float>("laborersDurationDays", this.def.royalAid.aidDurationDays, false);
			QuestUtility.GenerateQuestAndMakeAvailable(Permit_SLP_CallCombatParamedics, slate);
			pawn.royalty.GetPermit(this.def, faction).Notify_Used();
			if (!free)
			{
				pawn.royalty.TryRemoveFavor(faction, this.def.royalAid.favorCost);
			}
		}
	}

	public class RoyalTitlePermitWorker_SLP_CallSurgeons : RoyalTitlePermitWorker
	{
		public override IEnumerable<FloatMenuOption> GetRoyalAidOptions(Map map, Pawn pawn, Faction faction)
		{
			RoyalTitlePermitWorker_SLP_CallSurgeons workerCallParaSuTroopers = this;
			string reason;
			if (workerCallParaSuTroopers.AidDisabled(map, pawn, faction, out reason))
			{
				yield return new FloatMenuOption((string)(workerCallParaSuTroopers.def.LabelCap + ": " + reason), (Action)null);
			}
			else
			{
				Action action = (Action)null;
				string description = (string)(workerCallParaSuTroopers.def.LabelCap + " (" + "CommandCallNumSurgeons".Translate((NamedArgument)workerCallParaSuTroopers.def.royalAid.pawnCount) + "): ");
				bool free;
				if (workerCallParaSuTroopers.FillAidOption(pawn, faction, ref description, out free))
					action = (Action)(() => this.SLPCallSurgeons(pawn, map, faction, free));
				yield return new FloatMenuOption(description, action, faction.def.FactionIcon, faction.Color);
			}
		}

		private void SLPCallSurgeons(Pawn pawn, Map map, Faction faction, bool free)
		{
			if (faction.HostileTo(Faction.OfPlayer))
			{
				return;
			}
			QuestScriptDef Permit_SLP_CallSurgeons = QuestScriptDefOfSLP.Permit_SLP_CallSurgeons;
			Slate slate = new Slate();
			slate.Set<Map>("map", map, false);
			slate.Set<int>("laborersCount", this.def.royalAid.pawnCount, false);
			slate.Set<Faction>("permitFaction", faction, false);
			slate.Set<PawnKindDef>("laborersPawnKind", this.def.royalAid.pawnKindDef, false);
			slate.Set<float>("laborersDurationDays", this.def.royalAid.aidDurationDays, false);
			QuestUtility.GenerateQuestAndMakeAvailable(Permit_SLP_CallSurgeons, slate);
			pawn.royalty.GetPermit(this.def, faction).Notify_Used();
			if (!free)
			{
				pawn.royalty.TryRemoveFavor(faction, this.def.royalAid.favorCost);
			}
		}
	}

	public class RoyalTitlePermitWorker_SLP_CallAlpineRangers: RoyalTitlePermitWorker
	{
		public override IEnumerable<FloatMenuOption> GetRoyalAidOptions(Map map, Pawn pawn, Faction faction)
		{
			RoyalTitlePermitWorker_SLP_CallAlpineRangers workerCallAlpineRangers = this;
			string reason;
			if (workerCallAlpineRangers.SLP_AidDisabled(map, pawn, faction, out reason))
			{
				yield return new FloatMenuOption((string)(workerCallAlpineRangers.def.LabelCap + ": " + reason), (Action)null);
			}
			else
			{
				Action action = (Action)null;
				string description = (string)(workerCallAlpineRangers.def.LabelCap + " (" + "CommandCallAlpineNumAlpine".Translate((NamedArgument)workerCallAlpineRangers.def.royalAid.pawnCount) + "): ");
				bool free;
				if (workerCallAlpineRangers.FillAidOption(pawn, faction, ref description, out free))
					action = (Action)(() => this.SLPCallAplineRanger(pawn, map, faction, free));
				yield return new FloatMenuOption(description, action, faction.def.FactionIcon, faction.Color);
			}
		}

		protected virtual bool SLP_AidDisabled(Map map, Pawn pawn, Faction faction, out string reason)
		{
			if (faction.HostileTo(Faction.OfPlayer))
			{
				reason = (string)"CommandCallRoyalAidFactionHostile".Translate(faction.Named("FACTION"));
				return true;
			}
			if (map.generatorDef.isUnderground)
			{
				reason = (string)"CommandCallRoyalAidMapUnreachable".Translate(faction.Named("FACTION"));
				return true;
			}
			if (pawn.MapHeld.mapTemperature.SeasonalTemp > 45f)
			{
				reason = (string)"SLP_TemperateTooHigh".Translate();
				return true;
			}
			reason = (string)null;
			return false;
		}

		private void SLPCallAplineRanger (Pawn pawn, Map map, Faction faction, bool free)
		{
			if (faction.HostileTo(Faction.OfPlayer))
			{
				return;
			}
			QuestScriptDef Permit_SLP_CallAlpineRangers = QuestScriptDefOfSLP.Permit_SLP_CallAlpineRangers;
			Slate slate = new Slate();
			slate.Set<Map>("map", map, false);
			slate.Set<int>("laborersCount", this.def.royalAid.pawnCount, false);
			slate.Set<Faction>("permitFaction", faction, false);
			slate.Set<PawnKindDef>("laborersPawnKind", this.def.royalAid.pawnKindDef, false);
			slate.Set<float>("laborersDurationDays", this.def.royalAid.aidDurationDays, false);
			QuestUtility.GenerateQuestAndMakeAvailable(Permit_SLP_CallAlpineRangers, slate);
			pawn.royalty.GetPermit(this.def, faction).Notify_Used();
			if (!free)
			{
				pawn.royalty.TryRemoveFavor(faction, this.def.royalAid.favorCost);
			}
		}
	}

	public class RoyalTitlePermitWorker_SLP_CallDesertRangers : RoyalTitlePermitWorker
	{
		public override IEnumerable<FloatMenuOption> GetRoyalAidOptions(Map map, Pawn pawn, Faction faction)
		{
			RoyalTitlePermitWorker_SLP_CallDesertRangers workerCallDesertRangers = this;
			string reason;
			if (workerCallDesertRangers.SLP_AidDisabled(map, pawn, faction, out reason))
			{
				yield return new FloatMenuOption((string)(workerCallDesertRangers.def.LabelCap + ": " + reason), (Action)null);
			}
			else
			{
				Action action = (Action)null;
				string description = (string)(workerCallDesertRangers.def.LabelCap + " (" + "CommandCallDesertNumDesert".Translate((NamedArgument)workerCallDesertRangers.def.royalAid.pawnCount) + "): ");
				bool free;
				if (workerCallDesertRangers.FillAidOption(pawn, faction, ref description, out free))
					action = (Action)(() => this.SLPCallDesertRanger(pawn, map, faction, free));
				yield return new FloatMenuOption(description, action, faction.def.FactionIcon, faction.Color);
			}
		}

		protected virtual bool SLP_AidDisabled(Map map, Pawn pawn, Faction faction, out string reason)
		{
			if (faction.HostileTo(Faction.OfPlayer))
			{
				reason = (string)"CommandCallRoyalAidFactionHostile".Translate(faction.Named("FACTION"));
				return true;
			}
			if (map.generatorDef.isUnderground)
			{
				reason = (string)"CommandCallRoyalAidMapUnreachable".Translate(faction.Named("FACTION"));
				return true;
			}
			if (pawn.MapHeld.mapTemperature.SeasonalTemp < -40f)
			{
				reason = (string)"SLP_TemperateTooLow".Translate();
				return true;
			}
			reason = (string)null;
			return false;
		}

		private void SLPCallDesertRanger(Pawn pawn, Map map, Faction faction, bool free)
		{
			if (faction.HostileTo(Faction.OfPlayer))
			{
				return;
			}
			QuestScriptDef Permit_SLP_CallDesertRangers = QuestScriptDefOfSLP.Permit_SLP_CallDesertRangers;
			Slate slate = new Slate();
			slate.Set<Map>("map", map, false);
			slate.Set<int>("laborersCount", this.def.royalAid.pawnCount, false);
			slate.Set<Faction>("permitFaction", faction, false);
			slate.Set<PawnKindDef>("laborersPawnKind", this.def.royalAid.pawnKindDef, false);
			slate.Set<float>("laborersDurationDays", this.def.royalAid.aidDurationDays, false);
			QuestUtility.GenerateQuestAndMakeAvailable(Permit_SLP_CallDesertRangers, slate);
			pawn.royalty.GetPermit(this.def, faction).Notify_Used();
			if (!free)
			{
				pawn.royalty.TryRemoveFavor(faction, this.def.royalAid.favorCost);
			}
		}
	}

	[StaticConstructorOnStartup]
	public class SLP_RoyalTitlePermitWorker_DropResourcesStuff : RoyalTitlePermitWorker_Targeted
	{
		private Faction faction;

		private static readonly Texture2D CommandTex = ContentFinder<Texture2D>.Get("UI/Commands/CallAid");

		public override void OrderForceTarget(LocalTargetInfo target)
		{
			CallResources(target.Cell);
		}

		public override IEnumerable<FloatMenuOption> GetRoyalAidOptions(Map map, Pawn pawn, Faction faction)
		{
			if (map.generatorDef.isUnderground)
			{
				yield return new FloatMenuOption(def.LabelCap + ": " + "CommandCallRoyalAidMapUnreachable".Translate(faction.Named("FACTION")), null);
				yield break;
			}
			if (faction.HostileTo(Faction.OfPlayer))
			{
				yield return new FloatMenuOption("CommandCallRoyalAidFactionHostile".Translate(faction.Named("FACTION")), null);
				yield break;
			}
			Action action = null;
			string description = def.LabelCap + ": ";
			if (FillAidOption(pawn, faction, ref description, out var free))
			{
				action = delegate
				{
					BeginCallResources(pawn, faction, map, free);
				};
			}
			yield return new FloatMenuOption(description, action, faction.def.FactionIcon, faction.Color);
		}

		public override IEnumerable<Gizmo> GetCaravanGizmos(Pawn pawn, Faction faction)
		{
			if (!FillCaravanAidOption(pawn, faction, out var description, out free, out var disableNotEnoughFavor))
			{
				yield break;
			}
			Command_Action command_Action = new Command_Action
			{
				defaultLabel = def.LabelCap + " (" + pawn.LabelShort + ")",
				defaultDesc = description,
				icon = CommandTex,
				action = delegate
				{
					Caravan caravan = pawn.GetCaravan();
					float num = caravan.MassUsage;
					List<ThingDefCountClass> itemsToDrop = def.royalAid.itemsToDrop;
					for (int i = 0; i < itemsToDrop.Count; i++)
					{
						num += itemsToDrop[i].thingDef.BaseMass * (float)itemsToDrop[i].count;
					}
					if (num > caravan.MassCapacity)
					{
						Find.WindowStack.Add(Dialog_MessageBox.CreateConfirmation("DropResourcesOverweightConfirm".Translate(), delegate
						{
							CallResourcesToCaravan(pawn, faction, free);
						}, destructive: true));
					}
					else
					{
						CallResourcesToCaravan(pawn, faction, free);
					}
				}
			};
			if (pawn.MapHeld != null && pawn.MapHeld.generatorDef.isUnderground)
			{
				command_Action.Disable("CommandCallRoyalAidMapUnreachable".Translate(faction.Named("FACTION")));
			}
			if (faction.HostileTo(Faction.OfPlayer))
			{
				command_Action.Disable("CommandCallRoyalAidFactionHostile".Translate(faction.Named("FACTION")));
			}
			if (disableNotEnoughFavor)
			{
				command_Action.Disable("CommandCallRoyalAidNotEnoughFavor".Translate());
			}
			yield return command_Action;
		}

		private void BeginCallResources(Pawn caller, Faction faction, Map map, bool free)
		{
			targetingParameters = new TargetingParameters();
			targetingParameters.canTargetLocations = true;
			targetingParameters.canTargetBuildings = false;
			targetingParameters.canTargetPawns = false;
			base.caller = caller;
			base.map = map;
			this.faction = faction;
			base.free = free;
			targetingParameters.validator = delegate (TargetInfo target)
			{
				if (def.royalAid.targetingRange > 0f && target.Cell.DistanceTo(caller.Position) > def.royalAid.targetingRange)
				{
					return false;
				}
				if (target.Cell.Fogged(map))
				{
					return false;
				}
				return DropCellFinder.CanPhysicallyDropInto(target.Cell, map, canRoofPunch: true) ? true : false;
			};
			Find.Targeter.BeginTargeting(this);
		}

		private void CallResources(IntVec3 cell)
		{
			List<Thing> list = new List<Thing>();
			for (int i = 0; i < def.royalAid.itemsToDrop.Count; i++)
			{
				ThingDef stuff = ThingDefOf.Cloth;
				Thing thing = ThingMaker.MakeThing(def.royalAid.itemsToDrop[i].thingDef, stuff);
				thing.stackCount = def.royalAid.itemsToDrop[i].count;
				list.Add(thing);
			}
			if (list.Any())
			{
				ActiveTransporterInfo activeTransporterInfo = new ActiveTransporterInfo();
				activeTransporterInfo.innerContainer.TryAddRangeOrTransfer(list);
				DropPodUtility.MakeDropPodAt(cell, map, activeTransporterInfo);
				Messages.Message("MessagePermitTransportDrop".Translate(faction.Named("FACTION")), new LookTargets(cell, map), MessageTypeDefOf.NeutralEvent);
				caller.royalty.GetPermit(def, faction).Notify_Used();
				if (!free)
				{
					caller.royalty.TryRemoveFavor(faction, def.royalAid.favorCost);
				}
			}
		}

		private void CallResourcesToCaravan(Pawn caller, Faction faction, bool free)
		{
			Caravan caravan = caller.GetCaravan();
			for (int i = 0; i < def.royalAid.itemsToDrop.Count; i++)
			{
				ThingDef stuff = ThingDefOf.Cloth;
				Thing thing = ThingMaker.MakeThing(def.royalAid.itemsToDrop[i].thingDef, stuff);
				thing.stackCount = def.royalAid.itemsToDrop[i].count;
				CaravanInventoryUtility.GiveThing(caravan, thing);
			}
			Messages.Message("MessagePermitTransportDropCaravan".Translate(faction.Named("FACTION"), caller.Named("PAWN")), caravan, MessageTypeDefOf.NeutralEvent);
			caller.royalty.GetPermit(def, faction).Notify_Used();
			if (!free)
			{
				caller.royalty.TryRemoveFavor(faction, def.royalAid.favorCost);
			}
		}
	}

	[DefOf]
	public static class QuestScriptDefOfSLP
	{
		public static QuestScriptDef Permit_SLP_CallTroopers;
		public static QuestScriptDef Permit_SLP_CallJanissary;
		public static QuestScriptDef Permit_SLP_CallCataphract;
		public static QuestScriptDef Permit_SLP_CallStellicGuardMelee;
		public static QuestScriptDef Permit_SLP_CallStellicGuardRanged;
		public static QuestScriptDef Permit_SLP_CallChampions;
		public static QuestScriptDef Permit_SLP_CallParamedics;
		public static QuestScriptDef Permit_SLP_CallCombatParamedics;
		public static QuestScriptDef Permit_SLP_CallSurgeons;
		public static QuestScriptDef Permit_SLP_CallAlpineRangers;
		public static QuestScriptDef Permit_SLP_CallDesertRangers;
	}
}


