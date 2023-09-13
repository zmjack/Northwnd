namespace Northwnd.Package
{
    public static class Setting
    {
        public static RuntimePlatform RuntimePlatform;

        public static void UseDefault()
        {
            RuntimePlatform = RuntimePlatform.Default;
        }

        public static void UseDotNetFiddle()
        {
            RuntimePlatform = RuntimePlatform.DotNetFiddle;
        }
    }
}
