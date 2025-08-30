using BannerKings;
using BannerKings.Managers.Cultures;
using MCM.Abstractions.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaleWorlds.CampaignSystem;
using TaleWorlds.Localization;
using TaleWorlds.ObjectSystem;

namespace BKROTPatch.Titles
{
    internal class ROTTitleNames : DefaultTypeInitializer<ROTTitleNames, CulturalTitleName>
    {
        #region North
        public CulturalTitleName NorthEmperor { get; private set; }
        public CulturalTitleName NorthKing { get; private set; }
        public CulturalTitleName NorthDuke { get; private set; }
        public CulturalTitleName NorthCount { get; private set; }
        public CulturalTitleName NorthBaron { get; private set; }
        public CulturalTitleName NorthLord { get; private set; }
        public CulturalTitleName NorthPrince { get; private set; }
        public CulturalTitleName NorthKnight { get; private set; }
        #endregion North

        #region Vale
        public CulturalTitleName ValeEmperor { get; private set; }
        public CulturalTitleName ValeKing { get; private set; }
        public CulturalTitleName ValeDuke { get; private set; }
        public CulturalTitleName ValeCount { get; private set; }
        public CulturalTitleName ValeBaron { get; private set; }
        public CulturalTitleName ValeLord { get; private set; }
        public CulturalTitleName ValePrince { get; private set; }
        public CulturalTitleName ValeKnight { get; private set; }
        #endregion Vale

        #region River
        public CulturalTitleName RiverEmperor { get; private set; }
        public CulturalTitleName RiverKing { get; private set; }
        public CulturalTitleName RiverDuke { get; private set; }
        public CulturalTitleName RiverCount { get; private set; }
        public CulturalTitleName RiverBaron { get; private set; }
        public CulturalTitleName RiverLord { get; private set; }
        public CulturalTitleName RiverPrince { get; private set; }
        public CulturalTitleName RiverKnight { get; private set; }
        #endregion River

        #region Westerlands
        public CulturalTitleName WesterlandsEmperor { get; private set; }
        public CulturalTitleName WesterlandsKing { get; private set; }
        public CulturalTitleName WesterlandsDuke { get; private set; }
        public CulturalTitleName WesterlandsCount { get; private set; }
        public CulturalTitleName WesterlandsBaron { get; private set; }
        public CulturalTitleName WesterlandsLord { get; private set; }
        public CulturalTitleName WesterlandsPrince { get; private set; }
        public CulturalTitleName WesterlandsKnight { get; private set; }
        #endregion Westerlands

        #region Crown
        public CulturalTitleName CrownEmperor { get; private set; }
        public CulturalTitleName CrownKing { get; private set; }
        public CulturalTitleName CrownDuke { get; private set; }
        public CulturalTitleName CrownCount { get; private set; }
        public CulturalTitleName CrownBaron { get; private set; }
        public CulturalTitleName CrownLord { get; private set; }
        public CulturalTitleName CrownPrince { get; private set; }
        public CulturalTitleName CrownKnight { get; private set; }
        #endregion Crown

        #region Storm
        public CulturalTitleName StormEmperor { get; private set; }
        public CulturalTitleName StormKing { get; private set; }
        public CulturalTitleName StormDuke { get; private set; }
        public CulturalTitleName StormCount { get; private set; }
        public CulturalTitleName StormBaron { get; private set; }
        public CulturalTitleName StormLord { get; private set; }
        public CulturalTitleName StormPrince { get; private set; }
        public CulturalTitleName StormKnight { get; private set; }
        #endregion Storm

        #region Iron
        public CulturalTitleName IronEmperor { get; private set; }
        public CulturalTitleName IronKing { get; private set; }
        public CulturalTitleName IronDuke { get; private set; }
        public CulturalTitleName IronCount { get; private set; }
        public CulturalTitleName IronBaron { get; private set; }
        public CulturalTitleName IronLord { get; private set; }
        public CulturalTitleName IronPrince { get; private set; }
        public CulturalTitleName IronKnight { get; private set; }
        #endregion Iron

        #region NightsWatch
        public CulturalTitleName NightsWatchEmperor { get; private set; }
        public CulturalTitleName NightsWatchKing { get; private set; }
        public CulturalTitleName NightsWatchDuke { get; private set; }
        public CulturalTitleName NightsWatchCount { get; private set; }
        public CulturalTitleName NightsWatchBaron { get; private set; }
        public CulturalTitleName NightsWatchLord { get; private set; }
        public CulturalTitleName NightsWatchPrince { get; private set; }
        public CulturalTitleName NightsWatchKnight { get; private set; }
        #endregion NightsWatch

        #region Dragonstone
        public CulturalTitleName DragonstoneEmperor { get; private set; }
        public CulturalTitleName DragonstoneKing { get; private set; }
        public CulturalTitleName DragonstoneDuke { get; private set; }
        public CulturalTitleName DragonstoneCount { get; private set; }
        public CulturalTitleName DragonstoneBaron { get; private set; }
        public CulturalTitleName DragonstoneLord { get; private set; }
        public CulturalTitleName DragonstonePrince { get; private set; }
        public CulturalTitleName DragonstoneKnight { get; private set; }
        #endregion Dragonstone

        #region Reach
        public CulturalTitleName ReachEmperor { get; private set; }
        public CulturalTitleName ReachKing { get; private set; }
        public CulturalTitleName ReachDuke { get; private set; }
        public CulturalTitleName ReachCount { get; private set; }
        public CulturalTitleName ReachBaron { get; private set; }
        public CulturalTitleName ReachLord { get; private set; }
        public CulturalTitleName ReachPrince { get; private set; }
        public CulturalTitleName ReachKnight { get; private set; }
        #endregion Reach

        #region Dorne
        public CulturalTitleName DorneEmperor { get; private set; }
        public CulturalTitleName DorneKing { get; private set; }
        public CulturalTitleName DorneDuke { get; private set; }
        public CulturalTitleName DorneCount { get; private set; }
        public CulturalTitleName DorneBaron { get; private set; }
        public CulturalTitleName DorneLord { get; private set; }
        public CulturalTitleName DornePrince { get; private set; }
        public CulturalTitleName DorneKnight { get; private set; }
        #endregion Dorne

        #region Lorath
        public CulturalTitleName LorathEmperor { get; private set; }
        public CulturalTitleName LorathKing { get; private set; }
        public CulturalTitleName LorathDuke { get; private set; }
        public CulturalTitleName LorathCount { get; private set; }
        public CulturalTitleName LorathBaron { get; private set; }
        public CulturalTitleName LorathLord { get; private set; }
        public CulturalTitleName LorathPrince { get; private set; }
        public CulturalTitleName LorathKnight { get; private set; }
        #endregion Lorath

