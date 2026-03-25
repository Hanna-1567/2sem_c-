using pr2._2._2;

namespace pr2_2
{
    class Program
    {
        static void Main()
        {
            var player = new Player(100);

            var ui = new UIHealthBar();
            var sound = new SoundSystem();
            var achievements = new AchievementSystem();
            var logger = new GameLogger();

            player.OnDamageTaken += ui.Update;
            player.OnDamageTaken += sound.PlaySound;
            player.OnDamageTaken += achievements.Check;
            player.OnDamageTaken += logger.Log;

            player.TakeDamage(20);
            player.TakeDamage(30);
            player.TakeDamage(40);
            player.TakeDamage(20);
        }
    }
}
