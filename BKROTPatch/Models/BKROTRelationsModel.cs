using BannerKings;
using BannerKings.Behaviours.Relations;
using BannerKings.Managers.Institutions.Religions;
using BannerKings.Models.BKModels;
using BKROTPatch.Divinities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.CharacterDevelopment;

namespace BKROTPatch.Models
{
    internal class BKROTRelationsModel : BKRelationsModel
    {
        public override List<RelationsModifier> CalculateModifiers(HeroRelations heroRelations, Hero target)
        {
            List<RelationsModifier> list = base.CalculateModifiers(heroRelations, target);
            Hero sourceHero = heroRelations.Hero;
            Religion rel = BannerKingsConfig.Instance.ReligionsManager.GetHeroReligion(sourceHero);
            if (target.Age >= 50 && BannerKingsConfig.Instance.ReligionsManager.HasBlessing(sourceHero, ROTDivinities.Instance.TheWarrior, rel))
            {
                list.Add(new RelationsModifier(10, ROTDivinities.Instance.TheCrone.Name));
            }
            if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(sourceHero, ROTDivinities.Instance.Rhllor, rel) && rel == BannerKingsConfig.Instance.ReligionsManager.GetHeroReligion(target))
            {
                list.Add(new RelationsModifier(20, ROTDivinities.Instance.Rhllor.Name));
            }
            if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(sourceHero, ROTDivinities.Instance.BeardedGod, rel) && rel == BannerKingsConfig.Instance.ReligionsManager.GetHeroReligion(target))
            {
                list.Add(new RelationsModifier(20, ROTDivinities.Instance.BeardedGod.Name));
            }
            if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(sourceHero, ROTDivinities.Instance.WeepingLady, rel) && target.IsRuralNotable)
            {
                list.Add(new RelationsModifier(20, ROTDivinities.Instance.WeepingLady.Name));
            }
            if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(sourceHero, ROTDivinities.Instance.GodsLove, rel) && target.IsNotable)
            {
                list.Add(new RelationsModifier(20, ROTDivinities.Instance.GodsLove.Name));
            }
            return list;
        }
    }
}
