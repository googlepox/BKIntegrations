using BannerKings.Managers.Education.Books;
using BannerKings.Managers.Education.Languages;
using BKWarlordPatch.Books;
using System.Collections.Generic;
using TaleWorlds.SaveSystem;

namespace BKEducationPatch
{
    internal class BKWarlordSaveDefiner : SaveableTypeDefiner
    {
        public BKWarlordSaveDefiner() : base(7626594)
        {
        }

        protected override void DefineClassTypes()
        {
            AddClassDefinition(typeof(DefaultBookTypesWarlord), 1);
        }

        protected override void DefineContainerDefinitions()
        {
            ConstructContainerDefinition(typeof(Dictionary<BookType, Language>));
        }
    }
}
