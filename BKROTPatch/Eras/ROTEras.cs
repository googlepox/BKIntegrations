using BannerKings;
using BannerKings.Managers.Education.Languages;
using BannerKings.Managers.Innovations.Eras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaleWorlds.CampaignSystem;
using TaleWorlds.Core;
using TaleWorlds.Library;
using TaleWorlds.Localization;
using TaleWorlds.ObjectSystem;

namespace BKROTPatch.Eras
{
    public class ROTEras : DefaultTypeInitializer<ROTEras, Era>
    {
        public Era FourthEra { get; } = new Era("FourthEra");

        public override IEnumerable<Era> All
        {
            get
            {
                yield return this.FourthEra;
            }
        }

        public override void Initialize()
        {
            this.FourthEra.Initialize(
                new TextObject("High Steel Age"),
                new TextObject("The High Steel Age"),
                DefaultEras.Instance.ThirdEra);

            foreach (Era era in All)
            {
                DefaultTypeInitializer<DefaultEras, Era>.Instance.AddObject(era);
            }
        }
    }
}
