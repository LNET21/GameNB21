using Game.Core.Entities.Creatures;

namespace Game.Core.Entities.Items
{
    interface IUsable
    {
        void Use(Creature creature);
    }
}