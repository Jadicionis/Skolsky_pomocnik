using System;

namespace Skolsky_pomocnik
{
    public enum Theme
    {
        Light,
        Dark
    }

    public static class ThemeManager
    {
        public static Theme CurrentTheme { get; private set; } = Theme.Light;

        public static event Action ThemeChanged;

        public static void SetTheme(Theme theme)
        {
            if (CurrentTheme == theme)
                return;

            CurrentTheme = theme;
            ThemeChanged.Invoke();
        }
    }
}

