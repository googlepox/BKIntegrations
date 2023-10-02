using BannerKings.Managers.Education.Books;
using BannerKings.Managers.Education.Languages;
using BKEducationPatch.Books;
using System.Collections.Generic;
using TaleWorlds.SaveSystem;

namespace BKEducationPatch
{
    internal class BKEducationSaveDefiner : SaveableTypeDefiner
    {
        public BKEducationSaveDefiner() : base(7627494)
        {
        }

        protected override void DefineClassTypes()
        {
            AddClassDefinition(typeof(DefaultBookTypesAddOn), 1);
        }

        protected override void DefineContainerDefinitions()
        {
            ConstructContainerDefinition(typeof(Dictionary<BookType, Language>));
        }
    }
}
