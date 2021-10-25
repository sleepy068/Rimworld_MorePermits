using System;
using System.Collections.Generic;
using RimWorld;
using RimWorld.QuestGen;
using Verse;

namespace RimworldSLP_MorePermits
{
	public class RoyalTitlePermitWorker_SLP_CallTroopers : RoyalTitlePermitWorker
	{
		public override IEnumerable<FloatMenuOption> GetRoyalAidOptions(Map map, Pawn pawn, Faction faction)
		{
			string t;
			if (this.AidDisabled(map, pawn, faction, out t))
			{
				yield return new FloatMenuOption(this.def.LabelCap + ": " + t, null, MenuOptionPriority.Default, null, null, 0f, null, null, true, 0);
				yield break;
			}
			Action action = null;
			string label = this.def.LabelCap + " (" + "CommandCallTroopersNumTroopers".Translate(this.def.royalAid.pawnCount) + "): ";
			bool free;
			if (base.FillAidOption(pawn, faction, ref label, out free))
			{
				action = delegate ()
				{
					this.SLPCallTroopers(pawn, map, faction, free);
				};
			}
			yield return new FloatMenuOption(label, action, faction.def.FactionIcon, faction.Color, MenuOptionPriority.Default, null, null, 0f, null, null, true, 0);
			yield break;
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
			string t;
			if (this.AidDisabled(map, pawn, faction, out t))
			{
				yield return new FloatMenuOption(this.def.LabelCap + ": " + t, null, MenuOptionPriority.Default, null, null, 0f, null, null, true, 0);
				yield break;
			}
			Action action = null;
			string label = this.def.LabelCap + " (" + "CommandCallJanissariesNumJanissaries".Translate(this.def.royalAid.pawnCount) + "): ";
			bool free;
			if (base.FillAidOption(pawn, faction, ref label, out free))
			{
				action = delegate ()
				{
					this.SLPCallJanissary(pawn, map, faction, free);
				};
			}
			yield return new FloatMenuOption(label, action, faction.def.FactionIcon, faction.Color, MenuOptionPriority.Default, null, null, 0f, null, null, true, 0);
			yield break;
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
			string t;
			if (this.AidDisabled(map, pawn, faction, out t))
			{
				yield return new FloatMenuOption(this.def.LabelCap + ": " + t, null, MenuOptionPriority.Default, null, null, 0f, null, null, true, 0);
				yield break;
			}
			Action action = null;
			string label = this.def.LabelCap + " (" + "CommandCallCataphractsNumCataphracts".Translate(this.def.royalAid.pawnCount) + "): ";
			bool free;
			if (base.FillAidOption(pawn, faction, ref label, out free))
			{
				action = delegate ()
				{
					this.SLPCallCataphract(pawn, map, faction, free);
				};
			}
			yield return new FloatMenuOption(label, action, faction.def.FactionIcon, faction.Color, MenuOptionPriority.Default, null, null, 0f, null, null, true, 0);
			yield break;
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

	[DefOf]
	public static class QuestScriptDefOfSLP
	{
		public static QuestScriptDef Permit_SLP_CallTroopers;
		public static QuestScriptDef Permit_SLP_CallJanissary;
		public static QuestScriptDef Permit_SLP_CallCataphract;

	}
}


