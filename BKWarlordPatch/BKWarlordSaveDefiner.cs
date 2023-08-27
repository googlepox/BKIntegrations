using BKWarlordPatch.Books;
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
    }
}
