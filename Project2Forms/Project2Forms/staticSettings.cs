namespace Project2Forms
{
    public class staticInfo
    {
        public static readonly string dbdir = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
        public static readonly string dbfile = "project2.db";

        public static string database()
        {
            return ($"{dbdir}/{dbfile}");
        }
    }
}