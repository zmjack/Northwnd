namespace Northwnd
{
    public partial class NorthwndMemoryContext
    {
        public Region[] InitRegions()
        {
            return new[]
            {
                new Region
                {
                    RegionID = 1,
                    RegionDescription = "Eastern",
                },
                new Region
                {
                    RegionID = 2,
                    RegionDescription = "Western",
                },
                new Region
                {
                    RegionID = 3,
                    RegionDescription = "Northern",
                },
                new Region
                {
                    RegionID = 4,
                    RegionDescription = "Southern",
                },
            };

        }
    }
}