        #region Sarnor
        public CulturalTitleName SarnorEmperor { get; private set; }
        public CulturalTitleName SarnorKing { get; private set; }
        public CulturalTitleName SarnorDuke { get; private set; }
        public CulturalTitleName SarnorCount { get; private set; }
        public CulturalTitleName SarnorBaron { get; private set; }
        public CulturalTitleName SarnorLord { get; private set; }
        public CulturalTitleName SarnorPrince { get; private set; }
        public CulturalTitleName SarnorKnight { get; private set; }
        #endregion Sarnor

        #region Braavos
        public CulturalTitleName BraavosEmperor { get; private set; }
        public CulturalTitleName BraavosKing { get; private set; }
        public CulturalTitleName BraavosDuke { get; private set; }
        public CulturalTitleName BraavosCount { get; private set; }
        public CulturalTitleName BraavosBaron { get; private set; }
        public CulturalTitleName BraavosLord { get; private set; }
        public CulturalTitleName BraavosPrince { get; private set; }
        public CulturalTitleName BraavosKnight { get; private set; }
        #endregion Braavos

        #region Pentos
        public CulturalTitleName PentosEmperor { get; private set; }
        public CulturalTitleName PentosKing { get; private set; }
        public CulturalTitleName PentosDuke { get; private set; }
        public CulturalTitleName PentosCount { get; private set; }
        public CulturalTitleName PentosBaron { get; private set; }
        public CulturalTitleName PentosLord { get; private set; }
        public CulturalTitleName PentosPrince { get; private set; }
        public CulturalTitleName PentosKnight { get; private set; }
        #endregion Pentos

        #region Myr
        public CulturalTitleName MyrEmperor { get; private set; }
        public CulturalTitleName MyrKing { get; private set; }
        public CulturalTitleName MyrDuke { get; private set; }
        public CulturalTitleName MyrCount { get; private set; }
        public CulturalTitleName MyrBaron { get; private set; }
        public CulturalTitleName MyrLord { get; private set; }
        public CulturalTitleName MyrPrince { get; private set; }
        public CulturalTitleName MyrKnight { get; private set; }
        #endregion Myr

        #region Lys
        public CulturalTitleName LysEmperor { get; private set; }
        public CulturalTitleName LysKing { get; private set; }
        public CulturalTitleName LysDuke { get; private set; }
        public CulturalTitleName LysCount { get; private set; }
        public CulturalTitleName LysBaron { get; private set; }
        public CulturalTitleName LysLord { get; private set; }
        public CulturalTitleName LysPrince { get; private set; }
        public CulturalTitleName LysKnight { get; private set; }
        #endregion Lys

        #region Tyrosh
        public CulturalTitleName TyroshEmperor { get; private set; }
        public CulturalTitleName TyroshKing { get; private set; }
        public CulturalTitleName TyroshDuke { get; private set; }
        public CulturalTitleName TyroshCount { get; private set; }
        public CulturalTitleName TyroshBaron { get; private set; }
        public CulturalTitleName TyroshLord { get; private set; }
        public CulturalTitleName TyroshPrince { get; private set; }
        public CulturalTitleName TyroshKnight { get; private set; }
        #endregion Tyrosh

        #region Qohor
        public CulturalTitleName QohorEmperor { get; private set; }
        public CulturalTitleName QohorKing { get; private set; }
        public CulturalTitleName QohorDuke { get; private set; }
        public CulturalTitleName QohorCount { get; private set; }
        public CulturalTitleName QohorBaron { get; private set; }
        public CulturalTitleName QohorLord { get; private set; }
        public CulturalTitleName QohorPrince { get; private set; }
        public CulturalTitleName QohorKnight { get; private set; }
        #endregion Qohor

        #region Norvos
        public CulturalTitleName NorvosEmperor { get; private set; }
        public CulturalTitleName NorvosKing { get; private set; }
        public CulturalTitleName NorvosDuke { get; private set; }
        public CulturalTitleName NorvosCount { get; private set; }
        public CulturalTitleName NorvosBaron { get; private set; }
        public CulturalTitleName NorvosLord { get; private set; }
        public CulturalTitleName NorvosPrince { get; private set; }
        public CulturalTitleName NorvosKnight { get; private set; }
        #endregion Norvos

        #region Volantis
        public CulturalTitleName VolantisEmperor { get; private set; }
        public CulturalTitleName VolantisKing { get; private set; }
        public CulturalTitleName VolantisDuke { get; private set; }
        public CulturalTitleName VolantisCount { get; private set; }
        public CulturalTitleName VolantisBaron { get; private set; }
        public CulturalTitleName VolantisLord { get; private set; }
        public CulturalTitleName VolantisPrince { get; private set; }
        public CulturalTitleName VolantisKnight { get; private set; }
        #endregion Volantis

        #region Valyrian
        public CulturalTitleName ValyrianEmperor { get; private set; }
        public CulturalTitleName ValyrianKing { get; private set; }
        public CulturalTitleName ValyrianDuke { get; private set; }
        public CulturalTitleName ValyrianCount { get; private set; }
        public CulturalTitleName ValyrianBaron { get; private set; }
        public CulturalTitleName ValyrianLord { get; private set; }
        public CulturalTitleName ValyrianPrince { get; private set; }
        public CulturalTitleName ValyrianKnight { get; private set; }
        #endregion Valyrian

        #region Ghiscari
        public CulturalTitleName GhiscariEmperor { get; private set; }
        public CulturalTitleName GhiscariKing { get; private set; }
        public CulturalTitleName GhiscariDuke { get; private set; }
        public CulturalTitleName GhiscariCount { get; private set; }
        public CulturalTitleName GhiscariBaron { get; private set; }
        public CulturalTitleName GhiscariLord { get; private set; }
        public CulturalTitleName GhiscariPrince { get; private set; }
        public CulturalTitleName GhiscariKnight { get; private set; }
        #endregion Ghiscari

        #region YiTi
        public CulturalTitleName YiTiEmperor { get; private set; }
        public CulturalTitleName YiTiKing { get; private set; }
        public CulturalTitleName YiTiDuke { get; private set; }
        public CulturalTitleName YiTiCount { get; private set; }
        public CulturalTitleName YiTiBaron { get; private set; }
        public CulturalTitleName YiTiLord { get; private set; }
        public CulturalTitleName YiTiPrince { get; private set; }
        public CulturalTitleName YiTiKnight { get; private set; }
        #endregion Aserai

