namespace exercise.Repository
{
    public class HelperFun
    {
        public static void printRows(List<string> row)
        {
            Console.WriteLine(row.Count > 0 ? string.Join(",", row) : "Search Key is not Match with Any Value ");
        }

        public static Boolean isExistFile(string filePath)
        {
            try
            {

                if (File.Exists(filePath))
                    return true;

            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return false;
        }


    }
}