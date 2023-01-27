namespace exercise.Repository
{
    public class ArgsPassers
    {
        string[] args;
        public string FilePath { get; }
        public int Position { get; }
        public string SearchKey { get; }
        public ArgsPassers(string[] args)
        {
            this.args = args;
            FilePath = args[0];
            Position = checkPosition(args[1]);
            SearchKey = args[2];
        }
        public int checkPosition(string position)
        {
            try
            {
                int newPosition = 0;
                var isNumeric = int.TryParse(position, out newPosition);
                if (!isNumeric)
                {
                    throw new Exception("\nThe Column index must be number but the value entered is :" + position);
                }
                else
                {
                    if (newPosition < 0)
                    {
                        throw new Exception("\n The Column index must be Greater than 0 or equal to the value entered is :" + position);
                    }
                    else { return newPosition; }

                }

            }
            catch (Exception ex)
            {
                throw new Exception("CheckParam|checkPosition() " + ex.Message);
            }
        }
    }
}