        #region Freefolk
        public CulturalTitleName FreefolkEmperor { get; private set; }
        public CulturalTitleName FreefolkKing { get; private set; }
        public CulturalTitleName FreefolkDuke { get; private set; }
        public CulturalTitleName FreefolkCount { get; private set; }
        public CulturalTitleName FreefolkBaron { get; private set; }
        public CulturalTitleName FreefolkLord { get; private set; }
        public CulturalTitleName FreefolkPrince { get; private set; }
        public CulturalTitleName FreefolkKnight { get; private set; }
        #endregion Freefolk

        #region Skagos
        public CulturalTitleName SkagosEmperor { get; private set; }
        public CulturalTitleName SkagosKing { get; private set; }
        public CulturalTitleName SkagosDuke { get; private set; }
        public CulturalTitleName SkagosCount { get; private set; }
        public CulturalTitleName SkagosBaron { get; private set; }
        public CulturalTitleName SkagosLord { get; private set; }
        public CulturalTitleName SkagosPrince { get; private set; }
        public CulturalTitleName SkagosKnight { get; private set; }
        #endregion Skagos

        #region Dothraki
        public CulturalTitleName DothrakiEmperor { get; private set; }
        public CulturalTitleName DothrakiKing { get; private set; }
        public CulturalTitleName DothrakiDuke { get; private set; }
        public CulturalTitleName DothrakiCount { get; private set; }
        public CulturalTitleName DothrakiBaron { get; private set; }
        public CulturalTitleName DothrakiLord { get; private set; }
        public CulturalTitleName DothrakiPrince { get; private set; }
        public CulturalTitleName DothrakiKnight { get; private set; }
        #endregion Dothraki

        #region Summer
        public CulturalTitleName SummerEmperor { get; private set; }
        public CulturalTitleName SummerKing { get; private set; }
        public CulturalTitleName SummerDuke { get; private set; }
        public CulturalTitleName SummerCount { get; private set; }
        public CulturalTitleName SummerBaron { get; private set; }
        public CulturalTitleName SummerLord { get; private set; }
        public CulturalTitleName SummerPrince { get; private set; }
        public CulturalTitleName SummerKnight { get; private set; }
        #endregion Summer
        public override IEnumerable<CulturalTitleName> All
        {
            get
            {
                yield return NorthEmperor;
                yield return NorthKing;
                yield return NorthDuke;
                yield return NorthCount;
                yield return NorthBaron;
                yield return NorthLord;
                yield return NorthPrince;
                yield return NorthKnight;

                yield return ValeEmperor;
                yield return ValeKing;
                yield return ValeDuke;
                yield return ValeCount;
                yield return ValeBaron;
                yield return ValeLord;
                yield return ValePrince;
                yield return ValeKnight;

                yield return RiverEmperor;
                yield return RiverKing;
                yield return RiverDuke;
                yield return RiverCount;
                yield return RiverBaron;
                yield return RiverLord;
                yield return RiverPrince;
                yield return RiverKnight;

                yield return WesterlandsEmperor;
                yield return WesterlandsKing;
                yield return WesterlandsDuke;
                yield return WesterlandsCount;
                yield return WesterlandsBaron;
                yield return WesterlandsLord;
                yield return WesterlandsPrince;
                yield return WesterlandsKnight;

                yield return CrownEmperor;
                yield return CrownKing;
                yield return CrownDuke;
                yield return CrownCount;
                yield return CrownBaron;
                yield return CrownLord;
                yield return CrownPrince;
                yield return CrownKnight;

                yield return StormEmperor;
                yield return StormKing;
                yield return StormDuke;
                yield return StormCount;
                yield return StormBaron;
                yield return StormLord;
                yield return StormPrince;
                yield return StormKnight;

                yield return IronEmperor;
                yield return IronKing;
                yield return IronDuke;
                yield return IronCount;
                yield return IronBaron;
                yield return IronLord;
                yield return IronPrince;
                yield return IronKnight;

                yield return NightsWatchEmperor;
                yield return NightsWatchKing;
                yield return NightsWatchDuke;
                yield return NightsWatchCount;
                yield return NightsWatchBaron;
                yield return NightsWatchLord;
                yield return NightsWatchPrince;
                yield return NightsWatchKnight;

                yield return DragonstoneEmperor;
                yield return DragonstoneKing;
                yield return DragonstoneDuke;
                yield return DragonstoneCount;
                yield return DragonstoneBaron;
                yield return DragonstoneLord;
                yield return DragonstonePrince;
                yield return DragonstoneKnight;

                yield return ReachEmperor;
                yield return ReachKing;
                yield return ReachDuke;
                yield return ReachCount;
                yield return ReachBaron;
                yield return ReachLord;
                yield return ReachPrince;
                yield return ReachKnight;

                yield return DorneEmperor;
                yield return DorneKing;
                yield return DorneDuke;
                yield return DorneCount;
                yield return DorneBaron;
                yield return DorneLord;
                yield return DornePrince;
                yield return DorneKnight;

                yield return LorathEmperor;
                yield return LorathKing;
                yield return LorathDuke;
                yield return LorathCount;
                yield return LorathBaron;
                yield return LorathLord;
                yield return LorathPrince;
                yield return LorathKnight;

                yield return NorvosEmperor;
                yield return NorvosKing;
                yield return NorvosDuke;
                yield return NorvosCount;
                yield return NorvosBaron;
                yield return NorvosLord;
                yield return NorvosPrince;
                yield return NorvosKnight;

                yield return QohorEmperor;
                yield return QohorKing;
                yield return QohorDuke;
                yield return QohorCount;
                yield return QohorBaron;
                yield return QohorLord;
                yield return QohorPrince;
                yield return QohorKnight;

                yield return BraavosEmperor;
                yield return BraavosKing;
                yield return BraavosDuke;
                yield return BraavosCount;
                yield return BraavosBaron;
                yield return BraavosLord;
                yield return BraavosPrince;
                yield return BraavosKnight;

                yield return PentosEmperor;
                yield return PentosKing;
                yield return PentosDuke;
                yield return PentosCount;
                yield return PentosBaron;
                yield return PentosLord;
                yield return PentosPrince;
                yield return PentosKnight;

                yield return TyroshEmperor;
                yield return TyroshKing;
                yield return TyroshDuke;
                yield return TyroshCount;
                yield return TyroshBaron;
                yield return TyroshLord;
                yield return TyroshPrince;
                yield return TyroshKnight;

                yield return LysEmperor;
                yield return LysKing;
                yield return LysDuke;
                yield return LysCount;
                yield return LysBaron;
                yield return LysLord;
                yield return LysPrince;
                yield return LysKnight;

                yield return MyrEmperor;
                yield return MyrKing;
                yield return MyrDuke;
                yield return MyrCount;
                yield return MyrBaron;
                yield return MyrLord;
                yield return MyrPrince;
                yield return MyrKnight;

                yield return VolantisEmperor;
                yield return VolantisKing;
                yield return VolantisDuke;
                yield return VolantisCount;
                yield return VolantisBaron;
                yield return VolantisLord;
                yield return VolantisPrince;
                yield return VolantisKnight;

                yield return ValyrianEmperor;
                yield return ValyrianKing;
                yield return ValyrianDuke;
                yield return ValyrianCount;
                yield return ValyrianBaron;
                yield return ValyrianLord;
                yield return ValyrianPrince;
                yield return ValyrianKnight;

                yield return GhiscariEmperor;
                yield return GhiscariKing;
                yield return GhiscariDuke;
                yield return GhiscariCount;
                yield return GhiscariBaron;
                yield return GhiscariLord;
                yield return GhiscariPrince;
                yield return GhiscariKnight;

                yield return DothrakiEmperor;
                yield return DothrakiKing;
                yield return DothrakiDuke;
                yield return DothrakiCount;
                yield return DothrakiBaron;
                yield return DothrakiLord;
                yield return DothrakiPrince;
                yield return DothrakiKnight;

                yield return YiTiEmperor;
                yield return YiTiKing;
                yield return YiTiDuke;
                yield return YiTiCount;
                yield return YiTiBaron;
                yield return YiTiLord;
                yield return YiTiPrince;
                yield return YiTiKnight;

                yield return FreefolkEmperor;
                yield return FreefolkKing;
                yield return FreefolkDuke;
                yield return FreefolkCount;
                yield return FreefolkBaron;
                yield return FreefolkLord;
                yield return FreefolkPrince;
                yield return FreefolkKnight;

                yield return SkagosEmperor;
                yield return SkagosKing;
                yield return SkagosDuke;
                yield return SkagosCount;
                yield return SkagosBaron;
                yield return SkagosLord;
                yield return SkagosPrince;
                yield return SkagosKnight;

                yield return SummerEmperor;
                yield return SummerKing;
                yield return SummerDuke;
                yield return SummerCount;
                yield return SummerBaron;
                yield return SummerLord;
                yield return SummerPrince;
                yield return SummerKnight;

            }
        }

