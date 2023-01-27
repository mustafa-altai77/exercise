using exercise.Repository;

if (args.Length != 3)
{
    Console.WriteLine("\nThe Length it Must Contain Three Arguments ! The Argument Entred is : " + args.Length + "\nFirstly: File Name\tSecondly: Position\tLastly : Search Key");
    return;
}
try
{
    ArgsPassers argsPassers = new ArgsPassers(args);
    WorkFile workFile = new WorkFile(argsPassers.FilePath);
    HelperFun.printRows(workFile.search(argsPassers.Position, argsPassers.SearchKey));
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

