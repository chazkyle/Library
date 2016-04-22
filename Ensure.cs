namespace chaz.Core
{
    public static class Ensure
    {
        public static T NullSafe<T>(T actual, T safe) where T : class
        {
            return actual ?? safe;
        }
    }
}
