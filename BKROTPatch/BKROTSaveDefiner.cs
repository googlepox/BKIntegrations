using BKROTPatch.Faiths;
using BKROTPatch.Faiths.BKROTPatch.Faiths;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaleWorlds.SaveSystem;

namespace BKROTPatch
{
    internal class BKROTSaveDefiner : SaveableTypeDefiner
    {
        // Token: 0x06000005 RID: 5 RVA: 0x0000208A File Offset: 0x0000028A
        public BKROTSaveDefiner()
            : base(84926291)
        {
        }

        // Token: 0x06000006 RID: 6 RVA: 0x0000209C File Offset: 0x0000029C
        protected override void DefineClassTypes()
        {
            base.AddClassDefinition(typeof(SevenFaith), 1, null);
            base.AddClassDefinition(typeof(OldGodsFaith), 2, null);
            base.AddClassDefinition(typeof(BeardedGodFaith), 3, null);
            base.AddClassDefinition(typeof(BlackGoatFaith), 4, null);
            base.AddClassDefinition(typeof(BoashFaith), 5, null);
            base.AddClassDefinition(typeof(DrownedGodFaith), 6, null);
            base.AddClassDefinition(typeof(FourteenFlamesFaith), 7, null);
            base.AddClassDefinition(typeof(GoldenGardensFaith), 8, null);
            base.AddClassDefinition(typeof(GreatStallionFaith), 9, null);
            base.AddClassDefinition(typeof(HarpyFaith), 10, null);
            base.AddClassDefinition(typeof(HeritoryFaith), 11, null);
            base.AddClassDefinition(typeof(HuesOfTriosFaith), 12, null);
            base.AddClassDefinition(typeof(JosimakazmaFaith), 13, null);
            base.AddClassDefinition(typeof(ManyFacedGodFaith), 14, null);
            base.AddClassDefinition(typeof(MotherRhoyneFaith), 15, null);
            base.AddClassDefinition(typeof(PatternFaith), 16, null);
            base.AddClassDefinition(typeof(PearlDivinitiesFaith), 17, null);
            base.AddClassDefinition(typeof(PrincesMerciesFaith), 18, null);
            base.AddClassDefinition(typeof(RhllorFaith), 19, null);
            base.AddClassDefinition(typeof(SummerFaith), 20, null);
            base.AddClassDefinition(typeof(VhugyaharFaith), 21, null);
            base.AddClassDefinition(typeof(YiTiFaith), 22, null);
        }

        // Token: 0x06000007 RID: 7 RVA: 0x0000220A File Offset: 0x0000040A
        protected override void DefineContainerDefinitions()
        {
        }
    }
}
