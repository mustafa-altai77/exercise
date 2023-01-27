using Microsoft.VisualBasic.FileIO;

namespace exercise.Repository
{
    public class WorkFile : IWorkFile
    {
        TextFieldParser csvParser { get; set; }

        public WorkFile(string filePath)
        {

            if (HelperFun.isExistFile(filePath))
                csvParser = new TextFieldParser(filePath);
            else
                throw new Exception("WorkFile|Initialize Object  " + "\n fileName is Not Exsists" + filePath);
        }
        public List<string> search(int position, string searchKey)
        {
            var Rows = new List<string>();
            try
            {
                csvParser.SetDelimiters(new string[] { "," });
                while (!csvParser.EndOfData)
                {
                    // Read current line fields, pointer moves to the next line.
                    string[] fields = csvParser.ReadFields();
                    if (string.Equals(fields[position], searchKey, StringComparison.OrdinalIgnoreCase))
                    {
                        Rows.Add(string.Join(",", fields));
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("WorkFile|search() " + ex.Message + "  \n for position is : " + position + "  searchKey  is : " + searchKey);
            }
            return Rows;
        }
    }
}