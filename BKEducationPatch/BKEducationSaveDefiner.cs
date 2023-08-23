using BKEducationPatch.Books;
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
    }
}
