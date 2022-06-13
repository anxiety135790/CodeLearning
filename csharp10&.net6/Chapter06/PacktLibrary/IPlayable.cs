

namespace Packt.Shared
{
    public interface IPlayable
    {
        void Play();
        void Pause();

        void Stop() //defautl interface implement
        {
            WriteLine("Default implement of stop.");
        }



    }

}
