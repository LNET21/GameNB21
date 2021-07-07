namespace Game.Core.Services
{
    public interface IMapService
    {
        (int width, int height) GetMap();
    }
}