        public override void Initialize()
        {
            var cultures = TaleWorlds.CampaignSystem.Campaign.Current.ObjectManager.GetObjectTypeList<CultureObject>();
            CultureObject valyrian = MBObjectManager.Instance.GetObject<CultureObject>("valyrian");
            CultureObject freefolk = MBObjectManager.Instance.GetObject<CultureObject>("freefolk");
            CultureObject nightswatch = MBObjectManager.Instance.GetObject<CultureObject>("nightswatch");
            CultureObject vale = MBObjectManager.Instance.GetObject<CultureObject>("vale");
            CultureObject river = MBObjectManager.Instance.GetObject<CultureObject>("river");
            CultureObject dragonstone = MBObjectManager.Instance.GetObject<CultureObject>("dragonstone");
            CultureObject stormlands = MBObjectManager.Instance.GetObject<CultureObject>("stormlands");
            CultureObject reach = MBObjectManager.Instance.GetObject<CultureObject>("reach");
            CultureObject ghiscari = MBObjectManager.Instance.GetObject<CultureObject>("ghiscari");
            CultureObject crownlands = MBObjectManager.Instance.GetObject<CultureObject>("crownlands");
            CultureObject braavosi = MBObjectManager.Instance.GetObject<CultureObject>("empire");
            CultureObject dorne = MBObjectManager.Instance.GetObject<CultureObject>("aserai");
            CultureObject ironIslands = MBObjectManager.Instance.GetObject<CultureObject>("sturgia");
            CultureObject north = MBObjectManager.Instance.GetObject<CultureObject>("battania");
            CultureObject westerlands = MBObjectManager.Instance.GetObject<CultureObject>("vlandia");
            CultureObject dothraki = MBObjectManager.Instance.GetObject<CultureObject>("khuzait");
            CultureObject sarnor = MBObjectManager.Instance.GetObject<CultureObject>("sarnor");
            CultureObject skagos = MBObjectManager.Instance.GetObject<CultureObject>("skagosi");
            CultureObject Myr = MBObjectManager.Instance.GetObject<CultureObject>("Myr");
            CultureObject volantine = MBObjectManager.Instance.GetObject<CultureObject>("volantine");
            CultureObject qohorik = MBObjectManager.Instance.GetObject<CultureObject>("qohorik");
            CultureObject lorathi = MBObjectManager.Instance.GetObject<CultureObject>("lorathi");
            CultureObject pentoshi = MBObjectManager.Instance.GetObject<CultureObject>("pentoshi");
            CultureObject myrish = MBObjectManager.Instance.GetObject<CultureObject>("myrish");
            CultureObject tyroshi = MBObjectManager.Instance.GetObject<CultureObject>("tyroshi");
            CultureObject lyseni = MBObjectManager.Instance.GetObject<CultureObject>("lyseni");
            CultureObject yiti = MBObjectManager.Instance.GetObject<CultureObject>("yiti");
            CultureObject summer = MBObjectManager.Instance.GetObject<CultureObject>("summer");

            #region North
            NorthEmperor = CulturalTitleName.CreateEmpire("NorthEmperor",
                north,
                new TextObject("{=emperor_North}Emperor"),
                new TextObject("{=empress_North}Empress"),
                new TextObject("{=North_North}Empire"));

            NorthKing = CulturalTitleName.CreateKingdom("NorthKing",
                north,
                new TextObject("{=king_North}King"),
                new TextObject("{=queen_North}Queen"),
                new TextObject("{=kingdom_North}Kingdom"));

            NorthDuke = CulturalTitleName.CreateDuchy("NorthDuke",
                north,
                new TextObject("{=duke_North}Lord Paramount"),
                new TextObject("{=duchess_North}Lady Paramount"),
                new TextObject("{=duchy_North}Lord Paramountcy"));

            NorthCount = CulturalTitleName.CreateCounty("NorthCount",
                north,
                new TextObject("{=count_North}High Lord"),
                new TextObject("{=countess_North}High Lady"),
                new TextObject("{=county_North}High Lordship"));

            NorthBaron = CulturalTitleName.CreateBarony("NorthBaron",
                north,
                new TextObject("{=baron_North}Lord"),
                new TextObject("{=baroness_North}Lady"),
                new TextObject("{=barony_North}Lordship"));

            NorthLord = CulturalTitleName.CreateLordship("NorthLord",
                north,
                new TextObject("{=lord_North}Banneret Lord"),
                new TextObject("{=lady_North}Banneret Lady"),
                new TextObject("{=lordship_North}Village"));

            NorthPrince = CulturalTitleName.CreatePrince("NorthPrince",
                north,
                new TextObject("{=prince_North}Prince"),
                new TextObject("{=princess_North}Prinncess"),
                new TextObject("{=princes_North}Princes"));

            NorthKnight = CulturalTitleName.CreateKnight("NorthKnight",
                north,
                new TextObject("{=knight_North}Knight"),
                new TextObject("{=knightess_North}Knight"),
                new TextObject("{=knights_North}Knights"));

            #endregion North

            #region Vale
            ValeEmperor = CulturalTitleName.CreateEmpire("ValeEmperor",
                vale,
                new TextObject("{=emperor_Vale}Emperor"),
                new TextObject("{=empress_Vale}Empress"),
                new TextObject("{=Vale_Vale}Empire"));

            ValeKing = CulturalTitleName.CreateKingdom("ValeKing",
                vale,
                new TextObject("{=king_Vale}King"),
                new TextObject("{=queen_Vale}Queen"),
                new TextObject("{=kingdom_Vale}Kingdom"));

            ValeDuke = CulturalTitleName.CreateDuchy("ValeDuke",
                vale,
                new TextObject("{=duke_Vale}Lord Paramount"),
                new TextObject("{=duchess_Vale}Lady Paramount"),
                new TextObject("{=duchy_Vale}Lord Paramountcy"));

            ValeCount = CulturalTitleName.CreateCounty("ValeCount",
                vale,
                new TextObject("{=count_Vale}High Lord"),
                new TextObject("{=countess_Vale}High Lady"),
                new TextObject("{=county_Vale}High Lordship"));

            ValeBaron = CulturalTitleName.CreateBarony("ValeBaron",
                vale,
                new TextObject("{=baron_Vale}Lord"),
                new TextObject("{=baroness_Vale}Lady"),
                new TextObject("{=barony_Vale}Lordship"));

            ValeLord = CulturalTitleName.CreateLordship("ValeLord",
                vale,
                new TextObject("{=lord_Vale}Banneret Lord"),
                new TextObject("{=lady_Vale}Banneret Lady"),
                new TextObject("{=lordship_Vale}Village"));

            ValePrince = CulturalTitleName.CreatePrince("ValePrince",
                vale,
                new TextObject("{=prince_Vale}Prince"),
                new TextObject("{=princess_Vale}Prinncess"),
                new TextObject("{=princes_Vale}Princes"));

            ValeKnight = CulturalTitleName.CreateKnight("ValeKnight",
                vale,
                new TextObject("{=knight_Vale}Knight"),
                new TextObject("{=knightess_Vale}Knight"),
                new TextObject("{=knights_Vale}Knights"));

            #endregion Vale

            #region Crown
            CrownEmperor = CulturalTitleName.CreateEmpire("CrownEmperor",
                crownlands,
                new TextObject("{=emperor_Crown}Emperor"),
                new TextObject("{=empress_Crown}Empress"),
                new TextObject("{=Crown_Crown}Empire"));

            CrownKing = CulturalTitleName.CreateKingdom("CrownKing",
                crownlands,
                new TextObject("{=king_Crown}King"),
                new TextObject("{=queen_Crown}Queen"),
                new TextObject("{=kingdom_Crown}Kingdom"));

            CrownDuke = CulturalTitleName.CreateDuchy("CrownDuke",
                crownlands,
                new TextObject("{=duke_Crown}Lord Paramount"),
                new TextObject("{=duchess_Crown}Lady Paramount"),
                new TextObject("{=duchy_Crown}Lord Paramountcy"));

            CrownCount = CulturalTitleName.CreateCounty("CrownCount",
                crownlands,
                new TextObject("{=count_Crown}High Lord"),
                new TextObject("{=countess_Crown}High Lady"),
                new TextObject("{=county_Crown}High Lordship"));

            CrownBaron = CulturalTitleName.CreateBarony("CrownBaron",
                crownlands,
                new TextObject("{=baron_Crown}Lord"),
                new TextObject("{=baroness_Crown}Lady"),
                new TextObject("{=barony_Crown}Lordship"));

            CrownLord = CulturalTitleName.CreateLordship("CrownLord",
                crownlands,
                new TextObject("{=lord_Crown}Banneret Lord"),
                new TextObject("{=lady_Crown}Banneret Lady"),
                new TextObject("{=lordship_Crown}Village"));

            CrownPrince = CulturalTitleName.CreatePrince("CrownPrince",
                crownlands,
                new TextObject("{=prince_Crown}Prince"),
                new TextObject("{=princess_Crown}Prinncess"),
                new TextObject("{=princes_Crown}Princes"));

            CrownKnight = CulturalTitleName.CreateKnight("CrownKnight",
                crownlands,
                new TextObject("{=knight_Crown}Knight"),
                new TextObject("{=knightess_Crown}Knight"),
                new TextObject("{=knights_Crown}Knights"));

            #endregion Crown

            #region River
            RiverEmperor = CulturalTitleName.CreateEmpire("RiverEmperor",
                river,
                new TextObject("{=emperor_River}Emperor"),
                new TextObject("{=empress_River}Empress"),
                new TextObject("{=River_River}Empire"));

            RiverKing = CulturalTitleName.CreateKingdom("RiverKing",
                river,
                new TextObject("{=king_River}King"),
                new TextObject("{=queen_River}Queen"),
                new TextObject("{=kingdom_River}Kingdom"));

            RiverDuke = CulturalTitleName.CreateDuchy("RiverDuke",
                river,
                new TextObject("{=duke_River}Lord Paramount"),
                new TextObject("{=duchess_River}Lady Paramount"),
                new TextObject("{=duchy_River}Lord Paramountcy"));

            RiverCount = CulturalTitleName.CreateCounty("RiverCount",
                river,
                new TextObject("{=count_River}High Lord"),
                new TextObject("{=countess_River}High Lady"),
                new TextObject("{=county_River}High Lordship"));

            RiverBaron = CulturalTitleName.CreateBarony("RiverBaron",
                river,
                new TextObject("{=baron_River}Lord"),
                new TextObject("{=baroness_River}Lady"),
                new TextObject("{=barony_River}Lordship"));

            RiverLord = CulturalTitleName.CreateLordship("RiverLord",
                river,
                new TextObject("{=lord_River}Banneret Lord"),
                new TextObject("{=lady_River}Banneret Lady"),
                new TextObject("{=lordship_River}Village"));

            RiverPrince = CulturalTitleName.CreatePrince("RiverPrince",
                river,
                new TextObject("{=prince_River}Prince"),
                new TextObject("{=princess_River}Prinncess"),
                new TextObject("{=princes_River}Princes"));

            RiverKnight = CulturalTitleName.CreateKnight("RiverKnight",
                river,
                new TextObject("{=knight_River}Knight"),
                new TextObject("{=knightess_River}Knight"),
                new TextObject("{=knights_River}Knights"));

            #endregion River

            #region Iron
            IronEmperor = CulturalTitleName.CreateEmpire("IronEmperor",
                ironIslands,
                new TextObject("{=emperor_Iron}Emperor"),
                new TextObject("{=empress_Iron}Empress"),
                new TextObject("{=Iron_Iron}Empire"));

            IronKing = CulturalTitleName.CreateKingdom("IronKing",
                ironIslands,
                new TextObject("{=king_Iron}King"),
                new TextObject("{=queen_Iron}Queen"),
                new TextObject("{=kingdom_Iron}Kingdom"));

            IronDuke = CulturalTitleName.CreateDuchy("IronDuke",
                ironIslands,
                new TextObject("{=duke_Iron}Lord Paramount"),
                new TextObject("{=duchess_Iron}Lady Paramount"),
                new TextObject("{=duchy_Iron}Lord Paramountcy"));

            IronCount = CulturalTitleName.CreateCounty("IronCount",
                ironIslands,
                new TextObject("{=count_Iron}High Lord"),
                new TextObject("{=countess_Iron}High Lady"),
                new TextObject("{=county_Iron}High Lordship"));

            IronBaron = CulturalTitleName.CreateBarony("IronBaron",
                ironIslands,
                new TextObject("{=baron_Iron}Lord"),
                new TextObject("{=baroness_Iron}Lady"),
                new TextObject("{=barony_Iron}Lordship"));

            IronLord = CulturalTitleName.CreateLordship("IronLord",
                ironIslands,
                new TextObject("{=lord_Iron}Banneret Lord"),
                new TextObject("{=lady_Iron}Banneret Lady"),
                new TextObject("{=lordship_Iron}Village"));

            IronPrince = CulturalTitleName.CreatePrince("IronPrince",
                ironIslands,
                new TextObject("{=prince_Iron}Prince"),
                new TextObject("{=princess_Iron}Prinncess"),
                new TextObject("{=princes_Iron}Princes"));

            IronKnight = CulturalTitleName.CreateKnight("IronKnight",
                ironIslands,
                new TextObject("{=knight_Iron}Knight"),
                new TextObject("{=knightess_Iron}Knight"),
                new TextObject("{=knights_Iron}Knights"));

            #endregion Iron

            #region Reach
            ReachEmperor = CulturalTitleName.CreateEmpire("ReachEmperor",
                reach,
                new TextObject("{=emperor_Reach}Emperor"),
                new TextObject("{=empress_Reach}Empress"),
                new TextObject("{=Reach_Reach}Empire"));

            ReachKing = CulturalTitleName.CreateKingdom("ReachKing",
                reach,
                new TextObject("{=king_Reach}King"),
                new TextObject("{=queen_Reach}Queen"),
                new TextObject("{=kingdom_Reach}Kingdom"));

            ReachDuke = CulturalTitleName.CreateDuchy("ReachDuke",
                reach,
                new TextObject("{=duke_Reach}Lord Paramount"),
                new TextObject("{=duchess_Reach}Lady Paramount"),
                new TextObject("{=duchy_Reach}Lord Paramountcy"));

            ReachCount = CulturalTitleName.CreateCounty("ReachCount",
                reach,
                new TextObject("{=count_Reach}High Lord"),
                new TextObject("{=countess_Reach}High Lady"),
                new TextObject("{=county_Reach}High Lordship"));

            ReachBaron = CulturalTitleName.CreateBarony("ReachBaron",
                reach,
                new TextObject("{=baron_Reach}Lord"),
                new TextObject("{=baroness_Reach}Lady"),
                new TextObject("{=barony_Reach}Lordship"));

            ReachLord = CulturalTitleName.CreateLordship("ReachLord",
                reach,
                new TextObject("{=lord_Reach}Banneret Lord"),
                new TextObject("{=lady_Reach}Banneret Lady"),
                new TextObject("{=lordship_Reach}Village"));

            ReachPrince = CulturalTitleName.CreatePrince("ReachPrince",
                reach,
                new TextObject("{=prince_Reach}Prince"),
                new TextObject("{=princess_Reach}Prinncess"),
                new TextObject("{=princes_Reach}Princes"));

            ReachKnight = CulturalTitleName.CreateKnight("ReachKnight",
                reach,
                new TextObject("{=knight_Reach}Knight"),
                new TextObject("{=knightess_Reach}Knight"),
                new TextObject("{=knights_Reach}Knights"));

            #endregion Reach

            #region Storm
            StormEmperor = CulturalTitleName.CreateEmpire("StormEmperor",
                stormlands,
                new TextObject("{=emperor_Storm}Emperor"),
                new TextObject("{=empress_Storm}Empress"),
                new TextObject("{=Storm_Storm}Empire"));

            StormKing = CulturalTitleName.CreateKingdom("StormKing",
                stormlands,
                new TextObject("{=king_Storm}King"),
                new TextObject("{=queen_Storm}Queen"),
                new TextObject("{=kingdom_Storm}Kingdom"));

            StormDuke = CulturalTitleName.CreateDuchy("StormDuke",
                stormlands,
                new TextObject("{=duke_Storm}Lord Paramount"),
                new TextObject("{=duchess_Storm}Lady Paramount"),
                new TextObject("{=duchy_Storm}Lord Paramountcy"));

            StormCount = CulturalTitleName.CreateCounty("StormCount",
                stormlands,
                new TextObject("{=count_Storm}High Lord"),
                new TextObject("{=countess_Storm}High Lady"),
                new TextObject("{=county_Storm}High Lordship"));

            StormBaron = CulturalTitleName.CreateBarony("StormBaron",
                stormlands,
                new TextObject("{=baron_Storm}Lord"),
                new TextObject("{=baroness_Storm}Lady"),
                new TextObject("{=barony_Storm}Lordship"));

            StormLord = CulturalTitleName.CreateLordship("StormLord",
                stormlands,
                new TextObject("{=lord_Storm}Banneret Lord"),
                new TextObject("{=lady_Storm}Banneret Lady"),
                new TextObject("{=lordship_Storm}Village"));

            StormPrince = CulturalTitleName.CreatePrince("StormPrince",
                stormlands,
                new TextObject("{=prince_Storm}Prince"),
                new TextObject("{=princess_Storm}Prinncess"),
                new TextObject("{=princes_Storm}Princes"));

            StormKnight = CulturalTitleName.CreateKnight("StormKnight",
                stormlands,
                new TextObject("{=knight_Storm}Knight"),
                new TextObject("{=knightess_Storm}Knight"),
                new TextObject("{=knights_Storm}Knights"));

            #endregion Storm

            #region Dragonstone
            DragonstoneEmperor = CulturalTitleName.CreateEmpire("DragonstoneEmperor",
                dragonstone,
                new TextObject("{=emperor_Dragonstone}Emperor"),
                new TextObject("{=empress_Dragonstone}Empress"),
                new TextObject("{=Dragonstone_Dragonstone}Empire"));

            DragonstoneKing = CulturalTitleName.CreateKingdom("DragonstoneKing",
                dragonstone,
                new TextObject("{=king_Dragonstone}King"),
                new TextObject("{=queen_Dragonstone}Queen"),
                new TextObject("{=kingdom_Dragonstone}Kingdom"));

            DragonstoneDuke = CulturalTitleName.CreateDuchy("DragonstoneDuke",
                dragonstone,
                new TextObject("{=duke_Dragonstone}Lord Paramount"),
                new TextObject("{=duchess_Dragonstone}Lady Paramount"),
                new TextObject("{=duchy_Dragonstone}Lord Paramountcy"));

            DragonstoneCount = CulturalTitleName.CreateCounty("DragonstoneCount",
                dragonstone,
                new TextObject("{=count_Dragonstone}High Lord"),
                new TextObject("{=countess_Dragonstone}High Lady"),
                new TextObject("{=county_Dragonstone}High Lordship"));

            DragonstoneBaron = CulturalTitleName.CreateBarony("DragonstoneBaron",
                dragonstone,
                new TextObject("{=baron_Dragonstone}Lord"),
                new TextObject("{=baroness_Dragonstone}Lady"),
                new TextObject("{=barony_Dragonstone}Lordship"));

            DragonstoneLord = CulturalTitleName.CreateLordship("DragonstoneLord",
                dragonstone,
                new TextObject("{=lord_Dragonstone}Banneret Lord"),
                new TextObject("{=lady_Dragonstone}Banneret Lady"),
                new TextObject("{=lordship_Dragonstone}Village"));

            DragonstonePrince = CulturalTitleName.CreatePrince("DragonstonePrince",
                dragonstone,
                new TextObject("{=prince_Dragonstone}Prince"),
                new TextObject("{=princess_Dragonstone}Prinncess"),
                new TextObject("{=princes_Dragonstone}Princes"));

            DragonstoneKnight = CulturalTitleName.CreateKnight("DragonstoneKnight",
                dragonstone,
                new TextObject("{=knight_Dragonstone}Knight"),
                new TextObject("{=knightess_Dragonstone}Knight"),
                new TextObject("{=knights_Dragonstone}Knights"));

            #endregion Dragonstone

            #region Dorne
            DorneEmperor = CulturalTitleName.CreateEmpire("DorneEmperor",
                dorne,
                new TextObject("{=emperor_Dorne}Emperor"),
                new TextObject("{=empress_Dorne}Empress"),
                new TextObject("{=Dorne_Dorne}Empire"));

            DorneKing = CulturalTitleName.CreateKingdom("DorneKing",
                dorne,
                new TextObject("{=king_Dorne}King"),
                new TextObject("{=queen_Dorne}Queen"),
                new TextObject("{=kingdom_Dorne}Kingdom"));

            DorneDuke = CulturalTitleName.CreateDuchy("DorneDuke",
                dorne,
                new TextObject("{=duke_Dorne}Lord Paramount"),
                new TextObject("{=duchess_Dorne}Lady Paramount"),
                new TextObject("{=duchy_Dorne}Lord Paramountcy"));

            DorneCount = CulturalTitleName.CreateCounty("DorneCount",
                dorne,
                new TextObject("{=count_Dorne}High Lord"),
                new TextObject("{=countess_Dorne}High Lady"),
                new TextObject("{=county_Dorne}High Lordship"));

            DorneBaron = CulturalTitleName.CreateBarony("DorneBaron",
                dorne,
                new TextObject("{=baron_Dorne}Lord"),
                new TextObject("{=baroness_Dorne}Lady"),
                new TextObject("{=barony_Dorne}Lordship"));

            DorneLord = CulturalTitleName.CreateLordship("DorneLord",
                dorne,
                new TextObject("{=lord_Dorne}Banneret Lord"),
                new TextObject("{=lady_Dorne}Banneret Lady"),
                new TextObject("{=lordship_Dorne}Village"));

            DornePrince = CulturalTitleName.CreatePrince("DornePrince",
                dorne,
                new TextObject("{=prince_Dorne}Prince"),
                new TextObject("{=princess_Dorne}Prinncess"),
                new TextObject("{=princes_Dorne}Princes"));

            DorneKnight = CulturalTitleName.CreateKnight("DorneKnight",
                dorne,
                new TextObject("{=knight_Dorne}Knight"),
                new TextObject("{=knightess_Dorne}Knight"),
                new TextObject("{=knights_Dorne}Knights"));

            #endregion Dorne

            #region Westerlands
            WesterlandsEmperor = CulturalTitleName.CreateEmpire("WesterlandsEmperor",
                westerlands,
                new TextObject("{=emperor_Westerlands}Emperor"),
                new TextObject("{=empress_Westerlands}Empress"),
                new TextObject("{=Westerlands_Westerlands}Empire"));

            WesterlandsKing = CulturalTitleName.CreateKingdom("WesterlandsKing",
                westerlands,
                new TextObject("{=king_Westerlands}King"),
                new TextObject("{=queen_Westerlands}Queen"),
                new TextObject("{=kingdom_Westerlands}Kingdom"));

            WesterlandsDuke = CulturalTitleName.CreateDuchy("WesterlandsDuke",
                westerlands,
                new TextObject("{=duke_Westerlands}Lord Paramount"),
                new TextObject("{=duchess_Westerlands}Lady Paramount"),
                new TextObject("{=duchy_Westerlands}Lord Paramountcy"));

            WesterlandsCount = CulturalTitleName.CreateCounty("WesterlandsCount",
                westerlands,
                new TextObject("{=count_Westerlands}High Lord"),
                new TextObject("{=countess_Westerlands}High Lady"),
                new TextObject("{=county_Westerlands}High Lordship"));

            WesterlandsBaron = CulturalTitleName.CreateBarony("WesterlandsBaron",
                westerlands,
                new TextObject("{=baron_Westerlands}Lord"),
                new TextObject("{=baroness_Westerlands}Lady"),
                new TextObject("{=barony_Westerlands}Lordship"));

            WesterlandsLord = CulturalTitleName.CreateLordship("WesterlandsLord",
                westerlands,
                new TextObject("{=lord_Westerlands}Banneret Lord"),
                new TextObject("{=lady_Westerlands}Banneret Lady"),
                new TextObject("{=lordship_Westerlands}Village"));

            WesterlandsPrince = CulturalTitleName.CreatePrince("WesterlandsPrince",
                westerlands,
                new TextObject("{=prince_Westerlands}Prince"),
                new TextObject("{=princess_Westerlands}Prinncess"),
                new TextObject("{=princes_Westerlands}Princes"));

            WesterlandsKnight = CulturalTitleName.CreateKnight("WesterlandsKnight",
                westerlands,
                new TextObject("{=knight_Westerlands}Knight"),
                new TextObject("{=knightess_Westerlands}Knight"),
                new TextObject("{=knights_Westerlands}Knights"));

            #endregion Westerlands

            #region NightsWatch
            NightsWatchEmperor = CulturalTitleName.CreateEmpire("NightsWatchEmperor",
                nightswatch,
                new TextObject("{=emperor_NightsWatch}Emperor"),
                new TextObject("{=empress_NightsWatch}Empress"),
                new TextObject("{=NightsWatch_NightsWatch}Empire"));

            NightsWatchKing = CulturalTitleName.CreateKingdom("NightsWatchKing",
                nightswatch,
                new TextObject("{=king_NightsWatch}Lord Commander"),
                new TextObject("{=queen_NightsWatch}Lord Commander"),
                new TextObject("{=kingdom_NightsWatch}Order"));

            NightsWatchDuke = CulturalTitleName.CreateDuchy("NightsWatchDuke",
                nightswatch,
                new TextObject("{=duke_NightsWatch}First Ranger"),
                new TextObject("{=duchess_NightsWatch}First Ranger"),
                new TextObject("{=duchy_NightsWatch}Fort"));

            NightsWatchCount = CulturalTitleName.CreateCounty("NightsWatchCount",
                nightswatch,
                new TextObject("{=count_NightsWatch}Lord Steward"),
                new TextObject("{=countess_NightsWatch}Lord Steward"),
                new TextObject("{=county_NightsWatch}Fort"));

            NightsWatchBaron = CulturalTitleName.CreateBarony("NightsWatchBaron",
                nightswatch,
                new TextObject("{=baron_NightsWatch}Commander"),
                new TextObject("{=baroness_NightsWatch}Commander"),
                new TextObject("{=barony_NightsWatch}Fort"));

            NightsWatchLord = CulturalTitleName.CreateLordship("NightsWatchLord",
                nightswatch,
                new TextObject("{=lord_NightsWatch}Lord"),
                new TextObject("{=lady_NightsWatch}Lady"),
                new TextObject("{=lordship_NightsWatch}Village"));

            NightsWatchPrince = CulturalTitleName.CreatePrince("NightsWatchPrince",
                nightswatch,
                new TextObject("{=prince_NightsWatch}Prince"),
                new TextObject("{=princess_NightsWatch}Prinncess"),
                new TextObject("{=princes_NightsWatch}Princes"));

            NightsWatchKnight = CulturalTitleName.CreateKnight("NightsWatchKnight",
                nightswatch,
                new TextObject("{=knight_NightsWatch}Knight"),
                new TextObject("{=knightess_NightsWatch}Knight"),
                new TextObject("{=knights_NightsWatch}Knights"));

            #endregion NightsWatch

            #region Dothraki
            DothrakiEmperor = CulturalTitleName.CreateEmpire("DothrakiEmperor",
                dothraki,
                new TextObject("{=emperor_Dothraki}Rhaeshisal"),
                new TextObject("{=empress_Dothraki}Rhaeshisaleesi"),
                new TextObject("{=Dothraki_Dothraki}Rhaeshisar"));

            DothrakiKing = CulturalTitleName.CreateKingdom("DothrakiKing",
                dothraki,
                new TextObject("{=king_Dothraki}Khal"),
                new TextObject("{=queen_Dothraki}Khaleesi"),
                new TextObject("{=kingdom_Dothraki}Khalasar"));

            DothrakiDuke = CulturalTitleName.CreateDuchy("DothrakiDuke",
                dothraki,
                new TextObject("{=duke_Dothraki}Vezhof Khal"),
                new TextObject("{=duchess_Dothraki}Vezhof Khaleesi"),
                new TextObject("{=duchy_Dothraki}Vezhof Khalasar"));

            DothrakiCount = CulturalTitleName.CreateCounty("DothrakiCount",
                dothraki,
                new TextObject("{=count_Dothraki}Rakh Jhatti"),
                new TextObject("{=countess_Dothraki}Rakh Jhatteesi"),
                new TextObject("{=county_Dothraki}Rakh Jhattar"));

            DothrakiBaron = CulturalTitleName.CreateBarony("DothrakiBaron",
                dothraki,
                new TextObject("{=baron_Dothraki}Vezhof Rakh"),
                new TextObject("{=baroness_Dothraki}Vezhof Rakheesi"),
                new TextObject("{=barony_Dothraki}Vezhof Rakhar"));

            DothrakiLord = CulturalTitleName.CreateLordship("DothrakiLord",
                dothraki,
                new TextObject("{=lord_Dothraki}Bloodrider"),
                new TextObject("{=lady_Dothraki}Bloodrider"),
                new TextObject("{=lordship_Dothraki}Village"));

            DothrakiPrince = CulturalTitleName.CreatePrince("DothrakiPrince",
                dothraki,
                new TextObject("{=prince_Dothraki}Prince"),
                new TextObject("{=princess_Dothraki}Prinncess"),
                new TextObject("{=princes_Dothraki}Princes"));

            DothrakiKnight = CulturalTitleName.CreateKnight("DothrakiKnight",
                dothraki,
                new TextObject("{=knight_Dothraki}Bloodrider"),
                new TextObject("{=knightess_Dothraki}Bloodrider"),
                new TextObject("{=knights_Dothraki}Bloodriders"));

            #endregion Dothraki


            foreach (CulturalTitleName name in All)
            {
                DefaultTitleNames.Instance.AddObject(name);
            }
        }
    }
}
